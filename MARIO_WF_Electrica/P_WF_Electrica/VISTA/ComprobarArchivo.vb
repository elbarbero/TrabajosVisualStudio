Public Class ComprobarArchivo

    Public formatoArchivoCorrecto As Boolean = False

    Private Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        ProgressBar1.Value = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Maximum = 100
        If ProgressBar1.Value = 95 Then 'le digo que entre en 95 para corregir el retardo al mostrar la informacion en el ritchbox
            ProgressBar1.Value = ProgressBar1.Value + 5
            Label1.Text = CLng((ProgressBar1.Value * 100) / ProgressBar1.Maximum) & " %"
            Timer1.Stop()

            If Not comprobarInfo(rtxtTexto) Then
                ' Timer1.Start()
                mostrarInfoDelFichero(rtxtTexto)
                PanelCorreo.Visible = True
            Else
                rtxtTexto.Text = "TODO CORRECTO"
                formatoArchivoCorrecto = True
                PanelCorreo.Visible = False
            End If

        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            Label1.Text = CLng((ProgressBar1.Value * 100) / ProgressBar1.Maximum) & " %"
        End If
        'Next
    End Sub

    Private Sub btnAceptarPanel_Click(sender As Object, e As EventArgs) Handles btnAceptarPanel.Click
        If enviarCorreo(txtCorreo) Then
            PanelCorreo.Visible = False
        End If
    End Sub

End Class
