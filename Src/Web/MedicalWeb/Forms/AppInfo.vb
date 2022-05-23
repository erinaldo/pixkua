Public Class AppInfo
    Public Property VirtualDirectory As String
    Public Property PageSize As Integer

    Public Property Session As Azteca.Kernel.Security.SessionInfo
    Public Property DefaultBranch As Azteca.Kernel.Security.SucursalInfo
    Public Property DefaultCompany As Azteca.Kernel.Security.EmpresaInfo

    Public Property UITheme As String = "http://code.jquery.com/ui/1.10.3/themes/redmond/jquery-ui.min.css"

End Class
