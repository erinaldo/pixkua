Imports System.IO

Public Class CFDEmitidosForm
    Private ComprobanteFac As ComprobanteFiscalFacade

    Private Sub CFDEmitidosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ComprobanteFac = New ComprobanteFiscalFacade
            cboEmpresa.LoadList(App.Session.User.Identity)
            cboEmpresa.SelectedValue = App.DefaultCompany.Identity
            '
            If Date.Today.Month >= 2 Then
                cboMes.SelectedIndex = Date.Today.Month - 2
            Else
                cboMes.SelectedIndex = 11
            End If
            nudAnio.Value = Date.Today.Year
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim FechaInicial As Date = New Date(CInt(nudAnio.Value), cboMes.SelectedIndex + 1, 1)
            Dim FechaFinal As Date = New Date(CInt(nudAnio.Value), cboMes.SelectedIndex + 1, Date.DaysInMonth(CInt(nudAnio.Value), cboMes.SelectedIndex + 1))
            Dim dtComprobantes As InformesDS.ComprobantesEmitidosDataTable = ComprobanteFac.CargarInforme(App.Session.SessionID, CInt(cboEmpresa.SelectedValue), FechaInicial, FechaFinal)
            bsComprobantes.DataSource = dtComprobantes
            grdFacturas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If dlgFolder.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim fileName As String = dlgFolder.SelectedPath & "\" & "1" & App.DefaultCompany.RFC & (cboMes.SelectedIndex + 1).ToString("00") & CInt(nudAnio.Value).ToString & ".txt"
                Dim FechaInicial As Date = New Date(CInt(nudAnio.Value), cboMes.SelectedIndex + 1, 1)
                Dim FechaFinal As Date = New Date(CInt(nudAnio.Value), cboMes.SelectedIndex + 1, Date.DaysInMonth(CInt(nudAnio.Value), cboMes.SelectedIndex + 1))
                Dim Informe As String = ComprobanteFac.GenerarInformeHacienda(App.Session.SessionID, CInt(cboEmpresa.SelectedValue), FechaInicial, FechaFinal)
                Dim Writer As TextWriter = File.CreateText(fileName)
                Writer.Write(Informe)
                Writer.Close()
                MessageBox.Show("El informe mensual de comprobantes emitidas se ha generado como: " & fileName, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        grdFacturas.PrintInfo.PrintPreview()
    End Sub
End Class