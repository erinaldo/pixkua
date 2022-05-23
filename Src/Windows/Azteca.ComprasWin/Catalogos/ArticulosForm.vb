Imports Azteca.Business.Inventario

Public Class ArticulosForm
    Private GruposClasif, Clasificaciones, Almacenes, InfoInventario As DataTable

    Private Sub CargarAlmacenes()
        Dim AlmacenFac As New AlmacenFacade
        Almacenes = AlmacenFac.LoadList(App.Session.SessionID, App.DefaultSite.Identity, App.Session.User.Identity, TipoAccesoAlmacen.Lectura)
        bsAlmacenes.DataSource = Almacenes
        cboAlmacen.Rebind(True)
    End Sub

    Private Sub CargarInfoInventario(ByVal idArticuloStock As Integer)
        Dim ArticuloFac As New ArticuloStockFacade
        InfoInventario = ArticuloFac.CargarInfoInventario(App.Session.SessionID, App.DefaultSite.Identity, idArticuloStock)
        bsDatosInv.DataSource = InfoInventario
        grdDatosInv.Rebind(True)
        If bsDatosInv.Count > 0 Then bsDatosInv.Position = 0
    End Sub

    Private Sub CargarClasificaciones()
        Dim GrupoFac As New GrupoClasificacionesFacade
        Clasificaciones = GrupoFac.CargarClasificaciones(App.Session.SessionID, 1)
        bsClasificaciones.DataSource = Clasificaciones
        cboClasificaciones.Rebind(True)
        bsClasificaciones.Sort = "Nombre"
    End Sub

    Private Sub CargarGruposClasificaciones(ByVal idArticuloStock As Integer)
        Dim ArticuloFac As New ArticuloStockFacade
        GruposClasif = ArticuloFac.CargarClasificaciones(App.Session.SessionID, idArticuloStock)
        bsGruposClasif.DataSource = GruposClasif
        grdClasificaciones.Rebind(True)
        If bsGruposClasif.Count > 0 Then bsGruposClasif.Position = 0
    End Sub

    Private Function ValidarClasificaciones() As Boolean
        grdClasificaciones.UpdateData()
        For Each dr As DataRow In GruposClasif.Rows
            If CBool(dr("Requerido")) And CInt(dr("IdClasificacion")) = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

    Protected Overrides Function IsValid() As Boolean
        If Not ValidarClasificaciones() Then
            MessageBox.Show("Existen clasificaciones requeridas y no se ha especificado su valor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return MyBase.IsValid()
        End If
    End Function

    Private Sub ArticulosStockForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        CargarGruposClasificaciones(0)
        CargarInfoInventario(0)
    End Sub

    Private Sub ArticulosStockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarZonas()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ArticulosStockForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Articulo As ArticuloStockInfo = CType(PackageInfo, ArticuloStockInfo)
        With Articulo
            txtNombre.Text = .Nombre
            cboTipoUnidad.SelectedValue = .IdTipoUnidadMedida
            cboUnidadMedida.SelectedValue = .IdUnidadMedida
            txtEAN.Text = .EAN
            txtCuenta.Text = String.Empty
            If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
            txtDescr.Text = .Descripcion
            nudStockMax.Value = .StockMax
            nudStockMin.Value = .StockMin
            nudPuntoReorden.Value = .PuntoReorden
            CargarGruposClasificaciones(.Identity)
            CargarInfoInventario(.Identity)
        End With
    End Sub

    Private Sub ArticulosStockForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboTipoUnidad.LoadList()
        cboUnidadMedida.LoadList()
        If cboTipoUnidad.Items.Count > 0 Then cboTipoUnidad.SelectedIndex = 0
        CargarClasificaciones()
        CargarAlmacenes()
    End Sub

    Protected Overrides Sub OnSaveItem(ByVal e As Forms.InfoEntryEventArgs)
        MyBase.OnSaveItem(e)
        Dim Articulo As ArticuloStockInfo = CType(PackageInfo, ArticuloStockInfo)
        Dim ArticuloFac As New ArticuloStockFacade
        ArticuloFac.GuardarClasificaciones(App.Session.SessionID, Articulo.Identity, GruposClasif)
    End Sub

    Private Sub ArticulosStockForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Articulo As ArticuloStockInfo = CType(PackageInfo, ArticuloStockInfo)
        'Guardar las clasificaciones
        With Articulo
            .Nombre = txtNombre.Text
            .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
            .EAN = txtEAN.Text
            .IdCuenta = txtCuenta.Key
            .Descripcion = txtDescr.Text
            .StockMax = nudStockMax.Value
            .StockMin = nudStockMin.Value
            .PuntoReorden = nudPuntoReorden.Value
            .Origen = "I"
        End With
    End Sub

    Private Sub cboTipoUnidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoUnidad.SelectedIndexChanged
        Try
            If cboTipoUnidad.SelectedIndex >= 0 Then
                cboUnidadMedida.FilterExpression = "IdUnidadMedidaTipo=" & CInt(cboTipoUnidad.SelectedValue).ToString
            Else
                cboUnidadMedida.FilterExpression = String.Empty
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdClasificaciones_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdClasificaciones.AfterColUpdate
        grdClasificaciones.Columns("Descripción").Text = cboClasificaciones.Columns("Clasificación").Text
    End Sub

    Private Sub grdClasificaciones_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles grdClasificaciones.BeforeColEdit
        If e.Column.Name = "Valor" And bsClasificaciones.Current IsNot Nothing Then
            Dim IdGrupo As Integer = CInt(grdClasificaciones.Columns("IdGrupo").Value)
            bsClasificaciones.Filter = "IdClasificacionGrupo=" & IdGrupo
        End If
    End Sub

    Private Sub grdClasificaciones_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdClasificaciones.ButtonClick
        Try
            If e.Column.Name = "Valor" And bsGruposClasif.Current IsNot Nothing Then
                Dim IdGrupo As Integer = CInt(grdClasificaciones.Columns("IdGrupo").Value)
                bsClasificaciones.Filter = "IdClasificacionGrupo=" & IdGrupo
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdClasificaciones_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdClasificaciones.FetchRowStyle
        Try
            If CBool(grdClasificaciones.Columns("Requerido").CellValue(e.Row)) AndAlso CInt(grdClasificaciones.Columns("Valor").CellValue(e.Row)) = 0 Then
                e.CellStyle.BackColor = Drawing.Color.Orange
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#Region "Zonas"

    Private Sub CargarZonas()
        Dim ZonaFac As New ZonaCompraFacade
        Dim Zonas As DataTable = ZonaFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity, App.Session.User.Identity)
        bsZonas.DataSource = Zonas
        grdZonas.Rebind(True)
    End Sub

    Private Sub cmdProveedores_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdProveedores.Click
        If bsZonas.Current IsNot Nothing Then
            Dim Articulo As ArticuloStockInfo = CType(PackageInfo, ArticuloStockInfo)
            If Articulo.Identity > 0 Then
                Try
                    Dim IdZona As Integer = CInt(grdZonas.Columns("ID").Value)
                    Dim frmProveedores As New ProveedoresArticuloForm
                    If frmProveedores.ShowDialog(Me, IdZona, Articulo.Identity, False) = System.Windows.Forms.DialogResult.OK Then

                    End If
                Catch ex As Exception
                    MsgInfo.Show(ex)
                End Try
            Else
                MessageBox.Show("Primero debe guardar los datos del artículo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar una zona de compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

End Class