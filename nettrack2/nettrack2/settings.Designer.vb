<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbThemes = New System.Windows.Forms.ComboBox()
        Me.btnDefaultTheme = New System.Windows.Forms.Button()
        Me.btnChangeTheme = New System.Windows.Forms.Button()
        Me.ThemePic = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbThemes)
        Me.GroupBox1.Controls.Add(Me.ThemePic)
        Me.GroupBox1.Controls.Add(Me.btnDefaultTheme)
        Me.GroupBox1.Controls.Add(Me.btnChangeTheme)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(977, 454)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'cmbThemes
        '
        Me.cmbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbThemes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbThemes.FormattingEnabled = True
        Me.cmbThemes.Location = New System.Drawing.Point(215, 350)
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.Size = New System.Drawing.Size(517, 33)
        Me.cmbThemes.TabIndex = 3
        '
        'btnDefaultTheme
        '
        Me.btnDefaultTheme.BackColor = System.Drawing.Color.Red
        Me.btnDefaultTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaultTheme.ForeColor = System.Drawing.Color.White
        Me.btnDefaultTheme.Location = New System.Drawing.Point(468, 397)
        Me.btnDefaultTheme.Name = "btnDefaultTheme"
        Me.btnDefaultTheme.Size = New System.Drawing.Size(214, 41)
        Me.btnDefaultTheme.TabIndex = 1
        Me.btnDefaultTheme.Text = "Default Theme"
        Me.btnDefaultTheme.UseVisualStyleBackColor = False
        '
        'btnChangeTheme
        '
        Me.btnChangeTheme.BackColor = System.Drawing.Color.Red
        Me.btnChangeTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeTheme.ForeColor = System.Drawing.Color.White
        Me.btnChangeTheme.Location = New System.Drawing.Point(248, 397)
        Me.btnChangeTheme.Name = "btnChangeTheme"
        Me.btnChangeTheme.Size = New System.Drawing.Size(214, 41)
        Me.btnChangeTheme.TabIndex = 0
        Me.btnChangeTheme.Text = "Change Theme"
        Me.btnChangeTheme.UseVisualStyleBackColor = False
        '
        'ThemePic
        '
        Me.ThemePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThemePic.Image = Global.nettrack2.My.Resources.Resources._DEFAULT
        Me.ThemePic.Location = New System.Drawing.Point(215, 36)
        Me.ThemePic.Name = "ThemePic"
        Me.ThemePic.Size = New System.Drawing.Size(517, 308)
        Me.ThemePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ThemePic.TabIndex = 2
        Me.ThemePic.TabStop = False
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "settings"
        Me.Size = New System.Drawing.Size(1016, 487)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ThemePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ThemePic As PictureBox
    Friend WithEvents btnDefaultTheme As Button
    Friend WithEvents btnChangeTheme As Button
    Friend WithEvents cmbThemes As ComboBox
End Class
