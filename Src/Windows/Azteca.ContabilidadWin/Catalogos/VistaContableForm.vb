Public Class VistaContableForm

    Private Sub btnNuevaEntidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VistaContableForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim info As VistaContableInfo = CType(Me.PackageInfo, VistaContableInfo)
        bsEntidades.DataSource = info.EntidadesTable
        grdEntidad.Rebind(True)
        bsImportes.DataSource = info.ImportesTable
        grdImportes.Rebind(True)
    End Sub

    Private Sub VistaContableForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As VistaContableInfo = CType(Me.PackageInfo, VistaContableInfo)
        With info
            txtDescripcion.Text = .Descripcion
            txtSchema.Text = .Schema
            txtObjeto.Text = .Objeto
            txtIdObjeto.Text = .IdObjeto
            txtReferencia.Text = .Referencia
            selTipoDocto.LoadInfo(.IdDocumentoTipo)
            bsEntidades.DataSource = .EntidadesTable
            grdEntidad.Rebind(True)
            bsImportes.DataSource = .ImportesTable
            grdImportes.Rebind(True)
        End With

    End Sub

    Private Sub VistaContableForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As VistaContableInfo = CType(Me.PackageInfo, VistaContableInfo)
        With info
            .Descripcion = txtDescripcion.Text
            .Schema = txtSchema.Text
            .Objeto = txtObjeto.Text
            .IdObjeto = txtIdObjeto.Text
            .Referencia = txtReferencia.Text
            .IdDocumentoTipo = selTipoDocto.Key
            .Status = CatalogState.Active
        End With
    End Sub

    Private Sub grdEntidad_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdEntidad.ButtonClick
        Try
            Dim info As VistaContableInfo = CType(Me.PackageInfo, VistaContableInfo)
            If e.Column.Name = "Entidad" Then
                Dim EntidadFac As New EntidadFacade
                Dim lst As Azteca.Kernel.Search.IdentityList = MsgList.Show(EntidadFac, Nothing, True)
                For Each IdEntidad As String In lst
                    Dim Entidad As EntidadInfo = EntidadFac.GetDetail(App.Session.SessionID, CInt(IdEntidad))

                    Dim dv As New DataView(info.EntidadesTable, "Columna='" & grdEntidad.Columns(colColumnaEnt.Index).Value & "'", "", DataViewRowState.CurrentRows)
                    dv(0)("Entidad") = Entidad.Entidad : dv(0)("IdEntidad") = Entidad.Identity
                Next
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdImportes_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdImportes.ButtonClick
        Try
            Dim info As VistaContableInfo = CType(Me.PackageInfo, VistaContableInfo)
            If e.Column.Name = "Importe" Then
                Dim ImporteFac As New ImporteFacade
                Dim lst As Azteca.Kernel.Search.IdentityList = MsgList.Show(ImporteFac, Nothing, True)
                For Each IdImporte As String In lst
                    Dim Importe As ImporteInfo = ImporteFac.GetDetail(App.Session.SessionID, CInt(IdImporte))

                    Dim dv As New DataView(info.ImportesTable, "Columna='" & grdImportes.Columns(colColumnaImp.Index).Value & "'", "", DataViewRowState.CurrentRows)
                    dv(0)("Importe") = Importe.Importe : dv(0)("IdImporte") = Importe.Identity
                Next
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class