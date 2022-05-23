Public Class EditAlmacenForm
    Private IdArea, IdAlmacen As Integer
    Private Almacen As AlmacenInfo
    Private AlmacenFac As AlmacenFacade

    Private Function IsValid() As Boolean
        IsValid = False
        If txtNombre.Text = String.Empty Then
            MessageBox.Show("Debe capturar el nombre del almacén", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Focus()
        ElseIf cboArea.SelectedIndex = -1 Then
            MessageBox.Show("Debe elegir el área al que pertenece éste almacén", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboArea.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idArea As Integer, ByVal idAlmacen As Integer) As DialogResult
        Me.IdArea = idArea
        Me.IdAlmacen = idAlmacen
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditAlmacenForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AlmacenFac = New AlmacenFacade
        Try
            cboArea.LoadList(App.DefaultSite.Identity, -1)
            If IdAlmacen > 0 Then
                Almacen = AlmacenFac.GetDetail(App.Session.SessionID, IdAlmacen, False)
                With Almacen
                    cboArea.SelectedValue = .IdArea
                    txtNombre.Text = .Nombre
                    If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
                    chkActivo.Checked = (.Status = Kernel.BusinessStructure.CatalogState.Active)
                    chkPermiteNeg.Checked = .PermiteNegativos
                    chkReqCapturaFisico.Checked = .RequiereCapturaFisico
                End With
            Else
                Almacen = New AlmacenInfo(App.Session.SessionID)
                cboArea.SelectedValue = IdArea
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                With Almacen
                    .Nombre = txtNombre.Text
                    .IdArea = CInt(cboArea.SelectedValue)
                    .IdCuenta = txtCuenta.Key
                    .PermiteNegativos = chkPermiteNeg.Checked
                    .RequiereCapturaFisico = chkReqCapturaFisico.Checked
                    If chkActivo.Checked Then
                        .Status = Kernel.BusinessStructure.CatalogState.Active
                    Else
                        .Status = Kernel.BusinessStructure.CatalogState.Inactive
                    End If
                    .IdSucursal = App.DefaultSite.Identity
                    .IdEmpresa = App.DefaultCompany.Identity
                End With
                AlmacenFac.Update(Almacen)
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class