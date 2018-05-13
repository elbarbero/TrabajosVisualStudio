Imports System.ComponentModel

Public Class FAlta

    Dim txtFechaConvertida As Date

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtFechaNac.Text = ""
        txtSexo.Text = ""
        txtNombreTutor.Text = ""
        txtDniTutor.Text = ""
        txtNumHermanos.Text = ""
    End Sub

    Private Sub FAlta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMatricula.Text = generarMatricula()
        If (NAlumnos < 7) Then
            MessageBox.Show("NÚMERO DE ALUMNOS INSUFICIENTE")
        ElseIf (NAlumnos >= 7) Then
            MessageBox.Show("NÚMERO DE PLAZAS LIBRES: " & 15 - NAlumnos)
        End If
        If NAlumnos = 15 Then
            MessageBox.Show("La base de datos está llena", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Dispose()
        End If

    End Sub

    Public Function generarMatricula()

        Randomize(DateTime.Now.Millisecond)
        Dim rnd As New Random(DateTime.Now.Millisecond)
        Dim matric As String
        For i = 0 To 0

            matric = Convert.ToString(rnd.Next(1, 15))

        Next
        Return matric
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If (txtMatricula.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or
           txtFechaNac.Text = "" Or txtSexo.Text = "" Or txtNombreTutor.Text = "" Or
           txtDniTutor.Text = "" Or txtNumHermanos.Text = "") Then
            MessageBox.Show("DEBES RELLENAR TODOS LOS CAMPOS")
        Else
            If (Not comprobarDNI(txtDniTutor)) Then
                MessageBox.Show("DNI INCORRECTO")
            ElseIf (Not comprobarHermanos(txtNumHermanos)) Then
                MessageBox.Show("NUMERO DE HERMANOS INCORRECTO")
            ElseIf (Not comprobarSexo(txtSexo)) Then
                MessageBox.Show("SEXO INCORRECTO")
            Else
                Dim Aalumno As New Alumnos
                With Aalumno
                    .setMatricula(txtMatricula.Text)
                    .setNombre(txtNombre.Text)
                    .setApellido(txtApellido.Text)

                End With



                'alumno = New Alumnos
                'alumno.matriculaA = txtMatricula.Text
                'alumno.nombreA = txtNombre.Text
                'alumno.apellidoA = txtApellido.Text
                'alumno.fechaNacA = txtFechaNac.Text
                'alumno.sexoA = txtSexo.Text
                'alumno.nombreTutorA = txtNombreTutor.Text
                'alumno.dniTutorA = txtDniTutor.Text
                'alumno.NumHermanosA = txtNumHermanos.Text
                'alumno.GrabarProducto(NAlumnos)
                tablaDatos(NAlumnos) = Aalumno
                NAlumnos += 1
                ReDim Preserve tablaDatos(NAlumnos)
                limpiar()
                txtMatricula.Text = generarMatricula()
            End If
        End If
    End Sub

    Private Sub txtFechaNac_LostFocus(sender As Object, e As EventArgs) Handles txtFechaNac.LostFocus
        Dim fechaConv As Date
        Dim fechaActual As Date
        If (Not comprobarFormatoFecha(txtFechaNac, fechaConv)) Then
            MessageBox.Show("FECHA INCORRECTA")
        Else
            fechaActual = Date.Today
            fechaConv = Convert.ToDateTime(txtFechaNac.Text)
            If (fechaConv.Day = fechaActual.Day And fechaConv.Month = fechaActual.Month) Then
                MessageBox.Show("FELICIDADES CHAVAL" & "TIENES " & Math.Abs(DateDiff(DateInterval.Year, fechaConv, Date.Today)) & "AÑOS")
            ElseIf (fechaConv.Month > fechaActual.Month And fechaConv.Day > fechaActual.Day) Then
                MessageBox.Show("YA TIENES " & Math.Abs(DateDiff(DateInterval.Year, fechaConv, fechaActual)) & " AÑOS")
            Else
                MessageBox.Show("TIENES " & Math.Abs(DateDiff(DateInterval.Year, fechaConv, fechaActual)) & " AÑOS")
            End If
        End If
    End Sub

    Private Sub txtDniTutor_Validating(sender As Object, e As CancelEventArgs) Handles txtDniTutor.Validating
        txtLetraDNI.Text = calcularLetraDNI(txtDniTutor)

    End Sub
End Class