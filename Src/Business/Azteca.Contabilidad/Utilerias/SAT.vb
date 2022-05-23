Imports Chilkat

Public Class SATService
    Private Connection As IDbConnection
    Private Transaction As IDbTransaction
    Private Session As SessionInfo
    Protected SessionID As Guid

#Region "Constructores"

    Public Sub New(ByVal sessionID As GUID, ByVal connection As IDbConnection, ByVal transaction As IDbTransaction)
        Me.SessionID = SessionID
        Me.Connection = connection
        Me.Transaction = transaction
        Session = Azteca.Kernel.Server.Sessions(sessionID)
    End Sub

#End Region

    Public Sub GuardarFoliosAutorizados()
        Try
            Dim Folios As String = DescargarArchivoFolios()
            'Eliminar datos de la tabla de folios
            Dim spTruncate As New StoredProcedure("Purchasing", "CFDFoliosDEL", Connection, Transaction)
            spTruncate.Execute()
            'Insertar nuevos datos en tabla
            Dim Lineas() As String = Folios.Split(New Char() {ControlChars.NewLine})
            For Each Linea As String In Lineas
                Dim Campos() As String = Linea.Split(New Char() {"|"c})
                If Campos(0) = "RFC" Or Linea.Trim = String.Empty Then Continue For
                Dim RFC As String = Campos(0)
                Dim NumAprobacion As Integer = CInt(Campos(1))
                Dim AnioAprobacion As Integer = CInt(Campos(2))
                Dim Serie As String = Campos(3)
                Dim FolioIni As Integer = CInt(Campos(4))
                Dim FolioFin As Integer = CInt(Campos(5))
                'Actualizar folio en la base de datos
                Dim spInsert As New StoredProcedure("Purchasing", "CFDFoliosUPD", Connection, Transaction)
                spInsert.Parameters.Add("@RFC", DbType.String).Value = RFC.Trim
                spInsert.Parameters.Add("@NumAprobacion", DbType.Int32).Value = NumAprobacion
                spInsert.Parameters.Add("@AnioAprobacion", DbType.Int32).Value = AnioAprobacion
                spInsert.Parameters.Add("@Serie", DbType.String).Value = Serie.Trim
                spInsert.Parameters.Add("@FolioInicial", DbType.Int32).Value = FolioIni
                spInsert.Parameters.Add("@FolioFinal", DbType.Int32).Value = FolioFin
                spInsert.Parameters.Add("@FechaTransaccion", DbType.DateTime).Value = Date.Today
                spInsert.Execute()
            Next
            Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.SetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "UtimaActualizacion", Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el archivo de folios autorizados por el SAT.", ex)
        End Try
    End Sub

    Public Sub GuardarCertificados()
        Try
            Dim Certificados As String = DescargarArchivoCertificados()
            'Eliminar datos de la tabla de folios
            Dim spTruncate As New StoredProcedure("Purchasing", "CFDCertificadosDEL", Connection, Transaction)
            spTruncate.Execute()
            'Insertar nuevos datos en tabla
            Dim Lineas() As String = Certificados.Split(New Char() {Chr(10)})
            For Each Linea As String In Lineas
                Dim Campos() As String = Linea.Split(New Char() {"|"c})
                If Campos(0) = "no_serie" Or Linea.Trim = String.Empty Then Continue For
                Dim NumSerie As String = Campos(0)
                Dim FechaIni As Date = CDate(Campos(1))
                Dim FechaFin As Date = CDate(Campos(2))
                Dim RFC As String = Campos(3)
                Dim Estatus As String = Campos(4)
                'Actualizar folio en la base de datos
                Dim spInsert As New StoredProcedure("Purchasing", "CFDCertificadosUPD", Connection, Transaction)
                spInsert.Parameters.Add("@NumSerie", DbType.String).Value = NumSerie.Trim
                spInsert.Parameters.Add("@FechaIni", DbType.DateTime).Value = FechaIni
                spInsert.Parameters.Add("@FechaFin", DbType.DateTime).Value = FechaFin
                spInsert.Parameters.Add("@RFC", DbType.String).Value = RFC.Trim
                spInsert.Parameters.Add("@Estatus", DbType.String).Value = Estatus.Trim
                spInsert.Execute()
            Next
            Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.SetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "UtimaActualizacion", Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el archivo de folios certificados digitales.", ex)
        End Try
    End Sub

    Public Function DescargarArchivoFolios() As String
        Try
            Dim Host, Folder, ArchivoFolios As String
            Host = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "Host")
            Folder = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "Folder")
            ArchivoFolios = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "ArchivoFolios")
            '
            Dim ftp As New Ftp2
            Dim success As Boolean

            '  Any string unlocks the component for the 1st 30-days.
            success = ftp.UnlockComponent("RICARDFTP_QcwNssTElMnO")

            ftp.Hostname = Host
            'ftp.Username = string.empty
            'ftp.Password = string.empty
            ftp.Passive = True

            '  Connect and login to the FTP server.
            success = ftp.Connect()
            If Not success Then Throw New Exception(ftp.LastErrorText)

            '  Change to the remote directory where the existing file is located.
            success = ftp.ChangeRemoteDir(Folder)
            If Not success Then Throw New Exception(ftp.LastErrorText)

            '  Download the contents of the remote file into memory.
            Dim TextFolios As String = ftp.GetRemoteFileTextData(ArchivoFolios)
            If TextFolios = String.Empty Then Throw New BusinessException("Error al abrir el archivo de texto del sitio remoto. " & ftp.LastErrorText)
            ftp.Disconnect()
            Return TextFolios
        Catch ex As Exception
            Throw New BusinessException("Error al descargar el archivo de folios autorizados por el SAT.", ex)
        End Try
    End Function

    Public Function DescargarArchivoCertificados() As String
        Try
            Dim Host, Folder, ArchivoCerts As String
            Host = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "Host")
            Folder = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "Folder")
            ArchivoCerts = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Compras/FacturaElectronica/ArchivosSAT", "ArchivoCSD")
            '
            Dim ftp As New Ftp2
            Dim success As Boolean

            '  Any string unlocks the component for the 1st 30-days.
            success = ftp.UnlockComponent("RICARDFTP_QcwNssTElMnO")

            ftp.Hostname = Host
            'ftp.Username = string.empty
            'ftp.Password = string.empty
            ftp.Passive = True

            '  Connect and login to the FTP server.
            success = ftp.Connect()
            If Not success Then Throw New Exception(ftp.LastErrorText)

            '  Change to the remote directory where the existing file is located.
            success = ftp.ChangeRemoteDir(Folder)
            If Not success Then Throw New Exception(ftp.LastErrorText)

            '  Download the contents of the remote file into memory.
            Dim TextCertificados As String = ftp.GetRemoteFileTextData(ArchivoCerts)
            If TextCertificados = String.Empty Then Throw New BusinessException("Error al abrir el archivo de texto del sitio remoto. " & ftp.LastErrorText)
            ftp.Disconnect()
            Return TextCertificados
        Catch ex As Exception
            Throw New BusinessException("Error al descargar el archivo de certificados digitales autorizados por el SAT.", ex)
        End Try
    End Function


    Public Function ValidarFolio(ByVal rfc As String, ByVal numeroAprobacion As Integer, ByVal anioAprobacion As Integer, ByVal serie As String, ByVal folio As Integer) As Boolean
        Try
            Dim fxValidar As New FunctionSQL("Purchasing", "fxCFDFolioValido", Connection, Transaction)
            fxValidar.Parameters.Add("@RFC", DbType.String).Value = rfc
            fxValidar.Parameters.Add("@NumAprobacion", DbType.Int32).Value = numeroAprobacion
            fxValidar.Parameters.Add("@AnioAprobacion", DbType.Int32).Value = anioAprobacion
            fxValidar.Parameters.Add("@Serie", DbType.String).Value = serie
            fxValidar.Parameters.Add("@Folio", DbType.Int32).Value = folio
            Return CBool(fxValidar.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al validar el folio de comprobante digital.", ex)
        End Try
    End Function

    Public Function GetCertificadoInfo(ByVal rfc As String, ByVal numeroSerie As String) As DataTable
        Try
            Dim fxCert As New FunctionSQL(" Purchasing", "fxCFDCertificadosSEL", Connection, Transaction)
            fxCert.Parameters.Add("@RFC", DbType.String).Value = rfc
            fxCert.Parameters.Add("@NumSerie", DbType.String).Value = numeroSerie
            Dim dtInfo As DataTable = fxCert.GetTable("Certificado")
            Return dtInfo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del certificado.", ex)
        End Try
    End Function

End Class



Public Class SATFacade
    Inherits Azteca.Kernel.RemoteObject

    Private Connection As IDbConnection
    Private Transaction As IDbTransaction

#Region "Metodos Privados"
    Private Sub HandleException(ByVal ex As Exception)
        Azteca.Kernel.General.AppEventLog.LogException(ex)
        Throw ex
    End Sub

    Private Sub ValidateSession(ByVal sessionID As GUID)

    End Sub
#End Region

    Public Sub GuardarFoliosAutorizados(ByVal sessionID As GUID)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim svc As New SATService(sessionID, Connection, Transaction)
                svc.GuardarFoliosAutorizados()
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub GuardarCertificados(ByVal sessionID As GUID)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim svc As New SATService(sessionID, Connection, Transaction)
                svc.GuardarCertificados()
                DataServices.CommitTransaction(Transaction)
            Catch ex As Exception
                DataServices.RollbackTransaction(Transaction)
                Throw ex
            End Try
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
    End Sub


End Class