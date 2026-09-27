<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpenseIncome
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

        ' Create all controls
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()

        ' ========== CUSTOMER ==========
        Me.tabCustomer = New System.Windows.Forms.TabPage()
        Me.pnlSearchCust = New System.Windows.Forms.Panel()
        Me.lblSearchCust = New System.Windows.Forms.Label()
        Me.txtSearchCustName = New System.Windows.Forms.TextBox()
        Me.lblSearchMobile = New System.Windows.Forms.Label()
        Me.txtSearchMobile = New System.Windows.Forms.TextBox()
        Me.btnSearchCust = New System.Windows.Forms.Button()
        Me.btnClearSearchCust = New System.Windows.Forms.Button()
        Me.grpCustInfo = New System.Windows.Forms.GroupBox()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.lblPropertyNo = New System.Windows.Forms.Label()
        Me.txtPropertyNo = New System.Windows.Forms.TextBox()
        Me.lblPropertyAdd = New System.Windows.Forms.Label()
        Me.txtPropertyAdd = New System.Windows.Forms.TextBox()
        Me.lblLoanAmtCust = New System.Windows.Forms.Label()
        Me.txtLoanAmtCust = New System.Windows.Forms.TextBox()
        Me.lblCPA = New System.Windows.Forms.Label()
        Me.txtCPA = New System.Windows.Forms.TextBox()
        Me.lblBankCust = New System.Windows.Forms.Label()
        Me.txtBankCust = New System.Windows.Forms.TextBox()
        Me.lblCodeCust = New System.Windows.Forms.Label()
        Me.txtCodeCust = New System.Windows.Forms.TextBox()
        Me.lblHODateCust = New System.Windows.Forms.Label()
        Me.txtHODateCust = New System.Windows.Forms.TextBox()
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblTotalReceived = New System.Windows.Forms.Label()
        Me.txtTotalReceived = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.lblReceiveAmount = New System.Windows.Forms.Label()
        Me.txtReceiveAmount = New System.Windows.Forms.TextBox()
        Me.lblReceiveDate = New System.Windows.Forms.Label()
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCreditModeCust = New System.Windows.Forms.Label()
        Me.cboCreditModeCust = New System.Windows.Forms.ComboBox()
        Me.lblWaiver = New System.Windows.Forms.Label()
        Me.txtWaiver = New System.Windows.Forms.TextBox()
        Me.lblRemarksCust = New System.Windows.Forms.Label()
        Me.txtRemarksCust = New System.Windows.Forms.TextBox()
        Me.btnSaveCust = New System.Windows.Forms.Button()
        Me.btnClearCust = New System.Windows.Forms.Button()
        Me.dgvCust = New System.Windows.Forms.DataGridView()
        Me.dgvPaymentHistory = New System.Windows.Forms.DataGridView()

        ' ========== BANK ==========
        Me.tabBank = New System.Windows.Forms.TabPage()
        Me.pnlSearchBank = New System.Windows.Forms.Panel()
        Me.lblSearchBankCust = New System.Windows.Forms.Label()
        Me.txtSearchBankCust = New System.Windows.Forms.TextBox()
        Me.lblSearchBankMobile = New System.Windows.Forms.Label()
        Me.txtSearchBankMobile = New System.Windows.Forms.TextBox()
        Me.btnSearchBank = New System.Windows.Forms.Button()
        Me.btnClearSearchBank = New System.Windows.Forms.Button()
        Me.grpBankInfo = New System.Windows.Forms.GroupBox()
        Me.lblBankCustName = New System.Windows.Forms.Label()
        Me.txtBankCustName = New System.Windows.Forms.TextBox()
        Me.lblBankMobile = New System.Windows.Forms.Label()
        Me.txtBankMobile = New System.Windows.Forms.TextBox()
        Me.lblPropertyNoBank = New System.Windows.Forms.Label()
        Me.txtPropertyNoBank = New System.Windows.Forms.TextBox()
        Me.lblPropertyAddBank = New System.Windows.Forms.Label()
        Me.txtPropertyAddBank = New System.Windows.Forms.TextBox()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblCPABank = New System.Windows.Forms.Label()
        Me.txtCPABank = New System.Windows.Forms.TextBox()
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.lblCodeBank = New System.Windows.Forms.Label()
        Me.txtCodeBank = New System.Windows.Forms.TextBox()
        Me.lblHODateBank = New System.Windows.Forms.Label()
        Me.txtHODateBank = New System.Windows.Forms.TextBox()
        Me.grpBankPayment = New System.Windows.Forms.GroupBox()
        Me.lblPayoutStatus = New System.Windows.Forms.Label()
        Me.cboPayoutStatus = New System.Windows.Forms.ComboBox()
        Me.lblPOCreditAC = New System.Windows.Forms.Label()
        Me.cboPOCreditAC = New System.Windows.Forms.ComboBox()
        Me.lblCreditModeBank = New System.Windows.Forms.Label()
        Me.cboCreditModeBank = New System.Windows.Forms.ComboBox()
        Me.lblCreditDate = New System.Windows.Forms.Label()
        Me.dtpCreditDate = New System.Windows.Forms.DateTimePicker()
        Me.lblGrossPercent = New System.Windows.Forms.Label()
        Me.txtGrossPercent = New System.Windows.Forms.TextBox()
        Me.lblGrossBankPO = New System.Windows.Forms.Label()
        Me.txtGrossBankPO = New System.Windows.Forms.TextBox()
        Me.radTDSPercent = New System.Windows.Forms.RadioButton()
        Me.txtTDSPercent = New System.Windows.Forms.TextBox()
        Me.radTDSFixed = New System.Windows.Forms.RadioButton()
        Me.txtTDSFixedAmount = New System.Windows.Forms.TextBox()
        Me.lblTDS = New System.Windows.Forms.Label()
        Me.txtTDS = New System.Windows.Forms.TextBox()
        Me.lblNetBankPO = New System.Windows.Forms.Label()
        Me.txtNetBankPO = New System.Windows.Forms.TextBox()
        Me.lblRemarksBank = New System.Windows.Forms.Label()
        Me.txtRemarksBank = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSaveBank = New System.Windows.Forms.Button()
        Me.btnClearBank = New System.Windows.Forms.Button()
        Me.dgvBank = New System.Windows.Forms.DataGridView()

        ' ========== INSURANCE ==========
        Me.tabInsurance = New System.Windows.Forms.TabPage()
        Me.pnlSearchIns = New System.Windows.Forms.Panel()
        Me.lblSearchInsCust = New System.Windows.Forms.Label()
        Me.txtSearchInsCust = New System.Windows.Forms.TextBox()
        Me.lblSearchInsMobile = New System.Windows.Forms.Label()
        Me.txtSearchInsMobile = New System.Windows.Forms.TextBox()
        Me.btnSearchIns = New System.Windows.Forms.Button()
        Me.btnClearSearchIns = New System.Windows.Forms.Button()
        Me.grpInsInfo = New System.Windows.Forms.GroupBox()
        Me.lblInsCustName = New System.Windows.Forms.Label()
        Me.txtInsCustName = New System.Windows.Forms.TextBox()
        Me.lblInsMobile = New System.Windows.Forms.Label()
        Me.txtInsMobile = New System.Windows.Forms.TextBox()
        Me.lblInsPropertyNo = New System.Windows.Forms.Label()
        Me.txtInsPropertyNo = New System.Windows.Forms.TextBox()
        Me.lblInsPropertyAdd = New System.Windows.Forms.Label()
        Me.txtInsPropertyAdd = New System.Windows.Forms.TextBox()
        Me.lblInsLoanAmount = New System.Windows.Forms.Label()
        Me.txtInsLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblInsCPA = New System.Windows.Forms.Label()
        Me.txtInsCPA = New System.Windows.Forms.TextBox()
        Me.lblInsBank = New System.Windows.Forms.Label()
        Me.txtInsBank = New System.Windows.Forms.TextBox()
        Me.lblInsCode = New System.Windows.Forms.Label()
        Me.txtInsCode = New System.Windows.Forms.TextBox()
        Me.lblInsHODate = New System.Windows.Forms.Label()
        Me.txtInsHODate = New System.Windows.Forms.TextBox()
        Me.grpInsPayment = New System.Windows.Forms.GroupBox()
        Me.lblInsPayoutStatus = New System.Windows.Forms.Label()
        Me.cboInsPayoutStatus = New System.Windows.Forms.ComboBox()
        Me.lblInsPOCreditAC = New System.Windows.Forms.Label()
        Me.cboInsPOCreditAC = New System.Windows.Forms.ComboBox()
        Me.lblInsCreditMode = New System.Windows.Forms.Label()
        Me.cboInsCreditMode = New System.Windows.Forms.ComboBox()
        Me.lblInsCreditDate = New System.Windows.Forms.Label()
        Me.dtpInsCreditDate = New System.Windows.Forms.DateTimePicker()
        Me.lblInsGrossPercent = New System.Windows.Forms.Label()
        Me.txtInsGrossPercent = New System.Windows.Forms.TextBox()
        Me.lblInsGrossPO = New System.Windows.Forms.Label()
        Me.txtInsGrossPO = New System.Windows.Forms.TextBox()
        Me.radInsTDSPercent = New System.Windows.Forms.RadioButton()
        Me.txtInsTDSPercent = New System.Windows.Forms.TextBox()
        Me.radInsTDSFixed = New System.Windows.Forms.RadioButton()
        Me.txtInsTDSFixed = New System.Windows.Forms.TextBox()
        Me.lblInsTDS = New System.Windows.Forms.Label()
        Me.txtInsTDS = New System.Windows.Forms.TextBox()
        Me.lblInsNetPO = New System.Windows.Forms.Label()
        Me.txtInsNetPO = New System.Windows.Forms.TextBox()
        Me.lblInsRemarks = New System.Windows.Forms.Label()
        Me.txtInsRemarks = New System.Windows.Forms.TextBox()
        Me.btnInsCalculate = New System.Windows.Forms.Button()
        Me.btnSaveIns = New System.Windows.Forms.Button()
        Me.btnClearIns = New System.Windows.Forms.Button()
        Me.dgvInsurance = New System.Windows.Forms.DataGridView()

        ' ========== OTHER ==========
        Me.tabOther = New System.Windows.Forms.TabPage()
        Me.pnlSearchOther = New System.Windows.Forms.Panel()
        Me.lblSearchOtherCust = New System.Windows.Forms.Label()
        Me.txtSearchOtherCust = New System.Windows.Forms.TextBox()
        Me.lblSearchOtherMobile = New System.Windows.Forms.Label()
        Me.txtSearchOtherMobile = New System.Windows.Forms.TextBox()
        Me.btnSearchOther = New System.Windows.Forms.Button()
        Me.btnClearSearchOther = New System.Windows.Forms.Button()
        Me.grpOtherInfo = New System.Windows.Forms.GroupBox()
        Me.lblOtherCustName = New System.Windows.Forms.Label()
        Me.txtOtherCustName = New System.Windows.Forms.TextBox()
        Me.lblOtherMobile = New System.Windows.Forms.Label()
        Me.txtOtherMobile = New System.Windows.Forms.TextBox()
        Me.lblOtherPropertyNo = New System.Windows.Forms.Label()
        Me.txtOtherPropertyNo = New System.Windows.Forms.TextBox()
        Me.lblOtherPropertyAdd = New System.Windows.Forms.Label()
        Me.txtOtherPropertyAdd = New System.Windows.Forms.TextBox()
        Me.lblOtherLoanAmt = New System.Windows.Forms.Label()
        Me.txtOtherLoanAmt = New System.Windows.Forms.TextBox()
        Me.lblOtherCPA = New System.Windows.Forms.Label()
        Me.txtOtherCPA = New System.Windows.Forms.TextBox()
        Me.lblOtherBank = New System.Windows.Forms.Label()
        Me.txtOtherBank = New System.Windows.Forms.TextBox()
        Me.lblOtherCode = New System.Windows.Forms.Label()
        Me.txtOtherCode = New System.Windows.Forms.TextBox()
        Me.lblOtherHODate = New System.Windows.Forms.Label()
        Me.txtOtherHODate = New System.Windows.Forms.TextBox()
        Me.grpOtherSummary = New System.Windows.Forms.GroupBox()
        Me.lblOtherTotalAmount = New System.Windows.Forms.Label()
        Me.txtOtherTotalAmount = New System.Windows.Forms.TextBox()
        Me.lblOtherTotalReceived = New System.Windows.Forms.Label()
        Me.txtOtherTotalReceived = New System.Windows.Forms.TextBox()
        Me.lblOtherBalance = New System.Windows.Forms.Label()
        Me.txtOtherBalance = New System.Windows.Forms.TextBox()
        Me.grpOtherPayment = New System.Windows.Forms.GroupBox()
        Me.lblOtherReceiveAmount = New System.Windows.Forms.Label()
        Me.txtOtherReceiveAmount = New System.Windows.Forms.TextBox()
        Me.lblOtherReceiveDate = New System.Windows.Forms.Label()
        Me.dtpOtherReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.lblOtherCreditMode = New System.Windows.Forms.Label()
        Me.cboOtherCreditMode = New System.Windows.Forms.ComboBox()
        Me.lblOtherWaiver = New System.Windows.Forms.Label()
        Me.txtOtherWaiver = New System.Windows.Forms.TextBox()
        Me.lblOtherRemarks = New System.Windows.Forms.Label()
        Me.txtOtherRemarks = New System.Windows.Forms.TextBox()
        Me.btnSaveOther = New System.Windows.Forms.Button()
        Me.btnClearOther = New System.Windows.Forms.Button()
        Me.dgvOther = New System.Windows.Forms.DataGridView()
        Me.dgvOtherHistory = New System.Windows.Forms.DataGridView()

        ' ========== SUSPEND ==========
        Me.pnlTop.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabCustomer.SuspendLayout()
        Me.pnlSearchCust.SuspendLayout()
        Me.grpCustInfo.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        CType(Me.dgvCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBank.SuspendLayout()
        Me.pnlSearchBank.SuspendLayout()
        Me.grpBankInfo.SuspendLayout()
        Me.grpBankPayment.SuspendLayout()
        CType(Me.dgvBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInsurance.SuspendLayout()
        Me.pnlSearchIns.SuspendLayout()
        Me.grpInsInfo.SuspendLayout()
        Me.grpInsPayment.SuspendLayout()
        CType(Me.dgvInsurance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOther.SuspendLayout()
        Me.pnlSearchOther.SuspendLayout()
        Me.grpOtherInfo.SuspendLayout()
        Me.grpOtherSummary.SuspendLayout()
        Me.grpOtherPayment.SuspendLayout()
        CType(Me.dgvOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOtherHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ========== TOP PANEL ==========
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(31, 78, 121)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblSubTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1400, 55)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(18, 5)
        Me.lblTitle.Text = "INCOME MODULE"

        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSubTitle.Location = New System.Drawing.Point(20, 32)
        Me.lblSubTitle.Text = "Customer  |  Bank  |  Insurance  |  Other"

        ' ========== TAB CONTROL ==========
        Me.tabMain.Controls.Add(Me.tabCustomer)
        Me.tabMain.Controls.Add(Me.tabBank)
        Me.tabMain.Controls.Add(Me.tabInsurance)
        Me.tabMain.Controls.Add(Me.tabOther)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tabMain.ItemSize = New System.Drawing.Size(160, 30)
        Me.tabMain.Location = New System.Drawing.Point(0, 55)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1400, 745)
        Me.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed

        ' ========== CUSTOMER TAB ==========
        Me.tabCustomer.Controls.Add(Me.pnlSearchCust)
        Me.tabCustomer.Controls.Add(Me.grpCustInfo)
        Me.tabCustomer.Controls.Add(Me.grpSummary)
        Me.tabCustomer.Controls.Add(Me.grpPayment)
        Me.tabCustomer.Controls.Add(Me.dgvCust)
        Me.tabCustomer.Controls.Add(Me.dgvPaymentHistory)
        Me.tabCustomer.Location = New System.Drawing.Point(4, 34)
        Me.tabCustomer.Name = "tabCustomer"
        Me.tabCustomer.Padding = New System.Windows.Forms.Padding(8)
        Me.tabCustomer.Size = New System.Drawing.Size(1392, 707)
        Me.tabCustomer.Text = "  CUSTOMER  "
        Me.tabCustomer.UseVisualStyleBackColor = True

        ' Search Customer
        Me.pnlSearchCust.BackColor = System.Drawing.Color.White
        Me.pnlSearchCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchCust.Controls.Add(Me.lblSearchCust)
        Me.pnlSearchCust.Controls.Add(Me.txtSearchCustName)
        Me.pnlSearchCust.Controls.Add(Me.lblSearchMobile)
        Me.pnlSearchCust.Controls.Add(Me.txtSearchMobile)
        Me.pnlSearchCust.Controls.Add(Me.btnSearchCust)
        Me.pnlSearchCust.Controls.Add(Me.btnClearSearchCust)
        Me.pnlSearchCust.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchCust.Location = New System.Drawing.Point(8, 8)
        Me.pnlSearchCust.Name = "pnlSearchCust"
        Me.pnlSearchCust.Size = New System.Drawing.Size(1376, 45)

        Me.lblSearchCust.AutoSize = True
        Me.lblSearchCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchCust.Location = New System.Drawing.Point(12, 12)
        Me.lblSearchCust.Text = "Customer :"

        Me.txtSearchCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchCustName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchCustName.Location = New System.Drawing.Point(100, 9)
        Me.txtSearchCustName.Size = New System.Drawing.Size(200, 25)

        Me.lblSearchMobile.AutoSize = True
        Me.lblSearchMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchMobile.Location = New System.Drawing.Point(320, 12)
        Me.lblSearchMobile.Text = "Mobile :"

        Me.txtSearchMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchMobile.Location = New System.Drawing.Point(390, 9)
        Me.txtSearchMobile.Size = New System.Drawing.Size(150, 25)

        Me.btnSearchCust.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnSearchCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearchCust.ForeColor = System.Drawing.Color.White
        Me.btnSearchCust.Location = New System.Drawing.Point(560, 7)
        Me.btnSearchCust.Size = New System.Drawing.Size(95, 30)
        Me.btnSearchCust.Text = "Search"
        Me.btnSearchCust.UseVisualStyleBackColor = False

        Me.btnClearSearchCust.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearSearchCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearchCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearSearchCust.ForeColor = System.Drawing.Color.White
        Me.btnClearSearchCust.Location = New System.Drawing.Point(665, 7)
        Me.btnClearSearchCust.Size = New System.Drawing.Size(80, 30)
        Me.btnClearSearchCust.Text = "Clear"
        Me.btnClearSearchCust.UseVisualStyleBackColor = False

        ' Customer Info Group
        Me.grpCustInfo.Controls.Add(Me.lblCustName)
        Me.grpCustInfo.Controls.Add(Me.txtCustName)
        Me.grpCustInfo.Controls.Add(Me.lblMobile)
        Me.grpCustInfo.Controls.Add(Me.txtMobileNo)
        Me.grpCustInfo.Controls.Add(Me.lblPropertyNo)
        Me.grpCustInfo.Controls.Add(Me.txtPropertyNo)
        Me.grpCustInfo.Controls.Add(Me.lblLoanAmtCust)
        Me.grpCustInfo.Controls.Add(Me.txtLoanAmtCust)
        Me.grpCustInfo.Controls.Add(Me.lblPropertyAdd)
        Me.grpCustInfo.Controls.Add(Me.txtPropertyAdd)
        Me.grpCustInfo.Controls.Add(Me.lblCPA)
        Me.grpCustInfo.Controls.Add(Me.txtCPA)
        Me.grpCustInfo.Controls.Add(Me.lblBankCust)
        Me.grpCustInfo.Controls.Add(Me.txtBankCust)
        Me.grpCustInfo.Controls.Add(Me.lblCodeCust)
        Me.grpCustInfo.Controls.Add(Me.txtCodeCust)
        Me.grpCustInfo.Controls.Add(Me.lblHODateCust)
        Me.grpCustInfo.Controls.Add(Me.txtHODateCust)
        Me.grpCustInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpCustInfo.Location = New System.Drawing.Point(12, 60)
        Me.grpCustInfo.Name = "grpCustInfo"
        Me.grpCustInfo.Size = New System.Drawing.Size(540, 230)
        Me.grpCustInfo.TabStop = False
        Me.grpCustInfo.Text = "Customer Details"

        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustName.Location = New System.Drawing.Point(15, 28)
        Me.lblCustName.Text = "Name"
        Me.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCustName.Location = New System.Drawing.Point(115, 25)
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(190, 25)

        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMobile.Location = New System.Drawing.Point(320, 28)
        Me.lblMobile.Text = "Mobile"
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtMobileNo.Location = New System.Drawing.Point(390, 25)
        Me.txtMobileNo.ReadOnly = True
        Me.txtMobileNo.Size = New System.Drawing.Size(130, 25)

        Me.lblPropertyNo.AutoSize = True
        Me.lblPropertyNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPropertyNo.Location = New System.Drawing.Point(15, 62)
        Me.lblPropertyNo.Text = "Property No"
        Me.txtPropertyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropertyNo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPropertyNo.Location = New System.Drawing.Point(115, 59)
        Me.txtPropertyNo.ReadOnly = True
        Me.txtPropertyNo.Size = New System.Drawing.Size(190, 25)

        Me.lblLoanAmtCust.AutoSize = True
        Me.lblLoanAmtCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoanAmtCust.Location = New System.Drawing.Point(320, 62)
        Me.lblLoanAmtCust.Text = "Loan Amt"
        Me.txtLoanAmtCust.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtLoanAmtCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmtCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLoanAmtCust.Location = New System.Drawing.Point(390, 59)
        Me.txtLoanAmtCust.ReadOnly = True
        Me.txtLoanAmtCust.Size = New System.Drawing.Size(130, 25)
        Me.txtLoanAmtCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblPropertyAdd.AutoSize = True
        Me.lblPropertyAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPropertyAdd.Location = New System.Drawing.Point(15, 96)
        Me.lblPropertyAdd.Text = "Property Add"
        Me.txtPropertyAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropertyAdd.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPropertyAdd.Location = New System.Drawing.Point(115, 93)
        Me.txtPropertyAdd.ReadOnly = True
        Me.txtPropertyAdd.Size = New System.Drawing.Size(405, 25)

        Me.lblCPA.AutoSize = True
        Me.lblCPA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCPA.Location = New System.Drawing.Point(15, 130)
        Me.lblCPA.Text = "CPA Name"
        Me.txtCPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPA.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCPA.Location = New System.Drawing.Point(115, 127)
        Me.txtCPA.ReadOnly = True
        Me.txtCPA.Size = New System.Drawing.Size(190, 25)

        Me.lblBankCust.AutoSize = True
        Me.lblBankCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBankCust.Location = New System.Drawing.Point(320, 130)
        Me.lblBankCust.Text = "Bank"
        Me.txtBankCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtBankCust.Location = New System.Drawing.Point(390, 127)
        Me.txtBankCust.ReadOnly = True
        Me.txtBankCust.Size = New System.Drawing.Size(130, 25)

        Me.lblCodeCust.AutoSize = True
        Me.lblCodeCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodeCust.Location = New System.Drawing.Point(15, 164)
        Me.lblCodeCust.Text = "Code"
        Me.txtCodeCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodeCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCodeCust.Location = New System.Drawing.Point(115, 161)
        Me.txtCodeCust.ReadOnly = True
        Me.txtCodeCust.Size = New System.Drawing.Size(190, 25)

        Me.lblHODateCust.AutoSize = True
        Me.lblHODateCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHODateCust.Location = New System.Drawing.Point(320, 164)
        Me.lblHODateCust.Text = "HO Date"
        Me.txtHODateCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHODateCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtHODateCust.Location = New System.Drawing.Point(390, 161)
        Me.txtHODateCust.ReadOnly = True
        Me.txtHODateCust.Size = New System.Drawing.Size(130, 25)

        ' Summary
        Me.grpSummary.Controls.Add(Me.lblTotalAmount)
        Me.grpSummary.Controls.Add(Me.txtTotalAmount)
        Me.grpSummary.Controls.Add(Me.lblTotalReceived)
        Me.grpSummary.Controls.Add(Me.txtTotalReceived)
        Me.grpSummary.Controls.Add(Me.lblBalance)
        Me.grpSummary.Controls.Add(Me.txtBalance)
        Me.grpSummary.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpSummary.Location = New System.Drawing.Point(565, 60)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Size = New System.Drawing.Size(250, 230)
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Amount Summary"

        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalAmount.Location = New System.Drawing.Point(18, 45)
        Me.lblTotalAmount.Text = "Exp Offer"
        Me.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalAmount.Location = New System.Drawing.Point(105, 41)
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(125, 27)
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblTotalReceived.AutoSize = True
        Me.lblTotalReceived.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalReceived.Location = New System.Drawing.Point(18, 95)
        Me.lblTotalReceived.Text = "Received"
        Me.txtTotalReceived.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
        Me.txtTotalReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalReceived.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalReceived.Location = New System.Drawing.Point(105, 91)
        Me.txtTotalReceived.ReadOnly = True
        Me.txtTotalReceived.Size = New System.Drawing.Size(125, 27)
        Me.txtTotalReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBalance.Location = New System.Drawing.Point(18, 145)
        Me.lblBalance.Text = "Balance"
        Me.txtBalance.BackColor = System.Drawing.Color.FromArgb(255, 243, 224)
        Me.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBalance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtBalance.Location = New System.Drawing.Point(105, 141)
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(125, 27)
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        ' Payment
        Me.grpPayment.Controls.Add(Me.lblReceiveAmount)
        Me.grpPayment.Controls.Add(Me.txtReceiveAmount)
        Me.grpPayment.Controls.Add(Me.lblReceiveDate)
        Me.grpPayment.Controls.Add(Me.dtpReceiveDate)
        Me.grpPayment.Controls.Add(Me.lblCreditModeCust)
        Me.grpPayment.Controls.Add(Me.cboCreditModeCust)
        Me.grpPayment.Controls.Add(Me.lblWaiver)
        Me.grpPayment.Controls.Add(Me.txtWaiver)
        Me.grpPayment.Controls.Add(Me.lblRemarksCust)
        Me.grpPayment.Controls.Add(Me.txtRemarksCust)
        Me.grpPayment.Controls.Add(Me.btnSaveCust)
        Me.grpPayment.Controls.Add(Me.btnClearCust)
        Me.grpPayment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpPayment.Location = New System.Drawing.Point(830, 60)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(545, 230)
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Add New Payment"

        Me.lblReceiveAmount.AutoSize = True
        Me.lblReceiveAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReceiveAmount.Location = New System.Drawing.Point(18, 35)
        Me.lblReceiveAmount.Text = "Receive Amt"
        Me.txtReceiveAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceiveAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtReceiveAmount.Location = New System.Drawing.Point(125, 32)
        Me.txtReceiveAmount.Size = New System.Drawing.Size(130, 25)
        Me.txtReceiveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblReceiveDate.AutoSize = True
        Me.lblReceiveDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblReceiveDate.Location = New System.Drawing.Point(275, 35)
        Me.lblReceiveDate.Text = "Date"
        Me.dtpReceiveDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpReceiveDate.Location = New System.Drawing.Point(325, 32)
        Me.dtpReceiveDate.Size = New System.Drawing.Size(140, 25)

        Me.lblCreditModeCust.AutoSize = True
        Me.lblCreditModeCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCreditModeCust.Location = New System.Drawing.Point(18, 75)
        Me.lblCreditModeCust.Text = "Credit Mode"
        Me.cboCreditModeCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCreditModeCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboCreditModeCust.Items.AddRange(New Object() {"Cash", "Bank", "NEFT", "RTGS", "UPI", "Cheque", "Card"})
        Me.cboCreditModeCust.Location = New System.Drawing.Point(125, 72)
        Me.cboCreditModeCust.Size = New System.Drawing.Size(130, 25)

        Me.lblWaiver.AutoSize = True
        Me.lblWaiver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblWaiver.Location = New System.Drawing.Point(275, 75)
        Me.lblWaiver.Text = "Waiver"
        Me.txtWaiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWaiver.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtWaiver.Location = New System.Drawing.Point(325, 72)
        Me.txtWaiver.Size = New System.Drawing.Size(140, 25)
        Me.txtWaiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblRemarksCust.AutoSize = True
        Me.lblRemarksCust.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarksCust.Location = New System.Drawing.Point(18, 115)
        Me.lblRemarksCust.Text = "Remarks"
        Me.txtRemarksCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarksCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtRemarksCust.Location = New System.Drawing.Point(125, 112)
        Me.txtRemarksCust.Size = New System.Drawing.Size(340, 25)

        Me.btnSaveCust.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnSaveCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveCust.ForeColor = System.Drawing.Color.White
        Me.btnSaveCust.Location = New System.Drawing.Point(125, 165)
        Me.btnSaveCust.Size = New System.Drawing.Size(160, 35)
        Me.btnSaveCust.Text = "SAVE PAYMENT"
        Me.btnSaveCust.UseVisualStyleBackColor = False

        Me.btnClearCust.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearCust.ForeColor = System.Drawing.Color.White
        Me.btnClearCust.Location = New System.Drawing.Point(305, 165)
        Me.btnClearCust.Size = New System.Drawing.Size(100, 35)
        Me.btnClearCust.Text = "CLEAR"
        Me.btnClearCust.UseVisualStyleBackColor = False

        Me.dgvCust.AllowUserToAddRows = False
        Me.dgvCust.BackgroundColor = System.Drawing.Color.White
        Me.dgvCust.ColumnHeadersHeight = 30
        Me.dgvCust.EnableHeadersVisualStyles = False
        Me.dgvCust.Location = New System.Drawing.Point(12, 300)
        Me.dgvCust.Name = "dgvCust"
        Me.dgvCust.RowHeadersVisible = False
        Me.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCust.Size = New System.Drawing.Size(1360, 160)

        Me.dgvPaymentHistory.AllowUserToAddRows = False
        Me.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvPaymentHistory.ColumnHeadersHeight = 30
        Me.dgvPaymentHistory.EnableHeadersVisualStyles = False
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(12, 470)
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.RowHeadersVisible = False
        Me.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(1360, 210)

        ' ========== BANK TAB ==========
        Me.tabBank.Controls.Add(Me.pnlSearchBank)
        Me.tabBank.Controls.Add(Me.grpBankInfo)
        Me.tabBank.Controls.Add(Me.grpBankPayment)
        Me.tabBank.Controls.Add(Me.dgvBank)
        Me.tabBank.Location = New System.Drawing.Point(4, 34)
        Me.tabBank.Name = "tabBank"
        Me.tabBank.Padding = New System.Windows.Forms.Padding(8)
        Me.tabBank.Size = New System.Drawing.Size(1392, 707)
        Me.tabBank.Text = "  BANK  "
        Me.tabBank.UseVisualStyleBackColor = True

        Me.pnlSearchBank.BackColor = System.Drawing.Color.White
        Me.pnlSearchBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchBank.Controls.Add(Me.lblSearchBankCust)
        Me.pnlSearchBank.Controls.Add(Me.txtSearchBankCust)
        Me.pnlSearchBank.Controls.Add(Me.lblSearchBankMobile)
        Me.pnlSearchBank.Controls.Add(Me.txtSearchBankMobile)
        Me.pnlSearchBank.Controls.Add(Me.btnSearchBank)
        Me.pnlSearchBank.Controls.Add(Me.btnClearSearchBank)
        Me.pnlSearchBank.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchBank.Location = New System.Drawing.Point(8, 8)
        Me.pnlSearchBank.Name = "pnlSearchBank"
        Me.pnlSearchBank.Size = New System.Drawing.Size(1376, 45)

        Me.lblSearchBankCust.AutoSize = True
        Me.lblSearchBankCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchBankCust.Location = New System.Drawing.Point(12, 12)
        Me.lblSearchBankCust.Text = "Customer :"
        Me.txtSearchBankCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBankCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchBankCust.Location = New System.Drawing.Point(100, 9)
        Me.txtSearchBankCust.Size = New System.Drawing.Size(200, 25)
        Me.lblSearchBankMobile.AutoSize = True
        Me.lblSearchBankMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchBankMobile.Location = New System.Drawing.Point(320, 12)
        Me.lblSearchBankMobile.Text = "Mobile :"
        Me.txtSearchBankMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchBankMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchBankMobile.Location = New System.Drawing.Point(390, 9)
        Me.txtSearchBankMobile.Size = New System.Drawing.Size(150, 25)
        Me.btnSearchBank.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnSearchBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchBank.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearchBank.ForeColor = System.Drawing.Color.White
        Me.btnSearchBank.Location = New System.Drawing.Point(560, 7)
        Me.btnSearchBank.Size = New System.Drawing.Size(95, 30)
        Me.btnSearchBank.Text = "Search"
        Me.btnSearchBank.UseVisualStyleBackColor = False
        Me.btnClearSearchBank.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearSearchBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearchBank.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearSearchBank.ForeColor = System.Drawing.Color.White
        Me.btnClearSearchBank.Location = New System.Drawing.Point(665, 7)
        Me.btnClearSearchBank.Size = New System.Drawing.Size(80, 30)
        Me.btnClearSearchBank.Text = "Clear"
        Me.btnClearSearchBank.UseVisualStyleBackColor = False

        Me.grpBankInfo.Controls.Add(Me.lblBankCustName)
        Me.grpBankInfo.Controls.Add(Me.txtBankCustName)
        Me.grpBankInfo.Controls.Add(Me.lblBankMobile)
        Me.grpBankInfo.Controls.Add(Me.txtBankMobile)
        Me.grpBankInfo.Controls.Add(Me.lblPropertyNoBank)
        Me.grpBankInfo.Controls.Add(Me.txtPropertyNoBank)
        Me.grpBankInfo.Controls.Add(Me.lblLoanAmount)
        Me.grpBankInfo.Controls.Add(Me.txtLoanAmount)
        Me.grpBankInfo.Controls.Add(Me.lblPropertyAddBank)
        Me.grpBankInfo.Controls.Add(Me.txtPropertyAddBank)
        Me.grpBankInfo.Controls.Add(Me.lblCPABank)
        Me.grpBankInfo.Controls.Add(Me.txtCPABank)
        Me.grpBankInfo.Controls.Add(Me.lblBankName)
        Me.grpBankInfo.Controls.Add(Me.txtBankName)
        Me.grpBankInfo.Controls.Add(Me.lblCodeBank)
        Me.grpBankInfo.Controls.Add(Me.txtCodeBank)
        Me.grpBankInfo.Controls.Add(Me.lblHODateBank)
        Me.grpBankInfo.Controls.Add(Me.txtHODateBank)
        Me.grpBankInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBankInfo.Location = New System.Drawing.Point(12, 60)
        Me.grpBankInfo.Name = "grpBankInfo"
        Me.grpBankInfo.Size = New System.Drawing.Size(540, 230)
        Me.grpBankInfo.TabStop = False
        Me.grpBankInfo.Text = "Customer / Loan Info"

        Me.lblBankCustName.AutoSize = True
        Me.lblBankCustName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBankCustName.Location = New System.Drawing.Point(15, 28)
        Me.lblBankCustName.Text = "Name"
        Me.txtBankCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankCustName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtBankCustName.Location = New System.Drawing.Point(115, 25)
        Me.txtBankCustName.ReadOnly = True
        Me.txtBankCustName.Size = New System.Drawing.Size(190, 25)

        Me.lblBankMobile.AutoSize = True
        Me.lblBankMobile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBankMobile.Location = New System.Drawing.Point(320, 28)
        Me.lblBankMobile.Text = "Mobile"
        Me.txtBankMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtBankMobile.Location = New System.Drawing.Point(390, 25)
        Me.txtBankMobile.ReadOnly = True
        Me.txtBankMobile.Size = New System.Drawing.Size(130, 25)

        Me.lblPropertyNoBank.AutoSize = True
        Me.lblPropertyNoBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPropertyNoBank.Location = New System.Drawing.Point(15, 62)
        Me.lblPropertyNoBank.Text = "Property No"
        Me.txtPropertyNoBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropertyNoBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPropertyNoBank.Location = New System.Drawing.Point(115, 59)
        Me.txtPropertyNoBank.ReadOnly = True
        Me.txtPropertyNoBank.Size = New System.Drawing.Size(190, 25)

        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLoanAmount.Location = New System.Drawing.Point(320, 62)
        Me.lblLoanAmount.Text = "Loan Amt"
        Me.txtLoanAmount.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtLoanAmount.Location = New System.Drawing.Point(390, 59)
        Me.txtLoanAmount.ReadOnly = True
        Me.txtLoanAmount.Size = New System.Drawing.Size(130, 25)
        Me.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblPropertyAddBank.AutoSize = True
        Me.lblPropertyAddBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPropertyAddBank.Location = New System.Drawing.Point(15, 96)
        Me.lblPropertyAddBank.Text = "Property Add"
        Me.txtPropertyAddBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPropertyAddBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtPropertyAddBank.Location = New System.Drawing.Point(115, 93)
        Me.txtPropertyAddBank.ReadOnly = True
        Me.txtPropertyAddBank.Size = New System.Drawing.Size(405, 25)

        Me.lblCPABank.AutoSize = True
        Me.lblCPABank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCPABank.Location = New System.Drawing.Point(15, 130)
        Me.lblCPABank.Text = "CPA Name"
        Me.txtCPABank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPABank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCPABank.Location = New System.Drawing.Point(115, 127)
        Me.txtCPABank.ReadOnly = True
        Me.txtCPABank.Size = New System.Drawing.Size(190, 25)

        Me.lblBankName.AutoSize = True
        Me.lblBankName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBankName.Location = New System.Drawing.Point(320, 130)
        Me.lblBankName.Text = "Bank"
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtBankName.Location = New System.Drawing.Point(390, 127)
        Me.txtBankName.ReadOnly = True
        Me.txtBankName.Size = New System.Drawing.Size(130, 25)

        Me.lblCodeBank.AutoSize = True
        Me.lblCodeBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodeBank.Location = New System.Drawing.Point(15, 164)
        Me.lblCodeBank.Text = "Code"
        Me.txtCodeBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodeBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtCodeBank.Location = New System.Drawing.Point(115, 161)
        Me.txtCodeBank.ReadOnly = True
        Me.txtCodeBank.Size = New System.Drawing.Size(190, 25)

        Me.lblHODateBank.AutoSize = True
        Me.lblHODateBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblHODateBank.Location = New System.Drawing.Point(320, 164)
        Me.lblHODateBank.Text = "HO Date"
        Me.txtHODateBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHODateBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtHODateBank.Location = New System.Drawing.Point(390, 161)
        Me.txtHODateBank.ReadOnly = True
        Me.txtHODateBank.Size = New System.Drawing.Size(130, 25)

        Me.grpBankPayment.Controls.Add(Me.lblPayoutStatus)
        Me.grpBankPayment.Controls.Add(Me.cboPayoutStatus)
        Me.grpBankPayment.Controls.Add(Me.lblPOCreditAC)
        Me.grpBankPayment.Controls.Add(Me.cboPOCreditAC)
        Me.grpBankPayment.Controls.Add(Me.lblCreditModeBank)
        Me.grpBankPayment.Controls.Add(Me.cboCreditModeBank)
        Me.grpBankPayment.Controls.Add(Me.lblCreditDate)
        Me.grpBankPayment.Controls.Add(Me.dtpCreditDate)
        Me.grpBankPayment.Controls.Add(Me.lblGrossPercent)
        Me.grpBankPayment.Controls.Add(Me.txtGrossPercent)
        Me.grpBankPayment.Controls.Add(Me.lblGrossBankPO)
        Me.grpBankPayment.Controls.Add(Me.txtGrossBankPO)
        Me.grpBankPayment.Controls.Add(Me.radTDSPercent)
        Me.grpBankPayment.Controls.Add(Me.txtTDSPercent)
        Me.grpBankPayment.Controls.Add(Me.radTDSFixed)
        Me.grpBankPayment.Controls.Add(Me.txtTDSFixedAmount)
        Me.grpBankPayment.Controls.Add(Me.lblTDS)
        Me.grpBankPayment.Controls.Add(Me.txtTDS)
        Me.grpBankPayment.Controls.Add(Me.lblNetBankPO)
        Me.grpBankPayment.Controls.Add(Me.txtNetBankPO)
        Me.grpBankPayment.Controls.Add(Me.lblRemarksBank)
        Me.grpBankPayment.Controls.Add(Me.txtRemarksBank)
        Me.grpBankPayment.Controls.Add(Me.btnCalculate)
        Me.grpBankPayment.Controls.Add(Me.btnSaveBank)
        Me.grpBankPayment.Controls.Add(Me.btnClearBank)
        Me.grpBankPayment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpBankPayment.Location = New System.Drawing.Point(565, 60)
        Me.grpBankPayment.Name = "grpBankPayment"
        Me.grpBankPayment.Size = New System.Drawing.Size(810, 280)
        Me.grpBankPayment.TabStop = False
        Me.grpBankPayment.Text = "Bank Payout Details"

        Me.lblPayoutStatus.AutoSize = True
        Me.lblPayoutStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPayoutStatus.Location = New System.Drawing.Point(18, 32)
        Me.lblPayoutStatus.Text = "Payout Status"
        Me.cboPayoutStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayoutStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboPayoutStatus.Items.AddRange(New Object() {"PENDING", "RECEIVED", "INSURANCE"})
        Me.cboPayoutStatus.Location = New System.Drawing.Point(125, 28)
        Me.cboPayoutStatus.Size = New System.Drawing.Size(140, 25)

        Me.lblPOCreditAC.AutoSize = True
        Me.lblPOCreditAC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPOCreditAC.Location = New System.Drawing.Point(285, 32)
        Me.lblPOCreditAC.Text = "Credit A/C"
        Me.cboPOCreditAC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPOCreditAC.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboPOCreditAC.Items.AddRange(New Object() {"UNIQUE FINSERV-KOTAK", "SUMIT KATHIRIYA", "CHANDRAKANT PATEL", "ALPESH LAKHANI", "CHIRAG LATHIYA"})
        Me.cboPOCreditAC.Location = New System.Drawing.Point(365, 28)
        Me.cboPOCreditAC.Size = New System.Drawing.Size(220, 25)

        Me.lblCreditModeBank.AutoSize = True
        Me.lblCreditModeBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCreditModeBank.Location = New System.Drawing.Point(605, 32)
        Me.lblCreditModeBank.Text = "Mode"
        Me.cboCreditModeBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCreditModeBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboCreditModeBank.Items.AddRange(New Object() {"BANK", "CASH"})
        Me.cboCreditModeBank.Location = New System.Drawing.Point(655, 28)
        Me.cboCreditModeBank.Size = New System.Drawing.Size(100, 25)

        Me.lblCreditDate.AutoSize = True
        Me.lblCreditDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCreditDate.Location = New System.Drawing.Point(18, 72)
        Me.lblCreditDate.Text = "Credit Date"
        Me.dtpCreditDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpCreditDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpCreditDate.Location = New System.Drawing.Point(125, 68)
        Me.dtpCreditDate.Size = New System.Drawing.Size(140, 25)

        Me.lblGrossPercent.AutoSize = True
        Me.lblGrossPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrossPercent.Location = New System.Drawing.Point(285, 72)
        Me.lblGrossPercent.Text = "Gross %"
        Me.txtGrossPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPercent.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtGrossPercent.Location = New System.Drawing.Point(365, 68)
        Me.txtGrossPercent.Size = New System.Drawing.Size(80, 25)
        Me.txtGrossPercent.Text = "0.90"
        Me.txtGrossPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblGrossBankPO.AutoSize = True
        Me.lblGrossBankPO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrossBankPO.Location = New System.Drawing.Point(465, 72)
        Me.lblGrossBankPO.Text = "Gross PO"
        Me.txtGrossBankPO.BackColor = System.Drawing.Color.FromArgb(255, 249, 196)
        Me.txtGrossBankPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossBankPO.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtGrossBankPO.Location = New System.Drawing.Point(545, 68)
        Me.txtGrossBankPO.ReadOnly = True
        Me.txtGrossBankPO.Size = New System.Drawing.Size(210, 25)
        Me.txtGrossBankPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.radTDSPercent.AutoSize = True
        Me.radTDSPercent.Checked = True
        Me.radTDSPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radTDSPercent.Location = New System.Drawing.Point(18, 115)
        Me.radTDSPercent.Text = "TDS %"
        Me.txtTDSPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTDSPercent.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTDSPercent.Location = New System.Drawing.Point(100, 112)
        Me.txtTDSPercent.Size = New System.Drawing.Size(70, 25)
        Me.txtTDSPercent.Text = "2"
        Me.txtTDSPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.radTDSFixed.AutoSize = True
        Me.radTDSFixed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radTDSFixed.Location = New System.Drawing.Point(190, 115)
        Me.radTDSFixed.Text = "Fixed Amt"
        Me.txtTDSFixedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTDSFixedAmount.Enabled = False
        Me.txtTDSFixedAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTDSFixedAmount.Location = New System.Drawing.Point(290, 112)
        Me.txtTDSFixedAmount.Size = New System.Drawing.Size(100, 25)
        Me.txtTDSFixedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblTDS.AutoSize = True
        Me.lblTDS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTDS.Location = New System.Drawing.Point(420, 115)
        Me.lblTDS.Text = "TDS"
        Me.txtTDS.BackColor = System.Drawing.Color.FromArgb(255, 235, 238)
        Me.txtTDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTDS.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtTDS.Location = New System.Drawing.Point(460, 112)
        Me.txtTDS.ReadOnly = True
        Me.txtTDS.Size = New System.Drawing.Size(110, 25)
        Me.txtTDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblNetBankPO.AutoSize = True
        Me.lblNetBankPO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetBankPO.Location = New System.Drawing.Point(590, 115)
        Me.lblNetBankPO.Text = "Net"
        Me.txtNetBankPO.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
        Me.txtNetBankPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetBankPO.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtNetBankPO.Location = New System.Drawing.Point(630, 112)
        Me.txtNetBankPO.ReadOnly = True
        Me.txtNetBankPO.Size = New System.Drawing.Size(125, 25)
        Me.txtNetBankPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblRemarksBank.AutoSize = True
        Me.lblRemarksBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRemarksBank.Location = New System.Drawing.Point(18, 158)
        Me.lblRemarksBank.Text = "Remarks"
        Me.txtRemarksBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarksBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtRemarksBank.Location = New System.Drawing.Point(125, 155)
        Me.txtRemarksBank.Size = New System.Drawing.Size(630, 25)

        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(255, 193, 7)
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(280, 210)
        Me.btnCalculate.Size = New System.Drawing.Size(120, 35)
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False

        Me.btnSaveBank.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnSaveBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveBank.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveBank.ForeColor = System.Drawing.Color.White
        Me.btnSaveBank.Location = New System.Drawing.Point(420, 210)
        Me.btnSaveBank.Size = New System.Drawing.Size(180, 35)
        Me.btnSaveBank.Text = "SAVE BANK PAYOUT"
        Me.btnSaveBank.UseVisualStyleBackColor = False

        Me.btnClearBank.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearBank.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearBank.ForeColor = System.Drawing.Color.White
        Me.btnClearBank.Location = New System.Drawing.Point(620, 210)
        Me.btnClearBank.Size = New System.Drawing.Size(110, 35)
        Me.btnClearBank.Text = "CLEAR"
        Me.btnClearBank.UseVisualStyleBackColor = False

        Me.dgvBank.AllowUserToAddRows = False
        Me.dgvBank.BackgroundColor = System.Drawing.Color.White
        Me.dgvBank.ColumnHeadersHeight = 30
        Me.dgvBank.EnableHeadersVisualStyles = False
        Me.dgvBank.Location = New System.Drawing.Point(12, 355)
        Me.dgvBank.Name = "dgvBank"
        Me.dgvBank.RowHeadersVisible = False
        Me.dgvBank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBank.Size = New System.Drawing.Size(1360, 325)

        ' ========== INSURANCE TAB ==========
        Me.tabInsurance.Controls.Add(Me.pnlSearchIns)
        Me.tabInsurance.Controls.Add(Me.grpInsInfo)
        Me.tabInsurance.Controls.Add(Me.grpInsPayment)
        Me.tabInsurance.Controls.Add(Me.dgvInsurance)
        Me.tabInsurance.Location = New System.Drawing.Point(4, 34)
        Me.tabInsurance.Name = "tabInsurance"
        Me.tabInsurance.Padding = New System.Windows.Forms.Padding(8)
        Me.tabInsurance.Size = New System.Drawing.Size(1392, 707)
        Me.tabInsurance.Text = "  INSURANCE  "
        Me.tabInsurance.UseVisualStyleBackColor = True

        Me.pnlSearchIns.BackColor = System.Drawing.Color.White
        Me.pnlSearchIns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchIns.Controls.Add(Me.lblSearchInsCust)
        Me.pnlSearchIns.Controls.Add(Me.txtSearchInsCust)
        Me.pnlSearchIns.Controls.Add(Me.lblSearchInsMobile)
        Me.pnlSearchIns.Controls.Add(Me.txtSearchInsMobile)
        Me.pnlSearchIns.Controls.Add(Me.btnSearchIns)
        Me.pnlSearchIns.Controls.Add(Me.btnClearSearchIns)
        Me.pnlSearchIns.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchIns.Location = New System.Drawing.Point(8, 8)
        Me.pnlSearchIns.Name = "pnlSearchIns"
        Me.pnlSearchIns.Size = New System.Drawing.Size(1376, 45)

        Me.lblSearchInsCust.AutoSize = True
        Me.lblSearchInsCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchInsCust.Location = New System.Drawing.Point(12, 12)
        Me.lblSearchInsCust.Text = "Customer :"
        Me.txtSearchInsCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchInsCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchInsCust.Location = New System.Drawing.Point(100, 9)
        Me.txtSearchInsCust.Size = New System.Drawing.Size(200, 25)
        Me.lblSearchInsMobile.AutoSize = True
        Me.lblSearchInsMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchInsMobile.Location = New System.Drawing.Point(320, 12)
        Me.lblSearchInsMobile.Text = "Mobile :"
        Me.txtSearchInsMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchInsMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchInsMobile.Location = New System.Drawing.Point(390, 9)
        Me.txtSearchInsMobile.Size = New System.Drawing.Size(150, 25)
        Me.btnSearchIns.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnSearchIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchIns.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearchIns.ForeColor = System.Drawing.Color.White
        Me.btnSearchIns.Location = New System.Drawing.Point(560, 7)
        Me.btnSearchIns.Size = New System.Drawing.Size(95, 30)
        Me.btnSearchIns.Text = "Search"
        Me.btnSearchIns.UseVisualStyleBackColor = False
        Me.btnClearSearchIns.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearSearchIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearchIns.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearSearchIns.ForeColor = System.Drawing.Color.White
        Me.btnClearSearchIns.Location = New System.Drawing.Point(665, 7)
        Me.btnClearSearchIns.Size = New System.Drawing.Size(80, 30)
        Me.btnClearSearchIns.Text = "Clear"
        Me.btnClearSearchIns.UseVisualStyleBackColor = False

        Me.grpInsInfo.Controls.Add(Me.lblInsCustName)
        Me.grpInsInfo.Controls.Add(Me.txtInsCustName)
        Me.grpInsInfo.Controls.Add(Me.lblInsMobile)
        Me.grpInsInfo.Controls.Add(Me.txtInsMobile)
        Me.grpInsInfo.Controls.Add(Me.lblInsPropertyNo)
        Me.grpInsInfo.Controls.Add(Me.txtInsPropertyNo)
        Me.grpInsInfo.Controls.Add(Me.lblInsLoanAmount)
        Me.grpInsInfo.Controls.Add(Me.txtInsLoanAmount)
        Me.grpInsInfo.Controls.Add(Me.lblInsPropertyAdd)
        Me.grpInsInfo.Controls.Add(Me.txtInsPropertyAdd)
        Me.grpInsInfo.Controls.Add(Me.lblInsCPA)
        Me.grpInsInfo.Controls.Add(Me.txtInsCPA)
        Me.grpInsInfo.Controls.Add(Me.lblInsBank)
        Me.grpInsInfo.Controls.Add(Me.txtInsBank)
        Me.grpInsInfo.Controls.Add(Me.lblInsCode)
        Me.grpInsInfo.Controls.Add(Me.txtInsCode)
        Me.grpInsInfo.Controls.Add(Me.lblInsHODate)
        Me.grpInsInfo.Controls.Add(Me.txtInsHODate)
        Me.grpInsInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpInsInfo.Location = New System.Drawing.Point(12, 60)
        Me.grpInsInfo.Name = "grpInsInfo"
        Me.grpInsInfo.Size = New System.Drawing.Size(540, 230)
        Me.grpInsInfo.TabStop = False
        Me.grpInsInfo.Text = "Customer / Loan Info"

        Me.lblInsCustName.AutoSize = True
        Me.lblInsCustName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsCustName.Location = New System.Drawing.Point(15, 28)
        Me.lblInsCustName.Text = "Name"
        Me.txtInsCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsCustName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsCustName.Location = New System.Drawing.Point(115, 25)
        Me.txtInsCustName.ReadOnly = True
        Me.txtInsCustName.Size = New System.Drawing.Size(190, 25)

        Me.lblInsMobile.AutoSize = True
        Me.lblInsMobile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsMobile.Location = New System.Drawing.Point(320, 28)
        Me.lblInsMobile.Text = "Mobile"
        Me.txtInsMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsMobile.Location = New System.Drawing.Point(390, 25)
        Me.txtInsMobile.ReadOnly = True
        Me.txtInsMobile.Size = New System.Drawing.Size(130, 25)

        Me.lblInsPropertyNo.AutoSize = True
        Me.lblInsPropertyNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsPropertyNo.Location = New System.Drawing.Point(15, 62)
        Me.lblInsPropertyNo.Text = "Property No"
        Me.txtInsPropertyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsPropertyNo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsPropertyNo.Location = New System.Drawing.Point(115, 59)
        Me.txtInsPropertyNo.ReadOnly = True
        Me.txtInsPropertyNo.Size = New System.Drawing.Size(190, 25)

        Me.lblInsLoanAmount.AutoSize = True
        Me.lblInsLoanAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsLoanAmount.Location = New System.Drawing.Point(320, 62)
        Me.lblInsLoanAmount.Text = "Loan Amt"
        Me.txtInsLoanAmount.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtInsLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsLoanAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsLoanAmount.Location = New System.Drawing.Point(390, 59)
        Me.txtInsLoanAmount.ReadOnly = True
        Me.txtInsLoanAmount.Size = New System.Drawing.Size(130, 25)
        Me.txtInsLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblInsPropertyAdd.AutoSize = True
        Me.lblInsPropertyAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsPropertyAdd.Location = New System.Drawing.Point(15, 96)
        Me.lblInsPropertyAdd.Text = "Property Add"
        Me.txtInsPropertyAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsPropertyAdd.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsPropertyAdd.Location = New System.Drawing.Point(115, 93)
        Me.txtInsPropertyAdd.ReadOnly = True
        Me.txtInsPropertyAdd.Size = New System.Drawing.Size(405, 25)

        Me.lblInsCPA.AutoSize = True
        Me.lblInsCPA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsCPA.Location = New System.Drawing.Point(15, 130)
        Me.lblInsCPA.Text = "CPA Name"
        Me.txtInsCPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsCPA.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsCPA.Location = New System.Drawing.Point(115, 127)
        Me.txtInsCPA.ReadOnly = True
        Me.txtInsCPA.Size = New System.Drawing.Size(190, 25)

        Me.lblInsBank.AutoSize = True
        Me.lblInsBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsBank.Location = New System.Drawing.Point(320, 130)
        Me.lblInsBank.Text = "Bank"
        Me.txtInsBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsBank.Location = New System.Drawing.Point(390, 127)
        Me.txtInsBank.ReadOnly = True
        Me.txtInsBank.Size = New System.Drawing.Size(130, 25)

        Me.lblInsCode.AutoSize = True
        Me.lblInsCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsCode.Location = New System.Drawing.Point(15, 164)
        Me.lblInsCode.Text = "Code"
        Me.txtInsCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsCode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsCode.Location = New System.Drawing.Point(115, 161)
        Me.txtInsCode.ReadOnly = True
        Me.txtInsCode.Size = New System.Drawing.Size(190, 25)

        Me.lblInsHODate.AutoSize = True
        Me.lblInsHODate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsHODate.Location = New System.Drawing.Point(320, 164)
        Me.lblInsHODate.Text = "HO Date"
        Me.txtInsHODate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsHODate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsHODate.Location = New System.Drawing.Point(390, 161)
        Me.txtInsHODate.ReadOnly = True
        Me.txtInsHODate.Size = New System.Drawing.Size(130, 25)

        Me.grpInsPayment.Controls.Add(Me.lblInsPayoutStatus)
        Me.grpInsPayment.Controls.Add(Me.cboInsPayoutStatus)
        Me.grpInsPayment.Controls.Add(Me.lblInsPOCreditAC)
        Me.grpInsPayment.Controls.Add(Me.cboInsPOCreditAC)
        Me.grpInsPayment.Controls.Add(Me.lblInsCreditMode)
        Me.grpInsPayment.Controls.Add(Me.cboInsCreditMode)
        Me.grpInsPayment.Controls.Add(Me.lblInsCreditDate)
        Me.grpInsPayment.Controls.Add(Me.dtpInsCreditDate)
        Me.grpInsPayment.Controls.Add(Me.lblInsGrossPercent)
        Me.grpInsPayment.Controls.Add(Me.txtInsGrossPercent)
        Me.grpInsPayment.Controls.Add(Me.lblInsGrossPO)
        Me.grpInsPayment.Controls.Add(Me.txtInsGrossPO)
        Me.grpInsPayment.Controls.Add(Me.radInsTDSPercent)
        Me.grpInsPayment.Controls.Add(Me.txtInsTDSPercent)
        Me.grpInsPayment.Controls.Add(Me.radInsTDSFixed)
        Me.grpInsPayment.Controls.Add(Me.txtInsTDSFixed)
        Me.grpInsPayment.Controls.Add(Me.lblInsTDS)
        Me.grpInsPayment.Controls.Add(Me.txtInsTDS)
        Me.grpInsPayment.Controls.Add(Me.lblInsNetPO)
        Me.grpInsPayment.Controls.Add(Me.txtInsNetPO)
        Me.grpInsPayment.Controls.Add(Me.lblInsRemarks)
        Me.grpInsPayment.Controls.Add(Me.txtInsRemarks)
        Me.grpInsPayment.Controls.Add(Me.btnInsCalculate)
        Me.grpInsPayment.Controls.Add(Me.btnSaveIns)
        Me.grpInsPayment.Controls.Add(Me.btnClearIns)
        Me.grpInsPayment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpInsPayment.Location = New System.Drawing.Point(565, 60)
        Me.grpInsPayment.Name = "grpInsPayment"
        Me.grpInsPayment.Size = New System.Drawing.Size(810, 280)
        Me.grpInsPayment.TabStop = False
        Me.grpInsPayment.Text = "Insurance Payout Details"

        Me.lblInsPayoutStatus.AutoSize = True
        Me.lblInsPayoutStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsPayoutStatus.Location = New System.Drawing.Point(18, 32)
        Me.lblInsPayoutStatus.Text = "Payout Status"
        Me.cboInsPayoutStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsPayoutStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboInsPayoutStatus.Items.AddRange(New Object() {"PENDING", "RECEIVED", "INSURANCE"})
        Me.cboInsPayoutStatus.Location = New System.Drawing.Point(125, 28)
        Me.cboInsPayoutStatus.Size = New System.Drawing.Size(140, 25)

        Me.lblInsPOCreditAC.AutoSize = True
        Me.lblInsPOCreditAC.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsPOCreditAC.Location = New System.Drawing.Point(285, 32)
        Me.lblInsPOCreditAC.Text = "Credit A/C"
        Me.cboInsPOCreditAC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsPOCreditAC.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboInsPOCreditAC.Items.AddRange(New Object() {"UNIQUE FINSERV-KOTAK", "SUMIT KATHIRIYA", "CHANDRAKANT PATEL", "ALPESH LAKHANI", "CHIRAG LATHIYA"})
        Me.cboInsPOCreditAC.Location = New System.Drawing.Point(365, 28)
        Me.cboInsPOCreditAC.Size = New System.Drawing.Size(220, 25)

        Me.lblInsCreditMode.AutoSize = True
        Me.lblInsCreditMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsCreditMode.Location = New System.Drawing.Point(605, 32)
        Me.lblInsCreditMode.Text = "Mode"
        Me.cboInsCreditMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInsCreditMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboInsCreditMode.Items.AddRange(New Object() {"BANK", "CASH"})
        Me.cboInsCreditMode.Location = New System.Drawing.Point(655, 28)
        Me.cboInsCreditMode.Size = New System.Drawing.Size(100, 25)

        Me.lblInsCreditDate.AutoSize = True
        Me.lblInsCreditDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsCreditDate.Location = New System.Drawing.Point(18, 72)
        Me.lblInsCreditDate.Text = "Credit Date"
        Me.dtpInsCreditDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpInsCreditDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpInsCreditDate.Location = New System.Drawing.Point(125, 68)
        Me.dtpInsCreditDate.Size = New System.Drawing.Size(140, 25)

        Me.lblInsGrossPercent.AutoSize = True
        Me.lblInsGrossPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsGrossPercent.Location = New System.Drawing.Point(285, 72)
        Me.lblInsGrossPercent.Text = "Gross %"
        Me.txtInsGrossPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsGrossPercent.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsGrossPercent.Location = New System.Drawing.Point(365, 68)
        Me.txtInsGrossPercent.Size = New System.Drawing.Size(80, 25)
        Me.txtInsGrossPercent.Text = "0.90"
        Me.txtInsGrossPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblInsGrossPO.AutoSize = True
        Me.lblInsGrossPO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsGrossPO.Location = New System.Drawing.Point(465, 72)
        Me.lblInsGrossPO.Text = "Gross PO"
        Me.txtInsGrossPO.BackColor = System.Drawing.Color.FromArgb(255, 249, 196)
        Me.txtInsGrossPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsGrossPO.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsGrossPO.Location = New System.Drawing.Point(545, 68)
        Me.txtInsGrossPO.ReadOnly = True
        Me.txtInsGrossPO.Size = New System.Drawing.Size(210, 25)
        Me.txtInsGrossPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.radInsTDSPercent.AutoSize = True
        Me.radInsTDSPercent.Checked = True
        Me.radInsTDSPercent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radInsTDSPercent.Location = New System.Drawing.Point(18, 115)
        Me.radInsTDSPercent.Text = "TDS %"
        Me.txtInsTDSPercent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsTDSPercent.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsTDSPercent.Location = New System.Drawing.Point(100, 112)
        Me.txtInsTDSPercent.Size = New System.Drawing.Size(70, 25)
        Me.txtInsTDSPercent.Text = "2"
        Me.txtInsTDSPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.radInsTDSFixed.AutoSize = True
        Me.radInsTDSFixed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.radInsTDSFixed.Location = New System.Drawing.Point(190, 115)
        Me.radInsTDSFixed.Text = "Fixed Amt"
        Me.txtInsTDSFixed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsTDSFixed.Enabled = False
        Me.txtInsTDSFixed.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsTDSFixed.Location = New System.Drawing.Point(290, 112)
        Me.txtInsTDSFixed.Size = New System.Drawing.Size(100, 25)
        Me.txtInsTDSFixed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblInsTDS.AutoSize = True
        Me.lblInsTDS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsTDS.Location = New System.Drawing.Point(420, 115)
        Me.lblInsTDS.Text = "TDS"
        Me.txtInsTDS.BackColor = System.Drawing.Color.FromArgb(255, 235, 238)
        Me.txtInsTDS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsTDS.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsTDS.Location = New System.Drawing.Point(460, 112)
        Me.txtInsTDS.ReadOnly = True
        Me.txtInsTDS.Size = New System.Drawing.Size(110, 25)
        Me.txtInsTDS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblInsNetPO.AutoSize = True
        Me.lblInsNetPO.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsNetPO.Location = New System.Drawing.Point(590, 115)
        Me.lblInsNetPO.Text = "Net"
        Me.txtInsNetPO.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
        Me.txtInsNetPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsNetPO.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtInsNetPO.Location = New System.Drawing.Point(630, 112)
        Me.txtInsNetPO.ReadOnly = True
        Me.txtInsNetPO.Size = New System.Drawing.Size(125, 25)
        Me.txtInsNetPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblInsRemarks.AutoSize = True
        Me.lblInsRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInsRemarks.Location = New System.Drawing.Point(18, 158)
        Me.lblInsRemarks.Text = "Remarks"
        Me.txtInsRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInsRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtInsRemarks.Location = New System.Drawing.Point(125, 155)
        Me.txtInsRemarks.Size = New System.Drawing.Size(630, 25)

        Me.btnInsCalculate.BackColor = System.Drawing.Color.FromArgb(255, 193, 7)
        Me.btnInsCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsCalculate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnInsCalculate.Location = New System.Drawing.Point(280, 210)
        Me.btnInsCalculate.Size = New System.Drawing.Size(120, 35)
        Me.btnInsCalculate.Text = "Calculate"
        Me.btnInsCalculate.UseVisualStyleBackColor = False

        Me.btnSaveIns.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnSaveIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveIns.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveIns.ForeColor = System.Drawing.Color.White
        Me.btnSaveIns.Location = New System.Drawing.Point(420, 210)
        Me.btnSaveIns.Size = New System.Drawing.Size(180, 35)
        Me.btnSaveIns.Text = "SAVE INSURANCE"
        Me.btnSaveIns.UseVisualStyleBackColor = False

        Me.btnClearIns.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearIns.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearIns.ForeColor = System.Drawing.Color.White
        Me.btnClearIns.Location = New System.Drawing.Point(620, 210)
        Me.btnClearIns.Size = New System.Drawing.Size(110, 35)
        Me.btnClearIns.Text = "CLEAR"
        Me.btnClearIns.UseVisualStyleBackColor = False

        Me.dgvInsurance.AllowUserToAddRows = False
        Me.dgvInsurance.BackgroundColor = System.Drawing.Color.White
        Me.dgvInsurance.ColumnHeadersHeight = 30
        Me.dgvInsurance.EnableHeadersVisualStyles = False
        Me.dgvInsurance.Location = New System.Drawing.Point(12, 355)
        Me.dgvInsurance.Name = "dgvInsurance"
        Me.dgvInsurance.RowHeadersVisible = False
        Me.dgvInsurance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInsurance.Size = New System.Drawing.Size(1360, 325)

        ' ========== OTHER TAB ==========
        Me.tabOther.Controls.Add(Me.pnlSearchOther)
        Me.tabOther.Controls.Add(Me.grpOtherInfo)
        Me.tabOther.Controls.Add(Me.grpOtherSummary)
        Me.tabOther.Controls.Add(Me.grpOtherPayment)
        Me.tabOther.Controls.Add(Me.dgvOther)
        Me.tabOther.Controls.Add(Me.dgvOtherHistory)
        Me.tabOther.Location = New System.Drawing.Point(4, 34)
        Me.tabOther.Name = "tabOther"
        Me.tabOther.Padding = New System.Windows.Forms.Padding(8)
        Me.tabOther.Size = New System.Drawing.Size(1392, 707)
        Me.tabOther.Text = "  OTHER  "
        Me.tabOther.UseVisualStyleBackColor = True

        Me.pnlSearchOther.BackColor = System.Drawing.Color.White
        Me.pnlSearchOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchOther.Controls.Add(Me.lblSearchOtherCust)
        Me.pnlSearchOther.Controls.Add(Me.txtSearchOtherCust)
        Me.pnlSearchOther.Controls.Add(Me.lblSearchOtherMobile)
        Me.pnlSearchOther.Controls.Add(Me.txtSearchOtherMobile)
        Me.pnlSearchOther.Controls.Add(Me.btnSearchOther)
        Me.pnlSearchOther.Controls.Add(Me.btnClearSearchOther)
        Me.pnlSearchOther.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchOther.Location = New System.Drawing.Point(8, 8)
        Me.pnlSearchOther.Name = "pnlSearchOther"
        Me.pnlSearchOther.Size = New System.Drawing.Size(1376, 45)

        Me.lblSearchOtherCust.AutoSize = True
        Me.lblSearchOtherCust.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchOtherCust.Location = New System.Drawing.Point(12, 12)
        Me.lblSearchOtherCust.Text = "Customer :"
        Me.txtSearchOtherCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchOtherCust.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchOtherCust.Location = New System.Drawing.Point(100, 9)
        Me.txtSearchOtherCust.Size = New System.Drawing.Size(200, 25)
        Me.lblSearchOtherMobile.AutoSize = True
        Me.lblSearchOtherMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchOtherMobile.Location = New System.Drawing.Point(320, 12)
        Me.lblSearchOtherMobile.Text = "Mobile :"
        Me.txtSearchOtherMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchOtherMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearchOtherMobile.Location = New System.Drawing.Point(390, 9)
        Me.txtSearchOtherMobile.Size = New System.Drawing.Size(150, 25)
        Me.btnSearchOther.BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
        Me.btnSearchOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchOther.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSearchOther.ForeColor = System.Drawing.Color.White
        Me.btnSearchOther.Location = New System.Drawing.Point(560, 7)
        Me.btnSearchOther.Size = New System.Drawing.Size(95, 30)
        Me.btnSearchOther.Text = "Search"
        Me.btnSearchOther.UseVisualStyleBackColor = False
        Me.btnClearSearchOther.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearSearchOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearchOther.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearSearchOther.ForeColor = System.Drawing.Color.White
        Me.btnClearSearchOther.Location = New System.Drawing.Point(665, 7)
        Me.btnClearSearchOther.Size = New System.Drawing.Size(80, 30)
        Me.btnClearSearchOther.Text = "Clear"
        Me.btnClearSearchOther.UseVisualStyleBackColor = False

        Me.grpOtherInfo.Controls.Add(Me.lblOtherCustName)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherCustName)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherMobile)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherMobile)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherPropertyNo)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherPropertyNo)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherLoanAmt)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherLoanAmt)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherPropertyAdd)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherPropertyAdd)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherCPA)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherCPA)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherBank)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherBank)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherCode)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherCode)
        Me.grpOtherInfo.Controls.Add(Me.lblOtherHODate)
        Me.grpOtherInfo.Controls.Add(Me.txtOtherHODate)
        Me.grpOtherInfo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpOtherInfo.Location = New System.Drawing.Point(12, 60)
        Me.grpOtherInfo.Name = "grpOtherInfo"
        Me.grpOtherInfo.Size = New System.Drawing.Size(540, 230)
        Me.grpOtherInfo.TabStop = False
        Me.grpOtherInfo.Text = "Customer Details"

        Me.lblOtherCustName.AutoSize = True
        Me.lblOtherCustName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherCustName.Location = New System.Drawing.Point(15, 28)
        Me.lblOtherCustName.Text = "Name"
        Me.txtOtherCustName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherCustName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherCustName.Location = New System.Drawing.Point(115, 25)
        Me.txtOtherCustName.ReadOnly = True
        Me.txtOtherCustName.Size = New System.Drawing.Size(190, 25)

        Me.lblOtherMobile.AutoSize = True
        Me.lblOtherMobile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherMobile.Location = New System.Drawing.Point(320, 28)
        Me.lblOtherMobile.Text = "Mobile"
        Me.txtOtherMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherMobile.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherMobile.Location = New System.Drawing.Point(390, 25)
        Me.txtOtherMobile.ReadOnly = True
        Me.txtOtherMobile.Size = New System.Drawing.Size(130, 25)

        Me.lblOtherPropertyNo.AutoSize = True
        Me.lblOtherPropertyNo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherPropertyNo.Location = New System.Drawing.Point(15, 62)
        Me.lblOtherPropertyNo.Text = "Property No"
        Me.txtOtherPropertyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherPropertyNo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherPropertyNo.Location = New System.Drawing.Point(115, 59)
        Me.txtOtherPropertyNo.ReadOnly = True
        Me.txtOtherPropertyNo.Size = New System.Drawing.Size(190, 25)

        Me.lblOtherLoanAmt.AutoSize = True
        Me.lblOtherLoanAmt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherLoanAmt.Location = New System.Drawing.Point(320, 62)
        Me.lblOtherLoanAmt.Text = "Loan Amt"
        Me.txtOtherLoanAmt.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtOtherLoanAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherLoanAmt.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherLoanAmt.Location = New System.Drawing.Point(390, 59)
        Me.txtOtherLoanAmt.ReadOnly = True
        Me.txtOtherLoanAmt.Size = New System.Drawing.Size(130, 25)
        Me.txtOtherLoanAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblOtherPropertyAdd.AutoSize = True
        Me.lblOtherPropertyAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherPropertyAdd.Location = New System.Drawing.Point(15, 96)
        Me.lblOtherPropertyAdd.Text = "Property Add"
        Me.txtOtherPropertyAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherPropertyAdd.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherPropertyAdd.Location = New System.Drawing.Point(115, 93)
        Me.txtOtherPropertyAdd.ReadOnly = True
        Me.txtOtherPropertyAdd.Size = New System.Drawing.Size(405, 25)

        Me.lblOtherCPA.AutoSize = True
        Me.lblOtherCPA.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherCPA.Location = New System.Drawing.Point(15, 130)
        Me.lblOtherCPA.Text = "CPA Name"
        Me.txtOtherCPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherCPA.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherCPA.Location = New System.Drawing.Point(115, 127)
        Me.txtOtherCPA.ReadOnly = True
        Me.txtOtherCPA.Size = New System.Drawing.Size(190, 25)

        Me.lblOtherBank.AutoSize = True
        Me.lblOtherBank.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherBank.Location = New System.Drawing.Point(320, 130)
        Me.lblOtherBank.Text = "Bank"
        Me.txtOtherBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherBank.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherBank.Location = New System.Drawing.Point(390, 127)
        Me.txtOtherBank.ReadOnly = True
        Me.txtOtherBank.Size = New System.Drawing.Size(130, 25)

        Me.lblOtherCode.AutoSize = True
        Me.lblOtherCode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherCode.Location = New System.Drawing.Point(15, 164)
        Me.lblOtherCode.Text = "Code"
        Me.txtOtherCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherCode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherCode.Location = New System.Drawing.Point(115, 161)
        Me.txtOtherCode.ReadOnly = True
        Me.txtOtherCode.Size = New System.Drawing.Size(190, 25)

        Me.lblOtherHODate.AutoSize = True
        Me.lblOtherHODate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherHODate.Location = New System.Drawing.Point(320, 164)
        Me.lblOtherHODate.Text = "HO Date"
        Me.txtOtherHODate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherHODate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherHODate.Location = New System.Drawing.Point(390, 161)
        Me.txtOtherHODate.ReadOnly = True
        Me.txtOtherHODate.Size = New System.Drawing.Size(130, 25)

        Me.grpOtherSummary.Controls.Add(Me.lblOtherTotalAmount)
        Me.grpOtherSummary.Controls.Add(Me.txtOtherTotalAmount)
        Me.grpOtherSummary.Controls.Add(Me.lblOtherTotalReceived)
        Me.grpOtherSummary.Controls.Add(Me.txtOtherTotalReceived)
        Me.grpOtherSummary.Controls.Add(Me.lblOtherBalance)
        Me.grpOtherSummary.Controls.Add(Me.txtOtherBalance)
        Me.grpOtherSummary.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpOtherSummary.Location = New System.Drawing.Point(565, 60)
        Me.grpOtherSummary.Name = "grpOtherSummary"
        Me.grpOtherSummary.Size = New System.Drawing.Size(250, 230)
        Me.grpOtherSummary.TabStop = False
        Me.grpOtherSummary.Text = "Amount Summary"

        Me.lblOtherTotalAmount.AutoSize = True
        Me.lblOtherTotalAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherTotalAmount.Location = New System.Drawing.Point(18, 45)
        Me.lblOtherTotalAmount.Text = "Exp Offer"
        Me.txtOtherTotalAmount.BackColor = System.Drawing.Color.FromArgb(227, 242, 253)
        Me.txtOtherTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherTotalAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtOtherTotalAmount.Location = New System.Drawing.Point(105, 41)
        Me.txtOtherTotalAmount.ReadOnly = True
        Me.txtOtherTotalAmount.Size = New System.Drawing.Size(125, 27)
        Me.txtOtherTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblOtherTotalReceived.AutoSize = True
        Me.lblOtherTotalReceived.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherTotalReceived.Location = New System.Drawing.Point(18, 95)
        Me.lblOtherTotalReceived.Text = "Received"
        Me.txtOtherTotalReceived.BackColor = System.Drawing.Color.FromArgb(232, 245, 233)
        Me.txtOtherTotalReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherTotalReceived.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtOtherTotalReceived.Location = New System.Drawing.Point(105, 91)
        Me.txtOtherTotalReceived.ReadOnly = True
        Me.txtOtherTotalReceived.Size = New System.Drawing.Size(125, 27)
        Me.txtOtherTotalReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblOtherBalance.AutoSize = True
        Me.lblOtherBalance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherBalance.Location = New System.Drawing.Point(18, 145)
        Me.lblOtherBalance.Text = "Balance"
        Me.txtOtherBalance.BackColor = System.Drawing.Color.FromArgb(255, 243, 224)
        Me.txtOtherBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherBalance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtOtherBalance.Location = New System.Drawing.Point(105, 141)
        Me.txtOtherBalance.ReadOnly = True
        Me.txtOtherBalance.Size = New System.Drawing.Size(125, 27)
        Me.txtOtherBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.grpOtherPayment.Controls.Add(Me.lblOtherReceiveAmount)
        Me.grpOtherPayment.Controls.Add(Me.txtOtherReceiveAmount)
        Me.grpOtherPayment.Controls.Add(Me.lblOtherReceiveDate)
        Me.grpOtherPayment.Controls.Add(Me.dtpOtherReceiveDate)
        Me.grpOtherPayment.Controls.Add(Me.lblOtherCreditMode)
        Me.grpOtherPayment.Controls.Add(Me.cboOtherCreditMode)
        Me.grpOtherPayment.Controls.Add(Me.lblOtherWaiver)
        Me.grpOtherPayment.Controls.Add(Me.txtOtherWaiver)
        Me.grpOtherPayment.Controls.Add(Me.lblOtherRemarks)
        Me.grpOtherPayment.Controls.Add(Me.txtOtherRemarks)
        Me.grpOtherPayment.Controls.Add(Me.btnSaveOther)
        Me.grpOtherPayment.Controls.Add(Me.btnClearOther)
        Me.grpOtherPayment.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.grpOtherPayment.Location = New System.Drawing.Point(830, 60)
        Me.grpOtherPayment.Name = "grpOtherPayment"
        Me.grpOtherPayment.Size = New System.Drawing.Size(545, 230)
        Me.grpOtherPayment.TabStop = False
        Me.grpOtherPayment.Text = "Add New Payment"

        Me.lblOtherReceiveAmount.AutoSize = True
        Me.lblOtherReceiveAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherReceiveAmount.Location = New System.Drawing.Point(18, 35)
        Me.lblOtherReceiveAmount.Text = "Receive Amt"
        Me.txtOtherReceiveAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherReceiveAmount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherReceiveAmount.Location = New System.Drawing.Point(125, 32)
        Me.txtOtherReceiveAmount.Size = New System.Drawing.Size(130, 25)
        Me.txtOtherReceiveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblOtherReceiveDate.AutoSize = True
        Me.lblOtherReceiveDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherReceiveDate.Location = New System.Drawing.Point(275, 35)
        Me.lblOtherReceiveDate.Text = "Date"
        Me.dtpOtherReceiveDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpOtherReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpOtherReceiveDate.Location = New System.Drawing.Point(325, 32)
        Me.dtpOtherReceiveDate.Size = New System.Drawing.Size(140, 25)

        Me.lblOtherCreditMode.AutoSize = True
        Me.lblOtherCreditMode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherCreditMode.Location = New System.Drawing.Point(18, 75)
        Me.lblOtherCreditMode.Text = "Credit Mode"
        Me.cboOtherCreditMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOtherCreditMode.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cboOtherCreditMode.Items.AddRange(New Object() {"Cash", "Bank", "NEFT", "RTGS", "UPI", "Cheque", "Card"})
        Me.cboOtherCreditMode.Location = New System.Drawing.Point(125, 72)
        Me.cboOtherCreditMode.Size = New System.Drawing.Size(130, 25)

        Me.lblOtherWaiver.AutoSize = True
        Me.lblOtherWaiver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherWaiver.Location = New System.Drawing.Point(275, 75)
        Me.lblOtherWaiver.Text = "Waiver"
        Me.txtOtherWaiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherWaiver.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherWaiver.Location = New System.Drawing.Point(325, 72)
        Me.txtOtherWaiver.Size = New System.Drawing.Size(140, 25)
        Me.txtOtherWaiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right

        Me.lblOtherRemarks.AutoSize = True
        Me.lblOtherRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblOtherRemarks.Location = New System.Drawing.Point(18, 115)
        Me.lblOtherRemarks.Text = "Remarks"
        Me.txtOtherRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOtherRemarks.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtOtherRemarks.Location = New System.Drawing.Point(125, 112)
        Me.txtOtherRemarks.Size = New System.Drawing.Size(340, 25)

        Me.btnSaveOther.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.btnSaveOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveOther.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveOther.ForeColor = System.Drawing.Color.White
        Me.btnSaveOther.Location = New System.Drawing.Point(125, 165)
        Me.btnSaveOther.Size = New System.Drawing.Size(160, 35)
        Me.btnSaveOther.Text = "SAVE PAYMENT"
        Me.btnSaveOther.UseVisualStyleBackColor = False

        Me.btnClearOther.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnClearOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearOther.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnClearOther.ForeColor = System.Drawing.Color.White
        Me.btnClearOther.Location = New System.Drawing.Point(305, 165)
        Me.btnClearOther.Size = New System.Drawing.Size(100, 35)
        Me.btnClearOther.Text = "CLEAR"
        Me.btnClearOther.UseVisualStyleBackColor = False

        Me.dgvOther.AllowUserToAddRows = False
        Me.dgvOther.BackgroundColor = System.Drawing.Color.White
        Me.dgvOther.ColumnHeadersHeight = 30
        Me.dgvOther.EnableHeadersVisualStyles = False
        Me.dgvOther.Location = New System.Drawing.Point(12, 300)
        Me.dgvOther.Name = "dgvOther"
        Me.dgvOther.RowHeadersVisible = False
        Me.dgvOther.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOther.Size = New System.Drawing.Size(1360, 160)

        Me.dgvOtherHistory.AllowUserToAddRows = False
        Me.dgvOtherHistory.BackgroundColor = System.Drawing.Color.White
        Me.dgvOtherHistory.ColumnHeadersHeight = 30
        Me.dgvOtherHistory.EnableHeadersVisualStyles = False
        Me.dgvOtherHistory.Location = New System.Drawing.Point(12, 470)
        Me.dgvOtherHistory.Name = "dgvOtherHistory"
        Me.dgvOtherHistory.RowHeadersVisible = False
        Me.dgvOtherHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOtherHistory.Size = New System.Drawing.Size(1360, 210)

        ' ========== FORM ==========
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.ClientSize = New System.Drawing.Size(1400, 800)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.pnlTop)
        Me.MinimumSize = New System.Drawing.Size(1300, 750)
        Me.Name = "frmExpenseIncome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income Module - Customer | Bank | Insurance | Other"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.tabMain.ResumeLayout(False)
        Me.tabCustomer.ResumeLayout(False)
        Me.pnlSearchCust.ResumeLayout(False)
        Me.pnlSearchCust.PerformLayout()
        Me.grpCustInfo.ResumeLayout(False)
        Me.grpCustInfo.PerformLayout()
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        CType(Me.dgvCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBank.ResumeLayout(False)
        Me.pnlSearchBank.ResumeLayout(False)
        Me.pnlSearchBank.PerformLayout()
        Me.grpBankInfo.ResumeLayout(False)
        Me.grpBankInfo.PerformLayout()
        Me.grpBankPayment.ResumeLayout(False)
        Me.grpBankPayment.PerformLayout()
        CType(Me.dgvBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInsurance.ResumeLayout(False)
        Me.pnlSearchIns.ResumeLayout(False)
        Me.pnlSearchIns.PerformLayout()
        Me.grpInsInfo.ResumeLayout(False)
        Me.grpInsInfo.PerformLayout()
        Me.grpInsPayment.ResumeLayout(False)
        Me.grpInsPayment.PerformLayout()
        CType(Me.dgvInsurance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOther.ResumeLayout(False)
        Me.pnlSearchOther.ResumeLayout(False)
        Me.pnlSearchOther.PerformLayout()
        Me.grpOtherInfo.ResumeLayout(False)
        Me.grpOtherInfo.PerformLayout()
        Me.grpOtherSummary.ResumeLayout(False)
        Me.grpOtherSummary.PerformLayout()
        Me.grpOtherPayment.ResumeLayout(False)
        Me.grpOtherPayment.PerformLayout()
        CType(Me.dgvOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOtherHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    '==================== ALL CONTROLS ====================
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents tabMain As TabControl

    Friend WithEvents tabCustomer As TabPage
    Friend WithEvents pnlSearchCust As Panel
    Friend WithEvents lblSearchCust As Label
    Friend WithEvents txtSearchCustName As TextBox
    Friend WithEvents lblSearchMobile As Label
    Friend WithEvents txtSearchMobile As TextBox
    Friend WithEvents btnSearchCust As Button
    Friend WithEvents btnClearSearchCust As Button
    Friend WithEvents grpCustInfo As GroupBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents lblPropertyNo As Label
    Friend WithEvents txtPropertyNo As TextBox
    Friend WithEvents lblPropertyAdd As Label
    Friend WithEvents txtPropertyAdd As TextBox
    Friend WithEvents lblLoanAmtCust As Label
    Friend WithEvents txtLoanAmtCust As TextBox
    Friend WithEvents lblCPA As Label
    Friend WithEvents txtCPA As TextBox
    Friend WithEvents lblBankCust As Label
    Friend WithEvents txtBankCust As TextBox
    Friend WithEvents lblCodeCust As Label
    Friend WithEvents txtCodeCust As TextBox
    Friend WithEvents lblHODateCust As Label
    Friend WithEvents txtHODateCust As TextBox
    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblTotalReceived As Label
    Friend WithEvents txtTotalReceived As TextBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblReceiveAmount As Label
    Friend WithEvents txtReceiveAmount As TextBox
    Friend WithEvents lblReceiveDate As Label
    Friend WithEvents dtpReceiveDate As DateTimePicker
    Friend WithEvents lblCreditModeCust As Label
    Friend WithEvents cboCreditModeCust As ComboBox
    Friend WithEvents lblWaiver As Label
    Friend WithEvents txtWaiver As TextBox
    Friend WithEvents lblRemarksCust As Label
    Friend WithEvents txtRemarksCust As TextBox
    Friend WithEvents btnSaveCust As Button
    Friend WithEvents btnClearCust As Button
    Friend WithEvents dgvCust As DataGridView
    Friend WithEvents dgvPaymentHistory As DataGridView

    Friend WithEvents tabBank As TabPage
    Friend WithEvents pnlSearchBank As Panel
    Friend WithEvents lblSearchBankCust As Label
    Friend WithEvents txtSearchBankCust As TextBox
    Friend WithEvents lblSearchBankMobile As Label
    Friend WithEvents txtSearchBankMobile As TextBox
    Friend WithEvents btnSearchBank As Button
    Friend WithEvents btnClearSearchBank As Button
    Friend WithEvents grpBankInfo As GroupBox
    Friend WithEvents lblBankCustName As Label
    Friend WithEvents txtBankCustName As TextBox
    Friend WithEvents lblBankMobile As Label
    Friend WithEvents txtBankMobile As TextBox
    Friend WithEvents lblPropertyNoBank As Label
    Friend WithEvents txtPropertyNoBank As TextBox
    Friend WithEvents lblPropertyAddBank As Label
    Friend WithEvents txtPropertyAddBank As TextBox
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents lblCPABank As Label
    Friend WithEvents txtCPABank As TextBox
    Friend WithEvents lblBankName As Label
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents lblCodeBank As Label
    Friend WithEvents txtCodeBank As TextBox
    Friend WithEvents lblHODateBank As Label
    Friend WithEvents txtHODateBank As TextBox
    Friend WithEvents grpBankPayment As GroupBox
    Friend WithEvents lblPayoutStatus As Label
    Friend WithEvents cboPayoutStatus As ComboBox
    Friend WithEvents lblPOCreditAC As Label
    Friend WithEvents cboPOCreditAC As ComboBox
    Friend WithEvents lblCreditModeBank As Label
    Friend WithEvents cboCreditModeBank As ComboBox
    Friend WithEvents lblCreditDate As Label
    Friend WithEvents dtpCreditDate As DateTimePicker
    Friend WithEvents lblGrossPercent As Label
    Friend WithEvents txtGrossPercent As TextBox
    Friend WithEvents lblGrossBankPO As Label
    Friend WithEvents txtGrossBankPO As TextBox
    Friend WithEvents radTDSPercent As RadioButton
    Friend WithEvents txtTDSPercent As TextBox
    Friend WithEvents radTDSFixed As RadioButton
    Friend WithEvents txtTDSFixedAmount As TextBox
    Friend WithEvents lblTDS As Label
    Friend WithEvents txtTDS As TextBox
    Friend WithEvents lblNetBankPO As Label
    Friend WithEvents txtNetBankPO As TextBox
    Friend WithEvents lblRemarksBank As Label
    Friend WithEvents txtRemarksBank As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSaveBank As Button
    Friend WithEvents btnClearBank As Button
    Friend WithEvents dgvBank As DataGridView

    Friend WithEvents tabInsurance As TabPage
    Friend WithEvents pnlSearchIns As Panel
    Friend WithEvents lblSearchInsCust As Label
    Friend WithEvents txtSearchInsCust As TextBox
    Friend WithEvents lblSearchInsMobile As Label
    Friend WithEvents txtSearchInsMobile As TextBox
    Friend WithEvents btnSearchIns As Button
    Friend WithEvents btnClearSearchIns As Button
    Friend WithEvents grpInsInfo As GroupBox
    Friend WithEvents lblInsCustName As Label
    Friend WithEvents txtInsCustName As TextBox
    Friend WithEvents lblInsMobile As Label
    Friend WithEvents txtInsMobile As TextBox
    Friend WithEvents lblInsPropertyNo As Label
    Friend WithEvents txtInsPropertyNo As TextBox
    Friend WithEvents lblInsPropertyAdd As Label
    Friend WithEvents txtInsPropertyAdd As TextBox
    Friend WithEvents lblInsLoanAmount As Label
    Friend WithEvents txtInsLoanAmount As TextBox
    Friend WithEvents lblInsCPA As Label
    Friend WithEvents txtInsCPA As TextBox
    Friend WithEvents lblInsBank As Label
    Friend WithEvents txtInsBank As TextBox
    Friend WithEvents lblInsCode As Label
    Friend WithEvents txtInsCode As TextBox
    Friend WithEvents lblInsHODate As Label
    Friend WithEvents txtInsHODate As TextBox
    Friend WithEvents grpInsPayment As GroupBox
    Friend WithEvents lblInsPayoutStatus As Label
    Friend WithEvents cboInsPayoutStatus As ComboBox
    Friend WithEvents lblInsPOCreditAC As Label
    Friend WithEvents cboInsPOCreditAC As ComboBox
    Friend WithEvents lblInsCreditMode As Label
    Friend WithEvents cboInsCreditMode As ComboBox
    Friend WithEvents lblInsCreditDate As Label
    Friend WithEvents dtpInsCreditDate As DateTimePicker
    Friend WithEvents lblInsGrossPercent As Label
    Friend WithEvents txtInsGrossPercent As TextBox
    Friend WithEvents lblInsGrossPO As Label
    Friend WithEvents txtInsGrossPO As TextBox
    Friend WithEvents radInsTDSPercent As RadioButton
    Friend WithEvents txtInsTDSPercent As TextBox
    Friend WithEvents radInsTDSFixed As RadioButton
    Friend WithEvents txtInsTDSFixed As TextBox
    Friend WithEvents lblInsTDS As Label
    Friend WithEvents txtInsTDS As TextBox
    Friend WithEvents lblInsNetPO As Label
    Friend WithEvents txtInsNetPO As TextBox
    Friend WithEvents lblInsRemarks As Label
    Friend WithEvents txtInsRemarks As TextBox
    Friend WithEvents btnInsCalculate As Button
    Friend WithEvents btnSaveIns As Button
    Friend WithEvents btnClearIns As Button
    Friend WithEvents dgvInsurance As DataGridView

    Friend WithEvents tabOther As TabPage
    Friend WithEvents pnlSearchOther As Panel
    Friend WithEvents lblSearchOtherCust As Label
    Friend WithEvents txtSearchOtherCust As TextBox
    Friend WithEvents lblSearchOtherMobile As Label
    Friend WithEvents txtSearchOtherMobile As TextBox
    Friend WithEvents btnSearchOther As Button
    Friend WithEvents btnClearSearchOther As Button
    Friend WithEvents grpOtherInfo As GroupBox
    Friend WithEvents lblOtherCustName As Label
    Friend WithEvents txtOtherCustName As TextBox
    Friend WithEvents lblOtherMobile As Label
    Friend WithEvents txtOtherMobile As TextBox
    Friend WithEvents lblOtherPropertyNo As Label
    Friend WithEvents txtOtherPropertyNo As TextBox
    Friend WithEvents lblOtherPropertyAdd As Label
    Friend WithEvents txtOtherPropertyAdd As TextBox
    Friend WithEvents lblOtherLoanAmt As Label
    Friend WithEvents txtOtherLoanAmt As TextBox
    Friend WithEvents lblOtherCPA As Label
    Friend WithEvents txtOtherCPA As TextBox
    Friend WithEvents lblOtherBank As Label
    Friend WithEvents txtOtherBank As TextBox
    Friend WithEvents lblOtherCode As Label
    Friend WithEvents txtOtherCode As TextBox
    Friend WithEvents lblOtherHODate As Label
    Friend WithEvents txtOtherHODate As TextBox
    Friend WithEvents grpOtherSummary As GroupBox
    Friend WithEvents lblOtherTotalAmount As Label
    Friend WithEvents txtOtherTotalAmount As TextBox
    Friend WithEvents lblOtherTotalReceived As Label
    Friend WithEvents txtOtherTotalReceived As TextBox
    Friend WithEvents lblOtherBalance As Label
    Friend WithEvents txtOtherBalance As TextBox
    Friend WithEvents grpOtherPayment As GroupBox
    Friend WithEvents lblOtherReceiveAmount As Label
    Friend WithEvents txtOtherReceiveAmount As TextBox
    Friend WithEvents lblOtherReceiveDate As Label
    Friend WithEvents dtpOtherReceiveDate As DateTimePicker
    Friend WithEvents lblOtherCreditMode As Label
    Friend WithEvents cboOtherCreditMode As ComboBox
    Friend WithEvents lblOtherWaiver As Label
    Friend WithEvents txtOtherWaiver As TextBox
    Friend WithEvents lblOtherRemarks As Label
    Friend WithEvents txtOtherRemarks As TextBox
    Friend WithEvents btnSaveOther As Button
    Friend WithEvents btnClearOther As Button
    Friend WithEvents dgvOther As DataGridView
    Friend WithEvents dgvOtherHistory As DataGridView

End Class