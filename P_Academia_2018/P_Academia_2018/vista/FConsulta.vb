Public Class FConsulta

    Private Sub FConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.BDacademiaDataSet.DataTable1)
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.BDacademiaDataSet.DataTable1)

    End Sub
End Class