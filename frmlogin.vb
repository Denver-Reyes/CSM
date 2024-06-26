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
End Class