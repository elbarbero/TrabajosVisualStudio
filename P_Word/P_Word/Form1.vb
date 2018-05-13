Imports Microsoft.Office.Interop

Public Class Form1
    Dim oWord As New Word.Application
    Dim oDocumento As Word.Document

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'oWord.Application.ActiveDocument.SaveAs("D:\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_Word\Entrada_De_Datos.pdf")
        oWord.Quit()
        oWord = Nothing
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim oDocumento As Object
        oDocumento = oWord.Documents.Open("D:\Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\P_Word\Entrada_De_Datos.docx")
    End Sub

    Private Sub btnVerTexto_Click(sender As Object, e As EventArgs) Handles btnVerTexto.Click
        Dim palabra As Word.Range
        For Each palabra In oWord.ActiveDocument.Words
            MessageBox.Show(palabra.Text)
        Next
    End Sub

    Private Sub btnRellenarCampos_Click(sender As Object, e As EventArgs) Handles btnRellenarCampos.Click
        oDocumento.Bookmarks.Item("Nombre").Range.Text = "Mario"
        oDocumento.Bookmarks.Item("fecha").Range.Text = Now

        oDocumento.Content.Find.Execute2007(FindText:="ciudad", ReplaceWith:="Burgos")

        oDocumento.PrintOut()
    End Sub
End Class