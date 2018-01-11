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

        For Each course In PrintStudent.Courses
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
                    MsgBox("Too many years")
            End Select
        Next

        Dim FieldName As String

        If Courses9.Count > 0 Then
            Dim coursecnt As Integer = 0
            Dim overall As Double = 0
            Dim creds As Double = 0
            Dim BlankName As String = "9Course"
            Dim sem1, sem2, final, credits As Double
            Dim fieldcnt As Integer
            Dim sem1Assigns, sem2Assigns As List(Of Assignment)

            For Each course In Courses9
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
                'final = (sem1 + sem2) / 2
                credits = 1
                overall += final
                creds += credits
                'done with calculations

                coursecnt += 1
                fieldcnt = 0
                FieldName = BlankName & coursecnt.ToString

                'populate each semester, final and credits earned per course
                For Each name In fields(FieldName)
                    currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                    Select Case fieldcnt
                        Case 0
                            caseNamePdfStr = New PdfString(course.Title)
                        Case 1
                            caseNamePdfStr = New PdfString(sem1)
                        Case 2
                            caseNamePdfStr = New PdfString(sem2)
                        Case 3
                            caseNamePdfStr = New PdfString(final)
                        Case 4
                            caseNamePdfStr = New PdfString(credits)
                        Case Else
                            caseNamePdfStr = New PdfString(95)
                    End Select

                    currentField.Value = caseNamePdfStr
                    fieldcnt += 1
                Next
            Next

            'populate overall average and credits earned
            overall = overall / coursecnt
            fieldcnt = 0
            For Each name In fields("9Cumulative")
                currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                Select Case fieldcnt
                    Case 0
                        caseNamePdfStr = New PdfString(overall.ToString("N2"))
                    Case 1
                        caseNamePdfStr = New PdfString(creds)
                    Case Else
                        caseNamePdfStr = New PdfString("oops")
                End Select

                currentField.Value = caseNamePdfStr
                fieldcnt += 1

            Next

        End If

        If Courses10.Count > 0 Then
            Dim coursecnt As Integer = 0
            Dim overall As Double = 0
            Dim creds As Double = 0
            Dim BlankName As String = "10Course"
            Dim sem1, sem2, final, credits As Double
            Dim fieldcnt As Integer
            Dim sem1Assigns, sem2Assigns As List(Of Assignment)

            For Each course In Courses10
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
                'final = (sem1 + sem2) / 2
                credits = 1
                overall += final
                creds += credits
                'done with calculations

                coursecnt += 1
                fieldcnt = 0
                FieldName = BlankName & coursecnt.ToString

                'populate each semester, final and credits earned per course
                For Each name In fields(FieldName)
                    currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                    Select Case fieldcnt
                        Case 0
                            caseNamePdfStr = New PdfString(course.Title)
                        Case 1
                            caseNamePdfStr = New PdfString(sem1)
                        Case 2
                            caseNamePdfStr = New PdfString(sem2)
                        Case 3
                            caseNamePdfStr = New PdfString(final)
                        Case 4
                            caseNamePdfStr = New PdfString(credits)
                        Case Else
                            caseNamePdfStr = New PdfString(95)
                    End Select

                    currentField.Value = caseNamePdfStr
                    fieldcnt += 1
                Next
            Next

            'populate overall average and credits earned
            overall = overall / coursecnt
            fieldcnt = 0
            For Each name In fields("10Cumulative")
                currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                Select Case fieldcnt
                    Case 0
                        caseNamePdfStr = New PdfString(overall.ToString("N2"))
                    Case 1
                        caseNamePdfStr = New PdfString(creds)
                    Case Else
                        caseNamePdfStr = New PdfString("oops")
                End Select

                currentField.Value = caseNamePdfStr
                fieldcnt += 1

            Next

        End If

        If Courses11.Count > 0 Then
            Dim coursecnt As Integer = 0
            Dim overall As Double = 0
            Dim creds As Double = 0
            Dim BlankName As String = "11Course"
            Dim sem1, sem2, final, credits As Double
            Dim fieldcnt As Integer
            Dim sem1Assigns, sem2Assigns As List(Of Assignment)

            For Each course In Courses11
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
                'final = (sem1 + sem2) / 2
                credits = 1
                overall += final
                creds += credits
                'done with calculations

                coursecnt += 1
                fieldcnt = 0
                FieldName = BlankName & coursecnt.ToString

                'populate each semester, final and credits earned per course
                For Each name In fields(FieldName)
                    currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                    Select Case fieldcnt
                        Case 0
                            caseNamePdfStr = New PdfString(course.Title)
                        Case 1
                            caseNamePdfStr = New PdfString(sem1)
                        Case 2
                            caseNamePdfStr = New PdfString(sem2)
                        Case 3
                            caseNamePdfStr = New PdfString(final)
                        Case 4
                            caseNamePdfStr = New PdfString(credits)
                        Case Else
                            caseNamePdfStr = New PdfString("oops")
                    End Select

                    currentField.Value = caseNamePdfStr
                    fieldcnt += 1
                Next
            Next

            'populate overall average and credits earned
            overall = overall / coursecnt
            fieldcnt = 0
            For Each name In fields("11Cumulative")
                currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                Select Case fieldcnt
                    Case 0
                        caseNamePdfStr = New PdfString(overall.ToString("N2"))
                    Case 1
                        caseNamePdfStr = New PdfString(creds)
                    Case Else
                        caseNamePdfStr = New PdfString("oops")
                End Select

                currentField.Value = caseNamePdfStr
                fieldcnt += 1

            Next

        End If

        If Courses12.Count > 0 Then
            Dim coursecnt As Integer = 0
            Dim overall As Double = 0
            Dim creds As Double = 0
            Dim BlankName As String = "12Course"
            Dim sem1, sem2, final, credits As Double
            Dim fieldcnt As Integer
            Dim sem1Assigns, sem2Assigns As List(Of Assignment)

            For Each course In Courses12
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
                'final = (sem1 + sem2) / 2
                credits = 1
                overall += final
                creds += credits
                'done with calculations

                coursecnt += 1
                fieldcnt = 0
                FieldName = BlankName & coursecnt.ToString

                'populate each semester, final and credits earned per course
                For Each name In fields(FieldName)
                    currentField = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                    Select Case fieldcnt
                        Case 0
                            caseNamePdfStr = New PdfString(course.Title)
                        Case 1
                            caseNamePdfStr = New PdfString(sem1)
                        Case 2
                            caseNamePdfStr = New PdfString(sem2)
                        Case 3
                            caseNamePdfStr = New PdfString(final)
                        Case 4
                            caseNamePdfStr = New PdfString(credits)
                        Case Else
                            caseNamePdfStr = New PdfString("oops")
                    End Select

                    currentField.Value = caseNamePdfStr
                    fieldcnt += 1
                Next
            Next

            'populate overall average and credits earned
            overall = overall / coursecnt
            fieldcnt = 0
            For Each name In fields("12Cumulative")
                 currentField  = TryCast(doc.AcroForm.Fields(name), PdfTextField)
                Select Case fieldcnt
                    Case 0
                        caseNamePdfStr = New PdfString(overall.ToString("N2"))
                    Case 1
                        caseNamePdfStr = New PdfString(creds)
                    Case Else
                        caseNamePdfStr = New PdfString("oops")
                End Select

                currentField.Value = caseNamePdfStr
                fieldcnt += 1

            Next

        End If

        ' Save the document...
        doc.Save(transcriptfile)

        Process.Start(transcriptfile)

        Me.Dispose()
    End Sub
End Class