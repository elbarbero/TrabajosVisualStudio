<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnVerTexto = New System.Windows.Forms.Button()
        Me.btnRellenarCampos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVerTexto
        '
        Me.btnVerTexto.Location = New System.Drawing.Point(188, 83)
        Me.btnVerTexto.Name = "btnVerTexto"
        Me.btnVerTexto.Size = New System.Drawing.Size(143, 56)
        Me.btnVerTexto.TabIndex = 0
        Me.btnVerTexto.Text = "Ver Texto"
        Me.btnVerTexto.UseVisualStyleBackColor = True
        '
        'btnRellenarCampos
        '
        Me.btnRellenarCampos.Location = New System.Drawing.Point(193, 174)
        Me.btnRellenarCampos.Name = "btnRellenarCampos"
        Me.btnRellenarCampos.Size = New System.Drawing.Size(137, 58)
        Me.btnRellenarCampos.TabIndex = 1
        Me.btnRellenarCampos.Text = "Rellenar Campos"
        Me.btnRellenarCampos.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 336)
        Me.Controls.Add(Me.btnRellenarCampos)
        Me.Controls.Add(Me.btnVerTexto)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVerTexto As System.Windows.Forms.Button
    Friend WithEvents btnRellenarCampos As System.Windows.Forms.Button
End Class
