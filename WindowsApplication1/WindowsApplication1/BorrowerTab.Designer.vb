<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowerTab))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.BorrowerTabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Borrower_TabTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.Borrower_TabTableAdapter()
        Me.TransactionNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerTabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionNumDataGridViewTextBoxColumn, Me.BorrowDateDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BorrowerTabBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(817, 354)
        Me.DataGridView1.TabIndex = 0
        '
        'TryTestDataSet
        '
        Me.TryTestDataSet.DataSetName = "tryTestDataSet"
        Me.TryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowerTabBindingSource
        '
        Me.BorrowerTabBindingSource.DataMember = "Borrower_Tab"
        Me.BorrowerTabBindingSource.DataSource = Me.TryTestDataSet
        '
        'Borrower_TabTableAdapter
        '
        Me.Borrower_TabTableAdapter.ClearBeforeFill = True
        '
        'TransactionNumDataGridViewTextBoxColumn
        '
        Me.TransactionNumDataGridViewTextBoxColumn.DataPropertyName = "transactionNum"
        Me.TransactionNumDataGridViewTextBoxColumn.HeaderText = "transactionNum"
        Me.TransactionNumDataGridViewTextBoxColumn.Name = "TransactionNumDataGridViewTextBoxColumn"
        Me.TransactionNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BorrowDateDataGridViewTextBoxColumn
        '
        Me.BorrowDateDataGridViewTextBoxColumn.DataPropertyName = "borrowDate"
        Me.BorrowDateDataGridViewTextBoxColumn.HeaderText = "borrowDate"
        Me.BorrowDateDataGridViewTextBoxColumn.Name = "BorrowDateDataGridViewTextBoxColumn"
        Me.BorrowDateDataGridViewTextBoxColumn.ReadOnly = True
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
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Query:"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search1
        Me.Button1.Location = New System.Drawing.Point(513, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(164, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 27)
        Me.TextBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Last Name", "First Name", "Title", "Author"})
        Me.ComboBox1.Location = New System.Drawing.Point(164, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(343, 25)
        Me.ComboBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search By:"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.close
        Me.Button2.Location = New System.Drawing.Point(674, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 55)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BorrowerTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 436)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BorrowerTab"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowerTab"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerTabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents BorrowerTabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Borrower_TabTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.Borrower_TabTableAdapter
    Friend WithEvents TransactionNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BorrowDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
