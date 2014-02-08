Public Class Student_Faculty_Account

    Private Sub Student_Faculty_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TryTestDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.TryTestDataSet.Student)
        'TODO: This line of code loads data into the 'TryTestDataSet.Faculty' table. You can move, or remove it, as needed.
        Me.FacultyTableAdapter.Fill(Me.TryTestDataSet.Faculty)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newUser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class