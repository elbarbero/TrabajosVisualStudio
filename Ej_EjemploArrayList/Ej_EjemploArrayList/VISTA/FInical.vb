Public Class FInical

    Dim nivel As Integer = 0
    Dim totalmaterial As Decimal
    Dim importetotal As Single = 0
    Dim alumno As New ClaseAlumno

    Private Sub FInical_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FInical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNuAlumno.Text = NumeroAlumno()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click System.EventArgs) Handles btnAceptar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe introducir un nombre", "¡¡ C U I D A D O !!",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNombre.Focus()
            Exit Sub
        End If
        If Not (rdbtnAvanzado.Checked Or rdbtnBasico.Checked Or
       rdbtnMedio.Checked) Then
            MessageBox.Show("Debe seleccionar un nivel", "¡¡ C U I D A D O !!",
           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.rdbtnBasico.Focus()
            Exit Sub
        End If
        'Guardamos los datos en el ArrayList
        'Primero creamos una nueva instancia de alumno
        alumno = New ClaseAlumno
        alumno.numero = lblNuAlumno.Text
        alumno.nombre = txtNombre.Text
        alumno.nivel = Fnivel()
        alumno.material(0) = chkLibro.Checked
        alumno.material(1) = chkDvd.Checked
        alumno.material(2) = chkAcceso.Checked
        ListaAlumnos.Add(alumno)
        Call btnCancelar_Click(sender, e)
    End Sub

    Private Sub rdBtnBasico_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnBasico.CheckedChanged
        If rdbtnBasico.Checked Then
            Me.lblprecio.Text = lblPB.Text
            nivel = 1
            Call calcular(1, chkLibro.Checked, chkDvd.Checked, chkAcceso.Checked,
           totalmaterial, importetotal)
            lblMaterial.Text = totalmaterial.ToString("C")
            txtImporte.Text = importetotal
        End If
    End Sub

    Private Sub rdBtnMedio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnMedio.CheckedChanged
        If rdbtnMedio.Checked Then
            Me.lblprecio.Text = lblPM.Text
            nivel = 2
            calcular(2, chkLibro.Checked, chkDvd.Checked, chkAcceso.Checked,
           totalmaterial, importetotal)
            lblMaterial.Text = totalmaterial.ToString("C")
            txtImporte.Text = importetotal
        End If
    End Sub
    Private Sub rdBtnAvanzado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbtnAvanzado.CheckedChanged
        If rdbtnAvanzado.Checked Then
            Me.lblprecio.Text = lblPA.Text
            nivel = 3
            calcular(3, chkLibro.Checked, chkDvd.Checked, chkAcceso.Checked,
           totalmaterial, importetotal)
            lblMaterial.Text = totalmaterial.ToString("C")
            txtImporte.Text = importetotal
        End If
    End Sub

    Private Sub chkLibro_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLibro.CheckStateChanged
        nivel = Fnivel()
        calcular(nivel, chkLibro.Checked, chkDvd.Checked, chkAcceso.Checked,
       totalmaterial, importetotal)
        lblMaterial.Text = totalmaterial.ToString("C")
        txtImporte.Text = importetotal
    End Sub

    Private Sub chkDVD_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDvd.CheckStateChanged
        nivel = Fnivel()
        calcular(nivel, chkLibro.Checked, chkDVD.Checked, chkAcceso.Checked,
totalmaterial, importetotal)
        lblMaterial.Text = totalmaterial.ToString("C")
        txtImporte.Text = importetotal
    End Sub

    Private Sub chkAcceso_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAcceso.CheckStateChanged
        nivel = Fnivel()
        calcular(nivel, chkLibro.Checked, chkDvd.Checked, chkAcceso.Checked,
       totalmaterial, importetotal)
        lblMaterial.Text = totalmaterial.ToString("C")
        txtImporte.Text = importetotal
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.txtNombre.Clear()
        Me.lblMaterial.Text = ""
        Me.lblprecio.Text = ""
        Me.rdbtnBasico.Checked = False
        Me.rdbtnMedio.Checked = False
        Me.rdbtnAvanzado.Checked = False
        Me.chkAcceso.Checked = False
        Me.chkDvd.Checked = False
        Me.chkLibro.Checked = False
        Me.txtImporte.Clear()
        txtNombre.Focus()
    End Sub

    Private Function Fnivel() As Byte
        nivel = 0
        If rdbtnBasico.Checked Then
            nivel = 1
        ElseIf rdbtnMedio.Checked Then
            nivel = 2
        ElseIf rdbtnAvanzado.Checked Then
            nivel = 3
        End If
        Return nivel
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FSalida.Show()
        'CUIDADO PONER EN PROPIEDADES DEL PROYECTO QUE SE CIERRE LA APLICACIÓN CON EL ÚLTIMO FORMULARIO
        Me.Close()
        Me.Dispose()
    End Sub
End Class
