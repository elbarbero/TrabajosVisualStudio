Imports System.IO
Imports System.Net.Mail
Imports Microsoft.Office.Interop

Module Control2

    'Public UNIDAD As String = Application.StartupPath.ToString.Substring(0, 3)
    ' Public directorio As String = UNIDAD & "DATOS"
    Dim errores As String
    Dim oWord As New Word.Application
    'Dim oWord As New Microsoft.Office.Interop.Word.Application
    Dim oDocumento As Word.Document



    Public Sub anadirAlArray(ByRef mes As Integer, ByRef semana As Integer,
                             ByRef dia As Integer, ByRef diaTexto As String)
        DATOS(mes, semana, dia) = diaTexto
    End Sub

    Public Function comprobarContrato(ByVal cliente As TextBox, ByVal nacionalidadCliente As TextBox, ByVal ciudadCliente As TextBox,
                                      ByVal direccionCliente As TextBox, ByVal numeroCliente As TextBox, ByVal cifCliente As TextBox,
                                      ByVal telefonoCliente As TextBox, ByVal EmailCliente As TextBox, ByVal BancoCliente As TextBox,
                                      ByVal EntidadCliente As TextBox, ByVal OficinaCliente As TextBox, ByVal DCCliente As TextBox, ByVal NumCuentaCliente As TextBox,
                                      ByVal NombreNotario As TextBox, ByVal NumProtocolo As TextBox, ByVal CiudadNotario As TextBox,
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
        Dim correcto As Boolean = True

        If cliente.Text = "" Or nacionalidadCliente.Text = "" Or ciudadCliente.Text = "" Or
           telefonoCliente.Text = "" Or EmailCliente.Text = "" Or BancoCliente.Text = "" Or EntidadCliente.Text = "" Or
        OficinaCliente.Text = "" Or DCCliente.Text = "" Or NumCuentaCliente.Text = "" Or direccionCliente.Text = "" Or
        numeroCliente.Text = "" Or cifCliente.Text = "" Then
            MessageBox.Show("DEBE RELLENAR TODOS LOS CAMPOS")
            correcto = False
        Else
            If Not validarCuenta(EntidadCliente.Text, OficinaCliente.Text, DCCliente.Text, NumCuentaCliente.Text) Then
                correcto = False
            ElseIf Not SoloNumeros(telefonoCliente, numeroCliente) Then
                correcto = False
            ElseIf Not SoloLetrasSinEspacios(cliente, nacionalidadCliente, ciudadCliente) Then
                correcto = False
            ElseIf Not SoloLetrasConEspacios(direccionCliente) Then
                correcto = False
            ElseIf Not comprobarCorreo(EmailCliente) Then
                correcto = False
            ElseIf Not comprobarDNI(cifCliente) Then
                correcto = False
            Else
                correcto = True
                leerFicheroContratoTxt(NombreNotario, NumProtocolo, CiudadNotario,
                          CiudadMercantil, DiaInscripNotario, MesInscripNotario,
                          AnnoInscripNotario, Tomo, Folio,
                          Hoja, NumInscripcion, NombreRepresentante1,
                          CargoRepresentante1, DiaRepresentante1, MesRepresentante1,
                          AnnoRepresentante1, NomNotarioRepresentante1, ProtNotarioRepresentante1,
                          CiudNotarioRepresentante1, NomPrestador, NacionalidadPrestador,
                          CiudadPrestador, DireccionPrestador, NumDirecPrestador,
                          CifPrestador, telefonoPrestador, EmailPrestador, BancoPrestador, EntidadPrestador,
                           OficinaPrestador, DCPrestador, NumCuentaPrestador, NombreRepresentante2,
                          CargoRepresentante2, DiaRepresentante2, MesRepresentante2,
                          AnnoRepresentante2, NomNotarioRepresentante2, ProtNotarioRepresentante2,
                          CiudNotarioRepresentante2)
            End If
        End If
        Return correcto
    End Function

End Module
