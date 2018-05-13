Imports System.IO

Public Class Form1

    Dim Fichero As Stream
    Dim Archivo As New ArrayList
    Dim FicheroAbierto As String


    Private Sub txtArchivo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtArchivo.Validating
        If txtArchivo.Text <> "" Then
            If txtArchivo.Text.IndexOf(".") = -1 Then 'SI NO TIENE UN PUNTO
                MessageBox.Show("Debe poner extensión", " C U I D A D O")
                e.Cancel = True 'CANCELA EL EVENTO
            ElseIf txtArchivo.Text.IndexOf(".") <> txtArchivo.Text.IndexOf(".") Then
                MessageBox.Show("Debe contener un solo punto", " C U I D A D O")
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        If txtRuta.Text <> "" And txtArchivo.Text <> "" Then
            Try
                FicheroAbierto = txtRuta.Text & "\" & txtArchivo.Text
                Fichero = File.Open(FicheroAbierto, FileMode.Create, FileAccess.Write)
                MessageBox.Show("Fichero abierto para grabar (" & FicheroAbierto & "/", " C O R R E C T O")
                Archivo.Add(FicheroAbierto)
            Catch ex As DirectoryNotFoundException
                MessageBox.Show("La ruta introducida no existe")
            Catch ex As IOException
                MessageBox.Show("El fichero ya está abierto")
            Catch ex As Exception
                MessageBox.Show("Se ha producido una excepcion que impide crear el fichero")
            End Try
        Else
            MessageBox.Show("Se debe completar todos los datos")
            txtRuta.Focus()
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If txtRuta.Text <> "" And txtArchivo.Text <> "" Then
            Try
                FicheroAbierto = txtRuta.Text & "\" & txtArchivo.Text
                Fichero = File.Open(FicheroAbierto, FileMode.Create, FileAccess.Write)
                MessageBox.Show("Fichero abierto para grabar (" & FicheroAbierto & "/")
                Archivo.Add(FicheroAbierto)
                listaArchivosAbiertos(FicheroAbierto)
            Catch ex As DirectoryNotFoundException
                MessageBox.Show("La ruta introducida no existe")
            Catch ex As Exception
                MessageBox.Show("Se ha producido una excepcion que impide crear el fichero" & ChrW(10) &
                                ex.ToString, " C U I D A D O")
            End Try
        Else
            MessageBox.Show("Se debe completar todos los datos")
            txtRuta.Focus()
        End If
    End Sub


    Private Sub listaArchivosAbiertos(cadena As String)
        lstArchivos.Items.Clear()
        For Each elemento As String In Archivo
            lstArchivos.Items.Add(elemento)
        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Fichero.Close()
    End Sub

End Class
