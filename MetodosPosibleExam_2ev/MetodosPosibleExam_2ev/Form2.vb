Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDatosEnListView()
    End Sub

    Public Sub cargarDatosEnListView()
        'lstComsumosDias.Items.Add(diasSemana(a)).SubItems.Add(ArrayConjunto(a) & " kW/h")
        Dim listView As New ListViewItem

        For a = 0 To DatosSumados.Length - 1
            listView = lstLetras.Items.Add(arrayLetras(a))
            listView.SubItems.Add(DatosSumados(a))
            listView.SubItems.Add(DatosSumados(a))
            ''lstLetras.Items.Add(arrayLetras(a)).SubItems.Add(DatosSumados(a) & " kW/h")

            'lstLetras.Items.Add(arrayLetras(a))
            'lstLetras.Items(a).SubItems.Add(1)
            'lstLetras.Items(a).SubItems.Add(2)

        Next
    End Sub

End Class