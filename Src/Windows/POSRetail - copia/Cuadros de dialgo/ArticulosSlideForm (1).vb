Imports Azteca.Windows.Controls

Public Class ArticulosSlideForm
    Dim ButtonPresionado As Boolean = False
    Dim ButtonMoveX As Integer
    Dim ButtonMoveY As Integer
    Private _IdArticuloStock As Integer = 0

    Public ReadOnly Property IdArticuloStock As Integer
        Get
            Return _IdArticuloStock
        End Get
    End Property

    Public Overloads Function showdialog(IdEstCom As Integer) As DialogResult
        LoadArticulos(IdEstCom)
        Return MyBase.ShowDialog()
    End Function

    Private Sub LoadArticulos(IdEstCom As Integer)
        flowLytPnl.Controls.Clear()
        Dim ArtFac As New ArticuloFacade
        Dim ArticulosTable As DataTable = ArtFac.PresentacionesFotoList(App.Session.SessionID, IdEstCom)
        For Each dr As DataRow In ArticulosTable.Rows
            addArticulo(dr)
        Next
    End Sub

    Private Sub addArticulo(dr As DataRow)
        Dim pic As New PictureButton
        pic.Size = New Size(255, 237)
        pic.BorderStyle = BorderStyle.None
        If IsDBNull(dr("Foto")) Then

        Else
            Dim imageBuffer As Byte() = (CType(dr("Foto"), Byte()))
            If imageBuffer IsNot Nothing Then
                Dim ms As New MemoryStream(imageBuffer)
                pic.Imagen = Drawing.Image.FromStream(ms)
                ms.Close()
            End If
        End If
        pic.Etiqueta = CStr(dr("Nombre"))
        pic.Tag = dr("IdArticuloStock")

        AddHandler pic.MouseDown, AddressOf picBox_MouseDown
        AddHandler pic.MouseUp, AddressOf picBox_MouseUp
        AddHandler pic.MouseMove, AddressOf picBox_MouseMove
        AddHandler pic.MouseUp, AddressOf picBox_MouseUp
        AddHandler pic.DoubleClick, AddressOf picBox_DoubleClick

        flowLytPnl.Controls.Add(pic)
    End Sub

    Private Sub picBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        'flowLytPnl.ScrollControlIntoView(CType(sender, ButtonPlus))
        ButtonPresionado = True
        Dim PanelPoint = flowLytPnl.PointToClient(MousePosition)
        ButtonMoveX = PanelPoint.X
        ButtonMoveY = PanelPoint.Y
    End Sub

    Private Sub picBox_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        ButtonPresionado = False
        ButtonMoveX = 0
        ButtonMoveY = 0
    End Sub

    Private Sub picBox_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If ButtonPresionado Then
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Dim PanelPoint = flowLytPnl.PointToClient(MousePosition)
                If ButtonMoveX < PanelPoint.X Then
                    If flowLytPnl.HorizontalScroll.Value - 7 > 0 Then flowLytPnl.HorizontalScroll.Value -= 7
                Else
                    If flowLytPnl.HorizontalScroll.Value + 7 < flowLytPnl.HorizontalScroll.Maximum Then flowLytPnl.HorizontalScroll.Value += 7
                End If
            End If
        End If
    End Sub

    Private Sub picBox_DoubleClick(sender As Object, e As System.EventArgs)
        'If ButtonPresionado Then Exit Sub
        _IdArticuloStock = CInt(CType(sender, PictureButton).Tag)
        MyBase.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub flowLytPnl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles flowLytPnl.MouseDown
        ButtonPresionado = True
        ButtonMoveY = e.Y
        ButtonMoveX = e.X
    End Sub

    Private Sub flowLytPnl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles flowLytPnl.MouseMove
        If ButtonPresionado Then
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Dim PanelPoint = flowLytPnl.PointToClient(MousePosition)
                If ButtonMoveX < PanelPoint.X Then
                    If flowLytPnl.HorizontalScroll.Value - 7 > 0 Then flowLytPnl.HorizontalScroll.Value -= 7
                Else
                    If flowLytPnl.HorizontalScroll.Value + 7 < flowLytPnl.HorizontalScroll.Maximum Then flowLytPnl.HorizontalScroll.Value += 7
                End If
            End If
        End If
    End Sub

    Private Sub cmdSeleccionar_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub cmdCancelar_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCancelar.ClickButtonArea
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

   
End Class