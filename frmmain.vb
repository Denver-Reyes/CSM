Public Class frmmain
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        btnRegistrar.FillColor = Color.FromArgb(255, 128, 0)
        btnRegistrar.FillColor2 = Color.FromArgb(255, 100, 0)

        btnCashier.FillColor = Color.FromArgb(255, 255, 255)
        btnCashier.FillColor2 = Color.FromArgb(255, 255, 255)

        btnLibrary.FillColor = Color.FromArgb(255, 255, 255)
        btnLibrary.FillColor2 = Color.FromArgb(255, 255, 255)

        btnClinic.FillColor = Color.FromArgb(255, 255, 255)
        btnClinic.FillColor2 = Color.FromArgb(255, 255, 255)

        btnResults.FillColor = Color.FromArgb(255, 255, 255)
        btnResults.FillColor2 = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        btnRegistrar.FillColor = Color.FromArgb(255, 255, 255)
        btnRegistrar.FillColor2 = Color.FromArgb(255, 255, 255)

        btnCashier.FillColor = Color.FromArgb(255, 128, 0)
        btnCashier.FillColor2 = Color.FromArgb(255, 100, 0)

        btnLibrary.FillColor = Color.FromArgb(255, 255, 255)
        btnLibrary.FillColor2 = Color.FromArgb(255, 255, 255)

        btnClinic.FillColor = Color.FromArgb(255, 255, 255)
        btnClinic.FillColor2 = Color.FromArgb(255, 255, 255)

        btnResults.FillColor = Color.FromArgb(255, 255, 255)
        btnResults.FillColor2 = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        btnRegistrar.FillColor = Color.FromArgb(255, 255, 255)
        btnRegistrar.FillColor2 = Color.FromArgb(255, 255, 255)

        btnCashier.FillColor = Color.FromArgb(255, 255, 255)
        btnCashier.FillColor2 = Color.FromArgb(255, 255, 255)

        btnLibrary.FillColor = Color.FromArgb(255, 128, 0)
        btnLibrary.FillColor2 = Color.FromArgb(255, 100, 0)

        btnClinic.FillColor = Color.FromArgb(255, 255, 255)
        btnClinic.FillColor2 = Color.FromArgb(255, 255, 255)

        btnResults.FillColor = Color.FromArgb(255, 255, 255)
        btnResults.FillColor2 = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub btnClinic_Click(sender As Object, e As EventArgs) Handles btnClinic.Click
        btnRegistrar.FillColor = Color.FromArgb(255, 255, 255)
        btnRegistrar.FillColor2 = Color.FromArgb(255, 255, 255)

        btnCashier.FillColor = Color.FromArgb(255, 255, 255)
        btnCashier.FillColor2 = Color.FromArgb(255, 255, 255)

        btnLibrary.FillColor = Color.FromArgb(255, 255, 255)
        btnLibrary.FillColor2 = Color.FromArgb(255, 255, 255)

        btnClinic.FillColor = Color.FromArgb(255, 128, 5)
        btnClinic.FillColor2 = Color.FromArgb(255, 100, 0)

        btnResults.FillColor = Color.FromArgb(255, 255, 255)
        btnResults.FillColor2 = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        btnRegistrar.FillColor = Color.FromArgb(255, 255, 255)
        btnRegistrar.FillColor2 = Color.FromArgb(255, 255, 255)

        btnCashier.FillColor = Color.FromArgb(255, 255, 255)
        btnCashier.FillColor2 = Color.FromArgb(255, 255, 255)

        btnLibrary.FillColor = Color.FromArgb(255, 255, 255)
        btnLibrary.FillColor2 = Color.FromArgb(255, 255, 255)

        btnClinic.FillColor = Color.FromArgb(255, 255, 255)
        btnClinic.FillColor2 = Color.FromArgb(255, 255, 255)

        btnResults.FillColor = Color.FromArgb(255, 128, 0)
        btnResults.FillColor2 = Color.FromArgb(255, 100, 0)
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub btnSubmitMain_Click(sender As Object, e As EventArgs) Handles btnSubmitMain.Click

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
End Class