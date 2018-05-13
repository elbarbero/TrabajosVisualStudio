Public Class Cliente

    Dim nombre As String
    Dim nacionalidad As String
    Dim ciudad As String
    Dim direccion As String
    Dim numeroDireccion As Integer
    Dim cif As String
    Dim telefono As Integer
    Dim email As String
    Dim banco As String
    Dim cargoR As String
    Dim nombreR As String

    Public Sub New(ByVal nombre As String, ByVal cif As String, ByVal nombreR As String, ByVal cargoR As String, ByVal telefono As Integer)
        nombre = nombre
        cif = cif
        nombreR = nombreR
        cargoR = cargoR
        telefono = telefono
    End Sub

    Public Sub New(nombre As String, nacionalidad As String, ciudad As String, direccion As String,
                    numeroDireccion As String, cif As String, telefono As Integer, email As String,
                    banco As String, nombreR As String, cargoR As String)
        nombre = nombre
        nacionalidad = nacionalidad
        ciudad = ciudad
        direccion = direccion
        numeroDireccion = numeroDireccion
        cif = cif
        telefono = telefono
        email = email
        banco = banco
        nombreR = nombreR
        cargoR = cargoR
    End Sub
    Public Sub New(nombre As String, nacionalidad As String, ciudad As String, direccion As String,
                    numeroDireccion As String, cif As String)
        Me.nombre = nombre
        Me.nacionalidad = nacionalidad
        Me.ciudad = ciudad
        Me.direccion = direccion
        Me.numeroDireccion = numeroDireccion
        Me.cif = cif
    End Sub


    Public Function getNombre()
        Return Me.nombre
    End Function

    Public Function setNombre(ByVal nombre As String)
        Me.nombre = nombre
    End Function

    Public Function geNacionalidad()
        Return Me.nacionalidad
    End Function

    Public Function setNacionalidad(ByVal nacionalidad As String)
        Me.nacionalidad = nacionalidad
    End Function

    Public Function getCiudad()
        Return Me.ciudad
    End Function

    Public Function setCiudad(ByVal ciudad As String)
        Me.ciudad = ciudad
    End Function
    Public Function getDireccion()
        Return Me.direccion
    End Function

    Public Function setDireccion(ByVal direccion As String)
        Me.direccion = direccion
    End Function
    Public Function getNumeroDireccion()
        Return Me.numeroDireccion
    End Function

    Public Function setNumeroDireccion(ByVal numeroDireccion As String)
        Me.numeroDireccion = numeroDireccion
    End Function
    Public Function getCif()
        Return Me.cif
    End Function

    Public Function setCif(ByVal cif As String)
        Me.cif = cif
    End Function

    Public Function getTelefono()
        Return Me.telefono
    End Function

    Public Function setTelefono(ByVal telefono As String)
        Me.telefono = telefono
    End Function

    Public Function getEmail()
        Return Me.email
    End Function

    Public Function setEmail(ByVal email As String)
        Me.email = email
    End Function

    Public Function getBanco()
        Return Me.banco
    End Function

    Public Function setBanco(ByVal banco As String)
        Me.banco = banco
    End Function

    Public Function getCargoR()
        Return Me.cargoR
    End Function

    Public Function setCargoR(ByVal cargoR As String)
        Me.cargoR = cargoR
    End Function

    Public Function getNombreR()
        Return Me.nombreR
    End Function

    Public Function setNombreR(ByVal nombreR As String)
        Me.nombreR = nombreR
    End Function

End Class
