<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginMIS
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
        CboOtherPropAdd = New ComboBox()
        Label19 = New Label()
        CboPropertyNo = New ComboBox()
        Label17 = New Label()
        lstCustName = New ListBox()
        txtPropertyAdd = New ComboBox()
        Label16 = New Label()
        btnExpOfr = New Button()
        Label15 = New Label()
        txtExpOfrValue = New TextBox()
        CboCPA = New ComboBox()
        Label14 = New Label()
        txtExpOfr = New ComboBox()
        Label13 = New Label()
        Label9 = New Label()
        txtLoanAmnt = New TextBox()
        txtLLPs = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtBranchSole = New TextBox()
        txtBank = New ComboBox()
        Label6 = New Label()
        dtpHODate = New DateTimePicker()
        Label5 = New Label()
        dtpLeadDate = New DateTimePicker()
        Label4 = New Label()
        dtpRMDate = New DateTimePicker()
        Label2 = New Label()
        CboCode = New ComboBox()
        txtStage = New ComboBox()
        Label20 = New Label()
        txtMobileNo = New TextBox()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        txtAppNo = New TextBox()
        Label18 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        dtpDasatavgeDate = New DateTimePicker()
        txtCustName = New TextBox()
        Label3 = New Label()
        txtLoanNo = New TextBox()
        Label1 = New Label()
        dgv = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CboOtherPropAdd)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(CboPropertyNo)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(lstCustName)
        Panel1.Controls.Add(txtPropertyAdd)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(btnExpOfr)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(txtExpOfrValue)
        Panel1.Controls.Add(CboCPA)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(txtExpOfr)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtLoanAmnt)
        Panel1.Controls.Add(txtLLPs)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtBranchSole)
        Panel1.Controls.Add(txtBank)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(dtpHODate)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(dtpLeadDate)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(dtpRMDate)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CboCode)
        Panel1.Controls.Add(txtStage)
        Panel1.Controls.Add(Label20)
        Panel1.Controls.Add(txtMobileNo)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(txtAppNo)
        Panel1.Controls.Add(Label18)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(dtpDasatavgeDate)
        Panel1.Controls.Add(txtCustName)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtLoanNo)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1491, 340)
        Panel1.TabIndex = 1
        ' 
        ' CboOtherPropAdd
        ' 
        CboOtherPropAdd.DropDownStyle = ComboBoxStyle.DropDownList
        CboOtherPropAdd.FormattingEnabled = True
        CboOtherPropAdd.Location = New Point(164, 163)
        CboOtherPropAdd.Name = "CboOtherPropAdd"
        CboOtherPropAdd.Size = New Size(179, 28)
        CboOtherPropAdd.TabIndex = 88
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 12F)
        Label19.Location = New Point(1, 161)
        Label19.Name = "Label19"
        Label19.Size = New Size(170, 28)
        Label19.TabIndex = 89
        Label19.Text = "Ot. Property Add :"
        ' 
        ' CboPropertyNo
        ' 
        CboPropertyNo.DropDownStyle = ComboBoxStyle.DropDownList
        CboPropertyNo.FormattingEnabled = True
        CboPropertyNo.Location = New Point(161, 84)
        CboPropertyNo.Name = "CboPropertyNo"
        CboPropertyNo.Size = New Size(182, 28)
        CboPropertyNo.TabIndex = 86
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 12F)
        Label17.Location = New Point(27, 87)
        Label17.Name = "Label17"
        Label17.Size = New Size(129, 28)
        Label17.TabIndex = 87
        Label17.Text = "Property No :"
        ' 
        ' lstCustName
        ' 
        lstCustName.Font = New Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstCustName.FormattingEnabled = True
        lstCustName.ItemHeight = 22
        lstCustName.Location = New Point(351, 57)
        lstCustName.Name = "lstCustName"
        lstCustName.Size = New Size(118, 114)
        lstCustName.TabIndex = 85
        lstCustName.Visible = False
        ' 
        ' txtPropertyAdd
        ' 
        txtPropertyAdd.DropDownStyle = ComboBoxStyle.DropDownList
        txtPropertyAdd.FormattingEnabled = True
        txtPropertyAdd.Location = New Point(161, 121)
        txtPropertyAdd.Name = "txtPropertyAdd"
        txtPropertyAdd.Size = New Size(182, 28)
        txtPropertyAdd.TabIndex = 2
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 12F)
        Label16.Location = New Point(19, 124)
        Label16.Name = "Label16"
        Label16.Size = New Size(139, 28)
        Label16.TabIndex = 84
        Label16.Text = "Property Add :"
        ' 
        ' btnExpOfr
        ' 
        btnExpOfr.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExpOfr.Location = New Point(1140, 217)
        btnExpOfr.Name = "btnExpOfr"
        btnExpOfr.Size = New Size(29, 29)
        btnExpOfr.TabIndex = 18
        btnExpOfr.Text = "+"
        btnExpOfr.UseVisualStyleBackColor = True
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 12F)
        Label15.Location = New Point(809, 222)
        Label15.Name = "Label15"
        Label15.Size = New Size(157, 28)
        Label15.TabIndex = 82
        Label15.Text = "Exp. Offer Value :"
        ' 
        ' txtExpOfrValue
        ' 
        txtExpOfrValue.Location = New Point(970, 222)
        txtExpOfrValue.Name = "txtExpOfrValue"
        txtExpOfrValue.Size = New Size(154, 27)
        txtExpOfrValue.TabIndex = 17
        ' 
        ' CboCPA
        ' 
        CboCPA.DropDownStyle = ComboBoxStyle.DropDownList
        CboCPA.FormattingEnabled = True
        CboCPA.Location = New Point(594, 91)
        CboCPA.Name = "CboCPA"
        CboCPA.Size = New Size(186, 28)
        CboCPA.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 12F)
        Label14.Location = New Point(534, 94)
        Label14.Name = "Label14"
        Label14.Size = New Size(56, 28)
        Label14.TabIndex = 79
        Label14.Text = "CPA :"
        ' 
        ' txtExpOfr
        ' 
        txtExpOfr.DropDownStyle = ComboBoxStyle.DropDownList
        txtExpOfr.FormattingEnabled = True
        txtExpOfr.Location = New Point(970, 181)
        txtExpOfr.Name = "txtExpOfr"
        txtExpOfr.Size = New Size(151, 28)
        txtExpOfr.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(859, 177)
        Label13.Name = "Label13"
        Label13.Size = New Size(105, 28)
        Label13.TabIndex = 77
        Label13.Text = "Exp. Offer :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(475, 54)
        Label9.Name = "Label9"
        Label9.Size = New Size(139, 28)
        Label9.TabIndex = 76
        Label9.Text = "Loan Amount :"
        ' 
        ' txtLoanAmnt
        ' 
        txtLoanAmnt.Location = New Point(626, 54)
        txtLoanAmnt.Name = "txtLoanAmnt"
        txtLoanAmnt.Size = New Size(154, 27)
        txtLoanAmnt.TabIndex = 13
        ' 
        ' txtLLPs
        ' 
        txtLLPs.Location = New Point(970, 105)
        txtLLPs.Name = "txtLLPs"
        txtLLPs.Size = New Size(185, 27)
        txtLLPs.TabIndex = 6
        txtLLPs.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(867, 104)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 28)
        Label7.TabIndex = 73
        Label7.Text = "LLPS No. :"
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(817, 139)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 28)
        Label8.TabIndex = 72
        Label8.Text = "Branch Sole ID :"
        Label8.Visible = False
        ' 
        ' txtBranchSole
        ' 
        txtBranchSole.Location = New Point(970, 140)
        txtBranchSole.Name = "txtBranchSole"
        txtBranchSole.Size = New Size(185, 27)
        txtBranchSole.TabIndex = 7
        txtBranchSole.Visible = False
        ' 
        ' txtBank
        ' 
        txtBank.DropDownStyle = ComboBoxStyle.DropDownList
        txtBank.FormattingEnabled = True
        txtBank.Location = New Point(967, 70)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(182, 28)
        txtBank.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(890, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 28)
        Label6.TabIndex = 69
        Label6.Text = "BANK :"
        ' 
        ' dtpHODate
        ' 
        dtpHODate.CustomFormat = ""
        dtpHODate.Format = DateTimePickerFormat.Short
        dtpHODate.Location = New Point(599, 200)
        dtpHODate.Name = "dtpHODate"
        dtpHODate.Size = New Size(132, 27)
        dtpHODate.TabIndex = 10
        dtpHODate.Value = New Date(2026, 8, 21, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(494, 202)
        Label5.Name = "Label5"
        Label5.Size = New Size(96, 28)
        Label5.TabIndex = 67
        Label5.Text = "HO Date :"
        ' 
        ' dtpLeadDate
        ' 
        dtpLeadDate.CustomFormat = ""
        dtpLeadDate.Format = DateTimePickerFormat.Short
        dtpLeadDate.Location = New Point(159, 19)
        dtpLeadDate.Name = "dtpLeadDate"
        dtpLeadDate.Size = New Size(132, 27)
        dtpLeadDate.TabIndex = 66
        dtpLeadDate.Value = New Date(2026, 8, 21, 0, 0, 0, 0)
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(39, 17)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 28)
        Label4.TabIndex = 65
        Label4.Text = "Login Date :"
        ' 
        ' dtpRMDate
        ' 
        dtpRMDate.CustomFormat = ""
        dtpRMDate.Format = DateTimePickerFormat.Short
        dtpRMDate.Location = New Point(601, 162)
        dtpRMDate.Name = "dtpRMDate"
        dtpRMDate.Size = New Size(132, 27)
        dtpRMDate.TabIndex = 11
        dtpRMDate.Value = New Date(2026, 8, 21, 0, 0, 0, 0)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(493, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 28)
        Label2.TabIndex = 63
        Label2.Text = "RM Date :"
        ' 
        ' CboCode
        ' 
        CboCode.DropDownStyle = ComboBoxStyle.DropDownList
        CboCode.FormattingEnabled = True
        CboCode.Location = New Point(598, 125)
        CboCode.Name = "CboCode"
        CboCode.Size = New Size(182, 28)
        CboCode.TabIndex = 9
        ' 
        ' txtStage
        ' 
        txtStage.DropDownStyle = ComboBoxStyle.DropDownList
        txtStage.FormattingEnabled = True
        txtStage.Location = New Point(967, 31)
        txtStage.Name = "txtStage"
        txtStage.Size = New Size(153, 28)
        txtStage.TabIndex = 16
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI", 12F)
        Label20.Location = New Point(45, 200)
        Label20.Name = "Label20"
        Label20.Size = New Size(115, 28)
        Label20.TabIndex = 47
        Label20.Text = "Mobile No :"
        ' 
        ' txtMobileNo
        ' 
        txtMobileNo.Location = New Point(159, 203)
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(185, 27)
        txtMobileNo.TabIndex = 8
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 13.8F)
        btnDelete.Location = New Point(630, 282)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 38)
        btnDelete.TabIndex = 21
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Font = New Font("Segoe UI", 13.8F)
        btnRefresh.Location = New Point(730, 282)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(104, 38)
        btnRefresh.TabIndex = 22
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 13.8F)
        btnUpdate.Location = New Point(514, 282)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(110, 38)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "Edit"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 13.8F)
        btnSave.Location = New Point(413, 280)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 38)
        btnSave.TabIndex = 19
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtAppNo
        ' 
        txtAppNo.Location = New Point(162, 240)
        txtAppNo.Name = "txtAppNo"
        txtAppNo.Size = New Size(185, 27)
        txtAppNo.TabIndex = 3
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 12F)
        Label18.Location = New Point(519, 128)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 28)
        Label18.TabIndex = 26
        Label18.Text = "CODE :"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(3, 243)
        Label12.Name = "Label12"
        Label12.Size = New Size(158, 28)
        Label12.TabIndex = 20
        Label12.Text = "Application No. :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(495, 20)
        Label11.Name = "Label11"
        Label11.Size = New Size(95, 28)
        Label11.TabIndex = 19
        Label11.Text = "Loan No :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(892, 29)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 28)
        Label10.TabIndex = 18
        Label10.Text = "Stage :"
        ' 
        ' dtpDasatavgeDate
        ' 
        dtpDasatavgeDate.CustomFormat = ""
        dtpDasatavgeDate.Format = DateTimePickerFormat.Short
        dtpDasatavgeDate.Location = New Point(601, 237)
        dtpDasatavgeDate.Name = "dtpDasatavgeDate"
        dtpDasatavgeDate.Size = New Size(132, 27)
        dtpDasatavgeDate.TabIndex = 12
        dtpDasatavgeDate.Value = New Date(2026, 8, 21, 0, 0, 0, 0)
        ' 
        ' txtCustName
        ' 
        txtCustName.Location = New Point(160, 50)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(185, 27)
        txtCustName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(41, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 28)
        Label3.TabIndex = 8
        Label3.Text = "Cust Name :"
        ' 
        ' txtLoanNo
        ' 
        txtLoanNo.Location = New Point(589, 17)
        txtLoanNo.Name = "txtLoanNo"
        txtLoanNo.Size = New Size(191, 27)
        txtLoanNo.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(432, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 28)
        Label1.TabIndex = 4
        Label1.Text = "Dastavage Date :"
        ' 
        ' dgv
        ' 
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Dock = DockStyle.Fill
        dgv.Location = New Point(0, 340)
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 51
        dgv.Size = New Size(1491, 320)
        dgv.TabIndex = 2
        ' 
        ' frmLoginMIS
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        ClientSize = New Size(1491, 660)
        Controls.Add(dgv)
        Controls.Add(Panel1)
        Name = "frmLoginMIS"
        Tag = "Login MIS"
        Text = "Login MIS"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CboCode As ComboBox
    Friend WithEvents txtStage As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAppNo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpDasatavgeDate As DateTimePicker
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLoanNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dtpLeadDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpRMDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpHODate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBank As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLLPs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBranchSole As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtLoanAmnt As TextBox
    Friend WithEvents txtExpOfr As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CboCPA As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtExpOfrValue As TextBox
    Friend WithEvents btnExpOfr As Button
    Friend WithEvents txtPropertyAdd As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lstCustName As ListBox
    Friend WithEvents CboPropertyNo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CboOtherPropAdd As ComboBox
    Friend WithEvents Label19 As Label
End Class
