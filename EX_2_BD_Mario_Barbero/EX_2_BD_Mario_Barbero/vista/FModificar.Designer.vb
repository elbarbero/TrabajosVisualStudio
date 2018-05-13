<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FModificar
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
        Me.components = New System.ComponentModel.Container()
        Dim IdAlumnoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Fecha_nacimientoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.BDacademiaDataSet = New EX_2_BD_Mario_Barbero.BDacademiaDataSet()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.alumnosTableAdapter()
        Me.TableAdapterManager = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.TableAdapterManager()
        Me.IdAlumnoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.bvtnBuscar = New System.Windows.Forms.Button()
        IdAlumnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Fecha_nacimientoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BDacademiaDataSet
        '
        Me.BDacademiaDataSet.DataSetName = "BDacademiaDataSet"
        Me.BDacademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.BDacademiaDataSet
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
        Me.TableAdapterManager.UpdateOrder = EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdAlumnoLabel
        '
        IdAlumnoLabel.AutoSize = True
        IdAlumnoLabel.Location = New System.Drawing.Point(141, 161)
        IdAlumnoLabel.Name = "IdAlumnoLabel"
        IdAlumnoLabel.Size = New System.Drawing.Size(74, 17)
        IdAlumnoLabel.TabIndex = 1
        IdAlumnoLabel.Text = "id Alumno:"
        '
        'IdAlumnoTextBox
        '
        Me.IdAlumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "idAlumno", True))
        Me.IdAlumnoTextBox.Enabled = False
        Me.IdAlumnoTextBox.Location = New System.Drawing.Point(270, 158)
        Me.IdAlumnoTextBox.Name = "IdAlumnoTextBox"
        Me.IdAlumnoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdAlumnoTextBox.TabIndex = 2
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(141, 189)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(270, 186)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(141, 217)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 5
        ApellidosLabel.Text = "Apellidos:"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(270, 214)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ApellidosTextBox.TabIndex = 6
        '
        'Fecha_nacimientoLabel
        '
        Fecha_nacimientoLabel.AutoSize = True
        Fecha_nacimientoLabel.Location = New System.Drawing.Point(141, 246)
        Fecha_nacimientoLabel.Name = "Fecha_nacimientoLabel"
        Fecha_nacimientoLabel.Size = New System.Drawing.Size(123, 17)
        Fecha_nacimientoLabel.TabIndex = 7
        Fecha_nacimientoLabel.Text = "Fecha nacimiento:"
        '
        'Fecha_nacimientoDateTimePicker
        '
        Me.Fecha_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "Fecha_nacimiento", True))
        Me.Fecha_nacimientoDateTimePicker.Location = New System.Drawing.Point(270, 242)
        Me.Fecha_nacimientoDateTimePicker.Name = "Fecha_nacimientoDateTimePicker"
        Me.Fecha_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Fecha_nacimientoDateTimePicker.TabIndex = 8
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(141, 273)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 17)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(270, 270)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 10
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(297, 313)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(118, 53)
        Me.btnModificar.TabIndex = 11
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(270, 48)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(100, 22)
        Me.txtAlumno.TabIndex = 12
        '
        'bvtnBuscar
        '
        Me.bvtnBuscar.Location = New System.Drawing.Point(407, 48)
        Me.bvtnBuscar.Name = "bvtnBuscar"
        Me.bvtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bvtnBuscar.TabIndex = 13
        Me.bvtnBuscar.Text = "Buscar"
        Me.bvtnBuscar.UseVisualStyleBackColor = True
        '
        'FModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 423)
        Me.Controls.Add(Me.bvtnBuscar)
        Me.Controls.Add(Me.txtAlumno)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(IdAlumnoLabel)
        Me.Controls.Add(Me.IdAlumnoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(Fecha_nacimientoLabel)
        Me.Controls.Add(Me.Fecha_nacimientoDateTimePicker)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Name = "FModificar"
        Me.Text = "FModificar"
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As BDacademiaDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents TableAdapterManager As BDacademiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdAlumnoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents Fecha_nacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtAlumno As TextBox
    Friend WithEvents bvtnBuscar As Button
End Class
