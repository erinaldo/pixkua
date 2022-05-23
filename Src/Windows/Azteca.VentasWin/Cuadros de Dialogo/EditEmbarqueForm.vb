Public Class EditEmbarqueForm
    Private Pedido As PedidoInfo
    Private ArticuloFac As PresentacionFacade
    Private UnidadMedidaFac As Azteca.Business.Inventario.UnidadMedidaFacade
    Private UnidadesMedida As DataTable


#Region "Metodos Privados"

    Private Sub MostrarTotales()        
        Pedido.CalcularTotales()
        With Pedido
            txtTotalCant.Text = Pedido.TotalCantidad.ToString("N0")
            txtSubTotal.Text = Pedido.SubTotal.ToString("C")
            txtImpuestos.Text = Pedido.TotalImpuestosTrasladados.ToString("C")
            txtRetenciones.Text = Pedido.TotalImpuestosRetenidos.ToString("C")
            txtDescuentos.Text = Pedido.TotalDescuentos.ToString("C")
            txtTotal.Text = Pedido.Total.ToString("C")
        End With
    End Sub


    Private Function CargarExistencia(ByVal idArticuloStock As Integer) As Decimal
        If Context.UnidadNegocio.IdAlmacen > 0 Then
            Return ArticuloFac.GetStock(App.Session.SessionID, idArticuloStock, Context.UnidadNegocio.IdAlmacen)
        Else
            Return 0D
        End If
    End Function

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

    Private Function ConvertirCantidad(ByVal cantidad As Decimal, ByVal idUnidadMedida As Integer, ByVal tipoConversion As Integer) As Decimal
        Dim UnidadMedidaInf As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(idUnidadMedida)
        'Convertir desde unidad base a unidades multiplo
        If tipoConversion = 1 Then
            Return cantidad / UnidadMedidaInf.Factor
        Else 'Convertir unidad múltiplo a unidad base
            Return cantidad * UnidadMedidaInf.Factor
        End If
    End Function

    Private Function ValidarPrecio(ByVal precio As PrecioInfo) As Boolean
        ValidarPrecio = False
        If precio.Precio = 0 Then
            MessageBox.Show("El precio del artículo debe ser mayor a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
        End If
    End Function

#End Region

#Region "Implementacion Forma"

    Private Sub EditEmbarqueForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "Implementacion Articulos"

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.AfterDelete
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.AfterInsert
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdArticulos.BeforeColEdit
        Try
            'Si se está intenando editar una columna sin haber seleccionado el código de artículo no permitirlo
            If e.Column.Name <> "Código" AndAlso grdArticulos.Columns("Código").Text = String.Empty Then
                e.Cancel = True
                MessageBox.Show("Primero debe capturar el código del artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
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
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdArticulos_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdArticulos.BeforeColUpdate
        If bsArticulos.Current IsNot Nothing Then
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdArticulos.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdArticulos.Columns("Código").Text.Trim
                    If Context.Articulos.ContainsKey(Codigo) OrElse ArticuloFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ArticuloInf As Azteca.Business.Inventario.ArticuloStockInfo
                        'Checar si el artículo se encuentra en el caché, si no, cargarlo
                        If Context.Articulos.ContainsKey(Codigo) Then
                            ArticuloInf = Context.Articulos(Codigo)
                        Else
                            ArticuloInf = ArticuloFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                            Context.Articulos.Add(Codigo, ArticuloInf)
                        End If
                        If Pedido.Articulos.FindByIdArticuloStock(ArticuloInf.Identity) Is Nothing Then
                            With ArticuloInf
                                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                                grdArticulos.Columns("Descripción").Text = .Nombre
                                grdArticulos.Columns("UnidadMedida").Value = .UnidadMedida
                                drvPartida("Cantidad") = 1
                                drvPartida("IdArticuloStock") = .Identity
                                drvPartida("IdUnidadMedida") = .IdUnidadMedida
                                drvPartida("IdUnidadMedidaTipo") = .IdTipoUnidadMedida
                                'Cargar información de precio
                                Dim Precio As PrecioInfo = ArticuloFac.GetPrecio(App.Session.SessionID, .Identity, Pedido.IdCliente, App.DefaultSite.Identity)
                                'Validar precio de artículo
                                If ValidarPrecio(Precio) Then
                                    Pedido.AsignarPrecio(drvPartida.Row, Precio)
                                Else
                                    e.Cancel = True
                                    Return
                                End If
                                'Cargar existencia en el almacén
                                drvPartida("ExistenciaBase") = CargarExistencia(.Identity)
                                drvPartida("Existencia") = ConvertirCantidad(CDec(drvPartida("ExistenciaBase")), .IdUnidadMedida, 1)
                                bsUnidades.Filter = "IdUnidadMedidaTipo=" & .IdTipoUnidadMedida
                            End With
                        Else
                            MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            e.Cancel = True
                        End If
                    Else
                        MessageBox.Show("El código de artículo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                Else
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdArticulos_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.ButtonClick
        Try
            If e.Column.Name = "Código" And Pedido.Status = WorkflowSteps.Save Then
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New MsgSearch
                If frmSearch.ShowDialog(ArticuloFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdArticulo As Integer = CInt(frmSearch.SelectedItem)
                    If Pedido.Articulos.FindByIdArticuloStock(IdArticulo) Is Nothing Then
                        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = ArticuloFac.GetDetail(App.Session.SessionID, IdArticulo)
                        If Not Context.Articulos.ContainsKey(Articulo.UserCode) Then Context.Articulos.Add(Articulo.UserCode, Articulo)
                        Dim drPartida As DetallePedidoDS.ArticulosRow
                        If grdArticulos.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                            drPartida = Pedido.Articulos.NewArticulosRow
                        Else
                            drPartida = CType(CType(bsArticulos.Current, DataRowView).Row, DetallePedidoDS.ArticulosRow)
                        End If
                        'Cargar información de precio
                        Dim Precio As PrecioInfo = ArticuloFac.GetPrecio(App.Session.SessionID, Articulo.Identity, Pedido.IdCliente, App.DefaultSite.Identity)
                        'Validar precio de artículo
                        If ValidarPrecio(Precio) Then
                            Pedido.AsignarPrecio(drPartida, Precio)
                        Else
                            Return
                        End If
                        'Asinar datos del artículo
                        With drPartida
                            .IdArticuloStock = Articulo.Identity
                            .Codigo = Articulo.UserCode
                            .Descripcion = Articulo.Nombre
                            .UnidadMedida = Articulo.UnidadMedida
                            .Cantidad = 1
                            .IdUnidadMedida = Articulo.IdUnidadMedida
                            .IdUnidadMedidaTipo = Articulo.IdTipoUnidadMedida
                            .ExistenciaBase = CargarExistencia(IdArticulo)
                            .Existencia = ConvertirCantidad(.ExistenciaBase, .IdUnidadMedida, 1)
                        End With
                        If drPartida.RowState = DataRowState.Detached Then Pedido.Articulos.AddArticulosRow(drPartida)
                        bsUnidades.Filter = "IdUnidadMedidaTipo=" & Articulo.IdTipoUnidadMedida
                    Else
                        MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                'Filtrar unidades de medida del mismo tipo que el artículo
            ElseIf e.Column.Name = "U.M." And bsArticulos.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsArticulos.Current, DataRowView)
                bsUnidades.Filter = "IdUnidadMedidaTipo=" & CInt(dr("IdUnidadMedidaTipo")).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            Dim IdUnidadMedida As Integer = CInt(Val(grdArticulos.Columns("U.M.").CellValue(e.Row)))
            Dim IdUnidadMedidaTipo As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedidaTipo").CellValue(e.Row)))
            If Pedido.Status > 1 Or IdUnidadMedida = 0 Then Return

            'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
            If e.Column.Name = "Unidades" And (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If

            'Si es una salida y no hay existencia suficiente, marcar campo de cantidad y de unidades
            If e.Column.Name = "Cantidad" Or e.Column.Name = "Unidades" Then
                Dim UnidadMedida As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(IdUnidadMedida)
                Dim CantidadEmp As Azteca.Business.Inventario.Empaquetado
                If IdUnidadMedidaTipo = 1 And IdUnidadMedida > 0 Then
                    CantidadEmp = New Azteca.Business.Inventario.Empaquetado(CInt(grdArticulos.Columns("Cantidad").CellValue(e.Row)), CInt(grdArticulos.Columns("Unidades").CellValue(e.Row)), UnidadMedida.Factor)
                Else
                    CantidadEmp = New Azteca.Business.Inventario.Empaquetado(CDec(grdArticulos.Columns("Cantidad").CellValue(e.Row)), UnidadMedida.Factor)
                End If
                Dim Cantidad As Decimal = CantidadEmp.ToDecimal * UnidadMedida.Factor
                Dim Existencia As Decimal = CDec(grdArticulos.Columns("ExistenciaBase").CellValue(e.Row))
                If Existencia < Cantidad Then
                    e.CellStyle.BackColor = Drawing.Color.Orange
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


#End Region

End Class