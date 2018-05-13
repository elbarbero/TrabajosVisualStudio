<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBajaProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim IdMenajeLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CosteLabel As System.Windows.Forms.Label
        Dim IVALabel As System.Windows.Forms.Label
        Dim Stock_seguridadLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Precio_venta_mayoristaLabel As System.Windows.Forms.Label
        Dim Precio_venta_minoristaLabel As System.Windows.Forms.Label
        Dim IdProveedor_FK1Label As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Me.tab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtProveedorMen = New System.Windows.Forms.TextBox()
        Me.btnEliminarMen = New System.Windows.Forms.Button()
        Me.btnCancelarMen = New System.Windows.Forms.Button()
        Me.cmbMenaje = New System.Windows.Forms.ComboBox()
        Me.MenajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EcoPrimeDataSet = New EcoPrime_Manten.EcoPrimeDataSet()
        Me.txtIdMen = New System.Windows.Forms.TextBox()
        Me.txtNomMen = New System.Windows.Forms.TextBox()
        Me.txtCosteMen = New System.Windows.Forms.TextBox()
        Me.txtIvaMen = New System.Windows.Forms.TextBox()
        Me.txtStockMen = New System.Windows.Forms.TextBox()
        Me.txtDescripMen = New System.Windows.Forms.TextBox()
        Me.txtPrecioMayMen = New System.Windows.Forms.TextBox()
        Me.txtPrecioMinMen = New System.Windows.Forms.TextBox()
        Me.imagenMenaje = New System.Windows.Forms.PictureBox()
        Me.btnGrabarMen = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEliminarAli = New System.Windows.Forms.Button()
        Me.btnCancelarAli = New System.Windows.Forms.Button()
        Me.cmbAlimento = New System.Windows.Forms.ComboBox()
        Me.AlimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtIdAli = New System.Windows.Forms.TextBox()
        Me.txtNombreAli = New System.Windows.Forms.TextBox()
        Me.txtCosteAli = New System.Windows.Forms.TextBox()
        Me.txtIvaAli = New System.Windows.Forms.TextBox()
        Me.txtStockAli = New System.Windows.Forms.TextBox()
        Me.txtDescripAli = New System.Windows.Forms.TextBox()
        Me.txtPrecioMayAli = New System.Windows.Forms.TextBox()
        Me.txtPrecioMinAli = New System.Windows.Forms.TextBox()
        Me.imgAli = New System.Windows.Forms.PictureBox()
        Me.btnGrabarAli = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnEliminarBeb = New System.Windows.Forms.Button()
        Me.btnCancelarBeb = New System.Windows.Forms.Button()
        Me.cmbBebidas = New System.Windows.Forms.ComboBox()
        Me.BebidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtIdBeb = New System.Windows.Forms.TextBox()
        Me.txtNombreBeb = New System.Windows.Forms.TextBox()
        Me.txtCosteBeb = New System.Windows.Forms.TextBox()
        Me.txtIvaBeb = New System.Windows.Forms.TextBox()
        Me.txtStockBeb = New System.Windows.Forms.TextBox()
        Me.txtDescripBeb = New System.Windows.Forms.TextBox()
        Me.txtPrecioMayBeb = New System.Windows.Forms.TextBox()
        Me.txtPrecioMinBeb = New System.Windows.Forms.TextBox()
        Me.imgBebidas = New System.Windows.Forms.PictureBox()
        Me.btnGrabarBeb = New System.Windows.Forms.Button()
        Me.MenajeTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.MenajeTableAdapter()
        Me.AlimentosTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.AlimentosTableAdapter()
        Me.BebidasTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.BebidasTableAdapter()
        Me.ProveedoresTableAdapter1 = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.ProveedoresTableAdapter()
        Me.txtProveedorAli = New System.Windows.Forms.TextBox()
        Me.txtProveedorBeb = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        IdMenajeLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CosteLabel = New System.Windows.Forms.Label()
        IVALabel = New System.Windows.Forms.Label()
        Stock_seguridadLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Precio_venta_mayoristaLabel = New System.Windows.Forms.Label()
        Precio_venta_minoristaLabel = New System.Windows.Forms.Label()
        IdProveedor_FK1Label = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Me.tab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MenajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EcoPrimeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenMenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.AlimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgAli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBebidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(65, 30)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 17)
        Label1.TabIndex = 44
        Label1.Text = "Producto:"
        '
        'IdMenajeLabel
        '
        IdMenajeLabel.AutoSize = True
        IdMenajeLabel.Location = New System.Drawing.Point(65, 62)
        IdMenajeLabel.Name = "IdMenajeLabel"
        IdMenajeLabel.Size = New System.Drawing.Size(89, 17)
        IdMenajeLabel.TabIndex = 23
        IdMenajeLabel.Text = "Identificador:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(65, 89)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 25
        NombreLabel.Text = "Nombre:"
        '
        'CosteLabel
        '
        CosteLabel.AutoSize = True
        CosteLabel.Location = New System.Drawing.Point(65, 148)
        CosteLabel.Name = "CosteLabel"
        CosteLabel.Size = New System.Drawing.Size(48, 17)
        CosteLabel.TabIndex = 27
        CosteLabel.Text = "Coste:"
        '
        'IVALabel
        '
        IVALabel.AutoSize = True
        IVALabel.Location = New System.Drawing.Point(65, 176)
        IVALabel.Name = "IVALabel"
        IVALabel.Size = New System.Drawing.Size(33, 17)
        IVALabel.TabIndex = 29
        IVALabel.Text = "IVA:"
        '
        'Stock_seguridadLabel
        '
        Stock_seguridadLabel.AutoSize = True
        Stock_seguridadLabel.Location = New System.Drawing.Point(65, 204)
        Stock_seguridadLabel.Name = "Stock_seguridadLabel"
        Stock_seguridadLabel.Size = New System.Drawing.Size(116, 17)
        Stock_seguridadLabel.TabIndex = 31
        Stock_seguridadLabel.Text = "Stock Seguridad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(65, 118)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(86, 17)
        DescripcionLabel.TabIndex = 33
        DescripcionLabel.Text = "Descripcion:"
        '
        'Precio_venta_mayoristaLabel
        '
        Precio_venta_mayoristaLabel.AutoSize = True
        Precio_venta_mayoristaLabel.Location = New System.Drawing.Point(65, 233)
        Precio_venta_mayoristaLabel.Name = "Precio_venta_mayoristaLabel"
        Precio_venta_mayoristaLabel.Size = New System.Drawing.Size(158, 17)
        Precio_venta_mayoristaLabel.TabIndex = 37
        Precio_venta_mayoristaLabel.Text = "Precio Venta Mayorista:"
        '
        'Precio_venta_minoristaLabel
        '
        Precio_venta_minoristaLabel.AutoSize = True
        Precio_venta_minoristaLabel.Location = New System.Drawing.Point(65, 261)
        Precio_venta_minoristaLabel.Name = "Precio_venta_minoristaLabel"
        Precio_venta_minoristaLabel.Size = New System.Drawing.Size(154, 17)
        Precio_venta_minoristaLabel.TabIndex = 39
        Precio_venta_minoristaLabel.Text = "Precio Venta Minorista:"
        '
        'IdProveedor_FK1Label
        '
        IdProveedor_FK1Label.AutoSize = True
        IdProveedor_FK1Label.Location = New System.Drawing.Point(65, 290)
        IdProveedor_FK1Label.Name = "IdProveedor_FK1Label"
        IdProveedor_FK1Label.Size = New System.Drawing.Size(74, 17)
        IdProveedor_FK1Label.TabIndex = 18
        IdProveedor_FK1Label.Text = "Proveedor"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(65, 30)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(69, 17)
        Label2.TabIndex = 69
        Label2.Text = "Producto:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(65, 62)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(89, 17)
        Label3.TabIndex = 51
        Label3.Text = "Identificador:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(65, 89)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(62, 17)
        Label4.TabIndex = 53
        Label4.Text = "Nombre:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(65, 148)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(48, 17)
        Label5.TabIndex = 55
        Label5.Text = "Coste:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(65, 176)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(33, 17)
        Label6.TabIndex = 57
        Label6.Text = "IVA:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(65, 204)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(116, 17)
        Label7.TabIndex = 59
        Label7.Text = "Stock Seguridad:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(65, 118)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(86, 17)
        Label8.TabIndex = 61
        Label8.Text = "Descripcion:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(65, 233)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(158, 17)
        Label10.TabIndex = 63
        Label10.Text = "Precio Venta Mayorista:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(65, 261)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(154, 17)
        Label11.TabIndex = 65
        Label11.Text = "Precio Venta Minorista:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(65, 290)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(74, 17)
        Label12.TabIndex = 46
        Label12.Text = "Proveedor"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(65, 30)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(69, 17)
        Label9.TabIndex = 69
        Label9.Text = "Producto:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(65, 62)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(89, 17)
        Label13.TabIndex = 51
        Label13.Text = "Identificador:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(65, 89)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(62, 17)
        Label14.TabIndex = 53
        Label14.Text = "Nombre:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(65, 148)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(48, 17)
        Label15.TabIndex = 55
        Label15.Text = "Coste:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(65, 176)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(33, 17)
        Label16.TabIndex = 57
        Label16.Text = "IVA:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(65, 204)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(116, 17)
        Label17.TabIndex = 59
        Label17.Text = "Stock Seguridad:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(65, 118)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(86, 17)
        Label18.TabIndex = 61
        Label18.Text = "Descripcion:"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(65, 233)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(158, 17)
        Label19.TabIndex = 63
        Label19.Text = "Precio Venta Mayorista:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(65, 261)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(154, 17)
        Label20.TabIndex = 65
        Label20.Text = "Precio Venta Minorista:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(65, 290)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(74, 17)
        Label21.TabIndex = 46
        Label21.Text = "Proveedor"
        '
        'tab
        '
        Me.tab.Controls.Add(Me.TabPage1)
        Me.tab.Controls.Add(Me.TabPage2)
        Me.tab.Controls.Add(Me.TabPage3)
        Me.tab.Location = New System.Drawing.Point(70, 72)
        Me.tab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(672, 454)
        Me.tab.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.txtProveedorMen)
        Me.TabPage1.Controls.Add(Me.btnEliminarMen)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.btnCancelarMen)
        Me.TabPage1.Controls.Add(Me.cmbMenaje)
        Me.TabPage1.Controls.Add(IdMenajeLabel)
        Me.TabPage1.Controls.Add(Me.txtIdMen)
        Me.TabPage1.Controls.Add(NombreLabel)
        Me.TabPage1.Controls.Add(Me.txtNomMen)
        Me.TabPage1.Controls.Add(CosteLabel)
        Me.TabPage1.Controls.Add(Me.txtCosteMen)
        Me.TabPage1.Controls.Add(IVALabel)
        Me.TabPage1.Controls.Add(Me.txtIvaMen)
        Me.TabPage1.Controls.Add(Stock_seguridadLabel)
        Me.TabPage1.Controls.Add(Me.txtStockMen)
        Me.TabPage1.Controls.Add(DescripcionLabel)
        Me.TabPage1.Controls.Add(Me.txtDescripMen)
        Me.TabPage1.Controls.Add(Precio_venta_mayoristaLabel)
        Me.TabPage1.Controls.Add(Me.txtPrecioMayMen)
        Me.TabPage1.Controls.Add(Precio_venta_minoristaLabel)
        Me.TabPage1.Controls.Add(Me.txtPrecioMinMen)
        Me.TabPage1.Controls.Add(Me.imagenMenaje)
        Me.TabPage1.Controls.Add(Me.btnGrabarMen)
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
        'txtProveedorMen
        '
        Me.txtProveedorMen.Enabled = False
        Me.txtProveedorMen.Location = New System.Drawing.Point(227, 290)
        Me.txtProveedorMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProveedorMen.Name = "txtProveedorMen"
        Me.txtProveedorMen.Size = New System.Drawing.Size(120, 22)
        Me.txtProveedorMen.TabIndex = 46
        '
        'btnEliminarMen
        '
        Me.btnEliminarMen.Location = New System.Drawing.Point(155, 354)
        Me.btnEliminarMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarMen.Name = "btnEliminarMen"
        Me.btnEliminarMen.Size = New System.Drawing.Size(341, 44)
        Me.btnEliminarMen.TabIndex = 45
        Me.btnEliminarMen.Text = "Eliminar"
        Me.btnEliminarMen.UseVisualStyleBackColor = True
        '
        'btnCancelarMen
        '
        Me.btnCancelarMen.Location = New System.Drawing.Point(332, 354)
        Me.btnCancelarMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelarMen.Name = "btnCancelarMen"
        Me.btnCancelarMen.Size = New System.Drawing.Size(164, 44)
        Me.btnCancelarMen.TabIndex = 43
        Me.btnCancelarMen.Text = "Cancelar"
        Me.btnCancelarMen.UseVisualStyleBackColor = True
        '
        'cmbMenaje
        '
        Me.cmbMenaje.DataSource = Me.MenajeBindingSource
        Me.cmbMenaje.DisplayMember = "nombre"
        Me.cmbMenaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMenaje.FormattingEnabled = True
        Me.cmbMenaje.Location = New System.Drawing.Point(227, 26)
        Me.cmbMenaje.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMenaje.Name = "cmbMenaje"
        Me.cmbMenaje.Size = New System.Drawing.Size(185, 24)
        Me.cmbMenaje.TabIndex = 41
        Me.cmbMenaje.ValueMember = "idMenaje"
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
        'txtIdMen
        '
        Me.txtIdMen.Enabled = False
        Me.txtIdMen.Location = New System.Drawing.Point(227, 58)
        Me.txtIdMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdMen.Name = "txtIdMen"
        Me.txtIdMen.Size = New System.Drawing.Size(51, 22)
        Me.txtIdMen.TabIndex = 24
        '
        'txtNomMen
        '
        Me.txtNomMen.Enabled = False
        Me.txtNomMen.Location = New System.Drawing.Point(227, 86)
        Me.txtNomMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNomMen.Name = "txtNomMen"
        Me.txtNomMen.Size = New System.Drawing.Size(135, 22)
        Me.txtNomMen.TabIndex = 26
        '
        'txtCosteMen
        '
        Me.txtCosteMen.Enabled = False
        Me.txtCosteMen.Location = New System.Drawing.Point(227, 145)
        Me.txtCosteMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCosteMen.Name = "txtCosteMen"
        Me.txtCosteMen.Size = New System.Drawing.Size(71, 22)
        Me.txtCosteMen.TabIndex = 28
        '
        'txtIvaMen
        '
        Me.txtIvaMen.Enabled = False
        Me.txtIvaMen.Location = New System.Drawing.Point(227, 172)
        Me.txtIvaMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIvaMen.Name = "txtIvaMen"
        Me.txtIvaMen.Size = New System.Drawing.Size(51, 22)
        Me.txtIvaMen.TabIndex = 30
        '
        'txtStockMen
        '
        Me.txtStockMen.Enabled = False
        Me.txtStockMen.Location = New System.Drawing.Point(227, 201)
        Me.txtStockMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockMen.Name = "txtStockMen"
        Me.txtStockMen.Size = New System.Drawing.Size(91, 22)
        Me.txtStockMen.TabIndex = 32
        '
        'txtDescripMen
        '
        Me.txtDescripMen.Enabled = False
        Me.txtDescripMen.Location = New System.Drawing.Point(227, 116)
        Me.txtDescripMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripMen.Name = "txtDescripMen"
        Me.txtDescripMen.Size = New System.Drawing.Size(135, 22)
        Me.txtDescripMen.TabIndex = 34
        '
        'txtPrecioMayMen
        '
        Me.txtPrecioMayMen.Enabled = False
        Me.txtPrecioMayMen.Location = New System.Drawing.Point(227, 229)
        Me.txtPrecioMayMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioMayMen.Name = "txtPrecioMayMen"
        Me.txtPrecioMayMen.Size = New System.Drawing.Size(51, 22)
        Me.txtPrecioMayMen.TabIndex = 38
        '
        'txtPrecioMinMen
        '
        Me.txtPrecioMinMen.Enabled = False
        Me.txtPrecioMinMen.Location = New System.Drawing.Point(227, 257)
        Me.txtPrecioMinMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioMinMen.Name = "txtPrecioMinMen"
        Me.txtPrecioMinMen.Size = New System.Drawing.Size(51, 22)
        Me.txtPrecioMinMen.TabIndex = 40
        '
        'imagenMenaje
        '
        Me.imagenMenaje.BackgroundImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.imagenMenaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagenMenaje.InitialImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.imagenMenaje.Location = New System.Drawing.Point(459, 57)
        Me.imagenMenaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imagenMenaje.Name = "imagenMenaje"
        Me.imagenMenaje.Size = New System.Drawing.Size(167, 158)
        Me.imagenMenaje.TabIndex = 22
        Me.imagenMenaje.TabStop = False
        '
        'btnGrabarMen
        '
        Me.btnGrabarMen.Location = New System.Drawing.Point(155, 354)
        Me.btnGrabarMen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGrabarMen.Name = "btnGrabarMen"
        Me.btnGrabarMen.Size = New System.Drawing.Size(164, 44)
        Me.btnGrabarMen.TabIndex = 20
        Me.btnGrabarMen.Text = "Grabar"
        Me.btnGrabarMen.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtProveedorAli)
        Me.TabPage2.Controls.Add(Me.btnEliminarAli)
        Me.TabPage2.Controls.Add(Label2)
        Me.TabPage2.Controls.Add(Me.btnCancelarAli)
        Me.TabPage2.Controls.Add(Me.cmbAlimento)
        Me.TabPage2.Controls.Add(Label3)
        Me.TabPage2.Controls.Add(Me.txtIdAli)
        Me.TabPage2.Controls.Add(Label4)
        Me.TabPage2.Controls.Add(Me.txtNombreAli)
        Me.TabPage2.Controls.Add(Label5)
        Me.TabPage2.Controls.Add(Me.txtCosteAli)
        Me.TabPage2.Controls.Add(Label6)
        Me.TabPage2.Controls.Add(Me.txtIvaAli)
        Me.TabPage2.Controls.Add(Label7)
        Me.TabPage2.Controls.Add(Me.txtStockAli)
        Me.TabPage2.Controls.Add(Label8)
        Me.TabPage2.Controls.Add(Me.txtDescripAli)
        Me.TabPage2.Controls.Add(Label10)
        Me.TabPage2.Controls.Add(Me.txtPrecioMayAli)
        Me.TabPage2.Controls.Add(Label11)
        Me.TabPage2.Controls.Add(Me.txtPrecioMinAli)
        Me.TabPage2.Controls.Add(Me.imgAli)
        Me.TabPage2.Controls.Add(Me.btnGrabarAli)
        Me.TabPage2.Controls.Add(Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(664, 425)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Alimentos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEliminarAli
        '
        Me.btnEliminarAli.Location = New System.Drawing.Point(155, 354)
        Me.btnEliminarAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarAli.Name = "btnEliminarAli"
        Me.btnEliminarAli.Size = New System.Drawing.Size(341, 44)
        Me.btnEliminarAli.TabIndex = 70
        Me.btnEliminarAli.Text = "Eliminar"
        Me.btnEliminarAli.UseVisualStyleBackColor = True
        '
        'btnCancelarAli
        '
        Me.btnCancelarAli.Location = New System.Drawing.Point(332, 354)
        Me.btnCancelarAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelarAli.Name = "btnCancelarAli"
        Me.btnCancelarAli.Size = New System.Drawing.Size(164, 44)
        Me.btnCancelarAli.TabIndex = 68
        Me.btnCancelarAli.Text = "Cancelar"
        Me.btnCancelarAli.UseVisualStyleBackColor = True
        '
        'cmbAlimento
        '
        Me.cmbAlimento.DataSource = Me.AlimentosBindingSource
        Me.cmbAlimento.DisplayMember = "nombre"
        Me.cmbAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAlimento.FormattingEnabled = True
        Me.cmbAlimento.Location = New System.Drawing.Point(227, 26)
        Me.cmbAlimento.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAlimento.Name = "cmbAlimento"
        Me.cmbAlimento.Size = New System.Drawing.Size(185, 24)
        Me.cmbAlimento.TabIndex = 67
        Me.cmbAlimento.ValueMember = "idAlimento"
        '
        'AlimentosBindingSource
        '
        Me.AlimentosBindingSource.DataMember = "Alimentos"
        Me.AlimentosBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'txtIdAli
        '
        Me.txtIdAli.Enabled = False
        Me.txtIdAli.Location = New System.Drawing.Point(227, 58)
        Me.txtIdAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdAli.Name = "txtIdAli"
        Me.txtIdAli.Size = New System.Drawing.Size(51, 22)
        Me.txtIdAli.TabIndex = 52
        '
        'txtNombreAli
        '
        Me.txtNombreAli.Location = New System.Drawing.Point(227, 86)
        Me.txtNombreAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreAli.Name = "txtNombreAli"
        Me.txtNombreAli.Size = New System.Drawing.Size(135, 22)
        Me.txtNombreAli.TabIndex = 54
        '
        'txtCosteAli
        '
        Me.txtCosteAli.Location = New System.Drawing.Point(227, 145)
        Me.txtCosteAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCosteAli.Name = "txtCosteAli"
        Me.txtCosteAli.Size = New System.Drawing.Size(71, 22)
        Me.txtCosteAli.TabIndex = 56
        '
        'txtIvaAli
        '
        Me.txtIvaAli.Location = New System.Drawing.Point(227, 172)
        Me.txtIvaAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIvaAli.Name = "txtIvaAli"
        Me.txtIvaAli.Size = New System.Drawing.Size(51, 22)
        Me.txtIvaAli.TabIndex = 58
        '
        'txtStockAli
        '
        Me.txtStockAli.Location = New System.Drawing.Point(227, 201)
        Me.txtStockAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockAli.Name = "txtStockAli"
        Me.txtStockAli.Size = New System.Drawing.Size(91, 22)
        Me.txtStockAli.TabIndex = 60
        '
        'txtDescripAli
        '
        Me.txtDescripAli.Location = New System.Drawing.Point(227, 116)
        Me.txtDescripAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripAli.Name = "txtDescripAli"
        Me.txtDescripAli.Size = New System.Drawing.Size(135, 22)
        Me.txtDescripAli.TabIndex = 62
        '
        'txtPrecioMayAli
        '
        Me.txtPrecioMayAli.Location = New System.Drawing.Point(227, 229)
        Me.txtPrecioMayAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioMayAli.Name = "txtPrecioMayAli"
        Me.txtPrecioMayAli.Size = New System.Drawing.Size(51, 22)
        Me.txtPrecioMayAli.TabIndex = 64
        '
        'txtPrecioMinAli
        '
        Me.txtPrecioMinAli.Location = New System.Drawing.Point(227, 257)
        Me.txtPrecioMinAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioMinAli.Name = "txtPrecioMinAli"
        Me.txtPrecioMinAli.Size = New System.Drawing.Size(51, 22)
        Me.txtPrecioMinAli.TabIndex = 66
        '
        'imgAli
        '
        Me.imgAli.BackgroundImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.imgAli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgAli.Location = New System.Drawing.Point(459, 57)
        Me.imgAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imgAli.Name = "imgAli"
        Me.imgAli.Size = New System.Drawing.Size(167, 158)
        Me.imgAli.TabIndex = 49
        Me.imgAli.TabStop = False
        '
        'btnGrabarAli
        '
        Me.btnGrabarAli.Location = New System.Drawing.Point(155, 354)
        Me.btnGrabarAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGrabarAli.Name = "btnGrabarAli"
        Me.btnGrabarAli.Size = New System.Drawing.Size(164, 44)
        Me.btnGrabarAli.TabIndex = 47
        Me.btnGrabarAli.Text = "Grabar"
        Me.btnGrabarAli.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtProveedorBeb)
        Me.TabPage3.Controls.Add(Me.btnEliminarBeb)
        Me.TabPage3.Controls.Add(Label9)
        Me.TabPage3.Controls.Add(Me.btnCancelarBeb)
        Me.TabPage3.Controls.Add(Me.cmbBebidas)
        Me.TabPage3.Controls.Add(Label13)
        Me.TabPage3.Controls.Add(Me.txtIdBeb)
        Me.TabPage3.Controls.Add(Label14)
        Me.TabPage3.Controls.Add(Me.txtNombreBeb)
        Me.TabPage3.Controls.Add(Label15)
        Me.TabPage3.Controls.Add(Me.txtCosteBeb)
        Me.TabPage3.Controls.Add(Label16)
        Me.TabPage3.Controls.Add(Me.txtIvaBeb)
        Me.TabPage3.Controls.Add(Label17)
        Me.TabPage3.Controls.Add(Me.txtStockBeb)
        Me.TabPage3.Controls.Add(Label18)
        Me.TabPage3.Controls.Add(Me.txtDescripBeb)
        Me.TabPage3.Controls.Add(Label19)
        Me.TabPage3.Controls.Add(Me.txtPrecioMayBeb)
        Me.TabPage3.Controls.Add(Label20)
        Me.TabPage3.Controls.Add(Me.txtPrecioMinBeb)
        Me.TabPage3.Controls.Add(Me.imgBebidas)
        Me.TabPage3.Controls.Add(Me.btnGrabarBeb)
        Me.TabPage3.Controls.Add(Label21)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(664, 425)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bebidas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnEliminarBeb
        '
        Me.btnEliminarBeb.Location = New System.Drawing.Point(155, 354)
        Me.btnEliminarBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarBeb.Name = "btnEliminarBeb"
        Me.btnEliminarBeb.Size = New System.Drawing.Size(341, 44)
        Me.btnEliminarBeb.TabIndex = 70
        Me.btnEliminarBeb.Text = "Eliminar"
        Me.btnEliminarBeb.UseVisualStyleBackColor = True
        '
        'btnCancelarBeb
        '
        Me.btnCancelarBeb.Location = New System.Drawing.Point(332, 354)
        Me.btnCancelarBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelarBeb.Name = "btnCancelarBeb"
        Me.btnCancelarBeb.Size = New System.Drawing.Size(164, 44)
        Me.btnCancelarBeb.TabIndex = 68
        Me.btnCancelarBeb.Text = "Cancelar"
        Me.btnCancelarBeb.UseVisualStyleBackColor = True
        '
        'cmbBebidas
        '
        Me.cmbBebidas.DataSource = Me.BebidasBindingSource
        Me.cmbBebidas.DisplayMember = "nombre"
        Me.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBebidas.FormattingEnabled = True
        Me.cmbBebidas.Location = New System.Drawing.Point(227, 26)
        Me.cmbBebidas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBebidas.Name = "cmbBebidas"
        Me.cmbBebidas.Size = New System.Drawing.Size(185, 24)
        Me.cmbBebidas.TabIndex = 67
        Me.cmbBebidas.ValueMember = "idProducto"
        '
        'BebidasBindingSource
        '
        Me.BebidasBindingSource.DataMember = "Bebidas"
        Me.BebidasBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'txtIdBeb
        '
        Me.txtIdBeb.Enabled = False
        Me.txtIdBeb.Location = New System.Drawing.Point(227, 58)
        Me.txtIdBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIdBeb.Name = "txtIdBeb"
        Me.txtIdBeb.Size = New System.Drawing.Size(51, 22)
        Me.txtIdBeb.TabIndex = 52
        '
        'txtNombreBeb
        '
        Me.txtNombreBeb.Location = New System.Drawing.Point(227, 86)
        Me.txtNombreBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreBeb.Name = "txtNombreBeb"
        Me.txtNombreBeb.Size = New System.Drawing.Size(135, 22)
        Me.txtNombreBeb.TabIndex = 54
        '
        'txtCosteBeb
        '
        Me.txtCosteBeb.Location = New System.Drawing.Point(227, 145)
        Me.txtCosteBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCosteBeb.Name = "txtCosteBeb"
        Me.txtCosteBeb.Size = New System.Drawing.Size(71, 22)
        Me.txtCosteBeb.TabIndex = 56
        '
        'txtIvaBeb
        '
        Me.txtIvaBeb.Location = New System.Drawing.Point(227, 172)
        Me.txtIvaBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtIvaBeb.Name = "txtIvaBeb"
        Me.txtIvaBeb.Size = New System.Drawing.Size(51, 22)
        Me.txtIvaBeb.TabIndex = 58
        '
        'txtStockBeb
        '
        Me.txtStockBeb.Location = New System.Drawing.Point(227, 201)
        Me.txtStockBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStockBeb.Name = "txtStockBeb"
        Me.txtStockBeb.Size = New System.Drawing.Size(91, 22)
        Me.txtStockBeb.TabIndex = 60
        '
        'txtDescripBeb
        '
        Me.txtDescripBeb.Location = New System.Drawing.Point(227, 116)
        Me.txtDescripBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripBeb.Name = "txtDescripBeb"
        Me.txtDescripBeb.Size = New System.Drawing.Size(135, 22)
        Me.txtDescripBeb.TabIndex = 62
        '
        'txtPrecioMayBeb
        '
        Me.txtPrecioMayBeb.Location = New System.Drawing.Point(227, 229)
        Me.txtPrecioMayBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioMayBeb.Name = "txtPrecioMayBeb"
        Me.txtPrecioMayBeb.Size = New System.Drawing.Size(51, 22)
        Me.txtPrecioMayBeb.TabIndex = 64
        '
        'txtPrecioMinBeb
        '
        Me.txtPrecioMinBeb.Location = New System.Drawing.Point(227, 257)
        Me.txtPrecioMinBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecioMinBeb.Name = "txtPrecioMinBeb"
        Me.txtPrecioMinBeb.Size = New System.Drawing.Size(51, 22)
        Me.txtPrecioMinBeb.TabIndex = 66
        '
        'imgBebidas
        '
        Me.imgBebidas.BackgroundImage = Global.EcoPrime_Manten.My.Resources.Resources.LogoEcoPrime
        Me.imgBebidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBebidas.Location = New System.Drawing.Point(459, 57)
        Me.imgBebidas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.imgBebidas.Name = "imgBebidas"
        Me.imgBebidas.Size = New System.Drawing.Size(167, 158)
        Me.imgBebidas.TabIndex = 49
        Me.imgBebidas.TabStop = False
        '
        'btnGrabarBeb
        '
        Me.btnGrabarBeb.Location = New System.Drawing.Point(155, 354)
        Me.btnGrabarBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGrabarBeb.Name = "btnGrabarBeb"
        Me.btnGrabarBeb.Size = New System.Drawing.Size(164, 44)
        Me.btnGrabarBeb.TabIndex = 47
        Me.btnGrabarBeb.Text = "Grabar"
        Me.btnGrabarBeb.UseVisualStyleBackColor = True
        '
        'MenajeTableAdapter
        '
        Me.MenajeTableAdapter.ClearBeforeFill = True
        '
        'AlimentosTableAdapter
        '
        Me.AlimentosTableAdapter.ClearBeforeFill = True
        '
        'BebidasTableAdapter
        '
        Me.BebidasTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter1
        '
        Me.ProveedoresTableAdapter1.ClearBeforeFill = True
        '
        'txtProveedorAli
        '
        Me.txtProveedorAli.Enabled = False
        Me.txtProveedorAli.Location = New System.Drawing.Point(227, 290)
        Me.txtProveedorAli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProveedorAli.Name = "txtProveedorAli"
        Me.txtProveedorAli.Size = New System.Drawing.Size(120, 22)
        Me.txtProveedorAli.TabIndex = 71
        '
        'txtProveedorBeb
        '
        Me.txtProveedorBeb.Enabled = False
        Me.txtProveedorBeb.Location = New System.Drawing.Point(227, 290)
        Me.txtProveedorBeb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProveedorBeb.Name = "txtProveedorBeb"
        Me.txtProveedorBeb.Size = New System.Drawing.Size(120, 22)
        Me.txtProveedorBeb.TabIndex = 71
        '
        'FBajaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 599)
        Me.Controls.Add(Me.tab)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FBajaProductos"
        Me.Text = "BAJA DE PRODUCTOS"
        Me.tab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.MenajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EcoPrimeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenMenaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AlimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgAli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBebidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnEliminarMen As Button
    Friend WithEvents btnCancelarMen As Button
    Friend WithEvents cmbMenaje As ComboBox
    Friend WithEvents txtIdMen As TextBox
    Friend WithEvents txtNomMen As TextBox
    Friend WithEvents txtCosteMen As TextBox
    Friend WithEvents txtIvaMen As TextBox
    Friend WithEvents txtStockMen As TextBox
    Friend WithEvents txtDescripMen As TextBox
    Friend WithEvents txtPrecioMayMen As TextBox
    Friend WithEvents txtPrecioMinMen As TextBox
    Friend WithEvents imagenMenaje As PictureBox
    Friend WithEvents btnGrabarMen As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnEliminarAli As Button
    Friend WithEvents btnCancelarAli As Button
    Friend WithEvents cmbAlimento As ComboBox
    Friend WithEvents txtIdAli As TextBox
    Friend WithEvents txtNombreAli As TextBox
    Friend WithEvents txtCosteAli As TextBox
    Friend WithEvents txtIvaAli As TextBox
    Friend WithEvents txtStockAli As TextBox
    Friend WithEvents txtDescripAli As TextBox
    Friend WithEvents txtPrecioMayAli As TextBox
    Friend WithEvents txtPrecioMinAli As TextBox
    Friend WithEvents imgAli As PictureBox
    Friend WithEvents btnGrabarAli As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnEliminarBeb As Button
    Friend WithEvents btnCancelarBeb As Button
    Friend WithEvents cmbBebidas As ComboBox
    Friend WithEvents txtIdBeb As TextBox
    Friend WithEvents txtNombreBeb As TextBox
    Friend WithEvents txtCosteBeb As TextBox
    Friend WithEvents txtIvaBeb As TextBox
    Friend WithEvents txtStockBeb As TextBox
    Friend WithEvents txtDescripBeb As TextBox
    Friend WithEvents txtPrecioMayBeb As TextBox
    Friend WithEvents txtPrecioMinBeb As TextBox
    Friend WithEvents imgBebidas As PictureBox
    Friend WithEvents btnGrabarBeb As Button
    Friend WithEvents EcoPrimeDataSet As EcoPrimeDataSet
    Friend WithEvents MenajeBindingSource As BindingSource
    Friend WithEvents MenajeTableAdapter As EcoPrimeDataSetTableAdapters.MenajeTableAdapter
    Friend WithEvents AlimentosBindingSource As BindingSource
    Friend WithEvents AlimentosTableAdapter As EcoPrimeDataSetTableAdapters.AlimentosTableAdapter
    Friend WithEvents BebidasBindingSource As BindingSource
    Friend WithEvents BebidasTableAdapter As EcoPrimeDataSetTableAdapters.BebidasTableAdapter
    Friend WithEvents txtProveedorMen As TextBox
    Friend WithEvents ProveedoresTableAdapter1 As EcoPrimeDataSetTableAdapters.ProveedoresTableAdapter
    Friend WithEvents txtProveedorAli As TextBox
    Friend WithEvents txtProveedorBeb As TextBox
End Class
