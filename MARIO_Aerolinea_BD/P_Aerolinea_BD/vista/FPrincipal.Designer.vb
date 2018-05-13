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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VentaDePasajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaDePasajesToolStripMenuItem, Me.EnviarEmailToolStripMenuItem, Me.CrystalReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(764, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentaDePasajesToolStripMenuItem
        '
        Me.VentaDePasajesToolStripMenuItem.Name = "VentaDePasajesToolStripMenuItem"
        Me.VentaDePasajesToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.VentaDePasajesToolStripMenuItem.Text = "Venta de Pasajes"
        '
        'EnviarEmailToolStripMenuItem
        '
        Me.EnviarEmailToolStripMenuItem.Name = "EnviarEmailToolStripMenuItem"
        Me.EnviarEmailToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.EnviarEmailToolStripMenuItem.Text = "Enviar Email"
        '
        'CrystalReportToolStripMenuItem
        '
        Me.CrystalReportToolStripMenuItem.Name = "CrystalReportToolStripMenuItem"
        Me.CrystalReportToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.CrystalReportToolStripMenuItem.Text = "Crystal Report"
        '
        'FPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.P_Aerolinea_BD.My.Resources.Resources.avion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(764, 401)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aerolineas Jacinto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VentaDePasajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnviarEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CrystalReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
