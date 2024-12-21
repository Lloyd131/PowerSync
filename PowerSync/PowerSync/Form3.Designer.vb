<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(18, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(322, 781)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button1.Location = New Point(27, 68)
        Button1.Name = "Button1"
        Button1.Size = New Size(266, 94)
        Button1.TabIndex = 0
        Button1.Text = "E100-E105"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button2.Location = New Point(27, 227)
        Button2.Name = "Button2"
        Button2.Size = New Size(266, 94)
        Button2.TabIndex = 1
        Button2.Text = "E200-E205" & vbCrLf
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button3.Location = New Point(27, 383)
        Button3.Name = "Button3"
        Button3.Size = New Size(266, 94)
        Button3.TabIndex = 2
        Button3.Text = "E300-E305" & vbCrLf
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button4.Location = New Point(27, 556)
        Button4.Name = "Button4"
        Button4.Size = New Size(266, 94)
        Button4.TabIndex = 2
        Button4.Text = "E400-E405" & vbCrLf
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1282, 803)
        Controls.Add(GroupBox1)
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
