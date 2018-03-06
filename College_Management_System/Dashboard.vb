Imports Transitions
Imports MaterialSkin.Controls
Imports BunifuAnimatorNS

Public Class Dashboard
    Dim bin As RecycleBin = New RecycleBin()
    Dim ar As AddRemoveStudentStaff = New AddRemoveStudentStaff()
    Dim ps As ProgramAndSubjects = New ProgramAndSubjects()
    Dim a As Attendance = New Attendance()

    Private Sub HamburgerButton_Click(sender As Object, e As EventArgs) Handles HamburgerButton.Click
        If (hamburgerPnl.Width < 250) Then
            Transition.run(hamburgerPnl, "Width", 250, New TransitionType_EaseInEaseOut(100))
            Dim i As Integer = 0
            Dim buttonArray() As Button = New Button() {HamburgerButton, CloseButton, AddRemoveButton, RecycleBinButton, AttendanceButton, AdminSettingButton}
            Dim textName As String() = {"MENU", "EXIT", "CRUD", "RECYCLER", "ATTENDANCE", "SETTING"}
            For Each values As Button In buttonArray
                'values.Width = 250
                Transition.run(values, "Width", 250, New TransitionType_EaseInEaseOut(125))
                values.Text = textName(i)
                i = i + 1
            Next
            HamburgerButton.Width = 250
        Else
            Transition.run(hamburgerPnl, "Width", 45, New TransitionType_EaseInEaseOut(125))
            Dim buttonArray() As Button = New Button() {HamburgerButton, CloseButton, AddRemoveButton, RecycleBinButton, AttendanceButton, AdminSettingButton}
            For Each values As Button In buttonArray
                'values.Width = 45
                Transition.run(values, "Width", 45, New TransitionType_EaseInEaseOut(100))
                values.Text = ""
            Next
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
        a.Visible = False
    End Sub

    Sub showAddRemoveStudentUserPanel()
        ar.MdiParent = Me
        MainPanel.Controls.Add(ar)
        ar.Dock = DockStyle.Fill
        ar.Visible = True
        ar.BringToFront()
        bin.Visible = False
        ps.Visible = False
        a.Visible = False
    End Sub

    Sub showCourseAndSubjects()
        ps.MdiParent = Me
        MainPanel.Controls.Add(ps)
        ps.Dock = DockStyle.Fill
        ps.Visible = True
        ps.BringToFront()
        ar.Visible = False
        bin.Visible = False
        a.Visible = False
    End Sub

    Sub showAttendance()
        a.MdiParent = Me
        MainPanel.Controls.Add(a)
        a.Dock = DockStyle.Fill
        a.Visible = True
        a.BringToFront()
        ar.Visible = False
        bin.Visible = False
        ps.Visible = False
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

    Private Sub AddRemoveButton_Click(sender As Object, e As EventArgs) Handles AddRemoveButton.Click
        showAddRemoveStudentUserPanel()
    End Sub

    Private Sub AdminSettingButton_Click(sender As Object, e As EventArgs) Handles AdminSettingButton.Click
        showCourseAndSubjects()
    End Sub

    Private Sub RecycleBinButton_Click(sender As Object, e As EventArgs) Handles RecycleBinButton.Click
        showRecycleBin()
    End Sub

    Private Sub AttendanceButton_Click(sender As Object, e As EventArgs) Handles AttendanceButton.Click
        showAttendance()
    End Sub
 
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub
End Class