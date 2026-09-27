<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginMIS
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As New DataGridViewCellStyle()

        pnlTop = New Panel()
        lblTitle = New Label()
        lblSubTitle = New Label()

        pnlSearch = New Panel()
        lblSearchCustomer = New Label()
        txtSearchCustName = New TextBox()
        lblSearchMobile = New Label()
        txtSearchMobile = New TextBox()
        btnRefresh = New Button()
        btnClearSearch = New Button()

        pnlForm = New Panel()
        grpCustomer = New GroupBox()
        lblCustName = New Label()
        txtCustName = New TextBox()
        lblMobile = New Label()
        txtMobileNo = New TextBox()
        lblPropertyNo = New Label()
        txtPropertyNo = New TextBox()
        lblPropertyAdd = New Label()
        txtPropertyAdd = New TextBox()
        lblOtherProperty = New Label()
        txtOtherPropAdd = New TextBox()

        grpLoan = New GroupBox()
        lblLoginDate = New Label()
        dtpLeadDate = New DateTimePicker()
        lblApplicationNo = New Label()
        txtAppNo = New TextBox()
        lblLoanNo = New Label()
        txtLoanNo = New TextBox()
        lblLoanAmount = New Label()
        txtLoanAmnt = New TextBox()
        lblStage = New Label()
        txtStage = New ComboBox()
        lblBank = New Label()
        txtBank = New ComboBox()
        lblLLPs = New Label()
        txtLLPs = New TextBox()
        lblBranchSole = New Label()
        txtBranchSole = New TextBox()
        lblCode = New Label()
        CboCode = New ComboBox()
        lblCPA = New Label()
        CboCPA = New ComboBox()

        grpDatesExpense = New GroupBox()
        lblDastavage = New Label()
        dtpDasatavgeDate = New DateTimePicker()
        lblRMDate = New Label()
        dtpRMDate = New DateTimePicker()
        lblHODate = New Label()
        dtpHODate = New DateTimePicker()
        lblExpenseType = New Label()
        txtExpOfr = New ComboBox()
        lblExpenseValue = New Label()
        txtExpOfrValue = New TextBox()
        btnExpOfr = New Button()
        lblGrossTotalCaption = New Label()
        txtGrossTotal = New TextBox()

        pnlButtons = New Panel()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()

        dgv = New DataGridView()
        dgvExpense = New DataGridView()

        pnlTop.SuspendLayout()
        pnlSearch.SuspendLayout()
        pnlForm.SuspendLayout()
        grpCustomer.SuspendLayout()
        grpLoan.SuspendLayout()
        grpDatesExpense.SuspendLayout()
        pnlButtons.SuspendLayout()
        CType(dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '========== TOP HEADER ==========
        pnlTop.BackColor = Color.FromArgb(31, 78, 121)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Height = 70
        pnlTop.Controls.Add(lblTitle)
        pnlTop.Controls.Add(lblSubTitle)

        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0!, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 8)
        lblTitle.Text = "LOGIN MIS"

        lblSubTitle.AutoSize = True
        lblSubTitle.Font = New Font("Segoe UI", 9.5!)
        lblSubTitle.ForeColor = Color.WhiteSmoke
        lblSubTitle.Location = New Point(23, 42)
        lblSubTitle.Text = "Login Information Management System"

        '========== SEARCH BAR ==========
        pnlSearch.BackColor = Color.White
        pnlSearch.Dock = DockStyle.Top
        pnlSearch.Height = 60
        pnlSearch.Padding = New Padding(15, 12, 15, 12)

        lblSearchCustomer.AutoSize = True
        lblSearchCustomer.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        lblSearchCustomer.Location = New Point(18, 18)
        lblSearchCustomer.Text = "Customer :"

        txtSearchCustName.Font = New Font("Segoe UI", 10.0!)
        txtSearchCustName.Location = New Point(115, 14)
        txtSearchCustName.Size = New Size(220, 30)
        txtSearchCustName.BorderStyle = BorderStyle.FixedSingle

        lblSearchMobile.AutoSize = True
        lblSearchMobile.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        lblSearchMobile.Location = New Point(355, 18)
        lblSearchMobile.Text = "Mobile :"

        txtSearchMobile.Font = New Font("Segoe UI", 10.0!)
        txtSearchMobile.Location = New Point(430, 14)
        txtSearchMobile.Size = New Size(180, 30)
        txtSearchMobile.BorderStyle = BorderStyle.FixedSingle

        btnRefresh.Text = "Search / Refresh"
        btnRefresh.Font = New Font("Segoe UI", 9.5!, FontStyle.Bold)
        btnRefresh.BackColor = Color.FromArgb(0, 123, 255)
        btnRefresh.ForeColor = Color.White
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.Location = New Point(630, 12)
        btnRefresh.Size = New Size(140, 34)
        btnRefresh.Cursor = Cursors.Hand

        btnClearSearch.Text = "Clear"
        btnClearSearch.Font = New Font("Segoe UI", 9.5!, FontStyle.Bold)
        btnClearSearch.BackColor = Color.FromArgb(108, 117, 125)
        btnClearSearch.ForeColor = Color.White
        btnClearSearch.FlatStyle = FlatStyle.Flat
        btnClearSearch.FlatAppearance.BorderSize = 0
        btnClearSearch.Location = New Point(780, 12)
        btnClearSearch.Size = New Size(90, 34)
        btnClearSearch.Cursor = Cursors.Hand

        pnlSearch.Controls.AddRange(New Control() {lblSearchCustomer, txtSearchCustName, lblSearchMobile, txtSearchMobile, btnRefresh, btnClearSearch})

        '========== FORM PANEL ==========
        pnlForm.BackColor = Color.FromArgb(245, 247, 250)
        pnlForm.Dock = DockStyle.Top
        pnlForm.Height = 310
        pnlForm.Padding = New Padding(12)

        '----- Customer Group -----
        grpCustomer.Text = "Customer / Property"
        grpCustomer.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        grpCustomer.ForeColor = Color.FromArgb(31, 78, 121)
        grpCustomer.Location = New Point(12, 8)
        grpCustomer.Size = New Size(340, 290)

        AddLabel(lblCustName, "Customer Name", 15, 30)
        AddTextBox(txtCustName, 15, 55, 300, 28)

        AddLabel(lblMobile, "Mobile No", 15, 95)
        AddTextBox(txtMobileNo, 15, 120, 300, 28)

        AddLabel(lblPropertyNo, "Property No", 15, 160)
        AddTextBox(txtPropertyNo, 15, 185, 300, 28)

        AddLabel(lblPropertyAdd, "Property Address", 15, 225)
        AddTextBox(txtPropertyAdd, 15, 250, 300, 28)

        '----- Loan Group -----
        grpLoan.Text = "Loan / Login Details"
        grpLoan.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        grpLoan.ForeColor = Color.FromArgb(31, 78, 121)
        grpLoan.Location = New Point(365, 8)
        grpLoan.Size = New Size(480, 290)

        AddLabel(lblLoginDate, "Login Date", 15, 28)
        AddDatePicker(dtpLeadDate, 140, 25, 140)

        AddLabel(lblApplicationNo, "Application No", 15, 65)
        AddTextBox(txtAppNo, 140, 62, 160, 28)

        AddLabel(lblLoanNo, "Loan No", 15, 102)
        AddTextBox(txtLoanNo, 140, 99, 160, 28)

        AddLabel(lblLoanAmount, "Loan Amount", 15, 139)
        AddTextBox(txtLoanAmnt, 140, 136, 160, 28)

        AddLabel(lblStage, "Stage", 15, 176)
        AddComboBox(txtStage, 140, 173, 160)

        AddLabel(lblBank, "Bank", 15, 213)
        AddComboBox(txtBank, 140, 210, 160)

        AddLabel(lblCode, "Code", 320, 28)
        AddComboBox(CboCode, 320, 52, 140)

        AddLabel(lblCPA, "CPA", 320, 95)
        AddComboBox(CboCPA, 320, 119, 140)

        AddLabel(lblLLPs, "LLPS No", 320, 162)
        AddTextBox(txtLLPs, 320, 186, 140, 28)
        txtLLPs.Visible = False
        lblLLPs.Visible = False

        AddLabel(lblBranchSole, "Branch Sole", 320, 225)
        AddTextBox(txtBranchSole, 320, 249, 140, 28)
        txtBranchSole.Visible = False
        lblBranchSole.Visible = False

        '----- Dates + Expense Group -----
        grpDatesExpense.Text = "Process Dates / Expense"
        grpDatesExpense.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        grpDatesExpense.ForeColor = Color.FromArgb(31, 78, 121)
        grpDatesExpense.Location = New Point(860, 8)
        grpDatesExpense.Size = New Size(430, 290)

        AddLabel(lblDastavage, "Dastavage Date", 15, 30)
        AddDatePicker(dtpDasatavgeDate, 150, 27, 140)

        AddLabel(lblRMDate, "RM Date", 15, 70)
        AddDatePicker(dtpRMDate, 150, 67, 140)

        AddLabel(lblHODate, "HO Date", 15, 110)
        AddDatePicker(dtpHODate, 150, 107, 140)

        AddLabel(lblExpenseType, "Expense Type", 15, 155)
        AddComboBox(txtExpOfr, 150, 152, 160)

        AddLabel(lblExpenseValue, "Expense Value", 15, 195)
        AddTextBox(txtExpOfrValue, 150, 192, 120, 28)

        btnExpOfr.Text = "+"
        btnExpOfr.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        btnExpOfr.BackColor = Color.FromArgb(40, 167, 69)
        btnExpOfr.ForeColor = Color.White
        btnExpOfr.FlatStyle = FlatStyle.Flat
        btnExpOfr.FlatAppearance.BorderSize = 0
        btnExpOfr.Location = New Point(280, 190)
        btnExpOfr.Size = New Size(40, 32)
        btnExpOfr.Cursor = Cursors.Hand

        lblGrossTotalCaption.AutoSize = True
        lblGrossTotalCaption.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        lblGrossTotalCaption.ForeColor = Color.FromArgb(31, 78, 121)
        lblGrossTotalCaption.Location = New Point(15, 245)
        lblGrossTotalCaption.Text = "TOTAL EXPENSE :"

        txtGrossTotal.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        txtGrossTotal.BackColor = Color.FromArgb(230, 255, 240)
        txtGrossTotal.ForeColor = Color.FromArgb(25, 135, 84)
        txtGrossTotal.Location = New Point(170, 240)
        txtGrossTotal.Size = New Size(150, 32)
        txtGrossTotal.ReadOnly = True
        txtGrossTotal.TextAlign = HorizontalAlignment.Right
        txtGrossTotal.Text = "0.00"

        grpDatesExpense.Controls.AddRange(New Control() {
            lblDastavage, dtpDasatavgeDate, lblRMDate, dtpRMDate, lblHODate, dtpHODate,
            lblExpenseType, txtExpOfr, lblExpenseValue, txtExpOfrValue, btnExpOfr,
            lblGrossTotalCaption, txtGrossTotal})

        grpCustomer.Controls.AddRange(New Control() {
            lblCustName, txtCustName, lblMobile, txtMobileNo,
            lblPropertyNo, txtPropertyNo, lblPropertyAdd, txtPropertyAdd})

        grpLoan.Controls.AddRange(New Control() {
            lblLoginDate, dtpLeadDate, lblApplicationNo, txtAppNo,
            lblLoanNo, txtLoanNo, lblLoanAmount, txtLoanAmnt,
            lblStage, txtStage, lblBank, txtBank,
            lblCode, CboCode, lblCPA, CboCPA,
            lblLLPs, txtLLPs, lblBranchSole, txtBranchSole})

        pnlForm.Controls.AddRange(New Control() {grpCustomer, grpLoan, grpDatesExpense})

        '========== BUTTONS ==========
        pnlButtons.BackColor = Color.White
        pnlButtons.Dock = DockStyle.Top
        pnlButtons.Height = 55

        ConfigureButton(btnSave, "SAVE", Color.FromArgb(40, 167, 69), 30)
        ConfigureButton(btnUpdate, "UPDATE", Color.FromArgb(0, 123, 255), 160)
        ConfigureButton(btnDelete, "DELETE", Color.FromArgb(220, 53, 69), 290)
        ConfigureButton(btnClear, "CLEAR", Color.FromArgb(108, 117, 125), 420)

        pnlButtons.Controls.AddRange(New Control() {btnSave, btnUpdate, btnDelete, btnClear})

        '========== MAIN GRID ==========
        dgv.Dock = DockStyle.Top
        dgv.Height = 220
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.MultiSelect = False
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.RowHeadersVisible = False
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersHeight = 36
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        DataGridViewCellStyle2.BackColor = Color.FromArgb(31, 78, 121)
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2

        DataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1

        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(210, 230, 250)
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        dgv.DefaultCellStyle = DataGridViewCellStyle3

        '========== EXPENSE GRID (Readable Colors) ==========
        dgvExpense.Dock = DockStyle.Fill
        dgvExpense.BackgroundColor = Color.White
        dgvExpense.BorderStyle = BorderStyle.None
        dgvExpense.AllowUserToAddRows = False
        dgvExpense.AllowUserToDeleteRows = False
        dgvExpense.RowHeadersVisible = False
        dgvExpense.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvExpense.EnableHeadersVisualStyles = False
        dgvExpense.ColumnHeadersHeight = 36
        dgvExpense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvExpense.RowTemplate.Height = 30

        ' Header Style - Dark Blue (very readable)
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.FromArgb(31, 78, 121)          ' Dark Blue
        headerStyle.ForeColor = Color.White
        headerStyle.Font = New Font("Segoe UI", 9.5!, FontStyle.Bold)
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        headerStyle.SelectionBackColor = Color.FromArgb(31, 78, 121)
        headerStyle.SelectionForeColor = Color.White
        dgvExpense.ColumnHeadersDefaultCellStyle = headerStyle

        ' Normal Row Style - Black text on white
        Dim rowStyle As New DataGridViewCellStyle()
        rowStyle.BackColor = Color.White
        rowStyle.ForeColor = Color.FromArgb(30, 30, 30)              ' Almost black
        rowStyle.Font = New Font("Segoe UI", 9.5!)
        rowStyle.SelectionBackColor = Color.FromArgb(200, 230, 255)  ' Light Blue selection
        rowStyle.SelectionForeColor = Color.Black
        dgvExpense.DefaultCellStyle = rowStyle

        ' Alternating Row - Light Gray
        Dim altStyle As New DataGridViewCellStyle()
        altStyle.BackColor = Color.FromArgb(245, 248, 250)
        altStyle.ForeColor = Color.FromArgb(30, 30, 30)
        dgvExpense.AlternatingRowsDefaultCellStyle = altStyle

        '========== FORM ==========
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(245, 247, 250)
        Me.ClientSize = New Size(1400, 850)
        Me.Controls.Add(dgvExpense)
        Me.Controls.Add(dgv)
        Me.Controls.Add(pnlButtons)
        Me.Controls.Add(pnlForm)
        Me.Controls.Add(pnlSearch)
        Me.Controls.Add(pnlTop)
        Me.MinimumSize = New Size(1200, 750)
        Me.Name = "frmLoginMIS"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Login MIS"
        Me.WindowState = FormWindowState.Maximized
        Me.Tag = "Login MIS"

        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        pnlForm.ResumeLayout(False)
        grpCustomer.ResumeLayout(False)
        grpCustomer.PerformLayout()
        grpLoan.ResumeLayout(False)
        grpLoan.PerformLayout()
        grpDatesExpense.ResumeLayout(False)
        grpDatesExpense.PerformLayout()
        pnlButtons.ResumeLayout(False)
        CType(dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(dgvExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    '========== HELPER METHODS ==========
    Private Sub AddLabel(lbl As Label, text As String, x As Integer, y As Integer)
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(70, 70, 70)
        lbl.Location = New Point(x, y)
        lbl.Text = text
    End Sub

    Private Sub AddTextBox(txt As TextBox, x As Integer, y As Integer, width As Integer, height As Integer)
        txt.Font = New Font("Segoe UI", 9.5!)
        txt.Location = New Point(x, y)
        txt.Size = New Size(width, height)
        txt.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub AddComboBox(cbo As ComboBox, x As Integer, y As Integer, width As Integer)
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        cbo.Font = New Font("Segoe UI", 9.5!)
        cbo.FormattingEnabled = True
        cbo.Location = New Point(x, y)
        cbo.Size = New Size(width, 28)
    End Sub

    Private Sub AddDatePicker(dtp As DateTimePicker, x As Integer, y As Integer, width As Integer)
        dtp.Format = DateTimePickerFormat.Short
        dtp.Font = New Font("Segoe UI", 9.5!)
        dtp.Location = New Point(x, y)
        dtp.Size = New Size(width, 27)
    End Sub

    Private Sub ConfigureButton(btn As Button, caption As String, backColor As Color, x As Integer)
        btn.Text = caption
        btn.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        btn.BackColor = backColor
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Location = New Point(x, 10)
        btn.Size = New Size(115, 36)
        btn.Cursor = Cursors.Hand
    End Sub

    '========== CONTROLS ==========
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearchCustomer As Label
    Friend WithEvents txtSearchCustName As TextBox
    Friend WithEvents lblSearchMobile As Label
    Friend WithEvents txtSearchMobile As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClearSearch As Button
    Friend WithEvents pnlForm As Panel
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents lblPropertyNo As Label
    Friend WithEvents txtPropertyNo As TextBox
    Friend WithEvents lblPropertyAdd As Label
    Friend WithEvents txtPropertyAdd As TextBox
    Friend WithEvents lblOtherProperty As Label
    Friend WithEvents txtOtherPropAdd As TextBox
    Friend WithEvents grpLoan As GroupBox
    Friend WithEvents lblLoginDate As Label
    Friend WithEvents dtpLeadDate As DateTimePicker
    Friend WithEvents lblApplicationNo As Label
    Friend WithEvents txtAppNo As TextBox
    Friend WithEvents lblLoanNo As Label
    Friend WithEvents txtLoanNo As TextBox
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents txtLoanAmnt As TextBox
    Friend WithEvents lblStage As Label
    Friend WithEvents txtStage As ComboBox
    Friend WithEvents lblBank As Label
    Friend WithEvents txtBank As ComboBox
    Friend WithEvents lblLLPs As Label
    Friend WithEvents txtLLPs As TextBox
    Friend WithEvents lblBranchSole As Label
    Friend WithEvents txtBranchSole As TextBox
    Friend WithEvents lblCode As Label
    Friend WithEvents CboCode As ComboBox
    Friend WithEvents lblCPA As Label
    Friend WithEvents CboCPA As ComboBox
    Friend WithEvents grpDatesExpense As GroupBox
    Friend WithEvents lblDastavage As Label
    Friend WithEvents dtpDasatavgeDate As DateTimePicker
    Friend WithEvents lblRMDate As Label
    Friend WithEvents dtpRMDate As DateTimePicker
    Friend WithEvents lblHODate As Label
    Friend WithEvents dtpHODate As DateTimePicker
    Friend WithEvents lblExpenseType As Label
    Friend WithEvents txtExpOfr As ComboBox
    Friend WithEvents lblExpenseValue As Label
    Friend WithEvents txtExpOfrValue As TextBox
    Friend WithEvents btnExpOfr As Button
    Friend WithEvents lblGrossTotalCaption As Label
    Friend WithEvents txtGrossTotal As TextBox
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents dgvExpense As DataGridView
End Class