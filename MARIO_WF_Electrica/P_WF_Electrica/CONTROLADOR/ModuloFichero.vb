Imports System.IO
Imports Microsoft.Office.Interop

Module ModuloFichero

    Dim oWord As New Word.Application
    'Dim oWord As New Microsoft.Office.Interop.Word.Application
    Dim oDocumento As Word.Document

    Public Function comprobarInfo(ByRef texto As RichTextBox)
        Dim contadorMeses As Integer = -1
        Dim contadorSemanas As Integer = -1
        Dim posMes As Integer
        Dim semana As Integer
        Dim listaCaracteres() As String
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim primeraVez As Boolean = True
        Dim formatoCorrecto As Boolean = True
        Dim mesAnterior As Integer = -1
        Linea = srLector.ReadLine()
        Do While Not (Linea Is Nothing)

            semana = -1

            posMes = Array.IndexOf(nMeses, Linea)

            listaCaracteres = Linea.Split(";")
            If posMes = -1 And listaCaracteres.Length = 1 Then

                errores = "Mes incorrecto --> " & Linea
                formatoCorrecto = False
                Exit Function
            Else

                If (mesAnterior + 1) <> posMes And mesAnterior <> -1 Then

                    formatoCorrecto = False
                    If (mesAnterior = 11 And posMes = 0) Then
                        formatoCorrecto = True
                    Else
                        errores = "Mes incorrecto, no sigue el orden lógico del calendario --> " & Linea
                        Exit Function
                    End If
                End If

                If formatoCorrecto Then
                    contadorMeses = contadorMeses + 1
                    mesAnterior = posMes
                    indiceMes(contadorMeses) = posMes
                    'leer las semanas
                    Linea = srLector.ReadLine()
                    While contadorSemanas < 3
                        contadorSemanas = contadorSemanas + 1
                        semana = semana + 1
                        indiceSemanas(semana) = contadorSemanas
                        listaCaracteres = Linea.Split(";")
                        errores = "Semana incorrecta --> " & Linea 'ME ENVIA LA LÍNEA DE LA SEMANA ENTERA
                        Linea = srLector.ReadLine()
                        If listaCaracteres.Length = 7 Then
                            For i = 0 To listaCaracteres.Length - 1
                                If listaCaracteres(i) = "" Then
                                    formatoCorrecto = False
                                    Exit Function
                                Else
                                    Dim b As Integer = 0

                                    'COMPRUEBO SI SE PUEDE CONVERTIR A INTEGER
                                    If Not (Integer.TryParse(listaCaracteres(i), b)) Then
                                        formatoCorrecto = False
                                        Exit Function
                                    Else
                                        anadirAlArray(contadorMeses, contadorSemanas, i, listaCaracteres(i))
                                    End If
                                End If
                            Next
                        Else
                            errores = Linea
                            formatoCorrecto = False
                            Exit Function
                        End If

                    End While
                End If
            End If
            ' End If
            posMes = Array.IndexOf(nMeses, Linea)
            contadorSemanas = -1
        Loop
        srLector.Close()
        Return formatoCorrecto
    End Function

    Public Sub mostrarInfoDelFichero(ByRef texto As RichTextBox)
        texto.ResetText() 'RESETEAMOS LO QUE PUEDA HABER EN EL RICHBOX DEL FORM
        Dim contadorSemanas As Integer = 0
        Dim contadorMeses As Integer = -1
        Dim posMes As Integer
        Dim semana As Integer
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim primeraVez As Boolean = True

        Linea = srLector.ReadLine()
        Do While Not (Linea Is Nothing)
            texto.AppendText(Linea & vbCrLf)
            contadorSemanas = 0
            semana = -1

            posMes = Array.IndexOf(nMeses, Linea)
            contadorMeses = contadorMeses + 1
            Linea = srLector.ReadLine()

            For contadorSemanas = 0 To 3
                texto.AppendText(Linea & vbCrLf)
                semana = semana + 1
                indiceSemanas(semana) = contadorSemanas
                Linea = srLector.ReadLine()
            Next
            posMes = Array.IndexOf(nMeses, Linea)
        Loop
        srLector.Close()

    End Sub

    Public Sub insertarEnFichero(ByVal Nombrecliente As TextBox, ByVal cifCliente As TextBox, ByVal NombreRepresentante1 As TextBox,
                             ByVal CargoRepresentante1 As TextBox, ByVal telefono As TextBox)
        Dim swEscritor As StreamWriter
        swEscritor = New StreamWriter(directorio & "\Contratos.txt", True, System.Text.Encoding.Default)
        swEscritor.WriteLine(Nombrecliente.Text & ";" & cifCliente.Text & ";" & NombreRepresentante1.Text & ";" & CargoRepresentante1.Text & ";" & telefono.Text)
        swEscritor.Close()
    End Sub

    Public Function comprobarExisteCIFContratosTXT(ByVal cifCliente As TextBox)
        'Dim directorio2 As String = "C:\Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_WF_Electrica"
        crearFicheroContratos()
        Dim srLector As StreamReader = New StreamReader(directorio & "\Contratos.txt")
        Dim Linea As String = ""
        Dim listaCaracteres() As String
        Dim existe As Boolean = True

        Linea = srLector.ReadLine()
        Do While Not (Linea Is Nothing)
            listaCaracteres = Linea.Split(";")
            If listaCaracteres(1) = cifCliente.Text Then
                MessageBox.Show("ESE CIF YA EXISTE. NO SE PUEDE CREAR UN CONTRATO IGUAL")
                existe = False
                Exit Do
            End If
            Linea = srLector.ReadLine()
        Loop
        srLector.Close()
        Return existe
    End Function

    Public Sub leerFicheroContratoTxt(ByVal NombreNotario As TextBox, ByVal NumProtocolo As TextBox, ByVal CiudadNotario As TextBox,
                                    ByVal CiudadMercantil As TextBox, ByVal DiaInscripNotario As TextBox, ByVal MesInscripNotario As TextBox,
                                    ByVal AnnoInscripNotario As TextBox, ByVal Tomo As TextBox, ByVal Folio As TextBox,
                                    ByVal Hoja As TextBox, ByVal NumInscripcion As TextBox, ByVal NombreRepresentante1 As TextBox,
                                    ByVal CargoRepresentante1 As TextBox, ByVal DiaRepresentante1 As TextBox, ByVal MesRepresentante1 As TextBox,
                                    ByVal AnnoRepresentante1 As TextBox, ByVal NomNotarioRepresentante1 As TextBox, ByVal ProtNotarioRepresentante1 As TextBox,
                                    ByVal CiudNotarioRepresentante1 As TextBox, ByVal NomPrestador As TextBox, ByVal NacionalidadPrestador As TextBox,
                                    ByVal CiudadPrestador As TextBox, ByVal DireccionPrestador As TextBox, ByVal NumDirecPrestador As TextBox,
                                    ByVal CifPrestador As TextBox, ByVal telefonoPrestador As TextBox, ByVal EmailPrestador As TextBox, ByVal BancoPrestador As TextBox,
                                    ByVal EntidadPrestador As TextBox, ByVal OficinaPrestador As TextBox, ByVal DCPrestador As TextBox, ByVal NumCuentaPrestador As TextBox,
                                    ByVal NombreRepresentante2 As TextBox,
                                    ByVal CargoRepresentante2 As TextBox, ByVal DiaRepresentante2 As TextBox, ByVal MesRepresentante2 As TextBox,
                                    ByVal AnnoRepresentante2 As TextBox, ByVal NomNotarioRepresentante2 As TextBox, ByVal ProtNotarioRepresentante2 As TextBox,
                                    ByVal CiudNotarioRepresentante2 As TextBox)
        Dim directorio2 As String = "C:\Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_WF_Electrica"
        'Dim directorio2 As String = "D:\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_WF_Electrica"
        Dim srLector As StreamReader = New StreamReader(directorio2 & "\datosContrato.txt")
        Dim Linea As String = ""
        Dim listaCaracteres() As String

        For i = 1 To 3 'PARA QUE EMPIEZE DONDE YA HAY DATOS
            Linea = srLector.ReadLine()
        Next

        Do While Not (Linea Is Nothing)
            For i = 1 To 4
                listaCaracteres = Linea.Split(";")
                If i = 1 Then
                    CiudadNotario.Text = listaCaracteres(0)
                    NombreNotario.Text = listaCaracteres(1)
                    NumProtocolo.Text = listaCaracteres(2)
                    DiaInscripNotario.Text = listaCaracteres(3)
                    MesInscripNotario.Text = listaCaracteres(4)
                    AnnoInscripNotario.Text = listaCaracteres(5)
                    CiudadMercantil.Text = listaCaracteres(6)
                    Tomo.Text = listaCaracteres(7)
                    Folio.Text = listaCaracteres(8)
                    Hoja.Text = listaCaracteres(9)
                    NumInscripcion.Text = listaCaracteres(10)
                ElseIf i = 2 Then
                    NombreRepresentante1.Text = listaCaracteres(0)
                    CargoRepresentante1.Text = listaCaracteres(1)
                    DiaRepresentante1.Text = listaCaracteres(2)
                    MesRepresentante1.Text = listaCaracteres(3)
                    AnnoRepresentante1.Text = listaCaracteres(4)
                    CiudNotarioRepresentante1.Text = listaCaracteres(5)
                    NomNotarioRepresentante1.Text = listaCaracteres(6)
                    ProtNotarioRepresentante1.Text = listaCaracteres(7)
                ElseIf i = 3 Then
                    NomPrestador.Text = listaCaracteres(0)
                    NacionalidadPrestador.Text = listaCaracteres(1)
                    CiudadPrestador.Text = listaCaracteres(2)
                    DireccionPrestador.Text = listaCaracteres(3)
                    NumDirecPrestador.Text = listaCaracteres(4)
                    CifPrestador.Text = listaCaracteres(5)
                    telefonoPrestador.Text = listaCaracteres(6)
                    EmailPrestador.Text = listaCaracteres(7)
                    BancoPrestador.Text = listaCaracteres(8)
                    EntidadPrestador.Text = listaCaracteres(9)
                    OficinaPrestador.Text = listaCaracteres(10)
                    DCPrestador.Text = listaCaracteres(11)
                    NumCuentaPrestador.Text = listaCaracteres(12)
                Else
                    NombreRepresentante2.Text = listaCaracteres(0)
                    CargoRepresentante2.Text = listaCaracteres(1)
                    DiaRepresentante2.Text = listaCaracteres(2)
                    MesRepresentante2.Text = listaCaracteres(3)
                    AnnoRepresentante2.Text = listaCaracteres(4)
                    CiudNotarioRepresentante2.Text = listaCaracteres(5)
                    NomNotarioRepresentante2.Text = listaCaracteres(6)
                    ProtNotarioRepresentante2.Text = listaCaracteres(7)
                End If

                For a = 1 To 3 'PARA QUE EMPIEZE DONDE YA HAY DATOS
                    Linea = srLector.ReadLine()
                Next

            Next

        Loop
    End Sub

    Public Function recogerInfoDelFichero(ByRef arrayInfo As ArrayList)
        arrayInfo = New ArrayList

        arrayInfo.Clear() 'RESETEAMOS EL ARRAYlIST

        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim listaCaracteres() As String

        Linea = srLector.ReadLine()
        For a = 0 To 2 'PARA LOS MESES
            arrayInfo.Add(Linea)
            For b = 0 To 3 'PARA LAS SEMANAS
                arrayInfo.Add(b + 1)
                Linea = srLector.ReadLine()
                For c = 0 To 6 'PARA LOS DÍAS
                    listaCaracteres = Linea.Split(";")
                    arrayInfo.Add(listaCaracteres(c))
                Next
            Next
            Linea = srLector.ReadLine()
        Next

        srLector.Close()
        Return arrayInfo

    End Function

End Module
