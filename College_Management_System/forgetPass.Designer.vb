<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgetPass
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
        Me.EmailCheckTextBox = New System.Windows.Forms.TextBox()
        Me.EmailCheckLabel = New System.Windows.Forms.Label()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.forgetPassPanel = New System.Windows.Forms.Panel()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.ReEnterPasswordTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.CrossPictureBox = New System.Windows.Forms.PictureBox()
        Me.Bun = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.forgetPassPanel.SuspendLayout()
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmailCheckTextBox
        '
        Me.EmailCheckTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailCheckTextBox.Location = New System.Drawing.Point(13, 42)
        Me.EmailCheckTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailCheckTextBox.Multiline = True
        Me.EmailCheckTextBox.Name = "EmailCheckTextBox"
        Me.EmailCheckTextBox.Size = New System.Drawing.Size(428, 24)
        Me.EmailCheckTextBox.TabIndex = 0
        Me.EmailCheckTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmailCheckLabel
        '
        Me.EmailCheckLabel.AutoSize = True
        Me.EmailCheckLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailCheckLabel.Location = New System.Drawing.Point(9, 12)
        Me.EmailCheckLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailCheckLabel.Name = "EmailCheckLabel"
        Me.EmailCheckLabel.Size = New System.Drawing.Size(133, 19)
        Me.EmailCheckLabel.TabIndex = 1
        Me.EmailCheckLabel.Text = "Enter your email"
        '
        'CheckButton
        '
        Me.CheckButton.BackColor = System.Drawing.Color.Black
        Me.CheckButton.FlatAppearance.BorderSize = 0
        Me.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckButton.ForeColor = System.Drawing.Color.White
        Me.CheckButton.Location = New System.Drawing.Point(13, 74)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(429, 28)
        Me.CheckButton.TabIndex = 2
        Me.CheckButton.Text = "Check"
        Me.CheckButton.UseVisualStyleBackColor = False
        '
        'forgetPassPanel
        '
        Me.forgetPassPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.forgetPassPanel.Controls.Add(Me.ChangeButton)
        Me.forgetPassPanel.Controls.Add(Me.ReEnterPasswordTextBox)
        Me.forgetPassPanel.Enabled = False
        Me.forgetPassPanel.Location = New System.Drawing.Point(13, 116)
        Me.forgetPassPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.forgetPassPanel.Name = "forgetPassPanel"
        Me.forgetPassPanel.Size = New System.Drawing.Size(429, 123)
        Me.forgetPassPanel.TabIndex = 3
        Me.forgetPassPanel.Visible = False
        '
        'ChangeButton
        '
        Me.ChangeButton.BackColor = System.Drawing.Color.Black
        Me.ChangeButton.FlatAppearance.BorderSize = 0
        Me.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeButton.ForeColor = System.Drawing.Color.White
        Me.ChangeButton.Location = New System.Drawing.Point(70, 77)
        Me.ChangeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(283, 28)
        Me.ChangeButton.TabIndex = 5
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = False
        '
        'ReEnterPasswordTextBox
        '
        Me.ReEnterPasswordTextBox.Depth = 0
        Me.ReEnterPasswordTextBox.Hint = "New password"
        Me.ReEnterPasswordTextBox.Location = New System.Drawing.Point(70, 41)
        Me.ReEnterPasswordTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReEnterPasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ReEnterPasswordTextBox.Name = "ReEnterPasswordTextBox"
        Me.ReEnterPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ReEnterPasswordTextBox.SelectedText = ""
        Me.ReEnterPasswordTextBox.SelectionLength = 0
        Me.ReEnterPasswordTextBox.SelectionStart = 0
        Me.ReEnterPasswordTextBox.Size = New System.Drawing.Size(283, 23)
        Me.ReEnterPasswordTextBox.TabIndex = 3
        Me.ReEnterPasswordTextBox.UseSystemPasswordChar = False
        '
        'CrossPictureBox
        '
        Me.CrossPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CrossPictureBox.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px
        Me.CrossPictureBox.Location = New System.Drawing.Point(420, 4)
        Me.CrossPictureBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CrossPictureBox.Name = "CrossPictureBox"
        Me.CrossPictureBox.Size = New System.Drawing.Size(30, 32)
        Me.CrossPictureBox.TabIndex = 6
        Me.CrossPictureBox.TabStop = False
        '
        'Bun
        '
        Me.Bun.Delay = 1
        '
        'forgetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(454, 108)
        Me.Controls.Add(Me.CrossPictureBox)
        Me.Controls.Add(Me.forgetPassPanel)
        Me.Controls.Add(Me.CheckButton)
        Me.Controls.Add(Me.EmailCheckLabel)
        Me.Controls.Add(Me.EmailCheckTextBox)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "forgetPass"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgetPass"
        Me.forgetPassPanel.ResumeLayout(False)
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmailCheckTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailCheckLabel As System.Windows.Forms.Label
    Friend WithEvents CheckButton As System.Windows.Forms.Button
    Friend WithEvents forgetPassPanel As System.Windows.Forms.Panel
    Friend WithEvents ChangeButton As System.Windows.Forms.Button
    Friend WithEvents ReEnterPasswordTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents CrossPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Bun As Bunifu.Framework.UI.BunifuFormFadeTransition
End Class
