Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Public Class virusscan
    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        Try
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashbyte As Byte
            For Each hashbyte In hash
                buff.Append(String.Format("{0:X2}", hashbyte))
            Next
            f.close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                frmVirusDetected.ShowDialog()
            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Try
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashbyte As Byte
            For Each hashbyte In hash
                buff.Append(String.Format("{0:X2}", hashbyte))
            Next
            f.close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                frmVirusDetected.ShowDialog()
            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed
        Try
            Me.OpenFileDialog1.FileName = ""
            Dim scanbox As New TextBox
            scanbox.Text = My.Computer.FileSystem.ReadAllText("viruslist.txt").ToString
            Dim md5 As New MD5CryptoServiceProvider
            Dim f As New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            f = New FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read, &H2000)
            md5.ComputeHash(f)
            Dim hash As Byte() = md5.Hash
            Dim buff As New StringBuilder
            Dim hashbyte As Byte
            For Each hashbyte In hash
                buff.Append(String.Format("{0:X2}", hashbyte))
            Next
            f.close()
            If scanbox.Text.Contains(buff.ToString) Then
                Me.OpenFileDialog1.FileName = e.FullPath
                frmVirusDetected.ShowDialog()
            End If

        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            Dim ex As Exception = exception1
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Maximum = Conversions.ToString(ListBox1.Items.Count)
        total.Text = Conversions.ToString(ListBox1.Items.Count)
        If Not ProgressBar1.Value = ProgressBar1.Maximum Then
            Try
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
                readlist.Text = ListBox1.SelectedItem.ToString
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            Try
                Dim scanbox As New TextBox
                Dim read As String = My.Computer.FileSystem.ReadAllText("viruslist.txt")
                ProgressBar1.Increment(1)
                detected.Text = Conversions.ToString(ListBox2.Items.Count)
                files.Text = Conversions.ToString(ProgressBar1.Value)
                scanbox.Text = readlist.ToString
                Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
                Dim f As FileStream = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                f = New FileStream(ListBox1.SelectedItem, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashbyte As Byte
                For Each hashbyte In hash
                    buff.Append(String.Format("0:X2", hashbyte))

                Next
                If scanbox.Text.Contains(buff.ToString) Then
                    ListBox2.Items.Add(ListBox1.SelectedItem)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Timer1.Stop()
            MsgBox("Finished Scanning Folder!")
            TabControl1.SelectTab(1)
            If ListBox1.Items.Count = 0 Then
                MsgBox("No Threats Detected", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.SelectedPath = ("C:/")
        FolderBrowserDialog2.SelectedPath = ("D:/")
        Try
            For Each strdir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)
                For Each strfile As String In System.IO.Directory.GetFiles(strdir)
                    ListBox1.Items.Add(strfile)
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FolderBrowserDialog1.ShowDialog()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        TabControl1.SelectTab(0)
        Try
            For Each strdir As String In System.IO.Directory.GetDirectories(FolderBrowserDialog1.SelectedPath)
                For Each strfile As String In System.IO.Directory.GetFiles(strdir)
                    ListBox1.Items.Add(strfile)
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If Not ListBox2.Items.Count = 0 Then
                ListBox2.SelectedIndex += 1
                Kill(ListBox1.SelectedItem)
            Else
                Timer1.Stop()
                Timer2.Stop()
                MsgBox("Threat was removed Successfully!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Kill(ListBox2.SelectedItem)
            ListBox2.Items.RemoveAt(ListBox2.SelectedItem)
            MsgBox("Removed Successfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("No Virus was detected to be deleted!", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer2.Start()
    End Sub
End Class
