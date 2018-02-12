<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.hamburgerBarPnl = New System.Windows.Forms.Panel()
        Me.hamburgerPb = New System.Windows.Forms.PictureBox()
        Me.settingPb = New System.Windows.Forms.PictureBox()
        Me.crossPb = New System.Windows.Forms.PictureBox()
        Me.settingTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.hamburgerBarPnl.SuspendLayout()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crossPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingTableLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hamburgerBarPnl
        '
        Me.hamburgerBarPnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.hamburgerBarPnl.Controls.Add(Me.hamburgerPb)
        Me.hamburgerBarPnl.Controls.Add(Me.settingPb)
        Me.hamburgerBarPnl.Dock = System.Windows.Forms.DockStyle.Left
        Me.hamburgerBarPnl.Location = New System.Drawing.Point(0, 0)
        Me.hamburgerBarPnl.Name = "hamburgerBarPnl"
        Me.hamburgerBarPnl.Size = New System.Drawing.Size(42, 733)
        Me.hamburgerBarPnl.TabIndex = 3
        '
        'hamburgerPb
        '
        Me.hamburgerPb.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.hamburgerPb.Location = New System.Drawing.Point(5, 13)
        Me.hamburgerPb.Name = "hamburgerPb"
        Me.hamburgerPb.Size = New System.Drawing.Size(33, 31)
        Me.hamburgerPb.TabIndex = 4
        Me.hamburgerPb.TabStop = False
        '
        'settingPb
        '
        Me.settingPb.Image = Global.College_Management_System.My.Resources.Resources.Settings_32px
        Me.settingPb.Location = New System.Drawing.Point(4, 689)
        Me.settingPb.Margin = New System.Windows.Forms.Padding(0)
        Me.settingPb.Name = "settingPb"
        Me.settingPb.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.settingPb.Size = New System.Drawing.Size(32, 35)
        Me.settingPb.TabIndex = 2
        Me.settingPb.TabStop = False
        '
        'crossPb
        '
        Me.crossPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.crossPb.Image = Global.College_Management_System.My.Resources.Resources.Delete_32px2
        Me.crossPb.Location = New System.Drawing.Point(1293, 12)
        Me.crossPb.Name = "crossPb"
        Me.crossPb.Size = New System.Drawing.Size(31, 31)
        Me.crossPb.TabIndex = 5
        Me.crossPb.TabStop = False
        '
        'settingTableLayout
        '
        Me.settingTableLayout.ColumnCount = 1
        Me.settingTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.settingTableLayout.Controls.Add(Me.Panel1, 0, 0)
        Me.settingTableLayout.Controls.Add(Me.MetroPanel1, 0, 1)
        Me.settingTableLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settingTableLayout.Location = New System.Drawing.Point(0, 0)
        Me.settingTableLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.settingTableLayout.Name = "settingTableLayout"
        Me.settingTableLayout.RowCount = 2
        Me.settingTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.19271!))
        Me.settingTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.80729!))
        Me.settingTableLayout.Size = New System.Drawing.Size(1336, 733)
        Me.settingTableLayout.TabIndex = 4
        Me.settingTableLayout.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.crossPb)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1336, 104)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.College_Management_System.My.Resources.Resources.Left_32px
        Me.PictureBox1.Location = New System.Drawing.Point(69, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MetroPanel1
        '
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 104)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1336, 629)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1336, 733)
        Me.Controls.Add(Me.hamburgerBarPnl)
        Me.Controls.Add(Me.settingTableLayout)
        Me.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.hamburgerBarPnl.ResumeLayout(False)
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crossPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingTableLayout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents settingPb As PictureBox
    Friend WithEvents hamburgerBarPnl As Panel
    Friend WithEvents hamburgerPb As PictureBox
    Friend WithEvents settingTableLayout As TableLayoutPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents crossPb As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
