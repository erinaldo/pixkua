Imports Microsoft.Reporting.WinForms

Public Class PagosAdminForm
    Dim frmGenerador As GeneradorPagosForm

    Private Sub PagosAdminForm_AddingDocument(sender As Object, e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingDocument
        Try
            Dim Result As DialogResult = System.Windows.Forms.DialogResult.OK
            While Result <> System.Windows.Forms.DialogResult.Cancel
                Result = frmGenerador.ShowDialog(Me, CInt(cboCaja.SelectedValue))
            End While
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub PagosAdminForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cboCaja.LoadList(App.Session.User.Identity)
        CommandHolder.Commands("cmdNuevo").Text = "Generar Nuevos Pagos"

        frmGenerador = New GeneradorPagosForm
        frmGenerador.loadingList() : frmGenerador.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub PagosAdminForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim PagoFac As New PagoFacade
            bsPagos.DataSource = PagoFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, CInt(cboCaja.SelectedValue))
            grdPagos.Rebind(True)
            Me.DocumentBindingSource = bsPagos
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub PagosAdminForm_PrintingDocument(sender As Object, e As Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingDocument
        Try
            grdPagos.UpdateData()
            Dim FormatMgr As Azteca.Kernel.General.FormatManager
            Dim Formato As String = "", IdFormatoAnt As Integer = 0

            Dim PagoFac As New PagoFacade
            Dim dv As New DataView(CType(bsPagos.DataSource, DataTable), "Sel=1", "IdFormato,Folio", DataViewRowState.CurrentRows)

            For Each dr As DataRowView In dv

                Dim ChequeTable As InformesDS.PagoRPTDataTable = PagoFac.LoadPrint(App.Session.SessionID, CStr(dr("Id")))
                If ChequeTable.Rows.Count > 0 Then ChequeTable(0)("LeyendaCheque") = dr("LeyendaCheque")

                'Cargar formato de impresión
                If IdFormatoAnt <> CInt(dr("IdFormato")) Then
                    FormatMgr = New Azteca.Kernel.General.FormatManager()
                    Formato = FormatMgr.LoadFormat(App.Session.SessionID, dr("IdFormato"))
                End If
                Dim FormatoCheque As New Xml.XmlDocument
                FormatoCheque.LoadXml(Formato)

                'Vamos a ver q tipo de formato trae el cheque, Si es un formato xml o uno rdlc
                If Mid(Formato, 1, 13) = "<Report xmlns" Then 'rdcl 
                    Dim pd As New System.Drawing.Printing.PrintDocument
                    ' Default printer       
                    Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

                    Dim frmFactura As New ReportForm
                    Dim Reader As New System.IO.StringReader(Formato)
                    frmFactura.LocalReport.LoadReportDefinition(Reader)
                    frmFactura.LocalReport.DataSources.Add(New ReportDataSource("Pago", CType(ChequeTable, DataTable)))
                    frmFactura.PrintToPrinter(s_Default_Printer)
                Else 'xml
                    Dim Reporte As New Azteca.Windows.Printing.Report
                    Reporte.Load(FormatoCheque)                    
                    Dim Engine As New Azteca.Windows.Printing.PrintEngine(Reporte)
                    Engine.Data = ChequeTable
                    Engine.PrintReport()
                End If

                IdFormatoAnt = CInt(dr("IdFormato"))
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

End Class