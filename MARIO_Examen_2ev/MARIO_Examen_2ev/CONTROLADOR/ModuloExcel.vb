Imports Microsoft.Office.Interop
Imports System.IO

Module ModuloExcel


    Dim oExcel As Excel.Application
    'Creamos un libro y una hoja
    Dim libro As Excel.Workbook 'CREAMOS UN LIBRO
    Dim hoja As Excel.Worksheet 'CREAMOS UNA HOJA
    Dim rango As Excel.Range


    Public Sub generarExcel()

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
            hoja.Cells(1, 2) = "Grafico Notas" 'FILA 1, COLUMNA 2 (Cells(1, 2))
            rango = CType(hoja.Range("B3", "D11"), Microsoft.Office.Interop.Excel.Range) ' EL RANGO QUE RESERVAMOS VA DESDE 'B3' HASTA 'D11'
            rango.EntireRow.Font.Bold = True

            Dim fila As Integer = 5 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA FILA Nº3 DEL EXCEL
            Dim columna As Integer = 1 'ASÍ LE DECIMOS QUE EMPIECE A METER LOS DATOS EN LA COLUMNA Nº1 DEL EXCEL
            Dim fil As Integer = 5
            Dim numeroPregunta As Integer = 0

            hoja.Cells(3, 1) = Modulos(examenAlumno(0))

            hoja.Cells(3, 3) = examenAlumno(1) & "-" & calcularLetraDNI(examenAlumno(1))
            hoja.Cells(3, 5) = examenAlumno(2)


            For a = 0 To DatosReales.Length - 1
                hoja.Cells(fil, 1) = DatosReales(a) 'PONGO EL NUMERO DE LA PREGUNTA
                a = a + 1
                fil = fil + 1
            Next

            For i = 4 To examenAlumno.Length - 1 'PONGO LA RESPUESTA DE LA PREGUNTA
                If examenAlumno(i) <> "" Then
                    If DatosReales(numeroPregunta) = examenAlumno(i - 1) Then
                        hoja.Cells(fila, 2) = examenAlumno(i)
                        fila += 1
                        i = i + 1
                        numeroPregunta = numeroPregunta + 1
                    Else
                        hoja.Cells(fila, 2) = ""
                        fila += 1
                        i = i - 1
                        numeroPregunta = numeroPregunta + 1
                    End If

                    numeroPregunta = numeroPregunta + 1
                End If
            Next
            fila = 5
            For i = 0 To notasAlumno.Length - 1 'PONGO LA NOTA DE LA PREGUNTA


                hoja.Cells(fila, 3) = notasAlumno(i)
                fila += 1

            Next

            Dim graficos As Excel.ChartObjects = CType(hoja.ChartObjects(), 
           Excel.ChartObjects)
            'Añadimos el gráfico en la posición x=250 y=50 con 500 puntos de ancho x 300 de alto

            Dim ografico As Excel.ChartObject = graficos.Add(250, 50, 500, 300)
            Dim grafico As Excel.Chart = ografico.Chart
            'Tipo de gráfico
            grafico.HasTitle = True
            grafico.ChartTitle.Text = "Grafico Notas"
            grafico.ChartType = Excel.XlChartType.xlColumnClustered
            'Definimos el rango de columnas que contendrán los datos

            rango = hoja.Range(hoja.Cells(5, 3), hoja.Cells(fila - 1, 3))
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

    Public Sub ponerNotas()
        Dim listView As New ListViewItem
        Dim a As Integer = 3
        Dim b As Integer = 0
        Dim pos As Integer = 0
        Dim numeroPregunta As Integer = 0



        For i = 4 To examenAlumno.Length - 1 'PONGO LA RESPUESTA DE LA PREGUNTA
            If examenAlumno(i) <> "" Then
                If DatosReales(numeroPregunta) = examenAlumno(i - 1) Then

                    If DatosReales(numeroPregunta + 1) = examenAlumno(i) Then

                        notasAlumno(pos) = "1"

                        i = i + 1
                        numeroPregunta = numeroPregunta + 1
                    ElseIf DatosReales(numeroPregunta + 1) <> examenAlumno(i) Then

                        notasAlumno(pos) = "-0,25"

                        i = i + 1
                        numeroPregunta = numeroPregunta + 1
                    End If

                Else

                    notasAlumno(pos) = "0"

                    i = i - 1
                    numeroPregunta = numeroPregunta + 1
                End If

                numeroPregunta = numeroPregunta + 1
            End If
            pos = pos + 1
        Next

    End Sub

End Module
