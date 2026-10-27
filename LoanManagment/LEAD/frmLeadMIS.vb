Public Class frmLeadMIS

    Private selectedLeadMisID As Integer = 0

    Private Sub frmLeadMIS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtpLeadDate.Value = DateTime.Today

            ' Stage Type
            ssql = "SELECT StageType FROM StageMst WHERE IsActive='Y' ORDER BY StageType"
            FillCombo(txtStage, GetData(ssql), "StageType")

            ' Product
            ssql = "SELECT ProductType FROM ProductMst WHERE IsActive='Y' ORDER BY ProductType"
            FillCombo(CboProduct, GetData(ssql), "ProductType")

            ' Sub Product
            ssql = "SELECT ProductSubType FROM ProductSubMst WHERE IsActive='Y' ORDER BY ProductSubType"
            FillCombo(CboSubProduct, GetData(ssql), "ProductSubType")

            ' CPA
            ssql = "SELECT CPAName FROM CPAMst WHERE IsActive='Y' ORDER BY CPAName"
            FillCombo(CboCPA, GetData(ssql), "CPAName")

            ' Profile
            ssql = "SELECT ProfileType FROM ProfileMst WHERE IsActive='Y' ORDER BY ProfileType"
            FillCombo(txtProfile, GetData(ssql), "ProfileType")

            ' Bank
            ssql = "SELECT BankName FROM BankMst WHERE IsActive='Y' ORDER BY BankName"
            FillCombo(txtBank, GetData(ssql), "BankName")

            ' Property Address
            ssql = "SELECT PropertyAddress FROM PropertyAddressMst WHERE IsActive='Y' ORDER BY PropertyAddress"
            FillCombo(txtPropertyAdd, GetData(ssql), "PropertyAddress")

            ' Code
            ssql = "SELECT CodeName FROM CodeMst WHERE IsActive='Y' ORDER BY CodeName"
            FillCombo(CboCode, GetData(ssql), "CodeName")

            ' LEAD STAGE (used as Discuss Stage)
            ssql = "SELECT LeadStage FROM LeadStageMst WHERE IsActive='Y' ORDER BY LeadStage"
            FillCombo(CboLeadStage, GetData(ssql), "LeadStage")
            If CboLeadStage.Items.Count > 0 Then
                CboLeadStage.SelectedIndex = 0
            End If

            LoadLeadMISGrid()
        Catch ex As Exception
            MessageBox.Show("Form Load Error:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Not Required() Then Return

            ' Duplicate Mobile check
            ssql = "SELECT LeadMisID FROM LeadMIS " &
                   "WHERE MobileNo='" & SqlText(txtMobileNo.Text.Trim()) & "' " &
                   "AND ISNULL(IsDelete,'N')='N'"
            dt = GetData(ssql)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Record Already Exist with this Mobile No",
                                "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtMobileNo.Focus()
                Return
            End If

            ' INSERT
            ssql = "INSERT INTO LeadMIS " &
                   "(LeadDate,CustName,MobileNo,LoanAmount," &
                   "ExpOfferToCm,Stage,Product,SubProduct,CPA,PROFILE,BANK," &
                   "SdVALUE,SIZE,PropertyNo,PropertyAddress,OtherPropertyAddress," &
                   "REFERENCE,LeadStage,REMARKS,EntBy,EntDt,IsDelete) " &
                   "VALUES (" &
                   "'" & Format(dtpLeadDate.Value, "yyyy-MM-dd") & "'," &
                   "'" & SqlText(txtCustName.Text) & "'," &
                   "'" & SqlText(txtMobileNo.Text) & "'," &
                   "'" & SqlText(txtLoanAmnt.Text) & "'," &
                   "'" & SqlText(txtExpOfr.Text) & "'," &
                   "'" & SqlText(txtStage.Text) & "'," &
                   "'" & SqlText(CboProduct.Text) & "'," &
                   "'" & SqlText(CboSubProduct.Text) & "'," &
                   "'" & SqlText(CboCPA.Text) & "'," &
                   "'" & SqlText(txtProfile.Text) & "'," &
                   "'" & SqlText(txtBank.Text) & "'," &
                   "'" & SqlText(txtSdValue.Text) & "'," &
                   "'" & SqlText(txtSize.Text) & "'," &
                   "'" & SqlText(txtPropertyNo.Text) & "'," &
                   "'" & SqlText(txtPropertyAdd.Text) & "'," &
                   "'" & SqlText(txtOthrPropertyAdd.Text) & "'," &
                   "'" & SqlText(txtRef.Text) & "'," &
                   "'" & SqlText(CboLeadStage.Text) & "'," &
                   "'" & SqlText(txtRemarks.Text) & "'," &
                   "'" & SqlText(SessionEmpId) & "'," &
                   "GETDATE()," &
                   "'N')"

            ExecuteQuery(ssql)
            MessageBox.Show("Record Saved Successfully", "Save",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadLeadMISGrid()
        Catch ex As Exception
            MessageBox.Show("Save Error:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ClearForm()
            LoadLeadMISGrid()
        Catch ex As Exception
            MessageBox.Show("Refresh Error:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadLeadMISGrid()
        Try
            dgv.SuspendLayout()
            dgv.DataSource = Nothing
            dgv.Columns.Clear()

            ssql = "SELECT " &
                   "LeadMisID, " &
                   "LeadDate, " &
                   "LeadStage AS DiscussStage, " &
                   "CustName, " &
                   "MobileNo, " &
                   "LoanAmount, " &
                   "ExpOfferToCm, " &
                   "Stage, " &
                   "Product, " &
                   "SubProduct, " &
                   "CPA, " &
                   "PROFILE, " &
                   "BANK, " &
                   "SdVALUE, " &
                   "SIZE, " &
                   "PropertyNo, " &
                   "PropertyAddress, " &
                   "OtherPropertyAddress, " &
                   "REFERENCE, " &
                   "REMARKS, " &
                   "EntBy, " &
                   "EntDt, " &
                   "ModBy, " &
                   "ModDt " &
                   "FROM LeadMIS WITH (NOLOCK) " &
                   "WHERE ISNULL(IsDelete,'N')='N' " &
                   "AND ISNULL(LeadStage,'') <> 'LOGIN' " &
                   "ORDER BY LeadMisID DESC"

            Dim dtLead As DataTable = GetData(ssql)
            dgv.DataSource = dtLead

            ' Select CheckBox column for Bulk Delete
            Dim chk As New DataGridViewCheckBoxColumn()
            chk.Name = "SelectRow"
            chk.HeaderText = "Select"
            chk.Width = 55
            chk.ReadOnly = False
            dgv.Columns.Insert(0, chk)

            ' Make all data columns read-only
            For Each col As DataGridViewColumn In dgv.Columns
                If col.Name = "SelectRow" Then
                    col.ReadOnly = False
                Else
                    col.ReadOnly = True
                End If
            Next

            If dgv.Columns.Contains("LeadMisID") Then dgv.Columns("LeadMisID").Visible = False
            If dgv.Columns.Contains("DiscussStage") Then dgv.Columns("DiscussStage").HeaderText = "Discuss Stage"

            dgv.AllowUserToAddRows = False
            dgv.AllowUserToDeleteRows = False
            dgv.AllowUserToResizeRows = False
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.MultiSelect = False
            dgv.ReadOnly = False
            dgv.RowTemplate.Height = 30
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            dgv.ResumeLayout()
        Catch ex As Exception
            dgv.ResumeLayout()
            Throw New Exception("Unable to load Lead MIS grid." & Environment.NewLine & ex.Message)
        End Try
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Try
            If e.RowIndex < 0 Then Exit Sub

            ' If user clicks the checkbox column, let them toggle selection without repopulating form
            If dgv.Columns.Contains("SelectRow") AndAlso e.ColumnIndex = dgv.Columns("SelectRow").Index Then
                Exit Sub
            End If

            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            If row.IsNewRow Then Exit Sub

            selectedLeadMisID = Convert.ToInt32(GetCellValue(row, "LeadMisID"))

            ' Fill form inputs
            Dim dVal As Object = row.Cells("LeadDate").Value
            If dVal IsNot Nothing AndAlso Not IsDBNull(dVal) AndAlso IsDate(dVal) Then
                dtpLeadDate.Value = Convert.ToDateTime(dVal)
            End If

            txtCustName.Text = GetCellValue(row, "CustName")
            txtMobileNo.Text = GetCellValue(row, "MobileNo")
            txtLoanAmnt.Text = GetCellValue(row, "LoanAmount")
            txtExpOfr.Text = GetCellValue(row, "ExpOfferToCm")
            txtSdValue.Text = GetCellValue(row, "SdVALUE")
            txtSize.Text = GetCellValue(row, "SIZE")
            txtPropertyNo.Text = GetCellValue(row, "PropertyNo")
            txtOthrPropertyAdd.Text = GetCellValue(row, "OtherPropertyAddress")
            txtRef.Text = GetCellValue(row, "REFERENCE")
            txtRemarks.Text = GetCellValue(row, "REMARKS")

            SetComboValue(CboLeadStage, GetCellValue(row, "DiscussStage"))
            SetComboValue(CboProduct, GetCellValue(row, "Product"))
            SetComboValue(CboSubProduct, GetCellValue(row, "SubProduct"))
            SetComboValue(CboCPA, GetCellValue(row, "CPA"))
            SetComboValue(txtProfile, GetCellValue(row, "PROFILE"))
            SetComboValue(txtBank, GetCellValue(row, "BANK"))
            SetComboValue(txtPropertyAdd, GetCellValue(row, "PropertyAddress"))
            SetComboValue(txtStage, GetCellValue(row, "Stage"))

        Catch ex As Exception
            MessageBox.Show("Error loading record into form:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If selectedLeadMisID <= 0 Then
                MessageBox.Show("Please select a record from the grid to update.", "Update",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Not Required() Then Return

            Dim leadDateStr As String = Format(dtpLeadDate.Value, "yyyy-MM-dd")
            Dim discussStage As String = CboLeadStage.Text.Trim()

            ssql = "UPDATE LeadMIS SET " &
                   "LeadDate='" & SqlText(leadDateStr) & "'," &
                   "CustName='" & SqlText(txtCustName.Text) & "'," &
                   "MobileNo='" & SqlText(txtMobileNo.Text) & "'," &
                   "LoanAmount='" & SqlText(txtLoanAmnt.Text) & "'," &
                   "ExpOfferToCm='" & SqlText(txtExpOfr.Text) & "'," &
                   "Stage='" & SqlText(txtStage.Text) & "'," &
                   "Product='" & SqlText(CboProduct.Text) & "'," &
                   "SubProduct='" & SqlText(CboSubProduct.Text) & "'," &
                   "CPA='" & SqlText(CboCPA.Text) & "'," &
                   "PROFILE='" & SqlText(txtProfile.Text) & "'," &
                   "BANK='" & SqlText(txtBank.Text) & "'," &
                   "SdVALUE='" & SqlText(txtSdValue.Text) & "'," &
                   "SIZE='" & SqlText(txtSize.Text) & "'," &
                   "PropertyNo='" & SqlText(txtPropertyNo.Text) & "'," &
                   "PropertyAddress='" & SqlText(txtPropertyAdd.Text) & "'," &
                   "OtherPropertyAddress='" & SqlText(txtOthrPropertyAdd.Text) & "'," &
                   "REFERENCE='" & SqlText(txtRef.Text) & "'," &
                   "LeadStage='" & SqlText(discussStage) & "'," &
                   "REMARKS='" & SqlText(txtRemarks.Text) & "'," &
                   "ModBy='" & SqlText(SessionEmpId) & "'," &
                   "ModDt=GETDATE() " &
                   "WHERE LeadMisID=" & selectedLeadMisID

            ExecuteQuery(ssql)

            ' Special logic based on Discuss Stage
            If discussStage.ToUpper() = "LOGIN" Then
                ssql = "IF NOT EXISTS (SELECT 1 FROM LoginMIS WHERE LeadID=" & selectedLeadMisID & ") " &
                       "BEGIN INSERT INTO LoginMIS (LeadID) VALUES (" & selectedLeadMisID & ") END"
                ExecuteQuery(ssql)

                ssql = "IF NOT EXISTS (SELECT 1 FROM ExpenseIncome WHERE LeadID=" & selectedLeadMisID & ") " &
                       "BEGIN " &
                       "INSERT INTO ExpenseIncome (LeadID, LoginMisID, EntBy, EntDt, IsDelete) " &
                       "SELECT " & selectedLeadMisID & ", LoginMisID, '" & SessionEmpId & "', GETDATE(), 'N' " &
                       "FROM LoginMIS WHERE LeadID=" & selectedLeadMisID & " " &
                       "END"
                ExecuteQuery(ssql)
            End If

            If discussStage.ToUpper() = "CANCEL" Then
                ssql = "UPDATE LeadMIS SET IsDelete='Y' WHERE LeadMisID=" & selectedLeadMisID
                ExecuteQuery(ssql)
            End If

            MessageBox.Show("Record updated successfully.", "Update",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadLeadMISGrid()
        Catch ex As Exception
            MessageBox.Show("Update Error:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim selectedCount As Integer = 0
            For Each row As DataGridViewRow In dgv.Rows
                If row.IsNewRow Then Continue For
                If IsRowChecked(row) Then selectedCount += 1
            Next

            If selectedCount = 0 AndAlso selectedLeadMisID > 0 Then
                ' If no checkbox is ticked but a record is selected in form
                Dim res As DialogResult = MessageBox.Show("Are you sure you want to delete the currently selected record?",
                                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = DialogResult.Yes Then
                    ssql = "UPDATE LeadMIS SET IsDelete='Y', " &
                           "ModBy='" & SqlText(SessionEmpId) & "', ModDt=GETDATE() " &
                           "WHERE LeadMisID=" & selectedLeadMisID
                    ExecuteQuery(ssql)
                    MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                    LoadLeadMISGrid()
                End If
                Return
            End If

            If selectedCount = 0 Then
                MessageBox.Show("Please select at least one record to delete.", "Delete",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show(
                "Are you sure you want to delete " & selectedCount.ToString() & " selected record(s)?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result <> DialogResult.Yes Then Return

            For Each row As DataGridViewRow In dgv.Rows
                If row.IsNewRow Then Continue For
                If IsRowChecked(row) Then
                    Dim leadID As Integer = Convert.ToInt32(GetCellValue(row, "LeadMisID"))
                    ssql = "UPDATE LeadMIS SET IsDelete='Y', " &
                           "ModBy='" & SqlText(SessionEmpId) & "', ModDt=GETDATE() " &
                           "WHERE LeadMisID=" & leadID
                    ExecuteQuery(ssql)
                End If
            Next

            MessageBox.Show("Record(s) Deleted Successfully", "Delete",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadLeadMISGrid()
        Catch ex As Exception
            MessageBox.Show("Delete Error:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgv_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv.CurrentCellDirtyStateChanged
        Try
            If dgv.IsCurrentCellDirty AndAlso TypeOf dgv.CurrentCell Is DataGridViewCheckBoxCell Then
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        Catch
        End Try
    End Sub

    Private Function Required() As Boolean
        If Not RequiredField(dtpLeadDate, "Lead Date") Then Return False
        If Not RequiredField(txtCustName, "Customer Name") Then Return False
        If String.IsNullOrWhiteSpace(txtMobileNo.Text) Then
            MessageBox.Show("Please enter Mobile No.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMobileNo.Focus()
            Return False
        End If
        Dim mobile As String = txtMobileNo.Text.Trim()
        If mobile.Length <> 10 OrElse Not IsNumeric(mobile) Then
            MessageBox.Show("Mobile No must be exactly 10 digits.", "Invalid Mobile No",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMobileNo.Focus()
            Return False
        End If
        If Not RequiredField(txtLoanAmnt, "Loan Amount") Then Return False
        If Not RequiredField(CboProduct, "Product") Then Return False
        If Not RequiredField(CboSubProduct, "Sub Product") Then Return False
        If Not RequiredField(txtPropertyNo, "Property No") Then Return False
        If Not RequiredField(txtPropertyAdd, "Property Address") Then Return False
        If Not RequiredField(txtRef, "Reference") Then Return False
        If Not RequiredField(CboLeadStage, "Lead Stage") Then Return False
        Return True
    End Function

    Private Sub SetComboValue(cbo As ComboBox, value As String)
        If cbo Is Nothing Then Exit Sub
        Dim idx As Integer = cbo.FindStringExact(value)
        If idx >= 0 Then
            cbo.SelectedIndex = idx
        Else
            cbo.Text = value
        End If
    End Sub

    Private Function GetCellValue(row As DataGridViewRow, columnName As String) As String
        Try
            If Not dgv.Columns.Contains(columnName) Then Return ""
            Dim value As Object = row.Cells(columnName).Value
            If value Is Nothing OrElse IsDBNull(value) Then Return ""
            Return value.ToString().Trim()
        Catch
            Return ""
        End Try
    End Function

    Private Function IsRowChecked(row As DataGridViewRow) As Boolean
        Try
            If row Is Nothing OrElse row.IsNewRow Then Return False
            If Not dgv.Columns.Contains("SelectRow") Then Return False
            Dim value As Object = row.Cells("SelectRow").Value
            If value Is Nothing OrElse IsDBNull(value) Then Return False
            Return Convert.ToBoolean(value)
        Catch
            Return False
        End Try
    End Function

    Private Function SqlText(value As String) As String
        If value Is Nothing Then Return ""
        Return value.Replace("'", "''")
    End Function

    Private Sub ClearForm()
        Try
            selectedLeadMisID = 0
            txtCustName.Clear()
            txtMobileNo.Clear()
            txtLoanAmnt.Clear()
            txtExpOfr.Clear()
            txtSdValue.Clear()
            txtSize.Clear()
            txtPropertyNo.Clear()
            txtOthrPropertyAdd.Clear()
            txtRef.Clear()
            txtRemarks.Clear()
            CboProduct.SelectedIndex = -1
            CboSubProduct.SelectedIndex = -1
            CboCPA.SelectedIndex = -1
            txtProfile.SelectedIndex = -1
            txtBank.SelectedIndex = -1
            txtPropertyAdd.SelectedIndex = -1
            CboCode.SelectedIndex = -1
            txtStage.SelectedIndex = -1
            If CboLeadStage.Items.Count > 0 Then
                CboLeadStage.SelectedIndex = 0
            Else
                CboLeadStage.SelectedIndex = -1
            End If
            dtpLeadDate.Value = DateTime.Today
            txtCustName.Focus()
        Catch ex As Exception
            MessageBox.Show("Clear Form Error:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class