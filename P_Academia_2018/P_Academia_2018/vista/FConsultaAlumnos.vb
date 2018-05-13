Imports System.Data.SqlClient
Imports System.IO

Public Class FConsultaAlumnos

    Private Sub FConsultaAlumnos_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.alumnos1' Puede moverla o quitarla según sea necesario.
        Me.Alumnos1TableAdapter.Fill(Me.BDacademiaDataSet.alumnos1)
        'TODO: esta línea de código carga datos en la tabla 'BDacademiaDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.BDacademiaDataSet.alumnos)
        mostrarOcultarPaneles(False)
    End Sub

    Private Sub mostrarOcultarPaneles(mostrar As Boolean)
        pCodigo.Visible = mostrar
        pNomApe.Visible = mostrar
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        If rbCodigo.Checked Then
            pCodigo.Visible = True
            pNomApe.Visible = False
        End If
    End Sub

    Private Sub cmbCodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCodigo.SelectedIndexChanged
        If cmbCodigo.Text <> "" Then
            Me.DataTable2TableAdapter.Fill(Me.BDacademiaDataSet.DataTable2, cmbCodigo.Text)
        End If
    End Sub

    Private Sub cmbNomApe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNomApe.SelectedIndexChanged
        If cmbNomApe.Text <> "" Then
            Me.DataTable2TableAdapter.Fill(Me.BDacademiaDataSet.DataTable2, cmbNomApe.SelectedValue)
        End If
    End Sub

    Private Sub rbNomApe_CheckedChanged(sender As Object, e As EventArgs) Handles rbNomApe.CheckedChanged
        If rbNomApe.Checked Then
            pCodigo.Visible = False
            pNomApe.Visible = True
        End If
    End Sub

End Class