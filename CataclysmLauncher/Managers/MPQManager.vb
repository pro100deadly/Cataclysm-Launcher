Imports System.IO
Imports CataclysmLauncher.StormLibAPI

Public Class MPQManager

    Private hMPQ As Integer = 0
    Private hFile As Integer = 0
    Private FileSize As Integer = 0
    Private FileRead As Integer = 0
    Private extractedFiles As New ArrayList()

    Public Sub ExtractMPQContent(MPQFilePath As String)
        ' Create StormLib libary file to extract the MPQ content
        File.WriteAllBytes("StormLib.dll", My.Resources.StormLib)

        ' Opening base-win.MPQ
        If StormLib.SFileOpenArchive(MPQFilePath, 0, 0, hMPQ).Equals(False) Then
            Return
        End If

        If StormLib.SFileOpenFileEx(hMPQ, "(listfile)", 0, hFile).Equals(False) Then
            StormLib.SFileCloseArchive(hMPQ)
            Return
        End If

        FileSize = StormLib.SFileGetFileSize(hFile, FileSize)

        Dim buffer As Byte()
        buffer = New Byte(FileSize - 1) {}
        If StormLib.SFileReadFile(hFile, buffer, FileSize, FileRead, IntPtr.Zero).Equals(False) Then
            StormLib.SFileCloseFile(hFile)
            StormLib.SFileCloseArchive(hMPQ)
            Return
        End If

        StormLib.SFileCloseFile(hFile)
        Dim enc As New System.Text.ASCIIEncoding()
        Dim list As String = enc.GetString(buffer)
        Dim segs As String()

        For Each file As String In list.Split(Chr(10))
            If file = "" Then
                Return
            End If

            If Me.extractedFiles.Contains(file) Then
                Continue For
            End If
            segs = file.Split("\"c)

            If StormLib.SFileOpenFileEx(hMPQ, file.Trim(), 0, hFile).Equals(False) Then
                Continue For
            End If

            FileSize = StormLib.SFileGetFileSize(hFile, FileSize)
            If FileSize = 0 Then
                Continue For
            End If
            buffer = New Byte(FileSize - 1) {}
            If StormLib.SFileReadFile(hFile, buffer, CInt(FileSize), FileRead, IntPtr.Zero).Equals(False) Then
                StormLib.SFileCloseFile(hFile)
                Continue For
            End If

            Dim fs As FileStream
            fs = New FileStream(file.Trim(), FileMode.Create, FileAccess.Write)

            fs.Write(buffer, 0, FileSize)
            fs.Flush()
            fs.Close()
            Me.extractedFiles.Add(file)
        Next


        StormLib.SFileCloseArchive(hMPQ)

    End Sub

End Class
