Public Class TecladoNumerosForm
    Public Property TextInfo As String
        Get
            Return txtTexto.Text
        End Get
        Set(ByVal value As String)
            txtTexto.Text = value
        End Set
    End Property

    Private Sub btnESC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnESC.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdNumber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd0.Click, cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click, cmdDot.Click
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        txtTexto.Text = txtTexto.Text & cmd.Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtTexto.Text = ""
    End Sub

End Class