Imports System.Data.SqlClient
Imports System.IO

Public Class Form2

    'Dim cadenaConexion As String = "Data Source = 205P14; Initial Catalog = BDEjemplo2018; Integrated Security = True"
    Dim cadenaConexion As String = My.MySettings.Default.BDEjemplo2018ConnectionString
    Dim conexion As SqlConnection = New SqlConnection(cadenaConexion)
    Dim consultasql As SqlCommand = New SqlCommand()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDEjemplo2018DataSet.TableFamilias' Puede moverla o quitarla según sea necesario.
        Me.TableFamiliasTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias) 'TE RECARGA LA BBDD, ACTUALIZANDO LA TABLA SI HAY FILAS NUEVAS
        ocultarmostrarbotones(True)
        MostrarPosicion()
        bloquearcontroles(False)
        If Me.TableFamiliasBindingSource.Position <> -1 Then
            MostrarImagen()
        End If
        Me.bnImagen.Visible = False
    End Sub

    Private Sub ocultarmostrarbotones(ByVal tipo As Boolean)
        Me.BnImagen.Visible = Not tipo
        Me.Batras.Visible = tipo
        Me.Button1.Visible = tipo
        Me.lblposicion.Visible = tipo
        Me.BtnAlta.Visible = tipo
        Me.BtnBaja.Visible = tipo
        Me.BtnModifica.Visible = tipo
        Me.Btncancelar.Visible = Not tipo
        Me.BtnGrabar.Visible = Not tipo
    End Sub

    Private Sub MostrarPosicion()
        'Nº total de filas
        Dim nTotal As Integer = Me.TableFamiliasBindingSource.Count 'NOS DA EL TOTAL DE FILAS QUE TIENE LA TABLA
        Dim iposicion As Integer
        If nTotal = 0 Then  'SI NO TIENE FILAS...
            Me.lblPosicion.Text = "Sin datos"
        Else '...SI TIENE FILAS LA TABLA
            iposicion = Me.TableFamiliasBindingSource.Position + 1 ' INCREMENTAMOS EN 1 PARA QUE NOS MUESTRE 1 Y NO 0
            Me.lblPosicion.Text = iposicion & " de " & nTotal
        End If
    End Sub

    Private Sub bAtras_Click(sender As Object, e As EventArgs) Handles bAtras.Click
        If Me.TableFamiliasBindingSource.Position >= 0 Then
            Me.TableFamiliasBindingSource.Position =
            Me.TableFamiliasBindingSource.Position - 1
        End If
        MostrarPosicion()
        MostrarImagen()
    End Sub

    Private Sub MostrarImagen()
        Dim foto As String
        Dim fila As DataRowView 'Para mostrar una imagen que hay en la bbdd
        fila = Me.TableFamiliasBindingSource.Current
        If Not IsDBNull(fila.Row.Item(4)) Then 'SI NO ESTA VACIO
            If Not Trim(fila.Row.Item(4)) = "" Then
                foto = fila.Row.Item(4)
                Me.picFoto.SizeMode = PictureBoxSizeMode.StretchImage
                Me.picFoto.Image = Image.FromFile(foto)
            Else
                Me.picFoto.Image = Nothing
            End If
        Else
            Me.picFoto.Image = Nothing
        End If

        'Buscar el proveedor
        lblProveedor.Text = buscarProveedor(fila.Row.Item(2))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TableFamiliasBindingSource.Position < Me.TableFamiliasBindingSource.Count Then
            Me.TableFamiliasBindingSource.Position =
           Me.TableFamiliasBindingSource.Position + 1
        End If
        MostrarPosicion()
        MostrarImagen()
    End Sub

    Private Sub bloquearcontroles(ByVal tipo As Boolean)
        Me.Id_FamiliaTextBox.Enabled = tipo
        Me.DescripcionTextBox.Enabled = tipo
        Me.Id_ProveedorTextBox.Enabled = tipo
        Me.DescuentoTextBox.Enabled = tipo
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        ocultarmostrarbotones(False)
        bloquearcontroles(True)
        Me.TableFamiliasBindingSource.AddNew() 'Para que añada una nueva fila
        lblProveedor.Text = ""
        Me.picFoto.Image = Nothing
        'Me.Id_FamiliaTextBox.Focus()
        Me.DescripcionTextBox.Focus()
        Id_FamiliaTextBox.Enabled = False

        consultasql.Connection = conexion
        consultasql.CommandType = CommandType.Text
        consultasql.CommandText = "Select count(*) from TableFamilias"

        conexion.Open()

        Id_FamiliaTextBox.Text = consultasql.ExecuteScalar() + 1
        'ASÍ ME SACA EL NUMERO TOTAL QUE HAY Y LE SUMO +1 PARA SABER QUE ID LE CORRESPONDE
        conexion.Close()
    End Sub

    Private Function buscarProveedor(codigo As Integer)
        Dim nombre As String
        consultasql.CommandText = "Select Nombre from TableProveedor where id_Proveedor=" & codigo & ""
        consultasql.CommandType = CommandType.Text
        consultasql.Connection = conexion
        conexion.Open()
        nombre = consultasql.ExecuteScalar
        If IsNothing(nombre) Then
            nombre = "*** NO EXISTE EL CODIGO ***"
        End If
        conexion.Close()
        Return nombre
    End Function

    Private Sub Id_ProveedorTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Id_ProveedorTextBox.Validating
        If Id_ProveedorTextBox.Text <> "" Then
            If IsNumeric(Id_ProveedorTextBox.Text) Then
                lblProveedor.Text = buscarProveedor(Convert.ToInt16(Id_ProveedorTextBox.Text))
                If lblProveedor.Text = "*** NO EXISTE EL CODIGO ***" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.TableFamiliasBindingSource.CancelEdit()
        'el metodo FILL te recarga la BBDD
        Me.TableFamiliasTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias)
        ocultarmostrarbotones(True)
        bloquearcontroles(False)
        MostrarPosicion()
        MostrarImagen()
    End Sub

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        If Id_FamiliaTextBox.Text <> "" And Id_ProveedorTextBox.Text <> "" And DescripcionTextBox.Text <> "" And DescuentoTextBox.Text <> "" Then
            Try
                Dim fila As DataRowView
                fila = Me.TableFamiliasBindingSource.Current
                If Not IsNothing(Me.picFoto.Image) Then
                    If Me.OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                        fila.Row.Item(4) = Me.OpenFileDialog1.FileName 'PONEMOS 4 XK ES EN LA COLUMNA DONDE SE VA A GUARDAR LA IMAGEN
                    End If
                Else
                    fila.Row.Item(4) = Nothing
                End If
                Me.TableFamiliasBindingSource.EndEdit()

                Me.TableFamiliasTableAdapter.Update(Me.BDEjemplo2018DataSet.TableFamilias)
            Catch ex As Exception
                MessageBox.Show("Se ha producido el error " & ex.Message &
                                " al intentar actualizar la base de datos")
            End Try
            Me.TableFamiliasTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias)
            ocultarmostrarbotones(True)
            bloquearcontroles(False)
            MostrarPosicion()
            MostrarImagen()
        End If
    End Sub

    Private Sub bnImagen_Click(sender As Object, e As EventArgs) Handles bnImagen.Click
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.Multiselect = False 'ASÍ SOLO PUEDE SELECCIONAR 1 ARCHIVO
        Dim directorio As DirectoryInfo
        Dim NombreDir As String
        ' obtenemos el directorio actual de ejecución
        NombreDir = Directory.GetCurrentDirectory()
        ' obtenemos el directorio padre del actual, y mostramos información de dicha directorio
        directorio = Directory.GetParent(NombreDir)
        directorio = Directory.GetParent(directorio.FullName)
        Me.OpenFileDialog1.InitialDirectory = directorio.FullName & "\Imagenes"
        Me.OpenFileDialog1.Filter = "Ficheros png (*.png)|*.png|*.jpeg|*.bmp|Todos (*.*)|*.*"
        Me.OpenFileDialog1.FilterIndex = 3
        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" Then
            Me.picFoto.SizeMode = PictureBoxSizeMode.StretchImage
            Me.picFoto.Image =
           Image.FromFile(Me.OpenFileDialog1.FileName)
        Else
            Me.picFoto.Image = Nothing
        End If
    End Sub

    Private Sub btnModifica_Click(sender As Object, e As EventArgs) Handles btnModifica.Click
        ocultarmostrarbotones(False)
        bloquearcontroles(True)
        Me.DescripcionTextBox.Focus()
    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        'Dim sql As String = "Select count(*) from Tproductos where FAMILIA= " & Convert.ToInt16(Me.Id_FamiliaTextBox.Text)
        'Dim COMANDO As New SqlClient.SqlCommand(sql, conexion)
        'Dim Nproductos As Integer
        'conexion.Open()
        'Nproductos = COMANDO.ExecuteScalar
        'If Nproductos <> 0 Then
        '    MessageBox.Show("No puede borrar la Familia por tener productos relacionados")
        'Else
        '    'Borrar familia
        Try
            Dim fila As DataRowView
            fila = Me.TableFamiliasBindingSource.Current 'ME COGE LA FILA ACTUAL
            fila.Row.Delete()

            Me.TableFamiliasTableAdapter.Update(Me.BDEjemplo2018DataSet.TableFamilias)
        Catch ex As Exception
            MessageBox.Show("Se ha producido el error " &
           ex.Message & " al intentar borrar")
        End Try

        Me.TableFamiliasTableAdapter.Fill(Me.BDEjemplo2018DataSet.TableFamilias)
        MostrarPosicion()
        MostrarImagen()
        'End If
        'conexion.Close()
    End Sub
End Class