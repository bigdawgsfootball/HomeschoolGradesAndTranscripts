Imports Newtonsoft.Json
Imports System.IO
Imports System.Deployment.Application

Module DAL

    Friend Sub OpenGradebook()
        Dim FStream As Stream
        Dim JSONString As String = ""

        If GBFile = "" Then
            Using dialog As New OpenFileDialog
                dialog.Filter = "JSON Files (*.json) | *.json"
                dialog.Title = "Select Gradebook file to open"
#If DEBUG Then
               dialog.InitialDirectory = "C:\Users\Kurt\Downloads"
#Else
                dialog.InitialDirectory = ApplicationDeployment.CurrentDeployment.DataDirectory
#End If
                If dialog.ShowDialog() <> DialogResult.OK Then Return
                GBFile = dialog.FileName
            End Using
        End If

        If File.Exists(GBFile) Then
            FStream = File.OpenRead(GBFile)
            Dim reader As New StreamReader(FStream)
            JSONString = reader.ReadToEnd
            reader.Close()
            FStream.Close()
        Else
            MsgBox(GBFile & " does not exist." & vbCrLf & "Please select a new file", vbOKOnly)
        End If

        If Not IsNothing(JSONString) Then
            GB = JsonConvert.DeserializeObject(Of Gradebook)(JSONString)
            MsgBox("Gradebook Opened!", vbOKOnly, "Success!")
        Else
            MsgBox("JSON string invalid.", vbOKOnly)
        End If

    End Sub

    Friend Sub SaveGradebook()
        Dim json As String = JsonConvert.SerializeObject(GB, Formatting.Indented)
        Dim FStream As Stream

        If File.Exists(GBFile) Then
            If IsValidJSON(json) Then
                FStream = New FileStream(GBFile, FileMode.Create, FileAccess.Write, FileShare.Read)
                'FStream = File.OpenWrite(GBFile)
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
