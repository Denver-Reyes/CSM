Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmlogin
    Private Sub lnkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSignUpFrmnewlogin.LinkClicked

        'Next form when clicking the button
        Dim frmsignup As New frmSignUp()
        frmsignup.Show()
        Me.Hide()
    End Sub

    Private Sub lnkForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgetPassword.LinkClicked
        Dim frmforgetpassword As New frmforgetpassword
        frmforgetpassword.Show()
        Me.Hide()
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    ' Function to hash passwords
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

    Private Sub LogLoginAttempt(conn As MySqlConnection, userID As Integer, status As String)
        Dim query As String = "INSERT INTO logs (userID, loginTimestamp, deviceUsername, loginStatus) VALUES (@UserID, @LoginTimestamp, @DeviceUsername, @LoginStatus)"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UserID", userID)
            cmd.Parameters.AddWithValue("@LoginTimestamp", DateTime.Now)
            cmd.Parameters.AddWithValue("@DeviceUsername", Environment.UserName)
            cmd.Parameters.AddWithValue("@LoginStatus", status)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As MySqlException
                ' MySQL specific error
                MessageBox.Show("Error in LogLoginAttempt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnLoginNewButton_Click(sender As Object, e As EventArgs) Handles btnLoginNewButton.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim frmmaintest As New frmmaintest()
        Dim conn As MySqlConnection = Nothing


        If String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            conn = Common.getDBConnectionX()
            conn.Open()

                ' Check if email exists and retrieve the password hash and userID
                Dim query As String = "SELECT userID, PasswordHash FROM users WHERE Email = @Email LIMIT 1"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Email", email)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim userID As Integer = Convert.ToInt32(reader("userID"))
                    Dim storedHash As String = reader("PasswordHash").ToString()

                    ' Verify the password
                    If storedHash = HashPassword(password) Then
                        reader.Close() ' Ensure reader is closed in all cases
                        ' Log the successful login attempt
                        LogLoginAttempt(conn, userID, "success")
                        MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmmaintest.Show()
                        Me.Hide()
                    Else
                        reader.Close() ' Ensure reader is closed in all cases
                        ' Log the failed login attempt
                        LogLoginAttempt(conn, userID, "failed")
                        MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            reader.Close()
        Catch ex As MySqlException
            ' MySQL specific error
            MessageBox.Show("MySQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' General error
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub
End Class