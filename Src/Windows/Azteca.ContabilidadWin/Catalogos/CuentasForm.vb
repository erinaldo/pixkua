Public Class CuentasForm

    Private Sub CuentaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            NodesTree.ImageList = imlCuentas
            LoadCombos()
            Me.CodeTextBox.Mask = App.DefaultCompany.FormatoContable
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub CuentaForm_LoadingItem(ByVal sender As Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim CuentaInf As CuentaInfo = CType(PackageInfo, CuentaInfo)
        With CuentaInf
            txtNombre.Text = .Nombre
            cboTipo.SelectedValue = .IdCuentaTipo
            cboOrden.SelectedValue = .IdCuentaOrden
            If .IdFlujo > 0 Then
                selFlujo.LoadInfo(.IdFlujo)
            Else
                selFlujo.Text = String.Empty
            End If
            If .IdPadre > 0 Then
                selPadre.LoadInfo(.IdPadre)
            Else
                selPadre.Text = String.Empty
            End If
            txtPath.Text = .NamedPath
            txtNivel.Text = .Nivel.ToString
            chkActivo.Checked = (.Status = Azteca.Kernel.BusinessStructure.CatalogState.Active)
            txtNombre.Focus()
        End With
        txtNombre.Focus()
    End Sub

    Private Sub CuentaForm_SavingItem(ByVal sender As Object, ByVal e As Azteca.Windows.Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim CuentaInf As CuentaInfo = CType(PackageInfo, CuentaInfo)
        With CuentaInf
            .Nombre = txtNombre.Text
            .IdPadre = selPadre.Key
            .IdCuentaTipo = CInt(cboTipo.SelectedValue)
            .IdCuentaOrden = CInt(cboOrden.SelectedValue)
            .IdFlujo = selFlujo.Key
            If chkActivo.Checked Then
                .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active
            Else
                .Status = Azteca.Kernel.BusinessStructure.CatalogState.Inactive
            End If
        End With
    End Sub

    Private Sub LoadCombos()
        Dim CtaFac As New CuentaFacade
        Dim dt As DataTable = CtaFac.CuentasTipoCBO(App.Session.SessionID)
        cboTipo.DisplayMember = "Nombre" : cboTipo.ValueMember = "IdCuentaTipo" : cboTipo.DataSource = dt

        Dim dtOrden As DataTable = CtaFac.CuentasOrdenCBO(App.Session.SessionID)
        cboOrden.DisplayMember = "Nombre" : cboOrden.ValueMember = "Id" : cboOrden.DataSource = dtOrden

    End Sub

    'Private Sub selPadre_LoadingInfo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles selPadre.LoadingInfo
    '    Try
    '        Dim CtaFac As New CuentaFacade
    '        Dim Cta As CuentaInfo = CtaFac.GetDetail(App.Session.SessionID, CInt(selPadre.Text))
    '        selPadre.Text = Cta.UserCode
    '        selPadre.TextInfo = Cta.Nombre
    '        selPadre.Key = Cta.Identity
    '    Catch ex As Exception
    '        MsgInfo.Show(ex)
    '    End Try
    'End Sub

    Private Sub btnImportacion_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        Try
            Dim CtaFac As New CuentaFacade
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            CtaFac.Importar(App.Session.SessionID, App.DefaultCompany.Identity)
            System.Windows.Forms.Cursor.Current = Cursors.Default
            MessageBox.Show("Se ha realizado la importacion de las cuentas." & ControlChars.CrLf & "Refresque la informacion", "Importacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnImportacionFile_Click(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
        Try
            Dim CtaFac As New CuentaFacade
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Dim dtCuentas As CuentasDS.ImportacionDataTable = FileCuentasToTable()
            CtaFac.ImportarFile(App.Session.SessionID, dtCuentas, App.DefaultCompany.Identity)
            System.Windows.Forms.Cursor.Current = Cursors.Default
            MessageBox.Show("Se ha realizado la importacion de las cuentas." & ControlChars.CrLf & "Refresque la informacion", "Importacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Public Function FileCuentasToTable() As CuentasDS.ImportacionDataTable
        Dim CuentasTable As New CuentasDS.ImportacionDataTable
        Try
            Dim FileName As String = String.Empty

            If fileOpenDlg.ShowDialog = DialogResult.OK Then
                FileName = fileOpenDlg.FileName
                'Leer contenido del archivo
                Dim Reader As System.IO.TextReader = System.IO.File.OpenText(FileName)
                Dim Contenido As String = Reader.ReadToEnd
                Reader.Close()
                Reader.Dispose()

                Dim Lineas As New System.Collections.Generic.List(Of String)
                Lineas.AddRange(Contenido.Split(New Char() {Chr(10)}))
                Dim i As Integer = 0
                While i <= Lineas.Count - 1
                    'Obtener linea actual
                    Dim Linea As String = Lineas(i)
                    'Obtener el tipo de movimiento que indica la linea
                    If Linea.Length <= 0 Then
                        i += 1
                        Continue While
                    Else
                        If Linea.Substring(0, 2).Trim = "C" Then
                            Dim rowNew As CuentasDS.ImportacionRow = CuentasTable.NewImportacionRow
                            rowNew.Codigo = Linea.Substring(3, 30).TrimEnd
                            rowNew.Nombre = Linea.Substring(34, 50)
                            rowNew.Padre = Linea.Substring(136, 30)
                            rowNew.Tipo = Linea.Substring(167, 2)
                            rowNew.SegNeg = Linea.Substring(202, 1)
                            CuentasTable.AddImportacionRow(rowNew)
                        End If
                    End If

                    i += 1

                End While

            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return CuentasTable
    End Function

    Protected Overrides Sub LoadNodeChilds(parentNode As HierarchyNode)
        Dim childNodes As HierarchyDS.HierarchyDataTable
        'Verificar si el nodo es nothing, en tal caso se trata de nodos del nivel superior
        If parentNode Is Nothing Then
            LoadRootNodes()
        Else
            parentNode.Nodes.Clear()
            childNodes = HierarchyFacade.LoadChilds(App.Session.SessionID, App.DefaultCompany.Identity, parentNode.Identity)
            Dim vwNodes As New DataView(childNodes, String.Empty, "Orden, Nombre", DataViewRowState.CurrentRows)
            For Each drNode As DataRowView In vwNodes
                Dim node As New HierarchyNode(CStr(drNode("Nombre")), CInt(drNode("Identity")))
                node.Tag = drNode("IdFlujo")
                node.Orden = CInt(drNode("Orden"))
                node.IdParent = CInt(drNode("IdPadre"))
                If drNode("FlujosCount") > 0 Or node.Tag <> parentNode.Tag Then node.BackColor = Drawing.Color.LightGreen
                parentNode.Nodes.Add(node)
            Next
            If parentNode.Nodes.Count > 0 Then parentNode.Expand()
        End If
    End Sub

    Protected Overrides Sub LoadRootNodes()

        Me.NodesTree.Nodes.Clear()
        'Cargar lista de nodos raíz
        Dim Nodes As HierarchyDS.HierarchyDataTable = HierarchyFacade.LoadChilds(App.Session.SessionID, App.DefaultCompany.Identity, 0)
        Dim vwNodes As New DataView(Nodes, String.Empty, "Orden, Nombre", DataViewRowState.CurrentRows)
        For Each drNode As DataRowView In vwNodes
            Dim node As New HierarchyNode(CStr(drNode("Nombre")), CInt(drNode("Identity")))
            node.Tag = drNode("IdFlujo")
            If drNode("FlujosCount") > 0 Then node.BackColor = Drawing.Color.LightGreen
            node.Orden = CInt(drNode("Orden"))
            node.IdParent = CInt(drNode("IdPadre"))
            Me.NodesTree.Nodes.Add(node)
        Next
    End Sub

End Class