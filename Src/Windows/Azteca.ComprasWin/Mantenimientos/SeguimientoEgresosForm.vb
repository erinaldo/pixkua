Imports Microsoft.Reporting.WinForms

Public Class SeguimientoEgresosForm
    Private ArchiveroDigital As Azteca.Business.Tesoreria.PagosDS

#Region "Metodos Privados"
    Private Sub agruparDocumentos()
        Dim table As DataTable = CType(bsSeguimiento.DataSource, DataTable)

        Dim Gastos = From D In table
                     Where D!IdGasto IsNot DBNull.Value
                     Group By Gasto = D!IdGasto
                     Into Group

        Dim FacturasGasto = From D In table
             Where D!FacturaGasto.ToString <> ""
             Group By Factura = D!FacturaGasto
             Into Group

        Dim Requisiciones = From D In table
             Where D!IdRequisicion IsNot DBNull.Value
             Group By Requisicion = D!IdRequisicion
             Into Group

        Dim Ordenes = From D In table
              Where D!IdOrdenTit IsNot DBNull.Value
             Group By Orden = D!IdOrdenTit
             Into Group

        Dim Recepciones = From D In table
             Where D!IdRecepcionTit IsNot DBNull.Value
            Group By Recepcion = D!IdRecepcionTit
            Into Group

        Dim FacturasEntregas = From D In table
             Where D!FacturaRecep.ToString <> ""
             Group By Factura = D!FacturaRecep
             Into Group

        Dim Contrarecibos = From D In table
            Where D!IdContrareciboTit IsNot DBNull.Value
            Group By Contrarecibo = D!IdContrareciboTit
            Into Group

        Dim Pagos = From D In table
            Where D!IdPagoTit IsNot DBNull.Value
            Group By Pago = D!IdPagoTit
            Into Group

        lvwDocumentos.Items(0).Text = "Gastos [" & Gastos.Count & "]"
        lvwDocumentos.Items(1).Text = "Facturas de Gasto [" & FacturasGasto.Count & "]"
        lvwDocumentos.Items(2).Text = "Requisiciones [" & Requisiciones.Count & "]"
        lvwDocumentos.Items(3).Text = "Ordenes [" & Ordenes.Count & "]"
        lvwDocumentos.Items(4).Text = "Recepciones [" & Recepciones.Count & "]"
        lvwDocumentos.Items(5).Text = "Facturas Recib. [" & FacturasEntregas.Count & "]"
        lvwDocumentos.Items(6).Text = "Contrarecibos [" & Contrarecibos.Count & "]"
        lvwDocumentos.Items(7).Text = "Pagos [" & Pagos.Count & "]"

    End Sub

    Private Sub fillDetalle()
        If bsSeguimiento.DataSource Is Nothing Then Exit Sub
        If lvwDocumentos.SelectedItems.Count = 0 Then Exit Sub
        pnlSeleccion.Visible = False

        Dim table As DataTable = CType(bsSeguimiento.DataSource, DataTable)
        lvwDetalle.Items.Clear()

        If lvwDocumentos.SelectedItems(0).ImageIndex = 0 Then 'Gastos
            Dim Gastos = From D In table
                Where D!IdGasto IsNot DBNull.Value
                Group By Gasto = D!IdGasto
            Into Group
            For Each item In Gastos
                ItemDocumento(item.Gasto.ToString, 0)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 1 Then 'Facturas de Gasto
            Dim FacturasGasto = From D In table
                Where D!FacturaGasto.ToString <> ""
                Group By Factura = D!FacturaGasto
                Into Group
            For Each item In FacturasGasto
                lvwDetalle.Items.Add(CStr(item.Factura), 1)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 2 Then 'Requisiciones
            Dim Requisiciones = From D In table
                Where D!IdRequisicion IsNot DBNull.Value
                Group By Requisicion = D!IdRequisicion
                Into Group
            For Each item In Requisiciones
                ItemDocumento(CStr(item.Requisicion), 2)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 3 Then 'Ordenes
            Dim Ordenes = From D In table
            Where D!IdOrdenTit IsNot DBNull.Value
            Group By Orden = D!IdOrdenTit
            Into Group
            For Each item In Ordenes
                ItemDocumento(CStr(item.Orden), 3)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 4 Then 'Recepciones
            Dim Recepciones = From D In table
                Where D!IdRecepcionTit IsNot DBNull.Value
                Group By Recepcion = D!IdRecepcionTit
                Into Group
            For Each item In Recepciones
                ItemDocumento(CStr(item.Recepcion), 4)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 5 Then 'Facturas de Recepciones
            Dim FacturasEntregas = From D In table
                 Where D!FacturaRecep.ToString <> ""
                 Group By Factura = D!FacturaRecep
                 Into Group
            For Each item In FacturasEntregas
                lvwDetalle.Items.Add(CStr(item.Factura), 5)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 6 Then 'Contrarecibos
            Dim Contrarecibos = From D In table
                Where D!IdContrareciboTit IsNot DBNull.Value
                Group By Contrarecibo = D!IdContrareciboTit
                Into Group
            For Each item In Contrarecibos
                ItemDocumento(CStr(item.Contrarecibo), 6)
            Next
        ElseIf lvwDocumentos.SelectedItems(0).ImageIndex = 7 Then 'Pagos
            Dim Pagos = From D In table
            Where D!IdPagoTit IsNot DBNull.Value
            Group By Pago = D!IdPagoTit
            Into Group
            For Each item In Pagos
                ItemDocumento(CStr(item.Pago), 7)
            Next
        End If

    End Sub

    Private Sub ItemDocumento(Caption As String, IdImage As Integer)
        Dim item As New ListViewItem(Caption, IdImage)
        item.ToolTipText = "Presiones Click Derecho para mostrar el listado de Pólizas generadas para el documento"
        item.Tag = Caption
        lvwDetalle.Items.Add(item)
    End Sub

