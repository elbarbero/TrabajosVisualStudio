Public Class VInsertar1
    Private Sub VInsertar1_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        For i = 0 To ArrayProgramas.Length - 1
            Me.lstProgramas.Items.Add(ArrayProgramas.ElementAt(i))
        Next
    End Sub

    Private Sub btnTraspasar_Click(sender As Object, e As RoutedEventArgs) Handles btnTraspasar.Click

        For i = 0 To lstProgramas.SelectedItems.Count - 1
            lstEscogidos.Items.Add(lstProgramas.SelectedItems(i))
            codPrograma = lstProgramas.SelectedItems.Count
            lstProgramas.Items.Remove(lstProgramas.SelectedItems(i))

        Next
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As RoutedEventArgs) Handles btnAceptar.Click

        Dim col As New Colaborador
        With col
            .setNombre(txtNomCol.Text)
            .setPrecio(txtPrecio.Text)
            .setMinutos(txtMinutos.Text)
            .setCodClaborador(codColaborador)
            .setCodPrograma(codPrograma)

        End With
        tablaColaboradores(codColaborador) = col
        codColaborador += 1
        'ReDim Preserve tablaColaboradores(col)

        Dim prueba As String = col.getNombre()

    End Sub
End Class
