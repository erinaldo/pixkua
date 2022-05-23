Imports Azteca.Windows.Forms

Public Class ConfigRemoteConecctionForm

    Private Config As String

    Private Sub ConfigRemoteConecctionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Config = Registry.GetValue("Remoting", "Type", "LAN")
            lblConfig.Text = Config
            Select Case Config
                Case "LAN"
                    rdbLAN.Checked = True
                    lblConfig.ForeColor = Drawing.Color.Blue
                Case "WEB"
                    rdbWEB.Checked = True
                    lblConfig.ForeColor = Drawing.Color.Green
                Case "TEST"
                    rdbTest.Checked = True
                    lblConfig.ForeColor = Drawing.Color.Orange
            End Select

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Registry.SetValue("Remoting", "Type", Config)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rdbLAN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLAN.CheckedChanged
        Config = "LAN"
    End Sub

    Private Sub rdbWEB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbWEB.CheckedChanged
        Config = "WEB"
    End Sub

    Private Sub rdbTest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTest.CheckedChanged
        Config = "TEST"
    End Sub
End Class