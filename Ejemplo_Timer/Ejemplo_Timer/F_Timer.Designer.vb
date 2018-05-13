<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Timer
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
        Me.imgImagen = New System.Windows.Forms.PictureBox()
        Me.temporizador = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgImagen
        '
        Me.imgImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.imgImagen.Location = New System.Drawing.Point(98, 45)
        Me.imgImagen.Name = "imgImagen"
        Me.imgImagen.Size = New System.Drawing.Size(276, 254)
        Me.imgImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgImagen.TabIndex = 1
        Me.imgImagen.TabStop = False
        '
        'temporizador
        '
        Me.temporizador.Enabled = True
        Me.temporizador.Interval = 1000
        '
        'F_Timer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 434)
        Me.Controls.Add(Me.imgImagen)
        Me.Name = "F_Timer"
        Me.Text = "Form1"
        CType(Me.imgImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgImagen As PictureBox
    Friend WithEvents temporizador As Timer
End Class
