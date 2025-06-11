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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        CheckedListBox1 = New CheckedListBox()
        CheckedListBox2 = New CheckedListBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(175, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(175, 111)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(145, 23)
        TextBox2.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(438, 58)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 3
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(175, 169)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(219, 94)
        CheckedListBox1.TabIndex = 4
        ' 
        ' CheckedListBox2
        ' 
        CheckedListBox2.FormattingEnabled = True
        CheckedListBox2.Location = New Point(438, 169)
        CheckedListBox2.Name = "CheckedListBox2"
        CheckedListBox2.Size = New Size(202, 94)
        CheckedListBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(216, 296)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 37)
        Button1.TabIndex = 6
        Button1.Text = "create "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(438, 296)
        Button2.Name = "Button2"
        Button2.Size = New Size(120, 37)
        Button2.TabIndex = 7
        Button2.Text = "main menu "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CheckedListBox2)
        Controls.Add(CheckedListBox1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
