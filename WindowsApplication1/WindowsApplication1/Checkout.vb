Public Class Checkout

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DataGridView2.Visible = True
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Faculty Number")
        ComboBox1.Items.Add("Last Name")
        ComboBox1.Items.Add("First Name")
        Me.FacultyTableAdapter.Fill(Me.TryTestDataSet.Faculty)
        DataGridView1.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DataGridView1.Visible = True
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Student Number")
        ComboBox1.Items.Add("Last Name")
        ComboBox1.Items.Add("First Name")
        Me.StudentTableAdapter.Fill(Me.TryTestDataSet.Student)
        DataGridView2.Visible = False

    End Sub

    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        newUser.Show()
    End Sub
End Class