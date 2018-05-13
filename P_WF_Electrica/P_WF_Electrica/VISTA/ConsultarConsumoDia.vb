Imports System.IO

Public Class ConsultarConsumoDia

    Private Sub ConsultarConsumoDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboMes()
        cargarComboSemana()
        'cargarListView()
    End Sub

    Public Sub cargarComboMes()

        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String

        Linea = srLector.ReadLine()

        Do While Not (Linea Is Nothing)
            cmbMes.Items.Add(Linea)
            For i = 1 To 5
                Linea = srLector.ReadLine()
            Next
        Loop
        srLector.Close()
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
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim listaCaracteres() As String

        If Integer.Parse(cmbMes.SelectedIndex) > 0 Then
            Linea = srLector.ReadLine()
            For a = 0 To Integer.Parse(cmbMes.SelectedIndex) - 1
                For b = 0 To 4 'PARA QUE SE SALTE LAS SEMANASY SOLO RECOGA EL NOMBRE DEL MES
                    Linea = srLector.ReadLine()
                Next
            Next
        Else
            Linea = srLector.ReadLine()
        End If

        If Integer.Parse(cmbSemana.SelectedIndex) > 0 Then
            For i = 0 To Integer.Parse(cmbSemana.SelectedIndex) 'LE DIGO QUE EMPIECE EN -1 PORQUE LA 1 SEMANA ESTÁ EN LA POSICIÓN 0 DEL COMBOBOX
                Linea = srLector.ReadLine()
            Next
        Else
            Linea = srLector.ReadLine()
        End If

        listaCaracteres = Linea.Split(";")

        For a = 0 To diasSemana.Length - 1

            lstComsumosDias.Items.Add(diasSemana(a)).SubItems.Add(listaCaracteres(a) & " kW/h")

        Next

        srLector.Close()

    End Sub

    Private Sub cmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMes.SelectedIndexChanged
        lstComsumosDias.Clear()
        lstComsumosDias.Columns.Add("Día")
        lstComsumosDias.Columns.Add("Potencia")
        cargarListView()
    End Sub

    Private Sub cmbSemana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemana.SelectedIndexChanged
        lstComsumosDias.Clear()
        lstComsumosDias.Columns.Add("Día")
        lstComsumosDias.Columns.Add("Potencia")
        cargarListView()
    End Sub
End Class