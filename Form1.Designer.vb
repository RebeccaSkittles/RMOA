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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.usro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(715, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Run Me On Anything!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OS Support: Windows"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 418)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User OS:"
        '
        'usro
        '
        Me.usro.AutoSize = True
        Me.usro.Location = New System.Drawing.Point(47, 418)
        Me.usro.Name = "usro"
        Me.usro.Size = New System.Drawing.Size(59, 15)
        Me.usro.TabIndex = 3
        Me.usro.Text = "Unavalibe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 403)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "V: 1.0.0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Run_Me_On_Anything_.My.Resources.Resources.About
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(356, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 92)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "About"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Run_Me_On_Anything_.My.Resources.Resources.download
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(356, 202)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 92)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Update"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Run_Me_On_Anything_.My.Resources.Resources.preferences_desktop_peripherals_icon
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(356, 315)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 92)
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(365, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Test Features"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.usro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "Form1"
        Me.Text = "Run Me On Anything!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usro As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
End Class
