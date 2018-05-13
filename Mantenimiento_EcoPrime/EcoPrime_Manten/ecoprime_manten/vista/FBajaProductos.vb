Imports System.Data.SqlClient
Imports System.IO
Public Class FBajaProductos
    Private Sub FBajaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        Me.BebidasTableAdapter.Fill(Me.EcoPrimeDataSet.Bebidas)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Alimentos' Puede moverla o quitarla según sea necesario.
        Me.AlimentosTableAdapter.Fill(Me.EcoPrimeDataSet.Alimentos)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Menaje' Puede moverla o quitarla según sea necesario.
        Me.MenajeTableAdapter.Fill(Me.EcoPrimeDataSet.Menaje)
        cmbMenaje.SelectedIndex = -1
        cmbAlimento.SelectedIndex = -1
        cmbBebidas.SelectedIndex = -1
    End Sub


    '--------------------------------------TABLA MENAJE--------------------------------
    Private Sub cmbMenaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMenaje.SelectedIndexChanged
        Dim idMenaje As Integer = Convert.ToInt16(cmbMenaje.SelectedValue)

        If idMenaje >= 0 Then
            Dim sql As String = "SELECT * FROM Menaje where idMenaje='" & idMenaje & "'"
            consultasql.CommandType = CommandType.Text
            consultasql.Connection = conexion
            consultasql.CommandText = sql
            conexion.Open()
            Dim reader As SqlDataReader = consultasql.ExecuteReader()

            If (reader.Read()) Then
                txtIdMen.Text = reader(0)
                txtNomMen.Text = reader(1)
                txtCosteMen.Text = reader(2)
                txtIvaMen.Text = reader(3)
                txtStockMen.Text = reader(4)
                If reader(6) <> Nothing Or reader(6) <> "" Then
                    imagenMenaje.Image = Image.FromFile(reader(6))
                    imagenMenaje.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    imagenMenaje.Image = Image.FromFile(rutaImgEcoPrime)
                imagenMenaje.BackgroundImageLayout = ImageLayout.Stretch

            End If
            txtDescripMen.Text = reader(5)
                txtPrecioMayMen.Text = reader(7)
                txtPrecioMinMen.Text = reader(8)
                txtProveedorMen.Text = Me.ProveedoresTableAdapter1.ConsultarProveedor(reader(9))

            End If
            reader.Close()
            conexion.Close()
        End If
    End Sub

    Private Sub btnEliminarMen_Click(sender As Object, e As EventArgs) Handles btnEliminarMen.Click
        If txtIdMen.Text = "" Then
            MessageBox.Show("Selecciona un Menaje")
        Else
            Me.MenajeTableAdapter.EliminarMenaje(txtIdMen.Text)
            MessageBox.Show("MENAJE ELIMINADO")
            Me.MenajeTableAdapter.Fill(Me.EcoPrimeDataSet.Menaje)
            vaciarCamposMenaje()
        End If
    End Sub

    Public Sub vaciarCamposMenaje()
        txtIdMen.Text = ""
        txtNomMen.Text = ""
        txtCosteMen.Text = ""
        txtIvaMen.Text = ""
        txtStockMen.Text = ""
        txtDescripMen.Text = ""
        imagenMenaje.Image = Image.FromFile(rutaImgEcoPrime)
        imagenMenaje.BackgroundImageLayout = ImageLayout.Stretch
        txtPrecioMayMen.Text = ""
        txtPrecioMinMen.Text = ""
        txtProveedorMen.Text = ""
    End Sub


    '--------------------------------------TABLA ALIMENTO--------------------------------
    Private Sub cmbAlimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlimento.SelectedIndexChanged
        Dim idAlimento As Integer = Convert.ToInt16(cmbAlimento.SelectedValue)

        If idAlimento >= 0 Then
            Dim sql As String = "SELECT * FROM alimentos where idAlimento='" & idAlimento & "'"
            consultasql.CommandType = CommandType.Text
            consultasql.Connection = conexion
            consultasql.CommandText = sql
            conexion.Open()
            Dim reader As SqlDataReader = consultasql.ExecuteReader()

            If (reader.Read()) Then
                txtIdAli.Text = reader(0)
                txtNombreAli.Text = reader(1)
                txtCosteAli.Text = reader(2)
                txtIvaAli.Text = reader(3)
                txtStockAli.Text = reader(4)
                If reader(6) <> Nothing Or reader(6) <> "" Then
                    imgAli.Image = Image.FromFile(reader(6))
                    imgAli.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    imgAli.Image = Image.FromFile(rutaImgEcoPrime)
                imgAli.BackgroundImageLayout = ImageLayout.Stretch

            End If
            txtDescripAli.Text = reader(5)
                txtPrecioMayAli.Text = reader(7)
                txtPrecioMinAli.Text = reader(8)
                txtProveedorAli.Text = Me.ProveedoresTableAdapter1.ConsultarProveedor(reader(9))

            End If
            reader.Close()
            conexion.Close()
        End If
    End Sub

    Private Sub btnEliminarAli_Click(sender As Object, e As EventArgs) Handles btnEliminarAli.Click
        If txtIdAli.Text = "" Then
            MessageBox.Show("Selecciona un Alimento")
        Else
            Me.AlimentosTableAdapter.EliminarAlimento(txtIdAli.Text)
            MessageBox.Show("ALIMENTO ELIMINADO")
            Me.AlimentosTableAdapter.Fill(Me.EcoPrimeDataSet.Alimentos)
            vaciarCamposAlimentos()
        End If
    End Sub

    Public Sub vaciarCamposAlimentos()
        txtIdAli.Text = ""
        txtNombreAli.Text = ""
        txtCosteAli.Text = ""
        txtIvaAli.Text = ""
        txtStockAli.Text = ""
        txtDescripAli.Text = ""
        imgAli.Image = Image.FromFile(rutaImgEcoPrime)
        imgAli.BackgroundImageLayout = ImageLayout.Stretch
        txtPrecioMayAli.Text = ""
        txtPrecioMinAli.Text = ""
        txtProveedorAli.Text = ""
    End Sub


    '--------------------------------------TABLA BEBIDA--------------------------------
    Private Sub cmbBebidas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBebidas.SelectedIndexChanged
        Dim idBebidas As Integer = Convert.ToInt16(cmbBebidas.SelectedValue)

        If idBebidas >= 0 Then
            Dim sql As String = "SELECT * FROM bebidas where idProducto='" & idBebidas & "'"
            consultasql.CommandType = CommandType.Text
            consultasql.Connection = conexion
            consultasql.CommandText = sql
            conexion.Open()
            Dim reader As SqlDataReader = consultasql.ExecuteReader()

            If (reader.Read()) Then
                txtIdBeb.Text = reader(0)
                txtNombreBeb.Text = reader(1)
                txtCosteBeb.Text = reader(2)
                txtIvaBeb.Text = reader(3)
                txtStockBeb.Text = reader(4)
                If reader(6) <> Nothing Or reader(6) <> "" Then
                    imgBebidas.Image = Image.FromFile(reader(6))
                    imgBebidas.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    imgBebidas.Image = Image.FromFile(rutaImgEcoPrime)
                    imgBebidas.BackgroundImageLayout = ImageLayout.Stretch

                End If
                txtDescripBeb.Text = reader(5)
                txtPrecioMayBeb.Text = reader(7)
                txtPrecioMinBeb.Text = reader(8)
                txtProveedorBeb.Text = Me.ProveedoresTableAdapter1.ConsultarProveedor(reader(9))

            End If
            reader.Close()
            conexion.Close()
        End If
    End Sub

    Private Sub btnEliminarBeb_Click(sender As Object, e As EventArgs) Handles btnEliminarBeb.Click
        If txtIdBeb.Text = "" Then
            MessageBox.Show("Selecciona una Bebida")
        Else
            Me.BebidasTableAdapter.EliminarBebida(txtIdBeb.Text)
            MessageBox.Show("BEBIDA ELIMINADA")
            Me.BebidasTableAdapter.Fill(Me.EcoPrimeDataSet.Bebidas)
            vaciarCamposBebida()
        End If
    End Sub
    Public Sub vaciarCamposBebida()
        txtIdBeb.Text = ""
        txtNombreBeb.Text = ""
        txtCosteBeb.Text = ""
        txtIvaBeb.Text = ""
        txtStockBeb.Text = ""
        imgBebidas.Image = Image.FromFile(rutaImgEcoPrime)
        imgBebidas.BackgroundImageLayout = ImageLayout.Stretch
        txtDescripBeb.Text = ""
        txtPrecioMayBeb.Text = ""
        txtPrecioMinBeb.Text = ""
        txtProveedorBeb.Text = ""
    End Sub

End Class