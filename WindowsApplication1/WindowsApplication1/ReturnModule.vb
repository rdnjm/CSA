Public Class ReturnModule

    Private Sub ReturnModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TryTestDataSet.Borrower_Tab' table. You can move, or remove it, as needed.
        Me.Borrower_TabTableAdapter.Fill(Me.TryTestDataSet.Borrower_Tab)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        returnConfirm.Show()
    End Sub
End Class