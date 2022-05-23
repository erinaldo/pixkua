Public Class InsumosArticulosSelForm
    Public Property ArticuloRow As InsumosArticulosDS.InsumosArticulosRow


    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal articulo As InsumosArticulosDS.InsumosArticulosRow) As DialogResult
        ArticuloRow = articulo
        loadInsumo()
        Return MyBase.ShowDialog(owner)
    End Function


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If isValid Then
            With _ArticuloRow
                .IdArticuloStock = selArticuloStock.Key
                .ArticuloStock = selArticuloStock.TextInfo
                .Predeterminado = False
            End With

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

        Return True
    End Function
    Private Sub loadInsumo()
        If _ArticuloRow.IsNull("IdArticuloStock") Then Exit Sub
        selArticuloStock.LoadInfo(_ArticuloRow.IdArticuloStock)
    End Sub

#End Region

    Private Sub InsumosArticulosSelForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class