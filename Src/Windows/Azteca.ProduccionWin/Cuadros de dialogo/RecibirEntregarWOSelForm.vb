Public Class RecibirEntregarWOSelForm
    Private _OTInfo As New OrdenTrabajoInfo(App.Session.SessionID)
    Public _IdEmpleado As Integer
    Private _EnsambleSelected As New EnsambleInfo(App.Session.SessionID)


    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal otInfo As OrdenTrabajoInfo, ByVal idEmpleado As Integer) As DialogResult


        Try
            Dim EnsambleFac As New EnsambleFacade()
            cboEnsambles.LoadListByOT(otInfo.Identity)

            _OTInfo = otInfo
            lblOrdenTrabajo.Text = otInfo.UserCode
            cboEnsambles.SelectedValue = otInfo.EnsambleActual.Identity
            _IdEmpleado = idEmpleado
            _EnsambleSelected = EnsambleFac.GetDetail(App.Session.SessionID, otInfo.EnsambleActual.Identity, False)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub RecibirEntregarWOSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If (isValid()) Then

            Try
                Dim mov As New Movimiento()
                Dim OTFac As New OrdenTrabajoFacade()
                Cursor = Cursors.WaitCursor
                'Inicializo el movimiento a insertar
                mov.IdEnsamble = CInt(cboEnsambles.SelectedValue)
                mov.IdOrdenTrabajo = _OTInfo.Identity
                mov.Cantidad = CDec(txtCantidad.Text)
                mov.IdEmpleado = _IdEmpleado

                If (cboTipoMovimiento.Text = "Recepcion") Then
                    mov.Clase = TipoMovimientoOT.RecepcionMaterial
                Else
                    mov.Clase = TipoMovimientoOT.EntregaMaterial
                End If
                mov.Fecha = Date.Today()
                mov.Observaciones = txtObservaciones.Text

                Dim msgError As String
                msgError = OTFac.AddMovimiento(App.Session.SessionID, mov)

                Me.Cursor = Cursors.Default
                If (msgError <> "") Then
                    MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Transacción aplicada correctamente a la OT: " & _OTInfo.UserCode, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try


        End If
    End Sub

    Private Function isValid() As Boolean

        If (txtCantidad.Text = "") Then
            MessageBox.Show("Favor de introducir una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (CDec(txtCantidad.Text) <= 0) Then
            MessageBox.Show("La cantidad debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (cboTipoMovimiento.Text = "") Then
            MessageBox.Show("Favor de seleccionar un tipo de movimiento", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (CInt(cboEnsambles.SelectedValue()) = 0 Or CInt(cboEnsambles.SelectedValue) = Nothing) Then
            MessageBox.Show("Favor de seleccionar un ensamble", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cboTipoMovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoMovimiento.SelectedIndexChanged
        Try
            Call ChangeUnidadMedida()

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cboEnsambles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEnsambles.SelectedIndexChanged
        Try
            Dim EnsambleFac As New EnsambleFacade()
            _EnsambleSelected = EnsambleFac.GetDetail(App.Session.SessionID, CInt(cboEnsambles.SelectedValue))

            If (cboTipoMovimiento.Text <> String.Empty) Then
                Call ChangeUnidadMedida()
            Else
                txtUnidadMedida.Text = String.Empty
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ChangeUnidadMedida()
        Try
            Dim UnidadMedida As New Azteca.Business.Inventario.UnidadMedidaInfo(App.Session.SessionID)
            Dim UnidadMedidaFac As New Azteca.Business.Inventario.UnidadMedidaFacade()


            If (cboTipoMovimiento.Text = String.Empty) Then
                MessageBox.Show("Favor de seleccionar un tipo de movimiento", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf (cboTipoMovimiento.Text = "Recepcion") Then
                UnidadMedida = UnidadMedidaFac.GetDetail(App.Session.SessionID, _EnsambleSelected.IdUnidadMedidaTipoRecepcion)
                txtUnidadMedida.Text = UnidadMedida.Nombre
            Else
                UnidadMedida = UnidadMedidaFac.GetDetail(App.Session.SessionID, _EnsambleSelected.IdUnidadMedidaTipoEntrega)
                txtUnidadMedida.Text = UnidadMedida.Nombre
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class