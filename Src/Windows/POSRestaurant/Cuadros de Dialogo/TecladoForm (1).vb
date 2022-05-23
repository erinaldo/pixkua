Public Class TecladoForm
    Private CapsLockSel As CapsLockEnum = CapsLockEnum.Upper

    Public Overloads Function showDialog(ByVal Titulo As String, ByVal Password As Boolean) As DialogResult
        If Password Then txtTexto.PasswordChar = "*"
        setEventoClick()
        Return MyBase.ShowDialog
    End Function

    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        txtTexto.Focus() : txtTexto.SelectionStart = txtTexto.Text.Length
        SendKeys.Send("{BACKSPACE}")
    End Sub

    Private Sub cmdSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSpace.Click
        txtTexto.Text = txtTexto.Text & " "
    End Sub

    Private Sub btnESC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnESC.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub setEventoClick()
        For Each cmd As Control In Me.Controls
            If TypeOf cmd Is Azteca.Windows.Controls.ButtonPlus Then
                If Not cmd.Tag Is Nothing Then
                    AddHandler cmd.Click, AddressOf EventoClick
                End If
            End If
        Next
    End Sub

    Public Sub EventoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click, cmd1.Click, cmd2.Click, cmd3.Click, cmd4.Click, cmd5.Click, cmd6.Click, cmd7.Click, cmd8.Click, cmd9.Click, cmdA.Click, cmdB.Click, cmdC.Click, cmdD.Click, cmdE.Click, cmdF.Click, cmdG.Click, cmdH.Click, cmdI.Click, cmdJ.Click, cmdK.Click, cmdL.Click, cmdM.Click, cmdN.Click, cmdO.Click, cmdP.Click, cmdQ.Click, cmdR.Click, cmdS.Click, cmdT.Click, cmdU.Click, cmdV.Click, cmdW.Click, cmdX.Click, cmdY.Click, cmdZ.Click
        Dim cmd As Azteca.Windows.Controls.ButtonPlus = CType(sender, Azteca.Windows.Controls.ButtonPlus)
        txtTexto.Text = txtTexto.Text & cmd.Text
    End Sub

    Private Sub btnCapLocks_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCapLocks.Click
        For Each cmd As Control In pnlAlfabeto.Controls
            If TypeOf cmd Is Azteca.Windows.Controls.ButtonPlus Then
                If Not cmd.Tag Is Nothing Then
                    If CapsLockSel = CapsLockEnum.Upper Then
                        cmd.Text = cmd.Text.ToLower
                    Else
                        cmd.Text = cmd.Text.ToUpper
                    End If
                End If
            End If
        Next

        If CapsLockSel = CapsLockEnum.Upper Then
            CapsLockSel = CapsLockEnum.Lower
        Else
            CapsLockSel = CapsLockEnum.Upper
        End If
    End Sub

    
   
End Class

Public Enum CapsLockEnum
    Upper
    Lower
End Enum