Imports Microsoft.Office.Interop
Imports System.IO

Module ModuloExcel

    Dim oExcel As Excel.Application
    'Creamos un libro y una hoja
    Dim libro As Excel.Workbook 'CREAMOS UN LIBRO
    Dim hoja As Excel.Worksheet 'CREAMOS UNA HOJA
    Dim rango As Excel.Range


    Public Sub generarExcel(ByVal nombreCabecera As String)

        'creamos una instancia de hoja de cálculo
        oExcel = New Excel.Application
        oExcel.Visible = True
        libro = oExcel.Workbooks.Add() 'AÑADIMOS UN LIBRO (Workbooks), ES DECIR, UN NUEVO ARCHIVO DEL EXCEL
        hoja = CType(libro.Sheets(1), Excel.Worksheet) 'TRABAJAMOS CON LA PRIMERA HOJA (Sheets(1))
        'Leemos los datos del fichero

        Try
            'Pasar datos a Excel
            rango = CType(hoja.Rows(1), Excel.Range) 'LE DECIMOS EN QUÉ FILA COMENZAMOS. EN LA PRIMERA (hoja.Rows(1))
            rango.EntireRow.Font.Bold = True
            hoja.Cells(1, 2) = nombreCabecera 'FILA 1, COLUMNA 2 (Cells(1, 2))
            rango = CType(hoja.Range("B3", "D11"), Microsoft.Office.Interop.Excel.Range) ' EL RANGO QUE RESERVAMOS VA DESDE 'B3' HASTA 'D11'
            rango.EntireRow.Font.Bold = True

            Dim fila As Integer = 3 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA FILA Nº3 DEL EXCEL
            Dim columna As Integer = 1 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA COLUMNA Nº1 DEL EXCEL

            For i = 0 To arrayLetras.Length - 1
                columna = 1
                hoja.Cells(fila, columna) = arrayLetras(i)
                columna += 1
                hoja.Cells(fila, columna) = DatosSumados(i)
                fila += 1

            Next

            Dim graficos As Excel.ChartObjects = CType(hoja.ChartObjects(),
           Excel.ChartObjects)
            'Añadimos el gráfico en la posición x=250 y=50 con 500 puntos de ancho x 300 de alto
            Dim ografico As Excel.ChartObject = graficos.Add(250, 50, 500, 300)
            Dim grafico As Excel.Chart = ografico.Chart
            'Tipo de gráfico
            grafico.ChartType = Excel.XlChartType.xlColumnClustered
            'Definimos el rango de columnas que contendrán los datos

            rango = hoja.Range(hoja.Cells(3, 1), hoja.Cells(fila, 2))
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

End Module
