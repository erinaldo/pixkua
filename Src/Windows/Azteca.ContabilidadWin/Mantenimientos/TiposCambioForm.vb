Public Class TiposCambioForm
    Private DivisaFac As DivisaFacade
    Private IdDivisaBase As Integer

    Private Sub CargarTiposCambio()
        Dim dtDivisas As DataTable = DivisaFac.CargarTiposCambio(App.Session.SessionID, IdDivisaBase)
        bsTiposCambio.DataSource = dtDivisas
    End Sub

    Private Sub TiposCambioForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DivisaFac = New DivisaFacade
            Dim ConfigFac As New Azteca.Kernel.Configuration.ConfigurationFacade
            '
            Dim colEdit As New Azteca.Windows.Controls.ImageButtonColumn()
            colEdit.Image = My.Resources.Pencil_32
            grdTiposCambio.Columns.Insert(0, colEdit)
            'Cargar información de la divisa base
            IdDivisaBase = DivisaFac.GetDivisaBase(App.Session.SessionID)
            Dim DivisaBase As DivisaInfo = DivisaFac.GetDetail(App.Session.SessionID, IdDivisaBase, False)
            lblDivisaBase.Text = DivisaBase.Nombre
            'Cargar los tipos de cambio de la divisa base
            CargarTiposCambio()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdTiposCambio_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTiposCambio.CellClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        If bsTiposCambio.Current Is Nothing Then Return
        Try
            Dim drDivisa As DataRowView = CType(bsTiposCambio.Current, DataRowView)
            If e.ColumnIndex = 0 Then
                Dim frmActualizar As New ActualizarTipoCambioForm
                If frmActualizar.ShowDialog(Me, CInt(drDivisa("IdDivisa")), IdDivisaBase) = System.Windows.Forms.DialogResult.OK Then
                    CargarTiposCambio()
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub
End Class