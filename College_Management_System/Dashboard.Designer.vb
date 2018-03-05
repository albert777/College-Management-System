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
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.AddRemoveButton = New System.Windows.Forms.Button()
        Me.HamburgerButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.AdminSettingButton = New System.Windows.Forms.Button()
        Me.ImageOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.RecycleBinButton = New System.Windows.Forms.Button()
        Me.AttendanceButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.hamburgerPnl.SuspendLayout()
        Me.dashboardTablePnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'hamburgerPnl
        '
        Me.hamburgerPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerPnl.Controls.Add(Me.CloseButton)
        Me.hamburgerPnl.Controls.Add(Me.AttendanceButton)
        Me.hamburgerPnl.Controls.Add(Me.RecycleBinButton)
        Me.hamburgerPnl.Controls.Add(Me.AdminSettingButton)
        Me.hamburgerPnl.Controls.Add(Me.AddRemoveButton)
        Me.hamburgerPnl.Controls.Add(Me.HamburgerButton)
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPnl, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.hamburgerPnl.Name = "hamburgerPnl"
        Me.hamburgerPnl.Size = New System.Drawing.Size(45, 729)
        Me.hamburgerPnl.TabIndex = 3
        '
        'AddRemoveButton
        '
        Me.AddRemoveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.AddRemoveButton, BunifuAnimatorNS.DecorationType.None)
        Me.AddRemoveButton.FlatAppearance.BorderSize = 0
        Me.AddRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AddRemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AddRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddRemoveButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddRemoveButton.ForeColor = System.Drawing.Color.White
        Me.AddRemoveButton.Image = Global.College_Management_System.My.Resources.Resources.Registration_32px
        Me.AddRemoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddRemoveButton.Location = New System.Drawing.Point(0, 50)
        Me.AddRemoveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AddRemoveButton.Name = "AddRemoveButton"
        Me.AddRemoveButton.Size = New System.Drawing.Size(45, 50)
        Me.AddRemoveButton.TabIndex = 7
        Me.AddRemoveButton.UseVisualStyleBackColor = False
        '
        'HamburgerButton
        '
        Me.HamburgerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.HamburgerButton, BunifuAnimatorNS.DecorationType.None)
        Me.HamburgerButton.FlatAppearance.BorderSize = 0
        Me.HamburgerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.HamburgerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.HamburgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HamburgerButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HamburgerButton.ForeColor = System.Drawing.Color.White
        Me.HamburgerButton.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.HamburgerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HamburgerButton.Location = New System.Drawing.Point(0, 0)
        Me.HamburgerButton.Margin = New System.Windows.Forms.Padding(0)
        Me.HamburgerButton.Name = "HamburgerButton"
        Me.HamburgerButton.Size = New System.Drawing.Size(45, 50)
        Me.HamburgerButton.TabIndex = 7
        Me.HamburgerButton.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.BunifuTransition1.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(48, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1302, 729)
        Me.MainPanel.TabIndex = 0
        '
        'AdminSettingButton
        '
        Me.AdminSettingButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.AdminSettingButton, BunifuAnimatorNS.DecorationType.None)
        Me.AdminSettingButton.FlatAppearance.BorderSize = 0
        Me.AdminSettingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AdminSettingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AdminSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminSettingButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminSettingButton.ForeColor = System.Drawing.Color.White
        Me.AdminSettingButton.Image = Global.College_Management_System.My.Resources.Resources.Admin_Settings_Male_32px
        Me.AdminSettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AdminSettingButton.Location = New System.Drawing.Point(0, 100)
        Me.AdminSettingButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AdminSettingButton.Name = "AdminSettingButton"
        Me.AdminSettingButton.Size = New System.Drawing.Size(45, 50)
        Me.AdminSettingButton.TabIndex = 8
        Me.AdminSettingButton.UseVisualStyleBackColor = False
        '
        'ImageOpenDialog
        '
        Me.ImageOpenDialog.FileName = "Image Opener"
        '
        'dashboardTablePnl
        '
        Me.dashboardTablePnl.BackColor = System.Drawing.Color.LightSalmon
        Me.dashboardTablePnl.ColumnCount = 2
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Controls.Add(Me.MainPanel, 1, 0)
        Me.BunifuTransition1.SetDecoration(Me.dashboardTablePnl, BunifuAnimatorNS.DecorationType.None)
        Me.dashboardTablePnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboardTablePnl.Location = New System.Drawing.Point(0, 0)
        Me.dashboardTablePnl.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardTablePnl.Name = "dashboardTablePnl"
        Me.dashboardTablePnl.RowCount = 1
        Me.dashboardTablePnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dashboardTablePnl.Size = New System.Drawing.Size(1350, 729)
        Me.dashboardTablePnl.TabIndex = 4
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.MainPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.hamburgerPnl
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuDragControl3
        '
        Me.BunifuDragControl3.Fixed = True
        Me.BunifuDragControl3.Horizontal = True
        Me.BunifuDragControl3.TargetControl = Nothing
        Me.BunifuDragControl3.Vertical = True
        '
        'RecycleBinButton
        '
        Me.RecycleBinButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.RecycleBinButton, BunifuAnimatorNS.DecorationType.None)
        Me.RecycleBinButton.FlatAppearance.BorderSize = 0
        Me.RecycleBinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.RecycleBinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.RecycleBinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecycleBinButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecycleBinButton.ForeColor = System.Drawing.Color.White
        Me.RecycleBinButton.Image = Global.College_Management_System.My.Resources.Resources.Trash_32px
        Me.RecycleBinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecycleBinButton.Location = New System.Drawing.Point(0, 150)
        Me.RecycleBinButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RecycleBinButton.Name = "RecycleBinButton"
        Me.RecycleBinButton.Size = New System.Drawing.Size(45, 50)
        Me.RecycleBinButton.TabIndex = 9
        Me.RecycleBinButton.UseVisualStyleBackColor = False
        '
        'AttendanceButton
        '
        Me.AttendanceButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.AttendanceButton, BunifuAnimatorNS.DecorationType.None)
        Me.AttendanceButton.FlatAppearance.BorderSize = 0
        Me.AttendanceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.AttendanceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.AttendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttendanceButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceButton.ForeColor = System.Drawing.Color.White
        Me.AttendanceButton.Image = Global.College_Management_System.My.Resources.Resources.List_32px1
        Me.AttendanceButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AttendanceButton.Location = New System.Drawing.Point(0, 200)
        Me.AttendanceButton.Margin = New System.Windows.Forms.Padding(0)
        Me.AttendanceButton.Name = "AttendanceButton"
        Me.AttendanceButton.Size = New System.Drawing.Size(45, 50)
        Me.AttendanceButton.TabIndex = 10
        Me.AttendanceButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.CloseButton, BunifuAnimatorNS.DecorationType.None)
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px2
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(0, 679)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(45, 50)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.hamburgerPnl)
        Me.Controls.Add(Me.dashboardTablePnl)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.hamburgerPnl.ResumeLayout(False)
        Me.dashboardTablePnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents hamburgerPnl As System.Windows.Forms.Panel
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents ImageOpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dashboardTablePnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents HamburgerButton As System.Windows.Forms.Button
    Friend WithEvents AddRemoveButton As System.Windows.Forms.Button
    Friend WithEvents AdminSettingButton As System.Windows.Forms.Button
    Friend WithEvents RecycleBinButton As System.Windows.Forms.Button
    Friend WithEvents AttendanceButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
