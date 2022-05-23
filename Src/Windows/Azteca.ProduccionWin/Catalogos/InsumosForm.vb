Public Class InsumosForm

    Private Sub btnNuevoArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoArt.Click

        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As InsumoInfo = CType(Me.PackageInfo, InsumoInfo)
                Dim ArticuloRow As InsumosArticulosDS.InsumosArticulosRow = info.ArticulosTable.NewInsumosArticulosRow
                Dim frmArticuloSel As New InsumosArticulosSelForm
                If frmArticuloSel.ShowDialog(Me, ArticuloRow) = DialogResult.OK Then
                    Dim drExist As InsumosArticulosDS.InsumosArticulosRow = info.ArticulosTable.FindByIdArticuloStock(frmArticuloSel.ArticuloRow.IdArticuloStock)
                    If drExist Is Nothing Then
                        info.ArticulosTable.AddInsumosArticulosRow(frmArticuloSel.ArticuloRow)
                    Else
                        MessageBox.Show("El articulo [" & drExist.ArticuloStock & "] ya está incluido en el insumo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
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

    Private Sub InsumosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim info As InsumoInfo = CType(Me.PackageInfo, InsumoInfo)
        bsArticulos.DataSource = info.ArticulosTable
        grdArt.Rebind(True)
    End Sub

    Private Sub InsumosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As InsumoInfo = CType(Me.PackageInfo, InsumoInfo)
        With info
            txtDescripcion.Text = .Nombre
            selCuenta.LoadInfo(.IdCuenta)
            cboUnidadMedida.SelectedValue = .IdUnidadMedida

        End With
        bsArticulos.DataSource = info.ArticulosTable
        grdArt.Rebind(True)
    End Sub

    Private Sub InsumosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As InsumoInfo = CType(Me.PackageInfo, InsumoInfo)
        With info
            .Nombre = txtDescripcion.Text
            .IdCuenta = selCuenta.Key
            .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
        End With

    End Sub

    Private Sub InsumosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboUnidadMedida.LoadList()
    End Sub

    Private Sub grdArt_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArt.DeleteButtonClick
        Try
            Dim info As InsumoInfo = CType(Me.PackageInfo, InsumoInfo)
            grdArt.Delete()            
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class