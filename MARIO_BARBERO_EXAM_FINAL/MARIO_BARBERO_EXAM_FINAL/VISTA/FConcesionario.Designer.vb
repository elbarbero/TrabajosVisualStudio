<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConcesionario
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnClienteN = New System.Windows.Forms.Button()
        Me.btnConsultarCliente = New System.Windows.Forms.Button()
        Me.btnConsultarVentas = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.MARIO_BARBERO_EXAM_FINAL.My.Resources.Resources.concesionario
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(74, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 170)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnVehiculos
        '
        Me.btnVehiculos.Location = New System.Drawing.Point(47, 228)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(123, 59)
        Me.btnVehiculos.TabIndex = 1
        Me.btnVehiculos.Text = "mostrar Vehiculos"
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'btnClienteN
        '
        Me.btnClienteN.Location = New System.Drawing.Point(176, 228)
        Me.btnClienteN.Name = "btnClienteN"
        Me.btnClienteN.Size = New System.Drawing.Size(123, 59)
        Me.btnClienteN.TabIndex = 2
        Me.btnClienteN.Text = "Cliente Nuevo"
        Me.btnClienteN.UseVisualStyleBackColor = True
        '
        'btnConsultarCliente
        '
        Me.btnConsultarCliente.Location = New System.Drawing.Point(305, 228)
        Me.btnConsultarCliente.Name = "btnConsultarCliente"
        Me.btnConsultarCliente.Size = New System.Drawing.Size(123, 59)
        Me.btnConsultarCliente.TabIndex = 3
        Me.btnConsultarCliente.Text = "Consultar Clientes"
        Me.btnConsultarCliente.UseVisualStyleBackColor = True
        '
        'btnConsultarVentas
        '
        Me.btnConsultarVentas.Location = New System.Drawing.Point(434, 228)
        Me.btnConsultarVentas.Name = "btnConsultarVentas"
        Me.btnConsultarVentas.Size = New System.Drawing.Size(123, 59)
        Me.btnConsultarVentas.TabIndex = 4
        Me.btnConsultarVentas.Text = "Consultar Ventas"
        Me.btnConsultarVentas.UseVisualStyleBackColor = True
        '
        'FConcesionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 317)
        Me.Controls.Add(Me.btnConsultarVentas)
        Me.Controls.Add(Me.btnConsultarCliente)
        Me.Controls.Add(Me.btnClienteN)
        Me.Controls.Add(Me.btnVehiculos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FConcesionario"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVehiculos As System.Windows.Forms.Button
    Friend WithEvents btnClienteN As System.Windows.Forms.Button
    Friend WithEvents btnConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents btnConsultarVentas As System.Windows.Forms.Button

End Class
