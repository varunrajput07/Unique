<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeadMIS
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
        Panel1 = New Panel()
        txtOthrPropertyAdd = New TextBox()
        Label21 = New Label()
        txtExpOfr = New TextBox()
        CboLeadStage = New ComboBox()
        CboCode = New ComboBox()
        txtBank = New ComboBox()
        txtPropertyAdd = New ComboBox()
        CboProduct = New ComboBox()
        CboSubProduct = New ComboBox()
        CboCPA = New ComboBox()
        txtProfile = New ComboBox()
        txtStage = New ComboBox()
        Label20 = New Label()
        txtMobileNo = New TextBox()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        txtRemarks = New TextBox()
        txtRef = New TextBox()
        txtSdValue = New TextBox()
        txtSize = New TextBox()
        txtPropertyNo = New TextBox()
        CmbDiscLogin = New ComboBox()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        dtpLeadDate = New DateTimePicker()
        txtCustName = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtLoanAmnt = New TextBox()
        Label1 = New Label()
        dgv = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtOthrPropertyAdd)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(txtExpOfr)
        Panel1.Controls.Add(CboLeadStage)
        Panel1.Controls.Add(CboCode)
        Panel1.Controls.Add(txtBank)
        Panel1.Controls.Add(txtPropertyAdd)
        Panel1.Controls.Add(CboProduct)
        Panel1.Controls.Add(CboSubProduct)
        Panel1.Controls.Add(CboCPA)
        Panel1.Controls.Add(txtProfile)
        Panel1.Controls.Add(txtStage)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(txtMobileNo)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(txtRemarks)
        Panel1.Controls.Add(txtRef)
        Panel1.Controls.Add(txtSdValue)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(txtPropertyNo)
        Panel1.Controls.Add(CmbDiscLogin)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dtpLeadDate)
        Panel1.Controls.Add(txtCustName)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtLoanAmnt)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1475, 358)
        Panel1.TabIndex = 0
        ' 
        ' txtOthrPropertyAdd
        ' 
        txtOthrPropertyAdd.Location = New Point(939, 131)
        txtOthrPropertyAdd.Name = "txtOthrPropertyAdd"
        txtOthrPropertyAdd.Size = New Size(185, 27)
        txtOthrPropertyAdd.TabIndex = 16
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 12F)
        Label21.Location = New Point(712, 131)
        Label21.Name = "Label21"
        Label21.Size = New Size(223, 28)
        Label21.TabIndex = 50
        Label21.Text = "OTHER PROPERTY ADD :"
        ' 
        ' txtExpOfr
        ' 
        txtExpOfr.Location = New Point(182, 209)
        txtExpOfr.Name = "txtExpOfr"
        txtExpOfr.Size = New Size(185, 27)
        txtExpOfr.TabIndex = 5
        ' 
        ' CboLeadStage
        ' 
        CboLeadStage.DropDownStyle = ComboBoxStyle.DropDownList
        CboLeadStage.FormattingEnabled = True
        CboLeadStage.Location = New Point(182, 50)
        CboLeadStage.Name = "CboLeadStage"
        CboLeadStage.Size = New Size(182, 28)
        CboLeadStage.TabIndex = 1
        ' 
        ' CboCode
        ' 
        CboCode.DropDownStyle = ComboBoxStyle.DropDownList
        CboCode.FormattingEnabled = True
        CboCode.Location = New Point(1292, 44)
        CboCode.Name = "CboCode"
        CboCode.Size = New Size(182, 28)
        CboCode.TabIndex = 16
        CboCode.Visible = False
        ' 
        ' txtBank
        ' 
        txtBank.DropDownStyle = ComboBoxStyle.DropDownList
        txtBank.FormattingEnabled = True
        txtBank.Location = New Point(525, 182)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(182, 28)
        txtBank.TabIndex = 11
        ' 
        ' txtPropertyAdd
        ' 
        txtPropertyAdd.DropDownStyle = ComboBoxStyle.DropDownList
        txtPropertyAdd.FormattingEnabled = True
        txtPropertyAdd.Location = New Point(939, 93)
        txtPropertyAdd.Name = "txtPropertyAdd"
        txtPropertyAdd.Size = New Size(182, 28)
        txtPropertyAdd.TabIndex = 15
        ' 
        ' CboProduct
        ' 
        CboProduct.DropDownStyle = ComboBoxStyle.DropDownList
        CboProduct.FormattingEnabled = True
        CboProduct.Location = New Point(525, 31)
        CboProduct.Name = "CboProduct"
        CboProduct.Size = New Size(182, 28)
        CboProduct.TabIndex = 7
        ' 
        ' CboSubProduct
        ' 
        CboSubProduct.DropDownStyle = ComboBoxStyle.DropDownList
        CboSubProduct.FormattingEnabled = True
        CboSubProduct.Items.AddRange(New Object() {""})
        CboSubProduct.Location = New Point(524, 72)
        CboSubProduct.Name = "CboSubProduct"
        CboSubProduct.Size = New Size(182, 28)
        CboSubProduct.TabIndex = 8
        ' 
        ' CboCPA
        ' 
        CboCPA.DropDownStyle = ComboBoxStyle.DropDownList
        CboCPA.FormattingEnabled = True
        CboCPA.Location = New Point(525, 109)
        CboCPA.Name = "CboCPA"
        CboCPA.Size = New Size(182, 28)
        CboCPA.TabIndex = 9
        ' 
        ' txtProfile
        ' 
        txtProfile.DropDownStyle = ComboBoxStyle.DropDownList
        txtProfile.FormattingEnabled = True
        txtProfile.Location = New Point(526, 143)
        txtProfile.Name = "txtProfile"
        txtProfile.Size = New Size(182, 28)
        txtProfile.TabIndex = 10
        ' 
        ' txtStage
        ' 
        txtStage.DropDownStyle = ComboBoxStyle.DropDownList
        txtStage.FormattingEnabled = True
        txtStage.Location = New Point(1314, 10)
        txtStage.Name = "txtStage"
        txtStage.Size = New Size(151, 28)
        txtStage.TabIndex = 6
        txtStage.Visible = False
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F)
        Label20.Location = New Point(56, 136)
        Label20.Name = "Label20"
        Label20.Size = New Size(115, 28)
        Label20.TabIndex = 47
        Label20.Text = "Mobile No :"
        ' 
        ' txtMobileNo
        ' 
        txtMobileNo.Location = New Point(182, 129)
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(191, 27)
        txtMobileNo.TabIndex = 3
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 12F)
        btnDelete.Location = New Point(582, 280)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 36)
        btnDelete.TabIndex = 22
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 12F)
        btnRefresh.Location = New Point(682, 282)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 34)
        btnRefresh.TabIndex = 23
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 12F)
        btnUpdate.Location = New Point(482, 279)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 37)
        btnUpdate.TabIndex = 21
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 12F)
        btnSave.Location = New Point(382, 279)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 37)
        btnSave.TabIndex = 20
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Location = New Point(939, 210)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(185, 27)
        txtRemarks.TabIndex = 19
        ' 
        ' txtRef
        ' 
        txtRef.Location = New Point(939, 169)
        txtRef.Name = "txtRef"
        txtRef.Size = New Size(185, 27)
        txtRef.TabIndex = 17
        ' 
        ' txtSdValue
        ' 
        txtSdValue.Location = New Point(526, 221)
        txtSdValue.Name = "txtSdValue"
        txtSdValue.Size = New Size(185, 27)
        txtSdValue.TabIndex = 12
        ' 
        ' txtSize
        ' 
        txtSize.Location = New Point(937, 17)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(185, 27)
        txtSize.TabIndex = 13
        ' 
        ' txtPropertyNo
        ' 
        txtPropertyNo.Location = New Point(939, 54)
        txtPropertyNo.Name = "txtPropertyNo"
        txtPropertyNo.Size = New Size(185, 27)
        txtPropertyNo.TabIndex = 14
        ' 
        ' CmbDiscLogin
        ' 
        CmbDiscLogin.DropDownStyle = ComboBoxStyle.DropDownList
        CmbDiscLogin.FormattingEnabled = True
        CmbDiscLogin.Location = New Point(1324, 65)
        CmbDiscLogin.Name = "CmbDiscLogin"
        CmbDiscLogin.Size = New Size(151, 28)
        CmbDiscLogin.TabIndex = 1
        CmbDiscLogin.Visible = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F)
        Label19.Location = New Point(8, 55)
        Label19.Name = "Label19"
        Label19.Size = New Size(161, 28)
        Label19.TabIndex = 27
        Label19.Text = "DISCUSS STAGE :"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F)
        Label18.Location = New Point(1207, 40)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 28)
        Label18.TabIndex = 26
        Label18.Text = "CODE :"
        Label18.Visible = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F)
        Label17.Location = New Point(801, 169)
        Label17.Name = "Label17"
        Label17.Size = New Size(122, 28)
        Label17.TabIndex = 25
        Label17.Text = "REFERENCE :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F)
        Label16.Location = New Point(721, 93)
        Label16.Name = "Label16"
        Label16.Size = New Size(202, 28)
        Label16.TabIndex = 24
        Label16.Text = "PROPERTY ADDRESS :"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F)
        Label15.Location = New Point(814, 206)
        Label15.Name = "Label15"
        Label15.Size = New Size(109, 28)
        Label15.TabIndex = 23
        Label15.Text = "REMARKS :"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F)
        Label14.Location = New Point(397, 217)
        Label14.Name = "Label14"
        Label14.Size = New Size(108, 28)
        Label14.TabIndex = 22
        Label14.Text = "SD VALUE :"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(865, 20)
        Label13.Name = "Label13"
        Label13.Size = New Size(58, 28)
        Label13.TabIndex = 21
        Label13.Text = "SIZE :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(772, 59)
        Label12.Name = "Label12"
        Label12.Size = New Size(151, 28)
        Label12.TabIndex = 20
        Label12.Text = "PROPERTY NO. :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(32, 167)
        Label11.Name = "Label11"
        Label11.Size = New Size(139, 28)
        Label11.TabIndex = 19
        Label11.Text = "Loan Amount :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(1233, 13)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 28)
        Label10.TabIndex = 18
        Label10.Text = "Stage :"
        Label10.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(415, 31)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 28)
        Label9.TabIndex = 17
        Label9.Text = "Product :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(376, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(142, 28)
        Label8.TabIndex = 16
        Label8.Text = "Sub - Product :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(440, 105)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 28)
        Label7.TabIndex = 15
        Label7.Text = "CPA :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(412, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 28)
        Label6.TabIndex = 14
        Label6.Text = "PROFILE :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(424, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 28)
        Label5.TabIndex = 13
        Label5.Text = "BANK :"
        ' 
        ' dtpLeadDate
        ' 
        dtpLeadDate.CustomFormat = ""
        dtpLeadDate.Format = DateTimePickerFormat.Short
        dtpLeadDate.Location = New Point(187, 12)
        dtpLeadDate.Name = "dtpLeadDate"
        dtpLeadDate.Size = New Size(132, 27)
        dtpLeadDate.TabIndex = 0
        dtpLeadDate.Value = New Date(2026, 8, 21, 0, 0, 0, 0)
        ' 
        ' txtCustName
        ' 
        txtCustName.Location = New Point(184, 89)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(185, 27)
        txtCustName.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(1192, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 28)
        Label4.TabIndex = 10
        Label4.Text = "Disc Login :"
        Label4.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(55, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 28)
        Label3.TabIndex = 8
        Label3.Text = "Cust Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(7, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 28)
        Label2.TabIndex = 6
        Label2.Text = "Exp. Offer To Cm :"
        ' 
        ' txtLoanAmnt
        ' 
        txtLoanAmnt.Location = New Point(182, 164)
        txtLoanAmnt.Name = "txtLoanAmnt"
        txtLoanAmnt.Size = New Size(185, 27)
        txtLoanAmnt.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(63, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 28)
        Label1.TabIndex = 4
        Label1.Text = "Lead Date :"
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Dock = DockStyle.Fill
        dgv.Location = New Point(0, 358)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(1475, 321)
        dgv.TabIndex = 1
        ' 
        ' frmLeadMIS
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        ClientSize = New Size(1475, 679)
        Controls.Add(dgv)
        Controls.Add(Panel1)
        Name = "frmLeadMIS"
        Tag = "LEAD MIS"
        Text = "LEAD MIS"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtLoanAmnt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dtpLeadDate As DateTimePicker
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CmbDiscLogin As ComboBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtSubProduct As TextBox
    Friend WithEvents txtCPA As TextBox
    Friend WithEvents txtSdValue As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtPropertyNo As TextBox
    Friend WithEvents txtLeadsStage As TextBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtRef As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtStage As ComboBox
    Friend WithEvents CboProduct As ComboBox
    Friend WithEvents CboSubProduct As ComboBox
    Friend WithEvents CboCPA As ComboBox
    Friend WithEvents txtProfile As ComboBox
    Friend WithEvents txtBank As ComboBox
    Friend WithEvents txtPropertyAdd As ComboBox
    Friend WithEvents CboLeadStage As ComboBox
    Friend WithEvents CboCode As ComboBox
    Friend WithEvents txtExpOfr As TextBox
    Friend WithEvents txtOthrPropertyAdd As TextBox
    Friend WithEvents Label21 As Label

End Class
