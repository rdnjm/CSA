<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrow))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LibSystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.Lib_SystemTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.Lib_SystemTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(167, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(346, 27)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Query:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search By:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Title", "Author", "Category", "Call Number"})
        Me.ComboBox1.Location = New System.Drawing.Point(167, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(346, 25)
        Me.ComboBox1.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.checkBox, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.CallNumberDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LibSystemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(814, 298)
        Me.DataGridView1.TabIndex = 6
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
        'Button4
        '
        Me.Button4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Button4.Location = New System.Drawing.Point(679, 374)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 50)
        Me.Button4.TabIndex = 8
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.chekcout
        Me.Button3.Location = New System.Drawing.Point(519, 374)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 50)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.clear1
        Me.Button2.Location = New System.Drawing.Point(675, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 50)
        Me.Button2.TabIndex = 5
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search1
        Me.Button1.Location = New System.Drawing.Point(519, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'checkBox
        '
        Me.checkBox.HeaderText = ""
        Me.checkBox.MinimumWidth = 30
        Me.checkBox.Name = "checkBox"
        Me.checkBox.ReadOnly = True
        Me.checkBox.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.checkBox.ToolTipText = "asdac"
        Me.checkBox.Width = 30
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
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 436)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Borrow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrow"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibSystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents LibSystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lib_SystemTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.Lib_SystemTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CallNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
