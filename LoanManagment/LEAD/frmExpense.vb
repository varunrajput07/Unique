Public Class frmExpense

    Private currentLeadMisID As Integer = 0
    Private currentExpenseID As Integer = 0
    Private currentLoanAmount As Decimal = 0

    '========================================================
    ' FORM LOAD
    '========================================================
    Private Sub frmExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadPaidByCombos()
        LoadModeCombos()
        LoadFiRcuPdCombo()
        LoadStatusCombos()

        ClearAllTabs()
        pnlInfo.Visible = False
        tabExpense.Enabled = False
        btnSave.Enabled = False

    End Sub


    '========================================================
    ' LOAD MASTER DATA INTO COMBOS
    '========================================================
    Private Sub LoadPaidByCombos()

        ssql = "SELECT ExpPaidByID, ExpPaidByName FROM ExpPaidByMst WHERE IsActive = 'Y' ORDER BY ExpPaidByName"
        dt = GetData(ssql)

        FillCombo(cmbPFPaidBy, dt, "ExpPaidByName")
        FillCombo(cmbRMPaidBy, dt, "ExpPaidByName")
        FillCombo(cmbFiRcuPdPaidBy, dt, "ExpPaidByName")
        FillCombo(cmbStaffPaidBy, dt, "ExpPaidByName")
        FillCombo(cmbBuilderPaidBy, dt, "ExpPaidByName")

    End Sub

    Private Sub LoadModeCombos()

        ssql = "SELECT ExpModeID, ExpMode FROM ExpModeMst WHERE IsActive = 'Y' ORDER BY ExpMode"
        dt = GetData(ssql)

        FillCombo(cmbPFMode, dt, "ExpMode")
        FillCombo(cmbRMMode, dt, "ExpMode")
        FillCombo(cmbFiRcuPdMode, dt, "ExpMode")
        FillCombo(cmbStaffMode, dt, "ExpMode")
        FillCombo(cmbBuilderMode, dt, "ExpMode")

    End Sub

    Private Sub LoadFiRcuPdCombo()

        ssql = "SELECT FiRcuPdID, FiRcuPd FROM FiRcuPdMst WHERE IsActive = 'Y' ORDER BY FiRcuPd"
        dt = GetData(ssql)

        FillCombo(cmbFiRcuPdType, dt, "FiRcuPd")

    End Sub

    Private Sub LoadStatusCombos()

        Dim statusList As String() = {"PENDING", "PAID"}

        cmbStaffStatus.Items.Clear()
        cmbStaffStatus.Items.AddRange(statusList)

        cmbBuilderStatus.Items.Clear()
        cmbBuilderStatus.Items.AddRange(statusList)

    End Sub


    '========================================================
    ' SEARCH CUSTOMER / LEAD
    '========================================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try

            If String.IsNullOrWhiteSpace(txtSearch.Text) Then

                MessageBox.Show(
                    "Please enter a name, mobile number or Lead ID to search.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Exit Sub

            End If

            Dim keyword As String = txtSearch.Text.Trim().Replace("'", "''")

            ssql = "SELECT LeadMisID, CustName, MobileNo, LoanAmount, Product " &
                   "FROM LeadMis " &
                   "WHERE IsDelete <> 'Y' " &
                   "AND (CustName LIKE '%" & keyword & "%' " &
                   "OR MobileNo LIKE '%" & keyword & "%' " &
                   "OR CAST(LeadMisID AS VARCHAR) = '" & keyword & "') " &
                   "ORDER BY LeadMisID DESC"

            dt = GetData(ssql)

            dgvCustomerSearch.DataSource = dt
            dgvCustomerSearch.Visible = dt.Rows.Count > 0

            If dt.Rows.Count = 0 Then

                MessageBox.Show(
                    "No matching customer/lead found.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Search Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================================
    ' SELECT A LEAD FROM SEARCH GRID
    '========================================================
    Private Sub dgvCustomerSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerSearch.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        Try

            Dim row As DataGridViewRow = dgvCustomerSearch.Rows(e.RowIndex)

            currentLeadMisID = Convert.ToInt32(row.Cells("LeadMisID").Value)
            currentLoanAmount = Convert.ToDecimal(row.Cells("LoanAmount").Value)

            lblInfoName.Text = "Customer: " & row.Cells("CustName").Value.ToString()
            lblInfoMobile.Text = "Mobile: " & row.Cells("MobileNo").Value.ToString()
            lblInfoLoan.Text = "Loan Amount: " & row.Cells("LoanAmount").Value.ToString()
            lblInfoProduct.Text = "Product: " & row.Cells("Product").Value.ToString()

            pnlInfo.Visible = True
            dgvCustomerSearch.Visible = False
            tabExpense.Enabled = True
            btnSave.Enabled = True

            LoadExpenseData()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error Loading Lead",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================================
    ' LOAD EXISTING EXPENSE RECORD (IF ANY) FOR SELECTED LEAD
    '========================================================
    Private Sub LoadExpenseData()

        ClearAllTabs()

        ssql = "SELECT * FROM ExpenseMst WHERE LeadMisID = " & currentLeadMisID & " AND IsDelete <> 'Y'"

        dt = GetData(ssql)

        If dt.Rows.Count = 0 Then

            currentExpenseID = 0

            '--------------------------------------------
            ' AUTO-CALCULATE STAFF / BUILDER SHARING
            ' (Loan Amount * 0.10%)
            '--------------------------------------------
            Dim autoAmount As Decimal = Math.Round(currentLoanAmount * 0.001D, 2)
            txtStaffAmount.Text = autoAmount.ToString("0.00")
            txtBuilderAmount.Text = autoAmount.ToString("0.00")

            Exit Sub

        End If

        Dim r As DataRow = dt.Rows(0)

        currentExpenseID = Convert.ToInt32(r("ExpenseID"))

        '------------------------------------------------
        ' PF / AGREEMENT / OTHER
        '------------------------------------------------
        txtPFAmount.Text = IfNullDec(r("PFAmount"))
        If Not IsDBNull(r("PFDate")) Then dtpPFDate.Value = Convert.ToDateTime(r("PFDate"))
        SetComboByID(cmbPFPaidBy, "ExpPaidByID", r("PFPaidByID"))
        SetComboByID(cmbPFMode, "ExpModeID", r("PFModeID"))

        '------------------------------------------------
        ' RM
        '------------------------------------------------
        txtRMAmount.Text = IfNullDec(r("RMAmount"))
        If Not IsDBNull(r("RMDate")) Then dtpRMDate.Value = Convert.ToDateTime(r("RMDate"))
        SetComboByID(cmbRMPaidBy, "ExpPaidByID", r("RMPaidByID"))
        SetComboByID(cmbRMMode, "ExpModeID", r("RMModeID"))

        '------------------------------------------------
        ' FI / RCU / PD
        '------------------------------------------------
        SetComboByID(cmbFiRcuPdType, "FiRcuPdID", r("FiRcuPdID"))
        txtFiRcuPdAmount.Text = IfNullDec(r("FiRcuPdAmount"))
        If Not IsDBNull(r("FiRcuPdDate")) Then dtpFiRcuPdDate.Value = Convert.ToDateTime(r("FiRcuPdDate"))
        SetComboByID(cmbFiRcuPdPaidBy, "ExpPaidByID", r("FiRcuPdPaidByID"))
        SetComboByID(cmbFiRcuPdMode, "ExpModeID", r("FiRcuPdModeID"))

        '------------------------------------------------
        ' STAFF SHARING
        '------------------------------------------------
        txtStaffAmount.Text = IfNullDec(r("StaffAmount"))
        If Not IsDBNull(r("StaffDate")) Then dtpStaffDate.Value = Convert.ToDateTime(r("StaffDate"))
        cmbStaffStatus.Text = IfNullStr(r("StaffStatus"))
        SetComboByID(cmbStaffPaidBy, "ExpPaidByID", r("StaffPaidByID"))
        SetComboByID(cmbStaffMode, "ExpModeID", r("StaffModeID"))

        '------------------------------------------------
        ' BUILDER / IDC SHARING
        '------------------------------------------------
        txtBuilderAmount.Text = IfNullDec(r("BuilderAmount"))
        If Not IsDBNull(r("BuilderDate")) Then dtpBuilderDate.Value = Convert.ToDateTime(r("BuilderDate"))
        cmbBuilderStatus.Text = IfNullStr(r("BuilderStatus"))
        SetComboByID(cmbBuilderPaidBy, "ExpPaidByID", r("BuilderPaidByID"))
        SetComboByID(cmbBuilderMode, "ExpModeID", r("BuilderModeID"))

    End Sub


    '========================================================
    ' HELPER: SAFE NULL READERS
    '========================================================
    Private Function IfNullDec(val As Object) As String
        If IsDBNull(val) Then Return ""
        Return Convert.ToDecimal(val).ToString("0.00")
    End Function

    Private Function IfNullStr(val As Object) As String
        If IsDBNull(val) Then Return ""
        Return val.ToString()
    End Function

    Private Sub SetComboByID(cbo As ComboBox, valueColumn As String, idValue As Object)

        If IsDBNull(idValue) Then
            cbo.SelectedIndex = -1
            Exit Sub
        End If

        cbo.SelectedValue = Convert.ToInt32(idValue)

    End Sub

    Private Function GetComboID(cbo As ComboBox) As Object

        If cbo.SelectedValue Is Nothing OrElse cbo.SelectedIndex = -1 Then
            Return DBNull.Value
        End If

        Return cbo.SelectedValue

    End Function


    '========================================================
    ' SAVE (INSERT OR UPDATE)
    '========================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If currentLeadMisID = 0 Then

            MessageBox.Show(
                "Please search and select a customer/lead first.",
                "Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

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

                '------------------------------------------------
                ' INSERT NEW RECORD
                '------------------------------------------------
                ssql = "INSERT INTO ExpenseMst " &
                       "(LeadMisID, PFAmount, PFDate, PFPaidByID, PFModeID, " &
                       "RMAmount, RMDate, RMPaidByID, RMModeID, " &
                       "FiRcuPdID, FiRcuPdAmount, FiRcuPdDate, FiRcuPdPaidByID, FiRcuPdModeID, " &
                       "StaffAmount, StaffDate, StaffStatus, StaffPaidByID, StaffModeID, " &
                       "BuilderAmount, BuilderDate, BuilderStatus, BuilderPaidByID, BuilderModeID, " &
                       "EntBy, EntDt, IsDelete) VALUES (" &
                       currentLeadMisID & ", " &
                       NumOrNull(txtPFAmount.Text) & ", " & DateOrNull(dtpPFDate) & ", " & ObjOrNull(pfPaidBy) & ", " & ObjOrNull(pfMode) & ", " &
                       NumOrNull(txtRMAmount.Text) & ", " & DateOrNull(dtpRMDate) & ", " & ObjOrNull(rmPaidBy) & ", " & ObjOrNull(rmMode) & ", " &
                       ObjOrNull(firRcuPdType) & ", " & NumOrNull(txtFiRcuPdAmount.Text) & ", " & DateOrNull(dtpFiRcuPdDate) & ", " & ObjOrNull(firPaidBy) & ", " & ObjOrNull(firMode) & ", " &
                       NumOrNull(txtStaffAmount.Text) & ", " & DateOrNull(dtpStaffDate) & ", " & StrOrNull(cmbStaffStatus.Text) & ", " & ObjOrNull(staffPaidBy) & ", " & ObjOrNull(staffMode) & ", " &
                       NumOrNull(txtBuilderAmount.Text) & ", " & DateOrNull(dtpBuilderDate) & ", " & StrOrNull(cmbBuilderStatus.Text) & ", " & ObjOrNull(builderPaidBy) & ", " & ObjOrNull(builderMode) & ", " &
                       Convert.ToInt32(SessionEmpId) & ", GETDATE(), 'N')"

                ExecuteQuery(ssql)

                MessageBox.Show("Expense record saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                '------------------------------------------------
                ' UPDATE EXISTING RECORD
                '------------------------------------------------
                ssql = "UPDATE ExpenseMst SET " &
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

            MessageBox.Show(
                ex.Message,
                "Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================================
    ' SQL VALUE HELPERS (NULL-SAFE)
    '========================================================
    Private Function NumOrNull(val As String) As String
        If String.IsNullOrWhiteSpace(val) Then Return "NULL"
        Dim d As Decimal
        If Decimal.TryParse(val, d) Then Return d.ToString(Globalization.CultureInfo.InvariantCulture)
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
    ' CLEAR / NEW SEARCH
    '========================================================
    Private Sub btnNewSearch_Click(sender As Object, e As EventArgs) Handles btnNewSearch.Click

        currentLeadMisID = 0
        currentExpenseID = 0
        currentLoanAmount = 0

        txtSearch.Clear()
        dgvCustomerSearch.DataSource = Nothing
        dgvCustomerSearch.Visible = False
        pnlInfo.Visible = False
        tabExpense.Enabled = False
        btnSave.Enabled = False

        ClearAllTabs()

        txtSearch.Focus()

    End Sub

    Private Sub ClearAllTabs()

        txtPFAmount.Clear() : dtpPFDate.Value = DateTime.Today : cmbPFPaidBy.SelectedIndex = -1 : cmbPFMode.SelectedIndex = -1
        txtRMAmount.Clear() : dtpRMDate.Value = DateTime.Today : cmbRMPaidBy.SelectedIndex = -1 : cmbRMMode.SelectedIndex = -1
        cmbFiRcuPdType.SelectedIndex = -1 : txtFiRcuPdAmount.Clear() : dtpFiRcuPdDate.Value = DateTime.Today
        cmbFiRcuPdPaidBy.SelectedIndex = -1 : cmbFiRcuPdMode.SelectedIndex = -1
        txtStaffAmount.Clear() : dtpStaffDate.Value = DateTime.Today : cmbStaffStatus.SelectedIndex = -1
        cmbStaffPaidBy.SelectedIndex = -1 : cmbStaffMode.SelectedIndex = -1
        txtBuilderAmount.Clear() : dtpBuilderDate.Value = DateTime.Today : cmbBuilderStatus.SelectedIndex = -1
        cmbBuilderPaidBy.SelectedIndex = -1 : cmbBuilderMode.SelectedIndex = -1

    End Sub

End Class