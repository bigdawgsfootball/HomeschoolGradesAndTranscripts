Public Class frmCalcGrade
    Private studentsbindingsource As New BindingSource
    Private GradebookBindingSource As New BindingSource

    Private Sub frmCalcGrade_Load(sender As Object, e As EventArgs) Handles Me.Load
        studentsbindingsource.DataSource = GB.Students

        cboStudents.DataSource = studentsbindingsource
        cboStudents.DisplayMember = "Name"

        cboGradeLevel.Items.Clear()

        cboGradeLevel.Text = ""

        For Each course In cboStudents.SelectedItem.courses
            If Not cboGradeLevel.Items.Contains(course.gradelevel) Then
                cboGradeLevel.Items.Add(course.gradelevel)
            End If
        Next

    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGradeLevel.SelectedIndexChanged

        dgvGrades.Columns.Add("Course", "Course")
        dgvGrades.Columns.Add("Grade", "Grade")

        For Each course In cboStudents.SelectedItem.courses
            If course.gradelevel = cboGradeLevel.SelectedItem Then
                'calculate grade
                Dim grade As Double = 0
                Dim AGrade As Double = 0
                Dim QGrade As Double = 0
                Dim PGrade As Double = 0
                Dim TGrade As Double = 0
                Dim EGrade As Double = 0
                Dim ACount As Double = 0
                Dim QCount As Double = 0
                Dim PCount As Double = 0
                Dim TCount As Double = 0
                Dim ECount As Double = 0
                Dim Weights As Integer = 0

                For Each assignment In course.assignments
                    If assignment.grade <> "" Then
                        Select Case assignment.Type
                            Case AssignTypes.Assignment
                                AGrade += assignment.grade
                                ACount += 1
                            Case AssignTypes.Quiz
                                QGrade += assignment.grade
                                QCount += 1
                            Case AssignTypes.Test
                                TGrade += assignment.grade
                                TCount += 1
                            Case AssignTypes.Project
                                PGrade += assignment.grade
                                PCount += 1
                            Case AssignTypes.Exam
                                EGrade += assignment.grade
                                ECount += 1
                        End Select
                    End If
                Next

                AGrade = AGrade / ACount
                QGrade = QGrade / QCount
                TGrade = TGrade / TCount
                PGrade = PGrade / PCount
                EGrade = EGrade / ECount

                If ACount > 0 Then
                    grade += (AGrade * frmMainMenu.AssignWeights.Item(0).Weight)
                    Weights += frmMainMenu.AssignWeights.Item(0).Weight
                End If
                If QCount > 0 Then
                    grade += (QGrade * frmMainMenu.AssignWeights.Item(1).Weight)
                    Weights += frmMainMenu.AssignWeights.Item(1).Weight
                End If
                If TCount > 0 Then
                    grade += (TGrade * frmMainMenu.AssignWeights.Item(3).Weight)
                    Weights += frmMainMenu.AssignWeights.Item(3).Weight
                End If
                If PCount > 0 Then
                    grade += (PGrade * frmMainMenu.AssignWeights.Item(2).Weight)
                    Weights += frmMainMenu.AssignWeights.Item(2).Weight
                End If
                If ECount > 0 Then
                    grade += (EGrade * frmMainMenu.AssignWeights.Item(4).Weight)
                    Weights += frmMainMenu.AssignWeights.Item(4).Weight
                End If

                Dim row As String() = New String() {course.title, (grade / Weights).ToString("N2")}

                dgvGrades.Rows.Add(row)
                End If
        Next


    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        cboGradeLevel.Items.Clear()

        cboGradeLevel.Text = ""

        If cboStudents.Items.Count > 0 And cboStudents.SelectedIndex > -1 Then

            For Each course In cboStudents.SelectedItem.courses
                If Not cboGradeLevel.Items.Contains(course.gradelevel) Then
                    cboGradeLevel.Items.Add(course.gradelevel)
                End If
            Next
        End If

    End Sub
End Class