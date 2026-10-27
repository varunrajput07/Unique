<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOfficeExpense
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        '==================== MAIN TAB CONTROL ====================
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabStaff = New System.Windows.Forms.TabPage()
        Me.tabOffice = New System.Windows.Forms.TabPage()

        '==================== STAFF EXPENSE CONTROLS ====================
        Me.lblStaffName = New System.Windows.Forms.Label()
        Me.cmbStaffName = New System.Windows.Forms.ComboBox()
        Me.lblStaffMonth = New System.Windows.Forms.Label()
        Me.dtpStaffMonth = New System.Windows.Forms.DateTimePicker()
        Me.lblStaffAmount = New System.Windows.Forms.Label()
        Me.txtStaffAmount = New System.Windows.Forms.TextBox()
        Me.lblStaffPaidDate = New System.Windows.Forms.Label()
        Me.dtpStaffPaidDate = New System.Windows.Forms.DateTimePicker()
        Me.lblStaffPaidStatus = New System.Windows.Forms.Label()
        Me.cmbStaffPaidStatus = New System.Windows.Forms.ComboBox()
        Me.lblStaffPaidBy = New System.Windows.Forms.Label()
        Me.cmbStaffPaidBy = New System.Windows.Forms.ComboBox()
        Me.lblStaffRemarks = New System.Windows.Forms.Label()
        Me.txtStaffRemarks = New System.Windows.Forms.TextBox()
        Me.btnStaffSave = New System.Windows.Forms.Button()
        Me.btnStaffUpdate = New System.Windows.Forms.Button()
        Me.btnStaffDelete = New System.Windows.Forms.Button()
        Me.btnStaffClear = New System.Windows.Forms.Button()
        Me.dgvStaffExpense = New System.Windows.Forms.DataGridView()

        '==================== OFFICE EXPENSE CONTROLS ====================
        Me.lblOfficeCategory = New System.Windows.Forms.Label()
        Me.cmbOfficeCategory = New System.Windows.Forms.ComboBox()
        Me.lblOfficeMonth = New System.Windows.Forms.Label()
        Me.dtpOfficeMonth = New System.Windows.Forms.DateTimePicker()
        Me.lblOfficeAmount = New System.Windows.Forms.Label()
        Me.txtOfficeAmount = New System.Windows.Forms.TextBox()
        Me.lblOfficePaidBy = New System.Windows.Forms.Label()
        Me.cmbOfficePaidBy = New System.Windows.Forms.ComboBox()
        Me.lblOfficeRemarks = New System.Windows.Forms.Label()
        Me.txtOfficeRemarks = New System.Windows.Forms.TextBox()
        Me.btnOfficeSave = New System.Windows.Forms.Button()
        Me.btnOfficeUpdate = New System.Windows.Forms.Button()
        Me.btnOfficeDelete = New System.Windows.Forms.Button()
        Me.btnOfficeClear = New System.Windows.Forms.Button()
        Me.dgvOfficeExpense = New System.Windows.Forms.DataGridView()

        Me.tabMain.SuspendLayout()
        Me.tabStaff.SuspendLayout()
        Me.tabOffice.SuspendLayout()
        CType(Me.dgvStaffExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOfficeExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '==================== TAB CONTROL ====================
        Me.tabMain.Controls.Add(Me.tabStaff)
        Me.tabMain.Controls.Add(Me.tabOffice)
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(1000, 700)
        Me.tabMain.TabIndex = 0

        '==================== TAB 1 : STAFF EXPENSE ====================
        Me.tabStaff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabStaff.Controls.Add(Me.lblStaffName)
        Me.tabStaff.Controls.Add(Me.cmbStaffName)
        Me.tabStaff.Controls.Add(Me.lblStaffMonth)
        Me.tabStaff.Controls.Add(Me.dtpStaffMonth)
        Me.tabStaff.Controls.Add(Me.lblStaffAmount)
        Me.tabStaff.Controls.Add(Me.txtStaffAmount)
        Me.tabStaff.Controls.Add(Me.lblStaffPaidDate)
        Me.tabStaff.Controls.Add(Me.dtpStaffPaidDate)
        Me.tabStaff.Controls.Add(Me.lblStaffPaidStatus)
        Me.tabStaff.Controls.Add(Me.cmbStaffPaidStatus)
        Me.tabStaff.Controls.Add(Me.lblStaffPaidBy)
        Me.tabStaff.Controls.Add(Me.cmbStaffPaidBy)
        Me.tabStaff.Controls.Add(Me.lblStaffRemarks)
        Me.tabStaff.Controls.Add(Me.txtStaffRemarks)
        Me.tabStaff.Controls.Add(Me.btnStaffSave)
        Me.tabStaff.Controls.Add(Me.btnStaffUpdate)
        Me.tabStaff.Controls.Add(Me.btnStaffDelete)
        Me.tabStaff.Controls.Add(Me.btnStaffClear)
        Me.tabStaff.Controls.Add(Me.dgvStaffExpense)
        Me.tabStaff.Location = New System.Drawing.Point(4, 29)
        Me.tabStaff.Name = "tabStaff"
        Me.tabStaff.Padding = New System.Windows.Forms.Padding(3)
        Me.tabStaff.Size = New System.Drawing.Size(992, 667)
        Me.tabStaff.TabIndex = 0
        Me.tabStaff.Text = "1. Staff / Salary Expense"

        '----- Staff Labels & Controls -----
        Me.lblStaffName.AutoSize = True
        Me.lblStaffName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffName.Location = New System.Drawing.Point(25, 30)
        Me.lblStaffName.Name = "lblStaffName"
        Me.lblStaffName.Size = New System.Drawing.Size(80, 15)
        Me.lblStaffName.Text = "Staff Name :"

        Me.cmbStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbStaffName.FormattingEnabled = True
        Me.cmbStaffName.Location = New System.Drawing.Point(120, 27)
        Me.cmbStaffName.Name = "cmbStaffName"
        Me.cmbStaffName.Size = New System.Drawing.Size(220, 23)
        Me.cmbStaffName.TabIndex = 1

        Me.lblStaffMonth.AutoSize = True
        Me.lblStaffMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffMonth.Location = New System.Drawing.Point(370, 30)
        Me.lblStaffMonth.Name = "lblStaffMonth"
        Me.lblStaffMonth.Size = New System.Drawing.Size(55, 15)
        Me.lblStaffMonth.Text = "Month :"

        Me.dtpStaffMonth.CustomFormat = "MMM-yyyy"
        Me.dtpStaffMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStaffMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStaffMonth.Location = New System.Drawing.Point(440, 27)
        Me.dtpStaffMonth.Name = "dtpStaffMonth"
        Me.dtpStaffMonth.ShowUpDown = True
        Me.dtpStaffMonth.Size = New System.Drawing.Size(130, 23)
        Me.dtpStaffMonth.TabIndex = 2

        Me.lblStaffAmount.AutoSize = True
        Me.lblStaffAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffAmount.Location = New System.Drawing.Point(600, 30)
        Me.lblStaffAmount.Name = "lblStaffAmount"
        Me.lblStaffAmount.Size = New System.Drawing.Size(60, 15)
        Me.lblStaffAmount.Text = "Amount :"

        Me.txtStaffAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStaffAmount.Location = New System.Drawing.Point(675, 27)
        Me.txtStaffAmount.Name = "txtStaffAmount"
        Me.txtStaffAmount.Size = New System.Drawing.Size(130, 23)
        Me.txtStaffAmount.TabIndex = 3

        Me.lblStaffPaidDate.AutoSize = True
        Me.lblStaffPaidDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffPaidDate.Location = New System.Drawing.Point(25, 75)
        Me.lblStaffPaidDate.Name = "lblStaffPaidDate"
        Me.lblStaffPaidDate.Size = New System.Drawing.Size(70, 15)
        Me.lblStaffPaidDate.Text = "Paid Date :"

        Me.dtpStaffPaidDate.Checked = False
        Me.dtpStaffPaidDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStaffPaidDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStaffPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStaffPaidDate.Location = New System.Drawing.Point(120, 72)
        Me.dtpStaffPaidDate.Name = "dtpStaffPaidDate"
        Me.dtpStaffPaidDate.ShowCheckBox = True
        Me.dtpStaffPaidDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpStaffPaidDate.TabIndex = 4

        Me.lblStaffPaidStatus.AutoSize = True
        Me.lblStaffPaidStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffPaidStatus.Location = New System.Drawing.Point(310, 75)
        Me.lblStaffPaidStatus.Name = "lblStaffPaidStatus"
        Me.lblStaffPaidStatus.Size = New System.Drawing.Size(80, 15)
        Me.lblStaffPaidStatus.Text = "Paid Status :"

        Me.cmbStaffPaidStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffPaidStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbStaffPaidStatus.FormattingEnabled = True
        Me.cmbStaffPaidStatus.Items.AddRange(New Object() {"Paid", "Pending", "Partial"})
        Me.cmbStaffPaidStatus.Location = New System.Drawing.Point(400, 72)
        Me.cmbStaffPaidStatus.Name = "cmbStaffPaidStatus"
        Me.cmbStaffPaidStatus.Size = New System.Drawing.Size(130, 23)
        Me.cmbStaffPaidStatus.TabIndex = 5

        Me.lblStaffPaidBy.AutoSize = True
        Me.lblStaffPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffPaidBy.Location = New System.Drawing.Point(560, 75)
        Me.lblStaffPaidBy.Name = "lblStaffPaidBy"
        Me.lblStaffPaidBy.Size = New System.Drawing.Size(55, 15)
        Me.lblStaffPaidBy.Text = "Paid By :"

        Me.cmbStaffPaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStaffPaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbStaffPaidBy.FormattingEnabled = True
        Me.cmbStaffPaidBy.Location = New System.Drawing.Point(630, 72)
        Me.cmbStaffPaidBy.Name = "cmbStaffPaidBy"
        Me.cmbStaffPaidBy.Size = New System.Drawing.Size(175, 23)
        Me.cmbStaffPaidBy.TabIndex = 6

        Me.lblStaffRemarks.AutoSize = True
        Me.lblStaffRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStaffRemarks.Location = New System.Drawing.Point(25, 120)
        Me.lblStaffRemarks.Name = "lblStaffRemarks"
        Me.lblStaffRemarks.Size = New System.Drawing.Size(65, 15)
        Me.lblStaffRemarks.Text = "Remarks :"

        Me.txtStaffRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStaffRemarks.Location = New System.Drawing.Point(120, 117)
        Me.txtStaffRemarks.Multiline = True
        Me.txtStaffRemarks.Name = "txtStaffRemarks"
        Me.txtStaffRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStaffRemarks.Size = New System.Drawing.Size(685, 55)
        Me.txtStaffRemarks.TabIndex = 7

        '----- Staff Buttons -----
        Me.btnStaffSave.BackColor = System.Drawing.Color.FromArgb(0, 150, 0)
        Me.btnStaffSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffSave.ForeColor = System.Drawing.Color.White
        Me.btnStaffSave.Location = New System.Drawing.Point(830, 25)
        Me.btnStaffSave.Name = "btnStaffSave"
        Me.btnStaffSave.Size = New System.Drawing.Size(90, 32)
        Me.btnStaffSave.TabIndex = 8
        Me.btnStaffSave.Text = "Save"
        Me.btnStaffSave.UseVisualStyleBackColor = False

        Me.btnStaffUpdate.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.btnStaffUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffUpdate.ForeColor = System.Drawing.Color.White
        Me.btnStaffUpdate.Location = New System.Drawing.Point(830, 65)
        Me.btnStaffUpdate.Name = "btnStaffUpdate"
        Me.btnStaffUpdate.Size = New System.Drawing.Size(90, 32)
        Me.btnStaffUpdate.TabIndex = 9
        Me.btnStaffUpdate.Text = "Update"
        Me.btnStaffUpdate.UseVisualStyleBackColor = False

        Me.btnStaffDelete.BackColor = System.Drawing.Color.FromArgb(200, 0, 0)
        Me.btnStaffDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffDelete.ForeColor = System.Drawing.Color.White
        Me.btnStaffDelete.Location = New System.Drawing.Point(830, 105)
        Me.btnStaffDelete.Name = "btnStaffDelete"
        Me.btnStaffDelete.Size = New System.Drawing.Size(90, 32)
        Me.btnStaffDelete.TabIndex = 10
        Me.btnStaffDelete.Text = "Delete"
        Me.btnStaffDelete.UseVisualStyleBackColor = False

        Me.btnStaffClear.BackColor = System.Drawing.Color.Gray
        Me.btnStaffClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStaffClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStaffClear.ForeColor = System.Drawing.Color.White
        Me.btnStaffClear.Location = New System.Drawing.Point(830, 145)
        Me.btnStaffClear.Name = "btnStaffClear"
        Me.btnStaffClear.Size = New System.Drawing.Size(90, 32)
        Me.btnStaffClear.TabIndex = 11
        Me.btnStaffClear.Text = "Clear"
        Me.btnStaffClear.UseVisualStyleBackColor = False

        '----- Staff Grid -----
        Me.dgvStaffExpense.AllowUserToAddRows = False
        Me.dgvStaffExpense.AllowUserToDeleteRows = False
        Me.dgvStaffExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStaffExpense.BackgroundColor = System.Drawing.Color.White
        Me.dgvStaffExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffExpense.Location = New System.Drawing.Point(25, 195)
        Me.dgvStaffExpense.MultiSelect = False
        Me.dgvStaffExpense.Name = "dgvStaffExpense"
        Me.dgvStaffExpense.ReadOnly = True
        Me.dgvStaffExpense.RowHeadersVisible = False
        Me.dgvStaffExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStaffExpense.Size = New System.Drawing.Size(940, 450)
        Me.dgvStaffExpense.TabIndex = 12

        '==================== TAB 2 : OFFICE EXPENSE ====================
        Me.tabOffice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tabOffice.Controls.Add(Me.lblOfficeCategory)
        Me.tabOffice.Controls.Add(Me.cmbOfficeCategory)
        Me.tabOffice.Controls.Add(Me.lblOfficeMonth)
        Me.tabOffice.Controls.Add(Me.dtpOfficeMonth)
        Me.tabOffice.Controls.Add(Me.lblOfficeAmount)
        Me.tabOffice.Controls.Add(Me.txtOfficeAmount)
        Me.tabOffice.Controls.Add(Me.lblOfficePaidBy)
        Me.tabOffice.Controls.Add(Me.cmbOfficePaidBy)
        Me.tabOffice.Controls.Add(Me.lblOfficeRemarks)
        Me.tabOffice.Controls.Add(Me.txtOfficeRemarks)
        Me.tabOffice.Controls.Add(Me.btnOfficeSave)
        Me.tabOffice.Controls.Add(Me.btnOfficeUpdate)
        Me.tabOffice.Controls.Add(Me.btnOfficeDelete)
        Me.tabOffice.Controls.Add(Me.btnOfficeClear)
        Me.tabOffice.Controls.Add(Me.dgvOfficeExpense)
        Me.tabOffice.Location = New System.Drawing.Point(4, 29)
        Me.tabOffice.Name = "tabOffice"
        Me.tabOffice.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOffice.Size = New System.Drawing.Size(992, 667)
        Me.tabOffice.TabIndex = 1
        Me.tabOffice.Text = "2. Office Expense"

        '----- Office Labels & Controls -----
        Me.lblOfficeCategory.AutoSize = True
        Me.lblOfficeCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOfficeCategory.Location = New System.Drawing.Point(25, 30)
        Me.lblOfficeCategory.Name = "lblOfficeCategory"
        Me.lblOfficeCategory.Size = New System.Drawing.Size(70, 15)
        Me.lblOfficeCategory.Text = "Category :"

        Me.cmbOfficeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOfficeCategory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbOfficeCategory.FormattingEnabled = True
        Me.cmbOfficeCategory.Location = New System.Drawing.Point(120, 27)
        Me.cmbOfficeCategory.Name = "cmbOfficeCategory"
        Me.cmbOfficeCategory.Size = New System.Drawing.Size(220, 23)
        Me.cmbOfficeCategory.TabIndex = 1

        Me.lblOfficeMonth.AutoSize = True
        Me.lblOfficeMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOfficeMonth.Location = New System.Drawing.Point(370, 30)
        Me.lblOfficeMonth.Name = "lblOfficeMonth"
        Me.lblOfficeMonth.Size = New System.Drawing.Size(55, 15)
        Me.lblOfficeMonth.Text = "Month :"

        Me.dtpOfficeMonth.CustomFormat = "MMM-yyyy"
        Me.dtpOfficeMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpOfficeMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOfficeMonth.Location = New System.Drawing.Point(440, 27)
        Me.dtpOfficeMonth.Name = "dtpOfficeMonth"
        Me.dtpOfficeMonth.ShowUpDown = True
        Me.dtpOfficeMonth.Size = New System.Drawing.Size(130, 23)
        Me.dtpOfficeMonth.TabIndex = 2

        Me.lblOfficeAmount.AutoSize = True
        Me.lblOfficeAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOfficeAmount.Location = New System.Drawing.Point(600, 30)
        Me.lblOfficeAmount.Name = "lblOfficeAmount"
        Me.lblOfficeAmount.Size = New System.Drawing.Size(60, 15)
        Me.lblOfficeAmount.Text = "Amount :"

        Me.txtOfficeAmount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOfficeAmount.Location = New System.Drawing.Point(675, 27)
        Me.txtOfficeAmount.Name = "txtOfficeAmount"
        Me.txtOfficeAmount.Size = New System.Drawing.Size(130, 23)
        Me.txtOfficeAmount.TabIndex = 3

        Me.lblOfficePaidBy.AutoSize = True
        Me.lblOfficePaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOfficePaidBy.Location = New System.Drawing.Point(25, 75)
        Me.lblOfficePaidBy.Name = "lblOfficePaidBy"
        Me.lblOfficePaidBy.Size = New System.Drawing.Size(55, 15)
        Me.lblOfficePaidBy.Text = "Paid By :"

        Me.cmbOfficePaidBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOfficePaidBy.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbOfficePaidBy.FormattingEnabled = True
        Me.cmbOfficePaidBy.Location = New System.Drawing.Point(120, 72)
        Me.cmbOfficePaidBy.Name = "cmbOfficePaidBy"
        Me.cmbOfficePaidBy.Size = New System.Drawing.Size(220, 23)
        Me.cmbOfficePaidBy.TabIndex = 4

        Me.lblOfficeRemarks.AutoSize = True
        Me.lblOfficeRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblOfficeRemarks.Location = New System.Drawing.Point(370, 75)
        Me.lblOfficeRemarks.Name = "lblOfficeRemarks"
        Me.lblOfficeRemarks.Size = New System.Drawing.Size(65, 15)
        Me.lblOfficeRemarks.Text = "Remarks :"

        Me.txtOfficeRemarks.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOfficeRemarks.Location = New System.Drawing.Point(450, 72)
        Me.txtOfficeRemarks.Multiline = True
        Me.txtOfficeRemarks.Name = "txtOfficeRemarks"
        Me.txtOfficeRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOfficeRemarks.Size = New System.Drawing.Size(355, 55)
        Me.txtOfficeRemarks.TabIndex = 5

        '----- Office Buttons -----
        Me.btnOfficeSave.BackColor = System.Drawing.Color.FromArgb(0, 150, 0)
        Me.btnOfficeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficeSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOfficeSave.ForeColor = System.Drawing.Color.White
        Me.btnOfficeSave.Location = New System.Drawing.Point(830, 25)
        Me.btnOfficeSave.Name = "btnOfficeSave"
        Me.btnOfficeSave.Size = New System.Drawing.Size(90, 32)
        Me.btnOfficeSave.TabIndex = 6
        Me.btnOfficeSave.Text = "Save"
        Me.btnOfficeSave.UseVisualStyleBackColor = False

        Me.btnOfficeUpdate.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        Me.btnOfficeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficeUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOfficeUpdate.ForeColor = System.Drawing.Color.White
        Me.btnOfficeUpdate.Location = New System.Drawing.Point(830, 65)
        Me.btnOfficeUpdate.Name = "btnOfficeUpdate"
        Me.btnOfficeUpdate.Size = New System.Drawing.Size(90, 32)
        Me.btnOfficeUpdate.TabIndex = 7
        Me.btnOfficeUpdate.Text = "Update"
        Me.btnOfficeUpdate.UseVisualStyleBackColor = False

        Me.btnOfficeDelete.BackColor = System.Drawing.Color.FromArgb(200, 0, 0)
        Me.btnOfficeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficeDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOfficeDelete.ForeColor = System.Drawing.Color.White
        Me.btnOfficeDelete.Location = New System.Drawing.Point(830, 105)
        Me.btnOfficeDelete.Name = "btnOfficeDelete"
        Me.btnOfficeDelete.Size = New System.Drawing.Size(90, 32)
        Me.btnOfficeDelete.TabIndex = 8
        Me.btnOfficeDelete.Text = "Delete"
        Me.btnOfficeDelete.UseVisualStyleBackColor = False

        Me.btnOfficeClear.BackColor = System.Drawing.Color.Gray
        Me.btnOfficeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOfficeClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnOfficeClear.ForeColor = System.Drawing.Color.White
        Me.btnOfficeClear.Location = New System.Drawing.Point(830, 145)
        Me.btnOfficeClear.Name = "btnOfficeClear"
        Me.btnOfficeClear.Size = New System.Drawing.Size(90, 32)
        Me.btnOfficeClear.TabIndex = 9
        Me.btnOfficeClear.Text = "Clear"
        Me.btnOfficeClear.UseVisualStyleBackColor = False

        '----- Office Grid -----
        Me.dgvOfficeExpense.AllowUserToAddRows = False
        Me.dgvOfficeExpense.AllowUserToDeleteRows = False
        Me.dgvOfficeExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOfficeExpense.BackgroundColor = System.Drawing.Color.White
        Me.dgvOfficeExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOfficeExpense.Location = New System.Drawing.Point(25, 195)
        Me.dgvOfficeExpense.MultiSelect = False
        Me.dgvOfficeExpense.Name = "dgvOfficeExpense"
        Me.dgvOfficeExpense.ReadOnly = True
        Me.dgvOfficeExpense.RowHeadersVisible = False
        Me.dgvOfficeExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOfficeExpense.Size = New System.Drawing.Size(940, 450)
        Me.dgvOfficeExpense.TabIndex = 10

        '==================== FORM SETTINGS ====================
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmOfficeExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Office & Staff Expense Entry"
        Me.tabMain.ResumeLayout(False)
        Me.tabStaff.ResumeLayout(False)
        Me.tabStaff.PerformLayout()
        Me.tabOffice.ResumeLayout(False)
        Me.tabOffice.PerformLayout()
        CType(Me.dgvStaffExpense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOfficeExpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    '==================== CONTROL DECLARATIONS ====================
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabStaff As TabPage
    Friend WithEvents tabOffice As TabPage

    ' Staff
    Friend WithEvents lblStaffName As Label
    Friend WithEvents cmbStaffName As ComboBox
    Friend WithEvents lblStaffMonth As Label
    Friend WithEvents dtpStaffMonth As DateTimePicker
    Friend WithEvents lblStaffAmount As Label
    Friend WithEvents txtStaffAmount As TextBox
    Friend WithEvents lblStaffPaidDate As Label
    Friend WithEvents dtpStaffPaidDate As DateTimePicker
    Friend WithEvents lblStaffPaidStatus As Label
    Friend WithEvents cmbStaffPaidStatus As ComboBox
    Friend WithEvents lblStaffPaidBy As Label
    Friend WithEvents cmbStaffPaidBy As ComboBox
    Friend WithEvents lblStaffRemarks As Label
    Friend WithEvents txtStaffRemarks As TextBox
    Friend WithEvents btnStaffSave As Button
    Friend WithEvents btnStaffUpdate As Button
    Friend WithEvents btnStaffDelete As Button
    Friend WithEvents btnStaffClear As Button
    Friend WithEvents dgvStaffExpense As DataGridView

    ' Office
    Friend WithEvents lblOfficeCategory As Label
    Friend WithEvents cmbOfficeCategory As ComboBox
    Friend WithEvents lblOfficeMonth As Label
    Friend WithEvents dtpOfficeMonth As DateTimePicker
    Friend WithEvents lblOfficeAmount As Label
    Friend WithEvents txtOfficeAmount As TextBox
    Friend WithEvents lblOfficePaidBy As Label
    Friend WithEvents cmbOfficePaidBy As ComboBox
    Friend WithEvents lblOfficeRemarks As Label
    Friend WithEvents txtOfficeRemarks As TextBox
    Friend WithEvents btnOfficeSave As Button
    Friend WithEvents btnOfficeUpdate As Button
    Friend WithEvents btnOfficeDelete As Button
    Friend WithEvents btnOfficeClear As Button
    Friend WithEvents dgvOfficeExpense As DataGridView

End Class