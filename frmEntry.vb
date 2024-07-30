Public Class frmEntry
    Public Shared SelectedFacility As String ' Ensure it's shared so it can be accessed easily

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        SelectedFacility = "Registrar"
        OpenMainForm()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        SelectedFacility = "Cashier"
        OpenMainForm()
    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        SelectedFacility = "Library"
        OpenMainForm()
    End Sub

    Private Sub btnClinic_Click(sender As Object, e As EventArgs) Handles btnClinic.Click
        SelectedFacility = "Clinic"
        OpenMainForm()
    End Sub

    Private Sub OpenMainForm()
        Dim mainForm As New frmmain()
        mainForm.Show()
        Me.Hide() ' Hide or close the current form
    End Sub

    Private Sub lnklblAdminLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAdminLogin.LinkClicked
        Dim frmadminlogin As New frmadminlogin()
        frmadminlogin.Show()
        Me.Hide()
    End Sub
End Class
