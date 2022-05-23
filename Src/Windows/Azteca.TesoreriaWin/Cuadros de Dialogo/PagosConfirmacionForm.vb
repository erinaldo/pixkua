Public Class PagosConfirmacionForm

    Public Overloads Function ShowDialog(ByVal owner As Form, PagosTable As PagosDS.PagosDataTable, ContrarecibosSelTable As PagosDS.ContrarecibosPorPagarDataTable, _
                                         bsChequeras As BindingSource, bsPagosTipo As BindingSource) As DialogResult

        dropChequera.DataSource = bsChequeras
        dropPagoTipo.DataSource = bsPagosTipo

        dropChequera.Rebind(True) : dropPagoTipo.Rebind(True)

        bsTitulo.DataSource = PagosTable
        bsDetalle.DataSource = ContrarecibosSelTable
        grdTitulo.Rebind(True)
        grdDetalle.Rebind(True)


        Dim Total As Object = CType(bsTitulo.DataSource, PagosDS.PagosDataTable).Compute("SUM(Total)", "")
        If Not IsNothing(Total) Then grdTitulo.Columns("Total").FooterText = Format(Total, "0.00")
        grdDetalle.Columns("Beneficiario").FooterText = "Monto Total a Pagar:"


        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub grdTitulo_BeforeOpen(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdTitulo.BeforeOpen
        bsDetalle.Filter = "IdAgrupador=" & grdTitulo.Columns("IdAgrupador").Text
        Dim Total As Object = CType(bsDetalle.DataSource, PagosDS.ContrarecibosPorPagarDataTable).Compute("SUM(Monto)", "IdAgrupador=" & grdTitulo.Columns("IdAgrupador").Text)
        If Not IsNothing(Total) Then grdDetalle.Columns("Total").FooterText = Format(Total, "0.00")
        grdDetalle.Columns("Beneficiario").FooterText = "Suma de Contra recibos:"
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCerrarCorte_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrarCorte.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub


End Class