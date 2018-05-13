<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Estadisticas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnInformeSemanal = New System.Windows.Forms.Button()
        Me.btnInformeTrimestral = New System.Windows.Forms.Button()
        Me.panelInformeSemanal = New System.Windows.Forms.Panel()
        Me.btnGeneralExcel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSemana = New System.Windows.Forms.ComboBox()
        Me.lstMesesEstadisticas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.panelInformeSemanal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInformeSemanal
        '
        Me.btnInformeSemanal.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeSemanal.Location = New System.Drawing.Point(284, 66)
        Me.btnInformeSemanal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInformeSemanal.Name = "btnInformeSemanal"
        Me.btnInformeSemanal.Size = New System.Drawing.Size(165, 84)
        Me.btnInformeSemanal.TabIndex = 0
        Me.btnInformeSemanal.Text = "Informe Semanal"
        Me.btnInformeSemanal.UseVisualStyleBackColor = True
        '
        'btnInformeTrimestral
        '
        Me.btnInformeTrimestral.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeTrimestral.Location = New System.Drawing.Point(284, 206)
        Me.btnInformeTrimestral.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInformeTrimestral.Name = "btnInformeTrimestral"
        Me.btnInformeTrimestral.Size = New System.Drawing.Size(165, 84)
        Me.btnInformeTrimestral.TabIndex = 1
        Me.btnInformeTrimestral.Text = "Informe Trimestral"
        Me.btnInformeTrimestral.UseVisualStyleBackColor = True
        '
        'panelInformeSemanal
        '
        Me.panelInformeSemanal.Controls.Add(Me.btnAtras)
        Me.panelInformeSemanal.Controls.Add(Me.btnGeneralExcel)
        Me.panelInformeSemanal.Controls.Add(Me.Label1)
        Me.panelInformeSemanal.Controls.Add(Me.cmbSemana)
        Me.panelInformeSemanal.Controls.Add(Me.lstMesesEstadisticas)
        Me.panelInformeSemanal.Location = New System.Drawing.Point(53, 43)
        Me.panelInformeSemanal.Name = "panelInformeSemanal"
        Me.panelInformeSemanal.Size = New System.Drawing.Size(684, 294)
        Me.panelInformeSemanal.TabIndex = 2
        Me.panelInformeSemanal.Visible = False
        '
        'btnGeneralExcel
        '
        Me.btnGeneralExcel.Location = New System.Drawing.Point(392, 177)
        Me.btnGeneralExcel.Name = "btnGeneralExcel"
        Me.btnGeneralExcel.Size = New System.Drawing.Size(175, 69)
        Me.btnGeneralExcel.TabIndex = 5
        Me.btnGeneralExcel.Text = "Generar Excel"
        Me.btnGeneralExcel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Semana"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbSemana
        '
        Me.cmbSemana.FormattingEnabled = True
        Me.cmbSemana.Location = New System.Drawing.Point(310, 41)
        Me.cmbSemana.Name = "cmbSemana"
        Me.cmbSemana.Size = New System.Drawing.Size(121, 24)
        Me.cmbSemana.TabIndex = 3
        '
        'lstMesesEstadisticas
        '
        Me.lstMesesEstadisticas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstMesesEstadisticas.Location = New System.Drawing.Point(33, 29)
        Me.lstMesesEstadisticas.Name = "lstMesesEstadisticas"
        Me.lstMesesEstadisticas.Size = New System.Drawing.Size(136, 207)
        Me.lstMesesEstadisticas.TabIndex = 2
        Me.lstMesesEstadisticas.TileSize = New System.Drawing.Size(1, 1)
        Me.lstMesesEstadisticas.UseCompatibleStateImageBehavior = False
        Me.lstMesesEstadisticas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Meses"
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(200, 178)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(175, 69)
        Me.btnAtras.TabIndex = 6
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Estadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 421)
        Me.Controls.Add(Me.panelInformeSemanal)
        Me.Controls.Add(Me.btnInformeTrimestral)
        Me.Controls.Add(Me.btnInformeSemanal)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Estadisticas"
        Me.Text = "Estadisticas"
        Me.panelInformeSemanal.ResumeLayout(False)
        Me.panelInformeSemanal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInformeSemanal As System.Windows.Forms.Button
    Friend WithEvents btnInformeTrimestral As System.Windows.Forms.Button
    Friend WithEvents panelInformeSemanal As Panel
    Friend WithEvents lstMesesEstadisticas As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbSemana As ComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnGeneralExcel As Button
    Friend WithEvents btnAtras As Button
End Class
