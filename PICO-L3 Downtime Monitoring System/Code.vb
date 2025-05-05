Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data.SqlClient
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

    Public Onehr_Downtime_Stat As String
    Public Twohrs_Downtime_Stat As String
    Public Threehrs_Downtime_Stat As String

    Public Update_HourStatus As String


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


    '********************************* < For Escalation > ***************************
    '--------------------------------- < Get Hour Value > ---------------------------

    Sub Get_Onehr_Downtime_Stat()
        Dim HoursStat As String = System.Configuration.ConfigurationManager.AppSettings("1hr_Stat")
        Console.WriteLine(HoursStat)

        Onehr_Downtime_Stat = HoursStat
    End Sub

    Sub Get_Twohrs_Downtime_Stat()
        Dim HoursStat As String = System.Configuration.ConfigurationManager.AppSettings("2hr_Stat")
        Console.WriteLine(HoursStat)

        Twohrs_Downtime_Stat = HoursStat
    End Sub

    Sub Get_Threehrs_Downtime_Stat()
        Dim HoursStat As String = System.Configuration.ConfigurationManager.AppSettings("3hr_Stat")
        Console.WriteLine(HoursStat)

        Threehrs_Downtime_Stat = HoursStat
    End Sub

    '--------------------------------- < Udpdate Hour Value > ---------------------------
    Sub Update_Onehr_Downtime_Stat()
        config.AppSettings.Settings("1hr_Stat").Value = Update_HourStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Twohrs_Downtime_Stat()
        config.AppSettings.Settings("2hr_Stat").Value = Update_HourStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Threehrs_Downtime_Stat()
        config.AppSettings.Settings("3hr_Stat").Value = Update_HourStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub


    '==================================< GET LINE 5 PROCESS STATUS >===========================

    Public Line5_PreMelt_ErrorStat As Integer
    Public Line5_CLI_ErrorStat As Integer
    Public Line5_WireThreading_ErrorStat As Integer
    Public Line5_1stHeat_ErrorStat As Integer
    Public Line5_Sanding_ErrorStat As Integer
    Public Line5_2ndHeat_ErrorStat As Integer
    Public Line5_Assembly_ErrorStat As Integer

    Sub Get_Line5_PreMelt_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_PreMelt_Stat")
        Console.WriteLine(LineProStatus)

        Line5_PreMelt_ErrorStat = LineProStatus
    End Sub

    Sub Get_Line5_CLI_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_CLI_Stat")
        Console.WriteLine(LineProStatus)

        Line5_CLI_ErrorStat = LineProStatus
    End Sub

    Sub Get_Line5_WireThreading_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_WireThreading_Stat")
        Console.WriteLine(LineProStatus)

        Line5_WireThreading_ErrorStat = LineProStatus
    End Sub

    Sub Get_Line5_1stHeat_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_1stHeat_Stat")
        Console.WriteLine(LineProStatus)

        Line5_1stHeat_ErrorStat = LineProStatus
    End Sub

    Sub Get_Line5_Sanding_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_Sanding_Stat")
        Console.WriteLine(LineProStatus)

        Line5_Sanding_ErrorStat = LineProStatus
    End Sub

    Sub Get_Line5_2ndHeat_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_2ndHeat_Stat")
        Console.WriteLine(LineProStatus)

        Line5_2ndHeat_ErrorStat = LineProStatus
    End Sub

    Sub Get_Line5_Assembly_Status()
        Dim LineProStatus As String = System.Configuration.ConfigurationManager.AppSettings("Line5_Assembly_Stat")
        Console.WriteLine(LineProStatus)

        Line5_Assembly_ErrorStat = LineProStatus
    End Sub

    '==================================< UPDATE LINE 5 PROCESS STATUS >===========================
    Sub Update_Line5_PreMelt_ErrorStat()
        config.AppSettings.Settings("Line5_PreMelt_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line5_CLI_ErrorStat()
        config.AppSettings.Settings("Line5_CLI_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line5_WireThreading_ErrorStat()
        config.AppSettings.Settings("Line5_WireThreading_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line5_1stHeat_ErrorStat()
        config.AppSettings.Settings("Line5_1stHeat_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line5_Sanding_ErrorStat()
        config.AppSettings.Settings("Line5_Sanding_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line5_2ndHeat_ErrorStat()
        config.AppSettings.Settings("Line5_2ndHeat_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub Update_Line5_Assembly_ErrorStat()
        config.AppSettings.Settings("Line5_Assembly_Stat").Value = Update_ProcessStatus ' Update 
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

End Module

Module SendEmail_Module
    Public Email As MailMessage
    Public Acknowledge As Boolean = False

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

        Email.From = New MailAddress("PICO_Dowtime@littelfuse.com")
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
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>REPORTED BY:</td>
                              <td>" & Biometric_Name & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>PROCESS:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red;text-align: center;'>ISSUE:</td>
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
        SQL_Report_LineStat() ' Update stat in SQL Server database to notify techs

        'Form1.Timer1hour.Enabled = True
        'Form1.Timer2hours.Enabled = True
        'Form1.Timer3hours.Enabled = True
        IssueReport_Form.Close()

    End Sub

    Public LineIssue_Duration As String
    Public Totalhrs As Decimal
    Public Check_Line_For_Send As String

    Sub Send_DowntimeRep_Email()

        Check_Line_For_Send = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        Check_Whos_Recipient() 'Get the list of email from offline database based on Escalation Plan

        'Get_Emails() 'Get the list of email from offline database
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

        Dim EmailAdd As String = Escalation_Level_Recipient
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICO_Dowtime@littelfuse.com")
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
                              <td style='color: white; font-weight: bold; background-color: Green; text-align: center;'>PROCESS:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green; text-align: center;'>DURATION:</td>
                              <td>" & DT_Duration & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>CAUSE:</td>
                              <td>" & Cause & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>STATUS:</td>
                              <td>" & Status & "</td>
                            </tr>
                               <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>PIC:</td>
                              <td>" & Biometric_Name & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Green;text-align: center;'>ACTION TAKEN:</td>
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
        SQL_Resolved_LineStat() ' Update stat in SQL Server database to notify techs
        Log_TimeDuration() ' Log the duration time

        CheckPath() 'save history in csv file

        Delete_IssueTracker()
        ResolvedReport_Form.Close()

    End Sub

    Sub Send_DowntimeRep_OnGoing_Email()

        Check_Line_For_Send = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        Check_Whos_Recipient() 'Get the list of email from offline database based on Escalation Plan

        'Get_Emails() 'Get the list of email from offline database
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

        Dim EmailAdd As String = Escalation_Level_Recipient
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICO_Dowtime@littelfuse.com")
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
                              <td style='color: black; font-weight: bold; background-color: gold; text-align: center;'>PROCESS:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold; text-align: center;'>DURATION:</td>
                              <td>" & DT_Duration & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>CAUSE:</td>
                              <td>" & Cause & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>STATUS:</td>
                              <td>" & Status & "</td>
                            </tr>
                               <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>PIC:</td>
                              <td>" & Biometric_Name & "</td>
                            </tr>
                            <tr>
                              <td style='color: black; font-weight: bold; background-color: gold;text-align: center;'>ACTION TAKEN:</td>
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

    '===============================< For Escalation Plan >================================
    Sub Send_Issue_Email_OneHour()

        Get_1hour_Emails()

        Dim Process As String = Escalation_Process
        Dim Line As String = Escalation_Line
        Dim Issue As String = Escalation_Issue
        Dim Reportby As String = Escalation_ReportedBy
        Dim EmailAdd As String = OneHr_Emails_Db
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICO_Dowtime@littelfuse.com")
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
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>REPORTED BY:</td>
                              <td>" & Reportby & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>PROCESS:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red;text-align: center;'>ISSUE:</td>
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

        Update_HourStatus = "True"
        Update_Onehr_Downtime_Stat()


    End Sub

    Sub Send_Issue_Email_TwoHours()

        Get_2hours_Emails()

        Dim Process As String = Escalation_Process_Two
        Dim Line As String = Escalation_Line_Two
        Dim Issue As String = Escalation_Issue_Two
        Dim Reportby As String = Escalation_ReportedBy_Two
        Dim EmailAdd As String = TwoHr_Emails_Db
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICO_Dowtime@littelfuse.com")
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
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>REPORTED BY:</td>
                              <td>" & Reportby & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>PROCESS:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red;text-align: center;'>ISSUE:</td>
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

        Update_HourStatus = "True"
        Update_Twohrs_Downtime_Stat()


    End Sub

    Sub Send_Issue_Email_ThreeHours()

        Get_3hours_Emails()

        Dim Process As String = Escalation_Process_Three
        Dim Line As String = Escalation_Line_Three
        Dim Issue As String = Escalation_Issue_Three
        Dim Reportby As String = Escalation_ReportedBy_Three
        Dim EmailAdd As String = ThreeHr_Emails_Db
        Dim Recipients As String() = EmailAdd.Split(";"c)
        Dim SMTP As New SmtpClient

        Email = New MailMessage

        For Each Reciever As String In Recipients
            Email.To.Add(New MailAddress(Reciever.ToString()))
        Next

        'add this at table style for simple table
        'border-collapse: collapse;

        Email.From = New MailAddress("PICO_Dowtime@littelfuse.com")
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
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>REPORTED BY:</td>
                              <td>" & Reportby & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red; text-align: center;'>PROCESS:</td>
                              <td>" & Process & "</td>
                            </tr>
                            <tr>
                              <td style='color: white; font-weight: bold; background-color: Red;text-align: center;'>ISSUE:</td>
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

        Update_HourStatus = "True"
        Update_Threehrs_Downtime_Stat()


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

        Get_Line5_PreMelt_Status()
        Get_Line5_CLI_Status()
        Get_Line5_WireThreading_Status()
        Get_Line5_1stHeat_Status()
        Get_Line5_Sanding_Status()
        Get_Line5_2ndHeat_Status()
        Get_Line5_Assembly_Status()

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


                '==========================< FOR LINE 5 >==============================

            Case "PICO Line 5 Pre-Melt"
                Update_ProcessStatus = 1
                Update_Line5_PreMelt_ErrorStat()

                Form1.btnLine5_PreMelt.FillColor = Color.Salmon
                Form1.btnLine5_PreMelt.FillColor2 = Color.Red
                Form1.btnLine5_PreMelt.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 5 CLI"
                Update_ProcessStatus = 1
                Update_Line5_CLI_ErrorStat()

                Form1.btnLine5_CLI.FillColor = Color.Salmon
                Form1.btnLine5_CLI.FillColor2 = Color.Red
                Form1.btnLine5_CLI.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 5 Wire Threading"
                Update_ProcessStatus = 1
                Update_Line5_WireThreading_ErrorStat()

                Form1.btnLine5_WireThread.FillColor = Color.Salmon
                Form1.btnLine5_WireThread.FillColor2 = Color.Red
                Form1.btnLine5_WireThread.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 5 1st Heat"
                Update_ProcessStatus = 1
                Update_Line5_1stHeat_ErrorStat()

                Form1.btnLine5_1stHeat.FillColor = Color.Salmon
                Form1.btnLine5_1stHeat.FillColor2 = Color.Red
                Form1.btnLine5_1stHeat.ForeColor = Color.White

                Log_TimeReported()


            Case "PICO Line 5 Sanding"
                Update_ProcessStatus = 1
                Update_Line5_Sanding_ErrorStat()

                Form1.btnLine5_Sanding.FillColor = Color.Salmon
                Form1.btnLine5_Sanding.FillColor2 = Color.Red
                Form1.btnLine5_Sanding.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 5 2nd Heat"
                Update_ProcessStatus = 1
                Update_Line5_2ndHeat_ErrorStat()

                Form1.btnLine5_2ndHeat.FillColor = Color.Salmon
                Form1.btnLine5_2ndHeat.FillColor2 = Color.Red
                Form1.btnLine5_2ndHeat.ForeColor = Color.White

                Log_TimeReported()

            Case "PICO Line 5 Assembly"
                Update_ProcessStatus = 1
                Update_Line5_Assembly_ErrorStat()

                Form1.btnLine5_Assembly.FillColor = Color.Salmon
                Form1.btnLine5_Assembly.FillColor2 = Color.Red
                Form1.btnLine5_Assembly.ForeColor = Color.White

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

            Case "PICO Line 3A Assembly"
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

            Case "PICO Line 3B Assembly"
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

                '==========================< FOR LINE 5 >==============================

            Case "PICO Line 5 Pre-Melt"
                Update_ProcessStatus = 0
                Update_Line5_PreMelt_ErrorStat()

                Form1.btnLine5_PreMelt.FillColor = Color.Green
                Form1.btnLine5_PreMelt.FillColor2 = Color.LightGreen
                Form1.btnLine5_PreMelt.ForeColor = Color.Black



            Case "PICO Line 5 CLI"
                Update_ProcessStatus = 0
                Update_Line5_CLI_ErrorStat()

                Form1.btnLine5_CLI.FillColor = Color.Green
                Form1.btnLine5_CLI.FillColor2 = Color.LightGreen
                Form1.btnLine5_CLI.ForeColor = Color.Black



            Case "PICO Line 5 Wire Threading"
                Update_ProcessStatus = 0
                Update_Line5_WireThreading_ErrorStat()

                Form1.btnLine5_WireThread.FillColor = Color.Green
                Form1.btnLine5_WireThread.FillColor2 = Color.LightGreen
                Form1.btnLine5_WireThread.ForeColor = Color.Black



            Case "PICO Line 5 1st Heat"
                Update_ProcessStatus = 0
                Update_Line5_1stHeat_ErrorStat()

                Form1.btnLine5_1stHeat.FillColor = Color.Green
                Form1.btnLine5_1stHeat.FillColor2 = Color.LightGreen
                Form1.btnLine5_1stHeat.ForeColor = Color.Black




            Case "PICO Line 5 Sanding"
                Update_ProcessStatus = 0
                Update_Line5_Sanding_ErrorStat()

                Form1.btnLine5_Sanding.FillColor = Color.Green
                Form1.btnLine5_Sanding.FillColor2 = Color.LightGreen
                Form1.btnLine5_Sanding.ForeColor = Color.Black



            Case "PICO Line 5 2nd Heat"
                Update_ProcessStatus = 0
                Update_Line5_2ndHeat_ErrorStat()

                Form1.btnLine5_2ndHeat.FillColor = Color.Green
                Form1.btnLine5_2ndHeat.FillColor2 = Color.LightGreen
                Form1.btnLine5_2ndHeat.ForeColor = Color.Black



            Case "PICO Line 5 Assembly"
                Update_ProcessStatus = 0
                Update_Line5_Assembly_ErrorStat()

                Form1.btnLine5_Assembly.FillColor = Color.Green
                Form1.btnLine5_Assembly.FillColor2 = Color.LightGreen
                Form1.btnLine5_Assembly.ForeColor = Color.Black



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
    (WheelCoater_L5_ErrorStat, Form1.btnWC_Line5),
     (Line5_PreMelt_ErrorStat, Form1.btnLine5_PreMelt), 'Starting here is for Line 5
    (Line5_CLI_ErrorStat, Form1.btnLine5_CLI),
     (Line5_WireThreading_ErrorStat, Form1.btnLine5_WireThread),
    (Line5_1stHeat_ErrorStat, Form1.btnLine5_1stHeat),
    (Line5_Sanding_ErrorStat, Form1.btnLine5_Sanding),
    (Line5_2ndHeat_ErrorStat, Form1.btnLine5_2ndHeat),
    (Line5_Assembly_ErrorStat, Form1.btnLine5_Assembly)
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3A"
                IssueReport_Form.txtProcess.Text = "Assembly"
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
                ResolvedReport_Form.txtProcess.Text = "Assembly"
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 3B"
                IssueReport_Form.txtProcess.Text = "Assembly"
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
                ResolvedReport_Form.txtProcess.Text = "Assembly"
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
            Master_login.Label1.Text = "Please scan your finger."
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
            Master_login.Label1.Text = "Please scan your finger."
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


    '*************************** Reporting Code for Line 5 *****************************

    Sub Line5_PreMelt_Clicked()
        Get_Line5_PreMelt_Status()
        If Line5_PreMelt_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
                IssueReport_Form.txtProcess.Text = "Pre-Melt"
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
                ResolvedReport_Form.txtProcess.Text = "Pre-Melt"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line5_CLI_Clicked()
        Get_Line5_CLI_Status()
        If Line5_CLI_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
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
                ResolvedReport_Form.txtLine.Text = "PICO Line 5"
                ResolvedReport_Form.txtProcess.Text = "CLI"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line5_WireThreading_Clicked()
        Get_Line5_WireThreading_Status()
        If Line5_WireThreading_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
                IssueReport_Form.txtProcess.Text = "Wire Threading"
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
                ResolvedReport_Form.txtProcess.Text = "Wire Threading"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line5_1stHeat_Clicked()
        Get_Line5_1stHeat_Status()
        If Line5_1stHeat_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
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
                ResolvedReport_Form.txtLine.Text = "PICO Line 5"
                ResolvedReport_Form.txtProcess.Text = "1st Heat"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line5_Sanding_Clicked()
        Get_Line5_Sanding_Status()
        If Line5_Sanding_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
                IssueReport_Form.txtProcess.Text = "Sanding"
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
                ResolvedReport_Form.txtProcess.Text = "Sanding"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line5_2ndHeat_Clicked()
        Get_Line5_2ndHeat_Status()
        If Line5_2ndHeat_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
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
                ResolvedReport_Form.txtLine.Text = "PICO Line 5"
                ResolvedReport_Form.txtProcess.Text = "2nd Heat"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    Sub Line5_Assembly_Clicked()
        Get_Line5_Assembly_Status()
        If Line5_Assembly_ErrorStat = 0 Then
            Master_login.Label1.Text = "Please scan your finger."
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "Operator" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
                IssueReport_Form.txtLine.Text = "PICO Line 5"
                IssueReport_Form.txtProcess.Text = "Assembly"
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
                ResolvedReport_Form.txtProcess.Text = "Assembly"
                ResolvedReport_Form.ShowDialog()
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End If
    End Sub

    '***************************< Check Email Recipient >*****************************
    Public Escalation_Level_Recipient As String

    Sub Email_Escalation_Recipient()
        If Check_One_For_Send = 1 And Check_Two_For_Send = 0 And Check_Three_For_Send = 0 Then
            Escalation_Level_Recipient = Emails_Db & "; " & OneHr_Emails_Db

        ElseIf Check_One_For_Send = 1 And Check_Two_For_Send = 1 And Check_Three_For_Send = 0 Then
            Escalation_Level_Recipient = Emails_Db & "; " & OneHr_Emails_Db & "; " & TwoHr_Emails_Db

        ElseIf Check_One_For_Send = 1 And Check_Two_For_Send = 1 And Check_Three_For_Send = 1 Then
            Escalation_Level_Recipient = Emails_Db & "; " & OneHr_Emails_Db & "; " & TwoHr_Emails_Db & "; " & ThreeHr_Emails_Db

        Else

            Escalation_Level_Recipient = Emails_Db
        End If

        Console.WriteLine("Escalation Plan email: " & Escalation_Level_Recipient)
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

            MyData = "SELECT * FROM Email_tb WHERE Categ = '30mins'"
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
        Dim Line As String = IssueReport_Form.txtLine.Text
        Dim Pro As String = IssueReport_Form.txtProcess.Text
        Dim Issue As String = IssueReport_Form.cboIssue.Text
        Dim Line_Pro As String = IssueReport_Form.txtLine.Text & " " & IssueReport_Form.txtProcess.Text
        Dim Reporter As String = Biometric_Name

        Dim Init As Integer = 0

        Try
            ConOpen()
            mycommand = "INSERT INTO [IssueTimeTracker_tb] ([LineProcess],[Reported_by],[Reported_time],[Line],[Process],[Issue],
                         [One_Hour],[Two_Hours],[Three_Hours])
                         VALUES (@LP, @Repby, @Time, @Lne, @Proc, @Iss, @One, @Two, @Three)"
            Using command As New OleDbCommand(mycommand, Dbconnection)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                command.Parameters.AddWithValue("@Repby", Reporter)
                command.Parameters.AddWithValue("@Time", dateNtime)

                command.Parameters.AddWithValue("@Lne", Line)
                command.Parameters.AddWithValue("@Proc", Pro)
                command.Parameters.AddWithValue("@Iss", Issue)

                command.Parameters.AddWithValue("@One", Init)
                command.Parameters.AddWithValue("@Two", Init)
                command.Parameters.AddWithValue("@Three", Init)
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


    '=================================< For Escalation Plan >=================================

    Public OneHr_Emails_Db As String
    Public TwoHr_Emails_Db As String
    Public ThreeHr_Emails_Db As String

    Sub Get_1hour_Emails()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM Email_tb WHERE Categ = '1hour'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                OneHr_Emails_Db = Data.Rows(0).Item("List").ToString
                Console.WriteLine(OneHr_Emails_Db)

            Else
                MsgBox("No emails listed!", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            'ConClose()
        End Try
    End Sub

    Sub Get_2hours_Emails()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM Email_tb WHERE Categ = '2hours'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                TwoHr_Emails_Db = Data.Rows(0).Item("List").ToString
                Console.WriteLine(TwoHr_Emails_Db)

            Else
                MsgBox("No emails listed!", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            'ConClose()
        End Try
    End Sub

    Sub Get_3hours_Emails()
        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM Email_tb WHERE Categ = '3hours'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                ThreeHr_Emails_Db = Data.Rows(0).Item("List").ToString
                Console.WriteLine(ThreeHr_Emails_Db)

            Else
                MsgBox("No emails listed!", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            'ConClose()
        End Try
    End Sub


    Public Escalation_Line As String
    Public Escalation_Process As String
    Public Escalation_Issue As String
    Public Escalation_ReportedBy As String
    Public Escalation_Send_Done As Integer

    Public Escalation_Line_Two As String
    Public Escalation_Process_Two As String
    Public Escalation_Issue_Two As String
    Public Escalation_ReportedBy_Two As String
    Public Escalation_Send_Done_Two As Integer

    Public Escalation_Line_Three As String
    Public Escalation_Process_Three As String
    Public Escalation_Issue_Three As String
    Public Escalation_ReportedBy_Three As String
    Public Escalation_Send_Done_Three As Integer


    Sub Check_1hour_Down()
        Dim query As String = "SELECT Reported_by, Reported_time, Line, Process, Issue, One_Hour FROM IssueTimeTracker_tb"

        Using cmd As New OleDbCommand(query, Dbconnection)
            ConOpen()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim reportedTime As DateTime = Convert.ToDateTime(reader("Reported_time"))
                Dim timeDifference As TimeSpan = DateTime.Now - reportedTime

                If timeDifference.TotalMinutes > 59 AndAlso timeDifference.TotalMinutes < 119 Then
                    Escalation_Line = reader("Line").ToString()
                    Escalation_Process = reader("Process").ToString()
                    Escalation_Issue = reader("Issue").ToString()
                    Escalation_ReportedBy = reader("Reported_by").ToString()
                    Escalation_Send_Done = reader("One_Hour")

                    'Dim message As String = $"Error: Time difference is between 59 and 119 minutes.
                    '                          Line: {Escalation_Line}
                    '                          Process: {Escalation_Process}
                    '                          Issue: {Escalation_Issue}
                    '                          Report By: {Escalation_ReportedBy}"

                    'MessageBox.Show(message, "Time Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Escalation_Send_Done = 0 Then
                        Send_Issue_Email_OneHour()
                        OneHour_Send_Done()
                    End If
                End If
            End While
        End Using
        ConClose()
    End Sub

    Sub Check_2hour_Down()
        Dim query As String = "SELECT Reported_by, Reported_time, Line, Process, Issue, Two_Hours FROM IssueTimeTracker_tb"

        Using cmd As New OleDbCommand(query, Dbconnection)
            ConOpen()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim reportedTime As DateTime = Convert.ToDateTime(reader("Reported_time"))
                Dim timeDifference As TimeSpan = DateTime.Now - reportedTime

                If timeDifference.TotalMinutes > 119 AndAlso timeDifference.TotalMinutes < 179 Then
                    Escalation_Line_Two = reader("Line").ToString()
                    Escalation_Process_Two = reader("Process").ToString()
                    Escalation_Issue_Two = reader("Issue").ToString()
                    Escalation_ReportedBy_Two = reader("Reported_by").ToString()
                    Escalation_Send_Done_Two = reader("Two_Hours")

                    'Dim message As String = $"Error: Time difference is between 59 and 119 minutes.
                    '                          Line: {Escalation_Line_Two}
                    '                          Process: {Escalation_Process_Two}
                    '                          Issue: {Escalation_Issue_Two}
                    '                          Report By: {Escalation_ReportedBy_Two}"

                    'MessageBox.Show(message, "Time Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Escalation_Send_Done_Two = 0 Then
                        Send_Issue_Email_TwoHours()
                        TwoHours_Send_Done()
                    End If
                Else
                    'Console.WriteLine("Error")
                End If
            End While
        End Using
        ConClose()
    End Sub

    Sub Check_3hour_Down()
        Dim query As String = "SELECT Reported_by, Reported_time, Line, Process, Issue, Three_Hours FROM IssueTimeTracker_tb"

        Using cmd As New OleDbCommand(query, Dbconnection)
            ConOpen()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim reportedTime As DateTime = Convert.ToDateTime(reader("Reported_time"))
                Dim timeDifference As TimeSpan = DateTime.Now - reportedTime

                If timeDifference.TotalMinutes > 179 AndAlso timeDifference.TotalMinutes < 240 Then
                    Escalation_Line_Three = reader("Line").ToString()
                    Escalation_Process_Three = reader("Process").ToString()
                    Escalation_Issue_Three = reader("Issue").ToString()
                    Escalation_ReportedBy_Three = reader("Reported_by").ToString()
                    Escalation_Send_Done_Three = reader("Three_Hours").ToString()

                    'Dim message As String = $"Error: Time difference is between 59 and 119 minutes.
                    '                          Line: {Escalation_Line_Three}
                    '                          Process: {Escalation_Process_Three}
                    '                          Issue: {Escalation_Issue_Three}
                    '                          Report By: {Escalation_ReportedBy_Three}"

                    'MessageBox.Show(message, "Time Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If Escalation_Send_Done_Three = 0 Then
                        Send_Issue_Email_ThreeHours()
                        ThreeHours_Send_Done()
                    End If
                Else
                        'Console.WriteLine("Error")
                    End If

            End While
        End Using
        ConClose()
    End Sub


    Sub OneHour_Send_Done()
        Try
            Dim Send As Integer = 1
            Dim LinePro As String = Escalation_Line & " " & Escalation_Process
            Dim query As String = "UPDATE IssueTimeTracker_tb 
                                        SET One_Hour = @Send
                                        WHERE LineProcess = @LP"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Send", Send)
                command.Parameters.AddWithValue("@LP", LinePro)
                ConOpen()
                command.ExecuteNonQuery()
                'ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub TwoHours_Send_Done()
        Try
            Dim Send As Integer = 1
            Dim LinePro As String = Escalation_Line_Two & " " & Escalation_Process_Two
            Dim query As String = "UPDATE IssueTimeTracker_tb 
                                        SET Two_Hours = @Send
                                        WHERE LineProcess = @LP"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Send", Send)
                command.Parameters.AddWithValue("@LP", LinePro)
                ConOpen()
                command.ExecuteNonQuery()
                'ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub ThreeHours_Send_Done()
        Try
            Dim Send As Integer = 1
            Dim LinePro As String = Escalation_Line_Three & " " & Escalation_Process_Three
            Dim query As String = "UPDATE IssueTimeTracker_tb 
                                        SET Three_Hours = @Send
                                        WHERE LineProcess = @LP"

            Using command As New OleDbCommand(query, Dbconnection)
                command.Parameters.AddWithValue("@Send", Send)
                command.Parameters.AddWithValue("@LP", LinePro)
                ConOpen()
                command.ExecuteNonQuery()
                'ConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Public Check_One_For_Send As Integer
    Public Check_Two_For_Send As Integer
    Public Check_Three_For_Send As Integer

    Sub Check_Whos_Recipient()

        Get_Emails()
        Get_1hour_Emails()
        Get_2hours_Emails()
        Get_3hours_Emails()

        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            ConOpen()

            MyData = "SELECT * FROM IssueTimeTracker_tb WHERE LineProcess = '" & Check_Line_For_Send & "'"
            cmd.Connection = Dbconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                Check_One_For_Send = Data.Rows(0).Item("One_Hour")
                Check_Two_For_Send = Data.Rows(0).Item("Two_Hours")
                Check_Three_For_Send = Data.Rows(0).Item("Three_Hours")

                Console.WriteLine("One Hour: " & Check_One_For_Send)
                Console.WriteLine("Two Hours: " & Check_Two_For_Send)
                Console.WriteLine("Three Hours: " & Check_Three_For_Send)

                Email_Escalation_Recipient()

            Else
                'MsgBox("No emails listed!", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            ConClose()
        End Try
    End Sub

End Module

Module SQL_Server_Query_Module

    'Data Source=BTGCATAP5Y3JDK3;Initial Catalog=PICO Diagonal;Integrated Security=True;TrustServerCertificate=True
    'Data Source=BTMESSQLPROD;Initial Catalog=LFPHPICO;Persist Security Info=True;User ID=MESACCOUNT;Password=superfuse;TrustServerCertificate=True

    Public SQLconnString As String = "Data Source=BTMESSQLPROD;Initial Catalog=LFPHPICO;Persist Security Info=True;User ID=MESACCOUNT;Password=superfuse;TrustServerCertificate=True"
    Public SQLDbconnection As New SqlConnection(SQLconnString)

    Sub SQLConOpen()
        If SQLDbconnection.State = ConnectionState.Closed Then
            SQLDbconnection.Open()
        End If
    End Sub

    Sub SQLConClose()
        If SQLDbconnection.State = ConnectionState.Open Then
            SQLDbconnection.Close()
        End If
    End Sub

    'Public DownLines As String
    Sub SQL_Report_LineStat()

        Try

            Dim Line_Pro As String = IssueReport_Form.txtLine.Text & " " & IssueReport_Form.txtProcess.Text
            Dim query As String = "UPDATE PICO_DT_L3_Sta_tb 
                                        SET Status = @ProStat
                                        WHERE LineProcess = @LP"

            Using command As New SqlCommand(query, SQLDbconnection)
                command.Parameters.AddWithValue("@ProStat", Update_ProcessStatus)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                SQLConOpen()
                command.ExecuteNonQuery()
                SQLConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub SQL_Resolved_LineStat()

        Try

            Dim Line_Pro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text
            Dim query As String = "UPDATE PICO_DT_L3_Sta_tb 
                                        SET Status = @ProStat
                                        WHERE LineProcess = @LP"

            Using command As New SqlCommand(query, SQLDbconnection)
                command.Parameters.AddWithValue("@ProStat", Update_ProcessStatus)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                SQLConOpen()
                command.ExecuteNonQuery()
                SQLConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub SQL_Ongoing_LineStat()

        Try
            Dim Ongoing_Stat As Integer = 2

            Dim Line_Pro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text
            Dim query As String = "UPDATE PICO_DT_L3_Sta_tb 
                                        SET Status = @ProStat
                                        WHERE LineProcess = @LP"

            Using command As New SqlCommand(query, SQLDbconnection)
                command.Parameters.AddWithValue("@ProStat", Ongoing_Stat)
                command.Parameters.AddWithValue("@LP", Line_Pro)
                SQLConOpen()
                command.ExecuteNonQuery()
                SQLConClose()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Module

Module Saving_Module
    'I:\Dept_Pico\PICO Process Engineering\20. Sheila\Reference Tables for PowerBI Report\PICO Line 3 Downtime History\" & Year & "\" & Month & "\PICO Line 3 History.csv
    'C:\Backup\PICO Line 3 Downtime History\" & Year & "\" & Month & "\PICO Line 3 History.csv
    '\\btfile001\data\Dept_Pico\PICO Downtime Alarm System\" & Year & "\" & Month & "\PICO Line 3 History.csv
    Public History As String

    Public Year As String = Date.Now.ToString("yyyy")
    Public Month As String = Date.Now.ToString("MMMM")
    Public DateToday As String = Date.Now.ToString("dd")
    Public FolderPath As String '= "\\btfile001\data\Dept_Pico\PICO Downtime Alarm System\" & Year & "\" & Month & "\PICO Line 3 History.csv"

    Public Function IsCSVFileEmpty(filePath As String) As Boolean
        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read the entire file content as a string
            Dim fileContent As String = File.ReadAllText(filePath)
            ' Check if the file content contains any non-whitespace characters
            Return String.IsNullOrWhiteSpace(fileContent)
        Else
            ' File doesn't exist, so it's considered empty
            Return True
        End If
    End Function

    Sub CheckPath()
        Dim dateNtime As String = Date.Now.ToString("MM-dd-yy HH_mm")

        Select Case ResolvedReport_Form.txtLine.Text
            Case "PICO Line 3A"
                FolderPath = "\\btfile001\data\Dept_Pico\PICO Downtime Alarm System\" & Year & "\" & Month & "\PICO Line 3 History.csv"

            Case "PICO Line 3B"
                FolderPath = "\\btfile001\data\Dept_Pico\PICO Downtime Alarm System\" & Year & "\" & Month & "\PICO Line 3 History.csv"

            Case "PICO Line 5"
                FolderPath = "\\btfile001\data\Dept_Pico\PICO Downtime Alarm System\" & Year & "\" & Month & "\PICO Line 5 History.csv"

        End Select

        Try

            ' Ensure the directory exists or create it
            Dim directoryPath As String = Path.GetDirectoryName(FolderPath)
            If Not Directory.Exists(directoryPath) Then
                Directory.CreateDirectory(directoryPath)
            End If

            'SaveHistory()
            CheckCSV() ' 

        Catch ex As Exception
            MessageBox.Show("Error copying data: " & ex.Message)
        Finally

        End Try
    End Sub

    Sub SaveHistory()

        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mmtt")

        History = """Line""" & "," & """Process""" & "," & """Reported by""" & "," & """Reported Time""" & "," & """Resolved Time""" & "," & """Duration(hrs)""" & "," & """Cause""" & "," & """Action Taken""" & "," & """Person in Charge""" & vbCrLf
        History = History & ResolvedReport_Form.txtLine.Text & "," & ResolvedReport_Form.txtProcess.Text & "," & Rep_name & "," & Reported & "," & Resolved & "," & Totalhrs & "," & ResolvedReport_Form.txtCause.Text & "," & ResolvedReport_Form.txtNextStep.Text & "," & Biometric_Name & vbCrLf

        My.Computer.FileSystem.WriteAllText(FolderPath, History, True)
    End Sub

    Sub SaveHistory_NoHeader()

        Dim LinePro As String = ResolvedReport_Form.txtLine.Text & " " & ResolvedReport_Form.txtProcess.Text

        Dim dateNtime As String = Date.Now.ToString("MM/dd/yyyy hh:mmtt")

        'History = vbCrLf & """Line Process""" & "," & """Reported by""" & "," & """Reported Time""" & "," & """Resolved Time""" & "," & """Duration(hrs)""" & "," & """Cause""" & "," & """Person in Charge""" & vbCrLf
        History = ResolvedReport_Form.txtLine.Text & "," & ResolvedReport_Form.txtProcess.Text & "," & Rep_name & "," & Reported & "," & Resolved & "," & Totalhrs & "," & ResolvedReport_Form.txtCause.Text & "," & ResolvedReport_Form.txtNextStep.Text & "," & Biometric_Name & vbCrLf

        My.Computer.FileSystem.WriteAllText(FolderPath, History, True)
    End Sub

    Sub CheckCSV()
        Dim isFileEmpty As Boolean = IsCSVFileEmpty(FolderPath)
        If isFileEmpty Then
            SaveHistory()
        Else
            'MsgBox("The file is not empty!", MsgBoxStyle.Critical)
            SaveHistory_NoHeader()
        End If
    End Sub

End Module
