<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(134, 33)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1080, 646)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(110, 80)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(894, 475)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button5.Location = New Point(134, 697)
        Button5.Name = "Button5"
        Button5.Size = New Size(266, 94)
        Button5.TabIndex = 4
        Button5.Text = "Return"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1282, 803)
        Controls.Add(Button5)
        Controls.Add(GroupBox1)
        Name = "Form4"
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
End Class
