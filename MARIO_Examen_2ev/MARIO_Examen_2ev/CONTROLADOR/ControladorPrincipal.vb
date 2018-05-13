Imports System.IO

Module ControladorPrincipal

    Public UNIDAD As String = Application.StartupPath.ToString.Substring(0, 3)
    Public directorio As String = UNIDAD

    Public Sub Main()
        If Directory.Exists(directorio) Then
            If File.Exists("D:\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\ErrorFichero.txt") Then
                'MessageBox.Show("EXISTE")
                FPrincipal.Show()
                'insertarEnFichero()
            Else
                MessageBox.Show("NO EXISTIA, EL FICHERO. HA SIDO CREADO")
                File.Create(directorio & "\ErrorFichero.txt")
                FPrincipal.Show()
            End If

        Else
            Directory.CreateDirectory(directorio)
            MessageBox.Show("Se ha creado " & UNIDAD & ChrW(13) &
                " Debe cargar el archivo Contratos.txt en ella")
        End If
    End Sub

End Module
