<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SmallPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.btnTrialVersion = New System.Windows.Forms.Button()
        Me.btnPremium = New System.Windows.Forms.Button()
        Me.lblprotection = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnquickscan = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.btnfullcheck = New System.Windows.Forms.Button()
        Me.btntoolbox = New System.Windows.Forms.Button()
        Me.btnspeedup = New System.Windows.Forms.Button()
        Me.btncleanup = New System.Windows.Forms.Button()
        Me.btnvirusscan = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Welcome1 = New nettrack2.welcome()
        Me.Fullcheck1 = New nettrack2.fullcheck()
        Me.Virusscan1 = New nettrack2.virusscan()
        Me.Speedup1 = New nettrack2.speedup()
        Me.Cleanup1 = New nettrack2.cleanup()
        Me.Settings1 = New nettrack2.settings()
        Me.Close1 = New nettrack2.close()
        Me.Quickscan1 = New nettrack2.quickscan()
        Me.Quickscan2 = New nettrack2.quickscan()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.btnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SmallPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SmallPanel
        '
        Me.SmallPanel.BackColor = System.Drawing.Color.Lime
        Me.SmallPanel.Controls.Add(Me.PictureBox1)
        Me.SmallPanel.Location = New System.Drawing.Point(0, 31)
        Me.SmallPanel.Name = "SmallPanel"
        Me.SmallPanel.Size = New System.Drawing.Size(173, 196)
        Me.SmallPanel.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.nettrack2.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(14, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Blue
        Me.HeaderPanel.Controls.Add(Me.Button1)
        Me.HeaderPanel.Controls.Add(Me.lblRegister)
        Me.HeaderPanel.Controls.Add(Me.btnTrialVersion)
        Me.HeaderPanel.Controls.Add(Me.btnPremium)
        Me.HeaderPanel.Controls.Add(Me.lblprotection)
        Me.HeaderPanel.Controls.Add(Me.lblstatus)
        Me.HeaderPanel.Controls.Add(Me.PictureBox3)
        Me.HeaderPanel.Controls.Add(Me.PictureBox2)
        Me.HeaderPanel.Controls.Add(Me.Label1)
        Me.HeaderPanel.Controls.Add(Me.btnquickscan)
        Me.HeaderPanel.ForeColor = System.Drawing.Color.Blue
        Me.HeaderPanel.Location = New System.Drawing.Point(173, 31)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1055, 195)
        Me.HeaderPanel.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(704, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.White
        Me.lblRegister.Location = New System.Drawing.Point(862, 152)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(181, 25)
        Me.lblRegister.TabIndex = 7
        Me.lblRegister.Text = "30 Days Remaining"
        '
        'btnTrialVersion
        '
        Me.btnTrialVersion.BackColor = System.Drawing.Color.Red
        Me.btnTrialVersion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTrialVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrialVersion.ForeColor = System.Drawing.Color.White
        Me.btnTrialVersion.Location = New System.Drawing.Point(573, 84)
        Me.btnTrialVersion.Name = "btnTrialVersion"
        Me.btnTrialVersion.Size = New System.Drawing.Size(206, 50)
        Me.btnTrialVersion.TabIndex = 6
        Me.btnTrialVersion.Text = "Trial Version"
        Me.btnTrialVersion.UseVisualStyleBackColor = False
        '
        'btnPremium
        '
        Me.btnPremium.BackColor = System.Drawing.Color.Green
        Me.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPremium.ForeColor = System.Drawing.Color.White
        Me.btnPremium.Location = New System.Drawing.Point(41, 84)
        Me.btnPremium.Name = "btnPremium"
        Me.btnPremium.Size = New System.Drawing.Size(278, 50)
        Me.btnPremium.TabIndex = 5
        Me.btnPremium.Text = "Activate Premium"
        Me.btnPremium.UseVisualStyleBackColor = False
        '
        'lblprotection
        '
        Me.lblprotection.AutoSize = True
        Me.lblprotection.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprotection.ForeColor = System.Drawing.Color.Snow
        Me.lblprotection.Location = New System.Drawing.Point(139, 135)
        Me.lblprotection.Name = "lblprotection"
        Me.lblprotection.Size = New System.Drawing.Size(413, 42)
        Me.lblprotection.TabIndex = 4
        Me.lblprotection.Text = "Your Computer is Protected"
        Me.lblprotection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.ForeColor = System.Drawing.Color.Snow
        Me.lblstatus.Location = New System.Drawing.Point(31, 135)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(113, 42)
        Me.lblstatus.TabIndex = 3
        Me.lblstatus.Text = "Status"
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(967, -49)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(78, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(967, -49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NET-TRACK"
        '
        'btnquickscan
        '
        Me.btnquickscan.BackColor = System.Drawing.Color.Red
        Me.btnquickscan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquickscan.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnquickscan.ForeColor = System.Drawing.Color.FloralWhite
        Me.btnquickscan.Location = New System.Drawing.Point(799, 58)
        Me.btnquickscan.Name = "btnquickscan"
        Me.btnquickscan.Size = New System.Drawing.Size(214, 60)
        Me.btnquickscan.TabIndex = 0
        Me.btnquickscan.Text = "Quick Scan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnquickscan.UseVisualStyleBackColor = False
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.Aqua
        Me.SidePanel.Controls.Add(Me.btnfullcheck)
        Me.SidePanel.Controls.Add(Me.btntoolbox)
        Me.SidePanel.Controls.Add(Me.btnspeedup)
        Me.SidePanel.Controls.Add(Me.btncleanup)
        Me.SidePanel.Controls.Add(Me.btnvirusscan)
        Me.SidePanel.Location = New System.Drawing.Point(0, 226)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(211, 488)
        Me.SidePanel.TabIndex = 10
        '
        'btnfullcheck
        '
        Me.btnfullcheck.BackColor = System.Drawing.Color.Yellow
        Me.btnfullcheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfullcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfullcheck.ForeColor = System.Drawing.Color.Black
        Me.btnfullcheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfullcheck.Location = New System.Drawing.Point(0, 20)
        Me.btnfullcheck.Name = "btnfullcheck"
        Me.btnfullcheck.Size = New System.Drawing.Size(211, 60)
        Me.btnfullcheck.TabIndex = 5
        Me.btnfullcheck.Text = "Full Check"
        Me.btnfullcheck.UseVisualStyleBackColor = False
        '
        'btntoolbox
        '
        Me.btntoolbox.BackColor = System.Drawing.Color.Yellow
        Me.btntoolbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntoolbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntoolbox.ForeColor = System.Drawing.Color.Black
        Me.btntoolbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntoolbox.Location = New System.Drawing.Point(0, 283)
        Me.btntoolbox.Name = "btntoolbox"
        Me.btntoolbox.Size = New System.Drawing.Size(211, 60)
        Me.btntoolbox.TabIndex = 4
        Me.btntoolbox.Text = "Tool Box"
        Me.btntoolbox.UseVisualStyleBackColor = False
        '
        'btnspeedup
        '
        Me.btnspeedup.BackColor = System.Drawing.Color.Yellow
        Me.btnspeedup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnspeedup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnspeedup.ForeColor = System.Drawing.Color.Black
        Me.btnspeedup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnspeedup.Location = New System.Drawing.Point(0, 151)
        Me.btnspeedup.Name = "btnspeedup"
        Me.btnspeedup.Size = New System.Drawing.Size(211, 60)
        Me.btnspeedup.TabIndex = 3
        Me.btnspeedup.Text = "Speed Up"
        Me.btnspeedup.UseVisualStyleBackColor = False
        '
        'btncleanup
        '
        Me.btncleanup.BackColor = System.Drawing.Color.Yellow
        Me.btncleanup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncleanup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncleanup.ForeColor = System.Drawing.Color.Black
        Me.btncleanup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncleanup.Location = New System.Drawing.Point(0, 217)
        Me.btncleanup.Name = "btncleanup"
        Me.btncleanup.Size = New System.Drawing.Size(211, 60)
        Me.btncleanup.TabIndex = 2
        Me.btncleanup.Text = "Clean Up" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btncleanup.UseVisualStyleBackColor = False
        '
        'btnvirusscan
        '
        Me.btnvirusscan.BackColor = System.Drawing.Color.Yellow
        Me.btnvirusscan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnvirusscan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvirusscan.ForeColor = System.Drawing.Color.Black
        Me.btnvirusscan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvirusscan.Location = New System.Drawing.Point(0, 86)
        Me.btnvirusscan.Name = "btnvirusscan"
        Me.btnvirusscan.Size = New System.Drawing.Size(211, 60)
        Me.btnvirusscan.TabIndex = 1
        Me.btnvirusscan.Text = "Virus Scan"
        Me.btnvirusscan.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Yellow
        Me.Panel4.Controls.Add(Me.Welcome1)
        Me.Panel4.Controls.Add(Me.Fullcheck1)
        Me.Panel4.Controls.Add(Me.Virusscan1)
        Me.Panel4.Controls.Add(Me.Speedup1)
        Me.Panel4.Controls.Add(Me.Cleanup1)
        Me.Panel4.Controls.Add(Me.Settings1)
        Me.Panel4.Controls.Add(Me.Close1)
        Me.Panel4.Controls.Add(Me.Quickscan1)
        Me.Panel4.Controls.Add(Me.Quickscan2)
        Me.Panel4.Location = New System.Drawing.Point(211, 226)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1016, 487)
        Me.Panel4.TabIndex = 17
        '
        'Welcome1
        '
        Me.Welcome1.BackColor = System.Drawing.Color.Yellow
        Me.Welcome1.Location = New System.Drawing.Point(0, 0)
        Me.Welcome1.Name = "Welcome1"
        Me.Welcome1.Size = New System.Drawing.Size(1016, 487)
        Me.Welcome1.TabIndex = 0
        '
        'Fullcheck1
        '
        Me.Fullcheck1.BackColor = System.Drawing.Color.Black
        Me.Fullcheck1.Location = New System.Drawing.Point(3, 1)
        Me.Fullcheck1.Name = "Fullcheck1"
        Me.Fullcheck1.Size = New System.Drawing.Size(1016, 487)
        Me.Fullcheck1.TabIndex = 1
        '
        'Virusscan1
        '
        Me.Virusscan1.BackColor = System.Drawing.Color.Black
        Me.Virusscan1.Location = New System.Drawing.Point(0, 0)
        Me.Virusscan1.Name = "Virusscan1"
        Me.Virusscan1.Size = New System.Drawing.Size(1016, 487)
        Me.Virusscan1.TabIndex = 2
        '
        'Speedup1
        '
        Me.Speedup1.BackColor = System.Drawing.Color.Black
        Me.Speedup1.Location = New System.Drawing.Point(1, 0)
        Me.Speedup1.Name = "Speedup1"
        Me.Speedup1.Size = New System.Drawing.Size(1016, 487)
        Me.Speedup1.TabIndex = 3
        '
        'Cleanup1
        '
        Me.Cleanup1.BackColor = System.Drawing.Color.Black
        Me.Cleanup1.Location = New System.Drawing.Point(0, -1)
        Me.Cleanup1.Name = "Cleanup1"
        Me.Cleanup1.Size = New System.Drawing.Size(1016, 487)
        Me.Cleanup1.TabIndex = 4
        '
        'Settings1
        '
        Me.Settings1.BackColor = System.Drawing.Color.Black
        Me.Settings1.Location = New System.Drawing.Point(0, -1)
        Me.Settings1.Name = "Settings1"
        Me.Settings1.Size = New System.Drawing.Size(1016, 487)
        Me.Settings1.TabIndex = 5
        '
        'Close1
        '
        Me.Close1.Location = New System.Drawing.Point(270, 117)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(471, 213)
        Me.Close1.TabIndex = 6
        Me.Close1.Visible = False
        '
        'Quickscan1
        '
        Me.Quickscan1.BackColor = System.Drawing.Color.Blue
        Me.Quickscan1.Location = New System.Drawing.Point(1212, 780)
        Me.Quickscan1.Name = "Quickscan1"
        Me.Quickscan1.Size = New System.Drawing.Size(708, 250)
        Me.Quickscan1.TabIndex = 7
        '
        'Quickscan2
        '
        Me.Quickscan2.BackColor = System.Drawing.Color.Blue
        Me.Quickscan2.Location = New System.Drawing.Point(1212, 780)
        Me.Quickscan2.Name = "Quickscan2"
        Me.Quickscan2.Size = New System.Drawing.Size(708, 250)
        Me.Quickscan2.TabIndex = 8
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Blue
        Me.lblHeading.Location = New System.Drawing.Point(12, 5)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(92, 20)
        Me.lblHeading.TabIndex = 18
        Me.lblHeading.Text = "Net-Track" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(173, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 19
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(293, 5)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 20
        '
        'btnTimer
        '
        Me.btnTimer.Enabled = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.nettrack2.My.Resources.Resources.profile_32px
        Me.PictureBox8.Location = New System.Drawing.Point(1087, 4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.nettrack2.My.Resources.Resources.menu_24px
        Me.PictureBox6.Location = New System.Drawing.Point(1118, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.nettrack2.My.Resources.Resources.macos_minimize_32px
        Me.PictureBox7.Location = New System.Drawing.Point(1146, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.nettrack2.My.Resources.Resources.maximize_window_16px
        Me.PictureBox5.Location = New System.Drawing.Point(1174, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.nettrack2.My.Resources.Resources.close
        Me.PictureBox4.Location = New System.Drawing.Point(1202, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 714)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.SmallPanel)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SmallPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SmallPanel As Panel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents lblprotection As Label
    Friend WithEvents lblstatus As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnquickscan As Button
    Friend WithEvents SidePanel As Panel
    Friend WithEvents btnfullcheck As Button
    Friend WithEvents btntoolbox As Button
    Friend WithEvents btnspeedup As Button
    Friend WithEvents btncleanup As Button
    Friend WithEvents btnvirusscan As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Fullcheck1 As fullcheck
    Friend WithEvents Welcome1 As welcome
    Friend WithEvents Virusscan1 As virusscan
    Friend WithEvents Speedup1 As speedup
    Friend WithEvents lblHeading As Label
    Friend WithEvents Cleanup1 As cleanup
    Friend WithEvents Settings1 As settings
    Friend WithEvents Close1 As close
    Friend WithEvents Quickscan1 As quickscan
    Friend WithEvents Quickscan2 As quickscan
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents btnTimer As Timer
    Friend WithEvents btnTrialVersion As Button
    Friend WithEvents btnPremium As Button
    Friend WithEvents lblRegister As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox8 As PictureBox
End Class
