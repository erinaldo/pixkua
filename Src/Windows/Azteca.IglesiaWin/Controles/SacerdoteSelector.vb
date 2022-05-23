Public Class SacerdoteSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New SacerdoteFacade
            Me.EditorAssembly = "Azteca.IglesiaWin"
            Me.EditorClass = "Azteca.Windows.Iglesia.SacerdotesForm"
            Me.EditorTitle = "Editar los datos del Sacerdote..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Sacerdote As SacerdoteInfo = CType(Me.PackageInfo, SacerdoteInfo)
        If Sacerdote IsNot Nothing Then
            TextInfo = Sacerdote.Persona.Nombre & " " & Sacerdote.Persona.ApellidoP & " " & Sacerdote.Persona.ApellidoM
            Key = Sacerdote.Identity
        End If
    End Sub
End Class
