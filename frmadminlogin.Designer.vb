<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadminlogin
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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lnkForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lnkSignUpFrmnewlogin = New System.Windows.Forms.LinkLabel()
        Me.btnLoginNewButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pbPWEyeconClosed = New System.Windows.Forms.PictureBox()
        Me.pbPWEyeconOpen = New System.Windows.Forms.PictureBox()
        CType(Me.pbPWEyeconClosed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPWEyeconOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(38, 106)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(51, 20)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Log in"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(49, 132)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(74, 18)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Welcome Back!"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderColor = System.Drawing.Color.Black
        Me.txtEmail.BorderRadius = 15
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(23, 169)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "name@email.com"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(286, 35)
        Me.txtEmail.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(23, 220)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "●●●●●●●●●●●●●●●"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(286, 35)
        Me.txtPassword.TabIndex = 1
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(49, 156)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(28, 18)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "Email"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(49, 210)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(50, 18)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "Password"
        '
        'lnkForgetPassword
        '
        Me.lnkForgetPassword.AutoSize = True
        Me.lnkForgetPassword.BackColor = System.Drawing.Color.White
        Me.lnkForgetPassword.DisabledLinkColor = System.Drawing.Color.MediumBlue
        Me.lnkForgetPassword.LinkColor = System.Drawing.Color.DarkGray
        Me.lnkForgetPassword.Location = New System.Drawing.Point(223, 277)
        Me.lnkForgetPassword.Name = "lnkForgetPassword"
        Me.lnkForgetPassword.Size = New System.Drawing.Size(86, 13)
        Me.lnkForgetPassword.TabIndex = 3
        Me.lnkForgetPassword.TabStop = True
        Me.lnkForgetPassword.Text = "Forget Password"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(60, 382)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(112, 18)
        Me.Guna2HtmlLabel5.TabIndex = 8
        Me.Guna2HtmlLabel5.Text = "Dont have an account?"
        '
        'lnkSignUpFrmnewlogin
        '
        Me.lnkSignUpFrmnewlogin.AutoSize = True
        Me.lnkSignUpFrmnewlogin.BackColor = System.Drawing.Color.White
        Me.lnkSignUpFrmnewlogin.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkSignUpFrmnewlogin.Location = New System.Drawing.Point(178, 387)
        Me.lnkSignUpFrmnewlogin.Name = "lnkSignUpFrmnewlogin"
        Me.lnkSignUpFrmnewlogin.Size = New System.Drawing.Size(45, 13)
        Me.lnkSignUpFrmnewlogin.TabIndex = 4
        Me.lnkSignUpFrmnewlogin.TabStop = True
        Me.lnkSignUpFrmnewlogin.Text = "Sign Up"
        '
        'btnLoginNewButton
        '
        Me.btnLoginNewButton.BorderRadius = 15
        Me.btnLoginNewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLoginNewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLoginNewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoginNewButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoginNewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoginNewButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoginNewButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLoginNewButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLoginNewButton.ForeColor = System.Drawing.Color.White
        Me.btnLoginNewButton.Location = New System.Drawing.Point(23, 306)
        Me.btnLoginNewButton.Name = "btnLoginNewButton"
        Me.btnLoginNewButton.Size = New System.Drawing.Size(286, 35)
        Me.btnLoginNewButton.TabIndex = 10
        Me.btnLoginNewButton.Text = "Login"
        '
        'pbPWEyeconClosed
        '
        Me.pbPWEyeconClosed.BackColor = System.Drawing.Color.Transparent
        Me.pbPWEyeconClosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPWEyeconClosed.Image = Global.CSM.My.Resources.Resources.eyecon_closed_removebg_preview
        Me.pbPWEyeconClosed.Location = New System.Drawing.Point(259, 221)
        Me.pbPWEyeconClosed.Name = "pbPWEyeconClosed"
        Me.pbPWEyeconClosed.Size = New System.Drawing.Size(33, 33)
        Me.pbPWEyeconClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPWEyeconClosed.TabIndex = 11
        Me.pbPWEyeconClosed.TabStop = False
        '
        'pbPWEyeconOpen
        '
        Me.pbPWEyeconOpen.BackColor = System.Drawing.Color.Transparent
        Me.pbPWEyeconOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPWEyeconOpen.Image = Global.CSM.My.Resources.Resources.eyecon_open_removebg_preview
        Me.pbPWEyeconOpen.Location = New System.Drawing.Point(259, 221)
        Me.pbPWEyeconOpen.Name = "pbPWEyeconOpen"
        Me.pbPWEyeconOpen.Size = New System.Drawing.Size(33, 33)
        Me.pbPWEyeconOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPWEyeconOpen.TabIndex = 12
        Me.pbPWEyeconOpen.TabStop = False
        Me.pbPWEyeconOpen.Visible = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.CSM.My.Resources.Resources.Excolo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbPWEyeconOpen)
        Me.Controls.Add(Me.pbPWEyeconClosed)
        Me.Controls.Add(Me.btnLoginNewButton)
        Me.Controls.Add(Me.lnkSignUpFrmnewlogin)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.lnkForgetPassword)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Excolo"
        CType(Me.pbPWEyeconClosed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPWEyeconOpen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lnkForgetPassword As LinkLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lnkSignUpFrmnewlogin As LinkLabel
    Friend WithEvents btnLoginNewButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents pbPWEyeconClosed As PictureBox
    Friend WithEvents pbPWEyeconOpen As PictureBox
End Class
