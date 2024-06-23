Public Class frmsecurityquestionforgetpass
    Private Sub frmsecurityquestionforgetpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSecurityQuestion_Click(sender As Object, e As EventArgs) Handles btnSecurityQuestion.Click
        Dim frmlogin As New frmLogin()
        frmlogin.Show()
        Me.Hide()
    End Sub
End Class