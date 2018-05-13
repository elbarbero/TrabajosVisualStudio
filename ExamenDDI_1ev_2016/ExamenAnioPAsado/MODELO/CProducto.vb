Public Class CProducto
        Private codigo As String
        Private familia As Byte
        Private descripcion As String
        Private fechaAlta As Date
        Private existenciasMin As Integer
        Private existenciasActuales As Integer

        Public Property CodigoP() As String
            Get
                Return codigo
            End Get
            Set(ByVal Value As String)
                codigo = Value
            End Set
        End Property

        Public Property DescripcionP() As String
            Get
                Return descripcion
            End Get
            Set(ByVal Value As String)
                descripcion = Value
            End Set
        End Property

        Public Property FamiliaP() As String
            Get
                Return familia
            End Get
            Set(ByVal Value As String)
                familia = Value
            End Set
        End Property

        Public Property FechaAltaP() As String
            Get
                Return fechaAlta
            End Get
            Set(ByVal Value As String)
                fechaAlta = Value
            End Set
        End Property

        Public Property ExistenciasMinP() As String
            Get
                Return existenciasMin
            End Get
            Set(ByVal Value As String)
                existenciasMin = Value
            End Set
        End Property

        Public Property ExistenciasActualesP() As String
            Get
                Return existenciasActuales
            End Get
            Set(ByVal Value As String)
                existenciasActuales = Value
            End Set
        End Property
        Public Sub GrabarProducto(fila As Integer)
            tabla(fila, 0) = codigo
            tabla(fila, 1) = familia
            tabla(fila, 2) = descripcion
            tabla(fila, 3) = fechaAlta
            tabla(fila, 4) = existenciasActuales
            tabla(fila, 5) = existenciasMin
        End Sub
End Class

