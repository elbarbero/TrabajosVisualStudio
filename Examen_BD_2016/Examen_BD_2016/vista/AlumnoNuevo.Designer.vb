<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoNuevo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BDacademiaDataSet = New Examen_BD_2016.BDacademiaDataSet()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New Examen_BD_2016.BDacademiaDataSetTableAdapters.alumnosTableAdapter()
        Me.TableAdapterManager = New Examen_BD_2016.BDacademiaDataSetTableAdapters.TableAdapterManager()
        Me.IdAlumnoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.btnGrabar = New System.Windows.Forms.Button()
        IdAlumnoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Fecha_nacimientoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAlumnoLabel
        '
        IdAlumnoLabel.AutoSize = True
        IdAlumnoLabel.Location = New System.Drawing.Point(182, 224)
        IdAlumnoLabel.Name = "IdAlumnoLabel"
        IdAlumnoLabel.Size = New System.Drawing.Size(74, 17)
        IdAlumnoLabel.TabIndex = 2
        IdAlumnoLabel.Text = "id Alumno:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(182, 252)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(182, 280)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "Apellidos:"
        '
        'Fecha_nacimientoLabel
        '
        Fecha_nacimientoLabel.AutoSize = True
        Fecha_nacimientoLabel.Location = New System.Drawing.Point(182, 309)
        Fecha_nacimientoLabel.Name = "Fecha_nacimientoLabel"
        Fecha_nacimientoLabel.Size = New System.Drawing.Size(123, 17)
        Fecha_nacimientoLabel.TabIndex = 8
        Fecha_nacimientoLabel.Text = "Fecha nacimiento:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(182, 336)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(45, 17)
        EmailLabel.TabIndex = 10
        EmailLabel.Text = "email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUEVOS ALUMNOS"
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
        Me.TableAdapterManager.UpdateOrder = Examen_BD_2016.BDacademiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdAlumnoTextBox
        '
        Me.IdAlumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "idAlumno", True))
        Me.IdAlumnoTextBox.Enabled = False
        Me.IdAlumnoTextBox.Location = New System.Drawing.Point(311, 221)
        Me.IdAlumnoTextBox.Name = "IdAlumnoTextBox"
        Me.IdAlumnoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdAlumnoTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(311, 249)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "Apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(311, 277)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'Fecha_nacimientoDateTimePicker
        '
        Me.Fecha_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlumnosBindingSource, "Fecha_nacimiento", True))
        Me.Fecha_nacimientoDateTimePicker.Location = New System.Drawing.Point(311, 305)
        Me.Fecha_nacimientoDateTimePicker.Name = "Fecha_nacimientoDateTimePicker"
        Me.Fecha_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Fecha_nacimientoDateTimePicker.TabIndex = 9
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(311, 333)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailTextBox.TabIndex = 11
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(311, 374)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(97, 46)
        Me.btnGrabar.TabIndex = 12
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'AlumnoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 478)
        Me.Controls.Add(Me.btnGrabar)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "AlumnoNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriculas Nuevas"
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As BDacademiaDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents TableAdapterManager As BDacademiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdAlumnoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents Fecha_nacimientoDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents btnGrabar As Button
End Class
