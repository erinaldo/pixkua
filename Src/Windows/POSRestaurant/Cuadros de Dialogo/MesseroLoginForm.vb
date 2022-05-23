Public Class MesseroLoginForm
    Private _Password As String
    Private CapsLockSel As CapsLockEnum = CapsLockEnum.Upper

    Public Overloads Function showDialog(ByVal Usuario As String, ByVal Password As String, ByVal Imagen As Byte()) As DialogResult
        lblUsuarioTXT.Text = Usuario
        _Password = Azteca.Kernel.Security.CryptManager.Decrypt(Password)
        txtContrasenia.Text = ""
        picMngrImage.SetImageBytes(Imagen)
        setEventoClick()
        Return MyBase.ShowDialog
    End Function

    Private Sub btnTeclado_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Terminado As Boolean = False

        While Not Terminado
            Dim frm As New TecladoForm
            Dim Result As DialogResult = frm.ShowDialog("Captura de password", True)

            'Dio Enter para confirmar el password
            If Result = System.Windows.Forms.DialogResult.OK Then
                If frm.txtTexto.Text = _Password Then
                    Terminado = True
                    MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
                Else
                    'El password fue incorrecto
                    MessageBox.Show("El Password no es correcto", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End If

            If Result = System.Windows.Forms.DialogResult.Cancel Then
                Terminado = True
                MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
            End If

        End While


    End Sub

    Private Sub btnReturn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturn.Click
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
        txtContrasenia.Text = txtContrasenia.Text & cmd.Text
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

    Private Sub cmdEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click
        If txtContrasenia.Text = _Password Then
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            'El password fue incorrecto
            MessageBox.Show("El Password no es correcto", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        txtContrasenia.Focus() : txtContrasenia.SelectionStart = txtContrasenia.Text.Length
        SendKeys.Send("{BACKSPACE}")
    End Sub

    Private Sub cmdSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSpace.Click
        txtContrasenia.Text = txtContrasenia.Text & " "
    End Sub


  
End Class