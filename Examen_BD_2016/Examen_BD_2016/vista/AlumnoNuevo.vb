Public Class AlumnoNuevo
    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDacademiaDataSet)

    End Sub

    Private Sub AlumnoNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        'Me.AlumnosTableAdapter.Fill(Me.BDacademiaDataSet.alumnos)
        sacarelMaxIDDeAlu()

    End Sub

    Public Sub insertarNuevoAlumno(ByVal miArray As ArrayList)
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        conexion.Open()
        Dim sql As String = "insert into alumnos (idAlumno,Nombre,Apellidos,Fecha_nacimiento,email)" _
        & "VALUES (" & "'" & miArray(0) & "','" & miArray(1) & "','" & miArray(2) & "','" & miArray(3) & "','" & miArray(4) & "')"
        consultasql.CommandText = sql
        consultasql.ExecuteNonQuery()
        ' Me.TVuelosTableAdapter.Fill(Me.BDAerolineaDataSet.TVuelos)
        conexion.Close()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim CursoNuevo As ArrayList = New ArrayList
        CursoNuevo.Add(IdAlumnoTextBox.Text)
        CursoNuevo.Add(NombreTextBox.Text)
        CursoNuevo.Add(ApellidosTextBox.Text)
        CursoNuevo.Add(Fecha_nacimientoDateTimePicker.Value)
        CursoNuevo.Add(EmailTextBox.Text)

        If calcularEdad(Fecha_nacimientoDateTimePicker.Value) < 16 Then
            'If Me.AlumnosTableAdapter.edadAlumno(cmbCursos.SelectedValue) < 16 Then
            MessageBox.Show("DEBES TENER MÁS DE 16 AÑOS")
        Else
            insertarNuevoAlumno(CursoNuevo)
            MessageBox.Show("ALUMNO INSERTADO CORRECTAMENTE")
        End If
        Me.Close()
    End Sub

    Public Sub sacarelMaxIDDeAlu()
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        'consultasql.CommandText = "Select count(*) from cursos"
        consultasql.CommandText = "Select max(idAlumno) from alumnos"

        conexion.Open()

        IdAlumnoTextBox.Text = consultasql.ExecuteScalar() + 1
        conexion.Close()
    End Sub

End Class