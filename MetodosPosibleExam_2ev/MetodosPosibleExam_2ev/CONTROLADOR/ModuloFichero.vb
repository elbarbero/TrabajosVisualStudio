Imports System.IO

Module ModuloFichero

    Public Sub comprobarInfo()

        Dim listaCaracteres() As String
        Dim srLector As StreamReader
        Dim Linea As String
        Dim posEnArray As Integer
        Dim a As Integer

        Dim ArrayArchivos As ArrayList = New ArrayList
        ArrayArchivos.Add("\Modulo1.csv")
        ArrayArchivos.Add("\Modulo2.csv")
        ArrayArchivos.Add("\Modulo3.csv")
        ArrayArchivos.Add("\Modulo4.csv")

        Dim formatoCorrecto As Boolean = True
        Dim contadorA As Integer
        Dim contadorB As Integer
        Dim contadorc As Integer
        Dim contadorD As Integer

        For i = 0 To 3 'PARA LEER LOS 4 ARCHIVOS
            a = 0
            srLector = New StreamReader(directorio & ArrayArchivos(i).ToString)

            Linea = srLector.ReadLine()
            Do While Not (Linea Is Nothing)
                listaCaracteres = Linea.Split(";")

                If listaCaracteres(1).CompareTo("A") = 0 Then
                    contadorA = contadorA + 1
                    'posEnArray = 0
                ElseIf listaCaracteres(1).CompareTo("B") = 0 Then
                    contadorB = contadorB + 1
                    'posEnArray = 1
                ElseIf listaCaracteres(1).CompareTo("C") = 0 Then
                    contadorc = contadorc + 1
                    ' posEnArray = 2
                Else
                    contadorD = contadorD + 1
                    'posEnArray = 3
                End If

                DatosReles(i, a) = listaCaracteres(0)
                a = a + 1
                DatosReles(i, a) = listaCaracteres(1)
                a = a + 1
                'DATOS(posEnArray, 0)
                Linea = srLector.ReadLine()
            Loop
            srLector.Close()
        Next
        DatosSumados(0) = contadorA
        DatosSumados(1) = contadorB
        DatosSumados(2) = contadorc
        DatosSumados(3) = contadorD

    End Sub

    Public Sub conseguirSoloLetras()
        Dim listaCaracteres() As String
        Dim srLector As StreamReader
        Dim Linea As String
        Dim ultimaPosAnadida As Integer
        Dim primeraVez As Boolean = True
        Dim posEnAbecedario As Integer

        Dim ArrayArchivos As ArrayList = New ArrayList
        ArrayArchivos.Add("\Modulo1.csv")
        ArrayArchivos.Add("\Modulo2.csv")
        ArrayArchivos.Add("\Modulo3.csv")
        ArrayArchivos.Add("\Modulo4.csv")

        Dim formatoCorrecto As Boolean = True


        For i = 0 To 3 'PARA LEER LOS 4 ARCHIVOS

            srLector = New StreamReader(directorio & ArrayArchivos(i).ToString)

            Linea = srLector.ReadLine()
            Do While Not (Linea Is Nothing)
                listaCaracteres = Linea.Split(";")

                If primeraVez Then
                    'posEnAbecedario = conseguirPosicionenAbecedario(listaCaracteres(1))
                    arrayLetras(ultimaPosAnadida) = listaCaracteres(1)
                    primeraVez = False
                    ultimaPosAnadida = ultimaPosAnadida + 1
                ElseIf Not comprobarCualquierArray(arrayLetras, listaCaracteres(1), ultimaPosAnadida) Then
                    'posEnAbecedario = conseguirPosicionenAbecedario(listaCaracteres(1))
                    arrayLetras(ultimaPosAnadida) = listaCaracteres(1)
                    ultimaPosAnadida = ultimaPosAnadida + 1
                End If
                Linea = srLector.ReadLine()
            Loop
            srLector.Close()
        Next
        arrayLetras = colocarLetrasEnOrden(arrayLetras, 3)

    End Sub

    Public Function comprobarCualquierArray(ByVal miArray As Array, ByVal valor As String, ByVal pos As Integer)

        Dim existe As Boolean = False
        For i = 0 To (pos - 1)
            If miArray(i).ToString.CompareTo(valor) = 0 Then
                existe = True
                'Exit Function
            End If
        Next
        Return existe
    End Function

    Public Function colocarLetrasEnOrden(ByVal miArray As Array, ByVal posiciones As Integer)

        Dim longitudAbecedario As Integer = letasAbecedario.LongCount
        Dim letra As String
        Dim ArrayNuevo(posiciones) As String
        For i = 0 To longitudAbecedario - 1
            letra = letasAbecedario.Chars(i)
            For a = 0 To miArray.Length - 1
                If letra.CompareTo(miArray(a)) = 0 Then
                    ArrayNuevo(i) = miArray(a)
                End If
            Next
        Next
        Return ArrayNuevo
    End Function

End Module
