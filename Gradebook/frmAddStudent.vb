Public Class frmAddStudent
    Private studentsbindingsource As New BindingSource

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles Me.Load
        studentsbindingsource.DataSource = GB.Students

        dgvStudents.DataSource = studentsbindingsource
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim Found As Boolean

        If txtNewStudent.Text <> "" Then
            Found = False
            For Each student In GB.Students
                If student.Name = txtNewStudent.Text Then
                    Found = True
                End If
            Next

            If Not Found Then
                Dim NewStudent As New Student
                NewStudent.Name = txtNewStudent.Text
                GB.Students.Add(NewStudent)

                StudentsBindingSource.ResetBindings(True)

                SaveGradebook()
            Else
                MsgBox("Student already in list - enter new student.", vbOKOnly, "Error adding student")
            End If

            txtNewStudent.Text = ""

        End If
    End Sub
End Class