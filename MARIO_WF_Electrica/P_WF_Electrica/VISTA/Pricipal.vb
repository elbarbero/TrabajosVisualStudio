Public Class Pricipal

    Private Sub ComprobarArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobarArchivoToolStripMenuItem.Click
        ComprobarArchivo.ShowDialog()
        If ComprobarArchivo.formatoArchivoCorrecto Then
            PreciosToolStripMenuItem.Enabled = True
            ConsumoDíaToolStripMenuItem.Enabled = True
            PotenciaMediaToolStripMenuItem.Enabled = True
            GananciaSemanalToolStripMenuItem.Enabled = True
            GestiónContratosToolStripMenuItem.Enabled = True
            EstadisticasToolStripMenuItem.Enabled = True
        Else
            PreciosToolStripMenuItem.Enabled = False
            ConsumoDíaToolStripMenuItem.Enabled = False
            PotenciaMediaToolStripMenuItem.Enabled = False
            GananciaSemanalToolStripMenuItem.Enabled = False
            GestiónContratosToolStripMenuItem.Enabled = False
            EstadisticasToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub GestiónContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónContratosToolStripMenuItem.Click
        Contratos.ShowDialog()
    End Sub

    Private Sub ConsumoDíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsumoDíaToolStripMenuItem.Click
        ConsultarConsumoDia.ShowDialog()
    End Sub

    Private Sub PotenciaMediaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PotenciaMediaToolStripMenuItem.Click
        PotenciaMedia.ShowDialog()
    End Sub

    Private Sub GananciaSemanalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GananciaSemanalToolStripMenuItem.Click
        GanaciaSemanal.Show()
    End Sub

    Private Sub EstadisticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasToolStripMenuItem.Click
        Estadisticas.Show()
    End Sub
End Class