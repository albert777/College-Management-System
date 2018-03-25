Imports System.Data.SqlClient
Public Class Attendance
    Dim Id As Integer
    Dim su As AddRemoveStudentStaff = New AddRemoveStudentStaff

    Sub searchID()
        Dim sql As String = "SELECT * FROM attendanceTbl WHERE Id LIKE @a"
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@a", AttSearchTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dts As New DataTable()
        da.Fill(dts)
        AttendanceDataGridView.DataSource = dts
        If (AttSearchTextBox.Text = "") Then
            loadUsers()
        End If
    End Sub

    Sub loadPrograms()
        Dim programData As DataTable = su.loadUsers("SELECT * FROM tblPrograms")
        AttenProgramComboBox.DataSource = programData
        AttenProgramComboBox.DisplayMember = "program_name"
        AttenProgramComboBox.ValueMember = "Id"
    End Sub

    Sub loadall()
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand("SELECT * FROM attendanceTbl where Id = @a AND PA = @b", con)
        cmd.Parameters.AddWithValue("@a", Id)
        cmd.Parameters.AddWithValue("@b", "Present")
        Dim da As New SqlDataAdapter(cmd)
        Dim dts As New DataTable()
        da.Fill(dts)
        If (dts.Rows.Count > 0) Then
            PresentDaysLabel.Text = dts.Rows.Count & " days present"
        End If
        Dim cmd2 As New SqlCommand("SELECT * FROM attendanceTbl where Id = @a AND PA = @b", con)
        cmd2.Parameters.AddWithValue("@a", Id)
        cmd2.Parameters.AddWithValue("@b", "Absent")
        Dim da2 As New SqlDataAdapter(cmd2)
        Dim dts2 As New DataTable()
        da2.Fill(dts2)
        If (dts2.Rows.Count > 0) Then
            AbsentDaysLabel.Text = dts2.Rows.Count & " days absent"
        End If
    End Sub
    Sub loadUsers()
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand("SELECT * FROM attendanceTbl WHERE Date = @a AND program = @b", con)
        cmd.Parameters.AddWithValue("@a", MetroDateTime1.Text)
        cmd.Parameters.AddWithValue("@b", AttenProgramComboBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dts As New DataTable()
        da.Fill(dts)
        If (dts.Rows.Count > 0) Then
            AttendanceDataGridView.DataSource = dts
            updated()
        Else
            Dim cmd2 As New SqlCommand("Select Id,fname FROM stuTbl WHERE state = 1 AND course = @a", con)
            cmd2.Parameters.AddWithValue("@a", AttenProgramComboBox.Text)
            Dim da2 As New SqlDataAdapter(cmd2)
            Dim dts2 As New DataTable()
            da2.Fill(dts2)
            AttendanceDataGridView.DataSource = dts2
        End If


    End Sub
    Sub updated()
        For Each row As DataGridViewRow In AttendanceDataGridView.Rows
            If (row.Cells("PA").Value = "Present") Then
                row.Cells("PACheckBoxColumn").Value = True
            Else
                row.Cells("PACheckBoxColumn").Value = False
            End If
        Next
    End Sub

    Sub checkedAttendance()
        For i = 0 To AttendanceDataGridView.RowCount - 1
            AttendanceDataGridView.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPrograms()
        loadUsers()

    End Sub
    Sub sendValue()

        For Each row As DataGridViewRow In AttendanceDataGridView.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("PACheckBoxColumn").Value)
            If isSelected Then
                Dim con As SqlConnection = su.dbConnect()
                Dim cmd As New SqlCommand("INSERT INTO attendanceTbl VALUES(@a,@b,@c,@d,@e)", con)
                cmd.Parameters.AddWithValue("@a", row.Cells("Id").Value)
                cmd.Parameters.AddWithValue("@b", row.Cells("fname").Value)
                cmd.Parameters.AddWithValue("@c", "Present")
                cmd.Parameters.AddWithValue("@d", MetroDateTime1.Text)
                cmd.Parameters.AddWithValue("@e", AttenProgramComboBox.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                Dim con As SqlConnection = su.dbConnect()
                Dim cmd As New SqlCommand("INSERT INTO attendanceTbl VALUES(@a,@b,@c,@d,@e)", con)
                cmd.Parameters.AddWithValue("@a", row.Cells("Id").Value)
                cmd.Parameters.AddWithValue("@b", row.Cells("fname").Value)
                cmd.Parameters.AddWithValue("@c", "Absent")
                cmd.Parameters.AddWithValue("@d", MetroDateTime1.Text)
                cmd.Parameters.AddWithValue("@e", AttenProgramComboBox.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Next

    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        loadUsers()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        updated()
    End Sub

    Sub updates()
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand("UPDATE attendanceTbl SET PA = @a WHERE Id = @b AND Date = @c", con)
        Dim pa As String
        If (AttendanceDataGridView.CurrentRow.Cells(0).Value = True) Then
            pa = "Present"
        Else
            pa = "Absent"
        End If
        cmd.Parameters.AddWithValue("@a", pa)
        cmd.Parameters.AddWithValue("@b", Id)
        cmd.Parameters.AddWithValue("@c", MetroDateTime1.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        loadUsers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        updates()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        sendValue()
        loadUsers()
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        checkedAttendance()
    End Sub

    Private Sub AttendanceDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AttendanceDataGridView.CellClick
        Id = Convert.ToInt32(AttendanceDataGridView.CurrentRow.Cells(1).Value.ToString())
        loadall()
    End Sub

    Private Sub AttenProgramComboBox_MouseClick(sender As Object, e As MouseEventArgs) Handles AttenProgramComboBox.MouseClick
        loadPrograms()
    End Sub

    Private Sub AttenProgramComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AttenProgramComboBox.SelectedIndexChanged
        loadUsers()
    End Sub

    Private Sub AttSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles AttSearchTextBox.TextChanged
        searchID()
    End Sub
End Class