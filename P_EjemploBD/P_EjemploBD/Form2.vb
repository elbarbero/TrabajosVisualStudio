Imports System.Data.SqlClient

Public Class Form2

    'Dim cadenaConexion As String = "Data Source = 205P14; Initial Catalog = BDEjemplo2018; Integrated Security = True"
    Dim cadenaConexion As String = My.MySettings.Default.BDEjemplo2018ConnectionString
    Dim codigo As Integer
    Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
    'Dim consultasql As SqlCommand = New SqlCommand("Select * From TableFamilias", conexion)
    Dim consultasql As SqlCommand = New SqlCommand()

    Private Sub TableFamilias1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableFamilias1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDEjemplo2018DataSet) 'ACTUALIZA TODO EL CONTENIDO
        'Y LO PASA A LA BBDD
    End Sub


    Private Sub TableFamilias1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TableFamilias1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableFamilias1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDEjemplo2018DataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDEjemplo2018DataSet.TableProveedor' Puede moverla o quitarla según sea necesario.
        Me.TableProveedorTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableProveedor)
        'TODO: esta línea de código carga datos en la tabla 'BDEjemplo2018DataSet.TableFamilias1' Puede moverla o quitarla según sea necesario.
        Me.TableFamilias1TableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias1)
        'SE ENCARGA DE COGER LA INFO EN LA BBDD Y LA LLEVA A MEMORIA
    End Sub

    Private Sub Id_FamiliaTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Id_FamiliaTextBox.Validating
        'COMPROBAMOS SI EXISTE EL ID
        If Id_FamiliaTextBox.Text <> "" Then
            consultasql.Connection = conexion
            consultasql.CommandType = CommandType.Text
            consultasql.CommandText = "Select id_Familia from TableFamilias where id_Familia= " & Id_FamiliaTextBox.Text & ""

            conexion.Open()
            Dim id As Integer = consultasql.ExecuteScalar()
            'conexion.Close()
            If id <> 0 Then
                MessageBox.Show("YA EXISTE")
            End If

            conexion.Close()
        End If
    End Sub
End Class