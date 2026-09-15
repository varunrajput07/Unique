<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    '===========================================================
    ' FORM DISPOSE
    '===========================================================
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '===========================================================
    ' COMPONENTS
    '===========================================================
    Private components As System.ComponentModel.IContainer

    '===========================================================
    ' INITIALIZE COMPONENT
    '===========================================================
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager =
            New System.ComponentModel.ComponentResourceManager(GetType(Form1))

        '-------------------------------------------------------
        ' CREATE CONTROLS
        '-------------------------------------------------------
        MenuStrip2 = New MenuStrip()

        LoanToolStripMenuItem = New ToolStripMenuItem()
        CarLoanToolStripMenuItem = New ToolStripMenuItem()
        LOGINMISToolStripMenuItem = New ToolStripMenuItem()
        EXPENSEMISToolStripMenuItem = New ToolStripMenuItem()

        HomeToolStripMenuItem = New ToolStripMenuItem()
        RegistrationToolStripMenuItem = New ToolStripMenuItem()
        MastersToolStripMenuItem = New ToolStripMenuItem()

        REPORTSToolStripMenuItem = New ToolStripMenuItem()

        StatusStrip1 = New StatusStrip()
        lblUserInfo = New ToolStripStatusLabel()

        '-------------------------------------------------------
        ' SUSPEND
        '-------------------------------------------------------
        MenuStrip2.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()

        '=======================================================
        ' MAIN MENU STRIP
        '=======================================================
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(
            New ToolStripItem() {
                LoanToolStripMenuItem,
                HomeToolStripMenuItem,
                REPORTSToolStripMenuItem
            })

        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1600, 42)
        MenuStrip2.TabIndex = 0
        MenuStrip2.Text = "Main Navigation"
        MenuStrip2.BackColor = Color.FromArgb(15, 23, 42)
        MenuStrip2.ForeColor = Color.White
        MenuStrip2.Padding = New Padding(12, 4, 0, 4)

        '=======================================================
        ' MIS MENU
        '=======================================================
        LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        LoanToolStripMenuItem.Size = New Size(80, 34)
        LoanToolStripMenuItem.Text = "  MIS  "
        LoanToolStripMenuItem.ToolTipText = "Management Information System"
        LoanToolStripMenuItem.ForeColor = Color.White
        LoanToolStripMenuItem.BackColor = Color.FromArgb(37, 99, 235)
        LoanToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        LoanToolStripMenuItem.DropDownItems.AddRange(
            New ToolStripItem() {
                CarLoanToolStripMenuItem,
                LOGINMISToolStripMenuItem,
                EXPENSEMISToolStripMenuItem
            })

        '=======================================================
        ' LEAD MIS
        '=======================================================
        CarLoanToolStripMenuItem.Name = "CarLoanToolStripMenuItem"
        CarLoanToolStripMenuItem.Size = New Size(230, 34)
        CarLoanToolStripMenuItem.Text = "  Lead MIS"
        CarLoanToolStripMenuItem.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        CarLoanToolStripMenuItem.ForeColor = Color.FromArgb(15, 23, 42)

        '=======================================================
        ' LOGIN MIS
        '=======================================================
        LOGINMISToolStripMenuItem.Name = "LOGINMISToolStripMenuItem"
        LOGINMISToolStripMenuItem.Size = New Size(230, 34)
        LOGINMISToolStripMenuItem.Text = "  Login MIS"
        LOGINMISToolStripMenuItem.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        LOGINMISToolStripMenuItem.ForeColor = Color.FromArgb(15, 23, 42)

        '=======================================================
        ' EXPENSE MIS
        '=======================================================
        EXPENSEMISToolStripMenuItem.Name = "EXPENSEMISToolStripMenuItem"
        EXPENSEMISToolStripMenuItem.Size = New Size(230, 34)
        EXPENSEMISToolStripMenuItem.Text = "  Expense MIS"
        EXPENSEMISToolStripMenuItem.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        EXPENSEMISToolStripMenuItem.ForeColor = Color.FromArgb(15, 23, 42)

        '=======================================================
        ' MASTERS MENU
        '=======================================================
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(105, 34)
        HomeToolStripMenuItem.Text = "  MASTERS  "
        HomeToolStripMenuItem.ToolTipText = "Master Data"
        HomeToolStripMenuItem.ForeColor = Color.White
        HomeToolStripMenuItem.BackColor = Color.FromArgb(5, 150, 105)
        HomeToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        HomeToolStripMenuItem.DropDownItems.AddRange(
            New ToolStripItem() {
                RegistrationToolStripMenuItem,
                MastersToolStripMenuItem
            })

        '=======================================================
        ' REGISTRATION
        '=======================================================
        RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        RegistrationToolStripMenuItem.Size = New Size(230, 34)
        RegistrationToolStripMenuItem.Text = "  Registration"
        RegistrationToolStripMenuItem.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        RegistrationToolStripMenuItem.ForeColor = Color.FromArgb(15, 23, 42)

        '=======================================================
        ' ALL MASTERS
        '=======================================================
        MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        MastersToolStripMenuItem.Size = New Size(230, 34)
        MastersToolStripMenuItem.Text = "  All Masters"
        MastersToolStripMenuItem.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        MastersToolStripMenuItem.ForeColor = Color.FromArgb(15, 23, 42)

        '=======================================================
        ' REPORTS
        '=======================================================
        REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        REPORTSToolStripMenuItem.Size = New Size(105, 34)
        REPORTSToolStripMenuItem.Text = "  REPORTS  "
        REPORTSToolStripMenuItem.ToolTipText = "Reports"
        REPORTSToolStripMenuItem.ForeColor = Color.White
        REPORTSToolStripMenuItem.BackColor = Color.FromArgb(124, 58, 237)
        REPORTSToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)

        '=======================================================
        ' STATUS STRIP
        '=======================================================
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblUserInfo})
        StatusStrip1.Location = New Point(0, 841)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1600, 30)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "Status"
        StatusStrip1.BackColor = Color.FromArgb(15, 23, 42)
        StatusStrip1.ForeColor = Color.White
        StatusStrip1.Padding = New Padding(10, 0, 10, 0)

        '=======================================================
        ' USER INFORMATION
        '=======================================================
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(250, 24)
        lblUserInfo.Text = "  User"
        lblUserInfo.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Regular)
        lblUserInfo.ForeColor = Color.White
        lblUserInfo.Spring = False
        lblUserInfo.TextAlign = ContentAlignment.MiddleLeft

        '=======================================================
        ' FORM
        '=======================================================
        AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(241, 245, 249)
        ClientSize = New Size(1600, 871)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip2)
        Font = New Font("Segoe UI", 9.0!)
        ForeColor = Color.FromArgb(15, 23, 42)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip2
        MinimumSize = New Size(1100, 650)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UNIQUE"
        WindowState = FormWindowState.Maximized

        '=======================================================
        ' RESUME
        '=======================================================
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    '===========================================================
    ' CONTROLS
    '===========================================================
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CarLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUserInfo As ToolStripStatusLabel
    Friend WithEvents LOGINMISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MastersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXPENSEMISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
End Class