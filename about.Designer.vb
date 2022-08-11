<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Run_Me_On_Anything_.My.Resources.Resources.icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 115)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(122, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RMOA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Devleoper: XER+"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Version: 1.0.0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Version Author: XER+"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Support OS: Windows, Linux, MacOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "(C)2022 XER+"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 128)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(351, 167)
        Me.MinimumSize = New System.Drawing.Size(351, 167)
        Me.Name = "about"
        Me.Text = "Rum Me On Anything! - About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
