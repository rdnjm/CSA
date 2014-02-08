<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookList))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LibSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.Lib_SystemTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.Lib_SystemTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibSystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkBox, Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.CallNumberDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibSystemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(655, 411)
        Me.DataGridView1.TabIndex = 0
        '
        'LibSystemBindingSource
        '
        Me.LibSystemBindingSource.DataMember = "Lib_System"
        Me.LibSystemBindingSource.DataSource = Me.TryTestDataSet
        '
        'TryTestDataSet
        '
        Me.TryTestDataSet.DataSetName = "tryTestDataSet"
        Me.TryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lib_SystemTableAdapter
        '
        Me.Lib_SystemTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.delete
        Me.Button3.Location = New System.Drawing.Point(674, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 55)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.edit
        Me.Button2.Location = New System.Drawing.Point(674, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 55)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add1
        Me.Button1.Location = New System.Drawing.Point(674, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'checkBox
        '
        Me.checkBox.HeaderText = ""
        Me.checkBox.MinimumWidth = 30
        Me.checkBox.Name = "checkBox"
        Me.checkBox.ReadOnly = True
        Me.checkBox.Width = 30
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 30
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 30
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CallNumberDataGridViewTextBoxColumn
        '
        Me.CallNumberDataGridViewTextBoxColumn.DataPropertyName = "Call Number"
        Me.CallNumberDataGridViewTextBoxColumn.HeaderText = "Call Number"
        Me.CallNumberDataGridViewTextBoxColumn.Name = "CallNumberDataGridViewTextBoxColumn"
        Me.CallNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BookList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 436)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BookList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents LibSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lib_SystemTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.Lib_SystemTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents checkBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CallNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
