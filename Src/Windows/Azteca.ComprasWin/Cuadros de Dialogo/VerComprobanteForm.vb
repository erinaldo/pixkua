Public Class VerComprobanteForm
    Private Comprobante As ComprobanteFiscalInfo
    Private Correcto As Boolean

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal comprobante As ComprobanteFiscalInfo, ByVal comprobanteCorrecto As Boolean) As DialogResult
        Me.Comprobante = comprobante
        Me.Correcto = comprobanteCorrecto
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub VerComprobanteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With Comprobante
                txtFactura.Text = .Serie & "-" & .Folio
                txtFecha.Text = .Fecha.ToString("dd/MM/yyyy HH:mm:ss")
                txtEmisor.Text = .Emisor.RFC & "-" & .Emisor.Nombre
                txtReceptor.Text = .Receptor.RFC & "-" & .Receptor.Nombre
                txtSubTotal.Text = .SubTotal.ToString("C")
                txtImpTras.Text = .Impuestos.TotalTraslados.ToString("C")
                txtImpRet.Text = .Impuestos.TotalRetenciones.ToString("C")
                txtDesc.Text = .Descuento.ToString("C")
                txtTotal.Text = .Total.ToString("C")
            End With
            bsConceptos.DataSource = Comprobante.Conceptos
            If Correcto Then
                lblEstatus.Text = "Comprobante Válido"
                lblEstatus.BackColor = Drawing.Color.LightGreen
            Else
                lblEstatus.Text = "Comprobante NO Válido"
                lblEstatus.BackColor = Drawing.Color.OrangeRed
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub
End Class