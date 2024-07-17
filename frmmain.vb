Imports MySql.Data.MySqlClient

Public Class frmmain

    Dim conn As MySqlConnection = Nothing

    Private questions As New Dictionary(Of Integer, String)

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub btnConfirmbuttonMain_Click(sender As Object, e As EventArgs) Handles btnConfirmbuttonMain.Click
        Dim respondentType As String = ""
        Dim result As DialogResult = MessageBox.Show("Are you a student, faculty, or guest?", "Respondent Type", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            respondentType = "Student"
        ElseIf result = DialogResult.No Then
            respondentType = "Faculty"
        Else
            respondentType = "Guest"
        End If

        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim query As String = "INSERT INTO tblresults (questionID, rating, respondentType, date_submitted) VALUES (@questionID, @rating, @respondentType, @date_submitted)"
        Dim cmd As New MySqlCommand(query, connection)

        Try
            connection.Open()
            For Each control As Control In plQuestions.Controls
                If TypeOf control Is GroupBox Then
                    Dim gbQuestion As GroupBox = CType(control, GroupBox)
                    For Each rbtn As RadioButton In gbQuestion.Controls.OfType(Of RadioButton)()
                        If rbtn.Checked Then
                            Dim questionID As Integer = CInt(rbtn.Tag)
                            Dim rating As Integer = Integer.Parse(rbtn.Text.Split(" "c)(0))
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

    Private Sub pnlQuestionsContainer_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tlpQuestions_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles plQuestions.Paint

    End Sub

    Private Sub InitializePanel()
        plQuestions.AutoScroll = True
    End Sub

    Public Sub LoadQuestionsIntoPanel()
        Dim facility As String = frmEntry.SelectedFacility
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
            Dim gbQuestion As New GroupBox() With {
                .Text = questionText,
                .Size = New Size(plQuestions.ClientSize.Width - 20, questionHeight),
                .Location = New Point(10, y)
            }

            ' Add radio buttons to the group box with updated text
            Dim radioButtons As RadioButton() = {
                New RadioButton() With {.Text = "1 Star", .Tag = questionId},
                New RadioButton() With {.Text = "2 Star", .Tag = questionId},
                New RadioButton() With {.Text = "3 Star", .Tag = questionId},
                New RadioButton() With {.Text = "4 Star", .Tag = questionId},
                New RadioButton() With {.Text = "5 Star", .Tag = questionId}
            }

            Dim buttonX As Integer = 10 ' X position for radio buttons
            For Each rb As RadioButton In radioButtons
                rb.Size = New Size(80, 30) ' Adjust size if necessary
                rb.Location = New Point(buttonX, 30)
                rb.Font = New Font("Arial", 20) ' Ensure the font size is appropriate
                gbQuestion.Controls.Add(rb)
                buttonX += 90 ' Adjust the spacing between radio buttons
            Next

            plQuestions.Controls.Add(gbQuestion)
            y += questionHeight + 10 ' Move the Y position for the next question
        Next

        conn.Close()
    End Sub

End Class
