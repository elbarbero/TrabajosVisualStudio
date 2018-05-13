<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEmail
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
        Me.txtCodVuelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BDAerolineaDataSet = New P_Aerolinea_BD.BDAerolineaDataSet()
        Me.TPasajesTableAdapter = New P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TPasajesTableAdapter()
        Me.TVuelosTableAdapter1 = New P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TVuelosTableAdapter()
        Me.TTtripulacionesTableAdapter1 = New P_Aerolinea_BD.BDAerolineaDataSetTableAdapters.TTtripulacionesTableAdapter()
        CType(Me.BDAerolineaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodVuelo
        '
        Me.txtCodVuelo.Location = New System.Drawing.Point(333, 69)
        Me.txtCodVuelo.Name = "txtCodVuelo"
        Me.txtCodVuelo.Size = New System.Drawing.Size(111, 22)
        Me.txtCodVuelo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº Vuelo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(477, 67)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BDAerolineaDataSet
        '
        Me.BDAerolineaDataSet.DataSetName = "BDAerolineaDataSet"
        Me.BDAerolineaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TPasajesTableAdapter
        '
        Me.TPasajesTableAdapter.ClearBeforeFill = True
        '
        'TVuelosTableAdapter1
        '
        Me.TVuelosTableAdapter1.ClearBeforeFill = True
        '
        'TTtripulacionesTableAdapter1
        '
        Me.TTtripulacionesTableAdapter1.ClearBeforeFill = True
        '
        'FEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 450)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodVuelo)
        Me.Name = "FEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FEmail"
        CType(Me.BDAerolineaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodVuelo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BDAerolineaDataSet As BDAerolineaDataSet
    Friend WithEvents TPasajesTableAdapter As BDAerolineaDataSetTableAdapters.TPasajesTableAdapter
    Friend WithEvents TVuelosTableAdapter1 As BDAerolineaDataSetTableAdapters.TVuelosTableAdapter
    Friend WithEvents TTtripulacionesTableAdapter1 As BDAerolineaDataSetTableAdapters.TTtripulacionesTableAdapter
End Class
