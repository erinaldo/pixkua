Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class AlmacenDigitalForm
    Private Comprobantes As DataTable

    Private Sub ActualizarLista()
        Dim ComprobanteFac As New ComprobanteFiscalFacade
        Comprobantes = ComprobanteFac.ListaPorPeriodo(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, App.DefaultCompany.Identity)
        bsComprobantes.DataSource = Comprobantes
        grdComprobantes.Rebind(True)
    End Sub

    Private Sub AlmacenDigitalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpFechaIni.Value = Date.Today.AddDays(-15)
        dtpFechaFin.Value = Date.Today
        Try
            ActualizarLista()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdRecibir_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdRecibir.Click
        Try
            Dim frmRecibir As New RecibirFacturaForm
            If frmRecibir.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                ActualizarLista()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdImprimir.Click
        If bsComprobantes.Current IsNot Nothing Then
            Try
                Dim dr As DataRowView = CType(bsComprobantes.Current, DataRowView)
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim frmPrint As New ReportForm
                Dim ComprobanteFac As New ComprobanteFiscalFacade
                Dim Info As DataTable = ComprobanteFac.LoadPrintInfo(App.Session.SessionID, CInt(dr("IdProveedor")), dr("Serie").ToString, CInt(dr("Folio")), dr("UUID").ToString)
                '
                frmPrint.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.ComprobanteFiscal.rdlc"
                frmPrint.LocalReport.DataSources.Add(New ReportDataSource("Comprobantes", Info))
                frmPrint.Text = "Comprobante Fiscal Digital"
                frmPrint.ShowDialog(Me)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub cmdAdjuntos_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAdjuntos.Click

    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdActualizar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            ActualizarLista()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdComprobantes_AfterColEdit(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdComprobantes.AfterColEdit
        If e.Column.Name = "X" Then
            grdComprobantes.UpdateData()
            Dim vwSelected As New DataView(Comprobantes, "Sel=True", String.Empty, DataViewRowState.CurrentRows)
            cmdImprimir.Enabled = Not (vwSelected.Count > 1)
            cmdRecibir.Enabled = Not (vwSelected.Count > 1)
        End If
    End Sub

    Private Sub cmdDescargarXML_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdDescargarXML.Click
        Try
            Dim vwSelected As New DataView(Comprobantes, "Sel=True", String.Empty, DataViewRowState.CurrentRows)
            If vwSelected.Count > 1 Then
                If FolderBrowser.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    For Each dr As DataRowView In vwSelected
                        Dim ComprobanteFac As New ComprobanteFiscalFacade
                        Dim DocumentoXML As String = ComprobanteFac.GetXML(App.Session.SessionID, CInt(dr("IdProveedor")), dr("Serie").ToString, CInt(dr("Folio")), dr("UUID").ToString)
                        Using Writer As TextWriter = File.CreateText(FolderBrowser.SelectedPath & "\" & dr("RFC").ToString & "_" & dr("Serie").ToString.Trim & dr("Folio").ToString & dr("UUID").ToString.Trim & ".xml")
                            Writer.Write(DocumentoXML)
                        End Using
                    Next
                End If
            Else
                If bsComprobantes.Current IsNot Nothing Then
                    Dim dr As DataRowView = CType(bsComprobantes.Current, DataRowView)
                    dlgSaveXML.FileName = dr("Serie").ToString.Trim & dr("Folio").ToString & dr("UUID").ToString.Trim & ".xml"
                    If dlgSaveXML.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                        Dim ComprobanteFac As New ComprobanteFiscalFacade
                        Dim DocumentoXML As String = ComprobanteFac.GetXML(App.Session.SessionID, CInt(dr("IdProveedor")), dr("Serie").ToString.Trim, CInt(dr("Folio")), dr("UUID").ToString)
                        Using Writer As TextWriter = File.CreateText(dlgSaveXML.FileName)
                            Writer.Write(DocumentoXML)
                        End Using
                    End If
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class