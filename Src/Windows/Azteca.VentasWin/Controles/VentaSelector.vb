Public Class VentaSelector
    Inherits Azteca.Windows.Controls.DocumentSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New VentaFacade
            Me.EditorAssembly = "Azteca.VentasWin"
            Me.EditorClass = "Azteca.Windows.Ventas.VendedoresForm"
            Me.EditorTitle = "Editar datos de vendedor..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Venta As VentaInfo = CType(Me.DocumentPackage, VentaInfo)
        If Venta IsNot Nothing Then
            TextInfo = "[" & Venta.Identity & "] - " & Venta.Fecha.ToShortDateString
            Key = Venta.Identity
        End If
    End Sub

End Class
