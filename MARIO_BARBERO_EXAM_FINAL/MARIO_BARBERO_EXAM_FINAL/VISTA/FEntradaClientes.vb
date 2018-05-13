Public Class FEntradaClientes
    Dim cliente As New ClaseCliente
    Dim MasDeUnaArroba As Boolean = False
    Dim TienePunto As Boolean = False
    Dim TieneExtension As Boolean = False


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
    End Sub

    Public Sub Limpiar()
        txtNombre.Text = ""
        txtApellidos.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtTipo.Text = ""
        txtTipo.Text = ""
        txtFecha.Text = ""
    End Sub


    Public Sub cargarCombo()
        cmbVehiculoC.Items.Add("Citroen")
        cmbVehiculoC.Items.Add("Hyundai")
        cmbVehiculoC.Items.Add("Vespa Eléctrica")
        cmbVehiculoC.Items.Add("Yamaha")
        cmbVehiculoC.Items.Add("Mercedes vito")
        cmbVehiculoC.Items.Add("Nissan")
    End Sub

    Private Sub FEntradaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim fechaConvertida As Date

        If txtTelefono.Text = "" Or txtNombre.Text = "" Or txtApellidos.Text = "" Or
            txtEmail.Text = "" Or txtFecha.Text = "" Or txtTipo.Text = "" Or cmbVehiculoC.SelectedIndex = -1 Then
            MessageBox.Show("DEBES DE RELLENAR TODOS LOS CAMPOS")
        ElseIf Not comprobarFormatoFecha(txtFecha, fechaConvertida) Then
            MessageBox.Show("FORMATO DE FECHA MAL")
        ElseIf Not comprobarTelefono(txtTelefono) Then
            MessageBox.Show("FORMATO DE TELEFONO MAL")
        Else
            'Guardamos los datos en el ArrayList
            'Primero creamos una nueva instancia de cliente
            cliente = New ClaseCliente
            cliente.nombre = txtNombre.Text
            cliente.apellidos = txtApellidos.Text
            cliente.telefono = txtTelefono.Text
            cliente.email = txtEmail.Text
            cliente.vehiculo(0) = cmbVehiculoC.SelectedItem.ToString
            cliente.vehiculo(1) = txtTipo.Text
            cliente.vehiculo(2) = fechaConvertida

            ListaClientes.Add(cliente)
            MessageBox.Show("CLIENTE AÑADIDO CORRECTAMENTE")
            Limpiar()
        End If
    End Sub

    Private Sub cmbVehiculoC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehiculoC.SelectedIndexChanged
        txtTipo.Text = cmbVehiculoC.SelectedIndex
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        MasDeUnaArroba = False
        TienePunto = False
        TieneExtension = False
        Dim vector() As String = txtEmail.Text.Split("@")
        If vector.Length = 1 Or vector.Length > 2 Then 'PARA COMPROBAR SI NO TIENE O TIENE MAS DE UNA ARROBA @
            MasDeUnaArroba = True
        End If
        If vector.Length = 2 Then 'A PARTIR DE AQUI COMPROBAMOS DESDE LA ARROBA HACIA LA PARTE DERECHA DEL CORREO
            'comprobar la parte de derecha del correo
            Dim vector2() As String = vector.ElementAt(1).Split(".")
            If vector2.Length = 1 Or vector2.Length > 2 Then 'PARA COMPROBAR SI TIENE O NO PUNTO
                TienePunto = True
            ElseIf vector2.Length = 2 Then
                Dim prueba As String = vector2.ElementAt(1).ToString 'PARA CCOMPROBAR SI TIENE O NO EXTENSION DESPUES DEL PUNTO
                If prueba.CompareTo("") = 0 Then
                    TieneExtension = True
                End If
            End If
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If Not (txtEmail.Text.IndexOf("@") <> -1) Or txtEmail.Text.CompareTo("") = 0 Then
            'SI NO TIENE LA @
            MessageBox.Show("Formato de correo invalido")
            txtEmail.Focus()
        ElseIf (MasDeUnaArroba = True) Then
            MessageBox.Show("Contiene más de una arroba")
            txtEmail.Focus()
        ElseIf (TienePunto = True) Then
            MessageBox.Show("No contiene punto o tiene más de uno")
            txtEmail.Focus()
        ElseIf (TieneExtension = True) Then
            MessageBox.Show("No contiene la extension del correo valida")
            txtEmail.Focus()
        Else
            Dim listaCaracteres() As Char = txtEmail.Text.ToCharArray
            'Recorrer el array de caracterres desde la primera hasta la última posción que le diga
            Dim mensaje As String = ""
            'desde la primera hasta la última posción antes de la @
            For i = 0 To txtEmail.Text.IndexOf("@") - 1 'Step 5, avanza de 5 en 5 por ejmplo
                Dim bien As Boolean = True
                If Not (Char.IsLetter(listaCaracteres(i)) Or Char.IsDigit(listaCaracteres(i))) Then
                    If Not Char.IsWhiteSpace(listaCaracteres(i)) Then
                        If Not (listaCaracteres(i) = "." Or listaCaracteres(i) = "-" Or listaCaracteres(i) = "_") Then
                            bien = False
                        End If
                    Else
                        bien = False
                    End If
                End If
                If Not bien Then
                    MessageBox.Show("Caracter especial no admitido")
                    txtEmail.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

End Class