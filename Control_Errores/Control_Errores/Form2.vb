Imports System.IO

Public Class Form2

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim sNombreDir As String
        Dim Archivos() As String
        Dim Archivo As String
        Dim oDirInfo As DirectoryInfo
        sNombreDir = InputBox("Introducir un nombre de directorio")
        If Directory.Exists(sNombreDir) Then 'SI EXISTE LA RUTA...
            MessageBox.Show("Fecha último acceso: " &
            Directory.GetLastAccessTime(sNombreDir))
            Archivos = Directory.GetFiles(sNombreDir) 'GUARDAMOS TODAS LAS CARPETAS (Y SUBCARPETAS) QUE CONTIENE
            For Each Archivo In Archivos 'ME BUSCA LOS ARCHIVOS QUE HAY EN LAS CARPETAS
                MessageBox.Show(Archivo)
            Next
            oDirInfo = New DirectoryInfo(sNombreDir) 'RECOJO EL NOMBRE DEL DIRECTORIO ACTUAL
            oDirInfo.CreateSubdirectory("bak")
        Else
            Directory.CreateDirectory(sNombreDir)
            MessageBox.Show("No existía el directorio, se acaba de crear")
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim sNombreDir As String
        Dim oDirInfo As DirectoryInfo
        ' obtenemos el directorio actual de ejecución
        sNombreDir = Directory.GetCurrentDirectory()
        MessageBox.Show("Directorio actual: " & sNombreDir)
        ' obtenemos el directorio padre del actual, y mostramos información de dicha directorio
        oDirInfo = Directory.GetParent(sNombreDir)
        MessageBox.Show("Directorio padre y fecha de creación " &
        ControlChars.CrLf, oDirInfo.FullName &
        ControlChars.CrLf & oDirInfo.CreationTime)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        MessageBox.Show(Application.StartupPath) 'ME DICE LA RUTA
        MessageBox.Show(Application.ExecutablePath) 'ME DICE LA RUTA Y EL NOMBRE DE LA APLICACION
    End Sub
End Class