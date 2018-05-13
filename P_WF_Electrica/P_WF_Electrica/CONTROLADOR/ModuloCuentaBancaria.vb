Module ModuloCuentaBancaria

    Public Function comprobarTotalNumCuenta(ByVal numCuenta As String) As Boolean 'COMPRUEBA QUE LA CUENTA COMPLETA NO TENGA MENOS DE 20 DIGITOS
        Dim correcto As Boolean = True
        If (numCuenta.Length < 20) Then
            correcto = False
        End If
        Return correcto
    End Function

    Public Function ComprobarDC(ByVal numEntidad As String, ByVal numOficina As String, ByVal numDC As String, ByVal numCuenta As String) 'CALCULO LOS DIGITOS DE CONTROL
        Dim resultado1DC As Integer = 0
        Dim resultado2DC As Integer = 0
        Dim cuentaCompleta As String = numEntidad & numOficina & numDC & numCuenta ' meto todos los textbox en una sola variable
        'PRIMERA CIFRA DEL DC
        'PRIMERO CALCULAMOS LA ENTIDAD
        If (comprobarTotalNumCuenta(cuentaCompleta)) Then
            Dim valores As Array = {4, 8, 5, 10}
            Dim listaNumeros() As Char = numEntidad.ToCharArray
            For i = 0 To 3
                resultado1DC = resultado1DC + (Integer.Parse((listaNumeros(i))) * valores(i))
            Next

            'SEGUNDO CALCULAMOS LA OFICINA

            valores = {9, 7, 3, 6}
            listaNumeros = numOficina.ToCharArray
            For i = 0 To 3
                resultado1DC = resultado1DC + (Integer.Parse((listaNumeros(i))) * valores(i))
            Next
            resultado1DC = resultado1DC Mod 11
            ''resultado1DC = 11 - resultado1DC
            If (11 - resultado1DC = 10) Then
                resultado1DC = 1
            ElseIf (11 - resultado1DC = 11) Then
                resultado1DC = 0
            Else
                resultado1DC = 11 - resultado1DC
            End If


            'SEGUNDA CIFRA DEL DC
            valores = {1, 2, 4, 8, 5, 10, 9, 7, 3, 6}
            listaNumeros = numCuenta.ToCharArray
            For i = 0 To 9
                resultado2DC = resultado2DC + (Integer.Parse((listaNumeros(i))) * valores(i))
            Next
            resultado2DC = resultado2DC Mod 11
            'resultado2DC = 11 - resultado2DC
            If (11 - resultado2DC = 10) Then
                resultado2DC = 1
            ElseIf (11 - resultado2DC = 11) Then
                resultado2DC = 0
            Else
                resultado2DC = 11 - resultado2DC
            End If
            'txtDC.Text = resultado1DC.ToString & resultado2DC.ToString

        Else
            MessageBox.Show("Número de cuenta incompleta")
        End If
        Return (resultado1DC.ToString & resultado2DC.ToString)
    End Function

    Public Function calcularIBAN(ByVal numEntidad As String, ByVal numOficina As String, ByVal numDC As String, ByVal numCuenta As String) 'CALCULO EL IBAN
        Dim iban As Decimal
        iban = Convert.ToDecimal(numEntidad & numOficina & numDC & numCuenta & 142800)
        iban = iban Mod 97
        iban = 98 - iban
        If (iban < 10) Then
            Return Convert.ToString("0" & iban)
        Else
            Return iban
        End If

    End Function

    Public Function comprobarCuentaSoloNumeros(ByVal numEntidad As String, ByVal numOficina As String, ByVal numDC As String, ByVal numCuenta As String) 'COMPRUEBO QUE LA CUENTA SOLO CONTENGA NUMEROS
        Dim listaCaracteres() As Char = numEntidad.ToCharArray & numOficina.ToCharArray & numDC.ToCharArray & numCuenta.ToCharArray ' meto todos los textbox en una sola variable char
        Dim cuentaCompleta As String = numEntidad & numOficina & numDC & numCuenta ' meto todos los textbox en una sola variable, menos la entidad porque esa no la puede manipular el usuario
        Dim formatoValido As Boolean = True

        For i = 0 To cuentaCompleta.Length - 1
            If (Char.IsLetter(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i)) Or Char.IsWhiteSpace(listaCaracteres(i))) Then
                formatoValido = False
            End If
        Next

        Return formatoValido
    End Function

    Public Function validarCuenta(ByVal numEntidad As String, ByVal numOficina As String, ByVal numDC As String, ByVal numCuenta As String)
        Dim correcto As Boolean = True
        If (comprobarCuentaSoloNumeros(numEntidad, numOficina, numDC, numCuenta)) Then
            Dim digitosControl As String = ComprobarDC(numEntidad, numOficina, numDC, numCuenta)
            If (digitosControl.CompareTo(numDC)) = 0 Then
                'calcularIBAN(numEntidad, numOficina, numDC, numCuenta)
                ' MessageBox.Show("ES" & calcularIBAN(numEntidad, numOficina, numDC, numCuenta) & " " & numEntidad & " " & numOficina & " " & numDC & " " & numCuenta)
            Else
                correcto = False
                MessageBox.Show("El Digito de control no corresponde a esa cuenta")
            End If
        Else
            correcto = False
            MessageBox.Show("LA CUENTA SOLO DEBE CONTENER NÚMEROS ENTEROS")
        End If
        Return correcto
    End Function

End Module
