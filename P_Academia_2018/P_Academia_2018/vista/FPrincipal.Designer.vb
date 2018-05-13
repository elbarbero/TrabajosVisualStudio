<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrincipal
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
        Me.btnAltaResult = New System.Windows.Forms.Button()
        Me.btnConsultaMatricula = New System.Windows.Forms.Button()
        Me.btnConsultaAlu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAltaResult
        '
        Me.btnAltaResult.Location = New System.Drawing.Point(246, 49)
        Me.btnAltaResult.Name = "btnAltaResult"
        Me.btnAltaResult.Size = New System.Drawing.Size(157, 46)
        Me.btnAltaResult.TabIndex = 0
        Me.btnAltaResult.Text = "Alta Resultados"
        Me.btnAltaResult.UseVisualStyleBackColor = True
        '
        'btnConsultaMatricula
        '
        Me.btnConsultaMatricula.Location = New System.Drawing.Point(246, 135)
        Me.btnConsultaMatricula.Name = "btnConsultaMatricula"
        Me.btnConsultaMatricula.Size = New System.Drawing.Size(157, 46)
        Me.btnConsultaMatricula.TabIndex = 1
        Me.btnConsultaMatricula.Text = "Consulta Alumnos Matriculados"
        Me.btnConsultaMatricula.UseVisualStyleBackColor = True
        '
        'btnConsultaAlu
        '
        Me.btnConsultaAlu.Location = New System.Drawing.Point(246, 205)
        Me.btnConsultaAlu.Name = "btnConsultaAlu"
        Me.btnConsultaAlu.Size = New System.Drawing.Size(157, 46)
        Me.btnConsultaAlu.TabIndex = 2
        Me.btnConsultaAlu.Text = "Consulta Alumnos"
        Me.btnConsultaAlu.UseVisualStyleBackColor = True
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 333)
        Me.Controls.Add(Me.btnConsultaAlu)
        Me.Controls.Add(Me.btnConsultaMatricula)
        Me.Controls.Add(Me.btnAltaResult)
        Me.Name = "FPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAltaResult As System.Windows.Forms.Button
    Friend WithEvents btnConsultaMatricula As System.Windows.Forms.Button
    Friend WithEvents btnConsultaAlu As System.Windows.Forms.Button

End Class
