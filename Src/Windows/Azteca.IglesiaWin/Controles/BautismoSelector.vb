Public Class BautismoSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New BautismoFacade
            Me.EditorAssembly = "Azteca.IglesiaWin"
            Me.EditorClass = "Azteca.Windows.Iglesia.BautismoForm"
            Me.EditorTitle = "Editar los datos del Bautismo..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Bautismo As BautismoInfo = CType(Me.PackageInfo, BautismoInfo)
        If Bautismo IsNot Nothing Then
            TextInfo = Bautismo.Libro.ToString() & " / " & Bautismo.Pagina.ToString() & " / " & Bautismo.Acta.ToString()
            Key = Bautismo.Identity
        End If
    End Sub
End Class
