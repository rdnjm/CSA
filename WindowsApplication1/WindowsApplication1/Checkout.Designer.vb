<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TestDataSet = New WindowsApplication1.TestDataSet()
        Me.TestDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.StudentTableAdapter()
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FacultyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacultyTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.FacultyTableAdapter()
        Me.faculty_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(168, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 27)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Query:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Student Name", "Last Name", "First Name"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(352, 25)
        Me.ComboBox1.TabIndex = 3
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 75)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Student"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(134, 75)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 21)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Faculty"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 102)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(565, 109)
        Me.DataGridView1.TabIndex = 6
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "TestDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestDataSetBindingSource
        '
        Me.TestDataSetBindingSource.DataSource = Me.TestDataSet
        Me.TestDataSetBindingSource.Position = 0
        '
        'TryTestDataSet
        '
        Me.TryTestDataSet.DataSetName = "tryTestDataSet"
        Me.TryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.TryTestDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "studentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "studentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        Me.StudentNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.faculty_Number, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView2.DataSource = Me.FacultyBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(16, 102)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(665, 109)
        Me.DataGridView2.TabIndex = 7
        '
        'FacultyBindingSource
        '
        Me.FacultyBindingSource.DataMember = "Faculty"
        Me.FacultyBindingSource.DataSource = Me.TryTestDataSet
        '
        'FacultyTableAdapter
        '
        Me.FacultyTableAdapter.ClearBeforeFill = True
        '
        'faculty_Number
        '
        Me.faculty_Number.DataPropertyName = "faculty_Number"
        Me.faculty_Number.HeaderText = "faculty_Number"
        Me.faculty_Number.Name = "faculty_Number"
        Me.faculty_Number.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "lastName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "firstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Button4.Location = New System.Drawing.Point(531, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 50)
        Me.Button4.TabIndex = 11
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.confirm
        Me.Button3.Location = New System.Drawing.Point(370, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 50)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.new_user
        Me.Button2.Location = New System.Drawing.Point(214, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 50)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search
        Me.Button1.Location = New System.Drawing.Point(531, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 281)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Checkout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TestDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestDataSet As WindowsApplication1.TestDataSet
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents FacultyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacultyTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.FacultyTableAdapter
    Friend WithEvents faculty_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
