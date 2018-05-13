Public Class Alumnos

    Dim matricula As String
    Dim nombre As String
    Dim apellido As String
    Dim fechaNac As String
    Dim sexo As Char
    Dim nombreTutor As String
    Dim dniTutor As String
    Dim NumHermanos As Integer

    Public Function getMatricula() As String
        Return matricula
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function

    Public Function getApellido() As String
        Return apellido
    End Function

    Public Function getFechaNac() As String
        Return fechaNac
    End Function

    Public Function getSexo() As Char
        Return sexo
    End Function

    Public Function getNombreTutor() As String
        Return nombreTutor
    End Function

    Public Function getDniTutor() As String
        Return dniTutor
    End Function

    Public Function getNumHermanos() As String
        Return NumHermanos
    End Function

    '-----------------------------------------set --------------------------------
    Public Sub setMatricula(ByVal valor As String)
        matricula = valor
    End Sub

    Public Sub setNombre(ByVal valor As String)
        nombre = valor
    End Sub

    Public Sub setApellido(ByVal valor As String)
        apellido = valor
    End Sub

    Public Sub setFechaNac(ByVal valor As String)
        fechaNac = valor
    End Sub
    Public Sub setsexo(ByVal valor As Char)
        sexo = valor
    End Sub
    Public Sub setNombreTutor(ByVal valor As String)
        nombreTutor = valor
    End Sub

    Public Sub setDniTutor(ByVal valor As Integer)
        dniTutor = valor
    End Sub

    Public Sub setNumHermanos(ByVal valor As String)
        NumHermanos = valor
    End Sub







    'Public Property matriculaA() As String
    '    Get
    '        Return matricula
    '    End Get
    '    Set(ByVal Value As String)
    '        matricula = Value
    '    End Set
    'End Property

    'Public Property nombreA() As String
    '    Get
    '        Return nombre
    '    End Get
    '    Set(ByVal Value As String)
    '        nombre = Value
    '    End Set
    'End Property

    'Public Property apellidoA() As String
    '    Get
    '        Return apellido
    '    End Get
    '    Set(ByVal Value As String)
    '        apellido = Value
    '    End Set
    'End Property

    'Public Property fechaNacA() As String
    '    Get
    '        Return fechaNac
    '    End Get
    '    Set(ByVal Value As String)
    '        fechaNac = Value
    '    End Set
    'End Property

    'Public Property sexoA() As Char
    '    Get
    '        Return sexo
    '    End Get
    '    Set(ByVal Value As Char)
    '        sexo = Value
    '    End Set
    'End Property

    'Public Property nombreTutorA() As String
    '    Get
    '        Return nombreTutor
    '    End Get
    '    Set(ByVal Value As String)
    '        nombreTutor = Value
    '    End Set
    'End Property

    'Public Property dniTutorA() As String
    '    Get
    '        Return dniTutor
    '    End Get
    '    Set(ByVal Value As String)
    '        dniTutor = Value
    '    End Set
    'End Property

    'Public Property NumHermanosA() As String
    '    Get
    '        Return NumHermanos
    '    End Get
    '    Set(ByVal Value As String)
    '        NumHermanos = Value
    '    End Set
    'End Property

    'Public Sub GrabarProducto(fila As Integer)
    '    tabla(fila, 0) = matricula
    '    tabla(fila, 1) = nombre
    '    tabla(fila, 2) = apellido
    '    tabla(fila, 3) = fechaNac
    '    tabla(fila, 4) = sexo
    '    tabla(fila, 5) = nombreTutor
    '    tabla(fila, 6) = dniTutorA
    '    tabla(fila, 7) = NumHermanos
    'End Sub

End Class
