Imports Azteca.Windows
Imports Azteca.Windows.Controls.Common

Public Class ConfiguracionInicialForm

#Region "Implementacion"

    Private Sub ConfiguracionInicialForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tabConfiguracion.ShowTabs = False
        rdbCFDI.Checked = True
    End Sub

    Private Sub cmdFinalizar_Click(sender As System.Object, e As System.EventArgs) Handles cmdFinalizar.Click
        Try
            If ValidControls(Me.Controls) AndAlso IsValidCertificado() Then
                Dim Empresa As Azteca.Kernel.Security.EmpresaInfo = getEmpresa()
                Dim Sucursal As Azteca.Kernel.Security.SucursalInfo = getSucursal()
                Dim CertificadoInf As Azteca.Business.Contabilidad.CertificadoInfo = getCertificado()
                Dim Serie As New Azteca.Business.Contabilidad.SerieInfo(App.Session.SessionID)
                Serie.Serie = txtSerie.Text
                Dim UnidadNegocioFac As New Azteca.Business.Ventas.UnidadNegocioFacade
                UnidadNegocioFac.ConfiguracionEmpresaSave(App.Session.SessionID, Empresa, Sucursal, CertificadoInf, Serie, CInt(Val(txtAnioAprobacion.Text)), CInt(Val(txtNumAprobacion.Text)), CInt(txtFolioInicial.Text), CInt(txtFolioFinal.Text), txtRegimenFiscal.Text)
                'MessageBox.Show("Se ha guardado correctamente la Empresa." & ControlChars.CrLf & ControlChars.CrLf & "El sistema se cerrará para que vuelva a identificarse nuevamente.", "Guardado Correcto")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub cmdSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles cmdSiguiente.Click
        If Not ValidControls(tabConfiguracion.SelectedTab.Controls) Then Exit Sub

        If tabConfiguracion.SelectedTab Is pagBienvenida Then
            tabConfiguracion.SelectedTab = pagEmpresa : cmdAnterior.Enabled = True
        ElseIf tabConfiguracion.SelectedTab Is pagEmpresa Then
            tabConfiguracion.SelectedTab = pagRegimenFiscal
        ElseIf tabConfiguracion.SelectedTab Is pagRegimenFiscal Then
            tabConfiguracion.SelectedTab = pagSucursal
        ElseIf tabConfiguracion.SelectedTab Is pagSucursal Then
            tabConfiguracion.SelectedTab = pagCertificados : cmdSiguiente.Enabled = False : cmdFinalizar.Visible = True
        End If
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As System.EventArgs) Handles cmdAnterior.Click
        If tabConfiguracion.SelectedTab Is pagEmpresa Then
            tabConfiguracion.SelectedTab = pagBienvenida : cmdAnterior.Enabled = False
        ElseIf tabConfiguracion.SelectedTab Is pagCertificados Then
            tabConfiguracion.SelectedTab = pagSucursal : cmdFinalizar.Visible = False : cmdSiguiente.Enabled = True
        ElseIf tabConfiguracion.SelectedTab Is pagSucursal Then
            tabConfiguracion.SelectedTab = pagRegimenFiscal
        ElseIf tabConfiguracion.SelectedTab Is pagRegimenFiscal Then
            tabConfiguracion.SelectedTab = pagEmpresa
        End If
    End Sub

    Private Sub btnCopiarDomicilio_Click(sender As System.Object, e As System.EventArgs) Handles btnCopiarDomicilio.Click
        txtCalleSuc.Text = txtCalle.Text
        txtNumExtSuc.Text = txtNumExt.Text
        txtNumIntSuc.Text = txtNumInt.Text
        txtColoniaSuc.Text = txtColonia.Text
        txtCalleSuc.Text = txtCalle.Text
        txtCPSuc.Text = txtCP.Text
        selPoblacionSuc.LoadInfo(txtPoblacion.Key)
    End Sub

    Private Sub btnSelCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelCert.Click
        If dlgCertificate.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtCertificate.Text = dlgCertificate.FileName
        End If
    End Sub

    Private Sub btnSelPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelPK.Click
        If dlgPrivateKey.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPrivateKey.Text = dlgPrivateKey.FileName
        End If
    End Sub

    Private Sub rdbCFD_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbCFD.CheckedChanged, rdbCFDI.CheckedChanged
        If rdbCFDI.Checked Then
            pnlCFDI.Visible = True
            txtAnioAprobacion.Text = String.Empty
            txtAnioAprobacion.Visible = False
            txtNumAprobacion.Visible = False
            lblNoAprobacion.Visible = False
            lblAnioAprobacion.Visible = False
            txtFolioInicial.Text = "1"
            txtFolioFinal.Text = "1000000"
            txtFolioInicial.Focus()
        Else
            pnlCFDI.Visible = False
            txtAnioAprobacion.Text = Date.Today.Year.ToString
            txtAnioAprobacion.Visible = True
            txtNumAprobacion.Visible = True
            lblNoAprobacion.Visible = True
            lblAnioAprobacion.Visible = True
            txtFolioInicial.Focus()
        End If
    End Sub

    Private Sub lnkPagina_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPagina.LinkClicked
        Try
            System.Diagnostics.Process.Start("http://www.aztecasoftware.mx/productos/pixkua-facturacion/")

        Catch ex As Exception
            MsgInfo.Show(ex)
        End Try
    End Sub

    Private Sub lnkRegistro_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRegistro.LinkClicked
        Dim frm As New RegistroTimbradoForm
        frm.ShowDialog(Me)
    End Sub

