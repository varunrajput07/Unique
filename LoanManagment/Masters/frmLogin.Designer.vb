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

        Me.components = New System.ComponentModel.Container()

        Me.pnlMain = New Panel()
        Me.pnlLogin = New Panel()

        Me.lblCompany = New Label()
        Me.lblTitle = New Label()
        Me.lblSubtitle = New Label()

        Me.lblEmpId = New Label()
        Me.lblPassword = New Label()

        Me.txtId = New TextBox()
        Me.txtPassword = New TextBox()

        Me.btnShowPassword = New Button()
        Me.btnLogin = New Button()

        Me.lblFooter = New Label()

        Me.pnlMain.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()

        '
        ' pnlMain
        '
        Me.pnlMain.BackColor = Color.FromArgb(238, 242, 255)
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlMain.Location = New Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New Size(500, 560)
        Me.pnlMain.TabIndex = 0

        '
        ' pnlLogin
        '
        Me.pnlLogin.BackColor = Color.White
        Me.pnlLogin.BorderStyle = BorderStyle.FixedSingle
        Me.pnlLogin.Location = New Point(70, 55)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New Size(360, 445)
        Me.pnlLogin.TabIndex = 1

        '
        ' lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New Font("Segoe UI", 22.0!, FontStyle.Bold)
        Me.lblCompany.ForeColor = Color.FromArgb(79, 70, 229)
        Me.lblCompany.Location = New Point(125, 25)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New Size(112, 41)
        Me.lblCompany.TabIndex = 0

        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI Semibold", 18.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(31, 41, 55)
        Me.lblTitle.Location = New Point(112, 82)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(137, 32)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Welcome!"

        '
        ' lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.Font = New Font("Segoe UI", 9.5!, FontStyle.Regular)
        Me.lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128)
        Me.lblSubtitle.Location = New Point(92, 120)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New Size(174, 17)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Sign in to continue to UNIQUE"

        '
        ' lblEmpId
        '
        Me.lblEmpId.AutoSize = True
        Me.lblEmpId.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.lblEmpId.ForeColor = Color.FromArgb(55, 65, 81)
        Me.lblEmpId.Location = New Point(38, 164)
        Me.lblEmpId.Name = "lblEmpId"
        Me.lblEmpId.Size = New Size(81, 19)
        Me.lblEmpId.TabIndex = 3
        Me.lblEmpId.Text = "👤  Emp ID"

        '
        ' txtId
        '
        Me.txtId.BackColor = Color.FromArgb(249, 250, 251)
        Me.txtId.BorderStyle = BorderStyle.FixedSingle
        Me.txtId.Font = New Font("Segoe UI", 11.0!)
        Me.txtId.ForeColor = Color.FromArgb(31, 41, 55)
        Me.txtId.Location = New Point(38, 188)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New Size(282, 27)
        Me.txtId.TabIndex = 4

        '
        ' lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.lblPassword.ForeColor = Color.FromArgb(55, 65, 81)
        Me.lblPassword.Location = New Point(38, 231)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New Size(94, 19)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "🔑  Password"

        '
        ' txtPassword
        '
        Me.txtPassword.BackColor = Color.FromArgb(249, 250, 251)
        Me.txtPassword.BorderStyle = BorderStyle.FixedSingle
        Me.txtPassword.Font = New Font("Segoe UI", 11.0!)
        Me.txtPassword.ForeColor = Color.FromArgb(31, 41, 55)
        Me.txtPassword.Location = New Point(38, 255)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = "●"c
        Me.txtPassword.Size = New Size(240, 27)
        Me.txtPassword.TabIndex = 6

        '
        ' btnShowPassword
        '
        Me.btnShowPassword.BackColor = Color.FromArgb(249, 250, 251)
        Me.btnShowPassword.FlatAppearance.BorderSize = 1
        Me.btnShowPassword.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219)
        Me.btnShowPassword.FlatStyle = FlatStyle.Flat
        Me.btnShowPassword.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        Me.btnShowPassword.ForeColor = Color.FromArgb(75, 85, 99)
        Me.btnShowPassword.Location = New Point(278, 255)
        Me.btnShowPassword.Name = "btnShowPassword"
        Me.btnShowPassword.Size = New Size(42, 27)
        Me.btnShowPassword.TabIndex = 7
        Me.btnShowPassword.Text = "👁"
        Me.btnShowPassword.UseVisualStyleBackColor = False

        '
        ' btnLogin
        '
        Me.btnLogin.BackColor = Color.FromArgb(79, 70, 229)
        Me.btnLogin.Cursor = Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.Font = New Font("Segoe UI Semibold", 11.0!, FontStyle.Bold)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.Location = New Point(38, 310)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New Size(282, 45)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "LOGIN  →"
        Me.btnLogin.UseVisualStyleBackColor = False

        '
        ' lblFooter
        '
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Font = New Font("Segoe UI", 8.5!, FontStyle.Regular)
        Me.lblFooter.ForeColor = Color.FromArgb(156, 163, 175)
        Me.lblFooter.Location = New Point(92, 390)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New Size(176, 15)
        Me.lblFooter.TabIndex = 9
        '
        ' Add Controls
        '
        Me.pnlLogin.Controls.Add(Me.lblCompany)
        Me.pnlLogin.Controls.Add(Me.lblTitle)
        Me.pnlLogin.Controls.Add(Me.lblSubtitle)
        Me.pnlLogin.Controls.Add(Me.lblEmpId)
        Me.pnlLogin.Controls.Add(Me.txtId)
        Me.pnlLogin.Controls.Add(Me.lblPassword)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.btnShowPassword)
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.lblFooter)

        Me.pnlMain.Controls.Add(Me.pnlLogin)

        '
        ' frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(238, 242, 255)
        Me.ClientSize = New Size(500, 560)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Tag = "Login"
        Me.Text = "UNIQUE - Login"

        Me.pnlMain.ResumeLayout(False)
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlLogin As Panel

    Friend WithEvents lblCompany As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label

    Friend WithEvents lblEmpId As Label
    Friend WithEvents lblPassword As Label

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPassword As TextBox

    Friend WithEvents btnShowPassword As Button
    Friend WithEvents btnLogin As Button

    Friend WithEvents lblFooter As Label

End Class