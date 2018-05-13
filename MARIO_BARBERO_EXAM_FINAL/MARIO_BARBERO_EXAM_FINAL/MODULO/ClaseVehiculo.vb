Public Class ClaseVehiculo
    Dim Vtipo As Integer
    Dim Vmodelo As Integer
    Dim Vfecha As Date

    Property tipo As Integer
        Get
            tipo = Vtipo
        End Get
        Set(value As Integer)
            Vtipo = value
        End Set
    End Property

    Property modelo As Integer
        Get
            modelo = Vmodelo
        End Get
        Set(value As Integer)
            Vmodelo = value
        End Set
    End Property

    Property fecha As Date
        Get
            fecha = Vfecha
        End Get
        Set(value As Date)
            Vfecha = value
        End Set
    End Property

End Class
