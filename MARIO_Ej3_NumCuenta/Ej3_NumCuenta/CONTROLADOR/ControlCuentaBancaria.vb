Module ControlCuentaBancaria

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

        Return (resultado1DC.ToString & resultado2DC.ToString)
    End Function

End Module
