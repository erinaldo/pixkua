Public Class SacerdotesForm

    Private Sub SacerdotesForm_AddingItem(sender As Object, e As System.EventArgs) Handles Me.AddingItem
        chkActivo.Checked = True
        rbtMasculino.Checked = True
    End Sub

    Private Sub SacerdotesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SacerdotesForm_LoadingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.LoadingItem
        Try
            Dim SacerdoteInf As SacerdoteInfo = CType(Me.PackageInfo, SacerdoteInfo)
            With SacerdoteInf
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
                    rbtMasculino.Checked = True
                    rbtFemenino.Checked = False
                ElseIf .Genero = "F" Then
                    rbtFemenino.Checked = True
                    rbtMasculino.Checked = False
                End If
                txtNombreCorto.Text = .NombreCorto
                dtpFechaIngreso.Value = .FechaIngreso
                txtTitulo.Text = .Titulo
                txtIMSS.Text = .NSS
                txtRFC.Text = .RFC
                txtCURP.Text = .CURP
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

    Private Sub SacerdotesForm_SavingItem(sender As Object, e As Forms.InfoEntryEventArgs) Handles Me.SavingItem
        Try
            Dim SacerdoteInfo As SacerdoteInfo = CType(PackageInfo, SacerdoteInfo)
            With SacerdoteInfo
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
                If rbtMasculino.Checked Then
                    .Genero = "M"
                ElseIf rbtFemenino.Checked Then
                    .Genero = "F"
                End If
                .NombreCorto = txtNombreCorto.Text
                .FechaIngreso = dtpFechaIngreso.Value
                .Titulo = txtTitulo.Text
                .NSS = txtIMSS.Text
                .RFC = txtRFC.Text
                .CURP = txtCURP.Text
                If chkActivo.Checked Then
                    .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active
                ElseIf chkActivo.Checked = False Then
                    .Status = Azteca.Kernel.BusinessStructure.CatalogState.Inactive
                End If
            End With

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub txtPoblacion_InfoLoaded(sender As System.Object, e As System.EventArgs) Handles txtPoblacion.InfoLoaded
        Dim poblacion As Azteca.Kernel.General.PoblacionInfo = CType(txtPoblacion.PackageInfo, Azteca.Kernel.General.PoblacionInfo)
        lblEstadoInf.Text = poblacion.Estado
    End Sub
End Class