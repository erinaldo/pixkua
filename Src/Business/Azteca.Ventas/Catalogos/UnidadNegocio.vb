Partial Class UnidadNegocioService

    Public Function ExistsByIdSucursal(ByVal idSucursal As Integer) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Sales", "fxUnidadesNegocioExistsByIdSucursal", Connection, Transaction)
            fxExists.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la existencia de la unidad de negocio.", ex)
        End Try
    End Function

    Public Function GetDetailByIdSucursal(ByVal idSucursal As Integer) As UnidadNegocioInfo
        Try
            Dim fxGetID As New FunctionSQL("Sales", "fxSucursalUnidadNegocioID", Connection, Transaction)
            fxGetID.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            Dim IdUnidad As Integer = CInt(fxGetID.GetScalar)
            'Verificar que la sucursal sea una unidad de negocios
            If IdUnidad > 0 Then
                Dim UnidadInf As New UnidadNegocioInfo(sessionID)
                Dim UnidadSvc As New UnidadNegocioService(sessionID, Connection, Transaction)
                UnidadSvc.GetDetail(IdUnidad, UnidadInf, False)
                Return UnidadInf
            Else
                Throw New BusinessException("La sucursal especificada no contiene una unidad de negocios.")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la información de la unidad de negocio.", ex)
        End Try
    End Function

    Public Function GetDetailFromCacheByIdSucursal(ByVal idSucursal As Integer) As UnidadNegocioInfo
        Dim CacheKey As String = "UnidadNegocioSucursal" & idSucursal
        Try
            Dim UnidadInf As New UnidadNegocioInfo(sessionID)
            If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
                Dim UnidadSvc As New UnidadNegocioService(sessionID, Connection, Transaction)
                UnidadInf = UnidadSvc.GetDetailByIdSucursal(idSucursal)
                Azteca.Kernel.Cache.Add(CacheKey, UnidadInf, TimeSpan.FromDays(1))
            Else
                UnidadInf = CType(Azteca.Kernel.Cache.Item(CacheKey), UnidadNegocioInfo)
            End If
            Return UnidadInf
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la unidad de negocio desde el caché de sistema.", ex)
        End Try
    End Function


End Class


