Public Class ServicioSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ServicioFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.ServiciosForm"
            Me.EditorTitle = "Editar datos de servicio..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Servicio As ServicioInfo = CType(Me.PackageInfo, ServicioInfo)
        If Servicio IsNot Nothing Then
            TextInfo = Servicio.Nombre
            Key = Servicio.Identity
        End If
    End Sub

End Class
