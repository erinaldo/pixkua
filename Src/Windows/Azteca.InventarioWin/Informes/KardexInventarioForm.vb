Imports Microsoft.Reporting.WinForms

Public Class KardexInventarioForm

    Private Function CombineDateHour(ByVal fecha As Date, ByVal hora As Date) As Date
        Dim FechaTemp As Date = fecha
        FechaTemp = FechaTemp.AddHours(hora.Hour)
        FechaTemp = FechaTemp.AddMinutes(hora.Minute)
        FechaTemp = FechaTemp.AddSeconds(hora.Second)
        Return FechaTemp
    End Function

    Private Function IsValid() As Boolean
        IsValid = False
        If cboAlmacen.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un almacén", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboAlmacen.Focus()
        Else
            Return True
        End If
    End Function

    Private Sub ImprimirKardex()
        Dim FechaIni As Date = CombineDateHour(dtpFechaIni.Value, dtpHoraIni.Value)
        Dim FechaFin As Date = CombineDateHour(dtpFechaFin.Value, dtpHoraFin.Value)
        'Cargar información del informe
        Dim AlmacenSvc As New AlmacenFacade
        Dim dtKardex As DataTable = AlmacenSvc.GetInformeKardex(App.Session.SessionID, CInt(cboAlmacen.SelectedValue), FechaIni, FechaFin, txtArticulo.Key)
        'Generar parametros
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("FechaIni", FechaIni.ToString("dd/MM/yyyy hh:mm tt")))
        Parametros.Add(New ReportParameter("FechaFin", FechaFin.ToString("dd/MM/yyyy hh:mm tt")))
        'Configurar reporte
        Dim frmFacturas As New ReportForm
        frmFacturas.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Inventario.KardexAlmacenRPT.rdlc"
        frmFacturas.LocalReport.DataSources.Add(New ReportDataSource("Kardex", dtKardex))
        frmFacturas.LocalReport.SetParameters(Parametros)
        frmFacturas.Show("Kárdex del Inventario")
    End Sub

    Private Sub KardexInventarioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtpFechaIni.Value = Date.Today
            dtpFechaFin.Value = Date.Today
            dtpHoraIni.Value = Date.Today
            dtpHoraFin.Value = Date.Now
            cboArea.LoadListByUsuario(App.Session.User.Identity)
        Catch ex As Exception
            MsgInfo.Show(ex)
            Close()
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdImprimir.Click
        If IsValid() Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                ImprimirKardex()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub cboArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
        If cboArea.SelectedIndex >= 0 Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                cboAlmacen.LoadListByArea(CInt(cboArea.SelectedValue), App.Session.User.Identity, TipoAccesoAlmacen.Lectura)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

End Class