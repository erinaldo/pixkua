Public Class UnidadesNegocioAdminForm


    Private Sub UnidadesNegocioAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim UnidadFac As New Azteca.Business.Ventas.UnidadNegocioFacade
            bsUnidad.DataSource = UnidadFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
            grdUnidades.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdUnidades_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdUnidades.ButtonClick
        If bsUnidad.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsUnidad.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar la Empresa?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                'Dim EmpresaFac As New Azteca.Kernel.Security.EmpresaFacade
                'EmpresaFac.Delete(App.Session.SessionID, CInt(row("IdEmpresa")))
                'bsUnidad.Remove(bsUnidad.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New Azteca.Windows.Ventas.UnidadesNegocioForm ' Azteca.Windows.Ventas.ClientesForm
                frm.StartPosition = FormStartPosition.CenterScreen

                If frm.ShowDialog(CInt(row("IdUnidadNegocio")), "Editar Unidad de Negocio...") = System.Windows.Forms.DialogResult.OK Then
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