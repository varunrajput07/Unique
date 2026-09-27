<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlLogin = New Panel()
        lblCompany = New Label()
        lblTitle = New Label()
        lblSubtitle = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnShowPassword = New Button()
        btnLogin = New Button()
        lblFooter = New Label()
        pnlMain.SuspendLayout()
        pnlLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(238), CByte(242), CByte(255))
        pnlMain.Controls.Add(pnlLogin)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(500, 560)
        pnlMain.TabIndex = 0
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.White
        pnlLogin.BorderStyle = BorderStyle.FixedSingle
        pnlLogin.Controls.Add(lblCompany)
        pnlLogin.Controls.Add(lblTitle)
        pnlLogin.Controls.Add(lblSubtitle)
        pnlLogin.Controls.Add(lblUsername)
        pnlLogin.Controls.Add(txtUsername)
        pnlLogin.Controls.Add(lblPassword)
        pnlLogin.Controls.Add(txtPassword)
        pnlLogin.Controls.Add(btnShowPassword)
        pnlLogin.Controls.Add(btnLogin)
        pnlLogin.Controls.Add(lblFooter)
        pnlLogin.Location = New Point(70, 55)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(360, 445)
        pnlLogin.TabIndex = 1
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblCompany.ForeColor = Color.FromArgb(CByte(79), CByte(70), CByte(229))
        lblCompany.Location = New Point(125, 25)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(0, 50)
        lblCompany.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        lblTitle.Location = New Point(112, 82)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(154, 41)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Welcome!"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.5F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(107), CByte(114), CByte(128))
        lblSubtitle.Location = New Point(92, 120)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(220, 21)
        lblSubtitle.TabIndex = 2
        lblSubtitle.Text = "Sign in to continue to UNIQUE"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lblUsername.Location = New Point(38, 164)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(130, 23)
        lblUsername.TabIndex = 3
        lblUsername.Text = "👤  Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11.0F)
        txtUsername.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtUsername.Location = New Point(38, 188)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(282, 32)
        txtUsername.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(55), CByte(65), CByte(81))
        lblPassword.Location = New Point(38, 231)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(116, 23)
        lblPassword.TabIndex = 5
        lblPassword.Text = "🔑  Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(55))
        txtPassword.Location = New Point(38, 255)
        txtPassword.MaxLength = 50
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(240, 32)
        txtPassword.TabIndex = 6
        txtPassword.Text = "12345678"
        ' 
        ' btnShowPassword
        ' 
        btnShowPassword.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        btnShowPassword.FlatAppearance.BorderColor = Color.FromArgb(CByte(209), CByte(213), CByte(219))
        btnShowPassword.FlatStyle = FlatStyle.Flat
        btnShowPassword.Font = New Font("Segoe UI", 10F)
        btnShowPassword.ForeColor = Color.FromArgb(CByte(75), CByte(85), CByte(99))
        btnShowPassword.Location = New Point(278, 255)
        btnShowPassword.Name = "btnShowPassword"
        btnShowPassword.Size = New Size(42, 27)
        btnShowPassword.TabIndex = 7
        btnShowPassword.Text = "👁"
        btnShowPassword.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(79), CByte(70), CByte(229))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(38, 310)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(282, 45)
        btnLogin.TabIndex = 8
        btnLogin.Text = "LOGIN  →"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.AutoSize = True
        lblFooter.Font = New Font("Segoe UI", 8.5F)
        lblFooter.ForeColor = Color.FromArgb(CByte(156), CByte(163), CByte(175))
        lblFooter.Location = New Point(92, 390)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(0, 20)
        lblFooter.TabIndex = 9
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(238), CByte(242), CByte(255))
        ClientSize = New Size(500, 560)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "Login"
        Text = "UNIQUE - Login"
        pnlMain.ResumeLayout(False)
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlLogin As Panel

    Friend WithEvents lblCompany As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox

    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnLogin As Button

    Friend WithEvents lblFooter As Label

End Class