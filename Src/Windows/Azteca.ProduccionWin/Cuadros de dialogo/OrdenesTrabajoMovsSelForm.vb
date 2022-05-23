Public Class OrdenesTrabajoMovsSelForm
    Private _OTRow As OrdenesTrabajoDS.OrdenesTrabajoRow
    Private _CurrentEmploye As Business.RH.EmpleadoInfo

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal OTRow As OrdenesTrabajoDS.OrdenesTrabajoRow, ByVal currentEmploye As Business.RH.EmpleadoInfo)

        _OTRow = OTRow
        _CurrentEmploye = currentEmploye
        Call CargarMovimientosOT()
        Call CargarMovimientosInventario()

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub OrdenesTrabajoMovsSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CargarMovimientosOT()
        Dim OTRow As OrdenesTrabajoDS.OrdenesTrabajoRow = Me._OTRow
        Dim OTFacade As New OrdenTrabajoFacade
        Dim Movimientos As OrdenesTrabajoDS.MovimientosDataTable = OTFacade.LoadMovimientosByOT(App.Session.SessionID, OTRow.IdOrdenTrabajo)
        Dim Incidencias As DataTable = OTFacade.LoadIncidenciasByOT(App.Session.SessionID, OTRow.IdOrdenTrabajo)
        Dim Procesos As DataTable = OTFacade.LoadProcesosByOT(App.Session.SessionID, OTRow.IdOrdenTrabajo)

        lblOrdenTrabajo.Text = OTRow.OT
        bsMovimientos.DataSource = Movimientos
        grdGeneral.Rebind(True)

        Dim dvRecEnt As New DataView(Movimientos)
        dvRecEnt.RowFilter = "Clase =  '" & TipoMovimientoOT.EntregaMaterial & "' OR Clase= '" & TipoMovimientoOT.RecepcionMaterial & "'"
        grdRecEnt.DataSource = dvRecEnt

        bsIncidencias.DataSource = Incidencias
        grdIncidencias.Rebind(True)

        bsProcesos.DataSource = Procesos
        grdProcesos.Rebind(True)

    End Sub

    Private Sub CargarMovimientosInventario()
        Dim OTRow As OrdenesTrabajoDS.OrdenesTrabajoRow = Me._OTRow
        Dim OTFacade As New OrdenTrabajoFacade
        Dim MovsInventario As DataTable = OTFacade.LoadMovimientosInventarioByOT(App.Session.SessionID, OTRow.IdOrdenTrabajo, App.DefaultSite.Identity)
        grdInventario.DataSource = MovsInventario
    End Sub



    Private Sub OrdenesTrabajoMovsSelForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub



    Private Sub cmsModificar_Click(sender As System.Object, e As System.EventArgs) Handles cmsModificar.Click

        Try
            Dim SecurityFac As New Azteca.Kernel.Security.PoliticaFacade
            Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
            'Obtenemos el ID de la politica especificada en la tabla dbo.Configuracion
            Dim IdPoliticaEditMov As Integer = CInt(ConfigFac.GetSystemParameter("Configuracion/Seguridad/Politicas", "ModificarMovimientoOT"))

            'Verificamos si el usuario tiene activada la politica en la sucursal correspondiente
            If (SecurityFac.HasAccess(App.Session.SessionID, App.Session.User.Identity, App.DefaultSite.Identity, IdPoliticaEditMov)) Then
                Dim MovInfo As New Azteca.Business.Produccion.Movimiento
                Dim dvr As DataRowView = CType(bsMovimientos.Current, DataRowView)
                MovInfo.IdMovimiento = CInt(dvr("IdMovimiento"))
                MovInfo.Clase = Trim(dvr("Clase").ToString())

                If (MovInfo.Clase = "RM" Or MovInfo.Clase = "EM") Then
                    Dim res As String = InputBox("Introduce la cantidad a modificar", "Modificar " & MovInfo.Clase, "0")
                    If (res <> "") Then
                        MovInfo.Cantidad = CDec(res)
                        Dim OrdenTrabajoFac As New OrdenTrabajoFacade()
                        OrdenTrabajoFac.EditarMovimiento(App.Session.SessionID, MovInfo)
                        Call CargarMovimientosOT()
                    End If
                Else
                    MessageBox.Show("Solo esta permitido modificar alguna Recepción o Entrega", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No cuenta con los permisos necesarios para esta operacion", "acceso denegado!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If




            
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
        
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            
            Dim IncidenciaInfo As New Azteca.Business.Produccion.IncidenciaInfo(App.Session.SessionID)
            Dim IncidenciaFac As New IncidenciaFacade()
            Dim dvr As DataRowView = CType(bsIncidencias.Current, DataRowView)

            Dim status As String = dvr("Estatus").ToString()

            IncidenciaInfo = IncidenciaFac.GetDetail(App.Session.SessionID, CInt(dvr("IdIncidencia")))

            If (status = "Abierta") Then
                
                Me.Cursor = Cursors.WaitCursor

                Dim mov As New Movimiento
                mov.IdEnsamble = CInt(dvr("IdEnsamble"))
                mov.IdIncidencia = CInt(dvr("IdIncidencia"))
                mov.IdOrdenTrabajo = CInt(dvr("IdOrdenTrabajo"))
                mov.Fecha = Date.Today
                mov.Clase = TipoMovimientoOT.FinIncidencia
                mov.Observaciones = "Fin desde administrador de incidencias"
                mov.IdEmpleado = _CurrentEmploye.Identity

                Dim otFac As New OrdenTrabajoFacade
                Dim msgError As String
                msgError = otFac.AddMovimiento(App.Session.SessionID, mov)

                If (msgError <> "") Then
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Incidencia aplicada correctamente a la OT: " & lblOrdenTrabajo.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
                Me.Cursor = Cursors.Default

                Dim OTFacade As New OrdenTrabajoFacade
                Dim Incidencias As DataTable = OTFacade.LoadIncidenciasByOT(App.Session.SessionID, _OTRow.IdOrdenTrabajo)
                bsIncidencias.DataSource = Incidencias
                grdIncidencias.Rebind(True)


            Else
                MessageBox.Show("La Incidencia ya se encuentra cerrada", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    
    Private Sub mnuFinalizarProceso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinalizarProceso.Click
        Try

        
            Dim dvr As DataRowView = CType(bsProcesos.Current, DataRowView)
            Dim FechaInicio As String = dvr("FechaInicio").ToString()



            If (FechaInicio <> String.Empty Or FechaInicio <> Nothing) Then

                Me.Cursor = Cursors.WaitCursor

                Dim mov As New Movimiento
                mov.IdEnsamble = CInt(dvr("IdEnsamble"))
                mov.IdOrdenTrabajo = CInt(dvr("IdOrdenTrabajo"))
                mov.Fecha = Date.Today
                mov.Clase = TipoMovimientoOT.FinProceso
                mov.Observaciones = "Fin desde administrador de incidencias"
                mov.IdEmpleado = _CurrentEmploye.Identity

                Dim otFac As New OrdenTrabajoFacade
                Dim msgError As String
                msgError = otFac.AddMovimiento(App.Session.SessionID, mov)

                If (msgError <> "") Then
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("El proceso se ha finalizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
                Me.Cursor = Cursors.Default

                Dim OTFacade As New OrdenTrabajoFacade
                Dim Procesos As DataTable = OTFacade.LoadProcesosByOT(App.Session.SessionID, _OTRow.IdOrdenTrabajo)
                bsProcesos.DataSource = Procesos
                grdProcesos.Rebind(True)


            Else
                MessageBox.Show("La Incidencia ya se encuentra cerrada", "error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class