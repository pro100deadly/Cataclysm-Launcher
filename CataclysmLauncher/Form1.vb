Imports System.IO

Public Class MainWindow

    ' Download Server
    Dim DownloadServer As String = "http://ak.worldofwarcraft.com.edgesuite.net/wow-pod-retail/EU/15050.direct/"
    Dim launcherConfigPath As String = Directory.GetCurrentDirectory + "\WTF\Launcher.wtf"
    Dim configPath As String = Directory.GetCurrentDirectory + "\WTF\Config.wtf"
    Dim realmListFileName As String = "\realmlist.wtf"

    ' Patch Notes Tab
    Dim patchNotesTabOpened As Boolean = True

    ' Savemanager
    Public configMgr As ConfigManager

    ' Newsmanager
    Public newsManager As NewsManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check for existing WTF folder
        If Not Directory.Exists("WTF") Then
            Directory.CreateDirectory("WTF")
        End If

        ' Check for existing launcher.wtf config file and write new file if not existing
        If Not File.Exists(launcherConfigPath) Then
            My.Computer.FileSystem.WriteAllText(launcherConfigPath, My.Resources.Launcher, True)
        End If

        ' Load Config files
        configMgr = New ConfigManager
        configMgr.LoadLauncherConfiguration()
        configMgr.LoadGameConfiguration()

        ' Loads News content
        newsManager = New NewsManager
        newsManager.LoadPatchNotesContent()
        ' TODO: other news content

        ' Check for existing wow.exe
        If File.Exists("wow.exe") Or File.Exists("wow-64.exe") Then
            EnablePlayButton()
        Else
            ShowSetupOffering()
            DisablePlayButton()
        End If

        wowIcon.Parent = TopFrame
        wowVersionLabel.Parent = TopFrame

        InstallOfferingLable.Location = UpdateBackgroundImage.PointToClient(PointToScreen(InstallOfferingLable.Location))
        InstallOfferingLable.Parent = UpdateBackgroundImage
        InstallButton.Location = UpdateBackgroundImage.PointToClient(PointToScreen(InstallButton.Location))
        InstallButton.Parent = UpdateBackgroundImage

        PatchNotesLabel.Location = PatchNotesBackground.PointToClient(PointToScreen(PatchNotesLabel.Location))
        PatchNotesLabel.Parent = PatchNotesBackground

        PatchNotesLinkLabel.Location = PatchNotesBackground.PointToClient(PointToScreen(PatchNotesLinkLabel.Location))
        PatchNotesLinkLabel.Parent = PatchNotesBackground
    End Sub


    Private Sub ShowSetupOffering()
        InstallButton.Enabled = True
        InstallButton.Visible = True
        InstallOfferingLable.Enabled = True
        InstallOfferingLable.Visible = True
    End Sub

    Private Sub StartInstallation()
        UpdateBackgroundImage.BackgroundImage = My.Resources.BottomUpdatePatch
    End Sub

    Private Sub CreateConfig()

    End Sub

    Private Sub GetClientFiles()

    End Sub

    Private Sub DisablePlayButton()
        RemoveHandler PlayButton.MouseEnter, AddressOf PlayButton_MouseEnter
        RemoveHandler PlayButton.MouseDown, AddressOf PlayButton_MouseDown
        RemoveHandler PlayButton.MouseLeave, AddressOf PlayButton_MouseLeave
        RemoveHandler PlayButton.MouseUp, AddressOf PlayButton_MouseUp
        RemoveHandler PlayButton.Click, AddressOf PlayButton_Click
        PlayButton.BackgroundImage = My.Resources.PlayButtonDisabled
    End Sub

    Private Sub EnablePlayButton()
        AddHandler PlayButton.MouseEnter, AddressOf PlayButton_MouseEnter
        AddHandler PlayButton.MouseDown, AddressOf PlayButton_MouseDown
        AddHandler PlayButton.MouseLeave, AddressOf PlayButton_MouseLeave
        AddHandler PlayButton.MouseUp, AddressOf PlayButton_MouseUp
        AddHandler PlayButton.MouseClick, AddressOf PlayButton_Click
        PlayButton.BackgroundImage = My.Resources.PlayButtonBase
    End Sub

    ' Buttons

    ' ---- Close Button
    Private Sub CloseButton_MouseEnter(sender As Object, e As EventArgs) Handles CloseButton.MouseEnter
        CloseButton.BackgroundImage = My.Resources.CloseButtonHover
    End Sub

    Private Sub CloseButton_MouseLeave(sender As Object, e As EventArgs) Handles CloseButton.MouseLeave
        CloseButton.BackgroundImage = My.Resources.CloseButtonBase
    End Sub

    Private Sub CloseButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseDown
        CloseButton.BackgroundImage = My.Resources.CloseButtonDown
    End Sub

    Private Sub CloseButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseUp
        CloseButton.BackgroundImage = My.Resources.CloseButtonHover
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        MyBase.Close()
    End Sub

    ' ---- Minimize Button
    Private Sub MinimizeButton_MouseEnter(sender As Object, e As EventArgs) Handles MinimizeButton.MouseEnter
        MinimizeButton.BackgroundImage = My.Resources.MinimizeButtonHover
    End Sub

    Private Sub MinimizeButton_MouseLeave(sender As Object, e As EventArgs) Handles MinimizeButton.MouseLeave
        MinimizeButton.BackgroundImage = My.Resources.MinimizeButtonBase
    End Sub

    Private Sub MinimizeButton_MouseDown(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseDown
        MinimizeButton.BackgroundImage = My.Resources.MinimizeButtonDown
    End Sub

    Private Sub MinimizeButton_MouseUp(sender As Object, e As MouseEventArgs) Handles MinimizeButton.MouseUp
        MinimizeButton.BackgroundImage = My.Resources.MinimizeButtonHover
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        MyBase.WindowState = FormWindowState.Minimized
    End Sub

    ' --- PlayButton

    Private Sub PlayButton_MouseEnter(sender As Object, e As EventArgs) Handles PlayButton.MouseEnter
        PlayButton.BackgroundImage = My.Resources.PlayButtonHover
    End Sub

    Private Sub PlayButton_MouseDown(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseDown
        PlayButton.BackgroundImage = My.Resources.PlayButtonDown
    End Sub

    Private Sub PlayButton_MouseUp(sender As Object, e As MouseEventArgs) Handles PlayButton.MouseUp
        PlayButton.BackgroundImage = My.Resources.PlayButtonHover
    End Sub

    Private Sub PlayButton_MouseLeave(sender As Object, e As EventArgs) Handles PlayButton.MouseLeave
        PlayButton.BackgroundImage = My.Resources.PlayButtonBase
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        configMgr.UpdateRealmlistAdress()

        If File.Exists("wow.exe") And configMgr.launchWoW32 Then
            Process.Start("wow.exe")
        ElseIf File.Exists("wow-64.exe") Then
            Process.Start("wow-64.exe")
        End If
        MyBase.Close()
    End Sub

    ' Form Movement
    Dim drag As Boolean = False
    Dim x, y As Integer

    Private Sub TopFrame_MouseDown(sender As Object, e As MouseEventArgs) Handles TopFrame.MouseDown
        drag = True
        x = e.X
        y = e.Y
    End Sub

    Private Sub TopFrame_MouseMove(sender As Object, e As MouseEventArgs) Handles TopFrame.MouseMove
        If drag Then
            Me.Left = MousePosition.X - x
            Me.Top = MousePosition.Y - y
        End If
    End Sub

    Private Sub TopFrame_MouseUp(sender As Object, e As MouseEventArgs) Handles TopFrame.MouseUp
        drag = False
    End Sub

    Private Sub InstallButton_MouseEnter(sender As Object, e As EventArgs) Handles InstallButton.MouseEnter
        InstallButton.BackgroundImage = My.Resources.yesButtonHover
    End Sub

    Private Sub InstallButton_MouseDown(sender As Object, e As MouseEventArgs) Handles InstallButton.MouseDown
        InstallButton.BackgroundImage = My.Resources.yesButtonDown
    End Sub

    Private Sub InstallButton_MouseUp(sender As Object, e As MouseEventArgs) Handles InstallButton.MouseUp
        InstallButton.BackgroundImage = My.Resources.yesButtonHover
    End Sub

    Private Sub InstallButton_MouseLeave(sender As Object, e As EventArgs) Handles InstallButton.MouseLeave
        InstallButton.BackgroundImage = My.Resources.yesButtonBase
    End Sub

    Private Sub InstallButton_Click(sender As Object, e As EventArgs) Handles InstallButton.Click
        InstallButton.Visible = False
        InstallOfferingLable.Visible = False
        InstallButton.Enabled = False
        InstallOfferingLable.Enabled = False
        StartInstallation()
    End Sub

    Private Sub GameSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GrayOutForm()
        SettingsForm.Show()
    End Sub

    Private Sub SetRealmlistAdressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetRealmlistAdressToolStripMenuItem.Click
        GrayOutForm()
        RealmlistForm.Show()
    End Sub

    Public Sub GrayOutForm()
        GrayLayerForm.Size = Me.Size
        GrayLayerForm.Width -= 8
        GrayLayerForm.Show()
        GrayLayerForm.Location = Me.Location
        GrayLayerForm.Left += 4
    End Sub

    Public Sub RemoveGrayForm()
        GrayLayerForm.Hide()
    End Sub

    ' Patch Notes Tab
    Private Sub PatchNotesHeader_MouseEnter(sender As Object, e As EventArgs) Handles PatchNotesHeader.MouseEnter
        If Not patchNotesTabOpened Then
            PatchNotesHeader.BackgroundImage = My.Resources.patchNotesHeaderHover
        End If
    End Sub

    Private Sub PatchNotesHeader_MouseLeave(sender As Object, e As EventArgs) Handles PatchNotesHeader.MouseLeave
        If Not patchNotesTabOpened Then
            PatchNotesHeader.BackgroundImage = My.Resources.patchNotesHeaderBase
        End If
    End Sub

    Private Sub PatchNotesHeader_Click(sender As Object, e As EventArgs) Handles PatchNotesHeader.Click
        If Not patchNotesTabOpened Then
            PatchNotesHeader.BackgroundImage = My.Resources.patchNotesHeadMinimize
            PatchNotesBackground.Visible = True
            patchNotesTabOpened = True
        Else
            PatchNotesHeader.BackgroundImage = My.Resources.patchNotesHeaderHover
            PatchNotesBackground.Visible = False
            patchNotesTabOpened = False
        End If
    End Sub

    Private Sub PatchNotesLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PatchNotesLinkLabel.LinkClicked
        Process.Start(newsManager.patchNotesLink)
    End Sub

End Class
