Class MainWindow

    Dim pulsacion As Byte = 0 'PARA SABER QUIEN DE LOS DOS JUGADORES HA PULSADO LA CASILLA
    Dim tagBotonOrdenador As String 'PARA SABER EL TAG DEL BOTON QUE HA PULSADO LA MAQUINA
    Dim boton As Button
    Dim contadorFichas As Integer 'PARA SABER CUANTAS CASILLAS SE VAN PULSANDO
    Dim resultJug As Integer
    Dim resultPC As Integer
    Dim primeraVez As Boolean = True 'PARA COMPROBAR LA PRIMERA VEZ QUE SE PONE FICHA

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim boton As Button
        contadorFichas = 0
        reiniciarArray()

        For i = 0 To 8 ' PONGO 8 PORQUE SON LOS BOTONES QUE QUIERO QUE COJA, CORRESPONEN A LOS DEL 3 EN RAYA
            boton = Rejilla.Children.Item(i) 'CUANDO LO ASIGNAMOS A UN TIPO BOTON ES CUANDO PODEMOS UTILIZAR TODAS SUS PROPIEDADES
            DirectCast(boton, Button).Background = Brushes.White
        Next

        If Tipo = 1 Then
            imagen1 = "equis.png" 'IMAGEN DE LA MAQUINA
            imagen2 = "circulo.jpg" 'IMAGEN DEL JUGADOR
        Else
            imagen1 = "circulo.jpg"
            imagen2 = "equis.png"
        End If
    End Sub

    Private Sub botones_Click(sender As Object, e As RoutedEventArgs) Handles P00.Click, P01.Click, P02.Click, P03.Click, P04.Click, P05.Click, P06.Click, P07.Click, P08.Click
        boton = sender
        tagBotonHumano = boton.Tag
        Dim imagen As ImageBrush = New ImageBrush
        Dim uri As Uri 'PARA SABER EL ORIGEN DE LA IMAGEN

        If boton.Background.Equals(Brushes.White) Then
            uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen2)
            imagen.ImageSource = New BitmapImage(uri)
            boton.Background = imagen
            Select Case tagBotonHumano

                Case "p00"
                    tagBotonHumano = boton.Tag
                    arrayTablero(0, 0) = 1
                Case "p01"
                    tagBotonHumano = boton.Tag
                    arrayTablero(0, 1) = 1
                Case "p02"
                    tagBotonHumano = boton.Tag
                    arrayTablero(0, 2) = 1
                Case "p03"
                    tagBotonHumano = boton.Tag
                    arrayTablero(1, 0) = 1
                Case "p04"
                    tagBotonHumano = boton.Tag
                    arrayTablero(1, 1) = 1
                Case "p05"
                    tagBotonHumano = boton.Tag
                    arrayTablero(1, 2) = 1
                Case "p06"
                    tagBotonHumano = boton.Tag
                    arrayTablero(2, 0) = 1
                Case "p07"
                    tagBotonHumano = boton.Tag
                    arrayTablero(2, 1) = 1
                Case "p08"
                    tagBotonHumano = boton.Tag
                    arrayTablero(2, 2) = 1
            End Select
            pulsacion = 1
        End If
        contadorFichas = contadorFichas + 1
        If (contadorFichas >= 3) Then
            If comprobarGanadorHumano() Then
                MessageBox.Show("HA GANADO EL HUMANO")
                desactivarBotones()
                resultJug = resultJug + 1
                txtResultJugador.Text = resultJug
            End If
        End If
        pulsacionMaquina(sender, tagBotonHumano)

    End Sub

    Public Sub pulsacionMaquina(ByVal sender As Object, ByRef tagHuman As String)
        Dim imagen As ImageBrush = New ImageBrush
        Dim uri As Uri 'PARA SABER EL ORIGEN DE LA IMAGEN (LA RUTA)

        If contadorFichas < 9 Then 'SI EL TABLERO NO ESTÁ LLENO
            While (pulsacion = 1)
                tagBotonOrdenador = ponerFichaMaquina()
                If tagHuman <> tagBotonOrdenador Then
                    Select Case tagBotonOrdenador
                        Case "p00"
                            If P00.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P00.Background = imagen
                                pulsacion = 0
                                arrayTablero(0, 0) = 2
                            End If
                        Case "p01"
                            If P01.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P01.Background = imagen
                                pulsacion = 0
                                arrayTablero(0, 1) = 2
                            End If
                        Case "p02"
                            If P02.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P02.Background = imagen
                                pulsacion = 0
                                arrayTablero(0, 2) = 2
                            End If
                        Case "p03"
                            If P03.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P03.Background = imagen
                                pulsacion = 0
                                arrayTablero(1, 0) = 2
                            End If
                        Case "p04"
                            If P04.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P04.Background = imagen
                                pulsacion = 0
                                arrayTablero(1, 1) = 2
                            End If
                        Case "p05"
                            If P05.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P05.Background = imagen
                                pulsacion = 0
                                arrayTablero(1, 2) = 2
                            End If
                        Case "p06"
                            If P06.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P06.Background = imagen
                                pulsacion = 0
                                arrayTablero(2, 0) = 2
                            End If
                        Case "p07"
                            If P07.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P07.Background = imagen
                                pulsacion = 0
                                arrayTablero(2, 1) = 2
                            End If
                        Case "p08"
                            If P08.Background.Equals(Brushes.White) Then
                                uri = New Uri("pack://siteoforigin:,,,/IMAGENES/" & imagen1)
                                imagen.ImageSource = New BitmapImage(uri)
                                P08.Background = imagen
                                pulsacion = 0
                                arrayTablero(2, 2) = 2
                            End If
                    End Select
                End If
            End While
            contadorFichas = contadorFichas + 1
            If (contadorFichas >= 3) Then
                If comprobarGanadorMaquina() Then 'SI LA MAQUINA HA GANADO
                    MessageBox.Show("HA GANADO LA MAQUINA")
                    desactivarBotones()
                    resultPC = resultPC + 1
                    txtResultMaquina.Text = resultPC
                End If
            End If
        End If
    End Sub

    Public Sub desactivarBotones()
        P00.IsEnabled = False
        P01.IsEnabled = False
        P02.IsEnabled = False
        P03.IsEnabled = False
        P04.IsEnabled = False
        P05.IsEnabled = False
        P06.IsEnabled = False
        P07.IsEnabled = False
        P08.IsEnabled = False
    End Sub

    Public Sub activarBotones()
        P00.IsEnabled = True
        P01.IsEnabled = True
        P02.IsEnabled = True
        P03.IsEnabled = True
        P04.IsEnabled = True
        P05.IsEnabled = True
        P06.IsEnabled = True
        P07.IsEnabled = True
        P08.IsEnabled = True
    End Sub

    Public Function comprobarCasilla(botonTag As String) ' COMPRUEBO SI ESTÁ LIBRE UNA CASILLA
        Dim listaCaracteres() As Char = botonTag.ToCharArray
        Dim posArray2 As Integer = Integer.Parse(listaCaracteres(2)) ' LO IGUALO AL ÚLTIMO NUMERO DEL TAG
        Dim posArray1 As Integer
        Dim ocupado As Boolean = False
        'For a = 0 To 2
        While posArray2 > 2 'MIENTRAS EL NUMERO SEA MAOYR DE 2 (0,1,2)
            posArray2 = posArray2 - 3 '0) ME RESTA -3 AL SEGUNDO DIGITO DE LA ARRAY BIDIMENSIONAL PARA COLOCARSE DENTRO DE LOS VALORES ADMITIDOS
            posArray1 = posArray1 + 1 '(0, ME SUMA +1 AL PRIMER DIGITO DE LA ARRAY BIDIMENSIONAL
        End While

        If arrayTablero(posArray1, posArray2) = 1 Then 'SI ESA CASILLA ESTA OCUPADA POR EL JUGADOR
            ocupado = True
        End If

        Return ocupado
    End Function

    Public Sub intentarAtaque(ByRef nombreBoton As String, ByRef ataque As Boolean)

        'COMPRUEBO LA DIAGONAL \
        If arrayTablero(0, 0) = 2 And arrayTablero(1, 1) = 2 And P08.Background.Equals(Brushes.White) Then
            nombreBoton = "p08"
            ataque = True
        ElseIf arrayTablero(2, 2) = 2 And arrayTablero(1, 1) = 2 And P00.Background.Equals(Brushes.White) Then
            nombreBoton = "p00"
            ataque = True

            'COMPRUEBO LA DIAGONAL /
        ElseIf arrayTablero(0, 2) = 2 And arrayTablero(1, 1) = 2 And P06.Background.Equals(Brushes.White) Then
            nombreBoton = "p06"
            ataque = True
        ElseIf arrayTablero(2, 0) = 2 And arrayTablero(1, 1) = 2 And P02.Background.Equals(Brushes.White) Then
            nombreBoton = "p02"
            ataque = True
        Else
            ' ataque = False
        End If

        'COMPRUEBO LAS VERTICALES I
        If arrayTablero(0, 0) = 2 And arrayTablero(1, 0) = 2 And P06.Background.Equals(Brushes.White) Then
            nombreBoton = "p06"
            ataque = True
        ElseIf arrayTablero(2, 0) = 2 And arrayTablero(1, 0) = 2 And P00.Background.Equals(Brushes.White) Then
            nombreBoton = "p00"
            ataque = True
        ElseIf arrayTablero(2, 0) = 2 And arrayTablero(0, 0) = 2 And P03.Background.Equals(Brushes.White) Then
            nombreBoton = "p03"
            ataque = True

        ElseIf arrayTablero(0, 1) = 2 And arrayTablero(1, 1) = 2 And P07.Background.Equals(Brushes.White) Then
            nombreBoton = "p07"
            ataque = True
        ElseIf arrayTablero(2, 1) = 2 And arrayTablero(1, 1) = 2 And P01.Background.Equals(Brushes.White) Then
            nombreBoton = "p01"
            ataque = True
        ElseIf arrayTablero(2, 1) = 2 And arrayTablero(0, 1) = 2 And P04.Background.Equals(Brushes.White) Then
            nombreBoton = "p04"
            ataque = True

        ElseIf arrayTablero(0, 2) = 2 And arrayTablero(1, 2) = 2 And P08.Background.Equals(Brushes.White) Then
            nombreBoton = "p08"
            ataque = True
        ElseIf arrayTablero(2, 2) = 2 And arrayTablero(1, 2) = 2 And P02.Background.Equals(Brushes.White) Then
            nombreBoton = "p02"
            ataque = True
        ElseIf arrayTablero(2, 2) = 2 And arrayTablero(0, 2) = 2 And P05.Background.Equals(Brushes.White) Then
            nombreBoton = "p05"
            ataque = True
        Else
            'ataque = False
        End If

        'COMPRUEBO LAS HORIZONTALES --
        If arrayTablero(0, 0) = 2 And arrayTablero(0, 1) = 2 And P02.Background.Equals(Brushes.White) Then
            nombreBoton = "p02"
            ataque = True
        ElseIf arrayTablero(0, 2) = 2 And arrayTablero(0, 1) = 2 And P00.Background.Equals(Brushes.White) Then
            nombreBoton = "p00"
            ataque = True
        ElseIf arrayTablero(0, 2) = 2 And arrayTablero(0, 0) = 2 And P01.Background.Equals(Brushes.White) Then
            nombreBoton = "p01"
            ataque = True

        ElseIf arrayTablero(1, 0) = 2 And arrayTablero(1, 1) = 2 And P05.Background.Equals(Brushes.White) Then
            nombreBoton = "p05"
            ataque = True
        ElseIf arrayTablero(1, 2) = 2 And arrayTablero(1, 1) = 2 And P03.Background.Equals(Brushes.White) Then
            nombreBoton = "p03"
            ataque = True
        ElseIf arrayTablero(1, 2) = 2 And arrayTablero(1, 0) = 2 And P04.Background.Equals(Brushes.White) Then
            nombreBoton = "p04"
            ataque = True

        ElseIf arrayTablero(2, 0) = 2 And arrayTablero(2, 1) = 2 And P08.Background.Equals(Brushes.White) Then
            nombreBoton = "p08"
            ataque = True
        ElseIf arrayTablero(2, 2) = 2 And arrayTablero(2, 1) = 2 And P06.Background.Equals(Brushes.White) Then
            nombreBoton = "p06"
            ataque = True
        ElseIf arrayTablero(2, 2) = 2 And arrayTablero(2, 0) = 2 And P07.Background.Equals(Brushes.White) Then
            nombreBoton = "p07"
            ataque = True
        Else
            'ataque = False
        End If
        'Return ataque
    End Sub

    Public Sub intentarDefensa(ByRef nombreBoton As String)

        'COMPRUEBO LA DIAGONAL \
        If comprobarCasilla("p00") And comprobarCasilla("p04") And P08.Background.Equals(Brushes.White) Then
            nombreBoton = "p08"
        ElseIf comprobarCasilla("p08") And comprobarCasilla("p04") And P00.Background.Equals(Brushes.White) Then
            nombreBoton = "p00"

            'COMPRUEBO LA DIAGONAL /
        ElseIf comprobarCasilla("p02") And comprobarCasilla("p04") And P06.Background.Equals(Brushes.White) Then
            nombreBoton = "p06"
        ElseIf comprobarCasilla("p06") And comprobarCasilla("p04") And P02.Background.Equals(Brushes.White) Then
            nombreBoton = "p02"
        End If

        'COMPRUEBO LAS VERTICALES I
        If comprobarCasilla("p00") And comprobarCasilla("p03") And P06.Background.Equals(Brushes.White) Then
            nombreBoton = "p06"
        ElseIf comprobarCasilla("p06") And comprobarCasilla("p03") And P00.Background.Equals(Brushes.White) Then
            nombreBoton = "p00"
        ElseIf comprobarCasilla("p06") And comprobarCasilla("p00") And P03.Background.Equals(Brushes.White) Then
            nombreBoton = "p03"

        ElseIf comprobarCasilla("p01") And comprobarCasilla("p04") And P07.Background.Equals(Brushes.White) Then
            nombreBoton = "p07"
        ElseIf comprobarCasilla("p07") And comprobarCasilla("p04") And P01.Background.Equals(Brushes.White) Then
            nombreBoton = "p01"
        ElseIf comprobarCasilla("p07") And comprobarCasilla("p01") And P04.Background.Equals(Brushes.White) Then
            nombreBoton = "p04"

        ElseIf comprobarCasilla("p02") And comprobarCasilla("p05") And P08.Background.Equals(Brushes.White) Then
            nombreBoton = "p08"
        ElseIf comprobarCasilla("p08") And comprobarCasilla("p05") And P02.Background.Equals(Brushes.White) Then
            nombreBoton = "p02"
        ElseIf comprobarCasilla("p08") And comprobarCasilla("p02") And P05.Background.Equals(Brushes.White) Then
            nombreBoton = "p05"
        End If

        'COMPRUEBO LAS HORIZONTALES --
        If comprobarCasilla("p00") And comprobarCasilla("p01") And P02.Background.Equals(Brushes.White) Then
            nombreBoton = "p02"
        ElseIf comprobarCasilla("p02") And comprobarCasilla("p01") And P00.Background.Equals(Brushes.White) Then
            nombreBoton = "p00"
        ElseIf comprobarCasilla("p02") And comprobarCasilla("p00") And P01.Background.Equals(Brushes.White) Then
            nombreBoton = "p01"

        ElseIf comprobarCasilla("p03") And comprobarCasilla("p04") And P05.Background.Equals(Brushes.White) Then
            nombreBoton = "p05"
        ElseIf comprobarCasilla("p05") And comprobarCasilla("p04") And P03.Background.Equals(Brushes.White) Then
            nombreBoton = "p03"
        ElseIf comprobarCasilla("p05") And comprobarCasilla("p03") And P04.Background.Equals(Brushes.White) Then
            nombreBoton = "p04"

        ElseIf comprobarCasilla("p06") And comprobarCasilla("p07") And P08.Background.Equals(Brushes.White) Then
            nombreBoton = "p08"
        ElseIf comprobarCasilla("p08") And comprobarCasilla("p07") And P06.Background.Equals(Brushes.White) Then
            nombreBoton = "p06"
        ElseIf comprobarCasilla("p08") And comprobarCasilla("p06") And P07.Background.Equals(Brushes.White) Then
            nombreBoton = "p07"
        End If

    End Sub


    Public Function ponerFichaMaquina()
        Randomize(DateTime.Now.Millisecond)
        Dim rnd As New Random(DateTime.Now.Millisecond)
        'Dim listaCaracteres() As Char = tagBotonHumano.ToCharArray
        'Asc(listaCaracteres(2))
        Dim nombreBoton As String
        Dim botonCentral As Boolean = False
        Dim ataque As Boolean = False

        If primeraVez Then 'SI ES LA PRIMERA FICHA QUE PONE LA MAQUINA
            If comprobarCasilla("p04") Then 'SI P04 ESTÁ OCUPADA
                If P00.Background.Equals(Brushes.White) Then
                    nombreBoton = "p00"
                ElseIf P02.Background.Equals(Brushes.White) Then
                    nombreBoton = "p02"
                ElseIf P06.Background.Equals(Brushes.White) Then
                    nombreBoton = "p06"
                ElseIf P08.Background.Equals(Brushes.White) Then
                    nombreBoton = "p08"
                End If
            Else ' SI P04 ESTÁ LIBRE
                nombreBoton = "p04"
                'nombreBoton = Convert.ToChar(rnd.Next(112, 112)) & Convert.ToChar(rnd.Next(48, 48)) & Convert.ToChar(rnd.Next(48, 56))
            End If
        Else
            nombreBoton = Convert.ToChar(rnd.Next(112, 112)) & Convert.ToChar(rnd.Next(48, 48)) & Convert.ToChar(rnd.Next(48, 56))
        End If

        If Not primeraVez Then

            intentarAtaque(nombreBoton, ataque)
            If Not ataque Then
                intentarDefensa(nombreBoton)

            End If
        End If

        primeraVez = False

        Return nombreBoton
    End Function

    Public Function comprobarGanadorMaquina()
        Dim exito As Boolean = False
        'VERIFICO LA DIAGONAL(\)
        If (arrayTablero(0, 0) = 2 And arrayTablero(1, 1) = 2 And arrayTablero(2, 2) = 2) Then
            exito = True
        End If

        'VERIFICO LA DIAGONAL(/)
        If (arrayTablero(0, 2) = 2 And arrayTablero(1, 1) = 2 And arrayTablero(2, 0) = 2) Then
            exito = True
        End If

        'VERIFICO LAS FILAS HORIZONTALES Y VERTICALES
        For i = 0 To 2
            'VERIFICO LAS FILAS HORIZONTALES
            If (arrayTablero(i, 0) = 2 And arrayTablero(i, 1) = 2 And arrayTablero(i, 2) = 2) Then
                exito = True
            End If
            'VERIFICO LAS FILAS VERTICALES
            If (arrayTablero(0, i) = 2 And arrayTablero(1, i) = 2 And arrayTablero(2, i) = 2) Then
                exito = True
            End If
        Next
        Return exito
    End Function

    Public Function comprobarGanadorHumano()
        Dim exito As Boolean = False
        'VERIFICO LA DIAGONAL(\)
        If (arrayTablero(0, 0) = 1 And arrayTablero(1, 1) = 1 And arrayTablero(2, 2) = 1) Then
            exito = True
        End If

        'VERIFICO LA DIAGONAL(/)
        If (arrayTablero(0, 2) = 1 And arrayTablero(1, 1) = 1 And arrayTablero(2, 0) = 1) Then
            exito = True
        End If

        'VERIFICO LAS FILAS HORIZONTALES Y VERTICALES
        For i = 0 To 2
            'VERIFICO LAS FILAS HORIZONTALES
            If (arrayTablero(i, 0) = 1 And arrayTablero(i, 1) = 1 And arrayTablero(i, 2) = 1) Then
                exito = True
            End If
            'VERIFICO LAS FILAS VERTICALES
            If (arrayTablero(0, i) = 1 And arrayTablero(1, i) = 1 And arrayTablero(2, i) = 1) Then
                exito = True
            End If
        Next
        Return exito
    End Function

    Public Sub reiniciarArray()
        arrayTablero(0, 0) = 0
        arrayTablero(0, 1) = 0
        arrayTablero(0, 2) = 0
        arrayTablero(1, 0) = 0
        arrayTablero(1, 1) = 0
        arrayTablero(1, 2) = 0
        arrayTablero(2, 0) = 0
        arrayTablero(2, 1) = 0
        arrayTablero(2, 2) = 0
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As RoutedEventArgs) Handles btnReiniciar.Click
        Dim boton As Button
        contadorFichas = 0
        reiniciarArray()
        activarBotones()
        primeraVez = True
        For i = 0 To 8 ' PONGO 8 PORQUE SON LOS BOTONES QUE QUIERO QUE COJA, CORRESPONEN A LOS DEL 3 EN RAYA
            boton = Rejilla.Children.Item(i) 'CUANDO LO ASIGNAMOS A UN TIPO BOTON ES CUANDO PODEMOS UTILIZAR TODAS SUS PROPIEDADES
            DirectCast(boton, Button).Background = Brushes.White
        Next
    End Sub

End Class
