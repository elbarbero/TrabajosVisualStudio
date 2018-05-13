Imports System.Data.SqlClient
Imports System.IO
Public Class FAlta
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        reiniciarDatosAlumnos()
        Dim nombreCursosAlumno As ArrayList = New ArrayList
        If txtNombre.Text = "" Or txtApellidos.Text = "" Then
            MessageBox.Show("Debes rellenar todos los campos")
        Else
            If Not existeAlumno(txtNombre.Text, txtApellidos.Text) Then
                'If Me.AlumnosTableAdapter.existeAlumno(txtNombre.Text, txtApellidos.Text) = 0 Then
                MessageBox.Show("No existe  nigún Alumno llamado " & txtNombre.Text & " " & txtApellidos.Text)
                    AlumnoNuevo.Show()
                Else
                    gboxDatosAlumno.Visible = True

                    Me.IdAlumnoTextBox.Text = datosAlumno(0)
                    Me.NombreTextBox.Text = datosAlumno(1)
                    Me.ApellidosTextBox.Text = datosAlumno(2)
                    Me.Fecha_nacimientoDateTimePicker.Text = datosAlumno(3)
                    Me.EmailTextBox.Text = datosAlumno(4)

                    If conseguirIDCurso(datosAlumno(0)) = 0 Then
                        MessageBox.Show("El alumno llamado " & txtNombre.Text & " " & txtApellidos.Text & " no está matriculado en ningún curso")
                    Else
                        nombreCursosAlumno = obtenerNombreCurso()
                        For i = 0 To nombreCursosAlumno.Count - 1
                            lstCursosAlumno.Items.Add(nombreCursosAlumno(i))
                        Next
                    End If
                    lstCursosAlumno.Visible = True
                    lblAlumno.Text = NombreTextBox.Text & " " & ApellidosTextBox.Text 'ETIQUETA DEL PANEL
                    BDacademiaDataSet.EnforceConstraints = False
                    Me.Cursos1TableAdapter.Fill(Me.BDacademiaDataSet.cursos1, IdAlumnoTextBox.Text)

                    PanelCursos.Visible = True
                End If
            End If
    End Sub

    Private Sub FAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        'Me.AlumnosTableAdapter.Fill(Me.BDacademiaDataSet.alumnos)

    End Sub

    Public Sub reiniciarDatosAlumnos()
        Try
            For i = 0 To datosAlumno.Length - 1
                datosAlumno(i) = ""
            Next
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("ERROR")
        End Try
    End Sub

    Private Sub btnInsertarPanel_Click(sender As Object, e As EventArgs) Handles btnInsertarPanel.Click
        insertarAlumnoCurso(IdAlumnoTextBox.Text, cmbCursosAlu.SelectedValue)
        MessageBox.Show("ALUMNO INSERTADO EN CURSO CORRECTAMENTE")
        PanelCursos.Visible = False
    End Sub

    Public Sub insertarAlumnoCurso(ByVal idAlumno As Integer, ByVal idCurso As Integer)
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        conexion.Open()
        Dim sql As String = "insert into alumnoscursos (idAlumno,idCurso)" _
        & "VALUES (" & "'" & idAlumno & "','" & idCurso & "')"
        consultasql.CommandText = sql
        consultasql.ExecuteNonQuery()
        ' Me.TVuelosTableAdapter.Fill(Me.BDAerolineaDataSet.TVuelos)
        conexion.Close()
    End Sub

End Class