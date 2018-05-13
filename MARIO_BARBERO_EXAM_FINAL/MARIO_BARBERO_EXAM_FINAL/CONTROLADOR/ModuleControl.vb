Module ModuleControl
    Dim MasDeUnaArroba As Boolean = False
    Dim TienePunto As Boolean = False
    Dim TieneExtension As Boolean = False


    Public Function comprobarFormatoFecha(ByVal fecha As TextBox, ByRef FechaConvertida As Date)
        Dim formatoBien As Boolean = True
        Dim vector() As String
        Dim listaNumeros() As Char
        If (IsDate(fecha.Text)) Then
            vector = fecha.Text.Split("/")
            If (Convert.ToDateTime(fecha.Text) > Date.Today) Then
                formatoBien = False
            Else
                If (vector.Length = 3) Then
                    For i = 0 To vector.Length - 1
                        listaNumeros = vector(i).ToCharArray
                        For a = 0 To listaNumeros.Length - 1 'HAGO ESTO PARA QUE ME COMPRUEBE LOS ESPACIOS EN BLANCO PORQUE EN EL AÑO LOS ACEPTA CON ISDATE
                            If (vector(0).Length > 2 Or vector(1).Length > 2 Or Char.IsWhiteSpace(listaNumeros(a))) Then
                                formatoBien = False
                                Exit For
                            End If
                        Next
                    Next
                Else
                    formatoBien = False
                End If
            End If
            If (formatoBien) Then
                FechaConvertida = convertirATipoFecha(FechaConvertida, fecha)
                'FechaConvertida = Convert.ToDateTime(fecha.Text) 'CONVERTIMOS LA FECHA INTRODUCIDA A FORMATO FECHA
                'FechaConvertida.ToString("dd/MM/yyyy")
            End If
        Else
            formatoBien = False
        End If
        Return formatoBien
    End Function

    Public Function convertirATipoFecha(ByRef FechaConvertida As Date, ByVal fecha As TextBox)
        FechaConvertida = Convert.ToDateTime(fecha.Text) 'CONVERTIMOS LA FECHA INTRODUCIDA A FORMATO FECHA
        FechaConvertida.ToString("dd/MM/yyyy")
        Return FechaConvertida
    End Function

    Public Function comprobarTelefono(ByVal telefono As TextBox)
        Dim formatoBien As Boolean = True
        Dim listaTelefono() As Char = telefono.Text.ToCharArray
        If (telefono.Text.Length > 9) Then
            formatoBien = False
        Else
            For i = 0 To listaTelefono.Length - 1
                If (Not Char.IsDigit(listaTelefono(i))) Then
                    formatoBien = False
                End If
            Next
        End If
        Return formatoBien
    End Function

    Public Function comprobarCorreo(ByVal correo As TextBox)
        If Not (correo.Text.IndexOf("@") <> -1) Or correo.Text.CompareTo("") = 0 Then
            'SI NO TIENE LA @
            MessageBox.Show("Formato de correo invalido")
            correo.Focus()
        ElseIf (MasDeUnaArroba = True) Then
            MessageBox.Show("Contiene más de una arroba")
            correo.Focus()
        ElseIf (TienePunto = True) Then
            MessageBox.Show("No contiene punto o tiene más de uno")
            correo.Focus()
        ElseIf (TieneExtension = True) Then
            MessageBox.Show("No contiene la extension del correo valida")
            correo.Focus()
        Else
            Dim listaCaracteres() As Char = correo.Text.ToCharArray
            'Recorrer el array de caracterres desde la primera hasta la última posción que le diga
            Dim mensaje As String = ""
            'desde la primera hasta la última posción antes de la @
            For i = 0 To correo.Text.IndexOf("@") - 1 'Step 5, avanza de 5 en 5 por ejmplo
                Dim bien As Boolean = True
                If Not (Char.IsLetter(listaCaracteres(i)) Or Char.IsDigit(listaCaracteres(i))) Then
                    If Not Char.IsWhiteSpace(listaCaracteres(i)) Then
                        If Not (listaCaracteres(i) = "." Or listaCaracteres(i) = "-" Or listaCaracteres(i) = "_") Then
                            bien = False
                        End If
                    Else
                        bien = False
                    End If
                End If
                If Not bien Then
                    MessageBox.Show("Caracter especial no admitido")
                    correo.Focus()
                    Exit Function
                End If
            Next
        End If
    End Function

    Public Sub comprobarFormatoCorreo(ByVal correo As TextBox)
        MasDeUnaArroba = False
        TienePunto = False
        TieneExtension = False
        Dim vector() As String = correo.Text.Split("@")
        If vector.Length = 1 Or vector.Length > 2 Then 'PARA COMPROBAR SI NO TIENE O TIENE MAS DE UNA ARROBA @
            MasDeUnaArroba = True
        End If
        If vector.Length = 2 Then 'A PARTIR DE AQUI COMPROBAMOS DESDE LA ARROBA HACIA LA PARTE DERECHA DEL CORREO
            'comprobar la parte de derecha del correo
            Dim vector2() As String = vector.ElementAt(1).Split(".")
            If vector2.Length = 1 Or vector2.Length > 2 Then 'PARA COMPROBAR SI TIENE O NO PUNTO
                TienePunto = True
            ElseIf vector2.Length = 2 Then
                Dim prueba As String = vector2.ElementAt(1).ToString 'PARA CCOMPROBAR SI TIENE O NO EXTENSION DESPUES DEL PUNTO
                If prueba.CompareTo("") = 0 Then
                    TieneExtension = True
                End If
            End If
        End If
    End Sub

End Module
