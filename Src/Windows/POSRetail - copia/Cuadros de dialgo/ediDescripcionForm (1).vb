Public Class ediDescripcionForm

    Public ReadOnly Property Descripcion As String
        Get
            Return txtDescripcion.Text
        End Get
    End Property


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Public Overloads Function showdialog(ByVal Descripcion As String) As DialogResult
        txtDescripcion.Text = Descripcion
        Return MyBase.ShowDialog
    End Function

End Class