<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsulta
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
        Me.PanelProducto = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtFamilia = New System.Windows.Forms.TextBox()
        Me.txtFechaAlta = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtExMinimas = New System.Windows.Forms.TextBox()
        Me.TxtEXActuales = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.BtnFamilias = New System.Windows.Forms.Button()
        Me.PanelFamilia = New System.Windows.Forms.Panel()
        Me.lbldatos = New System.Windows.Forms.Label()
        Me.NupDownFamilia = New System.Windows.Forms.NumericUpDown()
        Me.BtnSalirFamilia = New System.Windows.Forms.Button()
        Me.BtnBuscaFamilia = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelProducto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelFamilia.SuspendLayout()
        CType(Me.NupDownFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelProducto
        '
        Me.PanelProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelProducto.Controls.Add(Me.BtnSalir)
        Me.PanelProducto.Controls.Add(Me.BtnBuscar)
        Me.PanelProducto.Controls.Add(Me.txtCodigo)
        Me.PanelProducto.Controls.Add(Me.Label4)
        Me.PanelProducto.Controls.Add(Me.TxtDescripcion)
        Me.PanelProducto.Controls.Add(Me.txtFamilia)
        Me.PanelProducto.Controls.Add(Me.txtFechaAlta)
        Me.PanelProducto.Controls.Add(Me.GroupBox1)
        Me.PanelProducto.Controls.Add(Me.Label3)
        Me.PanelProducto.Controls.Add(Me.Label2)
        Me.PanelProducto.Controls.Add(Me.Label1)
        Me.PanelProducto.Location = New System.Drawing.Point(33, 57)
        Me.PanelProducto.Name = "PanelProducto"
        Me.PanelProducto.Size = New System.Drawing.Size(499, 274)
        Me.PanelProducto.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(412, 172)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 23
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(357, 43)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 22
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(195, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Código"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(195, 82)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.TxtDescripcion.TabIndex = 18
        '
        'txtFamilia
        '
        Me.txtFamilia.Location = New System.Drawing.Point(195, 53)
        Me.txtFamilia.Name = "txtFamilia"
        Me.txtFamilia.Size = New System.Drawing.Size(100, 20)
        Me.txtFamilia.TabIndex = 17
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.Location = New System.Drawing.Point(195, 109)
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaAlta.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.TxtExMinimas)
        Me.GroupBox1.Controls.Add(Me.TxtEXActuales)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 77)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TxtExMinimas
        '
        Me.TxtExMinimas.Location = New System.Drawing.Point(157, 45)
        Me.TxtExMinimas.Name = "TxtExMinimas"
        Me.TxtExMinimas.Size = New System.Drawing.Size(100, 20)
        Me.TxtExMinimas.TabIndex = 10
        '
        'TxtEXActuales
        '
        Me.TxtEXActuales.Location = New System.Drawing.Point(157, 19)
        Me.TxtEXActuales.Name = "TxtEXActuales"
        Me.TxtEXActuales.Size = New System.Drawing.Size(100, 20)
        Me.TxtEXActuales.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Existencias Actuales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Existencias Mínimas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha Alta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Familia"
        '
        'BtnProducto
        '
        Me.BtnProducto.Location = New System.Drawing.Point(41, 9)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(75, 23)
        Me.BtnProducto.TabIndex = 1
        Me.BtnProducto.Text = "Productos"
        Me.BtnProducto.UseVisualStyleBackColor = True
        '
        'BtnFamilias
        '
        Me.BtnFamilias.Location = New System.Drawing.Point(221, 9)
        Me.BtnFamilias.Name = "BtnFamilias"
        Me.BtnFamilias.Size = New System.Drawing.Size(75, 23)
        Me.BtnFamilias.TabIndex = 2
        Me.BtnFamilias.Text = "Familias"
        Me.BtnFamilias.UseVisualStyleBackColor = True
        '
        'PanelFamilia
        '
        Me.PanelFamilia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelFamilia.Controls.Add(Me.Label7)
        Me.PanelFamilia.Controls.Add(Me.lbldatos)
        Me.PanelFamilia.Controls.Add(Me.NupDownFamilia)
        Me.PanelFamilia.Controls.Add(Me.BtnSalirFamilia)
        Me.PanelFamilia.Controls.Add(Me.BtnBuscaFamilia)
        Me.PanelFamilia.Location = New System.Drawing.Point(577, 57)
        Me.PanelFamilia.Name = "PanelFamilia"
        Me.PanelFamilia.Size = New System.Drawing.Size(208, 274)
        Me.PanelFamilia.TabIndex = 3
        '
        'lbldatos
        '
        Me.lbldatos.BackColor = System.Drawing.Color.White
        Me.lbldatos.Location = New System.Drawing.Point(50, 109)
        Me.lbldatos.Name = "lbldatos"
        Me.lbldatos.Size = New System.Drawing.Size(120, 77)
        Me.lbldatos.TabIndex = 3
        '
        'NupDownFamilia
        '
        Me.NupDownFamilia.Location = New System.Drawing.Point(130, 27)
        Me.NupDownFamilia.Name = "NupDownFamilia"
        Me.NupDownFamilia.Size = New System.Drawing.Size(61, 20)
        Me.NupDownFamilia.TabIndex = 2
        '
        'BtnSalirFamilia
        '
        Me.BtnSalirFamilia.Location = New System.Drawing.Point(53, 201)
        Me.BtnSalirFamilia.Name = "BtnSalirFamilia"
        Me.BtnSalirFamilia.Size = New System.Drawing.Size(97, 23)
        Me.BtnSalirFamilia.TabIndex = 1
        Me.BtnSalirFamilia.Text = "SalirFamilia"
        Me.BtnSalirFamilia.UseVisualStyleBackColor = True
        '
        'BtnBuscaFamilia
        '
        Me.BtnBuscaFamilia.Location = New System.Drawing.Point(103, 72)
        Me.BtnBuscaFamilia.Name = "BtnBuscaFamilia"
        Me.BtnBuscaFamilia.Size = New System.Drawing.Size(97, 23)
        Me.BtnBuscaFamilia.TabIndex = 0
        Me.BtnBuscaFamilia.Text = "BuscarFamilia"
        Me.BtnBuscaFamilia.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.BtnFamilias)
        Me.GroupBox2.Controls.Add(Me.BtnProducto)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 43)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Familias (1-5)"
        '
        'FConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 388)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PanelFamilia)
        Me.Controls.Add(Me.PanelProducto)
        Me.Name = "FConsulta"
        Me.Text = "FConsulta"
        Me.PanelProducto.ResumeLayout(False)
        Me.PanelProducto.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelFamilia.ResumeLayout(False)
        Me.PanelFamilia.PerformLayout()
        CType(Me.NupDownFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelProducto As System.Windows.Forms.Panel
    Friend WithEvents txtFechaAlta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtExMinimas As System.Windows.Forms.TextBox
    Friend WithEvents TxtEXActuales As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnProducto As System.Windows.Forms.Button
    Friend WithEvents BtnFamilias As System.Windows.Forms.Button
    Friend WithEvents PanelFamilia As System.Windows.Forms.Panel
    Friend WithEvents BtnSalirFamilia As System.Windows.Forms.Button
    Friend WithEvents BtnBuscaFamilia As System.Windows.Forms.Button
    Friend WithEvents NupDownFamilia As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbldatos As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
End Class
