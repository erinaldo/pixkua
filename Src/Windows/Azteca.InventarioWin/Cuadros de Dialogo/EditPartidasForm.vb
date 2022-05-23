Imports Azteca.Kernel.Search

Public Class EditPartidasForm
    Private ArticuloFac As ArticuloStockFacade
    Private ArticuloInf As ArticuloStockInfo
    Private AlmacenFac As AlmacenFacade
    Private AlmacenInf As AlmacenInfo
    Private UnidadMedidaInf As UnidadMedidaInfo
    Private LoadingInfo As Boolean
    Private StockInf As StockInfo
    Private TipoMovto As TipoMovimiento

    Private Delegate Sub CargarArticuloDelegate(ByVal codigoServicio As String)
    Private CargarDel As CargarArticuloDelegate
    Private Result As IAsyncResult

    Public Event AddingItem(ByVal sender As Object, ByVal e As AddingArticuloEventArgs)

#Region "Metodos Privados"

    Private Sub LoadInfo()
        LoadingInfo = True
        txtCodigo.Text = ArticuloInf.UserCode
        lblDescripcion.Text = ArticuloInf.Nombre
        'Cargar información de la unidad de medida
        If Context.UnidadesMedida.ContainsKey(ArticuloInf.IdUnidadMedida) Then
            UnidadMedidaInf = Context.UnidadesMedida(ArticuloInf.IdUnidadMedida)
        Else
            Dim UnidadMedidaFac As New UnidadMedidaFacade
            UnidadMedidaInf = UnidadMedidaFac.GetDetailFromCache(App.Session.SessionID, ArticuloInf.IdUnidadMedida)
        End If
        StockInf = AlmacenFac.GetStockInfo(App.Session.SessionID, ArticuloInf.Identity, AlmacenInf.Identity)        
        txtExistencia.Text = (StockInf.Existencia * UnidadMedidaInf.Factor).ToString("N3")
        txtUnidad.Text = UnidadMedidaInf.Nombre
        LoadingInfo = False
    End Sub

    Private Sub EnableControls(ByVal enable As Boolean)
        btnAgregar.Enabled = enable
    End Sub

    Private Sub ClearControls()
        ArticuloInf = Nothing
        lblDescripcion.Text = ""
        txtCantidad.Text = "1"
        txtCodigo.Text = ""
        txtCodigo.Focus()
        txtExistencia.Text = ""
        txtUnidad.Text = String.Empty
        EnableControls(False)
    End Sub

    Private Function IsValid() As Boolean
        IsValid = False
        If Val(txtCantidad.Text) <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor a cero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantidad.Focus()
        Else
            Return True
        End If
    End Function

    Private Sub CargarArticulo(ByVal codigo As String)
        Try
            'Checar si el servicio se encuentra en el caché, si no, cargarlo
            If Context.Articulos.ContainsKey(codigo) Then
                ArticuloInf = Context.Articulos(codigo)
            Else
                ArticuloInf = ArticuloFac.GetDetailFromCache(App.Session.SessionID, codigo, App.DefaultSite.Identity)
                Context.Articulos.Add(codigo, ArticuloInf)
            End If
            LoadInfo()
            EnableControls(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Implementacion"

    Public Overloads Function ShowDialog(ByVal owner As System.Windows.Forms.Form, ByVal almacen As AlmacenInfo, ByVal tipoMovimiento As TipoMovimiento) As DialogResult
        Me.AlmacenInf = almacen
        Me.TipoMovto = tipoMovimiento
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditPartidaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            CargarDel = New CargarArticuloDelegate(AddressOf CargarArticulo)
            ArticuloFac = New ArticuloStockFacade
            AlmacenFac = New AlmacenFacade
            EnableControls(False)
            txtAlmacen.Text = AlmacenInf.Nombre
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            'Verificar que se haya especificado un código
            If txtCodigo.Text <> String.Empty Then
                'Verificar que el código especificado exista
                If Context.Articulos.ContainsKey(txtCodigo.Text) OrElse ArticuloFac.Exists(App.Session.SessionID, txtCodigo.Text, App.DefaultSite.Identity) Then
                    txtCantidad.Text = "1"
                    Result = CargarDel.BeginInvoke(txtCodigo.Text, Nothing, Nothing)
                Else
                    MessageBox.Show("El código de artículo no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCodigo.Focus()
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub txtCodigo_SearchRequested(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.SearchRequested
        Try
            Dim frmSearch As New MsgSearch
            With frmSearch
                .IdProceso = IdProceso
                .Owner = Me
            End With
            If frmSearch.ShowDialog(ArticuloFac) = System.Windows.Forms.DialogResult.OK Then
                Dim IdArticulo As Integer = CInt(frmSearch.SelectedItem)
                ArticuloInf = ArticuloFac.GetDetailFromCache(App.Session.SessionID, IdArticulo)
                LoadInfo()
                txtCantidad.Text = String.Empty
                txtCantidad.Focus()
                EnableControls(True)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        If Not LoadingInfo Then
            EnableControls(False)
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            If IsValid() Then
                CargarDel.EndInvoke(Result)
                Dim Cantidad As Integer = CInt(Val(txtCantidad.Text))
                Dim CostoUnitario As Decimal = (StockInf.CostoPromedio * UnidadMedidaInf.Factor)
                Dim Existencia As Decimal = (StockInf.Existencia / UnidadMedidaInf.Factor)
                Dim Flete As Decimal = 0D
                Dim Concepto As String = ArticuloInf.Nombre
                Dim Args As New AddingArticuloEventArgs(ArticuloInf, Cantidad, Existencia, UnidadMedidaInf, CostoUnitario, Flete)
                RaiseEvent AddingItem(Me, Args)
                If Args.Cancel Then MessageBox.Show(Args.CancelMessage, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearControls()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

#End Region

End Class


Public Class AddingArticuloEventArgs
    Inherits System.EventArgs

#Region "Variables Privadas"
    Private _Articulo As ArticuloStockInfo    
    Private _Cantidad As Integer
    Private _Existencia As Decimal
    Private _UnidadMedida As UnidadMedidaInfo
    Private _CostoUnitario As Decimal
    Private _Flete As Decimal
    Private _Cancel As Boolean
    Private _CancelMessage As String
#End Region

#Region "Propiedades Publicas"

    Public ReadOnly Property Articulo() As ArticuloStockInfo
        Get
            Return _Articulo
        End Get
    End Property

    Public ReadOnly Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
    End Property

    Public ReadOnly Property Existencia As Decimal
        Get
            Return _Existencia
        End Get
    End Property

    Public ReadOnly Property CostoUnitario() As Decimal
        Get
            Return _CostoUnitario
        End Get
    End Property

    Public ReadOnly Property Flete As Decimal
        Get
            Return _Flete
        End Get
    End Property

    Public ReadOnly Property UnidadMedida As UnidadMedidaInfo
        Get
            Return _UnidadMedida
        End Get
    End Property

    Public Property Cancel() As Boolean
        Get
            Return _Cancel
        End Get
        Set(ByVal value As Boolean)
            _Cancel = value
        End Set
    End Property

    Public Property CancelMessage() As String
        Get
            Return _CancelMessage
        End Get
        Set(ByVal value As String)
            _CancelMessage = value
        End Set
    End Property
#End Region

    Public Sub New(ByVal articulo As ArticuloStockInfo, ByVal cantidad As Integer, ByVal existencia As Decimal, ByVal UnidadMedida As UnidadMedidaInfo, ByVal costoUnitario As Decimal, ByVal flete As Decimal)
        _Articulo = articulo
        _Cantidad = cantidad
        _Existencia = existencia
        _UnidadMedida = UnidadMedida
        _CostoUnitario = costoUnitario
        _Flete = flete
        _Cancel = False
        _CancelMessage = String.Empty
    End Sub

End Class
