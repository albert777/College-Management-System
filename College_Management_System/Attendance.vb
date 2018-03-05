Public Class Attendance
    Dim su As AddRemoveStudentStaff = New AddRemoveStudentStaff
    Sub loadUsers()
        Dim dt As New DataTable
        dt = su.loadUsers("Select firstname FROM userTbl WHERE state = 1")
        AttendanceDataGridView.DataSource = dt
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsers()
    End Sub
End Class