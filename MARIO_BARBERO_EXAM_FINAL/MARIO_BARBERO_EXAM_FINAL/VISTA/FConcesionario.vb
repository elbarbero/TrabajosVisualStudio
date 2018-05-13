Public Class FConcesionario
    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        FMostrarVehiculos.ShowDialog()
    End Sub

    Private Sub btnClienteN_Click(sender As Object, e As EventArgs) Handles btnClienteN.Click
        FEntradaClientes.ShowDialog()
    End Sub

    Private Sub btnConsultarCliente_Click(sender As Object, e As EventArgs) Handles btnConsultarCliente.Click
        FConsultarClientes.ShowDialog()
    End Sub

    Private Sub btnConsultarVentas_Click(sender As Object, e As EventArgs) Handles btnConsultarVentas.Click
        FConsultarVentas.ShowDialog()
    End Sub
End Class
