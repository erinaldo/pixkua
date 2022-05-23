Public Class ProductosEnsamblesSelForm

    Public Property _EnsambleRow As ProductosDS.EnsabladosRow

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal Ensamble As ProductosDS.EnsabladosRow) As DialogResult
        _EnsambleRow = Ensamble
        cboUnidadMedida.LoadList()
        loadProducto()
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub ProductosInsumosSelForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''cboUnidadMedida.LoadList()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If isValid Then
            With _EnsambleRow
                .IdSubProducto = selProducto.Key
                .Producto = selProducto.TextInfo
                .Cantidad = CDec(txtCantidad.Text)
                .IdUnidadMedida = CInt(cboUnidadMedida.SelectedValue)
                .IdMetaAlmacen = 0
                .PorcMerma = upDownPorcMerca.Value
                .Opcional = chkOpcional.Checked
                .OrdenSeparada = chkOrdenSeparada.Checked
            End With

            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#Region "Metodos Privados"
    Private Function isvalid() As Boolean
        If selProducto.Key = 0 Then
            MessageBox.Show("Debe seleccionar un Producto", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Stop)
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
    Private Sub loadProducto()
        If _EnsambleRow.IsNull("IdSubProducto") Then Exit Sub
        selProducto.LoadInfo(_EnsambleRow.IdSubProducto)
        txtCantidad.Text = _EnsambleRow.Cantidad.ToString
        cboUnidadMedida.SelectedValue = CInt(_EnsambleRow.IdUnidadMedida)
        ''Metaalmacen
        upDownPorcMerca.Value = _EnsambleRow.PorcMerma
        chkOpcional.Checked = _EnsambleRow.Opcional
        chkOrdenSeparada.Checked = _EnsambleRow.OrdenSeparada
    End Sub
#End Region

End Class