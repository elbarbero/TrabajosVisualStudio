Public Class ClaseCliente
    Dim Cnombre As String
    Dim Capellidos As String
    Dim Ctelefono As Integer
    Dim Cemail As String
    Dim Cvehiculo(3) As String

    Property nombre As String
        Get
            nombre = Cnombre
        End Get
        Set(value As String)
            Cnombre = value
        End Set
    End Property

    Property apellidos As String
        Get
            apellidos = Capellidos
        End Get
        Set(value As String)
            Capellidos = value
        End Set
    End Property

    Property telefono As Integer
        Get
            telefono = Ctelefono
        End Get
        Set(value As Integer)
            Ctelefono = value
        End Set
    End Property

    Property email As String
        Get
            email = Cemail
        End Get
        Set(value As String)
            Cemail = value
        End Set
    End Property


    'Asignar valores a un dato de tipo array
    Property vehiculo As String()
        Get
            Return Cvehiculo
        End Get
        Set(value As String())
            Cvehiculo(0) = value(0)
            Cvehiculo(1) = value(1)
            Cvehiculo(2) = value(2)
        End Set
    End Property

End Class
