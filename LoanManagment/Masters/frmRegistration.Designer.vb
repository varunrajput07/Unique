<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistration
    Inherits System.Windows.Forms.Form

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
        Label1 = New Label()
        txtName = New TextBox()
        Label3 = New Label()
        txtMobile = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label4 = New Label()
        CmbUsrTyp = New ComboBox()
        Label5 = New Label()
        CmbStatus = New ComboBox()
        btnSave = New Button()
        PanelHeader = New Panel()
        lblTitle = New Label()
        PanelHeader.SuspendLayout()
        SuspendLayout()

        '=======================================================
        ' HEADER PANEL
        '=======================================================
        PanelHeader.BackColor = Color.FromArgb(15, 23, 42)
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(420, 40)
        PanelHeader.TabIndex = 11

        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 11.0!, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(16, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(140, 25)
        lblTitle.Text = "USER REGISTRATION"

        '=======================================================
        ' LABELS & CONTROLS (ORDERED BY TABINDEX)
        '=======================================================
        ' Label1 - Full Name Label
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.5!)
        Label1.Location = New Point(30, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 21)
        Label1.TabIndex = 10
        Label1.Text = "Full Name :"

        ' txtName - TabIndex 0
        txtName.Font = New Font("Segoe UI", 9.5!)
        txtName.Location = New Point(140, 62)
        txtName.Name = "txtName"
        txtName.Size = New Size(240, 29)
        txtName.TabIndex = 0

        ' Label3 - Mobile No Label
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.5!)
        Label3.Location = New Point(30, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 21)
        Label3.TabIndex = 10
        Label3.Text = "Mobile No :"

        ' txtMobile - TabIndex 1
        txtMobile.Font = New Font("Segoe UI", 9.5!)
        txtMobile.Location = New Point(140, 107)
        txtMobile.MaxLength = 10
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(240, 29)
        txtMobile.TabIndex = 1

        ' Label2 - Password Label
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.5!)
        Label2.Location = New Point(30, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 21)
        Label2.TabIndex = 10
        Label2.Text = "Password :"

        ' txtPassword - TabIndex 2
        txtPassword.Font = New Font("Segoe UI", 9.5!)
        txtPassword.Location = New Point(140, 152)
        txtPassword.MaxLength = 8
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(240, 29)
        txtPassword.TabIndex = 2

        ' Label4 - User Type Label
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.5!)
        Label4.Location = New Point(30, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 21)
        Label4.TabIndex = 10
        Label4.Text = "User Type :"

        ' CmbUsrTyp - TabIndex 3
        CmbUsrTyp.DropDownStyle = ComboBoxStyle.DropDownList
        CmbUsrTyp.Font = New Font("Segoe UI", 9.5!)
        CmbUsrTyp.FormattingEnabled = True
        CmbUsrTyp.Items.AddRange(New Object() {"Super Admin", "Admin", "Employee"})
        CmbUsrTyp.Location = New Point(140, 197)
        CmbUsrTyp.Name = "CmbUsrTyp"
        CmbUsrTyp.Size = New Size(240, 29)
        CmbUsrTyp.TabIndex = 3

        ' Label5 - User Status Label
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.5!)
        Label5.Location = New Point(30, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 21)
        Label5.TabIndex = 10
        Label5.Text = "User Status :"

        ' CmbStatus - TabIndex 4
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.Font = New Font("Segoe UI", 9.5!)
        CmbStatus.FormattingEnabled = True
        CmbStatus.Items.AddRange(New Object() {"Y", "N"})
        CmbStatus.Location = New Point(140, 242)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(100, 29)
        CmbStatus.TabIndex = 4

        ' btnSave - TabIndex 5
        btnSave.BackColor = Color.FromArgb(37, 99, 235)
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(140, 295)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 36)
        btnSave.TabIndex = 5
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False

        '=======================================================
        ' FORM PROPERTIES
        '=======================================================
        AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(241, 245, 249)
        ClientSize = New Size(420, 360)
        Controls.Add(PanelHeader)
        Controls.Add(btnSave)
        Controls.Add(CmbStatus)
        Controls.Add(Label5)
        Controls.Add(CmbUsrTyp)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(Label2)
        Controls.Add(txtMobile)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "Registration"
        Text = "Registration"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    '===========================================================
    ' CONTROLS DECLARATION
    '===========================================================
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents CmbUsrTyp As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbStatus As ComboBox
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
End Class