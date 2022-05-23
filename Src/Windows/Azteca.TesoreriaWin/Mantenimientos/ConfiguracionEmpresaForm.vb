Public Class ConfiguracionEmpresaForm

#Region "Cajas"

    Private Sub CargaCajas()
        Dim CajaFac As New CajaFacade
        Dim CajasTable As ConfiguracionDS.CajasDataTable = CajaFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
        bsCajas.DataSource = CajasTable
        grdCajas.Rebind(True)

        cmdCajaNew.Enabled = True
        grdCajas.Enabled = True
    End Sub


    Private Sub btnCajas_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCajaActualizar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            CargaCajas()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdCajas_DeleteButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdCajas.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If MessageBox.Show("¿Esta seguro de eliminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim CentralFac As New CajaFacade
                CentralFac.Delete(App.Session.SessionID, e.ID)
                MessageBox.Show("El elemento ha sido eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargaCajas()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnCajasAdd_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCajaNew.Click
        Try
            Dim frm As New CajasForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, 0, "Agregar Nueva Caja") = System.Windows.Forms.DialogResult.OK Then
                CargaCajas()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCajas_EditButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdCajas.EditButtonClick
        Try
            Dim frm As New CajasForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, e.ID, "Editando Cajas") = System.Windows.Forms.DialogResult.OK Then
                CargaCajas()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Bancos"

    Private Sub CargaBancos()
        Dim BancoFac As New BancoFacade
        Dim BancosTable As DataTable = BancoFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
        bsBancos.DataSource = BancosTable
        grdBancos.Rebind(True)

        cmdBancoAdd.Enabled = True
        grdBancos.Enabled = True
    End Sub
    Private Sub btnBancosRefresh_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdBancoRefresh.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            CargaBancos()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdBancos_DeleteButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdBancos.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If MessageBox.Show("¿Esta seguro de eliminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim BancoFac As New BancoFacade
                BancoFac.Delete(App.Session.SessionID, e.ID)
                MessageBox.Show("El elemento ha sido eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargaBancos()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnBancosAdd_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdBancoAdd.Click
        Try
            Dim frm As New BancosForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, 0, "Agregar Nuevo Banco") = System.Windows.Forms.DialogResult.OK Then
                CargaBancos()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdBancos_EditButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdBancos.EditButtonClick
        Try
            Dim frm As New BancosForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, e.ID, "Editando Banco") = System.Windows.Forms.DialogResult.OK Then
                CargaBancos()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

End Class