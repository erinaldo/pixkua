Partial Class CertificadoService

    Public Function LoadList(ByVal idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxCFDCertificadosCBO", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            Dim dtList As DataTable = fxList.GetTable("Certificados")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de certificados.", ex)
        End Try
    End Function

    Public Function GetDetailFromCache(ByVal idCertificado As Integer) As CertificadoInfo
        Try
            'Obtener información del certificado y su llave privada
            Dim CertCacheKey As String = "CertificadoCFD_" & idCertificado.ToString
            Dim CertificadoInf As New CertificadoInfo(sessionID)
            'Verificar si el certificado ya existe en caché
            If Azteca.Kernel.Cache.Item(CertCacheKey) Is Nothing Then
                Dim CertificadoSvc As New CertificadoService(sessionID, Connection, Transaction)
                CertificadoSvc.GetDetail(idCertificado, CertificadoInf, False)
                Azteca.Kernel.Cache.Add(CertCacheKey, CertificadoInf, TimeSpan.FromDays(7))
            Else
                CertificadoInf = CType(Azteca.Kernel.Cache.Item(CertCacheKey), CertificadoInfo)
            End If
            Return CertificadoInf
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el certificado digitial del caché", ex)
        End Try
    End Function

End Class



Partial Class CertificadoFacade

    Public Function LoadList(ByVal sessionID As GUID, ByVal idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New CertificadoService(sessionID, Connection, Transaction)
            dtList = Svc.LoadList(idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Sub RegistroUsuarioCFDI(ByVal sessionID As Guid, ByVal usuario As String, contrasena As String)
        ValidateSession(sessionID)
        Try
            If isUserValidCFDI(usuario, contrasena) Then
                Connection = DataServices.OpenConnection
                Dim Svc As New CertificadoService(sessionID, Connection, Transaction)

                Dim Registro As Boolean = CBool(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/RegistroUserCFDI", "Registrado"))
                Dim User As String = CStr(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/RegistroUserCFDI", "Usuario"))
                Dim Pwd As String = CStr(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/RegistroUserCFDI", "Password"))

                'Si se esta registrando el mismo, no afectamos nada
                If Not Registro And usuario = User And contrasena = Pwd Then
                    Exit Sub
                End If

                'Guardarlo en el primer timbrador
                Dim TimbradorSvc As New TimbradorService(sessionID, Me.Connection)
                Dim Timbrador As New TimbradorInfo(sessionID)
                TimbradorSvc.GetDetail(1, Timbrador, False)
                Timbrador.Usuario = usuario
                Timbrador.Password = contrasena
                TimbradorSvc.Update(Timbrador)

                Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.SetValue("Configuracion/RegistroUserCFDI", "Registrado", "1")
                Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.SetValue("Configuracion/RegistroUserCFDI", "Usuario", usuario)
                Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.SetValue("Configuracion/RegistroUserCFDI", "Password", contrasena)
            End If
        Catch ex As Exception
            HandleException(ex)
        Finally
            'DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Private Function isUserValidCFDI(usuario As String, password As String) As Boolean
        Dim svc As New AztecaSoftwareCFDI.ServiceSoapClient
        Dim Llave As String = svc.IniciarSesion(usuario, password)

        If Llave.StartsWith("<Error>") Then
            Dim ex As New Exception(Llave)
            Throw New BusinessException("El usuario no se ha podido validar en la base de datos de Timbrado Electrónico", ex)
        End If

        Return True
    End Function

End Class
