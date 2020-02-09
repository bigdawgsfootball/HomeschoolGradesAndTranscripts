Imports Newtonsoft.Json
Imports System.IO
Imports System.Deployment.Application

Public Class frmMainMenu

    Private Sub btnOpenGB_Click(sender As Object, e As EventArgs) Handles btnOpenGB.Click
        OpenGradebook()

        If GBFile <> "" Then
            btnViewGradebook.Enabled = True
            btnBackUp.Enabled = True
            EditJSONToolStripMenuItem.Enabled = True
            BackupToolStripMenuItem.Enabled = True
            RestoreFromBackupToolStripMenuItem.Enabled = True
            AddStudentToolStripMenuItem.Enabled = True
            AddCourseToolStripMenuItem.Enabled = True
            AddAssignmentToolStripMenuItem.Enabled = True
            ViewGradebookToolStripMenuItem.Enabled = True
            CalcGradeToolStripMenuItem.Enabled = True
            GenReportCardToolStripMenuItem.Enabled = True
            GenerateTranscriptToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub btnViewGradebook_Click(sender As Object, e As EventArgs) Handles btnViewGradebook.Click
        frmViewGradebook.Show()
    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        BackUp()
    End Sub

    Private Sub LoadSchoolInfo()
        Dim stringSeparators() As String = {"``"}

        Dim Info As String = Environment.GetEnvironmentVariable("GBSCHOOLINFO", EnvironmentVariableTarget.User)
        If Info <> "" Then
            Dim Pieces() As String = Info.Split(stringSeparators, StringSplitOptions.None)
            lblSchoolName.Text = Pieces(0)
            lblAddr1.Text = Pieces(1)
            lblAddr2.Text = Pieces(2)
        Else
            lblSchoolName.Text = "Don't forget to include your"
            lblAddr1.Text = "school info for transcripts"
            lblAddr2.Text = "Menu Edit -> Edit School Info"
        End If
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSchoolInfo()

        If GBFile = "" Then
            btnOpenGB.Enabled = False
        End If

#If DEBUG Then
        Dim FileName As String = "C:\Users\Kurt\Source\Workspaces\Gradebook\Gradebook\Gradebook\bin\Debug\AppData.json"
#Else
        Dim FileName As String = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, "AppData.json")
#End If
        Dim content As String = File.ReadAllText(FileName)
        AD = JsonConvert.DeserializeObject(content, GetType(AppData))


    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()

        fd.Description = "Select folder location for new Gradebook file"
        fd.ShowNewFolderButton = True
        fd.RootFolder = Environment.SpecialFolder.MyComputer

        Dim FName As String = InputBox("What do you want to name this file?", "Filename", "gradebook")

        If FName.Contains(".") Then
            Dim Pieces() As String = FName.Split(".")
            FName = Pieces(0)
        End If

        If fd.ShowDialog() = DialogResult.OK And FName <> "" Then
            Using fs As System.IO.FileStream = System.IO.File.Create(fd.SelectedPath & "\" & FName.Trim & ".json")
                Dim txt As [Byte]() = New System.Text.UTF8Encoding(True).GetBytes("{" & vbCrLf)
                fs.Write(txt, 0, txt.Length)
                txt = New System.Text.UTF8Encoding(True).GetBytes("  ""Students"": []" & vbCrLf)
                fs.Write(txt, 0, txt.Length)
                txt = New System.Text.UTF8Encoding(True).GetBytes("}" & vbCrLf)
                fs.Write(txt, 0, txt.Length)
            End Using
        End If

    End Sub

    Private Sub EditJSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditJSONToolStripMenuItem.Click
        System.Diagnostics.Process.Start("notepad.exe", GBFile)
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        frmAddStudent.Show()
    End Sub

    Private Sub AddCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCourseToolStripMenuItem.Click
        frmAddCourse.Show()
    End Sub

    Private Sub GenerateTranscriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateTranscriptToolStripMenuItem.Click
        frmPrintTranscript.Show()
    End Sub

    Private Sub AddAssignmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssignmentToolStripMenuItem.Click
        frmAddAssignment.Show()
    End Sub

    Private Sub ViewGradebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewGradebookToolStripMenuItem.Click
        frmViewGradebook.Show()
    End Sub

    Private Sub CalcGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcGradeToolStripMenuItem.Click
        frmCalcGrade.Show()
    End Sub

    Private Sub GenReportCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenReportCardToolStripMenuItem.Click
        frmSelectReportCard.Show()
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        BackUp()
    End Sub

    Private Sub BackUp()
        Dim GDrivePath As String = System.Environment.GetEnvironmentVariable("GBSYNCPATH", EnvironmentVariableTarget.User)

        If GDrivePath = "" Then
            frmSetFileLocations.Show()
        End If

        If FileIO.FileSystem.DirectoryExists(GDrivePath) Then

            If FileIO.FileSystem.FileExists(GBFile) Then
                FileIO.FileSystem.CopyFile(GBFile, GDrivePath & "\Gradebook\gradebook.json", True)
                MsgBox(GBFile & " backed up to synched folder")
            Else
                MsgBox("Could not locate " & GBFile & " to copy")
            End If

        Else
            MsgBox("Could not determine synched folder location")
        End If
    End Sub

    Private Sub SetFileLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetFileLocationsToolStripMenuItem.Click
        frmSetFileLocations.Show()
    End Sub

    Private Sub EditSchoolInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSchoolInfoToolStripMenuItem.Click
        frmSchoolInfo.ShowDialog()
        LoadSchoolInfo()
    End Sub

    Private Sub EditCourseCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCourseCategoriesToolStripMenuItem.Click
        frmEditCategories.Show()
    End Sub

    Private Sub EditAssignmentTypesWeightsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAssignmentTypesWeightsToolStripMenuItem.Click
        frmEditATypes.Show()
    End Sub

    Private Sub RestoreFromBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreFromBackupToolStripMenuItem.Click
        Dim GDrivePath As String = System.Environment.GetEnvironmentVariable("GBSYNCPATH", EnvironmentVariableTarget.User)

        If GDrivePath = "" Then
            MsgBox("No backup location set!")
        Else
            If FileIO.FileSystem.DirectoryExists(GDrivePath) Then

                If FileIO.FileSystem.FileExists(GBFile) Then
                    FileIO.FileSystem.CopyFile(GDrivePath & "\Gradebook\gradebook.json", GBFile, True)
                    MsgBox(GBFile & " restored to working location. Re-open the Gradebook file.")
                Else
                    MsgBox("Could not locate " & GBFile & " to restore")
                End If

            Else
                MsgBox("Could not determine synched folder location")
            End If
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GenerateAssignmentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateAssignmentListToolStripMenuItem.Click
        frmPrintAssigns.Show()
    End Sub
End Class