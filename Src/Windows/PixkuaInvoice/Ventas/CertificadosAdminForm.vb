Imports Azteca.Windows

Public Class CertificadosAdminForm

    Private Sub CertificadosAdminForm_AddingItem(sender As Object, e As Azteca.Windows.Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frmCaptura As New Azteca.Windows.Contabilidad.CertificadosForm
            frmCaptura.StartPosition = FormStartPosition.CenterScreen
            If frmCaptura.ShowDialog(0, "Alta de Certificado") = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub CertificadosAdminForm_LoadingData(sender As Object, e As Azteca.Windows.Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Dim CertificadoFac As New Azteca.Business.Contabilidad.CertificadoFacade
        bsCertificados.DataSource = CertificadoFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
        grdCertificados.Rebind(True)
    End Sub

    Private Sub grdCertificados_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCertificados.ButtonClick
        If bsCertificados.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsCertificados.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar el Certificado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim CertificadoFac As New Azteca.Business.Contabilidad.CertificadoFacade
                CertificadoFac.Delete(App.Session.SessionID, CInt(row("IdCFDCertificado")))
                bsCertificados.Remove(bsCertificados.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New Azteca.Windows.Contabilidad.CertificadosForm
                frm.StartPosition = FormStartPosition.CenterScreen

                If frm.ShowDialog(CInt(row("IdCFDCertificado")), "Editar Certificado...") = System.Windows.Forms.DialogResult.OK Then
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