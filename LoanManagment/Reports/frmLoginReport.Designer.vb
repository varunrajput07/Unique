<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginReport
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
        lblReportType = New Label()
        cmbReportType = New ComboBox()
        lblFrom = New Label()
        dtpFrom = New DateTimePicker()
        lblTo = New Label()
        dtpTo = New DateTimePicker()
        lblCustName = New Label()
        txtCustName = New TextBox()
        lblStageFilter = New Label()
        cmbStage = New ComboBox()
        pnlFilterButtons = New Panel()
        btnSearch = New Button()
        btnClear = New Button()
        btnExportExcel = New Button()
        PanelGrid = New Panel()
        dgvLoginReport = New DataGridView()
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
        CType(dgvLoginReport, ComponentModel.ISupportInitialize).BeginInit()
        pnlLoader.SuspendLayout()
        CType(picLoader, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(24, 0, 24, 0)
        PanelHeader.Size = New Size(1300, 56)
        PanelHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(24, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1252, 56)
        lblTitle.TabIndex = 0
        lblTitle.Text = "LOGIN REPORT"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelFilter
        ' 
        PanelFilter.BackColor = Color.White
        PanelFilter.Controls.Add(tblFilter)
        PanelFilter.Dock = DockStyle.Top
        PanelFilter.Location = New Point(0, 56)
        PanelFilter.Name = "PanelFilter"
        PanelFilter.Padding = New Padding(16, 12, 16, 12)
        PanelFilter.Size = New Size(1300, 78)
        PanelFilter.TabIndex = 1
        ' 
        ' tblFilter
        ' 
        tblFilter.ColumnCount = 11
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 155.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 135.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 135.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle())
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 140.0F))
        tblFilter.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        tblFilter.Controls.Add(lblReportType, 0, 0)
        tblFilter.Controls.Add(cmbReportType, 1, 0)
        tblFilter.Controls.Add(lblFrom, 2, 0)
        tblFilter.Controls.Add(dtpFrom, 3, 0)
        tblFilter.Controls.Add(lblTo, 4, 0)
        tblFilter.Controls.Add(dtpTo, 5, 0)
        tblFilter.Controls.Add(lblCustName, 6, 0)
        tblFilter.Controls.Add(txtCustName, 7, 0)
        tblFilter.Controls.Add(lblStageFilter, 8, 0)
        tblFilter.Controls.Add(cmbStage, 9, 0)
        tblFilter.Controls.Add(pnlFilterButtons, 10, 0)
        tblFilter.Dock = DockStyle.Fill
        tblFilter.Location = New Point(16, 12)
        tblFilter.Name = "tblFilter"
        tblFilter.RowCount = 1
        tblFilter.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        tblFilter.Size = New Size(1268, 54)
        tblFilter.TabIndex = 0
        ' 
        ' lblReportType
        ' 
        lblReportType.Anchor = AnchorStyles.Left
        lblReportType.AutoSize = True
        lblReportType.Font = New Font("Segoe UI", 9.5F)
        lblReportType.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblReportType.Location = New Point(0, 16)
        lblReportType.Margin = New Padding(0, 0, 6, 0)
        lblReportType.Name = "lblReportType"
        lblReportType.Size = New Size(93, 21)
        lblReportType.TabIndex = 0
        lblReportType.Text = "Report Type"
        lblReportType.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbReportType
        ' 
        cmbReportType.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbReportType.Font = New Font("Segoe UI", 9.5F)
        cmbReportType.Location = New Point(99, 12)
        cmbReportType.Margin = New Padding(0, 0, 10, 0)
        cmbReportType.Name = "cmbReportType"
        cmbReportType.Size = New Size(145, 29)
        cmbReportType.TabIndex = 1
        ' 
        ' lblFrom
        ' 
        lblFrom.Anchor = AnchorStyles.Left
        lblFrom.AutoSize = True
        lblFrom.Font = New Font("Segoe UI", 9.5F)
        lblFrom.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblFrom.Location = New Point(254, 16)
        lblFrom.Margin = New Padding(0, 0, 6, 0)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(83, 21)
        lblFrom.TabIndex = 2
        lblFrom.Text = "Date From"
        lblFrom.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpFrom.Font = New Font("Segoe UI", 9.5F)
        dtpFrom.Format = DateTimePickerFormat.Short
        dtpFrom.Location = New Point(343, 12)
        dtpFrom.Margin = New Padding(0, 0, 10, 0)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.ShowCheckBox = True
        dtpFrom.Size = New Size(125, 29)
        dtpFrom.TabIndex = 3
        ' 
        ' lblTo
        ' 
        lblTo.Anchor = AnchorStyles.Left
        lblTo.AutoSize = True
        lblTo.Font = New Font("Segoe UI", 9.5F)
        lblTo.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblTo.Location = New Point(478, 16)
        lblTo.Margin = New Padding(0, 0, 6, 0)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(61, 21)
        lblTo.TabIndex = 4
        lblTo.Text = "Date To"
        lblTo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpTo
        ' 
        dtpTo.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dtpTo.Font = New Font("Segoe UI", 9.5F)
        dtpTo.Format = DateTimePickerFormat.Short
        dtpTo.Location = New Point(545, 12)
        dtpTo.Margin = New Padding(0, 0, 10, 0)
        dtpTo.Name = "dtpTo"
        dtpTo.ShowCheckBox = True
        dtpTo.Size = New Size(125, 29)
        dtpTo.TabIndex = 5
        ' 
        ' lblCustName
        ' 
        lblCustName.Anchor = AnchorStyles.Left
        lblCustName.AutoSize = True
        lblCustName.Font = New Font("Segoe UI", 9.5F)
        lblCustName.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblCustName.Location = New Point(680, 16)
        lblCustName.Margin = New Padding(0, 0, 6, 0)
        lblCustName.Name = "lblCustName"
        lblCustName.Size = New Size(78, 21)
        lblCustName.TabIndex = 6
        lblCustName.Text = "Customer"
        lblCustName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCustName
        ' 
        txtCustName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txtCustName.Font = New Font("Segoe UI", 9.5F)
        txtCustName.Location = New Point(764, 12)
        txtCustName.Margin = New Padding(0, 0, 10, 0)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(140, 29)
        txtCustName.TabIndex = 7
        ' 
        ' lblStageFilter
        ' 
        lblStageFilter.Anchor = AnchorStyles.Left
        lblStageFilter.AutoSize = True
        lblStageFilter.Font = New Font("Segoe UI", 9.5F)
        lblStageFilter.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblStageFilter.Location = New Point(914, 16)
        lblStageFilter.Margin = New Padding(0, 0, 6, 0)
        lblStageFilter.Name = "lblStageFilter"
        lblStageFilter.Size = New Size(48, 21)
        lblStageFilter.TabIndex = 8
        lblStageFilter.Text = "Stage"
        lblStageFilter.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cmbStage
        ' 
        cmbStage.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        cmbStage.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStage.Font = New Font("Segoe UI", 9.5F)
        cmbStage.Location = New Point(968, 12)
        cmbStage.Margin = New Padding(0, 0, 10, 0)
        cmbStage.Name = "cmbStage"
        cmbStage.Size = New Size(130, 29)
        cmbStage.TabIndex = 9
        ' 
        ' pnlFilterButtons
        ' 
        pnlFilterButtons.Controls.Add(btnSearch)
        pnlFilterButtons.Controls.Add(btnClear)
        pnlFilterButtons.Controls.Add(btnExportExcel)
        pnlFilterButtons.Dock = DockStyle.Fill
        pnlFilterButtons.Location = New Point(1111, 3)
        pnlFilterButtons.Name = "pnlFilterButtons"
        pnlFilterButtons.Size = New Size(154, 48)
        pnlFilterButtons.TabIndex = 10
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(0, 8)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 32)
        btnSearch.TabIndex = 0
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(90, 8)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 32)
        btnClear.TabIndex = 1
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExportExcel
        ' 
        btnExportExcel.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnExportExcel.Cursor = Cursors.Hand
        btnExportExcel.FlatAppearance.BorderSize = 0
        btnExportExcel.FlatStyle = FlatStyle.Flat
        btnExportExcel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnExportExcel.ForeColor = Color.White
        btnExportExcel.Location = New Point(170, 8)
        btnExportExcel.Name = "btnExportExcel"
        btnExportExcel.Size = New Size(100, 32)
        btnExportExcel.TabIndex = 2
        btnExportExcel.Text = "Export Excel"
        btnExportExcel.UseVisualStyleBackColor = False
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        PanelGrid.Controls.Add(dgvLoginReport)
        PanelGrid.Controls.Add(lblRecordCount)
        PanelGrid.Controls.Add(lblGridTitle)
        PanelGrid.Dock = DockStyle.Fill
        PanelGrid.Location = New Point(0, 134)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Padding = New Padding(20, 12, 20, 20)
        PanelGrid.Size = New Size(1300, 516)
        PanelGrid.TabIndex = 2
        ' 
        ' dgvLoginReport
        ' 
        dgvLoginReport.AllowUserToAddRows = False
        dgvLoginReport.AllowUserToDeleteRows = False
        dgvLoginReport.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        dgvLoginReport.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvLoginReport.BackgroundColor = Color.White
        dgvLoginReport.BorderStyle = BorderStyle.None
        dgvLoginReport.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvLoginReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLoginReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvLoginReport.ColumnHeadersHeight = 40
        dgvLoginReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvLoginReport.DefaultCellStyle = DataGridViewCellStyle3
        dgvLoginReport.Dock = DockStyle.Fill
        dgvLoginReport.EnableHeadersVisualStyles = False
        dgvLoginReport.GridColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        dgvLoginReport.Location = New Point(20, 71)
        dgvLoginReport.MultiSelect = False
        dgvLoginReport.Name = "dgvLoginReport"
        dgvLoginReport.ReadOnly = True
        dgvLoginReport.RowHeadersVisible = False
        dgvLoginReport.RowHeadersWidth = 51
        dgvLoginReport.RowTemplate.Height = 36
        dgvLoginReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoginReport.Size = New Size(1260, 425)
        dgvLoginReport.TabIndex = 2
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.AutoSize = True
        lblRecordCount.Dock = DockStyle.Top
        lblRecordCount.Font = New Font("Segoe UI", 9.0F)
        lblRecordCount.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
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
        lblGridTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblGridTitle.Location = New Point(20, 12)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Padding = New Padding(0, 0, 0, 6)
        lblGridTitle.Size = New Size(157, 31)
        lblGridTitle.TabIndex = 0
        lblGridTitle.Text = "LOGIN RECORDS"
        ' 
        ' pnlLoader
        ' 
        pnlLoader.BackColor = Color.FromArgb(CByte(230), CByte(255), CByte(255), CByte(255))
        pnlLoader.Controls.Add(picLoader)
        pnlLoader.Controls.Add(lblLoader)
        pnlLoader.Dock = DockStyle.Fill
        pnlLoader.Location = New Point(0, 134)
        pnlLoader.Name = "pnlLoader"
        pnlLoader.Size = New Size(1300, 516)
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
        lblLoader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblLoader.Location = New Point(0, 0)
        lblLoader.Name = "lblLoader"
        lblLoader.Size = New Size(320, 30)
        lblLoader.TabIndex = 1
        lblLoader.Text = "Loading data, please wait..."
        lblLoader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmLoginReport
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(1300, 650)
        Controls.Add(pnlLoader)
        Controls.Add(PanelGrid)
        Controls.Add(PanelFilter)
        Controls.Add(PanelHeader)
        MinimumSize = New Size(1200, 550)
        Name = "frmLoginReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Report"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelFilter.ResumeLayout(False)
        tblFilter.ResumeLayout(False)
        tblFilter.PerformLayout()
        pnlFilterButtons.ResumeLayout(False)
        PanelGrid.ResumeLayout(False)
        PanelGrid.PerformLayout()
        CType(dgvLoginReport, ComponentModel.ISupportInitialize).EndInit()
        pnlLoader.ResumeLayout(False)
        CType(picLoader, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents PanelFilter As Panel
    Friend WithEvents tblFilter As TableLayoutPanel
    Friend WithEvents lblReportType As Label
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblCustName As Label
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblStageFilter As Label
    Friend WithEvents cmbStage As ComboBox
    Friend WithEvents pnlFilterButtons As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvLoginReport As DataGridView
    Friend WithEvents pnlLoader As Panel
    Friend WithEvents picLoader As PictureBox
    Friend WithEvents lblLoader As Label

End Class