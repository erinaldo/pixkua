Public Class ConfigSucursalesForm
    Private Empresa As EmpresaConfigInfo
    Private Configuracion As SucursalesConfigDS.SucursalesDataTable
    Private Series As DataTable
    Private Formatos As DataTable

    Private Sub CargarSeries()
        Dim SerieFac As New SerieFacade
        Dim dtSeries As DataTable = SerieFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
        bsSerieCargo.DataSource = dtSeries
        bsSerieCredito.DataSource = dtSeries
        cboSerieCargo.Rebind(True)
        cboSerieCredito.Rebind(True)
    End Sub

    Private Sub CargarFormatos()
        Dim FormatMgr As New Azteca.Kernel.General.FormatManager
        Formatos = FormatMgr.LoadList(App.Session.SessionID, App.DefaultCompany.Identity, 0, 0)
        bsFormatoCargo.DataSource = Formatos
        bsFormatoCredito.DataSource = Formatos
        cboFormatoCargo.Rebind(True)
        cboFormatoCredito.Rebind(True)
    End Sub

    Private Sub ConfigSucursalesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Sucursales
            Dim SucursalConfig As New SucursalConfigFacade
            Configuracion = SucursalConfig.CargarConfiguraciones(App.Session.SessionID, App.DefaultCompany.Identity)
            bsSucursales.DataSource = Configuracion
            grdSucursales.Rebind(True)
            cboTimbrador.LoadList()
            CargarFormatos()
            CargarSeries()
            LoadEmpresa()
            LoadSegmentos()
            LoadStatus()
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim SucursalConfig As New SucursalConfigFacade
            SucursalConfig.GuardarConfiguracion(App.Session.SessionID, Configuracion)
            MessageBox.Show("Los cambios en la configuración han sido guardados con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub LoadEmpresa()
        Try
            Dim EmpresaConfig As New EmpresaConfigFacade
            Empresa = EmpresaConfig.GetDetail(App.Session.SessionID, App.DefaultCompany.Identity)
            'Llenamos los datos
            lblEmpresaTXT.Text = Empresa.Empresa
            txtFormatoContable.Text = Empresa.FormatoContable
            txtBaseDatos.Text = Empresa.BaseDatos
            txtRegimenFiscal.Text = Empresa.RegimenFiscal
            cboTimbrador.SelectedValue = Empresa.IdTimbrador
            upDwnIdServicio.Value = Empresa.IdServicio
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub LoadSegmentos()
        Try
            Dim SegmentoFac As New SegmentoNegocioFacade
            bsSegmentos.DataSource = SegmentoFac.SegmentosNegocioCBO(App.Session.SessionID, App.DefaultCompany.Identity)
            grdSegmentos.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub LoadStatus()
        Dim dt As New EjercicioFiscalDS.StatusDataTable
        Dim dr0 As EjercicioFiscalDS.StatusRow = dt.NewStatusRow
        dr0.IdStatus = 0 : dr0.Status = "Cerrado"
        dt.AddStatusRow(dr0)

        Dim dr1 As EjercicioFiscalDS.StatusRow = dt.NewStatusRow
        dr1.IdStatus = 1 : dr1.Status = "Abierto"
        dt.AddStatusRow(dr1)

        bsStatus.DataSource = dt
        dropStatus.Rebind(True)
    End Sub

    Private Sub btnGuardarEmpresas_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdGuardarEmpresas.Click
        Try
            Dim EmpresaConfig As New EmpresaConfigFacade
            With Empresa
                .FormatoContable = txtFormatoContable.Text
                .BaseDatos = txtBaseDatos.Text
                .IdServicio = upDwnIdServicio.Value
                .RegimenFiscal = txtRegimenFiscal.Text.Trim
                .IdTimbrador = CInt(cboTimbrador.SelectedValue)
            End With
            EmpresaConfig.Update(App.Session.SessionID, Empresa)
            MessageBox.Show("Se han actualizado los datos de la empresa correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdSegmentos_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdSegmentos.AfterUpdate
        Try
            Dim SegmentoFac As New SegmentoNegocioFacade
            Dim segmento As SegmentoNegocioInfo
            If IsDBNull(grdSegmentos.Columns("Id").Value) Then
                segmento = New SegmentoNegocioInfo(App.Session.SessionID)
                segmento.UserCode = ""
                segmento.Status = CatalogState.Active
                segmento.IdSucursal = App.DefaultSite.Identity
                segmento.IdEmpresa = App.DefaultCompany.Identity
            Else
                segmento = SegmentoFac.GetDetail(App.Session.SessionID, grdSegmentos.Columns("Id").Value)
            End If
            segmento.Descripcion = grdSegmentos.Columns("Descripcion").Value
            SegmentoFac.Update(segmento)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdSegmentos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdSegmentos.DeleteButtonClick
        Try
            Dim SegmentoFac As New SegmentoNegocioFacade
            SegmentoFac.Delete(App.Session.SessionID, e.ID)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


#Region "Ejercicio Fiscal"

    Private Sub cmdEjercicioRefrescar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdActualizarEjercicios.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            EjerciciosFiscalesRefrescar()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnEjercicioNuevo_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdNuevoEjercicio.Click
        Try
            EjercicioFiscalNuevo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnEjercicioCerrar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCerrarEjercicio.Click

    End Sub

    Private Sub cboEjercicios_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEjercicio.SelectedValueChanged
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            If IsNothing(cboEjercicio.SelectedValue) Then Exit Sub
            Dim EjercicioFac As New EjercicioFiscalFacade
            Dim EjercicioInfo As EjercicioFiscalInfo = EjercicioFac.GetDetail(App.Session.SessionID, CStr(cboEjercicio.SelectedValue))

            If EjercicioInfo.Status = 1 Then
                Dim dv As New DataView(EjercicioInfo.PeriodosTable, "Activo=1", "", DataViewRowState.CurrentRows)
                If dv.Count = 0 Then cmdCerrarEjercicio.Enabled = True
            End If
            bsPeriodos.DataSource = EjercicioInfo.PeriodosTable
            grdPeriodos.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdPeriodos_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdPeriodos.BeforeUpdate
        Dim EjercicioFac As New EjercicioFiscalFacade
        Try
            If grdPeriodos.Columns("Activo").Value = 0 Then
                EjercicioFac.PeriodoCerrar(App.Session.SessionID, CStr(cboEjercicio.SelectedValue), grdPeriodos.Columns("Mes").Value)
            Else
                EjercicioFac.PeriodoAbrir(App.Session.SessionID, CStr(cboEjercicio.SelectedValue), grdPeriodos.Columns("Mes").Value)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
            e.Cancel = True
        End Try
    End Sub


    Private Sub EjerciciosFiscalesRefrescar()
        cboEjercicio.LoadList(App.DefaultCompany.Identity)
        bsPeriodos.DataSource = Nothing
        cmdNuevoEjercicio.Enabled = True
    End Sub

    Private Sub EjercicioFiscalNuevo()
        Try
            Dim EjercicioFac As New EjercicioFiscalFacade
            Dim EjercicioInfo As New EjercicioFiscalInfo(App.Session.SessionID)
            EjercicioInfo = EjercicioInfo.NuevoEjercicio(EjercicioFac.GetUltimoEjercicio(App.Session.SessionID, App.DefaultCompany.Identity), EjercicioInfo)
            EjercicioInfo.IdEmpresa = App.DefaultCompany.Identity : EjercicioInfo.IdSucursal = App.DefaultCompany.Identity
            EjercicioFac.Update(EjercicioInfo)

            EjerciciosFiscalesRefrescar()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region



    Private Sub btnRacAdd_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub btnRefrescar_Click(sender As System.Object, e As System.EventArgs)

    End Sub
    Private Sub grdRacs_EditButtonClick(sender As System.Object, e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs)

    End Sub
    Private Sub grdRacs_DeleteButtonClick(sender As System.Object, e As Azteca.Windows.Controls.GridViewCatalogButtonEventArgs)

    End Sub
End Class