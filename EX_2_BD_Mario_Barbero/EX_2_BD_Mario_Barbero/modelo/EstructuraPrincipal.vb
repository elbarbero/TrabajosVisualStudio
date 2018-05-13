Imports System.Data.SqlClient
Imports System.IO
Module EstructuraPrincipal

    Public cadenaConexion As String = "Data Source = MARIOPORTATIL\SQL_MARIO; Initial Catalog = BDacademia; Integrated Security = True"
    Public conexion As SqlConnection = New SqlConnection(cadenaConexion)
    Public consultasql As SqlCommand = New SqlCommand()

End Module
