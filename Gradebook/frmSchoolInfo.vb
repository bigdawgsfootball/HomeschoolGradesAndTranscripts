Public Class frmSchoolInfo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If txtSchoolName.Text <> "" Then
            If txtAddr1.Text <> "" Then
                If txtAddr2.Text <> "" Then
                    Environment.SetEnvironmentVariable("GBSCHOOLINFO", txtSchoolName.Text & "``" & txtAddr1.Text & "``" & txtAddr2.Text, EnvironmentVariableTarget.User)
                    Me.Dispose()
                Else
                    MsgBox("Your School needs a complete address", vbOKOnly)
                    txtAddr2.Select()
                End If
            Else
                MsgBox("Your School needs a complete address", vbOKOnly)
                txtAddr1.Select()
            End If
        Else
            MsgBox("Your School needs a name!", vbOKOnly)
            txtSchoolName.Select()
        End If

    End Sub

    Private Sub frmSchoolInfo_Load() Handles MyBase.Load
        Dim stringSeparators() As String = {"``"}

        Dim Info As String = Environment.GetEnvironmentVariable("GBSCHOOLINFO", EnvironmentVariableTarget.User)
        If Info <> "" Then
            Dim Pieces() As String = Info.Split(stringSeparators, StringSplitOptions.None)
            txtSchoolName.Text = Pieces(0)
            txtAddr1.Text = Pieces(1)
            txtAddr2.Text = Pieces(2)
        End If
    End Sub

End Class