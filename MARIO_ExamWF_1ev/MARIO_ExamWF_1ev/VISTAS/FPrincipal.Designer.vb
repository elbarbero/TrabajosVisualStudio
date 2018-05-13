<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WFPrincipal
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlta = New System.Windows.Forms.Button()
        Me.imgPrincipal = New System.Windows.Forms.PictureBox()
        CType(Me.imgPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.MARIO_ExamWF_1ev.My.Resources.Resources.iconoConsultar
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsultar.Location = New System.Drawing.Point(428, 181)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(132, 81)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlta
        '
        Me.btnAlta.BackgroundImage = Global.MARIO_ExamWF_1ev.My.Resources.Resources.iconoAñadir
        Me.btnAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAlta.Location = New System.Drawing.Point(431, 66)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(130, 77)
        Me.btnAlta.TabIndex = 1
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'imgPrincipal
        '
        Me.imgPrincipal.BackgroundImage = Global.MARIO_ExamWF_1ev.My.Resources.Resources.ROBOTIX_Certified_Partner_black
        Me.imgPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgPrincipal.Location = New System.Drawing.Point(25, 36)
        Me.imgPrincipal.Name = "imgPrincipal"
        Me.imgPrincipal.Size = New System.Drawing.Size(342, 245)
        Me.imgPrincipal.TabIndex = 0
        Me.imgPrincipal.TabStop = False
        '
        'WFPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 341)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.imgPrincipal)
        Me.Name = "WFPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de productos"
        CType(Me.imgPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgPrincipal As System.Windows.Forms.PictureBox
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button

End Class
