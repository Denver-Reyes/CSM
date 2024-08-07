Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class frmmain
    Dim conn As MySqlConnection = Nothing

    Private questions As New Dictionary(Of Integer, String)
    Private respondentType As String = ""

    Private Sub btnConfirmbuttonMain_Click(sender As Object, e As EventArgs) Handles btnConfirmbuttonMain.Click
        ' Center the respondent type selection GroupBox
        CenterGroupBox(gbUserTypeSelection)
        gbUserTypeSelection.Visible = True
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        respondentType = "Student"
        If ValidateSurvey() Then
            SubmitSurvey()
            gbUserTypeSelection.Visible = False
        End If
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        respondentType = "Faculty"
        If ValidateSurvey() Then
            SubmitSurvey()
            gbUserTypeSelection.Visible = False
        End If
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        respondentType = "Guest"
        If ValidateSurvey() Then
            SubmitSurvey()
            gbUserTypeSelection.Visible = False
        End If
    End Sub

    Private Function ValidateSurvey() As Boolean
        For Each control As Control In plQuestions.Controls
            If TypeOf control Is Guna2GroupBox Then
                Dim gbQuestion As Guna2GroupBox = CType(control, Guna2GroupBox)
                Dim isAnswered As Boolean = gbQuestion.Controls.OfType(Of Guna2CircleButton)().Any(Function(btn) btn.Checked)
                If Not isAnswered Then
                    MessageBox.Show("Please answer all the questions before submitting the survey.")
                    gbUserTypeSelection.Visible = False
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub SubmitSurvey()
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim query As String = "INSERT INTO tblresults (questionID, rating, respondentType, date_submitted) VALUES (@questionID, @rating, @respondentType, @date_submitted)"
        Dim cmd As New MySqlCommand(query, connection)

        Try
            connection.Open()
            For Each control As Control In plQuestions.Controls
                If TypeOf control Is Guna2GroupBox Then
                    Dim gbQuestion As Guna2GroupBox = CType(control, Guna2GroupBox)
                    Dim questionID As Integer = CInt(gbQuestion.Tag) ' Get questionID from the GroupBox Tag
                    For Each btn As Guna2CircleButton In gbQuestion.Controls.OfType(Of Guna2CircleButton)()
                        If btn.Checked Then
                            ' Use the Tag property of the button for rating value
                            Dim rating As Integer = CInt(btn.Tag) ' Assuming Tag holds the rating value
                            Dim dateSubmitted As DateTime = DateTime.Now

                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@questionID", questionID)
                            cmd.Parameters.AddWithValue("@rating", rating)
                            cmd.Parameters.AddWithValue("@respondentType", respondentType)
                            cmd.Parameters.AddWithValue("@date_submitted", dateSubmitted)
                            cmd.ExecuteNonQuery()
                        End If
                    Next
                End If
            Next
            MessageBox.Show("Survey submitted successfully!")

            ' Clear the panel and reset the form state
            plQuestions.Controls.Clear()
            respondentType = ""
            questions.Clear()

            ' Optionally, reset other controls or states
            gbUserTypeSelection.Visible = False

            Me.Close()
            Dim frmEntry As New frmEntry

            ' Clear the SelectedFacility property
            frmEntry.SelectedFacility = ""
            frmEntry.Show()

        Catch ex As Exception
            MessageBox.Show("Error submitting survey: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializePanel()
        LoadQuestionsIntoPanel()
    End Sub

    Private Sub InitializePanel()
        plQuestions.AutoScroll = True
    End Sub

    Public Sub LoadQuestionsIntoPanel()
        Dim facility As String = frmEntry.SelectedFacility
        If String.IsNullOrEmpty(facility) Then
            MessageBox.Show("No facility selected.")
            Return
        End If

        Dim conn As MySqlConnection = Common.getDBConnectionX()
        Dim cmd As New MySqlCommand("SELECT questionID, questionText FROM tblquestions WHERE facility = @facility AND status = 'active'", conn)
        cmd.Parameters.AddWithValue("@facility", facility)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        plQuestions.Controls.Clear() ' Clear existing controls
        Dim y As Integer = 10 ' Starting Y position for the first question
        Dim questionHeight As Integer = 100 ' Height of each question block to accommodate text

        For Each row As DataRow In dt.Rows
            Dim questionId As Integer = row("questionID")
            Dim questionText As String = row("questionText").ToString()

            ' Create a new group box for each question
            Dim gbQuestion As New Guna2GroupBox() With {
            .Text = questionText,
            .Size = New Size(plQuestions.ClientSize.Width - 20, questionHeight),
            .Location = New Point(10, y),
            .Tag = questionId ' Assign questionID to Tag
        }

            ' Add rating buttons to the group box from the template
            Dim buttonX As Integer = 10 ' X position for rating buttons
            Dim buttonY As Integer = 50 ' Y position for rating buttons, adjusted for more spacing from the question text
            Dim buttonTemplates As Guna2CircleButton() = {btnRate1Template, btnRate2Template, btnRate3Template, btnRate4Template, btnRate5Template}

            For Each templateBtn As Guna2CircleButton In buttonTemplates
                Dim btnRating As New Guna2CircleButton With {
                .Text = templateBtn.Text,
                .Size = templateBtn.Size,
                .Location = New Point(buttonX, buttonY),
                .Font = templateBtn.Font,
                .FillColor = templateBtn.FillColor,
                .ForeColor = templateBtn.ForeColor,
                .CheckedState = templateBtn.CheckedState,
                .Checked = templateBtn.Checked,
                .Tag = templateBtn.Tag, ' Use template button's Tag if needed
                .Image = templateBtn.Image,
                .ImageSize = templateBtn.ImageSize,
                .ImageAlign = templateBtn.ImageAlign,
                .ImageOffset = templateBtn.ImageOffset,
                .CustomBorderColor = templateBtn.CustomBorderColor,
                .CustomBorderThickness = templateBtn.CustomBorderThickness,
                .BorderThickness = templateBtn.BorderThickness,
                .BorderColor = templateBtn.BorderColor,
                .ButtonMode = templateBtn.ButtonMode ' Set ButtonMode to ToggleButton
            }
                AddHandler btnRating.Click, AddressOf RatingButton_Click ' Add event handler for click event
                gbQuestion.Controls.Add(btnRating)
                buttonX += btnRating.Width + 10 ' Adjust spacing between buttons
            Next

            plQuestions.Controls.Add(gbQuestion)
            y += questionHeight + 10 ' Move the Y position for the next question
        Next

        conn.Close()
    End Sub


    ' Click event handler for rating buttons
    Private Sub RatingButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Guna2CircleButton = CType(sender, Guna2CircleButton)
        Dim gbQuestion As Guna2GroupBox = CType(clickedButton.Parent, Guna2GroupBox)

        ' Uncheck all other buttons in the same group box
        For Each control As Control In gbQuestion.Controls
            If TypeOf control Is Guna2CircleButton AndAlso Not control.Equals(clickedButton) Then
                CType(control, Guna2CircleButton).Checked = False
            End If
        Next

        ' Set the clicked button to checked
        clickedButton.Checked = True
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim frmEntry As New frmEntry
        frmEntry.Show()
        Me.Hide()
    End Sub

    Private Sub CenterGroupBox(gb As Guna2GroupBox)
        gb.Left = (Me.ClientSize.Width - gb.Width) / 2
        gb.Top = (Me.ClientSize.Height - gb.Height) / 2
    End Sub
End Class