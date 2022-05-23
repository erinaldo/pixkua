Imports Azteca.Business.Inventario
Public Class SurtirInsumoSelForm
    Dim _otInfo As New OrdenTrabajoInfo(App.Session.SessionID)

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal otInfo As OrdenTrabajoInfo) As DialogResult

        _otInfo = otInfo
        lblOrdenTrabajo.Text = otInfo.UserCode
        cboInsumos.LoadList(otInfo.Identity)
        Call FormatCantidad(CInt(cboInsumos.SelectedValue))

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub FormatCantidad(ByVal idArticuloStock As Integer)
        Try
            Dim asInfo As New ArticuloStockInfo(App.Session.SessionID)
            Dim asFac As New ArticuloStockFacade

            asInfo = asFac.GetDetail(App.Session.SessionID, idArticuloStock)

            If (asInfo.IdTipoUnidadMedida = 1) Then
                txtCantidad.DigitsType = Windows.Controls.DigitsType.Integers
            Else
                txtCantidad.DigitsType = Windows.Controls.DigitsType.Decimals
            End If
        Catch ex As Exception
            txtCantidad.Text = ""
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SurtirInsumoSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            If (IsValid()) Then
                Me.Cursor = Cursors.WaitCursor
                Dim OTFac As New OrdenTrabajoFacade
                Dim res As String = String.Empty
                Dim ASFacade As New ArticuloStockFacade
                Dim ASInfo As ArticuloStockInfo = ASFacade.GetDetail(App.Session.SessionID, CInt(cboInsumos.SelectedValue))

                Dim otInventariosMovs As DataTable = OTFac.LoadMovimientosInventarioByOT(App.Session.SessionID, _otInfo.Identity, App.DefaultSite.Identity)

                res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, TipoMovimiento.Salida, ASInfo, CDec(txtCantidad.Text), _otInfo.IdAlmacenInsumos)

                    If (res <> String.Empty) Then
                        MessageBox.Show("La salida del insumo se realizo correctamente con el folio: " & res, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
                    End If

                    Me.Cursor = Cursors.Default
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function IsValid() As Boolean

        If (CInt(cboInsumos.SelectedValue) = 0) Then
            MessageBox.Show("Favor de seleccionar un insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (txtCantidad.Text = "") Then
            MessageBox.Show("Favor de intruducir la cantidad a surtir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function
End Class