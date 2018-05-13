Public Class FPrincipal

    Private Sub VentaDePasajesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDePasajesToolStripMenuItem.Click
        FVenta.Show()
    End Sub

    Private Sub EnviarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarEmailToolStripMenuItem.Click
        FEmail.Show()
    End Sub

    Private Sub CrystalReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrystalReportToolStripMenuItem.Click
        MessageBox.Show("P R O X I M A M E N T E")
    End Sub
End Class
