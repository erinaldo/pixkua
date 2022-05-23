Public Class EditConceptoForm
    Private IdConcepto, IdClasificacion As Integer
    Private ConceptoFac As ConceptoFacade
    Private Concepto As ConceptoInfo

    Private Function IsValid() As Boolean
        IsValid = False
        If cboClasificacion.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir la clasificación del concepto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboClasificacion.Focus()
        ElseIf cboTipo.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir el tipo de concepto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboTipo.Focus()
        ElseIf txtNombre.Text = String.Empty Then
            MessageBox.Show("Debe introducir el nombre del concepto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idClasificacion As Integer, ByVal idConcepto As Integer) As DialogResult
        Me.IdClasificacion = idClasificacion
        Me.IdConcepto = idConcepto
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditConceptoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConceptoFac = New ConceptoFacade
        Try
            cboClasificacion.LoadList()
            If IdConcepto > 0 Then
                Concepto = ConceptoFac.GetDetail(App.Session.SessionID, IdConcepto, False)
                With Concepto
                    cboClasificacion.SelectedValue = .IdClasificacion
                    txtNombre.Text = .Nombre
                    Select Case .Tipo
                        Case TipoConcepto.Entrada
                            cboTipo.SelectedIndex = 0
                        Case TipoConcepto.Salida
                            cboTipo.SelectedIndex = 1
                        Case TipoConcepto.Traspaso
                            cboTipo.SelectedIndex = 2
                    End Select
                    nudDiasVig.Value = .DiasVigencia
                    If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
                    chkActivo.Checked = .Status = Kernel.BusinessStructure.CatalogState.Active
                    chkAutomatico.Checked = .Automatico
                End With
            Else
                Concepto = New ConceptoInfo(App.Session.SessionID)
                cboClasificacion.SelectedValue = IdClasificacion
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                With Concepto
                    .IdClasificacion = CInt(cboClasificacion.SelectedValue)
                    .Nombre = txtNombre.Text
                    Select Case cboTipo.SelectedIndex
                        Case 0
                            .Tipo = TipoConcepto.Entrada
                        Case 1
                            .Tipo = TipoConcepto.Salida
                        Case 2
                            .Tipo = TipoConcepto.Traspaso
                    End Select
                    .DiasVigencia = CInt(nudDiasVig.Value)
                    If chkActivo.Checked Then
                        .Status = Kernel.BusinessStructure.CatalogState.Active
                    Else
                        .Status = Kernel.BusinessStructure.CatalogState.Inactive
                    End If
                    .Automatico = chkAutomatico.Checked
                End With
                ConceptoFac.Update(Concepto)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class