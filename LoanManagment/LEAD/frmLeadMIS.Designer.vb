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
        Dim DataGridViewCellStyle1 As New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As New DataGridViewCellStyle()

        '==========================================================
        ' CREATE CONTROLS
        '==========================================================
        PanelHeader = New Panel()
        lblTitle = New Label()
        lblSubTitle = New Label()

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

        ' Legacy / Hidden
        txtStage = New ComboBox()
        CmbDiscLogin = New ComboBox()
        CboCode = New ComboBox()

        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()

        PanelButtons = New Panel()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnRefresh = New Button()

        dgv = New DataGridView()

        PanelHeader.SuspendLayout()
        PanelForm.SuspendLayout()
        PanelButtons.SuspendLayout()
        CType(dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '==========================================================
        ' FORM
        '==========================================================
        Me.AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(241, 245, 249)
        Me.ClientSize = New Size(1500, 850)
        Me.KeyPreview = True
        Me.Name = "frmLeadMIS"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Tag = "LEAD MIS"
        Me.Text = "UNIQUE - LEAD MIS"
        Me.WindowState = FormWindowState.Maximized

        '==========================================================
        ' HEADER
        '==========================================================
        PanelHeader.BackColor = Color.FromArgb(15, 23, 42)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1500, 70)
        PanelHeader.TabIndex = 0
        PanelHeader.TabStop = False

        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0!, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(25, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Text = "LEAD MIS"

        lblSubTitle.AutoSize = True
        lblSubTitle.Font = New Font("Segoe UI", 9.5!)
        lblSubTitle.ForeColor = Color.FromArgb(203, 213, 225)
        lblSubTitle.Location = New Point(28, 42)
        lblSubTitle.Name = "lblSubTitle"
        lblSubTitle.Text = "Lead Management Information System"

        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Controls.Add(lblSubTitle)

        '==========================================================
        ' FORM PANEL
        '==========================================================
        PanelForm.BackColor = Color.White
        PanelForm.Dock = DockStyle.Top
        PanelForm.Location = New Point(0, 70)
        PanelForm.Name = "PanelForm"
        PanelForm.Size = New Size(1500, 300)
        PanelForm.TabIndex = 0
        PanelForm.TabStop = False

        '----------------------------------------------------------
        ' LEFT COLUMN  (X = 25 / 150)
        '----------------------------------------------------------
        SetLabel(Label1, "Lead Date", 25, 22)
        SetLabel(Label2, "Lead Stage", 25, 67)
        SetLabel(Label3, "Customer Name", 25, 112)
        SetLabel(Label5, "Mobile No.", 25, 157)
        SetLabel(Label6, "Loan Amount", 25, 202)
        SetLabel(Label7, "Exp. Offer", 25, 247)

        dtpLeadDate.CustomFormat = "dd-MM-yyyy"
        dtpLeadDate.Font = New Font("Segoe UI", 10.0!)
        dtpLeadDate.Format = DateTimePickerFormat.Custom
        dtpLeadDate.Location = New Point(150, 18)
        dtpLeadDate.Name = "dtpLeadDate"
        dtpLeadDate.Size = New Size(240, 30)
        dtpLeadDate.TabIndex = 0

        CboLeadStage.DropDownStyle = ComboBoxStyle.DropDownList
        CboLeadStage.Font = New Font("Segoe UI", 10.0!)
        CboLeadStage.Location = New Point(150, 63)
        CboLeadStage.Name = "CboLeadStage"
        CboLeadStage.Size = New Size(240, 31)
        CboLeadStage.TabIndex = 1

        txtCustName.BorderStyle = BorderStyle.FixedSingle
        txtCustName.Font = New Font("Segoe UI", 10.0!)
        txtCustName.Location = New Point(150, 108)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(240, 30)
        txtCustName.TabIndex = 2

        txtMobileNo.BorderStyle = BorderStyle.FixedSingle
        txtMobileNo.Font = New Font("Segoe UI", 10.0!)
        txtMobileNo.Location = New Point(150, 153)
        txtMobileNo.MaxLength = 10
        txtMobileNo.Name = "txtMobileNo"
        txtMobileNo.Size = New Size(240, 30)
        txtMobileNo.TabIndex = 3

        txtLoanAmnt.BorderStyle = BorderStyle.FixedSingle
        txtLoanAmnt.Font = New Font("Segoe UI", 10.0!)
        txtLoanAmnt.Location = New Point(150, 198)
        txtLoanAmnt.Name = "txtLoanAmnt"
        txtLoanAmnt.Size = New Size(240, 30)
        txtLoanAmnt.TabIndex = 4

        txtExpOfr.BorderStyle = BorderStyle.FixedSingle
        txtExpOfr.Font = New Font("Segoe UI", 10.0!)
        txtExpOfr.Location = New Point(150, 243)
        txtExpOfr.Name = "txtExpOfr"
        txtExpOfr.Size = New Size(240, 30)
        txtExpOfr.TabIndex = 5

        '----------------------------------------------------------
        ' MIDDLE COLUMN  (X = 430 / 555)
        '----------------------------------------------------------
        SetLabel(Label8, "Product", 430, 22)
        SetLabel(Label9, "Sub Product", 430, 67)
        SetLabel(Label11, "CPA", 430, 112)
        SetLabel(Label12, "Profile", 430, 157)
        SetLabel(Label13, "Bank", 430, 202)
        SetLabel(Label14, "SD Value", 430, 247)

        CboProduct.DropDownStyle = ComboBoxStyle.DropDownList
        CboProduct.Font = New Font("Segoe UI", 10.0!)
        CboProduct.Location = New Point(555, 18)
        CboProduct.Name = "CboProduct"
        CboProduct.Size = New Size(240, 31)
        CboProduct.TabIndex = 6

        CboSubProduct.DropDownStyle = ComboBoxStyle.DropDownList
        CboSubProduct.Font = New Font("Segoe UI", 10.0!)
        CboSubProduct.Location = New Point(555, 63)
        CboSubProduct.Name = "CboSubProduct"
        CboSubProduct.Size = New Size(240, 31)
        CboSubProduct.TabIndex = 7

        CboCPA.DropDownStyle = ComboBoxStyle.DropDownList
        CboCPA.Font = New Font("Segoe UI", 10.0!)
        CboCPA.Location = New Point(555, 108)
        CboCPA.Name = "CboCPA"
        CboCPA.Size = New Size(240, 31)
        CboCPA.TabIndex = 8

        txtProfile.DropDownStyle = ComboBoxStyle.DropDownList
        txtProfile.Font = New Font("Segoe UI", 10.0!)
        txtProfile.Location = New Point(555, 153)
        txtProfile.Name = "txtProfile"
        txtProfile.Size = New Size(240, 31)
        txtProfile.TabIndex = 9

        txtBank.DropDownStyle = ComboBoxStyle.DropDownList
        txtBank.Font = New Font("Segoe UI", 10.0!)
        txtBank.Location = New Point(555, 198)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(240, 31)
        txtBank.TabIndex = 10

        txtSdValue.BorderStyle = BorderStyle.FixedSingle
        txtSdValue.Font = New Font("Segoe UI", 10.0!)
        txtSdValue.Location = New Point(555, 243)
        txtSdValue.Name = "txtSdValue"
        txtSdValue.Size = New Size(240, 30)
        txtSdValue.TabIndex = 11

        '----------------------------------------------------------
        ' RIGHT COLUMN  (X = 840 / 980)
        '----------------------------------------------------------
        SetLabel(Label15, "Size", 840, 22)
        SetLabel(Label16, "Property No.", 840, 67)
        SetLabel(Label17, "Property Address", 840, 112)
        SetLabel(Label19, "Other Property", 840, 157)
        SetLabel(Label20, "Reference", 840, 202)
        SetLabel(Label21, "Remarks", 840, 247)

        txtSize.BorderStyle = BorderStyle.FixedSingle
        txtSize.Font = New Font("Segoe UI", 10.0!)
        txtSize.Location = New Point(980, 18)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(280, 30)
        txtSize.TabIndex = 12

        txtPropertyNo.BorderStyle = BorderStyle.FixedSingle
        txtPropertyNo.Font = New Font("Segoe UI", 10.0!)
        txtPropertyNo.Location = New Point(980, 63)
        txtPropertyNo.Name = "txtPropertyNo"
        txtPropertyNo.Size = New Size(280, 30)
        txtPropertyNo.TabIndex = 13

        txtPropertyAdd.DropDownStyle = ComboBoxStyle.DropDownList
        txtPropertyAdd.Font = New Font("Segoe UI", 10.0!)
        txtPropertyAdd.Location = New Point(980, 108)
        txtPropertyAdd.Name = "txtPropertyAdd"
        txtPropertyAdd.Size = New Size(280, 31)
        txtPropertyAdd.TabIndex = 14

        txtOthrPropertyAdd.BorderStyle = BorderStyle.FixedSingle
        txtOthrPropertyAdd.Font = New Font("Segoe UI", 10.0!)
        txtOthrPropertyAdd.Location = New Point(980, 153)
        txtOthrPropertyAdd.Name = "txtOthrPropertyAdd"
        txtOthrPropertyAdd.Size = New Size(280, 30)
        txtOthrPropertyAdd.TabIndex = 15

        txtRef.BorderStyle = BorderStyle.FixedSingle
        txtRef.Font = New Font("Segoe UI", 10.0!)
        txtRef.Location = New Point(980, 198)
        txtRef.Name = "txtRef"
        txtRef.Size = New Size(280, 30)
        txtRef.TabIndex = 16

        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 10.0!)
        txtRemarks.Location = New Point(980, 243)
        txtRemarks.Name = "txtRemarks"
        txtRemarks.Size = New Size(400, 30)
        txtRemarks.TabIndex = 17

        '----------------------------------------------------------
        ' HIDDEN / LEGACY CONTROLS
        '----------------------------------------------------------
        txtStage.Visible = False
        txtStage.TabStop = False
        txtStage.Name = "txtStage"

        CmbDiscLogin.Visible = False
        CmbDiscLogin.TabStop = False
        CmbDiscLogin.Name = "CmbDiscLogin"

        CboCode.Visible = False
        CboCode.TabStop = False
        CboCode.Name = "CboCode"

        Label4.Visible = False
        Label10.Visible = False
        Label18.Visible = False

        '----------------------------------------------------------
        ' ADD CONTROLS TO FORM PANEL
        '----------------------------------------------------------
        PanelForm.Controls.AddRange(New Control() {
            dtpLeadDate, CboLeadStage, txtCustName, txtMobileNo, txtLoanAmnt, txtExpOfr,
            CboProduct, CboSubProduct, CboCPA, txtProfile, txtBank, txtSdValue,
            txtSize, txtPropertyNo, txtPropertyAdd, txtOthrPropertyAdd, txtRef, txtRemarks,
            txtStage, CmbDiscLogin, CboCode,
            Label1, Label2, Label3, Label4, Label5, Label6, Label7,
            Label8, Label9, Label10, Label11, Label12, Label13, Label14,
            Label15, Label16, Label17, Label18, Label19, Label20, Label21
        })

        '==========================================================
        ' BUTTON PANEL
        '==========================================================
        PanelButtons.BackColor = Color.FromArgb(226, 232, 240)
        PanelButtons.Dock = DockStyle.Top
        PanelButtons.Location = New Point(0, 370)
        PanelButtons.Name = "PanelButtons"
        PanelButtons.Size = New Size(1500, 65)
        PanelButtons.TabIndex = 1
        PanelButtons.TabStop = False

        btnSave.BackColor = Color.FromArgb(22, 163, 74)
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(21, 128, 61)
        btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 197, 94)
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(410, 12)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 40)
        btnSave.TabIndex = 0
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False

        btnUpdate.BackColor = Color.FromArgb(37, 99, 235)
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(29, 78, 216)
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246)
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(550, 12)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(125, 40)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False

        btnDelete.BackColor = Color.FromArgb(220, 38, 38)
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(185, 28, 28)
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 68, 68)
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(690, 12)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(125, 40)
        btnDelete.TabIndex = 2
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False

        btnRefresh.BackColor = Color.FromArgb(71, 85, 105)
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 65, 85)
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 116, 139)
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(830, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(125, 40)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False

        PanelButtons.Controls.AddRange(New Control() {btnSave, btnUpdate, btnDelete, btnRefresh})

        '==========================================================
        ' DATAGRIDVIEW
        '==========================================================
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.EnableHeadersVisualStyles = False
        dgv.Dock = DockStyle.Fill
        dgv.Location = New Point(0, 435)
        dgv.MultiSelect = False
        dgv.Name = "dgv"
        dgv.ReadOnly = False
        dgv.RowHeadersWidth = 35
        dgv.RowTemplate.Height = 32
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.TabIndex = 0

        ' Header style
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(30, 64, 175)
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 64, 175)
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgv.ColumnHeadersHeight = 42

        ' Row style
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254)
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42)
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgv.DefaultCellStyle = DataGridViewCellStyle3

        ' Alternate row
        DataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1

        '==========================================================
        ' ADD MAIN CONTROLS
        '==========================================================
        Me.Controls.Add(dgv)
        Me.Controls.Add(PanelButtons)
        Me.Controls.Add(PanelForm)
        Me.Controls.Add(PanelHeader)

        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        PanelForm.ResumeLayout(False)
        PanelForm.PerformLayout()
        PanelButtons.ResumeLayout(False)
        CType(dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    '==============================================================
    ' LABEL HELPER
    '==============================================================
    Private Sub SetLabel(ByVal lbl As Label, ByVal text As String, ByVal x As Integer, ByVal y As Integer)
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(51, 65, 85)
        lbl.Location = New Point(x, y)
        lbl.TabIndex = 0
        lbl.TabStop = False
        lbl.Text = text
    End Sub

    '==============================================================
    ' CONTROLS DECLARATIONS
    '==============================================================
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents PanelButtons As Panel

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label

    Friend WithEvents dtpLeadDate As DateTimePicker

    Friend WithEvents txtCustName As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtLoanAmnt As TextBox
    Friend WithEvents txtExpOfr As TextBox
    Friend WithEvents txtSdValue As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtPropertyNo As TextBox
    Friend WithEvents txtOthrPropertyAdd As TextBox
    Friend WithEvents txtRef As TextBox
    Friend WithEvents txtRemarks As TextBox

    Friend WithEvents CboLeadStage As ComboBox
    Friend WithEvents CboProduct As ComboBox
    Friend WithEvents CboSubProduct As ComboBox
    Friend WithEvents CboCPA As ComboBox
    Friend WithEvents txtProfile As ComboBox
    Friend WithEvents txtBank As ComboBox
    Friend WithEvents txtPropertyAdd As ComboBox

    ' Legacy
    Friend WithEvents txtStage As ComboBox
    Friend WithEvents CmbDiscLogin As ComboBox
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