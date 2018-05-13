Module ModuloGenerico

    Public Function SoloNumeros(ByVal campo As TextBox, ByVal campo2 As TextBox) 'COMPRUEBO QUE EL CAMPO SOLO TENGA NÚMEROS
        Dim listaCaracteres() As Char = campo.Text.ToCharArray & campo2.Text.ToCharArray
        Dim formatoValido As Boolean = True

        For i = 0 To listaCaracteres.Length - 1
            If (Char.IsLetter(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i)) Or Char.IsWhiteSpace(listaCaracteres(i))) Then
                formatoValido = False
                MessageBox.Show("DEBE CONTENER SOLO NÚMEROS")
                Exit For
            End If
        Next

        Return formatoValido
    End Function

    Public Function SoloLetrasSinEspacios(ByVal campo As TextBox, ByVal campo2 As TextBox, ByVal campo3 As TextBox) 'COMPRUEBO QUE EL CAMPO SOLO TENGA NÚMEROS
        Dim listaCaracteres() As Char = campo.Text.ToCharArray & campo2.Text.ToCharArray & campo3.Text.ToCharArray
        Dim formatoValido As Boolean = True

        For i = 0 To listaCaracteres.Length - 1
            If (Char.IsNumber(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i)) Or Char.IsWhiteSpace(listaCaracteres(i))) Then
                formatoValido = False
                MessageBox.Show("DEBE CONTENER SOLO LETRAS")
                Exit For
            End If
        Next

        Return formatoValido
    End Function

    Public Function SoloLetrasConEspacios(ByVal campo As TextBox) 'COMPRUEBO QUE EL CAMPO SOLO TENGA NÚMEROS
        Dim listaCaracteres() As Char = campo.Text.ToCharArray
        Dim formatoValido As Boolean = True

        For i = 0 To listaCaracteres.Length - 1
            If (Char.IsNumber(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i))) Then
                If listaCaracteres(i) <> "/" Then
                    formatoValido = False
                    MessageBox.Show("FORMATO DE DIRECCIÓN INCORRECTO")
                    Exit For
                End If
            End If
        Next

        Return formatoValido
    End Function

    Public Function comprobarDNI(ByVal DniTutor As TextBox)
        Dim formatoBien As Boolean = True
        Dim listaDNI() As Char = DniTutor.Text.ToCharArray
        Dim dniSinLetra As String
        For a = 0 To listaDNI.Length - 2
            dniSinLetra = dniSinLetra & listaDNI(a)
        Next

        If (DniTutor.Text.Length > 10) Then
            formatoBien = False
        Else

            For i = 0 To listaDNI.Length - 2 'PARA QUE NO COGA LA LETRA
                If (Not Char.IsDigit(listaDNI(i))) Then
                    formatoBien = False
                End If
            Next
            If Not calcularLetraDNI(dniSinLetra, listaDNI(8)) And formatoBien Then
                formatoBien = False
            End If
        End If
        Return formatoBien
    End Function

    Public Function calcularLetraDNI(ByVal dni As String, ByVal letraDNI As String) As Boolean
        Dim dniN As Integer = Convert.ToInt32(dni)
        Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim posicion As Byte = dniN Mod 23
        Dim letraCorreta As String = letras.Chars(posicion)

        If letraCorreta = letraDNI Then
            Return True
        Else
            Return False
            MessageBox.Show("DNI INCORRECTO")
        End If
        'Return letras.Chars(posicion)
    End Function

    'Public Function calcularLetraDNI(ByVal dni As TextBox) As Char
    'Dim dniN As Integer = Convert.ToInt32(dni.Text)
    'Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
    'Dim posicion As Byte = dniN Mod 23

    'Return letras.Chars(posicion)
    'End Function

End Module


