Public Class ImpresionCorteForm
    Private _IdCaja As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idCaja As Integer, ByVal Caja As String) As DialogResult
        _IdCaja = idCaja
        lblCaja.Text = Caja
        Me.Icon = owner.Icon
        Return MyBase.ShowDialog()
    End Function

    Private Sub btnVerCortes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerCortes.Click
        loadCortes()
    End Sub

    Private Sub btnImpresionCorteGrafica_Click(sender As System.Object, e As System.EventArgs) Handles btnImpresionCorte.Click
        If Not IsNothing(bsCortes.Current) Then
            ImprimirCorte()
        Else
            MessageBox.Show("Debe seleccionar un corte ", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
  
    Private Sub ImpresionCorteForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.dtpFechaIni.Value = Date.Today.AddDays(-2)
        loadCortes()
    End Sub

    Private Sub loadCortes()
        Try
            Dim row As DataRowView = CType(bsCortes.Current, DataRowView)
            Dim CajaFac As New CajaFacade
            bsCortes.DataSource = CajaFac.LoadCortes(App.Session.SessionID, _IdCaja, dtpFechaIni.Value, dtpFechaFin.Value)
            grdCortes.Rebind(True)
            grdCortes.Focus()
            grdCortes.MoveLast()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub showDetalle()
        Dim frm As New DetalleCorteForm
        Dim row As DataRowView = CType(bsCortes.Current, DataRowView)
        Dim IdCorte As Guid = CType(row("IdCorte"), Guid)
        Dim FechaApertura As Date = CDate(row("HoraApertura"))
        If IsDBNull(row("HoraCierre")) Then
            If frm.ShowDialog(Me, IdCorte, lblCaja.Text, FechaApertura) = System.Windows.Forms.DialogResult.OK Then

            End If
        Else
            If frm.ShowDialog(Me, IdCorte, lblCaja.Text, FechaApertura, CDate(row("HoraCierre"))) = System.Windows.Forms.DialogResult.OK Then

            End If
        End If
    End Sub

    Private Sub ImprimirCorte()
        Try
            Dim row As DataRowView = CType(bsCortes.Current, DataRowView)
            Dim CajaFac As New CajaFacade

            Dim dtCorte As InformesDS.CorteCajaDataTable = CajaFac.LoadCortePrintInfo(App.Session.SessionID, CType(row("IdCorte"), Guid))
            'Definir parametros del informe
            Dim Parametros As New System.Collections.Generic.List(Of ReportParameter)
            Parametros.Add(New ReportParameter("Empresa", App.DefaultCompany.NombreLargo))
            Parametros.Add(New ReportParameter("Sucursal", App.DefaultSite.NombreLargo))

            'Mostrar vista previa de la venta
            Dim frmReport As New ReportForm
            frmReport.LocalReport.ReportEmbeddedResource = "Azteca.Windows.Ventas.CorteCajaRPT.rdlc"
            frmReport.LocalReport.DataSources.Add(New ReportDataSource("Corte", CType(dtCorte, DataTable)))
            frmReport.LocalReport.SetParameters(Parametros)
            frmReport.Show("Corte de caja")
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnDetalleCorte_Click(sender As System.Object, e As System.EventArgs) Handles btnDetalleCorte.Click
        Try
            showDetalle()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSalir_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class