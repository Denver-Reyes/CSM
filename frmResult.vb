Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmResult
    Public isAdmin As Boolean
    Private selectedFacility As String ' Variable to store the selected facility

    Private Sub frmResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize or load any necessary data
    End Sub

    Private Sub btnResultsRegistrar_Click(sender As Object, e As EventArgs) Handles btnResultsRegistrar.Click
        selectedFacility = "Registrar"
        LoadResults(selectedFacility)
    End Sub

    Private Sub btnResultsCashier_Click(sender As Object, e As EventArgs) Handles btnResultsCashier.Click
        selectedFacility = "Cashier"
        LoadResults(selectedFacility)
    End Sub

    Private Sub btnResultsLibrary_Click(sender As Object, e As EventArgs) Handles btnResultsLibrary.Click
        selectedFacility = "Library"
        LoadResults(selectedFacility)
    End Sub

    Private Sub btnResultsClinic_Click(sender As Object, e As EventArgs) Handles btnResultsClinic.Click
        selectedFacility = "Clinic"
        LoadResults(selectedFacility)
    End Sub


    Private Sub LoadResults(facility As String)
        ' Retrieve the questions and categories for the selected facility
        Dim questions As List(Of (Category As String, QuestionID As Integer)) = GetQuestions(facility)

        ' Clear previous data
        ChartQuestionnaire.Series.Clear()
        ChartQuestionnaire.ChartAreas.Clear()
        ChartQuestionnaire.ChartAreas.Add(New ChartArea())

        ' Clear previous data for PieChartUserType
        PieChartUserType.Series.Clear()
        PieChartUserType.ChartAreas.Clear()
        PieChartUserType.ChartAreas.Add(New ChartArea())

        ' Initialize data holders
        Dim months As New HashSet(Of String)()

        ' Accumulate data for all questions
        For Each question In questions
            Dim questionID = question.QuestionID

            ' Retrieve the months for the current questionID
            Dim questionMonths As List(Of String) = GetMonths(questionID)
            For Each monthItem In questionMonths
                months.Add(monthItem)
            Next
        Next

        ' Populate months into ComboBox
        PopulateMonths(months.ToList())
    End Sub


    Private Sub PopulateMonths(months As List(Of String))
        cmbMonths.Items.Clear()
        For Each monthItem In months
            cmbMonths.Items.Add(monthItem)
        Next

        If cmbMonths.Items.Count > 0 Then
            cmbMonths.SelectedIndex = 0 ' Optionally select the first item
        End If
    End Sub


    Private Function GetQuestions(facility As String) As List(Of (Category As String, QuestionID As Integer))
        Dim questions As New List(Of (Category As String, QuestionID As Integer))()
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim query As String = "SELECT questionID, category FROM tblquestions WHERE facility = @facility"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@facility", facility)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                questions.Add((reader("category").ToString(), CInt(reader("questionID"))))
            End While
        Catch ex As Exception
            MessageBox.Show("Error retrieving questions: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return questions
    End Function

    Private Function GetMonths(questionID As Integer) As List(Of String)
        Dim months As New List(Of String)()
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim query As String = "SELECT DISTINCT DATE_FORMAT(date_submitted, '%Y-%m') AS monthYear " &
                              "FROM tblresults WHERE questionID = @questionID ORDER BY monthYear"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@questionID", questionID)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                months.Add(reader("monthYear").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("Error retrieving months: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return months
    End Function

    Private Sub AccumulateChartData(questionID As Integer, monthYear As String, dataPoints As Dictionary(Of String, (TotalRating As Integer, Count As Integer)), category As String)
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim query As String = "SELECT rating, COUNT(*) AS count " &
                              "FROM tblresults " &
                              "WHERE questionID = @questionID AND DATE_FORMAT(date_submitted, '%Y-%m') = @monthYear " &
                              "GROUP BY rating"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@questionID", questionID)
        cmd.Parameters.AddWithValue("@monthYear", monthYear)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim rating As Integer = CInt(reader("rating"))
                Dim count As Integer = CInt(reader("count"))
                Dim key As String = category

                If dataPoints.ContainsKey(key) Then
                    dataPoints(key) = (dataPoints(key).TotalRating + rating * count, dataPoints(key).Count + count)
                Else
                    dataPoints.Add(key, (rating * count, count))
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub AccumulatePieChartData(questionID As Integer, monthYear As String, dataPoints As Dictionary(Of String, Integer))
        Dim connection As MySqlConnection = Common.getDBConnectionX()
        Dim query As String = "SELECT respondentType, COUNT(*) AS count " &
                              "FROM tblresults " &
                              "WHERE questionID = @questionID AND DATE_FORMAT(date_submitted, '%Y-%m') = @monthYear " &
                              "GROUP BY respondentType"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@questionID", questionID)
        cmd.Parameters.AddWithValue("@monthYear", monthYear)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim respondentType As String = reader("respondentType").ToString()
                Dim count As Integer = Convert.ToInt32(reader("count"))

                If dataPoints.ContainsKey(respondentType) Then
                    dataPoints(respondentType) += count
                Else
                    dataPoints.Add(respondentType, count)
                End If
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub UpdateChartQuestionnaire(dataPoints As Dictionary(Of String, (TotalRating As Integer, Count As Integer)))
        ' Ensure the chart's size remains the same
        Dim originalSize As Size = ChartQuestionnaire.Size

        ' Configure ChartArea if it doesn't exist or clear it
        If ChartQuestionnaire.ChartAreas.Count = 0 Then
            ChartQuestionnaire.ChartAreas.Add(New ChartArea())
        End If
        Dim chartArea As ChartArea = ChartQuestionnaire.ChartAreas(0)

        ' Clear previous series
        ChartQuestionnaire.Series.Clear()

        ' Create or update the Series
        Dim series As New Series("Average Ratings")
        series.ChartType = SeriesChartType.Column
        series.IsValueShownAsLabel = False ' No labels directly on the columns

        ' Add data points
        For Each kvp In dataPoints
            Dim averageRating As Double = kvp.Value.TotalRating / kvp.Value.Count
            series.Points.AddXY(kvp.Key, averageRating)
        Next

        ' Add series to chart
        ChartQuestionnaire.Series.Add(series)

        ' Configure legend if needed
        If ChartQuestionnaire.Legends.Count = 0 Then
            Dim legend As New Legend()
            legend.Docking = Docking.Right
            ChartQuestionnaire.Legends.Add(legend)
        End If

        ' Optional: Configure chart area for better display
        chartArea.AxisX.Title = "Category"
        chartArea.AxisY.Title = "Average Rating"
        chartArea.AxisX.Interval = 1
        chartArea.AxisY.Interval = 1

        ' Restore the original size of the chart
        ChartQuestionnaire.Size = originalSize
    End Sub



    Private Sub UpdatePieChartUserType(dataPoints As Dictionary(Of String, Integer))
        ' Ensure the chart's size remains the same
        Dim originalSize As Size = PieChartUserType.Size

        ' Configure ChartArea if it doesn't exist or clear it
        If PieChartUserType.ChartAreas.Count = 0 Then
            PieChartUserType.ChartAreas.Add(New ChartArea())
        End If

        ' Clear previous series
        PieChartUserType.Series.Clear()

        ' Create or update the Series
        Dim series As New Series("User Types")
        series.ChartType = SeriesChartType.Pie

        ' Add data points
        For Each kvp In dataPoints
            series.Points.AddXY(kvp.Key, kvp.Value)
        Next

        PieChartUserType.Series.Add(series)

        ' Configure labels if needed
        series.IsValueShownAsLabel = True
        series.Label = "#VALX (#PERCENT)"

        ' Restore the original size of the chart
        PieChartUserType.Size = originalSize
    End Sub



    Private Sub ChartQuestionnaire_Click(sender As Object, e As EventArgs) Handles ChartQuestionnaire.Click

    End Sub

    Private Sub cmbMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonths.SelectedIndexChanged
        If cmbMonths.SelectedItem IsNot Nothing Then
            Dim selectedMonth As String = cmbMonths.SelectedItem.ToString()
            UpdateChartsForMonth(selectedMonth)
        End If
    End Sub

    Private Sub UpdateChartsForMonth(selectedMonth As String)
        ' Use the class-level variable for the selected facility
        Dim facility As String = selectedFacility
        Dim questions As List(Of (Category As String, QuestionID As Integer)) = GetQuestions(facility)

        ' Initialize data holders
        Dim categoryTotals As New Dictionary(Of String, (TotalRating As Integer, Count As Integer))
        Dim pieChartData As New Dictionary(Of String, Integer)

        ' Accumulate data for all questions and selected month
        For Each question In questions
            Dim questionID = question.QuestionID
            Dim category = question.Category

            ' Accumulate data for ChartQuestionnaire
            AccumulateChartData(questionID, selectedMonth, categoryTotals, category)

            ' Accumulate data for PieChartUserType
            AccumulatePieChartData(questionID, selectedMonth, pieChartData)
        Next

        ' Update ChartQuestionnaire with average ratings per category
        UpdateChartQuestionnaire(categoryTotals)

        ' Update PieChartUserType with accumulated data
        UpdatePieChartUserType(pieChartData)
    End Sub

    Private Sub lblMonthPlaceholder_Click(sender As Object, e As EventArgs) Handles lblMonthPlaceholder.Click

    End Sub

    Private Sub btnReturntoEntry_Click(sender As Object, e As EventArgs) Handles btnReturntoEntry.Click
        Dim frmEntry As New frmEntry
        frmEntry.Show()
        Me.Hide()
    End Sub
End Class
