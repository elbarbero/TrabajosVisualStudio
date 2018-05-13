Public Class Form3

    Private Sub TableFamilias1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableFamilias1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableFamilias1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDEjemplo2018DataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDEjemplo2018DataSet.TableFamilias1' Puede moverla o quitarla según sea necesario.
        Me.TableFamilias1TableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias1)

    End Sub
End Class