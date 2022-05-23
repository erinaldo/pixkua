Imports Azteca.Windows

Public Class EmpresaExpressForm

    Protected Overrides Sub OnAddSucursal()
        Dim frm As New UnidadNegocioExpressForm
        Dim UnidadNegocio As New Azteca.Business.Ventas.UnidadNegocioInfo(App.Session.SessionID)
        UnidadNegocio.IdEmpresa = PackageInfo.Identity
        If frm.ShowDialog(Me, UnidadNegocio, "Agregar Sucursal") = Windows.Forms.DialogResult.OK Then
            LoadSucursales()
        End If
    End Sub

    Protected Overrides Sub onEditSucursal(IdSucursal As Integer)

        Dim frm As New UnidadNegocioExpressForm
        Dim UnidadNegocioFac As New Azteca.Business.Ventas.UnidadNegocioFacade
        Dim unidadNegocio As Azteca.Business.Ventas.UnidadNegocioInfo = UnidadNegocioFac.GetDetailFromCacheByIdSucursal(App.Session.SessionID, IdSucursal)

        If frm.ShowDialog(Me, unidadNegocio.Identity, "Agregar Sucursal") = Windows.Forms.DialogResult.OK Then
            LoadSucursales()
        End If
    End Sub

    Private Sub EmpresaExpressForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class