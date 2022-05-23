Imports Azteca.Kernel.Search

Public Class EditPartidaServicioForm
    Private ServicioFac As ServicioFacade
    Private ServicioInf As ServicioInfo
    Private ClienteInf As ClienteInfo
    Private LoadingInfo As Boolean
    Private IdDivisa As Integer
    Private TipoCambio As Decimal

    Private Delegate Sub CargarArticuloDelegate(ByVal codigoServicio As String)
    Private CargarDel As CargarArticuloDelegate
    Private Result As IAsyncResult

    Public Event AddingItem(ByVal sender As Object, ByVal e As AddingServicioEventArgs)

#Region "Metodos Privados"

    Private Sub LoadInfo()
        LoadingInfo = True
        txtCodigo.Text = ServicioInf.UserCode
        lblDescripcion.Text = ServicioInf.Nombre
        If Context.UnidadNegocio.TipoPrecio = TipoPrecio.ListaPrecio Then
            'Dim drLista As Azteca.Inventario.ListasPreciosDS.ListasRow = ServicioInf.ListasPrecio.FindByIdListaPrecio(ClienteInf.IdListaPrecios)
            'If drLista IsNot Nothing Then
            '    txtPrecio.Text = drLista.Precio.ToString
            'Else
            '    txtPrecio.Text = "0.0"
            'End If
        Else
            'Obtener el precio del servicio en la zona
            Dim drZona As ZonasVentaDS.ZonasRow = ServicioInf.ZonasVenta.FindByIdZonaVenta(Context.UnidadNegocio.IdZonaVenta)
            If drZona IsNot Nothing Then
                txtPrecio.Text = drZona.Precio.ToString
                IdDivisa = drZona.IdDivisa
                txtDivisa.Text = drZona.Divisa
            Else
                txtPrecio.Text = "0.0"
            End If
        End If
        LoadingInfo = False
    End Sub

    Private Sub EnableControls(ByVal enable As Boolean)
        btnAgregar.Enabled = enable
        If ServicioInf IsNot Nothing AndAlso ServicioInf.ConceptoLibre Then
            txtDescripcion.ReadOnly = Not enable
            txtDescripcion.Text = ServicioInf.Nombre
            txtDescripcion.TabStop = enable
        Else
            txtDescripcion.ReadOnly = True
            txtDescripcion.Text = String.Empty
            txtDescripcion.TabStop = False
        End If
    End Sub

    Private Sub ClearControls()
        ServicioInf = Nothing
        lblDescripcion.Text = ""
        txtCantidad.Text = "1"
        txtCodigo.Text = ""
        txtCodigo.Focus()
        txtPrecio.Text = ""
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

    Private Sub CargarServicio(ByVal codigo As String)
        Try
            'Checar si el servicio se encuentra en el caché, si no, cargarlo
            If Context.Servicios.ContainsKey(codigo) Then
                ServicioInf = Context.Servicios(codigo)
            Else
                ServicioInf = ServicioFac.GetDetailFromCache(App.Session.SessionID, codigo, App.DefaultSite.Identity)
                Context.Servicios.Add(codigo, ServicioInf)
            End If
            txtPrecio.ReadOnly = Not ServicioInf.ConceptoLibre
            txtPrecio.TabStop = ServicioInf.ConceptoLibre
            LoadInfo()
            EnableControls(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Implementacion"

    Public Overloads Function ShowDialog(ByVal owner As System.Windows.Forms.Form, ByVal cliente As ClienteInfo) As DialogResult
        ClienteInf = cliente
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditPartidaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            CargarDel = New CargarArticuloDelegate(AddressOf CargarServicio)
            ServicioFac = New ServicioFacade
            EnableControls(False)
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
                If Context.Servicios.ContainsKey(txtCodigo.Text) OrElse ServicioFac.Exists(App.Session.SessionID, txtCodigo.Text, App.DefaultSite.Identity) Then
                    txtCantidad.Text = "1"
                    Result = CargarDel.BeginInvoke(txtCodigo.Text, Nothing, Nothing)
                Else
                    MessageBox.Show("El código de servicio no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If frmSearch.ShowDialog(ServicioFac) = System.Windows.Forms.DialogResult.OK Then
                Dim IdServicio As Integer = CInt(frmSearch.SelectedItem)
                Dim ServicioInf As ServicioInfo = ServicioFac.GetDetailFromCache(App.Session.SessionID, IdServicio)
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
                Dim Precio As Decimal = CDec(Val(txtPrecio.Text))
                Dim Concepto As String = ServicioInf.Nombre
                If ServicioInf.ConceptoLibre Then Concepto = txtDescripcion.Text
                Dim drZona As ZonasVentaDS.ZonasRow = ServicioInf.ZonasVenta.FindByIdZonaVenta(Context.UnidadNegocio.IdZonaVenta)
                Dim Args As New AddingServicioEventArgs(ServicioInf, drZona, Concepto, Cantidad, Precio, IdDivisa, txtDivisa.Text, 1)
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

    Private Sub txtDescripcion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        If Not LoadingInfo AndAlso ServicioInf IsNot Nothing AndAlso ServicioInf.ConceptoLibre Then
            lblDescripcion.Text = txtDescripcion.Text
        End If
    End Sub

#End Region

End Class


Public Class AddingServicioEventArgs
    Inherits System.EventArgs

#Region "Variables Privadas"
    Private _Servicio As ServicioInfo
    Private _Zona As ZonasVentaDS.ZonasRow
    Private _Concepto As String
    Private _Cantidad As Integer
    Private _Precio As Decimal
    Private _IdDivisa As Integer
    Private _Divisa As String
    Private _TipoCambio As Decimal = 1
    Private _Cancel As Boolean
    Private _CancelMessage As String
#End Region

#Region "Propiedades Publicas"

    Public ReadOnly Property Servicio() As ServicioInfo
        Get
            Return _Servicio
        End Get
    End Property

    Public ReadOnly Property Zona As ZonasVentaDS.ZonasRow
        Get
            Return _Zona
        End Get
    End Property

    Public ReadOnly Property Concepto As String
        Get
            Return _Concepto
        End Get
    End Property

    Public ReadOnly Property Cantidad() As Integer
        Get
            Return _Cantidad
        End Get
    End Property

    Public ReadOnly Property Precio() As Decimal
        Get
            Return _Precio
        End Get
    End Property

    Public ReadOnly Property IdDivisa As Integer
        Get
            Return _IdDivisa
        End Get
    End Property

    Public ReadOnly Property Divisa As String
        Get
            Return _Divisa
        End Get
    End Property

    Public ReadOnly Property TipoCambio As Decimal
        Get
            Return _TipoCambio
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

    Public Sub New(ByVal servicio As ServicioInfo, ByVal zona As ZonasVentaDS.ZonasRow, ByVal concepto As String, ByVal cantidad As Integer, ByVal precio As Decimal, ByVal idDivisa As Integer, ByVal divisa As String, ByVal tipoCambio As Decimal)
        _Servicio = servicio
        _Zona = zona
        _Concepto = concepto
        _Cantidad = cantidad
        _Precio = precio
        _IdDivisa = idDivisa
        _Divisa = divisa
        _TipoCambio = tipoCambio
        _Cancel = False
        _CancelMessage = String.Empty
    End Sub

End Class