#End Region

#Region "Metodos Privados"

    Private Function getEmpresa() As Azteca.Kernel.Security.EmpresaInfo
        Dim Empresa As New Azteca.Kernel.Security.EmpresaInfo(Azteca.Windows.App.Session.SessionID)

        'Si es la primera vez que se configura una empresa
        Dim ConfigMgr As New Azteca.Kernel.Configuration.ConfigurationFacade
        Dim Inicio As Boolean = CBool(ConfigMgr.GetSystemParameter("Configuracion/InicioExpress", "Inicio"))
        If Inicio Then
            Dim EmpresaFac As New Azteca.Kernel.Security.EmpresaFacade
            Empresa = EmpresaFac.GetDetail(App.Session.SessionID, App.DefaultCompany.Identity)
        End If

        With Empresa
            .Nombre = Me.txtEmpresa.Text
            .NombreLargo = Me.txtEmpresa.Text
            .Logo = picLogo.GetImageBytes()
            .RFC = txtRFC.Text
            .RazonSocial = txtRazonSocial.Text
            .Calle = txtCalle.Text
            .NumExt = txtNumExt.Text
            .NumInt = txtNumInt.Text
            .Colonia = txtColonia.Text
            .IdPoblacion = txtPoblacion.Key
            .CodigoPostal = txtCP.Text
            .FormatoContable = "0"
            .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active
        End With
        Return Empresa
    End Function

    Private Function getSucursal() As Azteca.Kernel.Security.SucursalInfo
        Dim Sucursal As New Azteca.Kernel.Security.SucursalInfo(Azteca.Windows.App.Session.SessionID)
        With Sucursal
            'Datos Generales
            .Nombre = txtSucursal.Text
            .NombreLargo = txtSucursal.Text
            .IdEmpresa = 0
            .Telefono1 = "" 'txtTel1suc.Text
            .Telefono2 = "" 'txtTel2.Text
            .Fax = "" 'txtFax.Text
            .Correo = "" 'txtCorreo.Text
            .PaginaWeb = "" 'txtPagWeb.Text
            'Domicilio
            .Calle = txtCalleSuc.Text
            .NumExt = txtNumExtSuc.Text
            .NumInt = txtNumIntSuc.Text
            .Colonia = txtColoniaSuc.Text
            .CP = txtCPSuc.Text
            .IdPoblacion = selPoblacionSuc.Key
            .Status = Azteca.Kernel.BusinessStructure.CatalogState.Active
        End With

        Return Sucursal
    End Function

    Private Function getCertificado() As Azteca.Business.Contabilidad.CertificadoInfo
        Dim CertificadoInf As New Azteca.Business.Contabilidad.CertificadoInfo(Azteca.Windows.App.Session.SessionID)
        Try
            'Cargar certificado
            Dim Certificate As New Chilkat.Cert
            Dim success As Boolean = Certificate.LoadFromFile(txtCertificate.Text)
            If Not success Then Throw New Azteca.Kernel.BusinessStructure.BusinessException("Error al cargar el archivo del certificado.")
            'Cargar llave privada
            Dim PK As New Chilkat.PrivateKey
            success = PK.LoadPkcs8EncryptedFile(txtPrivateKey.Text, txtPassword.Text)
            If Not success Then Throw New Azteca.Kernel.BusinessStructure.BusinessException("Error al cargar el archivo de la llave privada.")
            'Asignar certificado y llave privada a la unidad de negocio
            With CertificadoInf
                'General
                .Nombre = txtNombreCertificado.Text
                .NumeroCertificado = txtNumCertificado.Text
                If .IdEmpresa = 0 Then .IdEmpresa = Azteca.Windows.App.DefaultCompany.Identity
                If rdbCFD.Checked Then
                    .TipoCFD = Azteca.Business.Contabilidad.FormatoCFD.CFD
                Else
                    .TipoCFD = Azteca.Business.Contabilidad.FormatoCFD.CFDI
                End If

                .Certificado = Certificate.ExportCertDer
                .LlavePrivada = PK.GetPkcs8Encrypted(txtPassword.Text)
                .PasswordPrivateKey = txtPassword.Text
                'la serie se agrega en el guardado

            End With
        Catch ex As Exception
            Throw ex
        End Try

        Return CertificadoInf
    End Function

    Private Function IsValidCertificado() As Boolean
        IsValidCertificado = False
        If txtCertificate.Text = String.Empty Then
            MessageBox.Show("Especifique el archivo del certificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCertificate.Focus()
        ElseIf txtPrivateKey.Text = String.Empty Then
            MessageBox.Show("Especifique el archivo de la llave privada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrivateKey.Focus()
        ElseIf txtPassword.Text = String.Empty Then
            MessageBox.Show("Indique el password de la llave privada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
        ElseIf txtNumCertificado.Text.Length < 20 Then
            MessageBox.Show("El número de certificado debe tener una longitud de 20 caracteres.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNumCertificado.Focus()
        Else
            Return True
        End If
    End Function

    Private Function ValidControls(ByVal controls As System.Windows.Forms.Control.ControlCollection) As Boolean
        'Recorrer la colección de controles y verificar los controles que implementan
        'la interface IValidable.
        For Each ctrl As Control In controls
            If TypeOf ctrl Is IValidable Then
                Dim valControl As IValidable = CType(ctrl, IValidable)
                'Verificar si la información del control es válida
                If Not valControl.IsValid Then
                    'Verificar si el contenedor del control es una página de un TabedControl,
                    'si es asi, entonces activar página que contiene el control
                    If TypeOf ctrl.Parent Is TabPage Then
                        Dim page As TabPage = CType(ctrl.Parent, TabPage)
                        Dim tab As TabControl = CType(page.Parent, TabControl)
                        tab.SelectedTab = page
                    End If
                    'Si la información del control no es válida, mostrar mensaje al usuario y la razón por la cual la información es incorrecta
                    MessageBox.Show(valControl.InvalidReason & " (" & valControl.UIName & ")", _
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ErrProvider.SetError(ctrl, valControl.InvalidReason)
                    ctrl.Focus()
                    AddHandler ctrl.Validating, AddressOf ClearValidationError
                    Return False
                End If
            End If
            'Verificar si el control tiene mas controles internos, si es asi validarlos
            If ctrl.Controls.Count > 0 Then
                If Not ValidControls(ctrl.Controls) Then Return False
            End If
        Next
        Return True
    End Function

    Private Sub ClearValidationError(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'Quitar error de validación del control y remover manejador de evento del control
        Dim ctrl As Control = CType(sender, System.Windows.Forms.Control)
        ErrProvider.Clear()
        RemoveHandler ctrl.Validating, AddressOf ClearValidationError
    End Sub

#End Region

    'Private Sub CargarCertificadoActual()
    '    Dim CertificadoInf As CertificadoInfo = CType(PackageInfo, CertificadoInfo)

    '    If CertificadoInf.Certificado Is Nothing Then
    '        lblIssuer.Text = "NO EXISTE CERTIFICADO"
    '    Else
    '        Dim Certificate As New Cert
    '        Dim success As Boolean = Certificate.LoadFromBinary(CertificadoInf.Certificado)
    '        lblIssuer.Text = Certificate.SubjectCN
    '        lblValidFrom.Text = Certificate.ValidFrom.ToString("dd-MMM-yyyy")
    '        lblValidTo.Text = Certificate.ValidTo.ToString("dd-MMM-yyyy")
    '    End If
    'End Sub


  
End Class