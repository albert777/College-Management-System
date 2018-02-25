<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splashscreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splashscreen))
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.splashProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.developedBy = New System.Windows.Forms.Label()
        Me.logoPb = New System.Windows.Forms.PictureBox()
        Me.copyrightLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.logoPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Enabled = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.splashProgressBar, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 384)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'splashProgressBar
        '
        Me.splashProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splashProgressBar.Location = New System.Drawing.Point(0, 376)
        Me.splashProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.splashProgressBar.MarqueeAnimationSpeed = 50
        Me.splashProgressBar.Maximum = 101
        Me.splashProgressBar.Name = "splashProgressBar"
        Me.splashProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.splashProgressBar.Size = New System.Drawing.Size(249, 8)
        Me.splashProgressBar.Step = 2
        Me.splashProgressBar.Style = MetroFramework.MetroColorStyle.White
        Me.splashProgressBar.TabIndex = 2
        Me.splashProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.splashProgressBar.UseCustomBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.developedBy)
        Me.Panel2.Controls.Add(Me.logoPb)
        Me.Panel2.Controls.Add(Me.copyrightLbl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(249, 376)
        Me.Panel2.TabIndex = 4
        '
        'developedBy
        '
        Me.developedBy.AutoEllipsis = True
        Me.developedBy.ForeColor = System.Drawing.Color.White
        Me.developedBy.Location = New System.Drawing.Point(19, 255)
        Me.developedBy.Name = "developedBy"
        Me.developedBy.Size = New System.Drawing.Size(209, 59)
        Me.developedBy.TabIndex = 3
        Me.developedBy.Text = "Manjit Shakya, Sandesh Maharjan, Rahil Shakya, Asmin Khadka, Nirjar Maharjan"
        Me.developedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logoPb
        '
        Me.logoPb.BackgroundImage = Global.College_Management_System.My.Resources.Resources.CMS
        Me.logoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoPb.Location = New System.Drawing.Point(38, 47)
        Me.logoPb.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.logoPb.Name = "logoPb"
        Me.logoPb.Size = New System.Drawing.Size(178, 124)
        Me.logoPb.TabIndex = 0
        Me.logoPb.TabStop = False
        '
        'copyrightLbl
        '
        Me.copyrightLbl.AutoSize = True
        Me.copyrightLbl.BackColor = System.Drawing.Color.Transparent
        Me.copyrightLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.copyrightLbl.ForeColor = System.Drawing.Color.White
        Me.copyrightLbl.Location = New System.Drawing.Point(50, 226)
        Me.copyrightLbl.Name = "copyrightLbl"
        Me.copyrightLbl.Size = New System.Drawing.Size(143, 15)
        Me.copyrightLbl.TabIndex = 2
        Me.copyrightLbl.Text = " © 2018 XYZ Corporation"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.48532!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.51468!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(647, 384)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.College_Management_System.My.Resources.Resources.Splash_image
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(249, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 384)
        Me.Panel1.TabIndex = 2
        '
        'Splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(647, 384)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splashscreen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.logoPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logoPb As PictureBox
    Friend WithEvents LoadingTimer As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents splashProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Panel2 As Panel
    Protected WithEvents developedBy As Label
    Friend WithEvents copyrightLbl As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
