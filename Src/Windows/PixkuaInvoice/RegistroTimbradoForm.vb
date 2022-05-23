Public Class RegistroTimbradoForm

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim Certificado As New Azteca.Business.Contabilidad.CertificadoFacade
            Certificado.RegistroUsuarioCFDI(Azteca.Windows.App.Session.SessionID, txtUsuario.Text, txtPassword.Text)
            MessageBox.Show("Se ha reallizado el registro de su Usuario de Timbrado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

   
    Private Sub RegistroTimbradoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim Registrado As Boolean = CBool(ConfigMgr.GetSystemParameter("Configuracion/RegistroUserCFDI", "Registrado"))
        'Dim Usuario As String = CStr(ConfigMgr.GetSystemParameter("Configuracion/RegistroUserCFDI", "Usuario"))
        'Dim Password As String = CStr(ConfigMgr.GetSystemParameter("Configuracion/RegistroUserCFDI", "Usuario"))

        Dim TimbradorFac As New Azteca.Business.Contabilidad.TimbradorFacade
        Dim Timbrador As Azteca.Business.Contabilidad.TimbradorInfo = TimbradorFac.GetDetail(Azteca.Windows.App.Session.SessionID, 1)

        lblPruebas.Visible = Not Registrado
        lblAunNo.Visible = Not Registrado
        lnkPagina.Visible = Not Registrado

        txtUsuario.Text = Timbrador.Usuario
        txtPassword.Text = Timbrador.Password
    End Sub

    Private Sub lnkPagina_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPagina.LinkClicked
        Try
            System.Diagnostics.Process.Start("http://www.aztecasoftware.mx/productos/pixkua-facturacion/")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class