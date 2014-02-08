Public Class Borrow

    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TryTestDataSet.Lib_System' table. You can move, or remove it, as needed.
        Me.Lib_SystemTableAdapter.Fill(Me.TryTestDataSet.Lib_System)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Checkout.Show()
    End Sub
End Class