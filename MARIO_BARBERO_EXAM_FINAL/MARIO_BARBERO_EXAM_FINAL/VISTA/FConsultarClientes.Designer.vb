<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultarClientes
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
        Me.lstCliente = New System.Windows.Forms.ListView()
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Apellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lstCliente
        '
        Me.lstCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nombre, Me.Apellidos, Me.Telefono, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstCliente.Location = New System.Drawing.Point(51, 39)
        Me.lstCliente.Name = "lstCliente"
        Me.lstCliente.Size = New System.Drawing.Size(529, 217)
        Me.lstCliente.TabIndex = 0
        Me.lstCliente.UseCompatibleStateImageBehavior = False
        Me.lstCliente.View = System.Windows.Forms.View.Details
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        '
        'Apellidos
        '
        Me.Apellidos.Text = "Apellidos"
        '
        'Telefono
        '
        Me.Telefono.Text = "Telefono"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Num Vehiculos"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Última compra"
        '
        'FConsultarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 329)
        Me.Controls.Add(Me.lstCliente)
        Me.Name = "FConsultarClientes"
        Me.Text = "FConsultarClientes"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCliente As System.Windows.Forms.ListView
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Apellidos As System.Windows.Forms.ColumnHeader
    Friend WithEvents Telefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
