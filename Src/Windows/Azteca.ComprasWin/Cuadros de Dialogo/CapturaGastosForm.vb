Public Class CapturaGastosForm
    Private TipoAdmonPresupuesto As TipoAdmonPresupuestoEnum = TipoAdmonPresupuestoEnum.No
    Private GastosDatatable As GastosDS.DetalleDataTable
    Private ImpuestosTable As DataTable
    Private RetencionesTable As DataTable
    Private PartidaImpuestosTable As GastosDS.ImpuestosDataTable
    Private PartidaRetencionesTable As GastosDS.RetencionesDataTable
    Private ProveedorFac As ProveedorFacade

#Region "Manejo de eventos de la forma"

    Private Sub CapturaGastosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ProveedorFac = New ProveedorFacade
        cboDepartamento.LoadList()
        cboMoneda.LoadList()
        Dim ImpuestoFac As New Azteca.Business.Contabilidad.ImpuestoFacade
        ImpuestosTable = ImpuestoFac.LoadList(App.Session.SessionID)
        Dim RetencionesFac As New Azteca.Business.Contabilidad.RetencionFacade
        RetencionesTable = RetencionesFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)

        GastosDatatable = New GastosDS.DetalleDataTable
        PartidaImpuestosTable = New GastosDS.ImpuestosDataTable
        PartidaRetencionesTable = New GastosDS.RetencionesDataTable
        bsImpuestos.DataSource = PartidaImpuestosTable
        grdImpuetos.Rebind(True)

        bsRetenciones.DataSource = PartidaRetencionesTable
        grdRetenciones.Rebind(True)

        bsGastos.DataSource = GastosDatatable
        grdGastos.Rebind(True)
    End Sub

    Private Sub optBeneficiario_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optEmpleado.CheckedChanged, optProveedor.CheckedChanged, optOtro.CheckedChanged
        selEmpleado.Visible = optEmpleado.Checked
        selProveedor.Visible = optProveedor.Checked
        selBeneficiario.Visible = optOtro.Checked
    End Sub

    Private Sub optModalidad_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optComprobacion.CheckedChanged, optReposicion.CheckedChanged

    End Sub

    Private Sub cboDepartamento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDepartamento.SelectedIndexChanged
        'Verificamos el tipo de presupuesto q maneja este departamento para habilitar los controles correspondientes
        If IsNothing(cboDepartamento.DataSource) Then Exit Sub

        Dim dv As New DataView(CType(cboDepartamento.DataSource, DataView).Table, "IdDepartamento=" & CInt(cboDepartamento.SelectedValue), "", DataViewRowState.CurrentRows)
        If dv.Count > 0 Then
            TipoAdmonPresupuesto = DepartamentoInfo.GetTipoAdmonPresupuesto(CStr(dv(0)("AdmonPresupuesto")))

            'Si habilitan los controles en base al tipo de presupuesto q maneja el departamento seleccionado
            'cboCategoriaPresup.Enabled = (TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado)
            If TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Then
                cboPresupuesto.SelectedValue = 0
                cboPresupuesto.Enabled = False
            Else
                Dim DeptoFac As New DepartamentoFacade
                ''Llenar los presupuestos activos de este departamento
                cboPresupuesto.Enabled = True
                cboPresupuesto.DisplayMember = "Nombre" : cboPresupuesto.ValueMember = "IdPresupuesto"
                cboPresupuesto.DataSource = DeptoFac.PresupuestosActivos(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
            End If
        End If

        Dim Fac As New DepartamentoFacade
        bsConceptos.DataSource = Fac.LoadConceptos(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
        cboConcepto.Rebind(True)
        ''lblCategoriaPresupuestal.Text = ""
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        Dim Resp As DialogResult = System.Windows.Forms.DialogResult.Yes
        'Si ya se capturaron articulos o servicios, preguntar antes de salir
        If bsGastos.Count > 0 Then
            Resp = MessageBox.Show("¿Está seguro que desea salir sin guardar los gastos capturados?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        '
        If Resp = System.Windows.Forms.DialogResult.Yes Then
            DialogResult = System.Windows.Forms.DialogResult.Cancel
        End If
    End Sub
    Private Sub cmdGuardar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdGuardar.Click
        grdGastos.UpdateData()
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim GastoFac As New GastoFacade()
                Dim Modalidad As String = CStr(IIf(optReposicion.Checked, "R", "C"))
                Dim TipoBeneficiario As String = "O", IdBeneficiario As Integer = 0
                If optEmpleado.Checked Then
                    TipoBeneficiario = "E" : IdBeneficiario = selEmpleado.Key
                ElseIf optProveedor.Checked Then
                    TipoBeneficiario = "P" : IdBeneficiario = selProveedor.Key
                Else
                    TipoBeneficiario = "O" : IdBeneficiario = selBeneficiario.Key
                End If

                GastoFac.Update(App.Session.SessionID, App.DefaultSite.Identity, Modalidad, TipoBeneficiario, IdBeneficiario, CInt(cboDepartamento.SelectedValue), CInt(cboPresupuesto.SelectedValue), CInt(cboMoneda.SelectedValue), txtObervaciones.Text, GastosDatatable, PartidaImpuestosTable, PartidaRetencionesTable)

                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnCloseImpuesto_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles btnCloseImpuesto.ClickButtonArea, btnCloseRetencion.ClickButtonArea
        EdicionModal(False)
        pnlImpuestos.Visible = False
        pnlRetenciones.Visible = False

        Dim row As DataRowView = CType(bsGastos.Current, DataRowView)
        Dim drPartida As GastosDS.DetalleRow = CType(row.Row, GastosDS.DetalleRow)
        RecalcularImpuestos(drPartida)
        RecalcularRetenciones(drPartida)
        RecalcularTotales(drPartida)
        grdGastos.Focus()
    End Sub

#End Region

#Region "Manejo de grid de gastos"

    Private Sub grdGastos_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdGastos.AfterColUpdate
        If e.Column.Name = "Subtotal" Then
            Dim row As DataRowView = CType(bsGastos.Current, DataRowView)
            Dim drPartida As GastosDS.DetalleRow = CType(row.Row, GastosDS.DetalleRow)
            RecalcularTotales(drPartida)
        End If

        If e.Column.Name = "Concepto" Then
            If IsNothing(cboConcepto.DataSource) Then Exit Sub

            Dim row As DataRowView = CType(bsGastos.Current, DataRowView)
            'Verificamos q si maneja Presupuesto Categorizado, el concepto este asociado a una.
            If TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then
                Dim dv As New DataView(CType(bsConceptos.DataSource, DataTable), "IdGastoConcepto=" & CInt(row("IdGastoConcepto")), "", DataViewRowState.CurrentRows)
                If dv.Count > 0 Then
                    If IsDBNull(dv(0)("CategoriaPresupuestal")) Then
                        MessageBox.Show("El concepto seleccionado no tiene una categoria presupuestal que es requerida para la administracion del presupuesto de este departamento", _
                                        "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        row("CategoriaPresupuestal").Text = "Asigne una categoria presupuestal a este Concepto de Gastos"
                    Else
                        row("IdCategoriaPresupuestal") = CInt(dv(0)("IdCategoriaPresupuestal"))
                        row("CategoriaPresupuestal") = dv(0)("CategoriaPresupuestal").ToString
                    End If
                End If
            Else
                row("CategoriaPresupuestal") = "Se maneja presupuesto Global"
            End If
            'Insertamos una partida en los impuestos y las retenciones para la partida actual
            addPartidaImpuestosRetenciones(CType(row.Row, GastosDS.DetalleRow).Partida)
        End If

    End Sub

    Private Sub grdGastos_BeforeUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdGastos.BeforeUpdate
        'If Not isValid() Then e.Cancel = True
    End Sub

    Private Sub grdGastos_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdGastos.FetchCellStyle
        Dim FacturaElect As Boolean = False
        If Not IsDBNull(grdGastos.Columns("FacturaElectronica").CellValue(e.Row)) Then
            FacturaElect = CBool(Val(grdGastos.Columns("FacturaElectronica").CellValue(e.Row)))
        End If

        If e.Column.Name = "Cod.Proveedor" Then
            If optComprobacion.Checked Then
                e.CellStyle.BackColor = Drawing.Color.LightGray : e.CellStyle.Locked = True
            End If
        End If

        If e.Column.Name = "Serie" Or e.Column.Name = "Factura" Or e.Column.DataColumn.DataField = "AnioAprobacion" Or e.Column.DataColumn.DataField = "NumAprobacion" Then
            If FacturaElect Or optComprobacion.Checked Then
                e.CellStyle.BackColor = Drawing.Color.LightGray : e.CellStyle.Locked = True
            End If
        End If

        If e.Column.Name = "Subtotal" Or e.Column.Name = "Impuestos" Or e.Column.Name = "Retenciones" Then
            If FacturaElect Then
                e.CellStyle.BackColor = Drawing.Color.LightGray : e.CellStyle.Locked = True
            End If
        End If
    End Sub

    Private Sub grdGastos_AfterUpdate(sender As Object, e As System.EventArgs) Handles grdGastos.AfterUpdate
        Try
            RecalcularTotales(Nothing)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdGastos_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdGastos.BeforeColUpdate
        If bsGastos.Current IsNot Nothing Then
            Try
                If e.Column.Name = "Cod.Proveedor" Then
                    'Verificar que se haya capturado un código de artículo
                    If grdGastos.Columns("Cod.Proveedor").Text.Trim = String.Empty Then Return
                    Dim Codigo As String = grdGastos.Columns("Cod.Proveedor").Text.Trim
                    If ProveedorFac.Exists(App.Session.SessionID, Codigo, App.DefaultSite.Identity) Then
                        Dim Proveedor As ProveedorInfo = ProveedorFac.GetDetail(App.Session.SessionID, Codigo, App.DefaultSite.Identity)
                        CargarProveedor(Proveedor)
                    Else
                        MessageBox.Show("El código de artículo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        e.Cancel = True
                    End If
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdGastos_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdGastos.ButtonClick
        If e.Column.Name = "Cod.Proveedor" And optReposicion.Checked Then
            'Mostrar pantalla de búsqueda para que el usuario seleccione un Proveedor
            Dim ProveedorFac As New ProveedorFacade
            Dim frmSearch As New MsgSearch
            If frmSearch.ShowDialog(ProveedorFac) = System.Windows.Forms.DialogResult.OK Then
                Dim IdProveedor As Integer = CInt(frmSearch.SelectedItem)
                Dim Provedor As ProveedorInfo = ProveedorFac.GetDetail(App.Session.SessionID, IdProveedor)
                CargarProveedor(Provedor)
                grdGastos.Refresh()
            End If
        ElseIf e.Column.Name = "Impuestos" Then
            MostrarImpuestosSEL()
        ElseIf e.Column.Name = "Retenciones" Then
            MostrarRetencionesSEL()
        ElseIf e.Column.Name = "X" Then
            bsGastos.RemoveCurrent()
        End If
    End Sub

#End Region

#Region "Metodos Privados"
    Private Sub CargarProveedor(Provedor As ProveedorInfo)
        Dim drPart As DataRowView = CType(bsGastos.Current, DataRowView)
        Dim drPartida As GastosDS.DetalleRow = CType(drPart.Row, GastosDS.DetalleRow)
        'Asinar datos del proveedor
        With drPartida
            .IdProveedor = Provedor.Identity
            .CodProveedor = Provedor.UserCode
            .Proveedor = Provedor.Nombre
            .FacturaElectronica = Provedor.FacturaElectronica
            If Provedor.FacturaElectronica Then MostrarFacturas(Provedor.Identity, drPartida)
        End With
    End Sub

    Private Sub addPartidaImpuestosRetenciones(Partida As Integer)
        'Insertamos una partida en los impuestos y las retenciones para la partida actual en caso de q no exista
        If New DataView(PartidaImpuestosTable, "Partida=" & Partida, "", DataViewRowState.CurrentRows).Count = 0 Then
            For Each dr As DataRow In ImpuestosTable.Rows
                PartidaImpuestosTable.AddImpuestosRow(Partida, CInt(dr("IdImpuesto")), CStr("Abrev"), CDec(dr("Porcentaje")), 0, CInt(dr("TipoImpuesto")))
            Next
        End If

        If New DataView(PartidaRetencionesTable, "Partida=" & Partida, "", DataViewRowState.CurrentRows).Count = 0 Then
            For Each dr As DataRow In RetencionesTable.Rows
                PartidaRetencionesTable.AddRetencionesRow(Partida, CInt(dr("IdRetencion")), CStr("Abrev"), CDec(dr("Porcentaje")), 0)
            Next
        End If
    End Sub

    Private Sub MostrarFacturas(IdProveedor As Integer, drPartida As GastosDS.DetalleRow)

        Dim frm As New ProveedoresCFDsForm
        If frm.ShowDialog(Me, IdProveedor) = System.Windows.Forms.DialogResult.OK Then
            drPartida("Serie") = frm.ComprobanteFiscal.Serie : drPartida("Factura") = CStr(frm.ComprobanteFiscal.Folio)
            drPartida("UUID") = frm.ComprobanteFiscal.UUID : drPartida("AnioAprobacion") = frm.ComprobanteFiscal.AnioAprobacion : drPartida("NumAprobacion") = frm.ComprobanteFiscal.NumeroAprobacion
            drPartida("Subtotal") = Format(frm.ComprobanteFiscal.SubTotal - frm.ComprobanteFiscal.Descuento, "0.00")

            'Linkeamos los Impuestos
            For Each Traslado As TrasladoInfo In frm.ComprobanteFiscal.Impuestos.Traslados
                Dim dv As New DataView(PartidaImpuestosTable, "Partida=" & drPartida.Partida & " AND TipoImpuesto=" & Traslado.Impuesto & " AND Porcentaje=" & Traslado.Tasa, "", DataViewRowState.CurrentRows)
                dv(0)("Monto") = Traslado.Importe
            Next
            'Linkeamos las retenciones
            For Each Retencion As RetencionInfo In frm.ComprobanteFiscal.Impuestos.Retenciones
                Dim dv As New DataView(PartidaRetencionesTable, "Partida=" & drPartida.Partida & " AND TipoRetencion=" & Retencion.Impuesto, "", DataViewRowState.CurrentRows)
                dv(0)("Monto") = Retencion.Importe
            Next
            grdImpuetos.UpdateData()
            grdRetenciones.UpdateData()
            RecalcularImpuestos(drPartida)
            RecalcularRetenciones(drPartida)
            RecalcularTotales(drPartida)
        End If

    End Sub


    Private Sub resetImpuestos()
        For Each dr As DataRow In CType(bsImpuestos.DataSource, DataTable).Rows
            dr("Monto") = 0
        Next
    End Sub

    Private Sub resetRetenciones()
        For Each dr As DataRow In CType(bsRetenciones.DataSource, DataTable).Rows
            dr("Monto") = 0
        Next
    End Sub

    Private Sub RecalcularImpuestos(drPartida As GastosDS.DetalleRow)
        pnlImpuestos.Visible = False
        grdImpuetos.Update()
        grdImpuetos.UpdateData()
        Dim Total As Object = PartidaImpuestosTable.Compute("SUM(Monto)", "Partida=" & drPartida.Partida)
        If Not IsNothing(Total) AndAlso Not IsDBNull(Total) Then drPartida("Impuestos") = CDec(Total).ToString("0.00")
    End Sub

    Private Sub RecalcularRetenciones(drPartida As GastosDS.DetalleRow)
        pnlRetenciones.Visible = False
        grdRetenciones.Update()
        grdRetenciones.UpdateData()
        Dim Total As Object = PartidaRetencionesTable.Compute("SUM(Monto)", "Partida=" & drPartida.Partida)
        If Not IsNothing(Total) AndAlso Not IsDBNull(Total) Then drPartida("Retenciones") = CDec(Total).ToString("0.00")
    End Sub

    Private Sub RecalcularTotales(drPartida As GastosDS.DetalleRow)
        Dim TotalImpuesto As Decimal, TotalRetenciones As Decimal
        If drPartida IsNot Nothing Then
            Dim ImpuestosP As Object = PartidaImpuestosTable.Compute("SUM(Monto)", "Partida=" & drPartida.Partida)
            If Not IsNothing(ImpuestosP) AndAlso Not IsDBNull(ImpuestosP) Then TotalImpuesto = CDec(ImpuestosP)

            If Not IsNothing(bsRetenciones.DataSource) Then
                Dim Retenciones As Object = PartidaRetencionesTable.Compute("SUM(Monto)", "Partida=" & drPartida.Partida)
                If Not IsNothing(Retenciones) AndAlso Not IsDBNull(Retenciones) Then TotalRetenciones = CDec(Retenciones)
            End If
            drPartida("Total") = Format(Val(drPartida("Subtotal")) + TotalImpuesto - TotalRetenciones, "0.00")
        End If

        'Totales de pie de grid
        Dim SubTotal As Object = GastosDatatable.Compute("SUM(Subtotal)", "")
        Dim Impuestos As Object = GastosDatatable.Compute("SUM(Impuestos)", "")
        Dim Retencion As Object = GastosDatatable.Compute("SUM(Retenciones)", "")
        Dim Total As Object = GastosDatatable.Compute("SUM(Total)", "")

        If Not IsNothing(SubTotal) AndAlso Not IsDBNull(SubTotal) Then grdGastos.Columns("Subtotal").FooterText = CDec(SubTotal).ToString("0.00")
        If Not IsNothing(Impuestos) AndAlso Not IsDBNull(Impuestos) Then grdGastos.Columns("Impuestos").FooterText = CDec(Impuestos).ToString("0.00")
        If Not IsNothing(Retencion) AndAlso Not IsDBNull(Retencion) Then grdGastos.Columns("Retenciones").FooterText = CDec(Retencion).ToString("0.00")
        If Not IsNothing(Total) AndAlso Not IsDBNull(Total) Then grdGastos.Columns("Total").FooterText = CDec(Total).ToString("0.00")

    End Sub

    Public Function isValid() As Boolean
        isValid = False
        If cboDepartamento.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un Departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboDepartamento.Focus()
        ElseIf optEmpleado.Checked And selEmpleado.Key = 0 Then
            MessageBox.Show("Debe seleccionar un empleado Beneficiario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selEmpleado.Focus()
        ElseIf optProveedor.Checked And selProveedor.Key = 0 Then
            MessageBox.Show("Debe seleccionar un Proveedor Beneficiario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selProveedor.Focus()
        ElseIf optOtro.Checked And selBeneficiario.Key = 0 Then
            MessageBox.Show("Debe seleccionar un Beneficiario Otro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            selBeneficiario.Focus()
        ElseIf cboPresupuesto.Enabled AndAlso cboPresupuesto.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un presupuesto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboPresupuesto.Focus()
        ElseIf cboMoneda.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar una moneda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboMoneda.Focus()
        ElseIf Not PartidasValidas() Then
            grdGastos.Focus()
        Else
            Return True
        End If
    End Function

    Private Function PartidasValidas() As Boolean
        PartidasValidas = False
        'Validar información de los detalles de gasto
        For Each drGasto As GastosDS.DetalleRow In GastosDatatable.Rows
            If drGasto.IdProveedor = 0 And optReposicion.Checked Then
                MessageBox.Show("Una de las partidas no tiene asignada el proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If drGasto.IdCategoriaPresupuestal = 0 And TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then
                MessageBox.Show("Una de las partidas no tiene asociada una Categoria presupuestal al concepto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If drGasto.Serie.Trim.Length = 0 And optReposicion.Checked Then
                MessageBox.Show("Una de las partidas no tiene asignada la serie", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If drGasto.Factura = 0 And optReposicion.Checked Then
                MessageBox.Show("Una de las partidas no tiene asignada la Factura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If drGasto.Total = 0 Then
                MessageBox.Show("La suma de una de las partidas tiene un monto Total igual a cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

        Next
        Return True
    End Function

    Private Sub MostrarImpuestosSEL()
        'Verificamos cual renglon se tiene seleccionado de acuerdo al Id de Partida
        Dim row As DataRowView = CType(bsGastos.Current, DataRowView)
        bsImpuestos.Filter = "Partida=" & CInt(row("Partida"))
        EdicionModal(True)
        grdImpuetos.Splits(0).DisplayColumns("Monto").Locked = CBool(row("FacturaElectronica"))
        With pnlImpuestos
            .Left = Me.grdGastos.Left + Me.grdGastos.RecordSelectorWidth + Me.grdGastos.Splits(0).DisplayColumns(0).Width + Me.grdGastos.Splits(0).DisplayColumns(1).Width + _
                    Me.grdGastos.Splits(0).DisplayColumns(2).Width + Me.grdGastos.Splits(0).DisplayColumns(3).Width + Me.grdGastos.Splits(0).DisplayColumns(4).Width + _
                    Me.grdGastos.Splits(0).DisplayColumns(5).Width + Me.grdGastos.Splits(0).DisplayColumns(6).Width + Me.grdGastos.Splits(0).DisplayColumns(7).Width
            .Top = Me.grdGastos.Top + Me.grdGastos.RowTop(Me.grdGastos.Row) + Me.grdGastos.RowHeight
            .Visible = True
            .Select()
        End With
    End Sub

    Private Sub MostrarRetencionesSEL()
        'Verificamos cual renglon se tiene seleccionado de acuerdo al Id de Partida
        Dim row As DataRowView = CType(bsGastos.Current, DataRowView)
        bsRetenciones.Filter = "Partida=" & CInt(row("Partida"))
        EdicionModal(True)
        grdRetenciones.Splits(0).DisplayColumns("Monto").Locked = CBool(row("FacturaElectronica"))
        With pnlRetenciones
            .Left = Me.grdGastos.Left + Me.grdGastos.RecordSelectorWidth + Me.grdGastos.Splits(0).DisplayColumns(0).Width + Me.grdGastos.Splits(0).DisplayColumns(1).Width + _
                    Me.grdGastos.Splits(0).DisplayColumns(2).Width + Me.grdGastos.Splits(0).DisplayColumns(3).Width + Me.grdGastos.Splits(0).DisplayColumns(4).Width + _
                    Me.grdGastos.Splits(0).DisplayColumns(5).Width + Me.grdGastos.Splits(0).DisplayColumns(6).Width + Me.grdGastos.Splits(0).DisplayColumns(7).Width + _
                    Me.grdGastos.Splits(0).DisplayColumns(8).Width
            .Top = Me.grdGastos.Top + Me.grdGastos.RowTop(Me.grdGastos.Row) + Me.grdGastos.RowHeight
            .Visible = True
            .Select()
        End With
    End Sub

    Private Sub EdicionModal(Modal As Boolean)
        grdGastos.Enabled = Not Modal
        gbxTitulo.Enabled = Not Modal
        gbxModalidad.Enabled = Not Modal
        gbxBeneficiario.Enabled = Not Modal
        tlbMenu.Enabled = Not Modal
    End Sub

#End Region



End Class