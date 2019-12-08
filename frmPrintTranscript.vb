Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Imports PdfSharp.Pdf.AcroForms

Public Class frmPrintTranscript
    Private studentsbindingsource As New BindingSource

    Private Sub frmPrintTranscript_Load(sender As Object, e As EventArgs) Handles Me.Load
        studentsbindingsource.DataSource = GB.Students

        cboStudents.DataSource = studentsbindingsource
        cboStudents.DisplayMember = "Name"

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim PrintStudent As Student = cboStudents.SelectedItem

#If DEBUG Then
        Dim template As String = "C:\Users\Kurt\Documents\TranscriptTemplate.pdf"
#Else
        Dim template As String = Application.CommonAppDataPath & "\TranscriptTemplate.pdf"
#End If
        Dim transcriptfilepath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim transcriptfilename As String = ""

        Do
            transcriptfilename = InputBox("Input name for transcript file." & vbCrLf & "Must end in .pdf", "File Name?", PrintStudent.Name & " Transcript.pdf")
        Loop Until transcriptfilename.Contains(".pdf")
        Dim transcriptfile As String = transcriptfilepath & "\" & transcriptfilename

        Dim stringSeparators() As String = {"``"}

        Dim Info As String = Environment.GetEnvironmentVariable("GBSCHOOLINFO", EnvironmentVariableTarget.User)
        Dim Pieces() As String = Info.Split(stringSeparators, StringSplitOptions.None)

        System.IO.File.Copy(template, transcriptfile, True)
        LoadFields()

        ' Open the file
        Dim doc As PdfDocument = PdfReader.Open(transcriptfile, PdfDocumentOpenMode.Modify)

        Dim name As String
        Dim currentField As PdfTextField
        Dim caseNamePdfStr As PdfString
        For Each name In fields("StudentName")
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            caseNamePdfStr = New PdfString(PrintStudent.Name)
            'set the value of this field
            currentField.Value = caseNamePdfStr
        Next

        'fill in school info
        currentField = TryCast(doc.AcroForm.Fields(fields("SchoolName")(0)), PdfTextField)
        caseNamePdfStr = New PdfString(Pieces(0))
        currentField.Value = caseNamePdfStr
        currentField = TryCast(doc.AcroForm.Fields(fields("SchoolName")(1)), PdfTextField)
        caseNamePdfStr = New PdfString(Pieces(1))
        currentField.Value = caseNamePdfStr
        currentField = TryCast(doc.AcroForm.Fields(fields("SchoolName")(2)), PdfTextField)
        caseNamePdfStr = New PdfString(Pieces(2))
        currentField.Value = caseNamePdfStr

        Dim Courses9 As New List(Of Course)
        Dim Courses10 As New List(Of Course)
        Dim Courses11 As New List(Of Course)
        Dim Courses12 As New List(Of Course)
        Dim GPA9 As New Double
        Dim GPA10 As New Double
        Dim GPA11 As New Double
        Dim GPA12 As New Double
        Dim OverallGPA As New Double

        For Each course In PrintStudent.Courses
            If course.Assignments.Count > 0 Then
                Select Case course.Gradelevel
                    Case 9
                        Courses9.Add(course)
                    Case 10
                        Courses10.Add(course)
                    Case 11
                        Courses11.Add(course)
                    Case 12
                        Courses12.Add(course)
                    Case Else
                        MsgBox("Ignoring " & course.Title & " since " & course.Gradelevel & " isn't between 9 and 12." & vbCrLf & "Please type the info you need into the transcript manually after it is generated")
                End Select
            End If
        Next

        Dim OverallCredits As Double = 0
        Dim Cats As New Dictionary(Of String, Double)
        Dim Cats9 As New Dictionary(Of String, Double)
        Dim Cats10 As New Dictionary(Of String, Double)
        Dim Cats11 As New Dictionary(Of String, Double)
        Dim Cats12 As New Dictionary(Of String, Double)

        If Courses9.Count > 0 Then
            YearlyDetails("9Course", Courses9, Cats, Cats9, GPA9, "9Cumulative", OverallCredits, doc)
        End If

        If Courses10.Count > 0 Then
            YearlyDetails("10Course", Courses10, Cats, Cats10, GPA10, "10Cumulative", OverallCredits, doc)
        End If

        If Courses11.Count > 0 Then
            YearlyDetails("11Course", Courses11, Cats, Cats11, GPA11, "11Cumulative", OverallCredits, doc)
        End If

        If Courses12.Count > 0 Then
            YearlyDetails("12Course", Courses12, Cats, Cats12, GPA12, "12Cumulative", OverallCredits, doc)
        End If

        'print out overall credit counts
        Dim i As Integer = 1

        For Each cat In Cats
            Dim fname As String = "CAT" & i.ToString
            'Category title
            name = fields(fname)(0)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            caseNamePdfStr = New PdfString(cat.Key)
            currentField.Value = caseNamePdfStr

            '9th grade
            name = fields(fname)(2)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            If Cats9.ContainsKey(cat.Key) Then
                caseNamePdfStr = New PdfString(Cats9.Item(cat.Key))
                currentField.Value = caseNamePdfStr
            End If


            '10th grade
            name = fields(fname)(3)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            If Cats10.ContainsKey(cat.Key) Then
                caseNamePdfStr = New PdfString(Cats10.Item(cat.Key))
                currentField.Value = caseNamePdfStr
            End If

            '11th grade
            name = fields(fname)(4)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            If Cats11.ContainsKey(cat.Key) Then
                caseNamePdfStr = New PdfString(Cats11.Item(cat.Key))
                currentField.Value = caseNamePdfStr
            End If

            '12th grade
            name = fields(fname)(5)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            If Cats12.ContainsKey(cat.Key) Then
                caseNamePdfStr = New PdfString(Cats12.Item(cat.Key))
                currentField.Value = caseNamePdfStr
            End If

            'total column
            name = fields(fname)(6)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            caseNamePdfStr = New PdfString(cat.Value)
            currentField.Value = caseNamePdfStr

            i += 1
        Next

        For Each name In fields("AllCreds")
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            caseNamePdfStr = New PdfString(OverallCredits.ToString("N2"))
            currentField.Value = caseNamePdfStr
        Next

        'Print out GPA for each year and total
        OverallGPA = (GPA9 + GPA10 + GPA11 + GPA12) / 4
        i = 0
        For Each name In fields("GPA")
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            Select Case i
                Case 0
                    caseNamePdfStr = New PdfString(GPA9.ToString("N2"))
                Case 1
                    caseNamePdfStr = New PdfString(GPA10.ToString("N2"))
                Case 2
                    caseNamePdfStr = New PdfString(GPA11.ToString("N2"))
                Case 3
                    caseNamePdfStr = New PdfString(GPA12.ToString("N2"))
                Case 4
                    caseNamePdfStr = New PdfString(OverallGPA.ToString("N2"))
                Case Else
                    caseNamePdfStr = New PdfString("oops")
            End Select
            currentField.Value = caseNamePdfStr
            i += 1
        Next

        ' Save the document...
        doc.Save(transcriptfile)

        Process.Start(transcriptfile)

        Me.Dispose()
    End Sub

    Private Function CalcGPA(average) As Double

        Select Case average
            Case Is >= 90
                Return 4
            Case 80 To 89
                Return 3
            Case 70 To 79
                Return 2
            Case Else
                Return 1
        End Select

    End Function

    Private Sub FillOutGradeFields(FieldName As String, course As Course, sem1 As Double, sem2 As Double, final As Double, credits As Double, doc As PdfDocument)
        Dim name As String
        Dim currentField As PdfTextField
        Dim fieldcnt As Integer = 0
        Dim PdfStr As PdfString

        'populate semester and final grades and credits earned per course
        For Each name In fields(FieldName)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            Select Case fieldcnt
                Case 0
                    PdfStr = New PdfString(course.Title)
                Case 1
                    PdfStr = New PdfString(sem1)
                Case 2
                    PdfStr = New PdfString(sem2)
                Case 3
                    PdfStr = New PdfString(final)
                Case 4
                    PdfStr = New PdfString(credits)
                Case Else
                    PdfStr = New PdfString("oops")
            End Select

            currentField.Value = PdfStr
            fieldcnt += 1
        Next

    End Sub

    Private Sub FillOutCumulativeFields(FieldName As String, Overall As Double, creds As Double, doc As PdfDocument)
        Dim name As String
        Dim fieldcnt As Integer = 0
        Dim currentField As PdfTextField
        Dim PdfStr As PdfString

        For Each name In fields(FieldName)
            currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
            Select Case fieldcnt
                Case 0
                    PdfStr = New PdfString(Overall.ToString("N2"))
                Case 1, 2
                    PdfStr = New PdfString(creds)
                Case Else
                    PdfStr = New PdfString("oops")
            End Select

            currentField.Value = PdfStr
            fieldcnt += 1

        Next

    End Sub

    Private Sub YearlyDetails(BlankName As String, courses As List(Of Course), ByRef AllCats As Dictionary(Of String, Double), ByRef YearCats As Dictionary(Of String, Double), ByRef YearGPA As Double, CumFieldName As String, ByRef OverallCredits As Double, doc As PdfDocument)
        Dim coursecnt As Integer = 0
        Dim overall As Double = 0
        Dim creds As Double = 0
        Dim sem1, sem2, final, credits As Double
        Dim fieldcnt As Integer
        Dim sem1Assigns, sem2Assigns As List(Of Assignment)
        Dim FieldName As String

        For Each course In courses
            sem1 = 0
            sem2 = 0
            final = 0
            credits = 0
            sem1Assigns = New List(Of Assignment)
            sem2Assigns = New List(Of Assignment)

            'calculate sem1, sem2, final grades and #credits earned
            For Each assign In course.Assignments
                If assign.RatingPeriod < 4 Then
                    sem1Assigns.Add(assign)
                Else
                    sem2Assigns.Add(assign)
                End If
            Next

            final = course.CalcGrade(course.Assignments)
            sem1 = course.CalcGrade(sem1Assigns)
            sem2 = course.CalcGrade(sem2Assigns)
            credits = course.Credits
            overall += final
            creds += credits
            'done with calculations

            coursecnt += 1
            fieldcnt = 0
            FieldName = BlankName & coursecnt.ToString

            FillOutGradeFields(FieldName, course, sem1, sem2, final, credits, doc)

            'generate counts of course types for overall numbers
            If AllCats.ContainsKey(course.Category) Then
                AllCats.Item(course.Category) += course.Credits
            Else
                AllCats.Add(course.Category, course.Credits)
            End If

            If YearCats.ContainsKey(course.Category) Then
                YearCats.Item(course.Category) += course.Credits
            Else
                YearCats.Add(course.Category, course.Credits)
            End If

        Next

        'populate overall average and credits earned
        overall = overall / coursecnt

        YearGPA = CalcGPA(overall)

        FillOutCumulativeFields(CumFieldName, overall, creds, doc)

        OverallCredits += creds
    End Sub
End Class