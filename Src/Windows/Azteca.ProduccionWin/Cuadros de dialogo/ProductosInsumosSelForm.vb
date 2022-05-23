Public Class ProductosInsumosSelForm

    Public Property InsumoRow As ProductosDS.InsumosRow

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal insumo As ProductosDS.InsumosRow) As DialogResult
        _InsumoRow = insumo
        cboUnidadMedida.LoadList()
        loadInsumo()
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ProductosInsumosSelForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''cboUnidadMedida.LoadList()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If isValid Then
            With _InsumoRow
                .IdInsumo = selInsumos.Key
                .Insumo = selInsumos.TextInfo
                .Cantidad = CDec(txtCantidad.Text)
                .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
                .IdMetaAlmacen = 0
                .PorcMerma = upDownPorcMerca.Value
                .Opcional = chkOpcional.Checked
            End With

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#Region "Metodos Privados"
    Private Function isvalid() As Boolean
        If selInsumos.Key = 0 Then
            MessageBox.Show("Debe seleccionar un insumo", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If Val(txtCantidad.Text) = 0 Then
            MessageBox.Show("Debe capturar una cantidad", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        'Validar metaalmacen

        If CInt(cboUnidadMedida.SelectedValue) = 0 Then
            MessageBox.Show("Debe seleccionar una unidad de medida", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If


        Return True
    End Function
    Private Sub loadInsumo()
        If _InsumoRow.IsNull("IdInsumo") Then Exit Sub
        selInsumos.LoadInfo(_InsumoRow.IdInsumo)
        txtCantidad.Text = _InsumoRow.Cantidad.ToString
        cboUnidadMedida.SelectedValue = CInt(_InsumoRow.IdUnidadMedida)
        ''Metaalmacen
        upDownPorcMerca.Value = _InsumoRow.PorcMerma
        chkOpcional.Checked = _InsumoRow.Opcional
    End Sub
#End Region

End Class