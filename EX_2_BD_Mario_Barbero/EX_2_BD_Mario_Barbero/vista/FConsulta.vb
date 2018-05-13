Public Class FConsulta
    Private Sub FConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter1.Fill(Me.BDacademiaDataSet.DataTable1)
    End Sub

End Class