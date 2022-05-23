Imports Azteca.Business.Inventario
Public Class AdminTallasColoresForm

    Private _Articulo As ArticuloInfo
    Private _regleta As RegletaInfo
    Private ColoresTable As ArticulosDS.ColoresDataTable
    Private PresentacionesTable As ArticulosDS.TallasColoresDataTable

    Public Overloads Function showDialog(Articulo As ArticuloInfo) As DialogResult
        _Articulo = Articulo
        'Cargamos los colores
        CargarColores()
        'Cargamos las tallas
        If _Articulo.IdRegleta > 0 Then chkRegleta.Checked = True : selRegleta.LoadInfo(_Articulo.IdRegleta)
        'Cargamos actuales presentaciones q pertenezcan al articulo
        Dim ArtFac As New ArticuloFacade
        PresentacionesTable = ArtFac.PresentacionesTallaColorList(App.Session.SessionID, _Articulo.Identity)
        'Cargamos la matriz 
        cargarGrid()

        Return MyBase.ShowDialog
    End Function

    Private Sub CargarPresentaciones()
        If IsNothing(PresentacionesTable) Then Exit Sub
        'Ágregamos al grid lo que ya existe
        For Each Color As C1.Win.C1FlexGrid.Row In _flex.Rows
            For Each Talla As C1.Win.C1FlexGrid.Column In _flex.Cols
                If Talla.Index > 0 And Color.Index > 0 Then
                    If Talla.Format = "" Then Talla.Format = "0"
                    If Color.Format = "" Then Color.Format = "0"
                    Dim dv As New DataView(PresentacionesTable, "IdTalla=" & Talla.Format & " AND IdColor=" & Color.Format, "", DataViewRowState.CurrentRows)
                    If dv.Count > 0 Then _flex.SetData(Color.Index, Talla.Index, dv(0)("Codigo"))
                End If
            Next
        Next
    End Sub

    Private Sub CargarColores()
        Dim ArtFac As New ArticuloFacade
        ColoresTable = ArtFac.ColoresList(App.Session.SessionID, _Articulo.Identity)

        lsvColores.Items.Clear()
        Dim dv As New DataView(ColoresTable, "", "Nombre", DataViewRowState.CurrentRows)
        For Each dr As DataRowView In dv
            Dim item As New ListViewItem(CStr(dr("Nombre")))
            If CBool(dr("Sel")) Then item.Checked = True
            item.Tag = CInt(dr("IdColor"))

            lsvColores.Items.Add(item)
        Next

    End Sub

    Private Sub cargarGrid()

        Dim cs As C1.Win.C1FlexGrid.CellStyle = _flex.Styles.Add("Built-In Editors")
        'cs.UserData = 
        '	@"\b ** Built-In Editors\b0\par " +
        '	@"These cells use the C1FlexGrid built-in editors, controlled by " +
        '	@"the setting of the DataType, DataMap, ComboList, and EditMask properties.";

        _flex.Rows.RemoveRange(1, _flex.Rows.Count - 1)
        _flex.Cols.RemoveRange(1, _flex.Cols.Count - 1)
        _flex.Rows(0).Editor = TextBox1

        If Not IsNothing(_regleta) Then
            For Each Talla As TallasDS.TallasRow In _regleta.TallasTable
                Dim c As C1.Win.C1FlexGrid.Column
                c = _flex.Cols.Add()
                c.Caption = Talla.Nombre
                c.ComboList = "..."
                c.Style.MergeWith(cs)
                c.Format = CStr(Talla.IdTalla)
            Next
        End If

        Dim dv As New DataView(ColoresTable, "Sel=true", "Nombre", DataViewRowState.CurrentRows)
        For Each dr As DataRowView In dv
            Dim r As C1.Win.C1FlexGrid.Row
            r = _flex.Rows.Add
            r.Editor = TextBox1
            r.Caption = CStr(dr("Nombre"))
            r.Format = CStr(dr("IdColor"))
        Next
        chkColores.Checked = dv.Count > 0

        'En caso de no especificar regleta, poner un item gral
        If IsNothing(_regleta) OrElse _regleta.TallasTable.Rows.Count = 0 Then
            Dim c As C1.Win.C1FlexGrid.Column
            c = _flex.Cols.Add()
            c.Caption = "Unica"
            c.ComboList = "..."
            c.Style.MergeWith(cs)
        End If

        'En caso de no especificar colores, poner un item gral
        If dv.Count = 0 Or Not chkColores.Checked Then
            Dim r As C1.Win.C1FlexGrid.Row
            r = _flex.Rows.Add()
            r.Editor = TextBox1
            r.Caption = "General"
            r.Format = "0"
            r.Style.MergeWith(cs)
        End If

        CargarPresentaciones()
    End Sub

    Private Sub selRegleta_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles selRegleta.InfoLoaded
        _regleta = CType(selRegleta.PackageInfo, RegletaInfo)
        _Articulo.IdRegleta = _regleta.Identity
        cargarGrid()
    End Sub

    Private Sub chkRegleta_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRegleta.CheckedChanged, chkColores.CheckedChanged
        lsvColores.Enabled = chkColores.Checked
        selRegleta.Enabled = chkRegleta.Checked
    End Sub

    Private Sub lsvColores_ItemChecked(sender As Object, e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsvColores.ItemChecked
        Dim idColor As Integer = CInt(e.Item.Tag)
        Dim dv As New DataView(ColoresTable, "IdColor=" & idColor, "", DataViewRowState.CurrentRows)
        If dv.Count > 0 Then dv(0)("Sel") = e.Item.Checked

        cargarGrid()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAceptar.Click
        Try
            Generar()
            MyBase.DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        MyBase.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Generar()
        Try

            Dim TallasColoresTable As New ArticulosDS.TallasColoresDataTable
            For Each Color As C1.Win.C1FlexGrid.Row In _flex.Rows
                If Color.Index > 0 Then
                    For Each Talla As C1.Win.C1FlexGrid.Column In _flex.Cols
                        If Talla.Index > 0 AndAlso Not IsNothing(_flex.GetData(Color.Index, Talla.Index)) AndAlso CStr(_flex.GetData(Color.Index, Talla.Index)).Trim.Length > 0 Then
                            TallasColoresTable.AddTallasColoresRow(CStr(_flex.GetData(Color.Index, Talla.Index)),
                                                                   CInt(Talla.Format), CStr(_flex.GetData(0, Talla.Index)),
                                                                   CInt(Color.Format), CStr(_flex.GetData(Color.Index, 0)))
                        End If
                    Next
                End If
            Next

            Dim ArtFac As New ArticuloFacade
            ArtFac.savePresentacionesTallaColor(App.Session.SessionID, _Articulo, TallasColoresTable, ColoresTable)
        Catch ex As Exception
            Throw New Exception("Error al generar las Presentaciones de Talla/Color", ex)
        End Try
    End Sub

  
End Class


Public Class TallaColor
    Public Property IdTalla As Integer
    Public Property IdColor As Integer
    Public Property Codigo As String
End Class