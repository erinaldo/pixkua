Public Class RacWorkflowForm
    Public Property IdVistaContableTit As Integer
    Public Property IdContabilizadorDocumentoDet As Integer
    Private dtWorkflow As DataTable
    Private dtFiltros As DataTable
    Private CargandoFiltro As Boolean = False

    Public Overloads Function ShowDialog(ByVal owner As System.Windows.Forms.Form, ByVal IdVistaContableTit As Integer, ByVal IdContabilizadorDocumentoDet As Integer) As DialogResult

        _IdContabilizadorDocumentoDet = IdContabilizadorDocumentoDet
        _IdVistaContableTit = IdVistaContableTit
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarEntidad.Click
        Dim ConTabilizadorFac As New ContabilizadorDocumentosFacade
        dtWorkflow = ConTabilizadorFac.VariantesStatus(App.Session.SessionID, IdVistaContableTit, IdContabilizadorDocumentoDet)
        grdEntidades.AutoGenerateColumns = False : grdEntidades.DataSource = dtWorkflow
    End Sub

    Private Sub btnGuardarEntidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarEntidad.Click
        If MessageBox.Show("Aplicar este cambio provocará que se actualicen todas las combinaciones que resultarán de estas entidades." & ControlChars.CrLf & _
                           "¿Desea continuar de cualquier forma?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim ConTabilizadorFac As New ContabilizadorDocumentosFacade
                ConTabilizadorFac.CombinacionesSave(App.Session.SessionID, IdContabilizadorDocumentoDet, dtWorkflow)
                MessageBox.Show("Se han ajustado las Entidades" & ControlChars.CrLf & "Debe revisar las combinaciones para realizar las modificaciones correspondientes", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub btnActualizarComb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarComb.Click
        Try
            CargandoFiltro = True
            Dim ConTabilizadorFac As New ContabilizadorDocumentosFacade
            dtFiltros = ConTabilizadorFac.Filtrosload(App.Session.SessionID, IdContabilizadorDocumentoDet)
            grdFiltros.DataSource = dtFiltros
            formatearGrid()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            CargandoFiltro = False
        End Try
    End Sub

    Private Sub formatearGrid()
        For Each col As DataGridViewColumn In grdFiltros.Columns
            If col.Name = "IdContabilizacionFiltro" Or col.Name = "Filtro" Or col.Name = "IdRacTit" Or col.Name = "Rac" Or col.Name = "Pivote" Then
                col.MinimumWidth = 2 : col.Width = 2 : col.Visible = False
            End If
        Next
    End Sub

    Private Sub grdFiltros_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFiltros.CellClick

        Try
            Dim row As DataGridViewRow = CType(grdFiltros.CurrentRow, DataGridViewRow)
            Dim dv As New DataView(dtFiltros, "Filtro='" & row.Cells("Filtro").Value & "'", "", DataViewRowState.CurrentRows)

            Dim RacFac As New RacFacade
            Dim lst As Azteca.Kernel.Search.IdentityList = MsgList.Show(RacFac, Nothing, True)
            For Each IdRac As String In lst
                'Validamos el RAC
                Dim Vista As New VistaContableFacade
                Dim strEntidades As String = Vista.ValidaRac(App.Session.SessionID, IdVistaContableTit, CInt(IdRac))
                If strEntidades.Length > 0 Then
                    MessageBox.Show("Se prentende asignar un RAC que hace referencia a Entidades que no se encuentran incluidas en la Vista Contable:" & ControlChars.CrLf & _
                                    Replace(strEntidades, ",", ControlChars.CrLf), "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If

                Dim rac As RacInfo = RacFac.GetDetail(App.Session.SessionID, CInt(IdRac))
                dv(0)("Rac") = rac.Nombre : dv(0)("IdRacTit") = rac.Identity
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnGuardarComb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarComb.Click
        Try
            Dim ConTabilizadorFac As New ContabilizadorDocumentosFacade
            ConTabilizadorFac.FiltrosSave(App.Session.SessionID, IdContabilizadorDocumentoDet, dtFiltros)
            MessageBox.Show("Se han guardado los datos correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class