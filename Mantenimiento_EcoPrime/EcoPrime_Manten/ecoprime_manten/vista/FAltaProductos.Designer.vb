<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAltaProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdProveedor_FK1Label As System.Windows.Forms.Label
        Dim Precio_venta_minoristaLabel As System.Windows.Forms.Label
        Dim Precio_venta_mayoristaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Stock_seguridadLabel As System.Windows.Forms.Label
        Dim IVALabel As System.Windows.Forms.Label
        Dim CosteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim IdMenajeLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAltaProductos))
        Me.MenajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EcoPrimeDataSet = New EcoPrime_Manten.EcoPrimeDataSet()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BebidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BebidasTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.BebidasTableAdapter()
        Me.TableAdapterManager = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.TableAdapterManager()
        Me.ProveedoresTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.ProveedoresTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenajeTableAdapter1 = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.MenajeTableAdapter()
        Me.AlimentosTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.AlimentosTableAdapter()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.IdProductoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox2 = New System.Windows.Forms.TextBox()
        Me.CosteTextBox2 = New System.Windows.Forms.TextBox()
        Me.IVATextBox2 = New System.Windows.Forms.TextBox()
        Me.Stock_seguridadTextBox2 = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox2 = New System.Windows.Forms.TextBox()
        Me.Precio_venta_mayoristaTextBox2 = New System.Windows.Forms.TextBox()
        Me.Precio_venta_minoristaTextBox2 = New System.Windows.Forms.TextBox()
        Me.btnCargarImagenBebida = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmbProveedoresBebida = New System.Windows.Forms.ComboBox()
        Me.btnGrabarBebida = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.IdAlimentoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.CosteTextBox1 = New System.Windows.Forms.TextBox()
        Me.IVATextBox1 = New System.Windows.Forms.TextBox()
        Me.Stock_seguridadTextBox1 = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox1 = New System.Windows.Forms.TextBox()
        Me.Precio_venta_mayoristaTextBox1 = New System.Windows.Forms.TextBox()
        Me.Precio_venta_minoristaTextBox1 = New System.Windows.Forms.TextBox()
        Me.btnCargarImagenAlimentos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbProveedoresAli = New System.Windows.Forms.ComboBox()
        Me.btnGrabarAlimentos = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IdMenajeTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CosteTextBox = New System.Windows.Forms.TextBox()
        Me.IVATextBox = New System.Windows.Forms.TextBox()
        Me.Stock_seguridadTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_venta_mayoristaTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_venta_minoristaTextBox = New System.Windows.Forms.TextBox()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.imagenMenaje = New System.Windows.Forms.PictureBox()
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        Me.btnGrabarMenaje = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        IdProveedor_FK1Label = New System.Windows.Forms.Label()
        Precio_venta_minoristaLabel = New System.Windows.Forms.Label()
        Precio_venta_mayoristaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Stock_seguridadLabel = New System.Windows.Forms.Label()
        IVALabel = New System.Windows.Forms.Label()
        CosteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        IdMenajeLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        CType(Me.MenajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EcoPrimeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.imagenMenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdProveedor_FK1Label
        '
        IdProveedor_FK1Label.AutoSize = True
        IdProveedor_FK1Label.Location = New System.Drawing.Point(105, 274)
        IdProveedor_FK1Label.Name = "IdProveedor_FK1Label"
        IdProveedor_FK1Label.Size = New System.Drawing.Size(74, 17)
        IdProveedor_FK1Label.TabIndex = 18
        IdProveedor_FK1Label.Text = "Proveedor"
        '
        'Precio_venta_minoristaLabel
        '
        Precio_venta_minoristaLabel.AutoSize = True
        Precio_venta_minoristaLabel.Location = New System.Drawing.Point(105, 245)
        Precio_venta_minoristaLabel.Name = "Precio_venta_minoristaLabel"
        Precio_venta_minoristaLabel.Size = New System.Drawing.Size(154, 17)
        Precio_venta_minoristaLabel.TabIndex = 39
        Precio_venta_minoristaLabel.Text = "Precio Venta Minorista:"
        '
        'Precio_venta_mayoristaLabel
        '
        Precio_venta_mayoristaLabel.AutoSize = True
        Precio_venta_mayoristaLabel.Location = New System.Drawing.Point(105, 217)
        Precio_venta_mayoristaLabel.Name = "Precio_venta_mayoristaLabel"
        Precio_venta_mayoristaLabel.Size = New System.Drawing.Size(158, 17)
        Precio_venta_mayoristaLabel.TabIndex = 37
        Precio_venta_mayoristaLabel.Text = "Precio Venta Mayorista:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(105, 102)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 33
        DescripcionLabel.Text = "Descripcion:"
        '
        'Stock_seguridadLabel
        '
        Stock_seguridadLabel.AutoSize = True
        Stock_seguridadLabel.Location = New System.Drawing.Point(105, 188)
        Stock_seguridadLabel.Name = "Stock_seguridadLabel"
        Stock_seguridadLabel.Size = New System.Drawing.Size(116, 17)
        Stock_seguridadLabel.TabIndex = 31
        Stock_seguridadLabel.Text = "Stock Seguridad:"
        '
        'IVALabel
        '
        IVALabel.AutoSize = True
        IVALabel.Location = New System.Drawing.Point(105, 160)
        IVALabel.Name = "IVALabel"
        IVALabel.Size = New System.Drawing.Size(33, 17)
        IVALabel.TabIndex = 29
        IVALabel.Text = "IVA:"
        '
        'CosteLabel
        '
        CosteLabel.AutoSize = True
        CosteLabel.Location = New System.Drawing.Point(105, 132)
        CosteLabel.Name = "CosteLabel"
        CosteLabel.Size = New System.Drawing.Size(48, 17)
        CosteLabel.TabIndex = 27
        CosteLabel.Text = "Coste:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(105, 73)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 25
        NombreLabel.Text = "Nombre:"
        '
        'IdMenajeLabel
        '
        IdMenajeLabel.AutoSize = True
        IdMenajeLabel.Location = New System.Drawing.Point(105, 46)
        IdMenajeLabel.Name = "IdMenajeLabel"
        IdMenajeLabel.Size = New System.Drawing.Size(89, 17)
        IdMenajeLabel.TabIndex = 23
        IdMenajeLabel.Text = "Identificador:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(72, 45)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(89, 17)
        Label1.TabIndex = 46
        Label1.Text = "Identificador:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(72, 72)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(62, 17)
        Label2.TabIndex = 48
        Label2.Text = "Nombre:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(72, 131)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(48, 17)
        Label3.TabIndex = 50
        Label3.Text = "Coste:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(72, 159)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(33, 17)
        Label4.TabIndex = 52
        Label4.Text = "IVA:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(72, 187)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(116, 17)
        Label5.TabIndex = 54
        Label5.Text = "Stock Seguridad:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(72, 101)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(86, 17)
        Label6.TabIndex = 56
        Label6.Text = "Descripcion:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(72, 216)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(158, 17)
        Label7.TabIndex = 58
        Label7.Text = "Precio Venta Mayorista:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(72, 244)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(154, 17)
        Label8.TabIndex = 60
        Label8.Text = "Precio Venta Minorista:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(72, 273)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(74, 17)
        Label10.TabIndex = 41
        Label10.Text = "Proveedor"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(72, 45)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(89, 17)
        Label9.TabIndex = 46
        Label9.Text = "Identificador:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(72, 72)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(62, 17)
        Label11.TabIndex = 48
        Label11.Text = "Nombre:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(72, 131)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(48, 17)
        Label12.TabIndex = 50
        Label12.Text = "Coste:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(72, 159)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(33, 17)
        Label13.TabIndex = 52
        Label13.Text = "IVA:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(72, 187)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(116, 17)
        Label14.TabIndex = 54
        Label14.Text = "Stock Seguridad:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(72, 101)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(86, 17)
        Label15.TabIndex = 56
        Label15.Text = "Descripcion:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(72, 216)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(158, 17)
        Label16.TabIndex = 58
        Label16.Text = "Precio Venta Mayorista:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(72, 244)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(154, 17)
        Label17.TabIndex = 60
        Label17.Text = "Precio Venta Minorista:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(72, 273)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(74, 17)
        Label18.TabIndex = 41
        Label18.Text = "Proveedor"
        '
        'MenajeBindingSource
        '
        Me.MenajeBindingSource.DataMember = "Menaje"
        Me.MenajeBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'EcoPrimeDataSet
        '
        Me.EcoPrimeDataSet.DataSetName = "EcoPrimeDataSet"
        Me.EcoPrimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'AlimentosBindingSource
        '
        Me.AlimentosBindingSource.DataMember = "Alimentos"
        Me.AlimentosBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'BebidasBindingSource
        '
        Me.BebidasBindingSource.DataMember = "Bebidas"
        Me.BebidasBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'BebidasTableAdapter
        '
        Me.BebidasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AlimentosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BebidasTableAdapter = Me.BebidasTableAdapter
        Me.TableAdapterManager.MenajeTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EcoPrime_Manten.EcoPrimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenajeTableAdapter1
        '
        Me.MenajeTableAdapter1.ClearBeforeFill = True
        '
        'AlimentosTableAdapter
        '
        Me.AlimentosTableAdapter.ClearBeforeFill = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Label9)
        Me.TabPage3.Controls.Add(Me.IdProductoTextBox)
        Me.TabPage3.Controls.Add(Me.NombreTextBox2)
        Me.TabPage3.Controls.Add(Me.CosteTextBox2)
        Me.TabPage3.Controls.Add(Me.IVATextBox2)
        Me.TabPage3.Controls.Add(Me.Stock_seguridadTextBox2)
        Me.TabPage3.Controls.Add(Me.DescripcionTextBox2)
        Me.TabPage3.Controls.Add(Me.Precio_venta_mayoristaTextBox2)
        Me.TabPage3.Controls.Add(Me.Precio_venta_minoristaTextBox2)
        Me.TabPage3.Controls.Add(Label11)
        Me.TabPage3.Controls.Add(Label12)
        Me.TabPage3.Controls.Add(Label13)
        Me.TabPage3.Controls.Add(Label14)
        Me.TabPage3.Controls.Add(Label15)
        Me.TabPage3.Controls.Add(Label16)
        Me.TabPage3.Controls.Add(Label17)
        Me.TabPage3.Controls.Add(Me.btnCargarImagenBebida)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.cmbProveedoresBebida)
        Me.TabPage3.Controls.Add(Me.btnGrabarBebida)
        Me.TabPage3.Controls.Add(Label18)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(664, 425)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bebidas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'IdProductoTextBox
        '
        Me.IdProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "idMenaje", True))
        Me.IdProductoTextBox.Enabled = False
        Me.IdProductoTextBox.Location = New System.Drawing.Point(234, 41)
        Me.IdProductoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdProductoTextBox.Name = "IdProductoTextBox"
        Me.IdProductoTextBox.Size = New System.Drawing.Size(51, 22)
        Me.IdProductoTextBox.TabIndex = 47
        '
        'NombreTextBox2
        '
        Me.NombreTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "nombre", True))
        Me.NombreTextBox2.Location = New System.Drawing.Point(234, 69)
        Me.NombreTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox2.Name = "NombreTextBox2"
        Me.NombreTextBox2.Size = New System.Drawing.Size(135, 22)
        Me.NombreTextBox2.TabIndex = 49
        '
        'CosteTextBox2
        '
        Me.CosteTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "Coste", True))
        Me.CosteTextBox2.Location = New System.Drawing.Point(234, 128)
        Me.CosteTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CosteTextBox2.Name = "CosteTextBox2"
        Me.CosteTextBox2.Size = New System.Drawing.Size(111, 22)
        Me.CosteTextBox2.TabIndex = 51
        '
        'IVATextBox2
        '
        Me.IVATextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "IVA", True))
        Me.IVATextBox2.Location = New System.Drawing.Point(234, 155)
        Me.IVATextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IVATextBox2.Name = "IVATextBox2"
        Me.IVATextBox2.Size = New System.Drawing.Size(111, 22)
        Me.IVATextBox2.TabIndex = 53
        '
        'Stock_seguridadTextBox2
        '
        Me.Stock_seguridadTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "stock_seguridad", True))
        Me.Stock_seguridadTextBox2.Location = New System.Drawing.Point(234, 184)
        Me.Stock_seguridadTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Stock_seguridadTextBox2.Name = "Stock_seguridadTextBox2"
        Me.Stock_seguridadTextBox2.Size = New System.Drawing.Size(51, 22)
        Me.Stock_seguridadTextBox2.TabIndex = 55
        '
        'DescripcionTextBox2
        '
        Me.DescripcionTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "descripcion", True))
        Me.DescripcionTextBox2.Location = New System.Drawing.Point(234, 99)
        Me.DescripcionTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DescripcionTextBox2.Name = "DescripcionTextBox2"
        Me.DescripcionTextBox2.Size = New System.Drawing.Size(135, 22)
        Me.DescripcionTextBox2.TabIndex = 57
        '
        'Precio_venta_mayoristaTextBox2
        '
        Me.Precio_venta_mayoristaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "precio_venta_mayorista", True))
        Me.Precio_venta_mayoristaTextBox2.Location = New System.Drawing.Point(234, 212)
        Me.Precio_venta_mayoristaTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Precio_venta_mayoristaTextBox2.Name = "Precio_venta_mayoristaTextBox2"
        Me.Precio_venta_mayoristaTextBox2.Size = New System.Drawing.Size(111, 22)
        Me.Precio_venta_mayoristaTextBox2.TabIndex = 59
        '
        'Precio_venta_minoristaTextBox2
        '
        Me.Precio_venta_minoristaTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "precio_venta_minorista", True))
        Me.Precio_venta_minoristaTextBox2.Location = New System.Drawing.Point(234, 240)
        Me.Precio_venta_minoristaTextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Precio_venta_minoristaTextBox2.Name = "Precio_venta_minoristaTextBox2"
        Me.Precio_venta_minoristaTextBox2.Size = New System.Drawing.Size(111, 22)
        Me.Precio_venta_minoristaTextBox2.TabIndex = 61
        '
        'btnCargarImagenBebida
        '
        Me.btnCargarImagenBebida.Location = New System.Drawing.Point(426, 207)
        Me.btnCargarImagenBebida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCargarImagenBebida.Name = "btnCargarImagenBebida"
        Me.btnCargarImagenBebida.Size = New System.Drawing.Size(167, 44)
        Me.btnCargarImagenBebida.TabIndex = 45
        Me.btnCargarImagenBebida.Text = "Cargar Imagen"
        Me.btnCargarImagenBebida.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(426, 41)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 158)
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'cmbProveedoresBebida
        '
        Me.cmbProveedoresBebida.DataSource = Me.ProveedoresBindingSource
        Me.cmbProveedoresBebida.DisplayMember = "Nombre"
        Me.cmbProveedoresBebida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedoresBebida.FormattingEnabled = True
        Me.cmbProveedoresBebida.Location = New System.Drawing.Point(234, 270)
        Me.cmbProveedoresBebida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbProveedoresBebida.Name = "cmbProveedoresBebida"
        Me.cmbProveedoresBebida.Size = New System.Drawing.Size(135, 24)
        Me.cmbProveedoresBebida.TabIndex = 43
        Me.cmbProveedoresBebida.ValueMember = "idProveedor"
        '
        'btnGrabarBebida
        '
        Me.btnGrabarBebida.Location = New System.Drawing.Point(122, 339)
        Me.btnGrabarBebida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGrabarBebida.Name = "btnGrabarBebida"
        Me.btnGrabarBebida.Size = New System.Drawing.Size(341, 44)
        Me.btnGrabarBebida.TabIndex = 42
        Me.btnGrabarBebida.Text = "Grabar"
        Me.btnGrabarBebida.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Label1)
        Me.TabPage2.Controls.Add(Me.IdAlimentoTextBox)
        Me.TabPage2.Controls.Add(Me.NombreTextBox1)
        Me.TabPage2.Controls.Add(Me.CosteTextBox1)
        Me.TabPage2.Controls.Add(Me.IVATextBox1)
        Me.TabPage2.Controls.Add(Me.Stock_seguridadTextBox1)
        Me.TabPage2.Controls.Add(Me.DescripcionTextBox1)
        Me.TabPage2.Controls.Add(Me.Precio_venta_mayoristaTextBox1)
        Me.TabPage2.Controls.Add(Me.Precio_venta_minoristaTextBox1)
        Me.TabPage2.Controls.Add(Label2)
        Me.TabPage2.Controls.Add(Label3)
        Me.TabPage2.Controls.Add(Label4)
        Me.TabPage2.Controls.Add(Label5)
        Me.TabPage2.Controls.Add(Label6)
        Me.TabPage2.Controls.Add(Label7)
        Me.TabPage2.Controls.Add(Label8)
        Me.TabPage2.Controls.Add(Me.btnCargarImagenAlimentos)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.cmbProveedoresAli)
        Me.TabPage2.Controls.Add(Me.btnGrabarAlimentos)
        Me.TabPage2.Controls.Add(Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(664, 425)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Alimentos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'IdAlimentoTextBox
        '
        Me.IdAlimentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "idMenaje", True))
        Me.IdAlimentoTextBox.Enabled = False
        Me.IdAlimentoTextBox.Location = New System.Drawing.Point(234, 41)
        Me.IdAlimentoTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdAlimentoTextBox.Name = "IdAlimentoTextBox"
        Me.IdAlimentoTextBox.Size = New System.Drawing.Size(51, 22)
        Me.IdAlimentoTextBox.TabIndex = 47
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(234, 69)
        Me.NombreTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(135, 22)
        Me.NombreTextBox1.TabIndex = 49
        '
        'CosteTextBox1
        '
        Me.CosteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "Coste", True))
        Me.CosteTextBox1.Location = New System.Drawing.Point(234, 128)
        Me.CosteTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CosteTextBox1.Name = "CosteTextBox1"
        Me.CosteTextBox1.Size = New System.Drawing.Size(111, 22)
        Me.CosteTextBox1.TabIndex = 51
        '
        'IVATextBox1
        '
        Me.IVATextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "IVA", True))
        Me.IVATextBox1.Location = New System.Drawing.Point(234, 155)
        Me.IVATextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IVATextBox1.Name = "IVATextBox1"
        Me.IVATextBox1.Size = New System.Drawing.Size(111, 22)
        Me.IVATextBox1.TabIndex = 53
        '
        'Stock_seguridadTextBox1
        '
        Me.Stock_seguridadTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "stock_seguridad", True))
        Me.Stock_seguridadTextBox1.Location = New System.Drawing.Point(234, 184)
        Me.Stock_seguridadTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Stock_seguridadTextBox1.Name = "Stock_seguridadTextBox1"
        Me.Stock_seguridadTextBox1.Size = New System.Drawing.Size(51, 22)
        Me.Stock_seguridadTextBox1.TabIndex = 55
        '
        'DescripcionTextBox1
        '
        Me.DescripcionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "descripcion", True))
        Me.DescripcionTextBox1.Location = New System.Drawing.Point(234, 99)
        Me.DescripcionTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DescripcionTextBox1.Name = "DescripcionTextBox1"
        Me.DescripcionTextBox1.Size = New System.Drawing.Size(135, 22)
        Me.DescripcionTextBox1.TabIndex = 57
        '
        'Precio_venta_mayoristaTextBox1
        '
        Me.Precio_venta_mayoristaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "precio_venta_mayorista", True))
        Me.Precio_venta_mayoristaTextBox1.Location = New System.Drawing.Point(234, 212)
        Me.Precio_venta_mayoristaTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Precio_venta_mayoristaTextBox1.Name = "Precio_venta_mayoristaTextBox1"
        Me.Precio_venta_mayoristaTextBox1.Size = New System.Drawing.Size(111, 22)
        Me.Precio_venta_mayoristaTextBox1.TabIndex = 59
        '
        'Precio_venta_minoristaTextBox1
        '
        Me.Precio_venta_minoristaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "precio_venta_minorista", True))
        Me.Precio_venta_minoristaTextBox1.Location = New System.Drawing.Point(234, 240)
        Me.Precio_venta_minoristaTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Precio_venta_minoristaTextBox1.Name = "Precio_venta_minoristaTextBox1"
        Me.Precio_venta_minoristaTextBox1.Size = New System.Drawing.Size(111, 22)
        Me.Precio_venta_minoristaTextBox1.TabIndex = 61
        '
        'btnCargarImagenAlimentos
        '
        Me.btnCargarImagenAlimentos.Location = New System.Drawing.Point(426, 207)
        Me.btnCargarImagenAlimentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCargarImagenAlimentos.Name = "btnCargarImagenAlimentos"
        Me.btnCargarImagenAlimentos.Size = New System.Drawing.Size(167, 44)
        Me.btnCargarImagenAlimentos.TabIndex = 45
        Me.btnCargarImagenAlimentos.Text = "Cargar Imagen"
        Me.btnCargarImagenAlimentos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(426, 41)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 158)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'cmbProveedoresAli
        '
        Me.cmbProveedoresAli.DataSource = Me.ProveedoresBindingSource
        Me.cmbProveedoresAli.DisplayMember = "Nombre"
        Me.cmbProveedoresAli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedoresAli.FormattingEnabled = True
        Me.cmbProveedoresAli.Location = New System.Drawing.Point(234, 270)
        Me.cmbProveedoresAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbProveedoresAli.Name = "cmbProveedoresAli"
        Me.cmbProveedoresAli.Size = New System.Drawing.Size(135, 24)
        Me.cmbProveedoresAli.TabIndex = 43
        Me.cmbProveedoresAli.ValueMember = "idProveedor"
        '
        'btnGrabarAlimentos
        '
        Me.btnGrabarAlimentos.Location = New System.Drawing.Point(122, 339)
        Me.btnGrabarAlimentos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGrabarAlimentos.Name = "btnGrabarAlimentos"
        Me.btnGrabarAlimentos.Size = New System.Drawing.Size(341, 44)
        Me.btnGrabarAlimentos.TabIndex = 42
        Me.btnGrabarAlimentos.Text = "Grabar"
        Me.btnGrabarAlimentos.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(IdMenajeLabel)
        Me.TabPage1.Controls.Add(Me.IdMenajeTextBox)
        Me.TabPage1.Controls.Add(Me.NombreTextBox)
        Me.TabPage1.Controls.Add(Me.CosteTextBox)
        Me.TabPage1.Controls.Add(Me.IVATextBox)
        Me.TabPage1.Controls.Add(Me.Stock_seguridadTextBox)
        Me.TabPage1.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage1.Controls.Add(Me.Precio_venta_mayoristaTextBox)
        Me.TabPage1.Controls.Add(Me.Precio_venta_minoristaTextBox)
        Me.TabPage1.Controls.Add(NombreLabel)
        Me.TabPage1.Controls.Add(CosteLabel)
        Me.TabPage1.Controls.Add(IVALabel)
        Me.TabPage1.Controls.Add(Stock_seguridadLabel)
        Me.TabPage1.Controls.Add(DescripcionLabel)
        Me.TabPage1.Controls.Add(Precio_venta_mayoristaLabel)
        Me.TabPage1.Controls.Add(Precio_venta_minoristaLabel)
        Me.TabPage1.Controls.Add(Me.btnImagen)
        Me.TabPage1.Controls.Add(Me.imagenMenaje)
        Me.TabPage1.Controls.Add(Me.cmbProveedores)
        Me.TabPage1.Controls.Add(Me.btnGrabarMenaje)
        Me.TabPage1.Controls.Add(IdProveedor_FK1Label)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(664, 425)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menaje"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IdMenajeTextBox
        '
        Me.IdMenajeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "idMenaje", True))
        Me.IdMenajeTextBox.Enabled = False
        Me.IdMenajeTextBox.Location = New System.Drawing.Point(267, 42)
        Me.IdMenajeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IdMenajeTextBox.Name = "IdMenajeTextBox"
        Me.IdMenajeTextBox.Size = New System.Drawing.Size(51, 22)
        Me.IdMenajeTextBox.TabIndex = 24
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(267, 70)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(135, 22)
        Me.NombreTextBox.TabIndex = 26
        '
        'CosteTextBox
        '
        Me.CosteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "Coste", True))
        Me.CosteTextBox.Location = New System.Drawing.Point(267, 129)
        Me.CosteTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CosteTextBox.Name = "CosteTextBox"
        Me.CosteTextBox.Size = New System.Drawing.Size(111, 22)
        Me.CosteTextBox.TabIndex = 28
        '
        'IVATextBox
        '
        Me.IVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "IVA", True))
        Me.IVATextBox.Location = New System.Drawing.Point(267, 156)
        Me.IVATextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IVATextBox.Name = "IVATextBox"
        Me.IVATextBox.Size = New System.Drawing.Size(111, 22)
        Me.IVATextBox.TabIndex = 30
        '
        'Stock_seguridadTextBox
        '
        Me.Stock_seguridadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "stock_seguridad", True))
        Me.Stock_seguridadTextBox.Location = New System.Drawing.Point(267, 185)
        Me.Stock_seguridadTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Stock_seguridadTextBox.Name = "Stock_seguridadTextBox"
        Me.Stock_seguridadTextBox.Size = New System.Drawing.Size(51, 22)
        Me.Stock_seguridadTextBox.TabIndex = 32
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(267, 100)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(135, 22)
        Me.DescripcionTextBox.TabIndex = 34
        '
        'Precio_venta_mayoristaTextBox
        '
        Me.Precio_venta_mayoristaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "precio_venta_mayorista", True))
        Me.Precio_venta_mayoristaTextBox.Location = New System.Drawing.Point(267, 213)
        Me.Precio_venta_mayoristaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Precio_venta_mayoristaTextBox.Name = "Precio_venta_mayoristaTextBox"
        Me.Precio_venta_mayoristaTextBox.Size = New System.Drawing.Size(111, 22)
        Me.Precio_venta_mayoristaTextBox.TabIndex = 38
        '
        'Precio_venta_minoristaTextBox
        '
        Me.Precio_venta_minoristaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenajeBindingSource, "precio_venta_minorista", True))
        Me.Precio_venta_minoristaTextBox.Location = New System.Drawing.Point(267, 241)
        Me.Precio_venta_minoristaTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Precio_venta_minoristaTextBox.Name = "Precio_venta_minoristaTextBox"
        Me.Precio_venta_minoristaTextBox.Size = New System.Drawing.Size(111, 22)
        Me.Precio_venta_minoristaTextBox.TabIndex = 40
        '
        'btnImagen
        '
        Me.btnImagen.Location = New System.Drawing.Point(459, 208)
        Me.btnImagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(167, 44)
        Me.btnImagen.TabIndex = 23
        Me.btnImagen.Text = "Cargar Imagen"
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'imagenMenaje
        '
        Me.imagenMenaje.BackgroundImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.imagenMenaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagenMenaje.Location = New System.Drawing.Point(459, 42)
        Me.imagenMenaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imagenMenaje.Name = "imagenMenaje"
        Me.imagenMenaje.Size = New System.Drawing.Size(167, 158)
        Me.imagenMenaje.TabIndex = 22
        Me.imagenMenaje.TabStop = False
        '
        'cmbProveedores
        '
        Me.cmbProveedores.DataSource = Me.ProveedoresBindingSource
        Me.cmbProveedores.DisplayMember = "Nombre"
        Me.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(267, 271)
        Me.cmbProveedores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(135, 24)
        Me.cmbProveedores.TabIndex = 21
        Me.cmbProveedores.ValueMember = "idProveedor"
        '
        'btnGrabarMenaje
        '
        Me.btnGrabarMenaje.Location = New System.Drawing.Point(155, 340)
        Me.btnGrabarMenaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGrabarMenaje.Name = "btnGrabarMenaje"
        Me.btnGrabarMenaje.Size = New System.Drawing.Size(341, 44)
        Me.btnGrabarMenaje.TabIndex = 20
        Me.btnGrabarMenaje.Text = "Grabar"
        Me.btnGrabarMenaje.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 32)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(672, 454)
        Me.TabControl1.TabIndex = 0
        '
        'FAltaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 500)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FAltaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA DE PRODUCTOS"
        CType(Me.MenajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EcoPrimeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.imagenMenaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EcoPrimeDataSet As EcoPrimeDataSet
    Friend WithEvents BebidasBindingSource As BindingSource
    Friend WithEvents BebidasTableAdapter As EcoPrimeDataSetTableAdapters.BebidasTableAdapter
    Friend WithEvents TableAdapterManager As EcoPrimeDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingSource As BindingSource
    Friend WithEvents ProveedoresTableAdapter As EcoPrimeDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenajeTableAdapter1 As EcoPrimeDataSetTableAdapters.MenajeTableAdapter
    Friend WithEvents MenajeBindingSource As BindingSource
    Friend WithEvents AlimentosBindingSource As BindingSource
    Friend WithEvents AlimentosTableAdapter As EcoPrimeDataSetTableAdapters.AlimentosTableAdapter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents IdProductoTextBox As TextBox
    Friend WithEvents NombreTextBox2 As TextBox
    Friend WithEvents CosteTextBox2 As TextBox
    Friend WithEvents IVATextBox2 As TextBox
    Friend WithEvents Stock_seguridadTextBox2 As TextBox
    Friend WithEvents DescripcionTextBox2 As TextBox
    Friend WithEvents Precio_venta_mayoristaTextBox2 As TextBox
    Friend WithEvents Precio_venta_minoristaTextBox2 As TextBox
    Friend WithEvents btnCargarImagenBebida As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmbProveedoresBebida As ComboBox
    Friend WithEvents btnGrabarBebida As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents IdAlimentoTextBox As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents CosteTextBox1 As TextBox
    Friend WithEvents IVATextBox1 As TextBox
    Friend WithEvents Stock_seguridadTextBox1 As TextBox
    Friend WithEvents DescripcionTextBox1 As TextBox
    Friend WithEvents Precio_venta_mayoristaTextBox1 As TextBox
    Friend WithEvents Precio_venta_minoristaTextBox1 As TextBox
    Friend WithEvents btnCargarImagenAlimentos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbProveedoresAli As ComboBox
    Friend WithEvents btnGrabarAlimentos As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents IdMenajeTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CosteTextBox As TextBox
    Friend WithEvents IVATextBox As TextBox
    Friend WithEvents Stock_seguridadTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Precio_venta_mayoristaTextBox As TextBox
    Friend WithEvents Precio_venta_minoristaTextBox As TextBox
    Friend WithEvents btnImagen As Button
    Friend WithEvents imagenMenaje As PictureBox
    Friend WithEvents cmbProveedores As ComboBox
    Friend WithEvents btnGrabarMenaje As Button
    Friend WithEvents TabControl1 As TabControl
End Class
