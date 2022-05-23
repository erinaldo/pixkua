Imports Azteca.Business.Ventas

Public Class ServiciosAdminForm
    Private ZonaVenta As ZonaVentaInfo

    Private Sub ServiciosAdminForm_AddingItem(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frmCaptura As New ServiciosExpressForm
            frmCaptura.ServicioRow = ZonaVenta.Servicios.NewServiciosRow
            If frmCaptura.ShowDialog(0, "Agregar Servicio") = System.Windows.Forms.DialogResult.OK Then
                ZonaVenta.Servicios.AddServiciosRow(frmCaptura.ServicioRow)
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim ZonasVtaFac As New Azteca.Business.Ventas.ZonaVentaFacade
                ZonasVtaFac.Update(ZonaVenta)
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ServiciosAdminForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim ZonasVtaFac As New Azteca.Business.Ventas.ZonaVentaFacade
        ZonaVenta = ZonasVtaFac.GetDetail(Azteca.Windows.App.Session.SessionID, Context.UnidadNegocio.IdZonaVenta)
    End Sub

    Private Sub ServiciosAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim ServicioFac As New Azteca.Business.Ventas.ServicioFacade
            bsServicios.DataSource = ServicioFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
            grdServicios.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdServicios.ButtonClick
        If bsServicios.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsServicios.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar el servicio?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim ServFac As New Azteca.Business.Ventas.ServicioFacade
                ServFac.Delete(Azteca.Windows.App.Session.SessionID, CInt(row("IdServicio")))
                bsServicios.Remove(bsServicios.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim NoExiste As Boolean
                Dim frm As New ServiciosExpressForm
                frm.ServicioRow = ZonaVenta.Servicios.FindByIdServicio(CInt(row("IdServicio")))
                If IsNothing(frm.ServicioRow) Then frm.ServicioRow = ZonaVenta.Servicios.NewServiciosRow : NoExiste = True
                If frm.ShowDialog(CInt(row("IdServicio")), "Editar Servicio...") = System.Windows.Forms.DialogResult.OK Then
                    If NoExiste Then ZonaVenta.Servicios.AddServiciosRow(frm.ServicioRow)
                    Dim ZonasVtaFac As New Azteca.Business.Ventas.ZonaVentaFacade
                    ZonasVtaFac.Update(ZonaVenta)
                    LoadData()
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub


End Class