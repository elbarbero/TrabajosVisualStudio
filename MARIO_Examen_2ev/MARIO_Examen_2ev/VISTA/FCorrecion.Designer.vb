<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCorrecion
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
        Me.temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblMarcadorBarra = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCorregir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtTexto = New System.Windows.Forms.RichTextBox()
        Me.panelIncorrecto = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.panelIncorrecto.SuspendLayout()
        Me.SuspendLayout()
        '
        'temporizador
        '
        Me.temporizador.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(170, 283)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(337, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'lblMarcadorBarra
        '
        Me.lblMarcadorBarra.AutoSize = True
        Me.lblMarcadorBarra.Location = New System.Drawing.Point(288, 264)
        Me.lblMarcadorBarra.Name = "lblMarcadorBarra"
        Me.lblMarcadorBarra.Size = New System.Drawing.Size(24, 13)
        Me.lblMarcadorBarra.TabIndex = 1
        Me.lblMarcadorBarra.Text = "0 %"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 39)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCorregir
        '
        Me.btnCorregir.Location = New System.Drawing.Point(530, 163)
        Me.btnCorregir.Name = "btnCorregir"
        Me.btnCorregir.Size = New System.Drawing.Size(75, 62)
        Me.btnCorregir.TabIndex = 3
        Me.btnCorregir.Text = "Corregir"
        Me.btnCorregir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(118, 62)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(354, 199)
        Me.txtTexto.TabIndex = 7
        Me.txtTexto.Text = ""
        '
        'panelIncorrecto
        '
        Me.panelIncorrecto.Controls.Add(Me.btnNo)
        Me.panelIncorrecto.Controls.Add(Me.btnSi)
        Me.panelIncorrecto.Controls.Add(Me.Label1)
        Me.panelIncorrecto.Location = New System.Drawing.Point(170, 106)
        Me.panelIncorrecto.Name = "panelIncorrecto"
        Me.panelIncorrecto.Size = New System.Drawing.Size(246, 119)
        Me.panelIncorrecto.TabIndex = 8
        Me.panelIncorrecto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Quieres ver el examen?"
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(19, 71)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(75, 23)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Text = "SI"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(142, 71)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Text = "NO"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'FCorrecion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 393)
        Me.Controls.Add(Me.panelIncorrecto)
        Me.Controls.Add(Me.txtTexto)
        Me.Controls.Add(Me.btnCorregir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMarcadorBarra)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "FCorrecion"
        Me.Text = "Form2"
        Me.panelIncorrecto.ResumeLayout(False)
        Me.panelIncorrecto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents temporizador As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblMarcadorBarra As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCorregir As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents panelIncorrecto As System.Windows.Forms.Panel
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
