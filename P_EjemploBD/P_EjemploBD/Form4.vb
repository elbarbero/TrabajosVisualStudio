Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDEjemplo2018DataSet.TableFamilias1' Puede moverla o quitarla según sea necesario.
        Me.TableFamilias1TableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias1)

    End Sub
End Class