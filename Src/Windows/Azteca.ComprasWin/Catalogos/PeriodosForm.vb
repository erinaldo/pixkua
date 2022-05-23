Public Class PeriodosForm

    Private Sub PeriodosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        btnAbrir.Enabled = False
        btnCerrar.Enabled = False
    End Sub

    Private Sub PeriodosForm_ItemSaved(sender As Object, e As System.EventArgs) Handles Me.ItemSaved
        Dim info As PeriodoInfo = CType(Me.PackageInfo, PeriodoInfo)
        lblFechaApertura.Text = info.FechaApertura.ToString("dd-MM-yyyy")
        ''lblFechaCierreTXT.Text = info.FechaCierre.ToString("dd-MM-yyyy")
        btnCerrar.Enabled = True
    End Sub

    Private Sub PeriodosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboEjercicio.LoadList(App.DefaultCompany.Identity)
    End Sub


    Private Sub PeriodosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As PeriodoInfo = CType(Me.PackageInfo, PeriodoInfo)
        With info
            txtNombre.Text = .Nombre
            cboEjercicio.SelectedValue = .IdEjercicioFiscalTit
            cboPeriodo.SelectedIndex = .Mes - 1
            btnAbrir.Enabled = CBool(IIf(.Estatus = "A", False, True))
            btnCerrar.Enabled = CBool(IIf(.Estatus = "C", False, True))

            lblFechaApertura.Text = .FechaApertura.ToString("dd-MM-yyyy")
            lblFechaCierreTXT.Text = .FechaCierre.ToString("dd-MM-yyyy")
        End With
    End Sub

    Private Sub PeriodosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As PeriodoInfo = CType(Me.PackageInfo, PeriodoInfo)
        With info
            .Nombre = txtNombre.Text
            .IdEjercicioFiscalTit = CStr(cboEjercicio.SelectedValue)
            .Mes = cboPeriodo.SelectedIndex + 1

        End With
    End Sub

    Private Sub btnAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrir.Click
        Try
            Dim info As PeriodoInfo = CType(Me.PackageInfo, PeriodoInfo)
            Dim PerFac As New PeriodoFacade
            PerFac.Abrir(App.Session.SessionID, Me.PackageInfo.Identity)
            MessageBox.Show("Se ha abierto correctamente el presupuesto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblFechaApertura.Text = info.FechaApertura.ToString("dd-MM-yyyy")
            lblFechaCierreTXT.Text = info.FechaCierre.ToString("dd-MM-yyyy")
            btnAbrir.Enabled = False
            btnCerrar.Enabled = True
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Try
            Dim info As PeriodoInfo = CType(Me.PackageInfo, PeriodoInfo)
            Dim PerFac As New PeriodoFacade
            PerFac.Cerrar(App.Session.SessionID, Me.PackageInfo.Identity)
            MessageBox.Show("Se ha cerrado correctamente el presupuesto", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblFechaApertura.Text = info.FechaApertura.ToString("dd-MM-yyyy")
            lblFechaCierreTXT.Text = Date.Today.ToString("dd-MM-yyyy")
            btnAbrir.Enabled = True
            btnCerrar.Enabled = False
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

End Class