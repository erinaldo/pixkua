Imports Azteca.Windows

Public Class ListaPreciosAdminForm

    Private Sub ListaPreciosAdminForm_AddingItem(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frmCaptura As New Azteca.Windows.Ventas.ListaPreciosForm
            If frmCaptura.ShowDialog(0, "Agregar Lista de Precios") = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ListaPreciosAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim ListasFac As New Azteca.Business.Ventas.ListaPreciosFacade
            bsLista.DataSource = ListasFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
            grdListas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub



    Private Sub grdListas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdListas.ButtonClick
        If bsLista.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsLista.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar la Lista de Precio?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim ListaFac As New Azteca.Business.Ventas.ListaPreciosFacade
                ListaFac.Delete(App.Session.SessionID, CInt(row("IdListaPrecio")))
                bsLista.Remove(bsLista.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New Azteca.Windows.Ventas.ListaPreciosForm
                If frm.ShowDialog(CInt(row("IdListaPrecio")), "Editar Lista de Precio...") = System.Windows.Forms.DialogResult.OK Then
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