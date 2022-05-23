Public Class ArticulosForm
    Private Color As String = ""

    Private Sub ArticulosForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        Me.PackageInfo.Status = Kernel.BusinessStructure.CatalogState.Active
    End Sub

    Private Sub ArticulosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As Azteca.Business.Restaurante.ArticuloInfo = CType(Me.PackageInfo, Azteca.Business.Restaurante.ArticuloInfo)
        With info
            txtNombre.Text = .ArticuloStock.Nombre
            cboTipoUnidad.SelectedValue = .ArticuloStock.IdTipoUnidadMedida
            cboUnidadMedida.SelectedValue = .ArticuloStock.IdUnidadMedida

            selCuenta.LoadInfo(.IdCuenta)
            cboCategorias.SelectedValue = .IdCategoria
            picMngrImage.SetImageBytes(.Imagen)
            If Val(.Color) <> 0 Then
                lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(.Color)
            Else
                lblColorBOX.BackColor = Drawing.Color.Transparent
            End If
           
        End With
    End Sub

    Private Sub ArticulosForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboTipoUnidad.LoadList()
        cboUnidadMedida.LoadList()
        If cboTipoUnidad.Items.Count > 0 Then cboTipoUnidad.SelectedIndex = 0
        cboCategorias.LoadList()
    End Sub

    Private Sub ArticulosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As Azteca.Business.Restaurante.ArticuloInfo = CType(Me.PackageInfo, Azteca.Business.Restaurante.ArticuloInfo)
        With info

            .IdCuenta = selCuenta.Key
            .IdCategoria = CInt(cboCategorias.SelectedValue)
            .Imagen = picMngrImage.GetImageBytes
            .Color = Color
            .ArticuloStock.Nombre = txtNombre.Text
            .ArticuloStock.IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
            .ArticuloStock.Status = .Status
            .ArticuloStock.StockMax = 1 : .ArticuloStock.StockMin = 1 : .ArticuloStock.PuntoReorden = 1
        End With
    End Sub

    Private Sub cmdColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColor.Click
        If dlgColor.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Color = dlgColor.Color.ToArgb.ToString
            lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(Color)
        End If
    End Sub


  
End Class