Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1

    Dim oExcel As Excel.Application
    'Creamos un libro y una hoja
    Dim libro As Microsoft.Office.Interop.Excel.Workbook 'CREAMOS UN LIBRO
    Dim hoja As Microsoft.Office.Interop.Excel.Worksheet 'CREAMOS UNA HOJA
    Dim rango As Microsoft.Office.Interop.Excel.Range
    Dim linea As String
    Dim datos() As String
    Dim directorioDatos As String = "C:\Users\Mario-Portatil\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_Excel"

    Private Sub btnImportarExcel_Click(sender As Object, e As EventArgs) Handles btnImportarExcel.Click
        'creamos una instancia de hoja de cálculo
        oExcel = New Microsoft.Office.Interop.Excel.Application
        oExcel.Visible = True
        libro = oExcel.Workbooks.Add() 'AÑADIMOS UN LIBRO (Workbooks), ES DECIR, UN NUEVO ARCHIVO DEL EXCEL
        hoja = CType(libro.Sheets(1), Excel.Worksheet) 'TRABAJAMOS CON LA PRIMERA HOJA (Sheets(1))
        'Leemos los datos del fichero
        Dim lectorDatos As StreamReader = New StreamReader(directorioDatos & "\Articulos.txt")
        Try
            'Pasar datos a Excel
            rango = CType(hoja.Rows(1), Excel.Range) 'LE DECIMOS EN QUÉ FILA COMENZAMOS. EN LA PRIMERA (hoja.Rows(1))
            rango.EntireRow.Font.Bold = True
            hoja.Cells(1, 2) = "Movimientos de salida de los productos" 'FILA 1, COLUMNA 2 (Cells(1, 2))
            rango = CType(hoja.Range("B3", "D11"), Excel.Range) ' EL RANGO QUE RESERVAMOS VA DESDE 'B3' HASTA 'D11'
            rango.EntireRow.Font.Bold = True
            linea = lectorDatos.ReadLine
            linea = lectorDatos.ReadLine
            Dim fila As Integer = 3 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA FILA Nº3 DEL EXCEL
            Do While Not (linea Is Nothing)
                datos = Split(linea, ";")
                If datos(5) = "S" Then 'SI EL TIPO DEL PRODUCTO ES IGUAL A 'S'
                    hoja.Cells(fila, 2) = datos(0)
                    hoja.Cells(fila, 3) = datos(3)
                    fila += 1
                End If
                linea = lectorDatos.ReadLine
            Loop
            Dim graficos As Excel.ChartObjects = CType(hoja.ChartObjects(), 
           Excel.ChartObjects)
            'Añadimos el gráfico en la posición x=250 y=50 con 500 puntos de ancho x 300 de alto
            Dim ografico As Excel.ChartObject = graficos.Add(250, 50, 500, 300)
            Dim grafico As Excel.Chart = ografico.Chart
            'Tipo de gráfico
            grafico.ChartType = Excel.XlChartType.xlColumnClustered
            'Definimos el rango de columnas que contendrán los datos
            rango = hoja.Range(hoja.Cells(3, 2), hoja.Cells(fila - 1, 3))
            grafico.SetSourceData(rango)
            If Not oExcel Is Nothing Then
                oExcel.Quit()
                oExcel = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Fichero de datos erroneo " & ex.Message)
        End Try
        lectorDatos.Close()
        If Not oExcel Is Nothing Then
            oExcel.Quit()
            oExcel = Nothing
        End If
    End Sub

    Private Sub btnSalidaXArticulos_Click(sender As Object, e As EventArgs) Handles btnSalidaXArticulos.Click
        oExcel = New Excel.Application
        oExcel.Visible = True
        libro = oExcel.Workbooks.Add() 'AÑADIMOS UN LIBRO (Workbooks), ES DECIR, UN NUEVO ARCHIVO DEL EXCEL
        hoja = CType(libro.Sheets(1), Excel.Worksheet) 'TRABAJAMOS CON LA PRIMERA HOJA (Sheets(1))
        'Leemos los datos del fichero

        Try
            'Pasar datos a Excel
            rango = CType(hoja.Rows(1), Excel.Range) 'LE DECIMOS EN QUÉ FILA COMENZAMOS. EN LA PRIMERA (hoja.Rows(1))
            rango.EntireRow.Font.Bold = True
            hoja.Cells(1, 2) = "Agrupados por articulos" 'FILA 1, COLUMNA 2 (Cells(1, 2))
            rango = CType(hoja.Range("B3", "D11"), Microsoft.Office.Interop.Excel.Range) ' EL RANGO QUE RESERVAMOS VA DESDE 'B3' HASTA 'D11'
            rango.EntireRow.Font.Bold = True

            Dim fila As Integer = 3 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA FILA Nº3 DEL EXCEL
            Dim columna As Integer = 1 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA COLUMNA Nº1 DEL EXCEL

            For i = 0 To producto.Length - 1
                columna = 1
                hoja.Cells(fila, columna) = producto(i)
                columna += 1
                hoja.Cells(fila, columna) = datosSumados(i)
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

            rango = hoja.Range(hoja.Cells(3, 1), hoja.Cells(fila - 1, 2))
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

    Public Sub comprobarInfo()

        Dim listaCaracteres() As String
        Dim srLector As StreamReader
        Dim Linea As String
        Dim pos As Integer = 0
        Dim a As Integer

        Dim formatoCorrecto As Boolean = True
        Dim contador12C As Integer
        Dim contador20B As Integer
        Dim contador25D As Integer

        srLector = New StreamReader(directorioDatos & "\Articulos.txt")

        Linea = srLector.ReadLine()
        Linea = srLector.ReadLine()

        Do While Not (Linea Is Nothing)
            ' For i = 0 To 8

            listaCaracteres = Linea.Split(";")

            If listaCaracteres(0).Trim.CompareTo("12C") = 0 Then
                contador12C = contador12C + listaCaracteres(3)
                If Not comprobarCualquierArray(producto, listaCaracteres(0), 3) Then
                    producto(0) = listaCaracteres(0).Trim
                End If
            ElseIf listaCaracteres(0).Trim.CompareTo("20B") = 0 Then
                contador20B = contador20B + listaCaracteres(3)
                If Not comprobarCualquierArray(producto, listaCaracteres(0), 3) Then
                    producto(1) = listaCaracteres(0).Trim
                End If
            ElseIf listaCaracteres(0).Trim.CompareTo("25D") = 0 Then
                contador25D = contador25D + listaCaracteres(3)
                If Not comprobarCualquierArray(producto, listaCaracteres(0), 3) Then
                    producto(2) = listaCaracteres(0).Trim
                End If
            End If

            For a = 0 To listaCaracteres.Length - 1

                datosOriginales(pos) = listaCaracteres(a).Trim
                pos = pos + 1
            Next
            Linea = srLector.ReadLine()

        Loop
        srLector.Close()

        datosSumados(0) = contador12C
        datosSumados(1) = contador20B
        datosSumados(2) = contador25D

    End Sub

    Public Function comprobarCualquierArray(ByVal miArray As Array, ByVal valor As String, ByVal pos As Integer)

        Dim existe As Boolean = False

        For i = 0 To (pos - 1)
            If miArray(i) <> "" Then
                If miArray(i).ToString.CompareTo(valor.Trim) = 0 Then
                    existe = True
                    Return existe
                    Exit Function
                End If
            Else
                Exit For
            End If
            Next

        Return existe
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobarInfo()
    End Sub
End Class
