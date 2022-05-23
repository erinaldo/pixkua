Public Class CobrarComandasForm
    Private Shared _FormatoTicketComanda As String
    Private Shared _FormatoTicketComandaXML As Xml.XmlDocument

    Private Sub CobrarComandasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboCaja.LoadList()
        If Azteca.Windows.Ventas.Context.UnidadNegocio.IdFormatoTicketComanda > 0 Then
            Dim FormatMgr As New Azteca.Kernel.General.FormatManager()
            _FormatoTicketComanda = FormatMgr.LoadFormat(App.Session.SessionID, Azteca.Windows.Ventas.Context.UnidadNegocio.IdFormatoTicketComanda)
            _FormatoTicketComandaXML = New Xml.XmlDocument
            _FormatoTicketComandaXML.LoadXml(_FormatoTicketComanda)
        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            Consultar()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        Try
            If selCliente.Key = 0 Then
                MessageBox.Show("No se ha seleccionado ningun cliente", "restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim ComandaFac As New ComandaFacade
            If lvwComandas.SelectedItems.Count = 0 Then Exit Sub
            'Obtenemos la comanda
            Dim drSel As DataRow = CType(lvwComandas.SelectedItems(0).Tag, DataRow)
            Dim comanda As ComandaInfo = ComandaFac.GetDetail(App.Session.SessionID, CStr(drSel("IdComandaTit")))
            'Seleccionamos las formas de pago
            Dim Venta As Azteca.Business.Ventas.VentaInfo = ComandaFac.ToVentaInfo(App.Session.SessionID, comanda, CInt(selCliente.Key), Context.UnidadNegocio.PoliticaDescuento)
            ' Venta.IdDivisa = Azteca.Windows.Ventas.Context.UnidadNegocio.IdDivisaBase
            Dim frm As New selectFormaPagoVentaForm
            If frm.ShowDialog(Me, Venta, True) = System.Windows.Forms.DialogResult.OK Then
                'Pagamos la comanda. Ahi se genera la venta correspondiente
                ComandaFac.Pagar(App.Session.SessionID, comanda, Venta, frm.FormasPagoSelected)
                Consultar()
                MessageBox.Show("Se ha generado la venta", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#Region "Metodos Privados"

    Private Sub Consultar()
        Try
            Dim ComandaFac As New ComandaFacade
            Dim Mesas As DataTable = ComandaFac.MesasCuentasLST(App.Session.SessionID, CInt(cboCaja.SelectedValue))
            fillMesas(Mesas)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
    Private Sub fillMesas(ByVal Mesas As DataTable)
        lvwComandas.BeginUpdate()
        lvwComandas.Items.Clear()
        ''Dim vwOrdenes As New DataView(dtOrdenes, "", "Fecha DESC, SUCURSAL", DataViewRowState.CurrentRows)
        For Each dr As DataRow In Mesas.Rows
            Dim Item As New ListViewItem(CStr(dr("CentroConsumo")))

            Item.SubItems.Add((dr("Mesa").ToString))
            Item.SubItems.Add((dr("Mesero").ToString))
            Item.SubItems.Add((dr("Observaciones").ToString))
            Item.Tag = dr
            lvwComandas.Items.Add(Item)
        Next
        lvwComandas.EndUpdate()

    End Sub

#End Region

    Private Sub btnImprimirComanda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirComanda.Click
        Try
            If lvwComandas.SelectedItems.Count = 0 Then Exit Sub
            'Obtenemos la comanda
            Dim drSel As DataRow = CType(lvwComandas.SelectedItems(0).Tag, DataRow)
            'Obtenemos la impresora predeterminada
            Dim pd As New System.Drawing.Printing.PrintDocument
            Dim ImpresoraPath As String = pd.PrinterSettings.PrinterName
            PrintTicketComanda(CStr(drSel("IdComandaTit")), ImpresoraPath)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub PrintTicketComanda(ByVal IdComandaTit As String, ByVal ImpresoraPath As String)
        Dim ComandaFac As New ComandaFacade
        If Azteca.Windows.Ventas.Context.UnidadNegocio.IdFormatoTicketComanda > 0 Then
            Dim ComandaTable As Azteca.Business.Restaurante.InformesDS.ComandaTicketDataTable = ComandaFac.TicketPrint(App.Session.SessionID, IdComandaTit)

            'Vamos a ver q tipo de formato trae el cheque, Si es un formato xml o uno rdlc
            If Mid(_FormatoTicketComanda, 1, 13) = "<Report xmlns" Then 'rdcl 
                Dim frmFactura As New ReportForm
                Dim Reader As New System.IO.StringReader(_FormatoTicketComanda)
                frmFactura.LocalReport.LoadReportDefinition(Reader)
                frmFactura.LocalReport.DataSources.Add(New ReportDataSource("ComandaTicket", CType(ComandaTable, DataTable)))
                frmFactura.PrintToPrinter(ImpresoraPath)
            Else 'xml
                Dim Ticket As New Azteca.Windows.Printing.Report
                Ticket.Load(_FormatoTicketComandaXML)
                Dim Engine As New Azteca.Windows.Printing.PrintEngine(Ticket)
                Engine.Data = ComandaTable
                Engine.PrintReport(ImpresoraPath)
            End If
        Else
            MessageBox.Show("No se ha establecido un formato de impresion de Ticket de comanda", "restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
    End Sub

End Class