Public Class settings


    Private Sub comboItems()
        cmbThemes.Items.Add("Default Theme")
        cmbThemes.Items.Add("Dark Theme")
        cmbThemes.Items.Add("Red Theme")
        cmbThemes.Items.Add("Yellow Theme")
        cmbThemes.Items.Add("Gray Theme")
        cmbThemes.Items.Add("Blue Theme")
        cmbThemes.Items.Add("Violet Theme")
        cmbThemes.Items.Add("Green Theme")
        cmbThemes.Items.Add("Pink Theme")
    End Sub
    Private Sub Default_theme()
        Form1.HeaderPanel.BackColor = Color.Blue
        Form1.Virusscan1.BackColor = Color.Black
        Form1.SidePanel.BackColor = Color.Aqua
        Form1.SmallPanel.BackColor = Color.Lime
        Form1.Welcome1.BackColor = Color.Yellow
        Form1.Fullcheck1.BackColor = Color.Black
        Form1.Speedup1.BackColor = Color.Black
        Form1.Cleanup1.BackColor = Color.Black
        Form1.Close1.Panel1.BackColor = Color.Blue
        Form1.Close1.lblTitle.ForeColor = Color.Blue
        quick_scan.BackColor = Color.Blue
        quick_scan.GroupBox2.BackColor = Color.Blue
        Me.BackColor = Color.Black
        ThemePic.Image = My.Resources._DEFAULT

    End Sub
    Private Sub Dark_theme()
        Form1.HeaderPanel.BackColor = Color.Black
        Form1.SidePanel.BackColor = Color.Black
        Form1.SmallPanel.BackColor = Color.Black
        Form1.Welcome1.BackColor = Color.White
        Form1.Fullcheck1.BackColor = Color.White
        Form1.Speedup1.BackColor = Color.White
        Form1.Virusscan1.BackColor = Color.White
        Form1.Cleanup1.BackColor = Color.White
        Form1.Close1.Panel1.BackColor = Color.Black
        Form1.Close1.lblTitle.ForeColor = Color.Black
        quick_scan.BackColor = Color.Black
        quick_scan.GroupBox2.BackColor = Color.Black
        Me.BackColor = Color.White
        GroupBox1.BackColor = Color.Black
        ThemePic.Image = My.Resources.DARK_THEME


    End Sub
    Private Sub Red_theme()
        Form1.HeaderPanel.BackColor = Color.Red
        Form1.SidePanel.BackColor = Color.White
        Form1.SmallPanel.BackColor = Color.Red
        Form1.Welcome1.BackColor = Color.Red
        Form1.Fullcheck1.BackColor = Color.Red
        Form1.Speedup1.BackColor = Color.Red
        Form1.Virusscan1.BackColor = Color.Red
        Form1.Cleanup1.BackColor = Color.Red
        Form1.Close1.Panel1.BackColor = Color.Red
        Form1.Close1.lblTitle.ForeColor = Color.Red
        quick_scan.BackColor = Color.Red
        quick_scan.GroupBox2.BackColor = Color.Red
        Me.BackColor = Color.Red
        GroupBox1.BackColor = Color.Black
        ThemePic.Image = My.Resources.RED


    End Sub
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbThemes.SelectedIndex = 1
        Catch ex As Exception

        End Try


        comboItems()
    End Sub

    Private Sub cmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        If cmbThemes.Text = "Default Theme" Then
            Default_theme()
        Else
            If cmbThemes.Text = "Dark Theme" Then
                Dark_theme()
            Else
                If cmbThemes.Text = "Red Theme" Then
                    Red_theme()
                End If
            End If
        End If
    End Sub
End Class
