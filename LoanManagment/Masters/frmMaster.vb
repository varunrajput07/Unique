Public Class frmMaster

    '====================================================
    ' FORM LOAD
    '====================================================

    Private Sub frmMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            InitializeMasters()

            '--------------------------------------------
            ' MASTER COMBO
            '--------------------------------------------

            CboMaster.Items.Clear()

            For Each masterName As String In MasterList.Keys

                CboMaster.Items.Add(masterName)

            Next


            '--------------------------------------------
            ' STATUS COMBO
            '--------------------------------------------

            CboStatus.Items.Clear()

            CboStatus.Items.Add("ACTIVE")
            CboStatus.Items.Add("INACTIVE")


            If CboStatus.Items.Count > 0 Then

                CboStatus.SelectedIndex = 0

            End If


            '--------------------------------------------
            ' HIDE PARENT INITIALLY
            '--------------------------------------------

            CboParent.Visible = False
            lblParent.Visible = False


            '--------------------------------------------
            ' GRID
            '--------------------------------------------

            dgvMaster.ReadOnly = True

            dgvMaster.AllowUserToAddRows = False

            dgvMaster.AllowUserToDeleteRows = False

            dgvMaster.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvMaster.MultiSelect = False

            dgvMaster.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill


            '--------------------------------------------
            ' SELECT FIRST MASTER
            '--------------------------------------------

            If CboMaster.Items.Count > 0 Then

                CboMaster.SelectedIndex = 0

            End If


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' GET CURRENT MASTER
    '====================================================

    Private Function GetCurrentMaster() As MasterConfig

        If CboMaster.SelectedIndex = -1 Then

            Return Nothing

        End If


        If MasterList.ContainsKey(CboMaster.Text) Then

            Return MasterList(CboMaster.Text)

        End If


        Return Nothing

    End Function


    '====================================================
    ' MASTER CHANGE
    '====================================================

    Private Sub CboMaster_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles CboMaster.SelectedIndexChanged

        Try

            ClearFields()

            LoadParentData()

            LoadMasterData()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' LOAD PARENT DATA
    '====================================================

    Private Sub LoadParentData()

        Dim config As MasterConfig =
            GetCurrentMaster()


        If config Is Nothing Then Return


        '--------------------------------------------
        ' NORMAL MASTER
        '--------------------------------------------

        If String.IsNullOrWhiteSpace(
            config.ParentTableName) Then

            CboParent.Visible = False

            lblParent.Visible = False

            CboParent.DataSource = Nothing

            CboParent.Items.Clear()

            Return

        End If


        '--------------------------------------------
        ' PARENT-CHILD MASTER
        '--------------------------------------------

        CboParent.Visible = True

        lblParent.Visible = True

        lblParent.Text = "Product"


        CboParent.DataSource = Nothing

        CboParent.Items.Clear()


        ssql = "SELECT " &
               config.ParentIDColumn & ", " &
               config.ParentNameColumn &
               " FROM " &
               config.ParentTableName &
               " WHERE IsActive='Y'" &
               " ORDER BY " &
               config.ParentNameColumn


        dt = GetData(ssql)


        If dt.Rows.Count = 0 Then

            Return

        End If


        CboParent.DataSource = dt

        CboParent.DisplayMember =
            config.ParentNameColumn

        CboParent.ValueMember =
            config.ParentIDColumn

    End Sub


    '====================================================
    ' LOAD MASTER DATA
    '====================================================

    Private Sub LoadMasterData()

        Dim config As MasterConfig =
            GetCurrentMaster()


        If config Is Nothing Then Return


        If String.IsNullOrWhiteSpace(
            config.ParentTableName) Then

            '----------------------------------------
            ' NORMAL MASTER
            '----------------------------------------

            ssql = "SELECT " &
                   config.IDColumn & ", " &
                   config.NameColumn & ", " &
                   config.ActiveColumn &
                   " FROM " &
                   config.TableName &
                   " ORDER BY " &
                   config.IDColumn & " DESC"

        Else

            '----------------------------------------
            ' PRODUCT SUB MASTER
            '----------------------------------------

            ssql = "SELECT " &
                   "S." & config.IDColumn & ", " &
                   "S." & config.NameColumn & ", " &
                   "S." & config.ActiveColumn & ", " &
                   "S." & config.ForeignKeyColumn & ", " &
                   "P." & config.ParentNameColumn &
                   " AS ParentName " &
                   "FROM " & config.TableName & " S " &
                   "LEFT JOIN " &
                   config.ParentTableName & " P ON " &
                   "S." & config.ForeignKeyColumn &
                   " = P." & config.ParentIDColumn &
                   " ORDER BY S." &
                   config.IDColumn & " DESC"

        End If


        dt = GetData(ssql)

        dgvMaster.DataSource = dt


        '--------------------------------------------
        ' GRID HEADERS
        '--------------------------------------------

        If dgvMaster.Columns.Count > 0 Then

            dgvMaster.Columns(
                config.IDColumn).HeaderText = "ID"

            dgvMaster.Columns(
                config.NameColumn).HeaderText = "Name"

            dgvMaster.Columns(
                config.ActiveColumn).HeaderText = "Status"


            If Not String.IsNullOrWhiteSpace(
                config.ParentTableName) Then

                dgvMaster.Columns(
                    config.ForeignKeyColumn).HeaderText =
                    "Product ID"

                dgvMaster.Columns(
                    "ParentName").HeaderText =
                    "Product"

            End If

        End If

    End Sub


    '====================================================
    ' SAVE
    '====================================================

    Private Sub btnSave_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSave.Click

        Try

            Dim config As MasterConfig =
                GetCurrentMaster()


            If config Is Nothing Then

                MessageBox.Show(
                    "Please select Master.",
                    "Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return

            End If


            '--------------------------------------------
            ' VALUE REQUIRED
            '--------------------------------------------

            If txtValue.Text.Trim() = "" Then

                MessageBox.Show(
                    "Please enter value.",
                    "Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                txtValue.Focus()

                Return

            End If


            '--------------------------------------------
            ' STATUS REQUIRED
            '--------------------------------------------

            If CboStatus.SelectedIndex = -1 Then

                MessageBox.Show(
                    "Please select Status.",
                    "Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return

            End If


            '--------------------------------------------
            ' STATUS
            '--------------------------------------------

            Dim status As String

            If CboStatus.Text = "ACTIVE" Then

                status = "Y"

            Else

                status = "N"

            End If


            '--------------------------------------------
            ' CHECK PARENT
            '--------------------------------------------

            Dim parentID As Integer = 0


            If Not String.IsNullOrWhiteSpace(
                config.ParentTableName) Then


                If CboParent.SelectedIndex = -1 OrElse
                   CboParent.SelectedValue Is Nothing Then

                    MessageBox.Show(
                        "Please select Product.",
                        "Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

                    Return

                End If


                parentID =
                    Convert.ToInt32(
                        CboParent.SelectedValue)

            End If


            '--------------------------------------------
            ' DUPLICATE CHECK
            '--------------------------------------------

            If parentID > 0 Then

                ssql = "SELECT " &
                       config.IDColumn &
                       " FROM " &
                       config.TableName &
                       " WHERE " &
                       config.NameColumn &
                       "='" &
                       txtValue.Text.Trim() &
                       "' AND " &
                       config.ForeignKeyColumn &
                       "=" & parentID

            Else

                ssql = "SELECT " &
                       config.IDColumn &
                       " FROM " &
                       config.TableName &
                       " WHERE " &
                       config.NameColumn &
                       "='" &
                       txtValue.Text.Trim() &
                       "'"

            End If


            dt = GetData(ssql)


            If dt.Rows.Count > 0 Then

                MessageBox.Show(
                    "This record already exists.",
                    "Duplicate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return

            End If


            '--------------------------------------------
            ' INSERT
            '--------------------------------------------

            If parentID > 0 Then

                ssql = "INSERT INTO " &
                       config.TableName &
                       " (" &
                       config.NameColumn & "," &
                       config.ActiveColumn & "," &
                       config.ForeignKeyColumn &
                       ") VALUES (" &
                       "'" & txtValue.Text.Trim() & "'," &
                       "'" & status & "'," &
                       parentID & ")"

            Else

                ssql = "INSERT INTO " &
                       config.TableName &
                       " (" &
                       config.NameColumn & "," &
                       config.ActiveColumn &
                       ") VALUES (" &
                       "'" & txtValue.Text.Trim() & "'," &
                       "'" & status & "')"

            End If


            ExecuteQuery(ssql)


            MessageBox.Show(
                "Record saved successfully.",
                "Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)


            ClearFields()

            LoadParentData()

            LoadMasterData()


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Save Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' GRID ROW CLICK
    '====================================================

    Private Sub dgvMaster_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvMaster.CellClick

        Try

            If e.RowIndex < 0 Then Return


            Dim config As MasterConfig =
                GetCurrentMaster()


            If config Is Nothing Then Return


            Dim row As DataGridViewRow =
                dgvMaster.Rows(e.RowIndex)


            '--------------------------------------------
            ' VALUE
            '--------------------------------------------

            If row.Cells(config.NameColumn).Value IsNot Nothing Then

                txtValue.Text =
                    row.Cells(
                        config.NameColumn
                    ).Value.ToString()

            End If


            '--------------------------------------------
            ' STATUS
            '--------------------------------------------

            If row.Cells(config.ActiveColumn).Value IsNot Nothing Then

                Dim dbStatus As String =
                    row.Cells(
                        config.ActiveColumn
                    ).Value.ToString()


                If dbStatus = "Y" Then

                    CboStatus.Text = "ACTIVE"

                Else

                    CboStatus.Text = "INACTIVE"

                End If

            End If


            '--------------------------------------------
            ' PARENT PRODUCT
            '--------------------------------------------

            If Not String.IsNullOrWhiteSpace(
                config.ParentTableName) Then


                If row.Cells(
                    config.ForeignKeyColumn).Value IsNot Nothing Then


                    Dim productID As Integer =
                        Convert.ToInt32(
                            row.Cells(
                                config.ForeignKeyColumn
                            ).Value)


                    CboParent.SelectedValue =
                        productID

                End If

            End If


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' UPDATE
    '====================================================

    Private Sub btnUpdate_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpdate.Click

        Try

            Dim config As MasterConfig =
                GetCurrentMaster()


            If config Is Nothing Then

                Return

            End If


            '--------------------------------------------
            ' ROW REQUIRED
            '--------------------------------------------

            If dgvMaster.CurrentRow Is Nothing Then

                MessageBox.Show(
                    "Please select a record.",
                    "Update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return

            End If


            '--------------------------------------------
            ' VALUE REQUIRED
            '--------------------------------------------

            If txtValue.Text.Trim() = "" Then

                MessageBox.Show(
                    "Please enter value.",
                    "Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                txtValue.Focus()

                Return

            End If


            '--------------------------------------------
            ' STATUS
            '--------------------------------------------

            If CboStatus.SelectedIndex = -1 Then

                MessageBox.Show(
                    "Please select Status.",
                    "Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return

            End If


            Dim status As String

            If CboStatus.Text = "ACTIVE" Then

                status = "Y"

            Else

                status = "N"

            End If


            '--------------------------------------------
            ' GET PRIMARY KEY
            '--------------------------------------------

            Dim idValue As Integer =
                Convert.ToInt32(
                    dgvMaster.CurrentRow.Cells(
                        config.IDColumn
                    ).Value)


            '--------------------------------------------
            ' UPDATE PRODUCT SUB
            '--------------------------------------------

            If Not String.IsNullOrWhiteSpace(
                config.ParentTableName) Then


                If CboParent.SelectedIndex = -1 OrElse
                   CboParent.SelectedValue Is Nothing Then

                    MessageBox.Show(
                        "Please select Product.",
                        "Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

                    Return

                End If


                Dim parentID As Integer =
                    Convert.ToInt32(
                        CboParent.SelectedValue)


                'Duplicate check

                ssql = "SELECT " &
                       config.IDColumn &
                       " FROM " &
                       config.TableName &
                       " WHERE " &
                       config.NameColumn &
                       "='" &
                       txtValue.Text.Trim() &
                       "' AND " &
                       config.ForeignKeyColumn &
                       "=" & parentID &
                       " AND " &
                       config.IDColumn &
                       "<>" & idValue


                dt = GetData(ssql)


                If dt.Rows.Count > 0 Then

                    MessageBox.Show(
                        "This Product Sub already exists for the selected Product.",
                        "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

                    Return

                End If


                'UPDATE

                ssql = "UPDATE " &
                       config.TableName &
                       " SET " &
                       config.NameColumn &
                       "='" & txtValue.Text.Trim() & "'," &
                       config.ActiveColumn &
                       "='" & status & "'," &
                       config.ForeignKeyColumn &
                       "=" & parentID &
                       " WHERE " &
                       config.IDColumn &
                       "=" & idValue


            Else

                '----------------------------------------
                ' NORMAL MASTER
                '----------------------------------------

                'Duplicate check

                ssql = "SELECT " &
                       config.IDColumn &
                       " FROM " &
                       config.TableName &
                       " WHERE " &
                       config.NameColumn &
                       "='" &
                       txtValue.Text.Trim() &
                       "' AND " &
                       config.IDColumn &
                       "<>" & idValue


                dt = GetData(ssql)


                If dt.Rows.Count > 0 Then

                    MessageBox.Show(
                        "This record already exists.",
                        "Duplicate",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

                    Return

                End If


                'UPDATE

                ssql = "UPDATE " &
                       config.TableName &
                       " SET " &
                       config.NameColumn &
                       "='" & txtValue.Text.Trim() & "'," &
                       config.ActiveColumn &
                       "='" & status & "'" &
                       " WHERE " &
                       config.IDColumn &
                       "=" & idValue

            End If


            ExecuteQuery(ssql)


            MessageBox.Show(
                "Record updated successfully.",
                "Update",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)


            ClearFields()

            LoadParentData()

            LoadMasterData()


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Update Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' DELETE
    '====================================================

    Private Sub btnDelete_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDelete.Click

        Try

            Dim config As MasterConfig =
                GetCurrentMaster()


            If config Is Nothing Then Return


            If dgvMaster.CurrentRow Is Nothing Then

                MessageBox.Show(
                    "Please select a record.",
                    "Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return

            End If


            Dim answer As DialogResult =
                MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)


            If answer <> DialogResult.Yes Then

                Return

            End If


            Dim idValue As Integer =
                Convert.ToInt32(
                    dgvMaster.CurrentRow.Cells(
                        config.IDColumn
                    ).Value)


            '--------------------------------------------
            ' DELETE
            '--------------------------------------------

            ssql = "DELETE FROM " &
                   config.TableName &
                   " WHERE " &
                   config.IDColumn &
                   "=" & idValue


            ExecuteQuery(ssql)


            MessageBox.Show(
                "Record deleted successfully.",
                "Delete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)


            ClearFields()

            LoadParentData()

            LoadMasterData()


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Delete Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' SEARCH
    '====================================================

    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        Try

            Dim config As MasterConfig =
                GetCurrentMaster()


            If config Is Nothing Then Return


            If txtSearch.Text.Trim() = "" Then

                LoadMasterData()

                Return

            End If


            If String.IsNullOrWhiteSpace(
                config.ParentTableName) Then


                '----------------------------------------
                ' NORMAL MASTER SEARCH
                '----------------------------------------

                ssql = "SELECT " &
                       config.IDColumn & ", " &
                       config.NameColumn & ", " &
                       config.ActiveColumn &
                       " FROM " &
                       config.TableName &
                       " WHERE " &
                       config.NameColumn &
                       " LIKE '%" &
                       txtSearch.Text.Trim() &
                       "%' ORDER BY " &
                       config.IDColumn &
                       " DESC"


            Else


                '----------------------------------------
                ' PRODUCT SUB SEARCH
                '----------------------------------------

                ssql = "SELECT " &
                       "S." & config.IDColumn & ", " &
                       "S." & config.NameColumn & ", " &
                       "S." & config.ActiveColumn & ", " &
                       "S." & config.ForeignKeyColumn & ", " &
                       "P." & config.ParentNameColumn &
                       " AS ParentName " &
                       "FROM " &
                       config.TableName & " S " &
                       "LEFT JOIN " &
                       config.ParentTableName & " P ON " &
                       "S." & config.ForeignKeyColumn &
                       " = P." & config.ParentIDColumn &
                       " WHERE S." &
                       config.NameColumn &
                       " LIKE '%" &
                       txtSearch.Text.Trim() &
                       "%' OR P." &
                       config.ParentNameColumn &
                       " LIKE '%" &
                       txtSearch.Text.Trim() &
                       "%' ORDER BY S." &
                       config.IDColumn & " DESC"

            End If


            dt = GetData(ssql)

            dgvMaster.DataSource = dt


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Search Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' REFRESH
    '====================================================

    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        Try

            ClearFields()

            LoadParentData()

            LoadMasterData()


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

        End Try

    End Sub


    '====================================================
    ' CLEAR
    '====================================================

    Private Sub ClearFields()

        txtValue.Clear()

        txtSearch.Clear()


        If CboStatus.Items.Count > 0 Then

            CboStatus.SelectedIndex = 0

        End If


        If CboParent.Visible AndAlso
           CboParent.Items.Count > 0 Then

            CboParent.SelectedIndex = 0

        End If


        dgvMaster.ClearSelection()

    End Sub

End Class