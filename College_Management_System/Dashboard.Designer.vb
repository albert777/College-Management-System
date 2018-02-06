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
        Me.settingTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.hamburgerPb = New System.Windows.Forms.PictureBox()
        Me.settingPb = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hamburgerBarPnl.SuspendLayout()
        Me.settingTableLayout.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingPb, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.hamburgerBarPnl.Size = New System.Drawing.Size(42, 768)
        Me.hamburgerBarPnl.TabIndex = 3
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
        Me.settingTableLayout.Size = New System.Drawing.Size(1336, 768)
        Me.settingTableLayout.TabIndex = 4
        Me.settingTableLayout.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1336, 108)
        Me.Panel1.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroToggle1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 108)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1336, 660)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroToggle1
        '
        Me.MetroToggle1.BackColor = System.Drawing.Color.Transparent
        Me.MetroToggle1.Checked = True
        Me.MetroToggle1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroToggle1.Location = New System.Drawing.Point(166, 28)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(92, 18)
        Me.MetroToggle1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroToggle1.TabIndex = 2
        Me.MetroToggle1.Text = "On"
        Me.MetroToggle1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroToggle1.ThreeState = True
        Me.MetroToggle1.UseCustomBackColor = True
        Me.MetroToggle1.UseCustomForeColor = True
        Me.MetroToggle1.UseSelectable = True
        Me.MetroToggle1.UseStyleColors = True
        '
        'hamburgerPb
        '
        Me.hamburgerPb.Image = Global.College_Management_System.My.Resources.Resources.Menu_32px
        Me.hamburgerPb.Location = New System.Drawing.Point(3, 12)
        Me.hamburgerPb.Name = "hamburgerPb"
        Me.hamburgerPb.Size = New System.Drawing.Size(33, 31)
        Me.hamburgerPb.TabIndex = 4
        Me.hamburgerPb.TabStop = False
        '
        'settingPb
        '
        Me.settingPb.Image = Global.College_Management_System.My.Resources.Resources.Settings_32px
        Me.settingPb.Location = New System.Drawing.Point(5, 723)
        Me.settingPb.Name = "settingPb"
        Me.settingPb.Size = New System.Drawing.Size(31, 33)
        Me.settingPb.TabIndex = 2
        Me.settingPb.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.College_Management_System.My.Resources.Resources.Left_32px
        Me.PictureBox1.Location = New System.Drawing.Point(48, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1336, 768)
        Me.Controls.Add(Me.hamburgerBarPnl)
        Me.Controls.Add(Me.settingTableLayout)
        Me.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.hamburgerBarPnl.ResumeLayout(False)
        Me.settingTableLayout.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        CType(Me.hamburgerPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingPb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents settingPb As PictureBox
    Friend WithEvents hamburgerBarPnl As Panel
    Friend WithEvents hamburgerPb As PictureBox
    Friend WithEvents settingTableLayout As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents PictureBox1 As PictureBox
End Class
