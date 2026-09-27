Imports System.Runtime.InteropServices
Imports Microsoft.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Module GlobalVariable
    Public ssql As String = ""
    Public dt As New DataTable()

    Public SessionEmpId As String = ""
    Public SessionUserName As String = ""
    Public SessionEmpName As String = ""
    Public SessionUsrTyp As String = ""

    Private connectionString As String =
    "Data Source=LAPTOP-25S76HD1\SQLEXPRESS01;Initial Catalog=Loan;Integrated Security=True;TrustServerCertificate=True"
    '"Server=192.168.1.20,1433;Database=Unique;User Id=Unique;Password=Unique@123;TrustServerCertificate=True;"
    ' "Server=192.168.1.20,1433;Database=Unique;User Id=Unique;Password=Unique@123;Encrypt=True;TrustServerCertificate=True;"

    Public Function GetConnection() As SqlConnection

        Dim con As New SqlConnection(connectionString)

        Return con

    End Function

    Public Sub ExecuteQuery(query As String)

        Using con As SqlConnection = GetConnection()

            Using cmd As New SqlCommand(query, con)

                con.Open()
                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Function GetData(query As String) As DataTable

        Dim dt As New DataTable()

        Using con As SqlConnection = GetConnection()

            Using da As New SqlDataAdapter(query, con)

                da.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function GetCellValue(row As DataGridViewRow, ColumnName As String) As String

        If row.Cells(ColumnName).Value Is Nothing OrElse
           IsDBNull(row.Cells(ColumnName).Value) Then

            Return ""

        End If

        Return row.Cells(ColumnName).Value.ToString().Replace("'", "''")

    End Function

    Public Sub FillCombo(ByVal cbo As ComboBox, ByVal dt As DataTable, ByVal ColumnName As String)

        cbo.DataSource = Nothing
        cbo.DataSource = dt
        cbo.DisplayMember = ColumnName
        cbo.ValueMember = ColumnName
        cbo.SelectedIndex = -1

    End Sub

    Public Function RequiredField(ctrl As Control, fieldName As String) As Boolean

        If TypeOf ctrl Is TextBox Then

            Dim txt As TextBox = DirectCast(ctrl, TextBox)

            If String.IsNullOrWhiteSpace(txt.Text) Then
                MessageBox.Show("Please enter " & fieldName & ".",
                                "Required Field",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                txt.Focus()
                Return False
            End If

        ElseIf TypeOf ctrl Is ComboBox Then

            Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)

            If cmb.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cmb.Text) Then
                MessageBox.Show("Please select " & fieldName & ".",
                                "Required Field",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                cmb.Focus()
                Return False
            End If

        ElseIf TypeOf ctrl Is DateTimePicker Then

            Dim dtp As DateTimePicker = DirectCast(ctrl, DateTimePicker)

            If dtp.ShowCheckBox AndAlso Not dtp.Checked Then
                MessageBox.Show("Please select " & fieldName & ".",
                                "Required Field",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                dtp.Focus()
                Return False
            End If

        ElseIf TypeOf ctrl Is CheckBox Then

            Dim chk As CheckBox = DirectCast(ctrl, CheckBox)

            If Not chk.Checked Then
                MessageBox.Show("Please check " & fieldName & ".",
                                "Required Field",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                chk.Focus()
                Return False
            End If

        End If

        Return True

    End Function

    Public MasterList As New Dictionary(Of String, MasterConfig)

    Public Sub InitializeMasters()

        MasterList.Clear()

        ' DOCUMENT MASTER

        MasterList.Add("Document",
            New MasterConfig With {
                .TableName = "DocumentMst",
                .IDColumn = "DocumentID",
                .NameColumn = "DocumentType",
                .ActiveColumn = "IsActive"
            })

        ' EXPENSE MODE MASTER

        MasterList.Add("Expense Mode",
            New MasterConfig With {
                .TableName = "ExpModeMst",
                .IDColumn = "ExpModeID",
                .NameColumn = "ExpMode",
                .ActiveColumn = "IsActive"
            })

        ' EXPENSE OFFER MASTER

        MasterList.Add("Expense Offer",
            New MasterConfig With {
                .TableName = "ExpOfferMst",
                .IDColumn = "ExpOfferID",
                .NameColumn = "ExpOfferType",
                .ActiveColumn = "IsActive"
            })

        ' DISC LOGIN STAGE MASTER

        MasterList.Add("Disc Login Stage",
            New MasterConfig With {
                .TableName = "DiscLoginStageMst",
                .IDColumn = "DiscLoginStageID",
                .NameColumn = "DiscLoginStage",
                .ActiveColumn = "IsActive"
            })

        ' EXPENSE OFFER MASTER

        'MasterList.Add("Expense Offer",
        '    New MasterConfig With {
        '        .TableName = "ExpOfferMst",
        '        .IDColumn = "ExpOfferID",
        '        .NameColumn = "ExpOfferType",
        '        .ActiveColumn = "IsActive"
        '    })

        ' PRODUCT MASTER

        Dim ProductMaster As New MasterConfig()

        ProductMaster.TableName = "ProductMst"
        ProductMaster.IDColumn = "ProductID"
        ProductMaster.NameColumn = "ProductType"
        ProductMaster.ActiveColumn = "IsActive"

        MasterList.Add("Product", ProductMaster)

        ' PRODUCT SUB MASTER

        Dim ProductSubMaster As New MasterConfig()

        ProductSubMaster.TableName = "ProductSubMst"
        ProductSubMaster.IDColumn = "ProductSubID"
        ProductSubMaster.NameColumn = "ProductSubType"
        ProductSubMaster.ActiveColumn = "IsActive"

        ' Parent Product Master
        ProductSubMaster.ParentTableName = "ProductMst"
        ProductSubMaster.ParentIDColumn = "ProductID"
        ProductSubMaster.ParentNameColumn = "ProductType"

        ' Foreign key in ProductSubMst
        ProductSubMaster.ForeignKeyColumn = "ProductID"

        MasterList.Add("Product Sub", ProductSubMaster)

        ' CPA MASTER

        MasterList.Add("CPA",
            New MasterConfig With {
                .TableName = "CPAMst",
                .IDColumn = "CPAID",
                .NameColumn = "CPAType",
                .ActiveColumn = "IsActive"
            })

        ' PROFILE MASTER

        MasterList.Add("Profile",
            New MasterConfig With {
                .TableName = "ProfileMst",
                .IDColumn = "ProfileID",
                .NameColumn = "ProfileType",
                .ActiveColumn = "IsActive"
            })

        ' BANK MASTER

        MasterList.Add("Bank",
            New MasterConfig With {
                .TableName = "BankMst",
                .IDColumn = "BankID",
                .NameColumn = "BankName",
                .ActiveColumn = "IsActive"
            })

        ' PROPERTY ADDRESS MASTER

        MasterList.Add("Property Address",
            New MasterConfig With {
                .TableName = "PropertyAddressMst",
                .IDColumn = "PropertyAddressID",
                .NameColumn = "PropertyAddress",
                .ActiveColumn = "IsActive"
            })

        ' CODE MASTER

        MasterList.Add("Code",
            New MasterConfig With {
                .TableName = "CodeMst",
                .IDColumn = "CodeID",
                .NameColumn = "CodeType",
                .ActiveColumn = "IsActive"
            })

        ' LEAD STAGE MASTER

        MasterList.Add("Lead Stage",
            New MasterConfig With {
                .TableName = "LeadStageMst",
                .IDColumn = "LeadStageID",
                .NameColumn = "LeadStage",
                .ActiveColumn = "IsActive"
            })

        ' PAYOUT STATUS MASTER

        MasterList.Add("Payout Status",
            New MasterConfig With {
                .TableName = "PayoutStatusMst",
                .IDColumn = "PayoutStatusID",
                .NameColumn = "PayoutStatus",
                .ActiveColumn = "IsActive"
            })

        ' PAYOUT CREDIT ACCOUNT MASTER

        MasterList.Add("Payout Credit Account",
            New MasterConfig With {
                .TableName = "PayoutCreditAccountMst",
                .IDColumn = "PayoutCreditAccountID",
                .NameColumn = "PayoutCreditAccountName",
                .ActiveColumn = "IsActive"
            })

        ' CREDIT MODE MASTER

        MasterList.Add("Credit Mode",
            New MasterConfig With {
                .TableName = "CreditModeMst",
                .IDColumn = "CreditModeID",
                .NameColumn = "CreditMode",
                .ActiveColumn = "IsActive"
            })

        ' EXPENSE PAID BY MASTER

        MasterList.Add("Expense Paid By",
            New MasterConfig With {
                .TableName = "ExpPaidByMst",
                .IDColumn = "ExpPaidByID",
                .NameColumn = "ExpPaidByName",
                .ActiveColumn = "IsActive"
            })

        ' FI RCU PD MASTER

        MasterList.Add("FI RCU PD",
            New MasterConfig With {
                .TableName = "FiRcuPdMst",
                .IDColumn = "FiRcuPdID",
                .NameColumn = "FiRcuPd",
                .ActiveColumn = "IsActive"
            })

        ' COLLECTION STATUS MASTER

        MasterList.Add("Collection Status",
            New MasterConfig With {
                .TableName = "CollectionStatusMst",
                .IDColumn = "CollectionStatusID",
                .NameColumn = "CollectionStatus",
                .ActiveColumn = "IsActive"
            })
        MasterList.Add("Stage Master",
            New MasterConfig With {
                .TableName = "StageMst",
                .IDColumn = "StageID",
                .NameColumn = "StageType",
                .ActiveColumn = "IsActive"
            })

    End Sub

    'Public Sub SetAllDatePickersToToday(parent As Control)

    '    For Each ctrl As Control In parent.Controls

    '        If TypeOf ctrl Is DateTimePicker Then

    '            Dim dtp As DateTimePicker = DirectCast(ctrl, DateTimePicker)
    '            dtp.Value = Date.Today

    '        End If

    '        If ctrl.HasChildren Then
    '            SetAllDatePickersToToday(ctrl)
    '        End If
    '    Next
    'End Sub
    'Public Sub StartGlobalDatePicker()
    '    AddHandler Application.Idle, AddressOf GlobalApplicationIdle
    'End Sub

    'Private Sub GlobalApplicationIdle(sender As Object, e As EventArgs)

    '    For Each frm As Form In Application.OpenForms

    '        If Not frm.IsDisposed Then
    '            SetAllDatePickersToToday(frm)
    '        End If
    '    Next

    'End Sub
    Public Sub ExportDgvToExcel(dgv As DataGridView, reportTitle As String)

        If dgv.Rows.Count = 0 Then
            MessageBox.Show(
                "No data available to export.",
                "Export to Excel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkbook As Excel.Workbook = Nothing
        Dim xlSheet As Excel.Worksheet = Nothing

        Try

            '------------------------------------------------
            ' ASK WHERE TO SAVE
            '------------------------------------------------
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "Excel Files|*.xlsx"
            sfd.FileName = reportTitle & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")

            If sfd.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            '------------------------------------------------
            ' CREATE EXCEL APP
            '------------------------------------------------
            xlApp = New Excel.Application()
            xlWorkbook = xlApp.Workbooks.Add()
            xlSheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)
            xlSheet.Name = "Report"

            '------------------------------------------------
            ' REPORT TITLE ROW
            '------------------------------------------------
            xlSheet.Cells(1, 1) = reportTitle
            With CType(xlSheet.Range(xlSheet.Cells(1, 1), xlSheet.Cells(1, dgv.Columns.Count)), Excel.Range)
                .Merge()
                .Font.Bold = True
                .Font.Size = 14
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            End With

            '------------------------------------------------
            ' COLUMN HEADERS (row 3)
            '------------------------------------------------
            Dim headerRow As Integer = 3
            For colIndex As Integer = 0 To dgv.Columns.Count - 1
                xlSheet.Cells(headerRow, colIndex + 1) = dgv.Columns(colIndex).HeaderText
            Next

            With CType(xlSheet.Range(
                        xlSheet.Cells(headerRow, 1),
                        xlSheet.Cells(headerRow, dgv.Columns.Count)), Excel.Range)
                .Font.Bold = True
                .Interior.Color = ColorTranslator.ToOle(Color.FromArgb(15, 23, 42))
                .Font.Color = ColorTranslator.ToOle(Color.White)
            End With

            '------------------------------------------------
            ' DATA ROWS
            '------------------------------------------------
            For rowIndex As Integer = 0 To dgv.Rows.Count - 1

                If dgv.Rows(rowIndex).IsNewRow Then Continue For

                For colIndex As Integer = 0 To dgv.Columns.Count - 1
                    Dim cellValue As Object = dgv.Rows(rowIndex).Cells(colIndex).Value
                    xlSheet.Cells(headerRow + 1 + rowIndex, colIndex + 1) = If(cellValue Is Nothing, "", cellValue.ToString())
                Next

            Next

            '------------------------------------------------
            ' AUTO-FIT COLUMNS
            '------------------------------------------------
            xlSheet.Columns.AutoFit()

            '------------------------------------------------
            ' SAVE & CLOSE
            '------------------------------------------------
            xlWorkbook.SaveAs(sfd.FileName)
            xlWorkbook.Close()
            xlApp.Quit()

            MessageBox.Show(
                "Report exported successfully to:" & Environment.NewLine & sfd.FileName,
                "Export to Excel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception

            MessageBox.Show(
                "Excel export failed: " & ex.Message,
                "Export Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            '------------------------------------------------
            ' RELEASE COM OBJECTS
            '------------------------------------------------
            If xlSheet IsNot Nothing Then Marshal.ReleaseComObject(xlSheet)
            If xlWorkbook IsNot Nothing Then Marshal.ReleaseComObject(xlWorkbook)
            If xlApp IsNot Nothing Then
                xlApp.Quit()
                Marshal.ReleaseComObject(xlApp)
            End If

        End Try

    End Sub

End Module
