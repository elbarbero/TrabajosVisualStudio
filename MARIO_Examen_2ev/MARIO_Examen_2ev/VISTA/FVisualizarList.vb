Public Class FVisualizarList

    Private Sub FVisualizarList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtModulo.Text = Modulos(examenAlumno(0))

        txtAlumno.Text = examenAlumno(1) & "-" & calcularLetraDNI(examenAlumno(1))
        txtEmail.Text = examenAlumno(2)
        cargarListView()

    End Sub

    Public Sub cargarListView()
        Dim listView As New ListViewItem
        Dim a As Integer = 3
        Dim b As Integer = 0
        Dim numeroPregunta As Integer = 0
        Dim respuestas As ArrayList = New ArrayList

        For i = 4 To examenAlumno.Length - 1 'PONGO LA RESPUESTA DE LA PREGUNTA
            If examenAlumno(i) <> "" Then
                If DatosReales(numeroPregunta) = examenAlumno(i - 1) Then

                    If DatosReales(numeroPregunta + 1) = examenAlumno(i) Then

                        respuestas.Add("correcta")

                        i = i + 1
                        numeroPregunta = numeroPregunta + 1
                    ElseIf DatosReales(numeroPregunta + 1) <> examenAlumno(i) Then
   
                        respuestas.Add("Incorrecta")

                        i = i + 1
                        numeroPregunta = numeroPregunta + 1
                    End If

                Else

                    respuestas.Add("en blanco")

                    i = i - 1
                    numeroPregunta = numeroPregunta + 1
                End If

                numeroPregunta = numeroPregunta + 1
            End If
        Next

        numeroPregunta = 0
        For d = 0 To respuestas.Count - 1
            listView = lstExamen.Items.Add(DatosReales(numeroPregunta))
            listView.SubItems.Add(respuestas(d))
            numeroPregunta = numeroPregunta + 1
            numeroPregunta = numeroPregunta + 1
        Next
     
    End Sub

End Class