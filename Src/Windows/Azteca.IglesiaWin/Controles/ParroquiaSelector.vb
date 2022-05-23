Public Class ParroquiaSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New ParroquiaFacade
            Me.EditorAssembly = "Azteca.IglesiaWin"
            Me.EditorClass = "Azteca.Windows.Iglesia.ParroquiasForm"
            Me.EditorTitle = "Editar los datos de la Parroquia..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Parroquia As ParroquiaInfo = CType(Me.PackageInfo, ParroquiaInfo)
        If Parroquia IsNot Nothing Then
            TextInfo = Parroquia.Nombre
            Key = Parroquia.Identity
        End If
    End Sub

End Class
