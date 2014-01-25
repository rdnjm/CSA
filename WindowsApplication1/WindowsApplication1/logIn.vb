Public Class frmLogIn

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "admin" Then
            If txtPassword.Text = "1" Then
                mainWindow.Show()
                Me.Close()

            Else
                GoTo ent
            End If

        Else
ent:
            MsgBox("You have entered an invalid username/password.", MsgBoxStyle.Exclamation)
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If
    End Sub
End Class
