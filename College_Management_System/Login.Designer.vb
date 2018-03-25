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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.loginAreaPanel = New System.Windows.Forms.Panel()
        Me.ErrorMessagePanel = New System.Windows.Forms.Panel()
        Me.ErrorMessageLabel = New System.Windows.Forms.Label()
        Me.LoginLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.UserNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SignInBtn = New System.Windows.Forms.Button()
        Me.CrossPictureBox = New System.Windows.Forms.PictureBox()
        Me.ForgotPasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordIcon = New System.Windows.Forms.PictureBox()
        Me.UsernameIcon = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.transparentPanel = New System.Windows.Forms.Panel()
        Me.MainLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LoginTablePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.loginErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.ErrorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuFormFadeTransition1 = New Bunifu.Framework.UI.BunifuFormFadeTransition(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.loginAreaPanel.SuspendLayout()
        Me.ErrorMessagePanel.SuspendLayout()
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasswordIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernameIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transparentPanel.SuspendLayout()
        CType(Me.MainLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginTablePanel.SuspendLayout()
        CType(Me.loginErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginAreaPanel
        '
        Me.loginAreaPanel.BackColor = System.Drawing.Color.White
        Me.loginAreaPanel.Controls.Add(Me.ErrorMessagePanel)
        Me.loginAreaPanel.Controls.Add(Me.LoginLabel)
        Me.loginAreaPanel.Controls.Add(Me.PasswordTextBox)
        Me.loginAreaPanel.Controls.Add(Me.UserNameTextBox)
        Me.loginAreaPanel.Controls.Add(Me.SignInBtn)
        Me.loginAreaPanel.Controls.Add(Me.CrossPictureBox)
        Me.loginAreaPanel.Controls.Add(Me.ForgotPasswordLabel)
        Me.loginAreaPanel.Controls.Add(Me.PasswordIcon)
        Me.loginAreaPanel.Controls.Add(Me.UsernameIcon)
        Me.loginAreaPanel.Controls.Add(Me.ShapeContainer1)
        Me.BunifuTransition1.SetDecoration(Me.loginAreaPanel, BunifuAnimatorNS.DecorationType.None)
        Me.loginAreaPanel.ForeColor = System.Drawing.Color.Black
        Me.loginAreaPanel.Location = New System.Drawing.Point(374, 0)
        Me.loginAreaPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.loginAreaPanel.Name = "loginAreaPanel"
        Me.loginAreaPanel.Size = New System.Drawing.Size(428, 477)
        Me.loginAreaPanel.TabIndex = 3
        Me.loginAreaPanel.TabStop = True
        '
        'ErrorMessagePanel
        '
        Me.ErrorMessagePanel.BackColor = System.Drawing.Color.Black
        Me.ErrorMessagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorMessagePanel.Controls.Add(Me.ErrorMessageLabel)
        Me.BunifuTransition1.SetDecoration(Me.ErrorMessagePanel, BunifuAnimatorNS.DecorationType.None)
        Me.ErrorMessagePanel.ForeColor = System.Drawing.Color.White
        Me.ErrorMessagePanel.Location = New System.Drawing.Point(34, 15)
        Me.ErrorMessagePanel.Name = "ErrorMessagePanel"
        Me.ErrorMessagePanel.Size = New System.Drawing.Size(305, 32)
        Me.ErrorMessagePanel.TabIndex = 8
        Me.ErrorMessagePanel.Visible = False
        '
        'ErrorMessageLabel
        '
        Me.ErrorMessageLabel.AutoEllipsis = True
        Me.ErrorMessageLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.ErrorMessageLabel, BunifuAnimatorNS.DecorationType.None)
        Me.ErrorMessageLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorMessageLabel.Location = New System.Drawing.Point(43, 8)
        Me.ErrorMessageLabel.Name = "ErrorMessageLabel"
        Me.ErrorMessageLabel.Size = New System.Drawing.Size(210, 15)
        Me.ErrorMessageLabel.TabIndex = 0
        Me.ErrorMessageLabel.Text = "Username or Password is not correct"
        '
        'LoginLabel
        '
        Me.LoginLabel.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.LoginLabel, BunifuAnimatorNS.DecorationType.None)
        Me.LoginLabel.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginLabel.ForeColor = System.Drawing.Color.Black
        Me.LoginLabel.Location = New System.Drawing.Point(48, 67)
        Me.LoginLabel.Name = "LoginLabel"
        Me.LoginLabel.Size = New System.Drawing.Size(91, 36)
        Me.LoginLabel.TabIndex = 7
        Me.LoginLabel.Text = "LOGIN"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.PasswordTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.PasswordTextBox.Depth = 0
        Me.PasswordTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.White
        Me.PasswordTextBox.Hint = "Password"
        Me.PasswordTextBox.Location = New System.Drawing.Point(117, 211)
        Me.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Padding = New System.Windows.Forms.Padding(12)
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.Size = New System.Drawing.Size(222, 23)
        Me.PasswordTextBox.TabIndex = 1
        Me.PasswordTextBox.UseSystemPasswordChar = False
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition1.SetDecoration(Me.UserNameTextBox, BunifuAnimatorNS.DecorationType.None)
        Me.UserNameTextBox.Depth = 0
        Me.UserNameTextBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.ForeColor = System.Drawing.Color.White
        Me.UserNameTextBox.Hint = "Username"
        Me.UserNameTextBox.Location = New System.Drawing.Point(117, 149)
        Me.UserNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameTextBox.SelectedText = ""
        Me.UserNameTextBox.SelectionLength = 0
        Me.UserNameTextBox.SelectionStart = 0
        Me.UserNameTextBox.Size = New System.Drawing.Size(222, 23)
        Me.UserNameTextBox.TabIndex = 0
        Me.UserNameTextBox.UseSystemPasswordChar = False
        '
        'SignInBtn
        '
        Me.SignInBtn.BackColor = System.Drawing.Color.Black
        Me.BunifuTransition1.SetDecoration(Me.SignInBtn, BunifuAnimatorNS.DecorationType.None)
        Me.SignInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SignInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInBtn.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInBtn.ForeColor = System.Drawing.Color.White
        Me.SignInBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignInBtn.Location = New System.Drawing.Point(54, 331)
        Me.SignInBtn.Name = "SignInBtn"
        Me.SignInBtn.Size = New System.Drawing.Size(285, 49)
        Me.SignInBtn.TabIndex = 2
        Me.SignInBtn.Text = "SIGN IN"
        Me.SignInBtn.UseVisualStyleBackColor = False
        '
        'CrossPictureBox
        '
        Me.CrossPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.CrossPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.CrossPictureBox.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px
        Me.CrossPictureBox.Location = New System.Drawing.Point(386, 15)
        Me.CrossPictureBox.Name = "CrossPictureBox"
        Me.CrossPictureBox.Size = New System.Drawing.Size(31, 32)
        Me.CrossPictureBox.TabIndex = 4
        Me.CrossPictureBox.TabStop = False
        '
        'ForgotPasswordLabel
        '
        Me.ForgotPasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.ForgotPasswordLabel, BunifuAnimatorNS.DecorationType.None)
        Me.ForgotPasswordLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.ForgotPasswordLabel.Location = New System.Drawing.Point(50, 404)
        Me.ForgotPasswordLabel.Name = "ForgotPasswordLabel"
        Me.ForgotPasswordLabel.Size = New System.Drawing.Size(289, 19)
        Me.ForgotPasswordLabel.TabIndex = 3
        Me.ForgotPasswordLabel.Text = " Forgot password"
        Me.ForgotPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordIcon
        '
        Me.PasswordIcon.BackColor = System.Drawing.Color.Transparent
        Me.PasswordIcon.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Password
        Me.PasswordIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PasswordIcon, BunifuAnimatorNS.DecorationType.None)
        Me.PasswordIcon.Image = Global.College_Management_System.My.Resources.Resources.Password_32px
        Me.PasswordIcon.Location = New System.Drawing.Point(68, 202)
        Me.PasswordIcon.Name = "PasswordIcon"
        Me.PasswordIcon.Size = New System.Drawing.Size(29, 32)
        Me.PasswordIcon.TabIndex = 2
        Me.PasswordIcon.TabStop = False
        '
        'UsernameIcon
        '
        Me.UsernameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.UsernameIcon, BunifuAnimatorNS.DecorationType.None)
        Me.UsernameIcon.Image = Global.College_Management_System.My.Resources.Resources.Male_User_32px1
        Me.UsernameIcon.Location = New System.Drawing.Point(68, 139)
        Me.UsernameIcon.Name = "UsernameIcon"
        Me.UsernameIcon.Size = New System.Drawing.Size(29, 33)
        Me.UsernameIcon.TabIndex = 2
        Me.UsernameIcon.TabStop = False
        '
        'ShapeContainer1
        '
        Me.BunifuTransition1.SetDecoration(Me.ShapeContainer1, BunifuAnimatorNS.DecorationType.None)
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
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(11, 477)
        '
        'transparentPanel
        '
        Me.transparentPanel.BackColor = System.Drawing.Color.Transparent
        Me.transparentPanel.Controls.Add(Me.MainLogoPictureBox)
        Me.BunifuTransition1.SetDecoration(Me.transparentPanel, BunifuAnimatorNS.DecorationType.None)
        Me.transparentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transparentPanel.ForeColor = System.Drawing.Color.White
        Me.transparentPanel.Location = New System.Drawing.Point(0, 0)
        Me.transparentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.transparentPanel.Name = "transparentPanel"
        Me.transparentPanel.Size = New System.Drawing.Size(374, 477)
        Me.transparentPanel.TabIndex = 2
        '
        'MainLogoPictureBox
        '
        Me.MainLogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.MainLogoPictureBox.BackgroundImage = Global.College_Management_System.My.Resources.Resources.CMS
        Me.MainLogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.MainLogoPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.MainLogoPictureBox.Location = New System.Drawing.Point(12, 97)
        Me.MainLogoPictureBox.Name = "MainLogoPictureBox"
        Me.MainLogoPictureBox.Size = New System.Drawing.Size(327, 201)
        Me.MainLogoPictureBox.TabIndex = 0
        Me.MainLogoPictureBox.TabStop = False
        '
        'LoginTablePanel
        '
        Me.LoginTablePanel.BackColor = System.Drawing.Color.Transparent
        Me.LoginTablePanel.ColumnCount = 2
        Me.LoginTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.63342!))
        Me.LoginTablePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.36658!))
        Me.LoginTablePanel.Controls.Add(Me.transparentPanel, 0, 0)
        Me.LoginTablePanel.Controls.Add(Me.loginAreaPanel, 1, 0)
        Me.BunifuTransition1.SetDecoration(Me.LoginTablePanel, BunifuAnimatorNS.DecorationType.None)
        Me.LoginTablePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginTablePanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginTablePanel.Name = "LoginTablePanel"
        Me.LoginTablePanel.RowCount = 1
        Me.LoginTablePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LoginTablePanel.Size = New System.Drawing.Size(802, 477)
        Me.LoginTablePanel.TabIndex = 5
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
        'ErrorTimer
        '
        Me.ErrorTimer.Enabled = True
        '
        'BunifuFormFadeTransition1
        '
        Me.BunifuFormFadeTransition1.Delay = 1
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Login
        '
        Me.AcceptButton = Me.SignInBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.College_Management_System.My.Resources.Resources.student_education
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 477)
        Me.Controls.Add(Me.LoginTablePanel)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.loginAreaPanel.ResumeLayout(False)
        Me.loginAreaPanel.PerformLayout()
        Me.ErrorMessagePanel.ResumeLayout(False)
        Me.ErrorMessagePanel.PerformLayout()
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasswordIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernameIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transparentPanel.ResumeLayout(False)
        CType(Me.MainLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginTablePanel.ResumeLayout(False)
        CType(Me.loginErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginAreaPanel As Panel
    Friend WithEvents PasswordTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents UserNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SignInBtn As Button
    Friend WithEvents CrossPictureBox As PictureBox
    Friend WithEvents ForgotPasswordLabel As Label
    Friend WithEvents PasswordIcon As PictureBox
    Friend WithEvents UsernameIcon As PictureBox
    Friend WithEvents MainLogoPictureBox As PictureBox
    Friend WithEvents transparentPanel As Panel
    Friend WithEvents LoginTablePanel As TableLayoutPanel
    Friend WithEvents loginErrorProvider As ErrorProvider
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents LoginLabel As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents ErrorMessagePanel As System.Windows.Forms.Panel
    Friend WithEvents ErrorMessageLabel As System.Windows.Forms.Label
    Friend WithEvents ErrorTimer As System.Windows.Forms.Timer
    Friend WithEvents BunifuFormFadeTransition1 As Bunifu.Framework.UI.BunifuFormFadeTransition
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
End Class
