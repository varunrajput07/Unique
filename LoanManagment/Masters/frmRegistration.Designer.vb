<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtPassword = New TextBox()
        txtMobile = New TextBox()
        btnSave = New Button()
        CmbUsrTyp = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        CmbStatus = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 0
        Label1.Text = " Full Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 2
        Label3.Text = "Mobile no. :"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(154, 33)
        txtName.Name = "txtName"
        txtName.Size = New Size(185, 27)
        txtName.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(155, 107)
        txtPassword.MaxLength = 8
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(184, 27)
        txtPassword.TabIndex = 4
        ' 
        ' txtMobile
        ' 
        txtMobile.Location = New Point(153, 67)
        txtMobile.MaxLength = 10
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(186, 27)
        txtMobile.TabIndex = 5
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(142, 271)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' CmbUsrTyp
        ' 
        CmbUsrTyp.DropDownStyle = ComboBoxStyle.DropDownList
        CmbUsrTyp.FormattingEnabled = True
        CmbUsrTyp.Items.AddRange(New Object() {"Super Admin", "Admin", "Employee"})
        CmbUsrTyp.Location = New Point(154, 151)
        CmbUsrTyp.Name = "CmbUsrTyp"
        CmbUsrTyp.Size = New Size(151, 28)
        CmbUsrTyp.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 20)
        Label4.TabIndex = 8
        Label4.Text = "User Type :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(41, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 10
        Label5.Text = "User Status :"
        ' 
        ' CmbStatus
        ' 
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.FormattingEnabled = True
        CmbStatus.Items.AddRange(New Object() {"Y", "N"})
        CmbStatus.Location = New Point(151, 191)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(73, 28)
        CmbStatus.TabIndex = 9
        ' 
        ' frmRegistration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(390, 365)
        Controls.Add(Label5)
        Controls.Add(CmbStatus)
        Controls.Add(Label4)
        Controls.Add(CmbUsrTyp)
        Controls.Add(btnSave)
        Controls.Add(txtMobile)
        Controls.Add(txtPassword)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "Registration"
        Text = "Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

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
End Class
