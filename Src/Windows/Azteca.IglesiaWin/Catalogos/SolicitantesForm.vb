Public Class SolicitantesForm

    Private Sub SolicitantesForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
        rbtnMasculino.Checked = True
    End Sub

    Private Sub SolicitantesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SolicitantesForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim EmpleadoInf As SolicitanteInfo = CType(Me.PackageInfo, SolicitanteInfo)
            With EmpleadoInf
                'Cargar información de Persona
                txtNombre.Text = .Persona.Nombre
                txtApellidoP.Text = .Persona.ApellidoP
                txtApellidoM.Text = .Persona.ApellidoM
                txtTelCasa.Text = .Persona.TelCasa
                txtTelOficina.Text = .Persona.TelOficina
                txtCelular.Text = .Persona.Celular
                txtCorreo.Text = .Persona.Correo
                txtCalle.Text = .Persona.Calle
                txtNumExt.Text = .Persona.NumExt
                txtNumInt.Text = .Persona.NumInt
                txtColonia.Text = .Persona.Colonia
                txtCP.Text = .Persona.CP
                chkActivo.Checked = CBool(IIf(.Status = CatalogState.Active, True, False))
                'Cargar información de la población
                txtPoblacion.Text = CStr(.Persona.IdPoblacion)
                txtPoblacion.LoadInfo()

                'Cargar Información Adicional
                dtpFechaNacimiento.Value = .FechaNacimiento
                If .Genero = "M" Then
                    rbtnMasculino.Checked = True
                    rbtnFemenino.Checked = False
                ElseIf .Genero = "F" Then
                    rbtnFemenino.Checked = True
                    rbtnMasculino.Checked = False
                End If
                txtNombreCorto.Text = .NombreCorto
                
                'Datos Parroquiales
                txtNombrePadre.Text = .NombrePadre
                txtNombreMadre.Text = .NombreMadre
                txtAbuelosPaternos.Text = .AbuelosPaternos
                txtAbuelosMaternos.Text = .AbuelosMaternos
                dtpFechaAlta.Value = .FechaAlta
                txtLugarNacimiento.Text = .LugarNacimiento

                'Datos del Bautismo
                BautismoSel.Text = CStr(.IdBautismo)
                BautismoSel.LoadInfo()
                dtpFechaBautismo.Value = .FechaBautismo
                txtLibroBautismo.Text = .LibroBautismo
                txtPaginaBautismo.Text = .PaginaBautismo
                txtActaBautismo.Text = .ActaBautismo
                txtParroquiaBautismo.Text = .ParroquiaBautismo
                txtCalleBautismo.Text = .CalleBautismo
                txtColoniaBautismo.Text = .ColoniaBautismo
                txtCPBautismo.Text = .CPBautismo
                txtNumExteriorBautismo.Text = .NumExtBautismo
                txtNumInteriorBautismo.Text = .NumIntBautismo
                PoblacionBautismoSel.Text = CStr(.IdPoblacionBautismo)
                PoblacionBautismoSel.LoadInfo()

                txtLugarNacimiento.Text = .LugarNacimiento
                picEmpleado.SetImageBytes(.Foto)
                If .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active Then
                    chkActivo.Checked = True
                ElseIf .Status = Azteca.Kernel.BusinessStructure.CatalogState.Inactive Then
                    chkActivo.Checked = False
                End If

                If (.IdBautismo > 0) Then
                    chkCapturaManual.Checked = False
                End If
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub SolicitantesForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim SolicitanteInf As SolicitanteInfo = CType(Me.PackageInfo, SolicitanteInfo)
            With SolicitanteInf
                'Datos Personales
                .Persona.Nombre = txtNombre.Text
                .Persona.ApellidoP = txtApellidoP.Text
                .Persona.ApellidoM = txtApellidoM.Text
                .Persona.TelCasa = txtTelCasa.Text
                .Persona.TelOficina = txtTelOficina.Text
                .Persona.Celular = txtCelular.Text
                .Persona.Correo = txtCorreo.Text
                .Persona.Calle = txtCalle.Text
                .Persona.NumExt = txtNumExt.Text
                .Persona.NumInt = txtNumInt.Text
                .Persona.Colonia = txtColonia.Text
                .Persona.CP = txtCP.Text
                .Persona.Status = CType(IIf(chkActivo.Checked, CatalogState.Active, CatalogState.Inactive), CatalogState)
                .Persona.IdPoblacion = txtPoblacion.Key

                'Adicionales
                .FechaNacimiento = dtpFechaNacimiento.Value
                If rbtnMasculino.Checked Then
                    .Genero = "M"
                ElseIf rbtnFemenino.Checked Then
                    .Genero = "F"
                End If
                .NombreCorto = txtNombreCorto.Text

                'Datos Parroquiales
                .NombrePadre = txtNombrePadre.Text
                .NombreMadre = txtNombreMadre.Text
                .AbuelosPaternos = txtAbuelosPaternos.Text
                .AbuelosMaternos = txtAbuelosMaternos.Text
                .FechaAlta = dtpFechaAlta.Value

                'Datos del Bautismo
                If (Not chkCapturaManual.Checked) Then
                    .IdBautismo = BautismoSel.Key
                Else
                    .IdBautismo = 0
                End If

                .FechaBautismo = dtpFechaBautismo.Value
                .LugarNacimiento = txtLugarNacimiento.Text
                .LibroBautismo = txtLibroBautismo.Text
                .PaginaBautismo = txtPaginaBautismo.Text
                .ActaBautismo = txtActaBautismo.Text
                .ParroquiaBautismo = txtParroquiaBautismo.Text
                .CalleBautismo = txtCalleBautismo.Text
                .ColoniaBautismo = txtColoniaBautismo.Text
                .CPBautismo = txtCPBautismo.Text
                .NumExtBautismo = txtNumExteriorBautismo.Text
                .NumIntBautismo() = txtNumInteriorBautismo.Text
                .IdPoblacionBautismo = PoblacionBautismoSel.Key

                If chkActivo.Checked Then
                    .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active
                ElseIf chkActivo.Checked = False Then
                    .Status = Azteca.Kernel.BusinessStructure.CatalogState.Inactive
                End If
                .Foto = picEmpleado.GetImageBytes()
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtPoblacion_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtPoblacion.InfoLoaded
        Dim poblacion As Azteca.Kernel.General.PoblacionInfo = CType(txtPoblacion.PackageInfo, Azteca.Kernel.General.PoblacionInfo)
        lblEstadoInf.Text = poblacion.Estado
    End Sub

    Private Sub PoblacionBautismoSel_InfoLoaded(sender As System.Object, e As System.EventArgs)
        Dim poblacion As Azteca.Kernel.General.PoblacionInfo = CType(PoblacionBautismoSel.PackageInfo, Azteca.Kernel.General.PoblacionInfo)
        lblEstadoBautismo.Text = poblacion.Estado
    End Sub

    Private Sub chkCapturaManual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCapturaManual.CheckedChanged
        Call ActivarCapturaManual()
    End Sub

    Sub ActivarCapturaManual()
        grpBautismo.Enabled = chkCapturaManual.Checked
        BautismoSel.Enabled = Not chkCapturaManual.Checked
    End Sub
End Class