Public Class frmRegistration
    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CmbUsrTyp.SelectedIndex = 0
            CmbStatus.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ssql = "INSERT INTO RegistrationMaster(FullName,MobileNo,Password,UserType,EntBy,EntDt,IsActive) VALUES 
                        ('" & txtName.Text & "','" & txtMobile.Text & "','" & txtPassword.Text & "','" & CmbUsrTyp.Text & "','" & SessionEmpId & "',getdate(),'Y')"

            ExecuteQuery(ssql)

            MessageBox.Show("Record Saved Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class