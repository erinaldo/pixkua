Imports Azteca.Windows
Imports Azteca.Business.Ventas

Public Class ArticulosAdminForm
    Private ZonaVenta As ZonaVentaInfo

    Private Sub ArticulosAdminForm_AddingItem(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frmCaptura As New ArticulosExpressForm
            frmCaptura.ArticuloRow = ZonaVenta.Articulos.NewArticulosRow
            If frmCaptura.ShowDialog(0, "Agregar Articulo") = System.Windows.Forms.DialogResult.OK Then
                ZonaVenta.Articulos.AddArticulosRow(frmCaptura.ArticuloRow)
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

    Private Sub ArticulosAdminForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim ZonasVtaFac As New Azteca.Business.Ventas.ZonaVentaFacade
        ZonaVenta = ZonasVtaFac.GetDetail(Azteca.Windows.App.Session.SessionID, Context.UnidadNegocio.IdZonaVenta)
    End Sub

    Private Sub ArticulosAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim ArticuloFac As New Azteca.Business.Ventas.ArticuloFacade
            bsArticulos.DataSource = ArticuloFac.ListaExpress(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity)
            grdArticulos.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdArticulos_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdArticulos.ButtonClick
        If bsArticulos.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsArticulos.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar el articulo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim ArtFac As New Azteca.Business.Ventas.ArticuloFacade
                ArtFac.Delete(Azteca.Windows.App.Session.SessionID, CInt(row("IdArticulo")))
                bsArticulos.Remove(bsArticulos.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim NoExiste As Boolean
                Dim frm As New ArticulosExpressForm
                frm.ArticuloRow = ZonaVenta.Articulos.FindByIdArticuloStock(CInt(row("IdArticuloStock")))
                If IsNothing(frm.ArticuloRow) Then frm.ArticuloRow = ZonaVenta.Articulos.NewArticulosRow : NoExiste = True

                If frm.ShowDialog(CInt(row("IdArticulo")), "Editar Articulo...") = System.Windows.Forms.DialogResult.OK Then
                    If NoExiste Then ZonaVenta.Articulos.AddArticulosRow(frm.ArticuloRow)
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