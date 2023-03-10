<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class virusscan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.detected = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.files = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.readlist = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 250)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(930, 229)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(922, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "SCAN"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(8, 7)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(902, 180)
        Me.ListBox1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ListBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(922, 200)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RESULTS"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(735, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 43)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete All"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(556, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 43)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Black
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(8, 8)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(902, 148)
        Me.ListBox2.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.readlist)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.detected)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.total)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.files)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(40, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(933, 181)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scan for Virus"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(323, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 75)
        Me.Panel2.TabIndex = 18
        '
        'detected
        '
        Me.detected.AutoSize = True
        Me.detected.Location = New System.Drawing.Point(357, 76)
        Me.detected.Name = "detected"
        Me.detected.Size = New System.Drawing.Size(23, 25)
        Me.detected.TabIndex = 17
        Me.detected.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(73, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(217, 25)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Infected/Detected Files:"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(357, 51)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(23, 25)
        Me.total.TabIndex = 15
        Me.total.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Gold
        Me.Label15.Location = New System.Drawing.Point(147, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 25)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Files Scanned:"
        '
        'files
        '
        Me.files.AutoSize = True
        Me.files.Location = New System.Drawing.Point(357, 24)
        Me.files.Name = "files"
        Me.files.Size = New System.Drawing.Size(23, 25)
        Me.files.TabIndex = 13
        Me.files.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(60, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(230, 25)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Total Files in Destination:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(50, 147)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(867, 17)
        Me.ProgressBar1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(744, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CustomScan"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(744, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quick Scan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\"
        '
        'FolderBrowserDialog2
        '
        Me.FolderBrowserDialog2.SelectedPath = "D:\"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.Path = "C:\"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'readlist
        '
        Me.readlist.ForeColor = System.Drawing.Color.Gold
        Me.readlist.Location = New System.Drawing.Point(50, 119)
        Me.readlist.Name = "readlist"
        Me.readlist.Size = New System.Drawing.Size(867, 25)
        Me.readlist.TabIndex = 19
        '
        'virusscan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "virusscan"
        Me.Size = New System.Drawing.Size(1016, 487)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents detected As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents files As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents readlist As Label
End Class
