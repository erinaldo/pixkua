Imports System.Windows.Forms
Public Class BapiCduDialog

    Public _Paquete As String
    Public _Entrega As String
    Public _OrdenTransporte As String
    Public _IDCaja As String
    Public _Material As String
    Public _Cantidad As Decimal


    Public Overloads Function ShowDialog(ByVal owner As Form) As DialogResult

       
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub BapiCduDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _Paquete = String.Empty
            _Entrega = String.Empty
            _OrdenTransporte = String.Empty

            Dim RegFac As New IncidenciaRegistroFacade
            bsDatosBapi.DataSource = RegFac.LoadDatosBapi(App.Session.SessionID, DateTime.Today, Date.Today)
            grdDatosBapi.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try


            If (grdDatosBapi.Columns("Paquete").Text <> String.Empty) Then
                _Paquete = grdDatosBapi.Columns("Paquete").Text
                _Entrega = grdDatosBapi.Columns("Entrega").Text
                _OrdenTransporte = grdDatosBapi.Columns("Orden de Transporte").Text
                _IDCaja = grdDatosBapi.Columns("IDCaja").Text
                _Material = grdDatosBapi.Columns("Material").Text
                _Cantidad = grdDatosBapi.Columns("Cantidad").Value

                DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Debe seleccionar una linea de la tabla", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

          
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdDatosBapi_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDatosBapi.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
End Class