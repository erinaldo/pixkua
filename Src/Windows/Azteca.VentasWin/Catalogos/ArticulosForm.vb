Public Class ArticulosForm
    Private Presentaciones As ArticulosDS.PresentacionesDataTable
    Private Clasificaciones, GruposClasif As DataTable
    Private _IdArticuloStock As Integer

#Region "Propiedades Publicas"

    Public Property Articulo_Presentaciones As ArticulosDS.PresentacionesDataTable
        Get
            Return Presentaciones
        End Get
        Set(ByVal value As ArticulosDS.PresentacionesDataTable)
            Presentaciones = value
        End Set
    End Property

    Public Property Articulo_IdArticuloStockEditing As Integer
        Get
            Return _IdArticuloStock
        End Get
        Set(ByVal value As Integer)
            _IdArticuloStock = value
        End Set
    End Property


    Public ReadOnly Property Articulo_Nombre As String
        Get
            Return txtNombre.Text
        End Get
    End Property

    Public ReadOnly Property Articulo_IdTipoUnidad As Integer
        Get
            Return CInt(cboTipoUnidad.SelectedValue)
        End Get
    End Property
    Public ReadOnly Property Articulo_IdUnidadMedida As Integer
        Get
            Return CInt(cboUnidadMedida.SelectedValue)
        End Get
    End Property

#End Region

#Region "Clasificaciones"
    Private Sub CargarClasificaciones()
        Dim GrupoFac As New GrupoClasificacionesFacade
        Clasificaciones = GrupoFac.CargarClasificaciones(App.Session.SessionID, 2)
        bsClasificaciones.DataSource = Clasificaciones
        cboClasificaciones.Rebind(True)
        bsClasificaciones.Sort = "Nombre"
    End Sub

    Private Sub CargarGruposClasificaciones(ByVal idArticulo As Integer)
        Dim CteFac As New ArticuloFacade
        GruposClasif = CteFac.CargarClasificaciones(App.Session.SessionID, idArticulo)
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

