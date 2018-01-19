Public Class frmAddCourse
    Private studentsbindingsource As New BindingSource
    Private coursesbindingsource As New BindingSource

    Private Sub frmAddCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentsbindingsource.DataSource = GB.Students

        cboStudents.DataSource = studentsbindingsource
        cboStudents.DisplayMember = "Name"

        coursesbindingsource.DataSource = cboStudents.SelectedItem.courses
        dgvCourses.DataSource = coursesbindingsource

    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim ErrorMsg As String = ""

        If cboStudents.SelectedIndex < 0 Then
            ErrorMsg = "Please select a Student that is taking this course" & vbCrLf
        End If

        If txtGradeLevel.Text = "" Then
            ErrorMsg = ErrorMsg & "Please include a Grade Level" & vbCrLf
        End If

        If txtNumRatings.Text = "" Then
            ErrorMsg = ErrorMsg & "Please include the number of rating periods for this course" & vbCrLf
        End If

        If Not IsNumeric(txtNumRatings.Text) Then
            ErrorMsg = ErrorMsg & "The number of rating periods needs to be a number" & vbCrLf
        End If

        If txtPublisher.Text = "" Then
            ErrorMsg = ErrorMsg & "Please include a Publisher for this Course" & vbCrLf
        End If

        If txtCredits.Text = "" Then
            ErrorMsg = ErrorMsg & "Please include the number of credits earned for this course" & vbCrLf
        End If

        If Not IsNumeric(txtCredits.Text) Then
            ErrorMsg = ErrorMsg & "The number of credits earned needs to be a number" & vbCrLf
        End If

        If txtTitle.Text = "" Then
            ErrorMsg = ErrorMsg & "Please include a Title for this Course" & vbCrLf
        End If

        If ErrorMsg = "" Then
            Dim NewCourse As New Course

            NewCourse.Gradelevel = txtGradeLevel.Text
            NewCourse.Publisher = txtPublisher.Text
            NewCourse.Title = txtTitle.Text
            NewCourse.NumRatingPeriods = txtNumRatings.Text
            NewCourse.Credits = txtCredits.Text

            If Not cboStudents.SelectedItem.courses.contains(NewCourse) Then
                cboStudents.SelectedItem.Courses.Add(NewCourse)
                SaveGradebook()

                coursesbindingsource.ResetBindings(True)
            Else
                MsgBox("That course has already been added", vbOKOnly, "Course Exists")
            End If

        Else
                MsgBox(ErrorMsg, vbOKOnly, "Validation Errors - Please correct")
        End If
    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        coursesbindingsource.DataSource = cboStudents.SelectedItem.courses

    End Sub

End Class