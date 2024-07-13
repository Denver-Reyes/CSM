Imports MySql.Data.MySqlClient
Public Class frmmain

    Public Property isAdmin As Boolean
    Dim conn As MySqlConnection = Nothing
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

        ' Define the facility
        Dim facility As String = "Registrar"

        ' Retrieve and display questions
        RetrieveAndDisplayQuestions(facility)
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
        ' Define the facility
        Dim facility As String = "Cashier"

        ' Retrieve and display questions
        RetrieveAndDisplayQuestions(facility)
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
        ' Define the facility
        Dim facility As String = "Library"

        ' Retrieve and display questions
        RetrieveAndDisplayQuestions(facility)
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
        ' Define the facility
        Dim facility As String = "Clinic"

        ' Retrieve and display questions
        RetrieveAndDisplayQuestions(facility)
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

    Private Sub Guna2GroupBox2_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox2.Click

    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnResults.Visible = isAdmin
    End Sub

    Private Sub RetrieveAndDisplayQuestions(facility As String)
        ' Clear existing labels
        lblQ1.Text = String.Empty
        lblQ2.Text = String.Empty
        lblQ3.Text = String.Empty
        lblQ4.Text = String.Empty

        ' Create a list to store labels
        Dim labels As New List(Of Label) From {lblQ1, lblQ2, lblQ3, lblQ4}

        Try
            ' Open the connection
            conn = Common.getDBConnectionX()
            conn.Open()

            ' Define the query
            Dim query As String = "SELECT questionText FROM tblquestions WHERE facility = @facility AND status = 'active'"


            ' Create a command
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@facility", facility)

                ' Execute the command and read the results
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    Dim index As Integer = 0
                    While reader.Read() AndAlso index < labels.Count
                        labels(index).Text = reader("questionText").ToString()
                        index += 1
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("An error occurred while retrieving data: " & ex.Message)
        Finally
            If conn IsNot Nothing Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
