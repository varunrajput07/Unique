<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExpenseMIS
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

        Me.components = New System.ComponentModel.Container()

        '=========================================================
        ' MAIN PANELS
        '=========================================================
        Me.pnlTop = New Panel()
        Me.lblTitle = New Label()
        Me.lblSubTitle = New Label()

        Me.pnlSearch = New Panel()
        Me.lblSearchTitle = New Label()
        Me.lblLoginMisID = New Label()
        Me.txtLoginMisID = New TextBox()
        Me.btnSearch = New Button()

        Me.lblCustomer = New Label()
        Me.txtCustomer = New TextBox()

        Me.lblApplicationNo = New Label()
        Me.txtApplicationNo = New TextBox()

        Me.lblLoanNo = New Label()
        Me.txtLoanNo = New TextBox()

        Me.lblBank = New Label()
        Me.txtBank = New TextBox()

        Me.pnlContent = New Panel()

        '=========================================================
        ' PAYOUT
        '=========================================================
        Me.grpPayout = New GroupBox()

        Me.lblPayoutStatus = New Label()
        Me.cboPayoutStatus = New ComboBox()

        Me.lblGrossBankPO = New Label()
        Me.txtGrossBankPO = New TextBox()

        Me.lblPOCreditAC = New Label()
        Me.txtPOCreditAC = New TextBox()

        Me.lblCreditMode = New Label()
        Me.cboCreditMode = New ComboBox()

        Me.lblCreditDate = New Label()
        Me.dtpCreditDate = New DateTimePicker()

        Me.lblTDS = New Label()
        Me.txtTDS = New TextBox()

        Me.lblNetBankPO = New Label()
        Me.txtNetBankPO = New TextBox()

        '=========================================================
        ' INSURANCE
        '=========================================================
        Me.grpInsurance = New GroupBox()

        Me.lblInsurancePayment = New Label()
        Me.txtInsurancePayment = New TextBox()

        Me.lblInsPaymentDate = New Label()
        Me.dtpInsPaymentDate = New DateTimePicker()

        Me.lblInsPaymentAC = New Label()
        Me.txtInsPaymentAC = New TextBox()

        Me.lblInsCreditMode = New Label()
        Me.cboInsCreditMode = New ComboBox()

        '=========================================================
        ' CM PAYMENT
        '=========================================================
        Me.grpCM = New GroupBox()

        Me.lblCMPaymentReceive = New Label()
        Me.txtCMPaymentReceive = New TextBox()

        Me.lblCMPaymentDate = New Label()
        Me.dtpCMPaymentDate = New DateTimePicker()

        Me.lblCMPaymentAC = New Label()
        Me.txtCMPaymentAC = New TextBox()

        Me.lblCMCreditMode = New Label()
        Me.cboCMCreditMode = New ComboBox()

        '=========================================================
        ' SUMMARY
        '=========================================================
        Me.grpSummary = New GroupBox()

        Me.lblTotalPO = New Label()
        Me.txtTotalPO = New TextBox()

        Me.lblNetTotalPO = New Label()
        Me.txtNetTotalPO = New TextBox()

        '=========================================================
        ' EXPENSE
        '=========================================================
        Me.grpExpense = New GroupBox()

        Me.lblExpense = New Label()
        Me.txtExpense = New TextBox()

        Me.lblExpenseDate = New Label()
        Me.dtpExpenseDate = New DateTimePicker()

        Me.lblExpensePaidBy = New Label()
        Me.cboExpensePaidBy = New ComboBox()

        Me.lblExpenseMode = New Label()
        Me.cboExpenseMode = New ComboBox()

        '=========================================================
        ' RM
        '=========================================================
        Me.grpRM = New GroupBox()

        Me.lblRMAmount = New Label()
        Me.txtRMAmount = New TextBox()

        Me.lblRMDate = New Label()
        Me.dtpRMDate = New DateTimePicker()

        Me.lblRMPaidBy = New Label()
        Me.cboRMPaidBy = New ComboBox()

        Me.lblRMMode = New Label()
        Me.cboRMMode = New ComboBox()

        '=========================================================
        ' FI RCU PD
        '=========================================================
        Me.grpFIRcuPD = New GroupBox()

        Me.lblFIRcuPD = New Label()
        Me.txtFIRcuPD = New TextBox()

        Me.lblFIRcuPDDate = New Label()
        Me.dtpFIRcuPDDate = New DateTimePicker()

        Me.lblFIRcuPDPaidBy = New Label()
        Me.cboFIRcuPDPaidBy = New ComboBox()

        Me.lblFIRcuPDMode = New Label()
        Me.cboFIRcuPDMode = New ComboBox()

        '=========================================================
        ' STAFF SHARING
        '=========================================================
        Me.grpStaffSharing = New GroupBox()

        Me.lblStaffSharing = New Label()
        Me.txtStaffSharing = New TextBox()

        Me.lblStaffSharingPaymentDate = New Label()
        Me.dtpStaffSharingPaymentDate = New DateTimePicker()

        Me.lblStaffSharingPaymentStatus = New Label()
        Me.cboStaffSharingPaymentStatus = New ComboBox()

        Me.lblStaffSharingPaidBy = New Label()
        Me.cboStaffSharingPaidBy = New ComboBox()

        Me.lblStaffSharingMode = New Label()
        Me.cboStaffSharingMode = New ComboBox()

        '=========================================================
        ' BOTTOM BUTTONS
        '=========================================================
        Me.pnlButtons = New Panel()

        Me.btnSave = New Button()
        Me.btnUpdate = New Button()
        Me.btnDelete = New Button()
        Me.btnClear = New Button()

        '=========================================================
        ' FORM
        '=========================================================
        Me.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlButtons.SuspendLayout()

        '
        ' FORM
        '
        Me.Name = "frmPayoutMIS"
        Me.Text = "UNIQUE - PAYOUT MIS"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(241, 245, 249)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1500, 900)

        '=========================================================
        ' TOP HEADER
        '=========================================================
        Me.pnlTop.BackColor = Color.FromArgb(15, 23, 42)
        Me.pnlTop.Dock = DockStyle.Top
        Me.pnlTop.Height = 75
        Me.pnlTop.Name = "pnlTop"

        Me.lblTitle.Text = "PAYOUT MIS"
        Me.lblTitle.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(25, 12)
        Me.lblTitle.AutoSize = True

        Me.lblSubTitle.Text = "Payout & Payment Management"
        Me.lblSubTitle.Font = New Font("Segoe UI", 10)
        Me.lblSubTitle.ForeColor = Color.FromArgb(148, 163, 184)
        Me.lblSubTitle.Location = New Point(29, 48)
        Me.lblSubTitle.AutoSize = True

        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblSubTitle)

        '=========================================================
        ' SEARCH PANEL
        '=========================================================
        Me.pnlSearch.BackColor = Color.White
        Me.pnlSearch.Dock = DockStyle.Top
        Me.pnlSearch.Height = 115
        Me.pnlSearch.Padding = New Padding(15)
        Me.pnlSearch.Name = "pnlSearch"

        Me.lblSearchTitle.Text = "SEARCH LOGIN MIS"
        Me.lblSearchTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.lblSearchTitle.ForeColor = Color.FromArgb(30, 41, 59)
        Me.lblSearchTitle.Location = New Point(20, 10)
        Me.lblSearchTitle.AutoSize = True

        Me.lblLoginMisID.Text = "Login MIS ID"
        Me.lblLoginMisID.Location = New Point(20, 48)
        Me.lblLoginMisID.AutoSize = True
        Me.lblLoginMisID.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Me.txtLoginMisID.Location = New Point(105, 44)
        Me.txtLoginMisID.Size = New Size(120, 28)
        Me.txtLoginMisID.Font = New Font("Segoe UI", 10)
        Me.txtLoginMisID.BorderStyle = BorderStyle.FixedSingle

        Me.btnSearch.Text = "🔍 SEARCH"
        Me.btnSearch.Location = New Point(235, 43)
        Me.btnSearch.Size = New Size(110, 31)
        Me.btnSearch.BackColor = Color.FromArgb(37, 99, 235)
        Me.btnSearch.ForeColor = Color.White
        Me.btnSearch.FlatStyle = FlatStyle.Flat
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.Cursor = Cursors.Hand

        Me.lblCustomer.Text = "Customer"
        Me.lblCustomer.Location = New Point(380, 48)
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Me.txtCustomer.Location = New Point(445, 44)
        Me.txtCustomer.Size = New Size(220, 28)
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.BackColor = Color.FromArgb(248, 250, 252)
        Me.txtCustomer.BorderStyle = BorderStyle.FixedSingle

        Me.lblApplicationNo.Text = "Application No."
        Me.lblApplicationNo.Location = New Point(690, 48)
        Me.lblApplicationNo.AutoSize = True
        Me.lblApplicationNo.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Me.txtApplicationNo.Location = New Point(785, 44)
        Me.txtApplicationNo.Size = New Size(160, 28)
        Me.txtApplicationNo.ReadOnly = True
        Me.txtApplicationNo.BackColor = Color.FromArgb(248, 250, 252)
        Me.txtApplicationNo.BorderStyle = BorderStyle.FixedSingle

        Me.lblLoanNo.Text = "Loan No."
        Me.lblLoanNo.Location = New Point(970, 48)
        Me.lblLoanNo.AutoSize = True
        Me.lblLoanNo.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Me.txtLoanNo.Location = New Point(1030, 44)
        Me.txtLoanNo.Size = New Size(160, 28)
        Me.txtLoanNo.ReadOnly = True
        Me.txtLoanNo.BackColor = Color.FromArgb(248, 250, 252)
        Me.txtLoanNo.BorderStyle = BorderStyle.FixedSingle

        Me.lblBank.Text = "Bank"
        Me.lblBank.Location = New Point(1215, 48)
        Me.lblBank.AutoSize = True
        Me.lblBank.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Me.txtBank.Location = New Point(1260, 44)
        Me.txtBank.Size = New Size(150, 28)
        Me.txtBank.ReadOnly = True
        Me.txtBank.BackColor = Color.FromArgb(248, 250, 252)
        Me.txtBank.BorderStyle = BorderStyle.FixedSingle

        Me.pnlSearch.Controls.Add(Me.lblSearchTitle)
        Me.pnlSearch.Controls.Add(Me.lblLoginMisID)
        Me.pnlSearch.Controls.Add(Me.txtLoginMisID)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.lblCustomer)
        Me.pnlSearch.Controls.Add(Me.txtCustomer)
        Me.pnlSearch.Controls.Add(Me.lblApplicationNo)
        Me.pnlSearch.Controls.Add(Me.txtApplicationNo)
        Me.pnlSearch.Controls.Add(Me.lblLoanNo)
        Me.pnlSearch.Controls.Add(Me.txtLoanNo)
        Me.pnlSearch.Controls.Add(Me.lblBank)
        Me.pnlSearch.Controls.Add(Me.txtBank)

        '=========================================================
        ' CONTENT PANEL
        '=========================================================
        Me.pnlContent.Dock = DockStyle.Fill
        Me.pnlContent.AutoScroll = True
        Me.pnlContent.BackColor = Color.FromArgb(241, 245, 249)
        Me.pnlContent.Padding = New Padding(15)
        Me.pnlContent.Name = "pnlContent"

        '=========================================================
        ' COMMON GROUPBOX SETTINGS
        '=========================================================

        ' PAYOUT
        Me.grpPayout.Text = "  PAY OUT  "
        Me.grpPayout.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpPayout.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpPayout.BackColor = Color.White
        Me.grpPayout.Location = New Point(15, 15)
        Me.grpPayout.Size = New Size(700, 190)

        ' INSURANCE
        Me.grpInsurance.Text = "  INSURANCE PAYMENT  "
        Me.grpInsurance.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpInsurance.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpInsurance.BackColor = Color.White
        Me.grpInsurance.Location = New Point(730, 15)
        Me.grpInsurance.Size = New Size(700, 190)

        ' CM
        Me.grpCM.Text = "  CM PAYMENT RECEIVE  "
        Me.grpCM.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpCM.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpCM.BackColor = Color.White
        Me.grpCM.Location = New Point(15, 220)
        Me.grpCM.Size = New Size(700, 190)

        ' SUMMARY
        Me.grpSummary.Text = "  PAYOUT SUMMARY  "
        Me.grpSummary.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpSummary.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpSummary.BackColor = Color.White
        Me.grpSummary.Location = New Point(730, 220)
        Me.grpSummary.Size = New Size(700, 190)

        ' EXPENSE
        Me.grpExpense.Text = "  EXPENSE  "
        Me.grpExpense.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpExpense.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpExpense.BackColor = Color.White
        Me.grpExpense.Location = New Point(15, 425)
        Me.grpExpense.Size = New Size(700, 190)

        ' RM
        Me.grpRM.Text = "  RM PAYMENT  "
        Me.grpRM.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpRM.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpRM.BackColor = Color.White
        Me.grpRM.Location = New Point(730, 425)
        Me.grpRM.Size = New Size(700, 190)

        ' FI RCU PD
        Me.grpFIRcuPD.Text = "  FI / RCU / PD  "
        Me.grpFIRcuPD.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpFIRcuPD.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpFIRcuPD.BackColor = Color.White
        Me.grpFIRcuPD.Location = New Point(15, 630)
        Me.grpFIRcuPD.Size = New Size(700, 190)

        ' STAFF
        Me.grpStaffSharing.Text = "  STAFF SHARING  "
        Me.grpStaffSharing.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.grpStaffSharing.ForeColor = Color.FromArgb(30, 64, 175)
        Me.grpStaffSharing.BackColor = Color.White
        Me.grpStaffSharing.Location = New Point(730, 630)
        Me.grpStaffSharing.Size = New Size(700, 190)

        '=========================================================
        ' PAYOUT CONTROLS
        '=========================================================

        SetupLabel(Me.lblPayoutStatus, "Payout Status", 25, 40)
        SetupCombo(Me.cboPayoutStatus, 150, 37, 180)

        SetupLabel(Me.lblGrossBankPO, "Gross Bank P/O", 25, 80)
        SetupText(Me.txtGrossBankPO, 150, 77, 180)

        SetupLabel(Me.lblPOCreditAC, "P/O Credit A/C", 365, 40)
        SetupText(Me.txtPOCreditAC, 490, 37, 180)

        SetupLabel(Me.lblCreditMode, "Credit Mode", 365, 80)
        SetupCombo(Me.cboCreditMode, 490, 77, 180)

        SetupLabel(Me.lblCreditDate, "Credit Date", 25, 120)
        SetupDate(Me.dtpCreditDate, 150, 117, 180)

        SetupLabel(Me.lblTDS, "TDS", 365, 120)
        SetupText(Me.txtTDS, 490, 117, 180)

        SetupLabel(Me.lblNetBankPO, "Net Bank P/O", 25, 155)
        SetupText(Me.txtNetBankPO, 150, 152, 180)
        Me.txtNetBankPO.ReadOnly = True
        Me.txtNetBankPO.BackColor = Color.FromArgb(239, 246, 255)

        Me.grpPayout.Controls.AddRange({
            Me.lblPayoutStatus,
            Me.cboPayoutStatus,
            Me.lblGrossBankPO,
            Me.txtGrossBankPO,
            Me.lblPOCreditAC,
            Me.txtPOCreditAC,
            Me.lblCreditMode,
            Me.cboCreditMode,
            Me.lblCreditDate,
            Me.dtpCreditDate,
            Me.lblTDS,
            Me.txtTDS,
            Me.lblNetBankPO,
            Me.txtNetBankPO
        })

        '=========================================================
        ' INSURANCE
        '=========================================================

        SetupLabel(Me.lblInsurancePayment, "Insurance Payment", 25, 45)
        SetupText(Me.txtInsurancePayment, 150, 42, 190)

        SetupLabel(Me.lblInsPaymentDate, "Payment Date", 365, 45)
        SetupDate(Me.dtpInsPaymentDate, 490, 42, 180)

        SetupLabel(Me.lblInsPaymentAC, "Payment A/C", 25, 90)
        SetupText(Me.txtInsPaymentAC, 150, 87, 190)

        SetupLabel(Me.lblInsCreditMode, "Credit Mode", 365, 90)
        SetupCombo(Me.cboInsCreditMode, 490, 87, 180)

        Me.grpInsurance.Controls.AddRange({
            Me.lblInsurancePayment,
            Me.txtInsurancePayment,
            Me.lblInsPaymentDate,
            Me.dtpInsPaymentDate,
            Me.lblInsPaymentAC,
            Me.txtInsPaymentAC,
            Me.lblInsCreditMode,
            Me.cboInsCreditMode
        })

        '=========================================================
        ' CM
        '=========================================================

        SetupLabel(Me.lblCMPaymentReceive, "CM Payment Receive", 25, 45)
        SetupText(Me.txtCMPaymentReceive, 150, 42, 190)

        SetupLabel(Me.lblCMPaymentDate, "Payment Date", 365, 45)
        SetupDate(Me.dtpCMPaymentDate, 490, 42, 180)

        SetupLabel(Me.lblCMPaymentAC, "Payment A/C", 25, 90)
        SetupText(Me.txtCMPaymentAC, 150, 87, 190)

        SetupLabel(Me.lblCMCreditMode, "Credit Mode", 365, 90)
        SetupCombo(Me.cboCMCreditMode, 490, 87, 180)

        Me.grpCM.Controls.AddRange({
            Me.lblCMPaymentReceive,
            Me.txtCMPaymentReceive,
            Me.lblCMPaymentDate,
            Me.dtpCMPaymentDate,
            Me.lblCMPaymentAC,
            Me.txtCMPaymentAC,
            Me.lblCMCreditMode,
            Me.cboCMCreditMode
        })

        '=========================================================
        ' SUMMARY
        '=========================================================

        SetupLabel(Me.lblTotalPO, "Total P/O", 80, 55)
        SetupText(Me.txtTotalPO, 190, 52, 200)

        SetupLabel(Me.lblNetTotalPO, "Net Total P/O", 80, 105)
        SetupText(Me.txtNetTotalPO, 190, 102, 200)

        Me.txtTotalPO.ReadOnly = True
        Me.txtNetTotalPO.ReadOnly = True

        Me.txtTotalPO.BackColor = Color.FromArgb(239, 246, 255)
        Me.txtNetTotalPO.BackColor = Color.FromArgb(220, 252, 231)

        Me.grpSummary.Controls.AddRange({
            Me.lblTotalPO,
            Me.txtTotalPO,
            Me.lblNetTotalPO,
            Me.txtNetTotalPO
        })

        '=========================================================
        ' EXPENSE
        '=========================================================

        SetupLabel(Me.lblExpense, "Expense", 25, 45)
        SetupText(Me.txtExpense, 150, 42, 180)

        SetupLabel(Me.lblExpenseDate, "Expense Date", 365, 45)
        SetupDate(Me.dtpExpenseDate, 490, 42, 180)

        SetupLabel(Me.lblExpensePaidBy, "Paid By", 25, 90)
        SetupCombo(Me.cboExpensePaidBy, 150, 87, 180)

        SetupLabel(Me.lblExpenseMode, "Expense Mode", 365, 90)
        SetupCombo(Me.cboExpenseMode, 490, 87, 180)

        Me.grpExpense.Controls.AddRange({
            Me.lblExpense,
            Me.txtExpense,
            Me.lblExpenseDate,
            Me.dtpExpenseDate,
            Me.lblExpensePaidBy,
            Me.cboExpensePaidBy,
            Me.lblExpenseMode,
            Me.cboExpenseMode
        })

        '=========================================================
        ' RM
        '=========================================================

        SetupLabel(Me.lblRMAmount, "RM Amount", 25, 45)
        SetupText(Me.txtRMAmount, 150, 42, 180)

        SetupLabel(Me.lblRMDate, "RM Date", 365, 45)
        SetupDate(Me.dtpRMDate, 490, 42, 180)

        SetupLabel(Me.lblRMPaidBy, "Paid By", 25, 90)
        SetupCombo(Me.cboRMPaidBy, 150, 87, 180)

        SetupLabel(Me.lblRMMode, "RM Mode", 365, 90)
        SetupCombo(Me.cboRMMode, 490, 87, 180)

        Me.grpRM.Controls.AddRange({
            Me.lblRMAmount,
            Me.txtRMAmount,
            Me.lblRMDate,
            Me.dtpRMDate,
            Me.lblRMPaidBy,
            Me.cboRMPaidBy,
            Me.lblRMMode,
            Me.cboRMMode
        })

        '=========================================================
        ' FI RCU PD
        '=========================================================

        SetupLabel(Me.lblFIRcuPD, "FI, RCU & PD", 25, 45)
        SetupText(Me.txtFIRcuPD, 150, 42, 180)

        SetupLabel(Me.lblFIRcuPDDate, "Payment Date", 365, 45)
        SetupDate(Me.dtpFIRcuPDDate, 490, 42, 180)

        SetupLabel(Me.lblFIRcuPDPaidBy, "Paid By", 25, 90)
        SetupCombo(Me.cboFIRcuPDPaidBy, 150, 87, 180)

        SetupLabel(Me.lblFIRcuPDMode, "Mode", 365, 90)
        SetupCombo(Me.cboFIRcuPDMode, 490, 87, 180)

        Me.grpFIRcuPD.Controls.AddRange({
            Me.lblFIRcuPD,
            Me.txtFIRcuPD,
            Me.lblFIRcuPDDate,
            Me.dtpFIRcuPDDate,
            Me.lblFIRcuPDPaidBy,
            Me.cboFIRcuPDPaidBy,
            Me.lblFIRcuPDMode,
            Me.cboFIRcuPDMode
        })

        '=========================================================
        ' STAFF SHARING
        '=========================================================

        SetupLabel(Me.lblStaffSharing, "Staff Sharing", 25, 40)
        SetupText(Me.txtStaffSharing, 150, 37, 180)

        SetupLabel(Me.lblStaffSharingPaymentDate, "Payment Date", 365, 40)
        SetupDate(Me.dtpStaffSharingPaymentDate, 490, 37, 180)

        SetupLabel(Me.lblStaffSharingPaymentStatus, "Payment Status", 25, 85)
        SetupCombo(Me.cboStaffSharingPaymentStatus, 150, 82, 180)

        SetupLabel(Me.lblStaffSharingPaidBy, "Paid By", 365, 85)
        SetupCombo(Me.cboStaffSharingPaidBy, 490, 82, 180)

        SetupLabel(Me.lblStaffSharingMode, "Mode", 25, 130)
        SetupCombo(Me.cboStaffSharingMode, 150, 127, 180)

        Me.grpStaffSharing.Controls.AddRange({
            Me.lblStaffSharing,
            Me.txtStaffSharing,
            Me.lblStaffSharingPaymentDate,
            Me.dtpStaffSharingPaymentDate,
            Me.lblStaffSharingPaymentStatus,
            Me.cboStaffSharingPaymentStatus,
            Me.lblStaffSharingPaidBy,
            Me.cboStaffSharingPaidBy,
            Me.lblStaffSharingMode,
            Me.cboStaffSharingMode
        })

        '=========================================================
        ' ADD GROUPS TO CONTENT
        '=========================================================

        Me.pnlContent.Controls.Add(Me.grpPayout)
        Me.pnlContent.Controls.Add(Me.grpInsurance)
        Me.pnlContent.Controls.Add(Me.grpCM)
        Me.pnlContent.Controls.Add(Me.grpSummary)
        Me.pnlContent.Controls.Add(Me.grpExpense)
        Me.pnlContent.Controls.Add(Me.grpRM)
        Me.pnlContent.Controls.Add(Me.grpFIRcuPD)
        Me.pnlContent.Controls.Add(Me.grpStaffSharing)

        '=========================================================
        ' BUTTON PANEL
        '=========================================================

        Me.pnlButtons.Dock = DockStyle.Bottom
        Me.pnlButtons.Height = 70
        Me.pnlButtons.BackColor = Color.White
        Me.pnlButtons.Padding = New Padding(20)

        Me.btnSave.Text = "💾  SAVE"
        Me.btnSave.Size = New Size(130, 40)
        Me.btnSave.Location = New Point(20, 15)
        Me.btnSave.BackColor = Color.FromArgb(22, 163, 74)
        Me.btnSave.ForeColor = Color.White
        Me.btnSave.FlatStyle = FlatStyle.Flat
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnSave.Cursor = Cursors.Hand

        Me.btnUpdate.Text = "✏  UPDATE"
        Me.btnUpdate.Size = New Size(130, 40)
        Me.btnUpdate.Location = New Point(165, 15)
        Me.btnUpdate.BackColor = Color.FromArgb(37, 99, 235)
        Me.btnUpdate.ForeColor = Color.White
        Me.btnUpdate.FlatStyle = FlatStyle.Flat
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnUpdate.Cursor = Cursors.Hand

        Me.btnDelete.Text = "🗑  DELETE"
        Me.btnDelete.Size = New Size(130, 40)
        Me.btnDelete.Location = New Point(310, 15)
        Me.btnDelete.BackColor = Color.FromArgb(220, 38, 38)
        Me.btnDelete.ForeColor = Color.White
        Me.btnDelete.FlatStyle = FlatStyle.Flat
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnDelete.Cursor = Cursors.Hand

        Me.btnClear.Text = "⟳  CLEAR"
        Me.btnClear.Size = New Size(130, 40)
        Me.btnClear.Location = New Point(455, 15)
        Me.btnClear.BackColor = Color.FromArgb(100, 116, 139)
        Me.btnClear.ForeColor = Color.White
        Me.btnClear.FlatStyle = FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.btnClear.Cursor = Cursors.Hand

        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        Me.pnlButtons.Controls.Add(Me.btnClear)

        '=========================================================
        ' ADD MAIN CONTROLS
        '=========================================================

        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.pnlTop)

        Me.pnlButtons.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()

        Me.ResumeLayout(False)

    End Sub


    '=========================================================
    ' HELPER METHODS
    '=========================================================

    Private Sub SetupLabel(ByVal lbl As Label,
                           ByVal text As String,
                           ByVal x As Integer,
                           ByVal y As Integer)

        lbl.Text = text
        lbl.Location = New Point(x, y)
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(51, 65, 85)

    End Sub


    Private Sub SetupText(ByVal txt As TextBox,
                          ByVal x As Integer,
                          ByVal y As Integer,
                          ByVal width As Integer)

        txt.Location = New Point(x, y)
        txt.Size = New Size(width, 28)
        txt.Font = New Font("Segoe UI", 10)
        txt.BorderStyle = BorderStyle.FixedSingle
        txt.BackColor = Color.White
        txt.ForeColor = Color.FromArgb(15, 23, 42)

    End Sub


    Private Sub SetupCombo(ByVal cbo As ComboBox,
                           ByVal x As Integer,
                           ByVal y As Integer,
                           ByVal width As Integer)

        cbo.Location = New Point(x, y)
        cbo.Size = New Size(width, 28)
        cbo.Font = New Font("Segoe UI", 10)
        cbo.DropDownStyle = ComboBoxStyle.DropDownList
        cbo.BackColor = Color.White
        cbo.ForeColor = Color.FromArgb(15, 23, 42)

    End Sub


    Private Sub SetupDate(ByVal dtp As DateTimePicker,
                          ByVal x As Integer,
                          ByVal y As Integer,
                          ByVal width As Integer)

        dtp.Location = New Point(x, y)
        dtp.Size = New Size(width, 28)
        dtp.Font = New Font("Segoe UI", 10)
        dtp.Format = DateTimePickerFormat.Custom
        dtp.CustomFormat = "dd-MM-yyyy"

    End Sub


    '=========================================================
    ' CONTROLS
    '=========================================================

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label

    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearchTitle As Label
    Friend WithEvents lblLoginMisID As Label
    Friend WithEvents txtLoginMisID As TextBox
    Friend WithEvents btnSearch As Button

    Friend WithEvents lblCustomer As Label
    Friend WithEvents txtCustomer As TextBox

    Friend WithEvents lblApplicationNo As Label
    Friend WithEvents txtApplicationNo As TextBox

    Friend WithEvents lblLoanNo As Label
    Friend WithEvents txtLoanNo As TextBox

    Friend WithEvents lblBank As Label
    Friend WithEvents txtBank As TextBox

    Friend WithEvents pnlContent As Panel

    Friend WithEvents grpPayout As GroupBox
    Friend WithEvents lblPayoutStatus As Label
    Friend WithEvents cboPayoutStatus As ComboBox
    Friend WithEvents lblGrossBankPO As Label
    Friend WithEvents txtGrossBankPO As TextBox
    Friend WithEvents lblPOCreditAC As Label
    Friend WithEvents txtPOCreditAC As TextBox
    Friend WithEvents lblCreditMode As Label
    Friend WithEvents cboCreditMode As ComboBox
    Friend WithEvents lblCreditDate As Label
    Friend WithEvents dtpCreditDate As DateTimePicker
    Friend WithEvents lblTDS As Label
    Friend WithEvents txtTDS As TextBox
    Friend WithEvents lblNetBankPO As Label
    Friend WithEvents txtNetBankPO As TextBox

    Friend WithEvents grpInsurance As GroupBox
    Friend WithEvents lblInsurancePayment As Label
    Friend WithEvents txtInsurancePayment As TextBox
    Friend WithEvents lblInsPaymentDate As Label
    Friend WithEvents dtpInsPaymentDate As DateTimePicker
    Friend WithEvents lblInsPaymentAC As Label
    Friend WithEvents txtInsPaymentAC As TextBox
    Friend WithEvents lblInsCreditMode As Label
    Friend WithEvents cboInsCreditMode As ComboBox

    Friend WithEvents grpCM As GroupBox
    Friend WithEvents lblCMPaymentReceive As Label
    Friend WithEvents txtCMPaymentReceive As TextBox
    Friend WithEvents lblCMPaymentDate As Label
    Friend WithEvents dtpCMPaymentDate As DateTimePicker
    Friend WithEvents lblCMPaymentAC As Label
    Friend WithEvents txtCMPaymentAC As TextBox
    Friend WithEvents lblCMCreditMode As Label
    Friend WithEvents cboCMCreditMode As ComboBox

    Friend WithEvents grpSummary As GroupBox
    Friend WithEvents lblTotalPO As Label
    Friend WithEvents txtTotalPO As TextBox
    Friend WithEvents lblNetTotalPO As Label
    Friend WithEvents txtNetTotalPO As TextBox

    Friend WithEvents grpExpense As GroupBox
    Friend WithEvents lblExpense As Label
    Friend WithEvents txtExpense As TextBox
    Friend WithEvents lblExpenseDate As Label
    Friend WithEvents dtpExpenseDate As DateTimePicker
    Friend WithEvents lblExpensePaidBy As Label
    Friend WithEvents cboExpensePaidBy As ComboBox
    Friend WithEvents lblExpenseMode As Label
    Friend WithEvents cboExpenseMode As ComboBox

    Friend WithEvents grpRM As GroupBox
    Friend WithEvents lblRMAmount As Label
    Friend WithEvents txtRMAmount As TextBox
    Friend WithEvents lblRMDate As Label
    Friend WithEvents dtpRMDate As DateTimePicker
    Friend WithEvents lblRMPaidBy As Label
    Friend WithEvents cboRMPaidBy As ComboBox
    Friend WithEvents lblRMMode As Label
    Friend WithEvents cboRMMode As ComboBox

    Friend WithEvents grpFIRcuPD As GroupBox
    Friend WithEvents lblFIRcuPD As Label
    Friend WithEvents txtFIRcuPD As TextBox
    Friend WithEvents lblFIRcuPDDate As Label
    Friend WithEvents dtpFIRcuPDDate As DateTimePicker
    Friend WithEvents lblFIRcuPDPaidBy As Label
    Friend WithEvents cboFIRcuPDPaidBy As ComboBox
    Friend WithEvents lblFIRcuPDMode As Label
    Friend WithEvents cboFIRcuPDMode As ComboBox

    Friend WithEvents grpStaffSharing As GroupBox
    Friend WithEvents lblStaffSharing As Label
    Friend WithEvents txtStaffSharing As TextBox
    Friend WithEvents lblStaffSharingPaymentDate As Label
    Friend WithEvents dtpStaffSharingPaymentDate As DateTimePicker
    Friend WithEvents lblStaffSharingPaymentStatus As Label
    Friend WithEvents cboStaffSharingPaymentStatus As ComboBox
    Friend WithEvents lblStaffSharingPaidBy As Label
    Friend WithEvents cboStaffSharingPaidBy As ComboBox
    Friend WithEvents lblStaffSharingMode As Label
    Friend WithEvents cboStaffSharingMode As ComboBox

    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button

End Class