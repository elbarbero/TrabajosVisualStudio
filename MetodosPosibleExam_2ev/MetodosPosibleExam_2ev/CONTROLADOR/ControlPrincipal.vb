Imports System.IO

Module ControlPrincipal
    Public UNIDAD As String = Application.StartupPath.ToString.Substring(0, 3)
    Public directorio As String = UNIDAD & "DATOS"

    Public Sub main()
        If Directory.Exists(directorio) Then
            If File.Exists(directorio & "\informacion.txt") Then
                'Pricipal.ShowDialog()
            Else
                MessageBox.Show("NO EXISTE EL FICHERO")
            End If

        Else
            Directory.CreateDirectory(directorio)
            MessageBox.Show("Se ha creado la carpeta DATOS en la unidad " & UNIDAD & ChrW(13) &
                " Debe cargar el archivo información.txt en ella")
        End If
    End Sub

    Public Sub crearFicheroContratos()
        If Directory.Exists(directorio) Then
            If File.Exists(directorio & "\Contratos.txt") Then
                'MessageBox.Show("EXISTE")
                'Pricipal.ShowDialog()
                'insertarEnFichero()
            Else
                MessageBox.Show("NO EXISTIA EL FICHERO. HA SIDO CREADO")
                File.Create(directorio & "\Contratos.txt")
            End If

        Else
            Directory.CreateDirectory(directorio)
            MessageBox.Show("Se ha creado la carpeta DATOS en la unidad " & UNIDAD & ChrW(13) &
                " Debe cargar el archivo Contratos.txt en ella")
        End If
    End Sub

End Module
