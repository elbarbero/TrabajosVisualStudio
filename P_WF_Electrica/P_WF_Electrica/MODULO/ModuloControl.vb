Module ModuloControl

    Public nMeses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo",
                                "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Public diasSemana() As String = {"Lunes", "Martes", "Miércoles", "Jueves",
                               "Viernes", "Sabado", "Domingo"}

    Public DATOS(2, 3, 6) As Integer
    Public indiceMes(2) As Integer
    Public indiceSemanas(3) As Integer
    Public indiceDias(6) As Integer
    Public errores As String 'GUARDO EL PRIMER ERROR QUE ENCUENTRE AL LEER EL FICHERO PARA ENVIARLO POR EMAIL

End Module
