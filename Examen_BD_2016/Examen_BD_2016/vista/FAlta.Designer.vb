<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FAlta
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
        Me.components = New System.ComponentModel.Container()
        Dim IdAlumnoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Fecha_nacimientoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gboxDatosAlumno = New System.Windows.Forms.GroupBox()
        Me.IdAlumnoTextBox = New System.Windows.Forms.TextBox()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New Examen_BD_2016.BDacademiaDataSet()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.lstCursosAlumno = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelCursos = New System.Windows.Forms.Panel()
        Me.cmbCursosAlu = New System.Windows.Forms.ComboBox()
        Me.Cursos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Examen_BD_2016.BDacademiaDataSetTableAdapters.alumnosTableAdapter()
        Me.TableAdapterManager = New Examen_BD_2016.BDacademiaDataSetTableAdapters.TableAdapterManager()
        Me.Cursos1TableAdapter = New Examen_BD_2016.BDacademiaDataSetTableAdapters.cursos1TableAdapter()
        Me.btnInsertarPanel = New System.Windows.Forms.Button()
        Me.lblAlumno = New System.Windows.Forms.Label()
        IdAlumnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Fecha_nacimientoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Me.gboxDatosAlumno.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCursos.SuspendLayout()
        CType(Me.Cursos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAlumnoLabel
        '
        IdAlumnoLabel.AutoSize = True
        IdAlumnoLabel.Location = New System.Drawing.Point(78, 41)
        IdAlumnoLabel.Name = "IdAlumnoLabel"
        IdAlumnoLabel.Size = New System.Drawing.Size(74, 17)
        IdAlumnoLabel.TabIndex = 0
        IdAlumnoLabel.Text = "id Alumno:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(78, 69)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(78, 97)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 4
        ApellidosLabel.Text = "Apellidos:"
        '
        'Fecha_nacimientoLabel
        '
        Fecha_nacimientoLabel.AutoSize = True
        Fecha_nacimientoLabel.Location = New System.Drawing.Point(78, 126)
        Fecha_nacimientoLabel.Name = "Fecha_nacimientoLabel"
        Fecha_nacimientoLabel.Size = New System.Drawing.Size(123, 17)
        Fecha_nacimientoLabel.TabIndex = 6
        Fecha_nacimientoLabel.Text = "Fecha nacimiento:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(78, 153)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 17)
        EmailLabel.TabIndex = 8
        EmailLabel.Text = "email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATOS DEL ALUMNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellidos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(250, 108)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 22)
        Me.txtNombre.TabIndex = 3
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(250, 155)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(193, 22)
        Me.txtApellidos.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(503, 119)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 44)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'gboxDatosAlumno
        '
        Me.gboxDatosAlumno.Controls.Add(IdAlumnoLabel)
        Me.gboxDatosAlumno.Controls.Add(Me.IdAlumnoTextBox)
        Me.gboxDatosAlumno.Controls.Add(NombreLabel)
        Me.gboxDatosAlumno.Controls.Add(Me.NombreTextBox)
        Me.gboxDatosAlumno.Controls.Add(ApellidosLabel)
        Me.gboxDatosAlumno.Controls.Add(Me.ApellidosTextBox)
        Me.gboxDatosAlumno.Controls.Add(Fecha_nacimientoLabel)
        Me.gboxDatosAlumno.Controls.Add(Me.Fecha_nacimientoDateTimePicker)
        Me.gboxDatosAlumno.Controls.Add(EmailLabel)
        Me.gboxDatosAlumno.Controls.Add(Me.EmailTextBox)
        Me.gboxDatosAlumno.Location = New System.Drawing.Point(87, 203)
        Me.gboxDatosAlumno.Name = "gboxDatosAlumno"
        Me.gboxDatosAlumno.Size = New System.Drawing.Size(482, 223)
        Me.gboxDatosAlumno.TabIndex = 6
        Me.gboxDatosAlumno.TabStop = False
        Me.gboxDatosAlumno.Text = "Datos del Alumno"
        Me.gboxDatosAlumno.Visible = False
        '
        'IdAlumnoTextBox
        '
        Me.IdAlumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "idAlumno", True))
        Me.IdAlumnoTextBox.Enabled = False
        Me.IdAlumnoTextBox.Location = New System.Drawing.Point(207, 38)
        Me.IdAlumnoTextBox.Name = "IdAlumnoTextBox"
        Me.IdAlumnoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdAlumnoTextBox.TabIndex = 1
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.BDacademiaDataSet
        '
        'BDacademiaDataSet
        '
        Me.BDacademiaDataSet.DataSetName = "BDacademiaDataSet"
        Me.BDacademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(207, 66)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreTextBox.TabIndex = 3
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Enabled = False
        Me.ApellidosTextBox.Location = New System.Drawing.Point(207, 94)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ApellidosTextBox.TabIndex = 5
        '
        'Fecha_nacimientoDateTimePicker
        '
        Me.Fecha_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "Fecha_nacimiento", True))
        Me.Fecha_nacimientoDateTimePicker.Enabled = False
        Me.Fecha_nacimientoDateTimePicker.Location = New System.Drawing.Point(207, 122)
        Me.Fecha_nacimientoDateTimePicker.Name = "Fecha_nacimientoDateTimePicker"
        Me.Fecha_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Fecha_nacimientoDateTimePicker.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "email", True))
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Location = New System.Drawing.Point(207, 150)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 9
        '
        'lstCursosAlumno
        '
        Me.lstCursosAlumno.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstCursosAlumno.Location = New System.Drawing.Point(630, 198)
        Me.lstCursosAlumno.Name = "lstCursosAlumno"
        Me.lstCursosAlumno.Size = New System.Drawing.Size(211, 227)
        Me.lstCursosAlumno.TabIndex = 7
        Me.lstCursosAlumno.UseCompatibleStateImageBehavior = False
        Me.lstCursosAlumno.View = System.Windows.Forms.View.Details
        Me.lstCursosAlumno.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Curso"
        '
        'PanelCursos
        '
        Me.PanelCursos.BackColor = System.Drawing.SystemColors.Info
        Me.PanelCursos.Controls.Add(Me.lblAlumno)
        Me.PanelCursos.Controls.Add(Me.btnInsertarPanel)
        Me.PanelCursos.Controls.Add(Me.cmbCursosAlu)
        Me.PanelCursos.Location = New System.Drawing.Point(165, 43)
        Me.PanelCursos.Name = "PanelCursos"
        Me.PanelCursos.Size = New System.Drawing.Size(481, 226)
        Me.PanelCursos.TabIndex = 8
        Me.PanelCursos.Visible = False
        '
        'cmbCursosAlu
        '
        Me.cmbCursosAlu.DataSource = Me.Cursos1BindingSource
        Me.cmbCursosAlu.DisplayMember = "Nombre"
        Me.cmbCursosAlu.FormattingEnabled = True
        Me.cmbCursosAlu.Location = New System.Drawing.Point(127, 28)
        Me.cmbCursosAlu.Name = "cmbCursosAlu"
        Me.cmbCursosAlu.Size = New System.Drawing.Size(251, 24)
        Me.cmbCursosAlu.TabIndex = 0
        Me.cmbCursosAlu.ValueMember = "idCurso"
        '
        'Cursos1BindingSource
        '
        Me.Cursos1BindingSource.DataMember = "cursos1"
        Me.Cursos1BindingSource.DataSource = Me.BDacademiaDataSet
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosapTableAdapter = Nothing
        Me.TableAdapterManager.alumnoscursosTableAdapter = Nothing
        Me.TableAdapterManager.alumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cursos_nuevaTableAdapter = Nothing
        Me.TableAdapterManager.cursosTableAdapter = Nothing
        Me.TableAdapterManager.notasTableAdapter = Nothing
        Me.TableAdapterManager.profesoresTableAdapter = Nothing
        Me.TableAdapterManager.tcontadorTableAdapter = Nothing
        Me.TableAdapterManager.tresultadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Examen_BD_2016.BDacademiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Cursos1TableAdapter
        '
        Me.Cursos1TableAdapter.ClearBeforeFill = True
        '
        'btnInsertarPanel
        '
        Me.btnInsertarPanel.Location = New System.Drawing.Point(186, 133)
        Me.btnInsertarPanel.Name = "btnInsertarPanel"
        Me.btnInsertarPanel.Size = New System.Drawing.Size(118, 45)
        Me.btnInsertarPanel.TabIndex = 1
        Me.btnInsertarPanel.Text = "Insetar"
        Me.btnInsertarPanel.UseVisualStyleBackColor = True
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(152, 76)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(51, 17)
        Me.lblAlumno.TabIndex = 2
        Me.lblAlumno.Text = "Label4"
        '
        'FAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 456)
        Me.Controls.Add(Me.PanelCursos)
        Me.Controls.Add(Me.lstCursosAlumno)
        Me.Controls.Add(Me.gboxDatosAlumno)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FAlta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriculas Nuevas"
        Me.gboxDatosAlumno.ResumeLayout(False)
        Me.gboxDatosAlumno.PerformLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCursos.ResumeLayout(False)
        Me.PanelCursos.PerformLayout()
        CType(Me.Cursos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents gboxDatosAlumno As GroupBox
    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As BDacademiaDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents TableAdapterManager As BDacademiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdAlumnoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents Fecha_nacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents lstCursosAlumno As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents PanelCursos As Panel
    Friend WithEvents cmbCursosAlu As ComboBox
    Friend WithEvents Cursos1BindingSource As BindingSource
    Friend WithEvents Cursos1TableAdapter As BDacademiaDataSetTableAdapters.cursos1TableAdapter
    Friend WithEvents lblAlumno As Label
    Friend WithEvents btnInsertarPanel As Button
End Class
