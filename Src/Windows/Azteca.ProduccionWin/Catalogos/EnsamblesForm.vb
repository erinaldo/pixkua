Public Class EnsamblesForm

    Private Sub EnsamblesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboTipoUnidadEntrega.LoadList()
        cboUnidadEntrega.LoadList()
        cboTipoUnidadRecepcion.LoadList()
        cboUnidadRecepcion.LoadList()
        If cboTipoUnidadEntrega.Items.Count > 0 Then cboTipoUnidadEntrega.SelectedIndex = 0
    End Sub

    Private Sub EnsamblesForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As EnsambleInfo = CType(Me.PackageInfo, EnsambleInfo)

        With info
            txtNombre.Text = info.Nombre
            SelCuenta.LoadInfo(info.IdCuenta)
            cboUnidadEntrega.SelectedValue = info.IdEntregaUM
            cboTipoUnidadEntrega.SelectedValue = info.IdUnidadMedidaTipoEntrega
            cboTipoRecurso.Text = info.TipoRecurso
            cboUnidadRecepcion.SelectedValue = info.IdRecepcionUM
            cboTipoUnidadRecepcion.SelectedValue = info.IdUnidadMedidaTipoRecepcion

            txtHorasMaquina.Text = info.HorasMaquina.ToString()
            txtCostoMaquina.Text = info.CostoMaquina.ToString()
            txtHorasLabor.Text = info.HorasLabor.ToString()
            txtCostoLabor.Text = info.CostoLabor.ToString()

        End With
    End Sub



    Private Sub EnsamblesForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As EnsambleInfo = CType(Me.PackageInfo, EnsambleInfo)

        With info
            info.Nombre = txtNombre.Text
            info.IdCuenta = SelCuenta.Key
            info.IdEntregaUM = CInt(cboUnidadEntrega.SelectedValue)
            info.IdRecepcionUM = CInt(cboUnidadRecepcion.SelectedValue)
            info.TipoRecurso = cboTipoRecurso.Text

            info.HorasMaquina = CDec(txtHorasMaquina.Text)
            info.CostoMaquina = CDec(txtCostoMaquina.Text)
            info.HorasLabor = CDec(txtHorasLabor.Text)
            info.CostoLabor = CDec(txtCostoLabor.Text)


        End With
    End Sub



    Private Sub cboTipoUnidadEntrega_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoUnidadEntrega.SelectedIndexChanged
        Try
            If cboTipoUnidadEntrega.SelectedIndex >= 0 Then
                cboUnidadEntrega.FilterExpression = "IdUnidadMedidaTipo=" & CInt(cboTipoUnidadEntrega.SelectedValue).ToString
            Else
                cboUnidadEntrega.FilterExpression = String.Empty
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cboTipoUnidadRecepcion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoUnidadRecepcion.SelectedIndexChanged
        Try
            If cboTipoUnidadRecepcion.SelectedIndex >= 0 Then
                cboUnidadRecepcion.FilterExpression = "IdUnidadMedidaTipo=" & CInt(cboTipoUnidadRecepcion.SelectedValue).ToString
            Else
                cboUnidadRecepcion.FilterExpression = String.Empty
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class