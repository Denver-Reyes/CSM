<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntry))
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFaculty = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnStudent = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnGuest = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderRadius = 15
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2GroupBox1.Controls.Add(Me.PictureBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnFaculty)
        Me.Guna2GroupBox1.Controls.Add(Me.btnStudent)
        Me.Guna2GroupBox1.Controls.Add(Me.btnGuest)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(122, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.BorderRadius = 15
        Me.Guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GroupBox1.ShadowDecoration.Enabled = True
        Me.Guna2GroupBox1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(528, 426)
        Me.Guna2GroupBox1.TabIndex = 1
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(165, 165)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(194, 15)
        Me.Guna2HtmlLabel1.TabIndex = 7
        Me.Guna2HtmlLabel1.Text = "PLACEHOLDER D KO ALAM LALAGAY"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnFaculty
        '
        Me.btnFaculty.Animated = True
        Me.btnFaculty.BorderRadius = 21
        Me.btnFaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFaculty.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFaculty.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFaculty.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFaculty.ForeColor = System.Drawing.Color.White
        Me.btnFaculty.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFaculty.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFaculty.Image = CType(resources.GetObject("btnFaculty.Image"), System.Drawing.Image)
        Me.btnFaculty.ImageOffset = New System.Drawing.Point(23, -10)
        Me.btnFaculty.ImageSize = New System.Drawing.Size(75, 75)
        Me.btnFaculty.Location = New System.Drawing.Point(191, 212)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.ShadowDecoration.BorderRadius = 21
        Me.btnFaculty.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnFaculty.Size = New System.Drawing.Size(150, 150)
        Me.btnFaculty.TabIndex = 5
        Me.btnFaculty.Text = "FACULTY"
        Me.btnFaculty.TextOffset = New System.Drawing.Point(-18, 50)
        '
        'btnStudent
        '
        Me.btnStudent.Animated = True
        Me.btnStudent.BorderRadius = 21
        Me.btnStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudent.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudent.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudent.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStudent.Image = CType(resources.GetObject("btnStudent.Image"), System.Drawing.Image)
        Me.btnStudent.ImageOffset = New System.Drawing.Point(24, -10)
        Me.btnStudent.ImageSize = New System.Drawing.Size(80, 80)
        Me.btnStudent.Location = New System.Drawing.Point(24, 212)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.ShadowDecoration.BorderRadius = 21
        Me.btnStudent.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnStudent.Size = New System.Drawing.Size(150, 150)
        Me.btnStudent.TabIndex = 4
        Me.btnStudent.Text = "STUDENT"
        Me.btnStudent.TextOffset = New System.Drawing.Point(-19, 50)
        '
        'btnGuest
        '
        Me.btnGuest.Animated = True
        Me.btnGuest.BorderRadius = 21
        Me.btnGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuest.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuest.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuest.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuest.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.White
        Me.btnGuest.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuest.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuest.Image = CType(resources.GetObject("btnGuest.Image"), System.Drawing.Image)
        Me.btnGuest.ImageOffset = New System.Drawing.Point(16, -10)
        Me.btnGuest.ImageSize = New System.Drawing.Size(75, 75)
        Me.btnGuest.Location = New System.Drawing.Point(359, 212)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.ShadowDecoration.BorderRadius = 21
        Me.btnGuest.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.btnGuest.Size = New System.Drawing.Size(150, 150)
        Me.btnGuest.TabIndex = 3
        Me.btnGuest.Text = "GUEST"
        Me.btnGuest.TextOffset = New System.Drawing.Point(-20, 50)
        '
        'frmEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CSM.My.Resources.Resources.Purple_Simple_Login_Website_Application_Desktop_Prototype__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Excolo!"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnGuest As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFaculty As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnStudent As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
