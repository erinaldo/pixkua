Imports Microsoft.Reporting.WinForms

Public Class NotasForm

    Private dtImpuestos As DataTable
    Private FormatoComprobante As String

#Region "Metodos Privados"

    Private Sub CargarImpuestos()
        Dim ImpuestoFac As New ImpuestoFacade
        dtImpuestos = ImpuestoFac.LoadList(App.Session.SessionID)
        dtImpuestos.PrimaryKey = New DataColumn() {dtImpuestos.Columns("IdImpuesto")}
        bsImpuestos.DataSource = dtImpuestos
        cboImpuestos.Rebind(True)
    End Sub

#End Region

#Region "Implementacion"

    Private Sub NotasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Nota As NotaInfo = CType(PackageInfo, NotaInfo)
        With Nota
            .Fecha = Date.Today
            bsDetalle.DataSource = .Details
            grdDetalle.Rebind(True)
        End With

        lblFechaCap.Text = Date.Today.ToString("dd/MM/yyyy")
    End Sub

    Private Sub NotasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarImpuestos()
            'Cargar formato de factura asignado a la sucursal
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            FormatoComprobante = FormatMgr.LoadFormat(App.Session.SessionID, Context.Sucursal.IdFormatoNotasCredito)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub NotasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Nota As NotaInfo = CType(PackageInfo, NotaInfo)
        With Nota
            If .Tipo = TipoNota.Cargo Then
                rdbCargo.Checked = True
            Else
                rdbCredito.Checked = True
            End If
            lblFolio.Text = .Serie & "-" & .Folio
            lblFechaCap.Text = .Fecha.ToString("dd/MM/yyyy")
            lblFechaCFD.Text = .FechaCFD.ToString("dd/MM/yyyy hh:mm tt")
            If .FolioRef > 0 Then
                rdbVinculada.Checked = True
                txtFolioRef.Text = .FolioRef
                txtSerieRef.Text = String.Empty
                If .IdSerieRef > 0 Then txtSerieRef.LoadInfo(.IdSerieRef)
            Else
                rdbSinRef.Checked = True
                txtFolioRef.Text = String.Empty
                txtSerieRef.Text = String.Empty
            End If
            cboDivisa.SelectedValue = .IdDivisa
            lblSubTotal.Text = .SubTotal.ToString("C")
            lblImpuestos.Text = .TotalImpuestosTrasladados.ToString("C")
            lblTotal.Text = .Total.ToString("C")
            '
            txtRFC.Text = .RFC
            txtRazonSocial.Text = .RazonSocial
            txtCalle.Text = .Calle
            txtNumExt.Text = .NumExt
            txtNumInt.Text = .NumInt
            txtColonia.Text = .Colonia
            txtCP.Text = .CP
            txtPoblacion.Text = String.Empty
            If .IdPoblacion > 0 Then txtPoblacion.LoadInfo(.IdPoblacion)
            bsDetalle.DataSource = .Details
            grdDetalle.Rebind(True)
        End With
        'Cargar formato de CFD asignado a la sucursal
        Dim FormatMgr As New Azteca.Kernel.General.FormatManager
        'FormatoComprobante = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoFacturas)

    End Sub

    Private Sub NotasForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboDivisa.LoadList()
    End Sub

    Private Sub NotasForm_PrintingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PrintingItem
        Dim Nota As NotaInfo = CType(PackageInfo, NotaInfo)
        Dim ComprobanteFac As New ComprobanteFiscalFacade
        If Nota.Status = WorkflowSteps.Invoice Then
            'Cargar información de la factura
            Dim dtComprobante As InformesDS.ComprobantesFiscalesDataTable = ComprobanteFac.LoadPrintInfo(App.Session.SessionID, Nota.IdCFDSerie, Nota.Folio, Nota.UUID)
            'Mostrar vista previa de la factura
            Dim frmComprobante As New ReportForm
            Dim Reader As New System.IO.StringReader(FormatoComprobante)
            frmComprobante.LocalReport.LoadReportDefinition(Reader)
            frmComprobante.LocalReport.DataSources.Add(New ReportDataSource("Comprobantes", CType(dtComprobante, DataTable)))

            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteFac.Load(App.Session.SessionID, Nota.IdCFDSerie, Nota.Folio, Nota.UUID)
            Dim Imagenes As New Azteca.Business.Contabilidad.InformesDS.ImagenesDataTable
            Dim dr As Azteca.Business.Contabilidad.InformesDS.ImagenesRow = Imagenes.NewImagenesRow
            dr.Logo = App.DefaultCompany.Logo
            dr.QrCode = Comprobante.QrCode
            Imagenes.AddImagenesRow(dr)
            frmComprobante.LocalReport.DataSources.Add(New ReportDataSource("Imagenes", CType(Imagenes, DataTable)))
            frmComprobante.Show("CFD " & Nota.Folio.ToString)
        End If
    End Sub

    Private Sub NotasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Nota As NotaInfo = CType(PackageInfo, NotaInfo)
        With Nota
            If rdbCargo.Checked Then
                .Tipo = TipoNota.Cargo
            Else
                .Tipo = TipoNota.Credito
            End If
            .IdDivisa = CInt(cboDivisa.SelectedValue)
            If rdbSinRef.Checked Then
                .IdSerieRef = 0
                .FolioRef = 0
            Else
                .IdSerieRef = txtSerieRef.Key
                .FolioRef = CInt(Val(txtFolioRef.Text))
            End If
            .RFC = txtRFC.Text
            .RazonSocial = txtRazonSocial.Text
            .Calle = txtCalle.Text
            .NumExt = txtNumExt.Text
            .NumInt = txtNumInt.Text
            .Colonia = txtColonia.Text
            .CP = txtCP.Text
            .IdPoblacion = txtPoblacion.Key
        End With
    End Sub

    Private Sub rdbSinRef_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbSinRef.CheckedChanged
        txtSerieRef.Enabled = False
        txtFolioRef.Enabled = False
        btnCopiarDatos.Enabled = False
    End Sub

    Private Sub rdbVinculada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbVinculada.CheckedChanged
        txtSerieRef.Enabled = True
        txtFolioRef.Enabled = True
        btnCopiarDatos.Enabled = True
    End Sub

    Private Sub rdbCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCargo.CheckedChanged
        grpDatosNota.Text = "Nota de Cargo"
    End Sub

    Private Sub rdbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCredito.CheckedChanged
        grpDatosNota.Text = "Nota de Crédito"
    End Sub

    Private Sub btnCopiarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarDatos.Click
        If txtSerieRef.Key = 0 Then
            MessageBox.Show("Debe elegir la serie del CFD referencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSerieRef.Focus()
        ElseIf Val(txtFolioRef.Text) <= 0 Then
            MessageBox.Show("Debe introducir el folio del CFD referencia.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFolioRef.Focus()
        Else
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim ComprobanteFac As New ComprobanteFiscalFacade
                Dim Comprobante As ComprobanteFiscalInfo = ComprobanteFac.Load(App.Session.SessionID, txtSerieRef.Key, CInt(txtFolioRef.Text), String.Empty)
                With Comprobante
                    txtRFC.Text = .Receptor.RFC
                    txtRazonSocial.Text = .Receptor.Nombre
                    txtCalle.Text = .Receptor.Domicilio.Calle
                    txtNumExt.Text = .Receptor.Domicilio.NumExt
                    txtNumInt.Text = .Receptor.Domicilio.NumInt
                    txtColonia.Text = .Receptor.Domicilio.Colonia
                    txtCP.Text = .Receptor.Domicilio.CodigoPostal
                    txtPoblacion.Text = String.Empty
                End With
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub


#End Region

#Region "Partidas"

    Private Sub grdDetalle_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalle.AfterColUpdate
        Try
            If e.Column.Name = "Impuesto" Or e.Column.Name = "Monto" Then
                Dim IdImpuesto As Integer = CInt(grdDetalle.Columns("Impuesto").Value)
                If IdImpuesto > 0 Then
                    Dim drImpuesto As DataRow = dtImpuestos.Rows.Find(IdImpuesto)
                    Dim Porcentaje As Decimal = CDec(drImpuesto("Porcentaje")) / 100D
                    Dim Monto As Decimal = CDec(grdDetalle.Columns("Monto").Value)
                    grdDetalle.Columns("Porc. Impuesto").Value = Porcentaje
                    grdDetalle.Columns("Monto Impuesto").Value = Porcentaje * Monto
                Else
                    grdDetalle.Columns("Porc. Impuesto").Value = 0
                    grdDetalle.Columns("Monto Impuesto").Value = 0
                End If
            ElseIf e.Column.Name = "Código" Then
                grdDetalle.UpdateData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdDetalle_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdDetalle.BeforeColEdit
        If e.Column.Name <> "Código" AndAlso grdDetalle.Columns("Código").Text = String.Empty Then
            e.Cancel = True
            MessageBox.Show("Primero debe capturar el código del concepto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '
        If e.Column.Name = "Concepto" Then
            If Not CBool(grdDetalle.Columns("ConceptoLibre").Value) Then e.Cancel = True
        End If
    End Sub

    Private Sub grdDetalle_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdDetalle.BeforeColUpdate
        Try
            If e.Column.Name = "Código" Then
                If Val(grdDetalle.Columns("Código").Text) <= 0 Then Return
                Dim ConceptoFac As New ConceptoNotaFacade
                If ConceptoFac.Exists(App.Session.SessionID, grdDetalle.Columns("Código").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Concepto As ConceptoNotaInfo = ConceptoFac.GetDetail(App.Session.SessionID, grdDetalle.Columns("Código").Value.ToString, App.DefaultSite.Identity, False)
                    Dim drvDetalle As DataRowView = CType(bsDetalle.Current, DataRowView)
                    drvDetalle("IdNotaConcepto") = Concepto.Identity
                    grdDetalle.Columns("Código").Value = Concepto.UserCode
                    grdDetalle.Columns("Concepto").Value = Concepto.Nombre
                    grdDetalle.Columns("ConceptoLibre").Value = Concepto.ConceptoLibre
                Else
                    e.Cancel = True
                    MessageBox.Show("El concepto especificado no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdDetalle_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDetalle.ButtonClick
        Dim Nota As NotaInfo = CType(PackageInfo, NotaInfo)
        Try
            If e.Column.Name = "Código" And Nota.Status = WorkflowSteps.Save Then
                Dim frmSearch As New MsgSearch
                With frmSearch
                    .IdProceso = IdProceso
                    .Owner = Me
                End With
                Dim ConceptoFac As New ConceptoNotaFacade
                If frmSearch.ShowDialog(ConceptoFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim IdConcepto As Integer = CInt(frmSearch.SelectedItem)
                    Dim drDetalle As DetalleNotaDS.DetalleRow
                    If grdDetalle.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
                        drDetalle = Nota.Details.NewDetalleRow()
                    Else
                        drDetalle = CType(CType(bsDetalle.Current, DataRowView).Row, DetalleNotaDS.DetalleRow)
                    End If
                    Dim Concepto As ConceptoNotaInfo = ConceptoFac.GetDetail(App.Session.SessionID, CInt(IdConcepto), False)
                    drDetalle.IdNotaConcepto = Concepto.Identity
                    grdDetalle.Columns("Código").Value = Concepto.UserCode
                    grdDetalle.Columns("Concepto").Value = Concepto.Nombre
                    grdDetalle.Columns("ConceptoLibre").Value = Concepto.ConceptoLibre
                    If drDetalle.RowState = DataRowState.Detached Then Nota.Details.AddDetalleRow(drDetalle)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdDetalle_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdDetalle.FetchCellStyle
        If bsDetalle.Count = 0 Or bsDetalle.Count = e.Row Then Return
        If e.Column.Name = "Concepto" Then
            If Not CBool(grdDetalle.Columns("ConceptoLibre").CellValue(e.Row)) Then
                e.CellStyle.BackColor = Drawing.Color.LightGray
            End If
        End If
    End Sub

#End Region


End Class