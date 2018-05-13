<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnNuevaFamilia = New System.Windows.Forms.Button()
        Me.btnLeerfilas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstProveedor = New System.Windows.Forms.ListBox()
        Me.btnCargarFamilias = New System.Windows.Forms.Button()
        Me.lstFamilias = New System.Windows.Forms.ListBox()
        Me.BDEjemplo2018DataSet = New P_EjemploBD.BDEjemplo2018DataSet()
        Me.BDEjemplo2018DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableFamiliasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableFamiliasTableAdapter = New P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableFamiliasTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDEjemplo2018DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableFamiliasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevaFamilia
        '
        Me.btnNuevaFamilia.Location = New System.Drawing.Point(140, 195)
        Me.btnNuevaFamilia.Name = "btnNuevaFamilia"
        Me.btnNuevaFamilia.Size = New System.Drawing.Size(236, 69)
        Me.btnNuevaFamilia.TabIndex = 0
        Me.btnNuevaFamilia.Text = "Grabar Familia Nuevo"
        Me.btnNuevaFamilia.UseVisualStyleBackColor = True
        '
        'btnLeerfilas
        '
        Me.btnLeerfilas.Location = New System.Drawing.Point(143, 77)
        Me.btnLeerfilas.Name = "btnLeerfilas"
        Me.btnLeerfilas.Size = New System.Drawing.Size(232, 83)
        Me.btnLeerfilas.TabIndex = 1
        Me.btnLeerfilas.Text = "Leer Filas"
        Me.btnLeerfilas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'lstProveedor
        '
        Me.lstProveedor.FormattingEnabled = True
        Me.lstProveedor.Location = New System.Drawing.Point(455, 77)
        Me.lstProveedor.Name = "lstProveedor"
        Me.lstProveedor.Size = New System.Drawing.Size(169, 173)
        Me.lstProveedor.TabIndex = 4
        '
        'btnCargarFamilias
        '
        Me.btnCargarFamilias.Location = New System.Drawing.Point(331, 297)
        Me.btnCargarFamilias.Name = "btnCargarFamilias"
        Me.btnCargarFamilias.Size = New System.Drawing.Size(169, 88)
        Me.btnCargarFamilias.TabIndex = 5
        Me.btnCargarFamilias.Text = "Cargar familias-Ver codigo familia seleccionada"
        Me.btnCargarFamilias.UseVisualStyleBackColor = True
        '
        'lstFamilias
        '
        Me.lstFamilias.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFamilias.DataSource = Me.TableFamiliasBindingSource
        Me.lstFamilias.DisplayMember = "Descripcion"
        Me.lstFamilias.FormattingEnabled = True
        Me.lstFamilias.Location = New System.Drawing.Point(124, 281)
        Me.lstFamilias.Name = "lstFamilias"
        Me.lstFamilias.Size = New System.Drawing.Size(169, 173)
        Me.lstFamilias.TabIndex = 6
        Me.lstFamilias.ValueMember = "id_Familia"
        '
        'BDEjemplo2018DataSet
        '
        Me.BDEjemplo2018DataSet.DataSetName = "BDEjemplo2018DataSet"
        Me.BDEjemplo2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BDEjemplo2018DataSetBindingSource
        '
        Me.BDEjemplo2018DataSetBindingSource.DataSource = Me.BDEjemplo2018DataSet
        Me.BDEjemplo2018DataSetBindingSource.Position = 0
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 502)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstFamilias)
        Me.Controls.Add(Me.btnCargarFamilias)
        Me.Controls.Add(Me.lstProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLeerfilas)
        Me.Controls.Add(Me.btnNuevaFamilia)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDEjemplo2018DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableFamiliasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNuevaFamilia As System.Windows.Forms.Button
    Friend WithEvents btnLeerfilas As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstProveedor As System.Windows.Forms.ListBox
    Friend WithEvents btnCargarFamilias As System.Windows.Forms.Button
    Friend WithEvents lstFamilias As System.Windows.Forms.ListBox
    Friend WithEvents BDEjemplo2018DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDEjemplo2018DataSet As P_EjemploBD.BDEjemplo2018DataSet
    Friend WithEvents TableFamiliasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableFamiliasTableAdapter As P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableFamiliasTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
