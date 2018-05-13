Public Class Form1

    Private Sub rbtUno_CheckedChanged(sender As Object, e As EventArgs) Handles rbtUno.CheckedChanged
        Me.lstValores.SelectionMode = SelectionMode.One
    End Sub

    Private Sub rbtMultiple_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMultiple.CheckedChanged
        Me.lstValores.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub rbtExtendida_CheckedChanged(sender As Object, e As EventArgs) Handles rbtExtendida.CheckedChanged
        Me.lstValores.SelectionMode = SelectionMode.MultiExtended
    End Sub

    Private Sub chkOrdenar_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrdenar.CheckedChanged
        Me.lstValores.Sorted = Me.chkOrdenar.Checked
    End Sub

    Private Sub chkColumnas_CheckedChanged(sender As Object, e As EventArgs) Handles chkColumnas.CheckedChanged
        Me.lstValores.MultiColumn = Me.chkColumnas.Checked
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If Me.txtValor.Text <> "" Then
            Me.lstValores.Items.Add(Me.txtValor.Text)
            Me.txtValor.Text = ""
        End If
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim iposicion As Integer
        If txtValor.Text <> "" Then
            'El método FindString() busca un valor en la lista
            iposicion = Me.lstValores.FindStringExact(Me.txtValor.Text)
            'Devuelve la posición donde está o -1, si no se encuentra
            If iposicion = -1 Then
                MessageBox.Show("No existe el valor en la lista")
            Else
                'Si encontramos el valor lo seleccionamos por código
                Me.lstValores.SelectedIndex = iposicion
                'o
                'Me.lstValores.SetSelected(iposicion, True)
            End If
            'Selecciona el text del cuadro de texto
            Me.txtValor.SelectionStart = 0
            Me.txtValor.SelectionLength = Me.txtValor.TextLength
            'Coloca el foco en el cuadro de texto
            Me.txtValor.Focus()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.lstTraspaso.Items.Clear()
    End Sub

    Private Sub btnTraspasar_Click(sender As Object, e As EventArgs) Handles btnTraspasar.Click
        'La propiedad SelectedItems de control lista devuelve una colección con los elementos seleccionados
        'defino un variable que contendrá la colección
        Dim oSeleccion As ListBox.SelectedObjectCollection
        'Cargamos la colección con los elementos seleccionados
        oSeleccion = Me.lstValores.SelectedItems
        If oSeleccion.Count > 0 Then
            'Si hay elementos en la colección
            Dim oEnumerador As IEnumerator
            'Defino una variable para recorrer secuencialmente la colección
            oEnumerador = oSeleccion.GetEnumerator
            'Así obtenemos el enumerador de la colección
            'Con un enumerador no es necesario posicionarse en el primer elemento ni
            'calcular cuantos hay, sólo movernos hasta que no haya más
            While oEnumerador.MoveNext
                lstTraspaso.Items.Add(oEnumerador.Current)
            End While
        End If
    End Sub

    Private Sub btnSelecCod_Click(sender As Object, e As EventArgs) Handles btnSelecCod.Click
        'Podemos cambiar la selección también por código
        Me.rbtMultiple.Checked = True
        Me.lstValores.SetSelected(1, True)
        Me.lstValores.SetSelected(3, True)
        Me.lstValores.SetSelected(5, True)
    End Sub

    Private Sub lstValores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstValores.SelectedIndexChanged
        Dim titulo As String
        titulo = "Elemento Seleccionado: " & lstValores.SelectedItem
        Me.Text = titulo



    End Sub
End Class
