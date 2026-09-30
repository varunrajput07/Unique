<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpense
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
        PanelHeader = New Panel()
        lblTitle = New Label()
        PanelSearch = New Panel()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnNewSearch = New Button()
        dgvCustomerSearch = New DataGridView()
        pnlInfo = New Panel()
        lblInfoName = New Label()
        lblInfoMobile = New Label()
        lblInfoLoan = New Label()
        lblInfoProduct = New Label()
        tabExpense = New TabControl()
        tabPF = New TabPage()
        tblPF = New TableLayoutPanel()
        lblPFAmount = New Label()
        txtPFAmount = New TextBox()
        lblPFDate = New Label()
        dtpPFDate = New DateTimePicker()
        lblPFPaidBy = New Label()
        cmbPFPaidBy = New ComboBox()
        lblPFMode = New Label()
        cmbPFMode = New ComboBox()
        tabRM = New TabPage()
        tblRM = New TableLayoutPanel()
        lblRMAmount = New Label()
        txtRMAmount = New TextBox()
        lblRMDate = New Label()
        dtpRMDate = New DateTimePicker()
        lblRMPaidBy = New Label()
        cmbRMPaidBy = New ComboBox()
        lblRMMode = New Label()
        cmbRMMode = New ComboBox()
        tabFiRcuPd = New TabPage()
        tblFiRcuPd = New TableLayoutPanel()
        lblFiRcuPdType = New Label()
        cmbFiRcuPdType = New ComboBox()
        lblFiRcuPdAmount = New Label()
        txtFiRcuPdAmount = New TextBox()
        lblFiRcuPdDate = New Label()
        dtpFiRcuPdDate = New DateTimePicker()
        lblFiRcuPdPaidBy = New Label()
        cmbFiRcuPdPaidBy = New ComboBox()
        lblFiRcuPdMode = New Label()
        cmbFiRcuPdMode = New ComboBox()
        tabStaff = New TabPage()
        tblStaff = New TableLayoutPanel()
        lblStaffAmount = New Label()
        txtStaffAmount = New TextBox()
        lblStaffDate = New Label()
        dtpStaffDate = New DateTimePicker()
        lblStaffStatus = New Label()
        cmbStaffStatus = New ComboBox()
        lblStaffPaidBy = New Label()
        cmbStaffPaidBy = New ComboBox()
        lblStaffMode = New Label()
        cmbStaffMode = New ComboBox()
        tabBuilder = New TabPage()
        tblBuilder = New TableLayoutPanel()
        lblBuilderAmount = New Label()
        txtBuilderAmount = New TextBox()
        lblBuilderDate = New Label()
        dtpBuilderDate = New DateTimePicker()
        lblBuilderStatus = New Label()
        cmbBuilderStatus = New ComboBox()
        lblBuilderPaidBy = New Label()
        cmbBuilderPaidBy = New ComboBox()
        lblBuilderMode = New Label()
        cmbBuilderMode = New ComboBox()
        PanelActions = New Panel()
        btnSave = New Button()
        PanelHeader.SuspendLayout()
        PanelSearch.SuspendLayout()
        CType(dgvCustomerSearch, ComponentModel.ISupportInitialize).BeginInit()
        pnlInfo.SuspendLayout()
        tabExpense.SuspendLayout()
        tabPF.SuspendLayout()
        tblPF.SuspendLayout()
        tabRM.SuspendLayout()
        tblRM.SuspendLayout()
        tabFiRcuPd.SuspendLayout()
        tblFiRcuPd.SuspendLayout()
        tabStaff.SuspendLayout()
        tblStaff.SuspendLayout()
        tabBuilder.SuspendLayout()
        tblBuilder.SuspendLayout()
        PanelActions.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(20, 0, 20, 0)
        PanelHeader.Size = New Size(1100, 55)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1060, 55)
        lblTitle.TabIndex = 0
        lblTitle.Text = "EXPENSE MANAGEMENT"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelSearch
        ' 
        PanelSearch.BackColor = Color.White
        PanelSearch.Controls.Add(txtSearch)
        PanelSearch.Controls.Add(btnSearch)
        PanelSearch.Controls.Add(btnNewSearch)
        PanelSearch.Controls.Add(dgvCustomerSearch)
        PanelSearch.Dock = DockStyle.Top
        PanelSearch.Location = New Point(0, 55)
        PanelSearch.Name = "PanelSearch"
        PanelSearch.Padding = New Padding(20, 12, 20, 5)
        PanelSearch.Size = New Size(1100, 200)
        PanelSearch.TabIndex = 1
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.5F)
        txtSearch.Location = New Point(20, 15)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by Customer Name, Mobile No, or Lead ID"
        txtSearch.Size = New Size(700, 29)
        txtSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(730, 13)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 31)
        btnSearch.TabIndex = 1
        btnSearch.Text = "🔍 Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnNewSearch
        ' 
        btnNewSearch.BackColor = Color.White
        btnNewSearch.Cursor = Cursors.Hand
        btnNewSearch.FlatAppearance.BorderColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnNewSearch.FlatStyle = FlatStyle.Flat
        btnNewSearch.Font = New Font("Segoe UI", 9.5F)
        btnNewSearch.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnNewSearch.Location = New Point(840, 13)
        btnNewSearch.Name = "btnNewSearch"
        btnNewSearch.Size = New Size(110, 31)
        btnNewSearch.TabIndex = 2
        btnNewSearch.Text = "New Search"
        btnNewSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvCustomerSearch
        ' 
        dgvCustomerSearch.AllowUserToAddRows = False
        dgvCustomerSearch.AllowUserToDeleteRows = False
        dgvCustomerSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomerSearch.BackgroundColor = Color.White
        dgvCustomerSearch.ColumnHeadersHeight = 29
        dgvCustomerSearch.Location = New Point(20, 50)
        dgvCustomerSearch.MultiSelect = False
        dgvCustomerSearch.Name = "dgvCustomerSearch"
        dgvCustomerSearch.ReadOnly = True
        dgvCustomerSearch.RowHeadersVisible = False
        dgvCustomerSearch.RowHeadersWidth = 51
        dgvCustomerSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomerSearch.Size = New Size(1060, 140)
        dgvCustomerSearch.TabIndex = 3
        dgvCustomerSearch.Visible = False
        ' 
        ' pnlInfo
        ' 
        pnlInfo.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        pnlInfo.Controls.Add(lblInfoName)
        pnlInfo.Controls.Add(lblInfoMobile)
        pnlInfo.Controls.Add(lblInfoLoan)
        pnlInfo.Controls.Add(lblInfoProduct)
        pnlInfo.Dock = DockStyle.Top
        pnlInfo.Location = New Point(0, 255)
        pnlInfo.Name = "pnlInfo"
        pnlInfo.Padding = New Padding(20, 8, 20, 8)
        pnlInfo.Size = New Size(1100, 40)
        pnlInfo.TabIndex = 2
        ' 
        ' lblInfoName
        ' 
        lblInfoName.AutoSize = True
        lblInfoName.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblInfoName.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblInfoName.Location = New Point(20, 10)
        lblInfoName.Name = "lblInfoName"
        lblInfoName.Size = New Size(86, 21)
        lblInfoName.TabIndex = 0
        lblInfoName.Text = "Customer:"
        ' 
        ' lblInfoMobile
        ' 
        lblInfoMobile.AutoSize = True
        lblInfoMobile.Font = New Font("Segoe UI", 9.5F)
        lblInfoMobile.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblInfoMobile.Location = New Point(280, 10)
        lblInfoMobile.Name = "lblInfoMobile"
        lblInfoMobile.Size = New Size(61, 21)
        lblInfoMobile.TabIndex = 1
        lblInfoMobile.Text = "Mobile:"
        ' 
        ' lblInfoLoan
        ' 
        lblInfoLoan.AutoSize = True
        lblInfoLoan.Font = New Font("Segoe UI", 9.5F)
        lblInfoLoan.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblInfoLoan.Location = New Point(520, 10)
        lblInfoLoan.Name = "lblInfoLoan"
        lblInfoLoan.Size = New Size(107, 21)
        lblInfoLoan.TabIndex = 2
        lblInfoLoan.Text = "Loan Amount:"
        ' 
        ' lblInfoProduct
        ' 
        lblInfoProduct.AutoSize = True
        lblInfoProduct.Font = New Font("Segoe UI", 9.5F)
        lblInfoProduct.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblInfoProduct.Location = New Point(780, 10)
        lblInfoProduct.Name = "lblInfoProduct"
        lblInfoProduct.Size = New Size(67, 21)
        lblInfoProduct.TabIndex = 3
        lblInfoProduct.Text = "Product:"
        ' 
        ' tabExpense
        ' 
        tabExpense.Controls.Add(tabPF)
        tabExpense.Controls.Add(tabRM)
        tabExpense.Controls.Add(tabFiRcuPd)
        tabExpense.Controls.Add(tabStaff)
        tabExpense.Controls.Add(tabBuilder)
        tabExpense.Dock = DockStyle.Fill
        tabExpense.Font = New Font("Segoe UI", 9.5F)
        tabExpense.Location = New Point(0, 295)
        tabExpense.Name = "tabExpense"
        tabExpense.SelectedIndex = 0
        tabExpense.Size = New Size(1100, 350)
        tabExpense.TabIndex = 3
        ' 
        ' tabPF
        ' 
        tabPF.BackColor = Color.White
        tabPF.Controls.Add(tblPF)
        tabPF.Location = New Point(4, 30)
        tabPF.Name = "tabPF"
        tabPF.Padding = New Padding(20)
        tabPF.Size = New Size(1092, 316)
        tabPF.TabIndex = 0
        tabPF.Text = "PF / Agreement / Other"
        ' 
        ' tblPF
        ' 
        tblPF.ColumnCount = 4
        tblPF.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblPF.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblPF.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblPF.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblPF.Controls.Add(lblPFAmount, 0, 0)
        tblPF.Controls.Add(txtPFAmount, 1, 0)
        tblPF.Controls.Add(lblPFDate, 2, 0)
        tblPF.Controls.Add(dtpPFDate, 3, 0)
        tblPF.Controls.Add(lblPFPaidBy, 0, 1)
        tblPF.Controls.Add(cmbPFPaidBy, 1, 1)
        tblPF.Controls.Add(lblPFMode, 2, 1)
        tblPF.Controls.Add(cmbPFMode, 3, 1)
        tblPF.Dock = DockStyle.Fill
        tblPF.Location = New Point(20, 20)
        tblPF.Name = "tblPF"
        tblPF.RowCount = 2
        tblPF.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tblPF.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tblPF.Size = New Size(1052, 276)
        tblPF.TabIndex = 0
        ' 
        ' lblPFAmount
        ' 
        lblPFAmount.Location = New Point(3, 0)
        lblPFAmount.Name = "lblPFAmount"
        lblPFAmount.Size = New Size(100, 23)
        lblPFAmount.TabIndex = 0
        ' 
        ' txtPFAmount
        ' 
        txtPFAmount.Location = New Point(213, 3)
        txtPFAmount.Name = "txtPFAmount"
        txtPFAmount.Size = New Size(100, 29)
        txtPFAmount.TabIndex = 1
        ' 
        ' lblPFDate
        ' 
        lblPFDate.Location = New Point(528, 0)
        lblPFDate.Name = "lblPFDate"
        lblPFDate.Size = New Size(100, 23)
        lblPFDate.TabIndex = 2
        ' 
        ' dtpPFDate
        ' 
        dtpPFDate.Location = New Point(738, 3)
        dtpPFDate.Name = "dtpPFDate"
        dtpPFDate.Size = New Size(200, 29)
        dtpPFDate.TabIndex = 3
        ' 
        ' lblPFPaidBy
        ' 
        lblPFPaidBy.Location = New Point(3, 138)
        lblPFPaidBy.Name = "lblPFPaidBy"
        lblPFPaidBy.Size = New Size(100, 23)
        lblPFPaidBy.TabIndex = 4
        ' 
        ' cmbPFPaidBy
        ' 
        cmbPFPaidBy.Location = New Point(213, 141)
        cmbPFPaidBy.Name = "cmbPFPaidBy"
        cmbPFPaidBy.Size = New Size(121, 29)
        cmbPFPaidBy.TabIndex = 5
        ' 
        ' lblPFMode
        ' 
        lblPFMode.Location = New Point(528, 138)
        lblPFMode.Name = "lblPFMode"
        lblPFMode.Size = New Size(100, 23)
        lblPFMode.TabIndex = 6
        ' 
        ' cmbPFMode
        ' 
        cmbPFMode.Location = New Point(738, 141)
        cmbPFMode.Name = "cmbPFMode"
        cmbPFMode.Size = New Size(121, 29)
        cmbPFMode.TabIndex = 7
        ' 
        ' tabRM
        ' 
        tabRM.BackColor = Color.White
        tabRM.Controls.Add(tblRM)
        tabRM.Location = New Point(4, 30)
        tabRM.Name = "tabRM"
        tabRM.Padding = New Padding(20)
        tabRM.Size = New Size(1092, 216)
        tabRM.TabIndex = 1
        tabRM.Text = "RM"
        ' 
        ' tblRM
        ' 
        tblRM.ColumnCount = 4
        tblRM.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblRM.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblRM.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblRM.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblRM.Controls.Add(lblRMAmount, 0, 0)
        tblRM.Controls.Add(txtRMAmount, 1, 0)
        tblRM.Controls.Add(lblRMDate, 2, 0)
        tblRM.Controls.Add(dtpRMDate, 3, 0)
        tblRM.Controls.Add(lblRMPaidBy, 0, 1)
        tblRM.Controls.Add(cmbRMPaidBy, 1, 1)
        tblRM.Controls.Add(lblRMMode, 2, 1)
        tblRM.Controls.Add(cmbRMMode, 3, 1)
        tblRM.Dock = DockStyle.Fill
        tblRM.Location = New Point(20, 20)
        tblRM.Name = "tblRM"
        tblRM.RowCount = 2
        tblRM.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tblRM.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tblRM.Size = New Size(1052, 176)
        tblRM.TabIndex = 0
        ' 
        ' lblRMAmount
        ' 
        lblRMAmount.Location = New Point(3, 0)
        lblRMAmount.Name = "lblRMAmount"
        lblRMAmount.Size = New Size(100, 23)
        lblRMAmount.TabIndex = 0
        ' 
        ' txtRMAmount
        ' 
        txtRMAmount.Location = New Point(213, 3)
        txtRMAmount.Name = "txtRMAmount"
        txtRMAmount.Size = New Size(100, 29)
        txtRMAmount.TabIndex = 1
        ' 
        ' lblRMDate
        ' 
        lblRMDate.Location = New Point(528, 0)
        lblRMDate.Name = "lblRMDate"
        lblRMDate.Size = New Size(100, 23)
        lblRMDate.TabIndex = 2
        ' 
        ' dtpRMDate
        ' 
        dtpRMDate.Location = New Point(738, 3)
        dtpRMDate.Name = "dtpRMDate"
        dtpRMDate.Size = New Size(200, 29)
        dtpRMDate.TabIndex = 3
        ' 
        ' lblRMPaidBy
        ' 
        lblRMPaidBy.Location = New Point(3, 88)
        lblRMPaidBy.Name = "lblRMPaidBy"
        lblRMPaidBy.Size = New Size(100, 23)
        lblRMPaidBy.TabIndex = 4
        ' 
        ' cmbRMPaidBy
        ' 
        cmbRMPaidBy.Location = New Point(213, 91)
        cmbRMPaidBy.Name = "cmbRMPaidBy"
        cmbRMPaidBy.Size = New Size(121, 29)
        cmbRMPaidBy.TabIndex = 5
        ' 
        ' lblRMMode
        ' 
        lblRMMode.Location = New Point(528, 88)
        lblRMMode.Name = "lblRMMode"
        lblRMMode.Size = New Size(100, 23)
        lblRMMode.TabIndex = 6
        ' 
        ' cmbRMMode
        ' 
        cmbRMMode.Location = New Point(738, 91)
        cmbRMMode.Name = "cmbRMMode"
        cmbRMMode.Size = New Size(121, 29)
        cmbRMMode.TabIndex = 7
        ' 
        ' tabFiRcuPd
        ' 
        tabFiRcuPd.BackColor = Color.White
        tabFiRcuPd.Controls.Add(tblFiRcuPd)
        tabFiRcuPd.Location = New Point(4, 30)
        tabFiRcuPd.Name = "tabFiRcuPd"
        tabFiRcuPd.Padding = New Padding(20)
        tabFiRcuPd.Size = New Size(1092, 216)
        tabFiRcuPd.TabIndex = 2
        tabFiRcuPd.Text = "FI / RCU / PD"
        ' 
        ' tblFiRcuPd
        ' 
        tblFiRcuPd.ColumnCount = 4
        tblFiRcuPd.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblFiRcuPd.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblFiRcuPd.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblFiRcuPd.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblFiRcuPd.Controls.Add(lblFiRcuPdType, 0, 0)
        tblFiRcuPd.Controls.Add(cmbFiRcuPdType, 1, 0)
        tblFiRcuPd.Controls.Add(lblFiRcuPdAmount, 2, 0)
        tblFiRcuPd.Controls.Add(txtFiRcuPdAmount, 3, 0)
        tblFiRcuPd.Controls.Add(lblFiRcuPdDate, 0, 1)
        tblFiRcuPd.Controls.Add(dtpFiRcuPdDate, 1, 1)
        tblFiRcuPd.Controls.Add(lblFiRcuPdPaidBy, 0, 2)
        tblFiRcuPd.Controls.Add(cmbFiRcuPdPaidBy, 1, 2)
        tblFiRcuPd.Controls.Add(lblFiRcuPdMode, 2, 2)
        tblFiRcuPd.Controls.Add(cmbFiRcuPdMode, 3, 2)
        tblFiRcuPd.Dock = DockStyle.Fill
        tblFiRcuPd.Location = New Point(20, 20)
        tblFiRcuPd.Name = "tblFiRcuPd"
        tblFiRcuPd.RowCount = 3
        tblFiRcuPd.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblFiRcuPd.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblFiRcuPd.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblFiRcuPd.Size = New Size(1052, 176)
        tblFiRcuPd.TabIndex = 0
        ' 
        ' lblFiRcuPdType
        ' 
        lblFiRcuPdType.Location = New Point(3, 0)
        lblFiRcuPdType.Name = "lblFiRcuPdType"
        lblFiRcuPdType.Size = New Size(100, 23)
        lblFiRcuPdType.TabIndex = 0
        ' 
        ' cmbFiRcuPdType
        ' 
        cmbFiRcuPdType.Location = New Point(213, 3)
        cmbFiRcuPdType.Name = "cmbFiRcuPdType"
        cmbFiRcuPdType.Size = New Size(121, 29)
        cmbFiRcuPdType.TabIndex = 1
        ' 
        ' lblFiRcuPdAmount
        ' 
        lblFiRcuPdAmount.Location = New Point(528, 0)
        lblFiRcuPdAmount.Name = "lblFiRcuPdAmount"
        lblFiRcuPdAmount.Size = New Size(100, 23)
        lblFiRcuPdAmount.TabIndex = 2
        ' 
        ' txtFiRcuPdAmount
        ' 
        txtFiRcuPdAmount.Location = New Point(738, 3)
        txtFiRcuPdAmount.Name = "txtFiRcuPdAmount"
        txtFiRcuPdAmount.Size = New Size(100, 29)
        txtFiRcuPdAmount.TabIndex = 3
        ' 
        ' lblFiRcuPdDate
        ' 
        lblFiRcuPdDate.Location = New Point(3, 58)
        lblFiRcuPdDate.Name = "lblFiRcuPdDate"
        lblFiRcuPdDate.Size = New Size(100, 23)
        lblFiRcuPdDate.TabIndex = 4
        ' 
        ' dtpFiRcuPdDate
        ' 
        dtpFiRcuPdDate.Location = New Point(213, 61)
        dtpFiRcuPdDate.Name = "dtpFiRcuPdDate"
        dtpFiRcuPdDate.Size = New Size(200, 29)
        dtpFiRcuPdDate.TabIndex = 5
        ' 
        ' lblFiRcuPdPaidBy
        ' 
        lblFiRcuPdPaidBy.Location = New Point(3, 116)
        lblFiRcuPdPaidBy.Name = "lblFiRcuPdPaidBy"
        lblFiRcuPdPaidBy.Size = New Size(100, 23)
        lblFiRcuPdPaidBy.TabIndex = 6
        ' 
        ' cmbFiRcuPdPaidBy
        ' 
        cmbFiRcuPdPaidBy.Location = New Point(213, 119)
        cmbFiRcuPdPaidBy.Name = "cmbFiRcuPdPaidBy"
        cmbFiRcuPdPaidBy.Size = New Size(121, 29)
        cmbFiRcuPdPaidBy.TabIndex = 7
        ' 
        ' lblFiRcuPdMode
        ' 
        lblFiRcuPdMode.Location = New Point(528, 116)
        lblFiRcuPdMode.Name = "lblFiRcuPdMode"
        lblFiRcuPdMode.Size = New Size(100, 23)
        lblFiRcuPdMode.TabIndex = 8
        ' 
        ' cmbFiRcuPdMode
        ' 
        cmbFiRcuPdMode.Location = New Point(738, 119)
        cmbFiRcuPdMode.Name = "cmbFiRcuPdMode"
        cmbFiRcuPdMode.Size = New Size(121, 29)
        cmbFiRcuPdMode.TabIndex = 9
        ' 
        ' tabStaff
        ' 
        tabStaff.BackColor = Color.White
        tabStaff.Controls.Add(tblStaff)
        tabStaff.Location = New Point(4, 30)
        tabStaff.Name = "tabStaff"
        tabStaff.Padding = New Padding(20)
        tabStaff.Size = New Size(1092, 216)
        tabStaff.TabIndex = 3
        tabStaff.Text = "Staff Sharing"
        ' 
        ' tblStaff
        ' 
        tblStaff.ColumnCount = 4
        tblStaff.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblStaff.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblStaff.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblStaff.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblStaff.Controls.Add(lblStaffAmount, 0, 0)
        tblStaff.Controls.Add(txtStaffAmount, 1, 0)
        tblStaff.Controls.Add(lblStaffDate, 2, 0)
        tblStaff.Controls.Add(dtpStaffDate, 3, 0)
        tblStaff.Controls.Add(lblStaffStatus, 0, 1)
        tblStaff.Controls.Add(cmbStaffStatus, 1, 1)
        tblStaff.Controls.Add(lblStaffPaidBy, 0, 2)
        tblStaff.Controls.Add(cmbStaffPaidBy, 1, 2)
        tblStaff.Controls.Add(lblStaffMode, 2, 2)
        tblStaff.Controls.Add(cmbStaffMode, 3, 2)
        tblStaff.Dock = DockStyle.Fill
        tblStaff.Location = New Point(20, 20)
        tblStaff.Name = "tblStaff"
        tblStaff.RowCount = 3
        tblStaff.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblStaff.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblStaff.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblStaff.Size = New Size(1052, 176)
        tblStaff.TabIndex = 0
        ' 
        ' lblStaffAmount
        ' 
        lblStaffAmount.Location = New Point(3, 0)
        lblStaffAmount.Name = "lblStaffAmount"
        lblStaffAmount.Size = New Size(100, 23)
        lblStaffAmount.TabIndex = 0
        ' 
        ' txtStaffAmount
        ' 
        txtStaffAmount.Location = New Point(213, 3)
        txtStaffAmount.Name = "txtStaffAmount"
        txtStaffAmount.Size = New Size(100, 29)
        txtStaffAmount.TabIndex = 1
        ' 
        ' lblStaffDate
        ' 
        lblStaffDate.Location = New Point(528, 0)
        lblStaffDate.Name = "lblStaffDate"
        lblStaffDate.Size = New Size(100, 23)
        lblStaffDate.TabIndex = 2
        ' 
        ' dtpStaffDate
        ' 
        dtpStaffDate.Location = New Point(738, 3)
        dtpStaffDate.Name = "dtpStaffDate"
        dtpStaffDate.Size = New Size(200, 29)
        dtpStaffDate.TabIndex = 3
        ' 
        ' lblStaffStatus
        ' 
        lblStaffStatus.Location = New Point(3, 58)
        lblStaffStatus.Name = "lblStaffStatus"
        lblStaffStatus.Size = New Size(100, 23)
        lblStaffStatus.TabIndex = 4
        ' 
        ' cmbStaffStatus
        ' 
        cmbStaffStatus.Location = New Point(213, 61)
        cmbStaffStatus.Name = "cmbStaffStatus"
        cmbStaffStatus.Size = New Size(121, 29)
        cmbStaffStatus.TabIndex = 5
        ' 
        ' lblStaffPaidBy
        ' 
        lblStaffPaidBy.Location = New Point(3, 116)
        lblStaffPaidBy.Name = "lblStaffPaidBy"
        lblStaffPaidBy.Size = New Size(100, 23)
        lblStaffPaidBy.TabIndex = 6
        ' 
        ' cmbStaffPaidBy
        ' 
        cmbStaffPaidBy.Location = New Point(213, 119)
        cmbStaffPaidBy.Name = "cmbStaffPaidBy"
        cmbStaffPaidBy.Size = New Size(121, 29)
        cmbStaffPaidBy.TabIndex = 7
        ' 
        ' lblStaffMode
        ' 
        lblStaffMode.Location = New Point(528, 116)
        lblStaffMode.Name = "lblStaffMode"
        lblStaffMode.Size = New Size(100, 23)
        lblStaffMode.TabIndex = 8
        ' 
        ' cmbStaffMode
        ' 
        cmbStaffMode.Location = New Point(738, 119)
        cmbStaffMode.Name = "cmbStaffMode"
        cmbStaffMode.Size = New Size(121, 29)
        cmbStaffMode.TabIndex = 9
        ' 
        ' tabBuilder
        ' 
        tabBuilder.BackColor = Color.White
        tabBuilder.Controls.Add(tblBuilder)
        tabBuilder.Location = New Point(4, 30)
        tabBuilder.Name = "tabBuilder"
        tabBuilder.Padding = New Padding(20)
        tabBuilder.Size = New Size(1092, 216)
        tabBuilder.TabIndex = 4
        tabBuilder.Text = "Builder / IDC Sharing"
        ' 
        ' tblBuilder
        ' 
        tblBuilder.ColumnCount = 4
        tblBuilder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblBuilder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblBuilder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        tblBuilder.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        tblBuilder.Controls.Add(lblBuilderAmount, 0, 0)
        tblBuilder.Controls.Add(txtBuilderAmount, 1, 0)
        tblBuilder.Controls.Add(lblBuilderDate, 2, 0)
        tblBuilder.Controls.Add(dtpBuilderDate, 3, 0)
        tblBuilder.Controls.Add(lblBuilderStatus, 0, 1)
        tblBuilder.Controls.Add(cmbBuilderStatus, 1, 1)
        tblBuilder.Controls.Add(lblBuilderPaidBy, 0, 2)
        tblBuilder.Controls.Add(cmbBuilderPaidBy, 1, 2)
        tblBuilder.Controls.Add(lblBuilderMode, 2, 2)
        tblBuilder.Controls.Add(cmbBuilderMode, 3, 2)
        tblBuilder.Dock = DockStyle.Fill
        tblBuilder.Location = New Point(20, 20)
        tblBuilder.Name = "tblBuilder"
        tblBuilder.RowCount = 3
        tblBuilder.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblBuilder.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblBuilder.RowStyles.Add(New RowStyle(SizeType.Percent, 33.33F))
        tblBuilder.Size = New Size(1052, 176)
        tblBuilder.TabIndex = 0
        ' 
        ' lblBuilderAmount
        ' 
        lblBuilderAmount.Location = New Point(3, 0)
        lblBuilderAmount.Name = "lblBuilderAmount"
        lblBuilderAmount.Size = New Size(100, 23)
        lblBuilderAmount.TabIndex = 0
        ' 
        ' txtBuilderAmount
        ' 
        txtBuilderAmount.Location = New Point(213, 3)
        txtBuilderAmount.Name = "txtBuilderAmount"
        txtBuilderAmount.Size = New Size(100, 29)
        txtBuilderAmount.TabIndex = 1
        ' 
        ' lblBuilderDate
        ' 
        lblBuilderDate.Location = New Point(528, 0)
        lblBuilderDate.Name = "lblBuilderDate"
        lblBuilderDate.Size = New Size(100, 23)
        lblBuilderDate.TabIndex = 2
        ' 
        ' dtpBuilderDate
        ' 
        dtpBuilderDate.Location = New Point(738, 3)
        dtpBuilderDate.Name = "dtpBuilderDate"
        dtpBuilderDate.Size = New Size(200, 29)
        dtpBuilderDate.TabIndex = 3
        ' 
        ' lblBuilderStatus
        ' 
        lblBuilderStatus.Location = New Point(3, 58)
        lblBuilderStatus.Name = "lblBuilderStatus"
        lblBuilderStatus.Size = New Size(100, 23)
        lblBuilderStatus.TabIndex = 4
        ' 
        ' cmbBuilderStatus
        ' 
        cmbBuilderStatus.Location = New Point(213, 61)
        cmbBuilderStatus.Name = "cmbBuilderStatus"
        cmbBuilderStatus.Size = New Size(121, 29)
        cmbBuilderStatus.TabIndex = 5
        ' 
        ' lblBuilderPaidBy
        ' 
        lblBuilderPaidBy.Location = New Point(3, 116)
        lblBuilderPaidBy.Name = "lblBuilderPaidBy"
        lblBuilderPaidBy.Size = New Size(100, 23)
        lblBuilderPaidBy.TabIndex = 6
        ' 
        ' cmbBuilderPaidBy
        ' 
        cmbBuilderPaidBy.Location = New Point(213, 119)
        cmbBuilderPaidBy.Name = "cmbBuilderPaidBy"
        cmbBuilderPaidBy.Size = New Size(121, 29)
        cmbBuilderPaidBy.TabIndex = 7
        ' 
        ' lblBuilderMode
        ' 
        lblBuilderMode.Location = New Point(528, 116)
        lblBuilderMode.Name = "lblBuilderMode"
        lblBuilderMode.Size = New Size(100, 23)
        lblBuilderMode.TabIndex = 8
        ' 
        ' cmbBuilderMode
        ' 
        cmbBuilderMode.Location = New Point(738, 119)
        cmbBuilderMode.Name = "cmbBuilderMode"
        cmbBuilderMode.Size = New Size(121, 29)
        cmbBuilderMode.TabIndex = 9
        ' 
        ' PanelActions
        ' 
        PanelActions.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        PanelActions.Controls.Add(btnSave)
        PanelActions.Dock = DockStyle.Bottom
        PanelActions.Location = New Point(0, 645)
        PanelActions.Name = "PanelActions"
        PanelActions.Padding = New Padding(20, 8, 20, 8)
        PanelActions.Size = New Size(1100, 55)
        PanelActions.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(20, 8)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(150, 38)
        btnSave.TabIndex = 0
        btnSave.Text = "💾 Save Expense"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' frmExpense
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(1100, 700)
        Controls.Add(tabExpense)
        Controls.Add(pnlInfo)
        Controls.Add(PanelSearch)
        Controls.Add(PanelHeader)
        Controls.Add(PanelActions)
        MinimumSize = New Size(950, 600)
        Name = "frmExpense"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "Expense"
        Text = "Expense Management"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelSearch.ResumeLayout(False)
        PanelSearch.PerformLayout()
        CType(dgvCustomerSearch, ComponentModel.ISupportInitialize).EndInit()
        pnlInfo.ResumeLayout(False)
        pnlInfo.PerformLayout()
        tabExpense.ResumeLayout(False)
        tabPF.ResumeLayout(False)
        tblPF.ResumeLayout(False)
        tblPF.PerformLayout()
        tabRM.ResumeLayout(False)
        tblRM.ResumeLayout(False)
        tblRM.PerformLayout()
        tabFiRcuPd.ResumeLayout(False)
        tblFiRcuPd.ResumeLayout(False)
        tblFiRcuPd.PerformLayout()
        tabStaff.ResumeLayout(False)
        tblStaff.ResumeLayout(False)
        tblStaff.PerformLayout()
        tabBuilder.ResumeLayout(False)
        tblBuilder.ResumeLayout(False)
        tblBuilder.PerformLayout()
        PanelActions.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    '================================================
    ' SHARED FIELD SETUP HELPERS
    '================================================
    Private Sub SetupLabel(lbl As Label, caption As String)
        lbl.Text = caption
        lbl.Dock = DockStyle.Fill
        lbl.Font = New Font("Segoe UI", 9.5F)
        lbl.ForeColor = Color.FromArgb(51, 65, 85)
        lbl.Margin = New Padding(3, 10, 8, 0)
        lbl.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub SetupTextBox(txt As TextBox)
        txt.Dock = DockStyle.Fill
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.Font = New Font("Segoe UI", 9.5F)
        txt.Margin = New Padding(3, 6, 15, 6)
    End Sub

    Private Sub SetupDTP(dtp As DateTimePicker)
        dtp.Dock = DockStyle.Fill
        dtp.Font = New Font("Segoe UI", 9.5F)
        dtp.Format = DateTimePickerFormat.Short
        dtp.Margin = New Padding(3, 6, 15, 6)
    End Sub

    Private Sub SetupCombo(cbo As ComboBox, valueMember As String)
        cbo.Dock = DockStyle.Fill
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        cbo.Font = New Font("Segoe UI", 9.5F)
        cbo.ValueMember = valueMember
        cbo.Margin = New Padding(3, 6, 15, 6)
    End Sub

    Private Sub SetupComboPlain(cbo As ComboBox)
        cbo.Dock = DockStyle.Fill
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        cbo.Font = New Font("Segoe UI", 9.5F)
        cbo.Margin = New Padding(3, 6, 15, 6)
    End Sub

    '================================================
    ' CONTROLS
    '================================================
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label

    Friend WithEvents PanelSearch As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNewSearch As Button
    Friend WithEvents dgvCustomerSearch As DataGridView

    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblInfoName As Label
    Friend WithEvents lblInfoMobile As Label
    Friend WithEvents lblInfoLoan As Label
    Friend WithEvents lblInfoProduct As Label

    Friend WithEvents tabExpense As TabControl

    Friend WithEvents tabPF As TabPage
    Friend WithEvents tblPF As TableLayoutPanel
    Friend WithEvents lblPFAmount As Label
    Friend WithEvents txtPFAmount As TextBox
    Friend WithEvents lblPFDate As Label
    Friend WithEvents dtpPFDate As DateTimePicker
    Friend WithEvents lblPFPaidBy As Label
    Friend WithEvents cmbPFPaidBy As ComboBox
    Friend WithEvents lblPFMode As Label
    Friend WithEvents cmbPFMode As ComboBox

    Friend WithEvents tabRM As TabPage
    Friend WithEvents tblRM As TableLayoutPanel
    Friend WithEvents lblRMAmount As Label
    Friend WithEvents txtRMAmount As TextBox
    Friend WithEvents lblRMDate As Label
    Friend WithEvents dtpRMDate As DateTimePicker
    Friend WithEvents lblRMPaidBy As Label
    Friend WithEvents cmbRMPaidBy As ComboBox
    Friend WithEvents lblRMMode As Label
    Friend WithEvents cmbRMMode As ComboBox

    Friend WithEvents tabFiRcuPd As TabPage
    Friend WithEvents tblFiRcuPd As TableLayoutPanel
    Friend WithEvents lblFiRcuPdType As Label
    Friend WithEvents cmbFiRcuPdType As ComboBox
    Friend WithEvents lblFiRcuPdAmount As Label
    Friend WithEvents txtFiRcuPdAmount As TextBox
    Friend WithEvents lblFiRcuPdDate As Label
    Friend WithEvents dtpFiRcuPdDate As DateTimePicker
    Friend WithEvents lblFiRcuPdPaidBy As Label
    Friend WithEvents cmbFiRcuPdPaidBy As ComboBox
    Friend WithEvents lblFiRcuPdMode As Label
    Friend WithEvents cmbFiRcuPdMode As ComboBox

    Friend WithEvents tabStaff As TabPage
    Friend WithEvents tblStaff As TableLayoutPanel
    Friend WithEvents lblStaffAmount As Label
    Friend WithEvents txtStaffAmount As TextBox
    Friend WithEvents lblStaffDate As Label
    Friend WithEvents dtpStaffDate As DateTimePicker
    Friend WithEvents lblStaffStatus As Label
    Friend WithEvents cmbStaffStatus As ComboBox
    Friend WithEvents lblStaffPaidBy As Label
    Friend WithEvents cmbStaffPaidBy As ComboBox
    Friend WithEvents lblStaffMode As Label
    Friend WithEvents cmbStaffMode As ComboBox

    Friend WithEvents tabBuilder As TabPage
    Friend WithEvents tblBuilder As TableLayoutPanel
    Friend WithEvents lblBuilderAmount As Label
    Friend WithEvents txtBuilderAmount As TextBox
    Friend WithEvents lblBuilderDate As Label
    Friend WithEvents dtpBuilderDate As DateTimePicker
    Friend WithEvents lblBuilderStatus As Label
    Friend WithEvents cmbBuilderStatus As ComboBox
    Friend WithEvents lblBuilderPaidBy As Label
    Friend WithEvents cmbBuilderPaidBy As ComboBox
    Friend WithEvents lblBuilderMode As Label
    Friend WithEvents cmbBuilderMode As ComboBox

    Friend WithEvents PanelActions As Panel
    Friend WithEvents btnSave As Button

End Class