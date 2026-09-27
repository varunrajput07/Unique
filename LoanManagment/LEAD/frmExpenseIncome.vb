Public Class frmExpenseIncome

    '==================== COMMON VARIABLES ====================
    Private selectedLeadID As Integer = 0
    Private selectedLoginMisID As Integer = 0
    Private totalAmount As Decimal = 0
    Private loanAmount As Decimal = 0

    Private Sub frmExpenseIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpReceiveDate.Value = DateTime.Today
        dtpCreditDate.Value = DateTime.Today
        dtpInsCreditDate.Value = DateTime.Today
        dtpOtherReceiveDate.Value = DateTime.Today

        cboCreditModeCust.SelectedIndex = -1
        cboCreditModeBank.SelectedIndex = -1
        cboPayoutStatus.SelectedIndex = -1
        cboPOCreditAC.SelectedIndex = -1

        cboInsCreditMode.SelectedIndex = -1
        cboInsPayoutStatus.SelectedIndex = -1
        cboInsPOCreditAC.SelectedIndex = -1

        cboOtherCreditMode.SelectedIndex = -1
    End Sub

    '==============================================================
    '                     CUSTOMER TAB
    '==============================================================
    Private Sub btnSearchCust_Click(sender As Object, e As EventArgs) Handles btnSearchCust.Click
        Try
            selectedLeadID = 0
            selectedLoginMisID = 0
            totalAmount = 0
            ClearCustomerForm()

            Dim custName As String = txtSearchCustName.Text.Trim().Replace("'", "''")
            Dim mobileNo As String = txtSearchMobile.Text.Trim().Replace("'", "''")

            ssql = "SELECT " &
                   "ld.LeadMisID, lgn.LoginMisID, " &
                   "ld.CustName, ld.MobileNo, ld.PropertyNo, ld.PropertyAddress, " &
                   "ld.LoanAmount, ld.CPA, ld.BANK, lgn.Code, lgn.HODate, " &
                   "ISNULL((SELECT SUM(CAST(ExpOfrValue AS DECIMAL(18,2))) FROM ExpOfferTypeValue WITH (NOLOCK) WHERE ExpOfrLeadID = ld.LeadMisID), 0) AS TotalAmount, " &
                   "ISNULL((SELECT SUM(CAST(ReceiveAmount AS DECIMAL(18,2))) FROM ExpenseIncome WITH (NOLOCK) WHERE LeadID = ld.LeadMisID AND IncomeType = 'CUSTOMER' AND ISNULL(IsDelete,'N')='N'), 0) AS TotalReceived " &
                   "FROM LeadMIS ld WITH (NOLOCK) " &
                   "INNER JOIN LoginMIS lgn WITH (NOLOCK) ON ld.LeadMisID = lgn.LeadID " &
                   "WHERE ISNULL(ld.IsDelete,'N')='N' AND ISNULL(ld.DiscLogin,'') = 'LOGIN' "

            If custName <> "" Then ssql &= " AND ld.CustName LIKE '%" & custName & "%'"
            If mobileNo <> "" Then ssql &= " AND ld.MobileNo LIKE '%" & mobileNo & "%'"
            ssql &= " ORDER BY ld.LeadMisID DESC"

            dt = GetData(ssql)
            dgvCust.DataSource = dt

            If dgvCust.Columns.Contains("LeadMisID") Then dgvCust.Columns("LeadMisID").Visible = False
            If dgvCust.Columns.Contains("LoginMisID") Then dgvCust.Columns("LoginMisID").Visible = False

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearSearchCust_Click(sender As Object, e As EventArgs) Handles btnClearSearchCust.Click
        txtSearchCustName.Clear()
        txtSearchMobile.Clear()
        btnSearchCust.PerformClick()
    End Sub

    Private Sub dgvCust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCust.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim row As DataGridViewRow = dgvCust.Rows(e.RowIndex)

            selectedLeadID = Convert.ToInt32(GetCellValue(row, "LeadMisID"))
            selectedLoginMisID = Convert.ToInt32(GetCellValue(row, "LoginMisID"))

            txtCustName.Text = GetCellValue(row, "CustName")
            txtMobileNo.Text = GetCellValue(row, "MobileNo")
            txtPropertyNo.Text = GetCellValue(row, "PropertyNo")
            txtPropertyAdd.Text = GetCellValue(row, "PropertyAddress")
            txtLoanAmtCust.Text = FormatNumber(GetCellValue(row, "LoanAmount"), 2)
            txtCPA.Text = GetCellValue(row, "CPA")
            txtBankCust.Text = GetCellValue(row, "BANK")
            txtCodeCust.Text = GetCellValue(row, "Code")

            Dim hoDate As String = GetCellValue(row, "HODate")
            If IsDate(hoDate) Then
                txtHODateCust.Text = Convert.ToDateTime(hoDate).ToString("dd-MM-yyyy")
            Else
                txtHODateCust.Text = ""
            End If

            Decimal.TryParse(GetCellValue(row, "TotalAmount"), totalAmount)
            txtTotalAmount.Text = totalAmount.ToString("N2")

            Dim totalReceived As Decimal = 0
            Decimal.TryParse(GetCellValue(row, "TotalReceived"), totalReceived)
            txtTotalReceived.Text = totalReceived.ToString("N2")
            txtBalance.Text = (totalAmount - totalReceived).ToString("N2")

            LoadPaymentHistory(selectedLeadID)

            txtReceiveAmount.Clear()
            txtWaiver.Clear()
            txtRemarksCust.Clear()
            cboCreditModeCust.SelectedIndex = -1
            dtpReceiveDate.Value = DateTime.Today
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadPaymentHistory(leadId As Integer)
        Try
            ssql = "SELECT ExpenseIncomeID, ReceiveDate AS [Date], ReceiveAmount AS [Amount], " &
                   "CreditMode AS [Mode], ISNULL(Waiver,0) AS [Waiver], Remarks, EntBy, EntDt " &
                   "FROM ExpenseIncome WITH (NOLOCK) " &
                   "WHERE LeadID = " & leadId & " AND IncomeType = 'CUSTOMER' AND ISNULL(IsDelete,'N')='N' " &
                   "ORDER BY ReceiveDate DESC, ExpenseIncomeID DESC"

            dgvPaymentHistory.DataSource = GetData(ssql)
            If dgvPaymentHistory.Columns.Contains("ExpenseIncomeID") Then
                dgvPaymentHistory.Columns("ExpenseIncomeID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveCust_Click(sender As Object, e As EventArgs) Handles btnSaveCust.Click
        Try
            If selectedLeadID = 0 Then
                MessageBox.Show("Please select a customer first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtReceiveAmount.Text) Then
                MessageBox.Show("Please enter Receive Amount.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim receiveAmt As Decimal
            If Not Decimal.TryParse(txtReceiveAmount.Text.Trim(), receiveAmt) OrElse receiveAmt <= 0 Then
                MessageBox.Show("Receive Amount must be greater than 0.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(cboCreditModeCust.Text) Then
                MessageBox.Show("Please select Credit Mode.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim waiverAmt As Decimal = 0
            Decimal.TryParse(txtWaiver.Text.Trim(), waiverAmt)

            ssql = "INSERT INTO ExpenseIncome (" &
                   "LeadID, LoginMisID, IncomeType, ReceiveAmount, ReceiveDate, CreditMode, Waiver, Remarks, EntBy, EntDt, IsDelete) VALUES (" &
                   selectedLeadID & "," & selectedLoginMisID & ",'CUSTOMER'," &
                   receiveAmt & ",'" & Format(dtpReceiveDate.Value, "yyyy-MM-dd") & "'," &
                   "'" & cboCreditModeCust.Text.Trim().Replace("'", "''") & "'," &
                   waiverAmt & ",'" & txtRemarksCust.Text.Trim().Replace("'", "''") & "'," &
                   "'" & SessionEmpId & "',GETDATE(),'N')"

            ExecuteQuery(ssql)
            MessageBox.Show("Payment of ₹ " & receiveAmt.ToString("N2") & " saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnSearchCust.PerformClick()
            txtReceiveAmount.Clear()
            txtWaiver.Clear()
            txtRemarksCust.Clear()
            cboCreditModeCust.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearCust_Click(sender As Object, e As EventArgs) Handles btnClearCust.Click
        ClearCustomerForm()
    End Sub

    Private Sub ClearCustomerForm()
        selectedLeadID = 0
        selectedLoginMisID = 0
        totalAmount = 0

        txtCustName.Clear()
        txtMobileNo.Clear()
        txtPropertyNo.Clear()
        txtPropertyAdd.Clear()
        txtLoanAmtCust.Clear()
        txtCPA.Clear()
        txtBankCust.Clear()
        txtCodeCust.Clear()
        txtHODateCust.Clear()

        txtTotalAmount.Text = "0.00"
        txtTotalReceived.Text = "0.00"
        txtBalance.Text = "0.00"

        txtReceiveAmount.Clear()
        txtWaiver.Clear()
        txtRemarksCust.Clear()
        cboCreditModeCust.SelectedIndex = -1
        dgvPaymentHistory.DataSource = Nothing
    End Sub

    '==============================================================
    '                     BANK TAB
    '==============================================================
    Private Sub btnSearchBank_Click(sender As Object, e As EventArgs) Handles btnSearchBank.Click
        Try
            selectedLeadID = 0
            selectedLoginMisID = 0
            loanAmount = 0
            ClearBankForm()
            dgvBank.DataSource = Nothing

            Dim custName As String = txtSearchBankCust.Text.Trim().Replace("'", "''")
            Dim mobileNo As String = txtSearchBankMobile.Text.Trim().Replace("'", "''")

            ssql = "SELECT " &
                   "ld.LeadMisID, lgn.LoginMisID, " &
                   "ld.CustName, ld.MobileNo, ld.PropertyNo, ld.PropertyAddress, " &
                   "ld.LoanAmount, ld.CPA, ld.BANK, lgn.Code, lgn.HODate, " &
                   "ISNULL((SELECT SUM(CAST(NetBankPO AS DECIMAL(18,2))) FROM ExpenseIncome WITH (NOLOCK) WHERE LeadID = ld.LeadMisID AND IncomeType = 'BANK' AND ISNULL(IsDelete,'N')='N'), 0) AS TotalNetReceived " &
                   "FROM LeadMIS ld WITH (NOLOCK) " &
                   "INNER JOIN LoginMIS lgn WITH (NOLOCK) ON ld.LeadMisID = lgn.LeadID " &
                   "WHERE ISNULL(ld.IsDelete,'N')='N' AND ISNULL(ld.DiscLogin,'') = 'LOGIN' "

            If custName <> "" Then ssql &= " AND ld.CustName LIKE '%" & custName & "%'"
            If mobileNo <> "" Then ssql &= " AND ld.MobileNo LIKE '%" & mobileNo & "%'"
            ssql &= " ORDER BY ld.LeadMisID DESC"

            dt = GetData(ssql)
            dgvBank.DataSource = dt

            If dgvBank.Columns.Contains("LeadMisID") Then dgvBank.Columns("LeadMisID").Visible = False
            If dgvBank.Columns.Contains("LoginMisID") Then dgvBank.Columns("LoginMisID").Visible = False

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearSearchBank_Click(sender As Object, e As EventArgs) Handles btnClearSearchBank.Click
        txtSearchBankCust.Clear()
        txtSearchBankMobile.Clear()
        btnSearchBank.PerformClick()
    End Sub

    Private Sub dgvBank_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBank.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim row As DataGridViewRow = dgvBank.Rows(e.RowIndex)

            selectedLeadID = Convert.ToInt32(GetCellValue(row, "LeadMisID"))
            selectedLoginMisID = Convert.ToInt32(GetCellValue(row, "LoginMisID"))

            txtBankCustName.Text = GetCellValue(row, "CustName")
            txtBankMobile.Text = GetCellValue(row, "MobileNo")
            txtPropertyNoBank.Text = GetCellValue(row, "PropertyNo")
            txtPropertyAddBank.Text = GetCellValue(row, "PropertyAddress")
            txtCPABank.Text = GetCellValue(row, "CPA")
            txtBankName.Text = GetCellValue(row, "BANK")
            txtCodeBank.Text = GetCellValue(row, "Code")

            Dim hoDate As String = GetCellValue(row, "HODate")
            If IsDate(hoDate) Then
                txtHODateBank.Text = Convert.ToDateTime(hoDate).ToString("dd-MM-yyyy")
            Else
                txtHODateBank.Text = ""
            End If

            Decimal.TryParse(GetCellValue(row, "LoanAmount"), loanAmount)
            txtLoanAmount.Text = loanAmount.ToString("N2")

            LoadBankPaymentHistory(selectedLeadID)

            cboPayoutStatus.SelectedIndex = -1
            cboPOCreditAC.SelectedIndex = -1
            cboCreditModeBank.SelectedIndex = -1
            dtpCreditDate.Value = DateTime.Today
            txtGrossPercent.Text = "0.90"
            radTDSPercent.Checked = True
            txtTDSPercent.Text = "2"
            txtTDSFixedAmount.Clear()
            txtGrossBankPO.Clear()
            txtTDS.Clear()
            txtNetBankPO.Clear()
            txtRemarksBank.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadBankPaymentHistory(leadId As Integer)
        Try
            ssql = "SELECT ExpenseIncomeID, PayoutStatus AS [Status], POCreditAC AS [P/O Credit A/C], " &
                   "CreditMode AS [Mode], ReceiveDate AS [Credit Date], GrossBankPO AS [Gross P/O], " &
                   "TDS, NetBankPO AS [Net P/O], Remarks, EntBy, EntDt " &
                   "FROM ExpenseIncome WITH (NOLOCK) " &
                   "WHERE LeadID = " & leadId & " AND IncomeType = 'BANK' AND ISNULL(IsDelete,'N') = 'N' " &
                   "ORDER BY ReceiveDate DESC, ExpenseIncomeID DESC"

            dgvBank.DataSource = GetData(ssql)
            If dgvBank.Columns.Contains("ExpenseIncomeID") Then
                dgvBank.Columns("ExpenseIncomeID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TdsType_CheckedChanged(sender As Object, e As EventArgs) Handles radTDSPercent.CheckedChanged, radTDSFixed.CheckedChanged
        txtTDSPercent.Enabled = radTDSPercent.Checked
        txtTDSFixedAmount.Enabled = radTDSFixed.Checked
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            If loanAmount <= 0 Then
                MessageBox.Show("Please select a customer first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim grossPercent As Decimal
            If Not Decimal.TryParse(txtGrossPercent.Text.Trim(), grossPercent) OrElse grossPercent <= 0 Then
                MessageBox.Show("Please enter a valid Gross %.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim gross As Decimal = Math.Round(loanAmount * grossPercent / 100, 2)
            txtGrossBankPO.Text = gross.ToString("N2")

            Dim tds As Decimal
            If radTDSPercent.Checked Then
                Dim tdsPercent As Decimal
                If Not Decimal.TryParse(txtTDSPercent.Text.Trim(), tdsPercent) OrElse tdsPercent < 0 Then
                    MessageBox.Show("Please enter a valid TDS %.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                tds = Math.Round(gross * tdsPercent / 100, 2)
            ElseIf radTDSFixed.Checked Then
                If Not Decimal.TryParse(txtTDSFixedAmount.Text.Trim(), tds) OrElse tds < 0 Then
                    MessageBox.Show("Please enter a valid Fixed TDS amount.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Else
                MessageBox.Show("Please select TDS % or Fixed Amount.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If tds > gross Then
                MessageBox.Show("TDS amount cannot be greater than Gross Bank P/O.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            txtTDS.Text = tds.ToString("N2")
            txtNetBankPO.Text = (gross - tds).ToString("N2")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveBank_Click(sender As Object, e As EventArgs) Handles btnSaveBank.Click
        Try
            If selectedLeadID = 0 Then
                MessageBox.Show("Please select a customer first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(cboPayoutStatus.Text) Then
                MessageBox.Show("Please select Payout Status.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(cboPOCreditAC.Text) Then
                MessageBox.Show("Please select P/O Credit A/C.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(cboCreditModeBank.Text) Then
                MessageBox.Show("Please select Credit Mode.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtGrossBankPO.Text) Then
                MessageBox.Show("Please calculate or enter Gross Bank P/O.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim gross As Decimal = Convert.ToDecimal(txtGrossBankPO.Text)
            Dim tds As Decimal = Convert.ToDecimal(txtTDS.Text)
            Dim net As Decimal = Convert.ToDecimal(txtNetBankPO.Text)

            ssql = "INSERT INTO ExpenseIncome (" &
                   "LeadID, LoginMisID, IncomeType, " &
                   "PayoutStatus, POCreditAC, CreditMode, " &
                   "ReceiveDate, GrossBankPO, TDS, NetBankPO, " &
                   "Remarks, EntBy, EntDt, IsDelete) VALUES (" &
                   selectedLeadID & "," & selectedLoginMisID & ",'BANK'," &
                   "'" & cboPayoutStatus.Text.Trim().Replace("'", "''") & "'," &
                   "'" & cboPOCreditAC.Text.Trim().Replace("'", "''") & "'," &
                   "'" & cboCreditModeBank.Text.Trim().Replace("'", "''") & "'," &
                   "'" & Format(dtpCreditDate.Value, "yyyy-MM-dd") & "'," &
                   gross & "," & tds & "," & net & "," &
                   "'" & txtRemarksBank.Text.Trim().Replace("'", "''") & "'," &
                   "'" & SessionEmpId & "', GETDATE(), 'N')"

            ExecuteQuery(ssql)
            MessageBox.Show("Bank Payout of ₹ " & net.ToString("N2") & " saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadBankPaymentHistory(selectedLeadID)

            cboPayoutStatus.SelectedIndex = -1
            cboPOCreditAC.SelectedIndex = -1
            cboCreditModeBank.SelectedIndex = -1
            dtpCreditDate.Value = DateTime.Today
            txtGrossPercent.Text = "0.90"
            radTDSPercent.Checked = True
            txtTDSPercent.Text = "2"
            txtTDSFixedAmount.Clear()
            txtGrossBankPO.Clear()
            txtTDS.Clear()
            txtNetBankPO.Clear()
            txtRemarksBank.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearBank_Click(sender As Object, e As EventArgs) Handles btnClearBank.Click
        ClearBankForm()
    End Sub

    Private Sub ClearBankForm()
        selectedLeadID = 0
        selectedLoginMisID = 0
        loanAmount = 0

        txtBankCustName.Clear()
        txtBankMobile.Clear()
        txtPropertyNoBank.Clear()
        txtPropertyAddBank.Clear()
        txtLoanAmount.Clear()
        txtCPABank.Clear()
        txtBankName.Clear()
        txtCodeBank.Clear()
        txtHODateBank.Clear()

        cboPayoutStatus.SelectedIndex = -1
        cboPOCreditAC.SelectedIndex = -1
        cboCreditModeBank.SelectedIndex = -1
        dtpCreditDate.Value = DateTime.Today
        txtGrossPercent.Text = "0.90"
        radTDSPercent.Checked = True
        txtTDSPercent.Text = "2"
        txtTDSFixedAmount.Clear()
        txtGrossBankPO.Clear()
        txtTDS.Clear()
        txtNetBankPO.Clear()
        txtRemarksBank.Clear()
    End Sub

    '==============================================================
    '                     INSURANCE TAB  (Same as Bank)
    '==============================================================
    Private Sub btnSearchIns_Click(sender As Object, e As EventArgs) Handles btnSearchIns.Click
        Try
            selectedLeadID = 0
            selectedLoginMisID = 0
            loanAmount = 0
            ClearInsuranceForm()
            dgvInsurance.DataSource = Nothing

            Dim custName As String = txtSearchInsCust.Text.Trim().Replace("'", "''")
            Dim mobileNo As String = txtSearchInsMobile.Text.Trim().Replace("'", "''")

            ssql = "SELECT " &
                   "ld.LeadMisID, lgn.LoginMisID, " &
                   "ld.CustName, ld.MobileNo, ld.PropertyNo, ld.PropertyAddress, " &
                   "ld.LoanAmount, ld.CPA, ld.BANK, lgn.Code, lgn.HODate, " &
                   "ISNULL((SELECT SUM(CAST(NetBankPO AS DECIMAL(18,2))) FROM ExpenseIncome WITH (NOLOCK) WHERE LeadID = ld.LeadMisID AND IncomeType = 'INSURANCE' AND ISNULL(IsDelete,'N')='N'), 0) AS TotalNetReceived " &
                   "FROM LeadMIS ld WITH (NOLOCK) " &
                   "INNER JOIN LoginMIS lgn WITH (NOLOCK) ON ld.LeadMisID = lgn.LeadID " &
                   "WHERE ISNULL(ld.IsDelete,'N')='N' AND ISNULL(ld.DiscLogin,'') = 'LOGIN' "

            If custName <> "" Then ssql &= " AND ld.CustName LIKE '%" & custName & "%'"
            If mobileNo <> "" Then ssql &= " AND ld.MobileNo LIKE '%" & mobileNo & "%'"
            ssql &= " ORDER BY ld.LeadMisID DESC"

            dt = GetData(ssql)
            dgvInsurance.DataSource = dt

            If dgvInsurance.Columns.Contains("LeadMisID") Then dgvInsurance.Columns("LeadMisID").Visible = False
            If dgvInsurance.Columns.Contains("LoginMisID") Then dgvInsurance.Columns("LoginMisID").Visible = False

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearSearchIns_Click(sender As Object, e As EventArgs) Handles btnClearSearchIns.Click
        txtSearchInsCust.Clear()
        txtSearchInsMobile.Clear()
        btnSearchIns.PerformClick()
    End Sub

    Private Sub dgvInsurance_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInsurance.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim row As DataGridViewRow = dgvInsurance.Rows(e.RowIndex)

            selectedLeadID = Convert.ToInt32(GetCellValue(row, "LeadMisID"))
            selectedLoginMisID = Convert.ToInt32(GetCellValue(row, "LoginMisID"))

            txtInsCustName.Text = GetCellValue(row, "CustName")
            txtInsMobile.Text = GetCellValue(row, "MobileNo")
            txtInsPropertyNo.Text = GetCellValue(row, "PropertyNo")
            txtInsPropertyAdd.Text = GetCellValue(row, "PropertyAddress")
            txtInsCPA.Text = GetCellValue(row, "CPA")
            txtInsBank.Text = GetCellValue(row, "BANK")
            txtInsCode.Text = GetCellValue(row, "Code")

            Dim hoDate As String = GetCellValue(row, "HODate")
            If IsDate(hoDate) Then
                txtInsHODate.Text = Convert.ToDateTime(hoDate).ToString("dd-MM-yyyy")
            Else
                txtInsHODate.Text = ""
            End If

            Decimal.TryParse(GetCellValue(row, "LoanAmount"), loanAmount)
            txtInsLoanAmount.Text = loanAmount.ToString("N2")

            LoadInsuranceHistory(selectedLeadID)

            cboInsPayoutStatus.SelectedIndex = -1
            cboInsPOCreditAC.SelectedIndex = -1
            cboInsCreditMode.SelectedIndex = -1
            dtpInsCreditDate.Value = DateTime.Today
            txtInsGrossPercent.Text = "0.90"
            radInsTDSPercent.Checked = True
            txtInsTDSPercent.Text = "2"
            txtInsTDSFixed.Clear()
            txtInsGrossPO.Clear()
            txtInsTDS.Clear()
            txtInsNetPO.Clear()
            txtInsRemarks.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadInsuranceHistory(leadId As Integer)
        Try
            ssql = "SELECT ExpenseIncomeID, PayoutStatus AS [Status], POCreditAC AS [P/O Credit A/C], " &
                   "CreditMode AS [Mode], ReceiveDate AS [Credit Date], GrossBankPO AS [Gross P/O], " &
                   "TDS, NetBankPO AS [Net P/O], Remarks, EntBy, EntDt " &
                   "FROM ExpenseIncome WITH (NOLOCK) " &
                   "WHERE LeadID = " & leadId & " AND IncomeType = 'INSURANCE' AND ISNULL(IsDelete,'N') = 'N' " &
                   "ORDER BY ReceiveDate DESC, ExpenseIncomeID DESC"

            dgvInsurance.DataSource = GetData(ssql)
            If dgvInsurance.Columns.Contains("ExpenseIncomeID") Then
                dgvInsurance.Columns("ExpenseIncomeID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InsTdsType_CheckedChanged(sender As Object, e As EventArgs) Handles radInsTDSPercent.CheckedChanged, radInsTDSFixed.CheckedChanged
        txtInsTDSPercent.Enabled = radInsTDSPercent.Checked
        txtInsTDSFixed.Enabled = radInsTDSFixed.Checked
    End Sub

    Private Sub btnInsCalculate_Click(sender As Object, e As EventArgs) Handles btnInsCalculate.Click
        Try
            If loanAmount <= 0 Then
                MessageBox.Show("Please select a customer first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim grossPercent As Decimal
            If Not Decimal.TryParse(txtInsGrossPercent.Text.Trim(), grossPercent) OrElse grossPercent <= 0 Then
                MessageBox.Show("Please enter a valid Gross %.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim gross As Decimal = Math.Round(loanAmount * grossPercent / 100, 2)
            txtInsGrossPO.Text = gross.ToString("N2")

            Dim tds As Decimal
            If radInsTDSPercent.Checked Then
                Dim tdsPercent As Decimal
                If Not Decimal.TryParse(txtInsTDSPercent.Text.Trim(), tdsPercent) OrElse tdsPercent < 0 Then
                    MessageBox.Show("Please enter a valid TDS %.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                tds = Math.Round(gross * tdsPercent / 100, 2)
            ElseIf radInsTDSFixed.Checked Then
                If Not Decimal.TryParse(txtInsTDSFixed.Text.Trim(), tds) OrElse tds < 0 Then
                    MessageBox.Show("Please enter a valid Fixed TDS amount.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Else
                MessageBox.Show("Please select TDS % or Fixed Amount.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If tds > gross Then
                MessageBox.Show("TDS amount cannot be greater than Gross P/O.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            txtInsTDS.Text = tds.ToString("N2")
            txtInsNetPO.Text = (gross - tds).ToString("N2")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveIns_Click(sender As Object, e As EventArgs) Handles btnSaveIns.Click
        Try
            If selectedLeadID = 0 Then
                MessageBox.Show("Please select a customer first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(cboInsPayoutStatus.Text) Then
                MessageBox.Show("Please select Payout Status.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(cboInsPOCreditAC.Text) Then
                MessageBox.Show("Please select P/O Credit A/C.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(cboInsCreditMode.Text) Then
                MessageBox.Show("Please select Credit Mode.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtInsGrossPO.Text) Then
                MessageBox.Show("Please calculate or enter Gross P/O.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim gross As Decimal = Convert.ToDecimal(txtInsGrossPO.Text)
            Dim tds As Decimal = Convert.ToDecimal(txtInsTDS.Text)
            Dim net As Decimal = Convert.ToDecimal(txtInsNetPO.Text)

            ssql = "INSERT INTO ExpenseIncome (" &
                   "LeadID, LoginMisID, IncomeType, " &
                   "PayoutStatus, POCreditAC, CreditMode, " &
                   "ReceiveDate, GrossBankPO, TDS, NetBankPO, " &
                   "Remarks, EntBy, EntDt, IsDelete) VALUES (" &
                   selectedLeadID & "," & selectedLoginMisID & ",'INSURANCE'," &
                   "'" & cboInsPayoutStatus.Text.Trim().Replace("'", "''") & "'," &
                   "'" & cboInsPOCreditAC.Text.Trim().Replace("'", "''") & "'," &
                   "'" & cboInsCreditMode.Text.Trim().Replace("'", "''") & "'," &
                   "'" & Format(dtpInsCreditDate.Value, "yyyy-MM-dd") & "'," &
                   gross & "," & tds & "," & net & "," &
                   "'" & txtInsRemarks.Text.Trim().Replace("'", "''") & "'," &
                   "'" & SessionEmpId & "', GETDATE(), 'N')"

            ExecuteQuery(ssql)
            MessageBox.Show("Insurance Payout of ₹ " & net.ToString("N2") & " saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadInsuranceHistory(selectedLeadID)

            cboInsPayoutStatus.SelectedIndex = -1
            cboInsPOCreditAC.SelectedIndex = -1
            cboInsCreditMode.SelectedIndex = -1
            dtpInsCreditDate.Value = DateTime.Today
            txtInsGrossPercent.Text = "0.90"
            radInsTDSPercent.Checked = True
            txtInsTDSPercent.Text = "2"
            txtInsTDSFixed.Clear()
            txtInsGrossPO.Clear()
            txtInsTDS.Clear()
            txtInsNetPO.Clear()
            txtInsRemarks.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearIns_Click(sender As Object, e As EventArgs) Handles btnClearIns.Click
        ClearInsuranceForm()
    End Sub

    Private Sub ClearInsuranceForm()
        selectedLeadID = 0
        selectedLoginMisID = 0
        loanAmount = 0

        txtInsCustName.Clear()
        txtInsMobile.Clear()
        txtInsPropertyNo.Clear()
        txtInsPropertyAdd.Clear()
        txtInsLoanAmount.Clear()
        txtInsCPA.Clear()
        txtInsBank.Clear()
        txtInsCode.Clear()
        txtInsHODate.Clear()

        cboInsPayoutStatus.SelectedIndex = -1
        cboInsPOCreditAC.SelectedIndex = -1
        cboInsCreditMode.SelectedIndex = -1
        dtpInsCreditDate.Value = DateTime.Today
        txtInsGrossPercent.Text = "0.90"
        radInsTDSPercent.Checked = True
        txtInsTDSPercent.Text = "2"
        txtInsTDSFixed.Clear()
        txtInsGrossPO.Clear()
        txtInsTDS.Clear()
        txtInsNetPO.Clear()
        txtInsRemarks.Clear()
    End Sub

    '==============================================================
    '                     OTHER TAB  (Same as Customer)
    '==============================================================
    Private Sub btnSearchOther_Click(sender As Object, e As EventArgs) Handles btnSearchOther.Click
        Try
            selectedLeadID = 0
            selectedLoginMisID = 0
            totalAmount = 0
            ClearOtherForm()

            Dim custName As String = txtSearchOtherCust.Text.Trim().Replace("'", "''")
            Dim mobileNo As String = txtSearchOtherMobile.Text.Trim().Replace("'", "''")

            ssql = "SELECT " &
                   "ld.LeadMisID, lgn.LoginMisID, " &
                   "ld.CustName, ld.MobileNo, ld.PropertyNo, ld.PropertyAddress, " &
                   "ld.LoanAmount, ld.CPA, ld.BANK, lgn.Code, lgn.HODate, " &
                   "ISNULL((SELECT SUM(CAST(ExpOfrValue AS DECIMAL(18,2))) FROM ExpOfferTypeValue WITH (NOLOCK) WHERE ExpOfrLeadID = ld.LeadMisID), 0) AS TotalAmount, " &
                   "ISNULL((SELECT SUM(CAST(ReceiveAmount AS DECIMAL(18,2))) FROM ExpenseIncome WITH (NOLOCK) WHERE LeadID = ld.LeadMisID AND IncomeType = 'OTHER' AND ISNULL(IsDelete,'N')='N'), 0) AS TotalReceived " &
                   "FROM LeadMIS ld WITH (NOLOCK) " &
                   "INNER JOIN LoginMIS lgn WITH (NOLOCK) ON ld.LeadMisID = lgn.LeadID " &
                   "WHERE ISNULL(ld.IsDelete,'N')='N' AND ISNULL(ld.DiscLogin,'') = 'LOGIN' "

            If custName <> "" Then ssql &= " AND ld.CustName LIKE '%" & custName & "%'"
            If mobileNo <> "" Then ssql &= " AND ld.MobileNo LIKE '%" & mobileNo & "%'"
            ssql &= " ORDER BY ld.LeadMisID DESC"

            dt = GetData(ssql)
            dgvOther.DataSource = dt

            If dgvOther.Columns.Contains("LeadMisID") Then dgvOther.Columns("LeadMisID").Visible = False
            If dgvOther.Columns.Contains("LoginMisID") Then dgvOther.Columns("LoginMisID").Visible = False

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearSearchOther_Click(sender As Object, e As EventArgs) Handles btnClearSearchOther.Click
        txtSearchOtherCust.Clear()
        txtSearchOtherMobile.Clear()
        btnSearchOther.PerformClick()
    End Sub

    Private Sub dgvOther_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOther.CellClick
        If e.RowIndex < 0 Then Return
        Try
            Dim row As DataGridViewRow = dgvOther.Rows(e.RowIndex)

            selectedLeadID = Convert.ToInt32(GetCellValue(row, "LeadMisID"))
            selectedLoginMisID = Convert.ToInt32(GetCellValue(row, "LoginMisID"))

            txtOtherCustName.Text = GetCellValue(row, "CustName")
            txtOtherMobile.Text = GetCellValue(row, "MobileNo")
            txtOtherPropertyNo.Text = GetCellValue(row, "PropertyNo")
            txtOtherPropertyAdd.Text = GetCellValue(row, "PropertyAddress")
            txtOtherLoanAmt.Text = FormatNumber(GetCellValue(row, "LoanAmount"), 2)
            txtOtherCPA.Text = GetCellValue(row, "CPA")
            txtOtherBank.Text = GetCellValue(row, "BANK")
            txtOtherCode.Text = GetCellValue(row, "Code")

            Dim hoDate As String = GetCellValue(row, "HODate")
            If IsDate(hoDate) Then
                txtOtherHODate.Text = Convert.ToDateTime(hoDate).ToString("dd-MM-yyyy")
            Else
                txtOtherHODate.Text = ""
            End If

            Decimal.TryParse(GetCellValue(row, "TotalAmount"), totalAmount)
            txtOtherTotalAmount.Text = totalAmount.ToString("N2")

            Dim totalReceived As Decimal = 0
            Decimal.TryParse(GetCellValue(row, "TotalReceived"), totalReceived)
            txtOtherTotalReceived.Text = totalReceived.ToString("N2")
            txtOtherBalance.Text = (totalAmount - totalReceived).ToString("N2")

            LoadOtherHistory(selectedLeadID)

            txtOtherReceiveAmount.Clear()
            txtOtherWaiver.Clear()
            txtOtherRemarks.Clear()
            cboOtherCreditMode.SelectedIndex = -1
            dtpOtherReceiveDate.Value = DateTime.Today
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LoadOtherHistory(leadId As Integer)
        Try
            ssql = "SELECT ExpenseIncomeID, ReceiveDate AS [Date], ReceiveAmount AS [Amount], " &
                   "CreditMode AS [Mode], ISNULL(Waiver,0) AS [Waiver], Remarks, EntBy, EntDt " &
                   "FROM ExpenseIncome WITH (NOLOCK) " &
                   "WHERE LeadID = " & leadId & " AND IncomeType = 'OTHER' AND ISNULL(IsDelete,'N')='N' " &
                   "ORDER BY ReceiveDate DESC, ExpenseIncomeID DESC"

            dgvOtherHistory.DataSource = GetData(ssql)
            If dgvOtherHistory.Columns.Contains("ExpenseIncomeID") Then
                dgvOtherHistory.Columns("ExpenseIncomeID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveOther_Click(sender As Object, e As EventArgs) Handles btnSaveOther.Click
        Try
            If selectedLeadID = 0 Then
                MessageBox.Show("Please select a customer first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtOtherReceiveAmount.Text) Then
                MessageBox.Show("Please enter Receive Amount.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim receiveAmt As Decimal
            If Not Decimal.TryParse(txtOtherReceiveAmount.Text.Trim(), receiveAmt) OrElse receiveAmt <= 0 Then
                MessageBox.Show("Receive Amount must be greater than 0.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(cboOtherCreditMode.Text) Then
                MessageBox.Show("Please select Credit Mode.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim waiverAmt As Decimal = 0
            Decimal.TryParse(txtOtherWaiver.Text.Trim(), waiverAmt)

            ssql = "INSERT INTO ExpenseIncome (" &
                   "LeadID, LoginMisID, IncomeType, ReceiveAmount, ReceiveDate, CreditMode, Waiver, Remarks, EntBy, EntDt, IsDelete) VALUES (" &
                   selectedLeadID & "," & selectedLoginMisID & ",'OTHER'," &
                   receiveAmt & ",'" & Format(dtpOtherReceiveDate.Value, "yyyy-MM-dd") & "'," &
                   "'" & cboOtherCreditMode.Text.Trim().Replace("'", "''") & "'," &
                   waiverAmt & ",'" & txtOtherRemarks.Text.Trim().Replace("'", "''") & "'," &
                   "'" & SessionEmpId & "',GETDATE(),'N')"

            ExecuteQuery(ssql)
            MessageBox.Show("Payment of ₹ " & receiveAmt.ToString("N2") & " saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnSearchOther.PerformClick()
            txtOtherReceiveAmount.Clear()
            txtOtherWaiver.Clear()
            txtOtherRemarks.Clear()
            cboOtherCreditMode.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearOther_Click(sender As Object, e As EventArgs) Handles btnClearOther.Click
        ClearOtherForm()
    End Sub

    Private Sub ClearOtherForm()
        selectedLeadID = 0
        selectedLoginMisID = 0
        totalAmount = 0

        txtOtherCustName.Clear()
        txtOtherMobile.Clear()
        txtOtherPropertyNo.Clear()
        txtOtherPropertyAdd.Clear()
        txtOtherLoanAmt.Clear()
        txtOtherCPA.Clear()
        txtOtherBank.Clear()
        txtOtherCode.Clear()
        txtOtherHODate.Clear()

        txtOtherTotalAmount.Text = "0.00"
        txtOtherTotalReceived.Text = "0.00"
        txtOtherBalance.Text = "0.00"

        txtOtherReceiveAmount.Clear()
        txtOtherWaiver.Clear()
        txtOtherRemarks.Clear()
        cboOtherCreditMode.SelectedIndex = -1
        dgvOtherHistory.DataSource = Nothing
    End Sub

End Class