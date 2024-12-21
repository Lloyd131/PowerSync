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
        Button2 = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button1.Location = New Point(50, 91)
        Button1.Name = "Button1"
        Button1.Size = New Size(482, 166)
        Button1.TabIndex = 0
        Button1.Text = "View E-Building"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button2.Location = New Point(618, 91)
        Button2.Name = "Button2"
        Button2.Size = New Size(482, 166)
        Button2.TabIndex = 1
        Button2.Text = "View Weekly Report"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(98, 206)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1143, 333)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1282, 803)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
