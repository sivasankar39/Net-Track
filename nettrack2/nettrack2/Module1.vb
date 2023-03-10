Imports System.Security.Cryptography
Imports System.IO.Compression
Imports System.Text
Imports System.IO
Imports Microsoft.Win32

Module Module1
    Public Function ContentLink(ByVal url As String) As String
        Return New System.Net.WebClient().DownloadString(url)
    End Function
    Public Function GetExtension(ByVal value As String) As String
        On Error GoTo Serious
        Dim regkey As RegistryKey
        Dim Ta1, Ta2 As String
        regkey = Registry.ClassesRoot.OpenSubKey(value, False)
        Ta1 = regkey.GetValue("")
        regkey = Registry.ClassesRoot.OpenSubKey(Ta1, False)
        Ta2 = regkey.GetValue("")
        Return Ta2
        GoTo SafeArea
Serious:
        If value = "" Then Return "Unknown" Else Return value
SafeArea:
    End Function
    Public Function GetBytes(ByVal value As Decimal) As String
        Dim d As Decimal = value
        Dim tint As Integer
        tint = 0
        Dim blist As New List(Of String)
        blist.Add("B")
        blist.Add("KB")
        blist.Add("MB")
        blist.Add("GB")
        blist.Add("TB")
        If value >= 1024 Then
            Do While d >= 1024
                d /= 1024
                tint += 1
            Loop

        End If
        Return Math.Round(d, 2) & blist(tint)
    End Function
    Public Function GetMd5(ByVal Path As String) As String
        On Error Resume Next

        Dim Md5 As New MD5CryptoServiceProvider
        Dim FileS As New FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        Md5.ComputeHash(FileS)

        Dim mybuff As New StringBuilder
        Dim hashB As Byte

        For Each hashByte As Byte In Md5.hash
            mybuff.Append(String.Format("{0:X2}", hashB))
        Next
        Return mybuff.ToString.ToLower

    End Function
    Public Function GetFolders(ByVal path As String) As List(Of DirectoryInfo)
        On Error Resume Next
        Dim L As New List(Of DirectoryInfo)
        Dim D As New DirectoryInfo(path)
        L.Add(D)
        For Each DD As DirectoryInfo In D.GetDirectories("*.*", SearchOption.TopDirectoryOnly)
            L.AddRange(GetFolders(DD.FullName))
        Next
        Return L

    End Function
    Public Function SpecialDirectories() As List(Of String)
        On Error Resume Next
        Dim Folder_S As New List(Of String)
        Dim Folders As New List(Of DirectoryInfo)
        Dim d As DirectoryInfo
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Favorites, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Fonts, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Resources, Environment.SpecialFolderOption.None))
        Folder_S.Add(Environment.GetFolderPath(Environment.SpecialFolder.Windows, Environment.SpecialFolderOption.None))

        Return Folder_S
    End Function
End Module
