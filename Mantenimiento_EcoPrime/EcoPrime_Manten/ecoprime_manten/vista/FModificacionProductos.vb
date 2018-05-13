Imports System.Data.SqlClient
Imports System.IO

Public Class FModificacionProductos


    Private Sub FModificacionProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        Me.BebidasTableAdapter.Fill(Me.EcoPrimeDataSet.Bebidas)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Alimentos' Puede moverla o quitarla según sea necesario.
        Me.AlimentosTableAdapter.Fill(Me.EcoPrimeDataSet.Alimentos)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.EcoPrimeDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Menaje' Puede moverla o quitarla según sea necesario.
        Me.MenajeTableAdapter.Fill(Me.EcoPrimeDataSet.Menaje)


        'LOAD---------------------------------------------------------------------------------------------------------------------------
        txtIdMen.Enabled = False
        txtIdAli.Enabled = False
        txtIdBeb.Enabled = False

        modificarMen(False)
        modificarAli(False)
        modificarBeb(False)

        cmbMenaje.SelectedIndex = -1
        cmbAlimento.SelectedIndex = -1
        cmbBebidas.SelectedIndex = -1

        cmbProveedoresMen.SelectedIndex = -1
        cmbProveedorAli.SelectedIndex = -1
        cmbProveedorBeb.SelectedIndex = -1

    End Sub


    Public Function cargarImagen()
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.Multiselect = False 'ASÍ SOLO PUEDE SELECCIONAR 1 ARCHIVO
        Dim directorio As DirectoryInfo
        Dim NombreDir As String
        ' obtenemos el directorio actual de ejecución
        NombreDir = Directory.GetCurrentDirectory()
        ' obtenemos el directorio padre del actual, y mostramos información de dicha directorio
        directorio = Directory.GetParent(NombreDir)
        directorio = Directory.GetParent(directorio.FullName)
        Me.OpenFileDialog1.InitialDirectory = directorio.FullName & "\Imagenes"
        Me.OpenFileDialog1.Filter = "Ficheros png (*.png)|*.png|*.jpeg|*.bmp|Todos (*.*)|*.*"
        Me.OpenFileDialog1.FilterIndex = 3
        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" Then
            Me.imagenMenaje.SizeMode = PictureBoxSizeMode.StretchImage
            Me.imagenMenaje.Image =
           Image.FromFile(Me.OpenFileDialog1.FileName)
        Else
            Me.imagenMenaje.Image = Nothing
        End If
        Return Me.OpenFileDialog1.FileName
    End Function



    'MENAJE---------------------------------------------------------------------------------------------------------------------------
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
                cmbProveedoresMen.SelectedIndex = Convert.ToInt16(reader(9)) - 1

            End If
            reader.Close()
            conexion.Close()
        End If
    End Sub

    Private Sub modificarMen(valor As Boolean)

        txtNomMen.Enabled = valor
        txtCosteMen.Enabled = valor
        txtIvaMen.Enabled = valor
        txtStockMen.Enabled = valor
        txtDescripMen.Enabled = valor
        txtPrecioMayMen.Enabled = valor
        txtPrecioMinMen.Enabled = valor
        cmbProveedoresMen.Enabled = valor
        btnGrabarMen.Visible = valor
        btnCancelarMen.Visible = valor
        btnImagenMen.Visible = valor
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs)
        rutaImagen = cargarImagen()
    End Sub

    Private Sub btnGrabarMenaje_Click(sender As Object, e As EventArgs) Handles btnGrabarMen.Click

        Dim id As String = txtIdMen.Text
        Dim nombre As String = txtNomMen.Text
        Dim coste As String = txtCosteMen.Text
        Dim iva As String = txtIvaMen.Text
        Dim stock As String = txtStockMen.Text
        Dim descripcion As String = txtDescripMen.Text
        Dim precioMay As String = txtPrecioMayMen.Text
        Dim precioMin As String = txtPrecioMinMen.Text

        If cmbMenaje.SelectedValue = Nothing Then
            MessageBox.Show("NO HA ELEGIDO UN PRODUCTO PARA MODFICAR", "A T E N C I O N")
        Else
            Dim result As Integer = MessageBox.Show("SE VAN A MODIFICAR LOS DATOS, ¿ESTA SEGURO?", "P R E C A U C I O N ", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                MessageBox.Show("SE HA CANCELADO LA OPERACION")
                conexion.Close()
                modificarMen(False)
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                If nombre <> "" And coste <> "" And txtIvaMen.Text <> "" And iva <> "" And stock <> "" And descripcion <> "" And precioMay <> "" And precioMin <> "" Then
                    Try
                        If Not IsNothing(Me.imagenMenaje.Image) Then
                            If Me.OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                                rutaImagen = Me.OpenFileDialog1.FileName
                            End If
                        Else
                            rutaImagen = Nothing
                        End If

                        Dim sql As String = "UPDATE menaje SET nombre='" & nombre & "', coste='" & coste & "', iva='" & iva & "', stock_seguridad='" & stock & "', descripcion='" & descripcion & "', imagen_producto='" & rutaImagen & "', precio_venta_mayorista='" & precioMay & "', precio_venta_minorista='" & precioMin & "'  WHERE idMenaje='" & id & "'"
                        consultasql.CommandType = CommandType.Text
                        consultasql.Connection = conexion
                        consultasql.CommandText = sql
                        conexion.Open()
                        consultasql.ExecuteNonQuery()
                        conexion.Close()

                        Me.MenajeBindingSource.EndEdit()
                        Me.MenajeTableAdapter.Update(Me.EcoPrimeDataSet.Menaje)
                        Me.MenajeTableAdapter.Fill(Me.EcoPrimeDataSet.Menaje)

                        cmbMenaje.SelectedIndex = Convert.ToInt16(id) - 1
                        MessageBox.Show("MODIFICACION REALIZADA", "E X I T O")
                        modificarMen(False)
                        btnModificarMen.Visible = True

                    Catch ex As Exception
                        MessageBox.Show("Se ha producido el error " & ex.Message & " al intentar actualizar la base de datos")
                    End Try

                Else
                    MessageBox.Show("FALTAN CAMPOS POR COMPLETAR", "A T E N C I O N")
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelarMen.Click
        modificarMen(False)
        btnModificarMen.Visible = True
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificarMen.Click

        If cmbMenaje.SelectedValue = Nothing Then
            MessageBox.Show("PARA MODIFICAR PRIMERO TIENE QUE SELECCIONAR UN PRODUCTO", "A T E N C I O N")
        Else
            modificarMen(True)
            btnModificarMen.Visible = False
        End If

    End Sub

    'MENAJE---------------------------------------------------------------------------------------------------------------------------

    'ALIMENTOS------------------------------------------------------------------------------------------------------------------------
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
                cmbProveedorAli.SelectedIndex = Convert.ToInt16(reader(9)) - 1

            End If
            reader.Close()
            conexion.Close()
        End If
    End Sub

    Private Sub modificarAli(valor As Boolean)
        txtNombreAli.Enabled = valor
        txtCosteAli.Enabled = valor
        txtIvaAli.Enabled = valor
        txtStockAli.Enabled = valor
        txtDescripAli.Enabled = valor
        txtPrecioMayAli.Enabled = valor
        txtPrecioMinAli.Enabled = valor
        cmbProveedorAli.Enabled = valor
        btnGrabarAli.Visible = valor
        btnCancelarAli.Visible = valor
        btnImagenAli.Visible = valor
    End Sub

    Private Sub btnImagenAli_Click(sender As Object, e As EventArgs) Handles btnImagenAli.Click
        rutaImagen = cargarImagen()
    End Sub

    Private Sub btnGrabarAli_Click(sender As Object, e As EventArgs) Handles btnGrabarAli.Click
        Dim id As String = txtIdAli.Text
        Dim nombre As String = txtNombreAli.Text
        Dim coste As String = txtCosteAli.Text
        Dim iva As String = txtIvaAli.Text
        Dim stock As String = txtStockAli.Text
        Dim descripcion As String = txtDescripAli.Text
        Dim precioMay As String = txtPrecioMayAli.Text
        Dim precioMin As String = txtPrecioMinAli.Text

        If cmbAlimento.SelectedValue = Nothing Then
            MessageBox.Show("NO HA ELEGIDO UN PRODUCTO PARA MODFICAR", "A T E N C I O N")
        Else
            Dim result As Integer = MessageBox.Show("SE VAN A MODIFICAR LOS DATOS, ¿ESTA SEGURO?", "P R E C A U C I O N ", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                MessageBox.Show("SE HA CANCELADO LA OPERACION")
                conexion.Close()
                modificarMen(False)
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                If nombre <> "" And coste <> "" And iva <> "" And stock <> "" And descripcion <> "" And precioMay <> "" And precioMin <> "" Then
                    Try
                        If Not IsNothing(Me.imagenMenaje.Image) Then
                            If Me.OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                                rutaImagen = Me.OpenFileDialog1.FileName
                            End If
                        Else
                            rutaImagen = Nothing
                        End If

                        Dim sql As String = "UPDATE alimentos SET nombre='" & nombre & "', coste='" & coste & "', iva='" & iva & "', stock_seguridad='" & stock & "', descripcion='" & descripcion & "', imagen_producto='" & rutaImagen & "', precio_venta_mayorista='" & precioMay & "', precio_venta_minorista='" & precioMin & "'  WHERE idAlimento='" & id & "'"
                        consultasql.CommandType = CommandType.Text
                        consultasql.Connection = conexion
                        consultasql.CommandText = sql
                        conexion.Open()
                        consultasql.ExecuteNonQuery()
                        conexion.Close()

                        Me.AlimentosBindingSource.EndEdit()
                        Me.AlimentosTableAdapter.Update(Me.EcoPrimeDataSet.Alimentos)
                        Me.AlimentosTableAdapter.Fill(Me.EcoPrimeDataSet.Alimentos)

                        cmbAlimento.SelectedIndex = Convert.ToInt16(id) - 1
                        MessageBox.Show("MODIFICACION REALIZADA", "E X I T O")
                        modificarAli(False)
                        btnModificarAli.Visible = True

                    Catch ex As Exception
                        MessageBox.Show("Se ha producido el error " & ex.Message & " al intentar actualizar la base de datos")
                    End Try

                Else
                    MessageBox.Show("FALTAN CAMPOS POR COMPLETAR", "A T E N C I O N")
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarAli_Click(sender As Object, e As EventArgs) Handles btnCancelarAli.Click
        modificarAli(False)
        btnModificarAli.Visible = True
    End Sub

    Private Sub btnModificarAli_Click(sender As Object, e As EventArgs) Handles btnModificarAli.Click

        If cmbAlimento.SelectedValue = Nothing Then
            MessageBox.Show("PARA MODIFICAR PRIMERO TIENE QUE SELECCIONAR UN PRODUCTO", "A T E N C I O N")
        Else
            modificarAli(True)
            btnModificarAli.Visible = False
        End If
    End Sub

    'ALIMENTOS-----------------------------------------------------------------------------------------------------------------------

    'BEBIDAS-------------------------------------------------------------------------------------------------------------------------
    Private Sub modificarBeb(valor As Boolean)
        txtNombreBeb.Enabled = valor
        txtCosteBeb.Enabled = valor
        txtIvaBeb.Enabled = valor
        txtStockBeb.Enabled = valor
        txtDescripBeb.Enabled = valor
        txtPrecioMayBeb.Enabled = valor
        txtPrecioMinBeb.Enabled = valor
        cmbProveedorBeb.Enabled = valor
        btnGrabarBeb.Visible = valor
        btnCancelarBeb.Visible = valor
        btnImagenBeb.Visible = valor
    End Sub

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
                cmbProveedorBeb.SelectedIndex = Convert.ToInt16(reader(9)) - 1

            End If
            reader.Close()
            conexion.Close()
        End If
    End Sub

    Private Sub btnImagenBeb_Click(sender As Object, e As EventArgs) Handles btnImagenBeb.Click
        rutaImagen = cargarImagen()
    End Sub

    Private Sub btnModificarBeb_Click(sender As Object, e As EventArgs) Handles btnModificarBeb.Click

        If cmbBebidas.SelectedValue = Nothing Then
            MessageBox.Show("PARA MODIFICAR PRIMERO TIENE QUE SELECCIONAR UN PRODUCTO", "A T E N C I O N")
        Else
            modificarBeb(True)
            btnModificarBeb.Visible = False
        End If
    End Sub

    Private Sub btnGrabarBeb_Click(sender As Object, e As EventArgs) Handles btnGrabarBeb.Click
        Dim id As String = txtIdBeb.Text
        Dim nombre As String = txtNombreBeb.Text
        Dim coste As String = txtCosteBeb.Text
        Dim iva As String = txtIvaBeb.Text
        Dim stock As String = txtStockBeb.Text
        Dim descripcion As String = txtDescripBeb.Text
        Dim precioMay As String = txtPrecioMayBeb.Text
        Dim precioMin As String = txtPrecioMinBeb.Text

        If cmbBebidas.SelectedValue = Nothing Then
            MessageBox.Show("NO HA ELEGIDO UN PRODUCTO PARA MODFICAR", "A T E N C I O N")
        Else
            Dim result As Integer = MessageBox.Show("SE VAN A MODIFICAR LOS DATOS, ¿ESTA SEGURO?", "P R E C A U C I O N ", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                MessageBox.Show("SE HA CANCELADO LA OPERACION")
                conexion.Close()
                modificarBeb(False)
                Exit Sub
            ElseIf result = DialogResult.Yes Then
                If nombre <> "" And coste <> "" And iva <> "" And stock <> "" And descripcion <> "" And precioMay <> "" And precioMin <> "" Then
                    Try
                        If Not IsNothing(Me.imagenMenaje.Image) Then
                            If Me.OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                                rutaImagen = Me.OpenFileDialog1.FileName
                            End If
                        Else
                            rutaImagen = Nothing
                        End If

                        Dim sql As String = "UPDATE bebidas SET nombre='" & nombre & "', coste='" & coste & "', iva='" & iva & "', stock_seguridad='" & stock & "', descripcion='" & descripcion & "', imagen_producto='" & rutaImagen & "', precio_venta_mayorista='" & precioMay & "', precio_venta_minorista='" & precioMin & "'  WHERE idProducto='" & id & "'"
                        consultasql.CommandType = CommandType.Text
                        consultasql.Connection = conexion
                        consultasql.CommandText = sql
                        conexion.Open()
                        consultasql.ExecuteNonQuery()
                        conexion.Close()

                        Me.BebidasBindingSource.EndEdit()
                        Me.BebidasTableAdapter.Update(Me.EcoPrimeDataSet.Bebidas)
                        Me.BebidasTableAdapter.Fill(Me.EcoPrimeDataSet.Bebidas)

                        cmbBebidas.SelectedIndex = Convert.ToInt16(id) - 1
                        MessageBox.Show("MODIFICACION REALIZADA", "E X I T O")
                        modificarBeb(False)
                        btnModificarBeb.Visible = True

                    Catch ex As Exception
                        MessageBox.Show("Se ha producido el error " & ex.Message & " al intentar actualizar la base de datos")
                    End Try

                Else
                    MessageBox.Show("FALTAN CAMPOS POR COMPLETAR", "A T E N C I O N")
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelarBeb_Click(sender As Object, e As EventArgs) Handles btnCancelarBeb.Click
        modificarBeb(False)
        btnModificarBeb.Visible = True
    End Sub

    'BEBIDAS-------------------------------------------------------------------------------------------------------------------------



End Class