Public Class FacturacionInformesCteForm

    Private Sub FacturacionInformesCteForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblEmpresa.Text = App.DefaultCompany.NombreLargo
        lblReporte.Text = Me.Text
        Dim Imagen As Byte() = App.DefaultCompany.Logo

        Dim ms As New System.IO.MemoryStream(Imagen)
        picLogoEmpresa.Image = System.Drawing.Image.FromStream(ms)
        ms.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Not chkClientes.Checked And selCliente.Key = 0 Then
                MessageBox.Show("Debe seleccionar un cliente o seleccionar la opción de mostrar todos", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            Dim IdCliente As Integer = 0
            If chkClientes.Checked Then IdCliente = selCliente.Key

            ' Cargar información de impresión
            Dim VentaFac As New VentaFacade
            Dim dtSource As DataTable = VentaFac.FacturacionPeriodo(App.Session.SessionID, App.DefaultCompany.Identity, Me.dtpFechaIni.Value, Me.dtpFechaFin.Value, IdCliente)

            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("TituloReporte", "Facturación por Cliente:[" & dtpFechaIni.Value.ToShortDateString & " al " & dtpFechaFin.Value.ToShortDateString & "]"))

            Dim frm As New ReportForm
            frm.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.FacturacionPorClienteRPT.rdlc"
            frm.LocalReport.DataSources.Add(New ReportDataSource("Empresa", CType(getEmpresaTableRPT(), DataTable)))
            frm.LocalReport.DataSources.Add(New ReportDataSource("Facturacion", CType(dtSource, DataTable)))

            frm.LocalReport.SetParameters(Parametros)
            frm.Show("Facturación")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function getEmpresaTableRPT() As DataTable
        Dim LogoTable As New DataTable
        LogoTable.Columns.Add("Nombre", System.Type.GetType("System.String"))
        LogoTable.Columns.Add("Logo", System.Type.GetType("System.Byte[]"))

        Dim row As DataRow = LogoTable.NewRow
        row("Nombre") = App.DefaultCompany.NombreLargo
        row("Logo") = App.DefaultCompany.Logo
        LogoTable.Rows.Add(row)
        Return LogoTable
    End Function

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub chkClientes_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkClientes.CheckedChanged
        selCliente.Enabled = Not chkClientes.Checked
    End Sub

End Class