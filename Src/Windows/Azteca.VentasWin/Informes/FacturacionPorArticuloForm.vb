Public Class FacturacionPorArticuloForm

    Private Sub FacturacionPorArticulo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PorArticulo()
        Try
            ' Cargar información de impresión
            Dim VentaFac As New VentaFacade
            Dim dtSource As DataTable = VentaFac.FacturacionPorArticulo(App.Session.SessionID, App.DefaultCompany.Identity, Me.dtpFechaIni.Value, Me.dtpFechaFin.Value)

            Dim Ordenar As String = "A"
            'If optOrdenArticulo.Checked Then
            '    Ordenar = "A"
            'ElseIf optOrdenImporte.Checked Then
            '    Ordenar = "I"
            'ElseIf opOrdenCantidad.Checked Then
            '    Ordenar = "C"
            'End If

            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("TituloReporte", "Facturación de Articulos por Periodo:[" & dtpFechaIni.Value.ToShortDateString & " al " & dtpFechaFin.Value.ToShortDateString & "]"))
            Parametros.Add(New ReportParameter("Ordenar", Ordenar))

            Dim frm As New ReportForm
            frm.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.FacturacionPorArticuloRPT.rdlc"
            frm.LocalReport.DataSources.Add(New ReportDataSource("Empresa", CType(getEmpresaTableRPT(), DataTable)))
            frm.LocalReport.DataSources.Add(New ReportDataSource("Facturacion", CType(dtSource, DataTable)))

            frm.LocalReport.SetParameters(Parametros)
            frm.Show("Facturación")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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

    Private Sub FacturacionInformesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblEmpresa.Text = App.DefaultCompany.NombreLargo
        lblReporte.Text = Me.Text
        Dim Imagen As Byte() = App.DefaultCompany.Logo

        Dim ms As New System.IO.MemoryStream(Imagen)
        picLogoEmpresa.Image = System.Drawing.Image.FromStream(ms)
        ms.Close()
    End Sub

    Private Sub btnAceptar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        PorArticulo()
    End Sub

End Class