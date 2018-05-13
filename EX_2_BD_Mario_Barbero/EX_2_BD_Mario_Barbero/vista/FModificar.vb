Imports System.Data.SqlClient
Imports System.IO
Public Class FModificar

    Private Sub FModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        'Me.AlumnosTableAdapter.Fill(Me.BDacademiaDataSet.alumnos)

    End Sub

    Public Sub modificar(ByVal miArray As ArrayList)
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        conexion.Open()

        Dim sql As String = "Update alumnos set Nombre=" & "'" & miArray(1) & "'" _
            & ",Apellidos='" & miArray(2) & "',Fecha_nacimiento='" & miArray(3) & "',email='" & miArray(4) & "' where idAlumno='" & miArray(0) & "'"
        consultasql.CommandText = sql
        consultasql.ExecuteNonQuery()

        conexion.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim arrayMod As ArrayList = New ArrayList

        If NombreTextBox.Text = "" Or ApellidosTextBox.Text = "" Or EmailTextBox.Text = "" Then
            MessageBox.Show("DEBES RELLENAR TODOS LOS CAMPOS")
        ElseIf comprobarCorreo(EmailTextBox.Text) Then
            arrayMod.Add(IdAlumnoTextBox.Text)
            arrayMod.Add(NombreTextBox.Text)
            arrayMod.Add(ApellidosTextBox.Text)
            arrayMod.Add(Fecha_nacimientoDateTimePicker.Value)

            arrayMod.Add(EmailTextBox.Text)

            modificar(arrayMod)
            MessageBox.Show("INSERTADO CORRECTAMENTE")
        End If
    End Sub

    Public Function buscarAlumno(ByVal idAlu As String)
        Dim lectorDatos As SqlDataReader
        Dim ArrayAlumno As ArrayList = New ArrayList
        Dim existe As Boolean = True

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from alumnos where idAlumno=" & "'" & idAlu & "'"
        conexion.Open()
        'lectorDatos = consultasql.ExecuteReader
        If Not IsNothing(consultasql.ExecuteScalar) Then 'SI LA SQL NO DEVUELVE NULO
            lectorDatos = consultasql.ExecuteReader
            While lectorDatos.Read
                For i = 0 To lectorDatos.FieldCount - 1
                    ArrayAlumno.Add(lectorDatos.GetValue(i))
                    'MessageBox.Show(ArrayAlumno(i))
                Next
            End While
            rellenarCampos(ArrayAlumno)
            lectorDatos.Close()
        Else
            existe = False
        End If
        conexion.Close()
        Return existe
    End Function

    Public Sub rellenarCampos(ByVal miArray As ArrayList)
        IdAlumnoTextBox.Text = miArray(0)
        NombreTextBox.Text = miArray(1)
        ApellidosTextBox.Text = miArray(2)
        Fecha_nacimientoDateTimePicker.Value = miArray(3)
        If Not IsDBNull(miArray(4)) Then
            EmailTextBox.Text = miArray(4)
        Else
            EmailTextBox.Text = "NO TIENE EMAIL"
        End If
    End Sub

    Private Sub bvtnBuscar_Click(sender As Object, e As EventArgs) Handles bvtnBuscar.Click
        If Not buscarAlumno(txtAlumno.Text) Then
            MessageBox.Show("NO EXISTE")
        End If
    End Sub
End Class