<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramAndSubjects
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramAndSubjects))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SubjectDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgramDetailRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SubjectDetailRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ProgramNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SubjectNameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ProgramDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DeleteProgramBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.UpdateProgramBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DeleteSubjectBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.AddProgramBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.UpdateSubjectBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.AddSubjectBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProgramDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.MaterialLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1197, 176)
        Me.Panel1.TabIndex = 0
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(45, 119)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(298, 18)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Add/Update/Remove Program and Subjects"
        '
        'SubjectDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SubjectDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SubjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SubjectDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SubjectDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubjectDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubjectDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.DoubleBuffered = True
        Me.SubjectDataGridView.EnableHeadersVisualStyles = False
        Me.SubjectDataGridView.GridColor = System.Drawing.Color.White
        Me.SubjectDataGridView.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectDataGridView.HeaderForeColor = System.Drawing.Color.Black
        Me.SubjectDataGridView.Location = New System.Drawing.Point(679, 81)
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SubjectDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SubjectDataGridView.Size = New System.Drawing.Size(344, 156)
        Me.SubjectDataGridView.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.DeleteProgramBtn)
        Me.Panel2.Controls.Add(Me.UpdateProgramBtn)
        Me.Panel2.Controls.Add(Me.DeleteSubjectBtn)
        Me.Panel2.Controls.Add(Me.AddProgramBtn)
        Me.Panel2.Controls.Add(Me.UpdateSubjectBtn)
        Me.Panel2.Controls.Add(Me.AddSubjectBtn)
        Me.Panel2.Controls.Add(Me.ProgramDetailRichTextBox)
        Me.Panel2.Controls.Add(Me.SubjectDetailRichTextBox)
        Me.Panel2.Controls.Add(Me.ProgramNameTextBox)
        Me.Panel2.Controls.Add(Me.SubjectNameTextBox)
        Me.Panel2.Controls.Add(Me.ProgramDataGridView)
        Me.Panel2.Controls.Add(Me.SubjectDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1197, 514)
        Me.Panel2.TabIndex = 1
        '
        'ProgramDetailRichTextBox
        '
        Me.ProgramDetailRichTextBox.Location = New System.Drawing.Point(102, 329)
        Me.ProgramDetailRichTextBox.Name = "ProgramDetailRichTextBox"
        Me.ProgramDetailRichTextBox.Size = New System.Drawing.Size(533, 156)
        Me.ProgramDetailRichTextBox.TabIndex = 3
        Me.ProgramDetailRichTextBox.Text = ""
        '
        'SubjectDetailRichTextBox
        '
        Me.SubjectDetailRichTextBox.Location = New System.Drawing.Point(102, 81)
        Me.SubjectDetailRichTextBox.Name = "SubjectDetailRichTextBox"
        Me.SubjectDetailRichTextBox.Size = New System.Drawing.Size(533, 156)
        Me.SubjectDetailRichTextBox.TabIndex = 3
        Me.SubjectDetailRichTextBox.Text = ""
        '
        'ProgramNameTextBox
        '
        Me.ProgramNameTextBox.Depth = 0
        Me.ProgramNameTextBox.Hint = "Program"
        Me.ProgramNameTextBox.Location = New System.Drawing.Point(102, 300)
        Me.ProgramNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.ProgramNameTextBox.Name = "ProgramNameTextBox"
        Me.ProgramNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProgramNameTextBox.SelectedText = ""
        Me.ProgramNameTextBox.SelectionLength = 0
        Me.ProgramNameTextBox.SelectionStart = 0
        Me.ProgramNameTextBox.Size = New System.Drawing.Size(225, 23)
        Me.ProgramNameTextBox.TabIndex = 2
        Me.ProgramNameTextBox.UseSystemPasswordChar = False
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.Depth = 0
        Me.SubjectNameTextBox.Hint = "Subject"
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(102, 52)
        Me.SubjectNameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SubjectNameTextBox.SelectedText = ""
        Me.SubjectNameTextBox.SelectionLength = 0
        Me.SubjectNameTextBox.SelectionStart = 0
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(225, 23)
        Me.SubjectNameTextBox.TabIndex = 2
        Me.SubjectNameTextBox.UseSystemPasswordChar = False
        '
        'ProgramDataGridView
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProgramDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ProgramDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.ProgramDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProgramDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProgramDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ProgramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProgramDataGridView.DoubleBuffered = True
        Me.ProgramDataGridView.EnableHeadersVisualStyles = False
        Me.ProgramDataGridView.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.ProgramDataGridView.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.ProgramDataGridView.Location = New System.Drawing.Point(679, 329)
        Me.ProgramDataGridView.Name = "ProgramDataGridView"
        Me.ProgramDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProgramDataGridView.Size = New System.Drawing.Size(344, 156)
        Me.ProgramDataGridView.TabIndex = 1
        '
        'DeleteProgramBtn
        '
        Me.DeleteProgramBtn.ActiveBorderThickness = 1
        Me.DeleteProgramBtn.ActiveCornerRadius = 20
        Me.DeleteProgramBtn.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.DeleteProgramBtn.ActiveForecolor = System.Drawing.Color.White
        Me.DeleteProgramBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.DeleteProgramBtn.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteProgramBtn.BackgroundImage = CType(resources.GetObject("DeleteProgramBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteProgramBtn.ButtonText = "Delete"
        Me.DeleteProgramBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteProgramBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProgramBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.DeleteProgramBtn.IdleBorderThickness = 1
        Me.DeleteProgramBtn.IdleCornerRadius = 20
        Me.DeleteProgramBtn.IdleFillColor = System.Drawing.Color.White
        Me.DeleteProgramBtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.DeleteProgramBtn.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.DeleteProgramBtn.Location = New System.Drawing.Point(917, 493)
        Me.DeleteProgramBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.DeleteProgramBtn.Name = "DeleteProgramBtn"
        Me.DeleteProgramBtn.Size = New System.Drawing.Size(106, 41)
        Me.DeleteProgramBtn.TabIndex = 4
        Me.DeleteProgramBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateProgramBtn
        '
        Me.UpdateProgramBtn.ActiveBorderThickness = 1
        Me.UpdateProgramBtn.ActiveCornerRadius = 20
        Me.UpdateProgramBtn.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.UpdateProgramBtn.ActiveForecolor = System.Drawing.Color.White
        Me.UpdateProgramBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.UpdateProgramBtn.BackColor = System.Drawing.SystemColors.Control
        Me.UpdateProgramBtn.BackgroundImage = CType(resources.GetObject("UpdateProgramBtn.BackgroundImage"), System.Drawing.Image)
        Me.UpdateProgramBtn.ButtonText = "Update"
        Me.UpdateProgramBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateProgramBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateProgramBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.UpdateProgramBtn.IdleBorderThickness = 1
        Me.UpdateProgramBtn.IdleCornerRadius = 20
        Me.UpdateProgramBtn.IdleFillColor = System.Drawing.Color.White
        Me.UpdateProgramBtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.UpdateProgramBtn.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.UpdateProgramBtn.Location = New System.Drawing.Point(801, 493)
        Me.UpdateProgramBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.UpdateProgramBtn.Name = "UpdateProgramBtn"
        Me.UpdateProgramBtn.Size = New System.Drawing.Size(106, 41)
        Me.UpdateProgramBtn.TabIndex = 4
        Me.UpdateProgramBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeleteSubjectBtn
        '
        Me.DeleteSubjectBtn.ActiveBorderThickness = 1
        Me.DeleteSubjectBtn.ActiveCornerRadius = 20
        Me.DeleteSubjectBtn.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.DeleteSubjectBtn.ActiveForecolor = System.Drawing.Color.White
        Me.DeleteSubjectBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.DeleteSubjectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.DeleteSubjectBtn.BackgroundImage = CType(resources.GetObject("DeleteSubjectBtn.BackgroundImage"), System.Drawing.Image)
        Me.DeleteSubjectBtn.ButtonText = "Delete"
        Me.DeleteSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteSubjectBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteSubjectBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.DeleteSubjectBtn.IdleBorderThickness = 1
        Me.DeleteSubjectBtn.IdleCornerRadius = 20
        Me.DeleteSubjectBtn.IdleFillColor = System.Drawing.Color.White
        Me.DeleteSubjectBtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.DeleteSubjectBtn.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.DeleteSubjectBtn.Location = New System.Drawing.Point(917, 245)
        Me.DeleteSubjectBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.DeleteSubjectBtn.Name = "DeleteSubjectBtn"
        Me.DeleteSubjectBtn.Size = New System.Drawing.Size(106, 41)
        Me.DeleteSubjectBtn.TabIndex = 4
        Me.DeleteSubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddProgramBtn
        '
        Me.AddProgramBtn.ActiveBorderThickness = 1
        Me.AddProgramBtn.ActiveCornerRadius = 20
        Me.AddProgramBtn.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.AddProgramBtn.ActiveForecolor = System.Drawing.Color.White
        Me.AddProgramBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.AddProgramBtn.BackColor = System.Drawing.SystemColors.Control
        Me.AddProgramBtn.BackgroundImage = CType(resources.GetObject("AddProgramBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddProgramBtn.ButtonText = "Add"
        Me.AddProgramBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddProgramBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProgramBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.AddProgramBtn.IdleBorderThickness = 1
        Me.AddProgramBtn.IdleCornerRadius = 20
        Me.AddProgramBtn.IdleFillColor = System.Drawing.Color.White
        Me.AddProgramBtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.AddProgramBtn.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.AddProgramBtn.Location = New System.Drawing.Point(685, 493)
        Me.AddProgramBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.AddProgramBtn.Name = "AddProgramBtn"
        Me.AddProgramBtn.Size = New System.Drawing.Size(106, 41)
        Me.AddProgramBtn.TabIndex = 4
        Me.AddProgramBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateSubjectBtn
        '
        Me.UpdateSubjectBtn.ActiveBorderThickness = 1
        Me.UpdateSubjectBtn.ActiveCornerRadius = 20
        Me.UpdateSubjectBtn.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.UpdateSubjectBtn.ActiveForecolor = System.Drawing.Color.White
        Me.UpdateSubjectBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.UpdateSubjectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.UpdateSubjectBtn.BackgroundImage = CType(resources.GetObject("UpdateSubjectBtn.BackgroundImage"), System.Drawing.Image)
        Me.UpdateSubjectBtn.ButtonText = "Update"
        Me.UpdateSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateSubjectBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSubjectBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.UpdateSubjectBtn.IdleBorderThickness = 1
        Me.UpdateSubjectBtn.IdleCornerRadius = 20
        Me.UpdateSubjectBtn.IdleFillColor = System.Drawing.Color.White
        Me.UpdateSubjectBtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.UpdateSubjectBtn.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.UpdateSubjectBtn.Location = New System.Drawing.Point(801, 245)
        Me.UpdateSubjectBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.UpdateSubjectBtn.Name = "UpdateSubjectBtn"
        Me.UpdateSubjectBtn.Size = New System.Drawing.Size(106, 41)
        Me.UpdateSubjectBtn.TabIndex = 4
        Me.UpdateSubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddSubjectBtn
        '
        Me.AddSubjectBtn.ActiveBorderThickness = 1
        Me.AddSubjectBtn.ActiveCornerRadius = 20
        Me.AddSubjectBtn.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.AddSubjectBtn.ActiveForecolor = System.Drawing.Color.White
        Me.AddSubjectBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.AddSubjectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.AddSubjectBtn.BackgroundImage = CType(resources.GetObject("AddSubjectBtn.BackgroundImage"), System.Drawing.Image)
        Me.AddSubjectBtn.ButtonText = "Add"
        Me.AddSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddSubjectBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSubjectBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.AddSubjectBtn.IdleBorderThickness = 1
        Me.AddSubjectBtn.IdleCornerRadius = 20
        Me.AddSubjectBtn.IdleFillColor = System.Drawing.Color.White
        Me.AddSubjectBtn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.AddSubjectBtn.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.AddSubjectBtn.Location = New System.Drawing.Point(685, 245)
        Me.AddSubjectBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.AddSubjectBtn.Name = "AddSubjectBtn"
        Me.AddSubjectBtn.Size = New System.Drawing.Size(106, 41)
        Me.AddSubjectBtn.TabIndex = 4
        Me.AddSubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgramAndSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 690)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProgramAndSubjects"
        Me.Text = "ProgramAndSubjects"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ProgramDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SubjectDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgramDetailRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SubjectDetailRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents ProgramNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SubjectNameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ProgramDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DeleteProgramBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents UpdateProgramBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents DeleteSubjectBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents AddProgramBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents UpdateSubjectBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents AddSubjectBtn As Bunifu.Framework.UI.BunifuThinButton2
End Class
