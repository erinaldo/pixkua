Imports Azteca.Windows.Controls

Public Class UnidadesMedidaForm

    Private Sub CargarUnidadesMedida(ByVal idTipoUnidad As Integer)
        Dim TipoFac As New TipoUnidadMedidaFacade
        Dim dtUnidades As UnidadesMedidaDS.UnidadesMedidaDataTable = TipoFac.LoadUnidades(App.Session.SessionID, idTipoUnidad)
        bsUnidades.DataSource = dtUnidades
        grdUnidades.Rebind(True)
    End Sub

    Private Sub UnidadMedidaForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim dtUnidades As New UnidadesMedidaDS.UnidadesMedidaDataTable
        bsUnidades.DataSource = dtUnidades
        grdUnidades.Rebind(True)
    End Sub

    Private Sub UnidadMedidaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UnidadMedidaForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Tipo As TipoUnidadMedidaInfo = CType(PackageInfo, TipoUnidadMedidaInfo)
        With Tipo
            txtNombre.Text = .Nombre
        End With
        CargarUnidadesMedida(Tipo.Identity)
    End Sub

    Private Sub UnidadMedidaForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Tipo As TipoUnidadMedidaInfo = CType(PackageInfo, TipoUnidadMedidaInfo)
        With Tipo
            .Nombre = txtNombre.Text
        End With
    End Sub

    Private Sub btnNuevaUnidad_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAddUnidad.Click
        Dim Tipo As TipoUnidadMedidaInfo = CType(PackageInfo, TipoUnidadMedidaInfo)
        If Tipo.Identity > 0 Then
            Dim frmUnidad As New EditUnidadMedidaForm
            If frmUnidad.ShowDialog(Me, Tipo.Identity, 0) = System.Windows.Forms.DialogResult.OK Then
                CargarUnidadesMedida(Tipo.Identity)
            End If
        Else
            MessageBox.Show("Primero debe guardar los datos del tipo de unidad de medida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub grdUnidades_DeleteButtonClick(ByVal sender As Object, ByVal e As GridViewCatalogButtonEventArgs) Handles grdUnidades.DeleteButtonClick
        Dim Tipo As TipoUnidadMedidaInfo = CType(PackageInfo, TipoUnidadMedidaInfo)
        If Tipo.Identity > 0 AndAlso bsUnidades.Current IsNot Nothing Then
            Dim Resp As DialogResult = MessageBox.Show("¿Esta seguro que desea eliminar la unidad seleccionada?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim drUnidad As UnidadesMedidaDS.UnidadesMedidaRow = CType(CType(bsUnidades.Current, DataRowView).Row, UnidadesMedidaDS.UnidadesMedidaRow)
                    Dim UnidadFac As New UnidadMedidaFacade
                    UnidadFac.Delete(App.Session.SessionID, drUnidad.IdUnidadMedida)
                    CargarUnidadesMedida(Tipo.Identity)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        Else
            MessageBox.Show("Debe seleccionar el almacén a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdUnidades_EditButtonClick(ByVal sender As Object, ByVal e As GridViewCatalogButtonEventArgs) Handles grdUnidades.EditButtonClick
        Dim Tipo As TipoUnidadMedidaInfo = CType(PackageInfo, TipoUnidadMedidaInfo)
        If Tipo.Identity > 0 AndAlso bsUnidades.Current IsNot Nothing Then
            Dim drUnidad As UnidadesMedidaDS.UnidadesMedidaRow = CType(CType(bsUnidades.Current, DataRowView).Row, UnidadesMedidaDS.UnidadesMedidaRow)
            Dim frmUnidad As New EditUnidadMedidaForm
            If frmUnidad.ShowDialog(Me, Tipo.Identity, drUnidad.IdUnidadMedida) = System.Windows.Forms.DialogResult.OK Then
                CargarUnidadesMedida(Tipo.Identity)
            End If
        Else
            MessageBox.Show("No ha guardado los datos del tipo de unidad o no ha seleccionado la unidad de medida a editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdUnidades_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdUnidades.FetchRowStyle
        Try
            Dim IdStatus As Integer = CInt(grdUnidades.Columns("IdStatus").CellValue(e.Row))
            If IdStatus = 0 Then e.CellStyle.BackColor = Drawing.Color.Moccasin
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class