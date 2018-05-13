Imports Microsoft.Office.Interop

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ObjWord As Word.Application
        Dim ObjRange As Word.Range
        Dim NChar As Long
        Dim texto As String
        'Crea un nuevo objeto de word
        ObjWord = CreateObject("Word.Application")
        ' agrega un nuevo documento
        ObjWord.Documents.Add()
        texto = vbCrLf & "Titulo: Ejemplo " & vbCrLf & _
        "Fecha: " & Date.Today & vbCrLf & _
        "Hora: " & Now.ToString("HH:mm:ss") & vbCrLf
        ObjRange = ObjWord.ActiveDocument.Range(Start:=0, End:=0)
        ' asigna el texto anterior
        ObjRange.Text = texto
        ' cantidad de caracteres
        NChar = ObjWord.ActiveDocument.Characters.Count
        ' selecciona el rango, es decir todo el texto anterior
        ObjRange = ObjWord.ActiveDocument.Range(Start:=0, End:=NChar - 1)
        ObjRange.Select()
        ' Le aplica formato al texto seleccionado
        With ObjWord
            .Selection.Font.Size = 10 ' tamaño
            .Selection.Font.Name = "Verdana" ' fuente
            .Selection.Font.ColorIndex = Word.WdColorIndex.wdBlue 'color
        End With
        ' Referencia al rango
        ObjRange = ObjWord.ActiveDocument.Range(Start:=0, End:=0)
        ObjRange.Select() ' lo selecciona
        Clipboard.Clear() ' limpia el portapapeles
        ' Establece la imagen de Image1 en el Portap.
        Clipboard.SetImage(Pimagen1.BackgroundImage)
        ' pega el gráfico
        ObjWord.Selection.Paste()
        ' limpia el Clipboard
        Clipboard.Clear()
        ObjWord.Visible = True ' hace el Word Visible. Lo abre 
    End Sub
End Class