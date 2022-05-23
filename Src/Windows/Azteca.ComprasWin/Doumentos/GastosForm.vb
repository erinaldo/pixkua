Public Class GastosForm
    Private TipoAdmonPresupuesto As TipoAdmonPresupuestoEnum = TipoAdmonPresupuestoEnum.No
    Private IdCategoriaPresupuestal As Integer, CargandoGasto As Boolean = False

#Region "Implementacion de la forma"
    Protected Overrides Function IsValid() As Boolean
        If IdCategoriaPresupuestal = 0 And TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then
            MessageBox.Show("El Presupuesto de este departamento debe tener una categoria Presupuestal asociada al Concepto seleccionado" & ControlChars.CrLf & "Consulte con el administrador de presupuestos.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If optEmpleado.Checked And selEmpleado.Key = 0 Then
            MessageBox.Show("No se ha seleccionado un Empleado beneficiario para el gasto", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If optProveedor.Checked And selProveedor.Key = 0 Then
            MessageBox.Show("No se ha seleccionado un Proveedor beneficiario para el gasto", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return MyBase.IsValid()
    End Function

    Private Sub GastosForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        resetImpuestos()
        resetRetenciones()
        upDownAnioAprobacion.Value = 2000
        txtNumAprobacion.Text = "0"
    End Sub

    Private Sub GastosForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        CargandoGasto = True
        Dim info As GastoInfo = CType(Me.PackageInfo, GastoInfo)
        Dim dv As DataView
        With info
            cboDepartamento.SelectedValue = .IdDepartamento
            cboConcepto.SelectedValue = .IdGastoConcepto
            cboPresupuesto.SelectedValue = .IdPresupuesto
            'Categoria Presupuestal
            cboMoneda.SelectedValue = .IdDivisa
            optComprobacion.Checked = .ModalidadPago = "C"
            optReposicion.Checked = .ModalidadPago = "R"
            If .TipoBeneficiario = "E" Then optEmpleado.Checked = True : selEmpleado.LoadInfo(.IdBeneficiario)
            If .TipoBeneficiario = "P" Then optProveedor.Checked = True : selProveedor.LoadInfo(.IdBeneficiario)
            If .TipoBeneficiario = "O" Then optOtro.Checked = True : selBeneficiario.LoadInfo(.IdBeneficiario)
            txtObervaciones.Text = .Notas
            selProveedorExpress.LoadInfo(.IdProveedor)
            chkDigital.Checked = CType(selProveedor.PackageInfo, ProveedorInfo).FacturaElectronica
            upDownAnioAprobacion.Enabled = Not chkDigital.Checked
            txtNumAprobacion.Enabled = Not chkDigital.Checked
            txtSerie.Text = .SerieFactura
            txtFactura.Text = CStr(.FolioFactura)
            upDownAnioAprobacion.Value = .AnioAprobacion
            txtNumAprobacion.Text = CStr(.NumAprobacion)
            txtSubtotal.Text = .SubTotal.ToString("0.00")
            txtTotal.Text = .Total.ToString("0.00")
            'Impuestos
            dv = New DataView(CType(bsImpuestos.DataSource, DataTable), "IdImpuesto=" & .IdImpuesto1, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0)("Monto") = .MontoImp1
            dv = New DataView(CType(bsImpuestos.DataSource, DataTable), "IdImpuesto=" & .IdImpuesto2, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0)("Monto") = .MontoImp2
            dv = New DataView(CType(bsImpuestos.DataSource, DataTable), "IdImpuesto=" & .IdImpuesto3, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0)("Monto") = .MontoImp3
            'Retenciones
            dv = New DataView(CType(bsRetenciones.DataSource, DataTable), "IdRetencion=" & .IdRetencion1, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0)("Monto") = .MontoRetencion1
            dv = New DataView(CType(bsRetenciones.DataSource, DataTable), "IdRetencion=" & .IdRetencion2, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0)("Monto") = .MontoRetencion2
            dv = New DataView(CType(bsRetenciones.DataSource, DataTable), "IdRetencion=" & .IdRetencion3, "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then dv(0)("Monto") = .MontoRetencion3
            RecalcularImpuestos() : RecalcularRetenciones() : RecalcularTotales()
        End With
        CargandoGasto = False
    End Sub

    Private Sub GastosForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As GastoInfo = CType(Me.PackageInfo, GastoInfo)
        With info
            .IdDepartamento = CInt(cboDepartamento.SelectedValue)
            .IdGastoConcepto = CInt(cboConcepto.SelectedValue)
            If cboPresupuesto.Enabled Then .IdPresupuesto = CInt(cboPresupuesto.SelectedValue) 'Si esta habilitado es porque maneja presupuestos
            .IdCategoriaPresupuestal = IdCategoriaPresupuestal
            .IdDivisa = CInt(cboMoneda.SelectedValue)
            .TipoCambio = 0
            .ModalidadPago = CStr(IIf(optComprobacion.Checked, "C", "R"))
            If optEmpleado.Checked Then .IdBeneficiario = selEmpleado.Key : .TipoBeneficiario = "E"
            If optProveedor.Checked Then .IdBeneficiario = selProveedor.Key : .TipoBeneficiario = "P"
            If optOtro.Checked Then .IdBeneficiario = selBeneficiario.Key : .TipoBeneficiario = "O"
            .Notas = txtObervaciones.Text
            .IdProveedor = selProveedorExpress.Key
            .SerieFactura = txtSerie.Text
            .FolioFactura = CInt(txtFactura.Text)
            .AnioAprobacion = CInt(upDownAnioAprobacion.Value)
            .NumAprobacion = CInt(txtNumAprobacion.Text)
            .SubTotal = CDec(txtSubtotal.Text)
            asignarImpuestosRetenciones()
            .Total = CDec(txtTotal.Text)
        End With
    End Sub

#End Region

#Region "Manejador de Eventos"

    Private Sub GastosForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboDepartamento.LoadList()
        cboMoneda.LoadList()
        Dim ImpuestoFac As New Azteca.Business.Contabilidad.ImpuestoFacade
        bsImpuestos.DataSource = ImpuestoFac.LoadList(App.Session.SessionID)
        grdImpuetos.Rebind(True)

        Dim RetencionesFac As New Azteca.Business.Contabilidad.RetencionFacade
        bsRetenciones.DataSource = RetencionesFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
        grdRetenciones.Rebind(True)
    End Sub

    Private Sub optBeneficiario_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optEmpleado.CheckedChanged, optProveedor.CheckedChanged, optOtro.CheckedChanged
        selEmpleado.Visible = optEmpleado.Checked
        selProveedor.Visible = optProveedor.Checked
        selBeneficiario.Visible = optOtro.Checked
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
                cboPresupuesto.Enabled = False
            Else
                Dim DeptoFac As New DepartamentoFacade
                ''Llenar los presupuestos activos de este departamento
                cboPresupuesto.Enabled = True
                cboPresupuesto.DisplayMember = "Nombre" : cboPresupuesto.ValueMember = "IdPresupuesto"
                cboPresupuesto.DataSource = DeptoFac.PresupuestosActivos(App.Session.SessionID, CInt(cboDepartamento.SelectedValue))
            End If
        End If

        cboConcepto.LoadList(CInt(cboDepartamento.SelectedValue))
        lblCategoriaPresupuestal.Text = ""

    End Sub

    Private Sub cboConcepto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboConcepto.SelectedIndexChanged
        If IsNothing(cboConcepto.DataSource) Then Exit Sub

        'Verificamos q si maneja Presupuesto Categorizado, el concepto este asociado a una.
        If TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then
            Dim dv As New DataView(CType(cboConcepto.DataSource, DataView).Table, "IdGastoConcepto=" & CInt(cboConcepto.SelectedValue), "", DataViewRowState.CurrentRows)
            If dv.Count > 0 Then
                If IsDBNull(dv(0)("CategoriaPresupuestal")) Then
                    MessageBox.Show("El concepto seleccionado no tiene una categoria presupuestal que es requerida para la administracion del presupuesto de este departamento", _
                                    "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    lblCategoriaPresupuestal.Text = "Asigne una categoria presupuestal a este Concepto de Gastos"
                Else
                    IdCategoriaPresupuestal = CInt(dv(0)("IdCategoriaPresupuestal"))
                    lblCategoriaPresupuestal.Text = dv(0)("CategoriaPresupuestal").ToString
                End If
            End If
        Else
            lblCategoriaPresupuestal.Text = "Se maneja presupuesto Global"
        End If
    End Sub

    Private Sub txtImpuestos_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles txtImpuestos.LinkClicked
        If Not pnlImpuestos.Visible Then
            pnlImpuestos.Visible = True
            grdImpuetos.Focus()
        End If
    End Sub
    Private Sub txtRetenciones_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles txtRetenciones.LinkClicked
        If Not pnlRetenciones.Visible Then
            pnlRetenciones.Visible = True
            grdRetenciones.Focus()
        End If
    End Sub

    Private Sub pnlImpuestos_Leave(sender As Object, e As System.EventArgs)
        RecalcularImpuestos()
        RecalcularTotales()
    End Sub

    Private Sub pnlRetenciones_Leave(sender As Object, e As System.EventArgs)
        RecalcularRetenciones()
        RecalcularTotales()
    End Sub

    Private Sub txtSubtotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSubtotal.TextChanged
        RecalcularTotales()
    End Sub

    Private Sub ProveedorExpressSel_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles selProveedorExpress.InfoLoaded

        Try
            Dim Index As Integer = 0
            Dim Proveedor As ProveedorInfo = CType(selProveedorExpress.PackageInfo, ProveedorInfo)
            txtFactura.Text = "" : txtSerie.Text = ""
            chkDigital.Checked = False
            If Proveedor.FacturaElectronica Then
                If CargandoGasto Then
                    chkDigital.Checked = True
                    Exit Sub
                End If

                Dim frm As New ProveedoresCFDsForm
                If frm.ShowDialog(Me, Proveedor.Identity) = System.Windows.Forms.DialogResult.OK Then
                    chkDigital.Checked = True
                    txtSerie.Text = frm.ComprobanteFiscal.Serie : txtFactura.Text = CStr(frm.ComprobanteFiscal.Folio) : upDownAnioAprobacion.Value = frm.ComprobanteFiscal.AnioAprobacion : txtNumAprobacion.Text = CStr(frm.ComprobanteFiscal.NumeroAprobacion)
                    txtSubtotal.Text = Format(frm.ComprobanteFiscal.SubTotal - frm.ComprobanteFiscal.Descuento, "0.00")
                    'Linkeamos los Impuestos
                    For Each Traslado As TrasladoInfo In frm.ComprobanteFiscal.Impuestos.Traslados
                        Dim dv As New DataView(CType(bsImpuestos.DataSource, DataTable), "TipoImpuesto=" & Traslado.Impuesto & " AND Porcentaje=" & Traslado.Tasa, "", DataViewRowState.CurrentRows)
                        dv(0)("Monto") = Traslado.Importe
                    Next
                    'Linkeamos las retenciones
                    For Each Retencion As RetencionInfo In frm.ComprobanteFiscal.Impuestos.Retenciones
                        Dim dv As New DataView(CType(bsRetenciones.DataSource, DataTable), "TipoRetencion=" & Retencion.Impuesto, "", DataViewRowState.CurrentRows)
                        dv(0)("Monto") = Retencion.Importe
                    Next

                    grdImpuetos.UpdateData()
                    grdRetenciones.UpdateData()
                    RecalcularImpuestos()
                    RecalcularRetenciones()
                    RecalcularTotales()
                Else
                    upDownAnioAprobacion.Value = 0 : txtNumAprobacion.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub chkDigital_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkDigital.CheckedChanged
        txtSerie.Enabled = Not chkDigital.Checked
        txtFactura.Enabled = Not chkDigital.Checked
    End Sub
#End Region

#Region "Metodos Privados"
    Private Sub resetImpuestos()
        For Each dr As DataRow In CType(bsImpuestos.DataSource, DataTable).Rows
            dr("Monto") = 0
        Next
        txtImpuestos.Text = "0.00"
        RecalcularTotales()
    End Sub

    Private Sub resetRetenciones()
        For Each dr As DataRow In CType(bsRetenciones.DataSource, DataTable).Rows
            dr("Monto") = 0
        Next
        txtRetenciones.Text = "0.00"
        RecalcularTotales()
    End Sub

    Private Sub RecalcularImpuestos()
        pnlImpuestos.Visible = False
        grdImpuetos.Update()
        grdImpuetos.UpdateData()
        Dim Total As Object = CType(bsImpuestos.DataSource, DataTable).Compute("SUM(Monto)", "")
        If Not IsNothing(Total) Then txtImpuestos.Text = CDec(Total).ToString("0.00")
    End Sub

    Private Sub RecalcularRetenciones()
        pnlRetenciones.Visible = False
        grdRetenciones.Update()
        grdRetenciones.UpdateData()
        Dim Total As Object = CType(bsRetenciones.DataSource, DataTable).Compute("SUM(Monto)", "")
        If Not IsNothing(Total) Then txtRetenciones.Text = CDec(Total).ToString("0.00")
    End Sub

    Private Sub RecalcularTotales()
        Dim TotalImpuesto As Decimal, TotalRetenciones As Decimal

        Dim Impuestos As Object = CType(bsImpuestos.DataSource, DataTable).Compute("SUM(Monto)", "")
        If Not IsNothing(Impuestos) Then TotalImpuesto = CDec(Impuestos)

        If Not IsNothing(bsRetenciones.DataSource) Then
            Dim Retenciones As Object = CType(bsRetenciones.DataSource, DataTable).Compute("SUM(Monto)", "")
            If Not IsNothing(Retenciones) Then TotalRetenciones = CDec(Retenciones)

        End If
        txtTotal.Text = Format(Val(txtSubtotal.Text) + TotalImpuesto - TotalRetenciones, "0.00")

    End Sub

    Private Sub asignarImpuestosRetenciones()
        Dim Cont As Integer = 1
        Dim info As GastoInfo = CType(Me.PackageInfo, GastoInfo)
        With info
            'Asignar impuestos
            For Each dr As DataRowView In New DataView(CType(bsImpuestos.DataSource, DataTable), "", "", DataViewRowState.CurrentRows)
                If Cont = 1 And CDec(dr("Monto")) > 0 Then
                    .IdImpuesto1 = CInt(dr("IdImpuesto")) : .PorcImp1 = CDec(dr("Porcentaje")) / 100 : .MontoImp1 = CDec(dr("Monto")) : Cont = Cont + 1
                ElseIf Cont = 2 And CDec(dr("Monto")) > 0 Then
                    .IdImpuesto2 = CInt(dr("IdImpuesto")) : .PorcImp2 = CDec(dr("Porcentaje")) / 100 : .MontoImp2 = CDec(dr("Monto")) : Cont = Cont + 1
                ElseIf Cont = 3 And CDec(dr("Monto")) > 0 Then
                    .IdImpuesto3 = CInt(dr("IdImpuesto")) : .PorcImp3 = CDec(dr("Porcentaje")) / 100 : .MontoImp3 = CDec(dr("Monto")) : Cont = Cont + 1
                End If
            Next
            Cont = 1
            'Asignar Retenciones
            For Each dr As DataRowView In New DataView(CType(bsRetenciones.DataSource, DataTable), "", "", DataViewRowState.CurrentRows)
                If Cont = 1 And CDec(dr("Monto")) > 0 Then
                    .IdRetencion1 = CInt(dr("IdRetencion")) : .PorcRetencion1 = CDec(dr("Porcentaje")) / 100 : .MontoRetencion1 = CDec(dr("Monto")) : Cont = Cont + 1
                ElseIf Cont = 2 And CDec(dr("Monto")) > 0 Then
                    .IdRetencion2 = CInt(dr("IdRetencion")) : .PorcRetencion2 = CDec(dr("Porcentaje")) / 100 : .MontoRetencion2 = CDec(dr("Monto")) : Cont = Cont + 1
                ElseIf Cont = 3 And CDec(dr("Monto")) > 0 Then
                    .IdRetencion3 = CInt(dr("IdRetencion")) : .PorcRetencion3 = CDec(dr("Porcentaje")) / 100 : .MontoRetencion3 = CDec(dr("Monto")) : Cont = Cont + 1
                End If
            Next
        End With
    End Sub

#End Region

    Private Sub btnCloseImpuesto_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles btnCloseImpuesto.ClickButtonArea, btnCloseRetencion.ClickButtonArea
        Dim info As GastoInfo = CType(Me.PackageInfo, GastoInfo)
        pnlImpuestos.Visible = False
        pnlRetenciones.Visible = False

        asignarImpuestosRetenciones()

        RecalcularImpuestos()
        RecalcularRetenciones()
        RecalcularTotales()
        'txtImpuestos.Text = (info.MontoImp1 + info.MontoImp2 + info.MontoImp3).ToString("0.00")
        'txtRetenciones.Text = (info.MontoRetencion1 + info.MontoRetencion2 + info.MontoRetencion3).ToString("0.00")
        'txtTotal.Text = (CDec(Val(txtSubtotal.Text)) + CDec(Val(txtImpuestos.Text)) + CDec(Val(txtRetenciones.Text))).ToString("0.00")
    End Sub

End Class