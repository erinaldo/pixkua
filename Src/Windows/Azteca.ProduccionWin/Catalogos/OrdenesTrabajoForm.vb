Imports Microsoft.Reporting.WinForms
Imports System.Drawing
Imports System.IO

Public Class OrdenesTrabajoForm

    Private Sub OrdenesTrabajoForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        'Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)

        bsInsumos.DataSource = Nothing
        bsEnsambles.DataSource = Nothing
        bsServicios.DataSource = Nothing
        grdInsumos.Rebind(True)
        grdEnsambles.Rebind(True)
        grdServicios.Rebind(True)
        cboAlmacenInsumos.LoadList(App.DefaultSite.IdSucursal)
        cboAlmacenPT.LoadList(App.DefaultSite.IdSucursal)
        gbTipoOrden.Enabled = True
    End Sub

    Private Sub OrdenesTrabajoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAlmacenInsumos.LoadList(App.DefaultSite.IdSucursal)
        cboAlmacenPT.LoadList(App.DefaultSite.IdSucursal)

    End Sub

    Private Sub OrdenesTrabajoForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)

        With info
            txtNombre.Text = .Nombre
            selArticuloStock.LoadInfo(.IdArticuloStock)
            selCuenta.LoadInfo(.IdCuenta)
            txtVersion.Text = .Version.ToString()
            chkEntregasParciales.Checked = .EntregasParciales
            chkExigirRecepcion.Checked = .ExigirRecepcion
            txtCantDeseada.Text = .CantDeseada.ToString()
            dtpFechaPromEntrega.Value = .FechaPromEntrega
            dtpFechaRecepcion.Value = .FechaRecepcion
            cboAlmacenInsumos.SelectedValue = .IdAlmacenInsumos
            cboAlmacenPT.SelectedValue = .IdAlmacenPT
            txtFolioPedido.Text = info.FolioPedido
            txtObervaciones.Text = info.Observaciones
            dtpFechaRequerida.Value = .FechaRequerida
            txtCantPlanillas.Text = .CantidadPlanillas.ToString()
            cboArea.Text = .Area

            If (.Tipo = "W") Then
                rdbTipoOrdenTrabajo.Checked = True
            Else
                rdbTipoMaestroIng.Checked = True
            End If

            gbTipoOrden.Enabled = False

        End With

        Call CargarInsumos(info.Identity)
        Call CargarEnsambles(info.Identity)
        Call CargarServicios(info.Identity)


    End Sub

    Private Sub CargarInsumos(ByVal idOrdenTrabajo As Integer)
        Dim OTFacade As New OrdenTrabajoFacade()
        bsInsumos.DataSource = OTFacade.LoadInsumosOT(App.Session.SessionID, idOrdenTrabajo)
        grdInsumos.Rebind(True)
    End Sub

    Private Sub CargarEnsambles(ByVal idOrdenTrabajo As Integer)
        Dim OTFacade As New OrdenTrabajoFacade()
        bsEnsambles.DataSource = OTFacade.LoadEnsamblesOT(App.Session.SessionID, idOrdenTrabajo)
        grdEnsambles.Rebind(True)
    End Sub

    Private Sub CargarServicios(ByVal idOrdenTrabajo As Integer)
        Dim OTFacade As New OrdenTrabajoFacade()
        bsServicios.DataSource = OTFacade.LoadServiciosOT(App.Session.SessionID, idOrdenTrabajo)
        grdServicios.Rebind(True)
    End Sub

    Private Sub OrdenesTrabajoForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)

        With info
            .Nombre = txtNombre.Text
            .IdArticuloStock = selArticuloStock.Key
            .IdCuenta = selCuenta.Key
            If (txtVersion.Text = "") Then
                .Version = 1
            Else
                .Version = CInt(txtVersion.Text)
            End If

            .EntregasParciales = chkEntregasParciales.Checked
            .ExigirRecepcion = chkExigirRecepcion.Checked
            .CantDeseada = CDec(txtCantDeseada.Text)
            .FechaPromEntrega = dtpFechaPromEntrega.Value
            .FechaRecepcion = dtpFechaRecepcion.Value
            .Observaciones = ""
            .IdAlmacenInsumos = CInt(cboAlmacenInsumos.SelectedValue)
            .IdAlmacenPT = CInt(cboAlmacenPT.SelectedValue)
            .FolioPedido = txtFolioPedido.Text
            .Observaciones = txtObervaciones.Text
            .FechaRequerida = dtpFechaRequerida.Value
            If (rdbTipoMaestroIng.Checked) Then
                .Tipo = "M"
            Else
                .Tipo = "W"
            End If
            .CantidadPlanillas = CInt(IIf(txtCantPlanillas.Text = "", 0, txtCantPlanillas.Text))
            If (cboArea.Text <> String.Empty) Then
                .Area = cboArea.Text
            Else
                .Area = ""
            End If

        End With


    End Sub



    Private Sub grdInsumos_DeleteButtonClick(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs)

        Dim OTInfo As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)

        If (OTInfo.Identity > 0) Then

            If (MessageBox.Show("¿Esta seguro que desea eliminar el concepto?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then

                Try
                    Cursor = Cursors.WaitCursor
                    Dim InsumoRow As OrdenesTrabajoDS.InsumosRow = CType(bsInsumos.Current, OrdenesTrabajoDS.InsumosRow)
                    OTInfo.Insumos.RemoveInsumosRow(InsumoRow)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    Cursor = Cursors.Default
                End Try

            End If

        Else
            MessageBox.Show("Debe seleccionar el insumo a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnNuevoArt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoArt.Click
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
                Dim InsumoRow As OrdenesTrabajoDS.InsumosRow = info.Insumos.NewInsumosRow
                Dim frmArticuloSel As New OrdenesTrabajoInsumosSelForm

                If (frmArticuloSel.ShowDialog(Me, info.Identity, InsumoRow) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarInsumos(info.Identity)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información de la Orden de Trabajo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnNuevoEnsamble_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoEnsamble.Click
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
                Dim EnsambleRow As OrdenesTrabajoDS.EnsamblesRow = info.Ensambles.NewEnsamblesRow
                Dim frmEnsambleSel As New OrdenesTrabajoEnsamblesForm
                If (frmEnsambleSel.ShowDialog(Me, info.Identity, EnsambleRow) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarEnsambles(info.Identity)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información del ensamble", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdInsumos_EditButtonClick(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs) Handles grdInsumos.EditButtonClick
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
                Dim InsumoRow As OrdenesTrabajoDS.InsumosRow = GetInsumoByCurrent(bsInsumos.Current)
                Dim frmArticuloSel As New OrdenesTrabajoInsumosSelForm
                If (frmArticuloSel.ShowDialog(Me, info.Identity, InsumoRow) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarInsumos(info.Identity)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información de la OT", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function GetEnsambleByCurrent(ByVal ensambleCurrent As Object) As OrdenesTrabajoDS.EnsamblesRow
        Dim row As OrdenesTrabajoDS.EnsamblesRow = CType(PackageInfo, OrdenTrabajoInfo).Ensambles.NewEnsamblesRow

        Try
            Dim currentView As DataRowView = CType(ensambleCurrent, DataRowView)
            row.IdEnsamble = CInt(currentView("IdEnsamble"))
            row.IdOrdenTrabajo = CInt(currentView("IdOrdenTrabajo"))
            row.Orden = CShort(currentView("Orden"))
            row.HorasMaquina = CDec(currentView("HorasMaquina"))
            row.CostoMaquina = CDec(currentView("CostoMaquina"))
            row.HorasLabor = CDec(currentView("HorasLabor"))
            row.CostoLabor = CDec(currentView("CostoLabor"))
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return row

    End Function

    Private Function GetInsumoByCurrent(ByVal insumoCurrent As Object) As OrdenesTrabajoDS.InsumosRow
        Dim row As OrdenesTrabajoDS.InsumosRow = CType(PackageInfo, OrdenTrabajoInfo).Insumos.NewInsumosRow

        Try
            Dim currentView As DataRowView = CType(insumoCurrent, DataRowView)
            row.IdArticuloStock = CInt(currentView("IdArticuloStock"))
            row.Cantidad = CDec(currentView("Cantidad"))
            row.Surtir = CBool(currentView("Surtir"))
            row.IdUnidadMedida = CInt(currentView("IdUnidadMedida"))
            row.IdUnidadMedidaTipo = CInt(currentView("IdUnidadMedidaTipo"))
            row.IdOrdenTrabajo = CInt(currentView("IdOrdenTrabajo"))
            row.Costo = CDec(currentView("Costo"))
            row.MermaPorc = CDec(currentView("MermaPorc"))
            row.TipoMerma = CStr(currentView("TipoMerma"))
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return row

    End Function

    Private Sub grdInsumos_DeleteButtonClick_1(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs) Handles grdInsumos.DeleteButtonClick
        Try
            If (MessageBox.Show("¿Esta seguro de eliminar el insumo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                Dim row As OrdenesTrabajoDS.InsumosRow = GetInsumoByCurrent(bsInsumos.Current)

                Dim CatalogFacade As New OrdenTrabajoFacade()
                CatalogFacade.DeleteInsumoOT(App.Session.SessionID, row.IdOrdenTrabajo, row.IdArticuloStock)
                Call CargarInsumos(row.IdOrdenTrabajo)
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try




    End Sub

    Private Sub DataGridViewCatalog1_DeleteButtonClick(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs) Handles grdEnsambles.DeleteButtonClick

        Try
            If (MessageBox.Show("¿Seguro que desea eliminar el ensamble?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                Dim row As OrdenesTrabajoDS.EnsamblesRow = GetEnsambleByCurrent(bsEnsambles.Current)

                Dim CatalogFacade As New OrdenTrabajoFacade()
                CatalogFacade.DeleteEnsambleOT(App.Session.SessionID, row.IdOrdenTrabajo, row.IdEnsamble)
                Call CargarEnsambles(row.IdOrdenTrabajo)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try


    End Sub

    Private Sub DataGridViewCatalog1_EditButtonClick(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs) Handles grdEnsambles.EditButtonClick
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
                Dim EnsambleRow As OrdenesTrabajoDS.EnsamblesRow = GetEnsambleByCurrent(bsEnsambles.Current)
                Dim frmEnsambleSel As New OrdenesTrabajoEnsamblesForm
                If (frmEnsambleSel.ShowDialog(Me, info.Identity, EnsambleRow) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarEnsambles(info.Identity)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información del la OT", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        'Cargar información del informe
        Dim OTFac As New OrdenTrabajoFacade
        Dim dtOrdenTrabajo As DataTable = OTFac.GetInformeOrdenTrabajo(App.Session.SessionID, CInt(PackageInfo.Identity))
        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Dim barcode As Zen.Barcode.Code128BarcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum
        Dim ImageID As Image = barcode.Draw(PackageInfo.UserCode + "", 50)

        Parametros.Add(New ReportParameter("BarCodeID", ImageToBase64(ImageID, System.Drawing.Imaging.ImageFormat.Jpeg)))

        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Produccion.OrdenTrabajo.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("OrdenTrabajoDS", dtOrdenTrabajo))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Informe - Orden de Trabajo")
    End Sub

    Public Shared Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Using ms As MemoryStream = New MemoryStream()
            Dim bmp As Bitmap = New Bitmap(image)
            bmp.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray()
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Return base64String
        End Using
    End Function

    Private Sub rdbTipoMaestroIng_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTipoOrdenTrabajo.CheckedChanged, rdbTipoMaestroIng.CheckedChanged
        txtFolioPedido.Enabled = rdbTipoOrdenTrabajo.Checked
        dtpFechaPromEntrega.Enabled = rdbTipoOrdenTrabajo.Checked
        dtpFechaRecepcion.Enabled = rdbTipoOrdenTrabajo.Checked
        dtpFechaRequerida.Enabled = rdbTipoOrdenTrabajo.Checked

    End Sub

    Private Sub btnNuevoServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoServicio.Click
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
                Dim ServicioRow As OrdenesTrabajoDS.ServiciosRow = info.Servicios.NewServiciosRow
                Dim frmServiciosSel As New OrdenTrabajoServiciosForm

                If (frmServiciosSel.ShowDialog(Me, info.Identity, ServicioRow) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarServicios(info.Identity)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información de la Orden de Trabajo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdServicios_DeleteButtonClick(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs)

    End Sub

    Private Function GetServicioByCurrent(ByVal servicioCurrent As Object) As OrdenesTrabajoDS.ServiciosRow
        Dim row As OrdenesTrabajoDS.ServiciosRow = CType(PackageInfo, OrdenTrabajoInfo).Servicios.NewServiciosRow

        Try
            Dim currentView As DataRowView = CType(servicioCurrent, DataRowView)
            row.IdServicio = CInt(currentView("IdServicio"))
            row.Cantidad = CDec(currentView("Cantidad"))
            row.IdOrdenTrabajo = CInt(currentView("IdOrdenTrabajo"))
            row.Costo = CDec(currentView("Costo"))
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return row

    End Function

    Private Sub grdServicios_EditButtonClick(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs)

    End Sub

    Private Sub DataGridViewCatalog1_EditButtonClick_1(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.EditButtonClick


    End Sub

    Private Sub DataGridViewCatalog1_DeleteButtonClick_1(ByVal sender As System.Object, ByVal e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs) Handles grdServicios.DeleteButtonClick
        Dim row As OrdenesTrabajoDS.ServiciosRow = GetServicioByCurrent(bsServicios.Current)

        Dim CatalogFacade As New OrdenTrabajoFacade()
        CatalogFacade.DeleteInsumoOT(App.Session.SessionID, row.IdOrdenTrabajo, row.IdServicio)
        Call CargarServicios(row.IdOrdenTrabajo)

    End Sub

    Private Sub cmdClonar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClonar.Click
        Try
            Dim CrearOTDialog As New CrearOrdenTrabajoByMaestroForm()

            If (rdbTipoOrdenTrabajo.Checked) Then
                If (CrearOTDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                    LoadItem(CrearOTDialog._OrdenTrabajoIdentity)
                Else
                    MessageBox.Show("Error al clonar el maestro de Ingenieria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Seleccione el tipo de orden de trabajo para generar una copia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub OrdenesTrabajoForm_ItemSaved(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ItemSaved
        Try
            Dim CurrentPackage As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
            LoadItem(CurrentPackage.Identity)
            gbTipoOrden.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        Try
            If PackageInfo.Identity > 0 Then
                Me.Cursor = Cursors.WaitCursor
                Try
                    Dim info As OrdenTrabajoInfo = CType(PackageInfo, OrdenTrabajoInfo)
                    Dim ServicioRow As OrdenesTrabajoDS.ServiciosRow = GetServicioByCurrent(bsServicios.Current)
                    Dim frmServicioSel As New OrdenTrabajoServiciosForm
                    If (frmServicioSel.ShowDialog(Me, info.Identity, ServicioRow) = System.Windows.Forms.DialogResult.OK) Then
                        Call CargarServicios(info.Identity)
                    End If

                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    Me.Cursor = Cursors.Default
                End Try

            Else
                MessageBox.Show("Primero debe guardar la información de la OT", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Try


            Dim row As OrdenesTrabajoDS.ServiciosRow = GetServicioByCurrent(bsServicios.Current)

            If (MessageBox.Show("¿Esta seguro de eliminar el servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                Dim CatalogFacade As New OrdenTrabajoFacade()
                CatalogFacade.DeleteServicioOT(App.Session.SessionID, row.IdOrdenTrabajo, row.IdServicio)
                Call CargarServicios(row.IdOrdenTrabajo)
            End If


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class