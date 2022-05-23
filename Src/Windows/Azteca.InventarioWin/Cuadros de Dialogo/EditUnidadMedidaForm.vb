Public Class EditUnidadMedidaForm    
    Private IdUnidadMedida, IdTipoUnidad As Integer
    Private UnidadMedida As UnidadMedidaInfo
    Private UnidadMedidaFac As UnidadMedidaFacade
    Dim TipoUnidadFac As TipoUnidadMedidaFacade


    Private Function IsValid() As Boolean
        IsValid = False
        If txtNombre.Text = String.Empty Then
            MessageBox.Show("Debe introducir el nombre de la unidad de medida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        ElseIf cboTipo.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir el tipo de unidad de medida.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboTipo.Focus()
        ElseIf Val(txtFactor.Text) = 0 Then
            MessageBox.Show("Debe introducir el factor de la unidad de medida con respecto a la unidad base.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFactor.Focus()
        ElseIf Not chkBase.Checked AndAlso TipoUnidadFac.GetUnidadBaseID(App.Session.SessionID, CInt(cboTipo.SelectedValue)) = 0 Then
            MessageBox.Show("El tipo de unidad de medida seleccionado no tiene definido una unidad de medida base." & ControlChars.NewLine &
                            "Primero debe definir la unidad de medida base.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            chkBase.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idTipoUnidad As Integer, ByVal idUnidadMedida As Integer) As DialogResult
        Me.IdTipoUnidad = idTipoUnidad
        Me.IdUnidadMedida = idUnidadMedida
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditUnidadMedidaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UnidadMedidaFac = New UnidadMedidaFacade
        TipoUnidadFac = New TipoUnidadMedidaFacade
        Try
            cboTipo.LoadList()
            If IdUnidadMedida > 0 Then
                UnidadMedida = UnidadMedidaFac.GetDetail(App.Session.SessionID, IdUnidadMedida, False)
                With UnidadMedida
                    cboTipo.SelectedValue = .IdTipoUnidad
                    txtNombre.Text = .Nombre
                    txtAbreviatura.Text = .Abreviatura
                    chkBase.Checked = .Base
                    txtFactor.Text = .Factor.ToString
                    chkFraccionable.Checked = .Fraccionable
                    chkActivo.Checked = (.Status = Kernel.BusinessStructure.CatalogState.Active)
                End With
            Else
                cboTipo.SelectedValue = IdTipoUnidad
                UnidadMedida = New UnidadMedidaInfo(App.Session.SessionID)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub chkBase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBase.CheckedChanged
        If chkBase.Checked Then
            txtFactor.Enabled = False
            txtFactor.Text = "1"
            chkFraccionable.Checked = False
        Else
            txtFactor.Enabled = True
            txtFactor.Text = "0"
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                'Si se seleccionó como unidad de medida base y ya existe otra unidad base, advertir que se reemplazará
                If chkBase.Checked Then
                    Dim IdUnidadBase As Integer = TipoUnidadFac.GetUnidadBaseID(App.Session.SessionID, CInt(cboTipo.SelectedValue))
                    If IdUnidadBase > 0 AndAlso IdUnidadBase <> UnidadMedida.Identity Then
                        Dim Resp As DialogResult = MessageBox.Show("El tipo de unidad ya tiene asignado una unidad de medida base." & ControlChars.NewLine &
                                                                 "¿Esta seguro que desea reemplazar la unidad de medida base?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If Resp = System.Windows.Forms.DialogResult.No Then
                            Return
                        End If
                    End If
                End If

                With UnidadMedida
                    .IdTipoUnidad = CInt(cboTipo.SelectedValue)
                    .Nombre = txtNombre.Text
                    .Abreviatura = txtAbreviatura.Text
                    .Factor = CDec(Val(txtFactor.Text))
                    .Base = chkBase.Checked
                    .Fraccionable = chkFraccionable.Checked
                    If chkActivo.Checked Then
                        .Status = Kernel.BusinessStructure.CatalogState.Active
                    Else
                        .Status = Kernel.BusinessStructure.CatalogState.Inactive
                    End If
                    .IdSucursal = App.DefaultSite.Identity
                End With
                UnidadMedidaFac.Update(UnidadMedida)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

End Class