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

            Master_login.Label1.Text = "Please scan your finger. PO3 or Associate only"
            Acknowledge = True
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "Operator" Then

                Master_login.Close()

                If cboStatus.Text = "On-going" Then
                    SQL_Ongoing_LineStat()
                    Send_DowntimeRep_OnGoing_Email()
                Else
                    'Log_TimeResolved()
                    'UpdateResolved_LineProcess_Status()
                    Send_DowntimeRep_Email()
                End If

            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        End If
    End Sub

End Class