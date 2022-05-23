Public Class CerrarIncidenciaWOSelForm
    Dim _otInfo As OrdenTrabajoInfo
    Dim _IdEmpleado As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal OTInfo As OrdenTrabajoInfo, ByVal idEmpleado As Integer) As DialogResult
        _otInfo = OTInfo
        cboEnsambles.LoadListByOT(_otInfo.Identity)
        lblOrdenTrabajo.Text = _otInfo.UserCode
        cboEnsambles.SelectedValue = _otInfo.EnsambleActual.Identity
        _IdEmpleado = idEmpleado
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub CerrarIncidenciaWOSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If (IsValid()) Then

            Me.Cursor = Cursors.WaitCursor

            Dim OTFac As New OrdenTrabajoFacade()

            Try

                If (MessageBox.Show("La incidencia actual (" & _otInfo.IncidenciaActual.Nombre & ") de la orden de trabajo " & _otInfo.UserCode & " sera cerrada, esta de acuerdo?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK) Then
                    'Creamos el movimiento para insertar
                    Dim mov As New Movimiento()
                    mov.IdEnsamble = CInt(cboEnsambles.SelectedValue)
                    mov.IdOrdenTrabajo = _otInfo.Identity
                    mov.Clase = TipoMovimientoOT.FinIncidencia
                    mov.IdIncidencia = _otInfo.IncidenciaActual.Identity
                    mov.IdEmpleado = _IdEmpleado
                    Dim msgError As String = OTFac.AddMovimiento(App.Session.SessionID, mov)

                    If (msgError <> "") Then
                        MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Incidencia incidencia de la OT: " & _otInfo.UserCode & " fue aplicada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Function IsValid() As Boolean

        If (cboEnsambles.SelectedValue = 0) Then
            MessageBox.Show("Favor de seleccionar un ensamble", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class