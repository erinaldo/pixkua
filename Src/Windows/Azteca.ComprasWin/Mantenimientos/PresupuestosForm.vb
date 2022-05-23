Imports Microsoft.Reporting.WinForms

Public Class PresupuestosForm
    Private Presupuesto As PresupuestoInfo

    Private Sub PresupuestosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPeriodo.LoadList(App.DefaultCompany.Identity)
        Dim DeptosFac As New Azteca.Business.RH.DepartamentoFacade
        trvwDepartamentos.HierarchyFacade = DeptosFac
        trvwDepartamentos.LoadHierarchy()
    End Sub

    Private Sub trvwDepartamentos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvwDepartamentos.AfterSelect
        Resetear()
        lblDepartamento.Text = e.Node.Text
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        Resetear()
    End Sub

    Private Sub Resetear()
        grdPresupuesto.Visible = False
        gbxGlobal.Visible = False
        lblNoPresupuesto.Visible = False
        lblDepartamento.Text = "Seleccione un departamento"
        btnGuardar.Enabled = False
        'btnImprimir.Enabled = False
        lblPresupuestoEsta.Visible = False
        btnStatus.Visible = False
        btnAutorizar.Visible = False
        btnAutorizar.Enabled = False
        btnStatus.Text = ""
        Presupuesto = New PresupuestoInfo(App.Session.SessionID)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        If trvwDepartamentos.SelectedId = 0 Then
            MessageBox.Show("Debe seleccionar un departamento para asignarle centros de recepción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Try
            'Verificamos si el usuario actual tiene permiso para el departamento seleccionado
            Dim DepartamentoFac As New DepartamentoFacade
            If Not DepartamentoFac.HasAccess(App.Session.SessionID, trvwDepartamentos.SelectedId, App.Session.User.Identity) Then
                MessageBox.Show("No se tiene permiso de acceso al Departamento seleccionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            'Obtenemos los datos del departamento
            Dim PrestoFac As New PresupuestoFacade
            Presupuesto = PrestoFac.getFromPeriodoDepto(App.Session.SessionID, CInt(cboPeriodo.SelectedValue), trvwDepartamentos.SelectedId, App.DefaultSite.Identity)

            'Si el presupuesto esta solo guardado, permitimos editar en el.
            lblPresupuestoEsta.Visible = True : btnStatus.Visible = True : btnAutorizar.Visible = True

            If Presupuesto.Estatus = "G" Then
                grdPresupuesto.Splits(0).DisplayColumns("Presupuestado").Locked = False
                txtPresupuestado.Enabled = True
                btnStatus.Text = "No autorizado" : btnStatus.ForeColor = Drawing.Color.Red
                'Depende de la politica quien tiene permiso para habilidar el boton de autorizacion
                Me.ApplyPolicies(Me.Controls, Me.Politicas)
            Else
                btnStatus.Text = "Autorizado" : btnStatus.ForeColor = Drawing.Color.DarkGreen
                grdPresupuesto.Splits(0).DisplayColumns("Presupuestado").Locked = True
                txtPresupuestado.Enabled = False
                btnAutorizar.Enabled = False
            End If

            'Habilitar los botones correspondientes apartir del tipo de presupuesto del departamento seleccinado
            btnGuardar.Enabled = Presupuesto.TipoPresupuesto <> TipoAdmonPresupuestoEnum.No : btnImprimir.Enabled = Presupuesto.TipoPresupuesto <> TipoAdmonPresupuestoEnum.No

            bsPresupuesto.DataSource = Presupuesto.CategoriasTable
            grdPresupuesto.Rebind(True)
            txtPresupuestado.Text = Presupuesto.MontoPresupuesto.ToString("0.00")
            txtApartado.Text = Presupuesto.MontoApartado.ToString("0.00")
            txtUtilizado.Text = Presupuesto.MontoUtilizado.ToString("0.00")
            txtDisponible.Text = Presupuesto.Disponible.ToString("0.00")

            grdPresupuesto.Visible = Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Categorizado
            gbxGlobal.Visible = Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Global_Depto
            lblNoPresupuesto.Visible = Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.No
            Totalizar()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Global_Depto Then
                Presupuesto.MontoPresupuesto = CDec(txtPresupuestado.Text)
            ElseIf Presupuesto.TipoPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then

            Else
                Exit Sub
            End If
            Dim PrestoFac As New PresupuestoFacade
            PrestoFac.Update(Presupuesto)
            MessageBox.Show("Se ha actualizado el presupuesto actual.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdPresupuesto_AfterUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdPresupuesto.AfterUpdate
        Totalizar()
    End Sub

    Private Sub Totalizar()
        Dim Presupuestado As Object = Presupuesto.CategoriasTable.Compute("SUM(Presupuestado)", "")
        If Not IsNothing(Presupuestado) Then grdPresupuesto.Columns("Presupuestado").FooterText = Presupuestado.ToString()

        Dim Utilizado As Object = Presupuesto.CategoriasTable.Compute("SUM(Utilizado)", "")
        If Not IsNothing(Utilizado) Then grdPresupuesto.Columns("Utilizado").FooterText = Utilizado.ToString()

        Dim Apartado As Object = Presupuesto.CategoriasTable.Compute("SUM(Apartado)", "")
        If Not IsNothing(Apartado) Then grdPresupuesto.Columns("Apartado").FooterText = Apartado.ToString()

        grdPresupuesto.Columns("CategoriaPresupuestal").FooterText = "Totales"
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        Try
            ' Cargar información de impresión de los Presupuestos
            Dim PresupFac As New PresupuestoFacade
            Dim dtPresup As DataTable = PresupFac.LoadPrintInfo(App.Session.SessionID, CInt(cboPeriodo.SelectedValue))
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            Parametros.Add(New ReportParameter("Periodo", cboPeriodo.Text))

            'Mostrar vista previa de los presupuestos
            Dim frmVenta As New ReportForm
            frmVenta.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Compras.Presupuesto.rdlc"
            frmVenta.LocalReport.DataSources.Add(New ReportDataSource("Presuepuestos", CType(dtPresup, DataTable)))
            frmVenta.LocalReport.SetParameters(Parametros)
            frmVenta.Show("Presupuesto del Periodo " & cboPeriodo.Text)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnAutorizar_Click(sender As System.Object, e As System.EventArgs) Handles btnAutorizar.Click
        Try

            If Presupuesto.Identity = 0 Then
                MessageBox.Show("El Presupuesto debe guardarse antes de ser aplicado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim PresFac As New PresupuestoFacade
            PresFac.Autorizar(App.Session.SessionID, Presupuesto.Identity)
            Presupuesto.Estatus = "A"
            MessageBox.Show("El Presupuesto ha sido autorizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnStatus.Text = "Autorizado" : btnStatus.ForeColor = Drawing.Color.DarkGreen
            grdPresupuesto.Splits(0).DisplayColumns("Presupuestado").Locked = True
            txtPresupuestado.Enabled = False
            btnAutorizar.Enabled = False
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class