<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Faculty_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Faculty_Account))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacultyNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacultyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.FacultyTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.FacultyTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LibraryNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.StudentTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FacultyNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FacultyBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 184)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FacultyNumberDataGridViewTextBoxColumn
        '
        Me.FacultyNumberDataGridViewTextBoxColumn.DataPropertyName = "faculty_Number"
        Me.FacultyNumberDataGridViewTextBoxColumn.HeaderText = "faculty_Number"
        Me.FacultyNumberDataGridViewTextBoxColumn.Name = "FacultyNumberDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "middleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "middleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "contactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "contactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'FacultyBindingSource
        '
        Me.FacultyBindingSource.DataMember = "Faculty"
        Me.FacultyBindingSource.DataSource = Me.TryTestDataSet
        '
        'TryTestDataSet
        '
        Me.TryTestDataSet.DataSetName = "tryTestDataSet"
        Me.TryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacultyTableAdapter
        '
        Me.FacultyTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LibraryNumberDataGridViewTextBoxColumn, Me.StudentNumberDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn1, Me.FirstNameDataGridViewTextBoxColumn1, Me.MiddleNameDataGridViewTextBoxColumn1, Me.ContactNumberDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.StudentBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 32)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(663, 184)
        Me.DataGridView2.TabIndex = 2
        '
        'LibraryNumberDataGridViewTextBoxColumn
        '
        Me.LibraryNumberDataGridViewTextBoxColumn.DataPropertyName = "libraryNumber"
        Me.LibraryNumberDataGridViewTextBoxColumn.HeaderText = "libraryNumber"
        Me.LibraryNumberDataGridViewTextBoxColumn.Name = "LibraryNumberDataGridViewTextBoxColumn"
        '
        'StudentNumberDataGridViewTextBoxColumn
        '
        Me.StudentNumberDataGridViewTextBoxColumn.DataPropertyName = "studentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.HeaderText = "studentNumber"
        Me.StudentNumberDataGridViewTextBoxColumn.Name = "StudentNumberDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn1
        '
        Me.LastNameDataGridViewTextBoxColumn1.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn1.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn1.Name = "LastNameDataGridViewTextBoxColumn1"
        '
        'FirstNameDataGridViewTextBoxColumn1
        '
        Me.FirstNameDataGridViewTextBoxColumn1.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn1.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn1.Name = "FirstNameDataGridViewTextBoxColumn1"
        '
        'MiddleNameDataGridViewTextBoxColumn1
        '
        Me.MiddleNameDataGridViewTextBoxColumn1.DataPropertyName = "middleName"
        Me.MiddleNameDataGridViewTextBoxColumn1.HeaderText = "middleName"
        Me.MiddleNameDataGridViewTextBoxColumn1.Name = "MiddleNameDataGridViewTextBoxColumn1"
        '
        'ContactNumberDataGridViewTextBoxColumn1
        '
        Me.ContactNumberDataGridViewTextBoxColumn1.DataPropertyName = "contactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn1.HeaderText = "contactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn1.Name = "ContactNumberDataGridViewTextBoxColumn1"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Faculty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Student"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.close
        Me.Button2.Location = New System.Drawing.Point(681, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 52)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.new_user
        Me.Button1.Location = New System.Drawing.Point(681, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 52)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Student_Faculty_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 436)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Student_Faculty_Account"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Faculty Account"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacultyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents FacultyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacultyTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.FacultyTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacultyNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents LibraryNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
