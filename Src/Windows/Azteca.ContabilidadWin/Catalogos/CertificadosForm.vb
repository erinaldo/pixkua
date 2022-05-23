Imports Chilkat

Public Class CertificadosForm

#Region "Metodos Privados"

    Private Sub CargarCertificadoActual()
        Dim CertificadoInf As CertificadoInfo = CType(PackageInfo, CertificadoInfo)

        If CertificadoInf.Certificado Is Nothing Then
            lblIssuer.Text = "NO EXISTE CERTIFICADO"
        Else
            Dim Certificate As New Cert
            Dim success As Boolean = Certificate.LoadFromBinary(CertificadoInf.Certificado)
            lblIssuer.Text = Certificate.SubjectCN
            lblValidFrom.Text = Certificate.ValidFrom.ToString("dd-MMM-yyyy")
            lblValidTo.Text = Certificate.ValidTo.ToString("dd-MMM-yyyy")
        End If
    End Sub

#End Region

#Region "Implementacion"

    Protected Overrides Function IsValid() As Boolean
        IsValid = False
        If txtNumCertificado.Text.Length < 20 Then
            MessageBox.Show("El número de certificado debe tener una longitud de 20 caracteres.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumCertificado.Focus()
        Else
            Return MyBase.IsValid()
        End If
    End Function

    Private Sub CertificadosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
        bsSeries.DataSource = Certificado.Series
        rdbCFD.Checked = True
    End Sub

    Private Sub CertificadosForm_ItemSaved(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ItemSaved
        Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
        bsSeries.DataSource = Certificado.Series
    End Sub

    Private Sub CertificadosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CertificadosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
        With Certificado
            'General
            txtNombre.Text = .Nombre
            txtNumCertificado.Text = .NumeroCertificado
            CargarCertificadoActual()
            bsSeries.DataSource = .Series
            If .TipoCFD = FormatoCFD.CFD Then
                rdbCFD.Checked = True
            Else
                rdbCFDI.Checked = True
            End If
        End With
    End Sub

    Private Sub CertificadosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
        With Certificado
            'General
            .Nombre = txtNombre.Text
            .NumeroCertificado = txtNumCertificado.Text
            If .IdEmpresa = 0 Then .IdEmpresa = App.DefaultCompany.Identity
            If rdbCFD.Checked Then
                .TipoCFD = FormatoCFD.CFD
            Else
                .TipoCFD = FormatoCFD.CFDI
            End If
        End With
    End Sub

    Private Sub btnConfigCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigCert.Click
        Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
        Dim frmEditCert As New EditCertificadoDigitalForm
        If frmEditCert.ShowDialog(Me, Certificado) = System.Windows.Forms.DialogResult.OK Then
            CargarCertificadoActual()
        End If
    End Sub

    Private Sub btnNuevaSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevaSerie.Click
        Try
            Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
            If Certificado.Identity > 0 Then
                Dim frmEditSerie As New EditSerieForm
                If frmEditSerie.ShowDialog(Me, Certificado.Identity, Certificado.Nombre) = System.Windows.Forms.DialogResult.OK Then
                    Dim drSerie As CertificadoDS.SeriesRow = Certificado.Series.NewSeriesRow
                    With drSerie
                        .IdCFDSerie = frmEditSerie.SerieInf.Identity
                        .Codigo = frmEditSerie.SerieInf.UserCode
                        .Serie = frmEditSerie.SerieInf.Serie
                        .UltimoFolio = 0
                        .FolioLimite = 0
                        .Estatus = "Activo"
                    End With
                    Certificado.Series.AddSeriesRow(drSerie)
                End If
            Else
                MessageBox.Show("Primero guarde los datos del certificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnRegistrarFolios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarFolios.Click
        Dim Certificado As CertificadoInfo = CType(PackageInfo, CertificadoInfo)
        If bsSeries.Current IsNot Nothing Then
            Try
                Dim drSerie As CertificadoDS.SeriesRow = CType(CType(bsSeries.Current, DataRowView).Row, CertificadoDS.SeriesRow)
                Dim frmRegistrar As New RegistrarFoliosComprobantesForm
                If frmRegistrar.ShowDialog(Me, drSerie.IdCFDSerie, Certificado) = System.Windows.Forms.DialogResult.OK Then
                    drSerie.FolioLimite = frmRegistrar.txtFolioFinal.Text
                    grdSeries.Update()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub


    Private Sub btnDeshabilitarSerie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesabilitarSerie.Click
        If bsSeries.Current IsNot Nothing Then
            Try
                Dim Result As DialogResult = MessageBox.Show("¿Esta seguro que desea deshabilitar la serie seleccionada?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    Dim drvSerie As DataRowView = CType(bsSeries.Current, DataRowView)
                    Dim SerieFac As New SerieFacade
                    'Cargar información de la serie y modificar estatus
                    Dim SerieInf As SerieInfo = SerieFac.GetDetail(App.Session.SessionID, CInt(drvSerie("IdCFDSerie")), False)
                    SerieInf.Status = CatalogState.Inactive
                    SerieFac.Update(SerieInf)
                    'Marcar estatus en datarow
                    drvSerie("Estatus") = "Inactivo"
                    grdSeries.Update()
                    MessageBox.Show("La serie ha sido desactivada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

#End Region

End Class