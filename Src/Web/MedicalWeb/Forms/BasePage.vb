Imports Azteca.Data

Public Class BasePage
    Inherits System.Web.UI.Page

    Private _ScriptsVersion As String = "1.04"

    Public Property IdProceso As Integer = 0

    Public ReadOnly Property ScriptsVersion As String
        Get
            Return _ScriptsVersion
        End Get
    End Property

    Private Function CargarAccesos(idUsuario As Integer) As DataTable
        Dim Connection As IDbConnection = Nothing
        Dim Result As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection()
            Dim fxAccesos As New FunctionSQL("Medicine", "fxUsuarioAccesos", Connection, Nothing)
            fxAccesos.Parameters.Add("@IdUsuario", DbType.Int32).Value = idUsuario
            Result = fxAccesos.GetTable()
        Catch ex As Exception
            Azteca.Web.Services.Kernel.ErrorHandler.HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Result
    End Function

    Public Sub CheckAccess()
        Dim Sesion As Azteca.Kernel.Security.SessionInfo = CType(Session("Sesion"), Azteca.Kernel.Security.SessionInfo)
        If Sesion Is Nothing Then
            Response.Redirect("../Login.aspx")
            Return
        End If
        If Not Page.IsPostBack And IdProceso > 0 Then
            Dim dtAccesos As DataTable = CargarAccesos(Sesion.User.Identity)
            Dim dvAcceso As New DataView(dtAccesos, "IdProceso=" & IdProceso & " AND Acceso=true", String.Empty, DataViewRowState.CurrentRows)
            If dvAcceso.Count = 0 Then
                Response.Redirect("AccesoDenegado.aspx")
            End If
        End If
    End Sub

    Protected Overrides Sub OnLoad(e As System.EventArgs)
        MyBase.OnLoad(e)
        Dim Info As New AppInfo()
        Info.Session = CType(Session("Sesion"), Azteca.Kernel.Security.SessionInfo)
        Info.DefaultBranch = CType(Session("DefaultBranch"), Azteca.Kernel.Security.SucursalInfo)
        Info.DefaultCompany = CType(Session("DefaultCompany"), Azteca.Kernel.Security.EmpresaInfo)
        Info.VirtualDirectory = ResolveUrl("~")
        Info.PageSize = 15
        Dim JsonApp As String = Newtonsoft.Json.JsonConvert.SerializeObject(Info)
        ClientScript.RegisterHiddenField("__App", JsonApp)
        CheckAccess()
    End Sub

End Class
