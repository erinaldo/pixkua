Public Class EditArticuloPresZonaForm
    Private IdArticuloStock As Integer
    Private Codigo As String
    Private Descripcion As String
    Private Zonas As New ZonasVentaDS.ZonasDataTable

    Private Sub EditarZona()
        Dim drZona As ZonasVentaDS.ZonasRow = CType(CType(bsZonas.Current, DataRowView).Row, ZonasVentaDS.ZonasRow)
        Dim frmEditZona As New EditArticuloZonaForm
        If frmEditZona.ShowDialog(Me, IdArticuloStock, drZona) = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal idArticuloStock As Integer, ByVal Codigo As String, ByVal descripcion As String) As DialogResult
        Me.IdArticuloStock = idArticuloStock
        Me.Codigo = Codigo
        Me.Descripcion = descripcion
        Return MyBase.ShowDialog()
    End Function

    Private Sub EditArticuloPresZonaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lblCodigoDescr.Text = Codigo & " - " & Descripcion
            'Cargamos las zonas actuales q tiene configuradas el articulo
            Dim ArtPresFac As New PresentacionFacade
            Zonas = ArtPresFac.GetZonas(App.Session.SessionID, IdArticuloStock)
            bsZonas.DataSource = Zonas
            grdZonas.Rebind(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnAgregarZona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarZona.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim drZona As ZonasVentaDS.ZonasRow = Zonas.NewZonasRow
            Dim frmEditZona As New EditArticuloZonaForm
            If frmEditZona.ShowDialog(Me, IdArticuloStock, drZona) = System.Windows.Forms.DialogResult.OK Then
                If Zonas.FindByIdZonaVenta(drZona.IdZonaVenta) Is Nothing Then
                    Zonas.AddZonasRow(drZona)
                Else
                    MessageBox.Show("La zona de ventas que intenta agregar ya existe para éste Articulo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim ArtPresFac As New PresentacionFacade
            ArtPresFac.SaveZonas(App.Session.SessionID, IdArticuloStock, Zonas)
            MessageBox.Show("Las zonas de venta han sido actualizadas con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdZonas_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdZonas.DeleteButtonClick
        If bsZonas.Current IsNot Nothing Then
            Try
                Dim Result As DialogResult = MessageBox.Show("¿Esta seguro que desea quitar la zona de ventas seleccionada?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    bsZonas.RemoveCurrent()
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        End If
    End Sub

    Private Sub grdZonas_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdZonas.EditButtonClick
        If bsZonas.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                EditarZona()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub


End Class