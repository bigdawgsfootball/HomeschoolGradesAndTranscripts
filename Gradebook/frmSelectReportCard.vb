Public Class frmSelectReportCard
    Private studentsbindingsource As New BindingSource

    Private Sub frmSelectReportCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cboReportPeriod.Items.Clear()

        cboGrade.Text = ""
        cboReportPeriod.Text = ""

        If cboStudents.Items.Count > 0 And cboStudents.SelectedIndex > -1 Then

            For Each course In cboStudents.SelectedItem.courses
                If Not cboGrade.Items.Contains(course.gradelevel) Then
                    cboGrade.Items.Add(course.gradelevel)
                End If
            Next
        End If

    End Sub

    Private Sub cboGrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGrade.SelectedIndexChanged
        cboReportPeriod.Items.Clear()
        cboReportPeriod.Text = ""

        Dim courseList As New List(Of Course)
        For Each courses In cboStudents.SelectedItem.courses
            If courses.GradeLevel.Equals(cboGrade.SelectedItem.ToString) Then
                courseList.Add(courses)
            End If
        Next

        For Each courses In courseList
            For Each assignment In courses.Assignments
                If Not cboReportPeriod.Items.Contains(assignment.RatingPeriod) Then
                    cboReportPeriod.Items.Add(assignment.RatingPeriod)
                    cboReportPeriod.DisplayMember = "RatingPeriod"
                End If
            Next
        Next

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Report As New PrintReportCard

        If cboStudents.SelectedIndex > -1 And cboGrade.SelectedIndex > -1 And cboReportPeriod.SelectedIndex > -1 And (IsNumeric(txtNumPeriods.Text)) Then
            Report.Student = cboStudents.SelectedIndex

            Report.GradeLevel = cboGrade.Text

            Report.RatingPeriod = cboReportPeriod.Text

            Report.NumPeriods = txtNumPeriods.Text

            Report.doPrint()

            Me.Close()

        Else
            MsgBox("You need to select a Student, Grade Level, and a Rating Period, and use a valid number for Number of Rating Periods", vbOK)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class