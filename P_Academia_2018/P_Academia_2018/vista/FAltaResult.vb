Imports System.Data.SqlClient
Imports System.IO

Public Class FAltaResult

    Private Sub FAltaResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BDacademiaDataSet.cursos)
        'LLAMAMOS AL CAMBIO DEL COMBO
        cmbCursos_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmbCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCursos.SelectedIndexChanged
        'NOS MUESTRA EL ID DEL CURSO SELECCIONADO XK LO HEMOS ASOCIADO EN LA OPCION
        ' VALUE MEMBER DEL COMBO BOX CON EL ID DEL CURSO DEL MISMO ADAPTADOR
        lblIdCurso.Text = cmbCursos.SelectedValue
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Comprobar si hay datos de este curso y la evaluacion
        Dim sql As String = "SELECT count(*) from tresultado where codigo_curso=" _
 & Convert.ToInt16(lblIdCurso.Text) & " and nuEvaluacion=" & NuEvaluacion.Value
        consultasql.CommandType = CommandType.Text
        consultasql.Connection = conexion
        consultasql.CommandText = sql
        conexion.Open()
        Dim numero As Integer = consultasql.ExecuteScalar
        If numero <> 0 Then
            MessageBox.Show("Existen resultados para el curso y la evaluacion")
            Exit Sub
        End If

        'REALIZAR CALCULOS

        'NÚMERO DE ALUMNOS MATRICULADOS
        'SELECT ac.idCurso,  c.Nombre ,count(idAlumno) FROM ALUMNOSCURSOs ac, cursos c
        'where ac.idCurso=c.idCurso group by ac.IdCurso,c.nombre
        sql = "Select count(idAlumno) from alumnoscursos ac where ac.idCurso=" & Convert.ToInt16(lblIdCurso.Text)
        consultasql.CommandText = sql
        Dim numAluMatriculados As Integer = consultasql.ExecuteScalar

        sql = "SELECT count(idAlumno) from notas where idCurso=" & Convert.ToInt16(lblIdCurso.Text) & " and NuEvaluacion=" & NuEvaluacion.Value
        consultasql.CommandText = sql
        Dim nPresentados As Integer = consultasql.ExecuteScalar

        sql = "SELECT count(idAlumno) from notas where idCurso=" & Convert.ToInt16(lblIdCurso.Text) & " and NuEvaluacion=" & NuEvaluacion.Value & " and nota <5"
        consultasql.CommandText = sql
        Dim nSuspensos As Integer = consultasql.ExecuteScalar

        sql = "insert into tresultado values(" & NuEvaluacion.Value & "," & _
        Convert.ToInt16(lblIdCurso.Text) & "," & numAluMatriculados & "," & _
        nPresentados & "," & nSuspensos & ")"
        consultasql.CommandText = sql
        consultasql.ExecuteNonQuery()

        conexion.Close()

    End Sub
End Class