Public Class ListaPreciosForm

    Private Function GetGridFilter(grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid) As String
        Dim sb As New System.Text.StringBuilder()
        For Each col As C1.Win.C1TrueDBGrid.C1DataColumn In grid.Columns
            If col.FilterText.Trim = String.Empty Then Continue For
            If sb.Length > 0 Then sb.Append(" AND ")
            sb.Append(col.DataField & " like '" & col.FilterText & "%'")
        Next
        Return sb.ToString
    End Function

    Private Sub CargarClientes()
        Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)

        Dim ListaPrecioFac As New ListaPreciosFacade
        info.ClientesTable = ListaPrecioFac.ClientesLoad(App.Session.SessionID, App.DefaultCompany.Identity, info.Identity)
        bsClientes.DataSource = info.ClientesTable
        grdClientes.Rebind(True)
    End Sub

    Private Sub ListaPreciosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Try
            Dim ListaPrecioFac As New ListaPreciosFacade

            Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
            With info
                .ArticulosTable = ListaPrecioFac.ArticulosLoad(App.Session.SessionID, 0)
                .ServiciosTable = ListaPrecioFac.ServiciosLoad(App.Session.SessionID, 0)
                'Agregar columna para soporte de filas modificadas
                Dim colArtUpdate As New DataColumn("Updated", GetType(Boolean))
                colArtUpdate.DefaultValue = False
                '
                Dim colSvcUpdate As New DataColumn("Updated", GetType(Boolean))
                colSvcUpdate.DefaultValue = False
                '
                .ArticulosTable.Columns.Add(colArtUpdate)
                .ServiciosTable.Columns.Add(colSvcUpdate)

                bsArticulos.DataSource = .ArticulosTable
                bsServicios.DataSource = .ServiciosTable
                grdArticulos.Rebind(True)
                grdServicios.Rebind(True)
                CargarClientes()
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ListaPreciosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DivisaFac As New Business.Contabilidad.DivisaFacade
        Dim DivisasTable As DataTable = DivisaFac.LoadList(App.Session.SessionID)
        bsDivisasArt.DataSource = DivisasTable
        dropDivisaArt.DataSource = bsDivisasArt
        dropDivisaArt.Rebind(True)

        bsDivisaSvc.DataSource = DivisasTable
        dropDivisaSvc.DataSource = bsDivisasArt
        dropDivisaSvc.Rebind(True)

    End Sub

    Private Sub ListaPreciosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
        With info
            txtNombre.Text = .Nombre
            'Agregar columna para soporte de filas modificadas
            Dim colArtUpdate As New DataColumn("Updated", GetType(Boolean))
            colArtUpdate.DefaultValue = False
            '
            Dim colSvcUpdate As New DataColumn("Updated", GetType(Boolean))
            colSvcUpdate.DefaultValue = False
            '
            .ArticulosTable.Columns.Add(colArtUpdate)
            .ServiciosTable.Columns.Add(colSvcUpdate)
            '
            bsArticulos.DataSource = .ArticulosTable
            bsServicios.DataSource = .ServiciosTable
            grdArticulos.Rebind(True)
            grdServicios.Rebind(True)
            CargarClientes()
        End With

    End Sub

    Private Sub ListaPreciosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        txtNombre.Focus()
        Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
        With info
            .Nombre = txtNombre.Text
        End With

    End Sub

    Private Sub grdArticulos_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdArticulos.BeforeColUpdate
        grdArticulos.Columns("Updated").Value = True
    End Sub

    Private Sub grdArticulos_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            If CBool(grdArticulos.Columns("Updated").CellValue(e.Row)) = True Then
                e.CellStyle.BackColor = Drawing.Color.LightGreen
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAddCustomer_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAddCustomer.Click
        If PackageInfo.Identity > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
                Dim CtesFac As New Azteca.Business.Ventas.ClienteFacade

                Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(CtesFac, Nothing, True)
                For Each IdCte As String In lst
                    Dim drExist As ListaPreciosDS.ClientesRow = info.ClientesTable.FindByIdCliente(CInt(IdCte))
                    If drExist Is Nothing Then
                        'Obtenemos el Cliente
                        Dim CteInfo As Azteca.Business.Ventas.ClienteInfo = CtesFac.GetDetail(App.Session.SessionID, CInt(IdCte))
                        Dim drNew As ListaPreciosDS.ClientesRow = info.ClientesTable.NewClientesRow
                        With drNew
                            .IdCliente = CteInfo.Identity : .Codigo = CteInfo.UserCode : .Nombre = CteInfo.Nombre : .Sucursal = ""
                        End With
                        info.ClientesTable.AddClientesRow(drNew)
                    Else
                        MessageBox.Show("El Cliente [" & drExist.Codigo & "] ya está incluido en la lista de precios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                Next
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar la información de la lista de precios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdSaveClientes_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSaveClientes.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
            Dim ListaPrecioFac As New ListaPreciosFacade
            ListaPrecioFac.ClientesSave(App.Session.SessionID, info.Identity, info.ClientesTable)
            MessageBox.Show("La información correspondiente a los clientes ha sido actualizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdServicios_BeforeColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdServicios.BeforeColUpdate
        grdServicios.Columns("Updated").Value = True
    End Sub

    Private Sub grdServicios_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        Try
            If CBool(grdServicios.Columns("Updated").CellValue(e.Row)) = True Then
                e.CellStyle.BackColor = Drawing.Color.LightGreen
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAsignarArt_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAsignarArt.Click
        Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
        Try
            Dim frmEdit As New EditPrecioForm
            If frmEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If frmEdit.RangoAplicacion = "S" Then
                    For Each rowIndex As Integer In grdArticulos.SelectedRows
                        Dim IdArticuloStock As Integer = CInt(grdArticulos.Columns("IdArticuloStock").CellValue(rowIndex))
                        Dim dr As ListaPreciosDS.ArticulosRow = info.ArticulosTable.FindByIdArticuloStock(IdArticuloStock)
                        dr.Precio = frmEdit.Precio
                        dr.IdDivisa = frmEdit.IdDivisa
                        dr("Updated") = True
                    Next
                Else
                    Dim filter As String = GetGridFilter(grdArticulos)
                    Dim vwFilter As New DataView(info.ArticulosTable, filter, String.Empty, DataViewRowState.CurrentRows)
                    For Each dr As DataRowView In vwFilter
                        dr("Precio") = frmEdit.Precio
                        dr("IdDivisa") = frmEdit.IdDivisa
                        dr("Updated") = True
                    Next
                    grdArticulos.Update()
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdAsignarSvc_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAsignarSvc.Click
        Dim info As ListaPreciosInfo = CType(Me.PackageInfo, ListaPreciosInfo)
        Try
            Dim frmEdit As New EditPrecioForm
            If frmEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If frmEdit.RangoAplicacion = "S" Then
                    For Each rowIndex As Integer In grdServicios.SelectedRows
                        Dim IdServicio As Integer = CInt(grdServicios.Columns("IdServicio").CellValue(rowIndex))
                        Dim dr As ListaPreciosDS.ServiciosRow = info.ServiciosTable.FindByIdServicio(IdServicio)
                        dr.Precio = frmEdit.Precio
                        dr.IdDivisa = frmEdit.IdDivisa
                        dr("Updated") = True
                    Next
                Else
                    Dim filter As String = GetGridFilter(grdServicios)
                    Dim vwFilter As New DataView(info.ServiciosTable, filter, String.Empty, DataViewRowState.CurrentRows)
                    For Each dr As DataRowView In vwFilter
                        dr("Precio") = frmEdit.Precio
                        dr("IdDivisa") = frmEdit.IdDivisa
                        dr("Updated") = True
                    Next
                    grdServicios.Update()
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class