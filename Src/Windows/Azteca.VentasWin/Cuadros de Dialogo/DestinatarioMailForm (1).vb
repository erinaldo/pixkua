Public Class DestinatarioMailForm

    Public ReadOnly Property MailTo As String
        Get
            Return txtPara.Text
        End Get
    End Property

    Public ReadOnly Property MailCC As String
        Get
            Return txtCC.Text
        End Get
    End Property

    Public ReadOnly Property MailBody As String
        Get
            Return txtMensaje.Text
        End Get
    End Property


    Public Overloads Function showdialog(DestinatarioMail As String, CC As String, Mensaje As String) As DialogResult
        txtPara.Text = DestinatarioMail
        txtCC.Text = CC
        txtMensaje.Text = Mensaje
        Return Me.ShowDialog
    End Function

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If txtPara.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe establecer un destinatario de correo válido", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class