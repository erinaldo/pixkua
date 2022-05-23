Public Class AbrirInventarioForm
    Private IdArea As Integer
    Private AreaFac As AreaFacade

    Private Function IsAperturaValida() As Boolean
        IsAperturaValida = False
        If cboTurno.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un turno de almacén", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboTurno.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idArea As Integer) As DialogResult
        Me.IdArea = idArea
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub AdminTurnosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            AreaFac = New AreaFacade
            cboTurno.LoadList(IdArea)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAbrirCorte_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAbrirCorte.Click
        If IsAperturaValida() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                AreaFac.AbrirCorte(App.Session.SessionID, IdArea, CInt(cboTurno.SelectedValue))
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class