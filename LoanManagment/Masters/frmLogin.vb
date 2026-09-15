Public Class frmLogin

    Private passwordVisible As Boolean = False

    '========================================================
    ' FORM LOAD
    '========================================================
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AcceptButton = btnLogin

        txtPassword.PasswordChar = "●"c
        btnShowPassword.Text = "👁"

        txtId.Focus()

    End Sub


    '========================================================
    ' LOGIN
    '========================================================
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            '------------------------------------------------
            ' CHECK EMPLOYEE ID
            '------------------------------------------------
            If txtId.Text.Trim() = "" Then

                MessageBox.Show(
                    "Please Enter Employee ID",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtId.Focus()
                Exit Sub

            End If


            '------------------------------------------------
            ' CHECK PASSWORD
            '------------------------------------------------
            If txtPassword.Text.Trim() = "" Then

                MessageBox.Show(
                    "Please Enter Password",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtPassword.Focus()
                Exit Sub

            End If


            '------------------------------------------------
            ' LOGIN QUERY
            '------------------------------------------------
            ssql = "SELECT EmpId, FullName " &
                   "FROM RegistrationMaster " &
                   "WHERE EmpId='" & txtId.Text.Trim().Replace("'", "''") & "' " &
                   "AND Password='" & txtPassword.Text.Replace("'", "''") & "'"


            '------------------------------------------------
            ' GET DATA
            '------------------------------------------------
            dt = GetData(ssql)


            '------------------------------------------------
            ' LOGIN SUCCESS
            '------------------------------------------------
            If dt.Rows.Count > 0 Then

                SessionEmpId = dt.Rows(0)("EmpId").ToString()
                SessionEmpName = dt.Rows(0)("FullName").ToString()


                Dim frm As New Form1

                frm.Show()

                Me.Hide()


            Else

                '------------------------------------------------
                ' LOGIN FAILED
                '------------------------------------------------
                MessageBox.Show(
                    "Invalid Employee ID or Password",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtPassword.Clear()
                txtPassword.Focus()

            End If


        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '========================================================
    ' SHOW / HIDE PASSWORD
    '========================================================
    Private Sub btnShowPassword_Click(sender As Object, e As EventArgs) Handles btnShowPassword.Click

        passwordVisible = Not passwordVisible


        If passwordVisible Then

            txtPassword.PasswordChar = ControlChars.NullChar
            btnShowPassword.Text = "🙈"

        Else

            txtPassword.PasswordChar = "●"c
            btnShowPassword.Text = "👁"

        End If


        txtPassword.Focus()

    End Sub


    '========================================================
    ' LOGIN BUTTON HOVER
    '========================================================
    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter

        btnLogin.BackColor = Color.FromArgb(67, 56, 202)

    End Sub


    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave

        btnLogin.BackColor = Color.FromArgb(79, 70, 229)

    End Sub


    '========================================================
    ' EMPLOYEE ID FOCUS
    '========================================================
    Private Sub txtId_Enter(sender As Object, e As EventArgs) Handles txtId.Enter

        txtId.BackColor = Color.White

    End Sub


    Private Sub txtId_Leave(sender As Object, e As EventArgs) Handles txtId.Leave

        txtId.BackColor = Color.FromArgb(249, 250, 251)

    End Sub


    '========================================================
    ' PASSWORD FOCUS
    '========================================================
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter

        txtPassword.BackColor = Color.White

    End Sub


    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        txtPassword.BackColor = Color.FromArgb(249, 250, 251)

    End Sub

End Class

