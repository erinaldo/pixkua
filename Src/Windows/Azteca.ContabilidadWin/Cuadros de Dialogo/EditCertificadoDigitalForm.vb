Imports Chilkat

Public Class EditCertificadoDigitalForm
    Private CertificadoInf As CertificadoInfo

    Protected Function StringToByteArray(hex As String) As Byte()
        Dim NumberChars As Integer = hex.Length
        Dim bytes As Byte() = New Byte((NumberChars \ 2) - 1) {}
        For i As Integer = 0 To NumberChars - 1 Step 2
            bytes(i \ 2) = Convert.ToByte(hex.Substring(i, 2), 16)
        Next
        Return bytes
    End Function

    Private Function IsValid() As Boolean
        IsValid = False
        If txtCertificate.Text = String.Empty Then
            MessageBox.Show("Especifique el archivo del certificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCertificate.Focus()
        ElseIf txtPrivateKey.Text = String.Empty Then
            MessageBox.Show("Especifique el archivo de la llave privada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrivateKey.Focus()
        ElseIf txtPassword.Text = String.Empty Then
            MessageBox.Show("Indique el password de la llave privada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
        Else
            Return True
        End If
    End Function

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal certificado As CertificadoInfo) As System.Windows.Forms.DialogResult
        Me.CertificadoInf = certificado
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnSelCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelCert.Click
        If dlgCertificate.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtCertificate.Text = dlgCertificate.FileName            
        End If
    End Sub

    Private Sub btnSelPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelPK.Click
        If dlgPrivateKey.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPrivateKey.Text = dlgPrivateKey.FileName
        End If
    End Sub

    Private Sub btnChangeCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeCert.Click
        If IsValid() Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try
                'Cargar certificado
                Dim Certificate As New Cert
                Dim success As Boolean = Certificate.LoadFromFile(txtCertificate.Text)
                If Not success Then Throw New BusinessException("Error al cargar el archivo del certificado.")
                'Cargar llave privada
                Dim PK As New PrivateKey
                success = PK.LoadPkcs8EncryptedFile(txtPrivateKey.Text, txtPassword.Text)
                If Not success Then Throw New BusinessException("Error al cargar el archivo de la llave privada.")
                'Asignar certificado y llave privada a la unidad de negocio
                With CertificadoInf
                    .Certificado = Certificate.ExportCertDer
                    .LlavePrivada = PK.GetPkcs8Encrypted(txtPassword.Text)
                    .PasswordPrivateKey = txtPassword.Text
                    .NumeroCertificado = System.Text.Encoding.ASCII.GetString(StringToByteArray(Certificate.SerialNumber))
                End With
                DialogResult = System.Windows.Forms.DialogResult.OK
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        End If
    End Sub

End Class