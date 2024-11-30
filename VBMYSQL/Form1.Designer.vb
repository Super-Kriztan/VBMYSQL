<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        UnTextBox1 = New MaskedTextBox()
        PassTextBox2 = New MaskedTextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.MistyRose
        Button1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(60, 45)
        Button1.Name = "Button1"
        Button1.Size = New Size(266, 35)
        Button1.TabIndex = 0
        Button1.Text = "CHECK CONNECTION"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(192, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 27)
        Label1.TabIndex = 1
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(191, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 27)
        Label2.TabIndex = 2
        Label2.Text = "PASSWORD"
        ' 
        ' UnTextBox1
        ' 
        UnTextBox1.Location = New Point(434, 162)
        UnTextBox1.Name = "UnTextBox1"
        UnTextBox1.Size = New Size(200, 27)
        UnTextBox1.TabIndex = 3
        ' 
        ' PassTextBox2
        ' 
        PassTextBox2.Location = New Point(434, 251)
        PassTextBox2.Name = "PassTextBox2"
        PassTextBox2.PasswordChar = "*"c
        PassTextBox2.Size = New Size(200, 27)
        PassTextBox2.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Info
        Button2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(489, 334)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 35)
        Button2.TabIndex = 5
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(PassTextBox2)
        Controls.Add(UnTextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnTextBox1 As MaskedTextBox
    Friend WithEvents PassTextBox2 As MaskedTextBox
    Friend WithEvents Button2 As Button

End Class
