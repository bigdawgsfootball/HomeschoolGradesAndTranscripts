Imports System.Deployment.Application

Public Class frmSetFileLocations
    Private GDrivePath As String = System.Environment.GetEnvironmentVariable("GBSYNCPATH", EnvironmentVariableTarget.User)
    Private GBookLoc As String = System.Environment.GetEnvironmentVariable("GBLOCATION", EnvironmentVariableTarget.User)


    Private Sub frmSetFileLocations_Load(sender As Object, e As EventArgs) Handles Me.Load

        If GDrivePath <> "" Then
            txtBkUpLoc.Text = GDrivePath
        End If

        If GBookLoc <> "" Then
            txtGradeLoc.Text = GBookLoc
        End If

    End Sub

    Private Sub btnChangeBkUpLoc_Click(sender As Object, e As EventArgs) Handles btnChangeBkUpLoc.Click
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()

        fd.Description = "Select location of folder that is backed up"
        fd.ShowNewFolderButton = True
        fd.RootFolder = Environment.SpecialFolder.MyComputer

        If fd.ShowDialog() = DialogResult.OK Then
            System.Environment.SetEnvironmentVariable("GBSYNCPATH", fd.SelectedPath, EnvironmentVariableTarget.User)
            txtBkUpLoc.Text = fd.SelectedPath
        End If

    End Sub

    Private Sub btnChgGradeLoc_Click(sender As Object, e As EventArgs) Handles btnChgGradeLoc.Click
        Using dialog As New OpenFileDialog
            dialog.Filter = "JSON Files (*.json) | *.json"
            dialog.Title = "Select Gradebook file to open"
#If DEBUG Then
            dialog.InitialDirectory = "C:\Users\Kurt\Downloads"
#Else
            dialog.InitialDirectory = ApplicationDeployment.CurrentDeployment.DataDirectory
#End If
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            System.Environment.SetEnvironmentVariable("GBLOCATION", dialog.FileName, EnvironmentVariableTarget.User)
            txtGradeLoc.Text = dialog.FileName
            frmMainMenu.btnOpenGB.Enabled = True
            GBFile = dialog.FileName
        End Using

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Dispose()
    End Sub
End Class