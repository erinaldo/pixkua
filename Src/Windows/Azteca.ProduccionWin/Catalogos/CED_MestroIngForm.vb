Public Class CED_MestroIngForm

    Private Sub CED_MestroIngForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CED_MestroIngForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As MaestroIngInfo = CType(PackageInfo, MaestroIngInfo)

        With info
            txtNombre.Text = .Nombre
            selArticuloStock.LoadInfo(.IdArticuloStock)
            txtVersion.Text = .Version.ToString()
            txtCantDeseada.Text = .CantDeseada.ToString()
        End With

        Call CargarInsumos(info.Identity, 0)
        Call CargarEnsambles(info.Identity)
    End Sub

    Private Sub CED_MestroIngForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try

            Dim info As MaestroIngInfo = CType(Me.PackageInfo, MaestroIngInfo)

            With info
                .Nombre = txtNombre.Text
                .IdArticuloStock = selArticuloStock.Key
                .CantDeseada = CDec(txtCantDeseada.Text)
                If (txtVersion.Text = "") Then
                    .Version = 1
                Else
                    .Version = CInt(txtVersion.Text)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show("Error al guardar" + ex.Message(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tlbAgregarEnsamble_Click(sender As System.Object, e As System.EventArgs) Handles tlbAgregarEnsamble.Click
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As MaestroIngInfo = CType(PackageInfo, MaestroIngInfo)
                Dim EnsambleRow As MaestrosIngDS.EnsamblesRow = GetEnsambleByCurrent(bsEnsambles.Current)
                Dim frmEnsambleSel As New MaestroIngEnsamblesForm
                If (frmEnsambleSel.ShowDialog(Me, info.Identity, EnsambleRow) = System.Windows.Forms.DialogResult.OK) Then
                    Call CargarEnsambles(info.Identity)
                End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información del ensamble", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CargarEnsambles(ByVal idMaestroIng As Integer)
        Dim OTFacade As New MaestroIngFacade()
        bsEnsambles.DataSource = OTFacade.LoadEnsamblesMG(App.Session.SessionID, idMaestroIng)
        grdEnsambles.Rebind(True)

    End Sub

    Private Sub CargarInsumos(ByVal idMaestroIng As Integer, ByVal idEnsamble As Integer)
        Dim MGFacade As New MaestroIngFacade()
        bsInsumos.DataSource = MGFacade.LoadInsumosMG(App.Session.SessionID, idMaestroIng, idEnsamble)
        grdInsumos.Rebind(True)
    End Sub

    Private Function GetEnsambleByCurrent(ByVal ensambleCurrent As Object) As MaestrosIngDS.EnsamblesRow
        Dim row As MaestrosIngDS.EnsamblesRow = CType(PackageInfo, MaestroIngInfo).Ensambles.NewEnsamblesRow


        Try
            Dim currentView As DataRowView = CType(ensambleCurrent, DataRowView)
            row.IdEnsamble = CInt(currentView("IdEnsamble"))
            row.IdMaestroIng = CInt(currentView("IdMaestroIng"))
            row.Orden = CShort(currentView("Orden"))
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try

        Return row

    End Function

    Private Sub tlbAgregarArticulo_Click(sender As System.Object, e As System.EventArgs) Handles tlbAgregarArticulo.Click
        If PackageInfo.Identity > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Dim info As MaestroIngInfo = CType(PackageInfo, MaestroIngInfo)
                Dim InsumoRow As MaestrosIngDS.InsumosRow = info.Insumos.NewInsumosRow
                Dim frmArticuloSel As New OrdenesTrabajoInsumosSelForm

                'If (frmArticuloSel.ShowDialog(Me, info.Identity, InsumoRow) = System.Windows.Forms.DialogResult.OK) Then
                '    Call CargarInsumos(info.Identity, 0)
                'End If

            Catch ex As Exception
                MsgInfo.Show(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

        Else
            MessageBox.Show("Primero debe guardar la información de la Orden de Trabajo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdEnsambles_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles grdEnsambles.MouseClick

        Try
            Dim row As MaestrosIngDS.EnsamblesRow = CType(PackageInfo, MaestroIngInfo).Ensambles.NewEnsamblesRow
            Dim currentView As DataRowView = CType(bsEnsambles.Current, DataRowView)

            row.IdEnsamble = CInt(currentView("IdEnsamble"))
            row.IdMaestroIng = CInt(currentView("IdMaestroIng"))
            row.Orden = CShort(currentView("Orden"))

            Call CargarInsumos(row.IdMaestroIng, row.IdEnsamble)
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try


    End Sub
End Class