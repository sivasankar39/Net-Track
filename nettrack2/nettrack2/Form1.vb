Public Class Form1
    Dim day As String
    Dim month As String
    Dim year As String
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Close1.Visible = True
        Close1.BringToFront()
    End Sub

    Private Sub btnfullcheck_Click(sender As Object, e As EventArgs) Handles btnfullcheck.Click
        If Settings1.cmbThemes.Text = "Dark Theme" Then
            Fullcheck1.BringToFront()
            btnfullcheck.BackColor = Color.White
            btnfullcheck.ForeColor = Color.Black
            btnvirusscan.BackColor = Color.Yellow
            btnspeedup.BackColor = Color.Yellow
            btncleanup.BackColor = Color.Yellow
            btntoolbox.BackColor = Color.Yellow
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then
                Fullcheck1.BringToFront()
                btnfullcheck.BackColor = Color.Blue
                btnfullcheck.ForeColor = Color.Black
                btnvirusscan.BackColor = Color.Yellow
                btnspeedup.BackColor = Color.Yellow
                btncleanup.BackColor = Color.Yellow
                btntoolbox.BackColor = Color.Yellow
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then
                    Fullcheck1.BringToFront()

                    btnfullcheck.BackColor = Color.Red
                    btnfullcheck.ForeColor = Color.Black
                    btnvirusscan.BackColor = Color.Yellow
                    btnspeedup.BackColor = Color.Yellow
                    btncleanup.BackColor = Color.Yellow
                    btntoolbox.BackColor = Color.Yellow
                End If
            End If
        End If
    End Sub

    Private Sub btnvirusscan_Click(sender As Object, e As EventArgs) Handles btnvirusscan.Click

        If Settings1.cmbThemes.Text = "Dark Theme" Then
            Virusscan1.BringToFront()
            btnvirusscan.BackColor = Color.White
            btnvirusscan.ForeColor = Color.Black
            btnfullcheck.BackColor = Color.Yellow
            btnspeedup.BackColor = Color.Yellow
            btncleanup.BackColor = Color.Yellow
            btntoolbox.BackColor = Color.Yellow
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then
                Virusscan1.BringToFront()
                btnvirusscan.BackColor = Color.Blue
                btnvirusscan.ForeColor = Color.Black
                btnfullcheck.BackColor = Color.Yellow
                btnspeedup.BackColor = Color.Yellow
                btncleanup.BackColor = Color.Yellow
                btntoolbox.BackColor = Color.Yellow
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then
                    Virusscan1.BringToFront()
                    btnvirusscan.BackColor = Color.Red
                    btnvirusscan.ForeColor = Color.Black
                    btnfullcheck.BackColor = Color.Yellow
                    btnspeedup.BackColor = Color.Yellow
                    btncleanup.BackColor = Color.Yellow
                    btntoolbox.BackColor = Color.Yellow
                End If
            End If
        End If






    End Sub
    Private Sub btnspeedup_Click(sender As Object, e As EventArgs) Handles btnspeedup.Click
        Speedup1.BringToFront()
        If Settings1.cmbThemes.Text = "Dark Theme" Then
            Speedup1.BringToFront()
            btnspeedup.BackColor = Color.White
            btnspeedup.ForeColor = Color.Black
            btnfullcheck.BackColor = Color.Yellow
            btnvirusscan.BackColor = Color.Yellow
            btncleanup.BackColor = Color.Yellow
            btntoolbox.BackColor = Color.Yellow
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then
                Speedup1.BringToFront()
                btnspeedup.BackColor = Color.Blue
                btnspeedup.ForeColor = Color.Black
                btnfullcheck.BackColor = Color.Yellow
                btnvirusscan.BackColor = Color.Yellow
                btncleanup.BackColor = Color.Yellow
                btntoolbox.BackColor = Color.Yellow
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then
                    Speedup1.BringToFront()
                    btnspeedup.BackColor = Color.Red
                    btnspeedup.ForeColor = Color.Black
                    btnfullcheck.BackColor = Color.Yellow
                    btnvirusscan.BackColor = Color.Yellow
                    btncleanup.BackColor = Color.Yellow
                    btntoolbox.BackColor = Color.Yellow
                End If
            End If
        End If


    End Sub




    Private Sub btncleanup_Click(sender As Object, e As EventArgs) Handles btncleanup.Click

        If Settings1.cmbThemes.Text = "Dark Theme" Then
            Cleanup1.BringToFront()
            btncleanup.BackColor = Color.White
            btncleanup.ForeColor = Color.Black
            btnfullcheck.BackColor = Color.Yellow
            btnspeedup.BackColor = Color.Yellow
            btnvirusscan.BackColor = Color.Yellow
            btntoolbox.BackColor = Color.Yellow
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then
                Cleanup1.BringToFront()
                btncleanup.BackColor = Color.Blue
                btncleanup.ForeColor = Color.Black
                btnfullcheck.BackColor = Color.Yellow
                btnspeedup.BackColor = Color.Yellow
                btnvirusscan.BackColor = Color.Yellow
                btntoolbox.BackColor = Color.Yellow
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then
                    Cleanup1.BringToFront()
                    btncleanup.BackColor = Color.Red
                    btncleanup.ForeColor = Color.Black
                    btnfullcheck.BackColor = Color.Yellow
                    btnspeedup.BackColor = Color.Yellow
                    btnvirusscan.BackColor = Color.Yellow
                    btntoolbox.BackColor = Color.Yellow
                End If
            End If
        End If
    End Sub

    Private Sub btntoolbox_Click(sender As Object, e As EventArgs) Handles btntoolbox.Click

        If Settings1.cmbThemes.Text = "Dark Theme" Then
            Settings1.BringToFront()
            btntoolbox.BackColor = Color.White
            btntoolbox.ForeColor = Color.Black
            btnfullcheck.BackColor = Color.Yellow
            btnspeedup.BackColor = Color.Yellow
            btnvirusscan.BackColor = Color.Yellow
            btncleanup.BackColor = Color.Yellow
        Else
            If Settings1.cmbThemes.Text = "Default Theme" Then
                Settings1.BringToFront()
                btntoolbox.BackColor = Color.Blue
                btntoolbox.ForeColor = Color.Black
                btnfullcheck.BackColor = Color.Yellow
                btnspeedup.BackColor = Color.Yellow
                btnvirusscan.BackColor = Color.Yellow
                btncleanup.BackColor = Color.Yellow
            Else
                If Settings1.cmbThemes.Text = "Red Theme" Then
                    Settings1.BringToFront()
                    btntoolbox.BackColor = Color.Red
                    btntoolbox.ForeColor = Color.Black
                    btnfullcheck.BackColor = Color.Yellow
                    btnspeedup.BackColor = Color.Yellow
                    btnvirusscan.BackColor = Color.Yellow
                    btncleanup.BackColor = Color.Yellow
                End If
            End If
        End If
    End Sub
    Private Sub Trial_Validation()
        day = My.Computer.Clock.LocalTime.Day
        month = My.Computer.Clock.LocalTime.Month
        year = My.Computer.Clock.LocalTime.Year
        If My.Settings.validation() = False Then
            My.Settings.day = day
            My.Settings.month = month
            My.Settings.year = year
            My.Settings.validation = True
        Else
            If year = My.Settings.year Then
                If month = My.Settings.month Then
                Else
                    If month = My.Settings.month + 1 Then
                        If day = My.Settings.day Then
                            MsgBox("Trial Expired! Please Enter Your Purchase code to Unlock!", MsgBoxStyle.Information, "Validation")
                        Else
                            If day > My.Settings.day Then
                                MsgBox("Trial Expired! Please Enter Your Purchase code to Unlock!", MsgBoxStyle.Information, "Validation")
                            End If

                        End If

                    Else
                    If month >= My.Settings.month + 1 Then
                        MsgBox("Trial Expired! Please Enter Your Purchase code to Unlock!", MsgBoxStyle.Information, "Validation")
                    End If
                End If
            End If
            Else
            MsgBox("Trial Expired! Please Enter Your Purchase code to Unlock!", MsgBoxStyle.Information, "Validation")
        End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Timer1.Enabled = True Then
            Timer2.Enabled = False
        Else
            Timer2.Enabled = True
        End If
        Settings1.cmbThemes.Text = "Default Theme"
        Fullcheck1.computername.Text = My.Computer.Name
        Fullcheck1.computerversion.Text = My.Computer.Info.OSFullName
        Fullcheck1.osplatform.Text = My.Computer.Info.OSPlatform
        Fullcheck1.username.Text = SystemInformation.UserName
        If My.Settings.key = "0123-4567-8901-2345-6789" Then
            lblHeading.Text = "Net-Track - Pre-activated"
            btnPremium.Visible = False
            lblRegister.Visible = False
            lblstatus.Location = New Point(31, 81)
            lblprotection.Location = New Point(138, 81)


        End If
        Trial_Validation()
    End Sub

    Private Sub btnquickscan_Click(sender As Object, e As EventArgs) Handles btnquickscan.Click
        Me.Hide()
        quick_scan.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            notification.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = 100 Then
            Timer2.Stop()
            notification.Timer1.Start()
            notification.Timer2.Start()
        End If
    End Sub

    Private Sub btnTimer_Tick(sender As Object, e As EventArgs) Handles btnTimer.Tick

    End Sub

    Private Sub btnPremium_Click(sender As Object, e As EventArgs) Handles btnPremium.Click
        register.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.key = Nothing
        My.Settings.email = Nothing
        My.Settings.Save()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        profile.ShowDialog()

    End Sub
End Class
