<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pimagen1 = New System.Windows.Forms.PictureBox()
        CType(Me.Pimagen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pimagen1
        '
        Me.Pimagen1.BackgroundImage = Global.P_Word.My.Resources.Resources.putin
        Me.Pimagen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pimagen1.Location = New System.Drawing.Point(29, 43)
        Me.Pimagen1.Name = "Pimagen1"
        Me.Pimagen1.Size = New System.Drawing.Size(235, 192)
        Me.Pimagen1.TabIndex = 1
        Me.Pimagen1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 301)
        Me.Controls.Add(Me.Pimagen1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Pimagen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Pimagen1 As System.Windows.Forms.PictureBox
End Class
