Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            If txtId.Text.Trim = "" Then
                MessageBox.Show("Please Enter Employee ID")
                txtId.Focus()
                Exit Sub
            End If

            If txtPassword.Text.Trim = "" Then
                MessageBox.Show("Please Enter Password")
                txtPassword.Focus()
                Exit Sub
            End If

            ssql = "SELECT * FROM RegistrationMaster WHERE EmpId='" & txtId.Text & "' AND Password='" & txtPassword.Text & "'"

            dt = GetData(ssql)

            If dt.Rows.Count > 0 Then

                SessionEmpId = dt.Rows(0)("EmpId").ToString()
                SessionEmpName = dt.Rows(0)("FullName").ToString()

                Dim frm As New Form1
                frm.Show()

                Me.Hide()

            Else

                MessageBox.Show("Invalid Employee ID or Password")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = btnLogin
    End Sub
End Class