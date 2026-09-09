<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
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
        MenuStrip2.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 28)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1597, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(20, 20)
        MenuStrip2.Items.AddRange(New ToolStripItem() {LoanToolStripMenuItem, HomeToolStripMenuItem, REPORTSToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1597, 28)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' LoanToolStripMenuItem
        ' 
        LoanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CarLoanToolStripMenuItem, LOGINMISToolStripMenuItem, EXPENSEMISToolStripMenuItem})
        LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        LoanToolStripMenuItem.Size = New Size(48, 24)
        LoanToolStripMenuItem.Text = "MIS"
        ' 
        ' CarLoanToolStripMenuItem
        ' 
        CarLoanToolStripMenuItem.Name = "CarLoanToolStripMenuItem"
        CarLoanToolStripMenuItem.Size = New Size(224, 26)
        CarLoanToolStripMenuItem.Text = "LEAD MIS"
        ' 
        ' LOGINMISToolStripMenuItem
        ' 
        LOGINMISToolStripMenuItem.Name = "LOGINMISToolStripMenuItem"
        LOGINMISToolStripMenuItem.Size = New Size(224, 26)
        LOGINMISToolStripMenuItem.Text = "LOGIN MIS"
        ' 
        ' EXPENSEMISToolStripMenuItem
        ' 
        EXPENSEMISToolStripMenuItem.Name = "EXPENSEMISToolStripMenuItem"
        EXPENSEMISToolStripMenuItem.Size = New Size(224, 26)
        EXPENSEMISToolStripMenuItem.Text = "EXPENSE MIS"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrationToolStripMenuItem, MastersToolStripMenuItem})
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(87, 24)
        HomeToolStripMenuItem.Text = "MASTERS"
        ' 
        ' RegistrationToolStripMenuItem
        ' 
        RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        RegistrationToolStripMenuItem.Size = New Size(172, 26)
        RegistrationToolStripMenuItem.Text = "Registration"
        ' 
        ' MastersToolStripMenuItem
        ' 
        MastersToolStripMenuItem.Name = "MastersToolStripMenuItem"
        MastersToolStripMenuItem.Size = New Size(172, 26)
        MastersToolStripMenuItem.Text = "All Masters"
        ' 
        ' REPORTSToolStripMenuItem
        ' 
        REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        REPORTSToolStripMenuItem.Size = New Size(83, 24)
        REPORTSToolStripMenuItem.Text = "REPORTS"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblUserInfo})
        StatusStrip1.Location = New Point(0, 481)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1597, 26)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(153, 20)
        lblUserInfo.Text = "ToolStripStatusLabel1"
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        ClientSize = New Size(1597, 507)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        IsMdiContainer = True
        Name = "Form1"
        Text = "Unique"
        WindowState = FormWindowState.Maximized
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
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
