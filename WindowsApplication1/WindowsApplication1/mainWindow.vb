Public Class mainWindow

    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmOpac.Show()
    End Sub
End Class