<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResult
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResult))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnResultsClinic = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResultsLibrary = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResultsCashier = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResultsRegistrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReturntoEntry = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlResults = New System.Windows.Forms.Panel()
        Me.cmbMonths = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PieChartUserType = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartQuestionnaire = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblMonthPlaceholder = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlResults.SuspendLayout()
        CType(Me.PieChartUserType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartQuestionnaire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientPanel1.BorderThickness = 3
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1420, 84)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImage = CType(resources.GetObject("Guna2PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(181, 84)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnResultsClinic)
        Me.Guna2Panel1.Controls.Add(Me.btnResultsLibrary)
        Me.Guna2Panel1.Controls.Add(Me.btnResultsCashier)
        Me.Guna2Panel1.Controls.Add(Me.btnResultsRegistrar)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 84)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1420, 76)
        Me.Guna2Panel1.TabIndex = 1
        '
        'btnResultsClinic
        '
        Me.btnResultsClinic.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsClinic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsClinic.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResultsClinic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResultsClinic.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnResultsClinic.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResultsClinic.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultsClinic.ForeColor = System.Drawing.Color.White
        Me.btnResultsClinic.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResultsClinic.Location = New System.Drawing.Point(1065, 0)
        Me.btnResultsClinic.Name = "btnResultsClinic"
        Me.btnResultsClinic.Size = New System.Drawing.Size(355, 76)
        Me.btnResultsClinic.TabIndex = 2
        Me.btnResultsClinic.Text = "Clinic"
        '
        'btnResultsLibrary
        '
        Me.btnResultsLibrary.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsLibrary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsLibrary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResultsLibrary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResultsLibrary.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnResultsLibrary.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResultsLibrary.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultsLibrary.ForeColor = System.Drawing.Color.White
        Me.btnResultsLibrary.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResultsLibrary.Location = New System.Drawing.Point(710, 0)
        Me.btnResultsLibrary.Name = "btnResultsLibrary"
        Me.btnResultsLibrary.Size = New System.Drawing.Size(355, 76)
        Me.btnResultsLibrary.TabIndex = 2
        Me.btnResultsLibrary.Text = "Library"
        '
        'btnResultsCashier
        '
        Me.btnResultsCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResultsCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResultsCashier.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnResultsCashier.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResultsCashier.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultsCashier.ForeColor = System.Drawing.Color.White
        Me.btnResultsCashier.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResultsCashier.Location = New System.Drawing.Point(355, 0)
        Me.btnResultsCashier.Name = "btnResultsCashier"
        Me.btnResultsCashier.Size = New System.Drawing.Size(355, 76)
        Me.btnResultsCashier.TabIndex = 1
        Me.btnResultsCashier.Text = "Cashier"
        '
        'btnResultsRegistrar
        '
        Me.btnResultsRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResultsRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResultsRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResultsRegistrar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnResultsRegistrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResultsRegistrar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultsRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnResultsRegistrar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnResultsRegistrar.Location = New System.Drawing.Point(0, 0)
        Me.btnResultsRegistrar.Name = "btnResultsRegistrar"
        Me.btnResultsRegistrar.Size = New System.Drawing.Size(355, 76)
        Me.btnResultsRegistrar.TabIndex = 0
        Me.btnResultsRegistrar.Text = "Registrar"
        '
        'btnReturntoEntry
        '
        Me.btnReturntoEntry.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturntoEntry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturntoEntry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturntoEntry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturntoEntry.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReturntoEntry.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReturntoEntry.ForeColor = System.Drawing.Color.White
        Me.btnReturntoEntry.Image = CType(resources.GetObject("btnReturntoEntry.Image"), System.Drawing.Image)
        Me.btnReturntoEntry.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReturntoEntry.ImageOffset = New System.Drawing.Point(4, 0)
        Me.btnReturntoEntry.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnReturntoEntry.Location = New System.Drawing.Point(27, 789)
        Me.btnReturntoEntry.Name = "btnReturntoEntry"
        Me.btnReturntoEntry.Size = New System.Drawing.Size(91, 31)
        Me.btnReturntoEntry.TabIndex = 16
        Me.btnReturntoEntry.Text = "Return"
        Me.btnReturntoEntry.TextOffset = New System.Drawing.Point(8, 0)
        '
        'pnlResults
        '
        Me.pnlResults.BackColor = System.Drawing.Color.LightGray
        Me.pnlResults.Controls.Add(Me.cmbMonths)
        Me.pnlResults.Controls.Add(Me.lblMonthPlaceholder)
        Me.pnlResults.Controls.Add(Me.PieChartUserType)
        Me.pnlResults.Controls.Add(Me.ChartQuestionnaire)
        Me.pnlResults.Location = New System.Drawing.Point(0, 161)
        Me.pnlResults.Name = "pnlResults"
        Me.pnlResults.Size = New System.Drawing.Size(1420, 622)
        Me.pnlResults.TabIndex = 18
        '
        'cmbMonths
        '
        Me.cmbMonths.BackColor = System.Drawing.Color.Transparent
        Me.cmbMonths.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonths.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonths.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonths.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbMonths.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMonths.ItemHeight = 30
        Me.cmbMonths.Location = New System.Drawing.Point(142, 21)
        Me.cmbMonths.Name = "cmbMonths"
        Me.cmbMonths.Size = New System.Drawing.Size(140, 36)
        Me.cmbMonths.TabIndex = 24
        '
        'PieChartUserType
        '
        ChartArea3.Name = "ChartArea1"
        Me.PieChartUserType.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.PieChartUserType.Legends.Add(Legend3)
        Me.PieChartUserType.Location = New System.Drawing.Point(873, 63)
        Me.PieChartUserType.Name = "PieChartUserType"
        Me.PieChartUserType.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.PieChartUserType.Series.Add(Series3)
        Me.PieChartUserType.Size = New System.Drawing.Size(496, 375)
        Me.PieChartUserType.TabIndex = 22
        Me.PieChartUserType.Text = "Chart2"
        '
        'ChartQuestionnaire
        '
        ChartArea4.Name = "ChartArea1"
        Me.ChartQuestionnaire.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.ChartQuestionnaire.Legends.Add(Legend4)
        Me.ChartQuestionnaire.Location = New System.Drawing.Point(32, 63)
        Me.ChartQuestionnaire.Name = "ChartQuestionnaire"
        Me.ChartQuestionnaire.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.ChartQuestionnaire.Series.Add(Series4)
        Me.ChartQuestionnaire.Size = New System.Drawing.Size(795, 375)
        Me.ChartQuestionnaire.TabIndex = 21
        Me.ChartQuestionnaire.Text = "Chart1"
        '
        'lblMonthPlaceholder
        '
        Me.lblMonthPlaceholder.AutoSize = True
        Me.lblMonthPlaceholder.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthPlaceholder.ForeColor = System.Drawing.Color.Black
        Me.lblMonthPlaceholder.Location = New System.Drawing.Point(35, 20)
        Me.lblMonthPlaceholder.Name = "lblMonthPlaceholder"
        Me.lblMonthPlaceholder.Size = New System.Drawing.Size(113, 37)
        Me.lblMonthPlaceholder.TabIndex = 23
        Me.lblMonthPlaceholder.Text = "MONTH:"
        '
        'frmResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1420, 832)
        Me.Controls.Add(Me.pnlResults)
        Me.Controls.Add(Me.btnReturntoEntry)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Results"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.pnlResults.ResumeLayout(False)
        Me.pnlResults.PerformLayout()
        CType(Me.PieChartUserType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartQuestionnaire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnResultsRegistrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResultsClinic As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResultsLibrary As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResultsCashier As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReturntoEntry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlResults As Panel
    Friend WithEvents PieChartUserType As DataVisualization.Charting.Chart
    Friend WithEvents ChartQuestionnaire As DataVisualization.Charting.Chart
    Friend WithEvents cmbMonths As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblMonthPlaceholder As Label
End Class
