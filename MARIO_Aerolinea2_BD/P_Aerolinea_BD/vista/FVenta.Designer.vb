<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FVenta
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
        Me.BDAerolineaDataSet = New P_Aerolinea_BD.BDAerolineaDataSet()
        Me.TVuelosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TVuelosTableAdapter = New P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TVuelosTableAdapter()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.etiqueta = New System.Windows.Forms.Label()
        Me.panelDNI = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TableAdapterManager()
        Me.panelClases = New System.Windows.Forms.Panel()
        Me.btnAceptarClase = New System.Windows.Forms.Button()
        Me.cmbClases = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPasajesTableAdapter1 = New P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TPasajesTableAdapter()
        CType(Me.BDAerolineaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TVuelosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDNI.SuspendLayout()
        Me.panelClases.SuspendLayout()
        Me.SuspendLayout()
        '
        'BDAerolineaDataSet
        '
        Me.BDAerolineaDataSet.DataSetName = "BDAerolineaDataSet"
        Me.BDAerolineaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TVuelosBindingSource
        '
        Me.TVuelosBindingSource.DataMember = "TVuelos"
        Me.TVuelosBindingSource.DataSource = Me.BDAerolineaDataSet
        '
        'TVuelosTableAdapter
        '
        Me.TVuelosTableAdapter.ClearBeforeFill = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(274, 51)
        Me.txtFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(108, 20)
        Me.txtFecha.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(400, 51)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 19)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(110, 88)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(458, 151)
        Me.DataGridView1.TabIndex = 5
        '
        'etiqueta
        '
        Me.etiqueta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.etiqueta.Location = New System.Drawing.Point(244, 289)
        Me.etiqueta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.Size = New System.Drawing.Size(245, 67)
        Me.etiqueta.TabIndex = 6
        Me.etiqueta.Text = "Label2"
        '
        'panelDNI
        '
        Me.panelDNI.Controls.Add(Me.btnAceptar)
        Me.panelDNI.Controls.Add(Me.txtDni)
        Me.panelDNI.Controls.Add(Me.Label2)
        Me.panelDNI.Location = New System.Drawing.Point(178, 105)
        Me.panelDNI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelDNI.Name = "panelDNI"
        Me.panelDNI.Size = New System.Drawing.Size(312, 106)
        Me.panelDNI.TabIndex = 7
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(109, 74)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(56, 19)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(69, 39)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(166, 20)
        Me.txtDni.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Introduce tu DNI"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TAvionesTableAdapter = Nothing
        Me.TableAdapterManager.TPasajerosTableAdapter = Nothing
        Me.TableAdapterManager.TPasajesTableAdapter = Nothing
        Me.TableAdapterManager.TPersonalTableAdapter = Nothing
        Me.TableAdapterManager.TTtripulacionesTableAdapter = Nothing
        Me.TableAdapterManager.TVuelosTableAdapter = Me.TVuelosTableAdapter
        Me.TableAdapterManager.UpdateOrder = P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'panelClases
        '
        Me.panelClases.Controls.Add(Me.btnAceptarClase)
        Me.panelClases.Controls.Add(Me.cmbClases)
        Me.panelClases.Controls.Add(Me.Label3)
        Me.panelClases.Location = New System.Drawing.Point(91, 95)
        Me.panelClases.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelClases.Name = "panelClases"
        Me.panelClases.Size = New System.Drawing.Size(486, 125)
        Me.panelClases.TabIndex = 8
        '
        'btnAceptarClase
        '
        Me.btnAceptarClase.Location = New System.Drawing.Point(207, 84)
        Me.btnAceptarClase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAceptarClase.Name = "btnAceptarClase"
        Me.btnAceptarClase.Size = New System.Drawing.Size(56, 19)
        Me.btnAceptarClase.TabIndex = 2
        Me.btnAceptarClase.Text = "Aceptar"
        Me.btnAceptarClase.UseVisualStyleBackColor = True
        '
        'cmbClases
        '
        Me.cmbClases.FormattingEnabled = True
        Me.cmbClases.Location = New System.Drawing.Point(183, 38)
        Me.cmbClases.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbClases.Name = "cmbClases"
        Me.cmbClases.Size = New System.Drawing.Size(92, 21)
        Me.cmbClases.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Elegir Clase"
        '
        'TPasajesTableAdapter1
        '
        Me.TPasajesTableAdapter1.ClearBeforeFill = True
        '
        'FVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 496)
        Me.Controls.Add(Me.panelClases)
        Me.Controls.Add(Me.panelDNI)
        Me.Controls.Add(Me.etiqueta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "FVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta de Pasajes"
        CType(Me.BDAerolineaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TVuelosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDNI.ResumeLayout(False)
        Me.panelDNI.PerformLayout()
        Me.panelClases.ResumeLayout(False)
        Me.panelClases.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDAerolineaDataSet As BDAerolineaDataSet
    Friend WithEvents TVuelosBindingSource As BindingSource
    Friend WithEvents TVuelosTableAdapter As BDAerolineaDataSetTableAdapters.TVuelosTableAdapter
    Friend WithEvents TVuelosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents etiqueta As Label
    Friend WithEvents panelDNI As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableAdapterManager As BDAerolineaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents panelClases As Panel
    Friend WithEvents btnAceptarClase As Button
    Friend WithEvents cmbClases As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TPasajesTableAdapter1 As P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TPasajesTableAdapter
End Class
