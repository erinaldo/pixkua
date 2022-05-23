Imports Microsoft.Reporting.WinForms
Imports Azteca.Business.RH
Imports System.Drawing
Imports System.IO

Public Class AdminOTForm

    Dim CurrentStatusTlb As WorkFlowStatus
    Dim lastCodigoOT As String = ""
    Dim _EmpleadoCurrent As Azteca.Business.RH.EmpleadoInfo
    Dim _Minuto As Integer
    Dim _Segundo As Integer
    Dim _MinutosMax As Integer


    Private Sub cmdGuardados_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdGuardados.Click
        CurrentStatusTlb = WorkFlowStatus.Guardado
        Call CargarOrdenesTrabajo(CurrentStatusTlb, 0)
    End Sub

    Private Sub CargarOrdenesTrabajo(ByVal WorkFlowStatus As WorkFlowStatus, ByVal idEnsamble As Integer)
        Try
            If (_EmpleadoCurrent.Identity > 0) Then
                Dim OTFacade As New OrdenTrabajoFacade()
                bsOrdenesTrabajo.DataSource = OTFacade.LoadOrdenesTrabajoAdmin(App.Session.User.SessionID, WorkFlowStatus, idEnsamble, App.DefaultSite.Identity)
                grdOrdenesTrabajo.Rebind(True)
                Call ToolBarApplyEnables(New ToolBarStatus())
                lastCodigoOT = ""
                cboEnsambles.Focus()
            Else
                MessageBox.Show("Favor de iniciar sesión", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        
    End Sub

    Private Sub AdminOTForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call CargarOrdenesTrabajo(WorkFlowStatus.Guardado, 0)
        cboEnsambles.LoadList(App.DefaultCompany.Identity)
        cboEnsambles.SelectedValue = 0
        _EmpleadoCurrent = New Azteca.Business.RH.EmpleadoInfo(App.Session.SessionID)
        _MinutosMax = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Produccion/AdminOT", "MinutosMaxSesion"))

        _Minuto = _MinutosMax
        _Segundo = 0

    End Sub

    Private Sub tlbActualizar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbActualizar.Click
        Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbSiguiente.Click
        Dim OTFac As New OrdenTrabajoFacade()

        Try
            Dim OTSelected As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
            Dim otInfo As OrdenTrabajoInfo = OTFac.GetDetail(App.Session.SessionID, OTSelected.IdOrdenTrabajo)
            Dim salidaID As String

            If (_EmpleadoCurrent.Identity > 0) Then

                If (otInfo.EnsambleSiguiente.Identity > 0) Then

                    'Si la Orden todavia no es liberada entonces surtirla
                    If (otInfo.WorkFlowStatus = WorkFlowStatus.Guardado) Then

                        If (MessageBox.Show("¿Desea iniciar el proceso de produccion afectando inventarios? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then

                            'Invocamos el dialog para dar salida a los insumos necesarios y pasar a la OT a su primer Ensamble
                            Dim LiberarSelForm As New LiberarOrdenTrabajoSelForm()
                            If (LiberarSelForm.ShowDialog(Me, otInfo) = System.Windows.Forms.DialogResult.OK) Then
                                'Se genera la salida de los insumos marcados solo como Surtir
                                salidaID = OTFac.GenerarSalidaInumos(App.Session.SessionID, otInfo, True, _EmpleadoCurrent.Identity)
                                Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                                MessageBox.Show("La salida de los insumos se genero con exito Folio: " & salidaID, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            'Se inicia el proceso de la OT sin afectar inventarios
                            salidaID = OTFac.GenerarSalidaInumos(App.Session.SessionID, otInfo, False, _EmpleadoCurrent.Identity)
                            Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                            MessageBox.Show("La orden trabajo " & otInfo.UserCode & " inicio su proceso sin afectar inventarios con exito: ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If


                        'Si la Orden ya fue surtida entonces solo aplicar cambios de status y ensamble 
                    ElseIf (otInfo.WorkFlowStatus = WorkFlowStatus.Liberado) Then
                        If (MessageBox.Show("La Orden de Trabajo " & otInfo.UserCode & " sera enviada al ensamble: " & UCase(otInfo.EnsambleSiguiente.Nombre), "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK) Then
                            'Creamos el movimiento para insertar
                            Dim mov As New Movimiento()
                            mov.IdEnsamble = otInfo.EnsambleSiguiente.Identity
                            mov.IdOrdenTrabajo = otInfo.Identity
                            mov.Clase = "IP"
                            mov.IdEmpleado = _EmpleadoCurrent.Identity
                            Dim msgError As String = OTFac.AddMovimiento(App.Session.SessionID, mov)
                            If (msgError <> "") Then
                                MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                'Invocamos el metodo para cambiar de status de una ot
                                OTFac.ApplyWorkflow(App.Session.SessionID, otInfo, WorkFlowStatus.Liberado)
                                Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                                MessageBox.Show("La orden de trabajo fue enviada al siguiente ensamble correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                ElseIf (otInfo.EnsambleSiguiente.Identity = 0) Then
                    MessageBox.Show("La orden de trabajo no cuenta con ensambles", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'Si la OT ha llegado al final de la cadena de producción
                ElseIf (otInfo.EnsambleSiguiente.Identity = -1) Then

                    If (MessageBox.Show("La orden de trabajo ha llegado al fin de la cadena de producción, ¿Desea finalizar el proceso del ensamble actual (" & otInfo.EnsambleActual.Nombre & ") ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                        Dim mov As New Movimiento()
                        mov.IdEnsamble = otInfo.EnsambleActual.Identity
                        mov.IdOrdenTrabajo = otInfo.Identity
                        mov.Clase = TipoMovimientoOT.FinProceso
                        mov.IdEmpleado = _EmpleadoCurrent.Identity

                        Dim msgError As String = OTFac.AddMovimiento(App.Session.SessionID, mov)
                        If (msgError <> "") Then
                            MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            MessageBox.Show("Proceso finalizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                End If

            Else
                MessageBox.Show("Favor de Iniciar Sesión", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cmbLib_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmbLib.Click
        CurrentStatusTlb = WorkFlowStatus.Liberado
        Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
    End Sub

    Private Sub tlbEmitirRecibir_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbRecibirEntregar.Click
        Try
            If (_EmpleadoCurrent.Identity > 0) Then
                Dim OrdenTrabajoRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
                Dim OTFac As New OrdenTrabajoFacade()
                Dim OTInfo As New OrdenTrabajoInfo(App.Session.SessionID)

                OTInfo = OTFac.GetDetail(App.Session.SessionID, OrdenTrabajoRow.IdOrdenTrabajo)

                Dim RecibirEntregarSelForm As New RecibirEntregarWOSelForm()

                If (RecibirEntregarSelForm.ShowDialog(Me, OTInfo, _EmpleadoCurrent.Identity) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                End If

            Else

                MessageBox.Show("Favor de Iniciar Sesión del Operador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#Region "Metodos propios de la forma"

    Private Function GetCurrentGrdOrdenTrabajo(ByVal current As Object) As OrdenesTrabajoDS.OrdenesTrabajoRow

        Dim OrdenesTrabajoDT As New OrdenesTrabajoDS.OrdenesTrabajoDataTable
        Dim currentRow As OrdenesTrabajoDS.OrdenesTrabajoRow
        Dim drv As DataRowView

        If (bsOrdenesTrabajo.Count > 0) Then
            currentRow = OrdenesTrabajoDT.NewOrdenesTrabajoRow
            drv = CType(current, DataRowView)
        End If

        Try
            With currentRow
                .IdOrdenTrabajo = CInt(drv("IdOrdenTrabajo"))
                .IdArticuloStock = CInt(drv("IdArticuloStock"))
                .OT = drv("OT").ToString()
                .Codigo = drv("Codigo").ToString()
                .Articulo = drv("Articulo").ToString()
                .Cantidad = CDec(drv("Cantidad"))
                If (drv("CantidadRecibida") Is DBNull.Value) Then
                    .CantidadRecibida = 0
                Else
                    .CantidadRecibida = CDec(drv("CantidadRecibida"))
                End If
                .EntregasParciales = CBool(drv("EntregasParciales"))
                .ExigirRecepcion = CBool(drv("ExigirRecepcion"))
                .IdEnsambleActual = CInt(drv("IdEnsambleActual"))
                .IdIncidenciaActual = CInt(drv("IdIncidenciaActual"))
                .IdStatus = CInt(drv("IdStatus"))
                .IdWorkFlow = CInt(drv("IdWorkFlow"))
                If (drv("FechaEnsambleUltimaEntrega") IsNot DBNull.Value) Then
                    .FechaEnsambleUltimaEntrega = CDate(drv("FechaEnsambleUltimaEntrega"))
                End If
                If (drv("FechaEnsambleUltimaRecepcion") IsNot DBNull.Value) Then
                    .FechaEnsambleUltimaRecepcion = CDate(drv("FechaEnsambleUltimaRecepcion"))
                End If
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return currentRow
    End Function

    Private Sub ToolBarConfigByOT(ByVal currentOT As OrdenesTrabajoDS.OrdenesTrabajoRow)
        Dim tlbStatus As New ToolBarStatus()
        If (currentOT.IdWorkFlow = WorkFlowStatus.Guardado) Then
            tlbStatus.SiguienteWF = True

        ElseIf (currentOT.IdWorkFlow = WorkFlowStatus.Liberado) Then
            tlbStatus.RecibirEntregar = True
            tlbStatus.AgregarIncidencia = True
            tlbStatus.SiguienteWF = True
            If (currentOT.IdIncidenciaActual > 0) Then
                tlbStatus.CerrarIncidencia = True
            End If
            tlbStatus.CerrarOT = True
            tlbStatus.SurtirInsumos = True
            tlbStatus.DescargarPT = True

        ElseIf (currentOT.IdWorkFlow = WorkFlowStatus.EnEspera) Then
            tlbStatus.CerrarIncidencia = True
        End If

        Call ToolBarApplyEnables(tlbStatus)
    End Sub

    Private Sub ToolBarApplyEnables(ByVal tlbStatus As ToolBarStatus)
        tlbSiguiente.Enabled = tlbStatus.SiguienteWF
        tlbRecibirEntregar.Enabled = tlbStatus.RecibirEntregar
        tlbAgregarIncidencia.Enabled = tlbStatus.AgregarIncidencia
        tlbCerrarIncidencia.Enabled = tlbStatus.CerrarIncidencia
        tlbCierreOT.Enabled = tlbStatus.CerrarOT
        InvTrans.Enabled = tlbStatus.DescargarPT
        'tlbRecibirFabricacion.Enabled = tlbStatus.DescargarPT
        'tlbSurtirMP.Enabled = tlbStatus.SurtirInsumos
    End Sub


#End Region

    Private Sub grdOrdenesTrabajo_RowColChange(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles grdOrdenesTrabajo.RowColChange

        If (bsOrdenesTrabajo.Count > 0) Then
            Dim OTRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)

            If (OTRow IsNot Nothing And lastCodigoOT <> OTRow.OT) Then
                Call ToolBarConfigByOT(OTRow)
                lastCodigoOT = OTRow.OT
            End If
        Else
            lastCodigoOT = ""
            Call ToolBarApplyEnables(New ToolBarStatus())
        End If

    End Sub

    Private Sub grdOrdenesTrabajo_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdOrdenesTrabajo.ButtonClick
        Dim OTMovimientosSelForm As New OrdenesTrabajoMovsSelForm()
        Dim OrdenTrabajoRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)

        If (e.Column.Name = "M") Then
            OTMovimientosSelForm.ShowDialog(Me, OrdenTrabajoRow, _EmpleadoCurrent)
        ElseIf (e.Column.Name = "I") Then
            'Cargar información del informe
            Dim OTFac As New OrdenTrabajoFacade
            Dim dtOrdenTrabajo As DataTable = OTFac.GetInformeOrdenTrabajo(App.Session.SessionID, OrdenTrabajoRow.IdOrdenTrabajo)
            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Dim barcode As Zen.Barcode.Code128BarcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum
            Dim ImageID As Image = barcode.Draw(OrdenTrabajoRow.Codigo + "\t\n", 50)

            Parametros.Add(New ReportParameter("BarCodeID", ImageToBase64(ImageID, System.Drawing.Imaging.ImageFormat.Jpeg)))
            'Configurar reporte
            Dim frmFacturas As New ReportForm
            frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Produccion.OrdenTrabajo.rdlc"
            frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("OrdenTrabajoDS", dtOrdenTrabajo))
            frmFacturas.LocalReport.SetParameters(Parametros)
            frmFacturas.Show("Informe - Orden de Trabajo")
        End If
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

    Private Sub tlbAgregarIncidencia_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbAgregarIncidencia.Click
        Try

            If (_EmpleadoCurrent.Identity > 0) Then

                Dim AgregarIncSelForm As New AgregarIncidenciaWOSel
                Dim OrdenTrabajoRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
                Dim OTFac As New OrdenTrabajoFacade()
                Dim OTInfo As New OrdenTrabajoInfo(App.Session.SessionID)

                OTInfo = OTFac.GetDetail(App.Session.SessionID, OrdenTrabajoRow.IdOrdenTrabajo)
                If (AgregarIncSelForm.ShowDialog(Me, OTInfo, _EmpleadoCurrent.Identity) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                End If

            Else

                MessageBox.Show("Favor de Iniciar Sesión del Operador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub enEspera_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles enEspera.Click
        CurrentStatusTlb = WorkFlowStatus.EnEspera
        Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
    End Sub

    Private Sub tlbCerrarIncidencia_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbCerrarIncidencia.Click
        Try

            If (_EmpleadoCurrent.Identity > 0) Then
                Dim CerrarIncSelForm As New CerrarIncidenciaWOSelForm
                Dim OrdenTrabajoRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
                Dim OTFac As New OrdenTrabajoFacade()
                Dim OTInfo As New OrdenTrabajoInfo(App.Session.SessionID)

                OTInfo = OTFac.GetDetail(App.Session.SessionID, OrdenTrabajoRow.IdOrdenTrabajo)
                If (CerrarIncSelForm.ShowDialog(Me, OTInfo, _EmpleadoCurrent.Identity) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                End If

            Else
                MessageBox.Show("Favor de Iniciar Sesión del Operador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub tlbSurtirMP_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbSurtirMP.Click
    '    Try
    '        Dim OTFac As New OrdenTrabajoFacade()
    '        Dim SurtirInsumoSelForm As New SurtirInsumoSelForm
    '        Dim OTSelected As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
    '        Dim otInfo As OrdenTrabajoInfo = OTFac.GetDetail(App.Session.SessionID, OTSelected.IdOrdenTrabajo)

    '        SurtirInsumoSelForm.ShowDialog(Me, otInfo)

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub tlbRecibirFabricacion_Click(sender As System.Object, e As C1.Win.C1Command.ClickEventArgs) Handles tlbRecibirFabricacion.Click
    '    Try
    '        Dim OTFac As New OrdenTrabajoFacade()
    '        Dim RecibirPTSelForm As New DescargaPTSelForm
    '        Dim OTSelected As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
    '        Dim otInfo As OrdenTrabajoInfo = OTFac.GetDetail(App.Session.SessionID, OTSelected.IdOrdenTrabajo)

    '        RecibirPTSelForm.ShowDialog(Me, otInfo)
    '        Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub tlbCierreOT_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbCierreOT.Click
        Try
            If (_EmpleadoCurrent.Identity > 0) Then

                Dim OTFac As New OrdenTrabajoFacade()
                Dim OTSelected As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
                Dim otInfo As OrdenTrabajoInfo = OTFac.GetDetail(App.Session.SessionID, OTSelected.IdOrdenTrabajo)

                If (OTFac.ExistenInicenciasAbiertas(App.Session.SessionID, otInfo.Identity) = False) Then
                    If (MessageBox.Show("Una vez cerrada la orden de trabajo no podra realizar mas cambios, ¿Esta seguro que desea hacerlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then
                        If (otInfo.EnsambleSiguiente.Identity = -1) Then

                            OTFac.ApplyWorkflow(App.Session.SessionID, otInfo, WorkFlowStatus.Cerrado)
                            MessageBox.Show("El cierre de la OT se completo satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))

                        Else
                            MessageBox.Show("La orden de trabajo solo podra ser cerrada hasta que llegue a su ultimo ensamble", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MessageBox.Show("No puede cerrar una orden con incidencias abiertas", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                

            Else
                MessageBox.Show("Favor de Iniciar Sesión del Operador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cmdCerr_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCerr.Click
        CurrentStatusTlb = WorkFlowStatus.Cerrado
        Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
    End Sub

    Private Sub tlbInformes_Seguimiento_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbInformes_Seguimiento.Click


        Dim InformeSeguimientoDialog As New SiguimientoOTFormRpt
        InformeSeguimientoDialog.Show()

    End Sub

    Private Sub InvTrans_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles InvTrans.Click
        Try
            If (_EmpleadoCurrent.Identity > 0) Then


                Dim TransaccionesInvForm As New TransaccionesInventarioForm()

                Dim OrdenTrabajoRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
                Dim OTFac As New OrdenTrabajoFacade()
                Dim OTInfo As New OrdenTrabajoInfo(App.Session.SessionID)

                OTInfo = OTFac.GetDetail(App.Session.SessionID, OrdenTrabajoRow.IdOrdenTrabajo)

                'If (TransaccionesInvForm.ShowDialog(Me, OTInfo) = System.Windows.Forms.DialogResult.OK) Then
                Call TransaccionesInvForm.ShowDialog(Me, OTInfo)
                Call CargarOrdenesTrabajo(CurrentStatusTlb, CInt(cboEnsambles.SelectedValue))
                'End If
            Else
                MessageBox.Show("Favor de Iniciar Sesión del Operador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try




    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEmpleado.Click

    End Sub

    Private Sub cmdIniciarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIniciarSesion.Click
        Try

            If (cmdIniciarSesion.Text = "Iniciar Sesión") Then
                Dim CodigoEmpleado As String
                CodigoEmpleado = MsgInput.GetString("Introduce o Scannea tu Código de Empleado")
                Dim EmpFac As EmpleadoFacade = New EmpleadoFacade()

                _EmpleadoCurrent = EmpFac.GetDetail(App.Session.SessionID, CodigoEmpleado, App.DefaultSite.Identity, True)

                If (_EmpleadoCurrent.Identity > 0) Then
                    Dim ms As New IO.MemoryStream(CType(_EmpleadoCurrent.Foto, Byte()))
                    Dim returnImage As Image = Image.FromStream(ms)
                    imgEmpleado.Image = returnImage

                    tbEmpleado.Pages(0).Links(0).Text = _EmpleadoCurrent.Persona.Nombre
                    tbEmpleado.Pages(0).Links(1).Text = _EmpleadoCurrent.Persona.ApellidoP
                    tbEmpleado.Pages(0).Links(2).Text = _EmpleadoCurrent.Persona.ApellidoM

                    cmdIniciarSesion.Text = "Cerrar Sesión"
                    cmdIniciarSesion.BackColor = Color.PaleVioletRed
                    tlbScannWorkOrder.Enabled = True
                    Timer.Start()

                    Call tlbScannWorkOrder.PerformClick()
                    Call CargarOrdenesTrabajo(WorkFlowStatus.Liberado, 0)


                Else
                    MessageBox.Show("No se pudo cargar la información del empleado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                ClearSession()
            End If



        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ClearSession()

        _EmpleadoCurrent = New EmpleadoInfo(App.Session.SessionID)
        cmdIniciarSesion.Text = "Iniciar Sesión"
        cmdIniciarSesion.BackColor = Color.MintCream

        tbEmpleado.Pages(0).Links(0).Text = "Nombre"
        tbEmpleado.Pages(0).Links(1).Text = "ApellidoP"
        tbEmpleado.Pages(0).Links(2).Text = "ApellidoM"
        imgEmpleado.Image = Nothing
        tlbScannWorkOrder.Enabled = False

        tbEmpleado.Pages(1).Links(0).Text = "00:00"
        Timer.Stop()
        _Minuto = _MinutosMax
        _Segundo = 0

        bsOrdenesTrabajo.DataSource = New OrdenesTrabajoDS.OrdenesTrabajoDataTable()
        grdOrdenesTrabajo.Rebind(True)

    End Sub





    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Try

            If (_Segundo = 0) Then
                _Minuto -= 1
                If (_Minuto = 0 And _Segundo = 0) Then
                    Call ClearSession()
                    Exit Sub
                End If
                _Segundo = 60
            End If

            _Segundo -= 1

            Dim minS As String = String.Empty
            Dim segS As String = String.Empty

            If (_Minuto < 10) Then
                minS = "0" + _Minuto.ToString()
            Else
                minS = _Minuto.ToString()
            End If

            If (_Segundo < 10) Then
                segS = "0" + _Segundo.ToString()
            Else
                segS = _Segundo.ToString()
            End If

            tbEmpleado.Pages(1).Links(0).Text = "Tiempo Restante:" + minS + ":" + segS

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub tlbScannWorkOrder_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbScannWorkOrder.Click
        Try

            If (_EmpleadoCurrent.Identity > 0) Then

                Dim ScannCodigoOT As String = String.Empty

                ScannCodigoOT = MsgInput.GetString("Captura o Scannea el codigo de la OT")

                If (ScannCodigoOT <> String.Empty) Then
                    Dim otInfo As New OrdenTrabajoInfo(App.Session.SessionID)
                    Dim otFac As New OrdenTrabajoFacade()

                    'Obtenemos el detalle de la OT para saber su estatus y aplicar la selección en el grid
                    otInfo = otFac.GetDetail(App.Session.SessionID, ScannCodigoOT, App.DefaultSite.Identity, True)

                    If (otInfo.Identity > 0) Then

                        'Cargamos en el grid las ordenes con el estatus correspondiente a la OT buscada
                        Select Case otInfo.WorkFlowStatus

                            Case WorkFlowStatus.Guardado
                                Call cmdGuardados.PerformClick()

                            Case WorkFlowStatus.Liberado
                                Call cmbLib.PerformClick()

                            Case WorkFlowStatus.EnEspera
                                Call enEspera.PerformClick()

                            Case WorkFlowStatus.Cerrado
                                Call cmdCerr.PerformClick()

                        End Select


                        'Buscamos el codigo de la OT en el Grid y lo seleccionamos
                        grdOrdenesTrabajo.MoveFirst()
                        Dim drvPartida As DataRowView = CType(bsOrdenesTrabajo.Current, DataRowView)

                        For i = 0 To bsOrdenesTrabajo.Count
                            Dim colOT As C1.Win.C1TrueDBGrid.C1DataColumn = grdOrdenesTrabajo.Columns("OT")
                            grdOrdenesTrabajo.Select()

                            If (ScannCodigoOT = colOT.Value) Then

                                Exit Sub
                            End If
                            grdOrdenesTrabajo.MoveNext()
                        Next
                    End If

                    MessageBox.Show("No se encontro la orden de trabajo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Capture un codigo de OT", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Favor de Iniciar Sesión del Operador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If




        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub tlbImprimirMovimientos_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles tlbImprimirMovimientos.Click
        Try

            Dim OTMovimientosSelForm As New OrdenesTrabajoMovsSelForm()
            Dim OrdenTrabajoRow As OrdenesTrabajoDS.OrdenesTrabajoRow = GetCurrentGrdOrdenTrabajo(bsOrdenesTrabajo.Current)
            OTMovimientosSelForm.ShowDialog(Me, OrdenTrabajoRow, _EmpleadoCurrent)

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class