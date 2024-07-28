Public Class frmEntry
    Public SelectedFacility As String
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub frmEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        SelectedFacility = "Registrar"
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        SelectedFacility = "Cashier"
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        SelectedFacility = "Library"
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub btnClinic_Click(sender As Object, e As EventArgs) Handles btnClinic.Click
        SelectedFacility = "Clinic"
        frmmain.Show()
        Me.Hide()
    End Sub

    Private Sub lnklblAdminLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAdminLogin.LinkClicked
        Dim frmadminlogin As New frmadminlogin
        frmadminlogin.Show()
        Me.Hide()
    End Sub
End Class