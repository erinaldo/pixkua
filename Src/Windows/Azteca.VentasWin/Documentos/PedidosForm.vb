Public Class PedidosForm
    Private ArticuloFac As PresentacionFacade
    Private ServicioFac As ServicioFacade
    Private UnidadMedidaFac As Azteca.Business.Inventario.UnidadMedidaFacade
    Private UnidadesMedida As DataTable
    Private FormatoFactura As String

#Region "Metodos Privados"

    Private Sub MostrarTotales()
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        Pedido.CalcularTotales()
        With Pedido

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

    Private Function ValidHeader() As Boolean
        ValidHeader = False
        If txtCliente.Key = 0 Then
            MessageBox.Show("Primero debe elegir un cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboDivisa.SelectedIndex = -1 Then
            MessageBox.Show("Primero debe seleccionar la divisa del documento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
        End If
    End Function

    Private Function ValidarPrecio(ByVal precio As PrecioInfo) As Boolean
        ValidarPrecio = False
        If precio.Precio = 0 Then
            MessageBox.Show("El precio del artículo debe ser mayor a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf precio.IdDivisa <> CInt(cboDivisa.SelectedValue) Then
            MessageBox.Show("La divisa de los artículos debe corresponder a la divisa del documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
        End If
    End Function

#End Region

#Region "Implementacion"

    Private Sub VentasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        bsServicios.DataSource = Pedido.Servicios
        bsArticulos.DataSource = Pedido.Articulos
        grdArticulos.Rebind(True)
        grdServicios.Rebind(True)
        MostrarTotales()
        cboDivisa.SelectedValue = Context.UnidadNegocio.IdDivisaBase
        dtpFecha.Value = App.Session.BussinesDate
    End Sub

    Private Sub VentasForm_ItemSaved(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemSaved
        MostrarTotales()
    End Sub

    Private Sub VentasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtpFecha.Value = App.Session.BussinesDate
            ArticuloFac = New PresentacionFacade
            ServicioFac = New ServicioFacade
            UnidadMedidaFac = New Azteca.Business.Inventario.UnidadMedidaFacade
            'Cargar unidades de medida
            UnidadesMedida = UnidadMedidaFac.LoadList(App.Session.SessionID)
            bsUnidades.DataSource = UnidadesMedida
            cboUnidades.DataSource = bsUnidades
            cboUnidades.Rebind(True)
            'Cargar formato de factura asignado a la sucursal
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            FormatoFactura = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub VentasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        With Pedido
            dtpFecha.Value = .Fecha
            txtCliente.LoadInfo(.IdCliente)
            cboDivisa.SelectedValue = .IdDivisa
            txtNotas.Text = .Observaciones
            MostrarTotales()
            bsServicios.DataSource = .Servicios
            bsArticulos.DataSource = .Articulos
            grdArticulos.Rebind(True)
            grdServicios.Rebind(True)
        End With
    End Sub

    Private Sub VentasForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboDivisa.LoadList()
        cboVendedor.LoadList()
    End Sub

    Private Sub VentasForm_PrintingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PrintingItem
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        Dim VentaFac As New VentaFacade
        'Cargar información de impresión de la venta
        Dim dtVenta As DataTable = VentaFac.LoadPrintInfo(App.Session.SessionID, Pedido.Identity)
        'Definir parametros del informe
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        'Mostrar vista previa de la venta
        Dim frmVenta As New ReportForm
        frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.Orden.rdlc"
        frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Venta", CType(dtVenta, DataTable)))
        frmVenta.LocalReport.SetParameters(Parametros)
        frmVenta.Show("Orden de Venta " & Pedido.Identity)
    End Sub

    Private Sub VentasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        With Pedido
            .Fecha = dtpFecha.Value
            If (Pedido.Identity = String.Empty) Then
                .FechaEmbarque = Date.Parse("00:00 01.01.1900")
                .FechaEntrega = Date.Parse("00:00 01.01.1900")
            End If
            .IdCliente = txtCliente.Key
            .IdDivisa = CInt(cboDivisa.SelectedValue)
            .Observaciones = txtNotas.Text
            .Hora = Date.Now
            .OrdenCompra = txtOrdenCompra.Text
            .IdReferencia = txtReferencia.Text
        End With
    End Sub

    Protected Overrides Sub OnApplyingItem(ByVal e As Forms.BusinessForms.DocumentStatusEventArgs)
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        MyBase.OnApplyingItem(e)
    End Sub

    Public Overrides Sub OnItemApplied(ByVal e As Azteca.Windows.Forms.BusinessForms.DocumentStatusEventArgs)
        Try
            MostrarTotales()
            MyBase.OnItemApplied(e)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtCliente_InfoLoaded(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If txtCliente.Key > 0 Then
                Dim Cliente As ClienteInfo = CType(txtCliente.PackageInfo, ClienteInfo)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cboDivisa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDivisa.SelectedIndexChanged
        Try
            If cboDivisa.SelectedIndex >= 0 Then                
                'Obtener el tipo de cambio
                Dim DivisaFac As New Azteca.Business.Contabilidad.DivisaFacade
                lblTipoCambio.Text = DivisaFac.GetTipoCambioActual(App.Session.SessionID, Context.UnidadNegocio.IdDivisaBase).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Implementacion Articulos"

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        Try
            Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
            If e.Column.Name = "U.M." Then
                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                grdArticulos.Columns("Descripción U.M.").Text = cboUnidades.Columns("Nombre").Text
                Dim IdUnidadMedida As Integer = CInt(cboUnidades.Columns("ID").Value)
                grdArticulos.Columns("Existencia").Text = ConvertirCantidad(CDec(drvPartida("ExistenciaBase")), IdUnidadMedida, 1).ToString
                grdArticulos.Columns("Unidades").Text = "0"
            ElseIf e.Column.Name = "Código" Then
                grdArticulos.UpdateData()
            End If
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
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdArticulos.BeforeColEdit
        Try
            'Validar que se haya capturado los datos del encabezado
            If Not ValidHeader() Then
                e.Cancel = True
                Return
            End If
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
            Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
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
                                Dim Precio As PrecioInfo = ArticuloFac.GetPrecio(App.Session.SessionID, .Identity, txtCliente.Key, App.DefaultSite.Identity)
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
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        Try
            If e.Column.Name = "Código" And Pedido.Status = WorkflowSteps.Save Then
                'Validar que el almacén esté seleccionado un almacén
                If Not ValidHeader() Then Return
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
                        Dim Precio As PrecioInfo = ArticuloFac.GetPrecio(App.Session.SessionID, Articulo.Identity, txtCliente.Key, App.DefaultSite.Identity)
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
            Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
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

#Region "Implementacion Servicios"

    Private Sub grdServicios_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.AfterColUpdate
        Try
            Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
            If e.Column.Name = "P. Unitario" Then
                Dim drvPartida As DataRowView = CType(bsServicios.Current, DataRowView)
                Dim Precio As PrecioInfo = ServicioFac.GetPrecio(App.Session.SessionID, CInt(drvPartida("IdServicio")), txtCliente.Key, App.DefaultSite.Identity, CDec(grdServicios.Columns("P. Unitario").Value))
                Pedido.AsignarPrecio(drvPartida.Row, Precio)
            End If
            grdArticulos.UpdateData()
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.AfterDelete
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.AfterInsert
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdServicios.BeforeColEdit
        Try
            'Validar que se haya capturado los datos del encabezado
            If Not ValidHeader() Then
                e.Cancel = True
                Return
            End If
            'Si se está intenando editar una columna sin haber seleccionado el código de servicio no permitirlo
            If e.Column.Name <> "Código" AndAlso grdServicios.Columns("Código").Text = String.Empty Then
                e.Cancel = True
                MessageBox.Show("Primero debe capturar el código del servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Si no es un servicio de concepto libre, no permitir editar las celdas de descripcion y precio unitario
                If e.Column.Name = "Descripción" Or e.Column.Name = "P. Unitario" Then
                    If Not CBool(grdServicios.Columns("ConceptoLibre").Value) Then e.Cancel = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdServicios_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdServicios.BeforeColUpdate
        If bsServicios.Current IsNot Nothing Then
            Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdServicios.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdServicios.Columns("Código").Text.Trim
                    If Context.Servicios.ContainsKey(Codigo) OrElse ServicioFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ServicioInf As ServicioInfo
                        'Checar si el artículo se encuentra en el caché, si no, cargarlo
                        If Context.Servicios.ContainsKey(Codigo) Then
                            ServicioInf = Context.Servicios(Codigo)
                        Else
                            ServicioInf = ServicioFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                            Context.Servicios.Add(Codigo, ServicioInf)
                        End If
                        If Pedido.Servicios.FindByIdServicioDescripcion(ServicioInf.Identity, ServicioInf.Nombre) Is Nothing Then
                            With ServicioInf
                                Dim drvPartida As DataRowView = CType(bsServicios.Current, DataRowView)
                                grdServicios.Columns("Descripción").Text = .Nombre
                                drvPartida("Cantidad") = 1
                                drvPartida("IdServicio") = .Identity
                                drvPartida("ConceptoLibre") = .ConceptoLibre
                                'Cargar información de precio
                                Dim Precio As PrecioInfo = ServicioFac.GetPrecio(App.Session.SessionID, .Identity, txtCliente.Key, App.DefaultSite.Identity)
                                'Validar precio de servicio
                                If ValidarPrecio(Precio) Then
                                    Pedido.AsignarPrecio(drvPartida.Row, Precio)
                                Else
                                    e.Cancel = True
                                    Return
                                End If
                            End With
                        Else
                            MessageBox.Show("El servicio ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            e.Cancel = True
                        End If
                    Else
                        MessageBox.Show("El código de servicio no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                Else
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdServicios_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.ButtonClick
        Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
        Try
            If e.Column.Name = "Código" And Pedido.Status = WorkflowSteps.Save Then
                'Validar que el almacén esté seleccionado un almacén
                If Not ValidHeader() Then Return
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New MsgSearch
                If frmSearch.ShowDialog(ServicioFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdServicio As Integer = CInt(frmSearch.SelectedItem)
                    If Pedido.Servicios.FindByIdServicioDescripcion(IdServicio, String.Empty) Is Nothing Then
                        Dim Servicio As ServicioInfo = ServicioFac.GetDetail(App.Session.SessionID, IdServicio, False)
                        If Not Context.Servicios.ContainsKey(Servicio.UserCode) Then Context.Servicios.Add(Servicio.UserCode, Servicio)
                        Dim drPartida As DetallePedidoDS.ServiciosRow
                        If grdServicios.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                            drPartida = Pedido.Servicios.NewServiciosRow
                        Else
                            drPartida = CType(CType(bsServicios.Current, DataRowView).Row, DetallePedidoDS.ServiciosRow)
                        End If
                        'Cargar información de precio
                        Dim Precio As PrecioInfo = ServicioFac.GetPrecio(App.Session.SessionID, Servicio.Identity, txtCliente.Key, App.DefaultSite.Identity)
                        'Validar precio de servicio
                        If ValidarPrecio(Precio) Then
                            Pedido.AsignarPrecio(drPartida, Precio)
                        Else
                            Return
                        End If
                        'Asignar datos del servicio
                        With drPartida
                            .IdServicio = Servicio.Identity
                            .Codigo = Servicio.UserCode
                            .Descripcion = Servicio.Nombre
                            .Cantidad = 1
                            .ConceptoLibre = Servicio.ConceptoLibre
                        End With
                        If drPartida.RowState = DataRowState.Detached Then Pedido.Servicios.AddServiciosRow(drPartida)
                    Else
                        MessageBox.Show("El servicio ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        Try
            Dim Pedido As PedidoInfo = CType(PackageInfo, PedidoInfo)
            'Si no es un servicio de concepto libre, sombrear celdas de descripcion y precio unitario
            If (e.Column.Name = "Descripción" Or e.Column.Name = "P. Unitario") And Not CBool(grdServicios.Columns("ConceptoLibre").CellValue(e.Row)) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region


End Class