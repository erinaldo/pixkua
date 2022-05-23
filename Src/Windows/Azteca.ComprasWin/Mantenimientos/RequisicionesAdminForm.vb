Public Class RequisicionesAdminForm
    Dim frmDocument As RequisicionesForm

    Private Sub RequisicionesAdminForm_AplyingWorkflow(sender As Object, e As Forms.BusinessForms.ApplyingWorkflowEventArgs) Handles Me.ApplyingWorkflow
        grdRequisiciones.UpdateData()
    End Sub
   
    Private Sub RequisicionesAdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub RequisicionesAdminForm_LoadingData(sender As Object, e As Forms.BusinessForms.LoadDataEventArgs) Handles Me.LoadingData
        Try
            Dim ReqFac As New RequisicionFacade
            Dim dtRequisiciones As DataTable = ReqFac.LoadList(App.Session.SessionID, Me.FechaIni, Me.FechaFin, App.Session.User.Identity, App.DefaultSite.Identity)
            bsRequisiciones.DataSource = dtRequisiciones
            grdRequisiciones.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub RequisicionesAdminForm_NewDocument(sender As Object, e As Forms.BusinessForms.NewDocumentEventArgs) Handles Me.AddingDocument
        Try
            Dim frmCaptura As New CapturaRequisicionesForm
            If frmCaptura.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                LoadData()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdRequisiciones_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdRequisiciones.ButtonClick
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dr As DataRowView = CType(bsRequisiciones.Current, DataRowView)
            Dim frm As New RequisicionesForm
            frm.LoadLists()
            frm.StartPosition = FormStartPosition.CenterParent
            frm.ShowDialog(CStr(dr("Id")), "Editando Requisicion")
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub RequisicionesAdminForm_SelectedStatusChanged(sender As Object, e As System.EventArgs) Handles Me.SelectedStatusChanged
        If SelectedStatus > 0 Then
            grdRequisiciones.Splits(0).DisplayColumns("Sel").Visible = True
        Else
            grdRequisiciones.Splits(0).DisplayColumns("Sel").Visible = False
        End If
    End Sub

    Private Sub RequisicionesAdminForm_CancelingWorkflow(sender As Object, e As Forms.BusinessForms.CancelingWorkflowEventArgs) Handles Me.CancelingWorkflow
        grdRequisiciones.UpdateData()
    End Sub
End Class