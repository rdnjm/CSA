Public Class BookList
    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Lib_SystemTableAdapter.Fill(Me.TryTestDataSet.Lib_System)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addBook.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editBook.Show()
    End Sub
End Class