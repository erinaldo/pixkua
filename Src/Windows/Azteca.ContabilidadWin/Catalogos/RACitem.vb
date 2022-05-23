Public Class RACitem
    Private dtImportes As DataTable
    Private _RacDetRow As RacDetDS.RacDetRow

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal RacDet As RacDetDS.RacDetRow) As DialogResult
        Dim Ctafac As New CuentaFacade
        dtImportes = Ctafac.ImportesCBO(App.Session.SessionID)
        cboImporte.DisplayMember = "Descripcion" : cboImporte.ValueMember = "Id" : cboImporte.DataSource = dtImportes

        _RacDetRow = RacDet
        loadRacDet()
        Return MyBase.ShowDialog(owner)
    End Function


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub CuentaTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnEntidad.CheckedChanged, rbtnCuenta.CheckedChanged
        chkIsConceptoEntidad.Enabled = rbtnEntidad.Checked
        selCuenta.Enabled = rbtnCuenta.Checked
        selEntidad.Enabled = rbtnEntidad.Checked
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If isValid() Then
            With _RacDetRow
                .Afectador = IIf(rbtnCargo.Checked, "C", "A")
                If rbtnCuenta.Checked Then
                    .IdCuenta = selCuenta.Key
                    .Cuenta = selCuenta.Text : .Concepto = selCuenta.TextInfo
                    .IdEntidad = 0 : .Entidad = ""
                    .isEntidadConcepto = False
                Else
                    .IdCuenta = 0 : .Cuenta = ""
                    .IdEntidad = selEntidad.Key
                    .Entidad = selEntidad.TextInfo
                    .isEntidadConcepto = chkIsConceptoEntidad.Checked
                    If .isEntidadConcepto Then
                        .Concepto = "Descripcion de la entidad"
                    Else
                        .Concepto = "Descripcion de la cuenta de la entidad"
                    End If
                End If
                .IdImporte = CInt(cboImporte.SelectedValue)
                .Importe = cboImporte.Text
                .Rojo = chkRojo.Checked
            End With

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnOrigenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrigenNew.Click
        Dim frm As New addImportesForm
        If frm.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim Ctafac As New CuentaFacade
            cboImporte.DataSource = Ctafac.ImportesCBO(App.Session.SessionID)
        End If
    End Sub

    Private Sub loadRacDet()
        If _RacDetRow.IsNull("Afectador") Then Exit Sub

        With _RacDetRow
            rbtnAbono.Checked = CBool(IIf(.Afectador = "A", True, False))
            rbtnCargo.Checked = CBool(IIf(.Afectador = "C", True, False))

            If .IdCuenta > 0 Then
                rbtnCuenta.Checked = True
                selCuenta.LoadInfo(.IdCuenta)
            Else
                rbtnEntidad.Checked = True
                selEntidad.LoadInfo(.IdEntidad)
                chkIsConceptoEntidad.Checked = .isEntidadConcepto
            End If

            cboImporte.SelectedValue = .IdImporte
            chkRojo.Checked = .Rojo
        End With
    End Sub

    Private Function isValid() As Boolean
        'Se verifica el tipo de cuenta que se va a utilizar
        If rbtnCuenta.Checked Then
            If selCuenta.Key = 0 Then
                MessageBox.Show("Capture una cuenta contable", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                selCuenta.Focus()
                Return False
            End If
        Else
            If selEntidad.Key = 0 Then
                MessageBox.Show("Capture una Entidad", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                selEntidad.Focus()
                Return False
            End If
        End If

        If cboImporte.SelectedValue = 0 Then
            MessageBox.Show("Capture el importe a considerar", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            cboImporte.Focus()
            Return False
        End If

        Return True
    End Function

End Class
