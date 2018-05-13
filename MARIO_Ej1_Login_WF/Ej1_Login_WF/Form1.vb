Public Class Form1
    Dim MasDeUnaArroba As Boolean = False
    Dim TienePunto As Boolean = False
    Dim TieneExtension As Boolean = False

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim user As String = "mariob_89@gmail.com"
        Dim contrasena As String = "123_Mbs"
        Dim bien As Boolean
        bien = comprobarPass(txtPass.Text, bien)
        If Not bien Then
            MessageBox.Show("Debe tener, al menos 1 letra mayúscula, 1 número y 1 carácter especial que no sea espacio en blanco")
        Else
            If txtUsuario.Text.CompareTo(user) = 0 And txtPass.Text.CompareTo(contrasena) = 0 Then
                MessageBox.Show("Usuario y contraseña correctos")
            Else
                MessageBox.Show("Usuario y contraseña incorrectos")
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub txtUsuario_LostFocus(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        If btnCancelar.Focused.GetHashCode <> 1 Then 'SI NO PULSO EL BOTON DE CANCELAR
            If Not (txtUsuario.Text.IndexOf("@") <> -1) Or txtUsuario.Text.CompareTo("") = 0 Then
                'SI NO TIENE LA @
                MessageBox.Show("Formato de correo invalido")
                txtUsuario.Focus()
            ElseIf (MasDeUnaArroba = True) Then
                MessageBox.Show("Contiene más de una arroba")
                txtUsuario.Focus()
            ElseIf (TienePunto = True) Then
                MessageBox.Show("No contiene punto o tiene más de uno")
                txtUsuario.Focus()
            ElseIf (TieneExtension = True) Then
                MessageBox.Show("No contiene la extension del correo valida")
                txtUsuario.Focus()
            Else
                Dim listaCaracteres() As Char = txtUsuario.Text.ToCharArray
                'Recorrer el array de caracterres desde la primera hasta la última posción que le diga
                Dim mensaje As String = ""
                'desde la primera hasta la última posción antes de la @
                For i = 0 To txtUsuario.Text.IndexOf("@") - 1 'Step 5, avanza de 5 en 5 por ejmplo
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
                        txtUsuario.Focus()
                        Exit Sub
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        MasDeUnaArroba = False
        TienePunto = False
        TieneExtension = False
        Dim vector() As String = txtUsuario.Text.Split("@")
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

    Public Function comprobarPass(contraseña As String, bien As Boolean)
        If (contraseña.Length < 6) Then
            MessageBox.Show("La contraseña debe tener entre 6 y 12 caracteres")
        Else
            bien = False
            Dim listaCaracteres() As Char = txtPass.Text.ToCharArray
            'Recorrer el array de caracterres desde la primera hasta la última posción que le diga
            Dim espacioBlanco As Boolean = False
            Dim caracterEspecial As Boolean = False
            Dim mayuscula As Boolean = False
            Dim minuscula As Boolean = False
            Dim numero As Boolean = False
            'desde la primera hasta la última posción antes de la @

            For i = 0 To txtPass.Text.Length - 1
                If Char.IsWhiteSpace(listaCaracteres(i)) Then
                    espacioBlanco = True
                    Exit For
                ElseIf Not Char.IsLetter(listaCaracteres(i)) Or Not Char.IsDigit(listaCaracteres(i)) And Char.IsUpper(listaCaracteres(i)) And Not Char.IsWhiteSpace(listaCaracteres(i)) Then
                    If Char.IsPunctuation(listaCaracteres(i)) Then
                        If Not Char.IsWhiteSpace(listaCaracteres(i)) Then
                            caracterEspecial = True
                            espacioBlanco = False
                        End If
                    ElseIf Char.IsUpper(listaCaracteres(i)) Then
                        mayuscula = True
                    ElseIf Char.IsDigit(listaCaracteres(i)) Then
                        numero = True
                    End If
                ElseIf Char.IsLetter(listaCaracteres(i)) Then
                    minuscula = True
                End If
            Next

            If Not espacioBlanco And mayuscula And numero And caracterEspecial Then
                bien = True
            Else
                bien = False
            End If
        End If
        Return bien
    End Function

End Class
