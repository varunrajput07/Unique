Public Class frmExpense

    Private currentLeadMisID As Integer = 0
    Private currentLoginMisID As Integer = 0
    Private currentExpenseID As Integer = 0
    Private currentLoanAmount As Decimal = 0

    Private Sub frmExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaidByCombos()
        LoadModeCombos()
        LoadFiRcuPdCombo()
        LoadStatusCombos()
        ClearAllTabs()

        grpCustInfo.Visible = False
        tabExpense.Enabled = False
        btnSave.Enabled = False
        dgvCustomerSearch.Visible = False
        pnlSearch.Height = 50
    End Sub

    '========================================================
    ' LOAD MASTERS
    '========================================================
    Private Sub LoadPaidByCombos()
        ssql = "SELECT ExpPaidByID, ExpPaidByName FROM ExpPaidByMst WHERE IsActive = 'Y' ORDER BY ExpPaidByName"
        dt = GetData(ssql)
        FillComboWithID(cmbPFPaidBy, dt, "ExpPaidByName", "ExpPaidByID")
        FillComboWithID(cmbRMPaidBy, dt, "ExpPaidByName", "ExpPaidByID")
        FillComboWithID(cmbFiRcuPdPaidBy, dt, "ExpPaidByName", "ExpPaidByID")
        FillComboWithID(cmbStaffPaidBy, dt, "ExpPaidByName", "ExpPaidByID")
        FillComboWithID(cmbBuilderPaidBy, dt, "ExpPaidByName", "ExpPaidByID")
    End Sub

    Private Sub LoadModeCombos()
        ssql = "SELECT ExpModeID, ExpMode FROM ExpModeMst WHERE IsActive = 'Y' ORDER BY ExpMode"
        dt = GetData(ssql)
        FillComboWithID(cmbPFMode, dt, "ExpMode", "ExpModeID")
        FillComboWithID(cmbRMMode, dt, "ExpMode", "ExpModeID")
        FillComboWithID(cmbFiRcuPdMode, dt, "ExpMode", "ExpModeID")
        FillComboWithID(cmbStaffMode, dt, "ExpMode", "ExpModeID")
        FillComboWithID(cmbBuilderMode, dt, "ExpMode", "ExpModeID")
    End Sub

    Private Sub LoadFiRcuPdCombo()
        ssql = "SELECT FiRcuPdID, FiRcuPd FROM FiRcuPdMst WHERE IsActive = 'Y' ORDER BY FiRcuPd"
        dt = GetData(ssql)
        FillComboWithID(cmbFiRcuPdType, dt, "FiRcuPd", "FiRcuPdID")
    End Sub

    Private Sub LoadStatusCombos()
        Dim statusList As String() = {"PENDING", "PAID"}
        cmbStaffStatus.Items.Clear()
        cmbStaffStatus.Items.AddRange(statusList)
        cmbBuilderStatus.Items.Clear()
        cmbBuilderStatus.Items.AddRange(statusList)
    End Sub

    Private Sub FillComboWithID(cbo As ComboBox, data As DataTable, displayCol As String, valueCol As String)
        cbo.DataSource = Nothing
        cbo.DisplayMember = displayCol
        cbo.ValueMember = valueCol
        cbo.DataSource = data.Copy()
        cbo.SelectedIndex = -1
    End Sub

    '========================================================
    ' SEARCH – Only Login customers
    '========================================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            'If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            '    MessageBox.Show("Please enter Customer Name, Mobile No, Lead ID, Login ID, Application No or Loan No.",
            '                    "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            Dim keyword As String = txtSearch.Text.Trim().Replace("'", "''")

            ssql = "SELECT " &
                   "ld.LeadMisID, " &
                   "lgn.LoginMisID, " &
                   "ld.CustName, " &
                   "ld.MobileNo, " &
                   "lgn.LoanAmount, " &
                   "ld.Product, " &
                   "lgn.Stage AS LoginStage, " &
                   "lgn.ApplicationNo, " &
                   "lgn.LoanNo " &
                   "FROM LeadMis ld WITH (NOLOCK) " &
                   "INNER JOIN LoginMIS lgn WITH (NOLOCK) ON ld.LeadMisID = lgn.LeadID " &
                   "WHERE ld.IsDelete <> 'Y' " &
                   "AND (ld.CustName LIKE '%" & keyword & "%' " &
                   "OR ld.MobileNo LIKE '%" & keyword & "%' " &
                   "OR CAST(ld.LeadMisID AS VARCHAR) = '" & keyword & "' " &
                   "OR CAST(lgn.LoginMisID AS VARCHAR) = '" & keyword & "' " &
                   "OR ISNULL(lgn.ApplicationNo,'') LIKE '%" & keyword & "%' " &
                   "OR ISNULL(lgn.LoanNo,'') LIKE '%" & keyword & "%') " &
                   "ORDER BY lgn.LoginDate DESC, ld.LeadMisID DESC"

            dt = GetData(ssql)
            dgvCustomerSearch.DataSource = dt

            If dt.Rows.Count > 0 Then
                pnlSearch.Height = 200
                dgvCustomerSearch.Visible = True
                dgvCustomerSearch.BringToFront()

                SetGridHeader("LeadMisID", "Lead ID")
                SetGridHeader("LoginMisID", "Login ID")
                SetGridHeader("CustName", "Customer Name")
                SetGridHeader("MobileNo", "Mobile No")
                SetGridHeader("LoanAmount", "Loan Amount")
                SetGridHeader("Product", "Product")
                SetGridHeader("LoginStage", "Login Stage")
                SetGridHeader("ApplicationNo", "Application No")
                SetGridHeader("LoanNo", "Loan No")
            Else
                pnlSearch.Height = 50
                dgvCustomerSearch.Visible = False
                MessageBox.Show("No Login customer found." & vbCrLf &
                                "Only customers who have Login stage are shown.",
                                "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetGridHeader(colName As String, headerText As String)
        If dgvCustomerSearch.Columns.Contains(colName) Then
            dgvCustomerSearch.Columns(colName).HeaderText = headerText
        End If
    End Sub

    '========================================================
    ' SELECT CUSTOMER (Double Click)
    '========================================================
    Private Sub dgvCustomerSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerSearch.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        Try
            Dim row As DataGridViewRow = dgvCustomerSearch.Rows(e.RowIndex)

            currentLeadMisID = Convert.ToInt32(row.Cells("LeadMisID").Value)
            currentLoginMisID = Convert.ToInt32(row.Cells("LoginMisID").Value)
            currentLoanAmount = Convert.ToDecimal(row.Cells("LoanAmount").Value)

            ' Fill customer info group (new design)
            txtInfoName.Text = row.Cells("CustName").Value.ToString()
            txtInfoMobile.Text = row.Cells("MobileNo").Value.ToString()
            txtInfoLoan.Text = Convert.ToDecimal(row.Cells("LoanAmount").Value).ToString("N2")
            txtInfoProduct.Text = If(row.Cells("Product").Value IsNot Nothing, row.Cells("Product").Value.ToString(), "")
            txtInfoAppNo.Text = If(row.Cells("ApplicationNo").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("ApplicationNo").Value),
                                   row.Cells("ApplicationNo").Value.ToString(), "")
            txtInfoLoanNo.Text = If(row.Cells("LoanNo").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("LoanNo").Value),
                                    row.Cells("LoanNo").Value.ToString(), "")

            ' Hide search grid, show customer info
            pnlSearch.Height = 50
            dgvCustomerSearch.Visible = False
            grpCustInfo.Visible = True
            tabExpense.Enabled = True
            btnSave.Enabled = True

            LoadExpenseData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' LOAD EXPENSE DATA
    '========================================================
    Private Sub LoadExpenseData()
        ClearAllTabs()

        ssql = "SELECT * FROM Expense " &
               "WHERE LeadMisID = " & currentLeadMisID & " " &
               "AND LoginMisID = " & currentLoginMisID & " " &
               "AND IsDelete <> 'Y'"
        dt = GetData(ssql)

        If dt.Rows.Count = 0 Then
            currentExpenseID = 0
            ' Auto 0.1% of loan for Staff & Builder (new record)
            Dim autoAmount As Decimal = Math.Round(currentLoanAmount * 0.001D, 2)
            txtStaffAmount.Text = autoAmount.ToString("0.00")
            txtBuilderAmount.Text = autoAmount.ToString("0.00")
            Exit Sub
        End If

        Dim r As DataRow = dt.Rows(0)
        currentExpenseID = Convert.ToInt32(r("ExpenseID"))

        ' PF
        txtPFAmount.Text = IfNullDec(r("PFAmount"))
        If Not IsDBNull(r("PFDate")) Then dtpPFDate.Value = Convert.ToDateTime(r("PFDate"))
        SetComboByID(cmbPFPaidBy, r("PFPaidByID"))
        SetComboByID(cmbPFMode, r("PFModeID"))

        ' RM
        txtRMAmount.Text = IfNullDec(r("RMAmount"))
        If Not IsDBNull(r("RMDate")) Then dtpRMDate.Value = Convert.ToDateTime(r("RMDate"))
        SetComboByID(cmbRMPaidBy, r("RMPaidByID"))
        SetComboByID(cmbRMMode, r("RMModeID"))

        ' FI / RCU / PD
        SetComboByID(cmbFiRcuPdType, r("FiRcuPdID"))
        txtFiRcuPdAmount.Text = IfNullDec(r("FiRcuPdAmount"))
        If Not IsDBNull(r("FiRcuPdDate")) Then dtpFiRcuPdDate.Value = Convert.ToDateTime(r("FiRcuPdDate"))
        SetComboByID(cmbFiRcuPdPaidBy, r("FiRcuPdPaidByID"))
        SetComboByID(cmbFiRcuPdMode, r("FiRcuPdModeID"))

        ' Staff
        txtStaffAmount.Text = IfNullDec(r("StaffAmount"))
        If Not IsDBNull(r("StaffDate")) Then dtpStaffDate.Value = Convert.ToDateTime(r("StaffDate"))
        cmbStaffStatus.Text = IfNullStr(r("StaffStatus"))
        SetComboByID(cmbStaffPaidBy, r("StaffPaidByID"))
        SetComboByID(cmbStaffMode, r("StaffModeID"))

        ' Builder
        txtBuilderAmount.Text = IfNullDec(r("BuilderAmount"))
        If Not IsDBNull(r("BuilderDate")) Then dtpBuilderDate.Value = Convert.ToDateTime(r("BuilderDate"))
        cmbBuilderStatus.Text = IfNullStr(r("BuilderStatus"))
        SetComboByID(cmbBuilderPaidBy, r("BuilderPaidByID"))
        SetComboByID(cmbBuilderMode, r("BuilderModeID"))
    End Sub

    '========================================================
    ' HELPERS
    '========================================================
    Private Function IfNullDec(val As Object) As String
        If IsDBNull(val) Then Return ""
        Return Convert.ToDecimal(val).ToString("0.00")
    End Function

    Private Function IfNullStr(val As Object) As String
        If IsDBNull(val) Then Return ""
        Return val.ToString()
    End Function

    Private Sub SetComboByID(cbo As ComboBox, idValue As Object)
        If IsDBNull(idValue) OrElse idValue Is Nothing Then
            cbo.SelectedIndex = -1
            Exit Sub
        End If
        Try
            cbo.SelectedValue = Convert.ToInt32(idValue)
        Catch
            cbo.SelectedIndex = -1
        End Try
    End Sub

    Private Function GetComboID(cbo As ComboBox) As Object
        If cbo.SelectedValue Is Nothing OrElse cbo.SelectedIndex < 0 Then
            Return DBNull.Value
        End If
        Return cbo.SelectedValue
    End Function

    '========================================================
    ' SAVE
    '========================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If currentLeadMisID = 0 OrElse currentLoginMisID = 0 Then
            MessageBox.Show("Please search and select a Login customer first.", "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim pfPaidBy As Object = GetComboID(cmbPFPaidBy)
            Dim pfMode As Object = GetComboID(cmbPFMode)
            Dim rmPaidBy As Object = GetComboID(cmbRMPaidBy)
            Dim rmMode As Object = GetComboID(cmbRMMode)
            Dim firRcuPdType As Object = GetComboID(cmbFiRcuPdType)
            Dim firPaidBy As Object = GetComboID(cmbFiRcuPdPaidBy)
            Dim firMode As Object = GetComboID(cmbFiRcuPdMode)
            Dim staffPaidBy As Object = GetComboID(cmbStaffPaidBy)
            Dim staffMode As Object = GetComboID(cmbStaffMode)
            Dim builderPaidBy As Object = GetComboID(cmbBuilderPaidBy)
            Dim builderMode As Object = GetComboID(cmbBuilderMode)

            If currentExpenseID = 0 Then
                ssql = "INSERT INTO Expense " &
                       "(LeadMisID, LoginMisID, " &
                       "PFAmount, PFDate, PFPaidByID, PFModeID, " &
                       "RMAmount, RMDate, RMPaidByID, RMModeID, " &
                       "FiRcuPdID, FiRcuPdAmount, FiRcuPdDate, FiRcuPdPaidByID, FiRcuPdModeID, " &
                       "StaffAmount, StaffDate, StaffStatus, StaffPaidByID, StaffModeID, " &
                       "BuilderAmount, BuilderDate, BuilderStatus, BuilderPaidByID, BuilderModeID, " &
                       "EntBy, EntDt, IsDelete) VALUES (" &
                       currentLeadMisID & ", " & currentLoginMisID & ", " &
                       NumOrNull(txtPFAmount.Text) & ", " & DateOrNull(dtpPFDate) & ", " & ObjOrNull(pfPaidBy) & ", " & ObjOrNull(pfMode) & ", " &
                       NumOrNull(txtRMAmount.Text) & ", " & DateOrNull(dtpRMDate) & ", " & ObjOrNull(rmPaidBy) & ", " & ObjOrNull(rmMode) & ", " &
                       ObjOrNull(firRcuPdType) & ", " & NumOrNull(txtFiRcuPdAmount.Text) & ", " & DateOrNull(dtpFiRcuPdDate) & ", " & ObjOrNull(firPaidBy) & ", " & ObjOrNull(firMode) & ", " &
                       NumOrNull(txtStaffAmount.Text) & ", " & DateOrNull(dtpStaffDate) & ", " & StrOrNull(cmbStaffStatus.Text) & ", " & ObjOrNull(staffPaidBy) & ", " & ObjOrNull(staffMode) & ", " &
                       NumOrNull(txtBuilderAmount.Text) & ", " & DateOrNull(dtpBuilderDate) & ", " & StrOrNull(cmbBuilderStatus.Text) & ", " & ObjOrNull(builderPaidBy) & ", " & ObjOrNull(builderMode) & ", " &
                       Convert.ToInt32(SessionEmpId) & ", GETDATE(), 'N')"
                ExecuteQuery(ssql)
                MessageBox.Show("Expense record saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ssql = "UPDATE Expense SET " &
                       "LoginMisID = " & currentLoginMisID & ", " &
                       "PFAmount = " & NumOrNull(txtPFAmount.Text) & ", " &
                       "PFDate = " & DateOrNull(dtpPFDate) & ", " &
                       "PFPaidByID = " & ObjOrNull(pfPaidBy) & ", " &
                       "PFModeID = " & ObjOrNull(pfMode) & ", " &
                       "RMAmount = " & NumOrNull(txtRMAmount.Text) & ", " &
                       "RMDate = " & DateOrNull(dtpRMDate) & ", " &
                       "RMPaidByID = " & ObjOrNull(rmPaidBy) & ", " &
                       "RMModeID = " & ObjOrNull(rmMode) & ", " &
                       "FiRcuPdID = " & ObjOrNull(firRcuPdType) & ", " &
                       "FiRcuPdAmount = " & NumOrNull(txtFiRcuPdAmount.Text) & ", " &
                       "FiRcuPdDate = " & DateOrNull(dtpFiRcuPdDate) & ", " &
                       "FiRcuPdPaidByID = " & ObjOrNull(firPaidBy) & ", " &
                       "FiRcuPdModeID = " & ObjOrNull(firMode) & ", " &
                       "StaffAmount = " & NumOrNull(txtStaffAmount.Text) & ", " &
                       "StaffDate = " & DateOrNull(dtpStaffDate) & ", " &
                       "StaffStatus = " & StrOrNull(cmbStaffStatus.Text) & ", " &
                       "StaffPaidByID = " & ObjOrNull(staffPaidBy) & ", " &
                       "StaffModeID = " & ObjOrNull(staffMode) & ", " &
                       "BuilderAmount = " & NumOrNull(txtBuilderAmount.Text) & ", " &
                       "BuilderDate = " & DateOrNull(dtpBuilderDate) & ", " &
                       "BuilderStatus = " & StrOrNull(cmbBuilderStatus.Text) & ", " &
                       "BuilderPaidByID = " & ObjOrNull(builderPaidBy) & ", " &
                       "BuilderModeID = " & ObjOrNull(builderMode) & ", " &
                       "ModBy = " & Convert.ToInt32(SessionEmpId) & ", " &
                       "ModDt = GETDATE() " &
                       "WHERE ExpenseID = " & currentExpenseID
                ExecuteQuery(ssql)
                MessageBox.Show("Expense record updated successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            LoadExpenseData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' SQL HELPERS
    '========================================================
    Private Function NumOrNull(val As String) As String
        If String.IsNullOrWhiteSpace(val) Then Return "NULL"
        Dim d As Decimal
        If Decimal.TryParse(val, d) Then
            Return d.ToString(Globalization.CultureInfo.InvariantCulture)
        End If
        Return "NULL"
    End Function

    Private Function DateOrNull(dtp As DateTimePicker) As String
        Return "'" & dtp.Value.ToString("yyyy-MM-dd") & "'"
    End Function

    Private Function StrOrNull(val As String) As String
        If String.IsNullOrWhiteSpace(val) Then Return "NULL"
        Return "'" & val.Replace("'", "''") & "'"
    End Function

    Private Function ObjOrNull(val As Object) As String
        If val Is Nothing OrElse IsDBNull(val) Then Return "NULL"
        Return Convert.ToInt32(val).ToString()
    End Function

    '========================================================
    ' NEW SEARCH / CLEAR
    '========================================================
    Private Sub btnNewSearch_Click(sender As Object, e As EventArgs) Handles btnNewSearch.Click
        currentLeadMisID = 0
        currentLoginMisID = 0
        currentExpenseID = 0
        currentLoanAmount = 0

        txtSearch.Clear()
        dgvCustomerSearch.DataSource = Nothing
        dgvCustomerSearch.Visible = False
        pnlSearch.Height = 50

        grpCustInfo.Visible = False
        txtInfoName.Clear()
        txtInfoMobile.Clear()
        txtInfoLoan.Clear()
        txtInfoProduct.Clear()
        txtInfoAppNo.Clear()
        txtInfoLoanNo.Clear()

        tabExpense.Enabled = False
        btnSave.Enabled = False
        ClearAllTabs()
        txtSearch.Focus()
    End Sub

    Private Sub ClearAllTabs()
        txtPFAmount.Clear()
        dtpPFDate.Value = DateTime.Today
        cmbPFPaidBy.SelectedIndex = -1
        cmbPFMode.SelectedIndex = -1

        txtRMAmount.Clear()
        dtpRMDate.Value = DateTime.Today
        cmbRMPaidBy.SelectedIndex = -1
        cmbRMMode.SelectedIndex = -1

        cmbFiRcuPdType.SelectedIndex = -1
        txtFiRcuPdAmount.Clear()
        dtpFiRcuPdDate.Value = DateTime.Today
        cmbFiRcuPdPaidBy.SelectedIndex = -1
        cmbFiRcuPdMode.SelectedIndex = -1

        txtStaffAmount.Clear()
        dtpStaffDate.Value = DateTime.Today
        cmbStaffStatus.SelectedIndex = -1
        cmbStaffPaidBy.SelectedIndex = -1
        cmbStaffMode.SelectedIndex = -1

        txtBuilderAmount.Clear()
        dtpBuilderDate.Value = DateTime.Today
        cmbBuilderStatus.SelectedIndex = -1
        cmbBuilderPaidBy.SelectedIndex = -1
        cmbBuilderMode.SelectedIndex = -1
    End Sub

End Class