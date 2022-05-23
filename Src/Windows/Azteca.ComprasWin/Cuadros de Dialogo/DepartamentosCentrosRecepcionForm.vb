Public Class DepartamentosCentrosRecepcionForm
    Private CentrosRecepcionTable As ConfiguracionDS.DepartamentosCentrosRecepcionDataTable
    Private _IdDepartamento As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal IdDepartamento As Integer) As DialogResult
        Dim DeptoFac As New DepartamentoFacade
        _IdDepartamento = IdDepartamento
        CentrosRecepcionTable = DeptoFac.CentrosRecepcionList(App.Session.SessionID, IdDepartamento)
        bsCentrosRecepcion.DataSource = CentrosRecepcionTable
        grdCentrosRecepcion.Rebind(True)
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnCentroRecepcionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentroRecepcionAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim CentroRecepFac As New CentroRecepcionFacade

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(CentroRecepFac, Nothing, True)
            For Each Id As String In lst
                Dim drExist As ConfiguracionDS.DepartamentosCentrosRecepcionRow = CentrosRecepcionTable.FindByIdCentroRecepcion(CInt(Id))
                If drExist Is Nothing Then
                    'Obtenemos los datos del usuario
                    Dim CtroRecepInfo As CentroRecepcionInfo = CentroRecepFac.GetDetail(App.Session.SessionID, CInt(Id))
                    Dim drNew As ConfiguracionDS.DepartamentosCentrosRecepcionRow = CentrosRecepcionTable.NewDepartamentosCentrosRecepcionRow
                    With drNew
                        .IdCentroRecepcion = CtroRecepInfo.Identity : .CentroRecepcion = CtroRecepInfo.Nombre
                    End With
                    CentrosRecepcionTable.AddDepartamentosCentrosRecepcionRow(drNew)
                Else
                    MessageBox.Show("El Centro de recepcion[" & drExist.CentroRecepcion & "] ya está incluido en el Departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim DeptoFac As New DepartamentoFacade
            DeptoFac.CentrosRecepcionSave(App.Session.SessionID, _IdDepartamento, CentrosRecepcionTable)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            MessageBox.Show("Se ha guardado la información", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCentrosRecepcion_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCentrosRecepcion.DeleteButtonClick
        Try
            Dim dv As New DataView(CentrosRecepcionTable, "IdCentroRecepcion=" & e.ID, "", DataViewRowState.CurrentRows)
            dv(0).Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class