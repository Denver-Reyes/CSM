<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUp))
        Me.lblWelcome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtStudentId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbSecurityQuestion1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSecurityQuestion1Answer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNextPageSignUpFrm = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Group1infoandPass = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lnkReturnToPagefrmsignup = New System.Windows.Forms.LinkLabel()
        Me.lblPasswordDidntMatch = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel15 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel14 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Group2SecurityQuestion = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblSecurityQuestionHeader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lnkReturnfrmsignup = New System.Windows.Forms.LinkLabel()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2HtmlLabel22 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel23 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Group1infoandPass.SuspendLayout()
        Me.Group2SecurityQuestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Impact", 25.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(30, 78)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(250, 43)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Create an account"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderRadius = 15
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(59, 248)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(346, 35)
        Me.txtEmail.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(82, 235)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(37, 18)
        Me.Guna2HtmlLabel1.TabIndex = 9
        Me.Guna2HtmlLabel1.Text = "Email"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(72, 394)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(63, 18)
        Me.Guna2HtmlLabel2.TabIndex = 11
        Me.Guna2HtmlLabel2.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderRadius = 15
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(59, 405)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(346, 35)
        Me.txtPassword.TabIndex = 4
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(72, 445)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(111, 18)
        Me.Guna2HtmlLabel3.TabIndex = 13
        Me.Guna2HtmlLabel3.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPassword.BorderRadius = 15
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(59, 455)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPassword.PlaceholderText = "Password"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(346, 35)
        Me.txtConfirmPassword.TabIndex = 5
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(82, 289)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(65, 18)
        Me.Guna2HtmlLabel4.TabIndex = 19
        Me.Guna2HtmlLabel4.Text = "Student-ID"
        '
        'txtStudentId
        '
        Me.txtStudentId.BackColor = System.Drawing.Color.Transparent
        Me.txtStudentId.BorderRadius = 15
        Me.txtStudentId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentId.DefaultText = ""
        Me.txtStudentId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentId.Location = New System.Drawing.Point(59, 300)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentId.PlaceholderText = ""
        Me.txtStudentId.SelectedText = ""
        Me.txtStudentId.Size = New System.Drawing.Size(346, 35)
        Me.txtStudentId.TabIndex = 3
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(265, 183)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(68, 18)
        Me.Guna2HtmlLabel5.TabIndex = 17
        Me.Guna2HtmlLabel5.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.Transparent
        Me.txtLastName.BorderRadius = 15
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(235, 194)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(170, 35)
        Me.txtLastName.TabIndex = 1
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(59, 149)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(122, 22)
        Me.Guna2HtmlLabel6.TabIndex = 15
        Me.Guna2HtmlLabel6.Text = "Let's get started!"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.BorderRadius = 15
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(59, 194)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(170, 35)
        Me.txtFirstName.TabIndex = 0
        '
        'cmbSecurityQuestion1
        '
        Me.cmbSecurityQuestion1.BackColor = System.Drawing.Color.Transparent
        Me.cmbSecurityQuestion1.BorderRadius = 15
        Me.cmbSecurityQuestion1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbSecurityQuestion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecurityQuestion1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecurityQuestion1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbSecurityQuestion1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmbSecurityQuestion1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbSecurityQuestion1.ItemHeight = 30
        Me.cmbSecurityQuestion1.Items.AddRange(New Object() {"What was the name of your first pet?", "In what city were you born?", "What is your mother's maiden name?", "What was the make and model of your first car?", "What was the name of your elementary school?", "What was the name of your first teacher?", "What is the name of the street you grew up on?", "What was the name of your best friend in high school?", "What is the name of your favorite childhood book?", "What was the name of your first employer?"})
        Me.cmbSecurityQuestion1.Location = New System.Drawing.Point(58, 289)
        Me.cmbSecurityQuestion1.Name = "cmbSecurityQuestion1"
        Me.cmbSecurityQuestion1.Size = New System.Drawing.Size(344, 36)
        Me.cmbSecurityQuestion1.TabIndex = 6
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(81, 278)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(107, 18)
        Me.Guna2HtmlLabel7.TabIndex = 21
        Me.Guna2HtmlLabel7.Text = "Security Question"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(81, 365)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(154, 18)
        Me.Guna2HtmlLabel8.TabIndex = 23
        Me.Guna2HtmlLabel8.Text = "Security Question Answer "
        '
        'txtSecurityQuestion1Answer
        '
        Me.txtSecurityQuestion1Answer.BackColor = System.Drawing.Color.Transparent
        Me.txtSecurityQuestion1Answer.BorderRadius = 15
        Me.txtSecurityQuestion1Answer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSecurityQuestion1Answer.DefaultText = ""
        Me.txtSecurityQuestion1Answer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSecurityQuestion1Answer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSecurityQuestion1Answer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecurityQuestion1Answer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSecurityQuestion1Answer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecurityQuestion1Answer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSecurityQuestion1Answer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSecurityQuestion1Answer.Location = New System.Drawing.Point(58, 377)
        Me.txtSecurityQuestion1Answer.Name = "txtSecurityQuestion1Answer"
        Me.txtSecurityQuestion1Answer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSecurityQuestion1Answer.PlaceholderText = "Answer"
        Me.txtSecurityQuestion1Answer.SelectedText = ""
        Me.txtSecurityQuestion1Answer.Size = New System.Drawing.Size(344, 35)
        Me.txtSecurityQuestion1Answer.TabIndex = 7
        '
        'btnNextPageSignUpFrm
        '
        Me.btnNextPageSignUpFrm.BackColor = System.Drawing.Color.Transparent
        Me.btnNextPageSignUpFrm.BorderRadius = 15
        Me.btnNextPageSignUpFrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNextPageSignUpFrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNextPageSignUpFrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNextPageSignUpFrm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNextPageSignUpFrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNextPageSignUpFrm.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNextPageSignUpFrm.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNextPageSignUpFrm.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnNextPageSignUpFrm.ForeColor = System.Drawing.Color.White
        Me.btnNextPageSignUpFrm.Location = New System.Drawing.Point(82, 555)
        Me.btnNextPageSignUpFrm.Name = "btnNextPageSignUpFrm"
        Me.btnNextPageSignUpFrm.Size = New System.Drawing.Size(281, 40)
        Me.btnNextPageSignUpFrm.TabIndex = 33
        Me.btnNextPageSignUpFrm.Text = "Next Page"
        '
        'Group1infoandPass
        '
        Me.Group1infoandPass.BorderColor = System.Drawing.Color.Transparent
        Me.Group1infoandPass.Controls.Add(Me.lnkReturnToPagefrmsignup)
        Me.Group1infoandPass.Controls.Add(Me.lblPasswordDidntMatch)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel15)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel14)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Group1infoandPass.Controls.Add(Me.btnNextPageSignUpFrm)
        Me.Group1infoandPass.Controls.Add(Me.lblWelcome)
        Me.Group1infoandPass.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Group1infoandPass.Controls.Add(Me.txtLastName)
        Me.Group1infoandPass.Controls.Add(Me.txtFirstName)
        Me.Group1infoandPass.Controls.Add(Me.txtEmail)
        Me.Group1infoandPass.Controls.Add(Me.txtStudentId)
        Me.Group1infoandPass.Controls.Add(Me.txtConfirmPassword)
        Me.Group1infoandPass.Controls.Add(Me.txtPassword)
        Me.Group1infoandPass.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Group1infoandPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Group1infoandPass.ForeColor = System.Drawing.Color.White
        Me.Group1infoandPass.Location = New System.Drawing.Point(78, 0)
        Me.Group1infoandPass.Name = "Group1infoandPass"
        Me.Group1infoandPass.Size = New System.Drawing.Size(461, 683)
        Me.Group1infoandPass.TabIndex = 34
        '
        'lnkReturnToPagefrmsignup
        '
        Me.lnkReturnToPagefrmsignup.AutoSize = True
        Me.lnkReturnToPagefrmsignup.BackColor = System.Drawing.Color.Transparent
        Me.lnkReturnToPagefrmsignup.LinkColor = System.Drawing.Color.DimGray
        Me.lnkReturnToPagefrmsignup.Location = New System.Drawing.Point(184, 617)
        Me.lnkReturnToPagefrmsignup.Name = "lnkReturnToPagefrmsignup"
        Me.lnkReturnToPagefrmsignup.Size = New System.Drawing.Size(32, 15)
        Me.lnkReturnToPagefrmsignup.TabIndex = 37
        Me.lnkReturnToPagefrmsignup.TabStop = True
        Me.lnkReturnToPagefrmsignup.Text = "Back"
        '
        'lblPasswordDidntMatch
        '
        Me.lblPasswordDidntMatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordDidntMatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPasswordDidntMatch.ForeColor = System.Drawing.Color.Red
        Me.lblPasswordDidntMatch.Location = New System.Drawing.Point(156, 496)
        Me.lblPasswordDidntMatch.Name = "lblPasswordDidntMatch"
        Me.lblPasswordDidntMatch.Size = New System.Drawing.Size(137, 18)
        Me.lblPasswordDidntMatch.TabIndex = 36
        Me.lblPasswordDidntMatch.Text = "Password didn't match"
        Me.lblPasswordDidntMatch.Visible = False
        '
        'Guna2HtmlLabel15
        '
        Me.Guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Guna2HtmlLabel15.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel15.Location = New System.Drawing.Point(59, 359)
        Me.Guna2HtmlLabel15.Name = "Guna2HtmlLabel15"
        Me.Guna2HtmlLabel15.Size = New System.Drawing.Size(159, 22)
        Me.Guna2HtmlLabel15.TabIndex = 35
        Me.Guna2HtmlLabel15.Text = "Protect Your Account!"
        '
        'Guna2HtmlLabel14
        '
        Me.Guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Guna2HtmlLabel14.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel14.Location = New System.Drawing.Point(82, 183)
        Me.Guna2HtmlLabel14.Name = "Guna2HtmlLabel14"
        Me.Guna2HtmlLabel14.Size = New System.Drawing.Size(68, 18)
        Me.Guna2HtmlLabel14.TabIndex = 34
        Me.Guna2HtmlLabel14.Text = "First Name"
        '
        'Group2SecurityQuestion
        '
        Me.Group2SecurityQuestion.BorderColor = System.Drawing.Color.Transparent
        Me.Group2SecurityQuestion.Controls.Add(Me.lblSecurityQuestionHeader)
        Me.Group2SecurityQuestion.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Group2SecurityQuestion.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Group2SecurityQuestion.Controls.Add(Me.lnkReturnfrmsignup)
        Me.Group2SecurityQuestion.Controls.Add(Me.btnSignUp)
        Me.Group2SecurityQuestion.Controls.Add(Me.Guna2HtmlLabel22)
        Me.Group2SecurityQuestion.Controls.Add(Me.Guna2HtmlLabel23)
        Me.Group2SecurityQuestion.Controls.Add(Me.cmbSecurityQuestion1)
        Me.Group2SecurityQuestion.Controls.Add(Me.txtSecurityQuestion1Answer)
        Me.Group2SecurityQuestion.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Group2SecurityQuestion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Group2SecurityQuestion.ForeColor = System.Drawing.Color.White
        Me.Group2SecurityQuestion.Location = New System.Drawing.Point(718, 0)
        Me.Group2SecurityQuestion.Name = "Group2SecurityQuestion"
        Me.Group2SecurityQuestion.Size = New System.Drawing.Size(461, 683)
        Me.Group2SecurityQuestion.TabIndex = 38
        Me.Group2SecurityQuestion.Visible = False
        '
        'lblSecurityQuestionHeader
        '
        Me.lblSecurityQuestionHeader.AutoSize = False
        Me.lblSecurityQuestionHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblSecurityQuestionHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblSecurityQuestionHeader.ForeColor = System.Drawing.Color.Gray
        Me.lblSecurityQuestionHeader.Location = New System.Drawing.Point(58, 223)
        Me.lblSecurityQuestionHeader.Name = "lblSecurityQuestionHeader"
        Me.lblSecurityQuestionHeader.Size = New System.Drawing.Size(344, 46)
        Me.lblSecurityQuestionHeader.TabIndex = 38
        Me.lblSecurityQuestionHeader.Text = "Security questions are here to help! They verify your identity if you forget your" &
    " password or notice unusual activity on your account. "
        '
        'lnkReturnfrmsignup
        '
        Me.lnkReturnfrmsignup.AutoSize = True
        Me.lnkReturnfrmsignup.BackColor = System.Drawing.Color.Transparent
        Me.lnkReturnfrmsignup.LinkColor = System.Drawing.Color.DimGray
        Me.lnkReturnfrmsignup.Location = New System.Drawing.Point(203, 617)
        Me.lnkReturnfrmsignup.Name = "lnkReturnfrmsignup"
        Me.lnkReturnfrmsignup.Size = New System.Drawing.Size(32, 15)
        Me.lnkReturnfrmsignup.TabIndex = 37
        Me.lnkReturnfrmsignup.TabStop = True
        Me.lnkReturnfrmsignup.Text = "Back"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BorderRadius = 15
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignUp.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.btnSignUp.ForeColor = System.Drawing.Color.White
        Me.btnSignUp.Location = New System.Drawing.Point(82, 555)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(281, 40)
        Me.btnSignUp.TabIndex = 33
        Me.btnSignUp.Text = "Sign Up"
        '
        'Guna2HtmlLabel22
        '
        Me.Guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel22.Font = New System.Drawing.Font("Impact", 25.0!)
        Me.Guna2HtmlLabel22.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel22.Location = New System.Drawing.Point(30, 78)
        Me.Guna2HtmlLabel22.Name = "Guna2HtmlLabel22"
        Me.Guna2HtmlLabel22.Size = New System.Drawing.Size(250, 43)
        Me.Guna2HtmlLabel22.TabIndex = 4
        Me.Guna2HtmlLabel22.Text = "Create an account"
        '
        'Guna2HtmlLabel23
        '
        Me.Guna2HtmlLabel23.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Guna2HtmlLabel23.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel23.Location = New System.Drawing.Point(58, 195)
        Me.Guna2HtmlLabel23.Name = "Guna2HtmlLabel23"
        Me.Guna2HtmlLabel23.Size = New System.Drawing.Size(153, 22)
        Me.Guna2HtmlLabel23.TabIndex = 15
        Me.Guna2HtmlLabel23.Text = "Secure your account!"
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1449, 681)
        Me.Controls.Add(Me.Group2SecurityQuestion)
        Me.Controls.Add(Me.Group1infoandPass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.Group1infoandPass.ResumeLayout(False)
        Me.Group1infoandPass.PerformLayout()
        Me.Group2SecurityQuestion.ResumeLayout(False)
        Me.Group2SecurityQuestion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtStudentId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbSecurityQuestion1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtSecurityQuestion1Answer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNextPageSignUpFrm As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Group1infoandPass As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel14 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel15 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblPasswordDidntMatch As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lnkReturnToPagefrmsignup As LinkLabel
    Friend WithEvents Group2SecurityQuestion As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lnkReturnfrmsignup As LinkLabel
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel22 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel23 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSecurityQuestionHeader As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
