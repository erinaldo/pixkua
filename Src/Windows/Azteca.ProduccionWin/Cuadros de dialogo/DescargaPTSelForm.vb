Imports Azteca.Business.Inventario

Public Class DescargaPTSelForm
    Dim _otInfo As New OrdenTrabajoInfo(App.Session.SessionID)
    Dim _asInfo As New ArticuloStockInfo(App.Session.SessionID)


    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal otInfo As OrdenTrabajoInfo) As DialogResult
        _otInfo = otInfo
        Dim AsFac As New ArticuloStockFacade
        _asInfo = AsFac.GetDetail(App.Session.SessionID, otInfo.IdArticuloStock)
        lblOrdenTrabajo.Text = otInfo.UserCode
        lblArticulo.Text = _asInfo.Nombre
        lblCodigo.Text = _asInfo.UserCode
        Call FormatCantidad(_asInfo)
        Return Me.ShowDialog(owner)
    End Function

    Private Sub DescargaPTSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    
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
                Dim cant As Decimal = CDec(txtCantidad.Text)

                If ((_otInfo.CantRecibida + cant) > _otInfo.CantDeseada) Then
                    If (MessageBox.Show("Con esta cantidad a recibir (" + cant.ToString() + ") sobrepasaría la estimada de fabricación ( " + _otInfo.CantDeseada.ToString() + "), ¿Está seguro de aplicar la transacción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                        res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, TipoMovimiento.Entrada, _asInfo, cant, _otInfo.IdAlmacenPT)

                        If (res <> String.Empty) Then
                            MessageBox.Show("La entrada del Producto Terminado se realizo correctamente con el folio: " & res, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
                        End If
                    End If
                Else
                    res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, TipoMovimiento.Entrada, _asInfo, cant, _otInfo.IdAlmacenPT)

                    If (res <> String.Empty) Then
                        MessageBox.Show("La entrada del Producto Terminado se realizo correctamente con el folio: " & res, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
                    End If
                End If
                

                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function IsValid() As Boolean

        If (txtCantidad.Text = "") Then
            MessageBox.Show("Favor de intruducir la cantidad a surtir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function

    Private Sub FormatCantidad(ByVal asInfo As ArticuloStockInfo)
        Try
           
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
End Class