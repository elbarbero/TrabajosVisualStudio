Public Class FCorrecion

    Dim si As Boolean = False

    Private Sub btnCorregir_Click(sender As Object, e As EventArgs) Handles btnCorregir.Click
        'comprobarInfo(1)
        ' comprobarExamenAlumno("Grado Superior Desarrollo de Aplicaciones Multiplataforma\2 CURSO\Proyectos VisualStudio\MARIO_Examen_2ev\1 17100999.txt")
        leerCualquierArchivo()

    End Sub

    Public Sub leerCualquierArchivo()
        Dim nombre As String
        OpenFileDialog1.InitialDirectory = "D:\"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() =
        System.Windows.Forms.DialogResult.OK Then
            Try
                nombre = OpenFileDialog1.FileName

                If comprobarExamenAlumno(nombre) Then
                    todoCorrecto = True
                    '  temporizador.Start()
                    If (nombre IsNot Nothing) Then
                        txtTexto.Clear()
                        txtTexto.LoadFile(nombre, RichTextBoxStreamType.PlainText)
                    End If


                Else
                    temporizador.Start()
                    insertarEnFichero()
                    panelIncorrecto.Visible = True

                    'While panelIncorrecto.Visible = True

                    ' End While
                    If si Then
                        If (nombre IsNot Nothing) Then
                            txtTexto.Clear()
                            txtTexto.LoadFile(nombre, RichTextBoxStreamType.PlainText)
                        End If
                        ' panelIncorrecto.Visible = False
                    Else
                        'panelIncorrecto.Visible = False
                    End If

                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub

    Private Sub temporizador_Tick(sender As Object, e As EventArgs) Handles temporizador.Tick

        ProgressBar1.Maximum = 100
        If ProgressBar1.Value = 95 Then 'le digo que entre en 95 para corregir el retardo al mostrar la informacion en el ritchbox
            ProgressBar1.Value = ProgressBar1.Value + 5
            lblMarcadorBarra.Text = CLng((ProgressBar1.Value * 100) / ProgressBar1.Maximum) & " %"
            temporizador.Stop()

            'If Not comprobarInfo(rtxtTexto) Then
            '    ' Timer1.Start()
            '    mostrarInfoDelFichero(rtxtTexto)
            '    PanelCorreo.Visible = True
            'Else
            '    rtxtTexto.Text = "TODO CORRECTO"
            '    formatoArchivoCorrecto = True
            '    PanelCorreo.Visible = False
            'End If

        Else
            ProgressBar1.Value = ProgressBar1.Value + 1
            lblMarcadorBarra.Text = CLng((ProgressBar1.Value * 100) / ProgressBar1.Maximum) & " %"
        End If
    End Sub


    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        si = True
        panelIncorrecto.Visible = False
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        si = False
        panelIncorrecto.Visible = False
    End Sub

    Private Sub FCorrecion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        panelIncorrecto.Visible = False
    End Sub
End Class