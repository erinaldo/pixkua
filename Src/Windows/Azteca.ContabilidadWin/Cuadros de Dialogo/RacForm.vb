Public Class RacForm
    Private Rac As RacInfo
    Private _IdPolizaPerfil As Integer = 0

    Public Overloads Function ShowDialog(ByVal owner As Form, IdPolizaPerfil As Integer, ByVal IdRacTit As Integer) As System.Windows.Forms.DialogResult
        Dim RacFac As New RacFacade
        If IdRacTit = 0 Then
            Rac = New RacInfo(App.Session.SessionID)
            _IdPolizaPerfil = IdPolizaPerfil
        Else
            Rac = RacFac.GetDetail(App.Session.SessionID, IdRacTit)
            txtNombre.Text = Rac.Nombre
            cboSegmentoNegocio.SelectedValue = Rac.IdSegmentoNegocio
        End If

        bsRacDet.DataSource = Rac.RacDet
        grdRac.Rebind(True)

        Return MyBase.ShowDialog(owner)
    End Function

    Public Sub LoadingList(ByVal IdVistaContable As Integer)
        Dim SegNeg As New SegmentoNegocioFacade
        cboSegmentoNegocio.DisplayMember = "Descripcion" : cboSegmentoNegocio.ValueMember = "Id" : cboSegmentoNegocio.DataSource = SegNeg.SegmentosNegocioCBO(App.Session.SessionID, App.DefaultCompany.Identity)
        CargarAfectadores()
        CargarEntidades(IdVistaContable)
        CargarImportes(IdVistaContable)
    End Sub

    Public Sub CargarEntidades(ByVal IdVistaContable As Integer)
        Dim EntidadFac As New EntidadFacade
        bsEntidades.DataSource = EntidadFac.LoadList(App.Session.SessionID, IdVistaContable)
        dropEntidad.Rebind(True)
    End Sub
    Public Sub CargarImportes(ByVal IdVistaContable As Integer)
        Dim ImportesFac As New ImporteFacade
        bsImportes.DataSource = ImportesFac.LoadList(App.Session.SessionID, IdVistaContable)
        dropImportes.Rebind(True)
    End Sub

    Private Sub CargarAfectadores()
        Dim dt As New RacDS.AfectadoresDataTable

        Dim drC As RacDS.AfectadoresRow = dt.NewAfectadoresRow()
        drC.Abrev = "C" : drC.Afectador = "Cargo"
        dt.AddAfectadoresRow(drC)

        Dim drA As RacDS.AfectadoresRow = dt.NewAfectadoresRow()
        drA.Abrev = "A" : drA.Afectador = "Abono"
        dt.AddAfectadoresRow(drA)

        bsAfectador.DataSource = dt
        dropAfectador.Rebind(True)
    End Sub

    Private Sub grdRac_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdRac.BeforeColUpdate
        'If bsClasificaciones.Current IsNot Nothing AndAlso e.Column.Name = "Cuenta" Then
        Try
            If e.Column.Name = "Cuenta" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdRac.Columns("Cuenta").Value) <= 0 Then Return
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                If CuentaFac.Exists(App.Session.SessionID, grdRac.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, grdRac.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity, False)
                    grdRac.Columns("IdCuenta").Value = Cuenta.Identity
                    grdRac.Columns("Concepto").Value = Cuenta.Nombre
                    grdRac.Columns("IdEntidad").Value = 0
                Else
                    e.Cancel = True
                    MessageBox.Show("La cuenta especificada no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            If e.Column.Name = "IdEntidad" Then
                grdRac.Columns("IdCuenta").Value = 0
                grdRac.Columns("Concepto").Value = ""
                grdRac.Columns("Cuenta").Value = ""
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdRac_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdRac.ButtonClick
        ''If bsClasificaciones.Current IsNot Nothing Then
        Try
            If e.Column.Name = "Cuenta" Then
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
                frmSearch.StartPosition = FormStartPosition.CenterParent
                If frmSearch.ShowDialog(CuentaFac, CuentaFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                    grdRac.Columns("IdCuenta").Value = Cuenta.Identity
                    grdRac.Columns("Cuenta").Value = Cuenta.UserCode
                    grdRac.Columns("Concepto").Value = Cuenta.Nombre
                    grdRac.Columns("IdEntidad").Value = 0
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
        ''End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Not valida() Then Exit Sub
        Try
            Dim RacFac As New RacFacade
            Rac.Nombre = txtNombre.Text
            Rac.IdPolizaPerfil = _IdPolizaPerfil
            Rac.IdSegmentoNegocio = CInt(cboSegmentoNegocio.SelectedValue)
            Rac.IdEmpresa = App.DefaultCompany.IdEmpresa : Rac.IdSucursal = App.DefaultSite.Identity : Rac.Status = CatalogState.Active
            RacFac.Update(Rac)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Function valida() As Boolean
        If txtNombre.TextLength = 0 Then
            MessageBox.Show("Debe capturar un nombre para identificar el RAC", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtNombre.Focus()
            Return False
        End If

        If cboSegmentoNegocio.SelectedValue = 0 Then
            MessageBox.Show("Debe capturar un segmento de negocio", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cboSegmentoNegocio.Focus()
            Return False
        End If

        Return True
    End Function
End Class