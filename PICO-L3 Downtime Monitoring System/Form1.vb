Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'btn3A_PreMelt.FillColor = Color.Salmon
        'btn3A_PreMelt.FillColor2 = Color.Red
        'btn3A_PreMelt.ForeColor = Color.White

        Timer1hour.Enabled = True
        Timer2hours.Enabled = True
        Timer3hours.Enabled = True

        GetAll_Line_Process_Status()
        Check_LineIssue_Status()
    End Sub

    '******************** PICO LINE 3A *************************

    'Private Sub btn3A_PreMelt_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_PreMelt.DoubleClick
    '    Line3A_PreMelt_DblClick()
    'End Sub

    'Private Sub btn3A_CLI_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_CLI.DoubleClick
    '    Line3A_CLI_DblClick()
    'End Sub

    'Private Sub btn3A_Glassing_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_Glassing.DoubleClick
    '    Line3A_Glassing_DblClick()
    'End Sub

    'Private Sub btn3A_Picosine_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_Picosine.DoubleClick
    '    Line3A_Picosine_DblClick()
    'End Sub

    'Private Sub btn3A_PinTray_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_PinTray.DoubleClick
    '    Line3A_PinTray_DblClick()
    'End Sub

    'Private Sub btn3A_1stHeat_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_1stHeat.DoubleClick
    '    Line3A_1stHeat_DblClick()
    'End Sub

    'Private Sub btn3A_Turning_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_Turning.DoubleClick
    '    Line3A_Turning_DblClick()
    'End Sub

    'Private Sub btn3A_2ndHeat_DoubleClick_1(sender As Object, e As EventArgs) Handles btn3A_2ndHeat.DoubleClick
    '    Line3A_2ndHeat_DblClick()
    'End Sub

    'Private Sub btn3A_Trimming_DoubleClick(sender As Object, e As EventArgs) Handles btn3A_Trimming.DoubleClick
    '    Line3A_Trimming_DblClick()
    'End Sub


    ''******************** PICO LINE 3B *************************

    'Private Sub btn3B_PreMelt_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_PreMelt.DoubleClick
    '    Line3B_PreMelt_DblClick()
    'End Sub

    'Private Sub btn3B_CLI_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_CLI.DoubleClick
    '    Line3B_CLI_DblClick()
    'End Sub

    'Private Sub btn3B_Glassing_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_Glassing.DoubleClick
    '    Line3B_Glassing_DblClick()
    'End Sub

    'Private Sub btn3B_Picosine_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_Picosine.DoubleClick
    '    Line3B_Picosine_DblClick()
    'End Sub

    'Private Sub btn3B_PinTray_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_PinTray.DoubleClick
    '    Line3B_PinTray_DblClick()
    'End Sub

    'Private Sub btn3B_1stHeat_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_1stHeat.DoubleClick
    '    Line3B_1stHeat_DblClick()
    'End Sub

    'Private Sub btn3B_Turning_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_Turning.DoubleClick
    '    Line3B_Turning_DblClick()
    'End Sub

    'Private Sub btn3B_2ndHeat_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_2ndHeat.DoubleClick
    '    Line3B_2ndHeat_DblClick()
    'End Sub

    'Private Sub btn3B_Trimming_DoubleClick(sender As Object, e As EventArgs) Handles btn3B_Trimming.DoubleClick
    '    Line3B_Trimming_DblClick()
    'End Sub

    Private Sub AddAssociateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAssociateToolStripMenuItem.Click
        Load_AddForm()
    End Sub

    'Private Sub btnWC_Line3_DoubleClick(sender As Object, e As EventArgs) Handles btnWC_Line3.DoubleClick
    '    WC_Lin3_DblClick()
    'End Sub

    'Private Sub btnWC_Line5_DoubleClick(sender As Object, e As EventArgs) Handles btnWC_Line5.DoubleClick
    '    WC_Lin5_DblClick()
    'End Sub


    '******************** SINGLE CLICK *************************
    '******************** PICO LINE 3A *************************

    Private Sub btn3A_PreMelt_Click(sender As Object, e As EventArgs) Handles btn3A_PreMelt.Click
        Line3A_PreMelt_DblClick()
    End Sub

    Private Sub btn3A_CLI_Click(sender As Object, e As EventArgs) Handles btn3A_CLI.Click
        Line3A_CLI_DblClick()
    End Sub

    Private Sub btn3A_Glassing_Click(sender As Object, e As EventArgs) Handles btn3A_Glassing.Click
        Line3A_Glassing_DblClick()
    End Sub

    Private Sub btn3A_Picosine_Click(sender As Object, e As EventArgs) Handles btn3A_Picosine.Click
        Line3A_Picosine_DblClick()
    End Sub

    Private Sub btn3A_PinTray_Click(sender As Object, e As EventArgs) Handles btn3A_PinTray.Click
        Line3A_PinTray_DblClick()
    End Sub

    Private Sub btn3A_1stHeat_Click(sender As Object, e As EventArgs) Handles btn3A_1stHeat.Click
        Line3A_1stHeat_DblClick()
    End Sub

    Private Sub btn3A_Turning_Click(sender As Object, e As EventArgs) Handles btn3A_Turning.Click
        Line3A_Turning_DblClick()
    End Sub

    Private Sub btn3A_2ndHeat_Click(sender As Object, e As EventArgs) Handles btn3A_2ndHeat.Click
        Line3A_2ndHeat_DblClick()
    End Sub

    Private Sub btn3A_Trimming_Click(sender As Object, e As EventArgs) Handles btn3A_Trimming.Click
        Line3A_Trimming_DblClick()
    End Sub


    '******************** PICO LINE 3B *************************
    Private Sub btn3B_PreMelt_Click(sender As Object, e As EventArgs) Handles btn3B_PreMelt.Click
        Line3B_PreMelt_DblClick()
    End Sub

    Private Sub btn3B_CLI_Click(sender As Object, e As EventArgs) Handles btn3B_CLI.Click
        Line3B_CLI_DblClick()
    End Sub

    Private Sub btn3B_Glassing_Click(sender As Object, e As EventArgs) Handles btn3B_Glassing.Click
        Line3B_Glassing_DblClick()
    End Sub

    Private Sub btn3B_Picosine_Click(sender As Object, e As EventArgs) Handles btn3B_Picosine.Click
        Line3B_Picosine_DblClick()
    End Sub

    Private Sub btn3B_PinTray_Click(sender As Object, e As EventArgs) Handles btn3B_PinTray.Click
        Line3B_PinTray_DblClick()
    End Sub

    Private Sub btn3B_1stHeat_Click(sender As Object, e As EventArgs) Handles btn3B_1stHeat.Click
        Line3B_1stHeat_DblClick()
    End Sub

    Private Sub btn3B_Turning_Click(sender As Object, e As EventArgs) Handles btn3B_Turning.Click
        Line3B_Turning_DblClick()
    End Sub

    Private Sub btn3B_2ndHeat_Click(sender As Object, e As EventArgs) Handles btn3B_2ndHeat.Click
        Line3B_2ndHeat_DblClick()
    End Sub

    Private Sub btn3B_Trimming_Click(sender As Object, e As EventArgs) Handles btn3B_Trimming.Click
        Line3B_Trimming_DblClick()
    End Sub

    Private Sub btnWC_Line3_Click(sender As Object, e As EventArgs) Handles btnWC_Line3.Click
        WC_Lin3_DblClick()
    End Sub

    Private Sub btnWC_Line5_Click(sender As Object, e As EventArgs) Handles btnWC_Line5.Click
        WC_Lin5_DblClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Check_1hour_Down()
        'Check_2hour_Down()
        'Check_3hour_Down()

        'Check_Line_For_Send = "Sample2 Line2"

        'Check_Whos_Recipient()
    End Sub

    Private Sub Timer1hour_Tick(sender As Object, e As EventArgs) Handles Timer1hour.Tick
        Check_1hour_Down()
    End Sub

    Private Sub Timer2hours_Tick(sender As Object, e As EventArgs) Handles Timer2hours.Tick
        Check_2hour_Down()
    End Sub

    Private Sub Timer3hours_Tick(sender As Object, e As EventArgs) Handles Timer3hours.Tick
        Check_3hour_Down()
    End Sub


    '******************** PICO LINE 5 *************************
    Private Sub btnLine5_CLI_Click(sender As Object, e As EventArgs) Handles btnLine5_CLI.Click
        Line5_CLI_Clicked()
    End Sub

    Private Sub btnLine5_PreMelt_Click(sender As Object, e As EventArgs) Handles btnLine5_PreMelt.Click
        Line5_PreMelt_Clicked()
    End Sub

    Private Sub btnLine5_WireThread_Click(sender As Object, e As EventArgs) Handles btnLine5_WireThread.Click
        Line5_WireThreading_Clicked()
    End Sub

    Private Sub btnLine5_1stHeat_Click(sender As Object, e As EventArgs) Handles btnLine5_1stHeat.Click
        Line5_1stHeat_Clicked()
    End Sub

    Private Sub btnLine5_Sanding_Click(sender As Object, e As EventArgs) Handles btnLine5_Sanding.Click
        Line5_Sanding_Clicked()
    End Sub

    Private Sub btnLine5_2ndHeat_Click(sender As Object, e As EventArgs) Handles btnLine5_2ndHeat.Click
        Line5_2ndHeat_Clicked()
    End Sub

    Private Sub btnLine5_Assembly_Click(sender As Object, e As EventArgs) Handles btnLine5_Assembly.Click
        Line5_Assembly_Clicked()
    End Sub
End Class
