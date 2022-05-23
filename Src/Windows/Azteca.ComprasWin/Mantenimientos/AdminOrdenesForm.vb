Imports Microsoft.Reporting.WinForms

Public Class AdminOrdenesForm

    Private Sub AdminOrdenesForm_ApplyingWorkflow(sender As Object, e As Forms.BusinessForms.ApplyingWorkflowEventArgs) Handles Me.ApplyingWorkflow
        grdOrdenes.UpdateData()
    End Sub

    Private Sub AdminOrdenesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub AdminOrdenesForm_AddingDocument(sender As Object, e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingDocument
        Dim frmOpcion As New NuevaOrdenOpcionesForm
        If frmOpcion.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            LoadData()
        End If
    End Sub

    Private Sub AdminOrdenesForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim OrdenFac As New OrdenFacade
            Dim dtOrdenes As DataTable = OrdenFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, App.Session.User.Identity, App.DefaultSite.Identity)
            bsOrdenes.DataSource = dtOrdenes
            grdOrdenes.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub AdminOrdenesForm_PrintingDocument(sender As Object, e As Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingDocument
        If bsOrdenes.Current IsNot Nothing Then
            Try
                Dim frmPrint As New ReportForm
                Dim OrdenFac As New OrdenFacade
                Dim IdOrden As String = grdOrdenes.Columns("Folio").Text
                Dim Info As DataTable = OrdenFac.LoadPrintInfo(App.Session.SessionID, IdOrden)
                '
                frmPrint.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.Orden_DEMO.rdlc"
                frmPrint.LocalReport.DataSources.Add(New ReportDataSource("ReportData", Info))
                frmPrint.ShowDialog(Me)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub AdminOrdenesForm_SelectedStatusChanged(sender As Object, e As System.EventArgs) Handles Me.SelectedStatusChanged
        If SelectedStatus > 0 Then
            grdOrdenes.Splits(0).DisplayColumns("Sel").Visible = True
        Else
            grdOrdenes.Splits(0).DisplayColumns("Sel").Visible = False
        End If
    End Sub

    Private Sub grdOrdenes_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdOrdenes.ButtonClick
        If bsOrdenes.Current IsNot Nothing Then
            Try
                Dim frmOrden As New OrdenesForm
                If frmOrden.ShowDialog(grdOrdenes.Columns("Folio").Text, "Editar Orden de Compra") = System.Windows.Forms.DialogResult.OK Then
                    LoadData()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub AdminOrdenesForm_CancelingWorkflow(sender As Object, e As Forms.BusinessForms.CancelingWorkflowEventArgs) Handles Me.CancelingWorkflow
        grdOrdenes.UpdateData()
    End Sub
End Class