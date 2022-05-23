Imports Microsoft.Reporting.WinForms

Public Class InformesForm

    Private Sub InformesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim PolizaFac As New PolizaFacade
        cboInformes.DisplayMember = "Nombre" : cboInformes.ValueMember = "IdInforme"
        cboInformes.DataSource = PolizaFac.InformesList(App.Session.SessionID, App.Session.User.Identity)

        cboEjercicioFiscal.LoadList(App.DefaultCompany.Identity)
    End Sub

    Private Sub cboInformes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInformes.SelectedIndexChanged
        'Habilitamos los controles de las propiedades por las que filtra el reporte
        Dim dtSource As DataTable = CType(cboInformes.DataSource, DataTable)
        Dim dv As New DataView(dtSource, "IdInforme=" & cboInformes.SelectedValue, "", DataViewRowState.CurrentRows)

        selCuenta.Enabled = (CBool(dv(0)("SeleccionarCuenta")))
    End Sub

    Private Sub cboEjercicioFiscal_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Not Valida() Then Exit Sub
        Select Case CInt(cboInformes.SelectedValue)
            Case 1 : PrintBalanceGral()
            Case 2 : PrintEstadoResultados()
        End Select
    End Sub

    Private Function Valida() As Boolean
        If cboInformes.SelectedValue = 0 Then
            MessageBox.Show("Debe seleccionar un informe", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If cboEjercicioFiscal.SelectedValue = "" Then
            MessageBox.Show("Debe seleccionar un ejercicio fiscal", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If cboPeriodo.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar un periodo del ejercicio fiscal", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If selCuenta.Enabled And selCuenta.Key = 0 Then
            MessageBox.Show("Debe seleccionar una Cuenta", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return True
    End Function

    Private Sub PrintBalanceGral()
        'Cargar información de impresión del informe
        Dim PolizaFac As New PolizaFacade
        Dim dtReport As InformesDS.BalanceGralDataTable = PolizaFac.BalanceGral(App.Session.SessionID, App.DefaultCompany.Identity, CStr(cboEjercicioFiscal.SelectedValue), cboPeriodo.SelectedIndex + 1)
        'Definir parametros del informe
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("Periodo", "ultimo día de " & cboPeriodo.Text))
        'Mostrar vista previa 
        Dim frmReport As New ReportForm
        frmReport.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Contabilidad.BalanceGral.rdlc"
        frmReport.LocalReport.DataSources.Add(New ReportDataSource("BalanceGral", CType(dtReport, DataTable)))
        frmReport.LocalReport.SetParameters(Parametros)
        frmReport.Show("Balance General")
    End Sub

    Private Sub PrintEstadoResultados()
        'Cargar información de impresión del informe
        Dim PolizaFac As New PolizaFacade
        Dim dtReport As InformesDS.EstadoResultadosDataTable = PolizaFac.EstadoResultados(App.Session.SessionID, App.DefaultCompany.Identity, CStr(cboEjercicioFiscal.SelectedValue), cboPeriodo.SelectedIndex + 1)
        'Definir parametros del informe
        Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
        Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
        Parametros.Add(New ReportParameter("Periodo", "ultimo día de " & cboPeriodo.Text))
        'Mostrar vista previa 
        Dim frmReport As New ReportForm
        frmReport.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Contabilidad.EstadoResultados.rdlc"
        frmReport.LocalReport.DataSources.Add(New ReportDataSource("EstadoResultados", CType(dtReport, DataTable)))
        frmReport.LocalReport.SetParameters(Parametros)
        frmReport.Show("Estado Resultados")
    End Sub


End Class