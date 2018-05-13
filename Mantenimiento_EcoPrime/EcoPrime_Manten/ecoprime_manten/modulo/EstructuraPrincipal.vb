Imports System.Data.SqlClient
Imports System.IO
Module EstructuraPrincipal
    Public cadenaConexion As String = "Data Source =MARIOPORTATIL\SQL_MARIO; Initial Catalog = EcoPrime; Integrated Security = True"
    Public conexion As SqlConnection = New SqlConnection(cadenaConexion)
    Public consultasql As SqlCommand = New SqlCommand()


    Public rutaApp As String = My.Computer.FileSystem.CurrentDirectory
    Public rutaCompleta As String = rutaApp + "\"
    'Public rutaCompleta As String = rutaApp + "\" + rutaImagen

    Public rutaImagen As String = ""
    Public rutaImgEcoPrime As String = rutaApp + "\LogoEcoPrime.png"
End Module
