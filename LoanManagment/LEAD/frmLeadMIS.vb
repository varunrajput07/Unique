Public Class frmLeadMIS

    '===========================================================
    ' FORM LOAD
    '===========================================================
    Private Sub frmLeadMIS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            '---------------------------------------------------
            ' DISC LOGIN STAGE
            ' PENDING / CONFIRM / LOGIN
            '---------------------------------------------------
            ssql = "SELECT DiscLoginStage " &
         "FROM DiscLoginStageMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY DiscLoginStage"

            FillCombo(CmbDiscLogin, GetData(ssql), "DiscLoginStage")


            '---------------------------------------------------
            ' LEAD STAGE
            '---------------------------------------------------
            ssql = "SELECT StageType " &
         "FROM StageMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY StageType"

            FillCombo(txtStage, GetData(ssql), "StageType")


            '---------------------------------------------------
            ' PRODUCT
            '---------------------------------------------------
            ssql = "SELECT ProductType " &
         "FROM ProductMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY ProductType"

            FillCombo(CboProduct, GetData(ssql), "ProductType")


            '---------------------------------------------------
            ' SUB PRODUCT
            '---------------------------------------------------
            ssql = "SELECT ProductSubType " &
         "FROM ProductSubMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY ProductSubType"

            FillCombo(CboSubProduct, GetData(ssql), "ProductSubType")


            '---------------------------------------------------
            ' CPA
            '---------------------------------------------------
            ssql = "SELECT CPAName " &
         "FROM CPAMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY CPAName"

            FillCombo(CboCPA, GetData(ssql), "CPAName")


            '---------------------------------------------------
            ' PROFILE
            '---------------------------------------------------
            ssql = "SELECT ProfileType " &
         "FROM ProfileMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY ProfileType"

            FillCombo(txtProfile, GetData(ssql), "ProfileType")


            '---------------------------------------------------
            ' BANK
            '---------------------------------------------------
            ssql = "SELECT BankName " &
         "FROM BankMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY BankName"

            FillCombo(txtBank, GetData(ssql), "BankName")


            '---------------------------------------------------
            ' PROPERTY ADDRESS
            '---------------------------------------------------
            ssql = "SELECT PropertyAddress " &
         "FROM PropertyAddressMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY PropertyAddress"

            FillCombo(txtPropertyAdd, GetData(ssql), "PropertyAddress")


            '---------------------------------------------------
            ' CODE
            '---------------------------------------------------
            ssql = "SELECT CodeName " &
         "FROM CodeMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY CodeName"

            FillCombo(CboCode, GetData(ssql), "CodeName")


            '---------------------------------------------------
            ' LEAD STAGE MASTER
            '---------------------------------------------------
            ssql = "SELECT LeadStage " &
         "FROM LeadStageMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY LeadStage"

            FillCombo(CboLeadStage, GetData(ssql), "LeadStage")


            '---------------------------------------------------
            ' DEFAULT DISC LOGIN STAGE
            '---------------------------------------------------
            If CmbDiscLogin.Items.Count > 0 Then
                CmbDiscLogin.SelectedIndex = 0
            End If


            '---------------------------------------------------
            ' LOAD GRID
            '---------------------------------------------------
            LoadLeadMISGrid()

        Catch ex As Exception

            MessageBox.Show(
              "Form Load Error:" & Environment.NewLine & ex.Message,
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' SAVE
    '===========================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            '---------------------------------------------------
            ' VALIDATION
            '---------------------------------------------------
            If Not Required() Then
                Return
            End If


            '---------------------------------------------------
            ' CHECK DUPLICATE MOBILE NUMBER
            '---------------------------------------------------
            ssql = "SELECT LeadMisID " &
         "FROM LeadMIS " &
         "WHERE MobileNo='" & SqlText(txtMobileNo.Text.Trim()) & "' " &
         "AND ISNULL(IsDelete,'N')='N'"

            dt = GetData(ssql)


            If dt.Rows.Count > 0 Then

                MessageBox.Show(
                  "Record Already Exist with this Mobile No",
                  "Duplicate Record",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                )

                txtMobileNo.Focus()

                Return

            End If


            '---------------------------------------------------
            ' INSERT LEAD MIS
            '---------------------------------------------------
            ssql = "INSERT INTO LeadMIS " &
         "(LeadDate,DiscLogin,CustName,MobileNo,LoanAmount," &
         "ExpOfferToCm,Stage,Product,SubProduct,CPA,PROFILE,BANK," &
         "SdVALUE,SIZE,PropertyNo,PropertyAddress,OtherPropertyAddress," &
         "REFERENCE,LeadStage,REMARKS,EntBy,EntDt,IsDelete) " &
         "VALUES (" &
         "'" & Format(dtpLeadDate.Value, "yyyy-MM-dd") & "'," &
         "'" & SqlText(CmbDiscLogin.Text) & "'," &
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


            MessageBox.Show(
              "Record Saved Successfully",
              "Save",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            )


            '---------------------------------------------------
            ' CLEAR FORM
            '---------------------------------------------------
            ClearForm()


            '---------------------------------------------------
            ' REFRESH GRID
            '---------------------------------------------------
            LoadLeadMISGrid()


        Catch ex As Exception

            MessageBox.Show(
              "Save Error:" & Environment.NewLine & ex.Message,
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' REFRESH BUTTON
    '===========================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Try

            LoadLeadMISGrid()

        Catch ex As Exception

            MessageBox.Show(
              "Refresh Error:" & Environment.NewLine & ex.Message,
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' LOAD GRID
    '===========================================================
    Private Sub LoadLeadMISGrid()

        Try

            dgv.SuspendLayout()

            dgv.DataSource = Nothing

            If dgv.Columns.Contains("SelectRow") Then
                dgv.Columns.Remove("SelectRow")
            End If

            If dgv.Columns.Contains("DiscussStage") Then
                dgv.Columns.Remove("DiscussStage")
            End If

            ssql = "SELECT " &
               "LeadMisID, " &
               "LeadDate, " &
               "DiscLogin AS DiscussStage, " &
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
               "LeadStage, " &
               "REMARKS, " &
               "EntBy, " &
               "EntDt, " &
               "ModBy, " &
               "ModDt " &
               "FROM LeadMIS WITH (NOLOCK) " &
               "WHERE ISNULL(IsDelete,'N')='N' " &
               "AND ISNULL(DiscLogin,'') <> 'LOGIN' " &
               "ORDER BY LeadMisID DESC"


            Dim dtLead As DataTable = GetData(ssql)

            dgv.DataSource = dtLead


            '=========================================================
            ' CHECKBOX COLUMN
            '=========================================================
            Dim chk As New DataGridViewCheckBoxColumn()

            chk.Name = "SelectRow"
            chk.HeaderText = "Select"
            chk.Width = 55
            chk.ReadOnly = False

            dgv.Columns.Insert(0, chk)


            '=========================================================
            ' DISCUSS STAGE COMBOBOX
            ' PENDING / CONFIRM / LOGIN
            '=========================================================
            If dgv.Columns.Contains("DiscussStage") Then

                Dim colIndex As Integer =
                dgv.Columns("DiscussStage").Index

                dgv.Columns.Remove("DiscussStage")


                Dim cboDiscussStage As New DataGridViewComboBoxColumn()

                cboDiscussStage.Name = "DiscussStage"
                cboDiscussStage.HeaderText = "Discuss Stage"
                cboDiscussStage.DataPropertyName = "DiscussStage"

                cboDiscussStage.FlatStyle = FlatStyle.Flat

                cboDiscussStage.DisplayStyle =
                DataGridViewComboBoxDisplayStyle.DropDownButton


                ssql = "SELECT LeadStage " &
         "FROM LeadStageMst " &
         "WHERE IsActive='Y' " &
         "ORDER BY LeadStage"


                Dim dtDiscLogin As DataTable =
                GetData(ssql)


                For Each dr As DataRow In dtDiscLogin.Rows

                    If Not IsDBNull(dr("LeadStage")) Then

                        cboDiscussStage.Items.Add(
                        dr("LeadStage").ToString()
                    )

                    End If

                Next


                dgv.Columns.Insert(
                colIndex,
                cboDiscussStage
            )

            End If


            '=========================================================
            ' LEAD STAGE
            '
            ' LeadStage is already coming from LeadMIS
            ' and will display as a normal column.
            '=========================================================
            If dgv.Columns.Contains("LeadStage") Then

                dgv.Columns("LeadStage").HeaderText = "Lead Stage"

                dgv.Columns("LeadStage").ReadOnly = True

            End If


            '=========================================================
            ' SET READONLY
            '=========================================================
            For Each col As DataGridViewColumn In dgv.Columns

                If col.Name = "SelectRow" Then

                    col.ReadOnly = False

                Else

                    col.ReadOnly = True

                End If

            Next


            '=========================================================
            ' HIDE PRIMARY KEY
            '=========================================================
            If dgv.Columns.Contains("LeadMisID") Then
                dgv.Columns("LeadMisID").Visible = False
            End If


            '=========================================================
            ' GRID SETTINGS
            '=========================================================
            dgv.AllowUserToAddRows = False
            dgv.AllowUserToDeleteRows = False
            dgv.AllowUserToResizeRows = False

            dgv.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

            dgv.MultiSelect = True

            dgv.EditMode =
            DataGridViewEditMode.EditOnEnter


            '=========================================================
            ' COLUMN SETTINGS
            '=========================================================
            If dgv.Columns.Contains("SelectRow") Then
                dgv.Columns("SelectRow").Width = 55
            End If


            'Lead Stage width
            If dgv.Columns.Contains("LeadStage") Then
                dgv.Columns("LeadStage").Width = 120
            End If


            'Discuss Stage width
            If dgv.Columns.Contains("DiscussStage") Then
                dgv.Columns("DiscussStage").Width = 120
            End If


            'Customer Name width
            If dgv.Columns.Contains("CustName") Then
                dgv.Columns("CustName").Width = 180
            End If


            'Property Address width
            If dgv.Columns.Contains("PropertyAddress") Then
                dgv.Columns("PropertyAddress").Width = 180
            End If


            'Remarks width
            If dgv.Columns.Contains("REMARKS") Then
                dgv.Columns("REMARKS").Width = 200
            End If


            '=========================================================
            ' ROW HEIGHT
            '=========================================================
            dgv.RowTemplate.Height = 30


            dgv.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.DisplayedCells


            dgv.ResumeLayout()

        Catch ex As Exception

            dgv.ResumeLayout()

            Throw New Exception(
            "Unable to load Lead MIS grid." &
            Environment.NewLine &
            ex.Message
        )

        End Try
    End Sub


    '===========================================================
    ' DELETE
    '===========================================================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            Dim selectedCount As Integer = 0


            '---------------------------------------------------
            ' CHECK SELECTED RECORDS
            '---------------------------------------------------
            For Each row As DataGridViewRow In dgv.Rows

                If row.IsNewRow Then
                    Continue For
                End If


                If IsRowChecked(row) Then

                    selectedCount += 1

                End If

            Next


            If selectedCount = 0 Then

                MessageBox.Show(
                  "Please select at least one record.",
                  "Delete",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                )

                Return

            End If


            '---------------------------------------------------
            ' CONFIRM DELETE
            '---------------------------------------------------
            Dim result As DialogResult =
        MessageBox.Show(
          "Are you sure you want to delete " &
          selectedCount.ToString() &
          " selected record(s)?",
          "Confirm Delete",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
        )


            If result <> DialogResult.Yes Then
                Return
            End If


            '---------------------------------------------------
            ' DELETE SELECTED RECORDS
            '---------------------------------------------------
            For Each row As DataGridViewRow In dgv.Rows

                If row.IsNewRow Then
                    Continue For
                End If


                If IsRowChecked(row) Then

                    Dim leadID As Integer =
                      Convert.ToInt32(
                        GetCellValue(row, "LeadMisID")
                      )


                    ssql =
                      "UPDATE LeadMIS SET " &
                      "IsDelete='Y', " &
                      "ModBy='" & SqlText(SessionEmpId) & "', " &
                      "ModDt=GETDATE() " &
                      "WHERE LeadMisID=" & leadID


                    ExecuteQuery(ssql)

                End If

            Next


            MessageBox.Show(
              "Record(s) Deleted Successfully",
              "Delete",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            )


            '---------------------------------------------------
            ' REFRESH
            '---------------------------------------------------
            LoadLeadMISGrid()


        Catch ex As Exception

            MessageBox.Show(
              "Delete Error:" & Environment.NewLine &
              ex.Message,
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' UPDATE
    '===========================================================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Dim selectedCount As Integer = 0


            '---------------------------------------------------
            ' COUNT SELECTED ROWS
            '---------------------------------------------------
            For Each row As DataGridViewRow In dgv.Rows

                If row.IsNewRow Then
                    Continue For
                End If


                If IsRowChecked(row) Then

                    selectedCount += 1

                End If

            Next


            If selectedCount = 0 Then

                MessageBox.Show(
                  "Please select at least one record to update.",
                  "Update",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Warning
                )

                Return

            End If


            '---------------------------------------------------
            ' UPDATE SELECTED ROWS
            '---------------------------------------------------
            For Each row As DataGridViewRow In dgv.Rows

                If row.IsNewRow Then
                    Continue For
                End If


                If Not IsRowChecked(row) Then
                    Continue For
                End If


                Dim leadID As Integer =
                  Convert.ToInt32(
                    GetCellValue(row, "LeadMisID")
                  )


                '------------------------------------------------
                ' GET VALUES
                '------------------------------------------------
                Dim leadDate As String =
          GetCellValue(row, "LeadDate")

                Dim discussStage As String =
                  GetCellValue(row, "DiscussStage")

                Dim custName As String =
                  GetCellValue(row, "CustName")

                Dim mobileNo As String =
                  GetCellValue(row, "MobileNo")

                Dim loanAmount As String =
                  GetCellValue(row, "LoanAmount")

                Dim expOffer As String =
                  GetCellValue(row, "ExpOfferToCm")

                Dim stage As String =
                  GetCellValue(row, "Stage")

                Dim product As String =
                  GetCellValue(row, "Product")

                Dim subProduct As String =
                  GetCellValue(row, "SubProduct")

                Dim cpa As String =
                  GetCellValue(row, "CPA")

                Dim profile As String =
                  GetCellValue(row, "PROFILE")

                Dim bank As String =
                  GetCellValue(row, "BANK")

                Dim sdValue As String =
                  GetCellValue(row, "SdVALUE")

                Dim sizeValue As String =
                  GetCellValue(row, "SIZE")

                Dim propertyNo As String =
                  GetCellValue(row, "PropertyNo")

                Dim propertyAddress As String =
                  GetCellValue(row, "PropertyAddress")

                Dim otherPropertyAddress As String =
                  GetCellValue(row, "OtherPropertyAddress")

                Dim reference As String =
                  GetCellValue(row, "REFERENCE")

                Dim leadStage As String =
                  GetCellValue(row, "LeadStage")

                Dim remarks As String =
                  GetCellValue(row, "REMARKS")


                '------------------------------------------------
                ' UPDATE LEAD MIS
                '------------------------------------------------
                ssql =
          "UPDATE LeadMIS SET " &
          "LeadDate='" & SqlText(leadDate) & "'," &
          "DiscLogin='" & SqlText(discussStage) & "'," &
          "CustName='" & SqlText(custName) & "'," &
          "MobileNo='" & SqlText(mobileNo) & "'," &
          "LoanAmount='" & SqlText(loanAmount) & "'," &
          "ExpOfferToCm='" & SqlText(expOffer) & "'," &
          "Stage='" & SqlText(stage) & "'," &
          "Product='" & SqlText(product) & "'," &
          "SubProduct='" & SqlText(subProduct) & "'," &
          "CPA='" & SqlText(cpa) & "'," &
          "PROFILE='" & SqlText(profile) & "'," &
          "BANK='" & SqlText(bank) & "'," &
          "SdVALUE='" & SqlText(sdValue) & "'," &
          "SIZE='" & SqlText(sizeValue) & "'," &
          "PropertyNo='" & SqlText(propertyNo) & "'," &
          "PropertyAddress='" & SqlText(propertyAddress) & "'," &
          "OtherPropertyAddress='" & SqlText(otherPropertyAddress) & "'," &
          "REFERENCE='" & SqlText(reference) & "'," &
          "LeadStage='" & SqlText(leadStage) & "'," &
          "REMARKS='" & SqlText(remarks) & "'," &
          "ModBy='" & SqlText(SessionEmpId) & "'," &
          "ModDt=GETDATE() " &
          "WHERE LeadMisID=" & leadID


                ExecuteQuery(ssql)


                '------------------------------------------------
                ' IF DISCUSS STAGE = LOGIN
                ' CREATE LOGIN MIS RECORD
                '------------------------------------------------
                If discussStage.Trim().ToUpper() = "LOGIN" Then

                    ssql =
                      "IF NOT EXISTS " &
                      "(SELECT 1 FROM LoginMIS WHERE LeadID=" & leadID & ") " &
                      "BEGIN " &
                      "INSERT INTO LoginMIS (LeadID) " &
                      "VALUES (" & leadID & ") " &
                      "END"


                    ExecuteQuery(ssql)

                End If

            Next


            MessageBox.Show(
              selectedCount.ToString() &
              " record(s) updated successfully.",
              "Update",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information
            )


            '---------------------------------------------------
            ' REFRESH GRID
            '---------------------------------------------------
            LoadLeadMISGrid()


        Catch ex As Exception

            MessageBox.Show(
              "Update Error:" & Environment.NewLine &
              ex.Message,
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' CHECKBOX VALUE CHANGED
    '===========================================================
    Private Sub dgv_CellValueChanged(
    sender As Object,
    e As DataGridViewCellEventArgs
  ) Handles dgv.CellValueChanged

        Try

            If e.RowIndex < 0 Then
                Exit Sub
            End If


            If Not dgv.Columns.Contains("SelectRow") Then
                Exit Sub
            End If


            If e.ColumnIndex < 0 Then
                Exit Sub
            End If


            If dgv.Columns(e.ColumnIndex).Name <> "SelectRow" Then
                Exit Sub
            End If


            Dim row As DataGridViewRow =
              dgv.Rows(e.RowIndex)


            Dim isChecked As Boolean = False


            If row.Cells("SelectRow").Value IsNot Nothing AndAlso
             Not IsDBNull(row.Cells("SelectRow").Value) Then

                isChecked =
                  Convert.ToBoolean(
                    row.Cells("SelectRow").Value
                  )

            End If


            '---------------------------------------------------
            ' SELECTED = EDITABLE
            ' UNSELECTED = READONLY
            '---------------------------------------------------
            For Each col As DataGridViewColumn In dgv.Columns

                If col.Name = "SelectRow" Then

                    col.ReadOnly = False

                ElseIf col.Name = "LeadMisID" Then

                    col.ReadOnly = True

                Else

                    row.Cells(col.Index).ReadOnly =
                      Not isChecked

                End If

            Next


        Catch ex As Exception

            MessageBox.Show(
              "Selection Error:" & Environment.NewLine &
              ex.Message,
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error
            )

        End Try

    End Sub


    '===========================================================
    ' CHECKBOX COMMIT
    '===========================================================
    Private Sub dgv_CurrentCellDirtyStateChanged(
    sender As Object,
    e As EventArgs
  ) Handles dgv.CurrentCellDirtyStateChanged

        Try

            If dgv.IsCurrentCellDirty Then

                If TypeOf dgv.CurrentCell Is DataGridViewCheckBoxCell Then

                    dgv.CommitEdit(
                      DataGridViewDataErrorContexts.Commit
                    )

                End If

            End If

        Catch ex As Exception

        End Try

    End Sub


    '===========================================================
    ' REQUIRED VALIDATION
    '===========================================================
    Private Function Required() As Boolean

        If Not RequiredField(
          dtpLeadDate,
          "Lead Date"
        ) Then Return False


        If Not RequiredField(
          txtCustName,
          "Customer Name"
        ) Then Return False


        If Not RequiredField(
          txtMobileNo,
          "Mobile No."
        ) Then Return False


        If Not RequiredField(
          txtLoanAmnt,
          "Loan Amount"
        ) Then Return False


        If Not RequiredField(
          CboProduct,
          "Product"
        ) Then Return False


        If Not RequiredField(
          CboSubProduct,
          "Sub Product"
        ) Then Return False


        If Not RequiredField(
          txtPropertyNo,
          "Property No"
        ) Then Return False


        If Not RequiredField(
          txtPropertyAdd,
          "Property Address"
        ) Then Return False


        If Not RequiredField(
          txtRef,
          "Reference"
        ) Then Return False


        Return True

    End Function


    '===========================================================
    ' GET DATAGRIDVIEW CELL VALUE
    '===========================================================
    Private Function GetCellValue(
    row As DataGridViewRow,
    columnName As String
  ) As String

        Try

            If Not dgv.Columns.Contains(columnName) Then
                Return ""
            End If


            Dim value As Object =
              row.Cells(columnName).Value


            If value Is Nothing OrElse IsDBNull(value) Then
                Return ""
            End If


            Return value.ToString().Trim()


        Catch ex As Exception

            Return ""

        End Try

    End Function


    '===========================================================
    ' CHECK WHETHER ROW IS SELECTED
    '===========================================================
    Private Function IsRowChecked(
    row As DataGridViewRow
  ) As Boolean

        Try

            If row Is Nothing Then
                Return False
            End If


            If row.IsNewRow Then
                Return False
            End If


            If Not dgv.Columns.Contains("SelectRow") Then
                Return False
            End If


            Dim value As Object =
              row.Cells("SelectRow").Value


            If value Is Nothing OrElse IsDBNull(value) Then
                Return False
            End If


            Return Convert.ToBoolean(value)


        Catch ex As Exception

            Return False

        End Try

    End Function


    '===========================================================
    ' SQL TEXT ESCAPE
    '===========================================================
    Private Function SqlText(value As String) As String

        If value Is Nothing Then
            Return ""
        End If


        Return value.Replace("'", "''")

    End Function


    '===========================================================
    ' CLEAR FORM
    '===========================================================
    Private Sub ClearForm()

        Try

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


            If CmbDiscLogin.Items.Count > 0 Then
                CmbDiscLogin.SelectedIndex = 0
            Else
                CmbDiscLogin.SelectedIndex = -1
            End If


            CboProduct.SelectedIndex = -1
            CboSubProduct.SelectedIndex = -1
            CboCPA.SelectedIndex = -1
            txtProfile.SelectedIndex = -1
            txtBank.SelectedIndex = -1
            txtPropertyAdd.SelectedIndex = -1
            CboCode.SelectedIndex = -1
            CboLeadStage.SelectedIndex = -1
            txtStage.SelectedIndex = -1


            dtpLeadDate.Value = DateTime.Now


            txtCustName.Focus()

        Catch ex As Exception

            MessageBox.Show(
                "Clear Form Error:" & Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class