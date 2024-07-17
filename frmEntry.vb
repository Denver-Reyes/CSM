Public Class frmEntry
    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs)
        SetRespondentType("Student")
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs)
        SetRespondentType("Faculty")
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs)
        SetRespondentType("Guest")
    End Sub

    Private Sub SetRespondentType(type As String)
        Dim frmmaintest As New frmmain()
        frmmaintest.Show()
        frmmaintest.RespondentType = type
        Me.Hide()
    End Sub

    Private Sub frmEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub
End Class