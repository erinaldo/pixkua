Public Class LoginForm
    Private Pass As String = String.Empty
    Private LastUser As String
    Private LastSite As Integer
    Private LastCompany As Integer
    Private IdEmpresa As Integer
    Private IdSucursal As Integer


    Private Sub cmdCancelar_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdCancelar.ClickButtonArea
        Me.Close()
    End Sub

    Private Sub btnUser_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles btnUser.ClickButtonArea
        Dim frm As New TecladoForm
        If frm.ShowDialog("Usuario", False) = System.Windows.Forms.DialogResult.OK Then
            btnUser.Text = frm.txtTexto.Text
        End If
    End Sub

    Private Sub btnPass_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles btnPass.ClickButtonArea
        Dim frm As New TecladoForm
        If frm.ShowDialog("Password", True) = System.Windows.Forms.DialogResult.OK Then
            Pass = frm.txtTexto.Text
            btnPass.Text = StrDup(Pass.Length, "*")
        End If
    End Sub

    Private Sub cmdAceptar_ClickButtonArea(Sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cmdAceptar.ClickButtonArea
        If Not IsValid() Then Return
        Try
            Dim User As New UsuarioFacade
            Dim sesion As SessionInfo = User.LogIn(btnUser.Text, Pass, System.Windows.Forms.SystemInformation.ComputerName)
            If Not sesion Is Nothing Then
                App.InitSystem(sesion, "Pixkua Restaurante", Nothing, Nothing)
                App.Session.User.Password = String.Empty
                If ValidateSiteAccess() Then
                    SaveLogin(btnUser.Text, IdEmpresa, IdSucursal)
                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("El usuario no tiene acceso a ninguna sucursal o no se seleccionó una", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Contraseña y/o nombre de usuario incorrectos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnPass.Focus()
            End If
        Catch ex As System.Exception
            MsgInfo.Show(ex)
        Finally
            'btnAceptar.Enabled = True
        End Try
    End Sub

    Private Function IsValid() As Boolean
        If btnUser.Text.Trim = String.Empty Then
            MessageBox.Show("Por favor ingrese su nombre de usuario.", "Información Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUser.Focus()
            Return False
        End If
        Return True
    End Function
    Public Function ValidateSiteAccess() As Boolean
        'Obtener lista de sucursales a las que tiene acceso el usuario que ingresó
        Dim sucursal As New SucursalFacade()
        Dim dsSucursales As DataSet = sucursal.LoadList(0, App.Session.User.Identity)
        Dim dtSucursales As DataTable = dsSucursales.Tables(0)
        'Verificar que tenga acceso a por lo menos una sucursal
        If dtSucursales.Rows.Count = 1 Then
            Dim drSucursal As DataRow = dtSucursales.Rows(0)
            LoadDefaultSite(CInt(drSucursal("IdEmpresa")), CInt(drSucursal("IdSucursal")))
            Return True
        ElseIf dtSucursales.Rows.Count > 1 Then
            Dim frmDefaultSite As New DefaultSiteForm
            Return (frmDefaultSite.ShowDialog() = System.Windows.Forms.DialogResult.OK)
        Else
            Return False
        End If
    End Function

    Private Sub LoadDefaultSite(ByVal idEmpresa As Integer, ByVal idSucursal As Integer)
        Try
            MsgWorking.Show(Me)
            'Cargar paquete de información de empresa
            MsgWorking.SetProgress("Cargando información de la empresa.", 0)
            Dim empresaFac As New EmpresaFacade()
            Dim Empresa As EmpresaInfo = empresaFac.GetDetail(App.Session.SessionID, idEmpresa, True)
            'Cargar paquete de información de sucursal
            MsgWorking.SetProgress("Cargando información de la sucursal...", 20)
            Dim sucursalFac As New SucursalFacade
            Dim Sucursal As SucursalInfo = sucursalFac.GetDetail(App.Session.SessionID, idSucursal, True)

            App.InitSystem(App.Session, "Pixkua Restaurante", Sucursal, Empresa)
        Catch ex As Exception
            Throw ex
        Finally
            MsgWorking.Close()
        End Try
    End Sub

    Private Sub SaveLogin(ByVal user As String, ByVal company As Integer, ByVal site As Integer)
        'Actualiza el Último usuario y Compañia a donde ingreso el usuario
        'de éste equipo.
        Registry.setValue("Login", "User", user)
        Registry.setValue("Login", "Site", site.ToString)
        Registry.setValue("Login", "Company", company.ToString)
    End Sub

    Private Sub LoadLastLogin()
        'Obtiene el último usuario y compañia a donde se ingresó en éste equipo.
        LastUser = Registry.getValue("Login", "User", "")
        LastSite = CInt(Registry.getValue("Login", "Site", "1"))
        LastCompany = CInt(Registry.getValue("Login", "Company", "1"))
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            LoadLastLogin()
            If LastUser.Trim = String.Empty Then
                btnUser.Text = "admin"
            Else
                btnUser.Text = LastUser
            End If
            btnPass.Focus()
        Catch Exc As Exception
            MsgInfo.Show(Exc)
        End Try
    End Sub
End Class