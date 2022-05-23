Public Class ZonasVentaForm

    Private Function GetGridFilter(grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid) As String
        Dim sb As New System.Text.StringBuilder()
        For Each col As C1.Win.C1TrueDBGrid.C1DataColumn In grid.Columns
            If col.FilterText.Trim = String.Empty Then Continue For
            If sb.Length > 0 Then sb.Append(" AND ")
            sb.Append(col.DataField & " like '" & col.FilterText & "%'")
        Next
        Return sb.ToString
    End Function

#Region "Implementacion"

    Private Sub ZonasVentaForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        'Agregar columna para soporte de filas modificadas
        Dim colArtUpdate As New DataColumn("Updated", GetType(Boolean))
        colArtUpdate.DefaultValue = False
        '
        Dim colSvcUpdate As New DataColumn("Updated", GetType(Boolean))
        colSvcUpdate.DefaultValue = False
        '
        ZonaInf.Articulos.Columns.Add(colArtUpdate)
        ZonaInf.Servicios.Columns.Add(colSvcUpdate)
        bsArticulos.DataSource = ZonaInf.Articulos
        bsServicios.DataSource = ZonaInf.Servicios
        grdArticulos.Rebind(True)
        grdServicios.Rebind(True)
    End Sub

    Private Sub ZonasVentaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ZonasVentaForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        With ZonaInf
            txtNombre.Text = .Nombre
            'Agregar columna para soporte de filas modificadas
            Dim colArtUpdate As New DataColumn("Updated", GetType(Boolean))
            colArtUpdate.DefaultValue = False
            '
            Dim colSvcUpdate As New DataColumn("Updated", GetType(Boolean))
            colSvcUpdate.DefaultValue = False
            '
            .Articulos.Columns.Add(colArtUpdate)
            .Servicios.Columns.Add(colSvcUpdate)

            bsArticulos.DataSource = .Articulos
            bsServicios.DataSource = .Servicios
            grdArticulos.Rebind(True)
            grdServicios.Rebind(True)
        End With
    End Sub

    Private Sub ZonasVentaForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        With ZonaInf
            .Nombre = txtNombre.Text
        End With
    End Sub

#End Region


#Region "Articulos"

    Private Sub cmdAgregarArt_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarArt.Click
        Try
            Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
            Dim drArticulo As ZonasVentaDS.ArticulosRow = ZonaInf.Articulos.NewArticulosRow

            Dim frm As New EditArticuloZonaForm
            If frm.ShowDialog(Me, ZonaInf.Identity, drArticulo) = DialogResult.OK Then
                drArticulo("Updated") = True
                ZonaInf.Articulos.AddArticulosRow(drArticulo)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub grdArticulos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArticulos.DeleteButtonClick
        If bsArticulos.Current IsNot Nothing Then
            Try
                Dim Result As DialogResult = MessageBox.Show("¿Esta seguro que desea quitar el articulo seleccionado de la zona de venta actual?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    bsArticulos.RemoveCurrent()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdArticulos_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdArticulos.EditButtonClick
        If bsArticulos.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarArticulo()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub grdArticulos_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdArticulos.FetchCellStyle
        Try
            If CBool(grdArticulos.Columns("Updated").CellValue(e.Row)) = True Then
                e.CellStyle.BackColor = Drawing.Color.LightGreen
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub EditarArticulo()
        Dim Zona As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        Dim drArt As ZonasVentaDS.ArticulosRow = CType(CType(bsArticulos.Current, DataRowView).Row, ZonasVentaDS.ArticulosRow)
        Dim frmEditZona As New EditArticuloZonaForm
        If frmEditZona.ShowDialog(Me, Zona.Identity, drArt) = System.Windows.Forms.DialogResult.OK Then
            drArt("Updated") = True
        End If
    End Sub

    Private Sub cmdCambiarPrecioArt_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCambiarPrecioArt.Click
        Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        Try
            Dim frmEdit As New EditPrecioForm
            If frmEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If frmEdit.RangoAplicacion = "S" Then
                    For Each rowIndex As Integer In grdArticulos.SelectedRows
                        Dim IdArticuloStock As Integer = CInt(grdArticulos.Columns("IdArticuloStock").CellValue(rowIndex))
                        Dim dr As ZonasVentaDS.ArticulosRow = ZonaInf.Articulos.FindByIdArticuloStock(IdArticuloStock)
                        dr.Precio = frmEdit.Precio
                        dr.IdDivisa = frmEdit.IdDivisa
                        dr("Updated") = True
                    Next
                Else
                    Dim filter As String = GetGridFilter(grdArticulos)
                    Dim vwFilter As New DataView(ZonaInf.Articulos, filter, String.Empty, DataViewRowState.CurrentRows)
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

#End Region

#Region "Servicios"

    Private Sub cmdAgregarSvc_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarSvc.Click
        Try
            Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
            Dim drServicio As ZonasVentaDS.ServiciosRow = ZonaInf.Servicios.NewServiciosRow

            Dim frm As New EditServicioZonaForm
            If frm.ShowDialog(Me, ZonaInf.Identity, drServicio) = DialogResult.OK Then
                drServicio("Updated") = True
                ZonaInf.Servicios.AddServiciosRow(drServicio)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdServicios_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.DeleteButtonClick
        If bsServicios.Current IsNot Nothing Then
            Try
                Dim Result As DialogResult = MessageBox.Show("¿Esta seguro que desea quitar el servicio seleccionado de la zona de venta actual?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    bsServicios.RemoveCurrent()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdServicios_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.EditButtonClick
        If bsServicios.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarServicio()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub EditarServicio()
        Dim Zona As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        Dim drSvc As ZonasVentaDS.ServiciosRow = CType(CType(bsServicios.Current, DataRowView).Row, ZonasVentaDS.ServiciosRow)
        Dim frmEditZona As New EditServicioZonaForm
        If frmEditZona.ShowDialog(Me, Zona.Identity, drSvc) = System.Windows.Forms.DialogResult.OK Then
            drSvc("Updated") = True
        End If
    End Sub

    Private Sub grdServicios_FetchCellStyle(sender As Object, e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles grdServicios.FetchCellStyle
        Try
            If CBool(grdServicios.Columns("Updated").CellValue(e.Row)) = True Then
                e.CellStyle.BackColor = Drawing.Color.LightGreen
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdCambiarPreciosSvc_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCambiarPreciosSvc.Click
        Dim ZonaInf As ZonaVentaInfo = CType(PackageInfo, ZonaVentaInfo)
        Try
            Dim frmEdit As New EditPrecioForm
            If frmEdit.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                If frmEdit.RangoAplicacion = "S" Then
                    For Each rowIndex As Integer In grdServicios.SelectedRows
                        Dim IdServicio As Integer = CInt(grdServicios.Columns("IdServicio").CellValue(rowIndex))
                        Dim dr As ZonasVentaDS.ServiciosRow = ZonaInf.Servicios.FindByIdServicio(IdServicio)
                        dr.Precio = frmEdit.Precio
                        dr.IdDivisa = frmEdit.IdDivisa
                        dr("Updated") = True
                    Next
                Else
                    Dim filter As String = GetGridFilter(grdServicios)
                    Dim vwFilter As New DataView(ZonaInf.Servicios, filter, String.Empty, DataViewRowState.CurrentRows)
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


#End Region



End Class