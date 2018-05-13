<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComprobarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobarToolStripMenuItem, Me.VisualizarToolStripMenuItem, Me.EnviarEmailToolStripMenuItem, Me.GeneralExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComprobarToolStripMenuItem
        '
        Me.ComprobarToolStripMenuItem.Name = "ComprobarToolStripMenuItem"
        Me.ComprobarToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ComprobarToolStripMenuItem.Text = "Comprobar Examen"
        '
        'VisualizarToolStripMenuItem
        '
        Me.VisualizarToolStripMenuItem.Name = "VisualizarToolStripMenuItem"
        Me.VisualizarToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.VisualizarToolStripMenuItem.Text = "Visualizar List Box"
        '
        'EnviarEmailToolStripMenuItem
        '
        Me.EnviarEmailToolStripMenuItem.Name = "EnviarEmailToolStripMenuItem"
        Me.EnviarEmailToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.EnviarEmailToolStripMenuItem.Text = "Enviar Email"
        '
        'GeneralExcelToolStripMenuItem
        '
        Me.GeneralExcelToolStripMenuItem.Name = "GeneralExcelToolStripMenuItem"
        Me.GeneralExcelToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.GeneralExcelToolStripMenuItem.Text = "General Excel"
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MARIO_Examen_2ev.My.Resources.Resources.portada
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 379)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EducArte S.L."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ComprobarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