Partial Class UnidadNegocioFacade


    Public Function ExistsByIdSucursal(ByVal sessionID As GUID, ByVal idSucursal As Integer) As Boolean
        ValidateSession(sessionID)
        Dim Exists As Boolean = False
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UnidadNegocioService(sessionID, Connection)
            Exists = Svc.ExistsByIdSucursal(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Exists
    End Function

    Public Function GetDetailByIdSucursal(ByVal sessionID As GUID, ByVal idSucursal As Integer) As UnidadNegocioInfo
        ValidateSession(sessionID)
        Dim UnidadInf As UnidadNegocioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UnidadNegocioService(sessionID, Connection)
            UnidadInf = Svc.GetDetailByIdSucursal(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return UnidadInf
    End Function

    Public Function GetDetailFromCacheByIdSucursal(ByVal sessionID As GUID, ByVal idSucursal As Integer) As UnidadNegocioInfo
        ValidateSession(sessionID)
        Dim UnidadInf As UnidadNegocioInfo = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New UnidadNegocioService(sessionID, Connection)
            UnidadInf = Svc.GetDetailFromCacheByIdSucursal(idSucursal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return UnidadInf
    End Function


    Public Sub ConfiguracionEmpresaSave(sessionID As Guid, Empresa As EmpresaInfo, Sucursal As SucursalInfo, Certificado As Azteca.Business.Contabilidad.CertificadoInfo, Serie As Azteca.Business.Contabilidad.SerieInfo, _
                                        AnioAprobacion As Integer, NumAprobacion As Integer, FolioInicial As Integer, FolioFinal As Integer, RegimenFiscal As String)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = Connection.BeginTransaction
                'Guardamos la empresa
                Dim EmpresaSvc As New EmpresaService(sessionID, Connection, Transaction)
                Dim IdEmpresa As Integer = EmpresaSvc.Update(Empresa)
                'Guardamos la sucursal/Unidad de Negocio
                Dim UnidadNegocioSvc As New UnidadNegocioService(sessionID, Connection, Transaction)
                Dim UnidadNegocioInf As New UnidadNegocioInfo(sessionID)
                If CBool(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/InicioExpress", "Inicio")) Then
                    UnidadNegocioSvc.GetDetail(1, UnidadNegocioInf, True)
                    UnidadNegocioSvc.InizializacionSistema = True
                End If

                'EmpresaConfigInfo
                Dim EmpresaConfigSvc As New Azteca.Business.Contabilidad.EmpresaConfigService(sessionID, Me.Connection, Me.Transaction)
                Dim EmpresaConfigInf As Azteca.Business.Contabilidad.EmpresaConfigInfo = EmpresaConfigSvc.GetDetail(IdEmpresa)
                EmpresaConfigInf.IdTimbrador = 1 : EmpresaConfigInf.RegimenFiscal = RegimenFiscal
                EmpresaConfigSvc.Update(EmpresaConfigInf)

                With UnidadNegocioInf
                    .AfectarInventario = False
                    .AfectarInventarioLinea = True
                    .EnviarFacturas = True
                    .FacturacionElectronica = True
                    .GLN = ""
                    '.IdAlmacen = 0
                    .IdClienteFacturacion = 0
                    .IdClienteGenerico = 0
                    .IdDivisaBase = CInt(Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Contabilidad/Divisas", "Base"))
                    .IdFormatoDevoluciones = 2
                    .IdFormatoFacturas = 1
                    '.IdFormatoTicketComanda = 0
                    '.IdFormatoTicketPedimento = 0
                    '.IdFormatoTicketPOS = 0
                    '.IdRegion = 0
                    '.IdOperador = 0
                    .IdRemitente = 1
                    '.IdSerieDevoluciones = 0
                    '.IdSerieFacturas = 0
                    .IdZonaVenta = 0
                    .Nombre = Sucursal.Nombre
                    .NotificarFacturas = False
                    .NotificarFoliosTerminar = False
                    .PorcentajeFolios = 0
                    .SerieFacturas = ""
                    .Sucursal.Calle = Sucursal.Calle
                    .Sucursal.Colonia = Sucursal.Colonia
                    .Sucursal.Correo = Sucursal.Correo
                    .Sucursal.CP = Sucursal.CP
                    .Sucursal.Fax = Sucursal.Fax
                    .Sucursal.IdEmpresa = IdEmpresa
                    .Sucursal.IdPoblacion = Sucursal.IdPoblacion
                    .Sucursal.IdSucursal = 0
                    .Sucursal.Nombre = Sucursal.Nombre
                    .Sucursal.NombreLargo = Sucursal.NombreLargo
                    .Sucursal.NumExt = Sucursal.NumExt
                    .Sucursal.NumInt = Sucursal.NumInt
                    .Sucursal.PaginaWeb = Sucursal.PaginaWeb
                    .Sucursal.Telefono1 = Sucursal.Telefono1
                    .Sucursal.Telefono2 = Sucursal.Telefono2
                    .Sucursal.Status = CatalogState.Active
                    .TipoPrecio = TipoPrecio.ListaPrecio
                    '.UltimaFactura
                    .IdEmpresa = IdEmpresa
                    .Status = CatalogState.Active
                End With

                UnidadNegocioSvc.Update(UnidadNegocioInf)
                Dim IdSucursal = UnidadNegocioInf.Sucursal.Identity

                'Le agregamos una zona de venta
                Dim ZonaVtaSvc As New ZonaVentaService(sessionID, Me.Connection, Me.Transaction)
                Dim ZonaVta As New ZonaVentaInfo(sessionID)
                ZonaVta.IdEmpresa = IdEmpresa : ZonaVta.IdSucursal = IdSucursal : ZonaVta.Nombre = "Zona Venta Gral" : ZonaVta.Status = CatalogState.Active
                Dim idZonaVta As Integer = ZonaVtaSvc.Update(ZonaVta)

                'Guardamos el certificado
                Dim CertificadoSvc As New Azteca.Business.Contabilidad.CertificadoService(sessionID, Connection, Transaction)
                Certificado.IdEmpresa = IdEmpresa : Certificado.IdSucursal = IdSucursal : Certificado.Status = CatalogState.Active
                Dim IdCertificado As Integer = CertificadoSvc.Update(Certificado)
                'Guardar Serie
                Dim SerieSvc As New Azteca.Business.Contabilidad.SerieService(sessionID, Connection, Transaction)
                Serie.IdCertificado = IdCertificado : Serie.IdSucursal = IdSucursal : Serie.IdEmpresa = IdEmpresa : Serie.Status = CatalogState.Active
                Dim IdSerie As Integer = SerieSvc.Update(Serie)
                'Registrar Folios para el caso de los Certificados CFD
                'If Certificado.TipoCFD = Contabilidad.FormatoCFD.CFD Then
                SerieSvc.RegistrarFolios(IdSerie, AnioAprobacion, NumAprobacion, FolioInicial, FolioFinal)
                'End If

                'Asignar la serie al Certificado
                CertificadoSvc.GetDetail(IdCertificado, Certificado, False)
                Dim drSerie As Azteca.Business.Contabilidad.CertificadoDS.SeriesRow = Certificado.Series.FindByIdCFDSerie(IdSerie)
                With drSerie
                    .IdCFDSerie = IdSerie
                    .Codigo = IdSerie.ToString
                    .Serie = Serie.Serie
                    .UltimoFolio = FolioInicial
                    .FolioLimite = FolioFinal
                    .Estatus = "Activo"
                End With
                'Certificado.Series.AddSeriesRow(drSerie)
                CertificadoSvc.Update(Certificado) 'Lo volvemos a guardar ya con la serie q le correspondio

                UnidadNegocioSvc.InizializacionSistema = False
                'Asignar a la Unidad de negocio la serie
                UnidadNegocioInf.IdSerieFacturas = IdSerie
                UnidadNegocioInf.IdSerieDevoluciones = IdSerie
                UnidadNegocioInf.IdZonaVenta = idZonaVta
                UnidadNegocioSvc.Update(UnidadNegocioInf)

                'Marcamos el parametro que determina si ya se ha configurado una empresa
                Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.SetValue("Configuracion/InicioExpress", "Inicio", "0")

                Transaction.Commit()
            Catch ex As Exception
                Transaction.Rollback()
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

End Class