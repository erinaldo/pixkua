Imports Microsoft.Reporting.WinForms

Public Class ConfirmacionForm

    Private Sub ConfirmacionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ConfirmacionForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim BautismoInfo = CType(PackageInfo, ConfirmacionInfo)

            With BautismoInfo
                txtLibro.Text = .Libro
                txtPagina.Text = .Pagina
                txtActa.Text = .Acta
                If (.IdSacerdote > 0) Then
                    txtSacerdote.LoadInfo(.IdSacerdote)
                    chkMostrarListaSacerdotes.Checked = True
                Else
                    chkMostrarListaSacerdotes.Checked = False
                End If
                txtPBRO1.Text = .Conferida
                dtpFechaConfirmacion.Value = .Fecha
                SolicitanteSel.LoadInfo(.IdSolicitante)
                txtPadrino1.Text = .Padrino1
                If .GeneroPadrino1 = "M" Then
                    rbtnMasculino.Checked = True
                    rbtnFemenino.Checked = False
                ElseIf .GeneroPadrino1 = "F" Then
                    rbtnFemenino.Checked = True
                    rbtnMasculino.Checked = False
                End If
                dtpFechaExpedicion.Value = .FechaExpedicion
                ParroquiaSel.Text = CStr(.IdParroquia)
                ParroquiaSel.LoadInfo()
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub ConfirmacionForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim BautismoInfo = CType(PackageInfo, ConfirmacionInfo)

            With BautismoInfo
                .Libro = txtLibro.Text
                .Pagina = txtPagina.Text
                .Acta = txtActa.Text
                If (chkMostrarListaSacerdotes.Checked) Then
                    .IdSacerdote = txtSacerdote.Key
                    .Conferida = ""
                Else
                    .IdSacerdote = 0
                    .Conferida = txtPBRO1.Text
                End If
                .Fecha = dtpFechaConfirmacion.Value
                .IdSolicitante = SolicitanteSel.Key
                .Padrino1 = txtPadrino1.Text
                If rbtnMasculino.Checked Then
                    .GeneroPadrino1 = "M"
                    .GeneroPadrino2 = ""
                ElseIf rbtnFemenino.Checked Then
                    .GeneroPadrino1 = "F"
                    .GeneroPadrino2 = ""
                End If
                .Padrino2 = ""
                .FechaExpedicion = dtpFechaExpedicion.Value
                .IdParroquia = ParroquiaSel.Key

            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub chkMostrarListaSacerdotes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMostrarListaSacerdotes.CheckedChanged
        txtSacerdote.Visible = chkMostrarListaSacerdotes.Checked
        txtPBRO1.Visible = Not chkMostrarListaSacerdotes.Checked
    End Sub

    Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimir.Click
        Try
            'Cargar información del informe
            Dim ConfirmacionSvc As New ConfirmacionFacade
            Dim dtActaConfirmacion As New DataTable

            dtActaConfirmacion = ConfirmacionSvc.ActaConfirmacion(App.Session.SessionID, PackageInfo.Identity)


            'Generar parametros
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            'Configurar reporte
            Dim frmReport As New ReportForm
            With frmReport
                .LocalReport.ReportEmbeddedResource = "Azteca.Windows.Iglesia.ActaConfirmacionRPT.rdlc"
                .LocalReport.DataSources.Add(New ReportDataSource("ConfirmacionActa", dtActaConfirmacion))
                .LocalReport.SetParameters(Parametros)
                .Show("Acta de Confirmación")
            End With


        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class