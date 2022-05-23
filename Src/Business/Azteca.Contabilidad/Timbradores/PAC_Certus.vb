Imports System.Xml
Imports Chilkat

Public Class PAC_Certus
    Implements ITimbrador
    Private Shared _RFC, _Usuario, _Password As String
    Private Shared _IdServicio As Integer

    Public Sub Cancelar(UUID As String, rfcEmisor As String, Certificado As CertificadoInfo) Implements ITimbrador.Cancelar
        Try
            Dim Certificate As Cert = New Cert
            Certificate.LoadFromBinary(Certificado.Certificado)
            Dim PK As New PrivateKey()
            Dim success As Boolean = PK.LoadPkcs8Encrypted(Certificado.LlavePrivada, Certificado.PasswordPrivateKey)
            If Not success Then Throw New BusinessException("Error al cargar la llave privada (modo encriptado) para facturación")            
            Dim PrivateKeyBytes As Byte() = PK.GetPkcs8()
            '
            Dim Encoder As New Crypt2()
            Encoder.UnlockComponent("RICARDCrypt_mCog8gVULGne")
            Dim PrivateKeyEncoded As String = Encoder.Encode(PrivateKeyBytes, "base64")
            If Not success Then Throw New BusinessException("Error al convertir la llave privada a base64.")

            Dim TimbradoSvc As New Certus.Timbrado.WsEmisionTimbradoClient()
            Dim UUIDArray As String() = New String() {UUID}
            Azteca.Kernel.General.AppEventLog.WriteEntry("Cancelando CFDI " & UUID & " - Key base 64: " & PrivateKeyEncoded, Kernel.General.EventLogType.Information)
            Dim CancelacionInf As Certus.Timbrado.wsResponseBO = TimbradoSvc.Cancelar(_Usuario, _Password, UUIDArray, PrivateKeyEncoded)
            If CancelacionInf.isError Then
                Throw New BusinessException("Error al cancelar el comprobante fiscal. " & CancelacionInf.message)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error en la cancelación de timbrado.", ex)
        End Try
    End Sub

    Public Sub IniciarSersion(rfc As String, usuario As String, password As String) Implements ITimbrador.IniciarSersion
        Dim LoginSvc As New Certus.Servicios.WsServiciosClient()
        Dim LoginInf As Certus.Servicios.wsServicioBO = LoginSvc.obtenerServicios(usuario, password)
        If LoginInf.array IsNot Nothing Then
            _RFC = rfc
            _Usuario = usuario
            _Password = password
            _IdServicio = LoginInf.array(0).idProcess
        Else
            Throw New BusinessException("Error al iniciar sesión en el servicio de timbrado. " & LoginInf.mensaje)
        End If
    End Sub

    Public Function Timbrar(comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo Implements ITimbrador.Timbrar
        Try

            Dim xml As String = comprobante.GetXMLString(FormatoCFD.CFDI)
            Dim Encoder As New System.Text.UTF8Encoding()
            Dim ComprobanteBuffer As Byte() = Encoder.GetBytes(xml)
            '
            Dim TimbradoSvc As New Certus.Timbrado.WsEmisionTimbradoClient()            
            Dim TimbradoInf As Certus.Timbrado.wsResponseBO = TimbradoSvc.EmitirTimbrar(_Usuario, _Password, _IdServicio, ComprobanteBuffer)
            If Not TimbradoInf.isError Then
                Dim xmlResult As String = Encoder.GetString(TimbradoInf.XML)
                xmlResult = xmlResult.Remove(0, xmlResult.IndexOf(">") + 1)
                Dim ComprobanteXML As New XmlDocument()
                ComprobanteXML.LoadXml(xmlResult)
                Dim nsManager As New XmlNamespaceManager(ComprobanteXML.NameTable)
                nsManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
                nsManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
                'Obtener nodo correspondiente al timbre fiscal
                Dim Timbre As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/tfd:TimbreFiscalDigital", nsManager), XmlElement)
                comprobante.TimbreFiscal._Version = Timbre.GetAttribute("version")
                comprobante.TimbreFiscal._SelloSAT = Timbre.GetAttribute("selloSAT")
                comprobante.TimbreFiscal._SelloCFD = Timbre.GetAttribute("selloCFD")
                comprobante.TimbreFiscal._NumeroCertificadoSAT = Timbre.GetAttribute("noCertificadoSAT")
                comprobante.TimbreFiscal._UUID = Timbre.GetAttribute("UUID")
                comprobante.TimbreFiscal._Fecha = CDate(Timbre.GetAttribute("FechaTimbrado"))

                Return comprobante
            Else
                Throw New BusinessException("Error en el proceso de timbrado: " & TimbradoInf.message)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al timbrar el comprobante fiscal. ", ex)
        End Try
    End Function

    Private Function GetXMLFile() As String
        Dim Reader As System.IO.TextReader = System.IO.File.OpenText("C:\Publica\VERSION_3_2_sin_sello.xml")
        Dim Content As String = Reader.ReadToEnd()
        Reader.Close()
        Return Content
    End Function

End Class
