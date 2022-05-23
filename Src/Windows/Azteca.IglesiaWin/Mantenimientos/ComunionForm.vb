Imports Microsoft.Reporting.WinForms

Public Class ComunionForm

    Private Sub ComunionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComunionForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim ComunionInfo As ComunionInfo = CType(PackageInfo, ComunionInfo)

            With ComunionInfo
                txtLibro.Text = .Libro
                txtPagina.Text = .Pagina
                txtSacerdoteCertifica.Text = CStr(.IdSacerdoteCertifica)
                txtSacerdoteCertifica.LoadInfo()
                txtParroquiaSacerdoteCer.Text = CStr(.IdParroquiaSacerdoteCer)
                txtParroquiaSacerdoteCer.LoadInfo()
                txtSolicitante.Text = CStr(.IdSolicitante)
                txtSolicitante.LoadInfo()
                txtSacerdoteCelebra.Text = CStr(.IdSacerdoteCelebra)
                txtSacerdoteCelebra.LoadInfo()
                txtPadrinos.Text = .Padrinos
                dtpFecha.Value = .Fecha
                dtpFechaExpedicion.Value = .FechaExpedicion
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ComunionForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim ComunionInfo As ComunionInfo = CType(PackageInfo, ComunionInfo)

            With ComunionInfo
                .Libro = txtLibro.Text
                .Pagina = txtPagina.Text
                .IdSacerdoteCertifica = txtSacerdoteCertifica.Key
                .IdParroquiaSacerdoteCer = txtParroquiaSacerdoteCer.Key
                .IdSolicitante = txtSolicitante.Key
                .IdSacerdoteCelebra = txtSacerdoteCelebra.Key
                .Padrinos = txtPadrinos.Text
                .Fecha = dtpFecha.Value
                .FechaExpedicion = dtpFechaExpedicion.Value
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs)
       
    End Sub

    Private Sub cmdImprimirActa_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimirActa.Click
        Try
            'Cargar información del informe
            Dim ComunionSvc As New ComunionFacade
            Dim dtComunion As New DataTable

            dtComunion = ComunionSvc.InformeComunion(App.Session.SessionID, PackageInfo.Identity)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ActaComunionRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("Comunion", dtComunion))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Comunion")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdImprimirConstancia_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimirConstancia.Click
        Try
            'Cargar información del informe
            Dim ComunionSvc As New ComunionFacade
            Dim dtComunion As New DataTable

            dtComunion = ComunionSvc.InformeComunion(App.Session.SessionID, PackageInfo.Identity)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ConstanciaComunionRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("Comunion", dtComunion))
                .LocalReport.SetParameters(Parametros)
                .Show("Constancia de Comunion")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class