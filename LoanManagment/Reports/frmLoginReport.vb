Public Class frmLoginReport

    Private Sub frmLoginReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = DateTime.Today
        dtpTo.Value = DateTime.Today
        dtpFrom.Checked = True
        dtpTo.Checked = True
        CenterLoader()
        LoadReportType()
        LoadStageFilter()
        LoadLoginReport()
    End Sub

    Private Sub frmLoginReport_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterLoader()
    End Sub

    Private Sub CenterLoader()
        picLoader.Location = New Point((pnlLoader.Width - picLoader.Width) \ 2,
                                       (pnlLoader.Height - picLoader.Height) \ 2 - 25)
        lblLoader.Location = New Point((pnlLoader.Width - lblLoader.Width) \ 2,
                                       picLoader.Bottom + 12)
    End Sub

    Private Sub ShowLoader(Optional message As String = "Loading data, please wait...")
        lblLoader.Text = message
        pnlLoader.BringToFront()
        pnlLoader.Visible = True
        Application.DoEvents()
    End Sub

    Private Sub HideLoader()
        pnlLoader.Visible = False
    End Sub

    '==============================================================
    ' LOAD DROPDOWNS
    '==============================================================
    Private Sub LoadReportType()
        cmbReportType.Items.Clear()
        cmbReportType.Items.Add("Login Detail")
        cmbReportType.Items.Add("HO-PART Summary")
        cmbReportType.Items.Add("Bank Wise")
        cmbReportType.Items.Add("Stage Wise")
        cmbReportType.Items.Add("Expense Summary")
        cmbReportType.SelectedIndex = 0
    End Sub

    Private Sub LoadStageFilter()
        Try
            cmbStage.Items.Clear()
            ssql = "SELECT StageType FROM StageMst WITH (NOLOCK) WHERE IsActive='Y' ORDER BY StageType"
            Dim dtStg As DataTable = GetData(ssql)
            cmbStage.Items.Add("All")
            For Each row As DataRow In dtStg.Rows
                cmbStage.Items.Add(row("StageType").ToString())
            Next
            cmbStage.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Filter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '==============================================================
    ' MAIN LOAD – SWITCH BY REPORT TYPE
    '==============================================================
    Private Sub LoadLoginReport()
        Try
            ShowLoader("Fetching report...")

            Dim reportType As String = If(cmbReportType.SelectedItem IsNot Nothing,
                                          cmbReportType.SelectedItem.ToString(),
                                          "Login Detail")

            Select Case reportType
                Case "Login Detail"
                    LoadLoginDetail()
                    lblGridTitle.Text = "LOGIN DETAIL RECORDS"

                Case "HO-PART Summary"
                    LoadHOPartSummary()
                    lblGridTitle.Text = "HO-PART SUMMARY"

                Case "Bank Wise"
                    LoadBankWise()
                    lblGridTitle.Text = "BANK WISE SUMMARY"

                Case "Stage Wise"
                    LoadStageWise()
                    lblGridTitle.Text = "STAGE WISE SUMMARY"

                Case "Expense Summary"
                    LoadExpenseSummary()
                    lblGridTitle.Text = "EXPENSE SUMMARY"

                Case Else
                    LoadLoginDetail()
                    lblGridTitle.Text = "LOGIN RECORDS"
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            HideLoader()
        End Try
    End Sub

    '==============================================================
    ' 1. LOGIN DETAIL
    '==============================================================
    Private Sub LoadLoginDetail()
        ssql = "SELECT " &
               "lgn.LoginDate AS [Login Date], " &
               "ld.CustName AS [Customer Name], " &
               "ld.MobileNo AS [Mobile No], " &
               "lgn.ApplicationNo AS [Application No], " &
               "lgn.LoanNo AS [Loan No], " &
               "ld.LoanAmount AS [Original Loan Amount], " &
               "lgn.LoanAmount AS [Approved Amount], " &
               "lgn.Stage, " &
               "lgn.BANK AS [Bank], " &
               "lgn.Code, " &
               "lgn.CPA, " &
               "lgn.LLPSNo AS [LLPS No], " &
               "lgn.BranchSoleID AS [Branch Sole], " &
               "lgn.DastavageDate AS [Dastavage Date], " &
               "lgn.RMDate AS [RM Date], " &
               "lgn.HODate AS [HO Date], " &
               "ld.PropertyNo AS [Property No], " &
               "ld.PropertyAddress AS [Property Address], " &
               "ld.ExpOfferToCm AS [Exp Offer To CM], " &
               "ISNULL((SELECT SUM(CAST(l2.LoanAmount AS DECIMAL(18,2))) " &
               "        FROM LoginMIS l2 WITH (NOLOCK) " &
               "        WHERE l2.LeadID = ld.LeadMisID " &
               "          AND UPPER(LTRIM(RTRIM(l2.Stage))) = 'HO-PART'), 0) AS [Total Approved (HO-PART)], " &
               "ISNULL((SELECT SUM(CAST(e.ExpOfrValue AS DECIMAL(18,2))) " &
               "        FROM ExpOfferTypeValue e WITH (NOLOCK) " &
               "        WHERE e.ExpOfrLeadID = ld.LeadMisID), 0) AS [Total Expense] " &
               "FROM LoginMIS lgn WITH (NOLOCK) " &
               "INNER JOIN LeadMIS ld WITH (NOLOCK) ON lgn.LeadID = ld.LeadMisID " &
               "WHERE 1=1 "

        ApplyCommonFilters("lgn.LoginDate", "ld.CustName", "lgn.Stage")
        ssql &= "ORDER BY lgn.LoginDate DESC, ld.CustName"
        BindGrid()
    End Sub

    '==============================================================
    ' 2. HO-PART SUMMARY
    '==============================================================
    Private Sub LoadHOPartSummary()
        ssql = "SELECT " &
               "ld.CustName AS [Customer Name], " &
               "ld.MobileNo AS [Mobile No], " &
               "ld.LoanAmount AS [Original Loan Amount], " &
               "COUNT(*) AS [No of Parts], " &
               "SUM(CAST(lgn.LoanAmount AS DECIMAL(18,2))) AS [Total Approved], " &
               "MIN(lgn.LoginDate) AS [First Approval Date], " &
               "MAX(lgn.LoginDate) AS [Last Approval Date], " &
               "ld.PropertyNo AS [Property No], " &
               "ld.PropertyAddress AS [Property Address] " &
               "FROM LoginMIS lgn WITH (NOLOCK) " &
               "INNER JOIN LeadMIS ld WITH (NOLOCK) ON lgn.LeadID = ld.LeadMisID " &
               "WHERE UPPER(LTRIM(RTRIM(lgn.Stage))) = 'HO-PART' "

        ApplyCommonFilters("lgn.LoginDate", "ld.CustName", Nothing)
        ssql &= "GROUP BY ld.CustName, ld.MobileNo, ld.LoanAmount, ld.PropertyNo, ld.PropertyAddress "
        ssql &= "ORDER BY ld.CustName"
        BindGrid()
    End Sub

    '==============================================================
    ' 3. BANK WISE
    '==============================================================
    Private Sub LoadBankWise()
        ssql = "SELECT " &
               "ISNULL(lgn.BANK, 'N/A') AS [Bank], " &
               "COUNT(*) AS [Total Logins], " &
               "SUM(CAST(lgn.LoanAmount AS DECIMAL(18,2))) AS [Total Approved Amount], " &
               "SUM(CASE WHEN UPPER(LTRIM(RTRIM(lgn.Stage))) = 'HO-PART' THEN 1 ELSE 0 END) AS [HO-PART Count] " &
               "FROM LoginMIS lgn WITH (NOLOCK) " &
               "INNER JOIN LeadMIS ld WITH (NOLOCK) ON lgn.LeadID = ld.LeadMisID " &
               "WHERE 1=1 "

        ApplyCommonFilters("lgn.LoginDate", "ld.CustName", "lgn.Stage")
        ssql &= "GROUP BY lgn.BANK "
        ssql &= "ORDER BY [Total Logins] DESC"
        BindGrid()
    End Sub

    '==============================================================
    ' 4. STAGE WISE
    '==============================================================
    Private Sub LoadStageWise()
        ssql = "SELECT " &
               "ISNULL(lgn.Stage, 'N/A') AS [Stage], " &
               "COUNT(*) AS [Total Logins], " &
               "SUM(CAST(lgn.LoanAmount AS DECIMAL(18,2))) AS [Total Approved Amount] " &
               "FROM LoginMIS lgn WITH (NOLOCK) " &
               "INNER JOIN LeadMIS ld WITH (NOLOCK) ON lgn.LeadID = ld.LeadMisID " &
               "WHERE 1=1 "

        ApplyCommonFilters("lgn.LoginDate", "ld.CustName", "lgn.Stage")
        ssql &= "GROUP BY lgn.Stage "
        ssql &= "ORDER BY [Total Logins] DESC"
        BindGrid()
    End Sub

    '==============================================================
    ' 5. EXPENSE SUMMARY
    '==============================================================
    Private Sub LoadExpenseSummary()
        ssql = "SELECT " &
               "ld.CustName AS [Customer Name], " &
               "ld.MobileNo AS [Mobile No], " &
               "ld.LoanAmount AS [Original Loan Amount], " &
               "ISNULL(SUM(CAST(e.ExpOfrValue AS DECIMAL(18,2))), 0) AS [Total Expense], " &
               "COUNT(e.ExpOfrID) AS [Expense Entries], " &
               "ld.PropertyNo AS [Property No], " &
               "ld.PropertyAddress AS [Property Address] " &
               "FROM LeadMIS ld WITH (NOLOCK) " &
               "INNER JOIN LoginMIS lgn WITH (NOLOCK) ON lgn.LeadID = ld.LeadMisID " &
               "LEFT JOIN ExpOfferTypeValue e WITH (NOLOCK) ON e.ExpOfrLeadID = ld.LeadMisID " &
               "WHERE 1=1 "

        ApplyCommonFilters("lgn.LoginDate", "ld.CustName", "lgn.Stage")
        ssql &= "GROUP BY ld.CustName, ld.MobileNo, ld.LoanAmount, ld.PropertyNo, ld.PropertyAddress "
        ssql &= "ORDER BY [Total Expense] DESC"
        BindGrid()
    End Sub

    '==============================================================
    ' COMMON FILTERS
    '==============================================================
    Private Sub ApplyCommonFilters(dateColumn As String, custColumn As String, stageColumn As String)
        If dtpFrom.Checked Then
            ssql &= "AND CAST(" & dateColumn & " AS DATE) >= '" & dtpFrom.Value.ToString("yyyy-MM-dd") & "' "
        End If

        If dtpTo.Checked Then
            ssql &= "AND CAST(" & dateColumn & " AS DATE) <= '" & dtpTo.Value.ToString("yyyy-MM-dd") & "' "
        End If

        If txtCustName.Text.Trim() <> "" Then
            ssql &= "AND " & custColumn & " LIKE '%" & txtCustName.Text.Trim().Replace("'", "''") & "%' "
        End If

        If stageColumn IsNot Nothing AndAlso cmbStage.SelectedItem IsNot Nothing AndAlso cmbStage.SelectedItem.ToString() <> "All" Then
            ssql &= "AND " & stageColumn & " = '" & cmbStage.SelectedItem.ToString().Replace("'", "''") & "' "
        End If
    End Sub

    Private Sub BindGrid()
        dt = GetData(ssql)
        dgvLoginReport.DataSource = Nothing
        dgvLoginReport.DataSource = dt
        dgvLoginReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
        lblRecordCount.Text = dt.Rows.Count.ToString() & " record(s) found"
    End Sub

    '==============================================================
    ' BUTTONS
    '==============================================================
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If dtpFrom.Checked AndAlso dtpTo.Checked AndAlso dtpFrom.Value.Date > dtpTo.Value.Date Then
            MessageBox.Show("'Date From' cannot be greater than 'Date To'.",
                            "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        LoadLoginReport()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dtpFrom.Value = DateTime.Today
        dtpTo.Value = DateTime.Today
        dtpFrom.Checked = True
        dtpTo.Checked = True
        txtCustName.Clear()

        If cmbStage.Items.Count > 0 Then cmbStage.SelectedIndex = 0
        If cmbReportType.Items.Count > 0 Then cmbReportType.SelectedIndex = 0

        dgvLoginReport.DataSource = Nothing
        lblRecordCount.Text = "0 record(s) found"
        lblGridTitle.Text = "LOGIN RECORDS"
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvLoginReport.Rows.Count = 0 Then
            MessageBox.Show("No data available to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            ShowLoader("Exporting to Excel...")
            Dim reportName As String = If(cmbReportType.SelectedItem IsNot Nothing,
                                          cmbReportType.SelectedItem.ToString(),
                                          "Login Report")
            ExportDgvToExcel(dgvLoginReport, reportName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            HideLoader()
        End Try
    End Sub

End Class