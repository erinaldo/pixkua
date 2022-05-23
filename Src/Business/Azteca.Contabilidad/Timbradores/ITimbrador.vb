Public Interface ITimbrador

    Sub IniciarSersion(rfc As String, usuario As String, password As String)
    Function Timbrar(comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo
    Sub Cancelar(UUID As String, rfcEmisor As String, Certificado As CertificadoInfo)

End Interface
