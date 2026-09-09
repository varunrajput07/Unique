Public Class frmLoginMIS
    Dim dtMobile As DataTable
    Private Sub frmLoginMIS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ssql = "select StageType from StageMst where IsActive='Y'"
        FillCombo(txtStage, GetData(ssql), "StageType")

        ssql = "select BankName from BankMst where IsActive='Y'"
        FillCombo(txtBank, GetData(ssql), "BankName")

        ssql = "select CodeName from CodeMst where IsActive='Y'"
        FillCombo(CboCode, GetData(ssql), "CodeName")

        ssql = "select ExpOfferType from ExpOfferMst where IsActive='Y'"
        FillCombo(txtExpOfr, GetData(ssql), "ExpOfferType")

        ssql = "select CPAName from CPAMst where IsActive='Y'"
        FillCombo(CboCPA, GetData(ssql), "CPAName")

        ssql = "select CustName from LeadMIS where LeadStage='LOGIN'"
        dtMobile = GetData(ssql)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try

            For Each row As DataGridViewRow In dgv.Rows

                If Convert.ToBoolean(row.Cells("SelectRow").Value) = True Then

                    Dim LoginID As Integer = Convert.ToInt32(row.Cells("LoginMisID").Value)

                    ssql = "DELETE FROM LoginMIS WHERE LoginMisID=" & LoginID

                    ExecuteQuery(ssql)

                End If

            Next

            MessageBox.Show("Record Deleted Successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtBank.SelectedIndexChanged
        If txtBank.Text = "BOB" Then
            txtLLPs.Visible = True
            txtBranchSole.Visible = True
            Label8.Visible = True
            Label7.Visible = True
        Else
            txtLLPs.Visible = False
            txtBranchSole.Visible = False
            Label8.Visible = False
            Label7.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If Not Required() Then Return

            ssql = "SELECT * FROM LeadMIS " &
               "WHERE CustName='" & txtCustName.Text.Trim().Replace("'", "''") & "' " &
               "AND PropertyNo='" & CboPropertyNo.Text.Trim().Replace("'", "''") & "' " &
               "AND PropertyAddress='" & txtPropertyAdd.Text.Trim().Replace("'", "''") & "'"

            dt = GetData(ssql)


            If dt.Rows.Count = 0 Then

                MessageBox.Show("Customer and Property Address not found in Login MIS.",
                            "Record Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                Return

            End If


            '====================================================
            ' GET LOGIN MIS PRIMARY KEY
            '====================================================

            Dim LeadID As Integer = Convert.ToInt32(dt.Rows(0)("LeadMisID"))

            '====================================================
            ' 3. UPDATE LOGINMIS USING LEADID
            '====================================================

            ssql = "UPDATE Loginmis SET " &
           "LoginDate='" & Format(dtpLeadDate.Value, "yyyy-MM-dd") & "'," &
           "ApplicationNo='" & txtAppNo.Text & "'," &
           "LoanNo='" & txtLoanNo.Text & "'," &
           "CustName='" & txtCustName.Text & "'," &
           "MobileNo='" & txtMobileNo.Text & "'," &
           "Stage='" & txtStage.Text & "'," &
           "BANK='" & txtBank.Text & "'," &
           "LLPSNo='" & txtLLPs.Text & "'," &
           "LoanAmount='" & txtLoanAmnt.Text & "'," &
           "CPA='" & CboCPA.Text & "'," &
           "BranchSoleID='" & txtBranchSole.Text & "'," &
           "Code='" & CboCode.Text & "'," &
           "DastavageDate='" & Format(dtpDasatavgeDate.Value, "yyyy-MM-dd") & "'," &
           "RMDate='" & Format(dtpRMDate.Value, "yyyy-MM-dd") & "'," &
           "HODate='" & Format(dtpHODate.Value, "yyyy-MM-dd") & "'," &
           "EntBy='" & SessionEmpId & "'," &
           "EntDt=GETDATE() " &
           "WHERE LeadID=" & LeadID

            ExecuteQuery(ssql)


            MessageBox.Show("Login MIS record Added successfully.",
                    "Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            For Each row As DataGridViewRow In dgv.Rows

                If row.Cells("SelectRow").Value IsNot Nothing AndAlso
               CBool(row.Cells("SelectRow").Value) = True Then

                    ssql = "UPDATE leadmis SET " &
                               "LeadDate='" & GetCellValue(row, "LeadDate") & "'," &
                               "CustName='" & GetCellValue(row, "CustName") & "'," &
                               "MobileNo='" & GetCellValue(row, "MobileNo") & "'," &
                               "ApplicationNo='" & GetCellValue(row, "ApplicationNo") & "'," &
                               "LoanNo='" & GetCellValue(row, "LoanNo") & "'," &
                               "Stage='" & GetCellValue(row, "Stage") & "'," &
                               "BANK='" & GetCellValue(row, "BANK") & "'," &
                               "LLPSNo='" & GetCellValue(row, "LLPSNo") & "'," &
                               "BranchSoleID='" & GetCellValue(row, "BranchSoleID") & "'," &
                               "Code='" & GetCellValue(row, "Code") & "'," &
                               "DastavageDate='" & GetCellValue(row, "DastavageDate") & "'," &
                               "RMDate='" & GetCellValue(row, "RMDate") & "'," &
                               "HODate='" & GetCellValue(row, "HODate") & "'," &
                               "ModBy='" & SessionEmpId & "'," &
                               "ModDt=GETDATE() " &
                               "WHERE LoginMisID='" & GetCellValue(row, "LoginMisID") & "'"

                    ExecuteQuery(ssql)

                End If

            Next

            MessageBox.Show("Record Updated Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try

            ssql = "select LoginMisID,LoginDate,ApplicationNo,LoanNo,CustName,MobileNo,Stage,BANK,LLPSNo,BranchSoleID,Code,DastavageDate,RMDate,HODate,LoanAmount,sum(ExpOfrValue)ExpOffer,CPA
                        from LoginMIS with(nolock)
                        join ExpOfferTypeValue with(nolock) on ExpOfrLeadID=LeadID                        
                        group by LoginMisID,LoginDate,ApplicationNo,LoanNo,CustName,MobileNo,Stage,BANK,LLPSNo,BranchSoleID,Code,DastavageDate,RMDate,HODate,LoanAmount,ExpOffer,CPA"

            dt = GetData(ssql)

            dgv.DataSource = dt

            ' Add Checkbox Column
            If dgv.Columns("SelectRow") Is Nothing Then

                Dim chk As New DataGridViewCheckBoxColumn

                chk.Name = "SelectRow"
                chk.HeaderText = "Select"

                dgv.Columns.Insert(0, chk)

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

    Private Function Required() As Boolean

        If Not RequiredField(dtpLeadDate, "Lead Date") Then Return False
        If Not RequiredField(txtCustName, "Customer Name") Then Return False
        If Not RequiredField(txtMobileNo, "Mobile No.") Then Return False
        If Not RequiredField(txtLoanAmnt, "Loan Amount") Then Return False
        If Not RequiredField(txtAppNo, "Application No.") Then Return False
        If Not RequiredField(txtLoanNo, "Loan No") Then Return False
        If Not RequiredField(txtStage, "Stage") Then Return False
        If Not RequiredField(CboCode, "Code") Then Return False
        If Not RequiredField(txtExpOfr, "Exp. Offer") Then Return False
        If Not RequiredField(CboCPA, "CPA") Then Return False
        If Not RequiredField(txtBank, "Bank") Then Return False

        If txtBank.Text.Trim().ToUpper() = "BOB" Then

            If Not RequiredField(txtLLPs, "LLPs") Then Return False
            If Not RequiredField(txtBranchSole, "Branch Sole") Then Return False

        End If

        Return True

    End Function

    Private Sub btnExpOfr_Click(sender As Object, e As EventArgs) Handles btnExpOfr.Click
        Try

            'Check Customer Name
            If String.IsNullOrWhiteSpace(txtCustName.Text) Then

                MessageBox.Show("Please enter Customer Name.",
                            "Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                txtCustName.Focus()
                Return

            End If


            'Check Property Address
            If String.IsNullOrWhiteSpace(txtPropertyAdd.Text) Then

                MessageBox.Show("Please select Property Address.",
                            "Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                txtPropertyAdd.Focus()
                Return

            End If


            'Check Expense Offer Type
            If String.IsNullOrWhiteSpace(txtExpOfr.Text) Then

                MessageBox.Show("Please enter Expense Offer Type.",
                            "Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                txtExpOfr.Focus()
                Return

            End If


            'Check Expense Offer Value
            If String.IsNullOrWhiteSpace(txtExpOfrValue.Text) Then

                MessageBox.Show("Please enter Expense Offer Value.",
                            "Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                txtExpOfrValue.Focus()
                Return

            End If


            '====================================================
            ' FIND LOGIN MIS ID USING CUSTOMER + PROPERTY
            '====================================================

            ssql = "SELECT * FROM leadmis " &
               "WHERE CustName='" & txtCustName.Text.Trim() & "' " &
               "AND PropertyAddress='" & txtPropertyAdd.Text.Trim() & "'"

            dt = GetData(ssql)


            If dt.Rows.Count = 0 Then

                MessageBox.Show("Customer and Property Address not found in Login MIS.",
                            "Record Not Found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                Return

            End If

            ' GET LOGIN MIS PRIMARY KEY

            Dim LeadID As Integer = Convert.ToInt32(dt.Rows(0)("LeadMisID"))

            ' INSERT EXPENSE OFFER

            ssql = "INSERT INTO ExpOfferTypeValue " &
               "(ExpOfrType, ExpOfrValue, ExpOfrLeadID, EntBy, EntDt) VALUES (" &
               "'" & txtExpOfr.Text.Trim() & "'," &
               "'" & txtExpOfrValue.Text.Trim() & "'," &
               LeadID & "," &
               "'" & SessionEmpId & "'," &
               "GETDATE())"

            ExecuteQuery(ssql)


            MessageBox.Show("Expense offer saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)


        Catch ex As Exception

            MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtCustName_Leave(sender As Object, e As EventArgs) Handles txtCustName.Leave
        If txtCustName.Text.Trim() <> "" Then

            ssql = "SELECT * FROM LeadMIS " &
               "WHERE LeadStage='LOGIN' AND CustName='" & txtCustName.Text.Trim() & "'"

            dt = GetData(ssql)
            If dt.Rows.Count > 0 Then
                txtPropertyAdd.Items.Clear()
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("PropertyAddress")) Then
                        Dim propertyAddress As String = row("PropertyAddress").ToString()
                        If propertyAddress <> "" Then
                            txtPropertyAdd.Items.Add(propertyAddress)
                        End If
                    End If
                Next

                If txtPropertyAdd.Items.Count > 0 Then
                    txtPropertyAdd.SelectedIndex = 0
                End If

            Else

                txtPropertyAdd.Items.Clear()
                txtPropertyAdd.Text = ""

            End If

        Else
            txtPropertyAdd.Items.Clear()
            txtPropertyAdd.Text = ""
        End If
    End Sub

    Private Sub txtCustName_TextChanged(sender As Object, e As EventArgs) Handles txtCustName.TextChanged
        lstCustName.Items.Clear()

        Dim searchText As String = txtCustName.Text.Trim()

        If searchText = "" Then
            lstCustName.Visible = False
            Return
        End If

        For Each row As DataRow In dtMobile.Rows

            Dim custName As String = row("CustName").ToString()

            'Contains = middle word/letter matching
            If custName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 Then
                lstCustName.Items.Add(custName)
            End If

        Next

        If lstCustName.Items.Count > 0 Then
            lstCustName.Visible = True
        Else
            lstCustName.Visible = False
        End If
    End Sub

    Private Sub lstCustName_Click(sender As Object, e As EventArgs) Handles lstCustName.Click
        If lstCustName.SelectedItem IsNot Nothing Then
            txtCustName.Text = lstCustName.SelectedItem.ToString()
            txtCustName.SelectionStart = txtCustName.Text.Length
            lstCustName.Visible = False
        End If
    End Sub

End Class