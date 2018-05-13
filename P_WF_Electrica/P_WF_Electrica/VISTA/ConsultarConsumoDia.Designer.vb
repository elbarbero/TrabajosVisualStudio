<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarConsumoDia
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
        Me.lstComsumosDias = New System.Windows.Forms.ListView()
        Me.ColumnaDia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnaPotencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbSemana = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstComsumosDias
        '
        Me.lstComsumosDias.BackColor = System.Drawing.SystemColors.Info
        Me.lstComsumosDias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnaDia, Me.ColumnaPotencia})
        Me.lstComsumosDias.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstComsumosDias.Location = New System.Drawing.Point(22, 100)
        Me.lstComsumosDias.Name = "lstComsumosDias"
        Me.lstComsumosDias.Size = New System.Drawing.Size(204, 220)
        Me.lstComsumosDias.TabIndex = 0
        Me.lstComsumosDias.UseCompatibleStateImageBehavior = False
        Me.lstComsumosDias.View = System.Windows.Forms.View.Details
        '
        'ColumnaDia
        '
        Me.ColumnaDia.Text = "Dia"
        Me.ColumnaDia.Width = 123
        '
        'ColumnaPotencia
        '
        Me.ColumnaPotencia.Text = "Potencia"
        Me.ColumnaPotencia.Width = 157
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(105, 30)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(121, 21)
        Me.cmbMes.TabIndex = 1
        Me.cmbMes.UseWaitCursor = True
        '
        'cmbSemana
        '
        Me.cmbSemana.FormattingEnabled = True
        Me.cmbSemana.Location = New System.Drawing.Point(105, 73)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Size = New System.Drawing.Size(121, 21)
        Me.cmbSemana.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Semana"
        '
        'ConsultarConsumoDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSemana)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.lstComsumosDias)
        Me.Name = "ConsultarConsumoDia"
        Me.Text = "Consumos por Día"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstComsumosDias As System.Windows.Forms.ListView
    Friend WithEvents ColumnaDia As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnaPotencia As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSemana As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
