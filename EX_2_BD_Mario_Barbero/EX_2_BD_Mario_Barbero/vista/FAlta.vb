Imports System.Data.SqlClient
Public Class FAlta

    Dim ArrayAlumno As ArrayList = New ArrayList
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtAlumno.Text = "" Then
            MessageBox.Show("RELLENA EL CAMPO")
        Else
            ' Dim arrayAlumno As ArrayList = buscarAlumno(txtAlumno.Text)
            buscarAlumno(txtAlumno.Text)
            If arrayAlumno.Count = 0 Then
                MessageBox.Show("NO EXISTE ESE ALUMNO")
            Else
                lblAlumno.Text = ArrayAlumno(1) & " " & ArrayAlumno(2)
            End If
        End If
        BDacademiaDataSet.EnforceConstraints = False
        Me.Cursos1TableAdapter.Fill(Me.BDacademiaDataSet.cursos1, txtAlumno.Text)
        btnInsertar.Enabled = True
    End Sub

    Public Sub buscarAlumno(ByRef idAlu As String)
        Dim lectorDatos As SqlDataReader
        'Dim ArrayAlumno As ArrayList = New ArrayList

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from alumnos where idAlumno=" & "'" & idAlu & "'"
        conexion.Open()

        lectorDatos = consultasql.ExecuteReader
        While lectorDatos.Read
            ArrayAlumno.Add(lectorDatos.GetValue(0))
            ArrayAlumno.Add(lectorDatos.GetValue(1))
            ArrayAlumno.Add(lectorDatos.GetValue(2))
            ArrayAlumno.Add(lectorDatos.GetValue(3))
            If Not IsDBNull(lectorDatos.GetValue(4)) Then
                ArrayAlumno.Add(lectorDatos.GetValue(4))
            End If
        End While
        conexion.Close()
        ' Return ArrayAlumno
    End Sub

    Public Function obtenerFechaInicioCurso(ByVal idCurso As String)
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        conexion.Open()
        consultasql.CommandText = "Select FechaInicioCurso from cursos where idCurso=" & "'" & idCurso & "'"
        Dim fechaInicio As Date = consultasql.ExecuteScalar

        conexion.Close()
        Return fechaInicio
    End Function

    Public Sub insertarAlumnoEnCurso(ByVal idAlu As String, ByVal idCurso As String)
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        conexion.Open()
        Dim sql As String = "insert into alumnoscursos (idAlumno,idCurso)" _
        & "VALUES (" & "'" & idAlu & "','" & idCurso & "')"
        consultasql.CommandText = sql
        consultasql.ExecuteNonQuery()
        ' Me.TVuelosTableAdapter.Fill(Me.BDAerolineaDataSet.TVuelos)
        conexion.Close()
    End Sub

    Public Function comprobarCurso(ByVal idAlumno As String, ByVal idCurso As String)
        Dim existe As Boolean = False
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        conexion.Open()
        consultasql.CommandText = "Select count(*) from alumnoscursos where " _
& "idCurso=" & "'" & idCurso & "'" & "and idAlumno=" & "'" & idAlumno & "'"
        If consultasql.ExecuteScalar() > 0 Then
            existe = True
        End If

        conexion.Close()
        Return existe
    End Function

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim mensaje As String = ""
        Dim fechaInicio As Date = obtenerFechaInicioCurso(cmbCursos.SelectedValue)
        If Me.AlumnoscursosTableAdapter1.numeroAlumnos(cmbCursos.SelectedValue) >= 20 Then
            MessageBox.Show("CURSO LLENO")
            mensaje = "CURSO LLENO"
        ElseIf Date.Now > fechaInicio Then
            MessageBox.Show("EL CURSO YA HA EMPEZADO")
            mensaje = "EL CURSO YA HA EMPEZADO"
        Else
            If comprobarCurso(ArrayAlumno(0), cmbCursos.SelectedValue) Then
                MessageBox.Show("YA ESTAS MATRICULADO EN ESE CURSO")
            Else
                insertarAlumnoEnCurso(ArrayAlumno(0), cmbCursos.SelectedValue)
                MessageBox.Show("INSERTADO CORRECTAMENTE")
                mensaje = cmbCursos.Text & ", " & fechaInicio.Date
            End If
        End If
            If ArrayAlumno.Count < 5 Then
            MessageBox.Show("ESTE ALUMNO NO TIENE EMAIL")
        Else
            enviarCorreo(ArrayAlumno(4), mensaje)
        End If
    End Sub

    Private Sub FAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CursosTableAdapter1.Fill(Me.BDacademiaDataSet.cursos)
    End Sub
End Class