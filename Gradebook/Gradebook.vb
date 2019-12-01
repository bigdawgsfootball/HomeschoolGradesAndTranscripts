Public Enum AssignTypes
    Assignment = 1
    Quiz = 2
    Project = 3
    Test = 4
    Exam = 5
End Enum

Public Class Category
    Public Property Name As String
End Class

Public Class AssignmentType
    Public Property Name As String
    Public Property Weight As Double
End Class

Public Class AppData
    Public Property Categories As List(Of Category)
    Public Property AssignmentTypes As List(Of AssignmentType)
End Class

Public Class Gradebook

    Public Property Students() As New List(Of Student)
End Class

Public Class Student
    Implements IEquatable(Of Student)

    Public Property Name As String
    Public Property Courses() As New List(Of Course)
    Public Property Extracurriculars() As New List(Of Extracurricular)

    Public Overloads Function Equals(other As Student) As Boolean _
        Implements IEquatable(Of Student).Equals
        If other Is Nothing Then
            Return False
        End If

        Return (Me.Name.Equals(other.Name))
    End Function

End Class

Public Class Course
    Implements IEquatable(Of Course)

    Public Property Title As String
    Public Property Gradelevel As String
    Public Property Publisher As String
    Public Property NumRatingPeriods As Integer
    Public Property Credits As Double
    Public Property Category As String
    Public Property Assignments() As New List(Of Assignment)

    Public Function CalcGrade(Assignments As List(Of Assignment)) As Double
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

        For Each assignment In Me.Assignments
            If assignment.Grade <> "" Then
                Select Case assignment.Type
                    Case AssignTypes.Assignment
                        AGrade += assignment.Grade
                        ACount += 1
                    Case AssignTypes.Quiz
                        QGrade += assignment.Grade
                        QCount += 1
                    Case AssignTypes.Test
                        TGrade += assignment.Grade
                        TCount += 1
                    Case AssignTypes.Project
                        PGrade += assignment.Grade
                        PCount += 1
                    Case AssignTypes.Exam
                        EGrade += assignment.Grade
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
            grade += (AGrade * AssignTypes.Assignment)
            Weights += AssignTypes.Assignment
        End If
        If QCount > 0 Then
            grade += (QGrade * AssignTypes.Quiz)
            Weights += AssignTypes.Quiz
        End If
        If TCount > 0 Then
            grade += (TGrade * AssignTypes.Test)
            Weights += AssignTypes.Test
        End If
        If PCount > 0 Then
            grade += (PGrade * AssignTypes.Project)
            Weights += AssignTypes.Project
        End If
        If ECount > 0 Then
            grade += (EGrade * AssignTypes.Exam)
            Weights += AssignTypes.Exam
        End If

        If (grade > 0) Then
            Return ((grade / Weights).ToString("N2"))
        Else
            Return 0.ToString("N2")
        End If
    End Function

    Public Overloads Function Equals(other As Course) As Boolean _
        Implements IEquatable(Of Course).Equals
        If other Is Nothing Then
            Return False
        End If
        Dim testval = Me.Title & ":" & Me.Publisher
        Dim otherval = other.Title & ":" & other.Publisher

        Return (testval.Equals(otherval))
    End Function

End Class

Public Class Assignment
    Implements IEquatable(Of Assignment)

    Public Property Title As String
    Public Property Type As AssignTypes
    'Public Property Type As AssignmentType
    Public Property Description As String
    Public Property RatingPeriod As String
    Public Property Grade As String

    Public Overloads Function Equals(other As Assignment) As Boolean _
        Implements IEquatable(Of Assignment).Equals
        If other Is Nothing Then
            Return False
        End If

        Return (Me.Title.Equals(other.Title))
    End Function

End Class

Public Class Extracurricular
    Implements IEquatable(Of Extracurricular)

    Public Property Name As String
    Public Property Gradelevel As String
    Public Property Description As String

    Public Overloads Function Equals(other As Extracurricular) As Boolean _
        Implements IEquatable(Of Extracurricular).Equals
        If other Is Nothing Then
            Return False
        End If

        Return (Me.Name.Equals(other.Name))
    End Function

End Class
