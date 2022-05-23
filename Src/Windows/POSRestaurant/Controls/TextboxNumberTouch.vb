Public Class TextboxNumberTouch
    Public Event NumberChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    Public Property TextInfo As String
        Get
            Return txtCaptura.Text
        End Get
        Set(ByVal value As String)
            txtCaptura.Text = value
        End Set
    End Property

    Private Sub cmdAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccion.Click
        Dim frm As New TecladoNumerosForm
        frm.TopMost = True
        If frm.ShowDialog() = DialogResult.OK Then
            txtCaptura.Text = frm.TextInfo
            RaiseEvent NumberChanged(Me, EventArgs.Empty)
        End If
    End Sub

End Class
