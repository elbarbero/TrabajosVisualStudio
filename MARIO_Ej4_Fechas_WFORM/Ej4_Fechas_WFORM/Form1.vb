Public Class Form1

    Dim periodoDeTiempo As String
    Dim txtFechaConvertido As Date
    Dim txtFechaActualConvertida As Date

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFechaActual.Text = Date.Now.ToString("dd/MM/yyyy")
        txtFechaActualConvertida = Convert.ToDateTime(txtFechaActual.Text)
        cargarCombo()
    End Sub
    Public Sub cargarCombo()
        cmbCantidad.Items.Add("Días")
        cmbCantidad.Items.Add("Meses")
        cmbCantidad.Items.Add("Años")
    End Sub

    '----------------------------------1 FICHA
    Public Function comprobarFormatoFecha()
        Dim formatoBien As Boolean = True
        Dim vector() As String
        Dim listaNumeros() As Char
        If (IsDate(txtFecha.Text)) Then
            vector = txtFecha.Text.Split("/")

            If (vector.Length = 3) Then
                For i = 0 To vector.Length - 1
                    listaNumeros = vector(i).ToCharArray
                    For a = 0 To listaNumeros.Length - 1 'HAGO ESTO PARA QUE ME COMPRUEBE LOS ESPACIOS EN BLANCO PORQUE EN EL AÑO LOS ACEPTA CON ISDATE
                        If (vector(0).Length > 2 Or vector(1).Length > 2 Or Char.IsWhiteSpace(listaNumeros(a))) Then
                            formatoBien = False
                            Exit For
                        End If
                    Next
                Next
            Else

                formatoBien = False
            End If
            If (formatoBien) Then
                txtFechaConvertido = Convert.ToDateTime(txtFecha.Text) 'CONVERTIMOS LA FECHA INTRODUCIDA A FORMATO FECHA
                txtFechaConvertido.ToString("dd/MM/yyyy")
            End If
        Else
            formatoBien = False
        End If

        Return formatoBien
    End Function

    Public Function RecogerFechaCalendario()
        Dim fechaCalendario As Date

        If (CldCalendario.GetHashCode() = 0) Then 'SI NO SELECCIONO NADA...
            fechaCalendario = Date.Now
        Else
            fechaCalendario = CldCalendario.SelectionStart
        End If

        Return fechaCalendario
    End Function

    Public Function RecogerFechaPicker()
        Dim fechaPicker As Date
        If (dtpFecha.GetHashCode() = 0) Then 'SI NO SELECCIONO NADA...
            fechaPicker = Date.Now
        Else
            fechaPicker = dtpFecha.Value
        End If

        Return fechaPicker
    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim dias, meses, annos As Integer
        CalcularDistanciaEntreFechas(RecogerFechaCalendario(), RecogerFechaPicker(), dias, meses, annos)
        txtFechaCalculada.Text = annos & " años, " & meses & " meses y " & dias & " dias"
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        Dim fechaPicker As Date
        Dim fechaCalendario As Date

        If (comprobarFormatoFecha()) Then
            fechaPicker = RecogerFechaPicker()
            fechaCalendario = RecogerFechaCalendario()

            MessageBox.Show("FECHA DATEPICKER_FORMATO 1: " & ChrW(13) & fechaPicker.ToString("dd/MM/yyyy"))
            MessageBox.Show("FECHA DATEPICKER_FORMATO 2: " & ChrW(13) & fechaPicker.ToString("dddd, dd-MMMM/yyyy"))
            MessageBox.Show("FECHA CALENDAR_FORMATO 1: " & ChrW(13) & fechaCalendario.ToString("dd/MM/yyyy"))
            MessageBox.Show("FECHA CALENDAR_FORMATO 2: " & ChrW(13) & fechaCalendario.ToString("dddd, dd-MMMM/yyyy"))
            MessageBox.Show("FECHA INTRODUCIDA_FORMATO 1: " & ChrW(13) & txtFechaConvertido.ToString("dd/MM/yyyy"))
            MessageBox.Show("FECHA INTRODUCIDA_FORMATO 2: " & ChrW(13) & txtFechaConvertido.ToString("dddd, dd-MMMM/yyyy"))
        Else
            MessageBox.Show("Formato de Fecha Incorrecto")
        End If
    End Sub


    '----------------------------------2 FICHA

    Private Sub cmbCantidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCantidad.SelectedIndexChanged
        periodoDeTiempo = cmbCantidad.SelectedItem.ToString
        'MessageBox.Show(periodoDeTiempo)
    End Sub

    Public Sub Calcular()

        Dim listaCaracteres() As Char = txtCantidad.Text.ToCharArray
        Dim formatoValido As Boolean = True

        If (txtCantidad.Text.Equals("")) Then
            formatoValido = False
        Else
            For i = 0 To txtCantidad.Text.Length - 1
                If (Char.IsLetter(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i)) Or Char.IsWhiteSpace(listaCaracteres(i))) Then
                    formatoValido = False
                End If
            Next
        End If

        Try
            If (cmbCantidad.SelectedIndex = -1) Then
                MessageBox.Show("Primero debes seleccionar un intervalo")
            ElseIf (Not formatoValido) Then
                MessageBox.Show("Debe introducir un número con formato correcto")
            Else
                If (rbtSumar.Checked) Then
                    If (periodoDeTiempo.CompareTo("Días") = 0) Then
                        txtNuevaFecha.Text = DateAdd(DateInterval.Day, Convert.ToInt32(txtCantidad.Text), Convert.ToDateTime(txtFechaActual.Text))
                    ElseIf (periodoDeTiempo.CompareTo("Meses") = 0) Then
                        txtNuevaFecha.Text = DateAdd(DateInterval.Month, Convert.ToInt32(txtCantidad.Text), Convert.ToDateTime(txtFechaActual.Text))
                    ElseIf (periodoDeTiempo.CompareTo("Años") = 0) Then
                        txtNuevaFecha.Text = DateAdd(DateInterval.Year, Convert.ToInt32(txtCantidad.Text), Convert.ToDateTime(txtFechaActual.Text))
                    End If
                Else
                    If (periodoDeTiempo.CompareTo("Días") = 0) Then
                        txtNuevaFecha.Text = txtFechaActualConvertida.AddDays(-txtCantidad.Text)
                    ElseIf (periodoDeTiempo.CompareTo("Meses") = 0) Then
                        txtNuevaFecha.Text = txtFechaActualConvertida.AddMonths(-txtCantidad.Text)
                    ElseIf (periodoDeTiempo.CompareTo("Años") = 0) Then
                        txtNuevaFecha.Text = txtFechaActualConvertida.AddYears(-txtCantidad.Text)
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("CRASH")
        End Try
    End Sub

    Private Sub btnCalcular2_Click(sender As Object, e As EventArgs) Handles btnCalcular2.Click
        Calcular()
    End Sub
End Class
