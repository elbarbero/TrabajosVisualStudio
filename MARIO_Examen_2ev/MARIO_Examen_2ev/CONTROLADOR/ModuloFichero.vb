Imports System.IO

Module ModuloFichero

    Public Sub comprobarInfo(ByVal numeroModulo As Integer)
        'Dim formatoIncorrecto As Boolean = False
        Dim listaCaracteres() As String
        Dim srLector As StreamReader
        Dim Linea As String
        Dim a As Integer

        Dim ArrayArchivos As ArrayList = New ArrayList

        If numeroModulo = 1 Then
            ArrayArchivos.Add("Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\Modulo1.csv")
        ElseIf numeroModulo = 2 Then
            ArrayArchivos.Add("Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\Modulo2.csv")
        ElseIf numeroModulo = 3 Then
            ArrayArchivos.Add("Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\Modulo3.csv")
        ElseIf numeroModulo = 4 Then
            ArrayArchivos.Add("Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\Modulo4.csv")
        End If

        Dim formatoCorrecto As Boolean = True

        If numeroModulo > 0 And numeroModulo <= 4 Then
            For i = numeroModulo To numeroModulo 'PARA LEER LOS 4 ARCHIVOS
                a = 0
                srLector = New StreamReader(directorio & ArrayArchivos(i - 1).ToString)

                Linea = srLector.ReadLine()
                Do While Not (Linea Is Nothing)
                    listaCaracteres = Linea.Split(";")

                    DatosReales(a) = listaCaracteres(0)
                    a = a + 1
                    DatosReales(a) = listaCaracteres(1)
                    a = a + 1

                    Linea = srLector.ReadLine()
                Loop
                srLector.Close()
            Next

        End If

    End Sub

    Public Function comprobarExamenAlumno(ByVal rutaExamen As String)
        Dim formatoCorrecto As Boolean = True
        Dim listaCaracteres() As String
        Dim srLector As StreamReader = New StreamReader(rutaExamen)
        Dim Linea As String
        Dim a As Integer = 0
        Dim numeroModulo As Integer

        Linea = srLector.ReadLine()
        listaCaracteres = Linea.Split(";")
        numeroModulo = Integer.Parse(listaCaracteres(0).ToString)


        If listaCaracteres(0) < 1 Or listaCaracteres(0) > 4 Then 'SI EL NUMERO DEL MODULO NO COINCIDE
            formatoCorrecto = False
            errorEncontrado = "Modulo incorrecto" & " -->" & listaCaracteres(0)
        ElseIf Not comprobarCorreo(listaCaracteres(2)) Then 'SI EL CORREO ESTÁ MAL ESCRITO
            formatoCorrecto = False
            errorEncontrado = "correo no valido" & " -->" & listaCaracteres(2)
        Else
            For c = 0 To listaCaracteres.Length - 1
                examenAlumno(a) = listaCaracteres(c)
                a = a + 1
            Next
            For i = numeroModulo To numeroModulo
                Linea = srLector.ReadLine()
                Do While Not (Linea Is Nothing)

                    listaCaracteres = Linea.Split(";")
                    For b = 0 To listaCaracteres.Length - 1
                        If listaCaracteres(0) < 0 Or listaCaracteres(0) > 10 Then 'SI EL NMERO DE RESPUESTA NO COINCIDE
                            formatoCorrecto = False
                            errorEncontrado = "número de pregunta erronea" & " -->" & listaCaracteres(0)
                        ElseIf Not SoloUnaLetraConcreta(listaCaracteres(1).ToString, "A") And Not SoloUnaLetraConcreta(listaCaracteres(1).ToString, "B") And Not SoloUnaLetraConcreta(listaCaracteres(1).ToString, "C") And Not SoloUnaLetraConcreta(listaCaracteres(1).ToString, "D") Then
                            formatoCorrecto = False
                            errorEncontrado = "repuesta erronea" & " -->" & listaCaracteres(1)
                        Else

                            examenAlumno(a) = listaCaracteres(b)
                            a = a + 1
                        End If
                        ' a = +1
                    Next

                    Linea = srLector.ReadLine()
                Loop
                srLector.Close()

            Next
        End If
        Return formatoCorrecto

    End Function

    

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

    Public Sub insertarEnFichero()
        Dim swEscritor As StreamWriter
        swEscritor = New StreamWriter(directorio & "Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\ErrorFichero.txt", True, System.Text.Encoding.Default)
        swEscritor.WriteLine(examenAlumno(1) & " " & errorEncontrado & ";")
        swEscritor.Close()
    End Sub



End Module
