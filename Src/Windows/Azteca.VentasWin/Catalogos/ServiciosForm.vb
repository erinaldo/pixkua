Public Class ServiciosForm

    Private Sub EditarZona()
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        Dim drZona As ZonasVentaDS.ZonasRow = CType(CType(bsZonas.Current, DataRowView).Row, ZonasVentaDS.ZonasRow)
        Dim frmEditZona As New EditServicioZonaForm
        If frmEditZona.ShowDialog(Me, Servicio.Identity, drZona) = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub ServiciosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        bsZonas.DataSource = Servicio.ZonasVenta
        grdZonas.Rebind(True)
    End Sub

    Private Sub ServiciosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ServiciosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        With Servicio
            txtNombre.Text = .Nombre
            txtEstCom.Text = String.Empty
            txtCuenta.Text = String.Empty
            If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
            If .IdEstructuraComercial > 0 Then txtEstCom.LoadInfo(.IdEstructuraComercial)
            chkConceptoLibre.Checked = .ConceptoLibre
            bsZonas.DataSource = .ZonasVenta
            grdZonas.Rebind(True)
        End With
    End Sub

    Private Sub ServiciosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        With Servicio
            .Nombre = txtNombre.Text
            .IdEstructuraComercial = txtEstCom.Key
            .IdCuenta = txtCuenta.Key
            .ConceptoLibre = chkConceptoLibre.Checked
        End With
    End Sub

    Private Sub btnAgregarZona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarZona.Click
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim drZona As ZonasVentaDS.ZonasRow = Servicio.ZonasVenta.NewZonasRow
            Dim frmEditZona As New EditServicioZonaForm
            If frmEditZona.ShowDialog(Me, Servicio.Identity, drZona) = System.Windows.Forms.DialogResult.OK Then
                If Servicio.ZonasVenta.FindByIdZonaVenta(drZona.IdZonaVenta) Is Nothing Then
                    Servicio.ZonasVenta.AddZonasRow(drZona)
                Else
                    MessageBox.Show("La zona de ventas que intenta agregar ya existe para éste servicio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub


    Private Sub grdZonas_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdZonas.DeleteButtonClick
        Dim Servicio As ServicioInfo = CType(PackageInfo, ServicioInfo)
        If bsZonas.Current IsNot Nothing Then
            Try
                Dim Result As DialogResult = MessageBox.Show("¿Esta seguro que desea quitar la zona de ventas seleccionada del servicio actual?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    bsZonas.RemoveCurrent()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdZonas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdZonas.DoubleClick
        If bsZonas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarZona()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub grdZonas_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdZonas.EditButtonClick
        If bsZonas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarZona()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub
End Class