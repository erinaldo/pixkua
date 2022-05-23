Public Class EmpleadosForm

    Private Sub EmpleadosForm_AddingItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
        rbtnMasculino.Checked = True
    End Sub

    Private Sub EmpleadosForm_LoadingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim EmpleadoInf As EmpleadoInfo = CType(Me.PackageInfo, EmpleadoInfo)
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
                txtCodigoChecador.Text = CStr(.CodigoChecador)
                txtNombreCorto.Text = .NombreCorto
                If .IdTurno > 0 Then
                    ''selTurno.LoadInfo(.IdTurno)
                Else
                    ''selTurno.Text = String.Empty
                End If
                dtpFechaInicio.Value = .FechaInicio
                selDepartamento.LoadInfo(.IdDepartamento)
                'cboSucursal.SelectedValue = .IdSucursal
                dtpFechaIngreso.Value = .FechaIngreso
                txtSueldo.Text = .Sueldo.ToString
                txtTitulo.Text = .Titulo
                selPuesto.LoadInfo(.IdPuesto)
                txtIMSS.Text = .NSS
                txtRFC.Text = .RFC
                txtCURP.Text = .CURP
                selCuenta.LoadInfo(.IdCuenta)
                picEmpleado.SetImageBytes(.Foto)
                If .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active Then
                    chkActivo.Checked = True
                ElseIf .Status = Azteca.Kernel.BusinessStructure.CatalogState.Inactive Then
                    chkActivo.Checked = False
                End If
            End With
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub EmpleadosForm_SavingItem(ByVal sender As Object, ByVal e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim EmpleadoInf As EmpleadoInfo = CType(Me.PackageInfo, EmpleadoInfo)
            With EmpleadoInf
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
                If Val(txtCodigoChecador.Text) = 0 Then txtCodigoChecador.Text = Me.Code
                .CodigoChecador = CInt(Val(txtCodigoChecador.Text))
                .NombreCorto = txtNombreCorto.Text
                '.IdTurno = selTurno.Key
                .FechaInicio = dtpFechaInicio.Value
                .FechaIngreso = dtpFechaIngreso.Value
                .IdDepartamento = selDepartamento.Key
                ''.IdSucursal = CInt(cboSucursal.SelectedValue)
                .Sueldo = CDec(Val(txtSueldo.Text))

                .Titulo = txtTitulo.Text
                .IdPuesto = selPuesto.Key
                .NSS = txtIMSS.Text
                .RFC = txtRFC.Text
                .CURP = txtCURP.Text
                .IdCuenta = selCuenta.Key
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

    Private Sub txtPoblacion_InfoLoaded(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPoblacion.InfoLoaded
        Dim poblacion As Azteca.Kernel.General.PoblacionInfo = CType(txtPoblacion.PackageInfo, Azteca.Kernel.General.PoblacionInfo)
        lblEstadoInf.Text = poblacion.Estado
    End Sub

    Private Sub EmpleadosForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class