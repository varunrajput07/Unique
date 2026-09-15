<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLeadMIS
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelHeader = New Panel()
        lblTitle = New Label()
        PanelForm = New Panel()
        dtpLeadDate = New DateTimePicker()
        CboLeadStage = New ComboBox()
        txtCustName = New TextBox()
        txtMobileNo = New TextBox()
        txtLoanAmnt = New TextBox()
        txtExpOfr = New TextBox()
        CboProduct = New ComboBox()
        CboSubProduct = New ComboBox()
        CboCPA = New ComboBox()
        txtProfile = New ComboBox()
        txtBank = New ComboBox()
        txtSdValue = New TextBox()
        txtSize = New TextBox()
        txtPropertyNo = New TextBox()
        txtPropertyAdd = New ComboBox()
        txtOthrPropertyAdd = New TextBox()
        txtRef = New TextBox()
        txtRemarks = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        txtStage = New ComboBox()
        CmbDiscLogin = New ComboBox()
        CboCode = New ComboBox()
        Label4 = New Label()
        Label10 = New Label()
        Label18 = New Label()
        PanelButtons = New Panel()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()
        lblSubTitle = New Label()
        dgv = New DataGridView()
        PanelHeader.SuspendLayout()
        PanelForm.SuspendLayout()
        PanelButtons.SuspendLayout()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(16, 0, 16, 0)
        PanelHeader.Size = New Size(1500, 40)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(16, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(97, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "LEAD MIS"
        ' 
        ' PanelForm
        ' 
        PanelForm.BackColor = Color.White
        PanelForm.Controls.Add(dtpLeadDate)
        PanelForm.Controls.Add(CboLeadStage)
        PanelForm.Controls.Add(txtCustName)
        PanelForm.Controls.Add(txtMobileNo)
        PanelForm.Controls.Add(txtLoanAmnt)
        PanelForm.Controls.Add(txtExpOfr)
        PanelForm.Controls.Add(CboProduct)
        PanelForm.Controls.Add(CboSubProduct)
        PanelForm.Controls.Add(CboCPA)
        PanelForm.Controls.Add(txtProfile)
        PanelForm.Controls.Add(txtBank)
        PanelForm.Controls.Add(txtSdValue)
        PanelForm.Controls.Add(txtSize)
        PanelForm.Controls.Add(txtPropertyNo)
        PanelForm.Controls.Add(txtPropertyAdd)
        PanelForm.Controls.Add(txtOthrPropertyAdd)
        PanelForm.Controls.Add(txtRef)
        PanelForm.Controls.Add(txtRemarks)
        PanelForm.Controls.Add(Label1)
        PanelForm.Controls.Add(Label2)
        PanelForm.Controls.Add(Label3)
        PanelForm.Controls.Add(Label5)
        PanelForm.Controls.Add(Label6)
        PanelForm.Controls.Add(Label7)
        PanelForm.Controls.Add(Label8)
        PanelForm.Controls.Add(Label9)
        PanelForm.Controls.Add(Label11)
        PanelForm.Controls.Add(Label12)
        PanelForm.Controls.Add(Label13)
        PanelForm.Controls.Add(Label14)
        PanelForm.Controls.Add(Label15)
        PanelForm.Controls.Add(Label16)
        PanelForm.Controls.Add(Label17)
        PanelForm.Controls.Add(Label19)
        PanelForm.Controls.Add(Label20)
        PanelForm.Controls.Add(Label21)
        PanelForm.Controls.Add(txtStage)
        PanelForm.Controls.Add(CmbDiscLogin)
        PanelForm.Controls.Add(CboCode)
        PanelForm.Controls.Add(Label4)
        PanelForm.Controls.Add(Label10)
        PanelForm.Controls.Add(Label18)
        PanelForm.Dock = DockStyle.Top
        PanelForm.Location = New Point(0, 40)
        PanelForm.Name = "PanelForm"
        PanelForm.Padding = New Padding(20)
        PanelForm.Size = New Size(1500, 287)
        PanelForm.TabIndex = 24
        ' 
        ' dtpLeadDate
        ' 
        dtpLeadDate.CustomFormat = "dd-MM-yyyy"
        dtpLeadDate.Font = New Font("Segoe UI", 10.0F)
        dtpLeadDate.Format = DateTimePickerFormat.Custom
        dtpLeadDate.Location = New Point(175, 17)
        dtpLeadDate.Name = "dtpLeadDate"
        dtpLeadDate.Size = New Size(185, 30)
        dtpLeadDate.TabIndex = 0
        ' 
        ' CboLeadStage
        ' 
        CboLeadStage.DropDownStyle = ComboBoxStyle.DropDownList
        CboLeadStage.Font = New Font("Segoe UI", 10.0F)
        CboLeadStage.Location = New Point(175, 62)
        CboLeadStage.Name = "CboLeadStage"
        CboLeadStage.Size = New Size(185, 31)
        CboLeadStage.TabIndex = 1
        ' 
        ' txtCustName
        ' 
        txtCustName.BorderStyle = BorderStyle.FixedSingle
        txtCustName.Font = New Font("Segoe UI", 10.0F)
        txtCustName.Location = New Point(175, 107)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(185, 30)
        txtCustName.TabIndex = 2
        ' 
        ' txtMobileNo
        ' 
        txtMobileNo.BorderStyle = BorderStyle.FixedSingle
        txtMobileNo.Font = New Font("Segoe UI", 10.0F)
        txtMobileNo.Location = New Point(175, 152)
        txtMobileNo.MaxLength = 10
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(185, 30)
        txtMobileNo.TabIndex = 3
        ' 
        ' txtLoanAmnt
        ' 
        txtLoanAmnt.BorderStyle = BorderStyle.FixedSingle
        txtLoanAmnt.Font = New Font("Segoe UI", 10.0F)
        txtLoanAmnt.Location = New Point(175, 197)
        txtLoanAmnt.Name = "txtLoanAmnt"
        txtLoanAmnt.Size = New Size(185, 30)
        txtLoanAmnt.TabIndex = 4
        ' 
        ' txtExpOfr
        ' 
        txtExpOfr.BorderStyle = BorderStyle.FixedSingle
        txtExpOfr.Font = New Font("Segoe UI", 10.0F)
        txtExpOfr.Location = New Point(175, 242)
        txtExpOfr.Name = "txtExpOfr"
        txtExpOfr.Size = New Size(185, 30)
        txtExpOfr.TabIndex = 5
        ' 
        ' CboProduct
        ' 
        CboProduct.DropDownStyle = ComboBoxStyle.DropDownList
        CboProduct.Font = New Font("Segoe UI", 10.0F)
        CboProduct.Location = New Point(530, 17)
        CboProduct.Name = "CboProduct"
        CboProduct.Size = New Size(185, 31)
        CboProduct.TabIndex = 6
        ' 
        ' CboSubProduct
        ' 
        CboSubProduct.DropDownStyle = ComboBoxStyle.DropDownList
        CboSubProduct.Font = New Font("Segoe UI", 10.0F)
        CboSubProduct.Location = New Point(530, 62)
        CboSubProduct.Name = "CboSubProduct"
        CboSubProduct.Size = New Size(185, 31)
        CboSubProduct.TabIndex = 7
        ' 
        ' CboCPA
        ' 
        CboCPA.DropDownStyle = ComboBoxStyle.DropDownList
        CboCPA.Font = New Font("Segoe UI", 10.0F)
        CboCPA.Location = New Point(530, 107)
        CboCPA.Name = "CboCPA"
        CboCPA.Size = New Size(185, 31)
        CboCPA.TabIndex = 8
        ' 
        ' txtProfile
        ' 
        txtProfile.DropDownStyle = ComboBoxStyle.DropDownList
        txtProfile.Font = New Font("Segoe UI", 10.0F)
        txtProfile.Location = New Point(530, 152)
        txtProfile.Name = "txtProfile"
        txtProfile.Size = New Size(185, 31)
        txtProfile.TabIndex = 9
        ' 
        ' txtBank
        ' 
        txtBank.DropDownStyle = ComboBoxStyle.DropDownList
        txtBank.Font = New Font("Segoe UI", 10.0F)
        txtBank.Location = New Point(530, 197)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(185, 31)
        txtBank.TabIndex = 10
        ' 
        ' txtSdValue
        ' 
        txtSdValue.BorderStyle = BorderStyle.FixedSingle
        txtSdValue.Font = New Font("Segoe UI", 10.0F)
        txtSdValue.Location = New Point(530, 242)
        txtSdValue.Name = "txtSdValue"
        txtSdValue.Size = New Size(185, 30)
        txtSdValue.TabIndex = 11
        ' 
        ' txtSize
        ' 
        txtSize.BorderStyle = BorderStyle.FixedSingle
        txtSize.Font = New Font("Segoe UI", 10.0F)
        txtSize.Location = New Point(940, 17)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(210, 30)
        txtSize.TabIndex = 12
        ' 
        ' txtPropertyNo
        ' 
        txtPropertyNo.BorderStyle = BorderStyle.FixedSingle
        txtPropertyNo.Font = New Font("Segoe UI", 10.0F)
        txtPropertyNo.Location = New Point(940, 62)
        txtPropertyNo.Name = "txtPropertyNo"
        txtPropertyNo.Size = New Size(210, 30)
        txtPropertyNo.TabIndex = 13
        ' 
        ' txtPropertyAdd
        ' 
        txtPropertyAdd.DropDownStyle = ComboBoxStyle.DropDownList
        txtPropertyAdd.Font = New Font("Segoe UI", 10.0F)
        txtPropertyAdd.Location = New Point(940, 107)
        txtPropertyAdd.Name = "txtPropertyAdd"
        txtPropertyAdd.Size = New Size(210, 31)
        txtPropertyAdd.TabIndex = 14
        ' 
        ' txtOthrPropertyAdd
        ' 
        txtOthrPropertyAdd.BorderStyle = BorderStyle.FixedSingle
        txtOthrPropertyAdd.Font = New Font("Segoe UI", 10.0F)
        txtOthrPropertyAdd.Location = New Point(940, 152)
        txtOthrPropertyAdd.Name = "txtOthrPropertyAdd"
        txtOthrPropertyAdd.Size = New Size(210, 30)
        txtOthrPropertyAdd.TabIndex = 15
        ' 
        ' txtRef
        ' 
        txtRef.BorderStyle = BorderStyle.FixedSingle
        txtRef.Font = New Font("Segoe UI", 10.0F)
        txtRef.Location = New Point(940, 197)
        txtRef.Name = "txtRef"
        txtRef.Size = New Size(210, 30)
        txtRef.TabIndex = 16
        ' 
        ' txtRemarks
        ' 
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 10.0F)
        txtRemarks.Location = New Point(940, 242)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(300, 30)
        txtRemarks.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 20
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 23
        ' 
        ' Label8
        ' 
        Label8.Location = New Point(0, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 23)
        Label9.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 23)
        Label11.TabIndex = 26
        ' 
        ' Label12
        ' 
        Label12.Location = New Point(0, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 23)
        Label12.TabIndex = 27
        ' 
        ' Label13
        ' 
        Label13.Location = New Point(0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 23)
        Label13.TabIndex = 28
        ' 
        ' Label14
        ' 
        Label14.Location = New Point(0, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(100, 23)
        Label14.TabIndex = 29
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(100, 23)
        Label15.TabIndex = 30
        ' 
        ' Label16
        ' 
        Label16.Location = New Point(0, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(100, 23)
        Label16.TabIndex = 31
        ' 
        ' Label17
        ' 
        Label17.Location = New Point(0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 23)
        Label17.TabIndex = 32
        ' 
        ' Label19
        ' 
        Label19.Location = New Point(0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(100, 23)
        Label19.TabIndex = 33
        ' 
        ' Label20
        ' 
        Label20.Location = New Point(0, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(100, 23)
        Label20.TabIndex = 34
        ' 
        ' Label21
        ' 
        Label21.Location = New Point(0, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(100, 23)
        Label21.TabIndex = 35
        ' 
        ' txtStage
        ' 
        txtStage.Location = New Point(0, 0)
        txtStage.Name = "txtStage"
        txtStage.Size = New Size(121, 28)
        txtStage.TabIndex = 36
        txtStage.Visible = False
        ' 
        ' CmbDiscLogin
        ' 
        CmbDiscLogin.Location = New Point(0, 0)
        CmbDiscLogin.Name = "CmbDiscLogin"
        CmbDiscLogin.Size = New Size(121, 28)
        CmbDiscLogin.TabIndex = 37
        CmbDiscLogin.Visible = False
        ' 
        ' CboCode
        ' 
        CboCode.Location = New Point(0, 0)
        CboCode.Name = "CboCode"
        CboCode.Size = New Size(121, 28)
        CboCode.TabIndex = 38
        CboCode.Visible = False
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 39
        Label4.Visible = False
        ' 
        ' Label10
        ' 
        Label10.Location = New Point(0, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 23)
        Label10.TabIndex = 40
        Label10.Visible = False
        ' 
        ' Label18
        ' 
        Label18.Location = New Point(0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(100, 23)
        Label18.TabIndex = 41
        Label18.Visible = False
        ' 
        ' PanelButtons
        ' 
        PanelButtons.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        PanelButtons.Controls.Add(btnSave)
        PanelButtons.Controls.Add(btnUpdate)
        PanelButtons.Controls.Add(btnDelete)
        PanelButtons.Controls.Add(btnRefresh)
        PanelButtons.Dock = DockStyle.Top
        PanelButtons.Location = New Point(0, 327)
        PanelButtons.Name = "PanelButtons"
        PanelButtons.Size = New Size(1500, 59)
        PanelButtons.TabIndex = 23
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(390, 13)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(110, 38)
        btnSave.TabIndex = 18
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(510, 13)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(110, 38)
        btnUpdate.TabIndex = 19
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(630, 13)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 38)
        btnDelete.TabIndex = 20
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(750, 13)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(110, 38)
        btnRefresh.TabIndex = 21
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblSubTitle
        ' 
        lblSubTitle.Location = New Point(0, 0)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Size = New Size(100, 23)
        lblSubTitle.TabIndex = 0
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgv.ColumnHeadersHeight = 38
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgv.DefaultCellStyle = DataGridViewCellStyle3
        dgv.Dock = DockStyle.Fill
        dgv.EnableHeadersVisualStyles = False
        dgv.Location = New Point(0, 386)
        dgv.MultiSelect = False
        dgv.Name = "dgv"
        dgv.RowHeadersWidth = 30
        dgv.RowTemplate.Height = 32
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.Size = New Size(1500, 464)
        dgv.TabIndex = 22
        ' 
        ' frmLeadMIS
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(1500, 850)
        Controls.Add(dgv)
        Controls.Add(PanelButtons)
        Controls.Add(PanelForm)
        Controls.Add(PanelHeader)
        KeyPreview = True
        Name = "frmLeadMIS"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "LEAD MIS"
        Text = "UNIQUE"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelForm.ResumeLayout(False)
        PanelForm.PerformLayout()
        PanelButtons.ResumeLayout(False)
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub


    '==============================================================
    ' LABEL STYLE HELPER
    '==============================================================

    Private Sub SetLabel(
        ByVal lbl As Label,
        ByVal text As String,
        ByVal x As Integer,
        ByVal y As Integer)

        lbl.AutoSize = True
        lbl.Text = text
        lbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(51, 65, 85)
        lbl.Location = New Point(x, y)

        ' Labels are NOT part of the TabIndex sequence.
        lbl.TabStop = False

    End Sub


    '==============================================================
    ' CONTROLS
    '==============================================================

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelButtons As Panel

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label

    Friend WithEvents txtLoanAmnt As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtExpOfr As TextBox

    Friend WithEvents txtSdValue As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtPropertyNo As TextBox
    Friend WithEvents txtOthrPropertyAdd As TextBox
    Friend WithEvents txtRef As TextBox
    Friend WithEvents txtRemarks As TextBox

    Friend WithEvents dtpLeadDate As DateTimePicker

    Friend WithEvents CboLeadStage As ComboBox
    Friend WithEvents CmbDiscLogin As ComboBox
    Friend WithEvents CboProduct As ComboBox
    Friend WithEvents CboSubProduct As ComboBox
    Friend WithEvents CboCPA As ComboBox
    Friend WithEvents txtProfile As ComboBox
    Friend WithEvents txtBank As ComboBox
    Friend WithEvents txtPropertyAdd As ComboBox

    Friend WithEvents txtStage As ComboBox
    Friend WithEvents CboCode As ComboBox

    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button

    Friend WithEvents dgv As DataGridView

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label

End Class