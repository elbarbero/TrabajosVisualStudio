Module ModuleControl
    Public Function buscarCodigo(codigo As String) As Integer
        Dim esta As Integer = -1
        If Not IsNothing(tabla(0, 0)) Then
            Dim f As Integer
            While esta = -1 And f < 500
                If tabla(f, 0) = codigo Then
                    esta = f
                Else
                    f += 1
                End If
            End While
        End If
        Return esta
    End Function

    Public Function comprobarexistencias(ExActuales, ExMinimas) As Byte
        Dim Terror As Byte = 0
        Dim ExA As Integer
        Dim ExM As Integer
        If ExActuales <> "" Then
            ExA = Convert.ToInt16(ExActuales)
            If ExA < 0 Then
                Terror = 1
            End If
        End If
        If ExMinimas <> "" Then
            ExM = Convert.ToInt16(ExMinimas)
            If ExM < 0 Then
                Terror = 1
            End If
        End If
        If ExActuales <> "" And ExMinimas <> "" Then
            ExA = Convert.ToInt16(ExActuales)
            ExM = Convert.ToInt16(ExMinimas)
            If ExM > ExA Then
                Terror = 2
            End If
        End If
        Return Terror
    End Function

    Public Function UnidadesFamilia(Familia) As Integer
        Dim unidades As Integer
        Dim fila As Integer
        For fila = 0 To tabla.GetUpperBound(0)
            If tabla(fila, 1) = Familia Then
                unidades += 1
            End If
        Next
        Return unidades
    End Function

End Module
