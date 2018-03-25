<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notice
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NoticeLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NDeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PublishButton = New System.Windows.Forms.Button()
        Me.NoticeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AllNoticeListView = New System.Windows.Forms.ListBox()
        Me.NoticeHeadingTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.09091!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.90909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 610.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1076, 721)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.NoticeLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 54)
        Me.Panel1.TabIndex = 1
        '
        'NoticeLabel
        '
        Me.NoticeLabel.AutoSize = True
        Me.NoticeLabel.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoticeLabel.ForeColor = System.Drawing.Color.White
        Me.NoticeLabel.Location = New System.Drawing.Point(27, 9)
        Me.NoticeLabel.Name = "NoticeLabel"
        Me.NoticeLabel.Size = New System.Drawing.Size(115, 39)
        Me.NoticeLabel.TabIndex = 0
        Me.NoticeLabel.Text = "NOTICE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NoticeHeadingTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1076, 56)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.SeaShell
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.89447!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.10553!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AllNoticeListView, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 110)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1076, 611)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.NoticeRichTextBox, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.84437!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.155635!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(842, 605)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.NDeleteButton)
        Me.Panel3.Controls.Add(Me.UpdateButton)
        Me.Panel3.Controls.Add(Me.PublishButton)
        Me.Panel3.Location = New System.Drawing.Point(3, 564)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(836, 38)
        Me.Panel3.TabIndex = 0
        '
        'NDeleteButton
        '
        Me.NDeleteButton.Location = New System.Drawing.Point(732, 9)
        Me.NDeleteButton.Name = "NDeleteButton"
        Me.NDeleteButton.Size = New System.Drawing.Size(95, 23)
        Me.NDeleteButton.TabIndex = 0
        Me.NDeleteButton.Text = "Delete"
        Me.NDeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(631, 9)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(95, 23)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'PublishButton
        '
        Me.PublishButton.Location = New System.Drawing.Point(530, 8)
        Me.PublishButton.Name = "PublishButton"
        Me.PublishButton.Size = New System.Drawing.Size(95, 23)
        Me.PublishButton.TabIndex = 0
        Me.PublishButton.Text = "Publish"
        Me.PublishButton.UseVisualStyleBackColor = True
        '
        'NoticeRichTextBox
        '
        Me.NoticeRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NoticeRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.NoticeRichTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.NoticeRichTextBox.Name = "NoticeRichTextBox"
        Me.NoticeRichTextBox.Size = New System.Drawing.Size(842, 561)
        Me.NoticeRichTextBox.TabIndex = 1
        Me.NoticeRichTextBox.Text = ""
        '
        'AllNoticeListView
        '
        Me.AllNoticeListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AllNoticeListView.FormattingEnabled = True
        Me.AllNoticeListView.Location = New System.Drawing.Point(851, 3)
        Me.AllNoticeListView.Name = "AllNoticeListView"
        Me.AllNoticeListView.Size = New System.Drawing.Size(222, 605)
        Me.AllNoticeListView.TabIndex = 2
        '
        'NoticeHeadingTextBox
        '
        Me.NoticeHeadingTextBox.Depth = 0
        Me.NoticeHeadingTextBox.Hint = "Enter your notice heading"
        Me.NoticeHeadingTextBox.Location = New System.Drawing.Point(34, 17)
        Me.NoticeHeadingTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.NoticeHeadingTextBox.Name = "NoticeHeadingTextBox"
        Me.NoticeHeadingTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NoticeHeadingTextBox.SelectedText = ""
        Me.NoticeHeadingTextBox.SelectionLength = 0
        Me.NoticeHeadingTextBox.SelectionStart = 0
        Me.NoticeHeadingTextBox.Size = New System.Drawing.Size(312, 23)
        Me.NoticeHeadingTextBox.TabIndex = 0
        Me.NoticeHeadingTextBox.UseSystemPasswordChar = False
        '
        'Notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 721)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notice"
        Me.Text = "Notice"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents NoticeLabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NDeleteButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents PublishButton As System.Windows.Forms.Button
    Friend WithEvents NoticeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AllNoticeListView As System.Windows.Forms.ListBox
    Friend WithEvents NoticeHeadingTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
