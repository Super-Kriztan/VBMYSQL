<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        IDTextBox1 = New MaskedTextBox()
        NameTextBox2 = New MaskedTextBox()
        SurnameTextBox3 = New MaskedTextBox()
        AgeTextBox4 = New MaskedTextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        NameComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        SearchTextBox = New TextBox()
        Male = New RadioButton()
        Female = New RadioButton()
        dobPicker = New DateTimePicker()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(12, 486)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 39)
        Button1.TabIndex = 1
        Button1.Text = "SignOut"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Menu
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(87, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 31)
        Label1.TabIndex = 2
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Menu
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(87, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 31)
        Label2.TabIndex = 3
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Menu
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(87, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 31)
        Label3.TabIndex = 4
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Menu
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(87, 309)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 31)
        Label4.TabIndex = 5
        Label4.Text = "Age"
        ' 
        ' IDTextBox1
        ' 
        IDTextBox1.Location = New Point(257, 104)
        IDTextBox1.Name = "IDTextBox1"
        IDTextBox1.Size = New Size(184, 27)
        IDTextBox1.TabIndex = 6
        ' 
        ' NameTextBox2
        ' 
        NameTextBox2.Location = New Point(257, 173)
        NameTextBox2.Name = "NameTextBox2"
        NameTextBox2.Size = New Size(184, 27)
        NameTextBox2.TabIndex = 7
        ' 
        ' SurnameTextBox3
        ' 
        SurnameTextBox3.Location = New Point(257, 251)
        SurnameTextBox3.Name = "SurnameTextBox3"
        SurnameTextBox3.Size = New Size(184, 27)
        SurnameTextBox3.TabIndex = 8
        ' 
        ' AgeTextBox4
        ' 
        AgeTextBox4.Location = New Point(257, 325)
        AgeTextBox4.Name = "AgeTextBox4"
        AgeTextBox4.Size = New Size(184, 27)
        AgeTextBox4.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGreen
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(457, 485)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 40)
        Button2.TabIndex = 11
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightSkyBlue
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(306, 485)
        Button3.Name = "Button3"
        Button3.Size = New Size(108, 40)
        Button3.TabIndex = 12
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DeepPink
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(164, 485)
        Button4.Name = "Button4"
        Button4.Size = New Size(108, 40)
        Button4.TabIndex = 13
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' NameComboBox1
        ' 
        NameComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameComboBox1.FormattingEnabled = True
        NameComboBox1.Location = New Point(478, 21)
        NameComboBox1.Name = "NameComboBox1"
        NameComboBox1.Size = New Size(205, 36)
        NameComboBox1.TabIndex = 14
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(795, 21)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(213, 44)
        ListBox1.TabIndex = 15
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(478, 88)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(571, 188)
        DataGridView1.TabIndex = 16
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ControlDarkDark
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(716, 282)
        Button5.Name = "Button5"
        Button5.Size = New Size(114, 37)
        Button5.TabIndex = 17
        Button5.Text = "Load"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' SearchTextBox
        ' 
        SearchTextBox.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SearchTextBox.Location = New Point(670, 333)
        SearchTextBox.Name = "SearchTextBox"
        SearchTextBox.Size = New Size(210, 34)
        SearchTextBox.TabIndex = 18
        ' 
        ' Male
        ' 
        Male.AutoSize = True
        Male.Location = New Point(164, 432)
        Male.Name = "Male"
        Male.Size = New Size(63, 24)
        Male.TabIndex = 19
        Male.TabStop = True
        Male.Text = "Male"
        Male.UseVisualStyleBackColor = True
        ' 
        ' Female
        ' 
        Female.AutoSize = True
        Female.Location = New Point(318, 432)
        Female.Name = "Female"
        Female.Size = New Size(78, 24)
        Female.TabIndex = 20
        Female.TabStop = True
        Female.Text = "Female"
        Female.UseVisualStyleBackColor = True
        ' 
        ' dobPicker
        ' 
        dobPicker.CustomFormat = "yyyy-MM-dd"
        dobPicker.Format = DateTimePickerFormat.Custom
        dobPicker.Location = New Point(266, 385)
        dobPicker.Name = "dobPicker"
        dobPicker.Size = New Size(139, 27)
        dobPicker.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Menu
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(58, 381)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 31)
        Label5.TabIndex = 22
        Label5.Text = "Date of Birth"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1061, 713)
        Controls.Add(Label5)
        Controls.Add(dobPicker)
        Controls.Add(Female)
        Controls.Add(Male)
        Controls.Add(SearchTextBox)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(NameComboBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(AgeTextBox4)
        Controls.Add(SurnameTextBox3)
        Controls.Add(NameTextBox2)
        Controls.Add(IDTextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IDTextBox1 As MaskedTextBox
    Friend WithEvents NameTextBox2 As MaskedTextBox
    Friend WithEvents SurnameTextBox3 As MaskedTextBox
    Friend WithEvents AgeTextBox4 As MaskedTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NameComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents dobPicker As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
