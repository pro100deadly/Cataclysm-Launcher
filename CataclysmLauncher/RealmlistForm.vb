Public Class RealmlistForm

    Dim configMgr As ConfigManager

    Private Sub RealmlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configMgr = MainWindow.configMgr
        RealmlistTextBox.Text = configMgr.realmlistAdress

        Dim newPos As Point = MainWindow.Location
        newPos.X -= (Me.Width - MainWindow.Width) * 0.5
        newPos.Y -= (Me.Height - MainWindow.Height) * 0.5
        Me.Location = newPos
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
        configMgr.realmlistAdress = RealmlistTextBox.Text
        configMgr.UpdateLauncherConfiguration()
        MainWindow.RemoveGrayForm()
        MyBase.Close()
    End Sub

End Class