Public Class RequisicionesForm
    Private TipoAdmonPresupuesto As TipoAdmonPresupuestoEnum = TipoAdmonPresupuestoEnum.No

#Region "Implemantacion de la forma"

    Private Sub RequisicionesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As RequisicionInfo = CType(PackageInfo, RequisicionInfo)
        With info
            If .IdArticuloStock > 0 Then optArticulo.Checked = True : selArticuloStock.LoadInfo(.IdArticuloStock)
            If .IdServicio > 0 Then optServicio.Checked = True : selServicio.LoadInfo(.IdServicio)
            cboTipoRequisicion.SelectedValue = .IdRequisicionTipo
            cboDepartamento.SelectedValue = .IdDepartamento
            cboPresupuesto.SelectedValue = .IdPresupuesto
            cboCentrosRecep.SelectedValue = .IdCentroRecepcion
            txtObservaciones.Text = .Observaciones
            txtCantidad.Value = .Cantidad
            cboUnidadMedida.SelectedValue = .IdUnidadMedida
            cboCategoriaPresup.SelectedValue = .IdCategoriaPresupuestal
        End With
    End Sub

    Private Sub RequisicionesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As RequisicionInfo = CType(PackageInfo, RequisicionInfo)
        With info
            .IdArticuloStock = CInt(IIf(optArticulo.Checked, selArticuloStock.Key, 0))
            .IdServicio = CInt(IIf(optServicio.Checked, selServicio.Key, 0))
            .IdRequisicionTipo = CInt(cboTipoRequisicion.SelectedValue)
            .idDepartamento = CInt(cboDepartamento.SelectedValue)
            .IdPresupuesto = CInt(cboPresupuesto.SelectedValue)
            .IdCentroRecepcion = CInt(cboCentrosRecep.SelectedValue)
            .Observaciones = txtObservaciones.Text
            .Cantidad = txtCantidad.Value
            .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
            .IdCategoriaPresupuestal = CInt(IIf(cboCategoriaPresup.Enabled, cboCategoriaPresup.SelectedValue, 0))
        End With
    End Sub

    Private Sub RequisicionesForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboDepartamento.LoadList()
        cboTipoRequisicion.LoadList(App.DefaultCompany.Identity)
        cboUnidadMedida.LoadList()
    End Sub

    Protected Overrides Function IsValid() As Boolean

        If optArticulo.Checked And selArticuloStock.Key = 0 Then
            MessageBox.Show("Debe seleccionar un articulo", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If optServicio.Checked And selServicio.Key = 0 Then
            MessageBox.Show("Debe seleccionar un servicio", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If cboCategoriaPresup.Enabled And CInt(cboCategoriaPresup.SelectedValue) = 0 Then
            MessageBox.Show("Debe seleccionar una categoria presupuestal", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return MyBase.IsValid()
    End Function
#End Region

#Region "Manejo de enventos"

    Private Sub opto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optArticulo.CheckedChanged, optServicio.CheckedChanged
        selArticuloStock.Enabled = optArticulo.Checked
        selServicio.Enabled = optServicio.Checked
    End Sub

    Private Sub selElemento_InfoLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selArticuloStock.InfoLoaded, selServicio.InfoLoaded
        cboCategoriaPresup.DisplayMember = "CategoriaPresupuestal" : cboCategoriaPresup.ValueMember = "IdCategoriaPresupuestal"
        If optArticulo.Checked Then
            Dim ArtInf As Azteca.Business.Inventario.ArticuloStockInfo = CType(selArticuloStock.PackageInfo, Azteca.Business.Inventario.ArticuloStockInfo)
            cboUnidadMedida.Visible = True
            cboCategoriaPresup.LoadListByArticulo(selArticuloStock.Key)
            cboUnidadMedida.FilterExpression = "IdUnidadMedidaTipo=" & ArtInf.IdTipoUnidadMedida
            cboUnidadMedida.SelectedValue = ArtInf.IdUnidadMedida
        Else
            cboUnidadMedida.Visible = False
            cboCategoriaPresup.LoadListByServicio(selServicio.Key)
        End If
    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            'Verificamos el tipo de presupuesto q maneja este departamento para habilitar los controles correspondientes
            Dim dv As New DataView(cboDepartamento.ItemsTable, "IdDepartamento=" & CInt(cboDepartamento.SelectedValue), "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then
                TipoAdmonPresupuesto = DepartamentoInfo.GetTipoAdmonPresupuesto(CStr(dv(0)("AdmonPresupuesto")))

                'Cargamos los centros de recepcion disponibles para este departamento
                Dim DeptoFac As New DepartamentoFacade
                cboCentrosRecep.DisplayMember = "CentroRecepcion"
                cboCentrosRecep.ValueMember = "IdCentroRecepcion"
                cboCentrosRecep.DataSource = DeptoFac.CentrosRecepcionList(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))

                'Si habilitan los controles en base al tipo de presupuesto q maneja el departamento seleccionado
                cboCategoriaPresup.Enabled = (TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado)
                If TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Then
                    cboPresupuesto.Enabled = False
                Else
                    ''Llenar los presupuestos activos de este departamento
                    cboPresupuesto.Enabled = True
                    cboPresupuesto.DisplayMember = "Nombre"
                    cboPresupuesto.ValueMember = "IdPresupuesto"
                    cboPresupuesto.DataSource = DeptoFac.PresupuestosActivos(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cboUnidadMedida_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboUnidadMedida.SelectedIndexChanged
        If cboUnidadMedida.SelectedIndex >= 0 Then
            txtCantidad.IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
        End If
    End Sub

#End Region



    Private Sub RequisicionesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class