Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As RoutedEventArgs) Handles btnInsertar.Click
        Dim inser = New VInsertar1()
        inser.ShowDialog()

    End Sub
End Class
