Imports MARIO_Ej3_NumCuenta
Imports MARIO_Ej3_NumCuenta.Banco

Public Class Form1
    Dim list As ListView
    Dim miBanco As New List(Of Banco) 'ArrayList de tipo Banco

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        agregarBancos()
    End Sub


    Public Sub agregarBancos()

        ' lstBank.Items.Add(New Banco {"Bankia", "2038"})
        'lstBank.Items.Add(New Banco With {.nombre = "Banco de Sabadell", .codigo = "0081"})
        'lstBank.Items.Add(New Banco With {.nombre = "Banco Santander", .codigo = "0049"})
        'lstBank.Items.Add(New Banco With {.nombre = "CaixaBank", .codigo = "2100"})
        'lstBank.Items.Add(New Banco With {.nombre = "KutxaBank", .codigo = "2095"})
        ' lstBank.Items.Add(New Banco With {.nombre = "Ibercaja Banco", .codigo = "2085"})
        ' lstBank.Items.Add(New Banco With {.nombre = "Banco Popular", .codigo = "0075"})
        ' lstBank.Items.Add(New Banco With {.nombre = "Banco de Portugal", .codigo = "1913"})
        ' lstBank.Items.Add(New Banco With {.nombre = "Banco Pastor", .codigo = "0238"})
        ' lstBank.Items.Add(New Banco With {.nombre = "Bankinter", .codigo = "0128"})


        lstBank.Items.Add("Bankia").SubItems.Add("2038")
        lstBank.Items.Add("Banco de Sabadell").SubItems.Add("0081")
        lstBank.Items.Add("Banco Santander").SubItems.Add("0049")
        lstBank.Items.Add("CaixaBank").SubItems.Add("2100")
        lstBank.Items.Add("KutxaBank").SubItems.Add("2095")
        lstBank.Items.Add("Ibercaja Banco").SubItems.Add("2085")
        lstBank.Items.Add("Banco Popular").SubItems.Add("0075")
        lstBank.Items.Add("Banco de Portugal").SubItems.Add("1913")
        lstBank.Items.Add("Banco Pastor").SubItems.Add("0238")
        lstBank.Items.Add("Bankinter").SubItems.Add("0128")

    End Sub

    Private Sub lstBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBank.SelectedIndexChanged
        Dim indice As Integer
        indice = lstBank.FocusedItem.Index
        txtEntidad.Text = lstBank.Items(indice).SubItems(1).Text
    End Sub

    Public Function comprobarCuenta() 'COMPRUEBO QUE LA CUENTA SOLO CONTENGA NUMEROS
        Dim listaCaracteres() As Char = txtOficina.Text.ToCharArray & txtDC.Text.ToCharArray & txtNumCuenta.Text.ToCharArray ' meto todos los textbox en una sola variable char
        Dim cuentaCompleta As String = txtOficina.Text & txtDC.Text & txtNumCuenta.Text ' meto todos los textbox en una sola variable, menos la entidad porque esa no la puede manipular el usuario
        Dim formatoValido As Boolean = True

        For i = 0 To cuentaCompleta.Length - 1
            If (Char.IsLetter(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i)) Or Char.IsWhiteSpace(listaCaracteres(i))) Then
                formatoValido = False
            End If
        Next

        Return formatoValido
    End Function

    Public Function calcularIBAN() 'CALCULO EL IBAN
        Dim iban As Decimal
        iban = Convert.ToDecimal(txtEntidad.Text & txtOficina.Text & txtDC.Text & txtNumCuenta.Text & 142800)
        iban = iban Mod 97
        iban = 98 - iban
        If (iban < 10) Then
            Return Convert.ToString("0" & iban)
        Else
            Return iban
        End If

    End Function

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If (comprobarCuenta()) Then
            Dim digitosControl As String = ComprobarDC(txtEntidad.Text, txtOficina.Text, txtDC.Text, txtNumCuenta.Text)
            If (digitosControl.CompareTo(txtDC.Text)) = 0 Then
                calcularIBAN()
                MessageBox.Show("ES" & calcularIBAN() & " " & txtEntidad.Text & " " & txtOficina.Text & " " & txtDC.Text & " " & txtNumCuenta.Text)
            Else
                MessageBox.Show("El Digito de control no corresponde a esa cuenta")
            End If
        Else
            MessageBox.Show("LA CUENTA SOLO DEBE CONTENER NÚMEROS ENTEROS")
        End If
    End Sub
End Class
