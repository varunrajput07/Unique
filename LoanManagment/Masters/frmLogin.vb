Public Class frmLogin

    Private passwordVisible As Boolean = False

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AcceptButton = btnLogin

        txtPassword.PasswordChar = "●"c
        btnShowPassword.Text = "👁"

        txtUsername.Focus()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try
            If txtUsername.Text.Trim() = "" Then

                MessageBox.Show(
                    "Please Enter Username",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtUsername.Focus()
                Exit Sub

            End If

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

            ssql = "SELECT EmpId,UserName, FullName, UserType, IsActive " &
                   "FROM RegistrationMaster " &
                   "WHERE UserName='" & txtUsername.Text.Trim().Replace("'", "''") & "' " &
                   "AND Password='" & txtPassword.Text.Replace("'", "''") & "'"

            dt = GetData(ssql)

            If dt.Rows.Count > 0 Then

                If dt.Rows(0)("IsActive").ToString().Trim().ToUpper() <> "Y" Then

                    MessageBox.Show(
                        "This account is inactive. Please contact the administrator.",
                        "Login Blocked",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

                    txtPassword.Clear()
                    txtPassword.Focus()
                    Exit Sub

                End If

                SessionUserName = dt.Rows(0)("UserName").ToString()
                SessionEmpName = dt.Rows(0)("FullName").ToString()
                SessionUsrTyp = dt.Rows(0)("UserType").ToString()
                SessionEmpId = dt.Rows(0)("EmpId").ToString()


                Dim frm As New Form1

                frm.Show()

                Me.Hide()


            Else

                '------------------------------------------------
                ' LOGIN FAILED
                '------------------------------------------------
                MessageBox.Show(
                    "Invalid Username or Password",
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
    ' USERNAME FOCUS
    '========================================================
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter

        txtUsername.BackColor = Color.White

    End Sub


    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave

        txtUsername.BackColor = Color.FromArgb(249, 250, 251)

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