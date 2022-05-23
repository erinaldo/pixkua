Public Class RegistrarFoliosComprobantesForm
    Private IdSerie As Integer
    Private Certificado As CertificadoInfo
    Private SerieInf As SerieInfo
    Private SerieFac As SerieFacade

    Private Function IsValid() As Boolean
        IsValid = False
        If txtNumAprobacion.Text = String.Empty And Not txtNumAprobacion.ReadOnly Then
            MessageBox.Show("Debe ingresar el número de aprobación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumAprobacion.Focus()
        ElseIf (txtAnioAprobacion.Text = String.Empty OrElse Val(txtAnioAprobacion.Text) < Date.Today.Year) And Not txtAnioAprobacion.ReadOnly Then
            MessageBox.Show("Debe ingresar el año de aprobación y este debe ser igual al año actual.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAnioAprobacion.Focus()
        ElseIf txtFolioFinal.Text = String.Empty Then
            MessageBox.Show("Debe ingresar el folio final para facturación", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFolioFinal.Focus()
        ElseIf Val(txtFolioFinal.Text) <= SerieInf.UltimoFolio Then
            MessageBox.Show("El folio final no puede ser menor o igual al folio limite actual.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtFolioFinal.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idSerie As Integer, certificado As CertificadoInfo) As DialogResult
        Me.IdSerie = idSerie
        Me.Certificado = certificado
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub RegistrarFoliosFacturasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SerieFac = New SerieFacade
            SerieInf = SerieFac.GetDetail(App.Session.SessionID, IdSerie, False)
            '            
            txtCertificado.Text = Certificado.Nombre
            txtSerie.Text = SerieInf.Serie
            txtAnioAprobacion.Text = Date.Today.Year.ToString
            '
            If Certificado.TipoCFD = FormatoCFD.CFDI Then
                txtAnioAprobacion.Text = String.Empty
                txtAnioAprobacion.ReadOnly = True
                txtNumAprobacion.ReadOnly = True
                txtFolioInicial.Focus()
            Else
                txtNumAprobacion.Focus()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If IsValid() Then
                Dim SerieFac As New SerieFacade
                SerieFac.RegistrarFolios(App.Session.SessionID, IdSerie, CInt(Val(txtAnioAprobacion.Text)), CInt(Val(txtNumAprobacion.Text)), CInt(txtFolioInicial.Text), CInt(txtFolioFinal.Text))
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class