Public Class Colaborador

    Dim nombre As String
    Dim precio As Integer
    Dim codPrograma As String
    Dim codClaborador As String
    Dim minutos As String



    Public Function getNombre() As String
        Return nombre
    End Function
    Public Function getPrecio() As Integer
        Return precio
    End Function
    Public Function getCodPrograma() As String
        Return codPrograma
    End Function

    Public Function getCodClaborador() As String
        Return codClaborador
    End Function

    Public Function getMinutos() As String
        Return minutos
    End Function

    Public Sub setNombre(ByVal valor As String)
        nombre = valor
    End Sub
    Public Sub setPrecio(ByVal valor As Integer)
        precio = valor
    End Sub
    Public Sub setCodPrograma(ByVal valor As String)
        codPrograma = valor
    End Sub

    Public Sub setCodClaborador(ByVal valor As String)
        codClaborador = valor
    End Sub

    Public Sub setMinutos(ByVal valor As String)
        minutos = valor
    End Sub


End Class
