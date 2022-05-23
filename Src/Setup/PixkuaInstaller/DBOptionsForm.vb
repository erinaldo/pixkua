Imports System.IO
Imports System.Xml
Imports System.Data.SqlClient

Public Class DBOptionsForm
    Private InstallDirectory As String

    Public Overloads Function ShowDialog(ByVal installDirectory As String) As DialogResult
        Me.InstallDirectory = installDirectory
        Return MyBase.ShowDialog
    End Function

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub rdbContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbContinuar.Click
        If rdbConnect.Checked Then
            Dim frmConnection As New ConfigureConectionForm
            frmConnection.ShowDialog(InstallDirectory)
        Else
            Dim frmCreate As New CreateDBForm
            frmCreate.ShowDialog(InstallDirectory)
        End If
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class