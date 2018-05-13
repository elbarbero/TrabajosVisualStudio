Imports System.Data.SqlClient
Imports System.IO
Module ModuloAlta

    Public Function existeAlumno(ByVal nombre As String, ByVal apellidos As String)
        Dim existe As Boolean = True
        Dim lectorDatos As SqlDataReader
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from alumnos where Nombre=" & "'" & nombre.Trim & "'" & "and Apellidos= " & "'" & apellidos.Trim & "'"
        conexion.Open()

        lectorDatos = consultasql.ExecuteReader

        While lectorDatos.Read
            datosAlumno(0) = lectorDatos.GetInt32(0)
            datosAlumno(1) = lectorDatos.GetString(1)
            datosAlumno(2) = lectorDatos.GetString(2)
            datosAlumno(3) = lectorDatos.GetSqlDateTime(3)
            If Not IsDBNull(lectorDatos.GetValue(4)) Then
                datosAlumno(4) = lectorDatos.GetString(4)
            End If
        End While

        If datosAlumno(0) = "" Then
            existe = False
            conexion.Close()
            Exit Function
        End If

        conexion.Close()
        Return existe
    End Function

    Public Function conseguirIDCurso(ByVal idAlumno As String)
        Dim lectorDatos As SqlDataReader
        Dim numCursos As Integer = 0
        cursosAlumno = New ArrayList
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select idCurso from alumnoscursos where idAlumno=" & "'" & idAlumno & "'"
        conexion.Open()
        'nombre = consultasql.ExecuteScalar
        lectorDatos = consultasql.ExecuteReader
        While lectorDatos.Read
            cursosAlumno.Add(lectorDatos.GetInt32(0))
        End While
        numCursos = cursosAlumno.Count
        ' If IsNothing(nombre) Then
        'MessageBox.Show("No existe nadie con el " & dniPasajero)
        'Exit Function
        '  End If
        conexion.Close()
        Return numCursos
    End Function

    Public Function obtenerNombreCurso()
        Dim lectorDatos As SqlDataReader
        Dim nombreCursosAlumno As ArrayList=New ArrayList

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text

        conexion.Open()

        For i = 0 To cursosAlumno.Count - 1
            consultasql.CommandText = "Select nombre from cursos where idCurso=" & "'" & cursosAlumno(i) & "'"

            nombreCursosAlumno.Add(consultasql.ExecuteScalar)
        Next
        ' If IsNothing(nombre) Then
        'MessageBox.Show("No existe nadie con el " & dniPasajero)
        'Exit Function
        '  End If
        conexion.Close()
        Return nombreCursosAlumno
    End Function

End Module
