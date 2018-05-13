Imports System.Xml
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objeto As Object
        Dim archivo As Object
        objeto = CreateObject("Scripting.FileSystemObject")
        archivo = objeto.CreateTextFile("D:\NuevosModulos\DesarrolloInterfaces\Ejercicios2017\Pficheros1\Datos\ArchivoXml.xml", True)
        archivo.WriteLine("<?xml version='1.0' encoding='UTF-8' standalone= 'yes'?>")
        archivo.WriteLine("<G>")
        For i = 0 To 3
            archivo.WriteLine("<Id imagen ='" & Convert.ToString(i) & "'>")
            archivo.WriteLine("<Subnodo1>Primero</Subnodo1>")
            archivo.WriteLine("<Subnodo2>Segundo</Subnodo2>")
            archivo.WriteLine("</Id>")
            archivo.WriteLine("")
        Next
        archivo.WriteLine("</G>")
        archivo.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim documentoxml As XmlDocument
            Dim listanodos As XmlNodeList
            Dim nodo As XmlNode
            documentoxml = New XmlDocument
            'Cargamos el documento XML
            documentoxml.Load("D:\NuevosModulos\DesarrolloInterfaces\Ejercicios2017\Pficheros1\Datos\ArchivoXml.xml")
            listanodos = documentoxml.SelectNodes("/G/Id")
            For Each nodo In listanodos
                Dim IdImagen = nodo.Attributes.GetNamedItem("imagen").Value
                Dim nodo1 = nodo.ChildNodes(0).InnerText
                Dim nodo2 = nodo.ChildNodes(1).InnerText
                MessageBox.Show("Id imagen: " & Convert.ToString(IdImagen) & " Nodo 1:" & nodo1 & "- nodo 2:" & nodo2)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
