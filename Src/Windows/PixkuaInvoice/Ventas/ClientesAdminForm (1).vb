Imports Azteca.Windows

Public Class ClientesAdminForm

    Private Sub ClientesAdminForm_AddingItem(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frmCaptura As New ClienteExpressForm
            frmCaptura.StartPosition = FormStartPosition.CenterScreen
            If frmCaptura.ShowDialog(Me, 0, "Agregar Cliente") = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ClientesAdminForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClientesAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Dim ClienteFac As New Azteca.Business.Ventas.ClienteFacade
        bsClientes.DataSource = ClienteFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
        grdClientes.Rebind(True)
    End Sub

    Private Sub ClientesAdminForm_PrintingCatalogList(sender As Object, e As Azteca.Windows.Forms.BusinessForms.PrintDocumentEventArgs) Handles Me.PrintingCatalogList

    End Sub

    Private Sub grdClientes_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdClientes.ButtonClick
        If bsClientes.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsClientes.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar el Cliente?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim ClienteFac As New Azteca.Business.Ventas.ClienteFacade
                ClienteFac.Delete(App.Session.SessionID, CInt(row("IdCliente")))
                bsClientes.Remove(bsClientes.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New ClienteExpressForm ' Azteca.Windows.Ventas.ClientesForm
                frm.StartPosition = FormStartPosition.CenterScreen

                If frm.ShowDialog(CInt(row("IdCliente")), "Editar Cliente...") = System.Windows.Forms.DialogResult.OK Then
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