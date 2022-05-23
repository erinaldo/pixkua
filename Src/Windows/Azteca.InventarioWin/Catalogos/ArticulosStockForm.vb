Public Class ArticulosStockForm
    Private GruposClasif, Clasificaciones, Almacenes, InfoInventario As DataTable


    Private Sub CargarColores()
        Dim ColorFac As New ColorFacade
        Dim dtColores As DataTable = ColorFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
        cboColor.ItemsTable = dtColores
        cboColor.DisplayMember = "Nombre"
        cboColor.ValueMember = "IdColor"
        cboColor.SortExpression = "Nombre"
        cboColor.LoadList()
    End Sub

    Private Sub CargarTallas()
        Dim TallaFac As New TallaFacade
        Dim dtTallas As DataTable = TallaFac.LoadList(App.Session.SessionID)
        cboTalla.ItemsTable = dtTallas
        cboTalla.DisplayMember = "Nombre"
        cboTalla.ValueMember = "IdTalla"
        cboTalla.SortExpression = "Nombre"
        cboTalla.LoadList()
    End Sub

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
        If GruposClasif Is Nothing Then Return True
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
        chkCantidadFija.Checked = False
    End Sub

    Private Sub ArticulosStockForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            Dim ArtFac As New ArticuloStockFacade
            .Imagen = ArtFac.getImagen(App.Session.SessionID, .Identity)
            picMngrImage.SetImageBytes(.Imagen)
            cboTalla.SelectedValue = .IdTalla
            cboColor.SelectedValue = .IdColor

            txtCostoMaterial.Text = .CostoMaterial.ToString()
            txtCostoLabor.Text = .CostoLabor.ToString()
            txtCostoServicio.Text = .CostoServicio.ToString()
            txtCostoCarga.Text = .CostoCarga.ToString()

            cboTipo.SelectedValue = .IdTipo
            cboFamilia.SelectedValue = .IdFamilia
            txtVersionMaster.Text = .VersionMaster.ToString()
            txtFactorFab.Text = .FactorFabricacion.ToString()
            chkCantidadFija.Checked = CBool(.CantidadFija)

        End With
    End Sub



    Private Sub ArticulosStockForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboTipoUnidad.LoadList()
        cboUnidadMedida.LoadList()
        cboTipo.LoadList()
        cboFamilia.LoadList()
        If cboTipoUnidad.Items.Count > 0 Then cboTipoUnidad.SelectedIndex = 0
        CargarClasificaciones()
        CargarAlmacenes()
        'vick
        CargarTallas()
        CargarColores()
    End Sub

    Protected Overrides Sub OnSaveItem(ByVal e As Forms.InfoEntryEventArgs)
        MyBase.OnSaveItem(e)
        Dim Articulo As ArticuloStockInfo = CType(PackageInfo, ArticuloStockInfo)
        Dim ArticuloFac As New ArticuloStockFacade
        If GruposClasif IsNot Nothing Then ArticuloFac.GuardarClasificaciones(App.Session.SessionID, Articulo.Identity, GruposClasif)
    End Sub

    Private Sub ArticulosStockForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Articulo As ArticuloStockInfo = CType(PackageInfo, ArticuloStockInfo)
        Dim umFac As New UnidadMedidaFacade()
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
            .Imagen = picMngrImage.GetImageBytes
            .IdTalla = CInt(cboTalla.SelectedValue)
            .IdColor = CInt(cboColor.SelectedValue)
            If (txtCostoMaterial.Text <> "") Then
                .CostoMaterial = CDec(txtCostoMaterial.Text)
            Else
                .CostoMaterial = 0
            End If

            If (txtCostoLabor.Text <> "") Then
                .CostoLabor = CDec(txtCostoLabor.Text)
            Else
                .CostoLabor = 0
            End If

            If (txtCostoServicio.Text <> "") Then
                .CostoServicio = CDec(txtCostoServicio.Text)
            Else
                .CostoServicio = 0
            End If

            If (txtCostoCarga.Text <> "") Then
                .CostoCarga = CDec(txtCostoCarga.Text)
            Else
                .CostoCarga = 0
            End If

            .IdTipo = CInt(cboTipo.SelectedValue)
            .IdFamilia = CInt(cboFamilia.SelectedValue)
            .VersionMaster = CInt(txtVersionMaster.Text)
            .FactorFabricacion = CInt(txtFactorFab.Text)
            .CantidadFija = CShort(chkCantidadFija.Checked)

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

    Private Sub grdDatosInv_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdDatosInv.ButtonClick
        Try
            If e.Column.Name = "Ubicación" Then
                Dim UbicacionFac As New UbicacionFacade
                'Mostrar pantalla de búsqueda para que el usuario seleccione una ubicacion
                Dim frmSearch As New UbicacionesHierarchyForm
                If frmSearch.ShowDialog(CInt(grdDatosInv.Columns("IdAlmacen").Value)) = System.Windows.Forms.DialogResult.OK Then
                    Dim Ubicacion As UbicacionInfo = UbicacionFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                    grdDatosInv.Columns("IdUbicacion").Value = Ubicacion.Identity
                    grdDatosInv.Columns("Ubicacion").Value = Ubicacion.NamedPath
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
      
    End Sub

    Private Sub ActulizarCostoTotal()
        Dim CostoMaterial As Decimal = 0
        Dim CostoLabor As Decimal = 0
        Dim CostoServicio As Decimal = 0
        Dim CostoCarga As Decimal = 0
        Dim CostoTotal As Decimal = 0


        If (txtCostoMaterial.Text <> "") Then
            CostoMaterial = CDec(txtCostoMaterial.Text)
        End If

        If (txtCostoLabor.Text <> "") Then
            CostoLabor = CDec(txtCostoLabor.Text)
        End If

        If (txtCostoServicio.Text <> "") Then
            CostoServicio = CDec(txtCostoServicio.Text)
        End If

        If (txtCostoCarga.Text <> "") Then
            CostoCarga = CDec(txtCostoCarga.Text)
        End If

        txtCostoTotal.Text = (CostoMaterial + CostoLabor + CostoServicio + CostoCarga).ToString()

    End Sub



   
    Private Sub txtCostoMaterial_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCostoMaterial.TextChanged
        Call ActulizarCostoTotal()
    End Sub

    Private Sub txtCostoLabor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCostoLabor.TextChanged
        Call ActulizarCostoTotal()
    End Sub

    Private Sub txtCostoServicio_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCostoServicio.TextChanged
        Call ActulizarCostoTotal()
    End Sub

    Private Sub txtCostoCarga_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCostoCarga.TextChanged
        Call ActulizarCostoTotal()
    End Sub

    Private Sub cboUnidadMedida_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboUnidadMedida.SelectedIndexChanged
        'Try
        '    Dim umInfo As New UnidadMedidaInfo(App.Session.SessionID)
        '    Dim umFac As New UnidadMedidaFacade()

        '    If (IsNumeric(CInt(cboUnidadMedida.SelectedValue))) Then
        '        umInfo = umFac.GetDetail(App.Session.SessionID, CInt(cboUnidadMedida.SelectedValue))
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Error al cambiar el costo basado en la unidad de medida: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class