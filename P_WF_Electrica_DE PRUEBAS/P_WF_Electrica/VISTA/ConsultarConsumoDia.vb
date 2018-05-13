Imports System.IO

Public Class ConsultarConsumoDia

    Dim esPrimeraVez As Boolean = True

    Private Sub ConsultarConsumoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboMes()
        cargarComboSemana()
        esPrimeraVez = True
        'cargarListView()
    End Sub

    Public Sub cargarComboMes()

        For i = 0 To 2
            cmbMes.Items.Add(nMeses(indiceMes(i)))
        Next

        cmbMes.SelectedIndex = 0 'LE INDICAMOS EN QUE POSICIÓN QUEREMOS QUE EMPIECE
    End Sub

    Public Sub cargarComboSemana()
        cmbSemana.Items.Add("1")
        cmbSemana.Items.Add("2")
        cmbSemana.Items.Add("3")
        cmbSemana.Items.Add("4")
        cmbSemana.SelectedIndex = 0 'LE INDICAMOS EN QUE POSICIÓN QUEREMOS QUE EMPIECE
    End Sub

    Public Sub cargarListView()
        Dim posMesCombo As Integer = Integer.Parse(cmbMes.SelectedIndex)
        Dim posSemanaCombo As Integer = Integer.Parse(cmbSemana.SelectedIndex)
        Dim ArrayConjunto As ArrayList = New ArrayList

        esPrimeraVez = False
        For d = 0 To 6
            If posSemanaCombo = -1 Then
                ArrayConjunto.Add(DATOS(posMesCombo, (posSemanaCombo + 1), d))
            Else
                ArrayConjunto.Add(DATOS(posMesCombo, posSemanaCombo, d))
            End If
        Next

        For a = 0 To diasSemana.Length - 1

            ' lstComsumosDias.Items.Add(diasSemana(a)).SubItems.Add(ArrayConjunto(a) & " kW/h")
            Dim listView As New ListViewItem

            listView = lstComsumosDias.Items.Add(diasSemana(a))
            listView.SubItems.Add(ArrayConjunto(a) & " kW/h")
            ' listView.SubItems.Add("Columna3")
        Next

    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        If esPrimeraVez Then
            lstComsumosDias.Clear()
            lstComsumosDias.Columns.Add("Día")
            lstComsumosDias.Columns.Add("Potencia")
            cargarListView()
            esPrimeraVez = True
        End If
    End Sub

    Private Sub cmbSemana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemana.SelectedIndexChanged
        If esPrimeraVez Then
            lstComsumosDias.Clear()
            lstComsumosDias.Columns.Add("Día")
            lstComsumosDias.Columns.Add("Potencia")
            cargarListView()
            esPrimeraVez = True
        End If
    End Sub
End Class