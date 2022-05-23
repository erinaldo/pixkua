Imports Azteca.Windows.Controls
Imports System.Drawing

Public Class AlmacenesForm
    Private NewNodeIndex As Integer
    Private HierarchyFacade As UbicacionFacade
    Private NodesTable As HierarchyDS.HierarchyDataTable
    Private drNodeSelected As HierarchyDS.HierarchyRow
    Private ModoEdicion As modoEdicionNode = modoEdicionNode.No
    Private DragBoxFromMouseDown As Rectangle
    Private MovingNode As HierarchyNode
    Private OldNode As TreeNode

#Region "Implementacion de la forma"

    Private Sub AlmacenesForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        Dim info As AlmacenInfo = CType(Me.PackageInfo, AlmacenInfo)
        With info
            .UbicacionesNodesTable = NodesTable
        End With
    End Sub

    Private Sub AlmacenesForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As AlmacenInfo = CType(Me.PackageInfo, AlmacenInfo)
        With info
            cboArea.SelectedValue = .IdArea
            txtNombre.Text = .Nombre
            If .IdCuenta > 0 Then txtCuenta.LoadInfo(.IdCuenta)
            chkPermiteNeg.Checked = .PermiteNegativos
            chkReqCapturaFisico.Checked = .RequiereCapturaFisico

            HierarchyFacade = New UbicacionFacade
            .UbicacionesNodesTable = NodesTable
            LoadRootNodes()
        End With
    End Sub

    Private Sub AlmacenesForm_LoadingLists(sender As Object, e As System.EventArgs) Handles Me.LoadingLists
        cboArea.LoadList(App.DefaultSite.Identity, -1)
        cboImpresora.LoadList(App.DefaultSite.Identity)
        cboUbicacionTipo.LoadList()
    End Sub

    Private Sub AlmacenesForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As AlmacenInfo = CType(Me.PackageInfo, AlmacenInfo)
        With info
            .Nombre = txtNombre.Text
            .IdArea = CInt(cboArea.SelectedValue)
            .IdCuenta = txtCuenta.Key
            .PermiteNegativos = chkPermiteNeg.Checked
            .RequiereCapturaFisico = chkReqCapturaFisico.Checked
            .IdSucursal = App.DefaultSite.Identity
            .IdEmpresa = App.DefaultCompany.Identity
            .UbicacionesNodesTable = NodesTable
        End With
    End Sub

    'Private Sub btnNuevoNodo_Click(sender As System.Object, e As System.EventArgs)
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    Try
    '        NuevoNodo()
    '    Catch ex As Exception
    '        MsgInfo.Show(ex)
    '    Finally
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '    End Try
    'End Sub



#End Region

