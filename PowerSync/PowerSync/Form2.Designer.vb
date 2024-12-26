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
        GroupBox3 = New GroupBox()
        Label1 = New Label()
        Button5 = New Button()
        GroupBox2 = New GroupBox()
        Button7 = New Button()
        Button6 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button1.Location = New Point(13, 171)
        Button1.Name = "Button1"
        Button1.Size = New Size(280, 80)
        Button1.TabIndex = 0
        Button1.Text = "View E-Building"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button2.Location = New Point(13, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(280, 80)
        Button2.TabIndex = 1
        Button2.Text = "View Weekly Report"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Dock = DockStyle.Left
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(373, 952)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.DimGray
        GroupBox3.Location = New Point(0, 0)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1545, 833)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("BankGothic Md BT", 25.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(13, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 46)
        Label1.TabIndex = 5
        Label1.Text = "POWERSYNC"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button5.Location = New Point(13, 419)
        Button5.Name = "Button5"
        Button5.Size = New Size(280, 80)
        Button5.TabIndex = 4
        Button5.Text = "Log Out"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Gray
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Button6)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.Location = New Point(373, 0)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1551, 952)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Visible = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button7.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.White
        Button7.Location = New Point(6, 332)
        Button7.Name = "Button7"
        Button7.Size = New Size(280, 80)
        Button7.TabIndex = 9
        Button7.Text = "4th Floor"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button6.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.White
        Button6.Location = New Point(6, 230)
        Button6.Name = "Button6"
        Button6.Size = New Size(280, 80)
        Button6.TabIndex = 8
        Button6.Text = "3rd Floor"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button4.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(6, 129)
        Button4.Name = "Button4"
        Button4.Size = New Size(280, 80)
        Button4.TabIndex = 7
        Button4.Text = "2nd Floor"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button3.Font = New Font("BankGothic Md BT", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(6, 23)
        Button3.Name = "Button3"
        Button3.Size = New Size(280, 80)
        Button3.TabIndex = 6
        Button3.Text = "1st Floor"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1924, 952)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
End Class
