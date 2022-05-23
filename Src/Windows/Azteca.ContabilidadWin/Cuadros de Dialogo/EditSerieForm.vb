Public Class EditSerieForm
    Private IdCertificado As Integer
    Private NombreCertificado As String
    Private SerieFac As New SerieFacade
    Private _SerieInf As SerieInfo

    Public ReadOnly Property SerieInf As SerieInfo
        Get
            Return _SerieInf
        End Get
    End Property

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idCertificado As Integer, ByVal nombreCertificado As String) As DialogResult
        Me.IdCertificado = idCertificado
        Me.NombreCertificado = nombreCertificado
        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub EditSerieForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SerieFac = New SerieFacade
            _SerieInf = New SerieInfo(App.Session.SessionID)
            txtCertificado.Text = NombreCertificado
            txtSerie.Focus()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            With SerieInf
                .UserCode = String.Empty
                .IdCertificado = IdCertificado
                .Serie = txtSerie.Text
                .IdSucursal = App.DefaultSite.Identity
                .Status = CatalogState.Active
                If .IdEmpresa = 0 Then .IdEmpresa = App.DefaultCompany.Identity
            End With
            SerieFac.Update(SerieInf)
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class