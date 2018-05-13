Imports System.IO

Public Class PotenciaMedia
    Private Sub PotenciaMedia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboDias()
        cargarComboMeses()
    End Sub

    Public Function calcularPotenciaMediaTotal()
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim listaCaracteres() As String
        Dim suma As Double
        Dim media As Double
        Dim numDias As Integer

        Linea = srLector.ReadLine()
        For a = 0 To 2 'PARA LOS MESES
            For b = 0 To 3 'PARA LAS SEMANAS
                Linea = srLector.ReadLine()
                For c = 0 To 6 'PARA LOS DÍAS
                    listaCaracteres = Linea.Split(";")
                    suma = suma + listaCaracteres(c)
                Next
                numDias = numDias + 7
            Next
            Linea = srLector.ReadLine()
        Next

        media = (suma / numDias)
        srLector.Close()
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

        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String

        For a = 0 To 2 'PARA LOS MESES
            Linea = srLector.ReadLine()
            cmbMeses.Items.Add(Linea) 'INSERTAMOS EL MES
            For b = 0 To 3 'PARA LAS SEMANAS
                Linea = srLector.ReadLine()
            Next
        Next

        cmbMeses.Items.Insert(0, "----------")

        cmbMeses.SelectedIndex = 0 'LE INDICAMOS EN QUE POSICIÓN QUEREMOS QUE EMPIECE
        srLector.Close()

    End Sub

    Public Sub calcularPotenciaMediaDelMes()
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim listaCaracteres() As String
        Dim suma As Double
        Dim media As Double
        Dim numDias As Integer
        Dim mesElegido As String

        If Integer.Parse(cmbMeses.SelectedIndex) > 0 Then
            For a = 1 To cmbMeses.SelectedIndex  'PARA LOS MESES
                Linea = srLector.ReadLine()
                mesElegido = Linea
                For b = 0 To 3 'PARA LAS SEMANAS
                    Linea = srLector.ReadLine()
                    For c = 0 To 6 'PARA LOS DÍAS
                        listaCaracteres = Linea.Split(";")
                        suma = suma + listaCaracteres(c)
                    Next
                    numDias = numDias + 7
                Next
            Next
            Linea = srLector.ReadLine()
        Else
            calcularPotenciaMediaTotal()
        End If
        media = suma / numDias
        srLector.Close()
        labelMediaXMes.Text = "La Media total del mes de " & mesElegido & " es de " & media & " kW/h"

    End Sub

    Public Sub calcularPotenciaMediaDelDia()
        Dim srLector As StreamReader = New StreamReader(directorio & "\informacion.txt")
        Dim Linea As String
        Dim listaCaracteres() As String
        Dim suma As Double
        Dim media As Double
        Dim diaElegido As String
        Dim numDias As Integer

        If Integer.Parse(cmbDias.SelectedIndex) > 0 Then
            For a = 0 To 2  'PARA LOS MESES
                Linea = srLector.ReadLine()
                For b = 0 To 3 'PARA LAS SEMANAS
                    Linea = srLector.ReadLine()
                    For c = cmbDias.SelectedIndex - 1 To cmbDias.SelectedIndex - 1 'PARA LOS DÍAS
                        diaElegido = diasSemana(cmbDias.SelectedIndex - 1)
                        listaCaracteres = Linea.Split(";")
                        suma = suma + listaCaracteres(c)
                        numDias = numDias + 1
                    Next
                Next
            Next
            Linea = srLector.ReadLine()
        Else
            calcularPotenciaMediaTotal()
        End If
        media = suma / numDias
        srLector.Close()
        labelMediaXDia.Text = "La Media total de todos los " & diaElegido & " es de " & media & " kW/h"

    End Sub

    Private Sub cmbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMeses.SelectedIndexChanged
        calcularPotenciaMediaDelMes()
    End Sub

    Private Sub cmbDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDias.SelectedIndexChanged
        calcularPotenciaMediaDelDia()
    End Sub
End Class