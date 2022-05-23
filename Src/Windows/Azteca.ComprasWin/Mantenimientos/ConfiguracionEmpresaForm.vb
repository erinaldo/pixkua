Public Class ConfiguracionEmpresaForm
    Private DeptoInfo As Azteca.Business.Compras.DepartamentoInfo

    Private Sub optCategorizado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gbxDeptosCategorias.Enabled = optCategorizado.Checked
    End Sub

#Region "Centrales"
    Private Sub CargaCentrales()
        Dim CentralFac As New CentralFacade
        Dim CentralesTable As ConfiguracionDS.CentralesDataTable = CentralFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
        bsCentrales.DataSource = CentralesTable
        grdCentrales.Rebind(True)

        ''Çargamos los remitentes siempre y cuando no este la tabla ya con datos de un llamado previo
        'Dim Remitentes As New Azteca.Kernel.Mail.RemitenteFacade
        'Dim RemitentesTable As DataTable = Remitentes.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
        'bsRemitentes.DataSource = RemitentesTable
        'dropRemitentes.Rebind(True)

        ''Çargamos los operadores siempre y cuando no este la tabla ya con datos de un llamado previo
        'Dim Operadores As New Azteca.Kernel.General.OperadorFacade
        'Dim OperadoresTable As DataTable = Operadores.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
        'bsOperadores.DataSource = OperadoresTable
        'dropOperador.Rebind(True)

        btnCentralComprasAdd.Enabled = True
        grdCentrales.Enabled = True
    End Sub

    Private Sub btnCentralComprasRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentralComprasRefresh.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            CargaCentrales()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdCentrales_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdCentrales.BeforeColUpdate
        Try
            If e.Column.Name = "Cuenta" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdCentrales.Columns("Cuenta").Value) <= 0 Then Return
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                If CuentaFac.Exists(App.Session.SessionID, grdCentrales.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, grdCentrales.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity, False)
                    grdCentrales.Columns("IdCuenta").Value = Cuenta.Identity
                    grdCentrales.Columns("Concepto").Value = Cuenta.Nombre
                Else
                    e.Cancel = True
                    MessageBox.Show("La cuenta especificada no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub grdCentrales_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCentrales.ButtonClick
        Try
            If e.Column.Name = "Cuenta" Then
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
                frmSearch.StartPosition = FormStartPosition.CenterParent
                If frmSearch.ShowDialog(CuentaFac, CuentaFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                    grdCentrales.Columns("IdCuenta").Value = Cuenta.Identity
                    grdCentrales.Columns("Cuenta").Value = Cuenta.UserCode
                    grdCentrales.Columns("Concepto").Value = Cuenta.Nombre
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCentrales_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCentrales.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If MessageBox.Show("¿Esta seguro de eliminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim CentralFac As New CentralFacade
                CentralFac.Delete(App.Session.SessionID, e.ID)
                MessageBox.Show("El elemeno ha sido eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargaCentrales()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    'Private Sub btnCentralComprasSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) ''Handles btnCentralComprasAdd.Click
    '    Try
    '        Dim CentralesTable As ConfiguracionDS.CentralesDataTable = CType(bsCentrales.DataSource, ConfiguracionDS.CentralesDataTable)
    '        Dim CentralesFac As New CentralFacade
    '        CentralesFac.UpdateList(App.Session.SessionID, App.DefaultCompany.Identity, App.DefaultSite.Identity, CentralesTable.GetChanges)
    '        MessageBox.Show("Se han actualizado los datos de los Centros de Compras", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Catch ex As Exception
    '        MsgInfo.Show(ex)
    '    End Try
    'End Sub

    Private Sub btnCentralComprasAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentralComprasAdd.Click
        Try
            Dim frm As New CentralesForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, 0, "Agregar Nueva Central de Compras") = System.Windows.Forms.DialogResult.OK Then
                CargaCentrales()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCentrales_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCentrales.EditButtonClick
        Try
            Dim frm As New CentralesForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, e.ID, "Editando Central de Compras") = System.Windows.Forms.DialogResult.OK Then
                CargaCentrales()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

#Region "Centros de Recepcion"

    Private Sub CargarCentrosRecepcion()
        Try
            Dim CentroRecepFac As New CentroRecepcionFacade
            Dim CentroRecepTable As ConfiguracionDS.CentrosRecepcionDataTable = CentroRecepFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
            bsCentrosRecepcion.DataSource = CentroRecepTable
            grdCentrosRecepcion.Rebind(True)
            ''Çargamos los almacenes siempre y cuando no este la tabla ya con datos de un llamado previo
            'Dim AlmacenFac As New Azteca.Business.Inventario.AlmacenFacade
            'Dim AlmacenesTable As DataTable = AlmacenFac.LoadList(App.Session.SessionID, App.DefaultCompany.Identity)
            'bsAlmacenes.DataSource = AlmacenesTable
            'dropAlmacenes.Rebind(True)

            btnCentrosRecepcionAdd.Enabled = True
            grdCentrosRecepcion.Enabled = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub btnCentrosRecepcionRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentrosRecepcionRefresh.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            CargarCentrosRecepcion()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdCentrosRecepcion_BeforeColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles grdCentrosRecepcion.BeforeColUpdate
        Try
            If e.Column.Name = "Cuenta" Then
                'Validar que se haya especificado una cuenta válida
                If Val(grdCentrosRecepcion.Columns("Cuenta").Value) <= 0 Then Return
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                If CuentaFac.Exists(App.Session.SessionID, grdCentrosRecepcion.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity) Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, grdCentrosRecepcion.Columns("Cuenta").Value.ToString, App.DefaultSite.Identity, False)
                    grdCentrosRecepcion.Columns("IdCuenta").Value = Cuenta.Identity
                    grdCentrosRecepcion.Columns("Concepto").Value = Cuenta.Nombre
                Else
                    e.Cancel = True
                    MessageBox.Show("La cuenta especificada no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub grdCentrosRecepcion_BeforeUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles grdCentrosRecepcion.BeforeUpdate
        Try
            Dim row As ConfiguracionDS.CentrosRecepcionRow = CType(CType(bsCentrosRecepcion.Current, DataRowView).Row, ConfiguracionDS.CentrosRecepcionRow)
            If row.IdAlmacen = 0 Then
                MessageBox.Show("Debe seleccionar un almacen para el Centro de Recepcion.", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
            End If
            If row.Calle.Trim.Length = 0 Then
                MessageBox.Show("No se ha establecido la [Calle] en el domicilio del Centro de Recepcion", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
            End If
            If row.Colonia.Trim.Length = 0 Then
                MessageBox.Show("No se ha establecido la [Colonia] en el domicilio del Centro de Recepcion", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
            End If
            If row.IdPoblacion = 0 Then
                MessageBox.Show("No se ha establecido la [Poblacion] en el domicilio del Centro de Recepcion", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
            End If
            If row.IdMunicipio = 0 Then
                MessageBox.Show("No se ha establecido el [Municipio] en el domicilio del Centro de Recepcion", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                e.Cancel = True
            End If

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCentrosRecepcion_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdCentrosRecepcion.ButtonClick
        Try
            If e.Column.Name = "Cuenta" Then
                Dim CuentaFac As New Azteca.Business.Contabilidad.CuentaFacade
                Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
                frmSearch.StartPosition = FormStartPosition.CenterParent
                If frmSearch.ShowDialog(CuentaFac, CuentaFac) = System.Windows.Forms.DialogResult.OK Then
                    Dim Cuenta As Azteca.Business.Contabilidad.CuentaInfo = CuentaFac.GetDetail(App.Session.SessionID, frmSearch.SelectedId, False)
                    grdCentrosRecepcion.Columns("IdCuenta").Value = Cuenta.Identity
                    grdCentrosRecepcion.Columns("Cuenta").Value = Cuenta.UserCode
                    grdCentrosRecepcion.Columns("Concepto").Value = Cuenta.Nombre
                End If
            End If
            If e.Column.Name = "D" Then
                Dim row As ConfiguracionDS.CentrosRecepcionRow = CType(CType(bsCentrosRecepcion.Current, DataRowView).Row, ConfiguracionDS.CentrosRecepcionRow)

                Dim frm As New DomicilioEditForm
                If frm.ShowDialog(Me, row.Calle, row.NumExt, row.NumInt, row.Colonia, row.CP, row.IdPoblacion, row.IdMunicipio, row.Tel1, row.Tel2, row.Fax) = System.Windows.Forms.DialogResult.OK Then
                    With row
                        .Calle = frm.Calle : .NumExt = frm.NumExt : .NumInt = frm.NumInt : .Colonia = frm.Colonia : .IdPoblacion = frm.IdPoblacion : .IdMunicipio = frm.IdMunicipio : .Tel1 = frm.Tel1 : .Tel2 = frm.Tel2 : .Fax = frm.Fax
                    End With
                End If
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

    End Sub

    Private Sub grdCentrosRecepcion_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCentrosRecepcion.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If MessageBox.Show("¿Esta seguro de eliminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim CentroRecepFac As New CentroRecepcionFacade
                CentroRecepFac.Delete(App.Session.SessionID, e.ID)
                MessageBox.Show("El elemeno ha sido eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCentrosRecepcion()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    'Private Sub btnCentrosRecepcionSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentrosRecepcionAdd.Click
    '    Try
    '        Dim CentrosRecepcionTable As ConfiguracionDS.CentrosRecepcionDataTable = CType(bsCentrosRecepcion.DataSource, ConfiguracionDS.CentrosRecepcionDataTable)
    '        Dim CentrosRececpcionFac As New CentroRecepcionFacade
    '        CentrosRececpcionFac.UpdateList(App.Session.SessionID, App.DefaultCompany.Identity, App.DefaultSite.Identity, CentrosRecepcionTable.GetChanges)
    '        MessageBox.Show("Se han actualizado los datos de los Centros de Recepcion", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Catch ex As Exception
    '        MsgInfo.Show(ex)
    '    End Try
    'End Sub

    Private Sub btnCentrosRecepcionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentrosRecepcionAdd.Click
        Try
            Dim frm As New CentrosRecepcionForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, 0, "Agregar Nuevo Centro de Recepción") = System.Windows.Forms.DialogResult.OK Then
                CargarCentrosRecepcion()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCentrosRecepcion_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCentrosRecepcion.EditButtonClick
        Try
            Dim frm As New CentrosRecepcionForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, e.ID, "Editando Centros de Recepción") = System.Windows.Forms.DialogResult.OK Then
                CargarCentrosRecepcion()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub grdCentrosRecepcion_Error(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ErrorEventArgs) Handles grdCentrosRecepcion.Error
        Try
            Throw e.Exception
        Catch ex As System.Data.DataException
            MessageBox.Show("Algunos datos no contienen la informacion esperada." & ControlChars.CrLf & _
                            "Verifique la pantalla de Domicilio y ajuste los valores necesarios", "Restriccion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Departamentos"
    Private Sub itemSelectedBtns(ByVal Selected As Boolean)
        btnDeptosSave.Enabled = Selected
        btnDeptosAccesos.Enabled = Selected
        btnDeptosAsignarCtrosRecibo.Enabled = Selected
    End Sub


    Private Sub btnDepartamentosrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptosRefresh.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            cboCentralComprasDepto.LoadList(App.DefaultCompany.Identity)
            Dim DeptosFac As New Azteca.Business.RH.DepartamentoFacade
            trvwDepartamentos.HierarchyFacade = DeptosFac
            trvwDepartamentos.LoadHierarchy()
            cboCaja.LoadList()
            itemSelectedBtns(False)
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
    Private Sub trvwDepartamentos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvwDepartamentos.AfterSelect
        Try
            Dim DeptoFac As New Azteca.Business.Compras.DepartamentoFacade
            DeptoInfo = DeptoFac.GetDetail(App.Session.SessionID, CInt(trvwDepartamentos.SelectedId), False)
            DeptoInfo.UserCode = CStr(trvwDepartamentos.SelectedId)
            If DeptoInfo.IdCuenta > 0 Then selCuenta.LoadInfo(DeptoInfo.IdCuenta)
            If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No Then optNoUtilizar.Checked = True
            If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado Then optCategorizado.Checked = True
            If DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Global_Depto Then optGlobal.Checked = True
            cboCentralComprasDepto.SelectedValue = DeptoInfo.IdCentral
            cboCaja.SelectedValue = DeptoInfo.IdCajaGastos

            bsDepartamentoCategorias.DataSource = DeptoInfo.CategoriasPresup
            grdDepartamentoCategorias.Rebind(True)

            bsDepartamentoConceptos.DataSource = DeptoInfo.ConceptosTable
            grdDepartamentoConceptos.Rebind(True)

            itemSelectedBtns(True)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub optNoUtilizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optNoUtilizar.CheckedChanged, optGlobal.CheckedChanged, optCategorizado.CheckedChanged
        gbxDeptosCategorias.Enabled = optCategorizado.Checked
    End Sub

    Private Sub btnDeptosSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptosSave.Click
        Try
            DeptoInfo.IdCuenta = selCuenta.Key
            DeptoInfo.IdCentral = CInt(cboCentralComprasDepto.SelectedValue)
            DeptoInfo.IdCajaGastos = CInt(cboCaja.SelectedValue)
            If optCategorizado.Checked Then
                DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Categorizado
            ElseIf optGlobal.Checked Then
                DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.Global_Depto
            Else
                DeptoInfo.TipoAdmonPresupuesto = TipoAdmonPresupuestoEnum.No
            End If
            Dim DeptoFac As New Azteca.Business.Compras.DepartamentoFacade
            DeptoFac.Update(DeptoInfo)
            MessageBox.Show("Se han actualizado los datos del departamento", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnDeptosCategoriaAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptosCategoriaAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim CategoriasPresupFac As New CategoriaPresupuestalFacade

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(CategoriasPresupFac, Nothing, True)
            For Each IdCatPresup As String In lst
                Dim drExist As ConfiguracionDS.CategoriasPresupuestalesRow = DeptoInfo.CategoriasPresup.FindByIdCategoriaPresupuestal(CInt(IdCatPresup))
                If drExist Is Nothing Then
                    'Obtenemos la categoria presupuestal
                    Dim CatPresInfo As CategoriaPresupuestalInfo = CategoriasPresupFac.GetDetail(App.Session.SessionID, CInt(IdCatPresup))

                    Dim drNew As ConfiguracionDS.CategoriasPresupuestalesRow = DeptoInfo.CategoriasPresup.NewCategoriasPresupuestalesRow
                    With drNew
                        .IdCategoriaPresupuestal = CatPresInfo.Identity : .CategoriaPres = CatPresInfo.Nombre
                    End With
                    DeptoInfo.CategoriasPresup.AddCategoriasPresupuestalesRow(drNew)
                Else
                    MessageBox.Show("El Categoria Presupuestal[" & drExist.CategoriaPres & "] ya está incluido en el Departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnDeptosAccesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptosAccesos.Click
        If CInt(trvwDepartamentos.SelectedId) > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim DepartamentoFac As New DepartamentoFacade
                Dim frm As New DepartamentosAccesosForm
                If frm.ShowDialog(Me, CInt(trvwDepartamentos.SelectedId)) = System.Windows.Forms.DialogResult.OK Then

                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Debe seleccionar un departamento para asignarle acceso a usuarios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnDeptosAsignarCtrosRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeptosAsignarCtrosRecibo.Click
        If CInt(trvwDepartamentos.SelectedId) > 0 Then
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Try
                Dim DepartamentoFac As New DepartamentoFacade
                Dim frm As New DepartamentosCentrosRecepcionForm
                If frm.ShowDialog(Me, CInt(trvwDepartamentos.SelectedId)) = System.Windows.Forms.DialogResult.OK Then

                End If
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        Else
            MessageBox.Show("Debe seleccionar un departamento para asignarle centros de recepcion.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    
    Private Sub grdDepartamentoCategorias_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdDepartamentoCategorias.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim dv As New DataView(DeptoInfo.CategoriasPresup, "IdCategoriaPresupuestal=" & e.ID, "", DataViewRowState.CurrentRows)
            dv(0).Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnDeptoGastoConceptoAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnDeptoGastoConceptoAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim GastoConceptoFac As New GastoConceptoFacade

            Dim lst As Azteca.Kernel.Search.IdentityList = Azteca.Windows.Forms.MsgList.Show(GastoConceptoFac, Nothing, True)
            For Each Ids As String In lst
                Dim drExist As ConfiguracionDS.DepartamentosGastosConceptosRow = DeptoInfo.ConceptosTable.FindByIdGastoConcepto(CInt(Ids))
                If drExist Is Nothing Then
                    'Obtenemos la categoria presupuestal
                    Dim GastoConcepInfo As GastoConceptoInfo = GastoConceptoFac.GetDetail(App.Session.SessionID, CInt(Ids))

                    Dim drNew As ConfiguracionDS.DepartamentosGastosConceptosRow = DeptoInfo.ConceptosTable.NewDepartamentosGastosConceptosRow
                    With drNew
                        .IdGastoConcepto = GastoConcepInfo.Identity : .Concepto = GastoConcepInfo.Nombre : .IdGastoConceptoTipo = GastoConcepInfo.IdGastoConceptoTipo : .ConceptoTipo = GastoConcepInfo.GastoConceptoTipo : .Cuenta = GastoConcepInfo.Cuenta : .Descripcion = GastoConcepInfo.DescrCuenta : .CategoriaPresupuestal = GastoConcepInfo.CategoriaPresupuestal
                    End With
                    DeptoInfo.ConceptosTable.AddDepartamentosGastosConceptosRow(drNew)
                Else
                    MessageBox.Show("El Concepto de gasto[" & drExist.Concepto & "] ya está incluido en el Departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Next
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdDepartamentoConceptos_DeleteButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdDepartamentoConceptos.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim dv As New DataView(DeptoInfo.ConceptosTable, "IdGastoConcepto=" & e.ID, "", DataViewRowState.CurrentRows)
            dv(0).Delete()
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Categorias Presupuestales"

    Private Sub CargarCategoriasPresupuestales()
        Try
            Dim CatPresFac As New CategoriaPresupuestalFacade
            Dim CategoriasPresTable As DataTable = CatPresFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
            bsCategoriaPresupuestal.DataSource = CategoriasPresTable
            grdCategoriasPresupuestales.Rebind(True)

            btnCatPresupNew.Enabled = True
            grdCategoriasPresupuestales.Enabled = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCatPresupRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatPresupRefresh.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            CargarCategoriasPresupuestales()
        Catch ex As Exception
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnCatPresupNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatPresupNew.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim frm As New CategoriaPresupuestalForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, 0, "Agregar Nueva Categoria Presupuestal") = System.Windows.Forms.DialogResult.OK Then
                CargarCategoriasPresupuestales()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnArticulosCat_Click(sender As System.Object, e As System.EventArgs) Handles btnArticulosCat.Click
        If bsCategoriaPresupuestal.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim IdCatPresup As Integer = CInt(CType(bsCategoriaPresupuestal.Current, DataRowView)("IdCategoriaPresupuestal"))
                CategoriasArticulosAdmin(IdCatPresup)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub btnServiciosCat_Click(sender As System.Object, e As System.EventArgs) Handles btnServiciosCat.Click
        If bsCategoriaPresupuestal.Current IsNot Nothing Then
            Try
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim IdCatPresup As Integer = CInt(CType(bsCategoriaPresupuestal.Current, DataRowView)("IdCategoriaPresupuestal"))
                CategoriasServiciosAdmin(IdCatPresup)
            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                System.Windows.Forms.Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub


    Private Sub grdCategoriasPresupuestales_DeleteButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCategoriasPresupuestales.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If MessageBox.Show("¿Esta seguro de eliminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim CatPresupFac As New CategoriaPresupuestalFacade
                CatPresupFac.Delete(App.Session.SessionID, e.ID)
                MessageBox.Show("El elemeno ha sido eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCategoriasPresupuestales()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdCategoriasPresupuestales_EditButtonClick(ByVal sender As Object, ByVal e As Controls.GridViewCatalogButtonEventArgs) Handles grdCategoriasPresupuestales.EditButtonClick
        Try
            Dim frm As New CategoriaPresupuestalForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, e.ID, "Editando Categoria Presupuestal") = System.Windows.Forms.DialogResult.OK Then
                CargarCategoriasPresupuestales()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub CategoriasServiciosAdmin(ByVal IdCatPresup As Integer)
        Dim frm As New CategoriaPresupuestalServiciosAdmin
        If frm.ShowDialog(Me, IdCatPresup) = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

    Private Sub CategoriasArticulosAdmin(ByVal IdCatPresup As Integer)
        Dim frm As New CategoriaPresupuestalArticulosAdmin
        If frm.ShowDialog(Me, IdCatPresup) = System.Windows.Forms.DialogResult.OK Then

        End If
    End Sub

#End Region

#Region "Gastos"
    Private Sub btnGastosRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGastosRefresh.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            CargarGastos()
        Catch ex As Exception
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub
    Private Sub CargarGastos()
        Try
            Dim GastoConceptTipoFac As New GastoConceptoTipoFacade
            Dim GastoConcepTipoTable As DataTable = GastoConceptTipoFac.List(App.Session.SessionID, App.DefaultCompany.Identity)
            bsGastosTipos.DataSource = GastoConcepTipoTable
            grdGastosTipos.Rebind(True)

            btnGastosAdd.Enabled = True
            grdGastosTipos.Enabled = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnGastosAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGastosAdd.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            Dim frm As New GastosTiposForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, 0, "Agregar Nuevo Tipo de Gasto") = System.Windows.Forms.DialogResult.OK Then
                CargarGastos()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub grdGastosTipos_DeleteButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdGastosTipos.DeleteButtonClick
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            If MessageBox.Show("¿Esta seguro de eliminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Dim GastoConceptoTipoFac As New GastoConceptoTipoFacade
                GastoConceptoTipoFac.Delete(App.Session.SessionID, e.ID)
                MessageBox.Show("El elemeno ha sido eliminado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarCentrosRecepcion()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try
    End Sub


    Private Sub grdGastosTipos_EditButtonClick(sender As Object, e As Controls.GridViewCatalogButtonEventArgs) Handles grdGastosTipos.EditButtonClick
        Try
            Dim frm As New GastosTiposForm
            frm.CodeTextBox.Enabled = False : frm.StartPosition = FormStartPosition.CenterParent
            If frm.ShowDialog(Me, e.ID, "Editando el tipo de concepto de gastos") = System.Windows.Forms.DialogResult.OK Then
                CargarGastos()
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

#End Region

End Class