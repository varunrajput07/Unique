<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistration
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
        PanelHeader = New Panel()
        lblTitle = New Label()
        PanelSearch = New Panel()
        txtSearch = New TextBox()
        btnRefresh = New Button()
        btnSearch = New Button()
        lblSearch = New Label()
        PanelEntry = New Panel()
        tblEntry = New TableLayoutPanel()
        Label1 = New Label()
        txtName = New TextBox()
        Label6 = New Label()
        txtUserName = New TextBox()
        Label3 = New Label()
        txtMobile = New TextBox()
        Label2 = New Label()
        pnlPassword = New Panel()
        btnTogglePwd = New Button()
        txtPassword = New TextBox()
        Label4 = New Label()
        CmbUsrTyp = New ComboBox()
        Label5 = New Label()
        CmbStatus = New ComboBox()
        PanelActions = New Panel()
        btnSave = New Button()
        btnClear = New Button()
        PanelGrid = New Panel()
        dgvUsers = New DataGridView()
        lblGridTitle = New Label()
        PanelHeader.SuspendLayout()
        PanelSearch.SuspendLayout()
        PanelEntry.SuspendLayout()
        tblEntry.SuspendLayout()
        pnlPassword.SuspendLayout()
        PanelActions.SuspendLayout()
        PanelGrid.SuspendLayout()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        PanelHeader.Controls.Add(lblTitle)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Padding = New Padding(20, 0, 20, 0)
        PanelHeader.Size = New Size(1050, 58)
        PanelHeader.TabIndex = 4
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI Semibold", 15.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(1010, 58)
        lblTitle.TabIndex = 0
        lblTitle.Text = "USER REGISTRATION && MANAGEMENT"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelSearch
        ' 
        PanelSearch.BackColor = Color.White
        PanelSearch.Controls.Add(txtSearch)
        PanelSearch.Controls.Add(btnRefresh)
        PanelSearch.Controls.Add(btnSearch)
        PanelSearch.Controls.Add(lblSearch)
        PanelSearch.Dock = DockStyle.Top
        PanelSearch.Location = New Point(0, 58)
        PanelSearch.Name = "PanelSearch"
        PanelSearch.Padding = New Padding(20, 12, 20, 12)
        PanelSearch.Size = New Size(1050, 58)
        PanelSearch.TabIndex = 3
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.5F)
        txtSearch.Location = New Point(90, 13)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Name, username or mobile"
        txtSearch.Size = New Size(720, 29)
        txtSearch.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.5F)
        btnRefresh.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnRefresh.Location = New Point(925, 11)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(95, 32)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "Refresh"
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSearch.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9.5F)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(820, 11)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(95, 32)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 9.5F)
        lblSearch.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblSearch.Location = New Point(20, 19)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(60, 21)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search:"
        ' 
        ' PanelEntry
        ' 
        PanelEntry.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        PanelEntry.Controls.Add(tblEntry)
        PanelEntry.Dock = DockStyle.Top
        PanelEntry.Location = New Point(0, 116)
        PanelEntry.Name = "PanelEntry"
        PanelEntry.Padding = New Padding(20, 15, 20, 5)
        PanelEntry.Size = New Size(1050, 240)
        PanelEntry.TabIndex = 2
        ' 
        ' tblEntry
        ' 
        tblEntry.ColumnCount = 4
        tblEntry.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        tblEntry.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        tblEntry.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        tblEntry.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35.0F))
        tblEntry.Controls.Add(Label1, 0, 0)
        tblEntry.Controls.Add(txtName, 1, 0)
        tblEntry.Controls.Add(Label6, 2, 0)
        tblEntry.Controls.Add(txtUserName, 3, 0)
        tblEntry.Controls.Add(Label3, 0, 1)
        tblEntry.Controls.Add(txtMobile, 1, 1)
        tblEntry.Controls.Add(Label2, 2, 1)
        tblEntry.Controls.Add(pnlPassword, 3, 1)
        tblEntry.Controls.Add(Label4, 0, 2)
        tblEntry.Controls.Add(CmbUsrTyp, 1, 2)
        tblEntry.Controls.Add(Label5, 2, 2)
        tblEntry.Controls.Add(CmbStatus, 3, 2)
        tblEntry.Dock = DockStyle.Fill
        tblEntry.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        tblEntry.Location = New Point(20, 15)
        tblEntry.Name = "tblEntry"
        tblEntry.RowCount = 3
        tblEntry.RowStyles.Add(New RowStyle(SizeType.Percent, 33.333F))
        tblEntry.RowStyles.Add(New RowStyle(SizeType.Percent, 33.333F))
        tblEntry.RowStyles.Add(New RowStyle(SizeType.Percent, 33.333F))
        tblEntry.Size = New Size(1010, 220)
        tblEntry.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 9.5F)
        Label1.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 73)
        Label1.TabIndex = 0
        Label1.Text = "Name:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Dock = DockStyle.Fill
        txtName.Font = New Font("Segoe UI", 9.5F)
        txtName.Location = New Point(154, 8)
        txtName.Margin = New Padding(3, 8, 12, 8)
        txtName.Name = "txtName"
        txtName.Size = New Size(338, 29)
        txtName.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 9.5F)
        Label6.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        Label6.Location = New Point(507, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 73)
        Label6.TabIndex = 2
        Label6.Text = "User Name:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtUserName
        ' 
        txtUserName.BorderStyle = BorderStyle.FixedSingle
        txtUserName.Dock = DockStyle.Fill
        txtUserName.Font = New Font("Segoe UI", 9.5F)
        txtUserName.Location = New Point(658, 8)
        txtUserName.Margin = New Padding(3, 8, 3, 8)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(349, 29)
        txtUserName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 9.5F)
        Label3.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        Label3.Location = New Point(3, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 73)
        Label3.TabIndex = 4
        Label3.Text = "Mobile:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtMobile
        ' 
        txtMobile.BorderStyle = BorderStyle.FixedSingle
        txtMobile.Dock = DockStyle.Fill
        txtMobile.Font = New Font("Segoe UI", 9.5F)
        txtMobile.Location = New Point(154, 81)
        txtMobile.Margin = New Padding(3, 8, 12, 8)
        txtMobile.MaxLength = 10
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(338, 29)
        txtMobile.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 9.5F)
        Label2.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        Label2.Location = New Point(507, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 73)
        Label2.TabIndex = 6
        Label2.Text = "Password:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlPassword
        ' 
        pnlPassword.Controls.Add(btnTogglePwd)
        pnlPassword.Controls.Add(txtPassword)
        pnlPassword.Dock = DockStyle.Fill
        pnlPassword.Location = New Point(658, 81)
        pnlPassword.Margin = New Padding(3, 8, 3, 8)
        pnlPassword.Name = "pnlPassword"
        pnlPassword.Size = New Size(349, 57)
        pnlPassword.TabIndex = 7
        ' 
        ' btnTogglePwd
        ' 
        btnTogglePwd.Cursor = Cursors.Hand
        btnTogglePwd.Dock = DockStyle.Right
        btnTogglePwd.FlatAppearance.BorderSize = 0
        btnTogglePwd.FlatStyle = FlatStyle.Flat
        btnTogglePwd.Font = New Font("Segoe UI", 9.5F)
        btnTogglePwd.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnTogglePwd.Location = New Point(315, 0)
        btnTogglePwd.Name = "btnTogglePwd"
        btnTogglePwd.Size = New Size(34, 57)
        btnTogglePwd.TabIndex = 1
        btnTogglePwd.Text = "👁"
        btnTogglePwd.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Dock = DockStyle.Fill
        txtPassword.Font = New Font("Segoe UI", 9.5F)
        txtPassword.Location = New Point(0, 0)
        txtPassword.MaxLength = 8
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(349, 29)
        txtPassword.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 9.5F)
        Label4.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        Label4.Location = New Point(3, 146)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 74)
        Label4.TabIndex = 8
        Label4.Text = "User Type:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CmbUsrTyp
        ' 
        CmbUsrTyp.Dock = DockStyle.Fill
        CmbUsrTyp.DropDownStyle = ComboBoxStyle.DropDownList
        CmbUsrTyp.Font = New Font("Segoe UI", 9.5F)
        CmbUsrTyp.Items.AddRange(New Object() {"Super Admin", "Admin", "Employee"})
        CmbUsrTyp.Location = New Point(154, 154)
        CmbUsrTyp.Margin = New Padding(3, 8, 12, 8)
        CmbUsrTyp.Name = "CmbUsrTyp"
        CmbUsrTyp.Size = New Size(338, 29)
        CmbUsrTyp.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 9.5F)
        Label5.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        Label5.Location = New Point(507, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 74)
        Label5.TabIndex = 9
        Label5.Text = "Status:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CmbStatus
        ' 
        CmbStatus.Dock = DockStyle.Fill
        CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CmbStatus.Font = New Font("Segoe UI", 9.5F)
        CmbStatus.Items.AddRange(New Object() {"Y", "N"})
        CmbStatus.Location = New Point(658, 154)
        CmbStatus.Margin = New Padding(3, 8, 3, 8)
        CmbStatus.Name = "CmbStatus"
        CmbStatus.Size = New Size(349, 29)
        CmbStatus.TabIndex = 5
        ' 
        ' PanelActions
        ' 
        PanelActions.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        PanelActions.Controls.Add(btnSave)
        PanelActions.Controls.Add(btnClear)
        PanelActions.Dock = DockStyle.Top
        PanelActions.Location = New Point(0, 356)
        PanelActions.Name = "PanelActions"
        PanelActions.Padding = New Padding(20, 6, 20, 6)
        PanelActions.Size = New Size(1050, 54)
        PanelActions.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(20, 6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(120, 38)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatAppearance.BorderColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9.5F)
        btnClear.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnClear.Location = New Point(150, 6)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(120, 38)
        btnClear.TabIndex = 7
        btnClear.Text = "New / Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' PanelGrid
        ' 
        PanelGrid.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        PanelGrid.Controls.Add(dgvUsers)
        PanelGrid.Controls.Add(lblGridTitle)
        PanelGrid.Dock = DockStyle.Fill
        PanelGrid.Location = New Point(0, 410)
        PanelGrid.Name = "PanelGrid"
        PanelGrid.Padding = New Padding(20, 5, 20, 20)
        PanelGrid.Size = New Size(1050, 310)
        PanelGrid.TabIndex = 0
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.AllowUserToResizeRows = False
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.ColumnHeadersHeight = 38
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsers.Dock = DockStyle.Fill
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.Location = New Point(20, 40)
        dgvUsers.MultiSelect = False
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.RowTemplate.Height = 32
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(1010, 250)
        dgvUsers.TabIndex = 8
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.Dock = DockStyle.Top
        lblGridTitle.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblGridTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblGridTitle.Location = New Point(20, 5)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(1010, 35)
        lblGridTitle.TabIndex = 9
        lblGridTitle.Text = "REGISTERED USERS"
        lblGridTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmRegistration
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(1050, 720)
        Controls.Add(PanelGrid)
        Controls.Add(PanelActions)
        Controls.Add(PanelEntry)
        Controls.Add(PanelSearch)
        Controls.Add(PanelHeader)
        MinimumSize = New Size(900, 650)
        Name = "frmRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "Registration"
        Text = "User Registration and Management"
        WindowState = FormWindowState.Maximized
        PanelHeader.ResumeLayout(False)
        PanelSearch.ResumeLayout(False)
        PanelSearch.PerformLayout()
        PanelEntry.ResumeLayout(False)
        tblEntry.ResumeLayout(False)
        tblEntry.PerformLayout()
        pnlPassword.ResumeLayout(False)
        pnlPassword.PerformLayout()
        PanelActions.ResumeLayout(False)
        PanelGrid.ResumeLayout(False)
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    '================================================
    ' CONTROLS
    '================================================
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label

    Friend WithEvents PanelSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button

    Friend WithEvents PanelEntry As Panel
    Friend WithEvents tblEntry As TableLayoutPanel

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlPassword As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnTogglePwd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbUsrTyp As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbStatus As ComboBox

    Friend WithEvents PanelActions As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents PanelGrid As Panel
    Friend WithEvents lblGridTitle As Label
    Friend WithEvents dgvUsers As DataGridView

End Class