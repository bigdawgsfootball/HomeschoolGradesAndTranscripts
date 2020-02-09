Imports MigraDoc.Rendering
Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Tables
Imports Newtonsoft.Json
Imports System

Public Class PrintAssignmentList

    Public Property Student As String
    Public Property GradeLevel As String
    Public Property Courses As List(Of Course)

    Sub doPrint()
        ' Create a MigraDoc document
        Dim doc As Document = printAssignList()

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

    Function printAssignList() As Document
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
        para.AddText("Assignment List")

        Dim RptTable As Table = sect.AddTable()

        RptTable.Style = "Table"
        RptTable.Borders.Color = Colors.Blue
        RptTable.Borders.Width = 0.5
        RptTable.Borders.Left.Width = 0.5
        RptTable.Borders.Right.Width = 0.5
        RptTable.Rows.LeftIndent = 0

        Dim sectionWidth As Double = pdf.DefaultPageSetup.PageWidth.Centimeter - pdf.DefaultPageSetup.LeftMargin.Centimeter - pdf.DefaultPageSetup.RightMargin.Centimeter
        Dim TitleColWidth As Integer = 7
        Dim DescColWidth As Integer = 10

        Dim colWidth As Double = (sectionWidth - TitleColWidth - DescColWidth) / 3

        Dim TitleCol As Integer = 0
        Dim DescriptionCol As Integer = 1
        Dim AssignTypeCol As Integer = 2
        Dim RatingPeriodCol As Integer = 3
        Dim GradeCol As Integer = 4

        'define columns for all course info
        Dim numCols As Integer = 5
        Dim Column As Column
        For i = 0 To numCols - 1
            If i = TitleCol Then
                Column = RptTable.AddColumn(TitleColWidth.ToString + "cm")
                Column.Format.Alignment = ParagraphAlignment.Left
            ElseIf i = DescriptionCol Then
                Column = RptTable.AddColumn(DescColWidth.ToString + "cm")
                Column.Format.Alignment = ParagraphAlignment.Left
            Else
                Column = RptTable.AddColumn(colWidth.ToString + "cm")
                Column.Format.Alignment = ParagraphAlignment.Center
            End If
        Next

        ' Create the header of the table
        Dim Row As Row = RptTable.AddRow()
        Row.HeadingFormat = True
        Row.Format.Alignment = ParagraphAlignment.Center
        Row.Format.Font.Bold = True
        Row.Shading.Color = Colors.LightBlue

        Row.Cells(0).AddParagraph("Assignment")
        Row.Cells(0).Format.Alignment = ParagraphAlignment.Left

        For i = 1 To numCols - 1
            Select Case i
                Case DescriptionCol
                    Row.Cells(DescriptionCol).AddParagraph("Assignment Description")
                Case AssignTypeCol
                    Row.Cells(AssignTypeCol).AddParagraph("Assignment Type")
                Case RatingPeriodCol
                    Row.Cells(RatingPeriodCol).AddParagraph("Rating Period")
                Case GradeCol
                    Row.Cells(GradeCol).AddParagraph("Grade")
            End Select
            Row.Cells(i).Format.Alignment = ParagraphAlignment.Center
        Next

        For Each course In Me.Courses
            Row = RptTable.AddRow()

            para = Row.Cells(DescriptionCol).AddParagraph()

            para.Style = "Heading2"
            para.AddSpace(10)
            para.AddText(course.Title)

            For Each assign In course.Assignments
                Row = RptTable.AddRow()

                For i As Integer = 0 To numCols - 1
                    Select Case i
                        Case TitleCol
                            Row.Cells(TitleCol).AddParagraph(assign.Title)
                        Case DescriptionCol
                            Row.Cells(DescriptionCol).AddParagraph(assign.Description)
                        Case AssignTypeCol
                            Row.Cells(AssignTypeCol).AddParagraph(assign.Type.ToString)
                        Case RatingPeriodCol
                            Row.Cells(RatingPeriodCol).AddParagraph(assign.RatingPeriod)
                        Case GradeCol
                            Row.Cells(GradeCol).AddParagraph(assign.Grade)
                    End Select
                Next

            Next

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

        pdf.Info.Title = "Assignment List"

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

End Class
