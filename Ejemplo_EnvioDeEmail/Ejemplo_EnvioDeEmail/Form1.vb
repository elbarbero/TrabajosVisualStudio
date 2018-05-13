Imports System.Net.Mail

Public Class Form1
    Dim message As New MailMessage
    Dim smtp As New SmtpClient
    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        'For i = 0 To 100
        message.From = New MailAddress("mbarbero.ddi@gmail.com")
        message.To.Add("pruebaArtesanoDavid@gmail.com")
        message.Body = "EL CUERPO O EL CONTENIDO DEL MENSAJE "
        message.Subject = "Prueba DEL CORREO"
        message.Priority = MailPriority.Normal
        smtp.EnableSsl = True
        smtp.Port = "587"
        smtp.Host = "smtp.gmail.com"
        smtp.Credentials = New Net.NetworkCredential("mbarbero.ddi@gmail.com", "multiplataforma")
        smtp.Send(message)
        'Next
    End Sub
End Class
