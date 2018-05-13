Imports System.IO
Imports System.Net.Mail
Module ModuloEmail

    Public Function enviarCorreo(ByVal correo As String, ByVal mensaje As String)
        Dim message As New MailMessage
        Dim smtp As New SmtpClient
        Dim enviado As Boolean = False
        If comprobarCorreo(correo) Then
            message.From = New MailAddress(correo)
            message.To.Add(correo)
            'message.To.Add("belen.martinez@santamaria-artesano.org")
            message.Body = mensaje
            message.Subject = "MARIO"
            message.Priority = MailPriority.Normal
            smtp.EnableSsl = True
            smtp.Port = "587"
            smtp.Host = "smtp.gmail.com"
            smtp.Credentials = New Net.NetworkCredential("mbarbero.ddi@gmail.com", "multiplataforma")
            'smtp.Credentials = New Net.NetworkCredential("mbarbero.ddi@gmail.com", "multiplataforma")
            smtp.Send(message)
            enviado = True
        End If
        Return enviado
    End Function

    Public Function comprobarCorreo(ByVal correo As String)
        Dim correoCorrrecto As Boolean = False
        Dim vector() As String = correo.Split("@")
        If vector.Length = 1 Or vector.Length > 2 Then 'PARA COMPROBAR SI NO TIENE O TIENE MAS DE UNA ARROBA @
            MessageBox.Show("Contiene más de una arroba")
        End If
        'A PARTIR DE AQUI COMPROBAMOS DESDE LA ARROBA HACIA LA PARTE DERECHA DEL CORREO
        If vector.Length = 2 Then
            'COMPROMABOS LA PARTE DERECHA DEL CORREO
            Dim vector2() As String = vector.ElementAt(1).Split(".") 'COGEMOS LA POSICION 1 DEL ARRAY LLAMADO VECTOR
            If vector2.Length = 1 Or vector2.Length > 2 Then 'PARA COMPROBAR SI TIENE MÁS DE UN PUNTO O NO TIENE PUNTO
                MessageBox.Show("No contiene punto o tiene más de uno")
            ElseIf vector2.Length = 2 Then 'SI SOLO TIENE UN PUNTO
                Dim prueba As String = vector2.ElementAt(1).ToString 'PARA COMPROBAR SI TIENE O NO EXTENSION DESPUES DEL PUNTO
                If prueba.CompareTo("") = 0 Then
                    MessageBox.Show("No contiene una extension de correo valida")
                Else
                    correoCorrrecto = True
                End If
            End If
        End If
        Return correoCorrrecto
    End Function

End Module
