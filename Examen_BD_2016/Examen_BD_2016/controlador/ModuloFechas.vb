Module ModuloFechas

    Public Function comprobarFormatoFecha(ByVal FechaNac As TextBox, ByVal FechaConvertida As Date)
        Dim formatoBien As Boolean = True
        Dim vector() As String
        Dim listaNumeros() As Char
        If (IsDate(FechaNac.Text)) Then
            vector = FechaNac.Text.Split("-")
            If (Convert.ToDateTime(FechaNac.Text) > Date.Today) Then
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
                FechaConvertida = Convert.ToDateTime(FechaNac.Text) 'CONVERTIMOS LA FECHA INTRODUCIDA A FORMATO FECHA
                FechaConvertida.ToString("dd/MM/yyyy")
            End If
        Else
            formatoBien = False
        End If

        Return formatoBien
    End Function

    Public Function calcularEdad(ByVal fechaNac As Date)
        Dim fechaActual As Date = Date.Today
        Dim edad As Integer
        'fechaConv = Convert.ToDateTime(txtFechaNac.Text)
        If (fechaNac.Day = fechaActual.Day And fechaNac.Month = fechaActual.Month) Then
            'MessageBox.Show("FELICIDADES CHAVAL" & "TIENES " & Math.Abs(DateDiff(DateInterval.Year, fechaNac, Date.Today)) & "AÑOS")
            edad = Math.Abs(DateDiff(DateInterval.Year, fechaNac, Date.Today))
        ElseIf (fechaNac.Month > fechaActual.Month And fechaNac.Day > fechaActual.Day) Then
            MessageBox.Show("YA TIENES " & Math.Abs(DateDiff(DateInterval.Year, fechaNac, fechaActual)) - 1 & " AÑOS")
            edad = Math.Abs(DateDiff(DateInterval.Year, fechaNac, fechaActual)) - 1
        Else
            MessageBox.Show("TIENES " & Math.Abs(DateDiff(DateInterval.Year, fechaNac, fechaActual)) & " AÑOS")
            edad = Math.Abs(DateDiff(DateInterval.Year, fechaNac, fechaActual))
        End If
        Return edad
    End Function

End Module
