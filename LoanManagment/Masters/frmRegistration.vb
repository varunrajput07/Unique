
Imports System.Data

Public Class frmRegistration

    ' 0 = New user; greater than 0 = Edit existing user
    Public EmpId As Integer = 0

    Private isLoading As Boolean = False

    '========================================================
    ' FORM LOAD
    '========================================================
    Private Sub frmRegistration_Load(sender As Object,
                  e As EventArgs) Handles MyBase.Load
        Try
            If CmbUsrTyp.Items.Count > 0 Then
                CmbUsrTyp.SelectedIndex = 0
            End If

            If CmbStatus.Items.Count > 0 Then
                CmbStatus.SelectedIndex = 0
            End If

            txtMobile.MaxLength = 10
            txtUserName.MaxLength = 50

            ResetEntry()
            LoadUsers()

        Catch ex As Exception
            MessageBox.Show("Form loading error: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' LOAD ALL USERS / SEARCH USERS
    '========================================================
    Private Sub LoadUsers(Optional searchText As String = "")

        Try
            Dim search As String =
              searchText.Trim().Replace("'", "''")

            ssql =
              "SELECT EmpId, FullName, UserName, " &
              "MobileNo, UserType, ISNULL(IsActive,'Y') AS IsActive " &
              "FROM RegistrationMaster "

            If search <> "" Then
                ssql &= "WHERE FullName LIKE '%" & search & "%' " &
                    "OR UserName LIKE '%" & search & "%' " &
                    "OR MobileNo LIKE '%" & search & "%' "
            End If

            ssql &= "ORDER BY EmpId DESC"

            dt = GetData(ssql)

            If dt Is Nothing Then
                dgvUsers.DataSource = Nothing
                Return
            End If

            isLoading = True

            dgvUsers.DataSource = Nothing
            dgvUsers.DataSource = dt

            ConfigureGrid()

            dgvUsers.ClearSelection()
            dgvUsers.CurrentCell = Nothing

        Catch ex As Exception
            MessageBox.Show("Unable to load users: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        Finally
            isLoading = False
        End Try

    End Sub

    '========================================================
    ' GRID FORMATTING
    '========================================================
    Private Sub ConfigureGrid()

        If dgvUsers.Columns.Contains("EmpId") Then
            dgvUsers.Columns("EmpId").HeaderText = "ID"
            dgvUsers.Columns("EmpId").FillWeight = 40
        End If

        If dgvUsers.Columns.Contains("FullName") Then
            dgvUsers.Columns("FullName").HeaderText = "Full Name"
            dgvUsers.Columns("FullName").FillWeight = 140
        End If

        If dgvUsers.Columns.Contains("UserName") Then
            dgvUsers.Columns("UserName").HeaderText = "Username"
            dgvUsers.Columns("UserName").FillWeight = 100
        End If

        If dgvUsers.Columns.Contains("MobileNo") Then
            dgvUsers.Columns("MobileNo").HeaderText = "Mobile No"
            dgvUsers.Columns("MobileNo").FillWeight = 100
        End If

        If dgvUsers.Columns.Contains("UserType") Then
            dgvUsers.Columns("UserType").HeaderText = "User Type"
            dgvUsers.Columns("UserType").FillWeight = 90
        End If

        If dgvUsers.Columns.Contains("IsActive") Then
            dgvUsers.Columns("IsActive").HeaderText = "Status"
            dgvUsers.Columns("IsActive").FillWeight = 55
        End If

    End Sub

    '========================================================
    ' SEARCH BUTTON
    '========================================================
    Private Sub btnSearch_Click(sender As Object,
                e As EventArgs) Handles btnSearch.Click
        LoadUsers(txtSearch.Text)
    End Sub

    '========================================================
    ' ENTER KEY SEARCH
    '========================================================
    Private Sub txtSearch_KeyDown(sender As Object,
                 e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            LoadUsers(txtSearch.Text)
        End If
    End Sub

    '========================================================
    ' REFRESH BUTTON
    '========================================================
    Private Sub btnRefresh_Click(sender As Object,
                e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadUsers()
        ResetEntry()
    End Sub

    '========================================================
    ' SELECT USER FROM GRID
    '========================================================
    Private Sub dgvUsers_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        If isLoading OrElse e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow =
              dgvUsers.Rows(e.RowIndex)

            If row.Cells("EmpId").Value Is Nothing OrElse
             IsDBNull(row.Cells("EmpId").Value) Then
                Return
            End If

            Dim selectedID As Integer =
              Convert.ToInt32(row.Cells("EmpId").Value)

            LoadRecordDetails(selectedID)

        Catch ex As Exception
            MessageBox.Show("Unable to select user: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

    End Sub

    '========================================================
    ' DOUBLE CLICK USER TO SELECT FOR EDITING
    '========================================================
    Private Sub dgvUsers_CellDoubleClick(
    sender As Object,
    e As DataGridViewCellEventArgs) Handles dgvUsers.CellDoubleClick

        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow =
          dgvUsers.Rows(e.RowIndex)

        If row.Cells("EmpId").Value Is Nothing OrElse
         IsDBNull(row.Cells("EmpId").Value) Then
            Return
        End If

        Dim selectedID As Integer =
          Convert.ToInt32(row.Cells("EmpId").Value)

        LoadRecordDetails(selectedID)

    End Sub

    '========================================================
    ' LOAD SELECTED USER DETAILS
    '========================================================
    Private Sub LoadRecordDetails(id As Integer)

        Try
            ssql =
              "SELECT EmpId, FullName, UserName, " &
              "MobileNo, Password, UserType, " &
              "ISNULL(IsActive,'Y') AS IsActive " &
              "FROM RegistrationMaster " &
              "WHERE EmpId = " & id

            dt = GetData(ssql)

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("Selected user was not found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
                Return
            End If

            Dim row As DataRow = dt.Rows(0)

            EmpId = Convert.ToInt32(
              row("EmpId"))

            txtName.Text = row("FullName").ToString()
            txtUserName.Text = row("UserName").ToString()
            txtMobile.Text = row("MobileNo").ToString()
            txtPassword.Text = row("Password").ToString()

            CmbUsrTyp.SelectedIndex =
              CmbUsrTyp.FindStringExact(
                row("UserType").ToString())

            CmbStatus.SelectedIndex =
              CmbStatus.FindStringExact(
                row("IsActive").ToString())

            btnSave.Text = "Update"
            lblTitle.Text = "EDIT USER - " & txtUserName.Text

        Catch ex As Exception
            MessageBox.Show("Unable to load selected user: " &
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try

    End Sub

    '========================================================
    ' SAVE / UPDATE
    '========================================================
    Private Sub btnSave_Click(sender As Object,
               e As EventArgs) Handles btnSave.Click
        Try
            If Not Required() Then Return

            Dim fullName As String =
              txtName.Text.Trim().Replace("'", "''")

            Dim userName As String =
              txtUserName.Text.Trim().Replace("'", "''")

            Dim mobileNo As String =
              txtMobile.Text.Trim().Replace("'", "''")

            Dim password As String =
              txtPassword.Text.Trim().Replace("'", "''")

            Dim userType As String =
              CmbUsrTyp.Text.Trim().Replace("'", "''")

            Dim isActive As String =
              CmbStatus.Text.Trim().Replace("'", "''")

            ' Check for duplicate username, excluding current record
            ssql =
        "SELECT COUNT(*) FROM RegistrationMaster " &
        "WHERE UserName = '" & userName & "' " &
        "AND EmpId <> " & EmpId

            dt = GetData(ssql)

            If dt IsNot Nothing AndAlso
             Convert.ToInt32(dt.Rows(0)(0)) > 0 Then

                MessageBox.Show("Username is already in use.",
                        "Duplicate Username",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
                txtUserName.Focus()
                Return
            End If

            ' Check for duplicate mobile number
            ssql =
        "SELECT COUNT(*) FROM RegistrationMaster " &
        "WHERE MobileNo = '" & mobileNo & "' " &
        "AND EmpId <> " & EmpId

            dt = GetData(ssql)

            If dt IsNot Nothing AndAlso
             Convert.ToInt32(dt.Rows(0)(0)) > 0 Then

                MessageBox.Show("Mobile number is already in use.",
                        "Duplicate Mobile",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
                txtMobile.Focus()
                Return
            End If

            If EmpId = 0 Then
                '============================================
                ' INSERT NEW USER
                '============================================
                ssql =
          "INSERT INTO RegistrationMaster " &
          "(FullName, UserName, MobileNo, Password, " &
          "UserType, EntBy, EntDt, IsActive) VALUES (" &
          "'" & fullName & "'," &
          "'" & userName & "'," &
          "'" & mobileNo & "'," &
          "'" & password & "'," &
          "'" & userType & "'," &
          "'" & SessionEmpId.ToString().Replace("'", "''") & "'," &
          "GETDATE()," &
          "'" & isActive & "')"

                ExecuteQuery(ssql)

                MessageBox.Show("User saved successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            Else
                '============================================
                ' UPDATE EXISTING USER
                '============================================
                ssql =
          "UPDATE RegistrationMaster SET " &
          "FullName = '" & fullName & "', " &
          "UserName = '" & userName & "', " &
          "MobileNo = '" & mobileNo & "', " &
          "Password = '" & password & "', " &
          "UserType = '" & userType & "', " &
          "IsActive = '" & isActive & "', " &
          "ModBy = '" &
          SessionEmpId.ToString().Replace("'", "''") & "', " &
          "ModDt = GETDATE() " &
          "WHERE EmpId = " & EmpId

                ExecuteQuery(ssql)

                MessageBox.Show("User updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            End If

            ' Refresh the list and clear entry fields
            LoadUsers(txtSearch.Text)
            ResetEntry()

        Catch ex As Exception
            MessageBox.Show("Unable to save user: " & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
        End Try
    End Sub

    '========================================================
    ' VALIDATION
    '========================================================
    Private Function Required() As Boolean

        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter Full Name.")
            txtName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtUserName.Text) Then
            MessageBox.Show("Please enter Username.")
            txtUserName.Focus()
            Return False
        End If

        If txtUserName.Text.Trim().Length < 3 Then
            MessageBox.Show(
              "Username must be at least 3 characters.")
            txtUserName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtMobile.Text) Then
            MessageBox.Show("Please enter Mobile Number.")
            txtMobile.Focus()
            Return False
        End If

        Dim mobile As String = txtMobile.Text.Trim()

        If mobile.Length <> 10 OrElse
         Not mobile.All(Function(c) Char.IsDigit(c)) Then

            MessageBox.Show(
              "Mobile number must contain exactly 10 digits.")
            txtMobile.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter Password.")
            txtPassword.Focus()
            Return False
        End If

        If txtPassword.Text.Trim().Length < 4 Then
            MessageBox.Show(
              "Password must be at least 4 characters.")
            txtPassword.Focus()
            Return False
        End If

        If CmbUsrTyp.SelectedIndex = -1 Then
            MessageBox.Show("Please select User Type.")
            CmbUsrTyp.Focus()
            Return False
        End If

        If CmbStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select User Status.")
            CmbStatus.Focus()
            Return False
        End If

        Return True

    End Function

    '========================================================
    ' MOBILE NUMBER: DIGITS ONLY
    '========================================================
    Private Sub txtMobile_KeyPress(sender As Object,
                 e As KeyPressEventArgs) _
                                   Handles txtMobile.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
         Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    '========================================================
    ' CLEAR / NEW USER
    '========================================================
    Private Sub btnClear_Click(sender As Object,
               e As EventArgs) Handles btnClear.Click
        ResetEntry()
    End Sub

    Private Sub ResetEntry()

        EmpId = 0

        txtName.Clear()
        txtUserName.Clear()
        txtMobile.Clear()
        txtPassword.Clear()

        If CmbUsrTyp.Items.Count > 0 Then
            CmbUsrTyp.SelectedIndex = 0
        End If

        If CmbStatus.Items.Count > 0 Then
            CmbStatus.SelectedIndex = 0
        End If

        btnSave.Text = "Save"
        lblTitle.Text = "USER REGISTRATION & MANAGEMENT"

        dgvUsers.ClearSelection()
        dgvUsers.CurrentCell = Nothing

        txtName.Focus()

    End Sub

    Private Sub btnTogglePwd_Click(sender As Object, e As EventArgs) Handles btnTogglePwd.Click
        If txtPassword.PasswordChar = "*"c Then
            txtPassword.PasswordChar = Chr(0)   ' show plain text
            btnTogglePwd.Text = "🙈"
        Else
            txtPassword.PasswordChar = "*"c     ' mask again
            btnTogglePwd.Text = "👁"
        End If
    End Sub

End Class