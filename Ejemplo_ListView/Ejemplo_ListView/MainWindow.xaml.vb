Class MainWindow 
    Dim view As CollectionView 'recogemos todas las filas en un objeto de tipo ColectionView

    Private Sub btnAceptar_Click(sender As Object, e As RoutedEventArgs) Handles btnAceptar.Click
        If Me.TxtNombre.Text <> "" And Me.txtDNI.Text <> "" Then
            Dim diferencia As Long
            Dim fecha As Date = Me.DtpFechaNacimiento.SelectedDate
            diferencia = DateDiff(DateInterval.Year, fecha, Date.Today)
            If diferencia >= 18 Then
                LstVDatos.Items.Add(New Persona With {.Nombre = TxtNombre.Text, .FechaNacimiento = fecha.ToLongDateString, .DNI = txtDNI.Text})
                Me.TxtNombre.Text = ""
                Me.DtpFechaNacimiento.SelectedDate = DateAdd(DateInterval.Year, -18, Date.Today)
                Me.txtDNI.Text = ""
                ' Me.TxBLetra.Content = "" 
                Me.TxtNombre.Focus()
                Exit Sub
            Else
                MessageBox.Show("Debe tener más de 17 años")
            End If
        Else
            MessageBox.Show("Introduzca los 3 datos")
            Me.TxtNombre.Focus()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As RoutedEventArgs) Handles btnBorrar.Click
        If Me.LstVDatos.SelectedItems.Count = 0 Then
            MessageBox.Show("Seleccione el elemento a borrar")
            Me.LstVDatos.Focus()
        Else
            Me.LstVDatos.Items.Remove(LstVDatos.SelectedItem)
        End If
    End Sub

    Private Sub btnBuscarNombre_Click(sender As Object, e As RoutedEventArgs) Handles btnBuscarNombre.Click
        If TxtNombre.Text <> "" Then
      
        'Dim elemento As Persona
        'Dim posicion As Integer
        'Dim esta As Boolean = False
        view = CollectionViewSource.GetDefaultView(LstVDatos.Items)
        view.Filter = New Predicate(Of Object)(AddressOf Filtro)
        'posicion = -1 
        'For Each elemento In view ' 
        ' posicion = elemento.Nombre.IndexOf(TxtNombre.Text, StringComparison.OrdinalIgnoreCase) 
        ' If elemento.Nombre = TxtNombre.Text Then 
        ' esta = True 
        ' Exit For 
        ' End If 
        ' posicion += 1 
        'Next 'If esta Then 
        ' LstVDatos.SelectedIndex = posicion + 1 
        'End If 
        Else
            MessageBox.Show("Debe introducir nombre a buscar")
        End If
    End Sub

    Private Sub btnBuscarDNI_Click(sender As Object, e As RoutedEventArgs) Handles btnBuscarDNI.Click
        If txtDNI.Text <> "" Then
            Dim elemento As Persona 'es tipo persona por que todas las filas que recogemos son de tipo Persona
            Dim posicion As Integer
            Dim esta As Boolean = False
            view = CollectionViewSource.GetDefaultView(LstVDatos.Items) 'Leemos el origen de los datos de esta coleccion. Es un conjunto de filas de tipo Persona
            posicion = -1
            For Each elemento In view 'cada elemento debe de ser del mismo tipo. Elemento es de tipo Persona a ver si está en el view
                If elemento.DNI = txtDNI.Text Then
                    esta = True
                    Exit For
                End If
                posicion += 1
            Next
            If esta Then
                LstVDatos.SelectedIndex = posicion + 1 ' así nos posicionamos en un elemento del ListView
            End If
        Else
            MessageBox.Show("Debe introducir un DNI para buscar")
        End If
    End Sub

    Function Filtro(ByVal param As Object) As Boolean
        Dim elemento As Persona = TryCast(param, Persona)
        Dim retValue As Boolean
        If elemento IsNot Nothing Then
            If elemento.Nombre = TxtNombre.Text Then
                retValue = True
            Else : retValue = False
            End If
        End If
        Return retValue
    End Function

    Private Sub TxtNombre_GotFocus(sender As Object, e As RoutedEventArgs) Handles TxtNombre.GotFocus
        If LstVDatos.Items.Count > 0 Then
            view = CollectionViewSource.GetDefaultView(LstVDatos.Items)
            view.Filter = Nothing
        End If
    End Sub

    Private Sub LstVDatos_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles LstVDatos.SelectionChanged

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As RoutedEventArgs) Handles btnCargar.Click
        If Me.LstVDatos.SelectedItems.Count = 0 Then
            MessageBox.Show("Seleccione un elemento a mostrar")
            Me.LstVDatos.Focus()
        Else
            Dim elemento As Persona
            elemento = LstVDatos.SelectedItem
            TxtNombre.Text = elemento.Nombre
            DtpFechaNacimiento.SelectedDate = elemento.FechaNacimiento
            txtDNI.Text = elemento.DNI
        End If
    End Sub
End Class
