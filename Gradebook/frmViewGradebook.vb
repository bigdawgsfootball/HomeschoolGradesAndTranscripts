Imports System.Reflection

Public Class frmViewGradebook
    Private studentsbindingsource As New BindingSource
    Private GradebookBindingSource As New BindingSource

    Private Sub frmViewGradebook_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub cboCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourses.SelectedIndexChanged
        Dim dt As New DataTable
        Dim CurCourse As New Course

        Try

            CurCourse = cboCourses.SelectedItem

            If CurCourse.Assignments.Count > 0 Then
                dt = ConvertToDataTable(Of Assignment)(CurCourse.Assignments)

                Dim cmb As New DataGridViewComboBoxColumn()
                cmb.HeaderText = "AssignmentType"
                cmb.Name = "Type"
                cmb.DataPropertyName = "Type"

                Dim items As Array
                items = System.Enum.GetValues(GetType(AssignTypes))
                For Each item In items
                    cmb.Items.Add(item)
                Next

                dgvGradebook.DataSource = dt

                Dim TypeIndex As Integer = dgvGradebook.Columns.IndexOf(dgvGradebook.Columns.Item("Type"))
                dgvGradebook.Columns.Remove("Type")
                dgvGradebook.Columns.Insert(TypeIndex, cmb)

                dgvGradebook.DataSource = dt

                cboRatingPeriod.Items.Clear()
                cboRatingPeriod.Text = ""
                cboRatingPeriod.Items.Add("All")
                For Each assign In CurCourse.Assignments
                    If Not cboRatingPeriod.Items.Contains(assign.RatingPeriod) Then
                        cboRatingPeriod.Items.Add(assign.RatingPeriod)
                        cboRatingPeriod.DisplayMember = "RatingPeriod"
                    End If
                Next

            End If

            dgvGradebook.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of T)) As DataTable
        Dim table As New DataTable()
        If Not list.Any Then
            'don't know schema ....
            Return table
        End If
        Dim fields() = list.First.GetType.GetProperties
        For Each field In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next
        For Each item In list
            Dim row As DataRow = table.NewRow()
            For Each field In fields
                Dim p = item.GetType.GetProperty(field.Name)
                row(field.Name) = p.GetValue(item, Nothing)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim CurCourse As New Course
        Dim dt As New DataTable

        CurCourse = cboCourses.SelectedItem
        dt = dgvGradebook.DataSource

        Try
            For Each row In dt.Rows
                Dim CurAssignment As New Assignment
                CurAssignment.Title = row("Title").ToString
                CurAssignment.Description = row("Description").ToString
                CurAssignment.Type = row("Type").ToString
                CurAssignment.Grade = row("Grade").ToString
                CurAssignment.RatingPeriod = row("RatingPeriod").ToString

                If CurCourse.Assignments.Contains(CurAssignment) Then
                    'make sure values are correct
                    Dim index = CurCourse.Assignments.IndexOf(CurAssignment)
                    CurCourse.Assignments(index) = CurAssignment
                Else
                    'add new assignment
                    CurCourse.Assignments.Add(CurAssignment)
                End If
            Next

            Dim StudentIndex As Integer = GB.Students.IndexOf(cboStudents.SelectedItem)
            Dim CourseIndex As Integer = GB.Students(StudentIndex).Courses.IndexOf(cboCourses.SelectedItem)

            GB.Students(StudentIndex).Courses(CourseIndex) = CurCourse

            SaveGradebook()

            MsgBox("Save Successful", vbOKOnly)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        System.Diagnostics.Process.Start("calc.exe")
    End Sub

    Private Sub cboRatingPeriod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRatingPeriod.SelectedIndexChanged
        Dim dt As New DataTable
        Dim CurCourse As New Course
        Dim expression As String

        CurCourse = cboCourses.SelectedItem

        If CurCourse.Assignments.Count > 0 Then
            dt = ConvertToDataTable(Of Assignment)(CurCourse.Assignments)

            If cboRatingPeriod.SelectedIndex > -1 Then
                If cboRatingPeriod.SelectedItem <> "All" Then
                    expression = "RatingPeriod = " & cboRatingPeriod.SelectedItem
                Else
                    expression = ""
                End If
            Else
                    expression = ""
            End If

            Dim cmb As New DataGridViewComboBoxColumn()
            cmb.HeaderText = "AssignmentType"
            cmb.Name = "Type"
            cmb.DataPropertyName = "Type"

            Dim items As Array
            items = System.Enum.GetValues(GetType(AssignTypes))
            For Each item In items
                cmb.Items.Add(item)
            Next

            dgvGradebook.DataSource = dt

            Dim TypeIndex As Integer = dgvGradebook.Columns.IndexOf(dgvGradebook.Columns.Item("Type"))
            dgvGradebook.Columns.Remove("Type")
            dgvGradebook.Columns.Insert(TypeIndex, cmb)

            dt.DefaultView.RowFilter = expression
            dgvGradebook.DataSource = dt

        End If

        dgvGradebook.Refresh()


    End Sub

    Private Sub dgvGradebook_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvGradebook.DataError
        If (e.Context = (DataGridViewDataErrorContexts.Formatting Or DataGridViewDataErrorContexts.Display) Or
            (DataGridViewDataErrorContexts.Formatting Or DataGridViewDataErrorContexts.PreferredSize)) Then
            e.ThrowException = False
        Else
            MsgBox(e.Exception.Message)
        End If
    End Sub
End Class