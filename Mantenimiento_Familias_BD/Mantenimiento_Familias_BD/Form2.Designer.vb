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
        Me.BDEjemplo2018DataSet = New Mantenimiento_Familias_BD.BDEjemplo2018DataSet()
        Me.TableFamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableFamiliasTableAdapter = New Mantenimiento_Familias_BD.BDEjemplo2018DataSetTableAdapters.TableFamiliasTableAdapter()
        Me.Id_FamiliaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Id_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.DescuentoTextBox = New System.Windows.Forms.TextBox()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bAtras = New System.Windows.Forms.Button()
        Me.lblPosicion = New System.Windows.Forms.Label()
        Me.bnImagen = New System.Windows.Forms.Button()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Id_FamiliaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Id_ProveedorLabel = New System.Windows.Forms.Label()
        DescuentoLabel = New System.Windows.Forms.Label()
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableFamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_FamiliaLabel
        '
        Id_FamiliaLabel.AutoSize = True
        Id_FamiliaLabel.Location = New System.Drawing.Point(160, 74)
        Id_FamiliaLabel.Name = "Id_FamiliaLabel"
        Id_FamiliaLabel.Size = New System.Drawing.Size(53, 13)
        Id_FamiliaLabel.TabIndex = 1
        Id_FamiliaLabel.Text = "id Familia:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(160, 100)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 3
        DescripcionLabel.Text = "Descripcion:"
        '
        'Id_ProveedorLabel
        '
        Id_ProveedorLabel.AutoSize = True
        Id_ProveedorLabel.Location = New System.Drawing.Point(160, 126)
        Id_ProveedorLabel.Name = "Id_ProveedorLabel"
        Id_ProveedorLabel.Size = New System.Drawing.Size(70, 13)
        Id_ProveedorLabel.TabIndex = 5
        Id_ProveedorLabel.Text = "id Proveedor:"
        '
        'DescuentoLabel
        '
        DescuentoLabel.AutoSize = True
        DescuentoLabel.Location = New System.Drawing.Point(160, 152)
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
        'TableFamiliasBindingSource
        '
        Me.TableFamiliasBindingSource.DataMember = "TableFamilias"
        Me.TableFamiliasBindingSource.DataSource = Me.BDEjemplo2018DataSet
        '
        'TableFamiliasTableAdapter
        '
        Me.TableFamiliasTableAdapter.ClearBeforeFill = True
        '
        'Id_FamiliaTextBox
        '
        Me.Id_FamiliaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamiliasBindingSource, "id_Familia", True))
        Me.Id_FamiliaTextBox.Location = New System.Drawing.Point(236, 71)
        Me.Id_FamiliaTextBox.Name = "Id_FamiliaTextBox"
        Me.Id_FamiliaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_FamiliaTextBox.TabIndex = 2
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamiliasBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(236, 97)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(197, 20)
        Me.DescripcionTextBox.TabIndex = 4
        '
        'Id_ProveedorTextBox
        '
        Me.Id_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamiliasBindingSource, "id_Proveedor", True))
        Me.Id_ProveedorTextBox.Location = New System.Drawing.Point(236, 123)
        Me.Id_ProveedorTextBox.Name = "Id_ProveedorTextBox"
        Me.Id_ProveedorTextBox.Size = New System.Drawing.Size(65, 20)
        Me.Id_ProveedorTextBox.TabIndex = 6
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamiliasBindingSource, "descuento", True))
        Me.DescuentoTextBox.Location = New System.Drawing.Point(236, 149)
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescuentoTextBox.TabIndex = 8
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(469, 38)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(175, 131)
        Me.picFoto.TabIndex = 9
        Me.picFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(231, 284)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(75, 23)
        Me.btngrabar.TabIndex = 19
        Me.btngrabar.Text = "Grabar"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(414, 286)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 18
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.Location = New System.Drawing.Point(469, 280)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(114, 30)
        Me.btnModifica.TabIndex = 17
        Me.btnModifica.Text = "Modificacion"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(293, 280)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(114, 30)
        Me.btnBaja.TabIndex = 16
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(111, 280)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(114, 30)
        Me.btnAlta.TabIndex = 15
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 40)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bAtras
        '
        Me.bAtras.Location = New System.Drawing.Point(170, 186)
        Me.bAtras.Name = "bAtras"
        Me.bAtras.Size = New System.Drawing.Size(52, 40)
        Me.bAtras.TabIndex = 13
        Me.bAtras.Text = "<<"
        Me.bAtras.UseVisualStyleBackColor = True
        '
        'lblPosicion
        '
        Me.lblPosicion.BackColor = System.Drawing.Color.Red
        Me.lblPosicion.Location = New System.Drawing.Point(249, 186)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(100, 40)
        Me.lblPosicion.TabIndex = 20
        Me.lblPosicion.Text = "Label1"
        Me.lblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnImagen
        '
        Me.bnImagen.Location = New System.Drawing.Point(502, 191)
        Me.bnImagen.Name = "bnImagen"
        Me.bnImagen.Size = New System.Drawing.Size(114, 30)
        Me.bnImagen.TabIndex = 21
        Me.bnImagen.Text = "Cargar Imagen"
        Me.bnImagen.UseVisualStyleBackColor = True
        '
        'lblProveedor
        '
        Me.lblProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblProveedor.Location = New System.Drawing.Point(308, 124)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(125, 19)
        Me.lblProveedor.TabIndex = 22
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(682, 332)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.bnImagen)
        Me.Controls.Add(Me.lblPosicion)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bAtras)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Id_FamiliaLabel)
        Me.Controls.Add(Me.Id_FamiliaTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Id_ProveedorLabel)
        Me.Controls.Add(Me.Id_ProveedorTextBox)
        Me.Controls.Add(DescuentoLabel)
        Me.Controls.Add(Me.DescuentoTextBox)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableFamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BDEjemplo2018DataSet As Mantenimiento_Familias_BD.BDEjemplo2018DataSet
    Friend WithEvents TableFamiliasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableFamiliasTableAdapter As Mantenimiento_Familias_BD.BDEjemplo2018DataSetTableAdapters.TableFamiliasTableAdapter
    Friend WithEvents Id_FamiliaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescuentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents picFoto As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnBaja As System.Windows.Forms.Button
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents bAtras As System.Windows.Forms.Button
    Friend WithEvents lblPosicion As System.Windows.Forms.Label
    Friend WithEvents bnImagen As System.Windows.Forms.Button
    Friend WithEvents lblProveedor As System.Windows.Forms.Label
End Class
