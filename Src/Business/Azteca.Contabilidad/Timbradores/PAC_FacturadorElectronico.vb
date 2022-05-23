Imports System.Xml
Imports Chilkat

Public Class PAC_FacturadorElectronico
    Implements ITimbrador

    Private Shared _RFC, _Usuario, _Password As String

    Public Sub Cancelar(UUID As String, rfcEmisor As String, Certificado As CertificadoInfo) Implements ITimbrador.Cancelar
        Dim xml As String = GetXmlCancelCFDI(rfcEmisor, Certificado, UUID)
        Dim ws As New FacturadorElectronico.wsTimbradoSoapClient
        Dim Result As System.Xml.Linq.XElement = ws.cancelarComprobante(xml, _Usuario, _Password)
        If CBool(Result.Attribute("esValido").Value) Then
            Dim Folios As System.Xml.Linq.XElement = CType(Result.FirstNode, System.Xml.Linq.XElement)
            Dim Folio As System.Xml.Linq.XElement = CType(Folios.FirstNode, System.Xml.Linq.XElement)
            Dim Estatus As String = Folio.Attribute("Estatus").Value
            If Estatus <> "201" Then
                Dim Message As String = ""
                Select Case Estatus
                    Case "202"
                        Message = "El folio UUID del CFDI ha sido previamente cancelado."
                    Case "203"
                        Message = "El folio UUID del CFDI no fue encontrado"
                    Case "204"
                        Message = "El folio UUID no es aplicable para ser cancelado"
                    Case "205"
                        Message = "El folio UUID del CFDI aun no ha sido enviado al SAT"
                End Select
                Throw New BusinessException("Error al cancelar el comprobante fiscal: " & UUID & ". " & Message & ". Código Error: " & Estatus)
            End If
        Else
            Throw New BusinessException("Error al cancelar el comprobante fiscal: " & UUID & ". " & GetErrores(CType(Result.FirstNode, System.Xml.Linq.XElement)))
        End If
    End Sub

    Public Sub IniciarSersion(rfc As String, usuario As String, password As String) Implements ITimbrador.IniciarSersion
        _RFC = rfc
        _Usuario = usuario
        _Password = password
    End Sub

    Private Function GetErrores(errores As System.Xml.Linq.XElement) As String
        Dim ErrorText As New System.Text.StringBuilder()
        For Each xError As System.Xml.Linq.XElement In errores.Elements
            ErrorText.Append(xError.Attribute("codigo").Value & "-" & xError.Attribute("mensaje").Value)
            ErrorText.Append(ControlChars.NewLine)
        Next
        Return ErrorText.ToString()
    End Function

    Public Function Timbrar(comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo Implements ITimbrador.Timbrar
        Dim xml As String = comprobante.GetXMLString(FormatoCFD.CFDI)
        Dim ws As New FacturadorElectronico.wsTimbradoSoapClient
        Dim Result As System.Xml.Linq.XElement = ws.obtenerTimbrado(xml, _Usuario, _Password)
        If CBool(Result.Attribute("esValido").Value) Then
            Dim Timbre As System.Xml.Linq.XElement = CType(Result.FirstNode, System.Xml.Linq.XElement)
            comprobante.TimbreFiscal._Version = Timbre.Attribute("version").Value
            comprobante.TimbreFiscal._SelloSAT = Timbre.Attribute("selloSAT").Value
            comprobante.TimbreFiscal._SelloCFD = Timbre.Attribute("selloCFD").Value
            comprobante.TimbreFiscal._NumeroCertificadoSAT = Timbre.Attribute("noCertificadoSAT").Value
            comprobante.TimbreFiscal._UUID = Timbre.Attribute("UUID").Value
            comprobante.TimbreFiscal._Fecha = CDate(Timbre.Attribute("FechaTimbrado").Value)
            Return comprobante
        Else
            Throw New BusinessException("Error al timbrar el comprobante fiscal. " & GetErrores(CType(Result.FirstNode, System.Xml.Linq.XElement)))
        End If

    End Function

    Private Function GetXmlCancelCFDI(rfcEmisor As String, Certificado As CertificadoInfo, UUID As String) As String
        'Cargar certificado
        Dim CacheKey As String = "comprobante_Cert_" & Certificado.Identity.ToString()
        Dim Certificate As New Cert
        If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
            Certificate = New Cert
            Certificate.LoadFromBinary(Certificado.Certificado)
            Azteca.Kernel.Cache.Add(CacheKey, Certificate, TimeSpan.FromDays(1))
        Else
            Certificate = CType(Azteca.Kernel.Cache.Item(CacheKey), Cert)
        End If

        'Obtener llave privada
        Dim success As Boolean = True
        Dim PKCacheKey As String = "Factura_PrivateKey_Base64_" & Certificado.Identity.ToString()
        Dim PrivateKeyEncoded As String = String.Empty
        If Azteca.Kernel.Cache.Item(PKCacheKey) Is Nothing Then
            Dim PK As New PrivateKey()
            success = PK.LoadPkcs8Encrypted(Certificado.LlavePrivada, Certificado.PasswordPrivateKey)
            If Not success Then Throw New BusinessException("Error al cargar la llave privada (modo encriptado) para facturación")            
            Dim PrivateKeyXML As String = PK.GetXml()
            '
            Dim Encoder As New Crypt2()
            Encoder.UnlockComponent("RICARDCrypt_mCog8gVULGne")
            PrivateKeyEncoded = Encoder.EncodeString(PrivateKeyXML, "utf-8", "base64")
            If Not success Then Throw New BusinessException("Error al convertir la llave privada a base64.")
            'Transformar a xml
            Azteca.Kernel.Cache.Add(PKCacheKey, PrivateKeyEncoded, TimeSpan.FromDays(1))
        Else
            PrivateKeyEncoded = CStr(Azteca.Kernel.Cache.Item(PKCacheKey))
        End If

        'armamos el XML
        Dim cancelacionXML As New System.Xml.XmlDocument
        Dim ns As String = String.Empty
        Dim nsManager As New XmlNamespaceManager(cancelacionXML.NameTable)
        nsManager.AddNamespace("CancelacionOrigen", ns)

        cancelacionXML.LoadXml("<?xml version='1.0' encoding='utf-8'?>" & ControlChars.CrLf & "<Cancelacion></Cancelacion>")
        Dim Cancelacion As XmlElement = CType(cancelacionXML.SelectSingleNode("/Cancelacion", nsManager), XmlElement)
        With Cancelacion
            .SetAttribute("rfcEmisor", rfcEmisor)
            .SetAttribute("certificado", Certificate.GetEncoded().Replace(ControlChars.NewLine, String.Empty))
            .SetAttribute("llaveCertificado", PrivateKeyEncoded)
        End With

        Dim Folios As XmlElement = cancelacionXML.CreateElement("Folios", ns)
        Dim Folio As XmlElement = cancelacionXML.CreateElement("Folio", ns)
        Folio.SetAttribute("UUID", UUID.ToString)
        Folios.AppendChild(Folio)

        Cancelacion.AppendChild(Folios)

        Dim xmlText As New System.Text.StringBuilder
        Dim writer As New StringWriterWithEncoding(xmlText, New System.Text.UTF8Encoding())
        cancelacionXML.Save(writer)
        Dim xmlString As String = xmlText.ToString
        Return xmlString
    End Function

End Class
