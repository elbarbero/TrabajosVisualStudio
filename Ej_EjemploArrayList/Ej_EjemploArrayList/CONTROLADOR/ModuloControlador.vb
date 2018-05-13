Module ModuloControlador

    Dim incremento As Integer = 0

    Public Sub calcular(nivel As Byte, Libro As Boolean, DVD As Boolean, Internet As Boolean,
                        ByRef ImporteMaterial As Decimal, ByRef Importetotal As Decimal)
        Dim PrecioNivel As Integer
        incremento = 0
        Select Case nivel
            Case 1
                PrecioNivel = NivelB
            Case 2
                PrecioNivel = NivelM
                incremento = 10
            Case 3
                PrecioNivel = NivelA
                incremento = 20
        End Select
        ImporteMaterial = CosteMaterial(Libro, DVD, Internet)
        Importetotal = PrecioNivel + ImporteMaterial
    End Sub

    Private Function CosteMaterial(Libro As Boolean, DVD As Boolean, Internet As Boolean) As Single
        Dim coste As Single = 0
        If Libro Then
            coste = PrecioLibro * (1 + incremento / 100)
        End If
        If DVD Then
            coste += PrecioDVD * (1 + incremento / 100)
        End If
        If Internet Then
            coste += PrecioInternet * (1 + incremento / 100)
        End If
        Return coste
    End Function

    Public Function NumeroAlumno() As Integer
        If ListaAlumnos.Count = 0 Then
            Return 1
        Else
            Return ListaAlumnos.Count + 1
        End If
    End Function
End Module
