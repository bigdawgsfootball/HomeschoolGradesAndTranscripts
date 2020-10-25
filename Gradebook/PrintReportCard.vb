Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Tables
Imports Newtonsoft.Json
Imports System

Public Class PrintReportCard
    Public Property Student As String
    Public Property GradeLevel As String
    Public Property RatingPeriod As String
    Public Property NumPeriods As Integer

    Sub doPrint()
        ' Create a MigraDoc document

        'Dim doc As Document = printBook()
        Dim doc As Document = printReportCard()

        Try
            MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(doc, "c:\temp\MigraDoc.mdddl")

            Dim Renderer As New PdfDocumentRenderer(True)

            Renderer.Document = doc

            Renderer.RenderDocument()

            ' Save the document...
            Dim SaveDlg As New SaveFileDialog
            SaveDlg.Filter = "PDF Files (*.pdf)|*.pdf"
            SaveDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If SaveDlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Renderer.PdfDocument.Save(SaveDlg.FileName)
                Process.Start(SaveDlg.FileName)
            End If
        Catch ex As Exception
            MsgBox("Could not properly format document" + vbCrLf + ex.Message)
        End Try

    End Sub

    Function printReportCard() As Document
        Dim pdf As New Document
        Dim para As New Paragraph

        Cursor.Current = Cursors.WaitCursor

        DefineStyles(pdf)
        DefineContentSection(pdf)

        'Adds a section to the document
        Dim sect As Section = pdf.LastSection
        sect.AddParagraph()

        'Add content to the document
        para = sect.AddParagraph()
        para.Style = "Header2"
        para.Format.ClearAll()
        para.AddText("Student: " & GB.Students(Me.Student).Name.ToString)
        para.AddLineBreak()
        para.AddText("Grade Level: " & Me.GradeLevel)
        para.AddLineBreak()
        para.AddText("Rating Period: " & Me.RatingPeriod)

        Dim RptTable As Table = sect.AddTable()

        RptTable.Style = "Table"
        RptTable.Borders.Color = Colors.Red
        RptTable.Borders.Width = 0.5
        RptTable.Borders.Left.Width = 0.5
        RptTable.Borders.Right.Width = 0.5
        RptTable.Rows.LeftIndent = 0

        Dim sectionWidth As Double = pdf.DefaultPageSetup.PageWidth.Centimeter - pdf.DefaultPageSetup.LeftMargin.Centimeter - pdf.DefaultPageSetup.RightMargin.Centimeter

        'Dim numPeriods As Integer = InputBox("How many reporting periods total for your courses?", "Number of reporting periods", "6")
        Dim numPeriods As Integer = Me.NumPeriods
        Dim colWidth As Double = (sectionWidth - 10) / (numPeriods + 3)

        Dim sem1Col As Integer = Math.Round(numPeriods / 2) + 1
        Dim sem2Col As Integer = numPeriods + 2
        Dim overallCol As Integer = numPeriods + 3

        ' Before you can add a row, you must define the columns
        'Course Name
        Dim Column As Column = RptTable.AddColumn("10cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column.Format.Font.Size = 12
        Column.Format.Font.Bold = True

        'define columns for all periods, 1st semester, 2nd semester and final grades
        Dim numCols As Integer = numPeriods + 3
        For i = 0 To numCols - 1
            Column = RptTable.AddColumn(colWidth.ToString + "cm")
            Column.Format.Alignment = ParagraphAlignment.Center

            If ((i = sem1Col - 1) Or (i = sem2Col - 1) Or (i = overallCol - 1)) Then
                Column.Format.Font.Bold = True
            End If
        Next

        ' Create the header of the table
        Dim Row As Row = RptTable.AddRow()
        Row.HeadingFormat = True
        Row.Format.Alignment = ParagraphAlignment.Center
        Row.Format.Font.Bold = True
        Row.Shading.Color = Colors.LightBlue

        Row.Cells(0).AddParagraph("Course")
        Row.Cells(0).Format.Alignment = ParagraphAlignment.Left

        For i = 1 To numCols
            Select Case i
                Case sem1Col
                    Row.Cells(sem1Col).AddParagraph("Sem 1")
                Case sem2Col
                    Row.Cells(sem2Col).AddParagraph("Sem 2")
                Case overallCol
                    Row.Cells(overallCol).AddParagraph("Final")
                Case Else
                    If (i < sem1Col) Then
                        Row.Cells(i).AddParagraph(i.ToString)
                    Else
                        Row.Cells(i).AddParagraph((i - 1).ToString)
                    End If
            End Select
            Row.Cells(i).Format.Alignment = ParagraphAlignment.Center
        Next

        Dim RepCourses = GB.Students(Me.Student).Courses
        Dim PrintCourses As New List(Of Course)
        Dim AllGrades As New List(Of Decimal)
        Dim Sem1Grades As New List(Of Decimal)
        Dim Sem2Grades As New List(Of Decimal)

        For Each course In RepCourses
            Dim PrintAssignments As New List(Of Assignment)
            PrintAssignments.Clear()
            AllGrades.Clear()
            Sem1Grades.Clear()
            Sem2Grades.Clear()

            For i As Integer = 1 To Me.RatingPeriod

                If course.Gradelevel = Me.GradeLevel Then
                    For Each assignment In course.Assignments
                        If assignment.RatingPeriod = i.ToString() Then
                            PrintAssignments.Add(assignment)
                        End If
                    Next
                End If

            Next

            If PrintAssignments.Count > 0 Then
                Row = RptTable.AddRow()

                Dim PrintCourse As New Course

                PrintCourse = course
                PrintCourse.Assignments = PrintAssignments
                PrintCourses.Add(PrintCourse)

                para = Row.Cells(0).AddParagraph()

                para.Style = "Heading2"
                para.AddSpace(10)
                para.AddText(course.Title)

                For i As Integer = 1 To Me.RatingPeriod
                    If i >= Sem1Col Then
                        para = Row.Cells(i + 1).AddParagraph()
                    Else
                        para = Row.Cells(i).AddParagraph()
                    End If

                    Dim RAssigns As New List(Of Assignment)

                    For Each assign In course.Assignments

                        If assign.RatingPeriod = i Then
                            RAssigns.Add(assign)
                        End If
                    Next

                    If RAssigns.Count > 0 Then
                        para.AddText(CalcGrade(RAssigns).ToString("N0"))
                        AllGrades.Add(CalcGrade(RAssigns))

                        If i < sem1Col Then
                            Sem1Grades.Add(CalcGrade(RAssigns))
                        Else
                            Sem2Grades.Add(CalcGrade(RAssigns))
                        End If
                    Else
                        para.AddText("N/A")
                    End If

                Next

                'Calculate first semester average
                Dim Sem1 As New Decimal
                For Each grade In Sem1Grades
                    Sem1 += grade
                Next
                If Sem1Grades.Count > 0 Then
                    Sem1 = Sem1 / Sem1Grades.Count
                End If

                para = Row.Cells(Sem1Col).AddParagraph
                If Sem1 > 0 Then
                    para.AddText(Sem1.ToString("N0"))
                Else
                    para.AddText(" ")
                End If

                'Calculate second semester average
                Dim Sem2 As New Decimal
                For Each grade In Sem2Grades
                    Sem2 += grade
                Next
                If Sem2Grades.Count > 0 Then
                    Sem2 = Sem2 / Sem2Grades.Count
                End If

                para = Row.Cells(Sem2Col).AddParagraph
                If Sem2 > 0 Then
                    para.AddText(Sem2.ToString("N0"))
                Else
                    para.AddText(" ")
                End If

                'Calculate Final grade
                Dim overall As New Decimal
                For Each grade In AllGrades
                    overall += grade
                Next

                If AllGrades.Count > 0 Then
                    overall = overall / AllGrades.Count
                End If

                para = Row.Cells(OverallCol).AddParagraph
                If overall > 0 Then
                    para.AddText(overall.ToString("N0"))
                Else
                    para.AddText(" ")
                End If

            End If

        Next

        Return pdf

        Cursor.Current = Cursors.Default

    End Function

    Sub DefineStyles(Doc As Document)

        Doc.DefaultPageSetup.MirrorMargins = False

        ' Get the predefined style Normal.
        Dim style As Style = Doc.Styles("Normal")
        Dim rtabunit = Unit.FromInch("8.5")
        Dim RTab As String = (rtabunit.Inch - (Doc.DefaultPageSetup.RightMargin.Inch * 2)).ToString + "in"

        style.Font.Name = "Tahoma"

        style = Doc.Styles("Heading2") 'Course name
        style.Font.Size = 9
        style.Font.Bold = True
        style.ParagraphFormat.PageBreakBefore = False
        style.ParagraphFormat.SpaceBefore = 6
        style.ParagraphFormat.SpaceAfter = 6


    End Sub

    Sub DefineContentSection(pdf As Document)
        Dim Sect As Section = pdf.AddSection()
        Dim Height As String
        Dim Width As String

        Height = "8.5in"
        Width = "11in"

        pdf.DefaultPageSetup.PageHeight = Height
        pdf.DefaultPageSetup.PageWidth = Width

        pdf.Info.Title = "Report Card"

        pdf.DefaultPageSetup.RightMargin = ".5in"
        pdf.DefaultPageSetup.LeftMargin = ".5in"
        pdf.DefaultPageSetup.StartingNumber = 1

        Sect.PageSetup.TopMargin = Unit.FromCentimeter(0.5)
        Sect.PageSetup.BottomMargin = Unit.FromCentimeter(0.5)
        Sect.PageSetup.HeaderDistance = Unit.FromCentimeter(0.25)
        Sect.PageSetup.FooterDistance = Unit.FromCentimeter(0.25)

        ' Create a paragraph with centered page number. See definition of style "Footer".
        Dim para As New Paragraph
        para.AddTab()
        para.AddPageField()

        'Add Paragraph to footer for odd pages.
        Sect.Footers.Primary.Add(para.Clone())
    End Sub

    Friend Function CalcGrade(Assignments As List(Of Assignment)) As Decimal

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

        For Each assignment In Assignments
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
            grade += AGrade * (frmMainMenu.AssignWeights.Item(0).Weight)
            Weights += frmMainMenu.AssignWeights.Item(0).Weight
        End If
        If QCount > 0 Then
            grade += (QGrade * frmMainMenu.AssignWeights.Item(1).Weight)
            Weights += frmMainMenu.AssignWeights.Item(1).Weight

        End If
        If TCount > 0 Then
            grade += (TGrade * frmMainMenu.AssignWeights.Item(3).Weight)
            Weights += frmMainMenu.AssignWeights.Item(3).Weight

        End If
        If PCount > 0 Then
            grade += (PGrade * frmMainMenu.AssignWeights.Item(2).Weight)
            Weights += frmMainMenu.AssignWeights.Item(2).Weight

        End If
        If ECount > 0 Then
            grade += (EGrade * frmMainMenu.AssignWeights.Item(4).Weight)
            Weights += frmMainMenu.AssignWeights.Item(4).Weight

        End If
        If (grade > 0) Then
            Return ((grade / Weights).ToString("N0"))
        Else
            Return 0.ToString("N0")
        End If

    End Function
End Class
