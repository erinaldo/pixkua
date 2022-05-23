Public Class DetalleCorteForm
    Private _IdCorte As Guid

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal IdCorte As Guid, ByVal Caja As String, FechaApertura As Date, FechaCierre As Date) As DialogResult
        lblCaja.Text = "     " & Caja
        lblFechaApertura.Text = "          Fecha Apertura:" & FechaApertura
        lblFechaCierre.Text = "            Fecha Cierre:" & FechaCierre
        Me.Icon = owner.Icon
        _IdCorte = IdCorte
        loadDetalle()

        Return MyBase.ShowDialog()
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal IdCorte As Guid, ByVal Caja As String, FechaApertura As Date) As DialogResult
        lblCaja.Text = "     " & Caja
        lblFechaApertura.Text = "          Fecha Apertura:" & FechaApertura
        lblFechaCierre.Text = "            Fecha Cierre:" & "Abierto"

        Me.Icon = owner.Icon
        _IdCorte = IdCorte
        loadDetalle()

        Return MyBase.ShowDialog()
    End Function

    Private Sub loadDetalle()
        Dim CajaFac As New CajaFacade
        bsCierre.DataSource = CajaFac.LoadCorteDetalle(App.Session.SessionID, _IdCorte)
        grdDetalle.Rebind(True)

        Dim dtCorte As CajaDS.CorteDetalleDataTable = CType(bsCierre.DataSource, CajaDS.CorteDetalleDataTable)

        Dim Totales = From T In dtCorte
                      Group By FormaPago = T.FormaPago
                      Into Group, Total = Sum(T.Total)

        bsTitulo.DataSource = Totales
        grdTotales.Rebind(True)

        Dim MontoTotal As Object = dtCorte.Compute("SUM(Total)", "")
        If Not IsNothing(MontoTotal) Then grdTotales.Columns("Total").FooterText = CDec(MontoTotal).ToString("0.00")
        grdTotales.Columns("FormaPago").FooterText = "Total:"

    End Sub

    Private Sub cmdLnkRegresar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdLnkRegresar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdLnkImprimir_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdLnkImprimir.Click
        ImprimirCorte()
    End Sub

    Private Sub cmdLnkImpresionPOS_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdLnkImpresionPOS.Click
        Try
            If Context.UnidadNegocio.IdFormatoTicketCortePOS = 0 Then
                MessageBox.Show("No se ha configurado un Formato de Corte de texto para la unidad de negocios Actual", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim CajaFac As New CajaFacade
            Dim dtCorte As InformesDS.CorteCajaDataTable = CajaFac.LoadCortePrintInfo(App.Session.SessionID, _IdCorte)

            'Cargar formato de impresión
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager()
            Dim FormatoTicket As String = FormatMgr.LoadFormat(App.Session.SessionID, Context.UnidadNegocio.IdFormatoTicketCortePOS)
            Dim FormatoTicketPOS = New Xml.XmlDocument
            FormatoTicketPOS.LoadXml(FormatoTicket)

            If Mid(FormatoTicket, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim pd As New System.Drawing.Printing.PrintDocument
                Dim frmVenta As New ReportForm
                Dim Reader As New System.IO.StringReader(FormatoTicket)
                frmVenta.LocalReport.LoadReportDefinition(Reader)
                frmVenta.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Corte", CType(dtCorte, DataTable)))
                frmVenta.PrintToPrinter(pd.PrinterSettings.PrinterName)
            Else 'xml
                Dim Reporte As New Azteca.Windows.Printing.Report
                Reporte.Load(FormatoTicketPOS)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Reporte)
                Engine.Data = dtCorte
                Engine.PrintReport(CStr(dtCorte(0)("ImpresoraPath")))
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ImprimirCorte()
        Try
            Dim CajaFac As New CajaFacade

            Dim dtCorte As InformesDS.CorteCajaDataTable = CajaFac.LoadCortePrintInfo(App.Session.SessionID, _IdCorte)
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            Parametros.Add(New ReportParameter("Sucursal", App.DefaultSite.NombreLargo))

            'Mostrar vista previa de la venta
            Dim frmReport As New ReportForm
            frmReport.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.CorteCajaRPT.rdlc"
            frmReport.LocalReport.DataSources.Add(New ReportDataSource("Corte", CType(dtCorte, DataTable)))
            frmReport.LocalReport.SetParameters(Parametros)
            frmReport.Show("Corte de caja")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class