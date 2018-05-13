<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAlta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.cmbCursos = New System.Windows.Forms.ComboBox()
        Me.Cursos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDacademiaDataSet = New EX_2_BD_Mario_Barbero.BDacademiaDataSet()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.Cursos1TableAdapter = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.cursos1TableAdapter()
        Me.AlumnoscursosTableAdapter1 = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.alumnoscursosTableAdapter()
        Me.CursosTableAdapter1 = New EX_2_BD_Mario_Barbero.BDacademiaDataSetTableAdapters.cursosTableAdapter()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Cursos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alumno"
        '
        'txtAlumno
        '
        Me.txtAlumno.Location = New System.Drawing.Point(138, 31)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(158, 22)
        Me.txtAlumno.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(313, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblAlumno
        '
        Me.lblAlumno.BackColor = System.Drawing.SystemColors.Info
        Me.lblAlumno.Location = New System.Drawing.Point(443, 30)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(148, 61)
        Me.lblAlumno.TabIndex = 3
        Me.lblAlumno.Text = "Label2"
        '
        'cmbCursos
        '
        Me.cmbCursos.DataSource = Me.CursosBindingSource
        Me.cmbCursos.DisplayMember = "Nombre"
        Me.cmbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCursos.FormattingEnabled = True
        Me.cmbCursos.Location = New System.Drawing.Point(148, 98)
        Me.cmbCursos.Name = "cmbCursos"
        Me.cmbCursos.Size = New System.Drawing.Size(164, 24)
        Me.cmbCursos.TabIndex = 4
        Me.cmbCursos.ValueMember = "idCurso"
        '
        'Cursos1BindingSource
        '
        Me.Cursos1BindingSource.DataMember = "cursos1"
        Me.Cursos1BindingSource.DataSource = Me.BDacademiaDataSet
        '
        'BDacademiaDataSet
        '
        Me.BDacademiaDataSet.DataSetName = "BDacademiaDataSet"
        Me.BDacademiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnInsertar
        '
        Me.btnInsertar.Enabled = False
        Me.btnInsertar.Location = New System.Drawing.Point(162, 193)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 5
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'Cursos1TableAdapter
        '
        Me.Cursos1TableAdapter.ClearBeforeFill = True
        '
        'AlumnoscursosTableAdapter1
        '
        Me.AlumnoscursosTableAdapter1.ClearBeforeFill = True
        '
        'CursosTableAdapter1
        '
        Me.CursosTableAdapter1.ClearBeforeFill = True
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "cursos"
        Me.CursosBindingSource.DataSource = Me.BDacademiaDataSet
        '
        'FAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 397)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.cmbCursos)
        Me.Controls.Add(Me.lblAlumno)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtAlumno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FAlta"
        Me.Text = "FAlta"
        CType(Me.Cursos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDacademiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlumno As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblAlumno As Label
    Friend WithEvents cmbCursos As ComboBox
    Friend WithEvents Cursos1BindingSource As BindingSource
    Friend WithEvents BDacademiaDataSet As BDacademiaDataSet
    Friend WithEvents Cursos1TableAdapter As BDacademiaDataSetTableAdapters.cursos1TableAdapter
    Friend WithEvents AlumnoscursosTableAdapter1 As BDacademiaDataSetTableAdapters.alumnoscursosTableAdapter
    Friend WithEvents btnInsertar As Button
    Friend WithEvents CursosTableAdapter1 As BDacademiaDataSetTableAdapters.cursosTableAdapter
    Friend WithEvents CursosBindingSource As BindingSource
End Class
