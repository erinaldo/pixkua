Imports Microsoft.Reporting.WinForms

Public Class MatrimonioForm

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub MatrimonioForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MatrimonioForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim MatrimonioInfo = CType(PackageInfo, MatrimonioInfo)

            With MatrimonioInfo
                txtLibro.Text = .Libro
                txtPagina.Text = .Pagina
                txtActaIzq.Text = .ActaIzq
                txtActaDer.Text = .ActaDer
                txtExpedienteIzq.Text = .ExpedienteIzq
                txtExpedienteDer.Text = .ExpedienteDer
                If (.IdSacerdote > 0) Then
                    txtSacerdote.LoadInfo(.IdSacerdote)
                    chkMostrarListaSacerdotes.Checked = True
                Else
                    chkMostrarListaSacerdotes.Checked = False
                End If
                txtPBRO1.Text = .Suscrito
                txtParroquiaDe.Text = CStr(.IdParroquiaSacerdote)
                txtParroquiaDe.LoadInfo()
                dtpFecha.Value = .Fecha
                txtEsposo.LoadInfo(.IdSolicitanteEsposo)
                txtEsposa.LoadInfo(.IdSolicitanteEsposa)
                dtpFechaExpedicion.Value = .FechaExpedicion

                txtContrajeonEn.Text = .ContrajeronEn
                txtAsistio.Text = .SacerdoteAsistio
                txtTestigo1.Text = .Testigo1
                txtTestigo2.Text = .Testigo2
                txtPadrino1.Text = .Padrino1
                txtPadrino2.Text = .Padrino2
                txtTraslado.Text = .LugarTraslado

            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub MatrimonioForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim MatrimonioInfo = CType(PackageInfo, MatrimonioInfo)

            With MatrimonioInfo
                .Libro = txtLibro.Text
                .Pagina = txtPagina.Text
                .ActaIzq = txtActaIzq.Text
                .ActaDer = txtActaDer.Text
                .ExpedienteIzq = txtExpedienteIzq.Text
                .ExpedienteDer = txtExpedienteDer.Text
                If (chkMostrarListaSacerdotes.Checked) Then
                    .IdSacerdote = txtSacerdote.Key
                    .Suscrito = ""
                Else
                    .IdSacerdote = 0
                    .Suscrito = txtPBRO1.Text
                End If
                .IdParroquiaSacerdote = txtParroquiaDe.Key
                .Fecha = dtpFecha.Value
                .IdSolicitanteEsposo = txtEsposo.Key
                .IdSolicitanteEsposa = txtEsposa.Key
                .FechaExpedicion = dtpFechaExpedicion.Value

                .ContrajeronEn = txtContrajeonEn.Text
                .SacerdoteAsistio = txtAsistio.Text
                .Testigo1 = txtTestigo1.Text
                .Testigo2 = txtTestigo2.Text
                .Padrino1 = txtPadrino1.Text
                .Padrino2 = txtPadrino2.Text
                .LugarTraslado = txtTraslado.Text

            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub chkMostrarListaSacerdotes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarListaSacerdotes.CheckedChanged
        txtSacerdote.Visible = chkMostrarListaSacerdotes.Checked
        txtPBRO1.Visible = Not chkMostrarListaSacerdotes.Checked
    End Sub

    Private Sub cmdImprimirActa_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimirActa.Click
        Try
            'Cargar información del informe
            Dim MatrimonioSvc As New MatrimonioFacade
            Dim dtActaMatrimonio As New DataTable

            dtActaMatrimonio = MatrimonioSvc.ActaMatrimonio(App.Session.SessionID, PackageInfo.Identity)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ActaMatrimonioRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("ActaMatrimonio", dtActaMatrimonio))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Matrimonio")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdImprimirConstancia_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimirConstancia.Click
        Try
            'Cargar información del informe
            Dim MatrimonioSvc As New MatrimonioFacade
            Dim dtActaMatrimonio As New DataTable

            dtActaMatrimonio = MatrimonioSvc.ActaMatrimonio(App.Session.SessionID, PackageInfo.Identity)

            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ConstanciaMatrimonioRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("ConstanciaMatrimonio", dtActaMatrimonio))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Matrimonio")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class