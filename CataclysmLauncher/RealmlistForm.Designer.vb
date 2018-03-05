<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealmlistForm
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
        Me.RealmlistTextBox = New System.Windows.Forms.TextBox()
        Me.RealmlistLabel = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OkButton = New System.Windows.Forms.PictureBox()
        Me.CancelButton = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.OkButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CancelButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RealmlistTextBox
        '
        Me.RealmlistTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RealmlistTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RealmlistTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RealmlistTextBox.ForeColor = System.Drawing.Color.White
        Me.RealmlistTextBox.Location = New System.Drawing.Point(144, 111)
        Me.RealmlistTextBox.Name = "RealmlistTextBox"
        Me.RealmlistTextBox.Size = New System.Drawing.Size(200, 24)
        Me.RealmlistTextBox.TabIndex = 0
        Me.RealmlistTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RealmlistLabel
        '
        Me.RealmlistLabel.AutoSize = True
        Me.RealmlistLabel.BackColor = System.Drawing.Color.Transparent
        Me.RealmlistLabel.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.RealmlistLabel.ForeColor = System.Drawing.Color.SandyBrown
        Me.RealmlistLabel.Location = New System.Drawing.Point(60, 115)
        Me.RealmlistLabel.Name = "RealmlistLabel"
        Me.RealmlistLabel.Size = New System.Drawing.Size(81, 16)
        Me.RealmlistLabel.TabIndex = 19
        Me.RealmlistLabel.Text = "SET realmlist"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.InfoLabel.ForeColor = System.Drawing.Color.SandyBrown
        Me.InfoLabel.Location = New System.Drawing.Point(60, 66)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(270, 16)
        Me.InfoLabel.TabIndex = 20
        Me.InfoLabel.Text = "Change your game's realmlist to a new address."
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 63
        Me.LineShape6.X2 = 347
        Me.LineShape6.Y1 = 103
        Me.LineShape6.Y2 = 103
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape6})
        Me.ShapeContainer1.Size = New System.Drawing.Size(418, 244)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 63
        Me.LineShape1.X2 = 347
        Me.LineShape1.Y1 = 142
        Me.LineShape1.Y2 = 142
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.Transparent
        Me.OkButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.okButtonBase
        Me.OkButton.Location = New System.Drawing.Point(194, 170)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(91, 32)
        Me.OkButton.TabIndex = 23
        Me.OkButton.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.Transparent
        Me.CancelButton.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.cancelButtonBase
        Me.CancelButton.Location = New System.Drawing.Point(291, 170)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(91, 32)
        Me.CancelButton.TabIndex = 22
        Me.CancelButton.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Office Preview Font", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(60, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "The realmlist will be changed on next game start."
        '
        'RealmlistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.BackgroundImage = Global.CataclysmLauncher.My.Resources.Resources.InternalFormBackground2
        Me.ClientSize = New System.Drawing.Size(418, 244)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.RealmlistLabel)
        Me.Controls.Add(Me.RealmlistTextBox)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealmlistForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "RealmlistForm"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.OkButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CancelButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RealmlistTextBox As TextBox
    Private WithEvents RealmlistLabel As Label
    Private WithEvents InfoLabel As Label
    Friend WithEvents LineShape6 As PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents OkButton As PictureBox
    Friend WithEvents CancelButton As PictureBox
    Private WithEvents Label1 As Label
End Class
