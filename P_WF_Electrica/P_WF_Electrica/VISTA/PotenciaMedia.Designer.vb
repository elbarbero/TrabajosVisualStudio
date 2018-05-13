<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PotenciaMedia
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
        Me.cmbMeses = New System.Windows.Forms.ComboBox()
        Me.cmbDias = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelMediaXMes = New System.Windows.Forms.Label()
        Me.labelMediaXDia = New System.Windows.Forms.Label()
        Me.labelMediaTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(85, 97)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(121, 21)
        Me.cmbMeses.TabIndex = 0
        '
        'cmbDias
        '
        Me.cmbDias.FormattingEnabled = True
        Me.cmbDias.Location = New System.Drawing.Point(392, 97)
        Me.cmbDias.Name = "cmbDias"
        Me.cmbDias.Size = New System.Drawing.Size(121, 21)
        Me.cmbDias.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Por Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(392, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Por día de la semana"
        '
        'labelMediaXMes
        '
        Me.labelMediaXMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelMediaXMes.Location = New System.Drawing.Point(85, 171)
        Me.labelMediaXMes.Name = "labelMediaXMes"
        Me.labelMediaXMes.Size = New System.Drawing.Size(121, 63)
        Me.labelMediaXMes.TabIndex = 4
        '
        'labelMediaXDia
        '
        Me.labelMediaXDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.labelMediaXDia.Location = New System.Drawing.Point(392, 171)
        Me.labelMediaXDia.Name = "labelMediaXDia"
        Me.labelMediaXDia.Size = New System.Drawing.Size(121, 63)
        Me.labelMediaXDia.TabIndex = 5
        '
        'labelMediaTotal
        '
        Me.labelMediaTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.labelMediaTotal.Location = New System.Drawing.Point(249, 171)
        Me.labelMediaTotal.Name = "labelMediaTotal"
        Me.labelMediaTotal.Size = New System.Drawing.Size(121, 63)
        Me.labelMediaTotal.TabIndex = 6
        '
        'PotenciaMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 437)
        Me.Controls.Add(Me.labelMediaTotal)
        Me.Controls.Add(Me.labelMediaXDia)
        Me.Controls.Add(Me.labelMediaXMes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDias)
        Me.Controls.Add(Me.cmbMeses)
        Me.Name = "PotenciaMedia"
        Me.Text = "Potencia Media Semanal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMeses As ComboBox
    Friend WithEvents cmbDias As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelMediaXMes As Label
    Friend WithEvents labelMediaXDia As Label
    Friend WithEvents labelMediaTotal As Label
End Class
