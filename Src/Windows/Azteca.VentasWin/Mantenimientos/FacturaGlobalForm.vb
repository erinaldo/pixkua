Imports Azteca.Business.Contabilidad

Public Class FacturaGlobalForm
    Private VentaFac As VentaFacade

    Private Sub CargarLista()
        Dim dtFacturas As DataTable = VentaFac.CargarFacturasGlobales(App.Session.SessionID, App.DefaultSite.Identity, dtpFechaIni.Value, dtpFechaFin.Value)
        bsFacturas.DataSource = dtFacturas
        bsFacturas.Sort = "Fecha DESC"
        grdFacturas.Rebind(True)
    End Sub

    Private Sub FacturaGlobalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            VentaFac = New VentaFacade
            dtpFechaIni.Value = Date.Today.AddDays(-15)
            dtpFechaFin.Value = Date.Today
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCargar.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            CargarLista()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cmdNuevaFactura_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdNuevaFactura.Click
        Dim frmNueva As New NuevaFacturaGlobalForm
        If frmNueva.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub


    Private Sub grdFacturas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdFacturas.ButtonClick
        If e.Column.Name = "X" Then
            Dim Resp As DialogResult = MessageBox.Show("¿Está seguro que desea cancelar la factura global?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    Cursor.Current = Cursors.WaitCursor
                    Dim IdVenta As String = grdFacturas.Columns("Folio").Text
                    VentaFac.CancelWorkflow(App.Session.SessionID, IdVenta, WorkflowSteps.Invoice)
                    MessageBox.Show("La factura ha sido cancelada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarLista()
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    Cursor.Current = Cursors.Default
                End Try

            End If
        End If
    End Sub
End Class