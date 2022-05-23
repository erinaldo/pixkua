Public Class BeneficiarioSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New BeneficiarioFacade
            Me.EditorAssembly = "Azteca.TesoreriaWin"
            Me.EditorClass = "Azteca.Windows.Tesoreria.BeneficiariosForm"
            Me.EditorTitle = "Editar datos del Beneficiario..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim info As BeneficiarioInfo = CType(Me.PackageInfo, BeneficiarioInfo)
        If info IsNot Nothing Then
            TextInfo = info.RazonSocial
            Key = info.Identity
        End If
    End Sub
End Class
