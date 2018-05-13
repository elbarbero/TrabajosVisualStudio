<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprobarArchivo
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.rtxtTexto = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCorreo = New System.Windows.Forms.Panel()
        Me.btnAceptarPanel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.PanelCorreo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(133, 205)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(314, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'btnComprobar
        '
        Me.btnComprobar.Location = New System.Drawing.Point(212, 247)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(133, 51)
        Me.btnComprobar.TabIndex = 1
        Me.btnComprobar.Text = "Comprobar informacion"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'rtxtTexto
        '
        Me.rtxtTexto.Location = New System.Drawing.Point(103, 26)
        Me.rtxtTexto.Name = "rtxtTexto"
        Me.rtxtTexto.Size = New System.Drawing.Size(404, 150)
        Me.rtxtTexto.TabIndex = 2
        Me.rtxtTexto.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0 %"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'PanelCorreo
        '
        Me.PanelCorreo.Controls.Add(Me.btnAceptarPanel)
        Me.PanelCorreo.Controls.Add(Me.Label2)
        Me.PanelCorreo.Controls.Add(Me.txtCorreo)
        Me.PanelCorreo.Location = New System.Drawing.Point(123, 39)
        Me.PanelCorreo.Name = "PanelCorreo"
        Me.PanelCorreo.Size = New System.Drawing.Size(353, 123)
        Me.PanelCorreo.TabIndex = 4
        Me.PanelCorreo.Visible = False
        '
        'btnAceptarPanel
        '
        Me.btnAceptarPanel.Location = New System.Drawing.Point(114, 69)
        Me.btnAceptarPanel.Name = "btnAceptarPanel"
        Me.btnAceptarPanel.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptarPanel.TabIndex = 4
        Me.btnAceptarPanel.Text = "Aceptar"
        Me.btnAceptarPanel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(89, 16)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(235, 20)
        Me.txtCorreo.TabIndex = 0
        '
        'ComprobarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 314)
        Me.Controls.Add(Me.PanelCorreo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtxtTexto)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "ComprobarArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobar Formato Texto"
        Me.PanelCorreo.ResumeLayout(False)
        Me.PanelCorreo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnComprobar As Button
    Friend WithEvents rtxtTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelCorreo As Panel
    Friend WithEvents btnAceptarPanel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreo As TextBox
End Class
