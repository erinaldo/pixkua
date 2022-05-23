Public Class ListaDescuentosForm

    Private Sub ListaDescuentosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Try
            Dim GrupoDesctoFac As New GrupoDescuentosFacade

            Dim info As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)
            With info
                .ArticulosTable = GrupoDesctoFac.ArticulosLoad(App.Session.SessionID, 0)
                .ServiciosTable = GrupoDesctoFac.ServiciosLoad(App.Session.SessionID, 0)
                bsArticulos.DataSource = .ArticulosTable
                bsServicios.DataSource = .ServiciosTable
                bsClientes.DataSource = .ClientesTable
                grdArticulos.Rebind(True)
                grdServicios.Rebind(True)
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ListaDescuentosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)
        With info
            txtNombre.Text = .Nombre
            bsArticulos.DataSource = .ArticulosTable
            bsServicios.DataSource = .ServiciosTable
            grdArticulos.Rebind(True)
            grdServicios.Rebind(True)
        End With

    End Sub

    Private Sub ListaDescuentosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)
        With info
            .Nombre = txtNombre.Text
        End With
    End Sub

    Private Sub btnCtesRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtesRefresh.Click
        Try
            Dim info As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)

            Dim GrupoDesctoFac As New GrupoDescuentosFacade
            info.ClientesTable = GrupoDesctoFac.ClientesLoad(App.Session.SessionID, App.DefaultCompany.Identity, info.Identity)
            bsClientes.DataSource = info.ClientesTable
            grdClientes.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCtesAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtesAdd.Click
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)
                Dim CtesFac As New Azteca.Business.Ventas.ClienteFacade

                Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(CtesFac, Nothing, True)
                For Each IdCte As String In lst
                    Dim drExist As GrupoDescuentosDS.ClientesRow = info.ClientesTable.FindByIdCliente(CInt(IdCte))
                    If drExist Is Nothing Then
                        'Obtenemos el Cliente
                        Dim CteInfo As Azteca.Business.Ventas.ClienteInfo = CtesFac.GetDetail(App.Session.SessionID, CInt(IdCte))
                        Dim drNew As GrupoDescuentosDS.ClientesRow = info.ClientesTable.NewClientesRow
                        With drNew
                            .IdCliente = CteInfo.Identity : .Codigo = CteInfo.UserCode : .Nombre = CteInfo.Nombre : .Sucursal = ""
                        End With
                        info.ClientesTable.AddClientesRow(drNew)
                    Else
                        MessageBox.Show("El Cliente [" & drExist.Codigo & "] ya está incluido en el grupo de descuentos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Next
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información de el grupo de descuentos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCtesSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCtesSave.Click
        Try
            Dim info As GrupoDescuentosInfo = CType(Me.PackageInfo, GrupoDescuentosInfo)
            Dim ListaPrecioFac As New GrupoDescuentosFacade
            ListaPrecioFac.ClientesSave(App.Session.SessionID, info.Identity, info.ClientesTable)
            MessageBox.Show("La información correspondiente a los clientes ha sido actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class