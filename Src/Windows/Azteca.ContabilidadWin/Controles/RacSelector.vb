Public Class RacSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New RacFacade
            Me.EditorAssembly = "Azteca.ContabilidadWin"
            Me.EditorClass = "Azteca.Windows.Contabilidad.RacsForm"
            Me.EditorTitle = "Editar RAC contable..."
        End If
    End Sub
    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    'End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim rac As RacInfo = CType(Me.PackageInfo, RacInfo)
        If rac IsNot Nothing Then
            TextInfo = rac.Nombre
            Key = rac.Identity
        End If
    End Sub

End Class
