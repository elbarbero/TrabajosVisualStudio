Public Class FConsultarClientes

    Public Function anadirClientes()

        Dim cli As New ClaseCliente
        Dim lista As ListViewItem



        For Each cli In ListaClientes
            If Not IsNothing(cli) Then
                'Dim prueba As String = ListaClientes.Count - 1
                For i = 0 To ListaClientes.Count
                    lista = New ListViewItem(cli.nombre)
                    lista.SubItems.Add(cli.apellidos)
                    lista.SubItems.Add(cli.telefono)
                Next

                'Me.lstCliente.Items.Add(cli.nombre &,0)
            End If
        Next
    
    End Function

    Private Sub FConsultarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anadirClientes()
    End Sub
End Class