Public Class ColoresListForm

    Private Sub ColoresListForm_AddingItem(sender As Object, e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingItem
        Try
            Dim frm As New ColoresForm
            frm.StartPosition = FormStartPosition.CenterScreen
            If frm.ShowDialog(0, "Alta de Colores") = System.Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub ColoresListForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Dim ColoresFac As New ColorFacade
        bsColores.DataSource = ColoresFac.GetSearchResult(Azteca.Windows.App.Session.SessionID, Azteca.Windows.App.DefaultSite.Identity, Nothing, Nothing).Tables(0)
        grdColores.Rebind(True)
    End Sub

    Private Sub grdColores_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdColores.ButtonClick
        If bsColores.Current Is Nothing Then Exit Sub

        Dim row As DataRowView = CType(bsColores.Current, DataRowView)

        Try
            If e.Column.DataColumn.Caption = "X" Then
                If MessageBox.Show("¿Está usted seguro de eliminar el Color?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Cancel Then Exit Sub
                Dim ColorFac As New ColorFacade
                ColorFac.Delete(App.Session.SessionID, CInt(row("IdColor")))
                bsColores.Remove(bsColores.Current)
            ElseIf e.Column.DataColumn.Caption = "" Then
                Dim frm As New ColoresForm
                frm.StartPosition = FormStartPosition.CenterScreen
                If frm.ShowDialog(CInt(row("IdColor")), "Editar Color...") = System.Windows.Forms.DialogResult.OK Then
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