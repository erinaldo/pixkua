Imports Azteca.Windows.Forms.Security
Imports Azteca.Kernel.Security
Imports Azteca.Windows.Controls

Public Class AreasForm
    Private Almacenes As AreasDS.AlmacenesDataTable
    Private Turnos As AreasDS.TurnosDataTable

    Private Sub CargarAlmacenes(ByVal idArea As Integer)
        Dim AreaFac As AreaFacade = CType(Facade, AreaFacade)
        'Cargar almacenes que pertenecen al área
        Almacenes = AreaFac.LoadAlmacenes(App.Session.SessionID, idArea)
        bsAlmacenes.DataSource = Almacenes
        grdAlmacenes.Rebind(True)
    End Sub

    Private Sub CargarTurnos(ByVal idArea As Integer)
        Dim AreaFac As AreaFacade = CType(Facade, AreaFacade)
        Turnos = AreaFac.LoadTurnos(App.Session.SessionID, idArea)
        bsTurnos.DataSource = Turnos
        grdTurnos.Rebind(True)
    End Sub

    Private Sub AreasForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        Almacenes = New AreasDS.AlmacenesDataTable
        Turnos = New AreasDS.TurnosDataTable
        bsAlmacenes.DataSource = Almacenes
        bsTurnos.DataSource = Turnos
        grdAlmacenes.Rebind(True)
        grdTurnos.Rebind(True)
    End Sub

    Private Sub AreasForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AreasForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        With Area
            txtNombre.Text = .Nombre
            CargarAlmacenes(Area.Identity)
            CargarTurnos(Area.Identity)
        End With
    End Sub

    Private Sub AreasForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        With Area
            .Nombre = txtNombre.Text
        End With
    End Sub

    Private Sub btnNuevoAlmacen_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAddAlmacen.Click
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        If Area.Identity > 0 Then
            Try
                Dim frmEdit As New AlmacenesForm
                Dim alm As New AlmacenInfo(App.Session.SessionID)
                alm.IdArea = Area.Identity
                alm.Status = CatalogState.Active
                alm.IdSucursal = Area.IdSucursal : alm.IdEmpresa = Area.IdEmpresa
                If frmEdit.ShowDialog(Me, alm, "Agregar almacen") = System.Windows.Forms.DialogResult.OK Then
                    CargarAlmacenes(Area.Identity)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Else
            MessageBox.Show("Primero debe guardar los datos del área.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAccesosAlmacen_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdSeguridad.Click
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        If Area.Identity > 0 AndAlso bsAlmacenes.Current IsNot Nothing Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Try
                Dim drAlmacen As AreasDS.AlmacenesRow = CType(CType(bsAlmacenes.Current, DataRowView).Row, AreasDS.AlmacenesRow)
                Dim AlmacenFac As New AlmacenFacade
                Dim dtUsuarios As ObjectAccessDS.UsuariosDataTable = AlmacenFac.LoadAccesos(App.Session.SessionID, drAlmacen.IdAlmacen)
                Dim frmAccesos As New EditObjectAccessForm
                'Agregar columnas para el acceso de entradas y salidas
                Dim colEntrada As New C1.Win.C1TrueDBGrid.C1DataColumn()
                colEntrada.DataField = "Entrada"
                colEntrada.Caption = "Entrada"
                colEntrada.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                frmAccesos.UsersGrid.Columns.Add(colEntrada)
                Dim dcolEntrada As C1.Win.C1TrueDBGrid.C1DisplayColumn = frmAccesos.UsersGrid.Splits(0).DisplayColumns("Entrada")
                dcolEntrada.Width = 60
                dcolEntrada.Visible = True
                dcolEntrada.Locked = False
                dcolEntrada.Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
                '
                Dim colSalida As New C1.Win.C1TrueDBGrid.C1DataColumn()
                colSalida.DataField = "Salida"
                colSalida.Caption = "Salida"
                colSalida.ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
                frmAccesos.UsersGrid.Columns.Add(colSalida)
                Dim dcolSalida As C1.Win.C1TrueDBGrid.C1DisplayColumn = frmAccesos.UsersGrid.Splits(0).DisplayColumns("Salida")
                dcolSalida.Width = 60
                dcolSalida.Visible = True
                dcolSalida.Locked = False
                dcolSalida.Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If frmAccesos.ShowDialog(Me, dtUsuarios) = System.Windows.Forms.DialogResult.OK Then
                    AlmacenFac.SaveAccesos(App.Session.SessionID, drAlmacen.IdAlmacen, dtUsuarios)
                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End Try
        Else
            MessageBox.Show("Primero debe guardar los datos del área.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdAlmacenes_DeleteButtonClick(ByVal sender As Object, ByVal e As GridViewCatalogButtonEventArgs) Handles grdAlmacenes.DeleteButtonClick
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        If Area.Identity > 0 AndAlso bsAlmacenes.Current IsNot Nothing Then
            Dim Resp As DialogResult = MessageBox.Show("¿Esta se guro que desea eliminar el almacén seleccionado?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim drAlmacen As AreasDS.AlmacenesRow = CType(CType(bsAlmacenes.Current, DataRowView).Row, AreasDS.AlmacenesRow)
                    Dim AlmacenFac As New AlmacenFacade
                    AlmacenFac.Delete(App.Session.SessionID, drAlmacen.IdAlmacen)
                    CargarAlmacenes(Area.Identity)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        Else
            MessageBox.Show("Debe seleccionar el almacén a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdAlmacenes_EditButtonClick(ByVal sender As Object, ByVal e As GridViewCatalogButtonEventArgs) Handles grdAlmacenes.EditButtonClick
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        If Area.Identity > 0 AndAlso bsAlmacenes.Current IsNot Nothing Then
            'Try
            Dim drAlmacen As AreasDS.AlmacenesRow = CType(CType(bsAlmacenes.Current, DataRowView).Row, AreasDS.AlmacenesRow)
            Dim frmEdit As New AlmacenesForm
            If frmEdit.ShowDialog(Me, drAlmacen.IdAlmacen, "Editando almácen") = System.Windows.Forms.DialogResult.OK Then
                CargarAlmacenes(Area.Identity)
            End If
            'Catch ex As Exception
            'MsgInfo.Show(ex)
            'End Try
        Else
            MessageBox.Show("Primero debe guardar los datos del área y seleccionar el almacén a editar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregarTurno_Click(ByVal sender As System.Object, ByVal e As C1.Win.C1Command.ClickEventArgs) Handles cmdAddTurno.Click
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        If Area.Identity > 0 Then
            Try
                Dim TurnoFac As New TurnoFacade
                Dim AreaFac As New AreaFacade
                Dim Turnos As Azteca.Kernel.Search.IdentityList = MsgList.Show(TurnoFac, Nothing, True)
                For Each IdTurno As String In Turnos
                    AreaFac.AsignarTurno(App.Session.SessionID, Area.Identity, CInt(IdTurno), 1)
                    CargarTurnos(Area.Identity)
                Next
            Catch ex As Exception
                MsgInfo.Show(ex)
            End Try
        Else
            MessageBox.Show("Primero debe guardar los datos del área.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdTurnos_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdTurnos.DeleteButtonClick
        Dim Area As AreaInfo = CType(PackageInfo, AreaInfo)
        If Area.Identity > 0 AndAlso bsTurnos.Current IsNot Nothing Then
            Dim Resp As DialogResult = MessageBox.Show("¿Esta se guro que desea quitar el turno seleccionado?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resp = System.Windows.Forms.DialogResult.Yes Then
                Try
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    Dim drTurno As AreasDS.TurnosRow = CType(CType(bsTurnos.Current, DataRowView).Row, AreasDS.TurnosRow)
                    Dim AreaFac As New AreaFacade
                    AreaFac.QuitarTurno(App.Session.SessionID, Area.Identity, drTurno.IdTurno)
                    CargarTurnos(Area.Identity)
                Catch ex As Exception
                    MsgInfo.Show(ex)
                Finally
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                End Try
            End If
        Else
            MessageBox.Show("Debe seleccionar el turno a eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdAlmacenes_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles grdAlmacenes.FetchRowStyle
        Try
            Dim IdStatus As Integer = CInt(grdAlmacenes.Columns("IdStatus").CellValue(e.Row))
            If IdStatus = 0 Then e.CellStyle.BackColor = Drawing.Color.Moccasin            
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class