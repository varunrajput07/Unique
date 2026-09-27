<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLeadReport
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelHeader = New Panel()
        lblTitle = New Label()
        PanelFilter = New Panel()
        tblFilter = New TableLayoutPanel()
        lblFrom = New Label()
        dtpFrom = New DateTimePicker()
        lblTo = New Label()
        dtpTo = New DateTimePicker()
        lblDiscLoginFilter = New Label()
        cmbDiscLogin = New ComboBox()
        pnlFilterButtons = New Panel()
        btnSearch = New Button()
        btnExportExcel = New Button()
        PanelGrid = New Panel()
        dgvLeadReport = New DataGridView()
        lblRecordCount = New Label()
        lblGridTitle = New Label()
        pnlLoader = New Panel()
        picLoader = New PictureBox()
        lblLoader = New Label()
        PanelHeader.SuspendLayout()
        PanelFilter.SuspendLayout()
        tblFilter.SuspendLayout()
        pnlFilterButtons.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(dgvLeadReport, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoader.SuspendLayout()
        CType(picLoader, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(15, 23, 42)
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(24, 0, 24, 0)
        PanelHeader.Size = New Size(1200, 56)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(24, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1152, 56)
        lblTitle.TabIndex = 0
        lblTitle.Text = "LEAD REPORT"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelFilter
        ' 
        PanelFilter.BackColor = Color.White
        PanelFilter.Controls.Add(tblFilter)
        PanelFilter.Dock = DockStyle.Top
        PanelFilter.Location = New Point(0, 56)
        PanelFilter.Name = "PanelFilter"
        PanelFilter.Padding = New Padding(20, 14, 20, 14)
        PanelFilter.Size = New Size(1200, 72)
        PanelFilter.TabIndex = 1
        ' 
        ' tblFilter
        ' 
        tblFilter.ColumnCount = 7
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 155.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 155.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tblFilter.Controls.Add(lblFrom, 0, 0)
        tblFilter.Controls.Add(dtpFrom, 1, 0)
        tblFilter.Controls.Add(lblTo, 2, 0)
        tblFilter.Controls.Add(dtpTo, 3, 0)
        tblFilter.Controls.Add(lblDiscLoginFilter, 4, 0)
        tblFilter.Controls.Add(cmbDiscLogin, 5, 0)
        tblFilter.Controls.Add(pnlFilterButtons, 6, 0)
        tblFilter.Dock = DockStyle.Fill
        tblFilter.Location = New Point(20, 14)
        tblFilter.Name = "tblFilter"
        tblFilter.RowCount = 1
        tblFilter.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tblFilter.Size = New Size(1160, 44)
        tblFilter.TabIndex = 0
        ' 
        ' lblFrom
        ' 
        lblFrom.Anchor = AnchorStyles.Left
        lblFrom.AutoSize = True
        lblFrom.Font = New Font("Segoe UI", 9.5F)
        lblFrom.ForeColor = Color.FromArgb(51, 65, 85)
        lblFrom.Location = New Point(0, 11)
        lblFrom.Margin = New Padding(0, 0, 8, 0)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(83, 21)
        lblFrom.TabIndex = 0
        lblFrom.Text = "Date From"
        lblFrom.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpFrom.Font = New Font("Segoe UI", 9.5F)
        dtpFrom.Format = DateTimePickerFormat.Short
        dtpFrom.Location = New Point(91, 7)
        dtpFrom.Margin = New Padding(0, 0, 18, 0)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.ShowCheckBox = True
        dtpFrom.Size = New Size(137, 29)
        dtpFrom.TabIndex = 1
        ' 
        ' lblTo
        ' 
        lblTo.Anchor = AnchorStyles.Left
        lblTo.AutoSize = True
        lblTo.Font = New Font("Segoe UI", 9.5F)
        lblTo.ForeColor = Color.FromArgb(51, 65, 85)
        lblTo.Location = New Point(246, 11)
        lblTo.Margin = New Padding(0, 0, 8, 0)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(61, 21)
        lblTo.TabIndex = 2
        lblTo.Text = "Date To"
        lblTo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpTo
        ' 
        dtpTo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpTo.Font = New Font("Segoe UI", 9.5F)
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(315, 7)
        dtpTo.Margin = New Padding(0, 0, 18, 0)
        dtpTo.Name = "dtpTo"
        dtpTo.ShowCheckBox = True
        dtpTo.Size = New Size(137, 29)
        dtpTo.TabIndex = 3
        ' 
        ' lblDiscLoginFilter
        ' 
        lblDiscLoginFilter.Anchor = AnchorStyles.Left
        lblDiscLoginFilter.AutoSize = True
        lblDiscLoginFilter.Font = New Font("Segoe UI", 9.5F)
        lblDiscLoginFilter.ForeColor = Color.FromArgb(51, 65, 85)
        lblDiscLoginFilter.Location = New Point(470, 11)
        lblDiscLoginFilter.Margin = New Padding(0, 0, 8, 0)
        lblDiscLoginFilter.Name = "lblDiscLoginFilter"
        lblDiscLoginFilter.Size = New Size(92, 21)
        lblDiscLoginFilter.TabIndex = 4
        lblDiscLoginFilter.Text = "Disc / Login"
        lblDiscLoginFilter.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbDiscLogin
        ' 
        cmbDiscLogin.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbDiscLogin.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDiscLogin.Font = New Font("Segoe UI", 9.5F)
        cmbDiscLogin.Location = New Point(570, 7)
        cmbDiscLogin.Margin = New Padding(0, 0, 18, 0)
        cmbDiscLogin.Name = "cmbDiscLogin"
        cmbDiscLogin.Size = New Size(182, 29)
        cmbDiscLogin.TabIndex = 5
        ' 
        ' pnlFilterButtons
        ' 
        pnlFilterButtons.Controls.Add(btnSearch)
        pnlFilterButtons.Controls.Add(btnExportExcel)
        pnlFilterButtons.Dock = DockStyle.Fill
        pnlFilterButtons.Location = New Point(773, 3)
        pnlFilterButtons.Name = "pnlFilterButtons"
        pnlFilterButtons.Size = New Size(384, 38)
        pnlFilterButtons.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(37, 99, 235)
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(0, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(110, 34)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = Color.FromArgb(22, 163, 74)
        btnExportExcel.Cursor = Cursors.Hand
        btnExportExcel.FlatAppearance.BorderSize = 0
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(120, 2)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(120, 34)
        btnExportExcel.TabIndex = 1
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.FromArgb(241, 245, 249)
        PanelGrid.Controls.Add(dgvLeadReport)
        PanelGrid.Controls.Add(lblRecordCount)
        PanelGrid.Controls.Add(lblGridTitle)
        PanelGrid.Dock = DockStyle.Fill
        PanelGrid.Location = New Point(0, 128)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Padding = New Padding(20, 12, 20, 20)
        PanelGrid.Size = New Size(1200, 522)
        PanelGrid.TabIndex = 2
        ' 
        ' dgvLeadReport
        ' 
        dgvLeadReport.AllowUserToAddRows = False
        dgvLeadReport.AllowUserToDeleteRows = False
        dgvLeadReport.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dgvLeadReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvLeadReport.BackgroundColor = Color.White
        dgvLeadReport.BorderStyle = BorderStyle.None
        dgvLeadReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLeadReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59)
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 41, 59)
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLeadReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLeadReport.ColumnHeadersHeight = 40
        dgvLeadReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254)
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(15, 23, 42)
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLeadReport.DefaultCellStyle = DataGridViewCellStyle3
        dgvLeadReport.Dock = DockStyle.Fill
        dgvLeadReport.EnableHeadersVisualStyles = False
        dgvLeadReport.GridColor = Color.FromArgb(226, 232, 240)
        dgvLeadReport.Location = New Point(20, 71)
        dgvLeadReport.MultiSelect = False
        dgvLeadReport.Name = "dgvLeadReport"
        dgvLeadReport.ReadOnly = True
        dgvLeadReport.RowHeadersVisible = False
        dgvLeadReport.RowHeadersWidth = 51
        dgvLeadReport.RowTemplate.Height = 36
        dgvLeadReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLeadReport.Size = New Size(1160, 431)
        dgvLeadReport.TabIndex = 2
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.Dock = DockStyle.Top
        lblRecordCount.Font = New Font("Segoe UI", 9.0F)
        lblRecordCount.ForeColor = Color.FromArgb(100, 116, 139)
        lblRecordCount.Location = New Point(20, 43)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Padding = New Padding(0, 0, 0, 8)
        lblRecordCount.Size = New Size(123, 28)
        lblRecordCount.TabIndex = 1
        lblRecordCount.Text = "0 record(s) found"
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.Dock = DockStyle.Top
        lblGridTitle.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblGridTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblGridTitle.Location = New Point(20, 12)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Padding = New Padding(0, 0, 0, 6)
        lblGridTitle.Size = New Size(147, 31)
        lblGridTitle.TabIndex = 0
        lblGridTitle.Text = "LEAD RECORDS"
        ' 
        ' pnlLoader
        ' 
        pnlLoader.BackColor = Color.FromArgb(230, 255, 255, 255)
        pnlLoader.Controls.Add(picLoader)
        pnlLoader.Controls.Add(lblLoader)
        pnlLoader.Dock = DockStyle.Fill
        pnlLoader.Location = New Point(0, 128)
        pnlLoader.Name = "pnlLoader"
        pnlLoader.Size = New Size(1200, 522)
        pnlLoader.TabIndex = 100
        pnlLoader.Visible = False
        ' 
        ' picLoader
        ' 
        picLoader.Location = New Point(0, 0)
        picLoader.Name = "picLoader"
        picLoader.Size = New Size(64, 64)
        picLoader.SizeMode = PictureBoxSizeMode.Zoom
        picLoader.TabIndex = 0
        picLoader.TabStop = False
        ' 
        ' lblLoader
        ' 
        lblLoader.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblLoader.ForeColor = Color.FromArgb(30, 41, 59)
        lblLoader.Location = New Point(0, 0)
        lblLoader.Name = "lblLoader"
        lblLoader.Size = New Size(320, 30)
        lblLoader.TabIndex = 1
        lblLoader.Text = "Loading data, please wait..."
        lblLoader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmLeadReport
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(241, 245, 249)
        ClientSize = New Size(1200, 650)
        Controls.Add(pnlLoader)
        Controls.Add(PanelGrid)
        Controls.Add(PanelFilter)
        Controls.Add(PanelHeader)
        MinimumSize = New Size(1000, 550)
        Name = "frmLeadReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lead Report"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelFilter.ResumeLayout(False)
        tblFilter.ResumeLayout(False)
        tblFilter.PerformLayout()
        pnlFilterButtons.ResumeLayout(False)
        PanelGrid.ResumeLayout(False)
        PanelGrid.PerformLayout()
        CType(dgvLeadReport, ComponentModel.ISupportInitialize).EndInit()
        pnlLoader.ResumeLayout(False)
        CType(picLoader, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PanelFilter As Panel
    Friend WithEvents tblFilter As TableLayoutPanel
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblDiscLoginFilter As Label
    Friend WithEvents cmbDiscLogin As ComboBox
    Friend WithEvents pnlFilterButtons As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvLeadReport As DataGridView

    Friend WithEvents pnlLoader As Panel
    Friend WithEvents picLoader As PictureBox
    Friend WithEvents lblLoader As Label
End Class