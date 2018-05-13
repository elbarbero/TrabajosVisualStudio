Public Class ClaseAlumno

    Private Tnumero As Integer
        Private Tnombre As String
        Private Tnivel As Byte
        Private Tmaterial(2) As Boolean

        Property numero As String
            Get
                numero = Tnumero
            End Get
            Set(value As String)
                Tnumero = value
            End Set
        End Property

    'Public Sub setTnombre(ByVal valor As String)
    '    Tnombre = valor
    'End Sub

    'Public Function getTnombre() As String
    '    Return Tnombre
    'End Function



    Property nombre As String
            Get
                nombre = Tnombre
            End Get
            Set(value As String)
                Tnombre = value
            End Set
        End Property

        Property nivel As Byte
            Get
                nivel = Tnivel
            End Get
            Set(value As Byte)
                If value < 1 Or value > 3 Then
                    'El dato es incorrecto generamos una excepción que será tratada en el código
                    'que maneje el objeto
                    Dim NivelExceptión As New ArgumentException
                    Throw NivelExceptión
                Else
                    Tnivel = value
                End If
            End Set
        End Property
        'Asignar valores a un dato de tipo array
        Property material As Boolean()
            Get
                Return Tmaterial
            End Get
            Set(value As Boolean())
                Tmaterial(0) = value(0)
                Tmaterial(1) = value(1)
                Tmaterial(2) = value(2)
            End Set
        End Property


End Class
