<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ctt_t = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change The Text!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type In What You Want Then Press Chnage"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 23)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Change Text In The Box Below"
        '
        'ctt_t
        '
        Me.ctt_t.AutoSize = True
        Me.ctt_t.Location = New System.Drawing.Point(15, 187)
        Me.ctt_t.Name = "ctt_t"
        Me.ctt_t.Size = New System.Drawing.Size(109, 15)
        Me.ctt_t.TabIndex = 4
        Me.ctt_t.Text = "The Changed Thext"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ctt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 243)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ctt_t)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ctt"
        Me.Text = "Change The Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ctt_t As Label
    Friend WithEvents Button1 As Button
End Class
