<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FConsulta
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
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New EX_2_BD_Mario_Barbero.BDacademiaDataSet()
        Me.CursosTableAdapter = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.cursosTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DuracionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicioCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumAlumnosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter1 = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.DataTable1TableAdapter()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCursoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioCursoDataGridViewTextBoxColumn, Me.DuracionDataGridViewTextBoxColumn, Me.FechaInicioCursoDataGridViewTextBoxColumn, Me.NumAlumnosDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.FechaFinCursoDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 165)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(900, 218)
        Me.DataGridView1.TabIndex = 1
        '
        'IdCursoDataGridViewTextBoxColumn
        '
        Me.IdCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.HeaderText = "idCurso"
        Me.IdCursoDataGridViewTextBoxColumn.Name = "IdCursoDataGridViewTextBoxColumn"
        Me.IdCursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioCursoDataGridViewTextBoxColumn
        '
        Me.PrecioCursoDataGridViewTextBoxColumn.DataPropertyName = "PrecioCurso"
        Me.PrecioCursoDataGridViewTextBoxColumn.HeaderText = "PrecioCurso"
        Me.PrecioCursoDataGridViewTextBoxColumn.Name = "PrecioCursoDataGridViewTextBoxColumn"
        Me.PrecioCursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DuracionDataGridViewTextBoxColumn
        '
        Me.DuracionDataGridViewTextBoxColumn.DataPropertyName = "duracion"
        Me.DuracionDataGridViewTextBoxColumn.HeaderText = "duracion"
        Me.DuracionDataGridViewTextBoxColumn.Name = "DuracionDataGridViewTextBoxColumn"
        Me.DuracionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaInicioCursoDataGridViewTextBoxColumn
        '
        Me.FechaInicioCursoDataGridViewTextBoxColumn.DataPropertyName = "FechaInicioCurso"
        Me.FechaInicioCursoDataGridViewTextBoxColumn.HeaderText = "FechaInicioCurso"
        Me.FechaInicioCursoDataGridViewTextBoxColumn.Name = "FechaInicioCursoDataGridViewTextBoxColumn"
        Me.FechaInicioCursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumAlumnosDataGridViewTextBoxColumn
        '
        Me.NumAlumnosDataGridViewTextBoxColumn.DataPropertyName = "numAlumnos"
        Me.NumAlumnosDataGridViewTextBoxColumn.HeaderText = "numAlumnos"
        Me.NumAlumnosDataGridViewTextBoxColumn.Name = "NumAlumnosDataGridViewTextBoxColumn"
        Me.NumAlumnosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaFinCursoDataGridViewTextBoxColumn
        '
        Me.FechaFinCursoDataGridViewTextBoxColumn.DataPropertyName = "FechaFinCurso"
        Me.FechaFinCursoDataGridViewTextBoxColumn.HeaderText = "FechaFinCurso"
        Me.FechaFinCursoDataGridViewTextBoxColumn.Name = "FechaFinCursoDataGridViewTextBoxColumn"
        Me.FechaFinCursoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "NomProfe"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.BDacademiaDataSet
        '
        'DataTable1TableAdapter1
        '
        Me.DataTable1TableAdapter1.ClearBeforeFill = True
        '
        'FConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 438)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FConsulta"
        Me.Text = "FConsulta"
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BDacademiaDataSetTableAdapters.cursosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataTable1TableAdapter1 As BDacademiaDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents IdCursoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCursoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DuracionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioCursoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumAlumnosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinCursoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
