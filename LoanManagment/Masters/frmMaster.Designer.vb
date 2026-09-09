<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        CboParent = New ComboBox()
        lblParent = New Label()
        txtValue = New TextBox()
        txtSearch = New TextBox()
        Label2 = New Label()
        CboStatus = New ComboBox()
        Label1 = New Label()
        Label7 = New Label()
        CboMaster = New ComboBox()
        Label6 = New Label()
        btnDelete = New Button()
        btnRefresh = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        dgvMaster = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgvMaster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CboParent)
        Panel1.Controls.Add(lblParent)
        Panel1.Controls.Add(txtValue)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CboStatus)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(CboMaster)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(btnUpdate)
        Panel1.Controls.Add(btnSave)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1487, 181)
        Panel1.TabIndex = 2
        ' 
        ' CboParent
        ' 
        CboParent.DropDownStyle = ComboBoxStyle.DropDownList
        CboParent.FormattingEnabled = True
        CboParent.Location = New Point(420, 15)
        CboParent.Name = "CboParent"
        CboParent.Size = New Size(182, 28)
        CboParent.TabIndex = 81
        ' 
        ' lblParent
        ' 
        lblParent.AutoSize = True
        lblParent.Location = New Point(358, 20)
        lblParent.Name = "lblParent"
        lblParent.Size = New Size(57, 20)
        lblParent.TabIndex = 80
        lblParent.Text = "Parent :"
        ' 
        ' txtValue
        ' 
        txtValue.Location = New Point(147, 50)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(185, 27)
        txtValue.TabIndex = 79
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(147, 135)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(185, 27)
        txtSearch.TabIndex = 78
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 77
        Label2.Text = "Search :"
        ' 
        ' CboStatus
        ' 
        CboStatus.DropDownStyle = ComboBoxStyle.DropDownList
        CboStatus.FormattingEnabled = True
        CboStatus.Location = New Point(194, 87)
        CboStatus.Name = "CboStatus"
        CboStatus.Size = New Size(138, 28)
        CboStatus.TabIndex = 76
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(60, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 20)
        Label1.TabIndex = 75
        Label1.Text = "Active / In Active :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(92, 50)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 73
        Label7.Text = "Value :"
        ' 
        ' CboMaster
        ' 
        CboMaster.DropDownStyle = ComboBoxStyle.DropDownList
        CboMaster.FormattingEnabled = True
        CboMaster.Location = New Point(147, 15)
        CboMaster.Name = "CboMaster"
        CboMaster.Size = New Size(185, 28)
        CboMaster.TabIndex = 70
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(85, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 20)
        Label6.TabIndex = 69
        Label6.Text = "Master :"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(542, 133)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 45
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(641, 133)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 29)
        btnRefresh.TabIndex = 44
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(444, 133)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 43
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(348, 131)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 42
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' dgvMaster
        ' 
        dgvMaster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMaster.Dock = DockStyle.Fill
        dgvMaster.Location = New Point(0, 181)
        dgvMaster.Name = "dgvMaster"
        dgvMaster.RowHeadersWidth = 51
        dgvMaster.Size = New Size(1487, 447)
        dgvMaster.TabIndex = 3
        ' 
        ' frmMaster
        ' 
        AutoScaleMode = AutoScaleMode.Inherit
        ClientSize = New Size(1487, 628)
        Controls.Add(dgvMaster)
        Controls.Add(Panel1)
        Name = "frmMaster"
        Tag = "Masters"
        Text = "Masters"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvMaster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtLLPs As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBranchSole As TextBox
    Friend WithEvents CboMaster As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvMaster As DataGridView
    Friend WithEvents CboStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents CboParent As ComboBox
    Friend WithEvents lblParent As Label
End Class
