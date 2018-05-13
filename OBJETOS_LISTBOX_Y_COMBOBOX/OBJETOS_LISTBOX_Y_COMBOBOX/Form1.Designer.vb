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
        Me.lstValores = New System.Windows.Forms.ListBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.rbtExtendida = New System.Windows.Forms.RadioButton()
        Me.rbtMultiple = New System.Windows.Forms.RadioButton()
        Me.rbtUno = New System.Windows.Forms.RadioButton()
        Me.chkOrdenar = New System.Windows.Forms.CheckBox()
        Me.chkColumnas = New System.Windows.Forms.CheckBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lstTraspaso = New System.Windows.Forms.ListBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnTraspasar = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSelecCod = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstValores
        '
        Me.lstValores.FormattingEnabled = True
        Me.lstValores.Items.AddRange(New Object() {"Coche", "Silla", "Almohada", "Libro", "Mesa comedor", "Monitor", "Radio", "Teclado"})
        Me.lstValores.Location = New System.Drawing.Point(33, 40)
        Me.lstValores.Name = "lstValores"
        Me.lstValores.Size = New System.Drawing.Size(120, 121)
        Me.lstValores.TabIndex = 0
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.rbtExtendida)
        Me.GroupBox.Controls.Add(Me.rbtMultiple)
        Me.GroupBox.Controls.Add(Me.rbtUno)
        Me.GroupBox.Location = New System.Drawing.Point(213, 49)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(112, 126)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Tipo de Seleccion"
        '
        'rbtExtendida
        '
        Me.rbtExtendida.AutoSize = True
        Me.rbtExtendida.Location = New System.Drawing.Point(6, 95)
        Me.rbtExtendida.Name = "rbtExtendida"
        Me.rbtExtendida.Size = New System.Drawing.Size(72, 17)
        Me.rbtExtendida.TabIndex = 6
        Me.rbtExtendida.TabStop = True
        Me.rbtExtendida.Text = "Extendida"
        Me.rbtExtendida.UseVisualStyleBackColor = True
        '
        'rbtMultiple
        '
        Me.rbtMultiple.AutoSize = True
        Me.rbtMultiple.Location = New System.Drawing.Point(6, 55)
        Me.rbtMultiple.Name = "rbtMultiple"
        Me.rbtMultiple.Size = New System.Drawing.Size(61, 17)
        Me.rbtMultiple.TabIndex = 5
        Me.rbtMultiple.TabStop = True
        Me.rbtMultiple.Text = "Multiple"
        Me.rbtMultiple.UseVisualStyleBackColor = True
        '
        'rbtUno
        '
        Me.rbtUno.AutoSize = True
        Me.rbtUno.Location = New System.Drawing.Point(6, 19)
        Me.rbtUno.Name = "rbtUno"
        Me.rbtUno.Size = New System.Drawing.Size(45, 17)
        Me.rbtUno.TabIndex = 4
        Me.rbtUno.TabStop = True
        Me.rbtUno.Text = "Uno"
        Me.rbtUno.UseVisualStyleBackColor = True
        '
        'chkOrdenar
        '
        Me.chkOrdenar.AutoSize = True
        Me.chkOrdenar.Location = New System.Drawing.Point(33, 185)
        Me.chkOrdenar.Name = "chkOrdenar"
        Me.chkOrdenar.Size = New System.Drawing.Size(64, 17)
        Me.chkOrdenar.TabIndex = 2
        Me.chkOrdenar.Text = "Ordenar"
        Me.chkOrdenar.UseVisualStyleBackColor = True
        '
        'chkColumnas
        '
        Me.chkColumnas.AutoSize = True
        Me.chkColumnas.Location = New System.Drawing.Point(33, 222)
        Me.chkColumnas.Name = "chkColumnas"
        Me.chkColumnas.Size = New System.Drawing.Size(116, 17)
        Me.chkColumnas.TabIndex = 3
        Me.chkColumnas.Text = "Multiples Columnas"
        Me.chkColumnas.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(33, 263)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(143, 20)
        Me.txtValor.TabIndex = 4
        '
        'lstTraspaso
        '
        Me.lstTraspaso.FormattingEnabled = True
        Me.lstTraspaso.Location = New System.Drawing.Point(380, 49)
        Me.lstTraspaso.Name = "lstTraspaso"
        Me.lstTraspaso.Size = New System.Drawing.Size(120, 134)
        Me.lstTraspaso.TabIndex = 5
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(390, 207)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnTraspasar
        '
        Me.btnTraspasar.Location = New System.Drawing.Point(390, 251)
        Me.btnTraspasar.Name = "btnTraspasar"
        Me.btnTraspasar.Size = New System.Drawing.Size(171, 23)
        Me.btnTraspasar.TabIndex = 7
        Me.btnTraspasar.Text = "Traspasar Selección"
        Me.btnTraspasar.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(33, 312)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(75, 23)
        Me.btnAnadir.TabIndex = 8
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(175, 311)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSelecCod
        '
        Me.btnSelecCod.Location = New System.Drawing.Point(351, 311)
        Me.btnSelecCod.Name = "btnSelecCod"
        Me.btnSelecCod.Size = New System.Drawing.Size(180, 23)
        Me.btnSelecCod.TabIndex = 10
        Me.btnSelecCod.Text = "Seleccionar por Código"
        Me.btnSelecCod.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 368)
        Me.Controls.Add(Me.btnSelecCod)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnTraspasar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lstTraspaso)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.chkColumnas)
        Me.Controls.Add(Me.chkOrdenar)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.lstValores)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstValores As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rbtExtendida As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMultiple As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUno As System.Windows.Forms.RadioButton
    Friend WithEvents chkOrdenar As System.Windows.Forms.CheckBox
    Friend WithEvents chkColumnas As System.Windows.Forms.CheckBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lstTraspaso As System.Windows.Forms.ListBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnTraspasar As System.Windows.Forms.Button
    Friend WithEvents btnAnadir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnSelecCod As System.Windows.Forms.Button

End Class