#Region "Implementacion de Botones y menú para jerarquía"
    Private Sub cmdAplicar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAplicar.Click
        If txtNombreUbicacion.Text.Length = 0 Then
            MessageBox.Show("Debe capturar el nombre de la ubicación", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If IsNothing(cboUbicacionTipo.SelectedValue) Then
            MessageBox.Show("Debe capturar un Tipo de Ubicación", "Requerido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        'Determinar el nivel donde se creará el nuevo nodo
        Dim IdPadre As Integer = 0
        Dim nodeSel As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)
        If nodeSel IsNot Nothing Then IdPadre = nodeSel.Identity

        drNodeSelected.Nombre = txtNombreUbicacion.Text
        drNodeSelected("IdImpresora") = CInt(cboImpresora.SelectedValue)
        drNodeSelected("IdCuenta") = CInt(selCuenta.Key)
        drNodeSelected("IdUbicacionTipo") = CInt(cboUbicacionTipo.SelectedValue)

        If ModoEdicion = modoEdicionNode.EditandoNuevo Then
            'agregar en la tabla
            NodesTable.AddHierarchyRow(drNodeSelected)
            'agregar en el control de arbol
            addTreeNode(nodeSel, drNodeSelected)
        ElseIf ModoEdicion = modoEdicionNode.EditandoExistente Then
            'Modificar el nodo seleccionado y modificarlo
            nodeSel.Text = drNodeSelected.Nombre
            nodeSel.Tag = drNodeSelected
        End If

        edicionNodos(modoEdicionNode.No)
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdCancelar.Click
        edicionNodos(modoEdicionNode.No)
    End Sub
    Private Sub mnuNuevoNodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuevoNodo.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            NuevoNodo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub mnuEliminarNodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEliminarNodo.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim selectedNode As TreeNode = tvwHierarchy.SelectedNode
            If CType(selectedNode.Tag, HierarchyDS.HierarchyRow).IdPadre = 0 Then
                MessageBox.Show("El nodo Raíz no puede ser eliminado", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If

            If selectedNode IsNot Nothing Then
                Dim row As HierarchyDS.HierarchyRow = NodesTable.FindByIdentity(CType(selectedNode.Tag, HierarchyDS.HierarchyRow).Identity)
                If Not IsNothing(row) Then
                    If CInt(row("IdUbicacion")) > 0 Then
                        row.Delete() 'Si ya esta en la base de datos, lo marcamos pa q lo borre
                    Else
                        NodesTable.Rows.Remove(row) ' no esta en la base de datos, simplemente lo removemos
                    End If
                End If
                'Lo quitamos del control
                tvwHierarchy.Nodes.Remove(selectedNode)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub mnuActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActualizar.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            LoadRootNodes()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub mnuSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSubir.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            SubirNodo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub mnuBajar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBajar.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            BajarNodo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub mnuExpandir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExpandir.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim CurrentNode As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)
            If CurrentNode IsNot Nothing Then LoadNodeChilds(CurrentNode)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdAgregar.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            NuevoNodo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdEditar.Click
        Dim selectedNode As TreeNode = tvwHierarchy.SelectedNode
        If IsNothing(selectedNode.Tag) Then
            MessageBox.Show("El nodo Raíz no puede ser editado", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        edicionNodos(modoEdicionNode.EditandoExistente)
    End Sub

    Private Sub cmdSubir_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdSubir.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            SubirNodo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cmdBajar_Click(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdBajar.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            BajarNodo()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub cmdActualizar_Click1(sender As Object, e As C1.Win.C1Command.ClickEventArgs) Handles cmdActualizar.Click
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            LoadRootNodes()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

#End Region

#Region "Metodos Privados Manejo de Nodos"
    Private Sub addTreeNode(parentNode As HierarchyNode, drNode As HierarchyDS.HierarchyRow)
        If IsNothing(parentNode) Then
            Dim node As New HierarchyNode(CStr(drNode("Nombre")), CInt(drNode("Identity")))
            node.Orden = CInt(drNode("Orden"))
            node.IdParent = CInt(drNode("IdPadre"))
            node.Tag = drNode
            tvwHierarchy.Nodes.Add(node)
        Else
            Dim node As New HierarchyNode(CStr(drNode("Nombre")), CInt(drNode("Identity")))
            node.Orden = CInt(drNode("Orden"))
            node.IdParent = CInt(drNode("IdPadre"))
            node.Tag = drNode
            parentNode.Nodes.Add(node)
            parentNode.Expand()
        End If
    End Sub

    Private Sub addNodeRow(drNode As HierarchyDS.HierarchyRow)
        Dim IdPadre As Integer = 0

        If IsNothing(tvwHierarchy.SelectedNode) Then
            MessageBox.Show("Todas las ubicaciones deben desprenderse del nodo Raiz[Almacén]. Seleccionelo para poder agregar elementos debajo de él.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        edicionNodos(modoEdicionNode.EditandoNuevo)

        Dim nodeSel As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)

        If IsNothing(drNode) Then
            'Incrementar contador de nodos nuevos
            NewNodeIndex += 1

            'Agregar al dataset de Ubicaciones
            drNodeSelected = NodesTable.NewHierarchyRow
            With drNodeSelected
                .Codigo = ""
                .Nombre = "Nuevo Nodo " & NewNodeIndex.ToString
                .Orden = nodeSel.Nodes.Count + 1
                .IdPadre = IdPadre
                .Nivel = 0
                .Path = ""
                .IsLeaf = False
                drNodeSelected("IdImpresora") = 0
                drNodeSelected("IdImpresora") = 0
                drNodeSelected("IdCuenta") = 0
                drNodeSelected("IdUbicacion") = 0
                drNodeSelected("IdUbicacionTipo") = 0
                drNodeSelected("IdentityPadre") = 0
                If Not IsNothing(nodeSel) And Not IsNothing(nodeSel.Tag) Then
                    If CType(nodeSel.Tag, HierarchyDS.HierarchyRow)("IdUbicacion") = 0 Then
                        drNodeSelected("IdentityPadre") = nodeSel.Identity
                    Else
                        drNodeSelected("IdPadre") = CType(nodeSel.Tag, HierarchyDS.HierarchyRow)("IdUbicacion")
                    End If
                End If
                txtNombreUbicacion.Text = .Nombre
                cboImpresora.SelectedValue = 0
            End With
        Else
            NodesTable.AddHierarchyRow(drNode)
        End If

    End Sub

    Protected Overridable Sub LoadRootNodes()
        tvwHierarchy.Nodes.Clear()
       
        'Cargar lista de nodos 
        NodesTable = New HierarchyDS.HierarchyDataTable
        NodesTable.Columns("Identity").AllowDBNull = False
        NodesTable = HierarchyFacade.LoadChildsFirst(App.Session.SessionID, App.DefaultCompany.Identity, 0, PackageInfo.Identity)
        NodesTable.Columns("Identity").AutoIncrement = True
        NodesTable.Columns("Identity").AutoIncrementSeed = 1
        If NodesTable.Rows.Count > 0 Then NodesTable.Columns("Identity").AutoIncrementSeed = CInt(NodesTable(0)("IdUltimo"))
        NodesTable.Columns("Identity").AutoIncrementStep = 1

        'Si no hay nodo, agregamos el Raiz
        If NodesTable.Rows.Count = 0 Then
            Dim dr As HierarchyDS.HierarchyRow = NodesTable.AddHierarchyRow(-1, "", "Almacen", 0, 1, 1, "", True)
            dr("IdUbicacion") = 0 : dr("IdImpresora") = 0 : dr("Idcuenta") = 0 : dr("IdUbicacionTipo") = 0 : dr("IdentityPadre") = 0
            drNodeSelected = dr
            'Agregamos un nodo en Raiz
            addTreeNode(Nothing, dr)
        Else
            Dim vwNodes As New DataView(NodesTable, String.Empty, "Orden, Nombre", DataViewRowState.CurrentRows)
            For Each drNode As DataRowView In vwNodes
                Dim node As New HierarchyNode(CStr(drNode("Nombre")), CInt(drNode("Identity")))
                node.Orden = CInt(drNode("Orden"))
                node.IdParent = CInt(drNode("IdPadre"))
                node.Tag = CType(drNode.Row, HierarchyDS.HierarchyRow)
                tvwHierarchy.Nodes.Add(node)
            Next
        End If

    End Sub

    Protected Overridable Sub LoadNodeChilds(ByVal parentNode As HierarchyNode)
        'Dim childNodes As HierarchyDS.HierarchyDataTable
        'Verificar si el nodo es nothing, en tal caso se trata de nodos del nivel superior
        If parentNode Is Nothing Then
            LoadRootNodes()
        Else
            Dim Id As Integer = CInt(CType(parentNode.Tag, HierarchyDS.HierarchyRow)("IdUbicacion"))
            If Id > 0 Then HierarchyFacade.LoadChildsFill(App.Session.SessionID, App.DefaultCompany.Identity, Id, NodesTable)
            Dim vwNodes As DataView
            'Si es uno recien ingresado
            If CInt(CType(parentNode.Tag, HierarchyDS.HierarchyRow)("IdUbicacion")) = 0 Then
                vwNodes = New DataView(NodesTable, "Identity>0 AND IdentityPadre=" & CStr(CType(parentNode.Tag, HierarchyDS.HierarchyRow)("Identity")), "Orden, Nombre", DataViewRowState.CurrentRows)
            Else
                vwNodes = New DataView(NodesTable, "IdPadre=" & CStr(CType(parentNode.Tag, HierarchyDS.HierarchyRow)("IdUbicacion")), "Orden, Nombre", DataViewRowState.CurrentRows)
            End If
            'Dim vwNodes As New DataView(NodesTable, "(IdUbicacion<>0 AND       IdPadre=" & CStr(CType(parentNode.Tag, HierarchyDS.HierarchyRow)("IdUbicacion")) & ") OR " & _
            '                                        "(IdUbicacion =0 AND IdentityPadre=" & CStr(CType(parentNode.Tag, HierarchyDS.HierarchyRow)("Identity")) & ")", _
            '                                        "Orden, Nombre", DataViewRowState.CurrentRows)
            parentNode.Nodes.Clear()
            For Each drNode As DataRowView In vwNodes
                addTreeNode(parentNode, CType(drNode.Row, HierarchyDS.HierarchyRow))
            Next

            If parentNode.Nodes.Count > 0 Then parentNode.Expand()
        End If
    End Sub

    Private Sub loadSelectedNode()
        If (tvwHierarchy.SelectedNode Is Nothing) Then Exit Sub

        Dim CurrentNode As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)
        drNodeSelected = CType(CurrentNode.Tag, HierarchyDS.HierarchyRow)

        If Not IsNothing(drNodeSelected) Then
            txtNombreUbicacion.Text = drNodeSelected.Nombre
            cboImpresora.SelectedValue = CInt(drNodeSelected("IdImpresora"))
            If CInt(drNodeSelected("IdCuenta")) > 0 Then selCuenta.LoadInfo(CInt(drNodeSelected("IdCuenta")))
            cboUbicacionTipo.SelectedValue = CInt(drNodeSelected("IdUbicacionTipo"))
            txtPath.Text = drNodeSelected.Path
            txtNivel.Text = CStr(drNodeSelected.Nivel)
        End If

    End Sub

    'Private Function FindNode(ByVal Identity As Integer, ByVal nodes As TreeNodeCollection) As HierarchyNode
    '    Dim FoundNodes As TreeNode() = nodes.Find(Identity.ToString, True)
    '    Dim FoundNode As HierarchyNode = Nothing
    '    If FoundNodes.Length > 0 Then
    '        FoundNode = CType(FoundNodes(0), HierarchyNode)
    '    End If
    '    Return FoundNode
    'End Function

    Private Function FindNode(ByVal x As Integer, ByVal y As Integer) As HierarchyNode
        If tvwHierarchy.Nodes.Count > 0 Then
            Dim node As HierarchyNode = CType(tvwHierarchy.Nodes(0), HierarchyNode)
            Dim pt As New Point(x, y)
            pt = tvwHierarchy.PointToClient(pt)
            While node IsNot Nothing
                If node.Bounds.Contains(pt) Then
                    Return node
                End If
                node = CType(node.NextVisibleNode, HierarchyNode)
            End While
        End If
        Return Nothing
    End Function

    'Private Sub SelectNode(ByVal Identity As Integer, ByVal nodes As TreeNodeCollection)
    '    For Each node As TreeNode In nodes
    '        Dim hNode As HierarchyNode = CType(node, HierarchyNode)
    '        If hNode.Identity = Identity Then
    '            tvwHierarchy.SelectedNode = hNode
    '            Return
    '        End If
    '    Next
    'End Sub

    Private Sub NuevoNodo()
        addNodeRow(Nothing)
    End Sub

    Private Sub SubirNodo()
        Dim CurrentNode As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)
        Dim ParentNode As HierarchyNode = CType(CurrentNode.Parent, HierarchyNode)
        If CurrentNode IsNot Nothing AndAlso CurrentNode.PrevNode IsNot Nothing Then
            Dim DestNode As HierarchyNode = CType(CurrentNode.PrevNode, HierarchyNode)
            'Mover el nodo actual a su nueva posición
            HierarchyFacade.MoveNode(App.Session.SessionID, CurrentNode.Identity, DestNode.IdParent, DestNode.Orden)
            tvwHierarchy.Nodes.Remove(CurrentNode)
            If ParentNode Is Nothing Then
                tvwHierarchy.Nodes.Insert(DestNode.Index, CurrentNode)
            Else
                ParentNode.Nodes.Insert(DestNode.Index, CurrentNode)
            End If
            tvwHierarchy.SelectedNode = CurrentNode
        End If
    End Sub

    Private Sub BajarNodo()
        Dim CurrentNode As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)
        Dim ParentNode As HierarchyNode = CType(CurrentNode.Parent, HierarchyNode)
        If CurrentNode IsNot Nothing AndAlso CurrentNode.NextNode IsNot Nothing Then
            Dim DestNode As HierarchyNode = CType(CurrentNode.NextNode, HierarchyNode)
            'Mover el nodo actual a su nueva posición
            HierarchyFacade.MoveNode(App.Session.SessionID, CurrentNode.Identity, DestNode.IdParent, DestNode.Orden)
            tvwHierarchy.Nodes.Remove(CurrentNode)
            If ParentNode Is Nothing Then
                tvwHierarchy.Nodes.Insert(DestNode.Index + 1, CurrentNode)
            Else
                ParentNode.Nodes.Insert(DestNode.Index + 1, CurrentNode)
            End If
            tvwHierarchy.SelectedNode = CurrentNode
        End If
    End Sub

    Private Sub ValidateMenu(ByVal location As Point)
        Dim nodeSel As TreeNode = tvwHierarchy.GetNodeAt(location)
        mnuExpandir.Enabled = (nodeSel IsNot Nothing)
        mnuEliminarNodo.Enabled = (nodeSel IsNot Nothing)
        mnuSubir.Enabled = (nodeSel IsNot Nothing)
        mnuBajar.Enabled = (nodeSel IsNot Nothing)
    End Sub


    Private Sub edicionNodos(modo As modoEdicionNode)
        If modo = modoEdicionNode.EditandoNuevo Then
            split.Panel1.Enabled = False
            split.Panel2.Enabled = True
        ElseIf modo = modoEdicionNode.EditandoExistente Then
            split.Panel1.Enabled = False
            split.Panel2.Enabled = True
        ElseIf modo = modoEdicionNode.No Then
            split.Panel1.Enabled = True
            split.Panel2.Enabled = False
        End If
        ModoEdicion = modo
    End Sub

