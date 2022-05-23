Public Class BasePage
    Inherits System.Web.UI.Page

    Private _ScriptsVersion As String = "1.02"
    Private _UITheme As String = "cupertino"

    Public ReadOnly Property ScriptsVersion As String
        Get
            Return _ScriptsVersion
        End Get
    End Property

    Public ReadOnly Property UITheme As String
        Get
            Return _UITheme
        End Get
    End Property

    Public Sub CheckAccess()

    End Sub

    Protected Overrides Sub OnLoad(e As System.EventArgs)
        MyBase.OnLoad(e)
        CheckAccess()
        Dim Info As New AppInfo()
        Info.Session = CType(Session("Sesion"), Azteca.Kernel.Security.SessionInfo)
        Info.DefaultBranch = CType(Session("DefaultBranch"), Azteca.Kernel.Security.SucursalInfo)
        Info.DefaultCompany = CType(Session("DefaultCompany"), Azteca.Kernel.Security.EmpresaInfo)
        Info.VirtualDirectory = ResolveUrl("~")
        Info.PageSize = 20
        Dim JsonApp As String = Newtonsoft.Json.JsonConvert.SerializeObject(Info)
        ClientScript.RegisterHiddenField("__App", JsonApp)
    End Sub

End Class
