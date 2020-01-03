Imports System.Reflection

Public Class frmViewGradebook
    Private studentsbindingsource As New BindingSource
    Private GradebookBindingSource As New BindingSource
    Private HasChanges As Boolean = False
    Private PrevCourse As Course
    Private PrevStudent As Student
    Private PrevGradeLevel As String
    Private Skip As Boolean = False


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
        Dim Response As DialogResult = DialogResult.OK

        If Skip Then
            Skip = False
        Else

            If HasChanges Then
                Response = MessageBox.Show("You have unsaved changes. Are you sure you want to leave without saving?" & vbCrLf & vbCrLf & "OK to leave without saving, Cancel to return", "Warning! Uncommited Changes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If

            If Response = DialogResult.OK Then
                HasChanges = False

                PrevStudent = cboStudents.SelectedItem

                dgvGradebook.DataSource = Nothing

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

            Else
                Skip = True
                cboStudents.SelectedItem = PrevStudent
            End If
        End If

    End Sub

    Private Sub cboGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGradeLevel.SelectedIndexChanged
        Dim Response As DialogResult = DialogResult.OK

        If Skip Then
            Skip = False
        Else

            If HasChanges Then
                Response = MessageBox.Show("You have unsaved changes. Are you sure you want to leave without saving?" & vbCrLf & vbCrLf & "OK to leave without saving, Cancel to return", "Warning! Uncommited Changes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If

            If Response = DialogResult.OK Then
                HasChanges = False

                PrevGradeLevel = cboGradeLevel.SelectedItem

                dgvGradebook.DataSource = Nothing

                cboCourses.Items.Clear()
                cboCourses.Text = ""

                For Each course In cboStudents.SelectedItem.courses
                    If course.gradelevel = cboGradeLevel.SelectedItem Then
                        cboCourses.Items.Add(course)
                        cboCourses.DisplayMember = "Title"
                    End If
                Next
            Else
                Skip = True
                cboGradeLevel.SelectedItem = PrevGradeLevel
            End If
        End If

    End Sub

    Private Sub cboCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourses.SelectedIndexChanged
        Dim dt As New DataTable
        Dim CurCourse As New Course
        Dim Response As DialogResult = DialogResult.OK

        If Skip Then
            Skip = False
        Else

            If HasChanges Then
                Response = MessageBox.Show("You have unsaved changes. Are you sure you want to leave without saving?" & vbCrLf & vbCrLf & "OK to leave without saving, Cancel to return", "Warning! Uncommited Changes!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            End If

            If Response = DialogResult.OK Then
                HasChanges = False

                Try

                    CurCourse = cboCourses.SelectedItem
                    PrevCourse = CurCourse

                    If CurCourse.Assignments.Count > 0 Then
                        dt = ConvertToDataTable(Of Assignment)(CurCourse.Assignments)

                        'dt.Columns("ID").AutoIncrement = True
                        'dt.Columns("ID").AutoIncrementStep = 1
                        dt.Columns("ID").ReadOnly = True
                        'dt.Columns("ID").Unique = True

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
                    Else
                        dt.Columns.Add("ID")
                        dt.Columns.Add("Title")
                        dt.Columns.Add("Type")
                        dt.Columns.Add("Description")
                        dt.Columns.Add("RatingPeriod")
                        dt.Columns.Add("Grade")

                        'dt.Columns("ID").AutoIncrement = True
                        'dt.Columns("ID").AutoIncrementStep = 1
                        dt.Columns("ID").ReadOnly = True
                        'dt.Columns("ID").Unique = True

                        Dim cmb As New DataGridViewComboBoxColumn()
                        cmb.HeaderText = "AssignmentType"
                        cmb.Name = "Type"
                        cmb.DisplayMember = "Key"
                        cmb.DataPropertyName = "Type"
                        cmb.ValueType = GetType(AssignTypes)

                        Dim DictAssign As New Dictionary(Of String, Integer)

                        For Each eValue In System.Enum.GetValues(GetType(AssignTypes))
                            DictAssign.Add(System.Enum.GetName(GetType(AssignTypes), eValue), eValue)
                        Next

                        cmb.DisplayMember = "Key"
                        cmb.ValueMember = "Value"
                        cmb.DataSource = New BindingSource(DictAssign, Nothing)

                        dgvGradebook.DataSource = dt

                        Dim TypeIndex As Integer = dgvGradebook.Columns.IndexOf(dgvGradebook.Columns.Item("Type"))
                        dgvGradebook.Columns.Remove("Type")
                        dgvGradebook.Columns.Insert(TypeIndex, cmb)

                        dt = dgvGradebook.DataSource
                        dgvGradebook.DataSource = dt

                        cboRatingPeriod.Items.Clear()
                        cboRatingPeriod.Text = ""
                        cboRatingPeriod.Items.Add("All")
                    End If

                    dgvGradebook.Columns("ID").Visible = False

                    dgvGradebook.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Skip = True
                cboCourses.SelectedItem = PrevCourse
            End If
        End If
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
        Dim maxValue As Integer = 0

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
                If Not (row("ID").ToString = "") Then
                    CurAssignment.ID = row("ID")
                Else
                    Dim curValue As Integer = 0
                    Dim allAssigns As New DataTable

                    For Each thisCourse In GB.Students(cboStudents.SelectedIndex).Courses
                        allAssigns = ConvertToDataTable(Of Assignment)(thisCourse.Assignments)
                        If allAssigns.Rows.Count > 0 Then
                            curValue = allAssigns.Compute("MAX(ID)", "")
                            If maxValue < curValue Then maxValue = curValue
                        End If
                    Next

                    maxValue += 1
                    CurAssignment.ID = maxValue
                End If

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

            HasChanges = False

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

    Private Sub dgvGradebook_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvGradebook.CurrentCellDirtyStateChanged
        HasChanges = True
    End Sub

    Private Sub dgvGradebook_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvGradebook.UserDeletingRow

        For Each item In sender.selectedrows
            Dim DelAssign As New Assignment
            Dim thisCourse As Integer = 0
            Dim thisAssign As Integer = 0

            thisCourse = GB.Students(cboStudents.SelectedIndex).Courses.IndexOf(cboCourses.SelectedItem)
            thisAssign = item.cells(0).value
            DelAssign = (From Assignments In GB.Students(cboStudents.SelectedIndex).Courses(thisCourse).Assignments
                         Where Assignments.ID.Equals(thisAssign)
                         Select Assignments).FirstOrDefault
            GB.Students(cboStudents.SelectedIndex).Courses(thisCourse).Assignments.Remove(DelAssign)
        Next

        HasChanges = True

    End Sub
End Class