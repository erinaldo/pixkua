Public Class CertificadosCombobox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Certificado As New CertificadoFacade
            Dim dtCertificados As DataTable = Certificado.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdCFDCertificado"
            _ItemsTable = dtCertificados
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