#End Region

#Region "Implementacion Eventos Arbol de Jerarquía"

    Private Sub tvwHierarchy_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwHierarchy.AfterSelect
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            If IsNothing(tvwHierarchy.SelectedNode.Tag) Then Exit Sub

            'Verificar que un nodo esté seleccionado
            If (Not tvwHierarchy.SelectedNode Is Nothing) Then
                Dim nodeSel As HierarchyNode = CType(tvwHierarchy.SelectedNode, HierarchyNode)
                'Cargar información del nodo seleccionado
                loadSelectedNode()
                'Si el nodo ya fue cargado, entonces abortar operación
                If Not nodeSel.Loaded Then
                    'Obtener nodos hijo del nodo seleccionado
                    LoadNodeChilds(nodeSel)
                    'Marcar nodo para que no sea cargado de nuevo
                    nodeSel.Loaded = True
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub tvwHierarchy_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvwHierarchy.DragDrop
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim Pt As Point = tvwHierarchy.PointToClient(New Point(e.X, e.Y))
            Dim DestNode As HierarchyNode = CType(tvwHierarchy.GetNodeAt(Pt), HierarchyNode)
            If DestNode IsNot Nothing And MovingNode IsNot Nothing AndAlso DestNode.Identity <> MovingNode.Identity Then
                HierarchyFacade.MoveNode(App.Session.SessionID, MovingNode.Identity, DestNode.Identity, 0)
                tvwHierarchy.Nodes.Remove(MovingNode)
                DestNode.Nodes.Insert(0, MovingNode)
            ElseIf DestNode Is Nothing Then
                HierarchyFacade.MoveNode(App.Session.SessionID, MovingNode.Identity, 0, 0)
                tvwHierarchy.Nodes.Remove(MovingNode)
                tvwHierarchy.Nodes.Insert(0, MovingNode)
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub tvwHierarchy_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles tvwHierarchy.DragOver
        Try
            If Not (e.Data.GetDataPresent(GetType(HierarchyNode))) Then
                e.Effect = DragDropEffects.None
                Return
            Else
                e.Effect = DragDropEffects.Move
                'Obtener el nodo en las coordenadas y mostrarlo como seleccionado
                Dim node As TreeNode = FindNode(e.X, e.Y)
                If node IsNot Nothing Then
                    node.BackColor = Color.DarkBlue
                    node.ForeColor = Color.White
                    If OldNode IsNot Nothing AndAlso OldNode IsNot node Then
                        OldNode.BackColor = SystemColors.Window
                        OldNode.ForeColor = SystemColors.ControlText
                    End If
                    OldNode = node
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub tvwHierarchy_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwHierarchy.MouseDown
        Try
            Dim nodeSel As TreeNode = tvwHierarchy.GetNodeAt(e.Location)
            tvwHierarchy.SelectedNode = nodeSel
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                Dim dragSize As Size = SystemInformation.DragSize
                ' Create a rectangle using the DragSize, with the mouse position being
                ' at the center of the rectangle.
                DragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width \ 2), e.Y - (dragSize.Height \ 2)), dragSize)
            End If
            ValidateMenu(e.Location)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub tvwHierarchy_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwHierarchy.MouseMove
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                ' Proceed with the drag-and-drop, passing in the list item.
                If (Rectangle.op_Inequality(DragBoxFromMouseDown, Rectangle.Empty) And Not DragBoxFromMouseDown.Contains(e.X, e.Y)) Then
                    MovingNode = CType(tvwHierarchy.GetNodeAt(e.Location), HierarchyNode)
                    If MovingNode IsNot Nothing Then
                        Dim dropEffect As DragDropEffects = Me.DoDragDrop(MovingNode, DragDropEffects.Move)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub tvwHierarchy_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvwHierarchy.MouseUp
        Try
            DragBoxFromMouseDown = Rectangle.Empty
            MovingNode = Nothing
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

    
    Private Sub AlmacenesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        MessageBox.Show("132 = " & Chr(Integer.Parse(txtNombre.Text)), "info", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class

Public Enum modoEdicionNode
    EditandoNuevo = 1
    EditandoExistente = 2
    No = 3
End Enum