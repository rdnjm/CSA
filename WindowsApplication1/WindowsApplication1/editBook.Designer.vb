<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editBook
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
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Call_NumberLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editBook))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Call_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        LocationLabel = New System.Windows.Forms.Label()
        Call_NumberLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Circulation", "Fiction", "Reserve"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(539, 25)
        Me.ComboBox1.TabIndex = 22
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(12, 140)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(113, 17)
        LocationLabel.TabIndex = 20
        LocationLabel.Text = "Location:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(168, 137)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(539, 27)
        Me.LocationTextBox.TabIndex = 21
        '
        'Call_NumberLabel
        '
        Call_NumberLabel.AutoSize = True
        Call_NumberLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Call_NumberLabel.Location = New System.Drawing.Point(12, 107)
        Call_NumberLabel.Name = "Call_NumberLabel"
        Call_NumberLabel.Size = New System.Drawing.Size(152, 17)
        Call_NumberLabel.TabIndex = 18
        Call_NumberLabel.Text = "Call Number:"
        '
        'Call_NumberTextBox
        '
        Me.Call_NumberTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Call_NumberTextBox.Location = New System.Drawing.Point(168, 104)
        Me.Call_NumberTextBox.Name = "Call_NumberTextBox"
        Me.Call_NumberTextBox.Size = New System.Drawing.Size(539, 27)
        Me.Call_NumberTextBox.TabIndex = 19
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(12, 74)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(122, 17)
        CategoryLabel.TabIndex = 17
        CategoryLabel.Text = "Category:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(12, 41)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(94, 17)
        AuthorLabel.TabIndex = 14
        AuthorLabel.Text = "Author:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(168, 38)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(539, 27)
        Me.AuthorTextBox.TabIndex = 16
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(12, 8)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(65, 17)
        TitleLabel.TabIndex = 13
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("CreativeBlock BB", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(168, 5)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(539, 27)
        Me.TitleTextBox.TabIndex = 15
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cancel
        Me.Button2.Location = New System.Drawing.Point(552, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 55)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.confirm
        Me.Button1.Location = New System.Drawing.Point(391, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 55)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = True
        '
        'editBook
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
        Me.Name = "editBook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Call_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
End Class
