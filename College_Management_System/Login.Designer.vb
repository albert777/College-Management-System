<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.loginAreaPanel = New System.Windows.Forms.Panel()
        Me.loginLbl = New System.Windows.Forms.Label()
        Me.passwordTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.usernameTb = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.signInBtn = New System.Windows.Forms.Button()
        Me.crossPb = New System.Windows.Forms.PictureBox()
        Me.forgetPasswordLbl = New System.Windows.Forms.Label()
        Me.passwordIcon = New System.Windows.Forms.PictureBox()
        Me.usernameIcon = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.transparentPanel = New System.Windows.Forms.Panel()
        Me.mainLogo = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.loginErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.loginAreaPanel.SuspendLayout()
        CType(Me.crossPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernameIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transparentPanel.SuspendLayout()
        CType(Me.mainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.loginErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginAreaPanel
        '
        Me.loginAreaPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.loginAreaPanel.Controls.Add(Me.loginLbl)
        Me.loginAreaPanel.Controls.Add(Me.passwordTb)
        Me.loginAreaPanel.Controls.Add(Me.usernameTb)
        Me.loginAreaPanel.Controls.Add(Me.signInBtn)
        Me.loginAreaPanel.Controls.Add(Me.crossPb)
        Me.loginAreaPanel.Controls.Add(Me.forgetPasswordLbl)
        Me.loginAreaPanel.Controls.Add(Me.passwordIcon)
        Me.loginAreaPanel.Controls.Add(Me.usernameIcon)
        Me.loginAreaPanel.Controls.Add(Me.ShapeContainer1)
        Me.loginAreaPanel.Location = New System.Drawing.Point(374, 0)
        Me.loginAreaPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.loginAreaPanel.Name = "loginAreaPanel"
        Me.loginAreaPanel.Size = New System.Drawing.Size(428, 477)
        Me.loginAreaPanel.TabIndex = 3
        Me.loginAreaPanel.TabStop = True
        '
        'loginLbl
        '
        Me.loginLbl.AutoSize = True
        Me.loginLbl.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginLbl.ForeColor = System.Drawing.Color.White
        Me.loginLbl.Location = New System.Drawing.Point(48, 67)
        Me.loginLbl.Name = "loginLbl"
        Me.loginLbl.Size = New System.Drawing.Size(91, 36)
        Me.loginLbl.TabIndex = 7
        Me.loginLbl.Text = "LOGIN"
        '
        'passwordTb
        '
        Me.passwordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTb.Depth = 0
        Me.passwordTb.ForeColor = System.Drawing.Color.White
        Me.passwordTb.Hint = "Password"
        Me.passwordTb.Location = New System.Drawing.Point(117, 211)
        Me.passwordTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.passwordTb.Name = "passwordTb"
        Me.passwordTb.Padding = New System.Windows.Forms.Padding(12)
        Me.passwordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTb.SelectedText = ""
        Me.passwordTb.SelectionLength = 0
        Me.passwordTb.SelectionStart = 0
        Me.passwordTb.Size = New System.Drawing.Size(222, 23)
        Me.passwordTb.TabIndex = 1
        Me.passwordTb.UseSystemPasswordChar = False
        '
        'usernameTb
        '
        Me.usernameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTb.Depth = 0
        Me.usernameTb.ForeColor = System.Drawing.Color.White
        Me.usernameTb.Hint = "Username"
        Me.usernameTb.Location = New System.Drawing.Point(117, 149)
        Me.usernameTb.MouseState = MaterialSkin.MouseState.HOVER
        Me.usernameTb.Name = "usernameTb"
        Me.usernameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTb.SelectedText = ""
        Me.usernameTb.SelectionLength = 0
        Me.usernameTb.SelectionStart = 0
        Me.usernameTb.Size = New System.Drawing.Size(222, 23)
        Me.usernameTb.TabIndex = 0
        Me.usernameTb.UseSystemPasswordChar = False
        '
        'signInBtn
        '
        Me.signInBtn.BackColor = System.Drawing.Color.Transparent
        Me.signInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.signInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signInBtn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signInBtn.ForeColor = System.Drawing.Color.White
        Me.signInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.signInBtn.Location = New System.Drawing.Point(54, 331)
        Me.signInBtn.Name = "signInBtn"
        Me.signInBtn.Size = New System.Drawing.Size(285, 49)
        Me.signInBtn.TabIndex = 3
        Me.signInBtn.Text = "SIGN IN"
        Me.signInBtn.UseVisualStyleBackColor = False
        '
        'crossPb
        '
        Me.crossPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.crossPb.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px2
        Me.crossPb.Location = New System.Drawing.Point(386, 15)
        Me.crossPb.Name = "crossPb"
        Me.crossPb.Size = New System.Drawing.Size(31, 32)
        Me.crossPb.TabIndex = 4
        Me.crossPb.TabStop = False
        '
        'forgetPasswordLbl
        '
        Me.forgetPasswordLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetPasswordLbl.ForeColor = System.Drawing.Color.White
        Me.forgetPasswordLbl.Location = New System.Drawing.Point(50, 404)
        Me.forgetPasswordLbl.Name = "forgetPasswordLbl"
        Me.forgetPasswordLbl.Size = New System.Drawing.Size(289, 19)
        Me.forgetPasswordLbl.TabIndex = 2
        Me.forgetPasswordLbl.Text = " Forgot password"
        Me.forgetPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passwordIcon
        '
        Me.passwordIcon.BackColor = System.Drawing.Color.Transparent
        Me.passwordIcon.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Password
        Me.passwordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.passwordIcon.Location = New System.Drawing.Point(54, 202)
        Me.passwordIcon.Name = "passwordIcon"
        Me.passwordIcon.Size = New System.Drawing.Size(43, 42)
        Me.passwordIcon.TabIndex = 2
        Me.passwordIcon.TabStop = False
        '
        'usernameIcon
        '
        Me.usernameIcon.BackgroundImage = Global.College_Management_System.My.Resources.Resources.User
        Me.usernameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usernameIcon.Location = New System.Drawing.Point(54, 139)
        Me.usernameIcon.Name = "usernameIcon"
        Me.usernameIcon.Size = New System.Drawing.Size(41, 42)
        Me.usernameIcon.TabIndex = 2
        Me.usernameIcon.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(428, 477)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 2)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(11, 475)
        '
        'transparentPanel
        '
        Me.transparentPanel.BackColor = System.Drawing.Color.Transparent
        Me.transparentPanel.Controls.Add(Me.mainLogo)
        Me.transparentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transparentPanel.ForeColor = System.Drawing.Color.White
        Me.transparentPanel.Location = New System.Drawing.Point(0, 0)
        Me.transparentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.transparentPanel.Name = "transparentPanel"
        Me.transparentPanel.Size = New System.Drawing.Size(374, 477)
        Me.transparentPanel.TabIndex = 2
        '
        'mainLogo
        '
        Me.mainLogo.BackColor = System.Drawing.Color.Transparent
        Me.mainLogo.BackgroundImage = Global.College_Management_System.My.Resources.Resources.CMS
        Me.mainLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mainLogo.Location = New System.Drawing.Point(12, 97)
        Me.mainLogo.Name = "mainLogo"
        Me.mainLogo.Size = New System.Drawing.Size(327, 201)
        Me.mainLogo.TabIndex = 0
        Me.mainLogo.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.63342!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.36658!))
        Me.TableLayoutPanel1.Controls.Add(Me.transparentPanel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.loginAreaPanel, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(802, 477)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'loginErrorProvider
        '
        Me.loginErrorProvider.ContainerControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.loginAreaPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'Login
        '
        Me.AcceptButton = Me.signInBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.College_Management_System.My.Resources.Resources.student_education
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 477)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.loginAreaPanel.ResumeLayout(False)
        Me.loginAreaPanel.PerformLayout()
        CType(Me.crossPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernameIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transparentPanel.ResumeLayout(False)
        CType(Me.mainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.loginErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginAreaPanel As Panel
    Friend WithEvents passwordTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents usernameTb As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents signInBtn As Button
    Friend WithEvents crossPb As PictureBox
    Friend WithEvents forgetPasswordLbl As Label
    Friend WithEvents passwordIcon As PictureBox
    Friend WithEvents usernameIcon As PictureBox
    Friend WithEvents mainLogo As PictureBox
    Friend WithEvents transparentPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents loginErrorProvider As ErrorProvider
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents loginLbl As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
