<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pricipal
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
        Me.ComprobarArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsumoDíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PotenciaMediaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GananciaSemanalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprobarArchivoToolStripMenuItem, Me.PreciosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.GestiónContratosToolStripMenuItem, Me.EstadisticasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(896, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComprobarArchivoToolStripMenuItem
        '
        Me.ComprobarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComprobarArchivoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ComprobarArchivoToolStripMenuItem.Name = "ComprobarArchivoToolStripMenuItem"
        Me.ComprobarArchivoToolStripMenuItem.Size = New System.Drawing.Size(151, 24)
        Me.ComprobarArchivoToolStripMenuItem.Tag = ""
        Me.ComprobarArchivoToolStripMenuItem.Text = "Comprobar Archivo"
        Me.ComprobarArchivoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.ComprobarArchivoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ComprobarArchivoToolStripMenuItem.ToolTipText = "Comprobar Archivo de Datos"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.Enabled = False
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.PreciosToolStripMenuItem.Text = "Precios"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsumoDíaToolStripMenuItem, Me.PotenciaMediaToolStripMenuItem, Me.GananciaSemanalToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(84, 24)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsumoDíaToolStripMenuItem
        '
        Me.ConsumoDíaToolStripMenuItem.Enabled = False
        Me.ConsumoDíaToolStripMenuItem.Name = "ConsumoDíaToolStripMenuItem"
        Me.ConsumoDíaToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.ConsumoDíaToolStripMenuItem.Text = "Consumo Día"
        '
        'PotenciaMediaToolStripMenuItem
        '
        Me.PotenciaMediaToolStripMenuItem.Enabled = False
        Me.PotenciaMediaToolStripMenuItem.Name = "PotenciaMediaToolStripMenuItem"
        Me.PotenciaMediaToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.PotenciaMediaToolStripMenuItem.Text = "Potencia Media"
        '
        'GananciaSemanalToolStripMenuItem
        '
        Me.GananciaSemanalToolStripMenuItem.Enabled = False
        Me.GananciaSemanalToolStripMenuItem.Name = "GananciaSemanalToolStripMenuItem"
        Me.GananciaSemanalToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.GananciaSemanalToolStripMenuItem.Text = "Ganancia Semanal"
        '
        'GestiónContratosToolStripMenuItem
        '
        Me.GestiónContratosToolStripMenuItem.Enabled = False
        Me.GestiónContratosToolStripMenuItem.Name = "GestiónContratosToolStripMenuItem"
        Me.GestiónContratosToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.GestiónContratosToolStripMenuItem.Text = "Gestión Contratos"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Enabled = False
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(97, 24)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'Pricipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.P_WF_Electrica.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 395)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pricipal"
        Me.Text = "Pricipal"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ComprobarArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsumoDíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PotenciaMediaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GananciaSemanalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
