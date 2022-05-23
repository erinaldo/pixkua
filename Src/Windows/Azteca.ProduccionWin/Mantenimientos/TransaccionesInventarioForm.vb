Imports Azteca.Business.Inventario

Public Class TransaccionesInventarioForm
    Private _otInfo As New OrdenTrabajoInfo(App.Session.SessionID)
    Private _tipoMov As TipoMovimiento

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal otInfo As OrdenTrabajoInfo) As DialogResult

        _otInfo = otInfo
        selOrdenTrabajo.LoadInfo(_otInfo.Identity)
        Call LoadInfoByOT()

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub tcmdCancelar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tcmdCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub selOrdenTrabajo_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles selOrdenTrabajo.InfoLoaded
        cboInsumos.LoadList(_otInfo.Identity)
        Call LoadInfoByOT()
    End Sub

    Private Sub LoadInfoByOT()
        
        If (selOrdenTrabajo.Key > 0) Then
            Dim otFacade As New OrdenTrabajoFacade()
            _otInfo = otFacade.GetDetail(App.Session.SessionID, selOrdenTrabajo.Key)
            Call FormatCantidad(CInt(cboInsumos.SelectedValue))
            SelArticulo.LoadInfo(_otInfo.IdArticuloStock)

            If (rdbRecepcionOT.Checked Or rdbReciboDev.Checked) Then
                If (SelArticulo.Key > 0) Then
                    Call LoadInfoArticuloSelected(_otInfo.IdAlmacenPT, SelArticulo.Key)
                Else
                    MessageBox.Show("Favor de seleccionar un articulo", "error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            ElseIf (rdbEmision.Checked Or rdbEmisionDev.Checked) Then
                If (CInt(cboInsumos.SelectedValue) > 0) Then
                    Call LoadInfoArticuloSelected(_otInfo.IdAlmacenInsumos, CInt(cboInsumos.SelectedValue))
                Else
                    MessageBox.Show("Favor de seleccionar un articulo", "error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub FormatCantidad(ByVal idArticuloStock As Integer)
        Try
            Dim asInfo As New ArticuloStockInfo(App.Session.SessionID)
            Dim asFac As New ArticuloStockFacade
            If (idArticuloStock <> 0) Then
                asInfo = asFac.GetDetail(App.Session.SessionID, idArticuloStock)
            End If

            If (idArticuloStock = 0 Or asInfo.IdTipoUnidadMedida = 1) Then
                txtCantidad.DigitsType = Windows.Controls.DigitsType.Integers
            Else
                txtCantidad.DigitsType = Windows.Controls.DigitsType.Decimals
            End If
        Catch ex As Exception
            txtCantidad.Text = ""
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadInfoArticuloSelected(ByVal idAlmacen As Integer, ByVal idArticuloStock As Integer)

        Dim AlmacenFac As New AlmacenFacade()
        Dim AlmacenInfo As AlmacenInfo = AlmacenFac.GetDetail(App.Session.SessionID, idAlmacen)
        Dim StockInfo As StockInfo

        If (rdbRecepcionOT.Checked Or rdbReciboDev.Checked) Then
            StockInfo = AlmacenFac.GetStockInfo(App.Session.SessionID, idAlmacen, idArticuloStock)

            With StockInfo
                txtCantidadDisponible.Text = .Disponible.ToString()
                txtCantidadTransito.Text = .Transito.ToString()
                txtCantidadRequerido.Text = _otInfo.CantDeseada.ToString()
                txtCantidadRecibida.Text = _otInfo.CantRecibida.ToString()
                txtAlmacen.Text = AlmacenInfo.Nombre
            End With
        ElseIf (rdbEmision.Checked Or rdbEmisionDev.Checked) Then
            StockInfo = AlmacenFac.GetStockInfo(App.Session.SessionID, idAlmacen, idArticuloStock)

            Dim Merma As Decimal = 0

            If (_otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).MermaPorc > 0) Then
                If (_otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).TipoMerma = "C") Then
                    Merma = _otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).MermaPorc
                Else
                    Merma = _otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).Cantidad * (_otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).MermaPorc / 100)
                End If
            End If

            With StockInfo
                txtCantidadDisponible.Text = .Disponible.ToString()
                txtCantidadTransito.Text = .Transito.ToString()
                txtCantidadRequerido.Text = (_otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).Cantidad + Merma).ToString()
                txtCantidadRecibida.Text = _otInfo.Insumos.FindByIdArticuloStock(idArticuloStock).CantidadRec.ToString()
                txtAlmacen.Text = AlmacenInfo.Nombre
            End With
        End If

    End Sub

    Private Sub tlbGuardar_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbGuardar.Click
        Try
            If (selOrdenTrabajo.Key > 0) Then
                If (_otInfo.WorkFlowStatus = WorkFlowStatus.Liberado) Then

                    Dim OTFac As New OrdenTrabajoFacade
                    Dim res As String = String.Empty
                    Dim cant As Decimal = CDec(txtCantidad.Text)
                    Dim ASFacade As New ArticuloStockFacade
                    Dim ASInfo As New ArticuloStockInfo(App.Session.SessionID)

                    If (rdbRecepcionOT.Checked Or rdbReciboDev.Checked) Then
                        If (IsValid()) Then
                            ASInfo = ASFacade.GetDetail(App.Session.SessionID, CInt(SelArticulo.Key))
                            'Si la cantidad a recibir mas la recibida es mayor a la deseada alertar al usuario
                            If ((_otInfo.CantRecibida + cant) > _otInfo.CantDeseada And rdbRecepcionOT.Checked) Then
                                If (MessageBox.Show("Con esta cantidad a recibir (" & cant.ToString() & ") sobrepasaría la estimada de fabricación ( " & _otInfo.CantDeseada.ToString() & "), ¿Está seguro de aplicar la transacción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                                    res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, _tipoMov, ASInfo, cant, _otInfo.IdAlmacenPT)
                                End If
                            ElseIf (rdbReciboDev.Checked And cant > _otInfo.CantRecibida) Then
                                MessageBox.Show("La cantidad a devolver no puede ser mayor a lo recibido", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, _tipoMov, ASInfo, cant, _otInfo.IdAlmacenPT)
                            End If

                            If (res <> String.Empty) Then
                                MessageBox.Show("La entrada del Producto Terminado se realizo correctamente con el folio: " & res, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Call LoadInfoByOT()
                                txtCantidad.Text = "0"
                            End If

                        End If

                    ElseIf (rdbEmision.Checked Or rdbEmisionDev.Checked) Then
                        If (IsValid()) Then
                            ASInfo = ASFacade.GetDetail(App.Session.SessionID, CInt(cboInsumos.SelectedValue))
                            'Si la cantidad a emitir es mayor a lo requerido + la merma
                            Dim Merma As Decimal = 0

                            If (_otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).MermaPorc > 0) Then
                                If (_otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).TipoMerma = "C") Then
                                    Merma = _otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).MermaPorc
                                Else
                                    Merma = _otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).Cantidad * (_otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).MermaPorc / 100)
                                End If
                            End If
                            
                            If (rdbEmision.Checked And (_otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).CantidadRec + cant) > _otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).Cantidad + Merma) Then
                                If (MessageBox.Show("Con esta cantidad a emitir (" & cant.ToString() & ") sobrepasaría lo requerido para su fabricación" & vbCrLf & "Cant: ( " & _otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).Cantidad.ToString() & ") + Merma: (" & Merma.ToString() & "), ¿Está seguro de aplicar la transacción?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                                    res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, _tipoMov, ASInfo, cant, _otInfo.IdAlmacenInsumos)
                                End If
                            ElseIf (rdbEmisionDev.Checked And cant > _otInfo.Insumos.FindByIdArticuloStock(ASInfo.Identity).CantidadRec) Then
                                MessageBox.Show("La cantidad a devolver no puede ser mayor a lo emitido", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                res = OTFac.GenerarMovimientoByOT(App.Session.SessionID, _otInfo, _tipoMov, ASInfo, cant, _otInfo.IdAlmacenInsumos)
                            End If

                            If (res <> String.Empty) Then
                                MessageBox.Show("La salida del insumo se realizo correctamente con el folio: " & res, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Call LoadInfoByOT()
                                txtCantidad.Text = "0"
                            End If
                        End If
                    End If
                Else
                    MessageBox.Show("La Orden de Trajo tiene que estar liberada para esta transacción", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Favor de seleccionar una Orden de Trabajo", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("error:" & ex.ToString(), "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Function IsValid() As Boolean

        If ((rdbEmision.Checked Or rdbEmisionDev.Checked) And CInt(cboInsumos.SelectedValue) = 0) Then
            MessageBox.Show("Favor de seleccionar un insumo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If ((rdbRecepcionOT.Checked Or rdbReciboDev.Checked) And SelArticulo.Key = 0) Then
            MessageBox.Show("Favor de seleccionar un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (txtCantidad.Text = "") Then
            MessageBox.Show("Favor de intruducir la cantidad a surtir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True

    End Function

    Private Sub cboInsumos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboInsumos.SelectedIndexChanged
        Call FormatCantidad(CInt(cboInsumos.SelectedValue))
        Call LoadInfoByOT()
    End Sub

    Private Sub rdbRecepcionOT_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles rdbReciboDev.CheckedChanged, rdbRecepcionOT.CheckedChanged, rdbEmisionDev.CheckedChanged, rdbEmision.CheckedChanged
        
        If (rdbRecepcionOT.Checked) Then
            txtTipoTransaccion.Text = "Entrada"
            _tipoMov = TipoMovimiento.Entrada
            lblCantidadRequerida.Text = "Deseada"
            lblCantidadRecibida.Text = "Recibido"
            SelArticulo.Visible = True
            cboInsumos.Visible = False
        ElseIf (rdbReciboDev.Checked) Then
            txtTipoTransaccion.Text = "Salida"
            _tipoMov = TipoMovimiento.Salida
            lblCantidadRequerida.Text = "Deseada"
            lblCantidadRecibida.Text = "Recibido"
            SelArticulo.Visible = True
            cboInsumos.Visible = False
        ElseIf (rdbEmision.Checked) Then
            txtTipoTransaccion.Text = "Salida"
            _tipoMov = TipoMovimiento.Salida
            lblCantidadRequerida.Text = "Requerido"
            lblCantidadRecibida.Text = "Emitido"
            SelArticulo.Visible = False
            cboInsumos.Visible = True
        ElseIf (rdbEmisionDev.Checked) Then
            txtTipoTransaccion.Text = "Entrada"
            _tipoMov = TipoMovimiento.Entrada
            lblCantidadRequerida.Text = "Requerido"
            lblCantidadRecibida.Text = "Emitido"
            SelArticulo.Visible = False
            cboInsumos.Visible = True
        End If

        Me.Cursor = Cursors.WaitCursor
        Call LoadInfoByOT()
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub TransaccionesInventarioForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TransaccionesInventarioForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class