Module Control
    Public tablaDatos(0) As Alumnos
    Public tabla(14, 7) As String
    Public NAlumnos As Integer = 0

    Public Function calcularLetraDNI(ByVal dni As TextBox) As Char
        Dim dniN As Integer = Convert.ToInt32(dni.Text)
        Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim posicion As Byte = dniN Mod 23
        Return letras.Chars(posicion)
    End Function

    Public Function comprobarHermanos(ByVal NumHermanos As TextBox)
        Dim formatoBien As Boolean = True
        Dim listaHermanos() As Char = NumHermanos.Text.ToCharArray
        If (NumHermanos.Text.Length > 2) Then
            formatoBien = False
        Else

            For i = 0 To listaHermanos.Length - 1
                If (Not Char.IsDigit(listaHermanos(i))) Then
                    formatoBien = False
                End If
            Next
        End If
        Return formatoBien
    End Function

    Public Function comprobarDNI(ByVal DniTutor As TextBox)
        Dim formatoBien As Boolean = True
        Dim listaDNI() As Char = DniTutor.Text.ToCharArray
        If (DniTutor.Text.Length > 9) Then
            formatoBien = False
        Else

            For i = 0 To listaDNI.Length - 1
                If (Not Char.IsDigit(listaDNI(i))) Then
                    formatoBien = False
                End If
            Next
        End If
        Return formatoBien
    End Function

    Public Function comprobarSexo(ByVal Sexo As TextBox)
        Dim formatoBien As Boolean = True
        Dim listaSexo() As Char = Sexo.Text.ToCharArray
        If (Sexo.Text.Length > 1) Then
            formatoBien = False
        Else

            For i = 0 To listaSexo.Length - 1
                If (Not Char.IsLetter(listaSexo(i))) Then
                    formatoBien = False
                Else
                    If Not (listaSexo(i) = "M" Or listaSexo(i) = "H") Then
                        formatoBien = False
                        'Else
                        '   formatoBien = False
                    End If
                End If
            Next
        End If
        Return formatoBien
    End Function

    Public Function comprobarFormatoFecha(ByVal FechaNac As TextBox, ByVal FechaConvertida As Date)
        Dim formatoBien As Boolean = True
        Dim vector() As String
        Dim listaNumeros() As Char
        If (IsDate(FechaNac.Text)) Then
            vector = FechaNac.Text.Split("/")
            If (Convert.ToDateTime(FechaNac.Text) > Date.Today) Then
                formatoBien = False
            Else
                If (vector.Length = 3) Then
                    For i = 0 To vector.Length - 1
                        listaNumeros = vector(i).ToCharArray
                        For a = 0 To listaNumeros.Length - 1 'HAGO ESTO PARA QUE ME COMPRUEBE LOS ESPACIOS EN BLANCO PORQUE EN EL AÑO LOS ACEPTA CON ISDATE
                            If (vector(0).Length > 2 Or vector(1).Length > 2 Or Char.IsWhiteSpace(listaNumeros(a))) Then
                                formatoBien = False
                                Exit For
                            End If
                        Next
                    Next
                Else

                    formatoBien = False
                End If
            End If
            If (formatoBien) Then
                FechaConvertida = Convert.ToDateTime(FechaNac.Text) 'CONVERTIMOS LA FECHA INTRODUCIDA A FORMATO FECHA
                FechaConvertida.ToString("dd/MM/yyyy")
            End If
        Else
            formatoBien = False
        End If

        Return formatoBien
    End Function

    '  'GUARDAR DATOS EN EL ARRAY 
    '  Dim alumno As New CAlumno With alumno
    '      .setNumatricula(LblMatricula.Text)
    '  .setNombre(TxtNombre.Text).setApellidos(TxtApellidos.Text)
    '  .setFnacimiento(DTPFechaNacimiento.Value)
    '  If RdBtnChica.Checked Then
    '  .setSexo("M")
    '  Else
    '  .setSexo("F")
    '  End If
    '  .setNombreTutor(TxtNombreTutor.Text)
    '  .setDni(MkTxtDNI.Text)
    '  .setNuHermanos(MkTxtNuHermanos.Text)
    '  End With
    '  Dim posicion As Integer = Convert.ToInt16(LblMatricula.Text) - 1
    '  TablaDatos(posicion) = alumno   
    '  posicion += 1  
    '     If posicion > Numatriculas Then
    '  MessageBox.Show("El curso está completo", "¡¡¡¡ A V I S O !!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)  
    '         Me.Close()
    '  Me.Dispose()
    '  Else
    '  ReDim Preserve TablaDatos(TablaDatos.Length)
    '  Call BtnCancelar_Click(sender, e)
    '  TxtNombre.Focus()       
    'End If

End Module
