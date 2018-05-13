Public Class FPrincipal

    Private Sub OooToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprobarToolStripMenuItem.Click
        FCorrecion.Show()
    End Sub

    Private Sub FPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comprobarInfo(1)
        '    If Not todoCorrecto Then
        'VisualizarToolStripMenuItem.Enabled = False
        '     EnviarEmailToolStripMenuItem.Enabled = False
        '    GeneralExcelToolStripMenuItem.Enabled = False
        '    Else
        '   VisualizarToolStripMenuItem.Enabled = True
        '   EnviarEmailToolStripMenuItem.Enabled = True
        '   GeneralExcelToolStripMenuItem.Enabled = True
        '    End If
    End Sub

    Private Sub VisualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarToolStripMenuItem.Click
        FVisualizarList.Show()
    End Sub

    Private Sub GeneralExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralExcelToolStripMenuItem.Click
        FExcel.Show()
    End Sub

    Private Sub EnviarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarEmailToolStripMenuItem.Click
        FEmail.Show()
    End Sub
End Class
