<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMostrarVehiculos
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
        Me.cmbVehiculos = New System.Windows.Forms.ComboBox()
        Me.imgFotosV = New System.Windows.Forms.PictureBox()
        CType(Me.imgFotosV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbVehiculos
        '
        Me.cmbVehiculos.FormattingEnabled = True
        Me.cmbVehiculos.Location = New System.Drawing.Point(66, 48)
        Me.cmbVehiculos.Name = "cmbVehiculos"
        Me.cmbVehiculos.Size = New System.Drawing.Size(211, 21)
        Me.cmbVehiculos.TabIndex = 0
        '
        'imgFotosV
        '
        Me.imgFotosV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgFotosV.Location = New System.Drawing.Point(66, 109)
        Me.imgFotosV.Name = "imgFotosV"
        Me.imgFotosV.Size = New System.Drawing.Size(211, 147)
        Me.imgFotosV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFotosV.TabIndex = 1
        Me.imgFotosV.TabStop = False
        '
        'FMostrarVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 314)
        Me.Controls.Add(Me.imgFotosV)
        Me.Controls.Add(Me.cmbVehiculos)
        Me.Name = "FMostrarVehiculos"
        Me.Text = "FMostrarVehiculos"
        CType(Me.imgFotosV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbVehiculos As System.Windows.Forms.ComboBox
    Friend WithEvents imgFotosV As System.Windows.Forms.PictureBox
End Class
