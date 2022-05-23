Public Class RegletasListForm

    Private Sub RegletasListForm_AddingItem(sender As Object, e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frm As New RegletasForm
            frm.StartPosition = FormStartPosition.CenterScreen
            If frm.ShowDialog(0, "Alta de Regleta") = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub RegletasListForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Dim RegletaFac As New RegletaFacade
        bsRegletas.DataSource = RegletaFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
        grdRegletas.Rebind(True)
    End Sub

    Private Sub grdRegletas_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdRegletas.ButtonClick
        If bsRegletas.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsRegletas.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar la regleta?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim RegletaFac As New RegletaFacade
                RegletaFac.Delete(App.Session.SessionID, CInt(row("IdRegleta")))
                bsRegletas.Remove(bsRegletas.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New RegletasForm
                frm.StartPosition = FormStartPosition.CenterScreen
                If frm.ShowDialog(CInt(row("IdRegleta")), "Editar Regleta...") = System.Windows.Forms.DialogResult.OK Then
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