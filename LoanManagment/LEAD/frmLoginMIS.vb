Public Class frmLoginMIS

    Private selectedLoginMisID As Integer = 0
    Private selectedLeadMisID As Integer = 0

    Private Sub frmLoginMIS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDasatavgeDate.Value = DateTime.Today
        dtpRMDate.Value = DateTime.Today
        dtpHODate.Value = DateTime.Today
        dtpLeadDate.Value = DateTime.Today

        ssql = "SELECT StageType FROM StageMst WHERE IsActive='Y'"
        FillCombo(txtStage, GetData(ssql), "StageType")

        ssql = "SELECT BankName FROM BankMst WHERE IsActive='Y'"
        FillCombo(txtBank, GetData(ssql), "BankName")

        ssql = "SELECT CodeName FROM CodeMst WHERE IsActive='Y'"
        FillCombo(CboCode, GetData(ssql), "CodeName")

        ssql = "SELECT ExpOfferType FROM ExpOfferMst WHERE IsActive='Y'"
        FillCombo(txtExpOfr, GetData(ssql), "ExpOfferType")

        ssql = "SELECT CPAName FROM CPAMst WHERE IsActive='Y'"
        FillCombo(CboCPA, GetData(ssql), "CPAName")
    End Sub

    '==============================================================
    ' SEARCH / REFRESH
    '==============================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            selectedLoginMisID = 0
            selectedLeadMisID = 0
            txtGrossTotal.Text = "0.00"
            dgvExpense.DataSource = Nothing

            Dim custName As String = txtSearchCustName.Text.Trim().Replace("'", "''")
            Dim mobileNo As String = txtSearchMobile.Text.Trim().Replace("'", "''")

            ssql = "SELECT lgn.LoginMisID, lgn.LoginDate, lgn.ApplicationNo, lgn.LoanNo, " &
                   "ld.CustName, ld.MobileNo, ld.Stage, ld.BANK, lgn.LLPSNo, " &
                   "lgn.BranchSoleID, lgn.Code, lgn.DastavageDate, lgn.RMDate, lgn.HODate, " &
                   "ld.LoanAmount, ld.CPA, ld.PropertyNo, ld.PropertyAddress, ld.OtherPropertyAddress, " &
                   "ld.LeadMisID, " &
                   "ISNULL((SELECT SUM(CAST(ExpOfrValue AS DECIMAL(18,2))) " &
                   "        FROM ExpOfferTypeValue WITH (NOLOCK) " &
                   "        WHERE ExpOfrLeadID = ld.LeadMisID), 0) AS GrossTotal " &
                   "FROM LeadMIS ld WITH (NOLOCK) " &
                   "LEFT JOIN LoginMIS lgn WITH (NOLOCK) ON ld.LeadMisID = lgn.LeadID " &
                   "WHERE 1=1"

            If custName <> "" Then ssql &= " AND ld.CustName LIKE '%" & custName & "%'"
            If mobileNo <> "" Then ssql &= " AND ld.MobileNo LIKE '%" & mobileNo & "%'"

            ssql &= " ORDER BY lgn.LoginDate DESC"

            dt = GetData(ssql)
            dgv.DataSource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearchCustName.Clear()
        txtSearchMobile.Clear()
        btnRefresh.PerformClick()
    End Sub

    '==============================================================
    ' CELL CLICK → Fill Form + Load Expenses
    '==============================================================
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)

            If row.Cells("LoginMisID").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("LoginMisID").Value) Then
                selectedLoginMisID = Convert.ToInt32(row.Cells("LoginMisID").Value)
            Else
                selectedLoginMisID = 0
            End If

            If row.Cells("LeadMisID").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("LeadMisID").Value) Then
                selectedLeadMisID = Convert.ToInt32(row.Cells("LeadMisID").Value)
            Else
                selectedLeadMisID = 0
            End If

            ' Fill form
            If row.Cells("LoginDate").Value IsNot Nothing AndAlso IsDate(row.Cells("LoginDate").Value) Then
                dtpLeadDate.Value = Convert.ToDateTime(row.Cells("LoginDate").Value)
            Else
                dtpLeadDate.Value = DateTime.Today
            End If

            txtCustName.Text = GetCellValue(row, "CustName")
            txtMobileNo.Text = GetCellValue(row, "MobileNo")
            txtAppNo.Text = GetCellValue(row, "ApplicationNo")
            txtLoanNo.Text = GetCellValue(row, "LoanNo")
            txtStage.Text = GetCellValue(row, "Stage")
            txtBank.Text = GetCellValue(row, "BANK")
            txtLLPs.Text = GetCellValue(row, "LLPSNo")
            txtBranchSole.Text = GetCellValue(row, "BranchSoleID")
            CboCPA.Text = GetCellValue(row, "CPA")
            txtLoanAmnt.Text = GetCellValue(row, "LoanAmount")
            txtPropertyNo.Text = GetCellValue(row, "PropertyNo")
            txtPropertyAdd.Text = GetCellValue(row, "PropertyAddress")
            txtOtherPropAdd.Text = GetCellValue(row, "OtherPropertyAddress")
            CboCode.Text = GetCellValue(row, "Code")
            txtGrossTotal.Text = GetCellValue(row, "GrossTotal")

            If row.Cells("DastavageDate").Value IsNot Nothing AndAlso IsDate(row.Cells("DastavageDate").Value) Then
                dtpDasatavgeDate.Value = Convert.ToDateTime(row.Cells("DastavageDate").Value)
            End If
            If row.Cells("RMDate").Value IsNot Nothing AndAlso IsDate(row.Cells("RMDate").Value) Then
                dtpRMDate.Value = Convert.ToDateTime(row.Cells("RMDate").Value)
            End If
            If row.Cells("HODate").Value IsNot Nothing AndAlso IsDate(row.Cells("HODate").Value) Then
                dtpHODate.Value = Convert.ToDateTime(row.Cells("HODate").Value)
            End If

            ' ★★★ Load all expenses for this Lead ★★★
            LoadExpenses(selectedLeadMisID)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==============================================================
    ' LOAD EXPENSES (Client can see all expenses)
    '==============================================================
    Private Sub LoadExpenses(leadId As Integer)
        Try
            If leadId = 0 Then
                dgvExpense.DataSource = Nothing
                Return
            End If

            ssql = "SELECT ExpOfrID, ExpOfrType AS [Expense Type], " &
                   "ExpOfrValue AS [Amount], EntDt AS [Entry Date], EntBy AS [Entered By] " &
                   "FROM ExpOfferTypeValue WITH (NOLOCK) " &
                   "WHERE ExpOfrLeadID = " & leadId & " " &
                   "ORDER BY EntDt DESC"

            dgvExpense.DataSource = GetData(ssql)

            If dgvExpense.Columns.Contains("ExpOfrID") Then
                dgvExpense.Columns("ExpOfrID").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==============================================================
    ' SAVE
    '==============================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Not Required() Then Return

            If selectedLeadMisID = 0 Then
                ssql = "SELECT LeadMisID FROM LeadMIS " &
                       "WHERE CustName='" & txtCustName.Text.Trim().Replace("'", "''") & "' " &
                       "AND PropertyNo='" & txtPropertyNo.Text.Trim().Replace("'", "''") & "' " &
                       "AND PropertyAddress='" & txtPropertyAdd.Text.Trim().Replace("'", "''") & "'"
                dt = GetData(ssql)
                If dt.Rows.Count = 0 Then
                    MessageBox.Show("Customer + Property not found in Lead MIS.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                selectedLeadMisID = Convert.ToInt32(dt.Rows(0)("LeadMisID"))
            End If

            ' Check existing
            ssql = "SELECT LoginMisID FROM LoginMIS WHERE LeadID=" & selectedLeadMisID
            dt = GetData(ssql)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("Login record already exists. Please use UPDATE.", "Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ssql = "INSERT INTO LoginMIS (LeadID, LoginDate, ApplicationNo, LoanNo, CustName, MobileNo, Stage, BANK, " &
                   "LLPSNo, LoanAmount, CPA, BranchSoleID, Code, DastavageDate, RMDate, HODate, EntBy, EntDt) VALUES (" &
                   selectedLeadMisID & "," &
                   "'" & Format(dtpLeadDate.Value, "yyyy-MM-dd") & "'," &
                   "'" & txtAppNo.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtLoanNo.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtCustName.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtMobileNo.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtStage.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtBank.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtLLPs.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtLoanAmnt.Text.Trim().Replace("'", "''") & "'," &
                   "'" & CboCPA.Text.Trim().Replace("'", "''") & "'," &
                   "'" & txtBranchSole.Text.Trim().Replace("'", "''") & "'," &
                   "'" & CboCode.Text.Trim().Replace("'", "''") & "'," &
                   "'" & Format(dtpDasatavgeDate.Value, "yyyy-MM-dd") & "'," &
                   "'" & Format(dtpRMDate.Value, "yyyy-MM-dd") & "'," &
                   "'" & Format(dtpHODate.Value, "yyyy-MM-dd") & "'," &
                   "'" & SessionEmpId & "', GETDATE())"

            ExecuteQuery(ssql)
            MessageBox.Show("Login record saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnRefresh.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==============================================================
    ' UPDATE
    '==============================================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If selectedLoginMisID = 0 Then
                MessageBox.Show("Please select a record from the grid first.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Not Required() Then Return

            ssql = "UPDATE LoginMIS SET " &
                   "LoginDate='" & Format(dtpLeadDate.Value, "yyyy-MM-dd") & "'," &
                   "ApplicationNo='" & txtAppNo.Text.Trim().Replace("'", "''") & "'," &
                   "LoanNo='" & txtLoanNo.Text.Trim().Replace("'", "''") & "'," &
                   "CustName='" & txtCustName.Text.Trim().Replace("'", "''") & "'," &
                   "MobileNo='" & txtMobileNo.Text.Trim().Replace("'", "''") & "'," &
                   "Stage='" & txtStage.Text.Trim().Replace("'", "''") & "'," &
                   "BANK='" & txtBank.Text.Trim().Replace("'", "''") & "'," &
                   "LLPSNo='" & txtLLPs.Text.Trim().Replace("'", "''") & "'," &
                   "LoanAmount='" & txtLoanAmnt.Text.Trim().Replace("'", "''") & "'," &
                   "CPA='" & CboCPA.Text.Trim().Replace("'", "''") & "'," &
                   "BranchSoleID='" & txtBranchSole.Text.Trim().Replace("'", "''") & "'," &
                   "Code='" & CboCode.Text.Trim().Replace("'", "''") & "'," &
                   "DastavageDate='" & Format(dtpDasatavgeDate.Value, "yyyy-MM-dd") & "'," &
                   "RMDate='" & Format(dtpRMDate.Value, "yyyy-MM-dd") & "'," &
                   "HODate='" & Format(dtpHODate.Value, "yyyy-MM-dd") & "'," &
                   "ModBy='" & SessionEmpId & "', ModDt=GETDATE() " &
                   "WHERE LoginMisID=" & selectedLoginMisID

            ExecuteQuery(ssql)
            MessageBox.Show("Record updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnRefresh.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==============================================================
    ' DELETE
    '==============================================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If selectedLoginMisID = 0 Then
                MessageBox.Show("Please select a record from the grid first.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

            ssql = "DELETE FROM LoginMIS WHERE LoginMisID=" & selectedLoginMisID
            ExecuteQuery(ssql)

            MessageBox.Show("Record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selectedLoginMisID = 0
            selectedLeadMisID = 0
            txtGrossTotal.Text = "0.00"
            dgvExpense.DataSource = Nothing
            btnRefresh.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==============================================================
    ' ADD EXPENSE
    '==============================================================
    Private Sub btnExpOfr_Click(sender As Object, e As EventArgs) Handles btnExpOfr.Click
        Try
            If selectedLeadMisID = 0 Then
                MessageBox.Show("Please select a record from the grid first.", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtExpOfr.Text) Then
                MessageBox.Show("Please select Expense Type.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If String.IsNullOrWhiteSpace(txtExpOfrValue.Text) Then
                MessageBox.Show("Please enter Expense Value.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim expValue As Decimal
            If Not Decimal.TryParse(txtExpOfrValue.Text.Trim(), expValue) Then
                MessageBox.Show("Expense Value must be a valid number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ssql = "INSERT INTO ExpOfferTypeValue (ExpOfrType, ExpOfrValue, ExpOfrLeadID, EntBy, EntDt) VALUES (" &
                   "'" & txtExpOfr.Text.Trim().Replace("'", "''") & "'," &
                   "'" & expValue & "'," & selectedLeadMisID & "," &
                   "'" & SessionEmpId & "', GETDATE())"

            ExecuteQuery(ssql)
            MessageBox.Show("Expense added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtExpOfr.SelectedIndex = -1
            txtExpOfrValue.Clear()

            ' Refresh total + expense list
            btnRefresh.PerformClick()
            LoadExpenses(selectedLeadMisID)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==============================================================
    ' BANK CHANGE
    '==============================================================
    Private Sub txtBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBank.SelectedIndexChanged
        Dim isBOB As Boolean = (txtBank.Text.Trim().ToUpper() = "BOB")
        txtLLPs.Visible = isBOB
        txtBranchSole.Visible = isBOB
        lblLLPs.Visible = isBOB
        lblBranchSole.Visible = isBOB
    End Sub

    '==============================================================
    ' CLEAR FORM
    '==============================================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        selectedLoginMisID = 0
        selectedLeadMisID = 0
        txtCustName.Clear()
        txtMobileNo.Clear()
        txtAppNo.Clear()
        txtLoanNo.Clear()
        txtLoanAmnt.Clear()
        txtPropertyNo.Clear()
        txtPropertyAdd.Clear()
        txtOtherPropAdd.Clear()
        txtLLPs.Clear()
        txtBranchSole.Clear()
        txtStage.SelectedIndex = -1
        txtBank.SelectedIndex = -1
        CboCode.SelectedIndex = -1
        CboCPA.SelectedIndex = -1
        txtExpOfr.SelectedIndex = -1
        txtExpOfrValue.Clear()
        txtGrossTotal.Text = "0.00"
        dtpLeadDate.Value = DateTime.Today
        dtpDasatavgeDate.Value = DateTime.Today
        dtpRMDate.Value = DateTime.Today
        dtpHODate.Value = DateTime.Today
        dgvExpense.DataSource = Nothing
    End Sub

    '==============================================================
    ' VALIDATION + HELPER
    '==============================================================
    Private Function Required() As Boolean
        If Not RequiredField(dtpLeadDate, "Login Date") Then Return False
        If Not RequiredField(txtCustName, "Customer Name") Then Return False
        If Not RequiredField(txtMobileNo, "Mobile No") Then Return False
        If Not RequiredField(txtLoanAmnt, "Loan Amount") Then Return False
        If Not RequiredField(txtAppNo, "Application No") Then Return False
        If Not RequiredField(txtLoanNo, "Loan No") Then Return False
        If Not RequiredField(txtStage, "Stage") Then Return False
        If Not RequiredField(CboCode, "Code") Then Return False
        If Not RequiredField(CboCPA, "CPA") Then Return False
        If Not RequiredField(txtBank, "Bank") Then Return False

        If txtBank.Text.Trim().ToUpper() = "BOB" Then
            If Not RequiredField(txtLLPs, "LLPS No") Then Return False
            If Not RequiredField(txtBranchSole, "Branch Sole") Then Return False
        End If
        Return True
    End Function

    Private Function GetCellValue(row As DataGridViewRow, columnName As String) As String
        If row.Cells(columnName) Is Nothing OrElse row.Cells(columnName).Value Is Nothing OrElse IsDBNull(row.Cells(columnName).Value) Then
            Return ""
        End If
        Return row.Cells(columnName).Value.ToString()
    End Function

End Class