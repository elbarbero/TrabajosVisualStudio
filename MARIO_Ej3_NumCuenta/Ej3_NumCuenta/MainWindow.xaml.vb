
Imports System
Imports System.Collections
Imports Microsoft.VisualBasic
Imports MARIO_Ej3_NumCuenta
Imports MARIO_Ej3_NumCuenta.Banco

Class MainWindow
    Public MainWindow

    Dim list As ListView
    Dim miBanco As New List(Of Banco) 'ArrayList de tipo Banco

    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        agregarBancos()
    End Sub

    Public Sub agregarBancos()

        lstBank.Items.Add(New Banco With {.nombre = "Bankia", .codigo = "2038"})
        lstBank.Items.Add(New Banco With {.nombre = "Banco de Sabadell", .codigo = "0081"})
        lstBank.Items.Add(New Banco With {.nombre = "Banco Santander", .codigo = "0049"})
        lstBank.Items.Add(New Banco With {.nombre = "CaixaBank", .codigo = "2100"})
        lstBank.Items.Add(New Banco With {.nombre = "KutxaBank", .codigo = "2095"})
        lstBank.Items.Add(New Banco With {.nombre = "Ibercaja Banco", .codigo = "2085"})
        lstBank.Items.Add(New Banco With {.nombre = "Banco Popular", .codigo = "0075"})
        lstBank.Items.Add(New Banco With {.nombre = "Banco de Portugal", .codigo = "1913"})
        lstBank.Items.Add(New Banco With {.nombre = "Banco Pastor", .codigo = "0238"})
        lstBank.Items.Add(New Banco With {.nombre = "Bankinter", .codigo = "0128"})

    End Sub

    Private Sub lstBank_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lstBank.SelectionChanged
        Dim elemento As Banco
        elemento = Me.lstBank.SelectedItem
        txtEntidad.Text = elemento.codigo
    End Sub

    Public Function comprobarSoloNumerosCuenta() 'COMPRUEBO QUE LA CUENTA SOLO CONTENGA NUMEROS
        Dim listaCaracteres() As Char = txtOficina.Text.ToCharArray & txtDC.Text.ToCharArray & txtNumCuenta.Text.ToCharArray ' meto todos los textbox en una sola variable char
        Dim cuentaCompleta As String = txtOficina.Text & txtDC.Text & txtNumCuenta.Text ' meto todos los textbox en una sola variable, menos la entidad porque esa no la puede manipular el usuario
        Dim formatoValido As Boolean = True

        For i = 0 To cuentaCompleta.Length - 1
            If (Char.IsLetter(listaCaracteres(i)) Or Char.IsSymbol(listaCaracteres(i)) Or Char.IsPunctuation(listaCaracteres(i)) Or Char.IsWhiteSpace(listaCaracteres(i))) Then
                formatoValido = False
            End If

        Next
        If (Not formatoValido) Then
            MessageBox.Show("LA CUENTA SOLO DEBE CONTENER NÚMEROS ENTEROS")
        End If

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

    Private Sub btnValidar_Click(sender As Object, e As RoutedEventArgs) Handles btnValidar.Click
        Dim cuentaCompleta As String = txtEntidad.Text & txtOficina.Text & txtDC.Text & txtNumCuenta.Text
        If (comprobarSoloNumerosCuenta() And comprobarTotalNumCuenta(cuentaCompleta)) Then
            Dim digitosControl As String = ComprobarDC(txtEntidad.Text, txtOficina.Text, txtDC.Text, txtNumCuenta.Text)
            If (digitosControl.CompareTo(txtDC.Text)) = 0 Then
                calcularIBAN()
                MessageBox.Show("ES" & calcularIBAN() & " " & txtEntidad.Text & " " & txtOficina.Text & " " & txtDC.Text & " " & txtNumCuenta.Text)
            Else
                MessageBox.Show("El Digito de control no corresponde a esa cuenta")
            End If
        Else
            MessageBox.Show("Número de cuenta incompleta")
        End If

    End Sub

End Class




