Public Class frmAddAssignment
    Private studentsbindingsource As New BindingSource
    Private assignmentsbindingsource As New BindingSource


    Private Sub frmAddAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentsbindingsource.DataSource = GB.Students

        cboStudents.DataSource = studentsbindingsource
        cboStudents.DisplayMember = "Name"

        cboGradeLevel.Items.Clear()
        cboCourses.Items.Clear()

        cboGradeLevel.Text = ""
        cboCourses.Text = ""

        For Each course In cboStudents.SelectedItem.courses
            If Not cboGradeLevel.Items.Contains(course.gradelevel) Then
                cboGradeLevel.Items.Add(course.gradelevel)
            End If
        Next

        For Each course In cboStudents.SelectedItem.courses
            If course.gradelevel = cboGradeLevel.SelectedText Then
                cboCourses.Items.Add(course)
            End If
        Next

        cboWeight.DataSource = System.Enum.GetValues(GetType(AssignTypes))
        'cboWeight.DataSource = AD.AssignmentTypes
        'cboWeight.DisplayMember = "Name"

        dgvAssignments.ReadOnly = True
        dgvAssignments.AllowUserToAddRows = False

    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        cboGradeLevel.Items.Clear()
        cboCourses.Items.Clear()

        cboGradeLevel.Text = ""
        cboCourses.Text = ""

        If cboStudents.Items.Count > 0 And cboStudents.SelectedIndex > -1 Then

            For Each course In cboStudents.SelectedItem.courses
                If Not cboGradeLevel.Items.Contains(course.gradelevel) Then
                    cboGradeLevel.Items.Add(course.gradelevel)
                End If
            Next
        End If
    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGradeLevel.SelectedIndexChanged
        cboCourses.Items.Clear()
        cboCourses.Text = ""

        For Each course In cboStudents.SelectedItem.courses
            If course.gradelevel = cboGradeLevel.SelectedItem Then
                cboCourses.Items.Add(course)
                cboCourses.DisplayMember = "Title"
            End If
        Next

    End Sub

    Private Sub btnAddAssignment_Click(sender As Object, e As EventArgs) Handles btnAddAssignment.Click
        Dim errmsg As String = ""

        If txtTitle.Text = "" Then
            errmsg = "Assignments need a valid title" & vbCrLf
        End If

        If txtRatingPeriod.Text = "" Then
            errmsg = "Assignments need the Rating Period" & vbCrLf
        End If

        If Not IsNumeric(txtRatingPeriod.Text) Then
            errmsg = "The Rating Period needs to be a number" & vbCrLf
        Else
            If Convert.ToInt32(txtRatingPeriod.Text) > cboCourses.SelectedItem.NumRatingPeriods Then
                errmsg = "The Rating Period needs to be less than " & cboCourses.SelectedItem.NumRatingPeriods & " for this course" & vbCrLf
            End If
        End If

        If cboWeight.SelectedIndex = -1 Then
            errmsg = errmsg & "Please assign a weight to this assignment" & vbCrLf
        End If

        If rtbDescription.Text = "" Then
            errmsg = errmsg & "Please provide a description for this assignment" & vbCrLf
        End If

        If cboCourses.SelectedIndex = -1 Then
            errmsg = errmsg & "An Assignment needs to be associated with a Course" & vbCrLf
        End If

        If errmsg.Length > 0 Then
            MsgBox(errmsg, vbOKOnly, "Validation Errors")
        Else
            Dim NewAssignment As New Assignment

            NewAssignment.Description = rtbDescription.Text
            NewAssignment.Title = txtTitle.Text
            NewAssignment.Type = cboWeight.SelectedItem
            NewAssignment.RatingPeriod = txtRatingPeriod.Text

            If cboCourses.SelectedItem.assignments.contains(NewAssignment) Then
                MsgBox("This assignment has alrteady been added to this course", vbOKOnly, "Validation Errors")
            Else
                cboCourses.SelectedItem.assignments.add(NewAssignment)
                GB.Students(cboStudents.SelectedIndex).Courses(GB.Students(cboStudents.SelectedIndex).Courses.IndexOf(cboCourses.SelectedItem)).Assignments.Add(NewAssignment)

                SaveGradebook()

                studentsbindingsource.ResetBindings(True)
                assignmentsbindingsource.ResetBindings(True)

                txtTitle.Text = ""
                rtbDescription.Text = ""
                txtRatingPeriod.Text = ""
                cboWeight.SelectedIndex = 0

            End If
        End If
    End Sub

    Private Sub cboCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourses.SelectedIndexChanged
        assignmentsbindingsource.DataSource = cboCourses.SelectedItem.assignments
        dgvAssignments.DataSource = assignmentsbindingsource

    End Sub

End Class