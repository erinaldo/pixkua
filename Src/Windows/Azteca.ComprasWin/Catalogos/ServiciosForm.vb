Public Class ServiciosForm

    Private Sub ServiciosForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
    End Sub

    Private Sub ServiciosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            CargarZonas()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ServiciosForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        With Servicio
            txtNombre.Text = .Nombre
        End With
    End Sub

    Private Sub ServiciosForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        With Servicio
            .Nombre = txtNombre.Text
        End With
    End Sub

#Region "Zonas"

    Private Sub CargarZonas()
        Dim ZonaFac As New ZonaCompraFacade
        Dim Zonas As DataTable = ZonaFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity, App.Session.User.Identity)
        bsZonas.DataSource = Zonas
        grdZonas.Rebind(True)
    End Sub

    Private Sub cmdProveedores_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdProveedores.Click
        If bsZonas.Current IsNot Nothing Then
            Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
            If Servicio.Identity > 0 Then
                Try
                    Dim IdZona As Integer = CInt(grdZonas.Columns("ID").Value)
                    Dim frmProveedores As New ProveedoresServicioForm
                    If frmProveedores.ShowDialog(Me, IdZona, Servicio.Identity, False) = System.Windows.Forms.DialogResult.OK Then

                    End If
                Catch ex As Exception
                    MsgInfo.Show(ex)
                End Try
            Else
                MessageBox.Show("Primero debe guardar los datos del servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Debe seleccionar una zona de compra.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

End Class