Public Class ClienteExpressSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Public Sub New()
        MyBase.New()
        If Not Me.DesignMode Then
            Me.Facade = New Azteca.Business.Ventas.ClienteFacade
            Me.EditorAssembly = "PixkuaInvoice"
            Me.EditorClass = "PixkuaInvoice.ClienteExpressForm"
            Me.EditorTitle = "Editar datos de cliente..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Cliente As Azteca.Business.Ventas.ClienteInfo = CType(Me.PackageInfo, Azteca.Business.Ventas.ClienteInfo)
        If Cliente IsNot Nothing Then
            TextInfo = Cliente.Nombre
            Key = Cliente.Identity
        End If
    End Sub

    Protected Overrides Sub OnSearchingItem(e As System.EventArgs)
        Dim ClienteFac As New Azteca.Business.Ventas.ClienteFacade
        Dim frm As New Azteca.Windows.Forms.BusinessForms.CatalogListForm
        If frm.ShowDialog(Me.FindForm, ClienteFac) = DialogResult.OK Then
            Me.PackageInfo = ClienteFac.GetDetail(Azteca.Windows.App.Session.SessionID, frm.SelectedItem)
            Dim Cliente As Azteca.Business.Ventas.ClienteInfo = CType(Me.PackageInfo, Azteca.Business.Ventas.ClienteInfo)
            If Cliente IsNot Nothing Then
                TextInfo = Cliente.Nombre
                SetItem(PackageInfo.UserCode)
                Key = Cliente.Identity
            End If
            LoadInfo()
        End If
    End Sub

End Class