#End Region

    Private Sub cboDocumentos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboDocumentos.SelectedIndexChanged
        lblFolioDoc.Visible = False : txtDocumento.Visible = False
        lblSerie.Visible = False : lblFactura.Visible = False : txtSerie.Visible = False : txtFactura.Visible = False
        lblCaja.Visible = False : cboCaja.Visible = False : lblChequera.Visible = False : cboChequeras.Visible = False : lblFolio.Visible = False : txtFolio.Visible = False
        'Documentos
        If cboDocumentos.SelectedIndex = 0 Or cboDocumentos.SelectedIndex = 2 Or cboDocumentos.SelectedIndex = 3 Or cboDocumentos.SelectedIndex = 4 Or _
           cboDocumentos.SelectedIndex = 6 Or cboDocumentos.SelectedIndex = 7 Then
            lblFolioDoc.Visible = True : txtDocumento.Visible = True
        ElseIf cboDocumentos.SelectedIndex = 1 Or cboDocumentos.SelectedIndex = 5 Then 'Facturas
            lblSerie.Visible = True : lblFactura.Visible = True : txtSerie.Visible = True : txtFactura.Visible = True
        ElseIf cboDocumentos.SelectedIndex = 8 Then 'Folios
            lblFolio.Visible = True : txtFolio.Visible = True
            lblChequera.Visible = True : cboChequeras.Visible = True
            lblCaja.Visible = True : cboCaja.Visible = True
        End If
    End Sub

    Private Sub btnConsultar_Click(sender As System.Object, e As System.EventArgs) Handles btnConsultar.Click
        Dim IdGasto As String = CStr(IIf(cboDocumentos.SelectedIndex = 0, txtDocumento.Text, ""))
        Dim SerieGasto As String = CStr(IIf(cboDocumentos.SelectedIndex = 1, txtSerie.Text, ""))
        Dim FacturaGasto As Integer = CInt(IIf(cboDocumentos.SelectedIndex = 1, Val(txtFactura.Text), 0))
        Dim IdRequisicion As String = CStr(IIf(cboDocumentos.SelectedIndex = 2, txtDocumento.Text, ""))
        Dim IdOrdenTit As String = CStr(IIf(cboDocumentos.SelectedIndex = 3, txtDocumento.Text, ""))
        Dim IdRecepcionTit As String = CStr(IIf(cboDocumentos.SelectedIndex = 4, txtDocumento.Text, ""))
        Dim SerieRecep As String = CStr(IIf(cboDocumentos.SelectedIndex = 5, txtSerie.Text, ""))
        Dim FacturaRecep As Integer = CInt(IIf(cboDocumentos.SelectedIndex = 5, Val(txtFactura.Text), 0))
        Dim IdContrareciboTit As String = CStr(IIf(cboDocumentos.SelectedIndex = 6, txtDocumento.Text, ""))
        Dim IdPago As String = CStr(IIf(cboDocumentos.SelectedIndex = 7, txtDocumento.Text, ""))
        Dim IdChequera As Integer = CInt(IIf(cboDocumentos.SelectedIndex = 8, CInt(cboChequeras.SelectedValue), 0))
        Dim FolioPago As Integer = CInt(IIf(cboDocumentos.SelectedIndex = 8, Val(txtFolio.Text), 0))

        Try
            lvwDetalle.Clear()
            Dim PagoFac As New Azteca.Business.Tesoreria.PagoFacade
            ArchiveroDigital = PagoFac.ArchiveroDigital(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, IdGasto, SerieGasto, FacturaGasto, _
                                   IdRequisicion, IdOrdenTit, IdRecepcionTit, SerieRecep, FacturaRecep, _
                                   IdContrareciboTit, IdPago, IdChequera, FolioPago)
            bsSeguimiento.DataSource = ArchiveroDigital.ArchiveroDigital
            bsPolizas.DataSource = ArchiveroDigital.ArchiveroPolizas
            grdGastos.Rebind(True)
            grdPolizas.Rebind(True)
            agruparDocumentos()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub lvwDocumentos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvwDocumentos.SelectedIndexChanged
        fillDetalle()
    End Sub

    Private Sub lvwDetalle_DoubleClick(sender As Object, e As System.EventArgs) Handles lvwDetalle.DoubleClick
        Me.Cursor = Cursors.WaitCursor

        If lvwDetalle.SelectedItems.Count = 0 Then Exit Sub
        Try
            If lvwDocumentos.SelectedItems(0).Index = 0 Then
                MotrarGasto()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 1 Then
                MostrarFactura()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 2 Then
                MostrarRequisicion()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 3 Then
                MostrarOrden()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 4 Then
                MostrarRecepcion()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 5 Then
                MostrarFactura()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 6 Then
                MostrarContrarecibo()
            ElseIf lvwDocumentos.SelectedItems(0).Index = 7 Then
                MostrarCheque()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MotrarGasto()
        Try
            Dim IdGasto As String = CStr(lvwDetalle.SelectedItems(0).Tag)

            ' Cargar información de impresión de los Presupuestos
            Dim GastoFac As New GastoFacade
            Dim dtSource As DataTable = GastoFac.LoadPrintInfo(App.Session.SessionID, IdGasto)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            'Mostrar vista previa de los presupuestos
            Dim frmVenta As New ReportForm
            frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.Gasto.rdlc"
            frmVenta.LocalReport.DataSources.Add(New ReportDataSource("GastoInfo", CType(dtSource, DataTable)))
            frmVenta.LocalReport.SetParameters(Parametros)
            frmVenta.Show("Gasto")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
    Private Sub MostrarFactura()
        MessageBox.Show("No implemantado")
    End Sub
    Private Sub MostrarRequisicion()
        MessageBox.Show("No implemantado")
    End Sub
    Private Sub MostrarOrden()
        Try
            Dim OrdenFac As New OrdenFacade
            Dim IdOrden As String = CStr(lvwDetalle.SelectedItems(0).Tag)
            Dim Info As DataTable = OrdenFac.LoadPrintInfo(App.Session.SessionID, IdOrden)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            Dim Formato As String = FormatMgr.LoadFormat(App.Session.SessionID, "Azteca.Windows.Compras.Orden")

            Dim FormatoXML As New Xml.XmlDocument
            FormatoXML.LoadXml(Formato)

            'Vamos a ver q tipo de formato trae, Si es un formato xml o uno rdlc
            If Mid(Formato, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim frmPrint As New ReportForm
                Dim Reader As New System.IO.StringReader(Formato)
                frmPrint.LocalReport.LoadReportDefinition(Reader)
                frmPrint.LocalReport.DataSources.Add(New ReportDataSource("ReportData", CType(Info, DataTable)))
                'frmPrint.LocalReport.SetParameters(Parametros)
                frmPrint.Show()
            Else 'xml
                Dim Reporte As New Azteca.Windows.Printing.Report
                Reporte.Load(FormatoXML)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Reporte)
                Engine.Data = Info
                Engine.PrintReport()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
    Private Sub MostrarRecepcion()
        Try
            Dim IdRecep As String = CStr(lvwDetalle.SelectedItems(0).Tag)

            ' Cargar información de impresión de los Presupuestos
            Dim RecepFac As New RecepcionFacade
            Dim dtSource As DataTable = RecepFac.LoadPrintInfo(App.Session.SessionID, IdRecep)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            'Mostrar vista previa
            Dim frmPrint As New ReportForm
            frmPrint.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.Recepcion.rdlc"
            frmPrint.LocalReport.DataSources.Add(New ReportDataSource("ReportData", CType(dtSource, DataTable)))
            frmPrint.LocalReport.SetParameters(Parametros)
            frmPrint.Show("Recepcion")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
    Private Sub MostrarContrarecibo()
        Try
            ' Cargar información de impresión de los Presupuestos
            Dim ContraFac As New Azteca.Business.Tesoreria.ContrareciboFacade
            Dim dtSource As DataTable = ContraFac.LoadPrintInfo(App.Session.SessionID, Me.dtpFechaIni.Value, Me.dtpFechaFin.Value, CStr(lvwDetalle.SelectedItems(0).Tag))
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            'Mostrar vista previa de los presupuestos
            Dim frmVenta As New ReportForm
            frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Tesoreria.Contrarecibo.rdlc"
            frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Contrarecibos", CType(dtSource, DataTable)))
            frmVenta.LocalReport.SetParameters(Parametros)
            frmVenta.Show("Contrarecibos")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
    Private Sub MostrarCheque()
        MessageBox.Show("No implemantado")
    End Sub
    Private Sub MostrarPoliza()
        Try
            Dim row As DataRowView = CType(bsPolizas.Current, DataRowView)

            ' Cargar información de impresión de la poliza
            Dim PolizaFac As New Azteca.Business.Contabilidad.PolizaFacade
            Dim dtSource As DataTable = PolizaFac.InformeData(App.Session.SessionID, CStr(row("IdPolizaTit")))
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))

            Dim FormatMgr As New Azteca.Kernel.General.FormatManager
            Dim Formato As String = FormatMgr.LoadFormat(App.Session.SessionID, "Azteca.Windows.Contabilidad.PolizaRPT")

            Dim FormatoXML As New Xml.XmlDocument
            FormatoXML.LoadXml(Formato)

            'Vamos a ver q tipo de formato trae, Si es un formato xml o uno rdlc
            If Mid(Formato, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim frmPrint As New ReportForm
                Dim Reader As New System.IO.StringReader(Formato)
                frmPrint.LocalReport.LoadReportDefinition(Reader)
                frmPrint.LocalReport.DataSources.Add(New ReportDataSource("PolizaInfo", CType(dtSource, DataTable)))
                frmPrint.LocalReport.SetParameters(Parametros)
                frmPrint.Show()
            Else 'xml
                Dim Reporte As New Azteca.Windows.Printing.Report
                Reporte.Load(FormatoXML)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Reporte)
                Engine.Data = dtSource
                Engine.PrintReport()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub lvwDetalle_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lvwDetalle.MouseClick
        pnlSeleccion.Visible = False
        If lvwDetalle.SelectedItems.Count = 0 Then Exit Sub
        'Al dar boton derecho
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            If lvwDetalle.SelectedItems(0).Tag = "" Then Exit Sub
            'Nos traemos el item seleccionado
            bsPolizas.Filter = "IdDocumento='" & CStr(lvwDetalle.SelectedItems(0).Tag) & "'"
            pnlSeleccion.Location = New Drawing.Point(e.X, e.Y)
            pnlSeleccion.Visible = True
            pnlSeleccion.Focus()
        End If
    End Sub

    Private Sub pnlSeleccion_Leave(sender As Object, e As System.EventArgs) Handles pnlSeleccion.Leave
        'pnlSeleccion.Visible = False
    End Sub

    Private Sub pnlSeleccion_LostFocus(sender As Object, e As System.EventArgs) Handles pnlSeleccion.LostFocus
        If Not grdGastos.Focus Then pnlSeleccion.Visible = False
    End Sub

    Private Sub cboCaja_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCaja.SelectedIndexChanged
        If cboCaja.DataSource Is Nothing Then Exit Sub

        cboChequeras.LoadList(CInt(cboCaja.SelectedValue))
    End Sub

    Private Sub SeguimientoEgresosForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        cboCaja.LoadList()
    End Sub

    Private Sub grdPolizas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdPolizas.ButtonClick
        MostrarPoliza()
        pnlSeleccion.Visible = False
    End Sub

    Private Sub btnClosePol_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles btnClosePol.ClickButtonArea
        pnlSeleccion.Visible = False
    End Sub



End Class