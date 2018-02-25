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
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.hamburgerPnl = New System.Windows.Forms.Panel()
        Me.CrossPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.hamburgerPb = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.ImageOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.dashboardTablePnl = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl3 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.hamburgerPnl.SuspendLayout()
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardTablePnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'hamburgerPnl
        '
        Me.hamburgerPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerPnl.Controls.Add(Me.CrossPictureBox)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox5)
        Me.hamburgerPnl.Controls.Add(Me.hamburgerPb)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox2)
        Me.hamburgerPnl.Controls.Add(Me.PictureBox1)
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPnl, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerPnl.Margin = New System.Windows.Forms.Padding(0)
        Me.hamburgerPnl.Name = "hamburgerPnl"
        Me.hamburgerPnl.Size = New System.Drawing.Size(55, 729)
        Me.hamburgerPnl.TabIndex = 3
        '
        'CrossPictureBox
        '
        Me.CrossPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.CrossPictureBox, BunifuAnimatorNS.DecorationType.None)
        Me.CrossPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrossPictureBox.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px2
        Me.CrossPictureBox.Location = New System.Drawing.Point(0, 697)
        Me.CrossPictureBox.Name = "CrossPictureBox"
        Me.CrossPictureBox.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.CrossPictureBox.Size = New System.Drawing.Size(55, 32)
        Me.CrossPictureBox.TabIndex = 5
        Me.CrossPictureBox.TabStop = False
        '
        'PictureBox5
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox5, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox5.Image = Global.College_Management_System.My.Resources.Resources.Trash_32px
        Me.PictureBox5.Location = New System.Drawing.Point(8, 187)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'hamburgerPb
        '
        Me.hamburgerPb.BackColor = System.Drawing.Color.Transparent
        Me.hamburgerPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTransition1.SetDecoration(Me.hamburgerPb, BunifuAnimatorNS.DecorationType.None)
        Me.hamburgerPb.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.hamburgerPb.Location = New System.Drawing.Point(11, 12)
        Me.hamburgerPb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.hamburgerPb.Name = "hamburgerPb"
        Me.hamburgerPb.Size = New System.Drawing.Size(32, 26)
        Me.hamburgerPb.TabIndex = 1
        Me.hamburgerPb.TabStop = False
        '
        'PictureBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.College_Management_System.My.Resources.Resources.Registration_32px
        Me.PictureBox2.Location = New System.Drawing.Point(11, 68)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.College_Management_System.My.Resources.Resources.Admin_Settings_Male_32px
        Me.PictureBox1.Location = New System.Drawing.Point(10, 126)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainPanel
        '
        Me.BunifuTransition1.SetDecoration(Me.MainPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(60, 0)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1290, 729)
        Me.MainPanel.TabIndex = 0
        '
        'ImageOpenDialog
        '
        Me.ImageOpenDialog.FileName = "Image Opener"
        '
        'dashboardTablePnl
        '
        Me.dashboardTablePnl.BackColor = System.Drawing.Color.LightSalmon
        Me.dashboardTablePnl.ColumnCount = 2
        Me.dashboardTablePnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
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
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0.0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0.0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(0)
        Animation3.RotateCoeff = 0.0!
        Animation3.RotateLimit = 0.0!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0.0!
        Animation3.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation3
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
        CType(Me.CrossPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardTablePnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents hamburgerPnl As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents hamburgerPb As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents ImageOpenDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dashboardTablePnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl3 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents CrossPictureBox As System.Windows.Forms.PictureBox
End Class
