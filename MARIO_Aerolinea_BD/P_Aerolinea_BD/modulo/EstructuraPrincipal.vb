﻿Imports System.Data.SqlClient
Imports System.IO
Module EstructuraPrincipal

    Public asientosPorVuelo(2) As Integer 'GUARDO LAS PLAZAS QUE HAY DE CADA CLASE DEPENDIENDO DEL VUELO QUE SE ELIJA
    Public clases() As String = {"BUSINESS", "PRIMERA", "TURISTA"}
    Public cadenaConexion As String = "Data Source = MARIOPORTATIL\SQL_MARIO; Initial Catalog = BDAerolinea; Integrated Security = True"
    Public conexion As SqlConnection = New SqlConnection(cadenaConexion)
    Public consultasql As SqlCommand = New SqlCommand()

End Module
