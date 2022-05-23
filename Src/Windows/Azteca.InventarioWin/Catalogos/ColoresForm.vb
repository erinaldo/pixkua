Public Class ColoresForm
    Private Color As String = ""

    Private Sub cmdColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColor.Click
        If dlgColor.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Color = dlgColor.Color.ToArgb.ToString
            lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(Color)
        End If
    End Sub

    Private Sub ColoresForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As ColorInfo = CType(Me.PackageInfo, ColorInfo)
        With info
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)
            txtReferencia.Text = .Referencia
            If Val(.CodigoColor) <> 0 Then
                lblColorBOX.BackColor = System.Drawing.ColorTranslator.FromHtml(.CodigoColor)
            Else
                lblColorBOX.BackColor = Drawing.Color.Transparent
            End If
        End With

    End Sub

    Private Sub ColoresForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As ColorInfo = CType(Me.PackageInfo, ColorInfo)
        With info
            .Nombre = txtNombre.Text
            .IdCuenta = selCuenta.Key
            .Referencia = txtReferencia.Text
            .CodigoColor = Color
        End With
    End Sub

    Private Sub ColoresForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class