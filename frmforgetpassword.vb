Public Class frmforgetpassword
    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Group2SecurityQuestion.Click

    End Sub

    Private Sub Guna2HtmlLabel13_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel13.Click

    End Sub

    Private Sub Guna2HtmlLabel10_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel10.Click

    End Sub

    Private Sub Guna2TextBox12_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox12.TextChanged

    End Sub

    Private Sub Guna2TextBox10_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox10.TextChanged

    End Sub

    Private Sub frmforgetpasswordemail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide Groupbox
        Group2SecurityQuestion.Visible = False
        Groupbox3ChangePassword.Visible = False

        'Set Groupbox  location to Groupbox 1
        Group2SecurityQuestion.Location = Group1ForgotPassword.Location
        Groupbox3ChangePassword.Location = Group1ForgotPassword.Location

        ' Resize the form to match the size of GroupBox1 with padding
        Me.ClientSize = New Size(Group1ForgotPassword.Width + 150, Group1ForgotPassword.Height + 50)
    End Sub

    Private Sub btnNextPage1frmforgetpassword_Click(sender As Object, e As EventArgs) Handles btnNextPage1frmforgetpassword.Click
        Group2SecurityQuestion.Visible = True
        Group1ForgotPassword.Visible = False
        Groupbox3ChangePassword.Visible = False
    End Sub

    Private Sub lnkReturnToPage1frmchangepassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnToPage1frmchangepassword.LinkClicked
        Dim frmlogin As New frmadminlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnNextPage2frmforgetpassword_Click(sender As Object, e As EventArgs) Handles btnNextPage2frmforgetpassword.Click
        Group2SecurityQuestion.Visible = False
        Group1ForgotPassword.Visible = False
        Groupbox3ChangePassword.Visible = True
    End Sub

    Private Sub btnNextPage3frmforgetpassword_Click(sender As Object, e As EventArgs) Handles btnNextPage3frmforgetpassword.Click
        Dim frmlogin As New frmadminlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub lnkReturnToPage2frmchangepassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnToPage2frmchangepassword.LinkClicked
        Group2SecurityQuestion.Visible = False
        Group1ForgotPassword.Visible = True
        Groupbox3ChangePassword.Visible = False
    End Sub

    Private Sub lnkReturnToPage3frmchangepassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnToPage3frmchangepassword.LinkClicked
        Group2SecurityQuestion.Visible = True
        Group1ForgotPassword.Visible = False
        Groupbox3ChangePassword.Visible = False
    End Sub

    Private Sub Guna2HtmlLabel8_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel8.Click

    End Sub
End Class