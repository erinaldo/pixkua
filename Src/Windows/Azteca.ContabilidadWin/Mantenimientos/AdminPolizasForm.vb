Public Class AdminPolizasForm
    Private segundos As Integer

    Private Sub InterfazForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''    LlenarListas()
        Dim PolFac As New PolizaPerfilFacade
        cboPolizaOrigen.DisplayMember = "Descripcion" : cboPolizaOrigen.ValueMember = "Id" : cboPolizaOrigen.DataSource = PolFac.getPolizasOrigenCBO(App.Session.SessionID)
        'dtpFecha.Value = App.Session.BussinesDate
    End Sub

    'Public Sub LlenarListas()
    '    Dim x As Integer = 0
    '    'Bodegas
    '    Dim SucursalesFac As New CI.Kernel.Security.SucursalFacade
    '    Dim dtBodegas As DataTable
    '    Dim drBodegas As DataRow
    '    dtBodegas = SucursalesFac.LoadList(App.Session.User.Identity).Tables(0)
    '    For Each drBodegas In dtBodegas.Rows
    '        lstBodegas.Items.Add(drBodegas("IdSucursal"))
    '        lstBodegas.Items(x).SubItems.Add(drBodegas("Nombre"))
    '        x = x + 1
    '    Next
    'End Sub

    'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    '    Me.Dispose()
    'End Sub

    'Private Sub btnInvertirBod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvertirBod.Click
    '    Dim x As Integer
    '    For x = 0 To lstBodegas.Items.Count - 1
    '        If lstBodegas.Items(x).Checked = True Then
    '            lstBodegas.Items(x).Checked = False
    '        Else
    '            lstBodegas.Items(x).Checked = True
    '        End If
    '    Next
    'End Sub

    'Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
    '    Dim IdSucursales As String = ""

    '    If txtRuta.Text.Trim.Length = 0 Then
    '        MessageBox.Show("seleccione la ruta destino donde se guardara el archivo de interfaz", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If

    '    Try
    '        btnGenerar.Enabled = False
    '        If lstBodegas.CheckedItems.Count > 0 Then
    '            For Each item As ListViewItem In lstBodegas.CheckedItems
    '                IdSucursales = IdSucursales & item.Text & ","
    '            Next
    '            IdSucursales = IdSucursales.Substring(0, IdSucursales.Length - 1)
    '            Dim PolVtas As New PolizaFacade
    '            'Dim dtPolizas As DataTable = PolVtas.InterfazContpaq(App.Session.SessionID, dtpFecha.Value, IdSucursales)
    '            'InterfazCompaq(txtRuta.Text, dtPolizas)

    '            MessageBox.Show("La interfaz se genero correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Else
    '            MessageBox.Show("No hay elementos seleccionados en la lista de bodegas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Interfaces de Caja")
    '    Finally
    '        btnGenerar.Enabled = True
    '        System.Windows.Forms.Cursor.Current = Cursors.Default
    '    End Try
    'End Sub

    'Private Sub btnRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuta.Click
    '    If BrowseFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '        Dim Destino As String = BrowseFile.SelectedPath
    '        If Strings.Right(Destino, 1) <> "\" Then
    '            txtRuta.Text = Destino & "\InterfazVentas" & Format(dtpFecha.Value, "yyyyMMdd") & ".txt"
    '        End If
    '    End If
    'End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            ActualizarLista()
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub


    Private Sub ActualizarLista()
        Dim PolizasFac As New PolizaFacade

        Dim dtOrdenes As DataTable = PolizasFac.HistoricoLST(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value, CInt(cboPolizaOrigen.SelectedValue))
        lvwPolizas.BeginUpdate()
        lvwPolizas.Items.Clear()
        Dim vwOrdenes As New DataView(dtOrdenes, "", "Fecha DESC, SUCURSAL", DataViewRowState.CurrentRows)
        For Each drOrden As DataRowView In vwOrdenes

            Dim Item As New ListViewItem(drOrden("IdPolizaTit").ToString, 2)
            Item.SubItems.Add(CDate(drOrden("Fecha")).ToShortDateString)
            Item.SubItems.Add(drOrden("Sucursal").ToString)
            Item.SubItems.Add(drOrden("Origen").ToString)
            Item.SubItems.Add(drOrden("Tipo").ToString)
            Item.SubItems.Add(CStr(drOrden("Status")))
            Item.SubItems.Add(CStr(drOrden("Mensaje")))
            Item.Tag = CType(drOrden.Row, DataRow)
            '            If CInt(drOrden("IdStatus")) = Context.Workflow.Close Then Item.BackColor = SystemColors.Info

            Dim IdStatus As Integer = CInt(drOrden("IdStatus"))
            Select Case IdStatus
                Case 3 ''Context.Workflow.Apply
                    Item.ImageIndex = 0
                Case 7 ''Context.Workflow.Por revisar
                    Item.ImageIndex = 1
            End Select
            lvwPolizas.Items.Add(Item)
        Next
        lvwPolizas.EndUpdate()
    End Sub

    Private Sub lvwPolizas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvwPolizas.MouseDoubleClick
        MostrarPoliza()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        MostrarPoliza()
    End Sub
    Private Sub MostrarPoliza()
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            If lvwPolizas.SelectedItems.Count > 0 Then
                Dim IdPolizatit As String = CStr(CType(lvwPolizas.SelectedItems(0).Tag, DataRow)("IdPolizaTit"))

                Dim frm As New PolizaEditForm
                frm.ShowDialog(IdPolizatit)
            End If
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = Cursors.Default
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub ActivarParaSubirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEncolar.Click
        Dim PolFac As New PolizaFacade
        If lvwPolizas.SelectedItems.Count > 0 Then
            Dim IdPolizatit As String = CStr(CType(lvwPolizas.SelectedItems(0).Tag, DataRow)("IdPolizaTit"))
            PolFac.ApplyWorkflow(App.Session.SessionID, IdPolizatit, 1, Date.Today)
            lvwPolizas.SelectedItems(0).ImageIndex = 2
        End If
    End Sub

    Private Sub EliminarEnPixcuaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarEnPixcuaToolStripMenuItem.Click
        Dim PolFac As New PolizaFacade
        If lvwPolizas.SelectedItems.Count > 0 Then
            If MessageBox.Show("Eliminar está póliza implica solo la eliminación de pixcua y no de contpaq." & ControlChars.CrLf & "¿Está seguro de realizar esta acción?", "Eliminar", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.OK Then
                Dim IdPolizatit As String = CStr(CType(lvwPolizas.SelectedItems(0).Tag, DataRow)("IdPolizaTit"))
                PolFac.Delete(App.Session.SessionID, IdPolizatit)
                lvwPolizas.SelectedItems(0).Remove()
            End If
        End If
    End Sub

    Private Sub mnuInterfazTexto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInterfazTexto.Click
        Dim Destino As String = ""
        If lvwPolizas.SelectedItems.Count = 0 Then
            MessageBox.Show("No ha seleccionado una Póliza para generar el archivo de interfáz", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Try
            Dim IdPolizatit As String = CStr(CType(lvwPolizas.SelectedItems(0).Tag, DataRow)("IdPolizaTit"))

            If BrowseFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Destino = BrowseFile.SelectedPath
                If Strings.Right(Destino, 1) <> "\" Then
                    Destino = Destino & "\Pol." & IdPolizatit & ".txt"
                    Dim PolFac As New PolizaFacade
                    Dim PolInfo As PolizaInfo = PolFac.GetDetail(App.Session.SessionID, IdPolizatit)

                    PolizaInfo.InterfazContpaq(Destino, PolInfo, "")
                    MessageBox.Show("Se ha generado el archivo de texto", "Generado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub tabServicios_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabServicios.Enter
        segundos = 15
        tmrRefresh.Start()
    End Sub

    Private Sub tabServicios_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabServicios.Leave
        segundos = 15
        tmrRefresh.Stop()
    End Sub

    Private Sub tmrRefresh_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick
        lblTimer.Text = "La información se actualizará en " & segundos.ToString & " segundos."
        segundos = segundos - 1
        If segundos = -1 Then
            Try
                tmrRefresh.Stop()
                fillListViewEmpresas()
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                segundos = 15
                tmrRefresh.Start()
            End Try
        End If
    End Sub

    Private Sub fillListViewEmpresas()
        Dim PolizasFac As New PolizaFacade

        Dim dtEmpresas As DataTable = PolizasFac.PendientesPorEmpresa(App.Session.SessionID, dtpFechaIni.Value, dtpFechaFin.Value)
        lvwEmpresas.BeginUpdate()
        lvwEmpresas.Items.Clear()
        Dim vwEmpresas As New DataView(dtEmpresas, "", "Nombre", DataViewRowState.CurrentRows)
        For Each drOrden As DataRowView In vwEmpresas

            Dim Item As New ListViewItem(drOrden("Nombre").ToString)
            Item.SubItems.Add(drOrden("BaseDatos").ToString)
            Item.SubItems.Add(drOrden("IdServicio").ToString)
            Item.SubItems.Add(drOrden("Pendientes").ToString)
            Item.Tag = CType(drOrden.Row, DataRow)
            lvwEmpresas.Items.Add(Item)
        Next
        lvwEmpresas.EndUpdate()
    End Sub

    
End Class