<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GameSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.OptionsMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.OptionsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetRealmlistAdressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.MainWindowImage = New System.Windows.Forms.PictureBox()
        Me.FrameBottom = New System.Windows.Forms.PictureBox()
        Me.RightFrame = New System.Windows.Forms.PictureBox()
        Me.LeftFrame = New System.Windows.Forms.PictureBox()
        Me.TopFrame = New System.Windows.Forms.PictureBox()
        Me.MenuStripbackgroundPictureBox = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.PlayButton = New System.Windows.Forms.PictureBox()
        Me.wowIcon = New System.Windows.Forms.PictureBox()
        Me.wowVersionLabel = New System.Windows.Forms.Label()
        Me.UpdateBackgroundImage = New System.Windows.Forms.PictureBox()
        Me.InstallOfferingLable = New System.Windows.Forms.Label()
        Me.InstallButton = New System.Windows.Forms.PictureBox()
        Me.PatchNotesHeader = New System.Windows.Forms.PictureBox()
        Me.PatchNotesBackground = New System.Windows.Forms.PictureBox()
        Me.PatchNotesLabel = New System.Windows.Forms.Label()
        Me.PatchNotesLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        GameSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsMenuStrip.SuspendLayout()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainWindowImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuStripbackgroundPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wowIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateBackgroundImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatchNotesHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatchNotesBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameSettingsToolStripMenuItem
        '
        GameSettingsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        GameSettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        GameSettingsToolStripMenuItem.Name = "GameSettingsToolStripMenuItem"
        GameSettingsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        GameSettingsToolStripMenuItem.Size = New System.Drawing.Size(186, 20)
        GameSettingsToolStripMenuItem.Text = "Game Preferences"
        AddHandler GameSettingsToolStripMenuItem.Click, AddressOf Me.GameSettingsToolStripMenuItem_Click
        '
        'OptionsMenuStrip
        '
        Me.OptionsMenuStrip.BackColor = System.Drawing.Color.Black
        Me.OptionsMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.OptionsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsMenuItem, Me.InfoToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.OptionsMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.OptionsMenuStrip.Location = New System.Drawing.Point(6, 28)
        Me.OptionsMenuStrip.Name = "OptionsMenuStrip"
        Me.OptionsMenuStrip.Size = New System.Drawing.Size(221, 24)
        Me.OptionsMenuStrip.TabIndex = 6
        Me.OptionsMenuStrip.Text = "MenuStrip1"
        '
        'OptionsMenuItem
        '
        Me.OptionsMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OptionsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OptionsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {GameSettingsToolStripMenuItem, Me.SetRealmlistAdressToolStripMenuItem})
        Me.OptionsMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsMenuItem.Name = "OptionsMenuItem"
        Me.OptionsMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.OptionsMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.OptionsMenuItem.Text = "Options"
        '
        'SetRealmlistAdressToolStripMenuItem
        '
        Me.SetRealmlistAdressToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.SetRealmlistAdressToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SetRealmlistAdressToolStripMenuItem.Name = "SetRealmlistAdressToolStripMenuItem"
        Me.SetRealmlistAdressToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.SetRealmlistAdressToolStripMenuItem.Size = New System.Drawing.Size(186, 20)
        Me.SetRealmlistAdressToolStripMenuItem.Text = "Set Realmlist Address"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.InfoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(32, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.CloseButtonBase
        Me.CloseButton.Location = New System.Drawing.Point(782, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 8
        Me.CloseButton.TabStop = False
        '
        'MainWindowImage
        '
        Me.MainWindowImage.BackColor = System.Drawing.Color.Fuchsia
        Me.MainWindowImage.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.MainWindowImagePatch
        Me.MainWindowImage.Location = New System.Drawing.Point(6, 50)
        Me.MainWindowImage.Name = "MainWindowImage"
        Me.MainWindowImage.Size = New System.Drawing.Size(800, 480)
        Me.MainWindowImage.TabIndex = 5
        Me.MainWindowImage.TabStop = False
        '
        'FrameBottom
        '
        Me.FrameBottom.BackColor = System.Drawing.Color.MediumOrchid
        Me.FrameBottom.BackgroundImage = CType(resources.GetObject("FrameBottom.BackgroundImage"), System.Drawing.Image)
        Me.FrameBottom.Location = New System.Drawing.Point(3, 649)
        Me.FrameBottom.Name = "FrameBottom"
        Me.FrameBottom.Size = New System.Drawing.Size(806, 4)
        Me.FrameBottom.TabIndex = 3
        Me.FrameBottom.TabStop = False
        '
        'RightFrame
        '
        Me.RightFrame.BackColor = System.Drawing.Color.Transparent
        Me.RightFrame.BackgroundImage = CType(resources.GetObject("RightFrame.BackgroundImage"), System.Drawing.Image)
        Me.RightFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightFrame.Location = New System.Drawing.Point(806, 0)
        Me.RightFrame.Name = "RightFrame"
        Me.RightFrame.Size = New System.Drawing.Size(3, 653)
        Me.RightFrame.TabIndex = 2
        Me.RightFrame.TabStop = False
        '
        'LeftFrame
        '
        Me.LeftFrame.BackColor = System.Drawing.Color.Transparent
        Me.LeftFrame.BackgroundImage = CType(resources.GetObject("LeftFrame.BackgroundImage"), System.Drawing.Image)
        Me.LeftFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftFrame.Location = New System.Drawing.Point(3, 0)
        Me.LeftFrame.Name = "LeftFrame"
        Me.LeftFrame.Size = New System.Drawing.Size(3, 653)
        Me.LeftFrame.TabIndex = 1
        Me.LeftFrame.TabStop = False
        '
        'TopFrame
        '
        Me.TopFrame.BackColor = System.Drawing.Color.Transparent
        Me.TopFrame.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.BorderMain
        Me.TopFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TopFrame.Location = New System.Drawing.Point(3, 0)
        Me.TopFrame.Name = "TopFrame"
        Me.TopFrame.Size = New System.Drawing.Size(806, 29)
        Me.TopFrame.TabIndex = 0
        Me.TopFrame.TabStop = False
        '
        'MenuStripbackgroundPictureBox
        '
        Me.MenuStripbackgroundPictureBox.BackColor = System.Drawing.Color.Black
        Me.MenuStripbackgroundPictureBox.Location = New System.Drawing.Point(6, 12)
        Me.MenuStripbackgroundPictureBox.Name = "MenuStripbackgroundPictureBox"
        Me.MenuStripbackgroundPictureBox.Size = New System.Drawing.Size(800, 50)
        Me.MenuStripbackgroundPictureBox.TabIndex = 7
        Me.MenuStripbackgroundPictureBox.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.MinimizeButtonBase
        Me.MinimizeButton.Location = New System.Drawing.Point(756, 5)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(20, 20)
        Me.MinimizeButton.TabIndex = 9
        Me.MinimizeButton.TabStop = False
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Transparent
        Me.PlayButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.PlayButtonBase
        Me.PlayButton.Location = New System.Drawing.Point(650, 549)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(140, 84)
        Me.PlayButton.TabIndex = 11
        Me.PlayButton.TabStop = False
        '
        'wowIcon
        '
        Me.wowIcon.BackColor = System.Drawing.Color.Transparent
        Me.wowIcon.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.wowIcon
        Me.wowIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.wowIcon.Location = New System.Drawing.Point(9, 5)
        Me.wowIcon.Name = "wowIcon"
        Me.wowIcon.Size = New System.Drawing.Size(20, 20)
        Me.wowIcon.TabIndex = 12
        Me.wowIcon.TabStop = False
        '
        'wowVersionLabel
        '
        Me.wowVersionLabel.AutoSize = True
        Me.wowVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.wowVersionLabel.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!, System.Drawing.FontStyle.Bold)
        Me.wowVersionLabel.ForeColor = System.Drawing.Color.White
        Me.wowVersionLabel.Location = New System.Drawing.Point(30, 7)
        Me.wowVersionLabel.Name = "wowVersionLabel"
        Me.wowVersionLabel.Size = New System.Drawing.Size(204, 16)
        Me.wowVersionLabel.TabIndex = 13
        Me.wowVersionLabel.Text = "World of Warcraft v4.3.4.15595"
        '
        'UpdateBackgroundImage
        '
        Me.UpdateBackgroundImage.BackColor = System.Drawing.Color.Transparent
        Me.UpdateBackgroundImage.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.BottomMain
        Me.UpdateBackgroundImage.Location = New System.Drawing.Point(6, 529)
        Me.UpdateBackgroundImage.Name = "UpdateBackgroundImage"
        Me.UpdateBackgroundImage.Size = New System.Drawing.Size(800, 120)
        Me.UpdateBackgroundImage.TabIndex = 16
        Me.UpdateBackgroundImage.TabStop = False
        '
        'InstallOfferingLable
        '
        Me.InstallOfferingLable.AutoSize = True
        Me.InstallOfferingLable.BackColor = System.Drawing.Color.Transparent
        Me.InstallOfferingLable.Enabled = False
        Me.InstallOfferingLable.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.InstallOfferingLable.ForeColor = System.Drawing.Color.OrangeRed
        Me.InstallOfferingLable.Location = New System.Drawing.Point(140, 584)
        Me.InstallOfferingLable.Name = "InstallOfferingLable"
        Me.InstallOfferingLable.Size = New System.Drawing.Size(400, 16)
        Me.InstallOfferingLable.TabIndex = 17
        Me.InstallOfferingLable.Text = "Could not find World of Warcraft game client. Download and install now?"
        Me.InstallOfferingLable.Visible = False
        '
        'InstallButton
        '
        Me.InstallButton.BackColor = System.Drawing.Color.Transparent
        Me.InstallButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.yesButtonBase
        Me.InstallButton.Enabled = False
        Me.InstallButton.Location = New System.Drawing.Point(544, 574)
        Me.InstallButton.Name = "InstallButton"
        Me.InstallButton.Size = New System.Drawing.Size(91, 32)
        Me.InstallButton.TabIndex = 18
        Me.InstallButton.TabStop = False
        Me.InstallButton.Visible = False
        '
        'PatchNotesHeader
        '
        Me.PatchNotesHeader.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.patchNotesHeadMinimize
        Me.PatchNotesHeader.Location = New System.Drawing.Point(260, 172)
        Me.PatchNotesHeader.Name = "PatchNotesHeader"
        Me.PatchNotesHeader.Size = New System.Drawing.Size(505, 33)
        Me.PatchNotesHeader.TabIndex = 19
        Me.PatchNotesHeader.TabStop = False
        '
        'PatchNotesBackground
        '
        Me.PatchNotesBackground.BackgroundImage = CType(resources.GetObject("PatchNotesBackground.BackgroundImage"), System.Drawing.Image)
        Me.PatchNotesBackground.Location = New System.Drawing.Point(260, 205)
        Me.PatchNotesBackground.Name = "PatchNotesBackground"
        Me.PatchNotesBackground.Size = New System.Drawing.Size(505, 227)
        Me.PatchNotesBackground.TabIndex = 20
        Me.PatchNotesBackground.TabStop = False
        '
        'PatchNotesLabel
        '
        Me.PatchNotesLabel.BackColor = System.Drawing.Color.Transparent
        Me.PatchNotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatchNotesLabel.Location = New System.Drawing.Point(278, 224)
        Me.PatchNotesLabel.Name = "PatchNotesLabel"
        Me.PatchNotesLabel.Size = New System.Drawing.Size(460, 159)
        Me.PatchNotesLabel.TabIndex = 21
        Me.PatchNotesLabel.Text = "Patch notes text field"
        '
        'PatchNotesLinkLabel
        '
        Me.PatchNotesLinkLabel.AutoSize = True
        Me.PatchNotesLinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.PatchNotesLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatchNotesLinkLabel.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PatchNotesLinkLabel.Location = New System.Drawing.Point(281, 387)
        Me.PatchNotesLinkLabel.Name = "PatchNotesLinkLabel"
        Me.PatchNotesLinkLabel.Size = New System.Drawing.Size(234, 20)
        Me.PatchNotesLinkLabel.TabIndex = 22
        Me.PatchNotesLinkLabel.TabStop = True
        Me.PatchNotesLinkLabel.Text = "Read the whole patch notes"
        Me.PatchNotesLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(812, 653)
        Me.Controls.Add(Me.PatchNotesLinkLabel)
        Me.Controls.Add(Me.PatchNotesLabel)
        Me.Controls.Add(Me.PatchNotesBackground)
        Me.Controls.Add(Me.PatchNotesHeader)
        Me.Controls.Add(Me.InstallButton)
        Me.Controls.Add(Me.InstallOfferingLable)
        Me.Controls.Add(Me.wowVersionLabel)
        Me.Controls.Add(Me.wowIcon)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MainWindowImage)
        Me.Controls.Add(Me.FrameBottom)
        Me.Controls.Add(Me.TopFrame)
        Me.Controls.Add(Me.OptionsMenuStrip)
        Me.Controls.Add(Me.MenuStripbackgroundPictureBox)
        Me.Controls.Add(Me.UpdateBackgroundImage)
        Me.Controls.Add(Me.LeftFrame)
        Me.Controls.Add(Me.RightFrame)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.OptionsMenuStrip
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.OptionsMenuStrip.ResumeLayout(False)
        Me.OptionsMenuStrip.PerformLayout()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainWindowImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightFrame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftFrame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopFrame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuStripbackgroundPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wowIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateBackgroundImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatchNotesHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatchNotesBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopFrame As PictureBox
    Friend WithEvents LeftFrame As PictureBox
    Friend WithEvents RightFrame As PictureBox
    Friend WithEvents FrameBottom As PictureBox
    Friend WithEvents MainWindowImage As PictureBox
    Friend WithEvents OptionsMenuStrip As MenuStrip
    Friend WithEvents MenuStripbackgroundPictureBox As PictureBox
    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents PlayButton As PictureBox
    Friend WithEvents wowIcon As PictureBox
    Friend WithEvents wowVersionLabel As Label
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateBackgroundImage As PictureBox
    Private WithEvents InstallOfferingLable As Label
    Private WithEvents InstallButton As PictureBox
    Friend WithEvents SetRealmlistAdressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatchNotesHeader As PictureBox
    Friend WithEvents PatchNotesBackground As PictureBox
    Friend WithEvents OptionsMenuItem As ToolStripMenuItem
    Friend WithEvents PatchNotesLabel As Label
    Friend WithEvents PatchNotesLinkLabel As LinkLabel
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
