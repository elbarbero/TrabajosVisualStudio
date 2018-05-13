Imports System.Data.SqlClient
Imports System.IO

Public Class FVenta

    'Dim cadenaConexion As String = My.MySettings.Default.BDAerolineaConnectionString
    'Dim cadenaConexion As String = "Data Source = MARIOPORTATIL\SQL_MARIO; Initial Catalog = BDAerolinea; Integrated Security = True"
    'Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
    'Dim consultasql As SqlCommand = New SqlCommand()

    Dim matriculaAvion As String
    Dim codVuelo As Integer
    Dim asientosOcupados As Integer
    Dim dni As String

    Private Sub FVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDAerolineaDataSet.TVuelos' Puede moverla o quitarla según sea necesario.
        'Me.TVuelosTableAdapter.Fill(Me.BDAerolineaDataSet.TVuelos) 'si pongo esto aqui, me ccarga todo
        panelDNI.Visible = False
        panelClases.Visible = False
    End Sub

    Private Function buscarVuelo(fecha As String)
        'Dim nombre As String
        'Dim lectorDatos As SqlDataReader
        'consultasql.CommandText = "Select * from TVuelos where fecha=" & fecha & ""
        'consultasql.CommandType = CommandType.Text
        'consultasql.Connection = conexion
        'conexion.Open()
        'lectorDatos = consultasql.ExecuteReader
        'nombre = lectorDatos.GetInt32(0)
        'conexion.Close()
        'Dim sql As String = "Select * from TVuelos where fecha=" & "'" & fecha & "'"
        Try
            Dim sql As String = "Select * from TVuelos where fecha=" & "'" & fecha & "'"
            'Dim sql As String = "Select * from TPasajes"
            consultasql = New SqlCommand(sql, conexion)
            Dim da As New SqlDataAdapter(consultasql)
            Dim dataset As New DataSet
            'Me.TVuelosTableAdapter.Fill(Me.BDAerolineaDataSet.TVuelos)

            'da.Fill(dataset, "TVuelos")
            'Me.DataGridView1.DataSource = dataset.Tables("TVuelos")


            da.Fill(BDAerolineaDataSet, "TVuelos")
            Me.DataGridView1.DataSource = BDAerolineaDataSet.Tables("TVuelos")
        Catch ex As SqlException
            MessageBox.Show("Se ha producido el error de formmato-->" & ex.Message)
        End Try


        'Me.TableFamiliasTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias)
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ' limpiarDataGridView()
        If txtFecha.Text = "" Then
            MessageBox.Show("Debes poner una fecha")
        Else
            buscarVuelo(txtFecha.Text.ToString)
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        matriculaAvion = Convert.ToString(DataGridView1.CurrentRow.Cells(4).Value)
        codVuelo = Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value)
        MessageBox.Show(matriculaAvion)
        leerVuelos()
        panelDNI.Show()
    End Sub

    Public Sub limpiarDataGridView()
        Dim n As Integer
        n = DataGridView1.Rows.Count
        Dim i As Integer

        For i = 0 To n
            DataGridView1.Rows.Clear()
        Next
    End Sub

    Public Sub leerVuelos()
        Dim asientosTurista As Integer
        Dim asientosBusiness As Integer
        Dim asientosPrimera As Integer
        Dim lectorDatos As SqlDataReader
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from TAviones where matricula=" & "'" & matriculaAvion & "'"
        conexion.Open()
        lectorDatos = consultasql.ExecuteReader


        While lectorDatos.Read
            If lectorDatos.GetInt32(5) = 3 Then 'comparo la columna 5 que tiene las clases que tiene
                asientosTurista = lectorDatos.GetInt32(3) - 10 - 20
                asientosBusiness = 10
                asientosPrimera = 20
                etiqueta.Text = asientosBusiness & " de Business, " & asientosPrimera & " de primera, " & asientosTurista & " de turista"
            ElseIf lectorDatos.GetInt32(5) = 2 Then
                asientosTurista = lectorDatos.GetInt32(3) - 20
                asientosBusiness = 0
                asientosPrimera = 20
                etiqueta.Text = asientosBusiness & " de Business, " & asientosPrimera & " de primera, " & asientosTurista & " de turista"
            ElseIf lectorDatos.GetInt32(5) = 1 Then
                asientosTurista = lectorDatos.GetInt32(3)
                asientosBusiness = 0
                asientosPrimera = 0
                etiqueta.Text = asientosBusiness & " de Business, " & asientosPrimera & " de primera, " & asientosTurista & " de turista"
            End If

        End While

        asientosPorVuelo(0) = asientosBusiness
            asientosPorVuelo(1) = asientosPrimera
        asientosPorVuelo(2) = asientosTurista

        lectorDatos.Close()
        conexion.Close()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'Dim dni As String
        Dim nombre As String
        Dim edad As Integer
        If txtDni.Text = "" Then
            MessageBox.Show("Rellena el campo")
        Else
            dni = existePasajero(txtDni.Text.ToString)
            If dni <> "" Then 'SI ESE DNI EXISTE EN LA BBDD
                nombre = conseguirNombrePasajero(txtDni.Text.ToString)
                panelDNI.Visible = False
                MessageBox.Show("Pasajero con el nombre " & nombre & " aceptado")
                edad = obtenerFechaNacimiento(txtDni.Text.ToString)
                If edad < 18 Then
                    MessageBox.Show("Pasajero con el nombre " & nombre & " tiene " & edad & " años")
                Else
                    cargarComboClases()
                    panelClases.Show()
                End If
            Else
                MessageBox.Show("No se pueden vender más billetes")
                panelDNI.Visible = False
            End If
        End If
        txtDni.Text = ""
    End Sub

    Public Function existePasajero(ByRef dniPasajero As String)
        Dim dni As String
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select dni from TPasajeros where dni=" & "'" & dniPasajero & "'"
        conexion.Open()
        dni = consultasql.ExecuteScalar

        If IsNothing(dni) Then
            MessageBox.Show("No existe nadie con el " & dniPasajero)
            conexion.Close()
            Exit Function
        End If
        conexion.Close()
        Return dni
    End Function

    Public Function conseguirNombrePasajero(ByRef dniPasajero As String)
        Dim nombre As String
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select nombre from TPasajeros where dni=" & "'" & dniPasajero & "'"
        conexion.Open()
        nombre = consultasql.ExecuteScalar

        ' If IsNothing(nombre) Then
        'MessageBox.Show("No existe nadie con el " & dniPasajero)
        'Exit Function
        '  End If
        conexion.Close()
        Return nombre
    End Function

    Public Function obtenerFechaNacimiento(ByRef dniPasajero As String)
        Dim fechaNac As Date
        Dim edad As Integer
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select fecha_nacimiento from TPasajeros where dni=" & "'" & dniPasajero & "'"
        conexion.Open()
        fechaNac = consultasql.ExecuteScalar
        'fechaNac = Date.Today
        edad = calcularEdad(fechaNac)
        ' If IsNothing(nombre) Then
        'MessageBox.Show("No existe nadie con el " & dniPasajero)
        'Exit Function
        '  End If
        conexion.Close()
        Return edad
    End Function

    Public Sub cargarComboClases()
        'For i = 0 To asientosPorVuelo.Length - 1
        'cmbClases.Items.Add(asientosPorVuelo(i))
        'Next
        If asientosPorVuelo(0) > 0 Then
            cmbClases.Items.Add(clases(0))
        End If
        If asientosPorVuelo(1) > 0 Then
            cmbClases.Items.Add(clases(1))
        End If
        If asientosPorVuelo(2) > 0 Then
            cmbClases.Items.Add(clases(2))
        End If

    End Sub

    Private Sub btnAceptarClase_Click(sender As Object, e As EventArgs) Handles btnAceptarClase.Click
        Dim asiento As String = asignarAsiento()
        insertarBilleteDeAvion(asiento, dni, cmbClases.SelectedItem)
        MessageBox.Show("Pasajero insertado correctamente")
        Me.Close()
    End Sub

    Public Function asignarAsiento()
        Dim asientoMax As String
        Dim asientoNuevo As String
        Dim listaCaracteres() As Char
        consultasql.Connection = conexion
        'Select Case clase, max(asiento) from TPasajes where vid=1000 GROUP BY clase
        consultasql.CommandText = "Select max(asiento) from TPasajes where vid= " & codVuelo & " and clase= " & "'" & cmbClases.SelectedItem & "'"   'PARA EJECUTAR UNA SENTENCIA
        consultasql.CommandType = CommandType.Text
        conexion.Open()

        If Not IsDBNull(consultasql.ExecuteScalar) Then
            asientoMax = consultasql.ExecuteScalar
            listaCaracteres = asientoMax.ToCharArray
            asientoNuevo = listaCaracteres(0) & listaCaracteres(1) & (Convert.ToInt32(listaCaracteres(2).ToString()) + 1).ToString
            asientosOcupados = (Convert.ToInt32(listaCaracteres(2).ToString()) + 1)
        Else
            listaCaracteres = cmbClases.SelectedItem.ToString.ToCharArray
            asientoNuevo = listaCaracteres(0).ToString & "01"
            asientosOcupados = 0
        End If
        conexion.Close()

        Return asientoNuevo
    End Function

    Public Function comprobarPlazasLibres()
        Dim libre As Boolean = False
        For i = 0 To clases.Length - 1
            If cmbClases.SelectedItem = clases(i) Then
                If asientosOcupados < asientosPorVuelo(i) Then 'Si LOS ASIENTOS OCUPADOS SON MENOS QUE LOS TIENE EL AVION
                    libre = True
                Else
                    MessageBox.Show("NO QUEDAN PLAZAS LIBRES EN ESA CLASE")
                End If
            End If
        Next
        Return libre
    End Function

    Public Sub insertarBilleteDeAvion(ByVal asientoNuevo As String, ByVal dni As String, ByVal clase As String)
        'Me HE KDAO EN COMPROBAR SI KDAN PLAZAN PARA ESA CLASE E INSERTARLAO EN LA TABLA

        'LEER EL MAYOR IDFAMILIA
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        'consultasql.CommandText = "Select max(id_Familia) from TableFamilias"

        'EJECUTAR LA CONSULTA
        conexion.Open()
        'codigo = consultasql.ExecuteScalar + 1
        'Dim sql As String = "insert into TableFamilias VALUES (" & codigo & ",'Familia" & codigo & "',1,2)"
        Dim sql As String = "insert into TPasajes (vid,asiento,dni,clase) VALUES (" & "'" & codVuelo & "','" & asientoNuevo & "','" & dni & "','" & clase & "')"

        consultasql.CommandText = sql
        consultasql.ExecuteNonQuery()
        'Me.TVuelosTableAdapter.Update(Me.BDAerolineaDataSet.TVuelos)
        Me.TVuelosTableAdapter.Fill(Me.BDAerolineaDataSet.TVuelos)
        conexion.Close()

    End Sub

End Class