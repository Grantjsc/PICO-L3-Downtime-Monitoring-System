Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.Mail
Imports System.Threading
Module AppConfig_Module

    '***************** Line Process Error Status ******************

    '***************** For Line 3A *******************

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public Line3A_PreMelt_ErrorStat As Integer
    Public Line3A_CLI_ErrorStat As Integer
    Public Line3A_Glassing_ErrorStat As Integer
    Public Line3A_Picosine_ErrorStat As Integer
    Public Line3A_PinTray_ErrorStat As Integer
    Public Line3A_1stHeat_ErrorStat As Integer
    Public Line3A_Turning_ErrorStat As Integer
    Public Line3A_2ndHeat_ErrorStat As Integer
    Public Line3A_Trimming_ErrorStat As Integer

    Public Update_ProcessStatus As Integer

    Public WheelCoater_L3_ErrorStat As Integer
    Public WheelCoater_L5_ErrorStat As Integer


    '***************** Get Line 3A process status *******************

    Sub Get_3A_PreMelt_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_PreMelt_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_PreMelt_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_CLI_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_CLI_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_CLI_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_Glassing_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_Glassing_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_Glassing_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_Picosine_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_Picosine_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_Picosine_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_PinTray_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_PinTray_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_PinTray_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_1stHeat_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_1stHeat_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_1stHeat_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_Turning_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_Turning_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_Turning_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_2ndHeat_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_2ndHeat_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_2ndHeat_ErrorStat = LineProStatus
    End Sub

    Sub Get_3A_Trimming_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3A_Trimming_Stat")
        Console.WriteLine(LineProStatus)

        Line3A_Trimming_ErrorStat = LineProStatus
    End Sub


    '***************** Change Line 3A process status *******************
    Sub Update_Line3A_PreMelt_ErrorStat()
        config.AppSettings.Settings("3A_PreMelt_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_CLI_ErrorStat()
        config.AppSettings.Settings("3A_CLI_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_Glassing_ErrorStat()
        config.AppSettings.Settings("3A_Glassing_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_Picosine_ErrorStat()
        config.AppSettings.Settings("3A_Picosine_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_PinTray_ErrorStat()
        config.AppSettings.Settings("3A_PinTray_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_1stHeat_ErrorStat()
        config.AppSettings.Settings("3A_1stHeat_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_Turning_ErrorStat()
        config.AppSettings.Settings("3A_Turning_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_2ndHeat_ErrorStat()
        config.AppSettings.Settings("3A_2ndHeat_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3A_Trimming_ErrorStat()
        config.AppSettings.Settings("3A_Trimming_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub


    '***************** For Line 3B *******************

    Public Line3B_PreMelt_ErrorStat As Integer
    Public Line3B_CLI_ErrorStat As Integer
    Public Line3B_Glassing_ErrorStat As Integer
    Public Line3B_Picosine_ErrorStat As Integer
    Public Line3B_PinTray_ErrorStat As Integer
    Public Line3B_1stHeat_ErrorStat As Integer
    Public Line3B_Turning_ErrorStat As Integer
    Public Line3B_2ndHeat_ErrorStat As Integer
    Public Line3B_Trimming_ErrorStat As Integer

    '***************** Get Line 3B process status *******************

    Sub Get_3B_PreMelt_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_PreMelt_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_PreMelt_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_CLI_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_CLI_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_CLI_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_Glassing_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_Glassing_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_Glassing_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_Picosine_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_Picosine_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_Picosine_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_PinTray_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_PinTray_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_PinTray_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_1stHeat_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_1stHeat_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_1stHeat_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_Turning_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_Turning_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_Turning_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_2ndHeat_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_2ndHeat_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_2ndHeat_ErrorStat = LineProStatus
    End Sub

    Sub Get_3B_Trimming_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("3B_Trimming_Stat")
        Console.WriteLine(LineProStatus)

        Line3B_Trimming_ErrorStat = LineProStatus
    End Sub


    '***************** Change Line 3B process status *******************
    Sub Update_Line3B_PreMelt_ErrorStat()
        config.AppSettings.Settings("3B_PreMelt_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_CLI_ErrorStat()
        config.AppSettings.Settings("3B_CLI_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_Glassing_ErrorStat()
        config.AppSettings.Settings("3B_Glassing_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_Picosine_ErrorStat()
        config.AppSettings.Settings("3B_Picosine_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_PinTray_ErrorStat()
        config.AppSettings.Settings("3B_PinTray_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_1stHeat_ErrorStat()
        config.AppSettings.Settings("3B_1stHeat_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_Turning_ErrorStat()
        config.AppSettings.Settings("3B_Turning_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_2ndHeat_ErrorStat()
        config.AppSettings.Settings("3B_2ndHeat_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line3B_Trimming_ErrorStat()
        config.AppSettings.Settings("3B_Trimming_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub


    '***************** Get Wheel Coater process status *******************

    Sub Get_WC_L3_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("WC_L3_Stat")
        Console.WriteLine(LineProStatus)

        WheelCoater_L3_ErrorStat = LineProStatus
    End Sub

    Sub Get_WC_L5_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("WC_L5_Stat")
        Console.WriteLine(LineProStatus)

        WheelCoater_L5_ErrorStat = LineProStatus
    End Sub

    '***************** Change Wheel Coater process status *******************
    Sub Update_WC_L3_ErrorStat()
        config.AppSettings.Settings("WC_L3_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_WC_L5_ErrorStat()
        config.AppSettings.Settings("WC_L5_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

End Module

Module SendEmail_Module
    Public Email As MailMessage

    Sub Send_Issue_Email()

        Get_Emails() 'Get the list of email from offline database

        Dim Process As String = IssueReport_Form.txtProcess.Text
        Dim Line As String = IssueReport_Form.txtLine.Text
        Dim Issue As String = IssueReport_Form.cboIssue.Text
        Dim EmailAdd As String = Emails_Db
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICOLine3_Dowtime@littelfuse.com")
        Email.Subject = "DOWNTIME ALERT: " & Line
        Email.Body = "<style>
                        td {
                          border:1px solid black;
                        }
                        
                        table {
                            border:1px solid black;
                            width: 60%;
                        }
                        </style>
                      
                      <div style='font-family: Arial, sans-serif; font-size: 12pt;'>
                        Please refer to the table below for more information on the line issue.;<br><br>
                          <table>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>Process:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red;text-align: center;'>Issue:</td>
                              <td>" & Issue & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red;text-align: center;'>PIC:</td>
                              <td>PROCESS/PRODUCT/EQUIPMENT/QA/PRODUCTION</td>
                            </tr>
                          </table>
                        </div>
                        <br> 

                        <small style='color:Gray;'>
                          <i>This is a system generated mail. Please do not reply.</i>
                        </small>"


        Email.IsBodyHtml = True
        ' Set high importance
        Email.Priority = MailPriority.High

        'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

        SMTP.Host = "mailrelay.america.littelfuse.com"
        SMTP.SendAsync(Email, Nothing)

        UpdateError_LineProcess_Status() 'Update the Status(AppConfig) and change button color

        IssueReport_Form.Close()

    End Sub

    Public LineIssue_Duration As String
    Public Totalhrs As Decimal

    Sub Send_DowntimeRep_Email()

        Get_Emails() 'Get the list of email from offline database
        Thread.Sleep(100)
        Log_TimeResolved()
        Thread.Sleep(100)
        Get_Duration() 'Get the reported time and resolved time

        Dim dateTime1 As DateTime = DateTime.Parse(Reported)
        Dim dateTime2 As DateTime = DateTime.Parse(Resolved)

        ' Calculate the duration
        Dim duration As TimeSpan = dateTime2 - dateTime1

        Dim Process As String = ResolvedReport_Form.txtProcess.Text
        Dim Line As String = ResolvedReport_Form.txtLine.Text
        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        '= Reported & " to " & Resolved
        Dim DT_Duration As String = duration.Days & " day(s). " &
                                    duration.Hours & " hour(s). and " &
                                   duration.Minutes & " minute(s)."

        LineIssue_Duration = DT_Duration
        Totalhrs = Math.Round(duration.TotalHours, 2)

        Dim Cause As String = ResolvedReport_Form.txtCause.Text
        Dim Status As String = ResolvedReport_Form.cboStatus.Text
        Dim Next_S As String = ResolvedReport_Form.txtNextStep.Text

        Dim EmailAdd As String = Emails_Db
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICOLine3_Dowtime@littelfuse.com")
        Email.Subject = "DOWNTIME ALERT: " & Line
        Email.Body = "<style>
                        td {
                          border:1px solid black;
                        }
                        
                        table {
                            border:1px solid black;
                            width: 60%;
                        }
                        </style>
                      
                      <div style='font-family: Arial, sans-serif; font-size: 12pt;'>
                        Please refer to the table below for more information on the line issue.;<br><br>
                          <table>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green; text-align: center;'>Process:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green; text-align: center;'>Duration:</td>
                              <td>" & DT_Duration & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>Cause:</td>
                              <td>" & Cause & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>Status:</td>
                              <td>" & Status & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>Next Steps:</td>
                              <td>" & Next_S & "</td>
                            </tr>
                          </table>
                        </div>
                        <br> 

                        <small style='color:Gray;'>
                          <i>This is a system generated mail. Please do not reply.</i>
                        </small>"


        Email.IsBodyHtml = True
        ' Set high importance
        Email.Priority = MailPriority.High

        'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

        SMTP.Host = "mailrelay.america.littelfuse.com"
        SMTP.SendAsync(Email, Nothing)

        UpdateResolved_LineProcess_Status() 'Update the Status(AppConfig) and change button color
        Thread.Sleep(500)

        Log_TimeDuration() ' Log the duration time

        CheckPath() 'save history in csv file

        Delete_IssueTracker()
        ResolvedReport_Form.Close()

    End Sub

    Sub Send_DowntimeRep_OnGoing_Email()

        Get_Emails() 'Get the list of email from offline database
        Thread.Sleep(100)
        Get_Duration() 'Get the reported time and resolved time

        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mm:ss tt")

        Dim dateTime1 As DateTime = DateTime.Parse(Reported)
        Dim dateTime2 As DateTime = DateTime.Parse(dateNtime)

        ' Calculate the duration
        Dim duration As TimeSpan = dateTime2 - dateTime1

        Dim Process As String = ResolvedReport_Form.txtProcess.Text
        Dim Line As String = ResolvedReport_Form.txtLine.Text
        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        '= Reported & " to " & Resolved
        Dim DT_Duration As String = duration.Days & " day(s). " &
                                    duration.Hours & " hour(s). and " &
                                   duration.Minutes & " minute(s)."

        Dim Cause As String = ResolvedReport_Form.txtCause.Text
        Dim Status As String = ResolvedReport_Form.cboStatus.Text
        Dim Next_S As String = ResolvedReport_Form.txtNextStep.Text

        Dim EmailAdd As String = Emails_Db
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICOLine3_Dowtime@littelfuse.com")
        Email.Subject = "DOWNTIME ALERT: " & Line
        Email.Body = "<style>
                        td {
                          border:1px solid black;
                        }
                        
                        table {
                            border:1px solid black;
                            width: 60%;
                        }
                        </style>
                      
                      <div style='font-family: Arial, sans-serif; font-size: 12pt;'>
                        Please refer to the table below for more information on the line issue.;<br><br>
                          <table>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold; text-align: center;'>Process:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold; text-align: center;'>Duration:</td>
                              <td>" & DT_Duration & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>Cause:</td>
                              <td>" & Cause & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>Status:</td>
                              <td>" & Status & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>Next Steps:</td>
                              <td>" & Next_S & "</td>
                            </tr>
                          </table>
                        </div>
                        <br> 

                        <small style='color:Gray;'>
                          <i>This is a system generated mail. Please do not reply.</i>
                        </small>"


        Email.IsBodyHtml = True
        ' Set high importance
        Email.Priority = MailPriority.High

        'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

        SMTP.Host = "mailrelay.america.littelfuse.com"
        SMTP.SendAsync(Email, Nothing)

        ResolvedReport_Form.Close()

    End Sub
End Module

Module Function_Module

    Sub Load_AddForm()
        Master_login.Label1.Text = "Please scan your finger. Engineer only"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "Engineer" Then

            Master_login.Close()
            With Add_Form
                .TopLevel = False
                Form1.PanelMaster.Controls.Add(Add_Form)
                .WindowState = FormWindowState.Maximized
                .BringToFront()
                .Show()
            End With

        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

    Sub GetAll_Line_Process_Status()
        Get_3A_PreMelt_Status()
        Get_3A_CLI_Status()
        Get_3A_Glassing_Status()
        Get_3A_Picosine_Status()
        Get_3A_PinTray_Status()
        Get_3A_1stHeat_Status()
        Get_3A_Turning_Status()
        Get_3A_2ndHeat_Status()
        Get_3A_Trimming_Status()

        Get_3B_PreMelt_Status()
        Get_3B_CLI_Status()
        Get_3B_Glassing_Status()
        Get_3B_Picosine_Status()
        Get_3B_PinTray_Status()
        Get_3B_1stHeat_Status()
        Get_3B_Turning_Status()
        Get_3B_2ndHeat_Status()
        Get_3B_Trimming_Status()

        Get_WC_L3_Status()
        Get_WC_L5_Status()
    End Sub

    Sub UpdateError_LineProcess_Status()
        Dim Line_Pro As String = IssueReport_Form.txtLine.Text & " " & IssueReport_Form.txtProcess.Text

        Select Case Line_Pro

            Case "PICO Line 3A Pre-melt"
                'MsgBox("PICO Line 3A Pre-melt")
                Update_ProcessStatus = 1
                Update_Line3A_PreMelt_ErrorStat()

                Form1.btn3A_PreMelt.FillColor = Color.Salmon
                Form1.btn3A_PreMelt.FillColor2 = Color.Red
                Form1.btn3A_PreMelt.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3A CLI"
                'MsgBox("PICO Line 3A CLI")
                Update_ProcessStatus = 1
                Update_Line3A_CLI_ErrorStat()

                Form1.btn3A_CLI.FillColor = Color.Salmon
                Form1.btn3A_CLI.FillColor2 = Color.Red
                Form1.btn3A_CLI.ForeColor = Color.White


                Log_TimeReported()

            Case "PICO Line 3A Glassing"
                'MsgBox("PICO Line 3A Glassing")
                Update_ProcessStatus = 1
                Update_Line3A_Glassing_ErrorStat()

                Form1.btn3A_Glassing.FillColor = Color.Salmon
                Form1.btn3A_Glassing.FillColor2 = Color.Red
                Form1.btn3A_Glassing.ForeColor = Color.White


                Log_TimeReported()

            Case "PICO Line 3A Picosine"
                'MsgBox("PICO Line 3A Picosine")
                Update_ProcessStatus = 1
                Update_Line3A_Picosine_ErrorStat()

                Form1.btn3A_Picosine.FillColor = Color.Salmon
                Form1.btn3A_Picosine.FillColor2 = Color.Red
                Form1.btn3A_Picosine.ForeColor = Color.White


                Log_TimeReported()

            Case "PICO Line 3A Pin Tray"
                'MsgBox("PICO Line 3A Pin Tray")
                Update_ProcessStatus = 1
                Update_Line3A_PinTray_ErrorStat()

                Form1.btn3A_PinTray.FillColor = Color.Salmon
                Form1.btn3A_PinTray.FillColor2 = Color.Red
                Form1.btn3A_PinTray.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3A 1st Heat"
                'MsgBox("PICO Line 3A 1st Heat")
                Update_ProcessStatus = 1
                Update_Line3A_1stHeat_ErrorStat()

                Form1.btn3A_1stHeat.FillColor = Color.Salmon
                Form1.btn3A_1stHeat.FillColor2 = Color.Red
                Form1.btn3A_1stHeat.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3A Turning"
                'MsgBox("PICO Line 3A Turning")
                Update_ProcessStatus = 1
                Update_Line3A_Turning_ErrorStat()

                Form1.btn3A_Turning.FillColor = Color.Salmon
                Form1.btn3A_Turning.FillColor2 = Color.Red
                Form1.btn3A_Turning.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3A 2nd Heat"
                'MsgBox("PICO Line 3A 2nd Heat")
                Update_ProcessStatus = 1
                Update_Line3A_2ndHeat_ErrorStat()

                Form1.btn3A_2ndHeat.FillColor = Color.Salmon
                Form1.btn3A_2ndHeat.FillColor2 = Color.Red
                Form1.btn3A_2ndHeat.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3A Trimming"
                'MsgBox("PICO Line 3A Trimming")
                Update_ProcessStatus = 1
                Update_Line3A_Trimming_ErrorStat()

                Form1.btn3A_Trimming.FillColor = Color.Salmon
                Form1.btn3A_Trimming.FillColor2 = Color.Red
                Form1.btn3A_Trimming.ForeColor = Color.White

                Log_TimeReported()

                '****************** FOR LINE 3B ***********************


            Case "PICO Line 3B Pre-melt"
                'MsgBox("PICO Line 3B Pre-melt")
                Update_ProcessStatus = 1
                Update_Line3B_PreMelt_ErrorStat()

                Form1.btn3B_PreMelt.FillColor = Color.Salmon
                Form1.btn3B_PreMelt.FillColor2 = Color.Red
                Form1.btn3B_PreMelt.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B CLI"
                'MsgBox("PICO Line 3B CLI")
                Update_ProcessStatus = 1
                Update_Line3B_CLI_ErrorStat()

                Form1.btn3B_CLI.FillColor = Color.Salmon
                Form1.btn3B_CLI.FillColor2 = Color.Red
                Form1.btn3B_CLI.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B Glassing"
                'MsgBox("PICO Line 3B Glassing")
                Update_ProcessStatus = 1
                Update_Line3B_Glassing_ErrorStat()

                Form1.btn3B_Glassing.FillColor = Color.Salmon
                Form1.btn3B_Glassing.FillColor2 = Color.Red
                Form1.btn3B_Glassing.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B Picosine"
                'MsgBox("PICO Line 3B Picosine")
                Update_ProcessStatus = 1
                Update_Line3B_Picosine_ErrorStat()

                Form1.btn3B_Picosine.FillColor = Color.Salmon
                Form1.btn3B_Picosine.FillColor2 = Color.Red
                Form1.btn3B_Picosine.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B Pin Tray"
                'MsgBox("PICO Line 3B Pin Tray")
                Update_ProcessStatus = 1
                Update_Line3B_PinTray_ErrorStat()

                Form1.btn3B_PinTray.FillColor = Color.Salmon
                Form1.btn3B_PinTray.FillColor2 = Color.Red
                Form1.btn3B_PinTray.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B 1st Heat"
                'MsgBox("PICO Line 3B 1st Heat")
                Update_ProcessStatus = 1
                Update_Line3B_1stHeat_ErrorStat()

                Form1.btn3B_1stHeat.FillColor = Color.Salmon
                Form1.btn3B_1stHeat.FillColor2 = Color.Red
                Form1.btn3B_1stHeat.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B Turning"
                'MsgBox("PICO Line 3B Turning")
                Update_ProcessStatus = 1
                Update_Line3B_Turning_ErrorStat()

                Form1.btn3B_Turning.FillColor = Color.Salmon
                Form1.btn3B_Turning.FillColor2 = Color.Red
                Form1.btn3B_Turning.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B 2nd Heat"
                'MsgBox("PICO Line 3B 2nd Heat")
                Update_ProcessStatus = 1
                Update_Line3B_2ndHeat_ErrorStat()

                Form1.btn3B_2ndHeat.FillColor = Color.Salmon
                Form1.btn3B_2ndHeat.FillColor2 = Color.Red
                Form1.btn3B_2ndHeat.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3B Trimming"
                'MsgBox("PICO Line 3B Trimming")
                Update_ProcessStatus = 1
                Update_Line3B_Trimming_ErrorStat()

                Form1.btn3B_Trimming.FillColor = Color.Salmon
                Form1.btn3B_Trimming.FillColor2 = Color.Red
                Form1.btn3B_Trimming.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 3 Wheel Coater"
                'MsgBox("PICO Line 3 Wheel Coater")
                Update_ProcessStatus = 1
                Update_WC_L3_ErrorStat()

                Form1.btnWC_Line3.FillColor = Color.Salmon
                Form1.btnWC_Line3.FillColor2 = Color.Red
                Form1.btnWC_Line3.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 5 Wheel Coater"
                'MsgBox("PICO Line 3 Wheel Coater")
                Update_ProcessStatus = 1
                Update_WC_L5_ErrorStat()

                Form1.btnWC_Line5.FillColor = Color.Salmon
                Form1.btnWC_Line5.FillColor2 = Color.Red
                Form1.btnWC_Line5.ForeColor = Color.White

                Log_TimeReported()

        End Select



    End Sub

    Sub UpdateResolved_LineProcess_Status()

        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        Select Case LinePro
            Case "PICO Line 3A Pre-melt"
                'MsgBox("PICO Line 3A Pre-melt")
                Update_ProcessStatus = 0
                Update_Line3A_PreMelt_ErrorStat()

                Form1.btn3A_PreMelt.FillColor = Color.Green
                Form1.btn3A_PreMelt.FillColor2 = Color.LightGreen
                Form1.btn3A_PreMelt.ForeColor = Color.Black

            Case "PICO Line 3A CLI"
                'MsgBox("PICO Line 3A CLI")
                Update_ProcessStatus = 0
                Update_Line3A_CLI_ErrorStat()

                Form1.btn3A_CLI.FillColor = Color.Green
                Form1.btn3A_CLI.FillColor2 = Color.LightGreen
                Form1.btn3A_CLI.ForeColor = Color.Black

            Case "PICO Line 3A Glassing"
                'MsgBox("PICO Line 3A Glassing")
                Update_ProcessStatus = 0
                Update_Line3A_Glassing_ErrorStat()

                Form1.btn3A_Glassing.FillColor = Color.Green
                Form1.btn3A_Glassing.FillColor2 = Color.LightGreen
                Form1.btn3A_Glassing.ForeColor = Color.Black

            Case "PICO Line 3A Picosine"
                'MsgBox("PICO Line 3A Picosine")
                Update_ProcessStatus = 0
                Update_Line3A_Picosine_ErrorStat()

                Form1.btn3A_Picosine.FillColor = Color.Green
                Form1.btn3A_Picosine.FillColor2 = Color.LightGreen
                Form1.btn3A_Picosine.ForeColor = Color.Black

            Case "PICO Line 3A Pin Tray"
                'MsgBox("PICO Line 3A Pin Tray")
                Update_ProcessStatus = 0
                Update_Line3A_PinTray_ErrorStat()

                Form1.btn3A_PinTray.FillColor = Color.Green
                Form1.btn3A_PinTray.FillColor2 = Color.LightGreen
                Form1.btn3A_PinTray.ForeColor = Color.Black

            Case "PICO Line 3A 1st Heat"
                'MsgBox("PICO Line 3A 1st Heat")
                Update_ProcessStatus = 0
                Update_Line3A_1stHeat_ErrorStat()

                Form1.btn3A_1stHeat.FillColor = Color.Green
                Form1.btn3A_1stHeat.FillColor2 = Color.LightGreen
                Form1.btn3A_1stHeat.ForeColor = Color.Black

            Case "PICO Line 3A Turning"
                'MsgBox("PICO Line 3A Turning")
                Update_ProcessStatus = 0
                Update_Line3A_Turning_ErrorStat()

                Form1.btn3A_Turning.FillColor = Color.Green
                Form1.btn3A_Turning.FillColor2 = Color.LightGreen
                Form1.btn3A_Turning.ForeColor = Color.Black

            Case "PICO Line 3A 2nd Heat"
                'MsgBox("PICO Line 3A 2nd Heat")
                Update_ProcessStatus = 0
                Update_Line3A_2ndHeat_ErrorStat()

                Form1.btn3A_2ndHeat.FillColor = Color.Green
                Form1.btn3A_2ndHeat.FillColor2 = Color.LightGreen
                Form1.btn3A_2ndHeat.ForeColor = Color.Black

            Case "PICO Line 3A Trimming"
                'MsgBox("PICO Line 3A Trimming")
                Update_ProcessStatus = 0
                Update_Line3A_Trimming_ErrorStat()

                Form1.btn3A_Trimming.FillColor = Color.Green
                Form1.btn3A_Trimming.FillColor2 = Color.LightGreen
                Form1.btn3A_Trimming.ForeColor = Color.Black


                '****************** FOR LINE 3B ***********************


            Case "PICO Line 3B Pre-melt"
                'MsgBox("PICO Line 3B Pre-melt")
                Update_ProcessStatus = 0
                Update_Line3B_PreMelt_ErrorStat()

                Form1.btn3B_PreMelt.FillColor = Color.Green
                Form1.btn3B_PreMelt.FillColor2 = Color.LightGreen
                Form1.btn3B_PreMelt.ForeColor = Color.Black

            Case "PICO Line 3B CLI"
                'MsgBox("PICO Line 3B CLI")
                Update_ProcessStatus = 0
                Update_Line3B_CLI_ErrorStat()

                Form1.btn3B_CLI.FillColor = Color.Green
                Form1.btn3B_CLI.FillColor2 = Color.LightGreen
                Form1.btn3B_CLI.ForeColor = Color.Black

            Case "PICO Line 3B Glassing"
                'MsgBox("PICO Line 3B Glassing")
                Update_ProcessStatus = 0
                Update_Line3B_Glassing_ErrorStat()

                Form1.btn3B_Glassing.FillColor = Color.Green
                Form1.btn3B_Glassing.FillColor2 = Color.LightGreen
                Form1.btn3B_Glassing.ForeColor = Color.Black

            Case "PICO Line 3B Picosine"
                'MsgBox("PICO Line 3B Picosine")
                Update_ProcessStatus = 0
                Update_Line3B_Picosine_ErrorStat()

                Form1.btn3B_Picosine.FillColor = Color.Green
                Form1.btn3B_Picosine.FillColor2 = Color.LightGreen
                Form1.btn3B_Picosine.ForeColor = Color.Black

            Case "PICO Line 3B Pin Tray"
                'MsgBox("PICO Line 3B Pin Tray")
                Update_ProcessStatus = 0
                Update_Line3B_PinTray_ErrorStat()

                Form1.btn3B_PinTray.FillColor = Color.Green
                Form1.btn3B_PinTray.FillColor2 = Color.LightGreen
                Form1.btn3B_PinTray.ForeColor = Color.Black

            Case "PICO Line 3B 1st Heat"
                'MsgBox("PICO Line 3B 1st Heat")
                Update_ProcessStatus = 0
                Update_Line3B_1stHeat_ErrorStat()

                Form1.btn3B_1stHeat.FillColor = Color.Green
                Form1.btn3B_1stHeat.FillColor2 = Color.LightGreen
                Form1.btn3B_1stHeat.ForeColor = Color.Black

            Case "PICO Line 3B Turning"
                'MsgBox("PICO Line 3B Turning")
                Update_ProcessStatus = 0
                Update_Line3B_Turning_ErrorStat()

                Form1.btn3B_Turning.FillColor = Color.Green
                Form1.btn3B_Turning.FillColor2 = Color.LightGreen
                Form1.btn3B_Turning.ForeColor = Color.Black

            Case "PICO Line 3B 2nd Heat"
                'MsgBox("PICO Line 3B 2nd Heat")
                Update_ProcessStatus = 0
                Update_Line3B_2ndHeat_ErrorStat()

                Form1.btn3B_2ndHeat.FillColor = Color.Green
                Form1.btn3B_2ndHeat.FillColor2 = Color.LightGreen
                Form1.btn3B_2ndHeat.ForeColor = Color.Black

            Case "PICO Line 3B Trimming"
                'MsgBox("PICO Line 3B Trimming")
                Update_ProcessStatus = 0
                Update_Line3B_Trimming_ErrorStat()

                Form1.btn3B_Trimming.FillColor = Color.Green
                Form1.btn3B_Trimming.FillColor2 = Color.LightGreen
                Form1.btn3B_Trimming.ForeColor = Color.Black

            Case "PICO Line 3 Wheel Coater"
                'MsgBox("PICO Line 3B Trimming")
                Update_ProcessStatus = 0
                Update_WC_L3_ErrorStat()

                Form1.btnWC_Line3.FillColor = Color.Green
                Form1.btnWC_Line3.FillColor2 = Color.LightGreen
                Form1.btnWC_Line3.ForeColor = Color.Black

            Case "PICO Line 5 Wheel Coater"
                'MsgBox("PICO Line 3B Trimming")
                Update_ProcessStatus = 0
                Update_WC_L5_ErrorStat()

                Form1.btnWC_Line5.FillColor = Color.Green
                Form1.btnWC_Line5.FillColor2 = Color.LightGreen
                Form1.btnWC_Line5.ForeColor = Color.Black

        End Select



    End Sub

    Sub Check_LineIssue_Status()
        Dim errorMapping As New List(Of (ErrorStatus As Integer, Button As Guna.UI2.WinForms.Guna2GradientButton)) From {
    (Line3A_PreMelt_ErrorStat, Form1.btn3A_PreMelt),
    (Line3A_CLI_ErrorStat, Form1.btn3A_CLI),
    (Line3A_Glassing_ErrorStat, Form1.btn3A_Glassing),
    (Line3A_Picosine_ErrorStat, Form1.btn3A_Picosine),
    (Line3A_PinTray_ErrorStat, Form1.btn3A_PinTray),
    (Line3A_1stHeat_ErrorStat, Form1.btn3A_1stHeat),
    (Line3A_Turning_ErrorStat, Form1.btn3A_Turning),
    (Line3A_2ndHeat_ErrorStat, Form1.btn3A_2ndHeat),
    (Line3A_Trimming_ErrorStat, Form1.btn3A_Trimming),
    (Line3B_PreMelt_ErrorStat, Form1.btn3B_PreMelt), 'Starting here is for Line 3B
    (Line3B_CLI_ErrorStat, Form1.btn3B_CLI),
     (Line3B_Glassing_ErrorStat, Form1.btn3B_Glassing),
    (Line3B_Picosine_ErrorStat, Form1.btn3B_Picosine),
    (Line3B_PinTray_ErrorStat, Form1.btn3B_PinTray),
    (Line3B_1stHeat_ErrorStat, Form1.btn3B_1stHeat),
    (Line3B_Turning_ErrorStat, Form1.btn3B_Turning),
    (Line3B_2ndHeat_ErrorStat, Form1.btn3B_2ndHeat),
    (Line3B_Trimming_ErrorStat, Form1.btn3B_Trimming),
    (WheelCoater_L3_ErrorStat, Form1.btnWC_Line3), 'Starting here is for wheel coater
    (WheelCoater_L5_ErrorStat, Form1.btnWC_Line5)
}

        For Each mapping In errorMapping
            If mapping.ErrorStatus = 1 Then
                mapping.Button.FillColor = Color.Salmon
                mapping.Button.FillColor2 = Color.Red
                mapping.Button.ForeColor = Color.White
            End If
        Next
    End Sub


    '*************************** Reporting Code for Line 3A *****************************

    Sub Line3A_PreMelt_DblClick()
        Get_3A_PreMelt_Status()
        If Line3A_PreMelt_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Pre-melt"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "Pre-melt"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_CLI_DblClick()

        Get_3A_CLI_Status()
        If Line3A_CLI_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "CLI"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "CLI"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_Glassing_DblClick()

        Get_3A_Glassing_Status()
        If Line3A_Glassing_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Glassing"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "Glassing"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_Picosine_DblClick()

        Get_3A_Picosine_Status()
        If Line3A_Picosine_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Picosine"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "Picosine"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_PinTray_DblClick()

        Get_3A_PinTray_Status()
        If Line3A_PinTray_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Pin Tray"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "Pin Tray"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_1stHeat_DblClick()

        Get_3A_1stHeat_Status()
        If Line3A_1stHeat_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "1st Heat"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "1st Heat"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_Turning_DblClick()

        Get_3A_Turning_Status()
        If Line3A_Turning_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Turning"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "Turning"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_2ndHeat_DblClick()

        Get_3A_2ndHeat_Status()
        If Line3A_2ndHeat_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "2nd Heat"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "2nd Heat"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3A_Trimming_DblClick()

        Get_3A_Trimming_Status()
        If Line3A_Trimming_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Trimming"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3A"
                ResolvedReport_Form.txtProcess.Text = "Trimming"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    '*************************** Reporting Code for Line 3B *****************************

    Sub Line3B_PreMelt_DblClick()
        Get_3B_PreMelt_Status()
        If Line3B_PreMelt_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Pre-melt"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "Pre-melt"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_CLI_DblClick()
        Get_3B_CLI_Status()
        If Line3B_CLI_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "CLI"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "CLI"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_Glassing_DblClick()
        Get_3B_Glassing_Status()
        If Line3B_Glassing_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Glassing"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "Glassing"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_Picosine_DblClick()
        Get_3B_Picosine_Status()
        If Line3B_Picosine_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Picosine"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "Picosine"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_PinTray_DblClick()
        Get_3B_PinTray_Status()
        If Line3B_PinTray_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Pin Tray"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "Pin Tray"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_1stHeat_DblClick()
        Get_3B_1stHeat_Status()
        If Line3B_1stHeat_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "1st Heat"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "1st Heat"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_Turning_DblClick()
        Get_3B_Turning_Status()
        If Line3B_Turning_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Turning"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "Turning"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_2ndHeat_DblClick()
        Get_3B_2ndHeat_Status()
        If Line3B_2ndHeat_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "2nd Heat"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
                Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "2nd Heat"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line3B_Trimming_DblClick()
        Get_3B_Trimming_Status()
        If Line3B_Trimming_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Trimming"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3B"
                ResolvedReport_Form.txtProcess.Text = "Trimming"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    '*************************** Reporting Code for Wheel Coater*****************************

    Sub WC_Lin3_DblClick()
        Get_WC_L3_Status()
        If WheelCoater_L3_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3"
                IssueReport_Form.txtProcess.Text = "Wheel Coater"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 3"
                ResolvedReport_Form.txtProcess.Text = "Wheel Coater"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub WC_Lin5_DblClick()
        Get_WC_L5_Status()
        If WheelCoater_L5_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger. Operator, PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
                IssueReport_Form.txtProcess.Text = "Wheel Coater"
                IssueReport_Form.ShowDialog()

                Master_login.Close()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If

        Else
            Master_login.Label1.Text = "Please scan your finger. PO3, SPC or Technician only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                Master_login.Close()
                ResolvedReport_Form.txtLine.Text = "PICO Line 5"
                ResolvedReport_Form.txtProcess.Text = "Wheel Coater"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub
End Module

Module Query_Module

    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Downtime Monitoring System.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicodown"
    Public Dbconnection As New OleDbConnection(connString)

    Sub ConOpen()
        If Dbconnection.State = ConnectionState.Closed Then
            Dbconnection.Open()
        End If
    End Sub

    Sub ConClose()
        If Dbconnection.State = ConnectionState.Open Then
            Dbconnection.Close()
        End If
    End Sub

    Public Emails_Db As String

    Sub Get_Emails()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM Email_tb WHERE Categ = 'Emails'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Emails_Db = Data.Rows(0).Item("List").ToString
                Console.WriteLine(Emails_Db)

            Else
                MsgBox("No emails listed!", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub


    Sub Log_TimeReported()
        Dim mycommand As String

        Dim dateNtime As String = Date.Now.ToString("MMM/dd/yyyy hh:mm:ss tt")
        Dim Line_Pro As String = IssueReport_Form.txtLine.Text & " " & IssueReport_Form.txtProcess.Text
        Dim Reporter As String = Biometric_Name

        Try
            ConOpen()
            mycommand = "INSERT INTO [IssueTimeTracker_tb] ([LineProcess],[Reported_by],[Reported_time]) 
                                VALUES (@LP, @Repby, @Time)"
            Using command As New OleDbCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                command.Parameters.AddWithValue("@Repby", Reporter)
                command.Parameters.AddWithValue("@Time", dateNtime)
                command.ExecuteNonQuery()
            End Using
            ConClose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Biometric_Name As String

    Sub Log_TimeResolved()
        Try

            Dim dateNtime As String = Date.Now.ToString("MMM/dd/yyyy hh:mm:ss tt")
            Dim Line_Pro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text
            Dim Person_IC As String = Biometric_Name

            Dim query As String = "UPDATE IssueTimeTracker_tb 
                                        SET Resolved_time = @resolved, PIC = @InCharge
                                        WHERE LineProcess = @LP"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@resolved", dateNtime)
                command.Parameters.AddWithValue("@InCharge", Person_IC)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                ConOpen()
                command.ExecuteNonQuery()
                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Log_TimeDuration()
        Try

            Dim dateNtime As String = Date.Now.ToString("MMM/dd/yyyy hh:mm:ss tt")
            Dim Line_Pro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text
            Dim Person_IC As String = Biometric_Name

            Dim query As String = "UPDATE IssueTimeTracker_tb 
                                        SET Resolved_time = @resolved, Issue_Duration = @drtion, PIC = @InCharge
                                        WHERE LineProcess = @LP"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@resolved", dateNtime)
                command.Parameters.AddWithValue("@drtion", LineIssue_Duration)
                command.Parameters.AddWithValue("@InCharge", Person_IC)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                ConOpen()
                command.ExecuteNonQuery()
                ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Reported As String
    Public Resolved As String
    Public Rep_name As String

    Sub Get_Duration()
        Try
            Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM IssueTimeTracker_tb WHERE LineProcess = '" & LinePro & "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Reported = Data.Rows(0).Item("Reported_time").ToString
                Resolved = Data.Rows(0).Item("Resolved_time").ToString
                Rep_name = Data.Rows(0).Item("Reported_by").ToString
                Console.WriteLine(Reported)
                Console.WriteLine(Resolved)
                Console.WriteLine(Rep_name)

            Else
                MsgBox("No issue on the line process", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

    Sub Delete_IssueTracker()
        Dim mycommand As String
        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        ConOpen()
        mycommand = "Delete from IssueTimeTracker_tb Where LineProcess =@LP "
        Dim cmd As OleDbCommand = New OleDbCommand(mycommand, Dbconnection)
        Try
            cmd.Parameters.AddWithValue("@LP", LinePro)
            cmd.ExecuteNonQuery()
            ConClose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Module

Module Saving_Module

    Public History As String

    Public Year As String = Date.Now.ToString("yyyy")
    Public Month As String = Date.Now.ToString("MMMM")
    Public DateToday As String = Date.Now.ToString("dd")
    Public FolderPath As String = "C:\Backup\PICO Line 3 Downtime History\" & Year & "\" & Month & "\PICO Line 3 History.csv "

    Sub CheckPath()
        Dim dateNtime As String = Date.Now.ToString("MM-dd-yy HH_mm")

        Try

            ' Ensure the directory exists or create it
            Dim directoryPath As String = Path.GetDirectoryName(FolderPath)
            If Not Directory.Exists(directoryPath) Then
                Directory.CreateDirectory(directoryPath)
            End If

            SaveHistory()

        Catch ex As Exception
            MessageBox.Show("Error copying data: " & ex.Message)
        Finally

        End Try
    End Sub

    Sub SaveHistory()

        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mmtt")

        History = vbCrLf & """Line Process""" & "," & """Reported by""" & "," & """Reported Time""" & "," & """Resolved Time""" & "," & """Duration(hrs)""" & "," & """Cause""" & "," & """Person in Charge""" & vbCrLf
        History = History & LinePro & "," & Rep_name & "," & Reported & "," & Resolved & "," & Totalhrs & "," & ResolvedReport_Form.txtCause.Text & "," & Biometric_Name & vbCrLf

        My.Computer.FileSystem.WriteAllText(FolderPath, History, True)
    End Sub

End Module