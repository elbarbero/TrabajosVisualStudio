Public Class FConsultarvb
    Private Sub FConsultarvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.cursos' Puede moverla o quitarla según sea necesario.
        Me.CursosTableAdapter.Fill(Me.BDacademiaDataSet.cursos)

    End Sub

    Private Sub cmbCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCursos.SelectedIndexChanged
        Me.Alumnos1TableAdapter.Fill(Me.BDacademiaDataSet.alumnos1, cmbCursos.SelectedValue)
        lblNumAlu.Text = Me.Alumnos1TableAdapter.NumAlumnosPorCurso(cmbCursos.SelectedValue)
    End Sub
End Class