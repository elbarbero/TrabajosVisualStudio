Public Class FMostrarVehiculos
    Private Sub FMostrarVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub

    Public Sub cargarCombo()
        cmbVehiculos.Items.Add("Citroen")
        cmbVehiculos.Items.Add("Hyundai")
        cmbVehiculos.Items.Add("Vespa Eléctrica")
        cmbVehiculos.Items.Add("Yamaha")
        cmbVehiculos.Items.Add("Mercedes vito")
        cmbVehiculos.Items.Add("Nissan")
    End Sub

    Public Sub cargarImagen()
        Dim ruta As String = ""
        If cmbVehiculos.SelectedIndex = 0 Then
            ruta = "C:\Users\alumnoDAM\Desktop\MARIO_BARBERO_EXAM_FINAL\MARIO_BARBERO_EXAM_FINAL\Resources\citroen.jpg"
        ElseIf cmbVehiculos.SelectedIndex = 1 Then
            ruta = "C:\Users\alumnoDAM\Desktop\MARIO_BARBERO_EXAM_FINAL\MARIO_BARBERO_EXAM_FINAL\Resources\hyundai.jpg"
        ElseIf cmbVehiculos.SelectedIndex = 2 Then
            ruta = "C:\Users\alumnoDAM\Desktop\MARIO_BARBERO_EXAM_FINAL\MARIO_BARBERO_EXAM_FINAL\Resources\vespa.jpg"
        ElseIf cmbVehiculos.SelectedIndex = 3 Then
            ruta = "C:\Users\alumnoDAM\Desktop\MARIO_BARBERO_EXAM_FINAL\MARIO_BARBERO_EXAM_FINAL\Resources\yamaha.jpg"
        ElseIf cmbVehiculos.SelectedIndex = 4 Then
            ruta = "C:\Users\alumnoDAM\Desktop\MARIO_BARBERO_EXAM_FINAL\MARIO_BARBERO_EXAM_FINAL\Resources\vito.jpg"
        ElseIf cmbVehiculos.SelectedIndex = 5 Then
            ruta = "C:\Users\alumnoDAM\Desktop\MARIO_BARBERO_EXAM_FINAL\MARIO_BARBERO_EXAM_FINAL\Resources\nissan.jpg"

        End If
        imgFotosV.Image = Image.FromFile(ruta)
    End Sub

    Private Sub cmbVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehiculos.SelectedIndexChanged
        cargarImagen()
    End Sub
End Class