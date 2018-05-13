Imports Microsoft.Office.Interop
Imports System.IO

Module ModuloExcel

    Dim oExcel As Excel.Application
    'Creamos un libro y una hoja
    Dim libro As Excel.Workbook 'CREAMOS UN LIBRO
    Dim hoja As Excel.Worksheet 'CREAMOS UNA HOJA
    Dim rango As Excel.Range


    Public Sub importarExcelInformeTotal(ByVal arrayInfo As ArrayList, ByVal nombreCabecera As String)

        'creamos una instancia de hoja de cálculo
        oExcel = New Excel.Application
        oExcel.Visible = True
        libro = oExcel.Workbooks.Add() 'AÑADIMOS UN LIBRO (Workbooks), ES DECIR, UN NUEVO ARCHIVO DEL EXCEL
        hoja = CType(libro.Sheets(1), Excel.Worksheet) 'TRABAJAMOS CON LA PRIMERA HOJA (Sheets(1))
        'Leemos los datos del fichero
        'Dim lectorDatos As StreamReader = New StreamReader(directorioDatos & "\Articulos.txt")
        Try
            'Pasar datos a Excel
            rango = CType(hoja.Rows(1), Excel.Range) 'LE DECIMOS EN QUÉ FILA COMENZAMOS. EN LA PRIMERA (hoja.Rows(1))
            rango.EntireRow.Font.Bold = True
            hoja.Cells(1, 2) = nombreCabecera 'FILA 1, COLUMNA 2 (Cells(1, 2))
            rango = CType(hoja.Range("B3", "D11"), Microsoft.Office.Interop.Excel.Range) ' EL RANGO QUE RESERVAMOS VA DESDE 'B3' HASTA 'D11'
            rango.EntireRow.Font.Bold = True

            Dim rango2 As Excel.Range
            Dim rango3 As Excel.Range
            Dim fila As Integer = 3 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA FILA Nº3 DEL EXCEL
            Dim columna As Integer = 1 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA COLUMNA Nº1 DEL EXCEL
            Dim contador As Integer = 0
            Dim a As Integer = 0

            For i = 0 To arrayInfo.Count - 1

                hoja.Cells(fila, columna) = arrayInfo(i)

                fila += 1

                If i = (a + 32) Then

                    If contador = 1 Then
                        hoja.Cells(fila, columna) = arrayInfo(i + 1)
                        i = i + 1
                    ElseIf contador = 2 Then
                        hoja.Cells(fila, columna) = arrayInfo(i + 1)
                        hoja.Cells(fila, columna) = arrayInfo(i + 1)
                        i = i + 1
                    End If
                    contador += 1
                    fila = 3
                    columna += 1
                    a = i

                    'i -= -1
                End If

            Next

            Dim graficos As Excel.ChartObjects = CType(hoja.ChartObjects(),
           Excel.ChartObjects)
            'Añadimos el gráfico en la posición x=250 y=50 con 500 puntos de ancho x 300 de alto
            Dim ografico As Excel.ChartObject = graficos.Add(250, 50, 500, 300)
            Dim grafico As Excel.Chart = ografico.Chart
            'Tipo de gráfico
            grafico.ChartType = Excel.XlChartType.xlColumnClustered
            'Definimos el rango de columnas que contendrán los datos

            oExcel.Range("A37").Formula = "=SUM(A5:A35)" 'SUMAMOS EL 1 MES
            rango = hoja.Range("A37")

            oExcel.Range("B37").Formula = "=SUM(B5:B35)" 'SUMAMOS EL 2 MES
            rango2 = hoja.Range("B37")

            oExcel.Range("C37").Formula = "=SUM(C5:C35)" 'SUMAMOS EL 3 MES
            rango3 = hoja.Range("C37")

            rango = hoja.Range(hoja.Cells(37, 1), hoja.Cells(37, 3))
            grafico.SetSourceData(rango)

            If Not oExcel Is Nothing Then
                oExcel.Quit()
                oExcel = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Fichero de datos erroneo " & ex.Message)
        End Try
        ' lectorDatos.Close()
        If Not oExcel Is Nothing Then
            oExcel.Quit()
            oExcel = Nothing
        End If
    End Sub


    Public Sub importarExcelInformeSemanal(ByVal nombreCabecera As String, ByVal posMes As Integer, ByVal posSemana As Integer)
        oExcel = New Excel.Application
        oExcel.Visible = True
        libro = oExcel.Workbooks.Add() 'AÑADIMOS UN LIBRO (Workbooks), ES DECIR, UN NUEVO ARCHIVO DEL EXCEL
        hoja = CType(libro.Sheets(1), Excel.Worksheet) 'TRABAJAMOS CON LA PRIMERA HOJA (Sheets(1))
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim listaCaracteres() As String

        Try
            'Pasar datos a Excel
            rango = CType(hoja.Rows(1), Excel.Range) 'LE DECIMOS EN QUÉ FILA COMENZAMOS. EN LA PRIMERA (hoja.Rows(1))
            rango.EntireRow.Font.Bold = True
            hoja.Cells(1, 2) = nombreCabecera 'FILA 1, COLUMNA 2 (Cells(1, 2))
            rango = CType(hoja.Range("B3", "D11"), Microsoft.Office.Interop.Excel.Range) ' EL RANGO QUE RESERVAMOS VA DESDE 'B3' HASTA 'D11'
            rango.EntireRow.Font.Bold = True

            Dim fila As Integer = 3 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA FILA Nº3 DEL EXCEL
            Dim columna As Integer = 2 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA COLUMNA Nº1 DEL EXCEL
            Dim contador As Integer = 0
            Dim a As Integer = 0
            'Dim mesElegido As String

            For a = 0 To (5 * posMes) 'PARA LOS MESES
                'LO MULTIPLICO X5 PARA QUE SE SALTE EL NOMBRE DEL MES ANTERIOR Y LAS 4 SEMANAS DEL MES ANTERIOR
                Linea = srLector.ReadLine()
                'mesElegido = Linea
                If a = (5 * posMes) Then
                    For b = 0 To posSemana 'PARA LAS SEMANAS
                        Linea = srLector.ReadLine()
                        If b = posSemana Then
                            For i = 0 To 6 'PARA LOS DÍAS
                                listaCaracteres = Linea.Split(";")
                                hoja.Cells(fila, columna - 1) = diasSemana(i)
                                hoja.Cells(fila, columna) = listaCaracteres(i)
                                fila += 1

                            Next
                        End If
                    Next
                End If
            Next

            Dim graficos As Excel.ChartObjects = CType(hoja.ChartObjects(), Excel.ChartObjects)
            'Añadimos el gráfico en la posición x=250 y=50 con 500 puntos de ancho x 300 de alto
            Dim ografico As Excel.ChartObject = graficos.Add(250, 50, 500, 300)
            Dim grafico As Excel.Chart = ografico.Chart
            'Tipo de gráfico
            grafico.ChartType = Excel.XlChartType.xlPie
            'Definimos el rango de columnas que contendrán los datos

            rango = hoja.Range(hoja.Cells(3, 2), hoja.Cells(9, 2))
            grafico.SetSourceData(rango)
            If Not oExcel Is Nothing Then
                oExcel.Quit()
                oExcel = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Fichero de datos erroneo " & ex.Message)
        End Try

    End Sub

End Module
