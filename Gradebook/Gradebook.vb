Public Enum AssignTypes
    Assignment = 1
    Quiz = 2
    Project = 3
    Test = 4
    Exam = 5
End Enum

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
    Public Property Assignments() As New List(Of Assignment)

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
