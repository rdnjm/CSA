<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBook
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
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Call_NumberLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addBook))
        Me.TryTestDataSet = New WindowsApplication1.tryTestDataSet()
        Me.Lib_SystemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lib_SystemTableAdapter = New WindowsApplication1.tryTestDataSetTableAdapters.Lib_SystemTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.tryTestDataSetTableAdapters.TableAdapterManager()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.Call_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Call_NumberLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lib_SystemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(12, 9)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(65, 17)
        TitleLabel.TabIndex = 1
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(12, 42)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(94, 17)
        AuthorLabel.TabIndex = 2
        AuthorLabel.Text = "Author:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(12, 75)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(122, 17)
        CategoryLabel.TabIndex = 4
        CategoryLabel.Text = "Category:"
        '
        'Call_NumberLabel
        '
        Call_NumberLabel.AutoSize = True
        Call_NumberLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Call_NumberLabel.Location = New System.Drawing.Point(12, 108)
        Call_NumberLabel.Name = "Call_NumberLabel"
        Call_NumberLabel.Size = New System.Drawing.Size(152, 17)
        Call_NumberLabel.TabIndex = 6
        Call_NumberLabel.Text = "Call Number:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(12, 141)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(113, 17)
        LocationLabel.TabIndex = 8
        LocationLabel.Text = "Location:"
        '
        'TryTestDataSet
        '
        Me.TryTestDataSet.DataSetName = "tryTestDataSet"
        Me.TryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lib_SystemBindingSource
        '
        Me.Lib_SystemBindingSource.DataMember = "Lib_System"
        Me.Lib_SystemBindingSource.DataSource = Me.TryTestDataSet
        '
        'Lib_SystemTableAdapter
        '
        Me.Lib_SystemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Borrower_TabTableAdapter = Nothing
        Me.TableAdapterManager.FacultyTableAdapter = Nothing
        Me.TableAdapterManager.Lib_SystemTableAdapter = Me.Lib_SystemTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.tryTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_SystemBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(168, 6)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(539, 27)
        Me.TitleTextBox.TabIndex = 2
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_SystemBindingSource, "Author", True))
        Me.AuthorTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(168, 39)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(539, 27)
        Me.AuthorTextBox.TabIndex = 3
        '
        'Call_NumberTextBox
        '
        Me.Call_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_SystemBindingSource, "Call Number", True))
        Me.Call_NumberTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Call_NumberTextBox.Location = New System.Drawing.Point(168, 105)
        Me.Call_NumberTextBox.Name = "Call_NumberTextBox"
        Me.Call_NumberTextBox.Size = New System.Drawing.Size(539, 27)
        Me.Call_NumberTextBox.TabIndex = 7
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_SystemBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(168, 138)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(539, 27)
        Me.LocationTextBox.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Circulation", "Fiction", "Reserve"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 73)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(539, 25)
        Me.ComboBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.confirm
        Me.Button1.Location = New System.Drawing.Point(391, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 55)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Button2.Location = New System.Drawing.Point(552, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 55)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = True
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 230)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Call_NumberLabel)
        Me.Controls.Add(Me.Call_NumberTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addBook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addBook"
        CType(Me.TryTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lib_SystemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TryTestDataSet As WindowsApplication1.tryTestDataSet
    Friend WithEvents Lib_SystemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lib_SystemTableAdapter As WindowsApplication1.tryTestDataSetTableAdapters.Lib_SystemTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.tryTestDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Call_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
