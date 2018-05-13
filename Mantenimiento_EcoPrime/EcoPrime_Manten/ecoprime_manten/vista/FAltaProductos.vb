Imports System.Data.SqlClient
Imports System.IO

Public Class FAltaProductos

    Private Sub FAltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Alimentos' Puede moverla o quitarla según sea necesario.
        ' Me.AlimentosTableAdapter.Fill(Me.EcoPrimeDataSet.Alimentos)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.EcoPrimeDataSet.Proveedores)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        ' Me.BebidasTableAdapter.Fill(Me.EcoPrimeDataSet.Bebidas)
        IdMenajeTextBox.Text = buscarElMaxID(1)
        IdProductoTextBox.Text = buscarElMaxID(2)
        IdAlimentoTextBox.Text = buscarElMaxID(3)
        Me.OpenFileDialog1.FileName = rutaImgEcoPrime
    End Sub

    Public Function buscarElMaxID(ByVal tab As Integer)
        Dim maxId As Integer
        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        'consultasql.CommandText = "Select count(*) from cursos"
        If tab < 1 Or tab > 3 Then
            MessageBox.Show("Introduce el número de pestaña en la que esta situado (del 1 al 3)")
        Else
            If tab = 1 Then
                consultasql.CommandText = "Select max(idMenaje) from Menaje"
            ElseIf tab = 2 Then
                consultasql.CommandText = "Select max(idProducto) from Bebidas"
            ElseIf tab = 3 Then
                consultasql.CommandText = "Select max(idAlimento) from Alimentos"
            End If
            conexion.Open()
            maxId = consultasql.ExecuteScalar() + 1
            conexion.Close()
        End If
        Return maxId
    End Function

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


    '--------------------------------------PESTAÑA DE MENAJE-------------------------------------

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        rutaImagen = cargarImagen()
    End Sub

    Private Sub btnGrabarMenaje_Click(sender As Object, e As EventArgs) Handles btnGrabarMenaje.Click
        If IdMenajeTextBox.Text = "" Or NombreTextBox.Text = "" Or CosteTextBox.Text = "" Or
                IVATextBox.Text = "" Or Stock_seguridadTextBox.Text = "" Or DescripcionTextBox.Text = "" Or
                Precio_venta_mayoristaTextBox.Text = "" Or Precio_venta_minoristaTextBox.Text = "" Then
            MessageBox.Show("INTRODUCE LOS DATOS DEL MENAJE")
        Else
            Me.MenajeTableAdapter1.InsertarMenaje _
                (IdMenajeTextBox.Text, NombreTextBox.Text, Double.Parse(CosteTextBox.Text), Double.Parse(IVATextBox.Text),
                 Integer.Parse(Stock_seguridadTextBox.Text), DescripcionTextBox.Text, OpenFileDialog1.FileName,
                 Double.Parse(Precio_venta_mayoristaTextBox.Text),
                 Double.Parse(Precio_venta_minoristaTextBox.Text), cmbProveedores.SelectedValue)

            MessageBox.Show("Menaje insertado correctamente")
            borrarCamposMenaje()
        End If
    End Sub

    Public Sub borrarCamposMenaje()
        IdMenajeTextBox.Text = buscarElMaxID(1)
        NombreTextBox.Text = ""
        CosteTextBox.Text = ""
        IVATextBox.Text = ""
        Stock_seguridadTextBox.Text = ""
        DescripcionTextBox.Text = ""
        Precio_venta_mayoristaTextBox.Text = ""
        Precio_venta_minoristaTextBox.Text = ""
    End Sub


    '--------------------------------------PESTAÑA DE ALIMENTOS-------------------------------------

    Private Sub btnCargarImagenAlimentos_Click(sender As Object, e As EventArgs) Handles btnCargarImagenAlimentos.Click
        rutaImagen = cargarImagen()
    End Sub

    Private Sub btnGrabarAlimentos_Click_1(sender As Object, e As EventArgs) Handles btnGrabarAlimentos.Click
        If IdAlimentoTextBox.Text = "" Or NombreTextBox1.Text = "" Or DescripcionTextBox1.Text = "" Or
        CosteTextBox1.Text = "" Or IVATextBox1.Text = "" Or Stock_seguridadTextBox1.Text = "" Or
        Precio_venta_mayoristaTextBox1.Text = "" Or Precio_venta_minoristaTextBox1.Text = "" Then
            MessageBox.Show("INTRODUCE LOS DATOS DEL ALIMENTO")
        Else
            Me.AlimentosTableAdapter.insertarAlimento _
        (IdAlimentoTextBox.Text, NombreTextBox1.Text, Double.Parse(CosteTextBox1.Text), Double.Parse(IVATextBox1.Text),
         Integer.Parse(Stock_seguridadTextBox1.Text), DescripcionTextBox1.Text, OpenFileDialog1.FileName,
         Double.Parse(Precio_venta_mayoristaTextBox1.Text),
         Double.Parse(Precio_venta_minoristaTextBox1.Text), cmbProveedoresAli.SelectedValue)

            MessageBox.Show("Alimento insertado correctamente")
            borrarCamposAlimento()
        End If
    End Sub

    Public Sub borrarCamposAlimento()
        IdAlimentoTextBox.Text = buscarElMaxID(3)
        NombreTextBox1.Text = ""
        CosteTextBox1.Text = ""
        IVATextBox1.Text = ""
        Stock_seguridadTextBox1.Text = ""
        DescripcionTextBox1.Text = ""
        Precio_venta_mayoristaTextBox1.Text = ""
        Precio_venta_minoristaTextBox1.Text = ""
    End Sub


    '--------------------------------------PESTAÑA DE BEBIDAS-------------------------------------


    Private Sub btnCargarImagenBebida_Click(sender As Object, e As EventArgs) Handles btnCargarImagenBebida.Click
        rutaImagen = cargarImagen()
    End Sub

    Private Sub btnGrabarBebida_Click(sender As Object, e As EventArgs) Handles btnGrabarBebida.Click
        If IdProductoTextBox.Text = "" Or NombreTextBox2.Text = "" Or CosteTextBox2.Text = "" Or
                IVATextBox2.Text = "" Or Stock_seguridadTextBox2.Text = "" Or DescripcionTextBox2.Text = "" Or
                Precio_venta_mayoristaTextBox2.Text = "" Or Precio_venta_minoristaTextBox2.Text = "" Then
            MessageBox.Show("INTRODUCE LOS DATOS DE LAS BEBIDA")
        Else
            Me.BebidasTableAdapter.insertarBebida _
(IdProductoTextBox.Text, NombreTextBox2.Text, Double.Parse(CosteTextBox2.Text), Double.Parse(IVATextBox2.Text),
 Integer.Parse(Stock_seguridadTextBox2.Text), DescripcionTextBox2.Text, OpenFileDialog1.FileName,
 Double.Parse(Precio_venta_mayoristaTextBox2.Text),
 Double.Parse(Precio_venta_minoristaTextBox2.Text), cmbProveedoresBebida.SelectedValue)

            MessageBox.Show("Bebida insertada correctamente")
            borrarCamposBebida()
        End If
    End Sub

    Public Sub borrarCamposBebida()
        IdProductoTextBox.Text = buscarElMaxID(2)
        NombreTextBox2.Text = ""
        CosteTextBox2.Text = ""
        IVATextBox2.Text = ""
        Stock_seguridadTextBox2.Text = ""
        DescripcionTextBox2.Text = ""
        Precio_venta_mayoristaTextBox2.Text = ""
        Precio_venta_minoristaTextBox2.Text = ""
    End Sub


End Class