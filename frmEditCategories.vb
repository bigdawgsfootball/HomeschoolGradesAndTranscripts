Imports Newtonsoft.Json
Imports System.IO
Imports System.Deployment.Application

Public Class frmEditCategories

    Private Sub frmEditCategories_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim bsCategories As New BindingSource

        bsCategories.DataSource = AD.Categories
        dgvCategories.DataSource = bsCategories

        dgvCategories.Refresh()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim json As String = JsonConvert.SerializeObject(AD, Formatting.Indented)
        Dim FStream As Stream

#If DEBUG Then
        Dim FileName As String = "C:\Users\Kurt\documents\visual studio 2017\Projects\Gradebook\Gradebook\bin\Debug\AppData.json"
#Else
        Dim FileName As String = Path.Combine(ApplicationDeployment.CurrentDeployment.DataDirectory, "AppData.json")
#End If

        If File.Exists(FileName) Then
            If IsValidADJSON(json) Then
                FStream = New FileStream(FileName, FileMode.Create, FileAccess.Write, FileShare.Read)
                Dim writer As New StreamWriter(FStream)
                writer.Write(json)

                writer.Close()

                FStream.Close()
            End If
        End If

        Me.Dispose()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class