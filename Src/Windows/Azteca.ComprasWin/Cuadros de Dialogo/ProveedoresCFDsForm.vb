Public Class ProveedoresCFDsForm
    Private _ComprobanteFiscal As Azteca.Business.Compras.ComprobanteFiscalInfo
    Private IdProveedor As Integer

    Public ReadOnly Property ComprobanteFiscal As ComprobanteFiscalInfo
        Get
            Return _ComprobanteFiscal
        End Get
    End Property

    Public Overloads Function ShowDialog(owner As Form, idProveedor As Integer) As DialogResult
        Me.IdProveedor = idProveedor
        selProveedor.LoadInfo(idProveedor) : selProveedor.Enabled = False
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs) Handles btnRefrescar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ComprobanteFac As New ComprobanteFiscalFacade
            bsComprobantes.DataSource = ComprobanteFac.ListaPorPeriodo(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, App.DefaultCompany.Identity, selProveedor.Key)
            grdComprobantes.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If IsNothing(bsComprobantes.Current) Then
            MessageBox.Show("Debe seleccionar un elemento de la lista", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Try
            Dim Row As DataRowView = CType(bsComprobantes.Current, DataRowView)

            Dim ComprobanteFac As New ComprobanteFiscalFacade
            _ComprobanteFiscal = ComprobanteFac.GetComprobante(App.Session.SessionID, selProveedor.Key, CStr(Row("Serie")), CInt(Row("Folio")), CStr(Row("UUID")))
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

   
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class