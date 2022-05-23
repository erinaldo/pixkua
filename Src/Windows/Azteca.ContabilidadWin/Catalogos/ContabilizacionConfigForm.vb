Public Class ContabilizacionConfigForm

    Private Sub ContabilizacionConfigForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        grdWorkflow.DataSource = Nothing
        cboVista.Enabled = True
    End Sub

    Private Sub ContabilizacionConfigForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdWorkflow.AutoGenerateColumns = False

        Dim VistaFac As New VistaContableFacade
        cboVista.DisplayMember = "Descripcion" : cboVista.ValueMember = "Id" : cboVista.DataSource = VistaFac.LoadList(App.Session.SessionID, 0)

    End Sub

    Private Sub grdWorkflow_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdWorkflow.CellClick
        Dim info As ContabilizadorDocumentosInfo = CType(Me.PackageInfo, ContabilizadorDocumentosInfo)
        If e.ColumnIndex = colRac.Index Then
            Dim RacWorkform As New RacWorkflowForm
            Dim row As DataGridViewRow = CType(grdWorkflow.CurrentRow, DataGridViewRow)

            Dim dv As New DataView(info.WorkflowTable, "IdStatus=" & row.Cells("colIdStatus").Value, "", DataViewRowState.CurrentRows)

            'Si esta seleccionado lo de variantes
            If CInt(row.Cells(colVariantes.Index).Value) Then
                Dim IdContabilizacionDocumentoDet As Integer = CInt(row.Cells(colIdContabilizacionDocumentoDet.Index).Value)
                If IdContabilizacionDocumentoDet = 0 Then
                    MessageBox.Show("Debe guardar la información antes de poder configurar los Racs Variantes", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
                If RacWorkform.ShowDialog(Me, info.IdVistaContableTit, IdContabilizacionDocumentoDet) = System.Windows.Forms.DialogResult.OK Then
                    dv(0)("Rac") = "Variante" : dv(0)("IdRacTit") = 0
                End If

            Else
                Dim RacFac As New RacFacade
                Dim lst As Azteca.Kernel.Search.IdentityList = MsgList.Show(RacFac, Nothing, True)
                For Each IdRac As String In lst
                    'Validamos el RAC
                    Dim Vista As New VistaContableFacade
                    Dim strEntidades As String = Vista.ValidaRac(App.Session.SessionID, CInt(cboVista.SelectedValue), CInt(IdRac))
                    If strEntidades.Length > 0 Then
                        MessageBox.Show("Se prentende asignar un RAC que hace referencia a Entidades que no se encuentran incluidas en la Vista Contable:" & ControlChars.CrLf & _
                                        Replace(strEntidades, ",", ControlChars.CrLf), "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Else
                        Dim rac As RacInfo = RacFac.GetDetail(App.Session.SessionID, CInt(IdRac))
                        dv(0)("Rac") = rac.Nombre : dv(0)("IdRacTit") = rac.Identity : dv(0)("Variante") = 0
                    End If
                Next

            End If

        End If

    End Sub

    Private Sub ContabilizacionConfigForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As ContabilizadorDocumentosInfo = CType(Me.PackageInfo, ContabilizadorDocumentosInfo)
        With info
            cboVista.SelectedValue = .IdVistaContableTit
            cboVista.Enabled = False
            grdWorkflow.DataSource = .WorkflowTable
        End With
    End Sub

    Private Sub ContabilizacionConfigForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As ContabilizadorDocumentosInfo = CType(Me.PackageInfo, ContabilizadorDocumentosInfo)
        With info
            'Obtenemos el documento tipo del q se deriva esta vista de datos para traernos su workflow
            Dim dv As New DataView(CType(cboVista.DataSource, DataTable), "Id=" & CInt(cboVista.SelectedValue), "", DataViewRowState.CurrentRows)
            .IdDocumentoTipo = CInt(dv(0)("IdDocumentoTipo"))
            .IdVistaContableTit = CInt(cboVista.SelectedValue)
        End With
    End Sub

    Protected Overrides Function IsValid() As Boolean
        grdWorkflow.Update()
        Return MyBase.IsValid()
    End Function

    Private Sub cboVista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVista.SelectedIndexChanged
        Dim info As ContabilizadorDocumentosInfo = CType(Me.PackageInfo, ContabilizadorDocumentosInfo)
        If info.Identity = 0 Then
            Dim Fac As New ContabilizadorDocumentosFacade
            'Obtenemos el documento tipo del q se deriva esta vista de datos para traernos su workflow
            Dim dv As New DataView(CType(cboVista.DataSource, DataTable), "Id=" & CInt(cboVista.SelectedValue), "", DataViewRowState.CurrentRows)
            Dim IdDocumentoTipo As Integer = CInt(dv(0)("IdDocumentoTipo"))
            Fac.loadWorkflowNew(App.Session.SessionID, IdDocumentoTipo, info)
            grdWorkflow.DataSource = info.WorkflowTable
        End If

    End Sub

End Class