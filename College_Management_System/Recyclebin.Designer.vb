<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecycleBin
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UserDataGridView = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.RestoreDataGridViewButtonColumn = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UserDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.UserDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.UserDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RestoreDataGridViewButtonColumn})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UserDataGridView.DoubleBuffered = True
        Me.UserDataGridView.EnableHeadersVisualStyles = False
        Me.UserDataGridView.GridColor = System.Drawing.Color.White
        Me.UserDataGridView.HeaderBgColor = System.Drawing.Color.Black
        Me.UserDataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.UserDataGridView.Location = New System.Drawing.Point(0, 491)
        Me.UserDataGridView.Margin = New System.Windows.Forms.Padding(0)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UserDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.UserDataGridView.Size = New System.Drawing.Size(1200, 277)
        Me.UserDataGridView.TabIndex = 2
        '
        'RestoreDataGridViewButtonColumn
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.RestoreDataGridViewButtonColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.RestoreDataGridViewButtonColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestoreDataGridViewButtonColumn.HeaderText = "Restore"
        Me.RestoreDataGridViewButtonColumn.Name = "RestoreDataGridViewButtonColumn"
        Me.RestoreDataGridViewButtonColumn.Text = "Restore"
        Me.RestoreDataGridViewButtonColumn.ToolTipText = "Restore the user"
        Me.RestoreDataGridViewButtonColumn.UseColumnTextForButtonValue = True
        '
        'RecycleBin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 768)
        Me.Controls.Add(Me.UserDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecycleBin"
        Me.Text = "RecycleBin"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserDataGridView As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents RestoreDataGridViewButtonColumn As System.Windows.Forms.DataGridViewButtonColumn
End Class
