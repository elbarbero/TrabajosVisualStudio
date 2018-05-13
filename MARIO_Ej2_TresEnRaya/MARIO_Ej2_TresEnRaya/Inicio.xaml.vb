Public Class Inicio
    Private Sub Inicio_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim imagen As ImageBrush = New ImageBrush
        Dim imagen2 As ImageBrush = New ImageBrush
        Dim uri As Uri
        uri = New Uri("pack://siteoforigin:,,,/IMAGENES/circulo.jpg")
        imagen.ImageSource = New BitmapImage(uri)
        btnCirculo.Background = imagen

        uri = New Uri("pack://siteoforigin:,,,/IMAGENES/equis.png")
        imagen2.ImageSource = New BitmapImage(uri)
        btnEquis.Background = imagen2

    End Sub

    Private Sub btnEquis_Click(sender As Object, e As RoutedEventArgs) Handles btnEquis.Click
        Tipo = 0
        Dim main = New MainWindow()
        main.ShowDialog()

    End Sub

    Private Sub btnCirculo_Click_1(sender As Object, e As RoutedEventArgs) Handles btnCirculo.Click
        Tipo = 1
        Dim main = New MainWindow()
        main.ShowDialog()

    End Sub
End Class

