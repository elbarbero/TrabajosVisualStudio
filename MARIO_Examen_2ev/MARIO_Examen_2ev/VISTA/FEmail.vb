Public Class FEmail

    Dim notaEnLetra As String
    Dim notaEnNumero As Double

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If enviarCorreo(txtEmail.Text, "multiplataforma", notaEnNumero, notaEnLetra, Modulos(examenAlumno(0))) Then
            MessageBox.Show("MENSAJE ENVIADO")
        End If
    End Sub
End Class