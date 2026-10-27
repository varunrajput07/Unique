Public Class frmOfficeExpense

    Private selectedOfficeExpenseID As Integer = 0
    Private selectedStaffExpenseID As Integer = 0

    '========================================================
    ' FORM LOAD
    '========================================================
    Private Sub frmOfficeExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized          ' ← Full Screen / Maximized

        dtpOfficeMonth.Value = DateTime.Today
        dtpStaffMonth.Value = DateTime.Today

        LoadOfficeCategoryCombo()
        LoadPaidByCombo()               ' Same list for both Staff + Office
        LoadStaffNameCombo()

        ClearOfficeForm()
        ClearStaffForm()
        LoadOfficeGrid()
        LoadStaffGrid()
    End Sub

    '========================================================
    ' LOAD PAID BY (Common for Staff + Office)
    '========================================================
    Private Sub LoadPaidByCombo()
        Try
            ' Load from ExpPaidByMst and exclude any record that contains "Customer"
            ssql = "SELECT ExpPaidByID, ExpPaidByName " &
               "FROM ExpPaidByMst " &
               "WHERE IsActive = 'Y' " &
               "AND ExpPaidByName NOT LIKE '%Customer%' " &
               "ORDER BY ExpPaidByName"

            dt = GetData(ssql)

            ' Staff Paid By
            cmbStaffPaidBy.DataSource = Nothing
            cmbStaffPaidBy.DisplayMember = "ExpPaidByName"
            cmbStaffPaidBy.ValueMember = "ExpPaidByID"
            cmbStaffPaidBy.DataSource = dt.Copy()
            cmbStaffPaidBy.SelectedIndex = -1

            ' Office Paid By (same list, without Customer)
            cmbOfficePaidBy.DataSource = Nothing
            cmbOfficePaidBy.DisplayMember = "ExpPaidByName"
            cmbOfficePaidBy.ValueMember = "ExpPaidByID"
            cmbOfficePaidBy.DataSource = dt.Copy()
            cmbOfficePaidBy.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Paid By List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' LOAD DROPDOWNS
    '========================================================
    Private Sub LoadOfficeCategoryCombo()
        Try
            ' Option 1: Hard-coded (fast & matches your image exactly)
            cmbOfficeCategory.Items.Clear()
            cmbOfficeCategory.Items.AddRange(New String() {
                "RENT", "MAINTAINACE", "ELE.BILL", "WATER", "TEA",
                "MOBILE BILL", "STATIONARY", "SALARY", "MASI", "FLOWER", "OTHER"
            })
            cmbOfficeCategory.DropDownStyle = ComboBoxStyle.DropDownList

            ' Option 2: From table (recommended for future changes)
            'ssql = "SELECT CategoryName FROM OfficeExpenseCategoryMst WHERE IsActive = 'Y' ORDER BY CategoryName"
            'dt = GetData(ssql)
            'FillCombo(cmbOfficeCategory, dt, "CategoryName")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Categories", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadActiveEmployeeCombo()
        Try
            ' Display all ACTIVE employees (IsActive = 'Y')
            ssql = "SELECT EmpId, FullName FROM RegistrationMaster " &
                   "WHERE IsActive = 'Y' ORDER BY FullName"
            dt = GetData(ssql)

            cmbOfficePaidBy.DataSource = Nothing
            cmbOfficePaidBy.DisplayMember = "FullName"
            cmbOfficePaidBy.ValueMember = "EmpId"
            cmbOfficePaidBy.DataSource = dt
            cmbOfficePaidBy.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Employees", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadStaffNameCombo()
        Try
            ssql = "SELECT FullName FROM RegistrationMaster WHERE IsActive = 'Y' ORDER BY FullName"
            dt = GetData(ssql)
            FillCombo(cmbStaffName, dt, "FullName")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Staff List", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===========================  OFFICE EXPENSE  ======================

    Private Sub LoadOfficeGrid()
        Try
            ssql = "SELECT o.OfficeExpenseID, " &
               "o.ExpenseCategory AS [Category], " &
               "FORMAT(o.ExpenseMonth, 'MMM-yy') AS [Month], " &
               "o.Amount, " &
               "ISNULL(p.ExpPaidByName, '') AS [PaidBy], " &
               "o.Remarks " &
               "FROM OfficeExpenseMst o " &
               "LEFT JOIN ExpPaidByMst p ON o.PaidByID = p.ExpPaidByID " &
               "WHERE o.IsDelete <> 'Y' " &
               "ORDER BY o.ExpenseMonth DESC, o.ExpenseCategory"

            dt = GetData(ssql)
            dgvOfficeExpense.DataSource = dt

            If dgvOfficeExpense.Columns.Contains("OfficeExpenseID") Then
                dgvOfficeExpense.Columns("OfficeExpenseID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Office Expense", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' OFFICE SAVE
    '========================================================
    Private Sub btnOfficeSave_Click(sender As Object, e As EventArgs) Handles btnOfficeSave.Click
        If Not ValidateOfficeForm() Then Exit Sub

        Try
            Dim monthValue As Date = New Date(dtpOfficeMonth.Value.Year, dtpOfficeMonth.Value.Month, 1)
            Dim paidByID As Object = If(cmbOfficePaidBy.SelectedValue Is Nothing, DBNull.Value, cmbOfficePaidBy.SelectedValue)

            ssql = "INSERT INTO OfficeExpenseMst " &
               "(ExpenseCategory, ExpenseMonth, Amount, Remarks, PaidByID, EntBy, EntDt, IsDelete) VALUES (" &
               "'" & cmbOfficeCategory.Text.Trim().Replace("'", "''") & "', " &
               "'" & monthValue.ToString("yyyy-MM-dd") & "', " &
               Convert.ToDecimal(txtOfficeAmount.Text) & ", " &
               "'" & txtOfficeRemarks.Text.Trim().Replace("'", "''") & "', " &
               If(IsDBNull(paidByID), "NULL", Convert.ToInt32(paidByID).ToString()) & ", " &
               Convert.ToInt32(SessionEmpId) & ", GETDATE(), 'N')"

            ExecuteQuery(ssql)
            MessageBox.Show("Office expense saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearOfficeForm()
            LoadOfficeGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' OFFICE UPDATE
    '========================================================
    Private Sub btnOfficeUpdate_Click(sender As Object, e As EventArgs) Handles btnOfficeUpdate.Click
        If selectedOfficeExpenseID = 0 Then
            MessageBox.Show("Please select a record from the grid to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not ValidateOfficeForm() Then Exit Sub

        Try
            Dim monthValue As Date = New Date(dtpOfficeMonth.Value.Year, dtpOfficeMonth.Value.Month, 1)
            Dim paidByID As Object = If(cmbOfficePaidBy.SelectedValue Is Nothing, DBNull.Value, cmbOfficePaidBy.SelectedValue)

            ssql = "UPDATE OfficeExpenseMst SET " &
               "ExpenseCategory = '" & cmbOfficeCategory.Text.Trim().Replace("'", "''") & "', " &
               "ExpenseMonth = '" & monthValue.ToString("yyyy-MM-dd") & "', " &
               "Amount = " & Convert.ToDecimal(txtOfficeAmount.Text) & ", " &
               "Remarks = '" & txtOfficeRemarks.Text.Trim().Replace("'", "''") & "', " &
               "PaidByID = " & If(IsDBNull(paidByID), "NULL", Convert.ToInt32(paidByID).ToString()) & ", " &
               "ModBy = " & Convert.ToInt32(SessionEmpId) & ", " &
               "ModDt = GETDATE() " &
               "WHERE OfficeExpenseID = " & selectedOfficeExpenseID

            ExecuteQuery(ssql)
            MessageBox.Show("Office expense updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearOfficeForm()
            LoadOfficeGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvOfficeExpense_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOfficeExpense.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Try
            Dim row As DataGridViewRow = dgvOfficeExpense.Rows(e.RowIndex)
            selectedOfficeExpenseID = Convert.ToInt32(row.Cells("OfficeExpenseID").Value)

            cmbOfficeCategory.Text = row.Cells("Category").Value.ToString()

            Dim monthStr As String = row.Cells("Month").Value.ToString()
            dtpOfficeMonth.Value = DateTime.ParseExact(monthStr, "MMM-yy", Globalization.CultureInfo.InvariantCulture)

            txtOfficeAmount.Text = row.Cells("Amount").Value.ToString()
            txtOfficeRemarks.Text = If(IsDBNull(row.Cells("Remarks").Value), "", row.Cells("Remarks").Value.ToString())

            ' Set Paid By employee
            Dim paidByName As String = If(IsDBNull(row.Cells("PaidBy").Value), "", row.Cells("PaidBy").Value.ToString())
            If paidByName <> "" Then
                cmbOfficePaidBy.Text = paidByName
            Else
                cmbOfficePaidBy.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Selecting Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnOfficeDelete_Click(sender As Object, e As EventArgs) Handles btnOfficeDelete.Click
        If selectedOfficeExpenseID = 0 Then
            MessageBox.Show("Please select a record from the grid to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this record?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm <> DialogResult.Yes Then Exit Sub

        Try
            ssql = "UPDATE OfficeExpenseMst SET IsDelete = 'Y', " &
                   "ModBy = " & Convert.ToInt32(SessionEmpId) & ", " &
                   "ModDt = GETDATE() " &
                   "WHERE OfficeExpenseID = " & selectedOfficeExpenseID
            ExecuteQuery(ssql)

            MessageBox.Show("Office expense deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearOfficeForm()
            LoadOfficeGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOfficeClear_Click(sender As Object, e As EventArgs) Handles btnOfficeClear.Click
        ClearOfficeForm()
    End Sub

    Private Sub ClearOfficeForm()
        selectedOfficeExpenseID = 0
        cmbOfficeCategory.SelectedIndex = -1
        dtpOfficeMonth.Value = DateTime.Today
        txtOfficeAmount.Clear()
        txtOfficeRemarks.Clear()
        cmbOfficePaidBy.SelectedIndex = -1
        dgvOfficeExpense.ClearSelection()
        cmbOfficeCategory.Focus()
    End Sub

    Private Function ValidateOfficeForm() As Boolean
        If String.IsNullOrWhiteSpace(cmbOfficeCategory.Text) Then
            MessageBox.Show("Please select a category.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbOfficeCategory.Focus()
            Return False
        End If

        Dim amt As Decimal
        If Not Decimal.TryParse(txtOfficeAmount.Text, amt) OrElse amt <= 0 Then
            MessageBox.Show("Please enter a valid amount greater than zero.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtOfficeAmount.Focus()
            Return False
        End If

        ' Optional: force selection of Paid By employee
        'If cmbOfficePaidBy.SelectedValue Is Nothing Then
        '    MessageBox.Show("Please select the employee who paid.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    cmbOfficePaidBy.Focus()
        '    Return False
        'End If

        Return True
    End Function

    '====================================================================
    ' ===========================  STAFF EXPENSE  =======================
    '====================================================================
    ' (Your existing Staff Expense code remains almost the same)
    ' I only changed StaffName source to use FullName + IsActive = 'Y'

    Private Sub LoadStaffGrid()
        Try
            ssql = "SELECT s.StaffExpenseID, s.StaffName, " &
                   "FORMAT(s.SalaryMonth, 'MMM-yy') AS [Month], " &
                   "s.SalaryAmount, s.PaidDate, s.PaidStatus, " &
                   "p.ExpPaidByName AS [PaidBy], s.Remarks " &
                   "FROM StaffExpenseMst s " &
                   "LEFT JOIN ExpPaidByMst p ON s.PaidByID = p.ExpPaidByID " &
                   "WHERE s.IsDelete <> 'Y' " &
                   "ORDER BY s.SalaryMonth DESC, s.StaffName"
            dt = GetData(ssql)
            dgvStaffExpense.DataSource = dt

            If dgvStaffExpense.Columns.Contains("StaffExpenseID") Then
                dgvStaffExpense.Columns("StaffExpenseID").Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Staff Expense", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStaffSave_Click(sender As Object, e As EventArgs) Handles btnStaffSave.Click
        If Not ValidateStaffForm() Then Exit Sub
        Try
            Dim monthValue As Date = New Date(dtpStaffMonth.Value.Year, dtpStaffMonth.Value.Month, 1)
            Dim paidByID As Object = If(cmbStaffPaidBy.SelectedValue Is Nothing, DBNull.Value, cmbStaffPaidBy.SelectedValue)

            ssql = "INSERT INTO StaffExpenseMst " &
                   "(StaffName, SalaryMonth, SalaryAmount, PaidDate, PaidStatus, PaidByID, Remarks, EntBy, EntDt, IsDelete) VALUES (" &
                   "'" & cmbStaffName.Text.Trim().Replace("'", "''") & "', " &
                   "'" & monthValue.ToString("yyyy-MM-dd") & "', " &
                   Convert.ToDecimal(txtStaffAmount.Text) & ", " &
                   If(dtpStaffPaidDate.Checked, "'" & dtpStaffPaidDate.Value.ToString("yyyy-MM-dd") & "'", "NULL") & ", " &
                   "'" & cmbStaffPaidStatus.Text.Trim() & "', " &
                   If(IsDBNull(paidByID), "NULL", Convert.ToInt32(paidByID).ToString()) & ", " &
                   "'" & txtStaffRemarks.Text.Trim().Replace("'", "''") & "', " &
                   Convert.ToInt32(SessionEmpId) & ", GETDATE(), 'N')"
            ExecuteQuery(ssql)
            MessageBox.Show("Staff salary saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearStaffForm()
            LoadStaffGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvStaffExpense_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaffExpense.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Try
            Dim row As DataGridViewRow = dgvStaffExpense.Rows(e.RowIndex)
            selectedStaffExpenseID = Convert.ToInt32(row.Cells("StaffExpenseID").Value)

            cmbStaffName.Text = row.Cells("StaffName").Value.ToString()
            Dim monthStr As String = row.Cells("Month").Value.ToString()
            dtpStaffMonth.Value = DateTime.ParseExact(monthStr, "MMM-yy", Globalization.CultureInfo.InvariantCulture)
            txtStaffAmount.Text = row.Cells("SalaryAmount").Value.ToString()

            If IsDBNull(row.Cells("PaidDate").Value) Then
                dtpStaffPaidDate.Checked = False
            Else
                dtpStaffPaidDate.Checked = True
                dtpStaffPaidDate.Value = Convert.ToDateTime(row.Cells("PaidDate").Value)
            End If

            cmbStaffPaidStatus.Text = If(IsDBNull(row.Cells("PaidStatus").Value), "", row.Cells("PaidStatus").Value.ToString())
            cmbStaffPaidBy.Text = If(IsDBNull(row.Cells("PaidBy").Value), "", row.Cells("PaidBy").Value.ToString())
            txtStaffRemarks.Text = If(IsDBNull(row.Cells("Remarks").Value), "", row.Cells("Remarks").Value.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Selecting Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStaffUpdate_Click(sender As Object, e As EventArgs) Handles btnStaffUpdate.Click
        If selectedStaffExpenseID = 0 Then
            MessageBox.Show("Please select a record from the grid to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not ValidateStaffForm() Then Exit Sub

        Try
            Dim monthValue As Date = New Date(dtpStaffMonth.Value.Year, dtpStaffMonth.Value.Month, 1)
            Dim paidByID As Object = If(cmbStaffPaidBy.SelectedValue Is Nothing, DBNull.Value, cmbStaffPaidBy.SelectedValue)

            ssql = "UPDATE StaffExpenseMst SET " &
                   "StaffName = '" & cmbStaffName.Text.Trim().Replace("'", "''") & "', " &
                   "SalaryMonth = '" & monthValue.ToString("yyyy-MM-dd") & "', " &
                   "SalaryAmount = " & Convert.ToDecimal(txtStaffAmount.Text) & ", " &
                   "PaidDate = " & If(dtpStaffPaidDate.Checked, "'" & dtpStaffPaidDate.Value.ToString("yyyy-MM-dd") & "'", "NULL") & ", " &
                   "PaidStatus = '" & cmbStaffPaidStatus.Text.Trim() & "', " &
                   "PaidByID = " & If(IsDBNull(paidByID), "NULL", Convert.ToInt32(paidByID).ToString()) & ", " &
                   "Remarks = '" & txtStaffRemarks.Text.Trim().Replace("'", "''") & "', " &
                   "ModBy = " & Convert.ToInt32(SessionEmpId) & ", " &
                   "ModDt = GETDATE() " &
                   "WHERE StaffExpenseID = " & selectedStaffExpenseID
            ExecuteQuery(ssql)
            MessageBox.Show("Staff salary updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearStaffForm()
            LoadStaffGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStaffDelete_Click(sender As Object, e As EventArgs) Handles btnStaffDelete.Click
        If selectedStaffExpenseID = 0 Then
            MessageBox.Show("Please select a record from the grid to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to delete this record?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Exit Sub

        Try
            ssql = "UPDATE StaffExpenseMst SET IsDelete = 'Y', " &
                   "ModBy = " & Convert.ToInt32(SessionEmpId) & ", " &
                   "ModDt = GETDATE() " &
                   "WHERE StaffExpenseID = " & selectedStaffExpenseID
            ExecuteQuery(ssql)
            MessageBox.Show("Staff salary record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearStaffForm()
            LoadStaffGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnStaffClear_Click(sender As Object, e As EventArgs) Handles btnStaffClear.Click
        ClearStaffForm()
    End Sub

    Private Sub ClearStaffForm()
        selectedStaffExpenseID = 0
        cmbStaffName.SelectedIndex = -1
        dtpStaffMonth.Value = DateTime.Today
        txtStaffAmount.Clear()
        dtpStaffPaidDate.Checked = False
        cmbStaffPaidStatus.SelectedIndex = -1
        cmbStaffPaidBy.SelectedIndex = -1
        txtStaffRemarks.Clear()
        dgvStaffExpense.ClearSelection()
        cmbStaffName.Focus()
    End Sub

    Private Function ValidateStaffForm() As Boolean
        If String.IsNullOrWhiteSpace(cmbStaffName.Text) Then
            MessageBox.Show("Please select a staff name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStaffName.Focus()
            Return False
        End If

        Dim amt As Decimal
        If Not Decimal.TryParse(txtStaffAmount.Text, amt) OrElse amt <= 0 Then
            MessageBox.Show("Please enter a valid salary amount.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtStaffAmount.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(cmbStaffPaidStatus.Text) Then
            MessageBox.Show("Please select a paid status.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbStaffPaidStatus.Focus()
            Return False
        End If
        Return True
    End Function

End Class