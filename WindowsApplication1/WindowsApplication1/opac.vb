Public Class frmOpac

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ComboBox1.ResetText()
        TextBox1.Text = ""

    End Sub

    Private Sub frmOpac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.Lib_System' table. You can move, or remove it, as needed.
        Me.Lib_SystemTableAdapter.Fill(Me.TestDataSet.Lib_System)

    End Sub
End Class