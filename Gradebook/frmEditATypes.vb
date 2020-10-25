Imports Newtonsoft.Json
Imports System.IO
Imports System.Deployment.Application

Public Class frmEditATypes
    Private Sub frmEditCategories_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim bsAssignTypes As New BindingSource

        bsAssignTypes.DataSource = AD.AssignmentTypes
        dgvAssignTypes.DataSource = bsAssignTypes

        dgvAssignTypes.Refresh()

        dgvAssignTypes.Columns(0).ReadOnly = True

        dgvAssignTypes.AllowUserToAddRows = False
        dgvAssignTypes.AllowUserToDeleteRows = False

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim json As String = JsonConvert.SerializeObject(AD, Formatting.Indented)
        Dim FStream As Stream

#If DEBUG Then
        Dim FileName As String = "C:\Users\Kurt\Source\Workspaces\Gradebook\Gradebook\Gradebook\bin\Debug\AppData.json"
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

    Private Sub dgvAssignTypes_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvAssignTypes.CellValidating
        Dim headerText As String = dgvAssignTypes.Columns(e.ColumnIndex).HeaderText
        Dim testValue As Decimal

        ' Abort validation if cell is not in the CompanyName column.
        If Not headerText.Equals("Weight") Then Return

        If Not e.FormattedValue.ToString = String.Empty AndAlso Not Decimal.TryParse(e.FormattedValue.ToString, testValue) Then
            e.Cancel = True
            MessageBox.Show("This is Not a Decimal Value. Please Try Again!", "Invalid Value!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class