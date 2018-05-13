<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAltaResult
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
        Me.CursosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New P_Academia_2018.BDacademiaDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CursosTableAdapter = New P_Academia_2018.BDacademiaDataSetTableAdapters.cursosTableAdapter()
        Me.lblIdCurso = New System.Windows.Forms.Label()
        Me.nEvaluacion = New System.Windows.Forms.Label()
        Me.NuEvaluacion = New System.Windows.Forms.NumericUpDown()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.CursosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCursos
        '
        Me.cmbCursos.DataSource = Me.CursosBindingSource1
        Me.cmbCursos.DisplayMember = "Nombre"
        Me.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCursos.FormattingEnabled = True
        Me.cmbCursos.Location = New System.Drawing.Point(124, 37)
        Me.cmbCursos.Name = "cmbCursos"
        Me.cmbCursos.Size = New System.Drawing.Size(121, 21)
        Me.cmbCursos.TabIndex = 0
        Me.cmbCursos.ValueMember = "idCurso"
        '
        'CursosBindingSource1
        '
        Me.CursosBindingSource1.DataMember = "cursos"
        Me.CursosBindingSource1.DataSource = Me.BDacademiaDataSet
        '
        'BDacademiaDataSet
        '
        Me.BDacademiaDataSet.DataSetName = "BDacademiaDataSet"
        Me.BDacademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Curso"
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'lblIdCurso
        '
        Me.lblIdCurso.AutoSize = True
        Me.lblIdCurso.Location = New System.Drawing.Point(271, 40)
        Me.lblIdCurso.Name = "lblIdCurso"
        Me.lblIdCurso.Size = New System.Drawing.Size(39, 13)
        Me.lblIdCurso.TabIndex = 2
        Me.lblIdCurso.Text = "Label2"
        '
        'nEvaluacion
        '
        Me.nEvaluacion.AutoSize = True
        Me.nEvaluacion.Location = New System.Drawing.Point(71, 84)
        Me.nEvaluacion.Name = "nEvaluacion"
        Me.nEvaluacion.Size = New System.Drawing.Size(75, 13)
        Me.nEvaluacion.TabIndex = 3
        Me.nEvaluacion.Text = "Nº Evaluación"
        '
        'NuEvaluacion
        '
        Me.NuEvaluacion.Location = New System.Drawing.Point(168, 77)
        Me.NuEvaluacion.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NuEvaluacion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NuEvaluacion.Name = "NuEvaluacion"
        Me.NuEvaluacion.Size = New System.Drawing.Size(53, 20)
        Me.NuEvaluacion.TabIndex = 4
        Me.NuEvaluacion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(156, 152)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'FAltaResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 286)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.NuEvaluacion)
        Me.Controls.Add(Me.nEvaluacion)
        Me.Controls.Add(Me.lblIdCurso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCursos)
        Me.Name = "FAltaResult"
        Me.Text = "FAltaResult"
        CType(Me.CursosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCursos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BDacademiaDataSet As P_Academia_2018.BDacademiaDataSet
    Friend WithEvents CursosTableAdapter As P_Academia_2018.BDacademiaDataSetTableAdapters.cursosTableAdapter
    Friend WithEvents CursosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents lblIdCurso As System.Windows.Forms.Label
    Friend WithEvents nEvaluacion As System.Windows.Forms.Label
    Friend WithEvents NuEvaluacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
End Class
