
Module Main
    Friend GB As New Gradebook
    Friend GBFile As String = System.Environment.GetEnvironmentVariable("GBLOCATION", EnvironmentVariableTarget.User)
    Friend ATFile As String = ".\config.json"
End Module
