Imports Azteca.Business.Inventario

Public Class NuevaRecepcionForm
    Private IdOrden As String
    Private Proveedor As ProveedorInfo
    Private ProveedorFac As ProveedorFacade
    Private Recepcion As RecepcionInfo

#Region "Metodos Privados"

    Private Function ValidarSaldos() As Boolean
        'Verificar que las cantidades recibidas no excedan el saldo de la orden
        For Each drArticulo As DetalleRecepcionDS.ArticulosRow In Recepcion.Articulos
            Dim UnidadMedida As UnidadMedidaInfo = GetUnidadMedida(drArticulo.IdUnidadMedida)
            Dim Recibido As New Empaquetado(CDec(drArticulo.Recibido), UnidadMedida.Factor)
            Dim Saldo As New Empaquetado(CDec(drArticulo.Saldo), UnidadMedida.Factor)
            If Recibido > Saldo Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function IsValid() As Boolean
        Dim Diferencia As Decimal = CDec(Math.Abs(Val(txtTotalFact.Text) - Val(txtTotalRec.Text)))
        If txtFolio.Text <> String.Empty AndAlso txtUUID.Text <> String.Empty Then
            MessageBox.Show("Debe introducir el folio de la factura o el folio único UUID", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFolio.Focus()
            Return False
        ElseIf Val(txtSubTotalFact.Text) <= 0 Then
            MessageBox.Show("El sub total de la factura debe ser un valor mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSubTotalFact.Focus()
            Return False
        ElseIf Diferencia > 3D Then
            MessageBox.Show("Existe una diferencia no aceptable entre la factura y la recepción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf Not ValidarSaldos() Then
            MessageBox.Show("Existen partidas con cantidades recibidas mayores al saldo de la orden de compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CalcularTotalFactura()
        txtTotalFact.Text = CDec(Val(txtSubTotalFact.Text) + Val(txtImpuestosFact.Text) - Val(txtRetencionesFact.Text)).ToString
    End Sub

    Private Sub HabilitarFacturaManual()
        txtSerie.ReadOnly = False
        txtFolio.ReadOnly = False
        txtUUID.ReadOnly = False
        txtSubTotalFact.ReadOnly = False
        txtImpuestosFact.ReadOnly = False
        txtRetencionesFact.ReadOnly = False
        btnSelFactura.Enabled = False
    End Sub

    Private Sub MostrarTotales()
        GuardarEmpaquetados(Recepcion)
        Recepcion.CalcularTotales()
        With Recepcion
            txtSubTotalRec.Text = Recepcion.SubTotal.ToString
            txtImpuestosRec.Text = Recepcion.TotalImpuestosTrasladados.ToString
            txtRetencionesRec.Text = Recepcion.TotalImpuestosRetenidos.ToString
            txtTotalRec.Text = (Recepcion.Total + CDec(Val(txtFlete.Text))).ToString
        End With
    End Sub

    Private Function GetUnidadMedida(ByVal idUnidadMedida As Integer) As Azteca.Business.Inventario.UnidadMedidaInfo
        Dim UnidadMedidaInf As Azteca.Business.Inventario.UnidadMedidaInfo
        If Context.UnidadesMedida.ContainsKey(idUnidadMedida) Then
            UnidadMedidaInf = Context.UnidadesMedida(idUnidadMedida)
        Else
            Dim UnidadMedidaFac As New Azteca.Business.Inventario.UnidadMedidaFacade
            UnidadMedidaInf = UnidadMedidaFac.GetDetailFromCache(App.Session.SessionID, idUnidadMedida)
        End If
        Return UnidadMedidaInf
    End Function


    Private Sub CargarEmpaquetados(ByVal recepcion As RecepcionInfo)
        For Each drPartida As DetalleRecepcionDS.ArticulosRow In recepcion.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Azteca.Business.Inventario.Empaquetado(drPartida.Recibido, UnidadInf.Factor)
                    drPartida.CantidadAux = Cantidad.Cajas
                    drPartida.UnidadesAux = Cantidad.Unidades
                Else
                    drPartida.CantidadAux = drPartida.Cantidad
                End If
            End If
        Next
        recepcion.Articulos.AcceptChanges()
    End Sub

    Private Sub GuardarEmpaquetados(ByVal recepcion As RecepcionInfo)
        For Each drPartida As DetalleRecepcionDS.ArticulosRow In recepcion.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Empaquetado(CInt(drPartida.CantidadAux), drPartida.UnidadesAux, UnidadInf.Factor)
                    drPartida.Recibido = Cantidad.ToDecimal
                Else
                    drPartida.Recibido = drPartida.CantidadAux
                End If
            End If
        Next
    End Sub

    Private Sub AsignarArticulos(orden As OrdenInfo, recepcion As RecepcionInfo)
        For Each dr As DetalleOrdenDS.ArticulosRow In orden.Articulos
            Dim drArticulo As DetalleRecepcionDS.ArticulosRow = recepcion.Articulos.FindByIdArticuloStock(dr.IdArticuloStock)
            If drArticulo Is Nothing Then
                drArticulo = recepcion.Articulos.NewArticulosRow
                With drArticulo
                    .IdArticuloStock = dr.IdArticuloStock
                    .Codigo = dr.Codigo
                    .Descripcion = dr.Descripcion
                    .Cantidad = dr.Saldo
                    .Recibido = dr.Saldo
                    .Saldo = dr.Saldo
                    .IdUnidadMedida = dr.IdUnidadMedida
                    .IdUnidadMedidaTipo = dr.IdUnidadMedidaTipo
                    .UnidadMedida = dr.UnidadMedida
                    .CostoUnitario = dr.CostoUnitario
                    .PorcDescuento1 = dr.PorcDescuento1
                    .PorcDescuento2 = dr.PorcDescuento2
                    .PorcDescuento3 = dr.PorcDescuento3
                    .PorcDescuento4 = dr.PorcDescuento4
                    .PorcDescuento5 = dr.PorcDescuento5
                    .MontoDesc1 = dr.MontoDesc1
                    .MontoDesc2 = dr.MontoDesc2
                    .MontoDesc3 = dr.MontoDesc3
                    .MontoDesc4 = dr.MontoDesc4
                    .MontoDesc5 = dr.MontoDesc5
                    .IdImpuesto1 = dr.IdImpuesto1
                    .IdImpuesto2 = dr.IdImpuesto2
                    .IdImpuesto3 = dr.IdImpuesto3
                    .IdImpuesto4 = dr.IdImpuesto4
                    .IdImpuesto5 = dr.IdImpuesto5
                    .PorcImpTras1 = dr.PorcImpTras1
                    .PorcImpTras2 = dr.PorcImpTras2
                    .PorcImpTras3 = dr.PorcImpTras3
                    .PorcImpTras4 = dr.PorcImpTras4
                    .PorcImpTras5 = dr.PorcImpTras5
                    .MontoImpTras1 = dr.MontoImpTras1
                    .MontoImpTras2 = dr.MontoImpTras2
                    .MontoImpTras3 = dr.MontoImpTras3
                    .MontoImpTras4 = dr.MontoImpTras4
                    .MontoImpTras5 = dr.MontoImpTras5
                    .PorcImpRet1 = dr.PorcImpRet1
                    .PorcImpRet2 = dr.PorcImpRet2
                    .PorcImpRet3 = dr.PorcImpRet3
                    .PorcImpRet4 = dr.PorcImpRet4
                    .PorcImpRet5 = dr.PorcImpRet5
                    .MontoImpRet1 = dr.MontoImpRet1
                    .MontoImpRet2 = dr.MontoImpRet2
                    .MontoImpRet3 = dr.MontoImpRet3
                    .MontoImpRet4 = dr.MontoImpRet4
                    .MontoImpRet5 = dr.MontoImpRet5
                End With
                recepcion.Articulos.AddArticulosRow(drArticulo)
            Else
                drArticulo.Cantidad += dr.Saldo
                drArticulo.Recibido += dr.Saldo
                drArticulo.Saldo += dr.Saldo
            End If
        Next
    End Sub

    Private Sub AsignarServicios(orden As OrdenInfo, recepcion As RecepcionInfo)
        For Each dr As DetalleOrdenDS.ServiciosRow In orden.Servicios
            Dim drServicio As DetalleRecepcionDS.ServiciosRow = recepcion.Servicios.NewServiciosRow
            With drServicio
                .IdServicio = dr.IdServicio
                .Codigo = dr.Codigo
                .Descripcion = dr.Descripcion
                .Cantidad = dr.Saldo
                .Recibido = dr.Saldo
                .Saldo = dr.Saldo
                .CostoUnitario = dr.CostoUnitario
                .PorcDescuento1 = dr.PorcDescuento1
                .PorcDescuento2 = dr.PorcDescuento2
                .PorcDescuento3 = dr.PorcDescuento3
                .PorcDescuento4 = dr.PorcDescuento4
                .PorcDescuento5 = dr.PorcDescuento5
                .MontoDesc1 = dr.MontoDesc1
                .MontoDesc2 = dr.MontoDesc2
                .MontoDesc3 = dr.MontoDesc3
                .MontoDesc4 = dr.MontoDesc4
                .MontoDesc5 = dr.MontoDesc5
                .IdImpuesto1 = dr.IdImpuesto1
                .IdImpuesto2 = dr.IdImpuesto2
                .IdImpuesto3 = dr.IdImpuesto3
                .IdImpuesto4 = dr.IdImpuesto4
                .IdImpuesto5 = dr.IdImpuesto5
                .PorcImpTras1 = dr.PorcImpTras1
                .PorcImpTras2 = dr.PorcImpTras2
                .PorcImpTras3 = dr.PorcImpTras3
                .PorcImpTras4 = dr.PorcImpTras4
                .PorcImpTras5 = dr.PorcImpTras5
                .MontoImpTras1 = dr.MontoImpTras1
                .MontoImpTras2 = dr.MontoImpTras2
                .MontoImpTras3 = dr.MontoImpTras3
                .MontoImpTras4 = dr.MontoImpTras4
                .MontoImpTras5 = dr.MontoImpTras5
                .PorcImpRet1 = dr.PorcImpRet1
                .PorcImpRet2 = dr.PorcImpRet2
                .PorcImpRet3 = dr.PorcImpRet3
                .PorcImpRet4 = dr.PorcImpRet4
                .PorcImpRet5 = dr.PorcImpRet5
                .MontoImpRet1 = dr.MontoImpRet1
                .MontoImpRet2 = dr.MontoImpRet2
                .MontoImpRet3 = dr.MontoImpRet3
                .MontoImpRet4 = dr.MontoImpRet4
                .MontoImpRet5 = dr.MontoImpRet5
            End With
            recepcion.Servicios.AddServiciosRow(drServicio)
        Next
    End Sub

#End Region

#Region "Implementacion Forma"

    Public Overloads Function ShowDialog(owner As Form, idOrden As String) As DialogResult
        Me.IdOrden = idOrden
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub NuevaRecepcionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'Cargar información de la orden de compra
            Dim OrdenFac As New OrdenFacade
            Dim Orden As OrdenInfo = OrdenFac.GetDetail(App.Session.SessionID, IdOrden)

            'Cargar información del proveedor
            ProveedorFac = New ProveedorFacade
            Proveedor = ProveedorFac.GetDetail(App.Session.SessionID, Orden.IdProveedor, False)
            If Not Proveedor.FacturaElectronica Then
                HabilitarFacturaManual()
            End If
            'Cargar información de la orden dentro de la recepción
            Recepcion = New RecepcionInfo(App.Session.SessionID, IdOrden)
            AsignarArticulos(Orden, Recepcion)
            AsignarServicios(Orden, Recepcion)
            '
            cboDivisa.LoadList()
            cboDivisa.SelectedValue = Orden.IdDivisa
            CargarEmpaquetados(Recepcion)
            bsArticulos.DataSource = Recepcion.Articulos
            grdArticulos.Rebind(True)
            bsServicios.DataSource = Recepcion.Servicios
            grdServicios.Rebind(True)
            MostrarTotales()
            '
            AddHandler txtSubTotalFact.TextChanged, AddressOf MontosFactura_Changed
            AddHandler txtImpuestosFact.TextChanged, AddressOf MontosFactura_Changed
            AddHandler txtRetencionesFact.TextChanged, AddressOf MontosFactura_Changed

        Catch ex As Exception
            MsgInfo.Show(ex)
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        ' Dim Etiquetas As List(Of Azteca.Business.Inventario.Etiqueta) = New List(Of Azteca.Business.Inventario.Etiqueta)
        Dim OrdenFac As New OrdenFacade
        Dim Orden As OrdenInfo = OrdenFac.GetDetail(App.Session.SessionID, IdOrden)
        Dim folioOrden As String = String.Empty
        GuardarEmpaquetados(Recepcion)
        grdArticulos.UpdateData()
        grdServicios.UpdateData()
        Recepcion.CalcularTotales()
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                cmdAceptar.Enabled = False
                With Recepcion
                    .Fecha = Date.Today
                    .SerieFactura = txtSerie.Text
                    .FolioFactura = CInt(Val(txtFolio.Text))
                    .UUIDFactura = txtUUID.Text
                    .Flete = CDec(Val(txtFlete.Text))

                    For Each row As DetalleRecepcionDS.ArticulosRow In .Articulos.Rows
                        Dim Etiquetas As List(Of Azteca.Business.Inventario.Etiqueta) = New List(Of Azteca.Business.Inventario.Etiqueta)
                        Dim etiqDetalle As New Azteca.Business.Inventario.Etiqueta
                        '                        etiqDetalle.OrdenCompra = IdOrden
                        folioOrden = Orden.FolioExt.Trim()
                        etiqDetalle.OrdenCompra = folioOrden.Substring(folioOrden.Length - 5, 5)
                        etiqDetalle.CodigoArticulo = row.Codigo
                        etiqDetalle.DescArticulo = row.Descripcion
                        etiqDetalle.CodigoProveedor = Proveedor.UserCode
                        etiqDetalle.NombreProveedor = Proveedor.Nombre
                        etiqDetalle.Etiqueta = CInt(IIf(row.Etiqueta = String.Empty, "1", row.Etiqueta))
                        etiqDetalle.Cantidad = Math.Round(row.CantidadAux / etiqDetalle.Etiqueta, 2)
                        etiqDetalle.UnidMedida = row.UnidadMedida
                        etiqDetalle.LineaArticulo = "1[Genérico]"
                        etiqDetalle.LoteArticulo = Math.Round(row.Saldo, 2).ToString()
                        etiqDetalle.Reimpresion = False
                        Etiquetas.Add(etiqDetalle)
                        For i = 1 To etiqDetalle.Etiqueta
                            Dim ImpEtiqueta = New Azteca.Windows.Inventario.ImprimeEtiqueta()
                            If ImpEtiqueta.ShowDialog(Owner, IdOrden, Etiquetas, True, i) = System.Windows.Forms.DialogResult.OK Then
                                ImpEtiqueta.Dispose()
                                ImpEtiqueta.Close()
                            End If
                        Next
                        DialogResult = System.Windows.Forms.DialogResult.OK
                    Next
                End With
                Dim RecepcionFac As New RecepcionFacade
                RecepcionFac.Update(Recepcion)

                ''Dim ImpEtiqueta = New Azteca.Windows.Inventario.ImprimeEtiqueta()
                ''ImpEtiqueta.ShowDialog(Owner, IdOrden, Etiquetas, True)
                '   If ImpEtiqueta.ShowDialog(Owner, IdOrden, Etiquetas, True) = System.Windows.Forms.DialogResult.OK Then
                ' ImpEtiqueta.Dispose()
                ' ImpEtiqueta.Close()
                ' End If
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
                cmdAceptar.Enabled = True
            End Try
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtFlete_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFlete.TextChanged        
        MostrarTotales()
    End Sub

    Private Sub btnSelFactura_Click(sender As System.Object, e As System.EventArgs) Handles btnSelFactura.Click
        Dim frmFacturas As New FacturasProveedorForm()
        If frmFacturas.ShowDialog(Me, Proveedor.Identity) = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim FacturaFac As New ComprobanteFiscalFacade
                Dim Factura As ComprobanteFiscalInfo = FacturaFac.Load(App.Session.SessionID, Proveedor.Identity, frmFacturas.Serie, frmFacturas.Folio, frmFacturas.UUID)
                With Factura
                    txtSerie.Text = .Serie
                    txtFolio.Text = .Folio.ToString
                    txtUUID.Text = .UUID
                    txtSubTotalFact.Text = .SubTotal.ToString
                    txtImpuestosFact.Text = .Impuestos.TotalTraslados.ToString
                    txtRetencionesFact.Text = .Impuestos.TotalRetenciones.ToString
                    txtTotalFact.Text = .Total.ToString
                End With
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub MontosFactura_Changed(sender As Object, e As EventArgs)
        Dim TextBox As Azteca.Windows.Controls.CITextBox = CType(sender, Azteca.Windows.Controls.CITextBox)
        If Not TextBox.ReadOnly Then
            CalcularTotalFactura()
        End If
    End Sub

#End Region

#Region "Implementacion Articulos"

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        Try
            grdArticulos.UpdateData()
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdArticulos.BeforeColEdit
        Try
            Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
            Dim IdUnidadMedidaTipo As Integer = CInt(drvPartida("IdUnidadMedidaTipo"))
            Dim IdUnidadMedida As Integer = CInt(drvPartida("IdUnidadMedida"))
            If e.Column.Name = "Cantidad" Then
                'Si el tipo de unidad es de piezas (y cajas)
                If IdUnidadMedidaTipo = 1 Then
                    grdArticulos.Columns(e.ColIndex).EditMask = "000000000"
                Else
                    grdArticulos.Columns(e.ColIndex).EditMask = String.Empty
                End If
            ElseIf e.Column.Name = "Unidades" Then
                'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
                If (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then e.Cancel = True
            ElseIf e.Column.Name = "Etiqueta" Then
                'Si el tipo de unidad es de Etiqueta
                grdArticulos.Columns(e.ColIndex).EditMask = "000000000"
                grdArticulos.Columns(e.ColIndex).DefaultValue = "1"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdArticulos_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            Dim IdUnidadMedida As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedida").CellValue(e.Row)))
            Dim IdUnidadMedidaTipo As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedidaTipo").CellValue(e.Row)))
            ' Dim etiqValor As String = CStr(grdArticulos.Columns("Etiqueta").CellValue(e.Row))
            If IdUnidadMedida = 0 Then Return

            ' If etiqValor = String.Empty Then
            ' 'grdArticulos.Columns("Saldo").Value = "1"
            ' grdArticulos.Columns(e.Row).Value = "1"
            ' grdArticulos.UpdateData()
            ' End If

            'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
            If e.Column.Name = "Unidades" And (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If
            If e.Column.Name = "Saldo" Then
                Dim UnidadMedida As UnidadMedidaInfo = GetUnidadMedida(IdUnidadMedida)
                Dim Cantidad As Empaquetado
                If IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1 Then
                    Cantidad = New Empaquetado(CDec(grdArticulos.Columns("Cantidad").Value), UnidadMedida.Factor)
                Else
                    Cantidad = New Empaquetado(CInt(grdArticulos.Columns("Cantidad").Value), CInt(grdArticulos.Columns("Unidades").Value), UnidadMedida.Factor)
                End If
                Dim Saldo As New Empaquetado(CDec(grdArticulos.Columns("Saldo").Value), UnidadMedida.Factor)
                If Cantidad > Saldo Then
                    e.CellStyle.BackColor = Drawing.Color.OrangeRed
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Implementacion Servicios"

    Private Sub grdServicios_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.AfterColUpdate
        Try
            grdServicios.UpdateData()
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        Try

            If e.Column.Name = "Saldo" Then
                Dim Cantidad As Integer = CInt(grdServicios.Columns("Cantidad").Value)
                Dim Saldo As Integer = CInt(grdServicios.Columns("Saldo").Value)
                If Cantidad > Saldo Then
                    e.CellStyle.BackColor = Drawing.Color.OrangeRed
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

End Class