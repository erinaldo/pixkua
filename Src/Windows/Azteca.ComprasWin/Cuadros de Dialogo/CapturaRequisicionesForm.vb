Imports Azteca.Business.Inventario

Public Class CapturaRequisicionesForm
    Private ArticuloFac As ArticuloStockFacade
    Private ServicioFac As ServicioFacade
    Private Partidas As RequisicionesDS
    Private UnidadMedidaFac As UnidadMedidaFacade
    Private UnidadesMedida As DataTable

    Private TipoAdmonPresupuesto As TipoAdmonPresupuestoEnum = TipoAdmonPresupuestoEnum.No

#Region "Metodos Privados"

    Private Function ArticulosValidos() As Boolean
        ArticulosValidos = False
        If grdArticulos.Splits(0).DisplayColumns("Cat. Pres.").Locked Then
            Return True
        Else
            'Validar información de los artículos
            For Each drArticulo As RequisicionesDS.ArticulosRow In Partidas.Articulos
                If drArticulo.IdCategoriaPresupuestal = 0 Then
                    MessageBox.Show("La partida con el artículo " & drArticulo.Codigo & " no tiene asignada la categoria presupuestal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            Next
            Return True
        End If
    End Function

    Private Function ServiciosValidos() As Boolean
        ServiciosValidos = False
        If grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Locked Then
            Return True
        Else
            'Validar información de los artículos
            For Each drServicio As RequisicionesDS.ServiciosRow In Partidas.Servicios
                If drServicio.IdCategoriaPresupuestal = 0 Then
                    MessageBox.Show("La partida con el servicio " & drServicio.Codigo & " no tiene asignada la categoria presupuestal", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
            Next
            Return True
        End If
    End Function

    Private Function IsValid() As Boolean
        IsValid = False
        If cboTipoRequisicion.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un tipo de requisición", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboTipoRequisicion.Focus()
        ElseIf cboDepartamento.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un departamento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDepartamento.Focus()
        ElseIf cboPresupuesto.Enabled AndAlso cboPresupuesto.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un presupuesto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboPresupuesto.Focus()
        ElseIf Not ArticulosValidos() Then
            grdArticulos.Focus()
        ElseIf Not ServiciosValidos() Then
            grdServicios.Focus()
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

    Private Function ConvertirCantidad(ByVal cantidad As Decimal, ByVal idUnidadMedida As Integer, ByVal tipoConversion As Integer) As Decimal
        Dim UnidadMedidaInf As Azteca.Business.Inventario.UnidadMedidaInfo = GetUnidadMedida(idUnidadMedida)
        'Convertir desde unidad base a unidades multiplo
        If tipoConversion = 1 Then
            Return cantidad / UnidadMedidaInf.Factor
        Else 'Convertir unidad múltiplo a unidad base
            Return cantidad * UnidadMedidaInf.Factor
        End If
    End Function

    Private Sub ClearCategoriaPresupuestal()
        For Each drServicio As RequisicionesDS.ServiciosRow In Partidas.Servicios
            drServicio.IdCategoriaPresupuestal = 0
            drServicio.Categoria = String.Empty
        Next
        '
        For Each drArticulo As RequisicionesDS.ArticulosRow In Partidas.Articulos
            drArticulo.IdCategoriaPresupuestal = 0
            drArticulo.Categoria = String.Empty
        Next
    End Sub

#End Region

#Region "Implementacion"

    Private Sub CapturaRequisicionesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ArticuloFac = New ArticuloStockFacade
            ServicioFac = New ServicioFacade
            UnidadMedidaFac = New UnidadMedidaFacade
            Partidas = New RequisicionesDS
            bsArticulos.DataSource = Partidas.Articulos
            grdArticulos.Rebind(True)
            bsServicios.DataSource = Partidas.Servicios
            grdServicios.Rebind(True)
            '
            cboDepartamento.LoadList()
            cboTipoRequisicion.LoadList(App.DefaultCompany.Identity)

            'Cargar unidades de medida
            UnidadesMedida = UnidadMedidaFac.LoadList(App.Session.SessionID)
            bsUnidades.DataSource = UnidadesMedida
            cboUnidades.DataSource = bsUnidades
            cboUnidades.Rebind(True)

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

    Private Sub cmdGuardar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdGuardar.Click
        grdArticulos.UpdateData()
        grdServicios.UpdateData()
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim RequisicionFac As New RequisicionFacade()
                RequisicionFac.Update(App.Session.SessionID, App.DefaultSite.Identity, CInt(cboTipoRequisicion.SelectedValue), CInt(cboDepartamento.SelectedValue), CInt(cboPresupuesto.SelectedValue), CInt(cboCentrosRecep.SelectedValue), Partidas)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        Dim Resp As DialogResult = System.Windows.Forms.DialogResult.Yes
        'Si ya se capturaron articulos o servicios, preguntar antes de salir
        If bsArticulos.Count > 0 OrElse bsServicios.Count > 0 Then
            Resp = MessageBox.Show("¿Está seguro que desea salir sin guardar las requisiciones capturadas?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        '
        If Resp = System.Windows.Forms.DialogResult.Yes Then
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            'Verificamos el tipo de presupuesto q maneja este departamento para habilitar los controles correspondientes
            Dim dv As New DataView(cboDepartamento.ItemsTable, "IdDepartamento=" & CInt(cboDepartamento.SelectedValue), "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then
                Dim drvDepartamento As DataRowView = dv(0)
                TipoAdmonPresupuesto = DepartamentoInfo.GetTipoAdmonPresupuesto(CStr(drvDepartamento("AdmonPresupuesto")))
                'Cargamos los centros de recepcion disponibles para este departamento
                Dim DeptoFac As New DepartamentoFacade
                cboCentrosRecep.DisplayMember = "CentroRecepcion"
                cboCentrosRecep.ValueMember = "IdCentroRecepcion"
                cboCentrosRecep.DataSource = DeptoFac.CentrosRecepcionList(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
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
                    ClearCategoriaPresupuestal()
                End If
                If TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Then
                    cboPresupuesto.Enabled = False
                Else
                    ''Llenar los presupuestos activos de este departamento
                    Dim dtPrespuestos As DataTable = DeptoFac.PresupuestosActivos(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
                    cboPresupuesto.Enabled = True
                    cboPresupuesto.DisplayMember = "Nombre"
                    cboPresupuesto.ValueMember = "IdPresupuesto"
                    cboPresupuesto.DataSource = dtPrespuestos
                End If
            End If
            grdArticulos.Refresh()
            grdServicios.Refresh()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub


#End Region

#Region "Implementacion Articulos"

    Private Sub grdArticulos_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.AfterColUpdate
        Try
            If e.Column.Name = "U.M." Then
                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                grdArticulos.Columns("Descripción U.M.").Text = cboUnidades.Columns("Nombre").Text
                Dim IdUnidadMedida As Integer = CInt(cboUnidades.Columns("ID").Value)
                grdArticulos.Columns("Unidades").Text = "0"
            ElseIf e.Column.Name = "Código" Then
                grdArticulos.UpdateData()
            ElseIf e.Column.Name = "Cat. Pres." Then
                grdArticulos.Columns("Descripción Categoria").Text = cboCategoriasArt.Columns("Nombre").Text
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.AfterDelete
        Try

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdArticulos.AfterInsert
        Try

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
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdArticulos.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdArticulos.Columns("Código").Text.Trim
                    If ArticuloFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ArticuloInf As Azteca.Business.Inventario.ArticuloStockInfo = ArticuloFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                        If Partidas.Articulos.FindByIdArticuloStock(ArticuloInf.Identity) Is Nothing Then
                            With ArticuloInf
                                Dim drvPartida As DataRowView = CType(bsArticulos.Current, DataRowView)
                                grdArticulos.Columns("Descripción").Text = .Nombre
                                grdArticulos.Columns("UnidadMedida").Value = .UnidadMedida
                                drvPartida("Cantidad") = 1
                                drvPartida("IdArticuloStock") = .Identity
                                drvPartida("IdUnidadMedida") = .IdUnidadMedida
                                drvPartida("IdUnidadMedidaTipo") = .IdTipoUnidadMedida
                                bsUnidades.Filter = "IdUnidadMedidaTipo=" & .IdTipoUnidadMedida.ToString
                                bsCategoriasArt.Filter = "IdArticuloStock=" & .Identity.ToString
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
            If e.Column.Name = "Código" Then
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New MsgSearch
                If frmSearch.ShowDialog(ArticuloFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdArticulo As Integer = CInt(frmSearch.SelectedItem)
                    If Partidas.Articulos.FindByIdArticuloStock(IdArticulo) Is Nothing Then
                        Dim Articulo As Azteca.Business.Inventario.ArticuloStockInfo = ArticuloFac.GetDetail(App.Session.SessionID, IdArticulo)
                        Dim drPartida As RequisicionesDS.ArticulosRow
                        If grdArticulos.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                            drPartida = Partidas.Articulos.NewArticulosRow
                        Else
                            drPartida = CType(CType(bsArticulos.Current, DataRowView).Row, RequisicionesDS.ArticulosRow)
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
                        End With
                        If drPartida.RowState = DataRowState.Detached Then Partidas.Articulos.AddArticulosRow(drPartida)
                        bsCategoriasArt.Filter = "IdArticuloStock=" & Articulo.Identity
                        bsUnidades.Filter = "IdUnidadMedidaTipo=" & Articulo.IdTipoUnidadMedida
                        grdArticulos.Refresh()
                    Else
                        MessageBox.Show("El artículo ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
                'Filtrar unidades de medida del mismo tipo que el artículo
            ElseIf e.Column.Name = "U.M." And bsArticulos.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsArticulos.Current, DataRowView)
                bsUnidades.Filter = "IdUnidadMedidaTipo=" & CInt(dr("IdUnidadMedidaTipo")).ToString
            ElseIf e.Column.Name = "Cat. Pres." And bsArticulos.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsArticulos.Current, DataRowView)
                bsCategoriasArt.Filter = "IdArticuloStock=" & CInt(dr("IdArticuloStock")).ToString
            ElseIf e.Column.Name = "N" Then
                Dim frmNotas As New NotesForm
                If frmNotas.ShowDialog(Me, grdArticulos.Columns("N").Text, False) = System.Windows.Forms.DialogResult.OK Then
                    grdArticulos.Columns("N").Text = frmNotas.Notes
                End If
            ElseIf e.Column.Name = "X" Then
                bsArticulos.RemoveCurrent()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            Dim IdUnidadMedida As Integer = CInt(Val(grdArticulos.Columns("U.M.").CellValue(e.Row)))
            Dim IdUnidadMedidaTipo As Integer = CInt(Val(grdArticulos.Columns("IdUnidadMedidaTipo").CellValue(e.Row)))
            If IdUnidadMedida = 0 Then Return

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

    Private Sub grdArticulos_FetchCellTips(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs) Handles grdArticulos.FetchCellTips
        If e.Column.Name = "N" Then
            e.CellTip = grdArticulos.Columns("N").CellText(e.Row)
        End If
    End Sub

#End Region

#Region "Implementacion Servicios"

    Private Sub grdServicios_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.AfterColUpdate
        Try
            If e.Column.Name = "Cat. Pres." Then
                grdServicios.Columns("Descripción Categoria").Text = cboCategoriasServ.Columns("Nombre").Text
            End If
            grdArticulos.UpdateData()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.AfterDelete
        Try

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdServicios.AfterInsert
        Try

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdServicios.BeforeColEdit
        Try
            'Si se está intenando editar una columna sin haber seleccionado el código de servicio no permitirlo
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

    Private Sub grdServicios_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdServicios.BeforeColUpdate
        If bsServicios.Current IsNot Nothing Then
            Try
                If e.Column.Name = "Código" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdServicios.Columns("Código").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdServicios.Columns("Código").Text.Trim
                    If ServicioFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim ServicioInf As ServicioInfo = ServicioFac.GetDetailFromCache(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                        If Partidas.Servicios.FindByIdServicio(ServicioInf.Identity) Is Nothing Then
                            With ServicioInf
                                Dim drvPartida As DataRowView = CType(bsServicios.Current, DataRowView)
                                grdServicios.Columns("Descripción").Text = .Nombre
                                drvPartida("Cantidad") = 1
                                drvPartida("IdServicio") = .Identity
                                bsCategoriasServ.Filter = "IdServicio=" & .Identity.ToString
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
        Try
            If e.Column.Name = "Código" Then
                'Mostrar pantalla de búsqueda para que el usuario seleccione un artículo
                Dim frmSearch As New MsgSearch
                If frmSearch.ShowDialog(ServicioFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdServicio As Integer = CInt(frmSearch.SelectedItem)
                    If Partidas.Servicios.FindByIdServicio(IdServicio) Is Nothing Then
                        Dim Servicio As ServicioInfo = ServicioFac.GetDetail(App.Session.SessionID, IdServicio, False)
                        Dim drPartida As RequisicionesDS.ServiciosRow
                        If grdServicios.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                            drPartida = Partidas.Servicios.NewServiciosRow
                        Else
                            drPartida = CType(CType(bsServicios.Current, DataRowView).Row, RequisicionesDS.ServiciosRow)
                        End If
                        'Asignar datos del servicio
                        With drPartida
                            .IdServicio = Servicio.Identity
                            .Codigo = Servicio.UserCode
                            .Descripcion = Servicio.Nombre
                            .Cantidad = 1
                            bsCategoriasServ.Filter = "IdServicio=" & Servicio.Identity
                        End With
                        If drPartida.RowState = DataRowState.Detached Then Partidas.Servicios.AddServiciosRow(drPartida)
                        grdServicios.Refresh()
                    Else
                        MessageBox.Show("El servicio ya existe en otra partida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            ElseIf e.Column.Name = "Cat. Pres." And bsServicios.Current IsNot Nothing Then
                Dim dr As DataRowView = CType(bsServicios.Current, DataRowView)
                bsCategoriasServ.Filter = "IdServicio=" & CInt(dr("IdServicio")).ToString
            ElseIf e.Column.Name = "N" Then
                Dim frmNotas As New NotesForm
                If frmNotas.ShowDialog(Me, grdServicios.Columns("N").Text, False) = System.Windows.Forms.DialogResult.OK Then
                    grdServicios.Columns("N").Text = frmNotas.Notes
                End If
            ElseIf e.Column.Name = "X" Then
                bsServicios.RemoveCurrent()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        'Si las categorias presupuestales están habilitadas, marcar registros sin categoria
        If e.Column.Name = "Cat. Pres." And Not grdServicios.Splits(0).DisplayColumns("Cat. Pres.").Locked And Val(grdServicios.Columns("Cat. Pres.").CellValue(e.Row)) <= 0 Then
            e.CellStyle.BackColor = Drawing.Color.OrangeRed
        End If
    End Sub

    Private Sub grdServicios_FetchCellTips(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs) Handles grdServicios.FetchCellTips
        If e.Column.Name = "N" Then
            e.CellTip = grdServicios.Columns("N").CellText(e.Row)
        End If
    End Sub


#End Region

End Class