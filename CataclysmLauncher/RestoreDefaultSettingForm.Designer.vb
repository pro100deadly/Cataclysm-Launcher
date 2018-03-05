<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreDefaultSettingForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RestoreHeader = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ResetLabel1 = New System.Windows.Forms.Label()
        Me.ResetLabel2 = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.PictureBox()
        Me.NoButton = New System.Windows.Forms.PictureBox()
        CType(Me.RestoreHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YesButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RestoreHeader
        '
        Me.RestoreHeader.BackColor = System.Drawing.Color.Transparent
        Me.RestoreHeader.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.RestoreDefaultsHeader
        Me.RestoreHeader.Location = New System.Drawing.Point(40, 33)
        Me.RestoreHeader.Name = "RestoreHeader"
        Me.RestoreHeader.Size = New System.Drawing.Size(113, 19)
        Me.RestoreHeader.TabIndex = 0
        Me.RestoreHeader.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.questionMark
        Me.PictureBox1.Location = New System.Drawing.Point(50, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 63)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ResetLabel1
        '
        Me.ResetLabel1.AutoSize = True
        Me.ResetLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ResetLabel1.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.ResetLabel1.ForeColor = System.Drawing.Color.OrangeRed
        Me.ResetLabel1.Location = New System.Drawing.Point(120, 88)
        Me.ResetLabel1.Name = "ResetLabel1"
        Me.ResetLabel1.Size = New System.Drawing.Size(246, 16)
        Me.ResetLabel1.TabIndex = 18
        Me.ResetLabel1.Text = "This will reset the game video configuration."
        '
        'ResetLabel2
        '
        Me.ResetLabel2.AutoSize = True
        Me.ResetLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ResetLabel2.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.ResetLabel2.ForeColor = System.Drawing.Color.OrangeRed
        Me.ResetLabel2.Location = New System.Drawing.Point(120, 105)
        Me.ResetLabel2.Name = "ResetLabel2"
        Me.ResetLabel2.Size = New System.Drawing.Size(241, 16)
        Me.ResetLabel2.TabIndex = 19
        Me.ResetLabel2.Text = "Do you want to restore the default settings?"
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.Transparent
        Me.YesButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.yesButtonBase
        Me.YesButton.Location = New System.Drawing.Point(193, 169)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(91, 32)
        Me.YesButton.TabIndex = 20
        Me.YesButton.TabStop = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Transparent
        Me.NoButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.noButtonBase
        Me.NoButton.Location = New System.Drawing.Point(290, 169)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(91, 32)
        Me.NoButton.TabIndex = 21
        Me.NoButton.TabStop = False
        '
        'RestoreDefaultSettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.InternalFormBackground2
        Me.ClientSize = New System.Drawing.Size(418, 244)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.ResetLabel2)
        Me.Controls.Add(Me.ResetLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RestoreHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RestoreDefaultSettingForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RestoreDefaultSettingForm"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.RestoreHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YesButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RestoreHeader As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents ResetLabel1 As Label
    Private WithEvents ResetLabel2 As Label
    Private WithEvents YesButton As PictureBox
    Private WithEvents NoButton As PictureBox
End Class
