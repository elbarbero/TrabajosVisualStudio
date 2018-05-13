Public Class FConsulta
    Private Sub FConsulta_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanelProducto.Enabled = True
        PanelFamilia.Visible = False
        PanelProducto.Visible = False
        Me.Size = New System.Drawing.Size(800, 600)
        Dim desktopSize As Size
        desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize
        Dim alto As Integer = desktopSize.Height
        Dim ancho As Integer = desktopSize.Width
        Me.Top = Convert.ToInt16(alto - Me.Height) / 2
        Me.Left = Convert.ToInt16(ancho - Me.Width) / 2
        Me.PanelFamilia.Top = Convert.ToInt16(Me.Height - Me.PanelFamilia.Height) / 2
        Me.PanelFamilia.Left = Convert.ToInt16(Me.Width - Me.PanelFamilia.Width) / 2
    End Sub
    Private Sub BtnProducto_Click(sender As Object, e As EventArgs) Handles BtnProducto.Click
        Dim objeto As Control
        For Each objeto In PanelProducto.Controls
            objeto.Text = ""
        Next
        TxtEXActuales.Clear()
        TxtExMinimas.Clear()
        PanelProducto.Enabled = False
        PanelProducto.Visible = True
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If txtCodigo.Text <> "" Then
            Dim fila As Integer = buscarCodigo(txtCodigo.Text)
            If fila = -1 Then
                MessageBox.Show("El código no existe en la Base de Datos", "C U I D A D O", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCodigo.Focus()
                Exit Sub
            End If
            txtFamilia.Text = tabla(fila, 1)
            txtFechaAlta.Text = tabla(fila, 2)
            txtFechaAlta.Text = tabla(fila, 3)
            TxtEXActuales.Text = tabla(fila, 4)
            TxtExMinimas.Text = tabla(fila, 5)
        End If
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        PanelProducto.Visible = False
        PanelProducto.Enabled = True
    End Sub

    Private Sub BtnFamilias_Click(sender As Object, e As EventArgs) Handles BtnFamilias.Click
        PanelFamilia.Visible = True
        PanelProducto.Enabled = False
    End Sub
    Private Sub BtnBuscaFamilia_Click(sender As Object, e As EventArgs) Handles BtnBuscaFamilia.Click
        lbldatos.Text = "El nº de productos de la familia es : " &
       UnidadesFamilia(NupDownFamilia.Value)
    End Sub
    Private Sub BtnSalirFamilia_Click(sender As Object, e As EventArgs) Handles BtnSalirFamilia.Click
        PanelFamilia.Visible = False
        PanelProducto.Enabled = True
    End Sub
End Class