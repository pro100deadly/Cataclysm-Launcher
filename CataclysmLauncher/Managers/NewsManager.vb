Imports System.Net

Public Class NewsManager

    ' CHANGEME: TEXT LINKS
    ' This links will contain the news text and the link to the patch notes.
    ' Change them to your wanted DIRECT download links for the text
    Public patchNotesNewsLink As String = "https://gist.githubusercontent.com/Ovahlord/990673ed64bf28b3c7fe73313a9d7968/raw/89d0fa658842cd4e51a6081359b9f090c843da70/gistfile1.txt"
    Public patchNotesLink As String = "https://gist.githubusercontent.com/Ovahlord/08e43460de124ee6fd381580dc7880c5/raw/0a5c63dc012d4d0f84a4f2922903a0709d24c914/gistfile1.txt"

    ' Web Clients
    Dim WithEvents patchNotesNewsClient As WebClient
    Dim WithEvents patchNotesLinkClient As WebClient

    Public Sub LoadPatchNotesContent()
        patchNotesNewsClient = New WebClient
        patchNotesLinkClient = New WebClient
        MainWindow.PatchNotesLabel.Text = "Loading patch notes news..."
        MainWindow.PatchNotesLinkLabel.Visible = False
        LoadPatchNotesText()
        LoadPatchNotesLink()
    End Sub

    Private Sub LoadPatchNotesText()
        patchNotesNewsClient.DownloadStringAsync(New Uri(patchNotesNewsLink))
    End Sub

    Private Sub LoadPatchNotesLink()
        patchNotesLinkClient.DownloadStringAsync(New Uri(patchNotesLink))
    End Sub

    ' Web Client Handlers
    Private Sub patchNotesNewsClient_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs) Handles patchNotesNewsClient.DownloadStringCompleted
        MainWindow.PatchNotesLabel.Text = e.Result
        patchNotesNewsClient.Dispose()
    End Sub

    Private Sub patchNotesLinkClient_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs) Handles patchNotesLinkClient.DownloadStringCompleted
        MainWindow.PatchNotesLinkLabel.Visible = True
        patchNotesLink = e.Result
        patchNotesLinkClient.Dispose()
    End Sub

End Class
