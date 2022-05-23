Imports Microsoft.Reporting.WinForms
Public Class TrasladoForm

    Private Sub TrasladoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TrasladoForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim TrasladoInfo As TrasladoInfo = CType(PackageInfo, TrasladoInfo)

            With TrasladoInfo
                txtExpediente.Text = .Expediente
                txtNumero.Text = .NumParroquiaDest
                txtParroquiaCura.Text = CStr(.IdParroquiaCura)
                txtParroquiaCura.LoadInfo()
                txtEsposo.Text = CStr(.IdSolicitanteEsposo)
                txtEsposo.LoadInfo()
                txtEsposa.Text = CStr(.IdSolicitanteEsposa)
                txtEsposa.LoadInfo()
                txtTemplo.Text = .Templo
                dtpFechaExpedicion.Value = .FechaExpedicion
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub TrasladoForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim TrasladoInfo As TrasladoInfo = CType(PackageInfo, TrasladoInfo)

            With TrasladoInfo
                .Expediente = txtExpediente.Text
                .NumParroquiaDest = txtNumero.Text
                .IdParroquiaCura = txtParroquiaCura.Key
                .IdSolicitanteEsposo = txtEsposo.Key
                .IdSolicitanteEsposa = txtEsposa.Key
                .Templo = txtTemplo.Text
                .FechaExpedicion = dtpFechaExpedicion.Value
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtParroquiaCura_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtParroquiaCura.InfoLoaded
        Dim parroquiaInfo As New ParroquiaInfo(App.Session.SessionID)
        If (txtParroquiaCura.Key > 0) Then
            parroquiaInfo = txtParroquiaCura.PackageInfo
            lblDomicilio.Text = parroquiaInfo.Calle & ", " & parroquiaInfo.Colonia & ", CP:" & parroquiaInfo.CP
        Else
            lblDomicilio.Text = "Domicilio"
        End If




    End Sub

    Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimir.Click
        Try
            'Cargar información del informe
            Dim TrasladoSvc As New TrasladoFacade
            Dim dtTraslado As New DataTable

            dtTraslado = TrasladoSvc.InformeTraslado(App.Session.SessionID, PackageInfo.Identity)


            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.TrasladoRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("Traslado", dtTraslado))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Confirmación")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class