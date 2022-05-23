Imports Azteca.Business.Inventario

Public Class OrdenesTrabajoInsumosSelForm
    Public Property ArticuloRow As OrdenesTrabajoDS.InsumosRow
    Private _IdOrdenTrabajo As Integer

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idOrdenTrabajo As Integer, ByVal articulo As OrdenesTrabajoDS.InsumosRow) As DialogResult
        cboUnidadMedida.LoadList()
        ArticuloRow = articulo
        loadInsumo()
        _IdOrdenTrabajo = idOrdenTrabajo

        Return MyBase.ShowDialog(owner)
    End Function


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If isvalid() Then

            Dim OTFacade As New OrdenTrabajoFacade()

            With (_ArticuloRow)
                .IdArticuloStock = selArticuloStock.Key
                .NombreInsumo = selArticuloStock.TextInfo
                .Cantidad = CDec(txtCantDeseada.Text)
                .Costo = CDec(txtCosto.Text)
                .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
                .IdUnidadMedidaTipo = 0
                .UM = ""
                .Surtir = chkSurtir.Checked
                .MermaPorc = CDec(txtMerma.Text)

                If (rdbCantidad.Checked) Then
                    .TipoMerma = "C"
                Else
                    .TipoMerma = "P"
                End If
            End With

            OTFacade.SaveInsumoOT(App.Session.SessionID, _IdOrdenTrabajo, _ArticuloRow)

            Me.DialogResult = DialogResult.OK
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#Region "Metodos Privados"
    Private Function isvalid() As Boolean
        If selArticuloStock.Key = 0 Then
            MessageBox.Show("Debe seleccionar un articulo", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (txtCantDeseada.Text = "") Then
            MessageBox.Show("Favor de introducir una cantidad", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        If (txtCosto.Text = "") Then
            MessageBox.Show("Favor de introducir un costo mayor o igual a 0", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return True
    End Function

    Private Sub loadInsumo()
        If _ArticuloRow.IsNull("IdArticuloStock") Then Exit Sub
        cboUnidadMedida.FilterExpression = "IdUnidadMedidaTipo=" & CInt(_ArticuloRow.IdUnidadMedidaTipo).ToString()
        selArticuloStock.LoadInfo(_ArticuloRow.IdArticuloStock)
        cboUnidadMedida.SelectedValue = _ArticuloRow.IdUnidadMedida
        txtCantDeseada.Text = _ArticuloRow.Cantidad.ToString()
        chkSurtir.Checked = _ArticuloRow.Surtir
        txtMerma.Text = _ArticuloRow.MermaPorc.ToString()
        txtCosto.Text = _ArticuloRow.Costo.ToString()
        Call FormatCantidades(_ArticuloRow.IdUnidadMedidaTipo)
        If (_ArticuloRow.TipoMerma = "C") Then
            rdbCantidad.Checked = True
        Else
            rdbPorcentaje.Checked = True
        End If
        
    End Sub

#End Region

    Private Sub OrdenesTrabajoInsumosSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub selArticuloStock_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles selArticuloStock.InfoLoaded
        Try
            Dim asFac As New ArticuloStockFacade
            Dim asInfo As New ArticuloStockInfo(App.Session.SessionID)

            asInfo = asFac.GetDetail(App.Session.SessionID, selArticuloStock.Key)
            cboUnidadMedida.FilterExpression = "IdUnidadMedidaTipo=" & asInfo.IdTipoUnidadMedida.ToString()
            cboUnidadMedida.SelectedValue = asInfo.IdUnidadMedida
            txtCantDeseada.Text = "0"
            txtMerma.Text = "0"
            txtCosto.Text = asInfo.CostoMaterial.ToString()
            Call FormatCantidades(asInfo.IdTipoUnidadMedida)

            

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub FormatCantidades(ByVal idUnidadMedidaTipo As Integer)
        If (idUnidadMedidaTipo = 1) Then
            txtCantDeseada.DigitsType = Windows.Controls.DigitsType.Integers
            txtMerma.DigitsType = Windows.Controls.DigitsType.Integers
        Else
            txtCantDeseada.DigitsType = Windows.Controls.DigitsType.Decimals
            txtMerma.DigitsType = Windows.Controls.DigitsType.Decimals
        End If
    End Sub

    Private Sub rdbCantidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPorcentaje.CheckedChanged, rdbCantidad.CheckedChanged
        Try
            If (rdbCantidad.Checked) Then
                lblTituloMerma.Text = "Merma #"
            Else
                lblTituloMerma.Text = "Merma %"
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class