Public Class TerminalesForm

    Private Sub TerminalesForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
    End Sub

    Private Sub TerminalesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboCaja.LoadList()
    End Sub

    Private Sub TerminalesForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Dim info As TerminalInfo = CType(Me.PackageInfo, TerminalInfo)
        With info
            txtNombre.Text = .Nombre
            txtPC.Text = .PC
            cboCaja.SelectedValue = .IdCaja
            If .IdCuenta > 0 Then selCuenta.LoadInfo(.IdCuenta)

            If .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active Then
                chkActivo.Checked = True
            Else
                chkActivo.Checked = False
            End If
        End With

    End Sub

    Private Sub TerminalesForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Dim info As TerminalInfo = CType(Me.PackageInfo, TerminalInfo)
        With info
            .Nombre = txtNombre.Text
            .PC = txtPC.Text
            .IdCaja = CInt(cboCaja.SelectedValue)
            .IdCuenta = selCuenta.Key
            If chkActivo.Checked Then
                .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active
            Else
                .Status = Azteca.Kernel.BusinessStructure.CatalogState.Inactive
            End If
        End With

    End Sub

End Class