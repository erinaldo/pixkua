Imports Microsoft.Reporting.WinForms

Public Class TraspasosForm
    Private Concepto As ConceptoInfo
    Private ArticuloFac As ArticuloStockFacade
    Private UnidadMedidaFac As UnidadMedidaFacade
    Private UnidadesMedida As DataTable

#Region "Metodos Privados"

    Private Sub GuardarEmpaquetados(ByVal traspaso As TraspasoInfo)
        For Each drPartida As DetalleTraspasoDS.DetalleRow In traspaso.Details
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Empaquetado(CInt(drPartida.CantidadAux), drPartida.UnidadesAux, UnidadInf.Factor)
                    drPartida.CantidadEnviada = Cantidad.ToDecimal
                Else
                    drPartida.CantidadEnviada = drPartida.CantidadAux
                End If
            End If
        Next
    End Sub

    Private Sub CargarEmpaquetados(ByVal traspaso As TraspasoInfo)
        For Each drPartida As DetalleTraspasoDS.DetalleRow In traspaso.Details
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Azteca.Business.Inventario.Empaquetado(drPartida.CantidadEnviada, UnidadInf.Factor)
                    drPartida.CantidadAux = Cantidad.Cajas
                    drPartida.UnidadesAux = Cantidad.Unidades
                Else
                    drPartida.CantidadAux = drPartida.CantidadEnviada
                End If
            End If
        Next
    End Sub

    Private Sub MostrarTotales()
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        GuardarEmpaquetados(Traspaso)
        Traspaso.CalcularTotales()

        txtTotalCant.Text = Traspaso.TotalCantidad.ToString("N3")
        txtTotalCosto.Text = Traspaso.TotalCosto.ToString("C")
    End Sub

    Private Function CargarStockInfo(ByVal idArticuloStock As Integer) As StockInfo
        Dim AlmacenFac As New AlmacenFacade
        Return AlmacenFac.GetStockInfo(App.Session.SessionID, CInt(cboAlmacenOrig.SelectedValue), idArticuloStock)
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

    Private Function CalcularCosto(ByVal costo As Decimal, ByVal idUnidadMedida As Integer) As Decimal
        Dim UnidadMedidaInf As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(idUnidadMedida)
        Return costo * UnidadMedidaInf.Factor
    End Function

#End Region

