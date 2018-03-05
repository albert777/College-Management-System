Imports System.Data.SqlClient
Public Class Attendance
    Dim su As AddRemoveStudentStaff = New AddRemoveStudentStaff
    Sub loadUsers()
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand("SELECT * FROM attendanceTbl WHERE Date = @a", con)
        cmd.Parameters.AddWithValue("@a", MetroDateTime1.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dts As New DataTable()
        da.Fill(dts)
        If (dts.Rows.Count > 0) Then
            AddButton.Enabled = False
            AttendanceDataGridView.DataSource = dts
            'If (dts.Rows.Item) Then

            'End If
        Else
            Dim dt As New DataTable
            AddButton.Enabled = True
            dt = su.loadUsers("Select Id,firstname FROM userTbl WHERE state = 1")
            AttendanceDataGridView.DataSource = dt
        End If


    End Sub

    Sub checkedAttendance()
        For i = 0 To AttendanceDataGridView.RowCount - 1
            AttendanceDataGridView.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PresentCheckBox.Click
        checkedAttendance()
    End Sub
    Sub sendValue()
    
        For Each row As DataGridViewRow In AttendanceDataGridView.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("PACheckBoxColumn").Value)
            If isSelected Then
                Dim con As SqlConnection = su.dbConnect()
                Dim cmd As New SqlCommand("INSERT INTO attendanceTbl VALUES(@a,@b,@c,@d)", con)
                cmd.Parameters.AddWithValue("@a", row.Cells("Id").Value)
                cmd.Parameters.AddWithValue("@b", row.Cells("firstname").Value)
                cmd.Parameters.AddWithValue("@c", "Present")
                cmd.Parameters.AddWithValue("@d", MetroDateTime1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                Dim con As SqlConnection = su.dbConnect()
                Dim cmd As New SqlCommand("INSERT INTO attendanceTbl VALUES(@a,@b,@c,@d)", con)
                cmd.Parameters.AddWithValue("@a", row.Cells("Id").Value)
                cmd.Parameters.AddWithValue("@b", row.Cells("firstname").Value)
                cmd.Parameters.AddWithValue("@c", "Absent")
                cmd.Parameters.AddWithValue("@d", MetroDateTime1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click
        sendValue()
        loadUsers()
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        loadUsers()
    End Sub
End Class