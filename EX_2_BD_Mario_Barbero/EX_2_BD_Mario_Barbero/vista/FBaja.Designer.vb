<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FBaja
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
        Dim IdCursoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Id_profesorLabel As System.Windows.Forms.Label
        Dim PrecioCursoLabel As System.Windows.Forms.Label
        Dim DuracionLabel As System.Windows.Forms.Label
        Dim FechaInicioCursoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.IdCursoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.Id_profesorTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioCursoTextBox = New System.Windows.Forms.TextBox()
        Me.DuracionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaInicioCursoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblNumAluPorCurso = New System.Windows.Forms.Label()
        Me.txtNomProfe = New System.Windows.Forms.TextBox()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New EX_2_BD_Mario_Barbero.BDacademiaDataSet()
        Me.CursosTableAdapter = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.cursosTableAdapter()
        Me.TableAdapterManager = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.TableAdapterManager()
        Me.AlumnoscursosTableAdapter1 = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.alumnoscursosTableAdapter()
        Me.btnEliminar = New System.Windows.Forms.Button()
        IdCursoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        Id_profesorLabel = New System.Windows.Forms.Label()
        PrecioCursoLabel = New System.Windows.Forms.Label()
        DuracionLabel = New System.Windows.Forms.Label()
        FechaInicioCursoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curso"
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(121, 54)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(118, 22)
        Me.txtCurso.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(274, 54)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'IdCursoLabel
        '
        IdCursoLabel.AutoSize = True
        IdCursoLabel.Location = New System.Drawing.Point(28, 131)
        IdCursoLabel.Name = "IdCursoLabel"
        IdCursoLabel.Size = New System.Drawing.Size(64, 17)
        IdCursoLabel.TabIndex = 4
        IdCursoLabel.Text = "id Curso:"
        '
        'IdCursoTextBox
        '
        Me.IdCursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "idCurso", True))
        Me.IdCursoTextBox.Location = New System.Drawing.Point(162, 128)
        Me.IdCursoTextBox.Name = "IdCursoTextBox"
        Me.IdCursoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdCursoTextBox.TabIndex = 5
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(28, 159)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(162, 156)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NombreTextBox.TabIndex = 7
        '
        'Id_profesorLabel
        '
        Id_profesorLabel.AutoSize = True
        Id_profesorLabel.Location = New System.Drawing.Point(28, 187)
        Id_profesorLabel.Name = "Id_profesorLabel"
        Id_profesorLabel.Size = New System.Drawing.Size(80, 17)
        Id_profesorLabel.TabIndex = 8
        Id_profesorLabel.Text = "id profesor:"
        '
        'Id_profesorTextBox
        '
        Me.Id_profesorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "id_profesor", True))
        Me.Id_profesorTextBox.Location = New System.Drawing.Point(162, 184)
        Me.Id_profesorTextBox.Name = "Id_profesorTextBox"
        Me.Id_profesorTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Id_profesorTextBox.TabIndex = 9
        '
        'PrecioCursoLabel
        '
        PrecioCursoLabel.AutoSize = True
        PrecioCursoLabel.Location = New System.Drawing.Point(28, 242)
        PrecioCursoLabel.Name = "PrecioCursoLabel"
        PrecioCursoLabel.Size = New System.Drawing.Size(93, 17)
        PrecioCursoLabel.TabIndex = 10
        PrecioCursoLabel.Text = "Precio Curso:"
        '
        'PrecioCursoTextBox
        '
        Me.PrecioCursoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "PrecioCurso", True))
        Me.PrecioCursoTextBox.Location = New System.Drawing.Point(162, 239)
        Me.PrecioCursoTextBox.Name = "PrecioCursoTextBox"
        Me.PrecioCursoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PrecioCursoTextBox.TabIndex = 11
        '
        'DuracionLabel
        '
        DuracionLabel.AutoSize = True
        DuracionLabel.Location = New System.Drawing.Point(28, 270)
        DuracionLabel.Name = "DuracionLabel"
        DuracionLabel.Size = New System.Drawing.Size(67, 17)
        DuracionLabel.TabIndex = 12
        DuracionLabel.Text = "duracion:"
        '
        'DuracionTextBox
        '
        Me.DuracionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "duracion", True))
        Me.DuracionTextBox.Location = New System.Drawing.Point(162, 267)
        Me.DuracionTextBox.Name = "DuracionTextBox"
        Me.DuracionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DuracionTextBox.TabIndex = 13
        '
        'FechaInicioCursoLabel
        '
        FechaInicioCursoLabel.AutoSize = True
        FechaInicioCursoLabel.Location = New System.Drawing.Point(28, 299)
        FechaInicioCursoLabel.Name = "FechaInicioCursoLabel"
        FechaInicioCursoLabel.Size = New System.Drawing.Size(128, 17)
        FechaInicioCursoLabel.TabIndex = 14
        FechaInicioCursoLabel.Text = "Fecha Inicio Curso:"
        '
        'FechaInicioCursoDateTimePicker
        '
        Me.FechaInicioCursoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CursosBindingSource, "FechaInicioCurso", True))
        Me.FechaInicioCursoDateTimePicker.Location = New System.Drawing.Point(162, 295)
        Me.FechaInicioCursoDateTimePicker.Name = "FechaInicioCursoDateTimePicker"
        Me.FechaInicioCursoDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.FechaInicioCursoDateTimePicker.TabIndex = 15
        '
        'lblNumAluPorCurso
        '
        Me.lblNumAluPorCurso.BackColor = System.Drawing.SystemColors.Info
        Me.lblNumAluPorCurso.Location = New System.Drawing.Point(159, 350)
        Me.lblNumAluPorCurso.Name = "lblNumAluPorCurso"
        Me.lblNumAluPorCurso.Size = New System.Drawing.Size(135, 74)
        Me.lblNumAluPorCurso.TabIndex = 16
        Me.lblNumAluPorCurso.Text = "Label2"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(28, 214)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(99, 17)
        Label2.TabIndex = 17
        Label2.Text = "Nombre profe:"
        '
        'txtNomProfe
        '
        Me.txtNomProfe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "id_profesor", True))
        Me.txtNomProfe.Location = New System.Drawing.Point(162, 211)
        Me.txtNomProfe.Name = "txtNomProfe"
        Me.txtNomProfe.Size = New System.Drawing.Size(200, 22)
        Me.txtNomProfe.TabIndex = 18
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "cursos"
        Me.CursosBindingSource.DataSource = Me.BDacademiaDataSet
        '
        'BDacademiaDataSet
        '
        Me.BDacademiaDataSet.DataSetName = "BDacademiaDataSet"
        Me.BDacademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosapTableAdapter = Nothing
        Me.TableAdapterManager.alumnoscursosTableAdapter = Nothing
        Me.TableAdapterManager.alumnosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cursos_nuevaTableAdapter = Nothing
        Me.TableAdapterManager.cursosTableAdapter = Me.CursosTableAdapter
        Me.TableAdapterManager.notasTableAdapter = Nothing
        Me.TableAdapterManager.profesoresTableAdapter = Nothing
        Me.TableAdapterManager.tcontadorTableAdapter = Nothing
        Me.TableAdapterManager.tresultadoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlumnoscursosTableAdapter1
        '
        Me.AlumnoscursosTableAdapter1.ClearBeforeFill = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(418, 131)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(100, 73)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 490)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txtNomProfe)
        Me.Controls.Add(Me.lblNumAluPorCurso)
        Me.Controls.Add(IdCursoLabel)
        Me.Controls.Add(Me.IdCursoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Id_profesorLabel)
        Me.Controls.Add(Me.Id_profesorTextBox)
        Me.Controls.Add(PrecioCursoLabel)
        Me.Controls.Add(Me.PrecioCursoTextBox)
        Me.Controls.Add(DuracionLabel)
        Me.Controls.Add(Me.DuracionTextBox)
        Me.Controls.Add(FechaInicioCursoLabel)
        Me.Controls.Add(Me.FechaInicioCursoDateTimePicker)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FBaja"
        Me.Text = "FBaja"
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BDacademiaDataSetTableAdapters.cursosTableAdapter
    Friend WithEvents TableAdapterManager As BDacademiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdCursoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents Id_profesorTextBox As TextBox
    Friend WithEvents PrecioCursoTextBox As TextBox
    Friend WithEvents DuracionTextBox As TextBox
    Friend WithEvents FechaInicioCursoDateTimePicker As DateTimePicker
    Friend WithEvents lblNumAluPorCurso As Label
    Friend WithEvents txtNomProfe As TextBox
    Friend WithEvents AlumnoscursosTableAdapter1 As BDacademiaDataSetTableAdapters.alumnoscursosTableAdapter
    Friend WithEvents btnEliminar As Button
End Class