#Region "Implementacion"

    Protected Overrides Function IsValid() As Boolean
        IsValid = False
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        If cboAlmacenOrig.SelectedValue = cboAlmacenDest.SelectedValue Then
            MessageBox.Show("El almacén origen y el almacén destino no pueden ser el mismo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboAlmacenOrig.Focus()
        ElseIf Traspaso.Details.Count = 0 Then
            MessageBox.Show("El documento debe contener por lo menos una partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grdPartidas.Focus()
        Else
            Return MyBase.IsValid()
        End If
    End Function

    Private Sub TraspasosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        bsDetalle.DataSource = Traspaso.Details
        grdPartidas.Rebind(True)
        cboConcepto.Enabled = True
        txtOrdenTrabajo.Text = ""
    End Sub

    Private Sub TraspasosForm_ItemSaved(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemSaved
        cboConcepto.Enabled = False
    End Sub

    Private Sub TraspasosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ArticuloFac = New ArticuloStockFacade
        UnidadMedidaFac = New UnidadMedidaFacade

        Try
            UnidadesMedida = UnidadMedidaFac.LoadList(App.Session.SessionID)
            bsUnidades.DataSource = UnidadesMedida
            cboUnidades.DataSource = bsUnidades
            cboUnidades.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try
    End Sub

    Private Sub TraspasosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        With Traspaso
            cboAlmacenOrig.SelectedValue = .IdAlmacenOrigen
            cboAlmacenDest.SelectedValue = .IdAlmacenDestino
            cboConcepto.SelectedValue = .IdConcepto
            txtNotas.Text = .Observaciones
            txtTotalCant.Text = .TotalCantidad.ToString("N3")
            txtFlete.Text = .Flete.ToString
            txtOrdenTrabajo.Text = .OrdenTrabajo
            txtTotalCosto.Text = .TotalCosto.ToString("C")
            If .Aplicado Then
                txtFechaAplicado.Text = .HoraAplicado.ToString("dd/MM/yyyy hh:mm:ss tt")
            Else
                txtFechaAplicado.Text = "N/A"
            End If
            bsDetalle.DataSource = .Details
            grdPartidas.Rebind(True)
        End With
        cboConcepto.Enabled = False
        CargarEmpaquetados(Traspaso)
        MostrarTotales()
    End Sub

    Private Sub TraspasosForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboConcepto.LoadList(False, TipoConcepto.Traspaso)
        cboAlmacenOrig.LoadList(App.DefaultSite.Identity, App.Session.User.Identity, TipoAccesoAlmacen.Salida)
        cboAlmacenDest.LoadList(App.DefaultSite.Identity, App.Session.User.Identity, TipoAccesoAlmacen.Entrada)
    End Sub

    Private Sub TraspasosForm_PrintingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PrintingItem
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        Dim TraspasoFac As New TraspasoFacade
        Dim dtInforme As DataTable = TraspasoFac.GetInforme(App.Session.SessionID, Traspaso.Identity)
        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        'Configurar reporte
        Dim frmInforme As New ReportForm
        frmInforme.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.TraspasoRPT.rdlc"
        frmInforme.LocalReport.DataSources.Add(New ReportDataSource("ReportData", dtInforme))
        frmInforme.LocalReport.SetParameters(Parametros)
        frmInforme.Show("Traspaso entre Almacenes")
    End Sub

    Private Sub TraspasosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        grdPartidas.UpdateData()
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        With Traspaso
            .IdAlmacenOrigen = CInt(cboAlmacenOrig.SelectedValue)
            .IdAlmacenDestino = CInt(cboAlmacenDest.SelectedValue)
            .IdConcepto = CInt(cboConcepto.SelectedValue)
            .Observaciones = txtNotas.Text
            .Flete = CDec(Val(txtFlete.Text))
            .OrdenTrabajo = txtOrdenTrabajo.Text
        End With
        GuardarEmpaquetados(Traspaso)
        For Each dr As DetalleTraspasoDS.DetalleRow In Traspaso.Details
            If dr.RowState <> DataRowState.Deleted Then dr.CantidadRecibida = dr.CantidadEnviada
        Next
    End Sub

    Private Sub cboConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConcepto.SelectedIndexChanged
        If cboConcepto.SelectedIndex >= 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim ConceptoFac As New ConceptoFacade
                Concepto = ConceptoFac.GetDetailFromCache(App.Session.SessionID, CInt(cboConcepto.SelectedValue))
                SetDocumentType(Concepto.TipoDocumento.Identity)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

#End Region

#Region "Partidas"

    Private Sub grdPartidas_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdPartidas.AfterColUpdate
        Try
            Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
            If e.Column.Name = "U.M." Then
                Dim drvPartida As DataRowView = CType(bsDetalle.Current, DataRowView)
                grdPartidas.Columns("Descripción U.M.").Text = cboUnidades.Columns("Nombre").Text
                Dim IdUnidadMedida As Integer = CInt(cboUnidades.Columns("ID").Value)
                grdPartidas.Columns("Existencia").Text = ConvertirCantidad(CDec(drvPartida("ExistenciaBase")), IdUnidadMedida, 1).ToString
                grdPartidas.Columns("Unidades").Text = "0"
            ElseIf e.Column.Name = "Código" Then
                grdPartidas.UpdateData()
            End If
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdPartidas_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPartidas.AfterDelete
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        MostrarTotales()
    End Sub

    Private Sub grdPartidas_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPartidas.AfterInsert
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdPartidas_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdPartidas.BeforeColEdit
        Try
            'Validar que el almacén esté seleccionado un almacén
            If cboAlmacenOrig.SelectedIndex = -1 Then
                MessageBox.Show("Perimero debe seleccionar el almacén origen.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True
                Return
            End If
            'Si se está intenando editar una columna sin haber seleccionado el código de artículo no permitirlo
            If e.Column.Name <> "Código" AndAlso grdPartidas.Columns("Código").Text = String.Empty Then
                e.Cancel = True
                MessageBox.Show("Primero debe capturar el código del artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim drvPartida As DataRowView = CType(bsDetalle.Current, DataRowView)
                Dim IdUnidadMedidaTipo As Integer = CInt(drvPartida("IdUnidadMedidaTipo"))
                Dim IdUnidadMedida As Integer = CInt(drvPartida("IdUnidadMedida"))
                If e.Column.Name = "Cantidad" Then
                    'Si el tipo de unidad es de piezas (y cajas)
                    If IdUnidadMedidaTipo = 1 Then
                        grdPartidas.Columns(e.ColIndex).EditMask = "000000000"
                    Else
                        grdPartidas.Columns(e.ColIndex).EditMask = String.Empty
                    End If
                ElseIf e.Column.Name = "Unidades" Then
                    'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
                    If (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then e.Cancel = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdPartidas_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdPartidas.BeforeColUpdate
        If bsDetalle.Current IsNot Nothing Then
            Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdPartidas.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdPartidas.Columns("Código").Text.Trim
                    If Context.Articulos.ContainsKey(Codigo) OrElse ArticuloFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ArticuloInf As ArticuloStockInfo
                        'Checar si el artículo se encuentra en el caché, si no, cargarlo
                        If Context.Articulos.ContainsKey(Codigo) Then
                            ArticuloInf = Context.Articulos(Codigo)
                        Else
                            ArticuloInf = ArticuloFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                            Context.Articulos.Add(Codigo, ArticuloInf)
                        End If
                        If Traspaso.Details.FindByIdArticuloStock(ArticuloInf.Identity) Is Nothing Then
                            With ArticuloInf
                                Dim Info As StockInfo = CargarStockInfo(.Identity)
                                Dim drvPartida As DataRowView = CType(bsDetalle.Current, DataRowView)
                                grdPartidas.Columns("Descripción").Text = .Nombre
                                grdPartidas.Columns("UnidadMedida").Value = .UnidadMedida
                                drvPartida("CantidadAux") = 1
                                drvPartida("IdArticuloStock") = .Identity
                                drvPartida("IdUnidadMedida") = .IdUnidadMedida
                                drvPartida("IdUnidadMedidaTipo") = .IdTipoUnidadMedida
                                drvPartida("ExistenciaBase") = Info.Existencia
                                drvPartida("Existencia") = ConvertirCantidad(Info.Existencia, .IdUnidadMedida, 1)
                                drvPartida("CostoUnitario") = CalcularCosto(Info.UltimoCosto, .IdUnidadMedida)
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

    Private Sub grdPartidas_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdPartidas.ButtonClick
        Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
        Try
            If e.Column.Name = "Código" And Traspaso.Status = WorkflowSteps.Save Then
                'Validar que el almacén esté seleccionado un almacén
                If cboAlmacenOrig.SelectedIndex = -1 Then
                    MessageBox.Show("Perimero debe seleccionar el almacén origen.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New MsgSearch
                If frmSearch.ShowDialog(ArticuloFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdArticulo As Integer = CInt(frmSearch.SelectedItem)

                    If Traspaso.Details.FindByIdArticuloStock(IdArticulo) Is Nothing Then
                        Dim Articulo As ArticuloStockInfo = ArticuloFac.GetDetail(App.Session.SessionID, IdArticulo, False)
                        If Not Context.Articulos.ContainsKey(Articulo.UserCode) Then Context.Articulos.Add(Articulo.UserCode, Articulo)
                        Dim drPartida As DetalleTraspasoDS.DetalleRow
                        If grdPartidas.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                            drPartida = Traspaso.Details.NewDetalleRow
                        Else
                            drPartida = CType(CType(bsDetalle.Current, DataRowView).Row, DetalleTraspasoDS.DetalleRow)
                        End If
                        With drPartida
                            Dim Info As StockInfo = CargarStockInfo(Articulo.Identity)
                            .IdArticuloStock = Articulo.Identity
                            .CodigoArticulo = Articulo.UserCode
                            .NombreArticulo = Articulo.Nombre
                            .UnidadMedida = Articulo.UnidadMedida
                            .CantidadAux = 1
                            .IdUnidadMedida = Articulo.IdUnidadMedida
                            .IdUnidadMedidaTipo = Articulo.IdTipoUnidadMedida
                            .ExistenciaBase = Info.Existencia
                            .Existencia = ConvertirCantidad(Info.Existencia, .IdUnidadMedida, 1)
                            .CostoUnitario = CalcularCosto(Info.UltimoCosto, .IdUnidadMedida)
                        End With
                        If drPartida.RowState = DataRowState.Detached Then Traspaso.Details.AddDetalleRow(drPartida)
                        bsUnidades.Filter = "IdUnidadMedidaTipo=" & Articulo.IdTipoUnidadMedida
                    Else
                        MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                'Filtrar unidades de medida del mismo tipo que el artículo
            ElseIf e.Column.Name = "U.M." And bsDetalle.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsDetalle.Current, DataRowView)
                bsUnidades.Filter = "IdUnidadMedidaTipo=" & CInt(dr("IdUnidadMedidaTipo")).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdPartidas_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdPartidas.FetchCellStyle
        Try
            Dim Traspaso As TraspasoInfo = CType(PackageInfo, TraspasoInfo)
            Dim IdUnidadMedida As Integer = CInt(Val(grdPartidas.Columns("U.M.").CellValue(e.Row)))
            Dim IdUnidadMedidaTipo As Integer = CInt(Val(grdPartidas.Columns("IdUnidadMedidaTipo").CellValue(e.Row)))
            If Traspaso.Status > 1 Or IdUnidadMedida = 0 Then Return

            'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
            If e.Column.Name = "Unidades" And (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If

            'Si es una salida y no hay existencia suficiente, marcar campo de cantidad y de unidades
            If e.Column.Name = "Cantidad" Or e.Column.Name = "Unidades" Then
                Dim UnidadMedida As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(IdUnidadMedida)
                Dim CantidadEmp As Azteca.Business.Inventario.Empaquetado
                If IdUnidadMedidaTipo = 1 And IdUnidadMedida > 0 Then
                    CantidadEmp = New Azteca.Business.Inventario.Empaquetado(CInt(grdPartidas.Columns("Cantidad").CellValue(e.Row)), CInt(grdPartidas.Columns("Unidades").CellValue(e.Row)), UnidadMedida.Factor)
                Else
                    CantidadEmp = New Azteca.Business.Inventario.Empaquetado(CDec(grdPartidas.Columns("Cantidad").CellValue(e.Row)), UnidadMedida.Factor)
                End If
                Dim Cantidad As Decimal = CantidadEmp.ToDecimal * UnidadMedida.Factor
                Dim Existencia As Decimal = CDec(grdPartidas.Columns("ExistenciaBase").CellValue(e.Row))
                If Existencia < Cantidad Then
                    e.CellStyle.BackColor = Drawing.Color.Orange
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

End Class