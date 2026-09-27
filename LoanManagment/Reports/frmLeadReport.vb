Public Class frmLeadReport

    Private Sub frmLeadReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = DateTime.Today
        dtpTo.Value = DateTime.Today
        dtpFrom.Checked = True
        dtpTo.Checked = True

        CenterLoader()
        LoadDiscLoginFilter()
        LoadLeadReport()
    End Sub

    Private Sub frmLeadReport_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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
    Private Sub LoadDiscLoginFilter()
        Try
            cmbDiscLogin.Items.Clear()
            cmbDiscLogin.Items.Add("All")

            ssql = "SELECT DISTINCT DiscLogin FROM LeadMis " &
                   "WHERE IsDelete <> 'Y' AND DiscLogin IS NOT NULL AND DiscLogin <> '' " &
                   "ORDER BY DiscLogin"

            dt = GetData(ssql)

            For Each row As DataRow In dt.Rows
                cmbDiscLogin.Items.Add(row("DiscLogin").ToString())
            Next

            cmbDiscLogin.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Filter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadLeadReport()
        Try
            ShowLoader("Fetching Lead Report...")

            ssql = "SELECT " &
                   "LeadDate AS [Lead Date], " &
                   "DiscLogin AS [Disc/Login], " &
                   "CustName AS [Customer Name], " &
                   "MobileNo AS [Mobile No], " &
                   "LoanAmount AS [Loan Amount], " &
                   "ExpOfferToCm AS [Exp Offer To CM], " &
                   "Stage, " &
                   "Product, " &
                   "SubProduct AS [Sub Product], " &
                   "CPA, " &
                   "PROFILE, " &
                   "BANK, " &
                   "SdVALUE AS [SD Value], " &
                   "SIZE, " &
                   "PropertyNo AS [Property No], " &
                   "PropertyAddress AS [Property Address], " &
                   "REFERENCE, " &
                   "LeadStage AS [Lead Stage], " &
                   "REMARKS " &
                   "FROM LeadMis " &
                   "WHERE IsDelete <> 'Y' "

            ' Date From
            If dtpFrom.Checked Then
                ssql &= "AND CAST(LeadDate AS DATE) >= '" & dtpFrom.Value.ToString("yyyy-MM-dd") & "' "
            End If

            ' Date To
            If dtpTo.Checked Then
                ssql &= "AND CAST(LeadDate AS DATE) <= '" & dtpTo.Value.ToString("yyyy-MM-dd") & "' "
            End If

            ' Disc / Login
            If cmbDiscLogin.SelectedItem IsNot Nothing AndAlso cmbDiscLogin.SelectedItem.ToString() <> "All" Then
                ssql &= "AND DiscLogin = '" & cmbDiscLogin.SelectedItem.ToString().Replace("'", "''") & "' "
            End If

            ssql &= "ORDER BY LeadDate DESC"

            dt = GetData(ssql)

            dgvLeadReport.DataSource = Nothing
            dgvLeadReport.DataSource = dt

            ' Optional: Auto-size columns for better look
            dgvLeadReport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)

            lblRecordCount.Text = dt.Rows.Count.ToString() & " record(s) found"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            HideLoader()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If dtpFrom.Checked AndAlso dtpTo.Checked AndAlso dtpFrom.Value.Date > dtpTo.Value.Date Then
            MessageBox.Show("'Date From' cannot be greater than 'Date To'.",
                            "Invalid Date Range",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        LoadLeadReport()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        If dgvLeadReport.Rows.Count = 0 Then
            MessageBox.Show("No data available to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            ShowLoader("Exporting to Excel...")
            ExportDgvToExcel(dgvLeadReport, "Lead Report")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            HideLoader()
        End Try
    End Sub

End Class