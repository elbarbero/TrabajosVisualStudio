Public Class F_Timer

    'CUANTO MAS ALGO SEA NÚMERO DEL INTERVALO DEL TIMER, MÁS LENTAS IRÁN LAS IMAGENES
    Private Sub temporizador_Tick(sender As Object, e As EventArgs) Handles temporizador.Tick
        Static imagen As Integer
        Dim direccion As String
        Dim X, Y As Integer
        direccion = "C:\Users\Mario\Documents\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\Ejemplo_Timer\Ejemplo_Timer\"
        Select Case imagen
            Case 0
                direccion &= "bici barro 2.bmp"
            Case 1
                direccion &= "bici barro 3.jpg"
            Case 2
                direccion &= "bici barro.png"
            Case 3
                direccion &= "CAM00041.jpg"
        End Select
        'CENTRAMOS LA IMAGEN EN ELL FORMULARIO
        X = (Screen.PrimaryScreen.WorkingArea.Width - imgImagen.Width) / 2
        Y = (Screen.PrimaryScreen.WorkingArea.Height - imgImagen.Height) / 2
        'POSICIONAMOS  LA IMAGEN
        imgImagen.Location = New Point(X, Y)
        imagen += 1
        If imagen > 4 Then
            imagen = 0
        Else
            'CARGAMOS LA IMAGEN EN UN OBJETO PICTUREBOX
            imgImagen.Image = Image.FromFile(direccion)
        End If
    End Sub

End Class
