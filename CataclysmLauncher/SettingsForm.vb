Imports System.IO

Public Class SettingsForm
    ' Configuration Manager
    Dim configMgr As ConfigManager

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newPos As Point = MainWindow.Location
        newPos.X -= (Me.Width - MainWindow.Width) * 0.5
        newPos.Y -= (Me.Height - MainWindow.Height) * 0.5
        Me.Location = newPos
        Me.TopMost = True

        TextureDetailSlider.Parent = TextureDetailFiller
        TextureDetailSlider.Location = TextureDetailTrackerBackgroundBase.PointToClient(PointToScreen(TextureDetailSlider.Location))
        TextureDetailFiller.Parent = TextureDetailTrackerBackgroundBase
        TextureDetailFiller.Location = TextureDetailTrackerBackgroundBase.PointToClient(PointToScreen(TextureDetailFiller.Location))

        TextureFilteringSlider.Parent = TextureFilterFiller
        TextureFilteringSlider.Location = TextureFilteringTrackerBackgroundBase.PointToClient(PointToScreen(TextureFilteringSlider.Location))
        TextureFilterFiller.Parent = TextureFilteringTrackerBackgroundBase
        TextureFilterFiller.Location = TextureFilteringTrackerBackgroundBase.PointToClient(PointToScreen(TextureFilterFiller.Location))

        SoundChannelSlider.Parent = SoundChannelFiller
        SoundChannelSlider.Location = SoundChannelTrackerBackgroundBase.PointToClient(PointToScreen(SoundChannelSlider.Location))
        SoundChannelFiller.Parent = SoundChannelTrackerBackgroundBase
        SoundChannelFiller.Location = SoundChannelTrackerBackgroundBase.PointToClient(PointToScreen(SoundChannelFiller.Location))

        configMgr = MainWindow.configMgr

        InitializeElements()
    End Sub


    Public Sub DisableResetPreferencesButton()
        RemoveHandler RestoreButton.MouseEnter, AddressOf RestoreButton_MouseEnter
        RemoveHandler RestoreButton.MouseDown, AddressOf RestoreButton_MouseDown
        RemoveHandler RestoreButton.MouseLeave, AddressOf RestoreButton_MouseLeave
        RemoveHandler RestoreButton.MouseUp, AddressOf RestoreButton_MouseUp
        RemoveHandler RestoreButton.Click, AddressOf RestoreButton_Click
        RestoreButton.BackgroundImage = My.Resources.restoreButtonDisabled
    End Sub

    Public Sub InitializeElements()
        ' If we have 64 bit as parameter we are going to check for a existing wow-64.exe
        ' If we have 64 bit enabled but no wow.exe we are setting the game to 32 bit by default
        If Not File.Exists("wow-64.exe") Then
            configMgr.launchWoW32 = True
            configMgr.force32Bit = True
            BitTickBox.Image = My.Resources.tickGray
            RemoveHandler BitTickBox.MouseEnter, AddressOf BitTickBox_MouseEnter
            RemoveHandler BitTickBox.MouseDown, AddressOf BitTickBox_MouseDown
            RemoveHandler BitTickBox.MouseLeave, AddressOf BitTickBox_MouseLeave
            RemoveHandler BitTickBox.MouseUp, AddressOf BitTickBox_MouseUp
            RemoveHandler BitTickBox.Click, AddressOf BitTickBox_Click
        End If

        If configMgr.launchWoW32 And Not configMgr.force32Bit Then
            BitTickBox.Image = My.Resources.tickGold
        End If

        'Full Screen Tick Box
        If configMgr.fullScreenEnabled Then
            FullScreenTickbox.Image = My.Resources.tickGold
        End If

        ' Hardware Sound Tick Box
        If configMgr.useHardwareSound Then
            SoundHardwareTickbox.Image = My.Resources.tickGold
        End If

        ' Trilinear Filtering Tick Box
        If configMgr.trilinearFiltering Then
            TrilinearFilteintTickbox.Image = My.Resources.tickGold
        End If

        Dim position As Point = SoundChannelTrackerBackgroundBase.Location
        position.X = position.X + (84 * configMgr.soundChannels)
        SoundChannelSlider.Location = position
        SoundChannelSlider.Location = SoundChannelTrackerBackgroundBase.PointToClient(PointToScreen(SoundChannelSlider.Location))
        SoundChannelFiller.Width = (84 * configMgr.soundChannels) + 12

        position = TextureDetailTrackerBackgroundBase.Location
        position.X = position.X + (56 * configMgr.terrainTextureDetail)
        TextureDetailSlider.Location = position
        TextureDetailSlider.Location = TextureDetailTrackerBackgroundBase.PointToClient(PointToScreen(TextureDetailSlider.Location))
        TextureDetailFiller.Width = (56 * configMgr.terrainTextureDetail) + 12

        position = TextureFilteringTrackerBackgroundBase.Location
        position.X = position.X + (56 * configMgr.textureFilteringLevel)
        TextureFilteringSlider.Location = position
        TextureFilteringSlider.Location = TextureFilteringTrackerBackgroundBase.PointToClient(PointToScreen(TextureFilteringSlider.Location))
        TextureFilterFiller.Width = (56 * configMgr.textureFilteringLevel) + 12
    End Sub

    ' Full Screen Tick Box
    Private Sub FullScreenTickBox_MouseEnter(sender As Object, e As EventArgs) Handles FullScreenTickbox.MouseEnter
        FullScreenTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub FullScreenTickBox_MouseLeave(sender As Object, e As EventArgs) Handles FullScreenTickbox.MouseLeave
        FullScreenTickbox.BackgroundImage = My.Resources.TickBoxBase
    End Sub

    Private Sub FullScreenTickBox_MouseDown(sender As Object, e As MouseEventArgs) Handles FullScreenTickbox.MouseDown
        FullScreenTickbox.BackgroundImage = My.Resources.TickBoxDown
    End Sub

    Private Sub FullScreenTickBox_MouseUp(sender As Object, e As MouseEventArgs) Handles FullScreenTickbox.MouseUp
        FullScreenTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub FullScreenTickBox_Click(sender As Object, e As EventArgs) Handles FullScreenTickbox.Click
        If configMgr.fullScreenEnabled Then
            configMgr.fullScreenEnabled = False
            FullScreenTickbox.Image = Nothing
        Else
            configMgr.fullScreenEnabled = True
            FullScreenTickbox.Image = My.Resources.tickGold
        End If
    End Sub

    ' Sound Hardware Tick Box
    Private Sub SoundHardwareTickbox_MouseEnter(sender As Object, e As EventArgs) Handles SoundHardwareTickbox.MouseEnter
        SoundHardwareTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub SoundHardwareTickbox_MouseLeave(sender As Object, e As EventArgs) Handles SoundHardwareTickbox.MouseLeave
        SoundHardwareTickbox.BackgroundImage = My.Resources.TickBoxBase
    End Sub

    Private Sub SoundHardwareTickbox_MouseDown(sender As Object, e As MouseEventArgs) Handles SoundHardwareTickbox.MouseDown
        SoundHardwareTickbox.BackgroundImage = My.Resources.TickBoxDown
    End Sub

    Private Sub SoundHardwareTickbox_MouseUp(sender As Object, e As MouseEventArgs) Handles SoundHardwareTickbox.MouseUp
        SoundHardwareTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub SoundHardwareTickbox_Click(sender As Object, e As EventArgs) Handles SoundHardwareTickbox.Click
        If configMgr.useHardwareSound Then
            configMgr.useHardwareSound = False
            SoundHardwareTickbox.Image = Nothing
        Else
            configMgr.useHardwareSound = True
            SoundHardwareTickbox.Image = My.Resources.tickGold
        End If
    End Sub

    ' Trilinear Filtering Tick Box
    Private Sub TrilinearFilteintTickbox_MouseEnter(sender As Object, e As EventArgs) Handles TrilinearFilteintTickbox.MouseEnter
        TrilinearFilteintTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub TrilinearFilteintTickbox_MouseLeave(sender As Object, e As EventArgs) Handles TrilinearFilteintTickbox.MouseLeave
        TrilinearFilteintTickbox.BackgroundImage = My.Resources.TickBoxBase
    End Sub

    Private Sub TrilinearFilteintTickbox_MouseDown(sender As Object, e As MouseEventArgs) Handles TrilinearFilteintTickbox.MouseDown
        TrilinearFilteintTickbox.BackgroundImage = My.Resources.TickBoxDown
    End Sub

    Private Sub TrilinearFilteintTickbox_MouseUp(sender As Object, e As MouseEventArgs) Handles TrilinearFilteintTickbox.MouseUp
        TrilinearFilteintTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub TrilinearFilteintTickbox_Click(sender As Object, e As EventArgs) Handles TrilinearFilteintTickbox.Click
        If configMgr.trilinearFiltering Then
            configMgr.trilinearFiltering = False
            TrilinearFilteintTickbox.Image = Nothing
        Else
            configMgr.trilinearFiltering = True
            TrilinearFilteintTickbox.Image = My.Resources.tickGold
            Dim position As Point = TextureFilteringTrackerBackgroundBase.Location
            configMgr.textureFilteringLevel = 0
            TextureFilteringSlider.Location = TextureFilteringTrackerBackgroundBase.PointToClient(PointToScreen(TextureFilteringTrackerBackgroundBase.Location))
            TextureFilterFiller.Width = (56 * configMgr.textureFilteringLevel) + 12
        End If
    End Sub

    ' 32 Bit Tick Box
    Private Sub BitTickBox_MouseEnter(sender As Object, e As EventArgs) Handles BitTickBox.MouseEnter
        BitTickBox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub BitTickBox_MouseLeave(sender As Object, e As EventArgs) Handles BitTickBox.MouseLeave
        BitTickBox.BackgroundImage = My.Resources.TickBoxBase
    End Sub

    Private Sub BitTickBox_MouseDown(sender As Object, e As MouseEventArgs) Handles BitTickBox.MouseDown
        BitTickBox.BackgroundImage = My.Resources.TickBoxDown
    End Sub

    Private Sub BitTickBox_MouseUp(sender As Object, e As MouseEventArgs) Handles BitTickBox.MouseUp
        BitTickBox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub BitTickBox_Click(sender As Object, e As EventArgs) Handles BitTickBox.Click
        If configMgr.launchWoW32 Then
            configMgr.launchWoW32 = False
            BitTickBox.Image = Nothing
        Else
            configMgr.launchWoW32 = True
            BitTickBox.Image = My.Resources.tickGold
        End If
    End Sub

    ' Terrain Highlights Tickbox
    Private Sub TerrainHighlightsTickbox_MouseEnter(sender As Object, e As EventArgs) Handles TerrainHighlightsTickbox.MouseEnter
        TerrainHighlightsTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub TerrainHighlightsTickbox_MouseLeave(sender As Object, e As EventArgs) Handles TerrainHighlightsTickbox.MouseLeave
        TerrainHighlightsTickbox.BackgroundImage = My.Resources.TickBoxBase
    End Sub

    Private Sub TerrainHighlightsTickbox_MouseDown(sender As Object, e As MouseEventArgs) Handles TerrainHighlightsTickbox.MouseDown
        TerrainHighlightsTickbox.BackgroundImage = My.Resources.TickBoxDown
    End Sub

    Private Sub TerrainHighlightsTickbox_MouseUp(sender As Object, e As MouseEventArgs) Handles TerrainHighlightsTickbox.MouseUp
        TerrainHighlightsTickbox.BackgroundImage = My.Resources.TickBoxHover
    End Sub

    Private Sub TerrainHighlightsTickbox_Click(sender As Object, e As EventArgs) Handles TerrainHighlightsTickbox.Click
        If configMgr.terrainHighlights Then
            configMgr.terrainHighlights = False
            TerrainHighlightsTickbox.Image = Nothing
        Else
            configMgr.terrainHighlights = True
            TerrainHighlightsTickbox.Image = My.Resources.tickGold
        End If
    End Sub

    ' Cancel Button
    Private Sub CancelButton_MouseEnter(sender As Object, e As EventArgs) Handles CancelButton.MouseEnter
        CancelButton.BackgroundImage = My.Resources.cancelButtonHover
    End Sub

    Private Sub CancelButton_MouseDown(sender As Object, e As MouseEventArgs) Handles CancelButton.MouseDown
        CancelButton.BackgroundImage = My.Resources.cancelButtonDown
    End Sub

    Private Sub CancelButton_MouseUp(sender As Object, e As MouseEventArgs) Handles CancelButton.MouseUp
        CancelButton.BackgroundImage = My.Resources.cancelButtonHover
    End Sub

    Private Sub CancelButton_MouseLeave(sender As Object, e As EventArgs) Handles CancelButton.MouseLeave
        CancelButton.BackgroundImage = My.Resources.cancelButtonBase
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainWindow.RemoveGrayForm()
        MyBase.Close()
    End Sub

    ' Ok Button
    Private Sub OkButton_MouseEnter(sender As Object, e As EventArgs) Handles OkButton.MouseEnter
        OkButton.BackgroundImage = My.Resources.okButtonHover
    End Sub

    Private Sub OkButton_MouseDown(sender As Object, e As MouseEventArgs) Handles OkButton.MouseDown
        OkButton.BackgroundImage = My.Resources.okButtonDown
    End Sub

    Private Sub OkButton_MouseUp(sender As Object, e As MouseEventArgs) Handles OkButton.MouseUp
        OkButton.BackgroundImage = My.Resources.okButtonHover
    End Sub

    Private Sub OkButton_MouseLeave(sender As Object, e As EventArgs) Handles OkButton.MouseLeave
        OkButton.BackgroundImage = My.Resources.okButtonBase
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        configMgr.UpdateLauncherConfiguration()
        configMgr.UpdateGameConfiguration()
        MainWindow.RemoveGrayForm()
        MyBase.Close()
    End Sub

    ' Reset Game Preferences Buttom
    Private Sub RestoreButton_Click(sender As Object, e As EventArgs) Handles RestoreButton.Click
        Me.TopMost = False
        GrayLayerForm.BringToFront()
        RestoreDefaultSettingForm.Show()
        Dim newPos As Point = Me.Location
        newPos.X += (Me.Width - RestoreDefaultSettingForm.Width) * 0.5
        newPos.Y += (Me.Height - RestoreDefaultSettingForm.Height) * 0.5
        RestoreDefaultSettingForm.Location = newPos
    End Sub

    Private Sub RestoreButton_MouseEnter(sender As Object, e As EventArgs) Handles RestoreButton.MouseEnter
        RestoreButton.BackgroundImage = My.Resources.restoreButtonHover
    End Sub

    Private Sub RestoreButton_MouseDown(sender As Object, e As MouseEventArgs) Handles RestoreButton.MouseDown
        RestoreButton.BackgroundImage = My.Resources.restoreButtonDown
    End Sub

    Private Sub RestoreButton_MouseUp(sender As Object, e As MouseEventArgs) Handles RestoreButton.MouseUp
        RestoreButton.BackgroundImage = My.Resources.restoreButtonHover
    End Sub

    Private Sub RestoreButton_MouseLeave(sender As Object, e As EventArgs) Handles RestoreButton.MouseLeave
        RestoreButton.BackgroundImage = My.Resources.restoreButtonBase
    End Sub

    ' Slider Variables
    Dim drag As Boolean = False

    ' Sound Channel Slider
    Private Sub SoundChannelSlider_MouseEnter(sender As Object, e As EventArgs) Handles SoundChannelSlider.MouseEnter
        SoundChannelSlider.BackgroundImage = My.Resources.trackerSliderHover
    End Sub

    Private Sub SoundChannelSlider_MouseLeave(sender As Object, e As EventArgs) Handles SoundChannelSlider.MouseLeave
        SoundChannelSlider.BackgroundImage = My.Resources.trackerSliderBase
    End Sub

    Private Sub SoundChannelSlider_MouseDown(sender As Object, e As MouseEventArgs) Handles SoundChannelSlider.MouseDown
        SoundChannelSlider.BackgroundImage = My.Resources.trackerSliderDown
        drag = True
    End Sub

    Private Sub SoundChannelSlider_MouseUp(sender As Object, e As MouseEventArgs) Handles SoundChannelSlider.MouseUp
        SoundChannelSlider.BackgroundImage = My.Resources.trackerSliderHover
        drag = False
    End Sub

    Private Sub SoundChannelSlider_MouseMove(sender As Object, e As MouseEventArgs) Handles SoundChannelSlider.MouseMove
        If drag Then
            Dim stepSize As Integer = 84
            Dim position As Point = SoundChannelTrackerBackgroundBase.Location
            If e.X >= stepSize And configMgr.soundChannels < 2 Then
                position.X = position.X + stepSize * (configMgr.soundChannels + 1)
                SoundChannelSlider.Location = position
                SoundChannelSlider.Location = SoundChannelTrackerBackgroundBase.PointToClient(PointToScreen(SoundChannelSlider.Location))
                configMgr.soundChannels += 1
                SoundChannelFiller.Width = (stepSize * configMgr.soundChannels) + 12
            ElseIf e.X <= -stepSize And configMgr.soundChannels > 0 Then
                position.X = position.X + stepSize * (configMgr.soundChannels - 1)
                SoundChannelSlider.Location = position
                SoundChannelSlider.Location = SoundChannelTrackerBackgroundBase.PointToClient(PointToScreen(SoundChannelSlider.Location))
                configMgr.soundChannels -= 1
                SoundChannelFiller.Width = (stepSize * configMgr.soundChannels) + 12
            End If
        End If
    End Sub

    ' Terrain Texture Slider
    Private Sub TextureDetailSlider_MouseEnter(sender As Object, e As EventArgs) Handles TextureDetailSlider.MouseEnter
        TextureDetailSlider.BackgroundImage = My.Resources.trackerSliderHover
    End Sub

    Private Sub TextureDetailSlider_MouseLeave(sender As Object, e As EventArgs) Handles TextureDetailSlider.MouseLeave
        TextureDetailSlider.BackgroundImage = My.Resources.trackerSliderBase
    End Sub

    Private Sub TextureDetailSlider_MouseDown(sender As Object, e As MouseEventArgs) Handles TextureDetailSlider.MouseDown
        TextureDetailSlider.BackgroundImage = My.Resources.trackerSliderDown
        drag = True
    End Sub

    Private Sub TextureDetailSlider_MouseUp(sender As Object, e As MouseEventArgs) Handles TextureDetailSlider.MouseUp
        TextureDetailSlider.BackgroundImage = My.Resources.trackerSliderHover
        drag = False
    End Sub

    Private Sub TextureDetailSlider_MouseMove(sender As Object, e As MouseEventArgs) Handles TextureDetailSlider.MouseMove
        If drag Then
            Dim stepSize As Integer = 56
            Dim position As Point = TextureDetailTrackerBackgroundBase.Location
            If e.X >= stepSize And configMgr.terrainTextureDetail < 3 Then
                position.X = position.X + stepSize * (configMgr.terrainTextureDetail + 1)
                TextureDetailSlider.Location = position
                TextureDetailSlider.Location = TextureDetailTrackerBackgroundBase.PointToClient(PointToScreen(TextureDetailSlider.Location))
                configMgr.terrainTextureDetail += 1
                TextureDetailFiller.Width = (stepSize * configMgr.terrainTextureDetail) + 12
            ElseIf e.X <= -stepSize And configMgr.terrainTextureDetail > 0 Then
                position.X = position.X + stepSize * (configMgr.terrainTextureDetail - 1)
                TextureDetailSlider.Location = position
                TextureDetailSlider.Location = TextureDetailTrackerBackgroundBase.PointToClient(PointToScreen(TextureDetailSlider.Location))
                configMgr.terrainTextureDetail -= 1
                TextureDetailFiller.Width = (stepSize * configMgr.terrainTextureDetail) + 12
            End If
        End If
    End Sub

    ' Texture Filter Slider
    Private Sub TextureFilteringSlider_MouseEnter(sender As Object, e As EventArgs) Handles TextureFilteringSlider.MouseEnter
        TextureFilteringSlider.BackgroundImage = My.Resources.trackerSliderHover
    End Sub

    Private Sub TextureFilteringSlider_MouseLeave(sender As Object, e As EventArgs) Handles TextureFilteringSlider.MouseLeave
        TextureFilteringSlider.BackgroundImage = My.Resources.trackerSliderBase
    End Sub

    Private Sub TextureFilteringSlider_MouseDown(sender As Object, e As MouseEventArgs) Handles TextureFilteringSlider.MouseDown
        TextureFilteringSlider.BackgroundImage = My.Resources.trackerSliderDown
        drag = True
    End Sub

    Private Sub TextureFilteringSlider_MouseUp(sender As Object, e As MouseEventArgs) Handles TextureFilteringSlider.MouseUp
        TextureFilteringSlider.BackgroundImage = My.Resources.trackerSliderHover
        drag = False
    End Sub

    Private Sub TextureFilteringSlider_MouseMove(sender As Object, e As MouseEventArgs) Handles TextureFilteringSlider.MouseMove
        If drag Then
            Dim stepSize As Integer = 56
            Dim position As Point = TextureFilteringTrackerBackgroundBase.Location
            If e.X >= stepSize And configMgr.textureFilteringLevel < 3 Then
                position.X = position.X + stepSize * (configMgr.textureFilteringLevel + 1)
                TextureFilteringSlider.Location = position
                TextureFilteringSlider.Location = TextureFilteringTrackerBackgroundBase.PointToClient(PointToScreen(TextureFilteringSlider.Location))
                configMgr.textureFilteringLevel += 1
                TextureFilterFiller.Width = (stepSize * configMgr.textureFilteringLevel) + 12
                configMgr.trilinearFiltering = False
                TrilinearFilteintTickbox.Image = Nothing
            ElseIf e.X <= -stepSize And configMgr.textureFilteringLevel > 0 Then
                position.X = position.X + stepSize * (configMgr.textureFilteringLevel - 1)
                TextureFilteringSlider.Location = position
                TextureFilteringSlider.Location = TextureFilteringTrackerBackgroundBase.PointToClient(PointToScreen(TextureFilteringSlider.Location))
                configMgr.textureFilteringLevel -= 1
                TextureFilterFiller.Width = (stepSize * configMgr.textureFilteringLevel) + 12
                configMgr.trilinearFiltering = False
                TrilinearFilteintTickbox.Image = Nothing
            End If
        End If
    End Sub
End Class
