Public Class FAlta
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        MkTxtCodigo.Text = ""
        NUpDoFamilia.Value = 1
        TxtDescripcion.Clear()
        MkTxtFechaAlta.Text = Today
        TxtEXActuales.Text = ""
        TxtExMinimas.Text = ""
    End Sub

    Private Sub FAlta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FAlta_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Nuproductos = 500 Then
            MessageBox.Show("La base de datos está llena", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Me.Dispose()
        Else
            MkTxtFechaAlta.Text = Today
        End If
    End Sub

    Private Sub MkTxtCodigo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MkTxtCodigo.Validating

        If MkTxtCodigo.Text <> "" Then
            Text.ToUpper()
            If MkTxtCodigo.Text.Trim.Length <> 7 Then
                MessageBox.Show("El código debe tener 7 caracteres", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MkTxtCodigo.SelectionStart = 0
                MkTxtCodigo.SelectionLength = MkTxtCodigo.Text.Length
                e.Cancel = True
                Exit Sub
            End If
            If buscarCodigo(MkTxtCodigo.Text) <> -1 Then
                MessageBox.Show("El código ya existe en la Base de Datos", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MkTxtCodigo.SelectionStart = 0
                MkTxtCodigo.SelectionLength = MkTxtCodigo.Text.Length
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub MkTxtFechaAlta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MkTxtFechaAlta.Validating
        If MkTxtFechaAlta.Text <> "" Then
            If Not IsDate(MkTxtFechaAlta.Text) Then
                MessageBox.Show("La fecha no es correcta", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MkTxtFechaAlta.SelectionStart = 0
                MkTxtFechaAlta.SelectionLength = MkTxtFechaAlta.Text.Length
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TxtEXActuales_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtEXActuales.Validating
        If TxtEXActuales.Text <> "" Then
            If Not IsNumeric(TxtEXActuales.Text) Then
                MessageBox.Show("La existencias deben ser un número", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtEXActuales.SelectionStart = 0
                TxtEXActuales.SelectionLength = TxtEXActuales.Text.Length
                e.Cancel = True
                Exit Sub
            Else
                Select Case comprobarexistencias(TxtEXActuales.Text, TxtExMinimas.Text)
                    Case 1
                        MessageBox.Show("La existencias no pueden ser negativas", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        TxtEXActuales.SelectionStart = 0
                        TxtEXActuales.SelectionLength = TxtEXActuales.Text.Length
                        e.Cancel = True
                        Exit Sub
                    Case 2
                        MessageBox.Show("La existencias Actuales deben ser superior a las mínimas", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        TxtEXActuales.SelectionStart = 0
                        TxtEXActuales.SelectionLength = TxtEXActuales.Text.Length
                        e.Cancel = True
                        Exit Sub
                End Select
            End If
        End If
    End Sub

    Private Sub TxtExMinimas_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtExMinimas.Validating
        If TxtExMinimas.Text <> "" Then
            If Not IsNumeric(TxtExMinimas.Text) Then
                MessageBox.Show("La existencias deben ser un número", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TxtExMinimas.SelectionStart = 0
                TxtExMinimas.SelectionLength = TxtExMinimas.Text.Length
                e.Cancel = True
                Exit Sub
            Else
                Select Case comprobarexistencias(TxtEXActuales.Text, TxtExMinimas.Text)
                    Case 1
                        MessageBox.Show("La existencias no pueden ser negativas", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        TxtExMinimas.SelectionStart = 0
                        TxtExMinimas.SelectionLength = TxtExMinimas.Text.Length
                        e.Cancel = True
                        Exit Sub
                    Case 2
                        MessageBox.Show("La existencias Actuales deben ser superior a las mínimas", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        TxtExMinimas.SelectionStart = 0
                        TxtExMinimas.SelectionLength = TxtExMinimas.Text.Length
                        e.Cancel = True
                        Exit Sub
                End Select
            End If
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If MkTxtCodigo.Text <> "" And TxtDescripcion.Text <> "" And MkTxtFechaAlta.Text <> "" And TxtEXActuales.Text <> "" And TxtExMinimas.Text <> "" Then
            producto = New CProducto
            producto.CodigoP = MkTxtCodigo.Text
            producto.FamiliaP = NUpDoFamilia.Value.ToString
            producto.DescripcionP = TxtDescripcion.Text
            producto.FechaAltaP = MkTxtFechaAlta.Text
            producto.ExistenciasActualesP = TxtEXActuales.Text
            producto.ExistenciasMinP = TxtExMinimas.Text
            producto.GrabarProducto(Nuproductos)
            Nuproductos += 1
            limpiar()
            MkTxtCodigo.Focus()
            If Nuproductos = 500 Then
                MessageBox.Show("La base de datos está llena", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Me.Dispose()
            End If
        Else
            MessageBox.Show("Debe introducir todos los datos")
        End If
    End Sub

End Class