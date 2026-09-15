Public Class Form1
    Private tabForms As New TabControl()
    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Try

            ssql = "select * from  RegistrationMaster WHERE UserType='Super Admin'  and EmpId='" & SessionEmpId & "'"
            dt = GetData(ssql)

            If dt.Rows.Count = 1 Then
                Dim frm As New frmRegistration()
                frm.Show()
            Else
                MessageBox.Show("You are not allowed to open this form.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserInfo.Text = "👤 " & SessionEmpName & " (ID - " & SessionEmpId & ")"

        Me.IsMdiContainer = True
        Me.BackColor = Color.FromArgb(241, 245, 249)

        ' Apply background color match to the MDI container area
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = Color.FromArgb(241, 245, 249)
            End If
        Next

        tabForms.Dock = DockStyle.Top
        tabForms.Height = 25

        Me.Controls.Add(tabForms)
        StartGlobalDatePicker()
    End Sub

    Private Sub CarLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarLoanToolStripMenuItem.Click
        Try
            Dim frm As New frmLeadMIS()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LOGINMISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINMISToolStripMenuItem.Click
        Try
            Dim frm As New frmLoginMIS()
            frm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub OpenChildForm(childForm As Form)

        'Check if the form is already open
        For Each openForm As Form In Me.MdiChildren

            If openForm.GetType() = childForm.GetType() Then

                openForm.Activate()

                For Each existingTab As TabPage In tabForms.TabPages

                    If existingTab.Tag Is openForm Then
                        tabForms.SelectedTab = existingTab
                        Exit For
                    End If

                Next

                childForm.Dispose()
                Return

            End If

        Next


        'Set MDI parent
        childForm.MdiParent = Me
        childForm.WindowState = FormWindowState.Maximized


        'Create new tab
        Dim newTab As New TabPage(childForm.Text)

        newTab.Tag = childForm

        tabForms.TabPages.Add(newTab)
        tabForms.SelectedTab = newTab

        'Show child form
        childForm.Show()

        'Remove tab when form closes
        AddHandler childForm.FormClosed,
        Sub(sender As Object, e As FormClosedEventArgs)

            For Each existingTab As TabPage In tabForms.TabPages

                If existingTab.Tag Is childForm Then

                    tabForms.TabPages.Remove(existingTab)
                    Exit For

                End If

            Next

        End Sub

    End Sub

    Private Sub MastersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MastersToolStripMenuItem.Click
        Try

            ssql = "select * from  RegistrationMaster WHERE UserType='Super Admin'  and EmpId='" & SessionEmpId & "'"
            dt = GetData(ssql)

            If dt.Rows.Count = 1 Then
                Dim frm As New frmMaster()
                frm.Show()
            Else
                MessageBox.Show("You are not allowed to open this form.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EXPENSEMISToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPENSEMISToolStripMenuItem.Click
        Try

            ssql = "select * from  RegistrationMaster WHERE UserType='Super Admin' and EmpId='" & SessionEmpId & "'"
            dt = GetData(ssql)

            If dt.Rows.Count = 1 Then
                Dim frm As New frmExpenseMIS()
                frm.Show()
            Else
                MessageBox.Show("You are not allowed to open this form.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
