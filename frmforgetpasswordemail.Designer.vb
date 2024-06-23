<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmforgetpasswordemail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmforgetpasswordemail))
        Me.lblWelcome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmailForgetPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnConfirmEmailForgetPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Goudy Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(31, 23)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(206, 35)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "Forget Password?"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(31, 64)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(37, 18)
        Me.Guna2HtmlLabel1.TabIndex = 11
        Me.Guna2HtmlLabel1.Text = "Email"
        '
        'txtEmailForgetPassword
        '
        Me.txtEmailForgetPassword.BorderRadius = 15
        Me.txtEmailForgetPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailForgetPassword.DefaultText = ""
        Me.txtEmailForgetPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailForgetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailForgetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailForgetPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailForgetPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailForgetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmailForgetPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailForgetPassword.Location = New System.Drawing.Point(31, 85)
        Me.txtEmailForgetPassword.Name = "txtEmailForgetPassword"
        Me.txtEmailForgetPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailForgetPassword.PlaceholderText = "name@email.com"
        Me.txtEmailForgetPassword.SelectedText = ""
        Me.txtEmailForgetPassword.Size = New System.Drawing.Size(286, 35)
        Me.txtEmailForgetPassword.TabIndex = 10
        '
        'btnConfirmEmailForgetPassword
        '
        Me.btnConfirmEmailForgetPassword.BorderRadius = 15
        Me.btnConfirmEmailForgetPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmEmailForgetPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmEmailForgetPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmEmailForgetPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmEmailForgetPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnConfirmEmailForgetPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnConfirmEmailForgetPassword.ForeColor = System.Drawing.Color.White
        Me.btnConfirmEmailForgetPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.btnConfirmEmailForgetPassword.Location = New System.Drawing.Point(217, 322)
        Me.btnConfirmEmailForgetPassword.Name = "btnConfirmEmailForgetPassword"
        Me.btnConfirmEmailForgetPassword.Size = New System.Drawing.Size(100, 35)
        Me.btnConfirmEmailForgetPassword.TabIndex = 29
        Me.btnConfirmEmailForgetPassword.Text = "Confirm"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(31, 251)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(65, 18)
        Me.Guna2HtmlLabel4.TabIndex = 35
        Me.Guna2HtmlLabel4.Text = "Student-ID"
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.BorderRadius = 15
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(31, 272)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = "202X-00000"
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(286, 35)
        Me.Guna2TextBox4.TabIndex = 34
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(31, 186)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(68, 18)
        Me.Guna2HtmlLabel5.TabIndex = 33
        Me.Guna2HtmlLabel5.Text = "Last Name"
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.BorderRadius = 15
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(31, 207)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = "password"
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(286, 35)
        Me.Guna2TextBox5.TabIndex = 32
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(31, 123)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(68, 18)
        Me.Guna2HtmlLabel6.TabIndex = 31
        Me.Guna2HtmlLabel6.Text = "First Name"
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.BorderRadius = 15
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = ""
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Location = New System.Drawing.Point(31, 144)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderText = "name@email.com"
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.Size = New System.Drawing.Size(286, 35)
        Me.Guna2TextBox6.TabIndex = 30
        '
        'frmforgetpasswordemail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(347, 377)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2TextBox4)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2TextBox5)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2TextBox6)
        Me.Controls.Add(Me.btnConfirmEmailForgetPassword)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.txtEmailForgetPassword)
        Me.Controls.Add(Me.lblWelcome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmforgetpasswordemail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forget Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmailForgetPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnConfirmEmailForgetPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
End Class
