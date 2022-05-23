Public Class CentrosProduccionForm

    Private Sub CentrosProduccionForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboImpresora.LoadList()
    End Sub

    Private Sub CentrosProduccionForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim info As CentroProduccionInfo = CType(Me.PackageInfo, CentroProduccionInfo)        
        bsArticulos.DataSource = info.ArticulosTable
        grdArt.Rebind(True)
    End Sub

    Private Sub CentrosProduccionForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CentroProduccionInfo = CType(Me.PackageInfo, CentroProduccionInfo)
        With info
            txtNombre.Text = .Nombre
            selCuenta.LoadInfo(.IdCuenta)
            cboImpresora.SelectedValue = .IdImpresora
            picMngrImage.SetImageBytes(.Imagen)
            'CboLineaProduccion=.idlinea
            'If Val(.Color) <> 0 Then
            '    lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(CInt(.Color))
            'Else
            '    lblColorBOX.BackColor = Drawing.Color.Transparent
            'End If
            bsArticulos.DataSource = info.ArticulosTable
            grdArt.Rebind(True)
        End With
    End Sub

    Private Sub CentrosProduccionForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CentroProduccionInfo = CType(Me.PackageInfo, CentroProduccionInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
            .IdImpresora = CInt(cboImpresora.SelectedValue)
            .Imagen = picMngrImage.GetImageBytes
            .IdLinea = 0
        End With
    End Sub

    Private Sub btnNuevoArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoArt.Click
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As CentroProduccionInfo = CType(Me.PackageInfo, CentroProduccionInfo)
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
                        MessageBox.Show("El articulo [" & drExist.Articulo & "] ya está incluido en el centro de producción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Next
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información de los Centros de producción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub grdArt_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArt.DeleteButtonClick
        Try
            Dim info As CentroProduccionInfo = CType(Me.PackageInfo, CentroProduccionInfo)
            grdArt.Delete()            
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class