<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Id_FamiliaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Id_ProveedorLabel As System.Windows.Forms.Label
        Dim DescuentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BDEjemplo2018DataSet = New P_EjemploBD.BDEjemplo2018DataSet()
        Me.TableFamilias1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableFamilias1TableAdapter = New P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableFamilias1TableAdapter()
        Me.TableAdapterManager = New P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableAdapterManager()
        Me.TableFamilias1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableFamilias1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Id_FamiliaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.DescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TableProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableProveedorTableAdapter = New P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableProveedorTableAdapter()
        Id_FamiliaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Id_ProveedorLabel = New System.Windows.Forms.Label()
        DescuentoLabel = New System.Windows.Forms.Label()
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableFamilias1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableFamilias1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableFamilias1BindingNavigator.SuspendLayout()
        CType(Me.TableProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_FamiliaLabel
        '
        Id_FamiliaLabel.AutoSize = True
        Id_FamiliaLabel.Location = New System.Drawing.Point(44, 72)
        Id_FamiliaLabel.Name = "Id_FamiliaLabel"
        Id_FamiliaLabel.Size = New System.Drawing.Size(53, 13)
        Id_FamiliaLabel.TabIndex = 1
        Id_FamiliaLabel.Text = "id Familia:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(44, 98)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(44, 124)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(70, 13)
        Id_ProveedorLabel.TabIndex = 5
        Id_ProveedorLabel.Text = "id Proveedor:"
        '
        'DescuentoLabel
        '
        DescuentoLabel.AutoSize = True
        DescuentoLabel.Location = New System.Drawing.Point(44, 150)
        DescuentoLabel.Name = "DescuentoLabel"
        DescuentoLabel.Size = New System.Drawing.Size(60, 13)
        DescuentoLabel.TabIndex = 7
        DescuentoLabel.Text = "descuento:"
        '
        'BDEjemplo2018DataSet
        '
        Me.BDEjemplo2018DataSet.DataSetName = "BDEjemplo2018DataSet"
        Me.BDEjemplo2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableFamilias1BindingSource
        '
        Me.TableFamilias1BindingSource.DataMember = "TableFamilias1"
        Me.TableFamilias1BindingSource.DataSource = Me.BDEjemplo2018DataSet
        '
        'TableFamilias1TableAdapter
        '
        Me.TableFamilias1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableFamilias1TableAdapter = Me.TableFamilias1TableAdapter
        Me.TableAdapterManager.UpdateOrder = P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableFamilias1BindingNavigator
        '
        Me.TableFamilias1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TableFamilias1BindingNavigator.BindingSource = Me.TableFamilias1BindingSource
        Me.TableFamilias1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableFamilias1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TableFamilias1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TableFamilias1BindingNavigatorSaveItem})
        Me.TableFamilias1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TableFamilias1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableFamilias1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableFamilias1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableFamilias1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableFamilias1BindingNavigator.Name = "TableFamilias1BindingNavigator"
        Me.TableFamilias1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableFamilias1BindingNavigator.Size = New System.Drawing.Size(418, 25)
        Me.TableFamilias1BindingNavigator.TabIndex = 0
        Me.TableFamilias1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TableFamilias1BindingNavigatorSaveItem
        '
        Me.TableFamilias1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TableFamilias1BindingNavigatorSaveItem.Image = CType(resources.GetObject("TableFamilias1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TableFamilias1BindingNavigatorSaveItem.Name = "TableFamilias1BindingNavigatorSaveItem"
        Me.TableFamilias1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TableFamilias1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Id_FamiliaTextBox
        '
        Me.Id_FamiliaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamilias1BindingSource, "id_Familia", True))
        Me.Id_FamiliaTextBox.Location = New System.Drawing.Point(120, 69)
        Me.Id_FamiliaTextBox.Name = "Id_FamiliaTextBox"
        Me.Id_FamiliaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_FamiliaTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamilias1BindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(120, 95)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(211, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamilias1BindingSource, "descuento", True))
        Me.DescuentoTextBox.Location = New System.Drawing.Point(120, 147)
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescuentoTextBox.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TableFamilias1BindingSource, "id_Proveedor", True))
        Me.ComboBox1.DataSource = Me.TableProveedorBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(120, 120)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "id_Proveedor"
        '
        'TableProveedorBindingSource
        '
        Me.TableProveedorBindingSource.DataMember = "TableProveedor"
        Me.TableProveedorBindingSource.DataSource = Me.BDEjemplo2018DataSet
        '
        'TableProveedorTableAdapter
        '
        Me.TableProveedorTableAdapter.ClearBeforeFill = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 298)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Id_FamiliaLabel)
        Me.Controls.Add(Me.Id_FamiliaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Id_ProveedorLabel)
        Me.Controls.Add(DescuentoLabel)
        Me.Controls.Add(Me.DescuentoTextBox)
        Me.Controls.Add(Me.TableFamilias1BindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Mantenimiento Datos Familias"
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableFamilias1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableFamilias1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableFamilias1BindingNavigator.ResumeLayout(False)
        Me.TableFamilias1BindingNavigator.PerformLayout()
        CType(Me.TableProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDEjemplo2018DataSet As P_EjemploBD.BDEjemplo2018DataSet
    Friend WithEvents TableFamilias1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableFamilias1TableAdapter As P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableFamilias1TableAdapter
    Friend WithEvents TableAdapterManager As P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableFamilias1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableFamilias1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_FamiliaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescuentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TableProveedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableProveedorTableAdapter As P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableProveedorTableAdapter
End Class
