<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdFamilia = New System.Windows.Forms.TextBox()
        Me.BDEjemplo2018DataSet = New P_EjemploBD.BDEjemplo2018DataSet()
        Me.TableFamilias1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableFamilias1TableAdapter = New P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableFamilias1TableAdapter()
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableFamilias1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Familia"
        '
        'txtIdFamilia
        '
        Me.txtIdFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableFamilias1BindingSource, "id_Familia", True))
        Me.txtIdFamilia.Location = New System.Drawing.Point(135, 30)
        Me.txtIdFamilia.Name = "txtIdFamilia"
        Me.txtIdFamilia.Size = New System.Drawing.Size(100, 20)
        Me.txtIdFamilia.TabIndex = 1
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 315)
        Me.Controls.Add(Me.txtIdFamilia)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.BDEjemplo2018DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableFamilias1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIdFamilia As System.Windows.Forms.TextBox
    Friend WithEvents BDEjemplo2018DataSet As P_EjemploBD.BDEjemplo2018DataSet
    Friend WithEvents TableFamilias1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableFamilias1TableAdapter As P_EjemploBD.BDEjemplo2018DataSetTableAdapters.TableFamilias1TableAdapter
End Class
