Imports System.IO
Imports Microsoft.Office.Interop

Public Class Estadisticas

    Dim arrayListInfo As ArrayList

    Private Sub btnInformeTrimestral_Click(sender As Object, e As EventArgs) Handles btnInformeTrimestral.Click
        recogerInfoDelFichero(arrayListInfo)
        'Dim prueba As Integer = arrayListInfo.Count
        importarExcelInformeTotal(arrayListInfo, "Todos los meses")
    End Sub

    Private Sub btnInformeSemanal_Click(sender As Object, e As EventArgs) Handles btnInformeSemanal.Click
        panelInformeSemanal.Visible = True
        panelInformeSemanal.Show()
    End Sub

    Public Sub cargarMesesEnListView()

        For i = 0 To indiceMes.Length - 1
            lstMesesEstadisticas.Items.Add(nMeses(indiceMes(i)))
        Next

    End Sub

    Public Sub cargarComboSemana()
        'cmbSemana.Items.Insert(0, "----------")
        cmbSemana.Items.Add("1")
        cmbSemana.Items.Add("2")
        cmbSemana.Items.Add("3")
        cmbSemana.Items.Add("4")
        cmbSemana.SelectedIndex = 0 'LE INDICAMOS EN QUE POSICIÓN QUEREMOS QUE EMPIECE
    End Sub

    Private Sub panelInformeSemanal_Paint(sender As Object, e As PaintEventArgs) Handles panelInformeSemanal.Paint
        cargarMesesEnListView()
        cargarComboSemana()
    End Sub

    Private Sub btnGeneralExcel_Click(sender As Object, e As EventArgs) Handles btnGeneralExcel.Click
        Try
            ' lstMesesEstadisticas.SelectedItems(0).Text-->Me devuelve el valor seleccionado en la columna 0
            Dim cabecera As String = "Informe semanal del mes " & lstMesesEstadisticas.SelectedItems(0).Text
            importarExcelInformeSemanal(cabecera, lstMesesEstadisticas.SelectedItems.Count, cmbSemana.SelectedIndex)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("DEBES SELECCIONAR UN MES")
        End Try
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        panelInformeSemanal.Visible = False
        cmbSemana.Items.Clear()
        lstMesesEstadisticas.Clear()
        lstMesesEstadisticas.Columns.Add("Meses")
    End Sub
End Class