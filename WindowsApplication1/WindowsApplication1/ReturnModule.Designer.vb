<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnModule))
        Me.BorrowerTabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.Borrower_TabTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.Borrower_TabTableAdapter()
        Me.BorrowerTabBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BorrowerTabBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.checkBox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TransactionNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BorrowerTabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerTabBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerTabBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowerTabBindingSource
        '
        Me.BorrowerTabBindingSource.DataMember = "Borrower_Tab"
        Me.BorrowerTabBindingSource.DataSource = Me.TryTestDataSet
        '
        'TryTestDataSet
        '
        Me.TryTestDataSet.DataSetName = "tryTestDataSet"
        Me.TryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Borrower_TabTableAdapter
        '
        Me.Borrower_TabTableAdapter.ClearBeforeFill = True
        '
        'BorrowerTabBindingSource1
        '
        Me.BorrowerTabBindingSource1.DataMember = "Borrower_Tab"
        Me.BorrowerTabBindingSource1.DataSource = Me.TryTestDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkBox, Me.TransactionNumDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BorrowerTabBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(817, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'BorrowerTabBindingSource2
        '
        Me.BorrowerTabBindingSource2.DataMember = "Borrower_Tab"
        Me.BorrowerTabBindingSource2.DataSource = Me.TryTestDataSet
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Button2.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(674, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 55)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.confirm
        Me.Button1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(513, 352)
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
        Me.checkBox.Width = 30
        '
        'TransactionNumDataGridViewTextBoxColumn
        '
        Me.TransactionNumDataGridViewTextBoxColumn.DataPropertyName = "transactionNum"
        Me.TransactionNumDataGridViewTextBoxColumn.HeaderText = "transactionNum"
        Me.TransactionNumDataGridViewTextBoxColumn.Name = "TransactionNumDataGridViewTextBoxColumn"
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
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'ReturnModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 436)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReturnModule"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReturnModule"
        CType(Me.BorrowerTabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerTabBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerTabBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents BorrowerTabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Borrower_TabTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.Borrower_TabTableAdapter
    Friend WithEvents BorrowerTabBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BorrowerTabBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DatetimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents checkBox As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TransactionNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
