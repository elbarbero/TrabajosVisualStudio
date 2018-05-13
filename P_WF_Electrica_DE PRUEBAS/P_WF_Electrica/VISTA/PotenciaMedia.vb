Imports System.IO

Public Class PotenciaMedia
    Private Sub PotenciaMedia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboDias()
        cargarComboMeses()
    End Sub

    Public Function calcularPotenciaMediaTotal()
        Dim suma As Double
        Dim media As Double
        Dim numDias As Integer

        For a = 0 To 2 'PARA LOS MESES
            For b = 0 To 3 'PARA LAS SEMANAS
                For c = 0 To 6
                    suma = suma + DATOS(a, b, c)

                Next
                numDias = numDias + 7
            Next
        Next

        media = (suma / numDias)
        labelMediaTotal.Text = "La Media total de todos los meses es de " & media & " kW/h"

        Return media

    End Function

    Public Sub cargarComboDias()

        For a = 0 To diasSemana.Length - 1
            cmbDias.Items.Add(diasSemana(a))
        Next
        cmbDias.Items.Insert(0, "----------")

        cmbDias.SelectedIndex = 0 'LE INDICAMOS EN QUE POSICIÓN QUEREMOS QUE EMPIECE
    End Sub

    Public Sub cargarComboMeses()

        For i = 0 To 2
            cmbMeses.Items.Add(nMeses(indiceMes(i)))
        Next

        cmbMeses.Items.Insert(0, "----------")

        cmbMeses.SelectedIndex = 0 'LE INDICAMOS EN QUE POSICIÓN QUEREMOS QUE EMPIECE

    End Sub

    Public Sub calcularPotenciaMediaDelMes()
        Dim suma As Double
        Dim media As Double
        Dim numDias As Integer
        Dim mesElegido As String

        If Integer.Parse(cmbMeses.SelectedIndex) > 0 Then
            For a = 1 To cmbMeses.SelectedIndex
                mesElegido = nMeses(indiceMes((a - 1)))
                For b = 0 To 3
                    For c = 0 To 6
                        suma = suma + DATOS((a - 1), b, c)
                        numDias = numDias + 1
                    Next
                Next
            Next
        Else
            calcularPotenciaMediaTotal()
        End If

        media = suma / numDias
        labelMediaXMes.Text = "La Media total del mes de " & mesElegido & " es de " & media & " kW/h"

    End Sub

    Public Sub calcularPotenciaMediaDelDia()
        Dim suma As Double
        Dim media As Double
        Dim diaElegido As String
        Dim numDias As Integer

        If Integer.Parse(cmbDias.SelectedIndex) > 0 Then
            For i = 0 To 2
                For b = 0 To 3
                    For c = cmbDias.SelectedIndex - 1 To cmbDias.SelectedIndex - 1
                        diaElegido = diasSemana(cmbDias.SelectedIndex - 1)
                        suma = suma + DATOS(i, b, c)
                        numDias = numDias + 1
                    Next
                Next
            Next
        Else
            calcularPotenciaMediaTotal()
        End If

        media = suma / numDias
        labelMediaXDia.Text = "La Media total de todos los " & diaElegido & " es de " & media & " kW/h"

    End Sub

    Private Sub cmbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMeses.SelectedIndexChanged
        calcularPotenciaMediaDelMes()
    End Sub

    Private Sub cmbDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDias.SelectedIndexChanged
        calcularPotenciaMediaDelDia()
    End Sub
End Class