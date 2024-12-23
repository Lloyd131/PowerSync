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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(18, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(322, 870)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("BankGothic Md BT", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button5.Location = New Point(27, 726)
        Button5.Name = "Button5"
        Button5.Size = New Size(266, 94)
        Button5.TabIndex = 3
        Button5.Text = "Return"
        Button5.UseVisualStyleBackColor = True
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
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(380, 232)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(855, 255)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(380, 232)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(855, 255)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1282, 892)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "Form3"
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
