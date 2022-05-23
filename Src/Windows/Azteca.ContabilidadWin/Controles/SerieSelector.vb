Public Class SerieSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New SerieFacade
            Me.EditorAssembly = "Azteca.ContabilidadWin"
            Me.EditorClass = "Azteca.Windows.Contabilidad.SeriesForm"
            Me.EditorTitle = "Editar serie de comprobantes fiscales..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Serie As SerieInfo = CType(Me.PackageInfo, SerieInfo)
        If Serie IsNot Nothing Then
            TextInfo = Serie.Certificado & " - " & Serie.Serie
            Key = Serie.Identity
        End If
    End Sub

End Class
