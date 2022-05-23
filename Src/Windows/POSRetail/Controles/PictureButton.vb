Public Class PictureButton

    Public Property Etiqueta As String
        Get
            Return lblEtiqueta.Text
        End Get
        Set(value As String)
            lblEtiqueta.Text = value
        End Set
    End Property

    Public Property Imagen As Image
        Get
            Return pic.Image
        End Get
        Set(value As Image)
            pic.Image = value
        End Set
    End Property

    'Private Sub pic_Click(sender As Object, e As System.EventArgs) Handles pic.Click
    '    OnClick(e)
    'End Sub

    Private Sub pic_DoubleClick(sender As Object, e As System.EventArgs) Handles pic.DoubleClick
        OnDoubleClick(e)
    End Sub

    Private Sub pic_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseDown
        Dim PanelPoint As System.Drawing.Point = Me.PointToClient(MousePosition)
        Dim x As Integer = PanelPoint.X
        Dim Y As Integer = PanelPoint.Y

        Dim ePoint As New System.Windows.Forms.MouseEventArgs(e.Button, e.Clicks, x, Y, e.Delta)
        OnMouseDown(ePoint)
    End Sub

    Private Sub pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseMove
        Dim PanelPoint As System.Drawing.Point = Me.PointToClient(MousePosition)
        Dim x As Integer = PanelPoint.X
        Dim Y As Integer = PanelPoint.Y

        Dim ePoint As New System.Windows.Forms.MouseEventArgs(e.Button, e.Clicks, x, Y, e.Delta)
        OnMouseMove(ePoint)
    End Sub

    Private Sub pic_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseUp
        Dim PanelPoint As System.Drawing.Point = Me.PointToClient(MousePosition)
        Dim x As Integer = PanelPoint.X
        Dim Y As Integer = PanelPoint.Y

        Dim ePoint As New System.Windows.Forms.MouseEventArgs(e.Button, e.Clicks, x, Y, e.Delta)
        OnMouseUp(ePoint)
    End Sub


    Private Sub lblEtiqueta_Click(sender As Object, e As System.EventArgs) Handles lblEtiqueta.Click
        OnClick(e)
    End Sub

    Private Sub lblEtiqueta_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblEtiqueta.MouseDown
        Dim PanelPoint As System.Drawing.Point = Me.PointToClient(MousePosition)
        Dim x As Integer = PanelPoint.X
        Dim Y As Integer = PanelPoint.Y

        Dim ePoint As New System.Windows.Forms.MouseEventArgs(e.Button, e.Clicks, x, Y, e.Delta)
        OnMouseDown(ePoint)
    End Sub

    Private Sub lblEtiqueta_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblEtiqueta.MouseMove
        Dim PanelPoint As System.Drawing.Point = Me.PointToClient(MousePosition)
        Dim x As Integer = PanelPoint.X
        Dim Y As Integer = PanelPoint.Y

        Dim ePoint As New System.Windows.Forms.MouseEventArgs(e.Button, e.Clicks, x, Y, e.Delta)
        OnMouseMove(ePoint)
    End Sub

    Private Sub lblEtiqueta_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblEtiqueta.MouseUp
        Dim PanelPoint As System.Drawing.Point = Me.PointToClient(MousePosition)
        Dim x As Integer = PanelPoint.X
        Dim Y As Integer = PanelPoint.Y

        Dim ePoint As New System.Windows.Forms.MouseEventArgs(e.Button, e.Clicks, x, Y, e.Delta)
        OnMouseUp(ePoint)
    End Sub
End Class
