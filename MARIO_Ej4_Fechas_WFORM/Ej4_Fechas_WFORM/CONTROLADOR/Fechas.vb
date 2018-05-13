Module Fechas
    Public Sub CalcularDistanciaEntreFechas(fecha1 As Date, fecha2 As Date, ByRef dias As Integer, ByRef meses As Integer, ByRef annos As Integer)
        Dim fechaObtenida As Date = Date.Now
        Dim fechaMayor As Date
        Dim fechaMenor As Date
        Dim contadorMeses As Integer

        Select Case DateTime.Compare(fecha1, fecha2)
            Case -1
                fechaMayor = fecha2 'corresponde al DatePicker
                fechaMenor = fecha1 'corresponde al dateCalendario
            Case 0
                fechaMayor = fecha2 'corresponde al DatePicker
                fechaMenor = fecha1 'corresponde al dateCalendario
            Case 1
                fechaMayor = fecha1 'corresponde al dateCalendario
                fechaMenor = fecha2 'corresponde al DatePicker
        End Select

        contadorMeses = Math.Abs(DateDiff(DateInterval.Month, fecha2, fecha1)) 'PRIMERO CUENTO LOS MESES ENTRE LAS DOS FECHAS
        For i = 0 To contadorMeses - 1
            If (meses = 12) Then 'POR CADA 12 MESES CUENTO UN AÑO
                annos = annos + 1
                meses = 0
            End If
            meses = meses + 1
        Next

        fechaObtenida = DateAdd(DateInterval.Year, Convert.ToInt32(annos), Convert.ToDateTime(fechaMenor.Date)) 'CONSIGO LA NUEVA FECHA CON LOS AÑOS QUE HE CONTADO Y CON LA FECHA MENOR. PARA QUE VA AUMENTADO LA FECHA HASTA ALCANZAR EL AÑO DE LA FECHA MAYOR
        'A PARTIR DE AQUÍ AMBAS FECHAS YA ESTÁN EN EL MISMO AÑO
        'A PARTIR DE AQUÍ YA IGUALO LOS MESES Y LOS DÍAS
        If (Integer.Parse(fechaObtenida.Day) < Integer.Parse(fechaMayor.Day)) Then 'COMPARO LOS DÍAS DE CADA FECHA
            meses = Math.Abs(DateDiff(DateInterval.Month, fechaObtenida, fechaMayor)) 'CONSIGO LOS MESES QUE HAY ENTRE LA OBTENIDA Y LA FECHA MAYOR
            fechaObtenida = DateAdd(DateInterval.Month, Convert.ToInt32(meses), Convert.ToDateTime(fechaObtenida.Date)) 'CONSIGO LA NUEVA FECHA A PARTIR DE LOS MESES Y LA NUEVA FECHA HECHA EN LA LÍNEA ANTERIOR
            dias = Math.Abs(DateDiff(DateInterval.Day, fechaObtenida, fechaMayor))
            fechaObtenida = DateAdd(DateInterval.Day, Convert.ToInt32(dias), Convert.ToDateTime(fechaObtenida.Date))
        ElseIf (Integer.Parse(fechaObtenida.Day) > Integer.Parse(fechaMayor.Day)) Then
            meses = Math.Abs(DateDiff(DateInterval.Month, fechaObtenida, fechaMayor)) - 1 'LE RESTO 1 PARA CUANDO CAMBIA DE MES
            fechaObtenida = DateAdd(DateInterval.Month, Convert.ToInt32(meses), Convert.ToDateTime(fechaObtenida.Date))
            dias = Math.Abs(DateDiff(DateInterval.Day, fechaObtenida, fechaMayor))
            fechaObtenida = DateAdd(DateInterval.Day, Convert.ToInt32(dias), Convert.ToDateTime(fechaObtenida.Date))
        End If
        'txtFechaCalculada.Text = annos & " años, " & meses & " meses y " & dias & " dias"
    End Sub
End Module
