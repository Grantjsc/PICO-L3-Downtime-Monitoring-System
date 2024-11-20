Public Class ResolvedReport_Form

    Private Sub ResolvedReport_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCause.Text = ""
        cboStatus.Text = Nothing
        txtNextStep.Text = ""
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If String.IsNullOrEmpty(txtCause.Text) Then
            MsgBox("Please enter what is the cause!", MsgBoxStyle.Critical)
            txtCause.Focus()
        ElseIf String.IsNullOrEmpty(cboStatus.Text) Then
            MsgBox("Please enter an status!", MsgBoxStyle.Critical)
        ElseIf String.IsNullOrEmpty(txtNextStep.Text) Then
            MsgBox("Please enter what is the next step!", MsgBoxStyle.Critical)
            txtNextStep.Focus()
        Else

            If cboStatus.Text = "On-going" Then
                Send_DowntimeRep_OnGoing_Email()
            Else
                'Log_TimeResolved()
                'UpdateResolved_LineProcess_Status()
                Send_DowntimeRep_Email()
            End If

        End If
    End Sub

End Class