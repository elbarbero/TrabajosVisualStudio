<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInical
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtnAvanzado = New System.Windows.Forms.RadioButton()
        Me.rdbtnMedio = New System.Windows.Forms.RadioButton()
        Me.rdbtnBasico = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAcceso = New System.Windows.Forms.CheckBox()
        Me.chkDvd = New System.Windows.Forms.CheckBox()
        Me.chkLibro = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblImporteCurso = New System.Windows.Forms.Label()
        Me.lblImporteMaterial = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblNuAlumno = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(146, 22)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(236, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*Máximo 25 caracteres"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnAvanzado)
        Me.GroupBox1.Controls.Add(Me.rdbtnMedio)
        Me.GroupBox1.Controls.Add(Me.rdbtnBasico)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 110)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nivel del Curso"
        '
        'rdbtnAvanzado
        '
        Me.rdbtnAvanzado.AutoSize = True
        Me.rdbtnAvanzado.Location = New System.Drawing.Point(18, 72)
        Me.rdbtnAvanzado.Name = "rdbtnAvanzado"
        Me.rdbtnAvanzado.Size = New System.Drawing.Size(73, 17)
        Me.rdbtnAvanzado.TabIndex = 2
        Me.rdbtnAvanzado.TabStop = True
        Me.rdbtnAvanzado.Text = "Avanzado"
        Me.rdbtnAvanzado.UseVisualStyleBackColor = True
        '
        'rdbtnMedio
        '
        Me.rdbtnMedio.AutoSize = True
        Me.rdbtnMedio.Location = New System.Drawing.Point(18, 49)
        Me.rdbtnMedio.Name = "rdbtnMedio"
        Me.rdbtnMedio.Size = New System.Drawing.Size(54, 17)
        Me.rdbtnMedio.TabIndex = 1
        Me.rdbtnMedio.TabStop = True
        Me.rdbtnMedio.Text = "Medio"
        Me.rdbtnMedio.UseVisualStyleBackColor = True
        '
        'rdbtnBasico
        '
        Me.rdbtnBasico.AutoSize = True
        Me.rdbtnBasico.Location = New System.Drawing.Point(18, 26)
        Me.rdbtnBasico.Name = "rdbtnBasico"
        Me.rdbtnBasico.Size = New System.Drawing.Size(57, 17)
        Me.rdbtnBasico.TabIndex = 0
        Me.rdbtnBasico.TabStop = True
        Me.rdbtnBasico.Text = "Básico"
        Me.rdbtnBasico.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAcceso)
        Me.GroupBox2.Controls.Add(Me.chkDvd)
        Me.GroupBox2.Controls.Add(Me.chkLibro)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(141, 110)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Meterial"
        '
        'chkAcceso
        '
        Me.chkAcceso.AutoSize = True
        Me.chkAcceso.Location = New System.Drawing.Point(18, 77)
        Me.chkAcceso.Name = "chkAcceso"
        Me.chkAcceso.Size = New System.Drawing.Size(101, 17)
        Me.chkAcceso.TabIndex = 2
        Me.chkAcceso.Text = "Acceso Internet"
        Me.chkAcceso.UseVisualStyleBackColor = True
        '
        'chkDvd
        '
        Me.chkDvd.AutoSize = True
        Me.chkDvd.Location = New System.Drawing.Point(18, 54)
        Me.chkDvd.Name = "chkDvd"
        Me.chkDvd.Size = New System.Drawing.Size(49, 17)
        Me.chkDvd.TabIndex = 1
        Me.chkDvd.Text = "DVD"
        Me.chkDvd.UseVisualStyleBackColor = True
        '
        'chkLibro
        '
        Me.chkLibro.AutoSize = True
        Me.chkLibro.Location = New System.Drawing.Point(18, 31)
        Me.chkLibro.Name = "chkLibro"
        Me.chkLibro.Size = New System.Drawing.Size(49, 17)
        Me.chkLibro.TabIndex = 0
        Me.chkLibro.Text = "Libro"
        Me.chkLibro.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe Curso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Importe Material"
        '
        'lblImporteCurso
        '
        Me.lblImporteCurso.BackColor = System.Drawing.Color.Silver
        Me.lblImporteCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImporteCurso.Location = New System.Drawing.Point(282, 153)
        Me.lblImporteCurso.Name = "lblImporteCurso"
        Me.lblImporteCurso.Size = New System.Drawing.Size(135, 34)
        Me.lblImporteCurso.TabIndex = 7
        '
        'lblImporteMaterial
        '
        Me.lblImporteMaterial.BackColor = System.Drawing.Color.Silver
        Me.lblImporteMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImporteMaterial.Location = New System.Drawing.Point(282, 230)
        Me.lblImporteMaterial.Name = "lblImporteMaterial"
        Me.lblImporteMaterial.Size = New System.Drawing.Size(135, 28)
        Me.lblImporteMaterial.TabIndex = 8
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(153, 419)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(282, 419)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(428, 419)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(448, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 133)
        Me.Panel1.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(33, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Avanzado 300"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(33, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Medio 120"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(33, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Básico 60"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(449, 242)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 171)
        Me.Panel2.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(24, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 33)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Estos precios se incrementan un 10% por nivel"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Precio Material"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(20, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Acceso Internet 120"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(20, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 23)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "DVD 60"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(20, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 23)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Libro 30"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(98, 372)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 28)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Importe TOTAL Curso"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        Me.txtPrecio.Location = New System.Drawing.Point(237, 372)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecio.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(364, 372)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 23)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "€"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNuAlumno
        '
        Me.lblNuAlumno.BackColor = System.Drawing.Color.White
        Me.lblNuAlumno.Location = New System.Drawing.Point(567, 25)
        Me.lblNuAlumno.Name = "lblNuAlumno"
        Me.lblNuAlumno.Size = New System.Drawing.Size(46, 34)
        Me.lblNuAlumno.TabIndex = 17
        '
        'FInical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 461)
        Me.Controls.Add(Me.lblNuAlumno)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblImporteMaterial)
        Me.Controls.Add(Me.lblImporteCurso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.KeyPreview = True
        Me.Name = "FInical"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnAvanzado As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnMedio As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnBasico As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDvd As System.Windows.Forms.CheckBox
    Friend WithEvents chkLibro As System.Windows.Forms.CheckBox
    Friend WithEvents chkAcceso As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblImporteCurso As System.Windows.Forms.Label
    Friend WithEvents lblImporteMaterial As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblNuAlumno As System.Windows.Forms.Label

End Class
