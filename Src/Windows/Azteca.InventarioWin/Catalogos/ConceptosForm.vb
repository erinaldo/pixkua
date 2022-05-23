Public Class ConceptosForm

    Private Sub CargarConceptos(ByVal idClasificacion As Integer)
        Dim ClasificacionFac As New ClasificacionConceptoFacade
        Dim dtConceptos As DataTable = ClasificacionFac.CargarConceptos(App.Session.SessionID, idClasificacion)
        bsConceptos.DataSource = dtConceptos
        grdConceptos.Rebind(True)
    End Sub

    Private Sub ConceptosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        CargarConceptos(0)
    End Sub

    Private Sub ConceptosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConceptosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Clasificacion As ClasificacionConceptoInfo = CType(PackageInfo, ClasificacionConceptoInfo)
        With Clasificacion
            txtNombre.Text = .Nombre
            'Cargar la lista de conceptos asignados a esta clasificación
            CargarConceptos(.Identity)
        End With
    End Sub

    Private Sub ConceptosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Clasificacion As ClasificacionConceptoInfo = CType(PackageInfo, ClasificacionConceptoInfo)
        With Clasificacion
            .Nombre = txtNombre.Text
        End With
    End Sub

    Private Sub btnAddConcepto_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAddConcepto.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim Clasificacion As ClasificacionConceptoInfo = CType(PackageInfo, ClasificacionConceptoInfo)
        If Clasificacion.Identity > 0 Then
            Try
                cmdAddConcepto.Enabled = False
                Dim frmConcepto As New EditConceptoForm
                If frmConcepto.ShowDialog(Me, Clasificacion.Identity, 0) = System.Windows.Forms.DialogResult.OK Then
                    CargarConceptos(Clasificacion.Identity)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
                cmdAddConcepto.Enabled = True
            End Try
        Else
            MessageBox.Show("Primero debe guardar los datos de la clasificación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdConceptos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdConceptos.DeleteButtonClick
        Dim Clasificacion As ClasificacionConceptoInfo = CType(PackageInfo, ClasificacionConceptoInfo)
        If Clasificacion.Identity > 0 AndAlso bsConceptos.Current IsNot Nothing Then
            Dim Resp As DialogResult = MessageBox.Show("¿Esta seguro que desea eliminar el concepto?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim drConcepto As DataRowView = CType(bsConceptos.Current, DataRowView)
                    Dim ConceptoFac As New ConceptoFacade
                    ConceptoFac.Delete(App.Session.SessionID, CInt(drConcepto("IdConcepto")))
                    CargarConceptos(Clasificacion.Identity)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        Else
            MessageBox.Show("Debe seleccionar el concepto a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdConceptos_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdConceptos.EditButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim Clasificacion As ClasificacionConceptoInfo = CType(PackageInfo, ClasificacionConceptoInfo)
        If Clasificacion.Identity > 0 AndAlso bsConceptos.Current IsNot Nothing Then
            Try
                Dim drConcepto As DataRowView = CType(bsConceptos.Current, DataRowView)
                Dim frmConcepto As New EditConceptoForm
                If frmConcepto.ShowDialog(Me, Clasificacion.Identity, CInt(drConcepto("IdConcepto"))) = System.Windows.Forms.DialogResult.OK Then
                    CargarConceptos(Clasificacion.Identity)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar los datos de la clasificación y seleccionar el concepto a editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdConceptos_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdConceptos.FetchRowStyle
        Try
            Dim IdStatus As Integer = CInt(grdConceptos.Columns("IdStatus").CellValue(e.Row))
            If IdStatus = 0 Then e.CellStyle.BackColor = Drawing.Color.Moccasin
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub
End Class