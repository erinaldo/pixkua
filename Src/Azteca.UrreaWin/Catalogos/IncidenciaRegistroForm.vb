Public Class IncidenciaRegistroForm

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IncidenciaRegistroForm_SavingItem(ByVal sender As System.Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles MyBase.SavingItem
        Try
            Dim info As IncidenciaRegistroInfo = CType(PackageInfo, IncidenciaRegistroInfo)

            If (ValidateInfo()) Then
                info.Paquete = txtPaquete.Text
                info.Entrega = txtEntrega.Text
                info.OrdenTransporte = txtOrdenTransporte.Text
                info.FechaInicio = dtpFecha.Value.Date
                info.HoraInicio = dtpFecha.Value
                info.Figura = txtFigura.Text
                info.Cantidad = txtCantidad.Value
                info.NumColaborador = txtNumColaborador.Text
                info.NumContenedor = txtNumeroContenedor.Text
                info.IdCaja = txtIDCaja.Text
                info.RevisaOT = txtRevisaOT.Text
                info.RevisaFigura = txtRevisaFigura.Text
                info.Comentarios = txtComentarios.Text
                info.IdIncidencia = cboIncidencia.SelectedValue
                info.Responsable = txtResponsable.Text
                info.Area = cboArea.Text
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Function ValidateInfo() As Boolean

        Dim res As Boolean = True

        If (cboArea.Text = String.Empty) Then
            res = False
            MsgBox("Favor de seleccionar un Área", MsgBoxStyle.Information, "Información")
        End If

        Return res

    End Function

    Private Sub IncidenciaRegistroForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecha.Value = DateTime.Now
        cboIncidencia.LoadList()
    End Sub

    Private Sub IncidenciaRegistroForm_AddingItem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.AddingItem
        dtpFecha.Value = DateTime.Now
        dtpFechaCierre.Visible = False
        dtpHoraCierre.Visible = False
    End Sub

    Private Sub IncidenciaRegistroForm_LoadingItem(ByVal sender As System.Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles MyBase.LoadingItem
        Try
            Dim info As IncidenciaRegistroInfo = CType(PackageInfo, IncidenciaRegistroInfo)

            txtPaquete.Text = info.Paquete
            txtEntrega.Text = info.Entrega
            txtOrdenTransporte.Text = info.OrdenTransporte
            dtpFecha.Value = info.HoraInicio
            txtFigura.Text = info.Figura
            txtCantidad.Value = info.Cantidad
            txtNumColaborador.Text = info.NumColaborador
            txtNumeroContenedor.Text = info.NumContenedor
            txtIDCaja.Text = info.IdCaja
            txtRevisaOT.Text = info.RevisaOT
            txtRevisaFigura.Text = info.RevisaFigura
            txtComentarios.Text = info.Comentarios
            cboIncidencia.SelectedValue = info.IdIncidencia
            cboArea.Text = info.Area
            txtResponsable.Text = info.Responsable

            If (Not (info.FechaCierre Is Nothing)) Then
                dtpFechaCierre.Value = info.FechaCierre
                dtpFechaCierre.Visible = True
            Else
                dtpFechaCierre.Visible = False
            End If

            If (Not (info.HoraCierre Is Nothing)) Then
                dtpHoraCierre.Value = info.HoraCierre
                dtpHoraCierre.Visible = True
            Else
                dtpHoraCierre.Visible = False
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdBuscarLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscarLinea.Click
        Try
            Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim dialog As New BapiCduDialog

            dialog.ShowDialog()

            txtPaquete.Text = dialog._Paquete
            txtEntrega.Text = dialog._Entrega
            txtOrdenTransporte.Text = dialog._OrdenTransporte
            txtIDCaja.Text = dialog._IDCaja
            txtFigura.Text = dialog._Material
            txtCantidad.Value = dialog._Cantidad

        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class