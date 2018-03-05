Imports System.IO

Public Class ConfigManager

    ' Variables
    Public fullScreenEnabled As Boolean = True
    Public launchWoW32 As Boolean = False
    Public terrainHighlights As Boolean = False
    Public trilinearFiltering As Boolean = True
    Public useHardwareSound As Boolean = False
    Public terrainTextureDetail As Integer = 0
    Public textureFilteringLevel As Integer = 1
    Public soundChannels As Integer = 0
    Public locale As String = "enGB"
    Public force32Bit As Boolean = False
    Public realmlistAdress As String = Net.IPAddress.Parse("127.0.0.1").ToString

    ' Config Variables
    Dim wow32Variable As String = "run32BitClient"
    Dim windowModeVariable As String = "gxWindow"
    Dim hardwareSoundVariable As String = "Sound_EnableHardware"
    Dim textureFilteringVariable As String = "textureFilteringMode"
    Dim soundChannelVariable As String = "Sound_NumChannels"
    Dim baseMipVariable As String = "baseMip"
    Dim terrainMipVariable As String = "terrainMipLevel"
    Dim componentTextureVariable As String = "componentTextureLevel"
    Dim localeVariable As String = "locale"
    Dim realmlistVariable As String = "realmlist"
    Dim patchlistVariable As String = "patchlist"

    ' File Paths
    Dim launcherConfigPath As String = Directory.GetCurrentDirectory + "\WTF\Launcher.wtf"
    Dim gameConfigPath As String = Directory.GetCurrentDirectory + "\WTF\Config.wtf"

    Public Sub LoadGameConfiguration()
        If File.Exists(gameConfigPath) Then
            Dim reader As New StreamReader(gameConfigPath)
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                ' Full Screen Mode
                If line.Contains(windowModeVariable) And line.Contains("1") Then
                    fullScreenEnabled = False
                End If
                ' Hardware Sound
                If line.Contains(hardwareSoundVariable) And line.Contains("1") Then
                    useHardwareSound = True
                End If
                ' Trilinear Filtering
                If line.Contains(textureFilteringVariable) Then
                    trilinearFiltering = False
                End If

                ' Sound Channels
                If line.Contains(soundChannelVariable) And line.Contains("16") Then
                    soundChannels = 0
                ElseIf line.Contains(soundChannelVariable) And line.Contains("32") Then
                    soundChannels = 1
                ElseIf line.Contains(soundChannelVariable) And line.Contains("64") Then
                    soundChannels = 2
                End If

                ' Texture Filter Level
                If line.Contains(textureFilteringVariable) And line.Contains("2") Then
                    textureFilteringLevel = 0
                ElseIf line.Contains(textureFilteringVariable) And line.Contains("3") Then
                    textureFilteringLevel = 1
                ElseIf line.Contains(textureFilteringVariable) And line.Contains("4") Then
                    textureFilteringLevel = 2
                ElseIf line.Contains(textureFilteringVariable) And line.Contains("5") Then
                    textureFilteringLevel = 3
                End If

                ' Texture Detail Level
                If line.Contains(baseMipVariable) Then
                    terrainTextureDetail = 0
                ElseIf line.Contains(componentTextureVariable) Then
                    terrainTextureDetail = 3
                ElseIf line.Contains(terrainMipVariable) Then
                    terrainTextureDetail = 2
                End If

                If line.Contains(localeVariable) Then
                    locale = line.Replace("SET locale ", "").Replace("""", "").Replace(" ", "")
                End If

            End While
            reader.Close()
        Else
            ' If we cannot find a config when loading the preferences, we create a default config
            ResetGameConfiguration()
        End If
    End Sub

    Public Sub LoadLauncherConfiguration()
        If File.Exists(launcherConfigPath) Then
            Using reader As New StreamReader(launcherConfigPath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    If line.Contains("run32BitClient") And line.Contains("1") Then
                        launchWoW32 = True
                    End If
                    If line.Contains("realmlist") Then
                        realmlistAdress = line.Replace("SET realmlist ", "").Replace("""", "")
                    End If
                End While
                reader.Close()
            End Using
        End If
    End Sub

    Public Sub UpdateGameConfiguration()
        If File.Exists(gameConfigPath) Then
            ' Full Screen Mode
            If fullScreenEnabled Then
                ReplaceLineContent(gameConfigPath, windowModeVariable, "SET gxWindow ""0""")
            Else
                ReplaceLineContent(gameConfigPath, windowModeVariable, "SET gxWindow ""1""")
            End If
            ' Hardware Sound
            If useHardwareSound Then
                ReplaceLineContent(gameConfigPath, hardwareSoundVariable, "SET Sound_EnableHardware ""1""")
            Else
                ReplaceLineContent(gameConfigPath, hardwareSoundVariable, "SET Sound_EnableHardware ""0""")
            End If
            ' Trilinear Filtering
            If trilinearFiltering Then
                ReplaceLineContent(gameConfigPath, textureFilteringVariable, "", True)
            End If
            ' Sound Channels
            If soundChannels.Equals(0) Then
                ReplaceLineContent(gameConfigPath, soundChannelVariable, "SET Sound_NumChannels ""16""")
            ElseIf soundChannels.Equals(1) Then
                ReplaceLineContent(gameConfigPath, soundChannelVariable, "SET Sound_NumChannels ""32""")
            ElseIf soundChannels.Equals(2) Then
                ReplaceLineContent(gameConfigPath, soundChannelVariable, "SET Sound_NumChannels ""64""")
            End If
            ' Terrain Texture Details
            If terrainTextureDetail.Equals(0) Then
                ReplaceLineContent(gameConfigPath, baseMipVariable, "SET baseMip ""1""")
                ReplaceLineContent(gameConfigPath, terrainMipVariable, "", True)
                ReplaceLineContent(gameConfigPath, componentTextureVariable, "", True)
            ElseIf terrainTextureDetail.Equals(1) Then
                ReplaceLineContent(gameConfigPath, baseMipVariable, "", True)
                ReplaceLineContent(gameConfigPath, terrainMipVariable, "", True)
                ReplaceLineContent(gameConfigPath, componentTextureVariable, "", True)
            ElseIf terrainTextureDetail.Equals(2) Then
                ReplaceLineContent(gameConfigPath, baseMipVariable, "", True)
                ReplaceLineContent(gameConfigPath, terrainMipVariable, "SET terrainMipLevel ""0""")
                ReplaceLineContent(gameConfigPath, componentTextureVariable, "", True)
            ElseIf terrainTextureDetail.Equals(3) Then
                ReplaceLineContent(gameConfigPath, baseMipVariable, "", True)
                ReplaceLineContent(gameConfigPath, terrainMipVariable, "SET terrainMipLevel ""0""")
                ReplaceLineContent(gameConfigPath, componentTextureVariable, "SET componentTextureLevel ""9""")
            End If
            If Not trilinearFiltering Then
                If textureFilteringLevel.Equals(0) Then
                    ReplaceLineContent(gameConfigPath, textureFilteringVariable, "SET textureFilteringMode ""2""")
                ElseIf textureFilteringLevel.Equals(1) Then
                    ReplaceLineContent(gameConfigPath, textureFilteringVariable, "SET textureFilteringMode ""3""")
                ElseIf textureFilteringLevel.Equals(2) Then
                    ReplaceLineContent(gameConfigPath, textureFilteringVariable, "SET textureFilteringMode ""4""")
                ElseIf textureFilteringLevel.Equals(3) Then
                    ReplaceLineContent(gameConfigPath, textureFilteringVariable, "SET textureFilteringMode ""5""")
                End If
            End If
        End If
    End Sub

    Public Sub UpdateLauncherConfiguration()
        If File.Exists(launcherConfigPath) Then
            If launchWoW32 Then
                ReplaceLineContent(launcherConfigPath, wow32Variable, "SET run32BitClient ""1""")
            Else
                ReplaceLineContent(launcherConfigPath, wow32Variable, "SET run32BitClient ""0""")
            End If

            ReplaceLineContent(launcherConfigPath, realmlistVariable, "SET realmlist """ + realmlistAdress + """")
        End If
    End Sub

    Public Sub UpdateRealmlistAdress()
        ' First we gonna check if we can find a realmlist.wtf file
        If Directory.Exists("Data") Then
            If Directory.Exists(Directory.GetCurrentDirectory + "\Data\" + locale) Then
                Dim realmlistPath As String = Directory.GetCurrentDirectory + "\Data\" + locale + "\realmlist.wtf"
                If File.Exists(realmlistPath) Then
                    ReplaceLineContent(realmlistPath, realmlistVariable, "SET realmlist " + realmlistAdress)
                    ReplaceLineContent(realmlistPath, patchlistVariable, "SET patchlist " + Net.IPAddress.Parse("127.0.0.1").ToString)
                Else
                    If File.Exists(gameConfigPath) Then
                        ReplaceLineContent(gameConfigPath, realmlistVariable, "SET realmlist """ + realmlistAdress + """")
                        ReplaceLineContent(gameConfigPath, patchlistVariable, "SET patchlist """ + Net.IPAddress.Parse("127.0.0.1").ToString + """")
                    End If
                End If
            End If
        Else
            '... else we gonna write the realmlist into the config.wtf file
            If File.Exists(gameConfigPath) Then
                ReplaceLineContent(gameConfigPath, realmlistVariable, "SET realmlist """, realmlistAdress + """")
                ReplaceLineContent(gameConfigPath, patchlistVariable, "SET patchlist """ + Net.IPAddress.Parse("127.0.0.1").ToString + """")
            End If
        End If
    End Sub

    Public Sub ResetGameConfiguration()
        If File.Exists(gameConfigPath) Then
            File.Delete(gameConfigPath)
        End If
        Dim writer As New System.IO.StreamWriter(gameConfigPath)
        writer.Write(My.Resources.Config)
        writer.Close()
    End Sub

    ' Helpers

    Public Sub ReplaceLineContent(configFile As String, variable As String, newContent As String, Optional skipNewContent As Boolean = False)
        Dim lines As New List(Of String)
        Using sr As New StreamReader(configFile)
            While Not sr.EndOfStream
                lines.Add(sr.ReadLine)
            End While
        End Using

        ' Remove old config line and add new one
        For Each line As String In lines
            If line.Contains(variable) Then
                lines.Remove(line)
                If Not skipNewContent Then
                    lines.Add(newContent)
                End If
                Exit For
            End If
            ' If we did not exit the loop yet, we suspect a missing variable so we add it
            If (line Is lines.Last()) Then
                If Not skipNewContent Then
                    lines.Add(newContent)
                End If
                Exit For
            End If
        Next

        Using sw As New StreamWriter(configFile)
            For Each line As String In lines
                sw.WriteLine(line)
            Next
        End Using
    End Sub

End Class
