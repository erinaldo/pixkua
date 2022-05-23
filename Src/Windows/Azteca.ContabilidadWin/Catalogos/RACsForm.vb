Public Class RACsForm
    Private frmItem As RACitem
    Private RacsTable As RacDetDS.RacDetDataTable

    Private Sub Agregar()
        'Mostramos la forma para capturar los datos de la nueva cuenta
        Dim Row As RacDetDS.RacDetRow = RacsTable.NewRacDetRow
        Row.IdRacTit = Me.PackageInfo.Identity : Row.Id = 0
        Dim frm As New RACitem
        If frm.ShowDialog(Me, Row) = System.Windows.Forms.DialogResult.OK Then
            Row.Orden = RacsTable.Rows.Count + 1
            RacsTable.AddRacDetRow(Row)
        End If
    End Sub

    Private Sub RACsForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        RacsTable = New RacDetDS.RacDetDataTable
        bsRac.DataSource = RacsTable
        grdRac.Rebind(True)
    End Sub

    Private Sub RACsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PolFac As New PolizaPerfilFacade
        cboPoliza.DisplayMember = "Descripcion" : cboPoliza.ValueMember = "Id" : cboPoliza.DataSource = PolFac.ListaCBO(App.Session.SessionID)

        Dim SegNeg As New SegmentoNegocioFacade
        cboSegmentoNegocio.DisplayMember = "Descripcion" : cboSegmentoNegocio.ValueMember = "Id" : cboSegmentoNegocio.DataSource = SegNeg.SegmentosNegocioCBO(App.Session.SessionID, App.DefaultCompany.Identity)

        frmItem = New RACitem
    End Sub

    Private Sub RACsForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As RacInfo = CType(Me.PackageInfo, RacInfo)
        With info
            txtNombre.Text = .Nombre
            cboPoliza.SelectedValue = .IdPolizaPerfil
            cboSegmentoNegocio.SelectedValue = .IdSegmentoNegocio
            RacsTable = .racDet
        End With
        bsRac.DataSource = RacsTable
        grdRac.Rebind(True)
    End Sub

    Private Sub RACsForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As RacInfo = CType(Me.PackageInfo, RacInfo)
        With info
            .Nombre = txtNombre.Text
            .IdPolizaPerfil = CInt(cboPoliza.SelectedValue)
            .IdSegmentoNegocio = CInt(cboSegmentoNegocio.SelectedValue)
            .IdSucursal = App.DefaultSite.Identity
            .Status = CatalogState.Active
            .RacDet = RacsTable
        End With
    End Sub

    Private Sub btnNuevoRac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoRac.Click
        Agregar()
    End Sub

    Private Sub grdRac_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdRac.DeleteButtonClick
        Try
            Dim info As RacInfo = CType(Me.PackageInfo, RacInfo)
            grdRac.Delete()            
            grdRac.Refresh()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdRac_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdRac.EditButtonClick
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As RacInfo = CType(Me.PackageInfo, RacInfo)

                Dim dv As New DataView(info.RacDet, "Id=" & e.ID, "", DataViewRowState.CurrentRows)
                Dim RacDetRow As RacDetDS.RacDetRow = CType(dv(0).Row, RacDetDS.RacDetRow)
                Dim frmRacItem As New RACitem
                If frmRacItem.ShowDialog(Me, RacDetRow) = DialogResult.OK Then

                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información del insumo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

End Class