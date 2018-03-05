Imports System
Imports System.Runtime.InteropServices

Namespace StormLibAPI
    ' StormLib functions
    Class StormLib
        <DllImport("StormLib.dll", EntryPoint:="SFileOpenArchive")>
        Public Shared Function SFileOpenArchive(
            ByVal szMpqName As String,
            ByVal dwPriority As UInteger,
            ByVal dwFlags As UInteger,
            ByRef phMpq As UInteger) As Boolean
        End Function

        <DllImport("StormLib.dll", EntryPoint:="SFileCloseArchive")>
        Public Shared Function SFileCloseArchive(
            ByVal hMpq As UInteger) As Boolean
        End Function

        <DllImport("StormLib.dll", EntryPoint:="SFileOpenFileEx")>
        Public Shared Function SFileOpenFileEx(
            ByVal hMpq As UInteger,
            ByVal szFileName As String,
            ByVal dwSearchScope As UInteger,
            ByRef phFile As UInteger) As Boolean
        End Function

        <DllImport("StormLib.dll", EntryPoint:="SFileReadFile")>
        Public Shared Function SFileReadFile(
            ByVal hFile As UInteger,
            ByVal lpBuffer As Byte(),
            ByVal dwToRead As UInteger,
            ByRef pdwRead As UInteger,
            ByVal lpOverlapped As IntPtr) As Boolean
        End Function

        <DllImport("StormLib.dll", EntryPoint:="SFileCloseFile")>
        Public Shared Function SFileCloseFile(
            ByVal hFile As IntPtr) As Boolean
        End Function

        <DllImport("StormLib.dll", EntryPoint:="SFileGetFileSize")>
        Public Shared Function SFileGetFileSize(
            ByVal hFile As UInteger,
            ByRef lpFileSizeHigh As UInteger) As UInteger
        End Function
    End Class
End Namespace

