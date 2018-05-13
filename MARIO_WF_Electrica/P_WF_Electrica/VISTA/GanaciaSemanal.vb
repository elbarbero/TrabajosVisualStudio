Imports System.IO
Public Class GanaciaSemanal

    Dim arrayPrecios As ArrayList = New ArrayList
    Dim arrayGanacia As ArrayList = New ArrayList

    Public Sub grabarPreciosEnArray()
        arrayPrecios.Add(txtSemana1.Text)
        arrayPrecios.Add(txtSemana2.Text)
        arrayPrecios.Add(txtSemana3.Text)
        arrayPrecios.Add(txtSemana4.Text)
        arrayPrecios.Add(txtSemana5.Text)
        arrayPrecios.Add(txtSemana6.Text)
        arrayPrecios.Add(txtSemana7.Text)
        arrayPrecios.Add(txtSemana8.Text)
        arrayPrecios.Add(txtSemana9.Text)
        arrayPrecios.Add(txtSemana10.Text)
        arrayPrecios.Add(txtSemana11.Text)
        arrayPrecios.Add(txtSemana12.Text)
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        grabarPreciosEnArray()
        btnCalcular.Enabled = True
    End Sub

    Public Sub calcularGanacia()
        Dim numSemana As Integer = -1

        For a = 0 To DATOS(2, 3, 6).ToString.Length  'LEEMOS DEL ARRAY TRIDIMENSIONAL
            For i = 0 To 2
                For b = 0 To 3
                    For c = 0 To 6

                        arrayGanacia.Add(DATOS(i, b, c))
                        a = a + 1
                    Next
                Next
            Next
        Next

    End Sub

    Public Sub mostrarGanacias()
        txtGanacia1.Text = arrayGanacia(0)
        txtGanacia2.Text = arrayGanacia(1)
        txtGanacia3.Text = arrayGanacia(2)
        txtGanacia4.Text = arrayGanacia(3)
        txtGanacia5.Text = arrayGanacia(4)
        txtGanacia6.Text = arrayGanacia(5)
        txtGanacia7.Text = arrayGanacia(6)
        txtGanacia8.Text = arrayGanacia(7)
        txtGanacia9.Text = arrayGanacia(8)
        txtGanacia10.Text = arrayGanacia(9)
        txtGanacia11.Text = arrayGanacia(10)
        txtGanacia12.Text = arrayGanacia(11)

        txtGanciaTotal.Text = 0
        For i = 0 To 11
            txtGanciaTotal.Text = txtGanciaTotal.Text + arrayGanacia(i)
        Next
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        calcularGanacia()
        mostrarGanacias()
    End Sub
End Class