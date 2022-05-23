Public Class CategoriasForm
    Private Color As String = ""

    Private Sub CategoriasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim info As CategoriaInfo = CType(Me.PackageInfo, CategoriaInfo)        
        bsArticulos.DataSource = info.ArticulosTable
        grdArt.Rebind(True)
    End Sub

    Private Sub CategoriasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CategoriaInfo = CType(Me.PackageInfo, CategoriaInfo)
        With info
            txtNombre.Text = .Nombre
            selCuenta.LoadInfo(.IdCuenta)
            picMngrImage.SetImageBytes(.Imagen)
            If Val(.Color) <> 0 Then
                lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(.Color)
            Else
                lblColorBOX.BackColor = Drawing.Color.Transparent
            End If
        End With
        bsArticulos.DataSource = info.ArticulosTable
        grdArt.Rebind(True)
    End Sub

    Private Sub CategoriasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CategoriaInfo = CType(Me.PackageInfo, CategoriaInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
            .Imagen = picMngrImage.GetImageBytes
            .Color = Color
        End With
    End Sub

    Private Sub cmdColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColor.Click
        If dlgColor.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Color = dlgColor.Color.ToArgb.ToString
            lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(Color)
        End If
    End Sub

    Private Sub btnNuevoArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoArt.Click
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As CategoriaInfo = CType(Me.PackageInfo, CategoriaInfo)
                Dim ArtFac As New Azteca.Business.Restaurante.ArticuloFacade

                Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(ArtFac, Nothing, True)
                For Each IdArt As String In lst
                    Dim drExist As ArticulosConfigDS.CentroProduccionArticuloRow = info.ArticulosTable.FindByIdArticulo(CInt(IdArt))
                    If drExist Is Nothing Then
                        'Obtenemos el articulo
                        Dim ArtInfo As Azteca.Business.Restaurante.ArticuloInfo = ArtFac.GetDetail(App.Session.SessionID, CInt(IdArt))
                        Dim drNew As ArticulosConfigDS.CentroProduccionArticuloRow = info.ArticulosTable.NewCentroProduccionArticuloRow
                        With drNew
                            .IdArticulo = ArtInfo.Identity : .Articulo = ArtInfo.ArticuloStock.Nombre
                        End With
                        info.ArticulosTable.AddCentroProduccionArticuloRow(drNew)
                    Else
                        MessageBox.Show("El articulo [" & drExist.Articulo & "] ya está incluido en la categoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Next
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información de los Categoria.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub gbxDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbxDetalle.Enter

    End Sub
End Class