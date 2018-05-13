Public Class FConsultaProductos
    Private Sub FConsultaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Bebidas' Puede moverla o quitarla según sea necesario.
        Me.BebidasTableAdapter.Fill(Me.EcoPrimeDataSet.Bebidas)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Alimentos' Puede moverla o quitarla según sea necesario.
        Me.AlimentosTableAdapter.Fill(Me.EcoPrimeDataSet.Alimentos)
        'TODO: esta línea de código carga datos en la tabla 'EcoPrimeDataSet.Menaje' Puede moverla o quitarla según sea necesario.
        Me.MenajeTableAdapter.Fill(Me.EcoPrimeDataSet.Menaje)

    End Sub


    '--------------------------------------PESTAÑA DE MENAJE-------------------------------------

    Private Sub dgvMenaje_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvMenaje.CellMouseClick
        Convert.ToString(dgvMenaje.CurrentRow.Cells(6).Value)

        Me.imagenMenaje.SizeMode = PictureBoxSizeMode.StretchImage
        If dgvMenaje.CurrentRow.Cells(6).Value <> "" Then
            Me.imagenMenaje.Image = Image.FromFile(Convert.ToString(dgvMenaje.CurrentRow.Cells(6).Value))
        Else
            Me.imagenMenaje.Image = Image.FromFile("C:\Users\Mario-Portatil\Desktop\Mantenimiento_EcoPrime\EcoPrime_Manten\ecoprime_manten\bin\Debug\LogoEcoPrime.png")
        End If
    End Sub


    '--------------------------------------PESTAÑA DE ALIMENTOS-------------------------------------

    Private Sub dgvAlimentos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAlimentos.CellMouseClick
        Convert.ToString(dgvAlimentos.CurrentRow.Cells(6).Value)

        Me.imagenAlimentos.SizeMode = PictureBoxSizeMode.StretchImage
        If dgvAlimentos.CurrentRow.Cells(6).Value <> "" Then
            Me.imagenAlimentos.Image = Image.FromFile(Convert.ToString(dgvAlimentos.CurrentRow.Cells(6).Value))
        Else
            Me.imagenAlimentos.Image = Image.FromFile("C:\Users\Mario-Portatil\Desktop\Mantenimiento_EcoPrime\EcoPrime_Manten\ecoprime_manten\bin\Debug\LogoEcoPrime.png")
        End If
    End Sub


    '--------------------------------------PESTAÑA DE BEBIDAS-------------------------------------

    Private Sub dgvBebidas_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBebidas.CellMouseClick
        Convert.ToString(dgvBebidas.CurrentRow.Cells(6).Value)

        Me.imagenBebidas.SizeMode = PictureBoxSizeMode.StretchImage
        If dgvBebidas.CurrentRow.Cells(6).Value <> "" Then
            Me.imagenBebidas.Image = Image.FromFile(Convert.ToString(dgvBebidas.CurrentRow.Cells(6).Value))
        Else
            Me.imagenBebidas.Image = Image.FromFile("C:\Users\Mario-Portatil\Desktop\Mantenimiento_EcoPrime\EcoPrime_Manten\ecoprime_manten\bin\Debug\LogoEcoPrime.png")
        End If
    End Sub


End Class