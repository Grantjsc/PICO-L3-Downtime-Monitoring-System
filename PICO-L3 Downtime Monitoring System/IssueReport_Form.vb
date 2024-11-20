Public Class IssueReport_Form

    Private Sub IssueReport_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboIssue.Text = Nothing
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub btn3A_PreMelt_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If String.IsNullOrEmpty(cboIssue.Text) Then
            MsgBox("Please select an issue!", MsgBoxStyle.Critical)
        Else
            'UpdateError_LineProcess_Status()
            Send_Issue_Email()
        End If
    End Sub
End Class