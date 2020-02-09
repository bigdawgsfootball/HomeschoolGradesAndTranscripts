Public Class frmPrintAssigns
    Private studentsbindingsource As New BindingSource

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Report As New PrintAssignmentList
        Dim AssignList As New List(Of Course)

        If cboStudents.SelectedIndex > -1 And cboGrade.SelectedIndex > -1 And lstCourses.SelectedIndex > -1 Then
            Report.Student = cboStudents.SelectedIndex

            Report.GradeLevel = cboGrade.Text

            For Each item In lstCourses.SelectedItems
                AssignList.Add(item)
            Next
            Report.Courses = AssignList

            Report.doPrint()

            Me.Close()

        Else
            MsgBox("You need to select a Student, Grade Level, and a Rating Period, and use a valid number for Number of Rating Periods", vbOK)
        End If

    End Sub

    Private Sub frmPrintAssigns_Load(sender As Object, e As EventArgs) Handles Me.Load
        studentsbindingsource.DataSource = GB.Students

        cboStudents.DataSource = studentsbindingsource
        cboStudents.DisplayMember = "Name"

        cboGrade.Items.Clear()

        cboGrade.Text = ""

        For Each course In cboStudents.SelectedItem.courses
            If Not cboGrade.Items.Contains(course.gradelevel) Then
                cboGrade.Items.Add(course.gradelevel)
            End If
        Next

    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        cboGrade.Items.Clear()
        lstCourses.Items.Clear()

        cboGrade.Text = ""
        lstCourses.Text = ""

        If cboStudents.Items.Count > 0 And cboStudents.SelectedIndex > -1 Then

            For Each course In cboStudents.SelectedItem.courses
                If Not cboGrade.Items.Contains(course.gradelevel) Then
                    cboGrade.Items.Add(course.gradelevel)
                End If
            Next
        End If

    End Sub

    Private Sub cboGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrade.SelectedIndexChanged
        lstCourses.Items.Clear()
        lstCourses.Text = ""

        Dim courseList As New List(Of Course)
        For Each courses In cboStudents.SelectedItem.courses
            If courses.GradeLevel.Equals(cboGrade.SelectedItem.ToString) Then
                courseList.Add(courses)
            End If
        Next

        For Each courses In courseList
            If Not lstCourses.Items.Contains(courses.Title) Then
                lstCourses.Items.Add(courses)
                lstCourses.DisplayMember = "Title"
            End If
        Next

    End Sub
End Class