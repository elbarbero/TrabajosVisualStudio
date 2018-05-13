<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultar
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
        Me.lstAlumnos = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstAlumnos
        '
        Me.lstAlumnos.FormattingEnabled = True
        Me.lstAlumnos.Location = New System.Drawing.Point(40, 34)
        Me.lstAlumnos.Name = "lstAlumnos"
        Me.lstAlumnos.Size = New System.Drawing.Size(142, 212)
        Me.lstAlumnos.Sorted = True
        Me.lstAlumnos.TabIndex = 0
        '
        'FConsultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 413)
        Me.Controls.Add(Me.lstAlumnos)
        Me.Name = "FConsultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstAlumnos As System.Windows.Forms.ListBox
End Class
