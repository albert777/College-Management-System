<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailVerification
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
        Me.components = New System.ComponentModel.Container()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.EmailCheckLabel = New System.Windows.Forms.Label()
        Me.EmailCheckTextBox = New System.Windows.Forms.TextBox()
        Me.Bun = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.CrossPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckButton
        '
        Me.CheckButton.BackColor = System.Drawing.Color.Black
        Me.CheckButton.FlatAppearance.BorderSize = 0
        Me.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckButton.ForeColor = System.Drawing.Color.White
        Me.CheckButton.Location = New System.Drawing.Point(13, 78)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(429, 28)
        Me.CheckButton.TabIndex = 9
        Me.CheckButton.Text = "Send Email"
        Me.CheckButton.UseVisualStyleBackColor = False
        '
        'EmailCheckLabel
        '
        Me.EmailCheckLabel.AutoSize = True
        Me.EmailCheckLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailCheckLabel.Location = New System.Drawing.Point(9, 16)
        Me.EmailCheckLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailCheckLabel.Name = "EmailCheckLabel"
        Me.EmailCheckLabel.Size = New System.Drawing.Size(133, 19)
        Me.EmailCheckLabel.TabIndex = 8
        Me.EmailCheckLabel.Text = "Enter your email"
        '
        'EmailCheckTextBox
        '
        Me.EmailCheckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailCheckTextBox.Location = New System.Drawing.Point(13, 46)
        Me.EmailCheckTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EmailCheckTextBox.Multiline = True
        Me.EmailCheckTextBox.Name = "EmailCheckTextBox"
        Me.EmailCheckTextBox.Size = New System.Drawing.Size(428, 24)
        Me.EmailCheckTextBox.TabIndex = 7
        Me.EmailCheckTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bun
        '
        Me.Bun.Delay = 1
        '
        'CrossPictureBox
        '
        Me.CrossPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CrossPictureBox.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px
        Me.CrossPictureBox.Location = New System.Drawing.Point(420, 8)
        Me.CrossPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CrossPictureBox.Name = "CrossPictureBox"
        Me.CrossPictureBox.Size = New System.Drawing.Size(30, 32)
        Me.CrossPictureBox.TabIndex = 11
        Me.CrossPictureBox.TabStop = False
        '
        'EmailVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 123)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.EmailCheckLabel)
        Me.Controls.Add(Me.EmailCheckTextBox)
        Me.Controls.Add(Me.CrossPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmailVerification"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmailVerification"
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckButton As System.Windows.Forms.Button
    Friend WithEvents EmailCheckLabel As System.Windows.Forms.Label
    Friend WithEvents EmailCheckTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CrossPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Bun As Bunifu.Framework.UI.BunifuFormFadeTransition
End Class
