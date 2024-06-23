Public Class frmforgetpasswordemail
    Private Sub btnConfirmEmailForgetPassword_Click(sender As Object, e As EventArgs) Handles btnConfirmEmailForgetPassword.Click
        Dim frmsecurityquestionforgetpass As New frmsecurityquestionforgetpass()
        frmsecurityquestionforgetpass.Show()
        Me.Hide()
    End Sub
End Class