Public NotInheritable Class Context

    Private Sub New()

    End Sub

    Private Shared _Sucursal As SucursalConfigInfo

    Public Shared ReadOnly Property Sucursal As SucursalConfigInfo
        Get
            Return _Sucursal
        End Get
    End Property

    Public Shared Sub Initialize()
        Dim ConfigFac As New SucursalConfigFacade
        _Sucursal = ConfigFac.CargarConfiguracion(App.Session.SessionID, App.DefaultSite.Identity)
    End Sub

End Class
