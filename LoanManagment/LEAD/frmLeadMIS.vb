Public Class frmLeadMIS
    Private Sub frmLeadMIS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ssql = "select DiscLoginStage from DiscLoginStageMst where IsActive='Y'"
            FillCombo(CmbDiscLogin, GetData(ssql), "DiscLoginStage")

            ssql = "select StageType from StageMst where IsActive='Y'"
            FillCombo(txtStage, GetData(ssql), "StageType")

            ssql = "select ProductType from ProductMst where IsActive='Y'"
            FillCombo(CboProduct, GetData(ssql), "ProductType")

            ssql = "select ProductSubType from ProductSubMst where IsActive='Y'"
            FillCombo(CboSubProduct, GetData(ssql), "ProductSubType")

            ssql = "select CPAName from CPAMst where IsActive='Y'"
            FillCombo(CboCPA, GetData(ssql), "CPAName")

            ssql = "select ProfileType from ProfileMst where IsActive='Y'"
            FillCombo(txtProfile, GetData(ssql), "ProfileType")

            ssql = "select BankName from BankMst where IsActive='Y'"
            FillCombo(txtBank, GetData(ssql), "BankName")

            ssql = "select PropertyAddress from PropertyAddressMst where IsActive='Y'"
            FillCombo(txtPropertyAdd, GetData(ssql), "PropertyAddress")

            ssql = "select CodeName from CodeMst where IsActive='Y'"
            FillCombo(CboCode, GetData(ssql), "CodeName")

            ssql = "select LeadStage from LeadStageMst where IsActive='Y'"
            FillCombo(CboLeadStage, GetData(ssql), "LeadStage")


            CmbDiscLogin.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If Not Required() Then Return

            ssql = "select * from LeadMIS where MobileNo='" & txtMobileNo.Text & "'"
            dt = GetData(ssql)

            If dt.Rows.Count > 0 Then
                MessageBox.Show("Record Already Exist with this Mobile No")
                Exit Sub
            Else

            End If

            ssql = "INSERT INTO leadmis " &
           "(LeadDate,CustName,MobileNo,LoanAmount,ExpOfferToCm,Product,SubProduct,CPA,PROFILE,BANK,SdVALUE,SIZE,PropertyNo,PropertyAddress,OtherPropertyAddress,REFERENCE,LeadStage,REMARKS,EntBy,EntDt) " &
           "VALUES (" &
           "'" & Format(dtpLeadDate.Value, "yyyy-MM-dd") & "'," &
           "'" & txtCustName.Text & "'," &
           "'" & txtMobileNo.Text & "'," &
           "'" & txtLoanAmnt.Text & "'," &
           "'" & txtExpOfr.Text & "'," &
           "'" & CboProduct.Text & "'," &
           "'" & CboSubProduct.Text & "'," &
           "'" & CboCPA.Text & "'," &
           "'" & txtProfile.Text & "'," &
           "'" & txtBank.Text & "'," &
           "'" & txtSdValue.Text & "'," &
           "'" & txtSize.Text & "'," &
           "'" & txtPropertyNo.Text & "'," &
           "'" & txtPropertyAdd.Text & "'," &
           "'" & txtOthrPropertyAdd.Text & "'," &
           "'" & txtRef.Text & "'," &
           "'" & CboLeadStage.Text & "'," &
           "'" & txtRemarks.Text & "'," &
           "'" & SessionEmpId & "'," &
           "GETDATE())"

            ExecuteQuery(ssql)

            MessageBox.Show("Record Saved Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try

            ssql = "SELECT LeadMisID,LeadDate,LeadStage as DiscussStage,CustName,MobileNo,LoanAmount,ExpOfferToCm,Product,SubProduct,CPA,
                        PROFILE,BANK,SdVALUE,SIZE,PropertyNo,PropertyAddress,OtherPropertyAddress,REFERENCE,REMARKS,EntBy,EntDt,ModBy,ModDt 
                        FROM leadmis WITH(Nolock) where IsDelete='N' and LeadStage not in('LOGIN')"
            dt = GetData(ssql)

            dgv.DataSource = dt

            ' Add Checkbox Column
            If dgv.Columns("SelectRow") Is Nothing Then

                Dim chk As New DataGridViewCheckBoxColumn

                chk.Name = "SelectRow"
                chk.HeaderText = "Select"

                dgv.Columns.Insert(0, chk)

            End If

            ' DiscLogin Dropdown
            If TypeOf dgv.Columns("DiscussStage") IsNot DataGridViewComboBoxColumn Then

                Dim colIndex As Integer = dgv.Columns("DiscussStage").Index

                dgv.Columns.Remove("DiscussStage")

                Dim CboLeadStage As New DataGridViewComboBoxColumn()

                CboLeadStage.Name = "DiscussStage"
                CboLeadStage.HeaderText = "DiscussStage"
                CboLeadStage.DataPropertyName = "DiscussStage"

                ' Get data from Master Table
                ssql = "select LeadStage from LeadStageMst where IsActive='Y'"

                Dim dtDiscLogin As DataTable = GetData(ssql)

                For Each row As DataRow In dtDiscLogin.Rows
                    CboLeadStage.Items.Add(row("LeadStage").ToString())
                Next

                dgv.Columns.Insert(colIndex, CboLeadStage)

            End If

            ' All Columns ReadOnly
            For Each col As DataGridViewColumn In dgv.Columns
                col.ReadOnly = True
            Next

            ' Checkbox Editable
            dgv.Columns("SelectRow").ReadOnly = False

            dgv.EditMode = DataGridViewEditMode.EditOnEnter

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            For Each row As DataGridViewRow In dgv.Rows

                If Convert.ToBoolean(row.Cells("SelectRow").Value) = True Then

                    Dim LeadID As Integer = Convert.ToInt32(row.Cells("LeadMisID").Value)

                    ssql = "UPDATE leadmis Set IsDelete='Y' WHERE LeadMisID=" & LeadID

                    ExecuteQuery(ssql)

                End If

            Next

            MessageBox.Show("Record Deleted Successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            ' If Not Required() Then Return

            For Each row As DataGridViewRow In dgv.Rows

                If row.Cells("SelectRow").Value IsNot Nothing AndAlso
               CBool(row.Cells("SelectRow").Value) = True Then

                    ssql = "UPDATE leadmis SET " &
                               "LeadDate='" & GetCellValue(row, "LeadDate") & "'," &
                               "LeadStage='" & GetCellValue(row, "DiscussStage") & "'," &
                               "CustName='" & GetCellValue(row, "CustName") & "'," &
                               "MobileNo='" & GetCellValue(row, "MobileNo") & "'," &
                               "LoanAmount='" & GetCellValue(row, "LoanAmount") & "'," &
                               "ExpOfferToCm='" & GetCellValue(row, "ExpOfferToCm") & "'," &
                               "Product='" & GetCellValue(row, "Product") & "'," &
                               "SubProduct='" & GetCellValue(row, "SubProduct") & "'," &
                               "CPA='" & GetCellValue(row, "CPA") & "'," &
                               "PROFILE='" & GetCellValue(row, "PROFILE") & "'," &
                               "BANK='" & GetCellValue(row, "BANK") & "'," &
                               "SdVALUE='" & GetCellValue(row, "SdVALUE") & "'," &
                               "SIZE='" & GetCellValue(row, "SIZE") & "'," &
                               "PropertyNo='" & GetCellValue(row, "PropertyNo") & "'," &
                               "PropertyAddress='" & GetCellValue(row, "PropertyAddress") & "'," &
                               "OtherPropertyAddress='" & GetCellValue(row, "OtherPropertyAddress") & "'," &
                               "REFERENCE='" & GetCellValue(row, "REFERENCE") & "'," &
                               "REMARKS='" & GetCellValue(row, "REMARKS") & "'," &
                               "ModBy='" & SessionEmpId & "'," &
                               "ModDt=GETDATE() " &
                               "WHERE LeadMisID='" & GetCellValue(row, "LeadMisID") & "'"


                    ExecuteQuery(ssql)

                    If UCase(GetCellValue(row, "DiscussStage")) = "LOGIN" Then

                        ssql = "IF NOT EXISTS (SELECT 1 FROM loginmis WHERE LeadID='" &
                           GetCellValue(row, "LeadMisID") & "') " &
                           "INSERT INTO loginmis " &
                           "(LeadID) " &
                           "VALUES (" &
                           "'" & GetCellValue(row, "LeadMisID") & "')"

                        ExecuteQuery(ssql)

                    End If

                End If

            Next

            MessageBox.Show("Record Updated Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgv_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        If e.ColumnIndex = dgv.Columns("SelectRow").Index Then

            For Each row As DataGridViewRow In dgv.Rows

                Dim IsChecked As Boolean = False

                If row.Cells("SelectRow").Value IsNot Nothing Then
                    IsChecked = CBool(row.Cells("SelectRow").Value)
                End If

                For Each col As DataGridViewColumn In dgv.Columns

                    If col.Name <> "SelectRow" AndAlso col.Name <> "LeadMisID" Then
                        row.Cells(col.Index).ReadOnly = Not IsChecked
                    End If

                Next

            Next

        End If
    End Sub

    Private Sub dgv_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgv.CurrentCellDirtyStateChanged
        If dgv.IsCurrentCellDirty Then
            dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Function Required() As Boolean

        If Not RequiredField(dtpLeadDate, "Lead Date") Then Return False
        If Not RequiredField(txtCustName, "Customer Name") Then Return False
        If Not RequiredField(txtMobileNo, "Mobile No.") Then Return False
        If Not RequiredField(txtLoanAmnt, "Loan Amount") Then Return False
        If Not RequiredField(CboProduct, "Product") Then Return False
        If Not RequiredField(CboSubProduct, "Sub Product") Then Return False
        If Not RequiredField(txtPropertyNo, "Property No") Then Return False
        If Not RequiredField(txtPropertyAdd, "Property Address") Then Return False
        If Not RequiredField(txtRef, "Reference") Then Return False

        Return True

    End Function

End Class