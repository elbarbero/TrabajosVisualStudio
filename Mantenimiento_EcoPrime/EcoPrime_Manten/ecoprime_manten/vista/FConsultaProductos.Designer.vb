<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FConsultaProductos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.imagenMenaje = New System.Windows.Forms.PictureBox()
        Me.dgvMenaje = New System.Windows.Forms.DataGridView()
        Me.MenajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EcoPrimeDataSet = New EcoPrime_Manten.EcoPrimeDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvAlimentos = New System.Windows.Forms.DataGridView()
        Me.IdAlimentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockseguridadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventamayoristaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventaminoristaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorFK1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlimentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.imagenAlimentos = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvBebidas = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosteDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockseguridadDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenproductoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventamayoristaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventaminoristaDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorFK1DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BebidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.imagenBebidas = New System.Windows.Forms.PictureBox()
        Me.MenajeTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.MenajeTableAdapter()
        Me.AlimentosTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.AlimentosTableAdapter()
        Me.BebidasTableAdapter = New EcoPrime_Manten.EcoPrimeDataSetTableAdapters.BebidasTableAdapter()
        Me.IdMenajeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CosteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockseguridadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imagen_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventamayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioventaminoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedorFKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.imagenMenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EcoPrimeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvAlimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlimentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenAlimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvBebidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenBebidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(23, 10)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(838, 403)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.imagenMenaje)
        Me.TabPage1.Controls.Add(Me.dgvMenaje)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(830, 377)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menaje"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'imagenMenaje
        '
        Me.imagenMenaje.Location = New System.Drawing.Point(366, 68)
        Me.imagenMenaje.Margin = New System.Windows.Forms.Padding(2)
        Me.imagenMenaje.Name = "imagenMenaje"
        Me.imagenMenaje.Size = New System.Drawing.Size(89, 80)
        Me.imagenMenaje.TabIndex = 1
        Me.imagenMenaje.TabStop = False
        '
        'dgvMenaje
        '
        Me.dgvMenaje.AllowUserToAddRows = False
        Me.dgvMenaje.AllowUserToDeleteRows = False
        Me.dgvMenaje.AutoGenerateColumns = False
        Me.dgvMenaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenaje.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMenajeDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CosteDataGridViewTextBoxColumn, Me.IVADataGridViewTextBoxColumn, Me.StockseguridadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.imagen_producto, Me.PrecioventamayoristaDataGridViewTextBoxColumn, Me.PrecioventaminoristaDataGridViewTextBoxColumn, Me.IdProveedorFKDataGridViewTextBoxColumn})
        Me.dgvMenaje.DataSource = Me.MenajeBindingSource
        Me.dgvMenaje.Location = New System.Drawing.Point(53, 152)
        Me.dgvMenaje.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMenaje.Name = "dgvMenaje"
        Me.dgvMenaje.ReadOnly = True
        Me.dgvMenaje.RowTemplate.Height = 24
        Me.dgvMenaje.Size = New System.Drawing.Size(710, 213)
        Me.dgvMenaje.TabIndex = 0
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvAlimentos)
        Me.TabPage2.Controls.Add(Me.imagenAlimentos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(830, 377)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Alimentos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvAlimentos
        '
        Me.dgvAlimentos.AllowUserToAddRows = False
        Me.dgvAlimentos.AllowUserToDeleteRows = False
        Me.dgvAlimentos.AutoGenerateColumns = False
        Me.dgvAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlimentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAlimentoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn1, Me.CosteDataGridViewTextBoxColumn1, Me.IVADataGridViewTextBoxColumn1, Me.StockseguridadDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn1, Me.ImagenproductoDataGridViewTextBoxColumn, Me.PrecioventamayoristaDataGridViewTextBoxColumn1, Me.PrecioventaminoristaDataGridViewTextBoxColumn1, Me.IdProveedorFK1DataGridViewTextBoxColumn})
        Me.dgvAlimentos.DataSource = Me.AlimentosBindingSource
        Me.dgvAlimentos.Location = New System.Drawing.Point(16, 125)
        Me.dgvAlimentos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAlimentos.Name = "dgvAlimentos"
        Me.dgvAlimentos.ReadOnly = True
        Me.dgvAlimentos.RowTemplate.Height = 24
        Me.dgvAlimentos.Size = New System.Drawing.Size(637, 237)
        Me.dgvAlimentos.TabIndex = 3
        '
        'IdAlimentoDataGridViewTextBoxColumn
        '
        Me.IdAlimentoDataGridViewTextBoxColumn.DataPropertyName = "idAlimento"
        Me.IdAlimentoDataGridViewTextBoxColumn.HeaderText = "idAlimento"
        Me.IdAlimentoDataGridViewTextBoxColumn.Name = "IdAlimentoDataGridViewTextBoxColumn"
        Me.IdAlimentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        Me.NombreDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CosteDataGridViewTextBoxColumn1
        '
        Me.CosteDataGridViewTextBoxColumn1.DataPropertyName = "Coste"
        Me.CosteDataGridViewTextBoxColumn1.HeaderText = "Coste"
        Me.CosteDataGridViewTextBoxColumn1.Name = "CosteDataGridViewTextBoxColumn1"
        Me.CosteDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn1
        '
        Me.IVADataGridViewTextBoxColumn1.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn1.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn1.Name = "IVADataGridViewTextBoxColumn1"
        Me.IVADataGridViewTextBoxColumn1.ReadOnly = True
        '
        'StockseguridadDataGridViewTextBoxColumn1
        '
        Me.StockseguridadDataGridViewTextBoxColumn1.DataPropertyName = "stock_seguridad"
        Me.StockseguridadDataGridViewTextBoxColumn1.HeaderText = "stock_seguridad"
        Me.StockseguridadDataGridViewTextBoxColumn1.Name = "StockseguridadDataGridViewTextBoxColumn1"
        Me.StockseguridadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        Me.DescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ImagenproductoDataGridViewTextBoxColumn
        '
        Me.ImagenproductoDataGridViewTextBoxColumn.DataPropertyName = "imagen_producto"
        Me.ImagenproductoDataGridViewTextBoxColumn.HeaderText = "imagen_producto"
        Me.ImagenproductoDataGridViewTextBoxColumn.Name = "ImagenproductoDataGridViewTextBoxColumn"
        Me.ImagenproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioventamayoristaDataGridViewTextBoxColumn1
        '
        Me.PrecioventamayoristaDataGridViewTextBoxColumn1.DataPropertyName = "precio_venta_mayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn1.HeaderText = "precio_venta_mayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn1.Name = "PrecioventamayoristaDataGridViewTextBoxColumn1"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PrecioventaminoristaDataGridViewTextBoxColumn1
        '
        Me.PrecioventaminoristaDataGridViewTextBoxColumn1.DataPropertyName = "precio_venta_minorista"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn1.HeaderText = "precio_venta_minorista"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn1.Name = "PrecioventaminoristaDataGridViewTextBoxColumn1"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IdProveedorFK1DataGridViewTextBoxColumn
        '
        Me.IdProveedorFK1DataGridViewTextBoxColumn.DataPropertyName = "idProveedor_FK1"
        Me.IdProveedorFK1DataGridViewTextBoxColumn.HeaderText = "idProveedor_FK1"
        Me.IdProveedorFK1DataGridViewTextBoxColumn.Name = "IdProveedorFK1DataGridViewTextBoxColumn"
        Me.IdProveedorFK1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlimentosBindingSource
        '
        Me.AlimentosBindingSource.DataMember = "Alimentos"
        Me.AlimentosBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'imagenAlimentos
        '
        Me.imagenAlimentos.Location = New System.Drawing.Point(250, 27)
        Me.imagenAlimentos.Margin = New System.Windows.Forms.Padding(2)
        Me.imagenAlimentos.Name = "imagenAlimentos"
        Me.imagenAlimentos.Size = New System.Drawing.Size(89, 80)
        Me.imagenAlimentos.TabIndex = 2
        Me.imagenAlimentos.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvBebidas)
        Me.TabPage3.Controls.Add(Me.imagenBebidas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(830, 377)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bebidas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvBebidas
        '
        Me.dgvBebidas.AllowUserToAddRows = False
        Me.dgvBebidas.AllowUserToDeleteRows = False
        Me.dgvBebidas.AutoGenerateColumns = False
        Me.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBebidas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn2, Me.CosteDataGridViewTextBoxColumn2, Me.IVADataGridViewTextBoxColumn2, Me.StockseguridadDataGridViewTextBoxColumn2, Me.DescripcionDataGridViewTextBoxColumn2, Me.ImagenproductoDataGridViewTextBoxColumn1, Me.PrecioventamayoristaDataGridViewTextBoxColumn2, Me.PrecioventaminoristaDataGridViewTextBoxColumn2, Me.IdProveedorFK1DataGridViewTextBoxColumn1})
        Me.dgvBebidas.DataSource = Me.BebidasBindingSource
        Me.dgvBebidas.Location = New System.Drawing.Point(17, 145)
        Me.dgvBebidas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBebidas.Name = "dgvBebidas"
        Me.dgvBebidas.ReadOnly = True
        Me.dgvBebidas.RowTemplate.Height = 24
        Me.dgvBebidas.Size = New System.Drawing.Size(636, 219)
        Me.dgvBebidas.TabIndex = 3
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        Me.NombreDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CosteDataGridViewTextBoxColumn2
        '
        Me.CosteDataGridViewTextBoxColumn2.DataPropertyName = "Coste"
        Me.CosteDataGridViewTextBoxColumn2.HeaderText = "Coste"
        Me.CosteDataGridViewTextBoxColumn2.Name = "CosteDataGridViewTextBoxColumn2"
        Me.CosteDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'IVADataGridViewTextBoxColumn2
        '
        Me.IVADataGridViewTextBoxColumn2.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn2.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn2.Name = "IVADataGridViewTextBoxColumn2"
        Me.IVADataGridViewTextBoxColumn2.ReadOnly = True
        '
        'StockseguridadDataGridViewTextBoxColumn2
        '
        Me.StockseguridadDataGridViewTextBoxColumn2.DataPropertyName = "stock_seguridad"
        Me.StockseguridadDataGridViewTextBoxColumn2.HeaderText = "stock_seguridad"
        Me.StockseguridadDataGridViewTextBoxColumn2.Name = "StockseguridadDataGridViewTextBoxColumn2"
        Me.StockseguridadDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn2
        '
        Me.DescripcionDataGridViewTextBoxColumn2.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn2.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn2.Name = "DescripcionDataGridViewTextBoxColumn2"
        Me.DescripcionDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ImagenproductoDataGridViewTextBoxColumn1
        '
        Me.ImagenproductoDataGridViewTextBoxColumn1.DataPropertyName = "imagen_producto"
        Me.ImagenproductoDataGridViewTextBoxColumn1.HeaderText = "imagen_producto"
        Me.ImagenproductoDataGridViewTextBoxColumn1.Name = "ImagenproductoDataGridViewTextBoxColumn1"
        Me.ImagenproductoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PrecioventamayoristaDataGridViewTextBoxColumn2
        '
        Me.PrecioventamayoristaDataGridViewTextBoxColumn2.DataPropertyName = "precio_venta_mayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn2.HeaderText = "precio_venta_mayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn2.Name = "PrecioventamayoristaDataGridViewTextBoxColumn2"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'PrecioventaminoristaDataGridViewTextBoxColumn2
        '
        Me.PrecioventaminoristaDataGridViewTextBoxColumn2.DataPropertyName = "precio_venta_minorista"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn2.HeaderText = "precio_venta_minorista"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn2.Name = "PrecioventaminoristaDataGridViewTextBoxColumn2"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'IdProveedorFK1DataGridViewTextBoxColumn1
        '
        Me.IdProveedorFK1DataGridViewTextBoxColumn1.DataPropertyName = "idProveedor_FK1"
        Me.IdProveedorFK1DataGridViewTextBoxColumn1.HeaderText = "idProveedor_FK1"
        Me.IdProveedorFK1DataGridViewTextBoxColumn1.Name = "IdProveedorFK1DataGridViewTextBoxColumn1"
        Me.IdProveedorFK1DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BebidasBindingSource
        '
        Me.BebidasBindingSource.DataMember = "Bebidas"
        Me.BebidasBindingSource.DataSource = Me.EcoPrimeDataSet
        '
        'imagenBebidas
        '
        Me.imagenBebidas.Location = New System.Drawing.Point(250, 34)
        Me.imagenBebidas.Margin = New System.Windows.Forms.Padding(2)
        Me.imagenBebidas.Name = "imagenBebidas"
        Me.imagenBebidas.Size = New System.Drawing.Size(100, 96)
        Me.imagenBebidas.TabIndex = 2
        Me.imagenBebidas.TabStop = False
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
        'IdMenajeDataGridViewTextBoxColumn
        '
        Me.IdMenajeDataGridViewTextBoxColumn.DataPropertyName = "idMenaje"
        Me.IdMenajeDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdMenajeDataGridViewTextBoxColumn.Name = "IdMenajeDataGridViewTextBoxColumn"
        Me.IdMenajeDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdMenajeDataGridViewTextBoxColumn.Width = 40
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CosteDataGridViewTextBoxColumn
        '
        Me.CosteDataGridViewTextBoxColumn.DataPropertyName = "Coste"
        Me.CosteDataGridViewTextBoxColumn.HeaderText = "Coste"
        Me.CosteDataGridViewTextBoxColumn.Name = "CosteDataGridViewTextBoxColumn"
        Me.CosteDataGridViewTextBoxColumn.ReadOnly = True
        Me.CosteDataGridViewTextBoxColumn.Width = 50
        '
        'IVADataGridViewTextBoxColumn
        '
        Me.IVADataGridViewTextBoxColumn.DataPropertyName = "IVA"
        Me.IVADataGridViewTextBoxColumn.HeaderText = "IVA"
        Me.IVADataGridViewTextBoxColumn.Name = "IVADataGridViewTextBoxColumn"
        Me.IVADataGridViewTextBoxColumn.ReadOnly = True
        Me.IVADataGridViewTextBoxColumn.Width = 50
        '
        'StockseguridadDataGridViewTextBoxColumn
        '
        Me.StockseguridadDataGridViewTextBoxColumn.DataPropertyName = "stock_seguridad"
        Me.StockseguridadDataGridViewTextBoxColumn.HeaderText = "Stock Seguridad"
        Me.StockseguridadDataGridViewTextBoxColumn.Name = "StockseguridadDataGridViewTextBoxColumn"
        Me.StockseguridadDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockseguridadDataGridViewTextBoxColumn.Width = 70
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'imagen_producto
        '
        Me.imagen_producto.DataPropertyName = "imagen_producto"
        Me.imagen_producto.HeaderText = "Imagen"
        Me.imagen_producto.Name = "imagen_producto"
        Me.imagen_producto.ReadOnly = True
        Me.imagen_producto.Visible = False
        '
        'PrecioventamayoristaDataGridViewTextBoxColumn
        '
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.DataPropertyName = "precio_venta_mayorista"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.HeaderText = "Precio Venta May"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.Name = "PrecioventamayoristaDataGridViewTextBoxColumn"
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioventamayoristaDataGridViewTextBoxColumn.Width = 85
        '
        'PrecioventaminoristaDataGridViewTextBoxColumn
        '
        Me.PrecioventaminoristaDataGridViewTextBoxColumn.DataPropertyName = "precio_venta_minorista"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn.HeaderText = "Precio Venta Min"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn.Name = "PrecioventaminoristaDataGridViewTextBoxColumn"
        Me.PrecioventaminoristaDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioventaminoristaDataGridViewTextBoxColumn.Width = 85
        '
        'IdProveedorFKDataGridViewTextBoxColumn
        '
        Me.IdProveedorFKDataGridViewTextBoxColumn.DataPropertyName = "idProveedor_FK"
        Me.IdProveedorFKDataGridViewTextBoxColumn.HeaderText = "ID Proveedor"
        Me.IdProveedorFKDataGridViewTextBoxColumn.Name = "IdProveedorFKDataGridViewTextBoxColumn"
        Me.IdProveedorFKDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdProveedorFKDataGridViewTextBoxColumn.Width = 85
        '
        'FConsultaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 430)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FConsultaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSULTA DE PRODUCTOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.imagenMenaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EcoPrimeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvAlimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlimentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenAlimentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvBebidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BebidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenBebidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvMenaje As DataGridView
    Friend WithEvents EcoPrimeDataSet As EcoPrimeDataSet
    Friend WithEvents MenajeBindingSource As BindingSource
    Friend WithEvents MenajeTableAdapter As EcoPrimeDataSetTableAdapters.MenajeTableAdapter
    Friend WithEvents imagenMenaje As PictureBox
    Friend WithEvents dgvAlimentos As DataGridView
    Friend WithEvents imagenAlimentos As PictureBox
    Friend WithEvents AlimentosBindingSource As BindingSource
    Friend WithEvents AlimentosTableAdapter As EcoPrimeDataSetTableAdapters.AlimentosTableAdapter
    Friend WithEvents IdAlimentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CosteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StockseguridadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ImagenproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventamayoristaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaminoristaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorFK1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvBebidas As DataGridView
    Friend WithEvents imagenBebidas As PictureBox
    Friend WithEvents BebidasBindingSource As BindingSource
    Friend WithEvents BebidasTableAdapter As EcoPrimeDataSetTableAdapters.BebidasTableAdapter
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CosteDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents StockseguridadDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ImagenproductoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventamayoristaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaminoristaDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorFK1DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdMenajeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CosteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockseguridadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imagen_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioventamayoristaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioventaminoristaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdProveedorFKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
