Public Class FConsultar
    Dim copiaNumAlumos As Integer = NAlumnos


    Public Function anadirAlumnos()
        Dim fila As Integer = tabla.Length
        Dim alu As New Alumnos
        'If Me.txtValor.Text <> "" Then
        'While (copiaNumAlumos > 0)

        For Each alu In tablaDatos
            If Not IsNothing(alu) Then

                Me.lstAlumnos.Items.Add(alu.getApellido & ", " & alu.getNombre)
            End If
        Next
        'Me.lstAlumnos.Items.Add(tabla(copiaNumAlumos - 1, 2) & ", " & tabla(copiaNumAlumos - 1, 1))
        'copiaNumAlumos = copiaNumAlumos - 1

        ' End While

        ' End If
    End Function

    Private Sub FConsultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anadirAlumnos()
    End Sub
End Class