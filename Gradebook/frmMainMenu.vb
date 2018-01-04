Imports System.Deployment.Application

Public Class frmMainMenu

    Private Sub btnOpenGB_Click(sender As Object, e As EventArgs) Handles btnOpenGB.Click
        OpenGradebook()

        If GBFile <> "" Then
            btnAddAssignment.Enabled = True
            btnAddCourse.Enabled = True
            'btnAddExtra.Enabled = True
            btnAddStudent.Enabled = True
            btnCalcGrade.Enabled = True
            btnReportCard.Enabled = True
            btnViewGradebook.Enabled = True
            btnEditJSON.Enabled = True
            btnBackUp.Enabled = True
        End If

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        frmAddStudent.Show()
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        frmAddCourse.Show()
    End Sub

    Private Sub btnAddExtra_Click(sender As Object, e As EventArgs) Handles btnAddExtra.Click

    End Sub

    Private Sub btnAddAssignment_Click(sender As Object, e As EventArgs) Handles btnAddAssignment.Click
        frmAddAssignment.Show()
    End Sub

    Private Sub btnViewGradebook_Click(sender As Object, e As EventArgs) Handles btnViewGradebook.Click
        frmViewGradebook.Show()
    End Sub

    Private Sub btnCalcGrade_Click(sender As Object, e As EventArgs) Handles btnCalcGrade.Click
        frmCalcGrade.Show()
    End Sub

    Private Sub btnEditJSON_Click(sender As Object, e As EventArgs) Handles btnEditJSON.Click
        System.Diagnostics.Process.Start("notepad.exe", GBFile)
    End Sub

    Private Sub btnReportCard_Click(sender As Object, e As EventArgs) Handles btnReportCard.Click
        frmSelectReportCard.Show()
    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        Dim GDrivePath As String = System.Environment.GetEnvironmentVariable("GBSYNCPATH", EnvironmentVariableTarget.User)

        If GDrivePath = "" Then
            btnSetLocations_Click(sender, e)
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

    Private Sub btnSetLocations_Click(sender As Object, e As EventArgs) Handles btnSetLocations.Click
        Dim GDrivePath As String = System.Environment.GetEnvironmentVariable("GBSYNCPATH", EnvironmentVariableTarget.User)

        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()

        fd.Description = "Select location of Google Drive or One Drive synced folder"
        fd.ShowNewFolderButton = True
        fd.RootFolder = Environment.SpecialFolder.MyComputer

        If fd.ShowDialog() = DialogResult.OK Then
            System.Environment.SetEnvironmentVariable("GBSYNCPATH", fd.SelectedPath, EnvironmentVariableTarget.User)
        End If

    End Sub

    Private Sub btnCreateNew_Click(sender As Object, e As EventArgs) Handles btnCreateNew.Click
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
End Class