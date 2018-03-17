Imports Transitions
Imports MaterialSkin.Controls
Imports BunifuAnimatorNS
Imports System.IO

Public Class Dashboard
    Dim ar As New AddRemoveStudentStaff
    Dim ps As New ProgramAndSubjects
    Dim a As New Attendance
    Dim bin As New RecycleBin
    Private Sub HamburgerButton_Click(sender As Object, e As EventArgs) Handles HamburgerButton.Click
        userDetail()
        If (hamburgerPnl.Width < 250) Then
            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(20))
            Dim i As Integer = 0
            Dim buttonArray() As Button = New Button() {HamburgerButton, CloseButton, AddRemoveButton, RecycleBinButton, AttendanceButton, AdminSettingButton, HomeButton, LogOutButton}
            Dim textName As String() = {"MENU", "EXIT", "CRUD", "RECYCLER", "ATTENDANCE", "SETTINGS", "HOME", "LOG OUT"}
            For Each values As Button In buttonArray
                'values.Width = 250
                Transition.run(values, "Width", 250, New TransitionType_EaseInEaseOut(30))
                values.Text = textName(i)
                i = i + 1
            Next
            HamburgerButton.Width = 250
        Else
            Transition.run(hamburgerPnl, "Width", 45, New TransitionType_EaseInEaseOut(20))
            Dim buttonArray() As Button = New Button() {HamburgerButton, CloseButton, AddRemoveButton, RecycleBinButton, AttendanceButton, AdminSettingButton, HomeButton, LogOutButton}
            For Each values As Button In buttonArray
                'values.Width = 45
                Transition.run(values, "Width", 45, New TransitionType_EaseInEaseOut(30))
                values.Text = ""
            Next
        End If
    End Sub

    'Transform picturebox into circular format
    Sub circularImage(ByVal pb As PictureBox)
        Dim gp As Drawing2D.GraphicsPath
        Dim rg As Region
        gp = New Drawing2D.GraphicsPath
        gp.AddEllipse(0, 0, pb.Width - 4, pb.Height - 4)
        rg = New Region(gp)
        pb.Region = rg
    End Sub

    Sub showRecycleBin()
        bin.MdiParent = Me
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(bin)
        bin.Dock = DockStyle.Fill
        bin.Show()
        bin.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()

    End Sub

    Sub showAddRemoveStudentUserPanel()
        MainPanel.Controls.Clear()
        ar.MdiParent = Me
        MainPanel.Controls.Add(ar)
        ar.Dock = DockStyle.Fill
        ar.Show()
        ar.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
        ps.Hide()
        a.Hide()
    End Sub

    Sub showCourseAndSubjects()
        MainPanel.Controls.Clear()
        ps.MdiParent = Me
        MainPanel.Controls.Add(ps)
        ps.Dock = DockStyle.Fill
        ps.Show()
        ps.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub showAttendance()
        MainPanel.Controls.Clear()
        a.MdiParent = Me
        MainPanel.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Show()
        a.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub fullScreen()
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fullScreen()
        userDetail()
        profileDrop()
        labelCenterer(UserTypeLabel)
        labelCenterer(UsernameLabel)
    End Sub
    'Centers label to its parent
    Sub labelCenterer(ByVal a As Label)
        a.Left = (a.Parent.Width \ 2) - (a.Width \ 2)
    End Sub

    Sub profileDrop()
        circularImage(ProfilePictureBox)
        UserTypeLabel.Text = Login.usertype
        UsernameLabel.Text = Login.username
        Dim img() As Byte
        img = Login.img

        If (img IsNot Nothing) Then
            Dim ms As New MemoryStream(img)
            ProfilePictureBox.Image = Image.FromStream(ms)
        Else

        End If

    End Sub

    Sub userDetail()
        UserDetailPanel.BackColor = Color.FromArgb(125, Color.Black)
        SlideDownButton.BackColor = Color.FromArgb(125, Color.Black)
    End Sub

    Private Sub AddRemoveButton_Click(sender As Object, e As EventArgs) Handles AddRemoveButton.Click
        showAddRemoveStudentUserPanel()
        userDetail()
    End Sub

    Private Sub AdminSettingButton_Click(sender As Object, e As EventArgs) Handles AdminSettingButton.Click
        showCourseAndSubjects()
        userDetail()
    End Sub

    Private Sub RecycleBinButton_Click(sender As Object, e As EventArgs) Handles RecycleBinButton.Click
        showRecycleBin()
        userDetail()
    End Sub

    Private Sub AttendanceButton_Click(sender As Object, e As EventArgs) Handles AttendanceButton.Click
        showAttendance()
        userDetail()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SlideDownButton.Click

        If (UserDetailPanel.Height < 19) Then
            Transition.run(UserDetailPanel, "Height", 600, New TransitionType_EaseInEaseOut(100))
            SlideDownButton.Image = My.Resources.Collapse_Arrow_24px1
            userDetail()
        Else
            Transition.run(UserDetailPanel, "Height", 18, New TransitionType_EaseInEaseOut(100))
            SlideDownButton.Image = My.Resources.Expand_Arrow_24px
            userDetail()
        End If
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub
End Class