Imports System.IO
Imports Microsoft.Office.Interop

Module ModuloWord

    Dim oWord As New Word.Application
    'Dim oWord As New Microsoft.Office.Interop.Word.Application
    Dim oDocumento As Word.Document

    Public Sub rellenarCamposWord(ByVal Nombrecliente As TextBox, ByVal nacionalidadCliente As TextBox, ByVal ciudadCliente As TextBox,
                             ByVal direccionCliente As TextBox, ByVal numeroDirecCliente As TextBox, ByVal cifCliente As TextBox,
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

        If comprobarExisteCIFContratosTXT(cifCliente) Then

            oDocumento = oWord.Documents.Open("C:\Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_WF_Electrica\Contrato-de-prestación-de-servicios.doc")
            'oDocumento = oWord.Documents.Open("D:\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_WF_Electrica\Contrato-de-prestación-de-servicios.doc")

            Dim c As Cliente = New Cliente(Nombrecliente.Text, nacionalidadCliente.Text, ciudadCliente.Text, direccionCliente.Text, Integer.Parse(numeroDirecCliente.Text), cifCliente.Text)
            ArrayClientes.Add(c)
            oDocumento.Bookmarks.Item("dia").Range.Text = Now.Day
            oDocumento.Bookmarks.Item("mes").Range.Text = Now.Month
            oDocumento.Bookmarks.Item("año").Range.Text = Now.Year
            oDocumento.Bookmarks.Item("cliente").Range.Text = Nombrecliente.Text.ToUpper
            oDocumento.Bookmarks.Item("nacionalidad").Range.Text = nacionalidadCliente.Text.ToUpper
            oDocumento.Bookmarks.Item("ciudad").Range.Text = ciudadCliente.Text.ToUpper
            oDocumento.Bookmarks.Item("direccion").Range.Text = direccionCliente.Text.ToUpper
            oDocumento.Bookmarks.Item("numDireccion").Range.Text = numeroDirecCliente.Text.ToUpper
            oDocumento.Bookmarks.Item("cif").Range.Text = cifCliente.Text.ToUpper





            oDocumento.Bookmarks.Item("ciudadNotario").Range.Text = CiudadNotario.Text.ToUpper
            oDocumento.Bookmarks.Item("nombreNotario").Range.Text = NombreNotario.Text.ToUpper
            oDocumento.Bookmarks.Item("diaNotario").Range.Text = Now.Day
            oDocumento.Bookmarks.Item("mesNotario").Range.Text = Now.Month
            oDocumento.Bookmarks.Item("añoNotario").Range.Text = Now.Year
            oDocumento.Bookmarks.Item("numProtocolo").Range.Text = NumProtocolo.Text
            oDocumento.Bookmarks.Item("diaProtocolo").Range.Text = DiaInscripNotario.Text
            oDocumento.Bookmarks.Item("mesProtocolo").Range.Text = MesInscripNotario.Text
            oDocumento.Bookmarks.Item("añoProtocolo").Range.Text = AnnoInscripNotario.Text
            oDocumento.Bookmarks.Item("ciudadMercantil").Range.Text = CiudadMercantil.Text.ToUpper
            oDocumento.Bookmarks.Item("numTomo").Range.Text = Tomo.Text
            oDocumento.Bookmarks.Item("numFolio").Range.Text = Folio.Text
            oDocumento.Bookmarks.Item("numHoja").Range.Text = Hoja.Text
            oDocumento.Bookmarks.Item("numInscripcion").Range.Text = NumInscripcion.Text

            oDocumento.Content.Find.Execute2007(FindText:="(nombre del representante1)", ReplaceWith:=NombreRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(cargo1)", ReplaceWith:=CargoRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(día1)", ReplaceWith:=DiaRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(mes1)", ReplaceWith:=MesRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(año1)", ReplaceWith:=AnnoRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(ciudad1)", ReplaceWith:=CiudNotarioRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(nombre1)", ReplaceWith:=NomNotarioRepresentante1.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(número1)", ReplaceWith:=ProtNotarioRepresentante1.Text.ToUpper)

            oDocumento.Content.Find.Execute2007(FindText:="(nombre de la entidad/ sociedad/ persona jurídica)", ReplaceWith:=NomPrestador.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(española)", ReplaceWith:=NacionalidadPrestador.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(ciudad3)", ReplaceWith:=CiudadPrestador.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(calle/ avenida/ plaza)", ReplaceWith:=DireccionPrestador.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(número3)", ReplaceWith:=NumDirecPrestador.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(CIF)", ReplaceWith:=CifPrestador.Text.ToUpper)

            oDocumento.Content.Find.Execute2007(FindText:="(ciudad4)", ReplaceWith:=CiudadNotario.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(nombre del Notario)", ReplaceWith:=NombreNotario.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(día3)", ReplaceWith:=Now.Day)
            oDocumento.Content.Find.Execute2007(FindText:="(mes3)", ReplaceWith:=Now.Month)
            oDocumento.Content.Find.Execute2007(FindText:="(año3)", ReplaceWith:=Now.Year)
            oDocumento.Content.Find.Execute2007(FindText:="(número)", ReplaceWith:=NumProtocolo.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(día4)", ReplaceWith:=DiaInscripNotario.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(mes4)", ReplaceWith:=MesInscripNotario.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(año4)", ReplaceWith:=AnnoInscripNotario.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(ciudad2)", ReplaceWith:=CiudadMercantil.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(númeroT)", ReplaceWith:=Tomo.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(númeroF)", ReplaceWith:=Folio.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(númeroH)", ReplaceWith:=Hoja.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(númeroI)", ReplaceWith:=NumInscripcion.Text)

            oDocumento.Content.Find.Execute2007(FindText:="(nombre del representante2)", ReplaceWith:=NombreRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(cargo2)", ReplaceWith:=CargoRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(día2)", ReplaceWith:=DiaRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(mes2)", ReplaceWith:=MesRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(año2)", ReplaceWith:=AnnoRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(ciudad2)", ReplaceWith:=CiudNotarioRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(nombre2)", ReplaceWith:=NomNotarioRepresentante2.Text.ToUpper)
            oDocumento.Content.Find.Execute2007(FindText:="(número2)", ReplaceWith:=ProtNotarioRepresentante2.Text.ToUpper)

            oDocumento.Bookmarks.Item("p5NomCliente").Range.Text = Nombrecliente.Text.ToUpper
            oDocumento.Bookmarks.Item("p5TlfCliente").Range.Text = telefonoCliente.Text.ToUpper
            oDocumento.Bookmarks.Item("p5EmailCliente").Range.Text = EmailCliente.Text.ToUpper
            oDocumento.Bookmarks.Item("p5DirecCliente").Range.Text = direccionCliente.Text.ToUpper

            oDocumento.Bookmarks.Item("p5NomPrestador").Range.Text = NomPrestador.Text.ToUpper
            oDocumento.Bookmarks.Item("p5TlfPrestador").Range.Text = telefonoPrestador.Text.ToUpper
            oDocumento.Bookmarks.Item("p5EmailPrestador").Range.Text = EmailPrestador.Text.ToUpper
            oDocumento.Bookmarks.Item("p5DirecPrestador").Range.Text = DireccionPrestador.Text.ToUpper

            oDocumento.Content.Find.Execute2007(FindText:="(indicar banco)", ReplaceWith:=BancoPrestador.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(indicar número de cuenta)", ReplaceWith:=(EntidadPrestador.Text & " " & OficinaPrestador.Text & " " & DCPrestador.Text & " " & NumCuentaPrestador.Text))

            oDocumento.Content.Find.Execute2007(FindText:="(nombrePrestadorFirma)", ReplaceWith:=NomPrestador.Text)
            oDocumento.Content.Find.Execute2007(FindText:="(nombreClienteFirma)", ReplaceWith:=Nombrecliente.Text)

            insertarEnFichero(Nombrecliente, cifCliente, NombreRepresentante1,
                              CargoRepresentante1, telefonoCliente)
            oDocumento.PrintOut()
        End If
        'oDocumento.Close()
        oWord.Quit()
    End Sub

End Module
