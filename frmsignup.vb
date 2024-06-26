Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Data.SqlClient


Public Class frmSignUp

    ' Connection string for your SQL Server database
    Dim connectionString As String = "Data Source=localhost;Initial Catalog=dbexcolo;Integrated Security=True;"
    Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel4.Click

    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hide Groupbox2 
        Group2SecurityQuestion.Visible = False

        'Set Groupbox 2 location to Groupbox 1
        Group2SecurityQuestion.Location = Group1infoandPass.Location

        ' Resize the form to match the size of GroupBox1 with padding
        Me.ClientSize = New Size(Group1infoandPass.Width + 150, Group1infoandPass.Height + 50)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Dim frmlogin As New frmlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnBacktofrmLogin_Click(sender As Object, e As EventArgs)
        Dim frmlogin As New frmlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2HtmlLabel9_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel9.Click

    End Sub

    Private Sub btnNextPageSignUpFrm_Click(sender As Object, e As EventArgs) Handles btnNextPageSignUpFrm.Click
        Group1infoandPass.Visible = False
        Group2SecurityQuestion.Visible = True
    End Sub

    Private Sub Group2SecurityQuestion_Click(sender As Object, e As EventArgs) Handles Group2SecurityQuestion.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnfrmsignup.LinkClicked
        Group1infoandPass.Visible = True
        Group2SecurityQuestion.Visible = False
    End Sub

    Private Sub lnkReturnToPagefrmsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkReturnToPagefrmsignup.LinkClicked
        'Next form when clicking the button
        Dim frmnlogin As New frmlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim frmlogin As New frmlogin()
        frmlogin.Show()
        Me.Hide()
    End Sub

End Class