Imports System.Data.SqlClient

Public Class Form1

    Dim cadenaConexion As String = "Data Source = 205P14; Initial Catalog = BDEjemplo2018; Integrated Security = True"
    Dim codigo As Integer
    Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
    'Dim consultasql As SqlCommand = New SqlCommand("Select * From TableFamilias", conexion)
    Dim consultasql As SqlCommand = New SqlCommand()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDEjemplo2018DataSet.TableFamilias' Puede moverla o quitarla según sea necesario.
        Me.TableFamiliasTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias)
        'Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
        'Dim consultasql As SqlCommand = New SqlCommand("Select * From TableFamilias", conexion)
        consultasql.Connection = conexion
        consultasql.CommandText = "Select id_Familia from TableFamilias" 'PARA EJECUTAR UNA SENTENCIA
        consultasql.CommandType = CommandType.Text
        conexion.Open()
        codigo = consultasql.ExecuteScalar()
        conexion.Close()
        MessageBox.Show(codigo)
    End Sub

    Private Sub btnNuevaFamilia_Click(sender As Object, e As EventArgs) Handles btnNuevaFamilia.Click
        'GRABAR UNA NUEVA FAMILIA
        'LA CLAVE SE GENERA DE FORMA AUTOMATICA

        'LEER EL MAYOR IDFAMILIA
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select max(id_Familia) from TableFamilias"

        'EJECUTAR LA CONSULTA
        conexion.Open()
        codigo = consultasql.ExecuteScalar + 1
        'Dim sql As String = "insert into TableFamilias VALUES (" & codigo & ",'Familia" & codigo & "',1,2)"
        Dim sql As String = "insert into TableFamilias (id_Familia,Descripcion,id_Proveedor) VALUES (" & codigo & ",'Familia" & codigo & "',1)"

        consultasql.CommandText = Sql
        consultasql.ExecuteNonQuery()
        conexion.Close()

    End Sub

    Private Sub btnLeerfilas_Click(sender As Object, e As EventArgs) Handles btnLeerfilas.Click
        Dim lectorDatos As SqlDataReader
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select * from TableProveedor"
        conexion.Open()
        lectorDatos = consultasql.ExecuteReader
        lstProveedor.Items.Clear() 'PARA VACIAR EL LIST BOX

        While lectorDatos.Read
            Label1.Text = lectorDatos.GetInt32(0)
            Label2.Text = lectorDatos.GetString(1)

            lstProveedor.Items.Add(lectorDatos.GetInt32(0) & "- " & lectorDatos.GetString(1))

        End While
        lectorDatos.Close()
        conexion.Close()

    End Sub

    Private Sub lstFamilias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFamilias.SelectedIndexChanged
        Label3.Text = lstFamilias.SelectedValue 'mostramos en la label lo que seleccionamos en el list box

    End Sub
End Class
