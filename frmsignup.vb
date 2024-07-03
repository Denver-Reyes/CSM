Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmSignUp

    ' Connection string for your MySQL database
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=dbexcolo;Integrated Security=True;"

    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hide Groupbox2 
        Group2SecurityQuestion.Visible = False

        'Set Groupbox 2 location to Groupbox 1
        Group2SecurityQuestion.Location = Group1infoandPass.Location

        ' Resize the form to match the size of GroupBox1 with padding
        Me.ClientSize = New Size(Group1infoandPass.Width + 150, Group1infoandPass.Height + 50)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim frmlogin As New frmlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnBacktofrmLogin_Click(sender As Object, e As EventArgs)
        Dim frmlogin As New frmlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2HtmlLabel9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNextPageSignUpFrm_Click(sender As Object, e As EventArgs) Handles btnNextPageSignUpFrm.Click

        If txtFirstName.Text.Trim() = "" OrElse txtLastName.Text.Trim() = "" OrElse
          txtEmail.Text.Trim() = "" OrElse txtStudentId.Text.Trim() = "" OrElse
          txtPassword.Text.Trim() = "" OrElse txtConfirmPassword.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsValidEmail(txtEmail.Text.Trim()) Then
            MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not IsValidStudentId(txtStudentId.Text.Trim()) Then
            MessageBox.Show("Invalid student ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Group1infoandPass.Visible = False
        Group2SecurityQuestion.Visible = True

    End Sub

    Private Sub Group2SecurityQuestion_Click(sender As Object, e As EventArgs) Handles Group2SecurityQuestion.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnfrmsignup.LinkClicked
        Group1infoandPass.Visible = True
        Group2SecurityQuestion.Visible = False
    End Sub

    Private Sub lnkReturnToPagefrmsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnToPagefrmsignup.LinkClicked
        'Next form when clicking the button
        Dim frmnlogin As New frmlogin()
        frmnlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim conn As MySqlConnection = Nothing
        Dim cmd As New MySqlCommand()

        ' Validate inputs if needed before proceeding
        ' Ensure both questions are selected and answers are provided

        Try
            conn = Common.getDBConnectionX()
            conn.Open()

            ' SQL command with parameters to prevent SQL injection
            cmd.Connection = conn
            cmd.CommandText = "INSERT INTO tblusers (FirstName, LastName, Email, stdntID, PasswordHash, SecurityQuestion, SecurityQuestionAnswer,privilege) " &
                              "VALUES (@FirstName, @LastName, @Email, @stdntID, @PasswordHash, @SecurityQuestion, @SecurityQuestionAnswer, 'student')"

            ' Add parameters with sanitized input
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
            cmd.Parameters.AddWithValue("@stdntID", txtStudentId.Text.Trim())
            cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text.Trim()))
            cmd.Parameters.AddWithValue("@SecurityQuestion", cmbSecurityQuestion1.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@SecurityQuestion1Answer", HashSecurityQuestion(txtSecurityQuestion1Answer.Text.Trim()))

            cmd.ExecuteNonQuery()

            ' Clear textboxes after successful insert
            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmail.Clear()
            txtStudentId.Clear()
            txtPassword.Clear()
            txtConfirmPassword.Clear()
            txtSecurityQuestion1Answer.Clear()

            MessageBox.Show("User registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frmlogin As New frmlogin()
            frmlogin.Show()
            Me.Hide()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 1062 ' Duplicate entry error example
                    MessageBox.Show("Email or Student ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to validate email format
    Private Function IsValidEmail(email As String) As Boolean
        ' Implement your email validation logic (basic check for demonstration)
        Return email.Contains("@")
    End Function

    ' Function to validate student ID format
    Private Function IsValidStudentId(studentId As String) As Boolean
        ' Implement your student ID validation logic (basic check for demonstration)
        Return studentId.Contains("-")
    End Function

    ' Function to hash password (using SHA256 for demonstration)
    Private Function HashPassword(password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            ' ComputeHash - returns byte array
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))

            ' Convert byte array to a string
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2")) ' "x2" formats bytes to hexadecimal
            Next
            Return builder.ToString()
        End Using
    End Function

    ' Function to hash security question answers
    Private Function HashSecurityQuestion(answer As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            ' ComputeHash - returns byte array
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(answer))

            ' Convert byte array to a string
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2")) ' "x2" formats bytes to hexadecimal
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub txtSecurityQuestion1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSecurityQuestion1.SelectedIndexChanged

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub
End Class
