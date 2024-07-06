Public Class frmEntry
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim frmmaintest As New frmmaintest()
        frmmaintest.Show()
        Me.Hide()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Dim frmmaintest As New frmmaintest()
        frmmaintest.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim frmmaintest As New frmmaintest()
        frmmaintest.Show()
        Me.Hide()
    End Sub
End Class