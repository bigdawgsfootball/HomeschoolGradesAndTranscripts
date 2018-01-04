Imports System.Deployment.Application

Public Class frmMainMenu

    Private Sub btnOpenGB_Click(sender As Object, e As EventArgs) Handles btnOpenGB.Click
        OpenGradebook()
        btnAddAssignment.Enabled = True
        btnAddCourse.Enabled = True
        btnAddExtra.Enabled = True
        btnAddStudent.Enabled = True
        btnCalcGrade.Enabled = True
        btnReportCard.Enabled = True
        btnViewGradebook.Enabled = True
        btnEditJSON.Enabled = True
        btnBackUp.Enabled = True

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
        Dim GDrivePath As String = System.Environment.GetEnvironmentVariable("USERPROFILE") & "\Google Drive"

        If FileIO.FileSystem.DirectoryExists(GDrivePath) Then

            '#If DEBUG Then
            '            GBFile = ".\gradebook.json"
            '#Else
            '            GBFile = ApplicationDeployment.CurrentDeployment.DataDirectory & "\gradebook.json"
            '#End If

            If FileIO.FileSystem.FileExists(GBFile) Then
                FileIO.FileSystem.CopyFile(GBFile, GDrivePath & "\Gradebook\gradebook.json", True)
                MsgBox(GBFile & " backed up to Google Drive")
            Else
                MsgBox("Could not locate " & GBFile & " to copy")
            End If

        Else
            MsgBox("Could not determine Google Drive location")
        End If
    End Sub
End Class