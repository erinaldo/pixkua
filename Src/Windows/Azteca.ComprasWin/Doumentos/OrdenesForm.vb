Imports Microsoft.Reporting.WinForms
Imports Azteca.Business.Inventario
Imports Azteca.Kernel.BusinessStructure

Public Class OrdenesForm
    Private TipoAdmonPresupuesto As TipoAdmonPresupuestoEnum
    Private IdZonaCompra As Integer
    Private IdCentral As Integer
    Private ArticuloFac As ArticuloStockFacade
    Private ServicioFac As ServicioFacade
    Private ProveedorFac As ProveedorFacade
    Private Proveedor As ProveedorInfo
    Private Recepciones As DataTable

#Region "Metodos Privados"

    Private Function FindServicio(servicios As DetalleOrdenDS.ServiciosDataTable, idServicio As Integer) As DetalleOrdenDS.ServiciosRow
        Dim vwFind As New DataView(servicios, "IdServicio=" & idServicio.ToString, String.Empty, DataViewRowState.CurrentRows)
        If vwFind.Count > 0 Then
            Dim drServicio As DetalleOrdenDS.ServiciosRow = CType(vwFind(0).Row, DetalleOrdenDS.ServiciosRow)
            Return drServicio
        Else
            Return Nothing
        End If
    End Function

    Private Function FindArticulo(articulos As DetalleOrdenDS.ArticulosDataTable, idArticuloStock As Integer) As DetalleOrdenDS.ArticulosRow
        Dim vwFind As New DataView(articulos, "IdArticuloStock=" & idArticuloStock.ToString, String.Empty, DataViewRowState.CurrentRows)
        If vwFind.Count > 0 Then
            Dim drArticulo As DetalleOrdenDS.ArticulosRow = CType(vwFind(0).Row, DetalleOrdenDS.ArticulosRow)
            Return drArticulo
        Else
            Return Nothing
        End If
    End Function

    Private Sub CargarRecepciones()
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        Dim OrdenFac As New OrdenFacade
        Recepciones = OrdenFac.LoadRecepciones(App.Session.SessionID, Orden.Identity)
        bsRecepciones.DataSource = Recepciones
        grdRecepciones.Rebind(True)
    End Sub

    Private Sub MostrarTotales()
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        GuardarEmpaquetados(Orden)
        Orden.CalcularTotales()
        With Orden
            txtSubTotal.Text = Orden.SubTotal.ToString("C4")
            txtImpuestos.Text = Orden.TotalImpuestosTrasladados.ToString("C")
            txtRetenciones.Text = Orden.TotalImpuestosRetenidos.ToString("C")
            txtDescuentos.Text = Orden.TotalDescuentos.ToString("C")
            txtTotal.Text = Orden.Total.ToString("C4")
        End With
    End Sub

    Protected Overrides Function IsValid() As Boolean
        grdArticulos.UpdateData()
        If cboPresupuesto.Enabled And cboPresupuesto.SelectedIndex = -1 Then
            MessageBox.Show("El departamento seleccionado tiene prespuesto por lo que debe seleccionar uno.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboPresupuesto.Focus()
            Return False
        ElseIf IdCentral = 0 Then
            MessageBox.Show("El departamento seleccionado no tiene asignado una central de compras.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        ElseIf bsArticulos.Count = 0 AndAlso bsServicios.Count = 0 Then
            MessageBox.Show("Debe seleccionar al menos un artículo o servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            grdArticulos.Focus()
            Return False
        Else
            Return MyBase.IsValid()
        End If
    End Function

    Private Function ValidHeader() As Boolean
        ValidHeader = False
        If txtProveedor.Key = 0 Then
            MessageBox.Show("Debe elegir un proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboDepartamento.SelectedIndex = -1 Then
            MessageBox.Show("Primero debe seleccionar un departamento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboDivisa.SelectedIndex = -1 Then
            MessageBox.Show("Primero debe seleccionar una divisa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
        End If
    End Function

    Private Function ValidarCosto(ByVal costo As CostoInfo) As Boolean
        ValidarCosto = False
        If costo.Costo = 0 Then
            MessageBox.Show("El costo del artículo debe ser mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf costo.IdDivisa <> CInt(cboDivisa.SelectedValue) Then
            MessageBox.Show("La divisa de los artículos debe corresponder a la divisa del documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Return True
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

    Private Sub CargarEmpaquetados(ByVal orden As OrdenInfo)
        For Each drPartida As DetalleOrdenDS.ArticulosRow In orden.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Azteca.Business.Inventario.Empaquetado(drPartida.Cantidad, UnidadInf.Factor)
                    drPartida.CantidadAux = Cantidad.Cajas
                    drPartida.UnidadesAux = Cantidad.Unidades
                Else
                    drPartida.CantidadAux = drPartida.Cantidad
                End If
            End If
        Next
        orden.Articulos.AcceptChanges()
    End Sub

    Private Sub GuardarEmpaquetados(ByVal orden As OrdenInfo)
        For Each drPartida As DetalleOrdenDS.ArticulosRow In orden.Articulos
            If drPartida.RowState <> DataRowState.Deleted Then
                Dim UnidadInf As UnidadMedidaInfo = GetUnidadMedida(drPartida.IdUnidadMedida)
                'Si la unidad de medida son cajas, separar cajas y unidades
                If UnidadInf.IdTipoUnidad = 1 And UnidadInf.Identity > 0 Then
                    Dim Cantidad As New Empaquetado(CInt(drPartida.CantidadAux), drPartida.UnidadesAux, UnidadInf.Factor)
                    drPartida.Cantidad = Cantidad.ToDecimal
                Else
                    drPartida.Cantidad = drPartida.CantidadAux
                End If
            End If
        Next
    End Sub

#End Region

#Region "Implementacion"

    Private Sub OrdenesForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        bsArticulos.DataSource = Orden.Articulos
        bsServicios.DataSource = Orden.Servicios
        grdArticulos.Rebind(True)
        grdServicios.Rebind(True)
        'Obtener la divisa base
        Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim IdDivisaBase As Integer = CInt(ConfigMgr.GetSystemParameter("Configuracion/Contabilidad/Divisas", "Base"))
        cboDivisa.SelectedValue = IdDivisaBase
        cmdNuevaRecepcion.Enabled = False
    End Sub

    Private Sub OrdenesForm_ItemApplied(sender As Object, e As Forms.BusinessForms.DocumentStatusEventArgs) Handles Me.ItemApplied
        If e.IdStatus = WorkflowSteps.Apply Then
            cmdNuevaRecepcion.Enabled = True
        Else
            cmdNuevaRecepcion.Enabled = False
        End If
    End Sub


    Private Sub OrdenesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ArticuloFac = New ArticuloStockFacade
        ServicioFac = New ServicioFacade
        ProveedorFac = New ProveedorFacade
        Try
            'Cargar categorias presupuestales
            Dim CategoriaFac As New CategoriaPresupuestalFacade
            Dim CategoriasArt As DataTable = CategoriaFac.LoadListByArticulo(App.Session.SessionID, 0, App.Session.User.Identity)
            Dim CategoriasServ As DataTable = CategoriaFac.LoadListByServicio(App.Session.SessionID, 0, App.Session.User.Identity)
            bsCategoriasArt.DataSource = CategoriasArt
            bsCategoriasServ.DataSource = CategoriasServ
            cboCategoriasArt.Rebind(True)
            cboCategoriasServ.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub OrdenesForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        With Orden
            txtProveedor.Text = String.Empty
            txtProveedor.LoadInfo(.IdProveedor)
            cboDepartamento.SelectedValue = .IdDepartamento
            cboCentrosRecep.SelectedValue = .IdCentroRecepcion
            cboPresupuesto.SelectedValue = .IdPresupuesto
            cboDivisa.SelectedValue = .IdDivisa
            txtObervaciones.Text = .Observaciones
        End With
        CargarEmpaquetados(Orden)
        bsArticulos.DataSource = Orden.Articulos
        bsServicios.DataSource = Orden.Servicios
        grdArticulos.Rebind(True)
        grdServicios.Rebind(True)
        MostrarTotales()
        If Orden.Status = WorkflowSteps.Apply Then
            cmdNuevaRecepcion.Enabled = True
        Else
            cmdNuevaRecepcion.Enabled = False
        End If
        CargarRecepciones()
    End Sub

    Private Sub OrdenesForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboDepartamento.LoadList()
        cboDivisa.LoadList()
    End Sub

    Private Sub OrdenesForm_PrintingItem(sender As Object, e As System.EventArgs) Handles Me.PrintingItem
        If PackageInfo.Identity <> String.Empty Then
            Try
                Dim frmPrint As New ReportForm
                Dim OrdenFac As New OrdenFacade
                Dim Info As DataTable = OrdenFac.LoadPrintInfo(App.Session.SessionID, PackageInfo.Identity)
                '
                frmPrint.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.Orden_PLEC.rdlc"
                frmPrint.LocalReport.DataSources.Add(New ReportDataSource("ReportData", Info))
                frmPrint.Text = "Orden de Compra " & PackageInfo.Identity
                frmPrint.ShowDialog(Me)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub OrdenesForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        grdArticulos.UpdateData()
        grdServicios.UpdateData()
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        With Orden
            .IdProveedor = txtProveedor.Key
            .IdDepartamento = CInt(cboDepartamento.SelectedValue)
            .IdCentroRecepcion = CInt(cboCentrosRecep.SelectedValue)
            .IdPresupuesto = CInt(cboPresupuesto.SelectedValue)
            .IdDivisa = CInt(cboDivisa.SelectedValue)
            .IdCentralCompras = IdCentral
            .Origen = "M"
            .Observaciones = txtObervaciones.Text
        End With
        'Actualizar presupuesto en artículos y servicios
        For Each drArticulo As DetalleOrdenDS.ArticulosRow In Orden.Articulos
            drArticulo.IdPresupuesto = Orden.IdPresupuesto
        Next
        For Each drServicio As DetalleOrdenDS.ServiciosRow In Orden.Servicios
            drServicio.IdPresupuesto = Orden.IdPresupuesto
        Next
        GuardarEmpaquetados(Orden)
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
        If cboDepartamento.SelectedIndex >= 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                'Obtener el tipo de administración de presupuesto del departamento
                Dim dv As New DataView(cboDepartamento.ItemsTable, "IdDepartamento=" & CInt(cboDepartamento.SelectedValue), "", DataViewRowState.CurrentRows)
                Dim drvDepartamento As DataRowView = dv(0)
                TipoAdmonPresupuesto = DepartamentoInfo.GetTipoAdmonPresupuesto(CStr(drvDepartamento("AdmonPresupuesto")))
                IdZonaCompra = CInt(drvDepartamento("IdZonaCompra"))
                IdCentral = CInt(drvDepartamento("IdCentral"))

                'Cargar los centros de recepcion
                Dim DeptoFac As New DepartamentoFacade
                cboCentrosRecep.DisplayMember = "CentroRecepcion"
                cboCentrosRecep.ValueMember = "IdCentroRecepcion"
                Dim CentrosRecepcion As DataTable = DeptoFac.CentrosRecepcionList(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
                cboCentrosRecep.DataSource = CentrosRecepcion
                'Si habilitan los controles en base al tipo de presupuesto q maneja el departamento seleccionado
                If (TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado) Then
                    grdArticulos.Splits(0).DisplayColumns("Cat. Pres.").Locked = False
                    grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Locked = False
                    grdArticulos.Splits(0).DisplayColumns("Cat. Pres.").Style.BackColor = System.Drawing.SystemColors.Window
                    grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Style.BackColor = System.Drawing.SystemColors.Window
                Else
                    grdArticulos.Splits(0).DisplayColumns("Cat. Pres.").Locked = True
                    grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Locked = True
                    grdArticulos.Splits(0).DisplayColumns("Cat. Pres.").Style.BackColor = Drawing.Color.LightGray
                    grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Style.BackColor = Drawing.Color.LightGray
                End If
                '
                If TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Then
                    cboPresupuesto.SelectedIndex = -1
                    cboPresupuesto.Enabled = False
                Else
                    ''Llenar los presupuestos activos de este departamento
                    Dim dtPrespuestos As DataTable = DeptoFac.PresupuestosActivos(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
                    cboPresupuesto.Enabled = True
                    cboPresupuesto.DisplayMember = "Nombre"
                    cboPresupuesto.ValueMember = "IdPresupuesto"
                    cboPresupuesto.DataSource = dtPrespuestos
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

#End Region

#Region "Implementacion Articulos"

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        Try
            Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
            grdArticulos.UpdateData()
            MostrarTotales()
            If e.Column.Name = "Cat. Pres." Then
                grdArticulos.Columns("Descripción Categoría").Text = cboCategoriasArt.Columns("Nombre").Text
            End If
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
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
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
                ElseIf e.Column.Name = "Cat. Pres." And bsArticulos.Current IsNot Nothing Then
                    Dim dr As DataRowView = CType(bsArticulos.Current, DataRowView)
                    bsCategoriasArt.Filter = "IdArticuloStock=" & CInt(dr("IdArticuloStock")).ToString
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdArticulos_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdArticulos.BeforeColUpdate
        If bsArticulos.Current IsNot Nothing Then
            Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdArticulos.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdArticulos.Columns("Código").Text.Trim
                    If ArticuloFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ArticuloInf As CompraArticuloInfo = ProveedorFac.CargarArticuloFromCache(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, Codigo, App.DefaultSite.Identity)
                        If ArticuloInf IsNot Nothing Then
                            'Checar que el artículo no se encuentre en otra partida
                            If FindArticulo(Orden.Articulos, ArticuloInf.IdArticuloStock) Is Nothing Then
                                With ArticuloInf
                                    Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                                    'Cargar información de costos
                                    Dim Costo As CostoInfo = ProveedorFac.GetCostoArticulo(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, ArticuloInf.IdArticuloStock)
                                    If ValidarCosto(Costo) Then
                                        Orden.AsignarCosto(drvPartida.Row, Costo)
                                        grdArticulos.Columns("Descripción").Text = .Nombre
                                        grdArticulos.Columns("UnidadMedida").Value = .UnidadMedida
                                        drvPartida("CantidadAux") = 1
                                        drvPartida("IdArticuloStock") = .IdArticuloStock
                                        drvPartida("IdUnidadMedida") = .IdUnidadMedida
                                        drvPartida("IdUnidadMedidaTipo") = .IdTipoUnidadMedida
                                        bsCategoriasArt.Filter = "IdArticuloStock=" & .IdArticuloStock.ToString
                                    Else
                                        e.Cancel = True
                                        Return
                                    End If
                                End With
                            Else
                                MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                e.Cancel = True
                            End If
                        Else
                            MessageBox.Show("El artículo especificado no está asignado al proveedor de la orden." & ControlChars.NewLine & "De clic al botón de buscar para ver o modificar la lista de artículos asignados al proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            e.Cancel = True
                        End If
                    Else
                        MessageBox.Show("El código de artículo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                End If
            Catch ex As Exception
                e.Cancel = True
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdArticulos_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.ButtonClick
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        Try
            'Si no se ha introducido el código de artículo, no permitir función de los botones, excepto del de búsqueda de artículos
            If e.Column.Name <> "Código" AndAlso grdArticulos.Columns("Código").Text = String.Empty Then Return
            'Si se presionó el botón de búsqueda de artículos
            If e.Column.Name = "Código" And Orden.Status = WorkflowSteps.Save Then
                If grdArticulos.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then
                    bsArticulos.RemoveCurrent()
                    grdArticulos.UpdateData()
                End If
                'Validar que el almacén esté seleccionado un almacén
                If Not ValidHeader() Then Return
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmArticulos As New ArticulosProveedorForm
                If frmArticulos.ShowDialog(Me, IdZonaCompra, txtProveedor.Key, True) = System.Windows.Forms.DialogResult.OK Then
                    Dim SelectedItems As ProveedoresDS.ArticulosDataTable = frmArticulos.SelectedItems
                    For Each drArticulo As ProveedoresDS.ArticulosRow In SelectedItems
                        If FindArticulo(Orden.Articulos, drArticulo.IdArticuloStock) Is Nothing Then
                            Dim Articulo As CompraArticuloInfo = ProveedorFac.CargarArticuloFromCache(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, drArticulo.IdArticuloStock)
                            Dim drPartida As DetalleOrdenDS.ArticulosRow
                            drPartida = Orden.Articulos.NewArticulosRow
                            'Asinar datos del artículo
                            With drPartida
                                'Cargar información de costos
                                Dim Costo As CostoInfo = ProveedorFac.GetCostoArticulo(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, Articulo.IdArticuloStock)
                                If ValidarCosto(Costo) Then
                                    Orden.AsignarCosto(drPartida, Costo)
                                    .IdArticuloStock = Articulo.IdArticuloStock
                                    .Codigo = Articulo.Codigo
                                    .Descripcion = Articulo.Nombre
                                    .UnidadMedida = Articulo.UnidadMedida
                                    .CantidadAux = 1
                                    .IdUnidadMedida = Articulo.IdUnidadMedida
                                    .IdUnidadMedidaTipo = Articulo.IdTipoUnidadMedida
                                    bsCategoriasArt.Filter = "IdArticuloStock=" & .IdArticuloStock.ToString
                                Else
                                    Return
                                End If
                            End With
                            If drPartida.RowState = DataRowState.Detached Then Orden.Articulos.AddArticulosRow(drPartida)
                        End If
                    Next
                    grdArticulos.Refresh()
                    MostrarTotales()
                End If
            ElseIf e.Column.Name = "X" And Orden.Status = WorkflowSteps.Save Then
                bsArticulos.RemoveCurrent()
                MostrarTotales()
            ElseIf e.Column.Name = "N" Then
                'Mostrar el formulario de notas
                Dim frmNotas As New NotesForm
                If frmNotas.ShowDialog(Me, grdArticulos.Columns("N").Text, False) = System.Windows.Forms.DialogResult.OK Then
                    grdArticulos.Columns("N").Text = frmNotas.Notes
                    grdArticulos.UpdateData()
                End If
            ElseIf e.Column.Name = "Precio Unitario" And Orden.Status = WorkflowSteps.Save Then
                Dim drArticulo As DetalleOrdenDS.ArticulosRow = CType(CType(bsArticulos.Current, DataRowView).Row, DetalleOrdenDS.ArticulosRow)
                Dim frmArticulo As New EditArticuloProveedorForm
                If frmArticulo.ShowDialog(Me, IdZonaCompra, txtProveedor.Key, drArticulo.IdArticuloStock) = System.Windows.Forms.DialogResult.OK Then
                    Dim Articulo As CompraArticuloInfo = ProveedorFac.CargarArticuloFromCache(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, drArticulo.IdArticuloStock)
                    drArticulo.CostoUnitario = Articulo.Costo
                    drArticulo.IdUnidadMedida = Articulo.IdUnidadMedida
                    drArticulo.IdUnidadMedidaTipo = Articulo.IdTipoUnidadMedida
                    drArticulo.UnidadMedida = Articulo.UnidadMedida
                End If
                grdArticulos.UpdateData()
                MostrarTotales()
            ElseIf e.Column.Name = "Cat. Pres." And bsArticulos.Current IsNot Nothing Then
                Dim drArticulo As DataRowView = CType(bsArticulos.Current, DataRowView)
                bsCategoriasArt.Filter = "IdArticuloStock=" & CInt(drArticulo("IdArticuloStock")).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
            Dim IdUnidadMedida As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedida").CellValue(e.Row)))
            Dim IdUnidadMedidaTipo As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedidaTipo").CellValue(e.Row)))
            If Orden.Status > 1 Or IdUnidadMedida = 0 Then Return

            'Si el tipo de unidad no es de cajas, deshabilitar campo de unidades
            If e.Column.Name = "Unidades" And (IdUnidadMedidaTipo > 1 Or IdUnidadMedida = 1) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If

            'Si las categorias presupuestales están habilitadas, marcar registros sin categoria
            If e.Column.Name = "Cat. Pres." And Not grdArticulos.Splits(0).DisplayColumns("Cat. Pres.").Locked And Val(grdArticulos.Columns("Cat. Pres.").CellValue(e.Row)) <= 0 Then
                e.CellStyle.BackColor = Drawing.Color.OrangeRed
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdArticulos_FetchCellTips(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs) Handles grdArticulos.FetchCellTips
        If e.Column IsNot Nothing Then
            If e.Column.Name = "N" Then
                e.CellTip = grdArticulos.Columns("N").CellText(e.Row)
            End If
        End If
    End Sub

#End Region

#Region "Implementacion Servicios"

    Private Sub grdServicios_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.AfterColUpdate
        Try
            Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
            grdServicios.UpdateData()
            MostrarTotales()
            If e.Column.Name = "Cat. Pres." Then
                grdServicios.Columns("Descripción Categoría").Text = cboCategoriasServ.Columns("Nombre").Text
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterDelete(sender As Object, e As System.EventArgs) Handles grdServicios.AfterDelete
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterInsert(sender As Object, e As System.EventArgs) Handles grdServicios.AfterInsert
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        Try
            MostrarTotales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_BeforeColEdit(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdServicios.BeforeColEdit
        Try
            'Validar que se haya capturado los datos del encabezado
            If Not ValidHeader() Then
                e.Cancel = True
                Return
            End If
            'Si se está intenando editar una columna sin haber seleccionado el código de artículo no permitirlo
            If e.Column.Name <> "Código" AndAlso grdServicios.Columns("Código").Text = String.Empty Then
                e.Cancel = True
                MessageBox.Show("Primero debe capturar el código del servicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf e.Column.Name = "Cat. Pres." And bsServicios.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsServicios.Current, DataRowView)
                bsCategoriasServ.Filter = "IdServicio=" & CInt(dr("IdServicio")).ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdServicios_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdServicios.BeforeColUpdate
        If bsServicios.Current IsNot Nothing Then
            Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdServicios.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdServicios.Columns("Código").Text.Trim
                    If ServicioFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ServicioInf As CompraServicioInfo = ProveedorFac.CargarServicioFromCache(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, Codigo, App.DefaultSite.Identity)
                        If ServicioInf IsNot Nothing Then
                            'Checar que el artículo no se encuentre en otra partida
                            If FindServicio(Orden.Servicios, ServicioInf.IdServicio) Is Nothing Then
                                With ServicioInf
                                    Dim drvPartida As DataRowView = CType(bsServicios.Current, DataRowView)
                                    'Cargar información de costos
                                    Dim Costo As CostoInfo = ProveedorFac.GetCostoServicio(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, ServicioInf.IdServicio)
                                    If ValidarCosto(Costo) Then
                                        Orden.AsignarCosto(drvPartida.Row, Costo)
                                        grdServicios.Columns("Descripción").Text = .Nombre
                                        drvPartida("Cantidad") = 1
                                        drvPartida("IdServicio") = .IdServicio
                                        bsCategoriasServ.Filter = "IdServicio=" & .IdServicio.ToString
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
                            MessageBox.Show("El servicio especificado no está asignado al proveedor de la orden." & ControlChars.NewLine & "De clic al botón de buscar para ver o modificar la lista de servicios asignados al proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            e.Cancel = True
                        End If
                    Else
                        MessageBox.Show("El código de servicio no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                End If
            Catch ex As Exception
                e.Cancel = True
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdServicios_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.ButtonClick
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        Try
            'Si no se ha introducido el código de artículo, no permitir función de los botones, excepto del de búsqueda de artículos
            If e.Column.Name <> "Código" AndAlso grdServicios.Columns("Código").Text = String.Empty Then Return
            'Si se presionó el botón de búsqueda de artículos
            If e.Column.Name = "Código" And Orden.Status = WorkflowSteps.Save Then
                If grdServicios.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewPending Then
                    bsServicios.RemoveCurrent()
                    grdServicios.UpdateData()
                End If
                'Validar que el almacén esté seleccionado un almacén
                If Not ValidHeader() Then Return
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmServicios As New ServiciosProveedorForm
                If frmServicios.ShowDialog(Me, IdZonaCompra, txtProveedor.Key, True) = System.Windows.Forms.DialogResult.OK Then
                    Dim SelectedItems As ProveedoresDS.ServiciosDataTable = frmServicios.SelectedItems
                    For Each drServicio As ProveedoresDS.ServiciosRow In SelectedItems
                        If FindServicio(Orden.Servicios, drServicio.IdServicio) Is Nothing Then
                            Dim Servicio As CompraServicioInfo = ProveedorFac.CargarServicioFromCache(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, drServicio.IdServicio)
                            Dim drPartida As DetalleOrdenDS.ServiciosRow
                            drPartida = Orden.Servicios.NewServiciosRow
                            'Asinar datos del artículo
                            With drPartida
                                'Cargar información de costos
                                Dim Costo As CostoInfo = ProveedorFac.GetCostoServicio(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, Servicio.IdServicio)
                                If ValidarCosto(Costo) Then
                                    Orden.AsignarCosto(drPartida, Costo)
                                    .IdServicio = Servicio.IdServicio
                                    .Codigo = Servicio.Codigo
                                    .Descripcion = Servicio.Nombre
                                    .Cantidad = 1
                                    bsCategoriasServ.Filter = "IdServicio=" & Servicio.IdServicio
                                Else
                                    Return
                                End If
                            End With
                            If drPartida.RowState = DataRowState.Detached Then Orden.Servicios.AddServiciosRow(drPartida)
                        End If
                    Next
                    grdServicios.Refresh()
                    MostrarTotales()
                End If
            ElseIf e.Column.Name = "X" And Orden.Status = WorkflowSteps.Save Then
                bsServicios.RemoveCurrent()
                MostrarTotales()
            ElseIf e.Column.Name = "N" Then
                'Mostrar el formulario de notas
                Dim frmNotas As New NotesForm
                If frmNotas.ShowDialog(Me, grdServicios.Columns("N").Text, False) = System.Windows.Forms.DialogResult.OK Then
                    grdServicios.Columns("N").Text = frmNotas.Notes
                    grdServicios.UpdateData()
                End If
            ElseIf e.Column.Name = "Precio Unitario" And Orden.Status = WorkflowSteps.Save Then
                Dim drServicio As DetalleOrdenDS.ServiciosRow = CType(CType(bsServicios.Current, DataRowView).Row, DetalleOrdenDS.ServiciosRow)
                Dim frmServicio As New EditServicioProveedorForm
                If frmServicio.ShowDialog(Me, IdZonaCompra, txtProveedor.Key, drServicio.IdServicio) = System.Windows.Forms.DialogResult.OK Then
                    Dim Servicio As CompraServicioInfo = ProveedorFac.CargarServicioFromCache(App.Session.SessionID, IdZonaCompra, txtProveedor.Key, drServicio.IdServicio)
                    drServicio.CostoUnitario = Servicio.Costo
                End If
                grdServicios.UpdateData()
                MostrarTotales()
            ElseIf e.Column.Name = "Cat. Pres." And bsServicios.Current IsNot Nothing Then
                Dim drServicio As DataRowView = CType(bsServicios.Current, DataRowView)
                bsCategoriasServ.Filter = "IdServicio=" & CInt(drServicio("IdServicio")).ToString
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        Try
            Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
            'Si las categorias presupuestales están habilitadas, marcar registros sin categoria
            If e.Column.Name = "Cat. Pres." And Not grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Locked And Val(grdServicios.Columns("Cat. Pres.").CellValue(e.Row)) <= 0 Then
                e.CellStyle.BackColor = Drawing.Color.OrangeRed
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdServicios_FetchCellTips(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs) Handles grdServicios.FetchCellTips
        If e.Column.Name = "N" Then
            e.CellTip = grdServicios.Columns("N").CellText(e.Row)
        End If
    End Sub

#End Region

#Region "Implementacion Recepciones"

    Private Sub cmdNuevaRecepcion_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdNuevaRecepcion.Click
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        If Orden.Identity <> String.Empty Then
            Try
                Dim frmNuevaRecepcion As New NuevaRecepcionForm
                If frmNuevaRecepcion.ShowDialog(Me, Orden.Identity) = System.Windows.Forms.DialogResult.OK Then
                    LoadItem(Orden.Identity)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

#End Region

    Private Sub ReimpresiónDeCódigoDeBarrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReimpresiónDeCódigoDeBarrasToolStripMenuItem.Click
        ' Dim Etiquetas As List(Of Azteca.Business.Inventario.Etiqueta) = New List(Of Azteca.Business.Inventario.Etiqueta)
        Dim Orden As OrdenInfo = CType(PackageInfo, OrdenInfo)
        Dim sCodigo = grdArticulos.Columns("Código").Text
        Dim folioOrden As String = String.Empty
        Dim cantEtiquetas As Integer = CInt(InputBox("Ingrese el número de Etiquetas que desea Imprimir?", "Reimpresión de Etiquetas", "1", 100, 100))
        Proveedor = ProveedorFac.GetDetail(App.Session.SessionID, Orden.IdProveedor)

        If cantEtiquetas > 0 Then
            For Each row As DetalleOrdenDS.ArticulosRow In Orden.Articulos.Rows
                If row.Codigo = sCodigo And CInt(row.Saldo) > 0 And CInt(row.Cantidad) <> CInt(row.Saldo) Then
                    If cantEtiquetas > CInt(row.Cantidad) Then
                        MessageBox.Show("No es posible imprimir una cantidad mayor de Etiquetas que la cantidad existente en la Orden de Compra!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim Etiquetas As List(Of Azteca.Business.Inventario.Etiqueta) = New List(Of Azteca.Business.Inventario.Etiqueta)
                        Dim etiqDetalle As New Azteca.Business.Inventario.Etiqueta
                        '                        etiqDetalle.OrdenCompra = Orden.Identity
                        folioOrden = Orden.FolioExt.Trim()
                        etiqDetalle.OrdenCompra = folioOrden.Substring(folioOrden.Length - 5, 5)
                        etiqDetalle.CodigoArticulo = row.Codigo
                        etiqDetalle.DescArticulo = row.Descripcion
                        etiqDetalle.CodigoProveedor = Proveedor.UserCode
                        etiqDetalle.NombreProveedor = Proveedor.Nombre
                        '                        etiqDetalle.Cantidad = row.CantidadAux / cantEtiquetas
                        etiqDetalle.Cantidad = 1
                        etiqDetalle.Etiqueta = cantEtiquetas
                        etiqDetalle.UnidMedida = row.UnidadMedida
                        etiqDetalle.LineaArticulo = "1[Genérico]"
                        etiqDetalle.LoteArticulo = Math.Round(row.Saldo, 2).ToString()
                        etiqDetalle.Reimpresion = True
                        Etiquetas.Add(etiqDetalle)
                        For i = 1 To etiqDetalle.Etiqueta
                            Dim ImpEtiqueta = New Azteca.Windows.Inventario.ImprimeEtiqueta()
                            If ImpEtiqueta.ShowDialog(Owner, Orden.Identity, Etiquetas, True, i) = System.Windows.Forms.DialogResult.OK Then
                                ImpEtiqueta.Dispose()
                                ImpEtiqueta.Close()
                            End If
                        Next
                        DialogResult = System.Windows.Forms.DialogResult.OK
                    End If

                    ''Dim ImpEtiqueta = New Azteca.Windows.Inventario.ImprimeEtiqueta()
                    ''ImpEtiqueta.ShowDialog(Owner, Orden.Identity, Etiquetas, True, 1)
                    ''DialogResult = System.Windows.Forms.DialogResult.OK
                    'Dim ImpEtiqueta = New Azteca.Windows.Inventario.ImprimeEtiqueta()
                    'If ImpEtiqueta.ShowDialog(Owner, Orden.Identity, Etiquetas, True) = System.Windows.Forms.DialogResult.OK Then
                    ' ImpEtiqueta.Dispose()
                    ' ImpEtiqueta.Close()
                    'End If
                ElseIf row.Codigo = sCodigo And CInt(row.Saldo) = 0 Then
                    MessageBox.Show("No se pueden imprimir Etiquetas de un articulo con Saldo cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf row.Codigo = sCodigo And CInt(row.Cantidad) = CInt(row.Saldo) Then
                    MessageBox.Show("No se han impreso Etiquetas en el módulo de Recepción de Ordenes de Compra del artículo seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next

        End If

    End Sub
End Class