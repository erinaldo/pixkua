Imports System.Xml.Linq
Imports System.Xml
Imports System.IO
Imports System.Text
Imports Chilkat

Public Class PAC_AztecaSoftware
    Implements ITimbrador
    Private Shared _RFC, _Usuario, _Password, _SessionID As String

    Private Function GetError(messageError As String) As String
        Dim strError As New StringBuilder()
        Dim Reader As New StringReader(messageError)
        Dim XError As XElement = XElement.Load(Reader)
        Return XError.Value
    End Function

    Public Sub Cancelar(UUID As String, rfcEmisor As String, Certificado As CertificadoInfo) Implements ITimbrador.Cancelar
        'Cargar certificado
        Dim Certificate As New Cert
        Certificate = New Cert
        Certificate.LoadFromBinary(Certificado.Certificado)

        'Obtener llave privada
        Dim success As Boolean = True
        Dim PrivateKeyEncoded As String = String.Empty
        Dim PK As New PrivateKey()
        success = PK.LoadPkcs8Encrypted(Certificado.LlavePrivada, Certificado.PasswordPrivateKey)
        If Not success Then Throw New BusinessException("Error al cargar la llave privada (modo encriptado) para facturación")
        Dim PrivateKeyXML As String = PK.GetXml()
        '
        Dim Encoder As New Crypt2()
        Encoder.UnlockComponent("RICARDCrypt_mCog8gVULGne")
        PrivateKeyEncoded = Encoder.EncodeString(PrivateKeyXML, "utf-8", "base64")
        If Not success Then Throw New BusinessException("Error al convertir la llave privada a base64.")

        'El servicio permite cancelar mas de un folio a la vez, pero éste metodo solo cancela uno a la vez
        Dim Folios As New AztecaSoftwareCFDI.ArrayOfString()
        Folios.Add(UUID)
        'Enviar solicitud de cancelación de folio
        Try
            Dim Service As New AztecaSoftwareCFDI.ServiceSoapClient()
            Dim Result As String = Service.Cancelar(_SessionID, Folios, rfcEmisor, Certificate.GetEncoded().Replace(ControlChars.NewLine, String.Empty), PrivateKeyEncoded, Certificado.PasswordPrivateKey)
            If Result.StartsWith("<Error>") Then
                Throw New Exception(GetError(Result))
            End If
        Catch ex As Exception
            Throw New Exception("Error al cancelar el folio fiscal", ex)
        End Try
    End Sub

    Public Sub IniciarSersion(rfc As String, usuario As String, password As String) Implements ITimbrador.IniciarSersion
        _RFC = rfc
        _Usuario = usuario
        _Password = password
        Dim Service As New AztecaSoftwareCFDI.ServiceSoapClient()
        Try
            Dim Result As String = Service.IniciarSesion(_Usuario, _Password)

            If Result.StartsWith("<Error>") Then
                Throw New Exception(GetError(Result))
            Else
                _SessionID = Result
            End If
        Catch ex As Exception
            Throw New Exception("Error al iniciar sesión", ex)
        End Try
    End Sub

    Public Function Timbrar(comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo Implements ITimbrador.Timbrar
        Try
            'Enviar xml a servicio web de timbrado
            Dim Service As New AztecaSoftwareCFDI.ServiceSoapClient()            
            'Si se está utilizando el usuario de prueba, modificar rfc del emisor a goya780416gm0
            If _Usuario.Trim.ToLower = "test" Then                
                Service.Endpoint.ListenUri = New Uri("http://cfditest.azurewebsites.net/service.asmx")
            Else
                Service.Endpoint.ListenUri = New Uri("http://cfdi.azurewebsites.net/service.asmx")
            End If
            'Obtener el comprobante como una cadena xml
            Dim xml As String = comprobante.GetXMLString(FormatoCFD.CFDI)
            Dim Result As String = Service.Timbrar(_SessionID, xml)
            If Not Result.StartsWith("<Error>") Then
                'Cargar xml en instancia xml document
                Dim xmlComprobante As New XmlDocument
                xmlComprobante.LoadXml(Result)
                Dim nsManager As New XmlNamespaceManager(xmlComprobante.NameTable)
                nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/3")
                nsManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
                'Cargar información del timbre fiscal en objeto comprobante fiscal
                Dim TimbreFiscal As XmlElement = CType(xmlComprobante.SelectSingleNode("/cfd:Comprobante/cfd:Complemento/tfd:TimbreFiscalDigital", nsManager), XmlElement)
                With comprobante.TimbreFiscal
                    ._Version = TimbreFiscal.GetAttribute("version")
                    ._UUID = TimbreFiscal.GetAttribute("UUID")
                    ._Fecha = CDate(TimbreFiscal.GetAttribute("FechaTimbrado"))
                    ._SelloCFD = TimbreFiscal.GetAttribute("selloCFD")
                    ._NumeroCertificadoSAT = TimbreFiscal.GetAttribute("noCertificadoSAT")
                    ._SelloSAT = TimbreFiscal.GetAttribute("selloSAT")
                End With
                Return comprobante
            Else
                Throw New Exception(GetError(Result) & " XML Enviado: " & xml)
            End If
        Catch ex As Exception
            Throw New Exception("Error al timbrar el comprobante fiscal.", ex)
        End Try
    End Function

End Class
