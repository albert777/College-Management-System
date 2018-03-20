<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notification
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
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.DimGray
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Snow
        Me.BunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCards1.Margin = New System.Windows.Forms.Padding(0)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(387, 129)
        Me.BunifuCards1.TabIndex = 0
        '
        'Notification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 129)
        Me.Controls.Add(Me.BunifuCards1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notification"
        Me.Text = "Notification"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
End Class
