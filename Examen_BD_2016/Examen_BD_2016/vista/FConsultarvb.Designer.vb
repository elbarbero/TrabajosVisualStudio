<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultarvb
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
        Me.cmbCursos = New System.Windows.Forms.ComboBox()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New Examen_BD_2016.BDacademiaDataSet()
        Me.CursosTableAdapter = New Examen_BD_2016.BDacademiaDataSetTableAdapters.cursosTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Alumnos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alumnos1TableAdapter = New Examen_BD_2016.BDacademiaDataSetTableAdapters.alumnos1TableAdapter()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNumAlu = New System.Windows.Forms.Label()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alumnos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCursos
        '
        Me.cmbCursos.DataSource = Me.CursosBindingSource
        Me.cmbCursos.DisplayMember = "Nombre"
        Me.cmbCursos.FormattingEnabled = True
        Me.cmbCursos.Location = New System.Drawing.Point(194, 42)
        Me.cmbCursos.Name = "cmbCursos"
        Me.cmbCursos.Size = New System.Drawing.Size(311, 24)
        Me.cmbCursos.TabIndex = 0
        Me.cmbCursos.ValueMember = "idCurso"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.IdAlumnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Alumnos1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(194, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'Alumnos1BindingSource
        '
        Me.Alumnos1BindingSource.DataMember = "alumnos1"
        Me.Alumnos1BindingSource.DataSource = Me.BDacademiaDataSet
        '
        'Alumnos1TableAdapter
        '
        Me.Alumnos1TableAdapter.ClearBeforeFill = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdAlumnoDataGridViewTextBoxColumn
        '
        Me.IdAlumnoDataGridViewTextBoxColumn.DataPropertyName = "idAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.HeaderText = "idAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.Name = "IdAlumnoDataGridViewTextBoxColumn"
        Me.IdAlumnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'lblNumAlu
        '
        Me.lblNumAlu.BackColor = System.Drawing.SystemColors.Info
        Me.lblNumAlu.Location = New System.Drawing.Point(457, 157)
        Me.lblNumAlu.Name = "lblNumAlu"
        Me.lblNumAlu.Size = New System.Drawing.Size(213, 76)
        Me.lblNumAlu.TabIndex = 2
        Me.lblNumAlu.Text = "Label1"
        '
        'FConsultarvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 360)
        Me.Controls.Add(Me.lblNumAlu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbCursos)
        Me.Name = "FConsultarvb"
        Me.Text = "FConsultarvb"
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alumnos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbCursos As ComboBox
    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BDacademiaDataSetTableAdapters.cursosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAlumnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Alumnos1BindingSource As BindingSource
    Friend WithEvents Alumnos1TableAdapter As BDacademiaDataSetTableAdapters.alumnos1TableAdapter
    Friend WithEvents lblNumAlu As Label
End Class
