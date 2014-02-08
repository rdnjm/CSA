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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPassword.Clear()
        txtUsername.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
