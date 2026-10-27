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
        Me.components = New System.ComponentModel.Container()

        ' Create controls
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNewSearch = New System.Windows.Forms.Button()
        Me.dgvCustomerSearch = New System.Windows.Forms.DataGridView()
        Me.grpCustInfo = New System.Windows.Forms.GroupBox()
        Me.lblInfoName = New System.Windows.Forms.Label()
        Me.txtInfoName = New System.Windows.Forms.TextBox()
        Me.lblInfoMobile = New System.Windows.Forms.Label()
        Me.txtInfoMobile = New System.Windows.Forms.TextBox()
        Me.lblInfoLoan = New System.Windows.Forms.Label()
        Me.txtInfoLoan = New System.Windows.Forms.TextBox()
        Me.lblInfoProduct = New System.Windows.Forms.Label()
        Me.txtInfoProduct = New System.Windows.Forms.TextBox()
        Me.lblInfoAppNo = New System.Windows.Forms.Label()
        Me.txtInfoAppNo = New System.Windows.Forms.TextBox()
        Me.lblInfoLoanNo = New System.Windows.Forms.Label()
        Me.txtInfoLoanNo = New System.Windows.Forms.TextBox()
        Me.tabExpense = New System.Windows.Forms.TabControl()
        Me.tabPF = New System.Windows.Forms.TabPage()
        Me.grpPF = New System.Windows.Forms.GroupBox()
        Me.lblPFAmount = New System.Windows.Forms.Label()
        Me.txtPFAmount = New System.Windows.Forms.TextBox()
        Me.lblPFDate = New System.Windows.Forms.Label()
        Me.dtpPFDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPFPaidBy = New System.Windows.Forms.Label()
        Me.cmbPFPaidBy = New System.Windows.Forms.ComboBox()
        Me.lblPFMode = New System.Windows.Forms.Label()
        Me.cmbPFMode = New System.Windows.Forms.ComboBox()
        Me.tabRM = New System.Windows.Forms.TabPage()
        Me.grpRM = New System.Windows.Forms.GroupBox()
        Me.lblRMAmount = New System.Windows.Forms.Label()
        Me.txtRMAmount = New System.Windows.Forms.TextBox()
        Me.lblRMDate = New System.Windows.Forms.Label()
        Me.dtpRMDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRMPaidBy = New System.Windows.Forms.Label()
        Me.cmbRMPaidBy = New System.Windows.Forms.ComboBox()
        Me.lblRMMode = New System.Windows.Forms.Label()
        Me.cmbRMMode = New System.Windows.Forms.ComboBox()
        Me.tabFiRcuPd = New System.Windows.Forms.TabPage()
        Me.grpFiRcuPd = New System.Windows.Forms.GroupBox()
        Me.lblFiRcuPdType = New System.Windows.Forms.Label()
        Me.cmbFiRcuPdType = New System.Windows.Forms.ComboBox()
        Me.lblFiRcuPdAmount = New System.Windows.Forms.Label()
        Me.txtFiRcuPdAmount = New System.Windows.Forms.TextBox()
        Me.lblFiRcuPdDate = New System.Windows.Forms.Label()
        Me.dtpFiRcuPdDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFiRcuPdPaidBy = New System.Windows.Forms.Label()
        Me.cmbFiRcuPdPaidBy = New System.Windows.Forms.ComboBox()
        Me.lblFiRcuPdMode = New System.Windows.Forms.Label()
        Me.cmbFiRcuPdMode = New System.Windows.Forms.ComboBox()
        Me.tabStaff = New System.Windows.Forms.TabPage()
        Me.grpStaff = New System.Windows.Forms.GroupBox()
        Me.lblStaffAmount = New System.Windows.Forms.Label()
        Me.txtStaffAmount = New System.Windows.Forms.TextBox()
        Me.lblStaffDate = New System.Windows.Forms.Label()
        Me.dtpStaffDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStaffStatus = New System.Windows.Forms.Label()
        Me.cmbStaffStatus = New System.Windows.Forms.ComboBox()
        Me.lblStaffPaidBy = New System.Windows.Forms.Label()
        Me.cmbStaffPaidBy = New System.Windows.Forms.ComboBox()
        Me.lblStaffMode = New System.Windows.Forms.Label()
        Me.cmbStaffMode = New System.Windows.Forms.ComboBox()
        Me.tabBuilder = New System.Windows.Forms.TabPage()
        Me.grpBuilder = New System.Windows.Forms.GroupBox()
        Me.lblBuilderAmount = New System.Windows.Forms.Label()
        Me.txtBuilderAmount = New System.Windows.Forms.TextBox()
        Me.lblBuilderDate = New System.Windows.Forms.Label()
        Me.dtpBuilderDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBuilderStatus = New System.Windows.Forms.Label()
        Me.cmbBuilderStatus = New System.Windows.Forms.ComboBox()
        Me.lblBuilderPaidBy = New System.Windows.Forms.Label()
        Me.cmbBuilderPaidBy = New System.Windows.Forms.ComboBox()
        Me.lblBuilderMode = New System.Windows.Forms.Label()
        Me.cmbBuilderMode = New System.Windows.Forms.ComboBox()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()

        Me.pnlTop.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustInfo.SuspendLayout()
        Me.tabExpense.SuspendLayout()
        Me.tabPF.SuspendLayout()
        Me.grpPF.SuspendLayout()
        Me.tabRM.SuspendLayout()
        Me.grpRM.SuspendLayout()
        Me.tabFiRcuPd.SuspendLayout()
        Me.grpFiRcuPd.SuspendLayout()
        Me.tabStaff.SuspendLayout()
        Me.grpStaff.SuspendLayout()
        Me.tabBuilder.SuspendLayout()
        Me.grpBuilder.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()

        '========== TOP ==========
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblSubTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1200, 55)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Text = "EXPENSE MANAGEMENT"

        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSubTitle.Location = New System.Drawing.Point(20, 32)
        Me.lblSubTitle.Text = "PF / Agreement  |  RM  |  FI-RCU-PD  |  Staff  |  Builder / IDC"

        '========== SEARCH ==========
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.btnNewSearch)
        Me.pnlSearch.Controls.Add(Me.dgvCustomerSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 55)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1200, 50)

        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(12, 14)
        Me.lblSearch.Text = "Search :"

        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearch.Location = New System.Drawing.Point(80, 11)
        Me.txtSearch.Size = New System.Drawing.Size(420, 25)
        Me.txtSearch.PlaceholderText = "Customer Name / Mobile / Lead ID / Login ID / App No / Loan No"

        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(520, 8)
        Me.btnSearch.Size = New System.Drawing.Size(100, 30)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False

        Me.btnNewSearch.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnNewSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNewSearch.ForeColor = System.Drawing.Color.White
        Me.btnNewSearch.Location = New System.Drawing.Point(630, 8)
        Me.btnNewSearch.Size = New System.Drawing.Size(110, 30)
        Me.btnNewSearch.Text = "New Search"
        Me.btnNewSearch.UseVisualStyleBackColor = False

        Me.dgvCustomerSearch.AllowUserToAddRows = False
        Me.dgvCustomerSearch.AllowUserToDeleteRows = False
        Me.dgvCustomerSearch.AllowUserToResizeRows = False
        Me.dgvCustomerSearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomerSearch.ColumnHeadersHeight = 30
        Me.dgvCustomerSearch.EnableHeadersVisualStyles = False
        Me.dgvCustomerSearch.Location = New System.Drawing.Point(12, 48)
        Me.dgvCustomerSearch.MultiSelect = False
        Me.dgvCustomerSearch.Name = "dgvCustomerSearch"
        Me.dgvCustomerSearch.ReadOnly = True
        Me.dgvCustomerSearch.RowHeadersVisible = False
        Me.dgvCustomerSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomerSearch.Size = New System.Drawing.Size(1160, 140)
        Me.dgvCustomerSearch.Visible = False

        '========== CUSTOMER INFO ==========
        Me.grpCustInfo.Controls.Add(Me.lblInfoName)
        Me.grpCustInfo.Controls.Add(Me.txtInfoName)
        Me.grpCustInfo.Controls.Add(Me.lblInfoMobile)
        Me.grpCustInfo.Controls.Add(Me.txtInfoMobile)
        Me.grpCustInfo.Controls.Add(Me.lblInfoLoan)
        Me.grpCustInfo.Controls.Add(Me.txtInfoLoan)
        Me.grpCustInfo.Controls.Add(Me.lblInfoProduct)
        Me.grpCustInfo.Controls.Add(Me.txtInfoProduct)
        Me.grpCustInfo.Controls.Add(Me.lblInfoAppNo)
        Me.grpCustInfo.Controls.Add(Me.txtInfoAppNo)
        Me.grpCustInfo.Controls.Add(Me.lblInfoLoanNo)
        Me.grpCustInfo.Controls.Add(Me.txtInfoLoanNo)
        Me.grpCustInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpCustInfo.Location = New System.Drawing.Point(12, 115)
        Me.grpCustInfo.Name = "grpCustInfo"
        Me.grpCustInfo.Size = New System.Drawing.Size(1160, 90)
        Me.grpCustInfo.TabStop = False
        Me.grpCustInfo.Text = "Selected Customer (Login)"
        Me.grpCustInfo.Visible = False

        Me.lblInfoName.AutoSize = True
        Me.lblInfoName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoName.Location = New System.Drawing.Point(15, 28)
        Me.lblInfoName.Text = "Name"
        Me.txtInfoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInfoName.Location = New System.Drawing.Point(70, 25)
        Me.txtInfoName.ReadOnly = True
        Me.txtInfoName.Size = New System.Drawing.Size(200, 25)

        Me.lblInfoMobile.AutoSize = True
        Me.lblInfoMobile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoMobile.Location = New System.Drawing.Point(290, 28)
        Me.lblInfoMobile.Text = "Mobile"
        Me.txtInfoMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInfoMobile.Location = New System.Drawing.Point(350, 25)
        Me.txtInfoMobile.ReadOnly = True
        Me.txtInfoMobile.Size = New System.Drawing.Size(130, 25)

        Me.lblInfoLoan.AutoSize = True
        Me.lblInfoLoan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoLoan.Location = New System.Drawing.Point(500, 28)
        Me.lblInfoLoan.Text = "Loan Amt"
        Me.txtInfoLoan.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtInfoLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoLoan.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInfoLoan.Location = New System.Drawing.Point(580, 25)
        Me.txtInfoLoan.ReadOnly = True
        Me.txtInfoLoan.Size = New System.Drawing.Size(130, 25)
        Me.txtInfoLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblInfoProduct.AutoSize = True
        Me.lblInfoProduct.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoProduct.Location = New System.Drawing.Point(730, 28)
        Me.lblInfoProduct.Text = "Product"
        Me.txtInfoProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoProduct.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInfoProduct.Location = New System.Drawing.Point(800, 25)
        Me.txtInfoProduct.ReadOnly = True
        Me.txtInfoProduct.Size = New System.Drawing.Size(150, 25)

        Me.lblInfoAppNo.AutoSize = True
        Me.lblInfoAppNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoAppNo.Location = New System.Drawing.Point(15, 58)
        Me.lblInfoAppNo.Text = "App No"
        Me.txtInfoAppNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoAppNo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInfoAppNo.Location = New System.Drawing.Point(70, 55)
        Me.txtInfoAppNo.ReadOnly = True
        Me.txtInfoAppNo.Size = New System.Drawing.Size(200, 25)

        Me.lblInfoLoanNo.AutoSize = True
        Me.lblInfoLoanNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoLoanNo.Location = New System.Drawing.Point(290, 58)
        Me.lblInfoLoanNo.Text = "Loan No"
        Me.txtInfoLoanNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfoLoanNo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInfoLoanNo.Location = New System.Drawing.Point(350, 55)
        Me.txtInfoLoanNo.ReadOnly = True
        Me.txtInfoLoanNo.Size = New System.Drawing.Size(130, 25)

        '========== TABS ==========
        Me.tabExpense.Controls.Add(Me.tabPF)
        Me.tabExpense.Controls.Add(Me.tabRM)
        Me.tabExpense.Controls.Add(Me.tabFiRcuPd)
        Me.tabExpense.Controls.Add(Me.tabStaff)
        Me.tabExpense.Controls.Add(Me.tabBuilder)
        Me.tabExpense.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tabExpense.ItemSize = New System.Drawing.Size(160, 30)
        Me.tabExpense.Location = New System.Drawing.Point(12, 215)
        Me.tabExpense.Name = "tabExpense"
        Me.tabExpense.SelectedIndex = 0
        Me.tabExpense.Size = New System.Drawing.Size(1160, 280)
        Me.tabExpense.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabExpense.Enabled = False

        '----- PF TAB -----
        Me.tabPF.Controls.Add(Me.grpPF)
        Me.tabPF.Location = New System.Drawing.Point(4, 34)
        Me.tabPF.Name = "tabPF"
        Me.tabPF.Padding = New System.Windows.Forms.Padding(10)
        Me.tabPF.Size = New System.Drawing.Size(1152, 242)
        Me.tabPF.Text = "  PF / Agreement / Other  "
        Me.tabPF.UseVisualStyleBackColor = True

        Me.grpPF.Controls.Add(Me.lblPFAmount)
        Me.grpPF.Controls.Add(Me.txtPFAmount)
        Me.grpPF.Controls.Add(Me.lblPFDate)
        Me.grpPF.Controls.Add(Me.dtpPFDate)
        Me.grpPF.Controls.Add(Me.lblPFPaidBy)
        Me.grpPF.Controls.Add(Me.cmbPFPaidBy)
        Me.grpPF.Controls.Add(Me.lblPFMode)
        Me.grpPF.Controls.Add(Me.cmbPFMode)
        Me.grpPF.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpPF.Location = New System.Drawing.Point(15, 15)
        Me.grpPF.Name = "grpPF"
        Me.grpPF.Size = New System.Drawing.Size(1110, 200)
        Me.grpPF.TabStop = False
        Me.grpPF.Text = "PF / Agreement / Other Details"

        Me.lblPFAmount.AutoSize = True
        Me.lblPFAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPFAmount.Location = New System.Drawing.Point(30, 45)
        Me.lblPFAmount.Text = "Amount"
        Me.txtPFAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPFAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPFAmount.Location = New System.Drawing.Point(120, 42)
        Me.txtPFAmount.Size = New System.Drawing.Size(180, 25)
        Me.txtPFAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblPFDate.AutoSize = True
        Me.lblPFDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPFDate.Location = New System.Drawing.Point(350, 45)
        Me.lblPFDate.Text = "Date"
        Me.dtpPFDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpPFDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpPFDate.Location = New System.Drawing.Point(420, 42)
        Me.dtpPFDate.Size = New System.Drawing.Size(160, 25)

        Me.lblPFPaidBy.AutoSize = True
        Me.lblPFPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPFPaidBy.Location = New System.Drawing.Point(30, 100)
        Me.lblPFPaidBy.Text = "Paid By"
        Me.cmbPFPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPFPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbPFPaidBy.Location = New System.Drawing.Point(120, 97)
        Me.cmbPFPaidBy.Size = New System.Drawing.Size(180, 25)

        Me.lblPFMode.AutoSize = True
        Me.lblPFMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPFMode.Location = New System.Drawing.Point(350, 100)
        Me.lblPFMode.Text = "Mode"
        Me.cmbPFMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPFMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbPFMode.Location = New System.Drawing.Point(420, 97)
        Me.cmbPFMode.Size = New System.Drawing.Size(160, 25)

        '----- RM TAB -----
        Me.tabRM.Controls.Add(Me.grpRM)
        Me.tabRM.Location = New System.Drawing.Point(4, 34)
        Me.tabRM.Name = "tabRM"
        Me.tabRM.Padding = New System.Windows.Forms.Padding(10)
        Me.tabRM.Size = New System.Drawing.Size(1152, 242)
        Me.tabRM.Text = "  RM  "
        Me.tabRM.UseVisualStyleBackColor = True

        Me.grpRM.Controls.Add(Me.lblRMAmount)
        Me.grpRM.Controls.Add(Me.txtRMAmount)
        Me.grpRM.Controls.Add(Me.lblRMDate)
        Me.grpRM.Controls.Add(Me.dtpRMDate)
        Me.grpRM.Controls.Add(Me.lblRMPaidBy)
        Me.grpRM.Controls.Add(Me.cmbRMPaidBy)
        Me.grpRM.Controls.Add(Me.lblRMMode)
        Me.grpRM.Controls.Add(Me.cmbRMMode)
        Me.grpRM.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpRM.Location = New System.Drawing.Point(15, 15)
        Me.grpRM.Name = "grpRM"
        Me.grpRM.Size = New System.Drawing.Size(1110, 200)
        Me.grpRM.TabStop = False
        Me.grpRM.Text = "RM Details"

        Me.lblRMAmount.AutoSize = True
        Me.lblRMAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRMAmount.Location = New System.Drawing.Point(30, 45)
        Me.lblRMAmount.Text = "Amount"
        Me.txtRMAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRMAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtRMAmount.Location = New System.Drawing.Point(120, 42)
        Me.txtRMAmount.Size = New System.Drawing.Size(180, 25)
        Me.txtRMAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblRMDate.AutoSize = True
        Me.lblRMDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRMDate.Location = New System.Drawing.Point(350, 45)
        Me.lblRMDate.Text = "Date"
        Me.dtpRMDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpRMDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpRMDate.Location = New System.Drawing.Point(420, 42)
        Me.dtpRMDate.Size = New System.Drawing.Size(160, 25)

        Me.lblRMPaidBy.AutoSize = True
        Me.lblRMPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRMPaidBy.Location = New System.Drawing.Point(30, 100)
        Me.lblRMPaidBy.Text = "Paid By"
        Me.cmbRMPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRMPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbRMPaidBy.Location = New System.Drawing.Point(120, 97)
        Me.cmbRMPaidBy.Size = New System.Drawing.Size(180, 25)

        Me.lblRMMode.AutoSize = True
        Me.lblRMMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRMMode.Location = New System.Drawing.Point(350, 100)
        Me.lblRMMode.Text = "Mode"
        Me.cmbRMMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRMMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbRMMode.Location = New System.Drawing.Point(420, 97)
        Me.cmbRMMode.Size = New System.Drawing.Size(160, 25)

        '----- FI / RCU / PD TAB -----
        Me.tabFiRcuPd.Controls.Add(Me.grpFiRcuPd)
        Me.tabFiRcuPd.Location = New System.Drawing.Point(4, 34)
        Me.tabFiRcuPd.Name = "tabFiRcuPd"
        Me.tabFiRcuPd.Padding = New System.Windows.Forms.Padding(10)
        Me.tabFiRcuPd.Size = New System.Drawing.Size(1152, 242)
        Me.tabFiRcuPd.Text = "  FI / RCU / PD  "
        Me.tabFiRcuPd.UseVisualStyleBackColor = True

        Me.grpFiRcuPd.Controls.Add(Me.lblFiRcuPdType)
        Me.grpFiRcuPd.Controls.Add(Me.cmbFiRcuPdType)
        Me.grpFiRcuPd.Controls.Add(Me.lblFiRcuPdAmount)
        Me.grpFiRcuPd.Controls.Add(Me.txtFiRcuPdAmount)
        Me.grpFiRcuPd.Controls.Add(Me.lblFiRcuPdDate)
        Me.grpFiRcuPd.Controls.Add(Me.dtpFiRcuPdDate)
        Me.grpFiRcuPd.Controls.Add(Me.lblFiRcuPdPaidBy)
        Me.grpFiRcuPd.Controls.Add(Me.cmbFiRcuPdPaidBy)
        Me.grpFiRcuPd.Controls.Add(Me.lblFiRcuPdMode)
        Me.grpFiRcuPd.Controls.Add(Me.cmbFiRcuPdMode)
        Me.grpFiRcuPd.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpFiRcuPd.Location = New System.Drawing.Point(15, 15)
        Me.grpFiRcuPd.Name = "grpFiRcuPd"
        Me.grpFiRcuPd.Size = New System.Drawing.Size(1110, 200)
        Me.grpFiRcuPd.TabStop = False
        Me.grpFiRcuPd.Text = "FI / RCU / PD Details"

        Me.lblFiRcuPdType.AutoSize = True
        Me.lblFiRcuPdType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiRcuPdType.Location = New System.Drawing.Point(30, 40)
        Me.lblFiRcuPdType.Text = "Type"
        Me.cmbFiRcuPdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiRcuPdType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbFiRcuPdType.Location = New System.Drawing.Point(120, 37)
        Me.cmbFiRcuPdType.Size = New System.Drawing.Size(180, 25)

        Me.lblFiRcuPdAmount.AutoSize = True
        Me.lblFiRcuPdAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiRcuPdAmount.Location = New System.Drawing.Point(350, 40)
        Me.lblFiRcuPdAmount.Text = "Amount"
        Me.txtFiRcuPdAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiRcuPdAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtFiRcuPdAmount.Location = New System.Drawing.Point(430, 37)
        Me.txtFiRcuPdAmount.Size = New System.Drawing.Size(160, 25)
        Me.txtFiRcuPdAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblFiRcuPdDate.AutoSize = True
        Me.lblFiRcuPdDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiRcuPdDate.Location = New System.Drawing.Point(630, 40)
        Me.lblFiRcuPdDate.Text = "Date"
        Me.dtpFiRcuPdDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpFiRcuPdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFiRcuPdDate.Location = New System.Drawing.Point(690, 37)
        Me.dtpFiRcuPdDate.Size = New System.Drawing.Size(160, 25)

        Me.lblFiRcuPdPaidBy.AutoSize = True
        Me.lblFiRcuPdPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiRcuPdPaidBy.Location = New System.Drawing.Point(30, 95)
        Me.lblFiRcuPdPaidBy.Text = "Paid By"
        Me.cmbFiRcuPdPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiRcuPdPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbFiRcuPdPaidBy.Location = New System.Drawing.Point(120, 92)
        Me.cmbFiRcuPdPaidBy.Size = New System.Drawing.Size(180, 25)

        Me.lblFiRcuPdMode.AutoSize = True
        Me.lblFiRcuPdMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFiRcuPdMode.Location = New System.Drawing.Point(350, 95)
        Me.lblFiRcuPdMode.Text = "Mode"
        Me.cmbFiRcuPdMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiRcuPdMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbFiRcuPdMode.Location = New System.Drawing.Point(430, 92)
        Me.cmbFiRcuPdMode.Size = New System.Drawing.Size(160, 25)

        '----- STAFF TAB -----
        Me.tabStaff.Controls.Add(Me.grpStaff)
        Me.tabStaff.Location = New System.Drawing.Point(4, 34)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Padding = New System.Windows.Forms.Padding(10)
        Me.tabStaff.Size = New System.Drawing.Size(1152, 242)
        Me.tabStaff.Text = "  Staff Sharing  "
        Me.tabStaff.UseVisualStyleBackColor = True

        Me.grpStaff.Controls.Add(Me.lblStaffAmount)
        Me.grpStaff.Controls.Add(Me.txtStaffAmount)
        Me.grpStaff.Controls.Add(Me.lblStaffDate)
        Me.grpStaff.Controls.Add(Me.dtpStaffDate)
        Me.grpStaff.Controls.Add(Me.lblStaffStatus)
        Me.grpStaff.Controls.Add(Me.cmbStaffStatus)
        Me.grpStaff.Controls.Add(Me.lblStaffPaidBy)
        Me.grpStaff.Controls.Add(Me.cmbStaffPaidBy)
        Me.grpStaff.Controls.Add(Me.lblStaffMode)
        Me.grpStaff.Controls.Add(Me.cmbStaffMode)
        Me.grpStaff.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpStaff.Location = New System.Drawing.Point(15, 15)
        Me.grpStaff.Name = "grpStaff"
        Me.grpStaff.Size = New System.Drawing.Size(1110, 200)
        Me.grpStaff.TabStop = False
        Me.grpStaff.Text = "Staff Sharing Details"

        Me.lblStaffAmount.AutoSize = True
        Me.lblStaffAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffAmount.Location = New System.Drawing.Point(30, 40)
        Me.lblStaffAmount.Text = "Amount"
        Me.txtStaffAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStaffAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtStaffAmount.Location = New System.Drawing.Point(120, 37)
        Me.txtStaffAmount.Size = New System.Drawing.Size(180, 25)
        Me.txtStaffAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblStaffDate.AutoSize = True
        Me.lblStaffDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffDate.Location = New System.Drawing.Point(350, 40)
        Me.lblStaffDate.Text = "Date"
        Me.dtpStaffDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpStaffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpStaffDate.Location = New System.Drawing.Point(420, 37)
        Me.dtpStaffDate.Size = New System.Drawing.Size(160, 25)

        Me.lblStaffStatus.AutoSize = True
        Me.lblStaffStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffStatus.Location = New System.Drawing.Point(630, 40)
        Me.lblStaffStatus.Text = "Status"
        Me.cmbStaffStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbStaffStatus.Location = New System.Drawing.Point(700, 37)
        Me.cmbStaffStatus.Size = New System.Drawing.Size(150, 25)

        Me.lblStaffPaidBy.AutoSize = True
        Me.lblStaffPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffPaidBy.Location = New System.Drawing.Point(30, 95)
        Me.lblStaffPaidBy.Text = "Paid By"
        Me.cmbStaffPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbStaffPaidBy.Location = New System.Drawing.Point(120, 92)
        Me.cmbStaffPaidBy.Size = New System.Drawing.Size(180, 25)

        Me.lblStaffMode.AutoSize = True
        Me.lblStaffMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblStaffMode.Location = New System.Drawing.Point(350, 95)
        Me.lblStaffMode.Text = "Mode"
        Me.cmbStaffMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbStaffMode.Location = New System.Drawing.Point(420, 92)
        Me.cmbStaffMode.Size = New System.Drawing.Size(160, 25)

        '----- BUILDER TAB -----
        Me.tabBuilder.Controls.Add(Me.grpBuilder)
        Me.tabBuilder.Location = New System.Drawing.Point(4, 34)
        Me.tabBuilder.Name = "tabBuilder"
        Me.tabBuilder.Padding = New System.Windows.Forms.Padding(10)
        Me.tabBuilder.Size = New System.Drawing.Size(1152, 242)
        Me.tabBuilder.Text = "  Builder / IDC Sharing  "
        Me.tabBuilder.UseVisualStyleBackColor = True

        Me.grpBuilder.Controls.Add(Me.lblBuilderAmount)
        Me.grpBuilder.Controls.Add(Me.txtBuilderAmount)
        Me.grpBuilder.Controls.Add(Me.lblBuilderDate)
        Me.grpBuilder.Controls.Add(Me.dtpBuilderDate)
        Me.grpBuilder.Controls.Add(Me.lblBuilderStatus)
        Me.grpBuilder.Controls.Add(Me.cmbBuilderStatus)
        Me.grpBuilder.Controls.Add(Me.lblBuilderPaidBy)
        Me.grpBuilder.Controls.Add(Me.cmbBuilderPaidBy)
        Me.grpBuilder.Controls.Add(Me.lblBuilderMode)
        Me.grpBuilder.Controls.Add(Me.cmbBuilderMode)
        Me.grpBuilder.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBuilder.Location = New System.Drawing.Point(15, 15)
        Me.grpBuilder.Name = "grpBuilder"
        Me.grpBuilder.Size = New System.Drawing.Size(1110, 200)
        Me.grpBuilder.TabStop = False
        Me.grpBuilder.Text = "Builder / IDC Sharing Details"

        Me.lblBuilderAmount.AutoSize = True
        Me.lblBuilderAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuilderAmount.Location = New System.Drawing.Point(30, 40)
        Me.lblBuilderAmount.Text = "Amount"
        Me.txtBuilderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuilderAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtBuilderAmount.Location = New System.Drawing.Point(120, 37)
        Me.txtBuilderAmount.Size = New System.Drawing.Size(180, 25)
        Me.txtBuilderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblBuilderDate.AutoSize = True
        Me.lblBuilderDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuilderDate.Location = New System.Drawing.Point(350, 40)
        Me.lblBuilderDate.Text = "Date"
        Me.dtpBuilderDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpBuilderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpBuilderDate.Location = New System.Drawing.Point(420, 37)
        Me.dtpBuilderDate.Size = New System.Drawing.Size(160, 25)

        Me.lblBuilderStatus.AutoSize = True
        Me.lblBuilderStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuilderStatus.Location = New System.Drawing.Point(630, 40)
        Me.lblBuilderStatus.Text = "Status"
        Me.cmbBuilderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuilderStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbBuilderStatus.Location = New System.Drawing.Point(700, 37)
        Me.cmbBuilderStatus.Size = New System.Drawing.Size(150, 25)

        Me.lblBuilderPaidBy.AutoSize = True
        Me.lblBuilderPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuilderPaidBy.Location = New System.Drawing.Point(30, 95)
        Me.lblBuilderPaidBy.Text = "Paid By"
        Me.cmbBuilderPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuilderPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbBuilderPaidBy.Location = New System.Drawing.Point(120, 92)
        Me.cmbBuilderPaidBy.Size = New System.Drawing.Size(180, 25)

        Me.lblBuilderMode.AutoSize = True
        Me.lblBuilderMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBuilderMode.Location = New System.Drawing.Point(350, 95)
        Me.lblBuilderMode.Text = "Mode"
        Me.cmbBuilderMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuilderMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbBuilderMode.Location = New System.Drawing.Point(420, 92)
        Me.cmbBuilderMode.Size = New System.Drawing.Size(160, 25)

        '========== ACTIONS ==========
        Me.pnlActions.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.pnlActions.Controls.Add(Me.btnSave)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(0, 545)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(1200, 55)

        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(20, 10)
        Me.btnSave.Size = New System.Drawing.Size(160, 36)
        Me.btnSave.Text = "SAVE EXPENSE"
        Me.btnSave.Enabled = False
        Me.btnSave.UseVisualStyleBackColor = False

        '========== FORM ==========
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(1200, 600)
        Me.Controls.Add(Me.tabExpense)
        Me.Controls.Add(Me.grpCustInfo)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlActions)
        Me.MinimumSize = New System.Drawing.Size(1100, 550)
        Me.Name = "frmExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense Management"
        Me.Tag = "Expense"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvCustomerSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustInfo.ResumeLayout(False)
        Me.grpCustInfo.PerformLayout()
        Me.tabExpense.ResumeLayout(False)
        Me.tabPF.ResumeLayout(False)
        Me.grpPF.ResumeLayout(False)
        Me.grpPF.PerformLayout()
        Me.tabRM.ResumeLayout(False)
        Me.grpRM.ResumeLayout(False)
        Me.grpRM.PerformLayout()
        Me.tabFiRcuPd.ResumeLayout(False)
        Me.grpFiRcuPd.ResumeLayout(False)
        Me.grpFiRcuPd.PerformLayout()
        Me.tabStaff.ResumeLayout(False)
        Me.grpStaff.ResumeLayout(False)
        Me.grpStaff.PerformLayout()
        Me.tabBuilder.ResumeLayout(False)
        Me.grpBuilder.ResumeLayout(False)
        Me.grpBuilder.PerformLayout()
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    '==================== CONTROLS ====================
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNewSearch As Button
    Friend WithEvents dgvCustomerSearch As DataGridView
    Friend WithEvents grpCustInfo As GroupBox
    Friend WithEvents lblInfoName As Label
    Friend WithEvents txtInfoName As TextBox
    Friend WithEvents lblInfoMobile As Label
    Friend WithEvents txtInfoMobile As TextBox
    Friend WithEvents lblInfoLoan As Label
    Friend WithEvents txtInfoLoan As TextBox
    Friend WithEvents lblInfoProduct As Label
    Friend WithEvents txtInfoProduct As TextBox
    Friend WithEvents lblInfoAppNo As Label
    Friend WithEvents txtInfoAppNo As TextBox
    Friend WithEvents lblInfoLoanNo As Label
    Friend WithEvents txtInfoLoanNo As TextBox
    Friend WithEvents tabExpense As TabControl
    Friend WithEvents tabPF As TabPage
    Friend WithEvents grpPF As GroupBox
    Friend WithEvents lblPFAmount As Label
    Friend WithEvents txtPFAmount As TextBox
    Friend WithEvents lblPFDate As Label
    Friend WithEvents dtpPFDate As DateTimePicker
    Friend WithEvents lblPFPaidBy As Label
    Friend WithEvents cmbPFPaidBy As ComboBox
    Friend WithEvents lblPFMode As Label
    Friend WithEvents cmbPFMode As ComboBox
    Friend WithEvents tabRM As TabPage
    Friend WithEvents grpRM As GroupBox
    Friend WithEvents lblRMAmount As Label
    Friend WithEvents txtRMAmount As TextBox
    Friend WithEvents lblRMDate As Label
    Friend WithEvents dtpRMDate As DateTimePicker
    Friend WithEvents lblRMPaidBy As Label
    Friend WithEvents cmbRMPaidBy As ComboBox
    Friend WithEvents lblRMMode As Label
    Friend WithEvents cmbRMMode As ComboBox
    Friend WithEvents tabFiRcuPd As TabPage
    Friend WithEvents grpFiRcuPd As GroupBox
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
    Friend WithEvents grpStaff As GroupBox
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
    Friend WithEvents grpBuilder As GroupBox
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
    Friend WithEvents pnlActions As Panel
    Friend WithEvents btnSave As Button

End Class