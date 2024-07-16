Imports MySql.Data.MySqlClient

Public Class frmmain
    Public Property isAdmin As Boolean
    Public Property RespondentType As String

    Dim conn As MySqlConnection = Nothing

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        SetButtonColors(btnRegistrar, "Registrar")
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        SetButtonColors(btnCashier, "Cashier")
    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        SetButtonColors(btnLibrary, "Library")
    End Sub

    Private Sub btnClinic_Click(sender As Object, e As EventArgs) Handles btnClinic.Click
        SetButtonColors(btnClinic, "Clinic")
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim frmResult As New frmResult
        frmResult.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub btnSubmitMain_Click(sender As Object, e As EventArgs) Handles btnSubmitMain.Click
        SubmitResults()
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Dim frmentry As New frmEntry()
        frmentry.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminLogin_Click(sender As Object, e As EventArgs) Handles btnAdminLogin.Click
        Dim frmadminlogin As New frmadminlogin()
        frmadminlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GroupBox2_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox2.Click

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnResults.Visible = isAdmin
    End Sub

    Private Sub RetrieveAndDisplayQuestions(facility As String)
        ' Clear existing labels
        lblQ1.Text = String.Empty
        lblQ2.Text = String.Empty
        lblQ3.Text = String.Empty
        lblQ4.Text = String.Empty

        ' Clear the questions dictionary
        questions.Clear()

        ' Create a list to store labels
        Dim labels As New List(Of Label) From {lblQ1, lblQ2, lblQ3, lblQ4}

        Try
            ' Open the connection
            conn = Common.getDBConnectionX()
            conn.Open()

            ' Define the query
            Dim query As String = "SELECT questionID, questionText FROM tblquestions WHERE facility = @facility AND status = 'active'"

            ' Create a command
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@facility", facility)

                ' Execute the command and read the results
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim index As Integer = 0
                    While reader.Read() AndAlso index < labels.Count
                        Dim questionID As Integer = reader("questionID")
                        Dim questionText As String = reader("questionText").ToString()

                        ' Store questionID and questionText in the dictionary
                        questions.Add(questionID, questionText)

                        ' Display question text
                        labels(index).Text = questionText
                        index += 1
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Sub SetButtonColors(selectedButton As Guna.UI2.WinForms.Guna2GradientButton, facility As String)
        ' Reset all button colors
        For Each btn As Guna.UI2.WinForms.Guna2GradientButton In {btnRegistrar, btnCashier, btnLibrary, btnClinic, btnResults}
            btn.FillColor = Color.FromArgb(255, 255, 255)
            btn.FillColor2 = Color.FromArgb(255, 255, 255)
        Next

        ' Highlight the selected button
        selectedButton.FillColor = Color.FromArgb(255, 128, 0)
        selectedButton.FillColor2 = Color.FromArgb(255, 100, 0)

        ' Retrieve and display questions
        RetrieveAndDisplayQuestions(facility)
    End Sub

    Private Sub SubmitResults()
        ' Get ratings from radio buttons
        Dim ratings As New List(Of Integer) From {
        GetRatingFromRadioButtonGroup(gbquestion1),
        GetRatingFromRadioButtonGroup(gbquestion2),
        GetRatingFromRadioButtonGroup(gbquestion3),
        GetRatingFromRadioButtonGroup(gbquestion4)
    }

        ' Check if all questions have been answered
        If ratings.Contains(0) Then
            MessageBox.Show("Please answer all the questions before submitting.")
            Return
        End If

        ' Get comment
        Dim comment As String = txtCommentBox.Text

        ' Get current timestamp
        Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        Try
            ' Open the connection
            conn = Common.getDBConnectionX()
            conn.Open()

            ' Insert results into the database
            Dim index As Integer = 0
            For Each kvp As KeyValuePair(Of Integer, String) In questions
                Dim query As String = "INSERT INTO tblresults (respondentType, questionID, rating, comment, date_submitted) VALUES (@respondentType, @questionID, @rating, @comment, @date_submitted)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@respondentType", RespondentType)
                    cmd.Parameters.AddWithValue("@questionID", kvp.Key) ' Use the actual questionID
                    cmd.Parameters.AddWithValue("@rating", ratings(index))
                    cmd.Parameters.AddWithValue("@comment", comment)
                    cmd.Parameters.AddWithValue("@date_submitted", timestamp)
                    cmd.ExecuteNonQuery()
                End Using
                index += 1
            Next

            MessageBox.Show("Thank you for your feedback!")
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while submitting data: " & ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub



    Private Function GetRatingFromRadioButtonGroup(groupBox As Guna.UI2.WinForms.Guna2GroupBox) As Integer
        For Each control As Control In groupBox.Controls
            If TypeOf control Is RadioButton AndAlso DirectCast(control, RadioButton).Checked Then
                Select Case control.Name
                    Case "fivestarQ1", "fivestarQ2", "fivestarQ3", "fivestarQ4"
                        Return 5
                    Case "fourstarQ1", "fourstarQ2", "fourstarQ3", "fourstarQ4"
                        Return 4
                    Case "threestarQ1", "threestarQ2", "threestarQ3", "threestarQ4"
                        Return 3
                    Case "twostarQ1", "twostarQ2", "twostarQ3", "twostarQ4"
                        Return 2
                    Case "onestarQ1", "onestarQ2", "onestarQ3", "onestarQ4"
                        Return 1
                End Select
            End If
        Next
        Return 0 ' No rating selected
    End Function

    Private questions As New Dictionary(Of Integer, String)
End Class
