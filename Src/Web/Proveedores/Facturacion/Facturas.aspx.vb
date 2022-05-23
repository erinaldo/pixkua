Imports Azteca.Business.Compras
Imports System.Data

Partial Class Facturacion_Facturas
    Inherits System.Web.UI.Page

    Private PixcuaSession As Azteca.Kernel.Security.SessionInfo
    Dim Proveedor As ProveedorInfo
    Private IdProveedor As Integer

    Private Sub ActualizarFacturas()
        Dim FechaIni As Date = New Date(CInt(txtAnio.Text), CInt(cboMes.SelectedValue), 1)
        Dim FechaFin As Date = New Date(CInt(txtAnio.Text), CInt(cboMes.SelectedValue), Date.DaysInMonth(CInt(txtAnio.Text), CInt(cboMes.SelectedValue)))
        'Cargar lista de facturas
        Dim Comprobante As New ComprobanteFiscalFacade
        Dim dtFacturas As DataTable = Comprobante.ListaPorPeriodo(PixcuaSession.SessionID, FechaIni, FechaFin, 1, Proveedor.Identity)
        grdFacturas.DataSource = dtFacturas
        grdFacturas.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PixcuaSession = CType(Application("Session"), Azteca.Kernel.Security.SessionInfo)
        Proveedor = CType(Session("Proveedor"), ProveedorInfo)
        If Not Page.IsPostBack Then
            Try
                txtAnio.Text = Date.Today.Year
                cboMes.SelectedValue = Date.Today.Month
                ActualizarFacturas()
            Catch ex As Exception
                lblError.Text = ex.Message
            End Try
        End If
    End Sub

    Protected Sub mnuFacturas_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles mnuFacturas.MenuItemClick
        Try
            Select Case e.Item.Value
                Case "Actualizar"
                    ActualizarFacturas()
                Case "Cargar"

            End Select
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class
