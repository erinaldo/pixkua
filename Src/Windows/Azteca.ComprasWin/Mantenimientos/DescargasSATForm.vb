Imports Azteca.Business.Contabilidad

Public Class DescargasSATForm
    Private ConfigMgr As Azteca.Kernel.Configuration.ConfigurationFacade

    Private Sub GuardarFolios()

    End Sub

    Private Sub DescargasSATForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConfigMgr = New Azteca.Kernel.Configuration.ConfigurationFacade
            'Cargar parametros de configuración
            Dim UltimaAct As String = ConfigMgr.GetSystemParameter("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "UtimaActualizacion")
            If UltimaAct.Trim = String.Empty Then
                lblUltActualizacion.Text = "NUNCA"
            Else
                lblUltActualizacion.Text = UltimaAct
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            btnActualizar.Enabled = False
            Dim Resp As DialogResult = MessageBox.Show("La descarga de archivos puede tardar varios minutos ¿Desea continuar?", "Confirmar Acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.OK Then
                Dim SAT As New SATFacade
                If chkFolios.Checked Then SAT.GuardarFoliosAutorizados(App.Session.SessionID)
                If chkCertificados.Checked Then SAT.GuardarCertificados(App.Session.SessionID)
                lblUltActualizacion.Text = ConfigMgr.GetSystemParameter("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "UtimaActualizacion")
                MessageBox.Show("La información ha sido descargada y actualizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            btnActualizar.Enabled = True
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManual.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try

        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnSelFolios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFolios.Click
        If dlgOpen.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtArchivoFolios.Text = dlgOpen.FileName
        End If
    End Sub

    Private Sub btnSelCerts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelCerts.Click
        If dlgOpen.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtArchivoCert.Text = dlgOpen.FileName
        End If
    End Sub

End Class