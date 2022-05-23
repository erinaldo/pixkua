Public Class CentrosConsumoForm

    Private Sub CentrosConsumoForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboCaja.LoadList()
    End Sub

    Private Sub CentrosConsumoForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Me.PackageInfo = New CentroConsumoInfo(App.Session.SessionID)
        Dim info As CentroConsumoInfo = CType(Me.PackageInfo, CentroConsumoInfo)        
        bsMesa.DataSource = info.Mesas
        grdMesas.Rebind(True)
    End Sub

    Private Sub CentrosConsumoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As CentroConsumoInfo = CType(Me.PackageInfo, CentroConsumoInfo)
        With info
            txtDescripcion.Text = .Nombre
            selCuenta.LoadInfo(.IdCuenta)
            cboCaja.SelectedValue = .IdCaja
            bsMesa.DataSource = info.Mesas
            grdMesas.Rebind(True)
        End With
    End Sub

    Private Sub CentrosConsumoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As CentroConsumoInfo = CType(Me.PackageInfo, CentroConsumoInfo)
        With info
            .Nombre = txtDescripcion.Text
            .IdCuenta = selCuenta.Key
            .IdCaja = CInt(cboCaja.SelectedValue)
        End With
    End Sub

    Private Sub btnNuevoArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoArt.Click
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As CentroConsumoInfo = CType(Me.PackageInfo, CentroConsumoInfo)
                Dim MesaFac As New Azteca.Business.Restaurante.MesaFacade

                Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(MesaFac, Nothing, True)
                For Each IdMesa As String In lst
                    Dim drExist As CentrosConsumoDS.MesasRow = info.Mesas.FindByIdMesa(CInt(IdMesa))
                    If drExist Is Nothing Then
                        'Obtenemos el articulo
                        Dim MesaInfo As Azteca.Business.Restaurante.MesaInfo = MesaFac.GetDetail(App.Session.SessionID, CInt(IdMesa))

                        Dim drNew As CentrosConsumoDS.MesasRow = info.Mesas.NewMesasRow
                        With drNew
                            .IdMesa = MesaInfo.Identity : .Mesa = MesaInfo.Descripcion
                        End With
                        info.Mesas.AddMesasRow(drNew)
                    Else
                        MessageBox.Show("El Mesa [" & drExist.Mesa & "] ya está incluido en el centro de consumo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Next
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información del centro de consumo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CajaCombobox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCaja.SelectedIndexChanged

    End Sub
End Class