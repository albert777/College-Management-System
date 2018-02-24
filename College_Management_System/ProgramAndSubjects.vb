Imports System.Data.SqlClient

Public Class ProgramAndSubjects
   ' Dim su As AddRemoveStudentStaff = New AddRemoveStudentStaff
    Function loadUsers()
        Dim dt As New DataTable
        dt = su.loadUsers("Select * FROM tblSubjects")
        SubjectDataGridView.DataSource = dt
        Return dt
    End Function

    Private Sub ProgramAndSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUsers()
    End Sub

    Sub insertSubjects(ByVal subName As String, ByVal subDetail As String)
        Dim con As SqlConnection = su.dbConnect()
        Dim cmd As New SqlCommand("INSERT INTO tblSubjects VALUES(@a,@b)", con)
        cmd.Parameters.AddWithValue("@a", subName)
        cmd.Parameters.AddWithValue("@b", subDetail)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub AddSubjectBtn_Click(sender As Object, e As EventArgs) Handles AddSubjectBtn.Click
        insertSubjects(SubjectNameTextBox.Text, SubjectDetailRichTextBox.Text)
        loadUsers()
    End Sub
End Class