Imports Transitions
Imports MaterialSkin.Controls
Imports BunifuAnimatorNS
Imports System.IO

Public Class Dashboard
    Dim ar As New AddRemoveStudentStaff
    Dim ps As New ProgramAndSubjects
    Dim a As New Attendance
    Dim feeManager As New frmFeeManager
    Dim setting As New Setting
    Dim result As New Result
    Dim notice As New Notice
    Dim bin As New RecycleBin
    Public userType As String

    Sub unVisibleAll()
        PcMgmtButton.Visible = False
        RecycleBinButton.Visible = False
        NoticeButton.Visible = False
        BillButton.Visible = False
        SettingButton.Visible = False
        AddRemoveButton.Visible = False
        AttendanceButton.Visible = False
        ResultButton.Visible = False
    End Sub
    Sub userChecker()
        userType = Login.usertype
        If (userType = "") Then
            PcMgmtButton.Visible = True
            RecycleBinButton.Visible = True
            NoticeButton.Visible = True
            BillButton.Visible = True
            SettingButton.Visible = True
            AddRemoveButton.Visible = True
            AttendanceButton.Visible = True
            ResultButton.Visible = True
        Else
            If (userType.Equals("Student")) Then
                unVisibleAll()
                AttendanceButton.Visible = True
                ResultButton.Visible = True
                HamburgerButton.Dock = DockStyle.Top
                HomeButton.Dock = DockStyle.Top
                AttendanceButton.Dock = DockStyle.Top
                ResultButton.Dock = DockStyle.Top
            ElseIf (userType.Equals("Receptionist")) Then
                unVisibleAll()
                AddRemoveButton.Visible = True
                SettingButton.Visible = True
                HamburgerButton.Dock = DockStyle.Top
                HomeButton.Dock = DockStyle.Top
                AddRemoveButton.Dock = DockStyle.Top
                SettingButton.Dock = DockStyle.Bottom
            End If
        End If
      
    End Sub
    Sub closeAll()
        ar.Close()
        ps.Close()
        a.Close()
        feeManager.Close()
        setting.Close()
        result.Close()
        notice.Close()
        bin.Close()
    End Sub
    Private Sub HamburgerButton_Click(sender As Object, e As EventArgs) Handles HamburgerButton.Click
        userDetail()
        If (hamburgerPnl.Width < 250) Then
            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(20))
            Dim i As Integer = 0
            Dim buttonArray() As Button = New Button() {HamburgerButton, CloseButton, AddRemoveButton, RecycleBinButton, AttendanceButton, PcMgmtButton, HomeButton, LogOutButton, ResultButton, BillButton, NoticeButton, SettingButton}
            Dim textName As String() = {"MENU", "EXIT", "CRUD", "RECYCLER", "ATTENDANCE", "FACULTY MGMT", "HOME", "LOG OUT", "RESULT", "FEES MGMT", "NOTICE", "SETTING"}
            For Each values As Button In buttonArray
                'values.Width = 250
                Transition.run(values, "Width", 250, New TransitionType_EaseInEaseOut(30))
                values.Text = textName(i)
                i = i + 1
            Next
            HamburgerButton.Width = 250
        Else
            Transition.run(hamburgerPnl, "Width", 45, New TransitionType_EaseInEaseOut(20))
            Dim buttonArray() As Button = New Button() {HamburgerButton, CloseButton, AddRemoveButton, RecycleBinButton, AttendanceButton, PcMgmtButton, HomeButton, LogOutButton, ResultButton, BillButton, NoticeButton, SettingButton}
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
        'closeAll()
        Cursor = Cursors.WaitCursor
        bin.MdiParent = Me
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(bin)
        bin.Dock = DockStyle.Fill
        bin.Show()
        bin.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
        Cursor = Cursors.Arrow
    End Sub

    Sub showAddRemoveStudentUserPanel()
        'closeAll()
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
        'closeAll()
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
        'closeAll()
        MainPanel.Controls.Clear()
        a.MdiParent = Me
        MainPanel.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Show()
        a.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub showSetting()
        'closeAll()
        MainPanel.Controls.Clear()
        setting.MdiParent = Me
        MainPanel.Controls.Add(setting)
        setting.Dock = DockStyle.Fill
        setting.Show()
        setting.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub showResult()
        'closeAll()
        MainPanel.Controls.Clear()
        result.MdiParent = Me
        MainPanel.Controls.Add(result)
        result.Dock = DockStyle.Fill
        result.Show()
        result.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub showFeeMgmt()
        'closeAll()
        MainPanel.Controls.Clear()
        feeManager.MdiParent = Me
        MainPanel.Controls.Add(feeManager)
        feeManager.Dock = DockStyle.Fill
        feeManager.Show()
        feeManager.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub showNotice()
        'closeAll()
        MainPanel.Controls.Clear()
        notice.MdiParent = Me
        MainPanel.Controls.Add(notice)
        notice.Dock = DockStyle.Fill
        notice.Show()
        notice.BringToFront()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Sub fullScreen()
        Me.Top = 0
        Me.Left = 0
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
    End Sub
    'Dim b As String
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fullScreen()
        userChecker()
        userDetail()
        profileDrop()
        labelCenterer(NameLabel)
        labelCenterer(PhoneNoLabel)
        labelCenterer(EmailLabel)

    End Sub

    'Public Sub New(ByVal empid As String)
    '    InitializeComponent()
    '    b = empid
    'End Sub
    'Centers label to its parent
    Sub labelCenterer(ByVal a As Label)
        a.Left = (a.Parent.Width \ 2) - (a.Width \ 2)
    End Sub

    Sub profileDrop()
        circularImage(ProfilePictureBox)

        NameLabel.Text = Login.fname & " " & Login.lname
        PhoneNoLabel.Text = Login.phone
        EmailLabel.Text = Login.email
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

    Private Sub AdminSettingButton_Click(sender As Object, e As EventArgs) Handles PcMgmtButton.Click
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
            Transition.run(UserDetailPanel, "Height", 600, New TransitionType_Acceleration(100))
            SlideDownButton.Image = My.Resources.Collapse_Arrow_24px1
            userDetail()
        Else
            Transition.run(UserDetailPanel, "Height", 18, New TransitionType_EaseInEaseOut(100))
            SlideDownButton.Image = My.Resources.Expand_Arrow_24px
            userDetail()
        End If
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Close()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(UserDetailPanel)
        UserDetailPanel.BringToFront()
    End Sub

    Private Sub ResultButton_Click(sender As Object, e As EventArgs) Handles ResultButton.Click
        showResult()
    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs) Handles BillButton.Click
        showFeeMgmt()
    End Sub

    Private Sub NoticeButton_Click(sender As Object, e As EventArgs) Handles NoticeButton.Click
        showNotice()
    End Sub
End Class