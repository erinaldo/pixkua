Public Class SolicitanteSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New SolicitanteFacade
            Me.EditorAssembly = "Azteca.IglesiaWin"
            Me.EditorClass = "Azteca.Windows.Iglesia.SolicitantesForm"
            Me.EditorTitle = "Editar los datos del Solicitante..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Solicitante As SolicitanteInfo = CType(Me.PackageInfo, SolicitanteInfo)
        If Solicitante IsNot Nothing Then
            TextInfo = Solicitante.Persona.Nombre & " " & Solicitante.Persona.ApellidoP & " " & Solicitante.Persona.ApellidoM
            Key = Solicitante.Identity
        End If
    End Sub

End Class
