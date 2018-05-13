Imports System.Data.SqlClient
Imports System.IO
Public Class FBaja

    Private Sub FBaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.cursos' Puede moverla o quitarla según sea necesario.
        'Me.CursosTableAdapter.Fill(Me.BDacademiaDataSet.cursos)

    End Sub
    Public Sub buscarCurso(ByVal idCurso As Integer)
        Dim lectorDatos As SqlDataReader
        Dim ArrayCurso As ArrayList = New ArrayList

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from cursos where idCurso=" & "'" & idCurso & "'"
        conexion.Open()
        'lectorDatos = consultasql.ExecuteReader
        If Not IsNothing(consultasql.ExecuteScalar) Then 'SI LA SQL NO DEVUELVE NULO
            lectorDatos = consultasql.ExecuteReader
            While lectorDatos.Read
                For i = 0 To lectorDatos.FieldCount - 1
                    ArrayCurso.Add(lectorDatos.GetValue(i))
                    'MessageBox.Show(ArrayCurso(i))
                Next
            End While
            conexion.Close()
            rellenarCampos(ArrayCurso)
            'cargarCursosEnList(ArrayCurso)
            lectorDatos.Close()
        Else
            MessageBox.Show("NO EXISTE")
        End If

    End Sub

    Public Sub rellenarCampos(ByVal miArray As ArrayList)
        IdCursoTextBox.Text = miArray(0)
        NombreTextBox.Text = miArray(1)
        Id_profesorTextBox.Text = miArray(2)
        PrecioCursoTextBox.Text = miArray(3)
        DuracionTextBox.Text = miArray(4)
        FechaInicioCursoDateTimePicker.Text = miArray(5)
        txtNomProfe.Text = buscarProfesor(IdCursoTextBox.Text)


    End Sub

    Public Function buscarProfesor(ByVal idCurso As String)

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select p.nombre from profesores p, cursos c" _
            & " where c.id_profesor = p.idProfesor And c.idCurso=" & "'" & idCurso & "'"
        conexion.Open()
        Dim nombre As String = consultasql.ExecuteScalar
        conexion.Close()
        Return nombre
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtCurso.Text = "" Then
            MessageBox.Show("DEBES RELLENAR EL CAMPO")
        Else
            buscarCurso(txtCurso.Text)
        End If
        lblNumAluPorCurso.Text = "NÚMERO DE ALUMNOS: " & Me.AlumnoscursosTableAdapter1.numeroAlumnos(IdCursoTextBox.Text)
        btnEliminar.Enabled = True
    End Sub

    Public Sub eliminarCurso(ByVal idCurso As String)
        Dim idAlumnos As ArrayList = New ArrayList

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text

        consultasql.CommandText = " Select count(*) As numAlu, ac.IdCurso from alumnoscursos ac " _
        & " where ac.idCurso = " & "'" & idCurso & "'" & "  group by ac.IdCurso" & ""
        conexion.Open()
        Dim numAlu As Integer = consultasql.ExecuteScalar

        consultasql.CommandText = "Select FechaInicioCurso from cursos where idCurso=" & "'" & idCurso & "'"
        Dim fechaInicio As Date = consultasql.ExecuteScalar
        'conexion.Open()
        If numAlu < 7 Or Date.Now < fechaInicio Then
            If numAlu < 7 Then
                'conexion.Close()
                eliminarAluDeCurso(idCurso)
                'conexion.Open()
                consultasql.CommandText = "delete from cursos where idCurso=" & "'" & idCurso & "'"
                consultasql.ExecuteNonQuery()
            Else
                'conexion.Open()
                consultasql.CommandText = "delete from cursos where idCurso=" & "'" & idCurso & "'"
                consultasql.ExecuteNonQuery()
            End If
        Else
            MessageBox.Show("NO SE PUEDE BORRAR EL CURSO")
        End If
        conexion.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarCurso(IdCursoTextBox.Text)
        vaciarCampos()
        MessageBox.Show("EL CURSO HA SIDO BORRADO")
    End Sub

    Public Sub vaciarCampos()
        IdCursoTextBox.Text = ""
        NombreTextBox.Text = ""
        Id_profesorTextBox.Text = ""
        txtNomProfe.Text = ""
        PrecioCursoTextBox.Text = ""
        DuracionTextBox.Text = ""
    End Sub

    Public Function conseguirAlumnosCurso(ByVal idCurso As String)
        Dim idAlumnos As ArrayList = New ArrayList
        Dim lectorDatos As SqlDataReader
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        'conexion.Close()
        consultasql.CommandText = " Select a.idAlumno from alumnos a, alumnoscursos ac, cursos c " _
        & " where a.idAlumno = ac.idAlumno And c.idCurso = ac.IdCurso And ac.IdCurso =  " & "'" & idCurso & "'"
        'conexion.Open()


        If Not IsNothing(consultasql.ExecuteScalar) Then 'SI LA SQL NO DEVUELVE NULO
            lectorDatos = consultasql.ExecuteReader
            While lectorDatos.Read

                idAlumnos.Add(lectorDatos.GetValue(0))
                'MessageBox.Show(ArrayCurso(i)
            End While
            'conexion.Close()
            'cargarCursosEnList(ArrayCurso)
            lectorDatos.Close()
        Else
            MessageBox.Show("NO EXISTE")
        End If

        'conexion.Close()
        Return idAlumnos
    End Function


    Public Sub eliminarAluDeCurso(ByVal idCurso As String)
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        'conexion.Open()

        Dim idAlumnos As ArrayList = New ArrayList
        idAlumnos = conseguirAlumnosCurso(idCurso)

        For i = 0 To idAlumnos.Count - 1
            consultasql.CommandText = "delete from alumnoscursos where idAlumno=" & "'" & idAlumnos(i) & "'"
            consultasql.ExecuteNonQuery()
        Next

        'conexion.Close()
    End Sub

End Class