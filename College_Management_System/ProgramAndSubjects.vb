Imports System.Data.SqlClient

Public Class ProgramAndSubjects
    Dim su As New AddRemoveStudentStaff
    Dim con As SqlConnection = su.dbConnect()
    Sub loadPrograms()
        Dim programData As DataTable = su.loadUsers("SELECT * FROM tblPrograms")
        ProgramDataGridView.DataSource = programData
        ProgramComboBox.DataSource = programData
        ProgramComboBox.DisplayMember = "program_name"
        ProgramComboBox.ValueMember = "Id"
    End Sub
    Function checkIfProgramExist() As Boolean
        Dim cmd As New SqlCommand("SELECT * FROM tblPrograms WHERE program_name=@a", con)
        cmd.Parameters.AddWithValue("@a", ProgramNameTextBox.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If (dt.Rows.Count > 0) Then
            Return False
        End If
        Return True
    End Function
    Sub AddPrograms()
        If (checkIfProgramExist() = True) Then
            Dim cmd As New SqlCommand("INSERT INTO tblPrograms VALUES(@a,@b)", con)
            Dim cmd2 As New SqlCommand("CREATE TABLE tbl" & ProgramNameTextBox.Text & "(subject_id NVARCHAR(50) NULL,subject_name NVARCHAR(50) NULL, subject_description NVARCHAR(50) NULL)", con)
            cmd.Parameters.AddWithValue("@a", ProgramNameTextBox.Text)
            cmd.Parameters.AddWithValue("@b", ProgramDetailRichTextBox.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            con.Close()
        Else
            MsgBox("Given course already exist")
        End If
    End Sub

    Private Sub AddProgramBtn_Click(sender As Object, e As EventArgs) Handles AddProgramBtn.Click
        AddPrograms()
        loadPrograms()
    End Sub
    Private Sub ProgramAndSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadPrograms()
    End Sub
    Sub loadSubjects()
        Dim a As String = "SELECT * FROM tbl" & ProgramComboBox.Text
        Dim cmd As New SqlCommand(a, con)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        SubjectDataGridView.DataSource = dt
    End Sub
    Sub addSubjects()
        Dim cmd As New SqlCommand("INSERT INTO tbl" & ProgramComboBox.Text & " VALUES(@a,@b,@c)", con)
        cmd.Parameters.AddWithValue("@a", SubjectIdTextBox.Text)
        cmd.Parameters.AddWithValue("@b", SubjectNameTextBox.Text)
        cmd.Parameters.AddWithValue("@c", SubjectDetailRichTextBox.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        loadSubjects()
    End Sub

    Private Sub addsubjectbtn_click(sender As Object, e As EventArgs) Handles AddSubjectBtn.Click
        addsubjects()
        loadSubjects()
    End Sub

    Private Sub ProgramComboBox_Click(sender As Object, e As EventArgs) Handles ProgramComboBox.Click
        loadSubjects()
    End Sub

    'Private Sub ProgramComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgramComboBox.SelectedIndexChanged
    '    loadSubjects()
    'End Sub
End Class