Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Tables
Imports Newtonsoft.Json
Imports System

Public Class PrintReportCard
    Public Property Student As String
    Public Property GradeLevel As String
    Public Property RatingPeriod As String

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
        Dim Sem1Col As Integer = 4
        Dim Sem2Col As Integer = 8
        Dim OverallCol As Integer = 9

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
        RptTable.Borders.Width = 0.25
        RptTable.Borders.Left.Width = 0.25
        RptTable.Borders.Right.Width = 0.25
        RptTable.Rows.LeftIndent = 0
        ' Before you can add a row, you must define the columns
        Dim Column As Column = RptTable.AddColumn("6cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column.Format.Font.Bold = True
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column.Format.Font.Bold = True
        Column = RptTable.AddColumn("1.5cm")
        Column.Format.Alignment = ParagraphAlignment.Center
        Column.Format.Font.Bold = True

        ' Create the header of the table
        Dim Row As Row = RptTable.AddRow()
        Row.HeadingFormat = True
        Row.Format.Alignment = ParagraphAlignment.Center
        Row.Format.Font.Bold = True
        Row.Shading.Color = Colors.LightBlue
        Row.Cells(0).AddParagraph("Course")
        Row.Cells(0).Format.Alignment = ParagraphAlignment.Left
        Row.Cells(1).AddParagraph("1")
        Row.Cells(1).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(2).AddParagraph("2")
        Row.Cells(2).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(3).AddParagraph("3")
        Row.Cells(3).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(Sem1Col).AddParagraph("Sem 1")
        Row.Cells(Sem1Col).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(5).AddParagraph("4")
        Row.Cells(5).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(6).AddParagraph("5")
        Row.Cells(6).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(7).AddParagraph("6")
        Row.Cells(7).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(Sem2Col).AddParagraph("Sem 2")
        Row.Cells(Sem2Col).Format.Alignment = ParagraphAlignment.Center
        Row.Cells(OverallCol).AddParagraph("Final")
        Row.Cells(OverallCol).Format.Alignment = ParagraphAlignment.Center

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

                para.Style = "Heading3"
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
                        para.AddText(CalcGrade(RAssigns).ToString)
                        AllGrades.Add(CalcGrade(RAssigns))

                        If i < 4 Then
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
                    para.AddText(Sem1.ToString("N2"))
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
                    para.AddText(Sem2.ToString("N2"))
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
                    para.AddText(overall.ToString("N2"))
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

        ' Heading1 to Heading9 are predefined styles with an outline level. An outline level
        ' other than OutlineLevel.BodyText automatically creates the outline (Or bookmarks)
        ' in PDF.

        style = Doc.Styles("Heading1") 'Field
        style.Font.Size = 10
        style.Font.Bold = True
        style.Font.Color = Colors.Black
        style.ParagraphFormat.PageBreakBefore = True
        style.ParagraphFormat.SpaceAfter = 6

        style = Doc.Styles("Heading2") 'Church
        style.Font.Size = 9
        style.Font.Bold = True
        style.ParagraphFormat.PageBreakBefore = False
        style.ParagraphFormat.SpaceBefore = 6
        style.ParagraphFormat.SpaceAfter = 6

        style = Doc.Styles("Heading3") 'entry
        style.Font.Size = 8
        style.Font.Bold = False
        style.ParagraphFormat.SpaceBefore = 3
        style.ParagraphFormat.SpaceAfter = 3
        style.ParagraphFormat.LeftIndent = ".5in" 'this will put wrapped lines indented
        style.ParagraphFormat.FirstLineIndent = "-.5in" 'this makes sure the first line is not indented
        style.ParagraphFormat.TabStops.ClearAll()
        style.ParagraphFormat.AddTabStop("1in")
        style.ParagraphFormat.KeepTogether = True

        style = Doc.Styles(StyleNames.Header)
        style.ParagraphFormat.TabStops.ClearAll()
        style.ParagraphFormat.AddTabStop("2.25in", TabAlignment.Center)
        style.ParagraphFormat.AddTabStop("4.25in", TabAlignment.Right)
        style.Font.Size = 6
        style.Font.Bold = True

        style = Doc.Styles(StyleNames.Footer)
        style.ParagraphFormat.TabStops.ClearAll()
        style.ParagraphFormat.AddTabStop(Unit.FromInch((8.5) / 2), TabAlignment.Center)
        style.Font.Size = 6
        style.Font.Bold = True

    End Sub

    Sub DefineContentSection(pdf As Document)
        Dim Sect As Section = pdf.AddSection()
        Dim Height As String
        Dim Width As String

        'Height = "11in"
        'Width = "8.5in"
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
End Class
