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

        For Each courses In cboStudents.SelectedItem.courses
            For Each assignment In courses.assignments
                If Not cboReportPeriod.Items.Contains(assignment.RatingPeriod) Then
                    cboReportPeriod.Items.Add(assignment.ratingperiod)
                    cboReportPeriod.DisplayMember = "RatingPeriod"
                End If
            Next
        Next

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Report As New PrintReportCard

        If cboStudents.SelectedIndex > -1 And cboGrade.SelectedIndex > -1 And cboReportPeriod.SelectedIndex > -1 Then
            Report.Student = cboStudents.SelectedIndex

            Report.GradeLevel = cboGrade.Text

            Report.RatingPeriod = cboReportPeriod.Text

            Report.doPrint()

            Me.Close()

        Else
            MsgBox("You need to select a Student, Grade Level, and a Rating Period", vbOK)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class