<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultaAlumnos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNomApe = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.pCodigo = New System.Windows.Forms.Panel()
        Me.cmbCodigo = New System.Windows.Forms.ComboBox()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New P_Academia_2018.BDacademiaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pNomApe = New System.Windows.Forms.Panel()
        Me.cmbNomApe = New System.Windows.Forms.ComboBox()
        Me.Alumnos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridConsultaAlu = New System.Windows.Forms.DataGridView()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet1 = New P_Academia_2018.BDacademiaDataSet()
        Me.AlumnosTableAdapter = New P_Academia_2018.BDacademiaDataSetTableAdapters.alumnosTableAdapter()
        Me.Alumnos1TableAdapter = New P_Academia_2018.BDacademiaDataSetTableAdapters.alumnos1TableAdapter()
        Me.DataTable2TableAdapter = New P_Academia_2018.BDacademiaDataSetTableAdapters.DataTable2TableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.pCodigo.SuspendLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pNomApe.SuspendLayout()
        CType(Me.Alumnos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsultaAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNomApe)
        Me.GroupBox1.Controls.Add(Me.rbCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(64, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo Consulta"
        '
        'rbNomApe
        '
        Me.rbNomApe.AutoSize = True
        Me.rbNomApe.Location = New System.Drawing.Point(218, 20)
        Me.rbNomApe.Name = "rbNomApe"
        Me.rbNomApe.Size = New System.Drawing.Size(115, 17)
        Me.rbNomApe.TabIndex = 1
        Me.rbNomApe.TabStop = True
        Me.rbNomApe.Text = "Nombre y Apellidos"
        Me.rbNomApe.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(23, 20)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rbCodigo.TabIndex = 0
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Código"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'pCodigo
        '
        Me.pCodigo.Controls.Add(Me.cmbCodigo)
        Me.pCodigo.Controls.Add(Me.Label1)
        Me.pCodigo.Location = New System.Drawing.Point(109, 115)
        Me.pCodigo.Name = "pCodigo"
        Me.pCodigo.Size = New System.Drawing.Size(288, 49)
        Me.pCodigo.TabIndex = 1
        Me.pCodigo.Visible = False
        '
        'cmbCodigo
        '
        Me.cmbCodigo.DataSource = Me.AlumnosBindingSource
        Me.cmbCodigo.DisplayMember = "idAlumno"
        Me.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodigo.FormattingEnabled = True
        Me.cmbCodigo.Location = New System.Drawing.Point(138, 13)
        Me.cmbCodigo.Name = "cmbCodigo"
        Me.cmbCodigo.Size = New System.Drawing.Size(81, 21)
        Me.cmbCodigo.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione un Alumno"
        '
        'pNomApe
        '
        Me.pNomApe.Controls.Add(Me.cmbNomApe)
        Me.pNomApe.Controls.Add(Me.Label2)
        Me.pNomApe.Location = New System.Drawing.Point(109, 180)
        Me.pNomApe.Name = "pNomApe"
        Me.pNomApe.Size = New System.Drawing.Size(288, 49)
        Me.pNomApe.TabIndex = 2
        Me.pNomApe.Visible = False
        '
        'cmbNomApe
        '
        Me.cmbNomApe.DataSource = Me.Alumnos1BindingSource
        Me.cmbNomApe.DisplayMember = "nomApe"
        Me.cmbNomApe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNomApe.FormattingEnabled = True
        Me.cmbNomApe.Location = New System.Drawing.Point(113, 13)
        Me.cmbNomApe.Name = "cmbNomApe"
        Me.cmbNomApe.Size = New System.Drawing.Size(159, 21)
        Me.cmbNomApe.TabIndex = 1
        Me.cmbNomApe.ValueMember = "idAlumno"
        '
        'Alumnos1BindingSource
        '
        Me.Alumnos1BindingSource.DataMember = "alumnos1"
        Me.Alumnos1BindingSource.DataSource = Me.BDacademiaDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellidos Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cursos de Alumno"
        '
        'DataGridConsultaAlu
        '
        Me.DataGridConsultaAlu.AllowUserToAddRows = False
        Me.DataGridConsultaAlu.AllowUserToDeleteRows = False
        Me.DataGridConsultaAlu.AutoGenerateColumns = False
        Me.DataGridConsultaAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsultaAlu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Expr1DataGridViewTextBoxColumn, Me.Column1})
        Me.DataGridConsultaAlu.DataSource = Me.DataTable2BindingSource1
        Me.DataGridConsultaAlu.Location = New System.Drawing.Point(130, 253)
        Me.DataGridConsultaAlu.Name = "DataGridConsultaAlu"
        Me.DataGridConsultaAlu.ReadOnly = True
        Me.DataGridConsultaAlu.Size = New System.Drawing.Size(333, 115)
        Me.DataGridConsultaAlu.TabIndex = 4
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Nombre Profrsor"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr1DataGridViewTextBoxColumn.Width = 130
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Nombre"
        Me.Column1.HeaderText = "Curso"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'DataTable2BindingSource1
        '
        Me.DataTable2BindingSource1.DataMember = "DataTable2"
        Me.DataTable2BindingSource1.DataSource = Me.BDacademiaDataSet
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.BDacademiaDataSet1
        '
        'BDacademiaDataSet1
        '
        Me.BDacademiaDataSet1.DataSetName = "BDacademiaDataSet"
        Me.BDacademiaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'Alumnos1TableAdapter
        '
        Me.Alumnos1TableAdapter.ClearBeforeFill = True
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'FConsultaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 380)
        Me.Controls.Add(Me.DataGridConsultaAlu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pNomApe)
        Me.Controls.Add(Me.pCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FConsultaAlumnos"
        Me.Text = "FConsultaAlumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pCodigo.ResumeLayout(False)
        Me.pCodigo.PerformLayout()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pNomApe.ResumeLayout(False)
        Me.pNomApe.PerformLayout()
        CType(Me.Alumnos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConsultaAlu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNomApe As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents pCodigo As System.Windows.Forms.Panel
    Friend WithEvents cmbCodigo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pNomApe As System.Windows.Forms.Panel
    Friend WithEvents cmbNomApe As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridConsultaAlu As System.Windows.Forms.DataGridView
    Friend WithEvents BDacademiaDataSet As P_Academia_2018.BDacademiaDataSet
    Friend WithEvents AlumnosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlumnosTableAdapter As P_Academia_2018.BDacademiaDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents Alumnos1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Alumnos1TableAdapter As P_Academia_2018.BDacademiaDataSetTableAdapters.alumnos1TableAdapter
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BDacademiaDataSet1 As P_Academia_2018.BDacademiaDataSet
    Friend WithEvents DataTable2TableAdapter As P_Academia_2018.BDacademiaDataSetTableAdapters.DataTable2TableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable2BindingSource1 As System.Windows.Forms.BindingSource
End Class
