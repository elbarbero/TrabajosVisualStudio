Imports System.Data.SqlClient
Imports System.IO
Public Class FEmail

    Dim ArrayPasajeros As ArrayList = New ArrayList

    Public Function exiteVuelo(ByVal codVuelo As String)
        Dim codigo As String
        Dim existeVuelo As Boolean = True
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from TVuelos where vid=" & "'" & codVuelo & "'"
        conexion.Open()
        codigo = consultasql.ExecuteScalar

        If IsNothing(codigo) Then
            existeVuelo = False
        End If
        conexion.Close()
        Return existeVuelo
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim mensaje As String = "el vuelo ha sido cancelado por inclemencias del tiempo"
        Dim a As Integer = 2
        If Not exiteVuelo(txtCodVuelo.Text) Then
            MessageBox.Show("No existe ningún vuelo con el código " & txtCodVuelo.Text)
        Else
            conseguirPasajerosDelVuelo()
            ' For i = 0 To ArrayPasajeros.ToString.Length - 1
            ' enviarCorreo(ArrayPasajeros(a), mensaje)
            ' a = a + 3
            ' Next
            eliminarPasajeroDelVuelo(txtCodVuelo.Text)
            eliminarTripulantesDelVuelo(txtCodVuelo.Text)
            eliminarVuelo(txtCodVuelo.Text)
            MessageBox.Show("Elvuelo con el código " & txtCodVuelo.Text & " ha sido borrado")
            Me.Close()
        End If
    End Sub

    Public Function conseguirPasajerosDelVuelo()
        'Dim ArrayPasajeros As ArrayList

        Dim lectorDatos As SqlDataReader
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select tpa.dni, tpa.nombre ,tpa.email from TPasajeros tpa, 
        (Select dni from TPasajes where vid=" & "'" & 1000 & "'" & "group by dni) Sub
        where tpa.dni = Sub.dni"
        conexion.Open()
        lectorDatos = consultasql.ExecuteReader


        While lectorDatos.Read
            For i = 0 To 2
                ArrayPasajeros.Add(lectorDatos.GetValue(i))
            Next
        End While
        lectorDatos.Close()
        conexion.Close()

        ' Select Case tpa.dni, tpa.nombre ,tpa.email from TPasajeros tpa, (Select dni from TPasajes where vid=1000 group by dni) Sub
        'where tpa.dni = Sub() .dni
    End Function

    Public Sub eliminarPasajeroDelVuelo(ByVal codVuelo As String)

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "delete from TPasajes where vid=" & "'" & codVuelo & "'"
        conexion.Open()
        consultasql.ExecuteNonQuery()
        Me.TPasajesTableAdapter.Fill(Me.BDAerolineaDataSet.TPasajes)
        conexion.Close()

        'delete From jugadores2 Where id_jugador = 17;
    End Sub

    Public Sub eliminarTripulantesDelVuelo(ByVal codVuelo As String)

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "delete from TTtripulaciones where vid=" & "'" & codVuelo & "'"
        conexion.Open()
        consultasql.ExecuteNonQuery()
        Me.TTtripulacionesTableAdapter1.Fill(Me.BDAerolineaDataSet.TTtripulaciones)
        conexion.Close()

        'delete From jugadores2 Where id_jugador = 17;
    End Sub

    Public Sub eliminarVuelo(ByVal codVuelo As String)

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "delete from TVuelos where vid=" & "'" & codVuelo & "'"
        conexion.Open()
        consultasql.ExecuteNonQuery()
        Me.TVuelosTableAdapter1.Fill(Me.BDAerolineaDataSet.TVuelos)
        conexion.Close()

        'delete From jugadores2 Where id_jugador = 17;
    End Sub

End Class