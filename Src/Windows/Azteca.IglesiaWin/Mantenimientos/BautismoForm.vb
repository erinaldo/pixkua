Imports Microsoft.Reporting.WinForms

Public Class BautismoForm

    Private Sub BautismoForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem

    End Sub

    Private Sub BautismoForm_ItemSaved(sender As Object, e As System.EventArgs) Handles Me.ItemSaved
        Call LoadPackageInfo()
    End Sub

    Private Sub BautismoForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadPackageInfo()
        Try
            Dim BautismoInfo = CType(PackageInfo, BautismoInfo)

            With BautismoInfo
                txtLibro.Text = .Libro
                txtPagina.Text = .Pagina
                txtActa.Text = .Acta
                If (.IdSacerdoteCertifica > 0) Then
                    txtSacerdoteCertifica.Text = CStr(.IdSacerdoteCertifica)
                    txtSacerdoteCertifica.LoadInfo()
                    chkMostrarListaSacerdotes.Checked = True
                Else
                    chkMostrarListaSacerdotes.Checked = False
                End If
                txtPBRO1.Text = .PBRO1

                txtLugar.Text = .Lugar
                txtParroquia.Text = .IdParroquia
                txtParroquia.LoadInfo()
                dtpFechaBautizo.Value = .Fecha
                txtSacerdoteBautizo.Text = .IdSacerdoteBautizo
                txtSacerdoteBautizo.LoadInfo()
                SolicitanteSel.LoadInfo(.IdSolicitante)
                txtPadrinos.Text = .Padrinos
                txtNotasaMarginales.Text = .NotasMarginales
                txtNumOficina.Text = .NumOfina
                txtNumActa.Text = .NumeroActa
                txtLibroActa.Text = .LibroActa
                txtLugarRegistro.Text = .LugarRegistro
                chkIlegitimo.Checked = .Ilegitimo
                txtTenor.Text = .Tenor
                dtpFechaExpedicion.Value = .FechaExpedicion
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub BautismoForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Call LoadPackageInfo()
    End Sub

    Private Sub BautismoForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim BautismoInfo = CType(PackageInfo, BautismoInfo)

            With BautismoInfo
                .Libro = txtLibro.Text
                .Pagina = txtPagina.Text
                .Acta = txtActa.Text
                If (chkMostrarListaSacerdotes.Checked) Then
                    .IdSacerdoteCertifica = txtSacerdoteCertifica.Key
                    .PBRO1 = ""
                Else
                    .IdSacerdoteCertifica = 0
                    .PBRO1 = txtPBRO1.Text
                End If
                .Lugar = txtLugar.Text
                .IdParroquia = txtParroquia.Key
                .Fecha = dtpFechaBautizo.Value
                .IdSacerdoteBautizo = txtSacerdoteBautizo.Text
                .IdSolicitante = SolicitanteSel.Key
                .Padrinos = txtPadrinos.Text
                .NotasMarginales = txtNotasaMarginales.Text
                .NumOfina = txtNumOficina.Text
                If (Trim(txtLibroActa.Text) = String.Empty) Then
                    .LibroActa = 0
                Else
                    .LibroActa = CInt(txtLibroActa.Text)
                End If

                If (Trim(txtNumActa.Text) = String.Empty) Then
                    .NumeroActa = 0
                Else
                    .NumeroActa = CInt(txtNumActa.Text)
                End If
                .LugarRegistro = txtLugarRegistro.Text
                .Ilegitimo = chkIlegitimo.Checked
                .Tenor = txtTenor.Text
                .FechaExpedicion = dtpFechaExpedicion.Value
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdImprimirActa_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimirActa.Click
        Try
            'Cargar información del informe
            Dim BautismoSvc As New BautismoFacade
            Dim dtActaBautismo As New DataTable

            dtActaBautismo = BautismoSvc.ActaBautismo(App.Session.SessionID, PackageInfo.Identity)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ActaBautismoRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("BautismoActa", dtActaBautismo))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Bautismo")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub chkMostrarListaSacerdotes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarListaSacerdotes.CheckedChanged

        txtSacerdoteCertifica.Visible = chkMostrarListaSacerdotes.Checked
        txtPBRO1.Visible = Not chkMostrarListaSacerdotes.Checked

        If (Not chkMostrarListaSacerdotes.Checked) Then
            txtSacerdoteCertifica.LoadInfo(0)
        End If




    End Sub

    Private Sub cmdImprimirConstancia_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimirConstancia.Click
        Try
            'Cargar información del informe
            Dim BautismoSvc As New BautismoFacade
            Dim dtActaBautismo As New DataTable

            dtActaBautismo = BautismoSvc.ActaBautismo(App.Session.SessionID, PackageInfo.Identity)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ConstanciaBautismoRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("BautismoActa", dtActaBautismo))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Bautismo")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class