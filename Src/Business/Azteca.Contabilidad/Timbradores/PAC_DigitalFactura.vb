Public Class PAC_DigitalFactura
    Implements ITimbrador

    Private Shared SessionID As String = String.Empty


    Public Sub Cancelar(UUID As String, rfcEmisor As String, Certificado As CertificadoInfo) Implements ITimbrador.Cancelar
    End Sub

    Public Sub IniciarSersion(rfc As String, usuario As String, password As String) Implements ITimbrador.IniciarSersion
        Dim ws As New DigitalFactura.Timbrar.FuncionesGeneralesFacPortTypeClient()
        Dim ID As String = ws.fnIniciaSesion(rfc, usuario, password)
        SessionID = ID.Substring(2)
    End Sub

    Public Function Timbrar(comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo Implements ITimbrador.Timbrar
        Dim ws As New DigitalFactura.Timbrar.FuncionesGeneralesFacPortTypeClient
        Dim xml As String = comprobante.GetXMLString(FormatoCFD.CFDI)
        Dim xmlTimbrado As String = ws.Generartimbre(xml, SessionID)
        Return comprobante
    End Function
End Class
