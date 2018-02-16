<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.hamburgerPb = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dashboardMainPnl = New System.Windows.Forms.Panel()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.editTablePanelAdmin = New System.Windows.Forms.TableLayoutPanel()
        Me.T = New MaterialSkin.Controls.MaterialTabControl()
        Me.addUserTb = New System.Windows.Forms.TabPage()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MaterialSingleLineTextField6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.addStudent = New System.Windows.Forms.TabPage()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.hamburgerPnl.SuspendLayout()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardMainPnl.SuspendLayout()
        Me.dashboardTablePnl.SuspendLayout()
        Me.editTablePanelAdmin.SuspendLayout()
        Me.T.SuspendLayout()
        Me.addUserTb.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addStudent.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BunifuTransition1.Interval = 26
        '
        'hamburgerPnl
        '
        Me.hamburgerPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerPnl.Controls.Add(Me.hamburgerPb)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox2)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox1)
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPnl, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.hamburgerPnl.Name = "hamburgerPnl"
        Me.hamburgerPnl.Size = New System.Drawing.Size(55, 749)
        Me.hamburgerPnl.TabIndex = 1
        '
        'hamburgerPb
        '
        Me.hamburgerPb.BackColor = System.Drawing.Color.Transparent
        Me.hamburgerPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPb, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPb.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.hamburgerPb.Location = New System.Drawing.Point(12, 12)
        Me.hamburgerPb.Name = "hamburgerPb"
        Me.hamburgerPb.Size = New System.Drawing.Size(31, 26)
        Me.hamburgerPb.TabIndex = 1
        Me.hamburgerPb.TabStop = False
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.College_Management_System.My.Resources.Resources.Registration_32px
        Me.PictureBox2.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.College_Management_System.My.Resources.Resources.Admin_Settings_Male_32px
        Me.PictureBox1.Location = New System.Drawing.Point(9, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dashboardMainPnl
        '
        Me.dashboardMainPnl.Controls.Add(Me.hamburgerPnl)
        Me.dashboardMainPnl.Controls.Add(Me.dashboardTablePnl)
        Me.BunifuTransition1.SetDecoration(Me.dashboardMainPnl, BunifuAnimatorNS.DecorationType.None)
        Me.dashboardMainPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardMainPnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardMainPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardMainPnl.Name = "dashboardMainPnl"
        Me.dashboardMainPnl.Size = New System.Drawing.Size(1366, 749)
        Me.dashboardMainPnl.TabIndex = 1
        '
        'dashboardTablePnl
        '
        Me.dashboardTablePnl.ColumnCount = 2
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Controls.Add(Me.editTablePanelAdmin, 1, 0)
        Me.BunifuTransition1.SetDecoration(Me.dashboardTablePnl, BunifuAnimatorNS.DecorationType.None)
        Me.dashboardTablePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardTablePnl.Enabled = False
        Me.dashboardTablePnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardTablePnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardTablePnl.Name = "dashboardTablePnl"
        Me.dashboardTablePnl.RowCount = 1
        Me.dashboardTablePnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Size = New System.Drawing.Size(1366, 749)
        Me.dashboardTablePnl.TabIndex = 2
        Me.dashboardTablePnl.Visible = False
        '
        'editTablePanelAdmin
        '
        Me.editTablePanelAdmin.ColumnCount = 1
        Me.editTablePanelAdmin.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.editTablePanelAdmin.Controls.Add(Me.T, 0, 1)
        Me.editTablePanelAdmin.Controls.Add(Me.MaterialTabSelector1, 0, 0)
        Me.BunifuTransition1.SetDecoration(Me.editTablePanelAdmin, BunifuAnimatorNS.DecorationType.None)
        Me.editTablePanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editTablePanelAdmin.Location = New System.Drawing.Point(55, 0)
        Me.editTablePanelAdmin.Margin = New System.Windows.Forms.Padding(0)
        Me.editTablePanelAdmin.Name = "editTablePanelAdmin"
        Me.editTablePanelAdmin.RowCount = 2
        Me.editTablePanelAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.editTablePanelAdmin.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.editTablePanelAdmin.Size = New System.Drawing.Size(1311, 749)
        Me.editTablePanelAdmin.TabIndex = 0
        '
        'T
        '
        Me.T.Controls.Add(Me.addUserTb)
        Me.T.Controls.Add(Me.addStudent)
        Me.BunifuTransition1.SetDecoration(Me.T, BunifuAnimatorNS.DecorationType.None)
        Me.T.Depth = 0
        Me.T.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T.Location = New System.Drawing.Point(0, 37)
        Me.T.Margin = New System.Windows.Forms.Padding(0)
        Me.T.MouseState = MaterialSkin.MouseState.HOVER
        Me.T.Name = "T"
        Me.T.SelectedIndex = 0
        Me.T.Size = New System.Drawing.Size(1311, 712)
        Me.T.TabIndex = 0
        '
        'addUserTb
        '
        Me.addUserTb.BackColor = System.Drawing.Color.White
        Me.addUserTb.Controls.Add(Me.MaterialLabel1)
        Me.addUserTb.Controls.Add(Me.MaterialRadioButton2)
        Me.addUserTb.Controls.Add(Me.MaterialRadioButton1)
        Me.addUserTb.Controls.Add(Me.MetroComboBox1)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField6)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField5)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField3)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField7)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.addUserTb.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.addUserTb.Controls.Add(Me.BunifuThinButton21)
        Me.addUserTb.Controls.Add(Me.PictureBox3)
        Me.BunifuTransition1.SetDecoration(Me.addUserTb, BunifuAnimatorNS.DecorationType.None)
        Me.addUserTb.Location = New System.Drawing.Point(4, 24)
        Me.addUserTb.Margin = New System.Windows.Forms.Padding(0)
        Me.addUserTb.Name = "addUserTb"
        Me.addUserTb.Size = New System.Drawing.Size(1303, 684)
        Me.addUserTb.TabIndex = 0
        Me.addUserTb.Text = "Add User"
        '
        'MetroComboBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.MetroComboBox1, BunifuAnimatorNS.DecorationType.None)
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Receptionist", "Cashier", "Lecturer"})
        Me.MetroComboBox1.Location = New System.Drawing.Point(349, 240)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.PromptText = "Select Usertype"
        Me.MetroComboBox1.Size = New System.Drawing.Size(345, 29)
        Me.MetroComboBox1.TabIndex = 13
        Me.MetroComboBox1.UseSelectable = True
        '
        'MaterialSingleLineTextField6
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField6, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField6.Depth = 0
        Me.MaterialSingleLineTextField6.Hint = ""
        Me.MaterialSingleLineTextField6.Location = New System.Drawing.Point(720, 192)
        Me.MaterialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField6.Name = "MaterialSingleLineTextField6"
        Me.MaterialSingleLineTextField6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField6.SelectedText = ""
        Me.MaterialSingleLineTextField6.SelectionLength = 0
        Me.MaterialSingleLineTextField6.SelectionStart = 0
        Me.MaterialSingleLineTextField6.Size = New System.Drawing.Size(329, 23)
        Me.MaterialSingleLineTextField6.TabIndex = 6
        Me.MaterialSingleLineTextField6.Text = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField6.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField5
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField5, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField5.Depth = 0
        Me.MaterialSingleLineTextField5.Hint = ""
        Me.MaterialSingleLineTextField5.Location = New System.Drawing.Point(349, 192)
        Me.MaterialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField5.Name = "MaterialSingleLineTextField5"
        Me.MaterialSingleLineTextField5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField5.SelectedText = ""
        Me.MaterialSingleLineTextField5.SelectionLength = 0
        Me.MaterialSingleLineTextField5.SelectionStart = 0
        Me.MaterialSingleLineTextField5.Size = New System.Drawing.Size(345, 23)
        Me.MaterialSingleLineTextField5.TabIndex = 7
        Me.MaterialSingleLineTextField5.Text = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField5.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField3
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField3, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField3.Depth = 0
        Me.MaterialSingleLineTextField3.Hint = "Contact No"
        Me.MaterialSingleLineTextField3.Location = New System.Drawing.Point(793, 130)
        Me.MaterialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField3.Name = "MaterialSingleLineTextField3"
        Me.MaterialSingleLineTextField3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField3.SelectedText = ""
        Me.MaterialSingleLineTextField3.SelectionLength = 0
        Me.MaterialSingleLineTextField3.SelectionStart = 0
        Me.MaterialSingleLineTextField3.Size = New System.Drawing.Size(265, 23)
        Me.MaterialSingleLineTextField3.TabIndex = 9
        Me.MaterialSingleLineTextField3.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField7
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField7, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField7.Depth = 0
        Me.MaterialSingleLineTextField7.Hint = "Middlename"
        Me.MaterialSingleLineTextField7.Location = New System.Drawing.Point(627, 65)
        Me.MaterialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField7.Name = "MaterialSingleLineTextField7"
        Me.MaterialSingleLineTextField7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField7.SelectedText = ""
        Me.MaterialSingleLineTextField7.SelectionLength = 0
        Me.MaterialSingleLineTextField7.SelectionStart = 0
        Me.MaterialSingleLineTextField7.Size = New System.Drawing.Size(151, 23)
        Me.MaterialSingleLineTextField7.TabIndex = 10
        Me.MaterialSingleLineTextField7.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField2
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "Lastname"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(793, 65)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(265, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 11
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField1
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Firstname"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(349, 65)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(265, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 12
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "ThinButton"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(59, 295)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(198, 41)
        Me.BunifuThinButton21.TabIndex = 1
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Location = New System.Drawing.Point(59, 65)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(198, 225)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'addStudent
        '
        Me.addStudent.BackColor = System.Drawing.Color.White
        Me.addStudent.Controls.Add(Me.BunifuThinButton22)
        Me.addStudent.Controls.Add(Me.PictureBox4)
        Me.BunifuTransition1.SetDecoration(Me.addStudent, BunifuAnimatorNS.DecorationType.None)
        Me.addStudent.Location = New System.Drawing.Point(4, 24)
        Me.addStudent.Margin = New System.Windows.Forms.Padding(0)
        Me.addStudent.Name = "addStudent"
        Me.addStudent.Padding = New System.Windows.Forms.Padding(3)
        Me.addStudent.Size = New System.Drawing.Size(1303, 684)
        Me.addStudent.TabIndex = 1
        Me.addStudent.Text = "Add Student"
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "ThinButton"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.BunifuThinButton22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(57, 293)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(0)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(198, 41)
        Me.BunifuThinButton22.TabIndex = 3
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.PictureBox4, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox4.Location = New System.Drawing.Point(57, 65)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(198, 225)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.T
        Me.BunifuTransition1.SetDecoration(Me.MaterialTabSelector1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1311, 37)
        Me.MaterialTabSelector1.TabIndex = 1
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialRadioButton1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(477, 125)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(59, 30)
        Me.MaterialRadioButton1.TabIndex = 14
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Male"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialRadioButton2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(607, 125)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(74, 30)
        Me.MaterialRadioButton2.TabIndex = 14
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "Female"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(345, 130)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "Gender"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.dashboardMainPnl)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.hamburgerPnl.ResumeLayout(False)
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardMainPnl.ResumeLayout(False)
        Me.dashboardTablePnl.ResumeLayout(False)
        Me.editTablePanelAdmin.ResumeLayout(False)
        Me.T.ResumeLayout(False)
        Me.addUserTb.ResumeLayout(False)
        Me.addUserTb.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addStudent.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents dashboardMainPnl As System.Windows.Forms.Panel
    Friend WithEvents hamburgerPnl As System.Windows.Forms.Panel
    Friend WithEvents hamburgerPb As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dashboardTablePnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents editTablePanelAdmin As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents T As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents addUserTb As System.Windows.Forms.TabPage
    Friend WithEvents addStudent As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MaterialSingleLineTextField6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
