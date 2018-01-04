Imports Newtonsoft.Json
Imports Newtonsoft.Json.Schema
Imports System.IO
Imports System.Deployment.Application

Module DAL

    Friend Sub OpenGradebook()
        Dim FStream As Stream
        Dim JSONString As String = ""

#If DEBUG Then
        'GBFile = ".\gradebook.json"
        Using dialog As New OpenFileDialog
            dialog.Filter = "JSON Files (*.json) | *.json"
            dialog.Title = "Select Gradebook file to open"
            dialog.InitialDirectory = "C:\Users\Kurt\Downloads"
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            GBFile = dialog.FileName
        End Using
#Else
        GBFile = ApplicationDeployment.CurrentDeployment.DataDirectory & "\gradebook.json"
#End If

        If File.Exists(GBFile) Then
            FStream = File.OpenRead(GBFile)
            Dim reader As New StreamReader(FStream)
            JSONString = reader.ReadToEnd
            reader.Close()
            FStream.Close()
        End If

        If Not IsNothing(JSONString) Then
            GB = JsonConvert.DeserializeObject(Of Gradebook)(JSONString)
            MsgBox("Gradebook Opened!", vbOKOnly, "Success!")
        End If

    End Sub

    Friend Sub SaveGradebook()
        Dim json As String = JsonConvert.SerializeObject(GB, Formatting.Indented)
        Dim FStream As Stream

        If File.Exists(GBFile) Then
            If IsValidJSON(json) Then
                FStream = File.OpenWrite(GBFile)
                Dim writer As New StreamWriter(FStream)
                writer.Write(json)

                writer.Close()

                FStream.Close()
            End If
        End If

    End Sub

    Friend Function IsValidJSON(json As String)

        Try
            GB = JsonConvert.DeserializeObject(Of Gradebook)(json)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Module
