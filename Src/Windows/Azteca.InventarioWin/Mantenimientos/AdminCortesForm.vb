Public Class AdminCortesForm
    Private AreaFac As AreaFacade

    Private Sub SetButtonStatus()
        If bsCortes.Current Is Nothing Then Return
        If Val(grdCortes.Columns("IdStatus").Value) = 1 Then
            cmdAbrirCorte.Enabled = False
            cmdCerrarCorte.Enabled = True
            cmdCapturaFisico.Enabled = True
        Else
            cmdAbrirCorte.Enabled = True
            cmdCerrarCorte.Enabled = False
            cmdCapturaFisico.Enabled = False
        End If
    End Sub

    Private Sub CargarCortes()
        Try
            Dim Cortes As DataTable = AreaFac.LoadCortes(App.Session.SessionID, App.DefaultSite.Identity, App.Session.User.Identity)
            bsCortes.DataSource = Cortes
            grdCortes.Rebind(True)
            SetButtonStatus()
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de cortes.", ex)
        End Try
    End Sub

    Private Sub AdminCortesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            AreaFac = New AreaFacade
            CargarCortes()
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub cmdAbrirCorte_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAbrirCorte.Click
        If bsCortes.Current Is Nothing Then Return
        If Val(grdCortes.Columns("IdStatus").Value) = 0 Then
            Try
                Dim frmAbrir As New AbrirInventarioForm()
                If frmAbrir.ShowDialog(Me, CInt(grdCortes.Columns("IdArea").Value)) = System.Windows.Forms.DialogResult.OK Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    CargarCortes()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("El inventario del área seleccionada ya está abierto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCerrarCorte_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCerrarCorte.Click        
        If bsCortes.Current Is Nothing Then Return        
        If Val(grdCortes.Columns("IdStatus").Value) = 1 Then
            Try
                Dim IdCorteActual As Guid = New Guid(grdCortes.Columns("IdCorte").Value.ToString)                
                Dim frmCerrar As New CerrarInventarioForm()
                If frmCerrar.ShowDialog(Me, IdCorteActual) = System.Windows.Forms.DialogResult.OK Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    CargarCortes()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("El inventario del área seleccionada ya está cerrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cmdCapturaFisico_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdCapturaFisico.Click
        If bsCortes.Current Is Nothing Then Return
        Try
            Dim frmCapturaFis As New CapturaInventarioFisicoForm
            If frmCapturaFis.ShowDialog(Me, CInt(grdCortes.Columns("IdArea").Value)) = System.Windows.Forms.DialogResult.OK Then

            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCortes_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdCortes.FetchRowStyle
        If grdCortes.Columns("IdStatus").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.SystemColors.Info
        End If
    End Sub

    Private Sub bsCortes_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsCortes.CurrentChanged
        SetButtonStatus()
    End Sub
End Class