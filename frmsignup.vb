Public Class frmSignUp
    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim frmlogin As New frmLogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnBacktofrmLogin_Click(sender As Object, e As EventArgs) Handles btnBacktofrmLogin.Click
        Dim frmlogin As New frmLogin()
        frmlogin.Show()
        Me.Hide()
    End Sub
End Class