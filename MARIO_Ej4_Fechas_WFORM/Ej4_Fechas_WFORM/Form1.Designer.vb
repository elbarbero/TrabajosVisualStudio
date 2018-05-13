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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtFechaCalculada = New System.Windows.Forms.TextBox()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.CldCalendario = New System.Windows.Forms.MonthCalendar()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtNuevaFecha = New System.Windows.Forms.TextBox()
        Me.btnCalcular2 = New System.Windows.Forms.Button()
        Me.rbtRestar = New System.Windows.Forms.RadioButton()
        Me.rbtSumar = New System.Windows.Forms.RadioButton()
        Me.cmbCantidad = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtFechaActual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(27, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(734, 468)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtFechaCalculada)
        Me.TabPage1.Controls.Add(Me.btnVisualizar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnCalcular)
        Me.TabPage1.Controls.Add(Me.txtFecha)
        Me.TabPage1.Controls.Add(Me.CldCalendario)
        Me.TabPage1.Controls.Add(Me.dtpFecha)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 442)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fechas1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtFechaCalculada
        '
        Me.txtFechaCalculada.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaCalculada.Enabled = False
        Me.txtFechaCalculada.Location = New System.Drawing.Point(359, 265)
        Me.txtFechaCalculada.Name = "txtFechaCalculada"
        Me.txtFechaCalculada.Size = New System.Drawing.Size(162, 20)
        Me.txtFechaCalculada.TabIndex = 7
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Location = New System.Drawing.Point(367, 312)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(164, 57)
        Me.btnVisualizar.TabIndex = 6
        Me.btnVisualizar.Text = "Visualizar Fechas con otros Formatos"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha Calculada"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(363, 124)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(141, 66)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(358, 62)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(186, 20)
        Me.txtFecha.TabIndex = 2
        '
        'CldCalendario
        '
        Me.CldCalendario.Location = New System.Drawing.Point(35, 96)
        Me.CldCalendario.Name = "CldCalendario"
        Me.CldCalendario.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(34, 50)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(199, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNuevaFecha)
        Me.TabPage2.Controls.Add(Me.btnCalcular2)
        Me.TabPage2.Controls.Add(Me.rbtRestar)
        Me.TabPage2.Controls.Add(Me.rbtSumar)
        Me.TabPage2.Controls.Add(Me.cmbCantidad)
        Me.TabPage2.Controls.Add(Me.txtCantidad)
        Me.TabPage2.Controls.Add(Me.txtFechaActual)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(726, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fechas2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtNuevaFecha
        '
        Me.txtNuevaFecha.Enabled = False
        Me.txtNuevaFecha.Location = New System.Drawing.Point(159, 207)
        Me.txtNuevaFecha.Name = "txtNuevaFecha"
        Me.txtNuevaFecha.Size = New System.Drawing.Size(130, 20)
        Me.txtNuevaFecha.TabIndex = 9
        '
        'btnCalcular2
        '
        Me.btnCalcular2.Location = New System.Drawing.Point(395, 98)
        Me.btnCalcular2.Name = "btnCalcular2"
        Me.btnCalcular2.Size = New System.Drawing.Size(130, 74)
        Me.btnCalcular2.TabIndex = 8
        Me.btnCalcular2.Text = "Calcular"
        Me.btnCalcular2.UseVisualStyleBackColor = True
        '
        'rbtRestar
        '
        Me.rbtRestar.AutoSize = True
        Me.rbtRestar.Location = New System.Drawing.Point(102, 172)
        Me.rbtRestar.Name = "rbtRestar"
        Me.rbtRestar.Size = New System.Drawing.Size(56, 17)
        Me.rbtRestar.TabIndex = 7
        Me.rbtRestar.Text = "Restar"
        Me.rbtRestar.UseVisualStyleBackColor = True
        '
        'rbtSumar
        '
        Me.rbtSumar.AutoSize = True
        Me.rbtSumar.Checked = True
        Me.rbtSumar.Location = New System.Drawing.Point(101, 137)
        Me.rbtSumar.Name = "rbtSumar"
        Me.rbtSumar.Size = New System.Drawing.Size(55, 17)
        Me.rbtSumar.TabIndex = 6
        Me.rbtSumar.TabStop = True
        Me.rbtSumar.Text = "Sumar"
        Me.rbtSumar.UseVisualStyleBackColor = True
        '
        'cmbCantidad
        '
        Me.cmbCantidad.FormattingEnabled = True
        Me.cmbCantidad.Location = New System.Drawing.Point(195, 89)
        Me.cmbCantidad.Name = "cmbCantidad"
        Me.cmbCantidad.Size = New System.Drawing.Size(74, 21)
        Me.cmbCantidad.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(110, 90)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(56, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'txtFechaActual
        '
        Me.txtFechaActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaActual.Enabled = False
        Me.txtFechaActual.Location = New System.Drawing.Point(121, 33)
        Me.txtFechaActual.Name = "txtFechaActual"
        Me.txtFechaActual.Size = New System.Drawing.Size(148, 20)
        Me.txtFechaActual.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nueva Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fecha Actual"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 492)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Calculos con Fechas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CldCalendario As MonthCalendar
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaActual As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNuevaFecha As TextBox
    Friend WithEvents btnCalcular2 As Button
    Friend WithEvents rbtRestar As RadioButton
    Friend WithEvents rbtSumar As RadioButton
    Friend WithEvents cmbCantidad As ComboBox
    Friend WithEvents txtFechaCalculada As TextBox
End Class
