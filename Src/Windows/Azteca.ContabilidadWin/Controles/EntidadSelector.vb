Public Class EntidadSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New EntidadFacade
            Me.EditorAssembly = "Azteca.ContabilidadWin"
            Me.EditorClass = "Azteca.Windows.Contabilidad.EntidadesForm"
            Me.EditorTitle = "Editar entidad contable..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Entidad As EntidadInfo = CType(Me.PackageInfo, EntidadInfo)
        If Entidad IsNot Nothing Then
            TextInfo = Entidad.Entidad
            Key = Entidad.Identity
        End If
    End Sub

End Class
