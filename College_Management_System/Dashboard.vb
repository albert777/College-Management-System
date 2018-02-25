Imports Transitions
Imports MaterialSkin.Controls
Imports BunifuAnimatorNS

Public Class Dashboard
    Dim bin As RecycleBin = New RecycleBin()
    Dim ar As AddRemoveStudentStaff = New AddRemoveStudentStaff()
    Dim ps As ProgramAndSubjects = New ProgramAndSubjects()
    Private Sub hamburgerPb_Click_1(sender As Object, e As EventArgs) Handles hamburgerPb.Click
        If (hamburgerPnl.Width < 250) Then
            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(150))
        Else
            Transition.run(hamburgerPnl, "Width", 55, New TransitionType_EaseInEaseOut(150))
        End If
    End Sub
    Sub showRecycleBin()
        bin.MdiParent = Me
        MainPanel.Controls.Add(bin)
        bin.Dock = DockStyle.Fill
        bin.Visible = True
        bin.BringToFront()
        ar.Visible = False
        ps.Visible = False
    End Sub
    Sub showAddRemoveStudentUserPanel()
        ar.MdiParent = Me
        MainPanel.Controls.Add(ar)
        ar.Dock = DockStyle.Fill
        ar.Visible = True
        ar.BringToFront()
        bin.Visible = False
        ps.Visible = False
    End Sub
    Sub showCourseAndSubjects()
        ps.MdiParent = Me
        MainPanel.Controls.Add(ps)
        ps.Dock = DockStyle.Fill
        ps.Visible = True
        ps.BringToFront()
        ar.Visible = False
        bin.Visible = False

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        showRecycleBin()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        showAddRemoveStudentUserPanel()
    End Sub


    Private Sub CrossPictureBox_Click(sender As Object, e As EventArgs) Handles CrossPictureBox.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        showCourseAndSubjects()
    End Sub
    Sub fullScreen()
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fullScreen()
    End Sub
End Class