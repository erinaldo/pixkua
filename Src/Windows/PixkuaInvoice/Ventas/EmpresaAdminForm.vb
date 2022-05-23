Imports Azteca.Windows

Public Class EmpresaAdminForm

    Private Sub EmpresaAdminForm_AddingItem(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frmCaptura As New ConfiguracionInicialForm
            frmCaptura.StartPosition = FormStartPosition.CenterScreen
            If frmCaptura.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub EmpresaAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim EmpresaFac As New Azteca.Kernel.Security.EmpresaFacade
            bsEmpresas.DataSource = EmpresaFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
            grdEmpresas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdEmpresas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdEmpresas.ButtonClick
        If bsEmpresas.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsEmpresas.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar la Empresa?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim EmpresaFac As New Azteca.Kernel.Security.EmpresaFacade
                EmpresaFac.Delete(App.Session.SessionID, CInt(row("IdEmpresa")))
                bsEmpresas.Remove(bsEmpresas.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New EmpresaExpressForm
                frm.StartPosition = FormStartPosition.CenterScreen

                If frm.ShowDialog(CInt(row("IdEmpresa")), "Editar Empresa...") = System.Windows.Forms.DialogResult.OK Then
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