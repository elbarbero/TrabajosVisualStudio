Public Class Contratos
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If comprobarContrato(txtNomCliente, txtNacionalidadCliente, txtCiudadCliente, txtDireccionCliente, txtNumDirecCliente, txtCifCliente,
                           txtTelefonoCliente, txtEmailCliente, txtBancoCliente, txtEntidadCliente, txtOficinaCliente, txtDCCliente, txtNumCuentaCliente,
                             txtNombreNotario, txtNumProtocolo, txtCiudadNotario, txtCiudadMercantil, txtDiaInscripNotario, txtMesInscripNotario,
                             txtAnnoInscripNotario, txtTomo, txtFolio, txtHoja, txtNumInscripcion, txtNombreRepresentante1, txtCargoRepresentante1,
                             txtDiaRepresentante1, txtMesRepresentante1, txtAnnoRepresentante1, txtNomNotarioRepresentante1,
                             txtProtNotarioRepresentante1, txtCiudNotarioRepresentante1, txtNomPrestador, txtNacionalidadPrestador,
                             txtCiudadPrestador, txtDireccionPrestador, txtNumDirecPrestador, txtCifPrestador,
                           txtTelefonoPrestador, txtEmailPrestador, txtBancoPrestador, txtEntidadPrestador, txtOficinaPrestador, txtDCPrestador, txtNumCuentaPrestador,
                           txtNombreRepresentante2, txtCargoRepresentante2,
                             txtDiaRepresentante2, txtMesRepresentante2, txtAnnoRepresentante2, txtNomNotarioRepresentante2,
                             txtProtNotarioRepresentante2, txtCiudNotarioRepresentante2) Then

            rellenarCamposWord(txtNomCliente, txtNacionalidadCliente, txtCiudadCliente, txtDireccionCliente, txtNumDirecCliente, txtCifCliente,
                           txtTelefonoCliente, txtEmailCliente, txtBancoCliente, txtEntidadCliente, txtOficinaCliente, txtDCCliente, txtNumCuentaCliente,
                             txtNombreNotario, txtNumProtocolo, txtCiudadNotario, txtCiudadMercantil, txtDiaInscripNotario, txtMesInscripNotario,
                             txtAnnoInscripNotario, txtTomo, txtFolio, txtHoja, txtNumInscripcion, txtNombreRepresentante1, txtCargoRepresentante1,
                             txtDiaRepresentante1, txtMesRepresentante1, txtAnnoRepresentante1, txtNomNotarioRepresentante1,
                             txtProtNotarioRepresentante1, txtCiudNotarioRepresentante1, txtNomPrestador, txtNacionalidadPrestador,
                             txtCiudadPrestador, txtDireccionPrestador, txtNumDirecPrestador, txtCifPrestador,
                           txtTelefonoPrestador, txtEmailPrestador, txtBancoPrestador, txtEntidadPrestador, txtOficinaPrestador, txtDCPrestador, txtNumCuentaPrestador,
                           txtNombreRepresentante2, txtCargoRepresentante2,
                             txtDiaRepresentante2, txtMesRepresentante2, txtAnnoRepresentante2, txtNomNotarioRepresentante2,
                             txtProtNotarioRepresentante2, txtCiudNotarioRepresentante2)
        End If
    End Sub

End Class