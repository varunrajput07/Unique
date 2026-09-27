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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip2 = New MenuStrip()
        LoanToolStripMenuItem = New ToolStripMenuItem()
        CarLoanToolStripMenuItem = New ToolStripMenuItem()
        LOGINMISToolStripMenuItem = New ToolStripMenuItem()
        EXPENSEMISToolStripMenuItem = New ToolStripMenuItem()
        IncomeToolStripMenuItem = New ToolStripMenuItem()
        ExpenceToolStripMenuItem = New ToolStripMenuItem()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        RegistrationToolStripMenuItem = New ToolStripMenuItem()
        MastersToolStripMenuItem = New ToolStripMenuItem()
        REPORTSToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        lblUserInfo = New ToolStripStatusLabel()
        LeadToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip2.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        MenuStrip2.ForeColor = Color.White
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {LoanToolStripMenuItem, HomeToolStripMenuItem, REPORTSToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Padding = New Padding(12, 4, 0, 4)
        MenuStrip2.Size = New Size(1600, 35)
        MenuStrip2.TabIndex = 0
        MenuStrip2.Text = "Main Navigation"
        ' 
        ' LoanToolStripMenuItem
        ' 
        LoanToolStripMenuItem.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        LoanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CarLoanToolStripMenuItem, LOGINMISToolStripMenuItem, EXPENSEMISToolStripMenuItem})
        LoanToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        LoanToolStripMenuItem.ForeColor = Color.White
        LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        LoanToolStripMenuItem.Size = New Size(74, 27)
        LoanToolStripMenuItem.Text = "  MIS  "
        LoanToolStripMenuItem.ToolTipText = "Management Information System"
        ' 
        ' CarLoanToolStripMenuItem
        ' 
        CarLoanToolStripMenuItem.Font = New Font("Segoe UI", 10F)
        CarLoanToolStripMenuItem.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        CarLoanToolStripMenuItem.Name = "CarLoanToolStripMenuItem"
        CarLoanToolStripMenuItem.Size = New Size(200, 28)
        CarLoanToolStripMenuItem.Text = "  Lead MIS"
        ' 
        ' LOGINMISToolStripMenuItem
        ' 
        LOGINMISToolStripMenuItem.Font = New Font("Segoe UI", 10F)
        LOGINMISToolStripMenuItem.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        LOGINMISToolStripMenuItem.Name = "LOGINMISToolStripMenuItem"
        LOGINMISToolStripMenuItem.Size = New Size(200, 28)
        LOGINMISToolStripMenuItem.Text = "  Login MIS"
        ' 
        ' EXPENSEMISToolStripMenuItem
        ' 
        EXPENSEMISToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IncomeToolStripMenuItem, ExpenceToolStripMenuItem})
        EXPENSEMISToolStripMenuItem.Font = New Font("Segoe UI", 10F)
        EXPENSEMISToolStripMenuItem.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        EXPENSEMISToolStripMenuItem.Name = "EXPENSEMISToolStripMenuItem"
        EXPENSEMISToolStripMenuItem.Size = New Size(200, 28)
        EXPENSEMISToolStripMenuItem.Text = "  Expense MIS"
        ' 
        ' IncomeToolStripMenuItem
        ' 
        IncomeToolStripMenuItem.Name = "IncomeToolStripMenuItem"
        IncomeToolStripMenuItem.Size = New Size(157, 28)
        IncomeToolStripMenuItem.Text = "Income"
        ' 
        ' ExpenceToolStripMenuItem
        ' 
        ExpenceToolStripMenuItem.Name = "ExpenceToolStripMenuItem"
        ExpenceToolStripMenuItem.Size = New Size(157, 28)
        ExpenceToolStripMenuItem.Text = "Expence"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.BackColor = Color.FromArgb(CByte(5), CByte(150), CByte(105))
        HomeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrationToolStripMenuItem, MastersToolStripMenuItem})
        HomeToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        HomeToolStripMenuItem.ForeColor = Color.White
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(118, 27)
        HomeToolStripMenuItem.Text = "  MASTERS  "
        HomeToolStripMenuItem.ToolTipText = "Master Data"
        ' 
        ' RegistrationToolStripMenuItem
        ' 
        RegistrationToolStripMenuItem.Font = New Font("Segoe UI", 10F)
        RegistrationToolStripMenuItem.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        RegistrationToolStripMenuItem.Size = New Size(195, 28)
        RegistrationToolStripMenuItem.Text = "  Registration"
        ' 
        ' MastersToolStripMenuItem
        ' 
        MastersToolStripMenuItem.Font = New Font("Segoe UI", 10F)
        MastersToolStripMenuItem.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        MastersToolStripMenuItem.Size = New Size(195, 28)
        MastersToolStripMenuItem.Text = "  All Masters"
        ' 
        ' REPORTSToolStripMenuItem
        ' 
        REPORTSToolStripMenuItem.BackColor = Color.FromArgb(CByte(124), CByte(58), CByte(237))
        REPORTSToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LeadToolStripMenuItem})
        REPORTSToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        REPORTSToolStripMenuItem.ForeColor = Color.White
        REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        REPORTSToolStripMenuItem.Size = New Size(116, 27)
        REPORTSToolStripMenuItem.Text = "  REPORTS  "
        REPORTSToolStripMenuItem.ToolTipText = "Reports"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        StatusStrip1.ForeColor = Color.White
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblUserInfo})
        StatusStrip1.Location = New Point(0, 844)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(10, 0, 10, 0)
        StatusStrip1.Size = New Size(1600, 27)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "Status"
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.Font = New Font("Segoe UI Semibold", 9.5F)
        lblUserInfo.ForeColor = Color.White
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(51, 21)
        lblUserInfo.Text = "  User"
        lblUserInfo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LeadToolStripMenuItem
        ' 
        LeadToolStripMenuItem.Name = "LeadToolStripMenuItem"
        LeadToolStripMenuItem.Size = New Size(224, 28)
        LeadToolStripMenuItem.Text = "Lead"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        ClientSize = New Size(1600, 871)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip2)
        Font = New Font("Segoe UI", 9F)
        ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip2
        MinimumSize = New Size(1100, 650)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "UNIQUE"
        WindowState = FormWindowState.Maximized
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
    Friend WithEvents IncomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadToolStripMenuItem As ToolStripMenuItem
End Class