#End Region


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

    Public Sub CargarPresentaciones()
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        Dim ArticuloFac As New ArticuloFacade
        Presentaciones = ArticuloFac.LoadPresentaciones(App.Session.SessionID, Articulo.Identity)
        bsPresentaciones.DataSource = Presentaciones
        grdPresentaciones.Rebind(True)
    End Sub

    Public Overridable Sub AgregarPresentacion()
        Dim ArticuloFac As New ArticuloFacade
        Dim frmArticulosStock As New Azteca.Windows.Inventario.ArticulosStockForm
        frmArticulosStock.StartPosition = FormStartPosition.CenterParent
        With frmArticulosStock
            .AddItem()
            .LoadLists()
            .txtNombre.Text = txtNombre.Text
            .cboTipoUnidad.SelectedValue = cboTipoUnidad.SelectedValue
            .cboUnidadMedida.SelectedValue = cboUnidadMedida.SelectedValue
            .txtNombre.Focus()
        End With
        'Si el artículo aun no contiene ninguna presentación, sugerir datos y código de este artículo
        If Presentaciones.Count = 0 Then
            If frmArticulosStock.ShowDialog(Me, Code, "Agregar presentación del artículo") = System.Windows.Forms.DialogResult.OK Then
                ArticuloFac.AgregarPresentacion(App.Session.SessionID, PackageInfo.Identity, frmArticulosStock.PackageInfo.Identity)
                CargarPresentaciones()
            End If
        Else
            If frmArticulosStock.ShowDialog(Me, String.Empty, "Agregar presentación del artículo") = System.Windows.Forms.DialogResult.OK Then
                ArticuloFac.AgregarPresentacion(App.Session.SessionID, PackageInfo.Identity, frmArticulosStock.PackageInfo.Identity)
                CargarPresentaciones()
            End If
        End If
    End Sub

    Private Sub ArticulosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        Presentaciones = New ArticulosDS.PresentacionesDataTable
        bsPresentaciones.DataSource = Presentaciones
        grdPresentaciones.Rebind(True)
        CargarGruposClasificaciones(0)
    End Sub

    Private Sub ArticulosForm_ItemSaved(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemSaved
        If Presentaciones.Count = 0 Then
            AgregarPresentacion()
        End If
    End Sub

    Private Sub ArticulosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ArticulosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        With Articulo
            txtNombre.Text = .Nombre
            cboTipoUnidad.SelectedValue = .IdTipoUnidadMedida
            cboUnidadMedida.SelectedValue = .IdUnidadMedida
            cboMarca.SelectedValue = .IdMarca
            txtModelo.Text = .Modelo
            txtEstCom.Text = String.Empty
            If .IdEstCom > 0 Then txtEstCom.LoadInfo(.IdEstCom)
            .IdCategoriaFlujo = 0

            CargarGruposClasificaciones(.Identity)
        End With
        CargarPresentaciones()
    End Sub

    Private Sub ArticulosForm_LoadingLists(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadingLists
        cboTipoUnidad.LoadList()
        cboMarca.LoadList()
        cboUnidadMedida.LoadList()
        CargarClasificaciones()
    End Sub

    Protected Overrides Sub OnSaveItem(ByVal e As Forms.InfoEntryEventArgs)
        MyBase.OnSaveItem(e)
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        Dim ArtFac As New ArticuloFacade
        ArtFac.GuardarClasificaciones(App.Session.SessionID, Articulo.Identity, GruposClasif)
    End Sub


    Private Sub ArticulosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        With Articulo
            .Nombre = txtNombre.Text
            .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
            .IdMarca = CInt(cboMarca.SelectedValue)
            .Modelo = txtModelo.Text
            .IdEstCom = txtEstCom.Key
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

    Private Sub btnAddPresentacion_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregarPresentacion.Click
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        If Articulo.Identity > 0 Then
            Try
                AgregarPresentacion()
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Else
            MessageBox.Show("Primero debe guardar los datos del artículo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdPresentaciones_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdPresentaciones.DeleteButtonClick
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        If bsPresentaciones.Current IsNot Nothing Then
            Dim Resp As DialogResult = MessageBox.Show("¿Esta se guro que desea quitar la presentación seleccionada?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim drPresentacion As ArticulosDS.PresentacionesRow = CType(CType(bsPresentaciones.Current, DataRowView).Row, ArticulosDS.PresentacionesRow)
                    Dim ArticuloFac As New ArticuloFacade
                    ArticuloFac.QuitarPresentacion(App.Session.SessionID, Articulo.Identity, drPresentacion.IdArticuloStock)
                    CargarPresentaciones()
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        Else
            MessageBox.Show("Debe seleccionar la presentación a remover.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdPresentaciones_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdPresentaciones.EditButtonClick
        Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
        If bsPresentaciones.Current IsNot Nothing Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim drPresentacion As ArticulosDS.PresentacionesRow = CType(CType(bsPresentaciones.Current, DataRowView).Row, ArticulosDS.PresentacionesRow)
                _IdArticuloStock = drPresentacion.IdArticuloStock
                ShowEditPresentacion()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Debe seleccionar la presentación a editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Overridable Sub ShowEditPresentacion()
        Dim frmArticulosStock As New Azteca.Windows.Inventario.ArticulosStockForm
        frmArticulosStock.StartPosition = FormStartPosition.CenterParent
        If frmArticulosStock.ShowDialog(Me, _IdArticuloStock, "Editar presentación del artículo") = System.Windows.Forms.DialogResult.OK Then
            CargarPresentaciones()
        End If
    End Sub


    Private Sub btnZonas_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdZonasVenta.Click
        If bsPresentaciones.Current IsNot Nothing Then
            Try
                Dim IdArticuloStock As Integer = CInt(grdPresentaciones.Columns("IdArticuloStock").Value)
                Dim Codigo As String = grdPresentaciones.Columns("Código").Text
                Dim ArticuloStock As String = grdPresentaciones.Columns("Descripción").Text
                '
                Dim frm As New EditArticuloPresZonaForm
                If frm.ShowDialog(Me, IdArticuloStock, Codigo, ArticuloStock) = System.Windows.Forms.DialogResult.OK Then

                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdPresentaciones_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdPresentaciones.FetchRowStyle
        Try
            Dim IdStatus As Integer = CInt(grdPresentaciones.Columns("IdStatus").CellValue(e.Row))
            If IdStatus = 0 Then e.CellStyle.BackColor = Drawing.Color.Moccasin
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdAdminTallasColores_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAdminTallasColores.Click
        Try
            Dim Articulo As ArticuloInfo = CType(PackageInfo, ArticuloInfo)
            If Articulo.Identity > 0 Then
                Try
                    Dim frm As New AdminTallasColoresForm
                    If frm.ShowDialog(Articulo) = System.Windows.Forms.DialogResult.OK Then
                        'Listar Presentaciones
                        CargarPresentaciones()
                    End If
                Catch ex As Exception
                    MsgInfo.Show(ex)
                End Try
            Else
                MessageBox.Show("Primero debe guardar los datos del artículo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
           
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class