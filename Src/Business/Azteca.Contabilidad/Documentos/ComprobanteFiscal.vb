Imports Chilkat
Imports System.IO
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.XPath
Imports System.Xml.Xsl
Imports Azteca.Kernel
Imports Azteca.Kernel.General


#Region "Clases Auxiliares"

<Serializable()> _
Public Class DomicilioInfo

    Public Property Calle() As String = String.Empty

    Public Property NumExt() As String = String.Empty

    Public Property NumInt() As String = String.Empty

    Public Property Colonia() As String = String.Empty

    Public Property Localidad() As String = String.Empty

    Public Property Referencia() As String = String.Empty

    Public Property Municipio() As String = String.Empty

    Public Property Estado() As String = String.Empty

    Public Property Pais() As String = String.Empty

    Public Property CodigoPostal() As String = String.Empty

End Class

<Serializable()> _
Public Class EmisorInfo

    Public Sub New()
        _DomicilioFiscal = New DomicilioInfo
        _LugarExpedicion = New DomicilioInfo
        _RegimenesFiscales = New RegimenFiscalCollection
    End Sub

    Public Property RFC() As String = String.Empty

    Public Property Nombre() As String = String.Empty

    Public Property DomicilioFiscal() As DomicilioInfo

    Public Property LugarExpedicion() As DomicilioInfo

    Public Property RegimenesFiscales As RegimenFiscalCollection

End Class

<Serializable()> _
Public Class ReceptorInfo

    Public Sub New()
        _Domicilio = New DomicilioInfo
        _DomicilioEnvio = New DomicilioInfo
    End Sub


    Public Property RFC As String = String.Empty

    Public Property Nombre As String = String.Empty

    Public Property Domicilio As DomicilioInfo

    Public Property DomicilioEnvio As DomicilioInfo

End Class

<Serializable()> _
Public Class ConceptoInfo

    Public Sub New()
        InformacionAduanera = New InformacionAduaneraCollection
    End Sub

    Public Property Cantidad() As Decimal

    Public Property CantidadConsumo() As Integer

    Public Property Unidad() As String = "No Aplica"

    Public Property IdArticulo() As Integer

    Public Property IdServicio As Integer

    Public Property Codigo() As String = String.Empty

    Public Property EAN() As String = String.Empty

    Public Property Descripcion() As String = String.Empty

    Public Property ValorUnitario() As Decimal

    Public ReadOnly Property Importe() As Decimal
        Get
            Return _ValorUnitario * _Cantidad
        End Get
    End Property

    Public Property PorcentajeImpuestoTrasladado1 As Decimal

    Public Property PorcentajeImpuestoTrasladado2 As Decimal

    Public Property PorcentajeImpuestoTrasladado3 As Decimal

    Public Property MontoImpuestoTrasladado1 As Decimal

    Public Property MontoImpuestoTrasladado2 As Decimal

    Public Property MontoImpuestoTrasladado3 As Decimal

    Public Property PorcentajeImpuestoRetenido1 As Decimal

    Public Property PorcentajeImpuestoRetenido2 As Decimal

    Public Property PorcentajeImpuestoRetenido3 As Decimal

    Public Property MontoImpuestoRetenido1 As Decimal

    Public Property MontoImpuestoRetenido2 As Decimal

    Public Property MontoImpuestoRetenido3 As Decimal

    Public Property PorcentajeDescuento1 As Decimal

    Public Property PorcentajeDescuento2 As Decimal

    Public Property PorcentajeDescuento3 As Decimal

    Public Property PorcentajeDescuento4 As Decimal

    Public Property PorcentajeDescuento5 As Decimal

    Public Property MontoDescuento1 As Decimal

    Public Property MontoDescuento2 As Decimal

    Public Property MontoDescuento3 As Decimal

    Public Property MontoDescuento4 As Decimal

    Public Property MontoDescuento5 As Decimal

    Public Property IdDocumento As String = String.Empty

    Public Property FechaDocumento() As Date

    Public Property Referencia As String = String.Empty

    Public Property InformacionAduanera As InformacionAduaneraCollection

End Class

<Serializable()> _
Public Class InformacionAduanera

    Public Property Numero As String = String.Empty

    Public Property Fecha As Date = Date.Today

    Public Property Aduana As String = String.Empty
End Class

<Serializable()> _
Public Class InformacionAduaneraCollection
    Inherits System.Collections.Generic.List(Of InformacionAduanera)

End Class

<Serializable()> _
Public Class ConceptosCollection
    Inherits System.Collections.Generic.List(Of ConceptoInfo)

End Class

<Serializable()> _
Public Class RegimenFiscalCollection
    Inherits System.Collections.Generic.List(Of String)

End Class

<Serializable()> _
Public Class ImpuestosInfo
    Private _Retenciones As RetencionesCollection
    Private _Traslados As TrasladosCollection

    Public Sub New()
        _Retenciones = New RetencionesCollection
        _Traslados = New TrasladosCollection
    End Sub

    Private Function CalcularTotalTraslados() As Decimal
        Dim Total As Decimal = 0
        For Each traslado As TrasladoInfo In _Traslados
            Total += traslado.Importe
        Next
        Return Total
    End Function

    Private Function CalcularTotalRetenciones() As Decimal
        Dim total As Decimal = 0
        For Each retencion As RetencionCFDInfo In _Retenciones
            total += retencion.Importe
        Next
        Return total
    End Function

    Public ReadOnly Property Retenciones() As RetencionesCollection
        Get
            Return _Retenciones
        End Get
    End Property

    Public ReadOnly Property Traslados() As TrasladosCollection
        Get
            Return _Traslados
        End Get
    End Property

    Public ReadOnly Property TotalRetenciones() As Decimal
        Get
            Return CalcularTotalRetenciones()
        End Get
    End Property

    Public ReadOnly Property TotalTraslados() As Decimal
        Get
            Return CalcularTotalTraslados()
        End Get
    End Property

End Class

<Serializable()> _
Public Class RetencionCFDInfo
    Private _Impuesto As TipoImpuestoRetencion
    Private _Importe As Decimal

    Public Property Impuesto() As TipoImpuestoRetencion
        Get
            Return _Impuesto
        End Get
        Set(ByVal value As TipoImpuestoRetencion)
            _Impuesto = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return _Importe
        End Get
        Set(ByVal value As Decimal)
            _Importe = value
        End Set
    End Property


End Class

<Serializable()> _
Public Class TrasladoInfo
    Private _Impuesto As TipoImpuestoTraslado
    Private _Tasa As Decimal
    Private _Importe As Decimal

    Public Property Impuesto() As TipoImpuestoTraslado
        Get
            Return _Impuesto
        End Get
        Set(ByVal value As TipoImpuestoTraslado)
            _Impuesto = value
        End Set
    End Property

    Public Property Tasa() As Decimal
        Get
            Return _Tasa
        End Get
        Set(ByVal value As Decimal)
            _Tasa = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return _Importe
        End Get
        Set(ByVal value As Decimal)
            _Importe = value
        End Set
    End Property


End Class

<Serializable()> _
Public Class RetencionesCollection
    Inherits System.Collections.Generic.List(Of RetencionCFDInfo)

End Class

<Serializable()> _
Public Class TrasladosCollection
    Inherits System.Collections.Generic.List(Of TrasladoInfo)

End Class

<Serializable()> _
Public Class TimbreFiscalInfo
    Friend _Version As String = String.Empty
    Friend _SelloSAT As String = String.Empty
    Friend _NumeroCertificadoSAT As String = String.Empty
    Friend _UUID As String = String.Empty
    Friend _Fecha As Date = Date.Now
    Friend _SelloCFD As String = String.Empty


    Public ReadOnly Property Version As String
        Get
            Return _Version
        End Get
    End Property

    Public ReadOnly Property SelloSAT As String
        Get
            Return _SelloSAT
        End Get
    End Property

    Public ReadOnly Property NumeroCertificadoSAT As String
        Get
            Return _NumeroCertificadoSAT
        End Get
    End Property

    Public ReadOnly Property UUID As String
        Get
            Return _UUID
        End Get
    End Property

    Public ReadOnly Property Fecha As Date
        Get
            Return _Fecha
        End Get
    End Property

    Public ReadOnly Property SelloCFD As String
        Get
            Return _SelloCFD
        End Get
    End Property

End Class

Public Class ComercioExteriorInfo

    Public Property Version As String = String.Empty

    Public Property TipoOperacion As String = String.Empty

    Public Property ClavePedimento As String = String.Empty

    Public Property CertificadoOrigen As String = String.Empty

    Public Property NumCertificadoOrigen As String = String.Empty

    Public Property NumExportadorConfiable As String = String.Empty

    Public Property Incoterm As String = String.Empty

    Public Property SubDivision As String = String.Empty

    Public Property Observaciones As String = String.Empty

    Public Property TipoCambio As Decimal

    Public Property TotalUSD As Decimal

    Public Property Emisor As EmisorInfo

    Public Property Receptor As ReceptorInfo

    Public Property Destinatario As DestinatarioInfo

    Public Property Mercancias As MercanciasCollection

    Public Sub New()
        Emisor = New EmisorInfo()
        Receptor = New ReceptorInfo()
        Destinatario = New DestinatarioInfo()
        Mercancias = New MercanciasCollection()
    End Sub

    Public Class EmisorInfo
        Public Property Curp As String = String.Empty
    End Class

    Public Class ReceptorInfo
        Public Property Curp As String = String.Empty
        Public Property NumRegIdTrib As String = String.Empty
    End Class


    Public Class DestinatarioInfo
        Public Property NumRegIdTrib As String = String.Empty
        Public Property RFC As String = String.Empty
        Public Property Curp As String = String.Empty
        Public Property Nombre As String = String.Empty
        Public Property Domicilio As DomicilioInfo

        Public Sub New()
            Domicilio = New DomicilioInfo()
        End Sub

    End Class


    Public Class MercanciaInfo
        Public Property NumIdentificacion As String = String.Empty
        Public Property FraccionArancelaria As String = String.Empty
        Public Property CantidadAduana As Decimal
        Public Property UnidadAduana As String = String.Empty
        Public Property ValorUnitarioAduana As Decimal
        Public Property ValorDolares As Decimal

    End Class

    Public Class MercanciasCollection
        Inherits System.Collections.Generic.List(Of MercanciaInfo)

    End Class
End Class

<Serializable()> _
Public Enum TipoComprobante
    Ingreso
    Egreso
    Traslado
End Enum

<Serializable()> _
Public Enum TipoImpuestoRetencion
    IVA = 1
    ISR = 2
End Enum

<Serializable()> _
Public Enum TipoImpuestoTraslado
    IVA = 1
    IEPS = 2
End Enum

<Serializable()> _
Public Enum TipoCFD
    Factura = 1
    NotaCargo = 2
    NotaCredito = 3
    NotaVenta = 4
End Enum


#End Region


<Serializable()> _
Public Class ComprobanteFiscalInfo

#Region "Campos Privados"
    Private SessionID As Guid

    Private _Emisor As EmisorInfo
    Private _Receptor As ReceptorInfo
    Private _Conceptos As ConceptosCollection
    Private _Impuestos As ImpuestosInfo
    Private _TimbreFiscal As TimbreFiscalInfo
    Private _ComercioExterior As ComercioExteriorInfo

    Friend _Folio As Integer
    Friend _NumeroAprobacion As Integer
    Friend _AnioAprobacion As Integer
    Friend _NumeroCertificado As String = String.Empty
    Friend _Certificado As String = String.Empty
    Friend _Cancelada As Boolean
    Friend _FechaCancelacion As Date
    Friend _QrCode As Byte()
#End Region

#Region "Propiedades Auxiliares"

    Public Property IdCliente() As Integer

    Public Property Referencia As String = String.Empty

    Public Property Credito() As Boolean

    Public Property DiasCredito As Integer

    Public Property FechaDocumento() As Date

    Public Property IdDocumento() As String = String.Empty

    Public Property TipoDocumento() As TipoCFD

    Public Property IdSucursal() As Integer

    Public Property TipoComprobante() As TipoComprobante

    Public ReadOnly Property Cancelada() As Boolean
        Get
            Return _Cancelada
        End Get
    End Property

    Public ReadOnly Property FechaCancelacion() As Date
        Get
            Return _FechaCancelacion
        End Get
    End Property

    Public ReadOnly Property QrCode As Byte()
        Get
            Return _QrCode
        End Get
    End Property

    Public Property IdAddenda As Integer

    Public Property GLNBuyer As String = String.Empty

    Public Property GLNStore As String = String.Empty

    Public Property GLNSeller As String = String.Empty

    Public Property SellerID As String = String.Empty

#End Region

#Region "Propiedades"

    Public ReadOnly Property Emisor() As EmisorInfo
        Get
            Return _Emisor
        End Get
    End Property

    Public ReadOnly Property Receptor() As ReceptorInfo
        Get
            Return _Receptor
        End Get
    End Property

    Public ReadOnly Property Conceptos() As ConceptosCollection
        Get
            Return _Conceptos
        End Get
    End Property

    Public ReadOnly Property Impuestos() As ImpuestosInfo
        Get
            Return _Impuestos
        End Get
    End Property

    Public ReadOnly Property TimbreFiscal As TimbreFiscalInfo
        Get
            Return _TimbreFiscal
        End Get
    End Property

    Public ReadOnly Property ComercioExterior As ComercioExteriorInfo
        Get
            Return _ComercioExterior
        End Get
    End Property



    Public Property Version() As String

    Public Property IdSerie As Integer

    Public Property Serie() As String

    Public ReadOnly Property Folio() As Integer
        Get
            Return _Folio
        End Get
    End Property

    Public ReadOnly Property UUID As String
        Get
            Return TimbreFiscal.UUID
        End Get
    End Property

    Public Property Fecha() As Date

    Public Property Sello() As String

    Public ReadOnly Property NumeroAprobacion() As Integer
        Get
            Return _NumeroAprobacion
        End Get
    End Property

    Public ReadOnly Property AnioAprobacion() As Integer
        Get
            Return _AnioAprobacion
        End Get
    End Property

    Public Property FormaPago As String = String.Empty

    Public ReadOnly Property NumeroCertificado() As String
        Get
            Return _NumeroCertificado
        End Get
    End Property

    Public ReadOnly Property Certificado() As String
        Get
            Return _Certificado
        End Get
    End Property

    Public Property CondicionesPago As String = String.Empty

    Public Property IdDivisa As Integer

    Public Property Divisa As String = "MXN"

    Public Property TipoCambio As Decimal

    Public Property SubTotal As Decimal

    Public Property Descuentos As Decimal

    Public Property MotivoDescuento As String = String.Empty

    Public Property Total As Decimal

    Public Property MetodoPago As String = "No Identificado"
    Public Property LugarExpedicion As String = String.Empty
    Public Property NumeroCuentaPago As String = String.Empty
    Public Property FolioFiscalOrigen As String = String.Empty
    Public Property UUIDFiscalOrigen As String = String.Empty
    Public Property SerieFolioFiscalOrigen As String = String.Empty
    Public Property FechaFolioFiscalOrigen As Date = Date.Today
    Public Property MontoFolioFiscalOrigen As Decimal



#End Region

#Region "Metodos XML"

    Public Function GetXMLString(formato As FormatoCFD) As String
        Dim ComprobanteXML As XmlDocument = GetXML(formato)
        Dim xmlText As New System.Text.StringBuilder()
        Dim writer As New StringWriterWithEncoding(xmlText, New System.Text.UTF8Encoding())
        ComprobanteXML.Save(writer)
        Dim xmlString As String = xmlText.ToString
        Return xmlString
    End Function

    Public Function GetXML(formato As FormatoCFD) As XmlDocument
        Dim xmlFact As New XmlDocument
        Try
            Dim ns As String = "http://www.sat.gob.mx/cfd/2"
            If formato = FormatoCFD.CFDI Then ns = "http://www.sat.gob.mx/cfd/3"
            Dim nsManager As New XmlNamespaceManager(xmlFact.NameTable)

            'Generar documento xml de la factura
            If formato = FormatoCFD.CFD Then
                nsManager.AddNamespace("cfd", ns)
                xmlFact.LoadXml("<?xml version='1.0' encoding='utf-8'?>" & ControlChars.NewLine & "<Comprobante xmlns='http://www.sat.gob.mx/cfd/2' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xsi:schemaLocation='http://www.sat.gob.mx/cfd http://www.sat.gob.mx/sitio_internet/cfd/2/cfdv22.xsd'></Comprobante>")
            Else
                nsManager.AddNamespace("cfdi", ns)
                xmlFact.LoadXml("<?xml version='1.0' encoding='utf-8'?>" & ControlChars.NewLine & "<cfdi:Comprobante xsi:schemaLocation='http://www.sat.gob.mx/cfd/3 http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd' xmlns:cfdi='http://www.sat.gob.mx/cfd/3' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'></cfdi:Comprobante>")
            End If
            'COMPROBANTE
            Dim Comprobante As XmlElement
            If formato = FormatoCFD.CFD Then
                Comprobante = CType(xmlFact.SelectSingleNode("/cfd:Comprobante", nsManager), XmlElement)
            Else
                Comprobante = CType(xmlFact.SelectSingleNode("/cfdi:Comprobante", nsManager), XmlElement)
            End If
            With Comprobante
                If formato = FormatoCFD.CFD Then
                    .SetAttribute("version", "2.2")
                Else
                    .SetAttribute("version", "3.2")
                End If
                If Serie.Trim <> String.Empty Then .SetAttribute("serie", Serie.Trim)
                .SetAttribute("folio", Folio.ToString)
                .SetAttribute("fecha", Fecha.ToString("yyyy-MM-dd") & "T" & Fecha.ToString("HH:mm:ss"))
                .SetAttribute("sello", Sello)
                If formato = FormatoCFD.CFD Then
                    .SetAttribute("noAprobacion", NumeroAprobacion.ToString)
                    .SetAttribute("anoAprobacion", AnioAprobacion.ToString)
                End If
                .SetAttribute("formaDePago", FormaPago)
                .SetAttribute("noCertificado", NumeroCertificado.ToString)
                If Certificado <> String.Empty Then .SetAttribute("certificado", Certificado)
                If CondicionesPago <> String.Empty Then .SetAttribute("condicionesDePago", CondicionesPago)
                .SetAttribute("subTotal", SubTotal.ToString("##0.00"))
                .SetAttribute("descuento", Descuentos.ToString("##0.00"))
                If MotivoDescuento <> String.Empty Then .SetAttribute("motivoDescuento", MotivoDescuento)
                .SetAttribute("TipoCambio", TipoCambio.ToString("##0.00"))
                .SetAttribute("Moneda", Divisa)
                .SetAttribute("total", Total.ToString("##0.00"))
                If MetodoPago <> String.Empty Then .SetAttribute("metodoDePago", MetodoPago)
                .SetAttribute("tipoDeComprobante", TipoComprobante.ToString.ToLower)
                .SetAttribute("LugarExpedicion", LugarExpedicion)
                If NumeroCuentaPago.Trim <> String.Empty Then .SetAttribute("NumCtaPago", NumeroCuentaPago)
                If Val(FolioFiscalOrigen) > 0 Then .SetAttribute("FolioFiscalOrig", FolioFiscalOrigen)
                If SerieFolioFiscalOrigen.Trim <> String.Empty Then .SetAttribute("SerieFolioFiscalOrig", SerieFolioFiscalOrigen)
                .SetAttribute("FechaFolioFiscalOrig", FechaFolioFiscalOrigen.ToString("yyyy-MM-dd") & "T" & FechaFolioFiscalOrigen.ToString("HH:mm:ss"))
                If Val(MontoFolioFiscalOrigen) > 0 Then .SetAttribute("MontoFolioFiscalOrig", MontoFolioFiscalOrigen.ToString("##0.00"))
            End With
            'EMISOR
            Dim EmisorTag As String = "Emisor"
            If formato = FormatoCFD.CFDI Then EmisorTag = "cfdi:Emisor"
            Dim Emisor As XmlElement = xmlFact.CreateElement(EmisorTag, ns)
            CreateEmisorXML(xmlFact, Emisor, Me, ns, formato)
            Comprobante.AppendChild(Emisor)
            'RECEPTOR
            Dim ReceptorTag As String = "Receptor"
            If formato = FormatoCFD.CFDI Then ReceptorTag = "cfdi:Receptor"
            Dim Receptor As XmlElement = xmlFact.CreateElement(ReceptorTag, ns)
            CreateReceptorXML(xmlFact, Receptor, Me, ns, formato)
            Comprobante.AppendChild(Receptor)
            'CONCEPTOS
            Dim ConceptosTag As String = "Conceptos"
            If formato = FormatoCFD.CFDI Then ConceptosTag = "cfdi:Conceptos"
            Dim Conceptos As XmlElement = xmlFact.CreateElement(ConceptosTag, ns)
            CreateConceptosXML(xmlFact, Conceptos, Me, ns, formato)
            Comprobante.AppendChild(Conceptos)
            'IMPUESTOS
            Dim ImpuestosTag As String = "Impuestos"
            If formato = FormatoCFD.CFDI Then ImpuestosTag = "cfdi:Impuestos"
            Dim Impuestos As XmlElement = xmlFact.CreateElement(ImpuestosTag, ns)
            CreateImpuestosXML(xmlFact, Impuestos, Me, ns, formato)
            Comprobante.AppendChild(Impuestos)
            'COMPLEMENTO
            If formato = FormatoCFD.CFDI Then
                Dim ComplementoTag = "cfdi:Complemento"
                Dim Complemento As XmlElement = xmlFact.CreateElement(ComplementoTag, ns)
                If TimbreFiscal.Version <> String.Empty Then
                    Dim tfns As String = "http://www.sat.gob.mx/TimbreFiscalDigital"
                    '
                    nsManager.AddNamespace("tfd", tfns)
                    Dim TimbreFiscal As XmlElement = xmlFact.CreateElement("tfd:TimbreFiscalDigital", tfns)
                    'Agregar ubicación del esquema del timbre
                    Dim SchemaLocation As XmlAttribute = xmlFact.CreateAttribute("xsi", "schemaLocation", "http://www.w3.org/2001/XMLSchema-instance")
                    SchemaLocation.Value = "http://www.sat.gob.mx/TimbreFiscalDigital http://www.sat.gob.mx/sitio_internet/TimbreFiscalDigital/TimbreFiscalDigital.xsd"
                    TimbreFiscal.SetAttributeNode(SchemaLocation)
                    '
                    TimbreFiscal.SetAttribute("version", Me.TimbreFiscal.Version)
                    TimbreFiscal.SetAttribute("UUID", Me.TimbreFiscal.UUID)
                    TimbreFiscal.SetAttribute("FechaTimbrado", Me.TimbreFiscal.Fecha.ToString("yyyy-MM-dd") & "T" & Me.TimbreFiscal.Fecha.ToString("HH:mm:ss"))
                    TimbreFiscal.SetAttribute("selloCFD", Me.TimbreFiscal.SelloCFD)
                    TimbreFiscal.SetAttribute("noCertificadoSAT", Me.TimbreFiscal.NumeroCertificadoSAT)
                    TimbreFiscal.SetAttribute("selloSAT", Me.TimbreFiscal.SelloSAT)
                    Complemento.AppendChild(TimbreFiscal)
                End If
                '
                If ComercioExterior.Version <> String.Empty Then
                    Dim cens As String = "http://www.sat.gob.mx/ComercioExterior"
                    nsManager.AddNamespace("cce", cens)
                    Dim ComercioExteriorNode As XmlElement = xmlFact.CreateElement("cce:ComercioExterior", cens)
                    CreateComercioExteriorXML(xmlFact, ComercioExteriorNode, Me, ns)
                    Complemento.AppendChild(ComercioExteriorNode)
                End If
                Comprobante.AppendChild(Complemento)
            End If

            'Addenda
            If IdAddenda > 0 Then
                Dim AddendaTag As String = "Addenda"
                If formato = FormatoCFD.CFDI Then AddendaTag = "cfdi:Addenda"
                Dim Addenda As XmlElement = xmlFact.CreateElement(AddendaTag, ns)
                Select Case IdAddenda
                    Case 1 : AddendaAMECE(xmlFact, Addenda, Me, ns)
                End Select
                Comprobante.AppendChild(Addenda)
                If xmlFact.Schemas IsNot Nothing AndAlso xmlFact.Schemas.Count > 0 Then xmlFact.Validate(AddressOf Esquema_Validation)
            Else
                'Leer el esquema normal de la factura
                Dim XSDString As String = String.Empty
                If formato = FormatoCFD.CFD Then
                    XSDString = My.Resources.FacturaXSD_V2_2
                Else
                    XSDString = My.Resources.FacturaXSD_V3_2
                End If
                Dim FacturaXSD As Schema.XmlSchema
                Dim reader As New System.IO.StringReader(XSDString)
                FacturaXSD = XmlSchema.Read(reader, AddressOf Esquema_Validation)
                Dim Esquemas As New XmlSchemaSet()
                Esquemas.Add(FacturaXSD)
                If formato = FormatoCFD.CFDI And Me.TimbreFiscal.Version <> String.Empty Then
                    Dim tfdReader As New System.IO.StringReader(My.Resources.TimbreFiscal_XSD)
                    Dim TimbreXSD As Schema.XmlSchema = XmlSchema.Read(tfdReader, AddressOf Esquema_Validation)
                    Esquemas.Add(TimbreXSD)
                End If
                xmlFact.Schemas = Esquemas
                xmlFact.Validate(AddressOf Esquema_Validation)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al generar el xml del comprobante fiscal.", ex)
        End Try
        Return xmlFact
    End Function

    Private Sub Esquema_Validation(ByVal sender As Object, ByVal e As System.Xml.Schema.ValidationEventArgs)
        If e.Severity = XmlSeverityType.Error Then
            Throw New BusinessException("Error al validar la el esquema del comprobante fiscal.", e.Exception)
        Else
            AppEventLog.WriteEntry(e.Message, EventLogType.Warning)
        End If
    End Sub

    Private Sub CreateEmisorXML(ByVal xmlDoc As XmlDocument, ByVal emisor As XmlElement, ByVal comprobante As ComprobanteFiscalInfo, ByVal ns As String, formato As FormatoCFD)
        Try
            With emisor
                .SetAttribute("rfc", comprobante.Emisor.RFC)
                .SetAttribute("nombre", comprobante.Emisor.Nombre)
                'Domicilio Fiscal
                Dim DomicilioFiscalTag As String = "DomicilioFiscal"
                If formato = FormatoCFD.CFDI Then DomicilioFiscalTag = "cfdi:DomicilioFiscal"
                Dim DomicilioFiscal As XmlElement = xmlDoc.CreateElement(DomicilioFiscalTag, ns)
                With DomicilioFiscal
                    .SetAttribute("calle", comprobante.Emisor.DomicilioFiscal.Calle)
                    If comprobante.Emisor.DomicilioFiscal.NumExt.Trim <> String.Empty Then .SetAttribute("noExterior", comprobante.Emisor.DomicilioFiscal.NumExt.Trim)
                    If comprobante.Emisor.DomicilioFiscal.NumInt.Trim <> String.Empty Then .SetAttribute("noInterior", comprobante.Emisor.DomicilioFiscal.NumInt.Trim)
                    If comprobante.Emisor.DomicilioFiscal.Colonia.Trim <> String.Empty Then .SetAttribute("colonia", comprobante.Emisor.DomicilioFiscal.Colonia.Trim)
                    If comprobante.Emisor.DomicilioFiscal.Localidad.Trim <> String.Empty Then .SetAttribute("localidad", comprobante.Emisor.DomicilioFiscal.Localidad.Trim)
                    If comprobante.Emisor.DomicilioFiscal.Referencia.Trim <> String.Empty Then .SetAttribute("referencia", comprobante.Emisor.DomicilioFiscal.Referencia.Trim)
                    .SetAttribute("municipio", comprobante.Emisor.DomicilioFiscal.Municipio.Trim)
                    .SetAttribute("estado", comprobante.Emisor.DomicilioFiscal.Estado.Trim)
                    .SetAttribute("pais", comprobante.Emisor.DomicilioFiscal.Pais.Trim)
                    .SetAttribute("codigoPostal", comprobante.Emisor.DomicilioFiscal.CodigoPostal.Trim)
                End With
                emisor.AppendChild(DomicilioFiscal)

                'Lugar de Expedición
                Dim LugarExpedicionTag As String = "ExpedidoEn"
                If formato = FormatoCFD.CFDI Then LugarExpedicionTag = "cfdi:ExpedidoEn"
                Dim LugarExpedicion As XmlElement = xmlDoc.CreateElement(LugarExpedicionTag, ns)
                With LugarExpedicion
                    If comprobante.Emisor.LugarExpedicion.Calle.Trim <> String.Empty Then .SetAttribute("calle", comprobante.Emisor.LugarExpedicion.Calle)
                    If comprobante.Emisor.LugarExpedicion.NumExt.Trim <> String.Empty Then .SetAttribute("noExterior", comprobante.Emisor.LugarExpedicion.NumExt)
                    If comprobante.Emisor.LugarExpedicion.NumInt.Trim <> String.Empty Then .SetAttribute("noInterior", comprobante.Emisor.LugarExpedicion.NumInt)
                    If comprobante.Emisor.LugarExpedicion.Colonia.Trim <> String.Empty Then .SetAttribute("colonia", comprobante.Emisor.LugarExpedicion.Colonia)
                    If comprobante.Emisor.LugarExpedicion.Localidad.Trim <> String.Empty Then .SetAttribute("localidad", comprobante.Emisor.LugarExpedicion.Localidad)
                    If comprobante.Emisor.LugarExpedicion.Referencia.Trim <> String.Empty Then .SetAttribute("referencia", comprobante.Emisor.LugarExpedicion.Referencia)
                    If comprobante.Emisor.LugarExpedicion.Municipio.Trim <> String.Empty Then .SetAttribute("municipio", comprobante.Emisor.LugarExpedicion.Municipio)
                    If comprobante.Emisor.LugarExpedicion.Estado.Trim <> String.Empty Then .SetAttribute("estado", comprobante.Emisor.LugarExpedicion.Estado.Trim)
                    .SetAttribute("pais", comprobante.Emisor.LugarExpedicion.Pais)
                    If comprobante.Emisor.LugarExpedicion.CodigoPostal.Trim <> String.Empty Then .SetAttribute("codigoPostal", comprobante.Emisor.LugarExpedicion.CodigoPostal.Trim)
                End With
                emisor.AppendChild(LugarExpedicion)
                'Agregar regimenes fiscales
                For Each regimen As String In comprobante.Emisor.RegimenesFiscales
                    Dim RegimenFiscalTag As String = "RegimenFiscal"
                    If formato = FormatoCFD.CFDI Then RegimenFiscalTag = "cfdi:RegimenFiscal"
                    Dim RegimenFiscal As XmlElement = xmlDoc.CreateElement(RegimenFiscalTag, ns)
                    RegimenFiscal.SetAttribute("Regimen", regimen)
                    emisor.AppendChild(RegimenFiscal)
                Next
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al generar el xml del emisor", ex)
        End Try
    End Sub

    Private Sub CreateReceptorXML(ByVal xmlDoc As XmlDocument, ByVal receptor As XmlElement, ByVal comprobante As ComprobanteFiscalInfo, ByVal ns As String, formato As FormatoCFD)
        Try
            With receptor
                .SetAttribute("rfc", comprobante.Receptor.RFC)
                .SetAttribute("nombre", comprobante.Receptor.Nombre)
                'Domicilio Fiscal
                Dim DomicilioTag As String = "Domicilio"
                If formato = FormatoCFD.CFDI Then DomicilioTag = "cfdi:Domicilio"
                Dim Domicilio As XmlElement = xmlDoc.CreateElement(DomicilioTag, ns)
                With Domicilio
                    .SetAttribute("calle", comprobante.Receptor.Domicilio.Calle.Trim)
                    If comprobante.Receptor.Domicilio.NumExt.Trim <> String.Empty Then .SetAttribute("noExterior", comprobante.Receptor.Domicilio.NumExt.Trim)
                    If comprobante.Receptor.Domicilio.NumInt.Trim <> String.Empty Then .SetAttribute("noInterior", comprobante.Receptor.Domicilio.NumInt.Trim)
                    If comprobante.Receptor.Domicilio.Colonia.Trim <> String.Empty Then .SetAttribute("colonia", comprobante.Receptor.Domicilio.Colonia.Trim)
                    If comprobante.Receptor.Domicilio.Localidad.Trim <> String.Empty Then .SetAttribute("localidad", comprobante.Receptor.Domicilio.Localidad.Trim)
                    If comprobante.Receptor.Domicilio.Referencia.Trim <> String.Empty Then .SetAttribute("referencia", comprobante.Receptor.Domicilio.Referencia.Trim)
                    If comprobante.Receptor.Domicilio.Municipio.Trim <> String.Empty Then .SetAttribute("municipio", comprobante.Receptor.Domicilio.Municipio.Trim)
                    If comprobante.Receptor.Domicilio.Estado.Trim <> String.Empty Then .SetAttribute("estado", comprobante.Receptor.Domicilio.Estado.Trim)
                    .SetAttribute("pais", comprobante.Receptor.Domicilio.Pais)
                    If comprobante.Receptor.Domicilio.CodigoPostal.Trim <> String.Empty Then .SetAttribute("codigoPostal", comprobante.Receptor.Domicilio.CodigoPostal.Trim)
                End With
                receptor.AppendChild(Domicilio)
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al generarl el xml del receptor.", ex)
        End Try
    End Sub

    Private Sub CreateConceptosXML(ByVal xmlDoc As XmlDocument, ByVal conceptos As XmlElement, ByVal comprobante As ComprobanteFiscalInfo, ByVal ns As String, formato As FormatoCFD)
        Try
            For Each conceptoInf As ConceptoInfo In comprobante.Conceptos
                Dim ConceptoTag As String = "Concepto"
                If formato = FormatoCFD.CFDI Then ConceptoTag = "cfdi:Concepto"
                Dim Concepto As XmlElement = xmlDoc.CreateElement(ConceptoTag, ns)
                With Concepto
                    .SetAttribute("cantidad", conceptoInf.Cantidad.ToString("##0.00"))
                    If conceptoInf.Unidad.Trim <> String.Empty Then .SetAttribute("unidad", conceptoInf.Unidad.Trim)
                    If conceptoInf.Codigo.Trim <> String.Empty Then .SetAttribute("noIdentificacion", conceptoInf.Codigo.Trim)
                    .SetAttribute("descripcion", conceptoInf.Descripcion.Trim)
                    .SetAttribute("valorUnitario", (conceptoInf.ValorUnitario - conceptoInf.MontoDescuento1 - conceptoInf.MontoDescuento2 - conceptoInf.MontoDescuento3).ToString("##0.00"))
                    .SetAttribute("importe", ((conceptoInf.ValorUnitario - conceptoInf.MontoDescuento1 - conceptoInf.MontoDescuento2 - conceptoInf.MontoDescuento3) * conceptoInf.Cantidad).ToString("##0.00"))
                    For Each infoAduanera As InformacionAduanera In conceptoInf.InformacionAduanera
                        Dim InfoAduaneraTag As String = "InformacionAduanera"
                        If formato = FormatoCFD.CFDI Then InfoAduaneraTag = "cfdi:InformacionAduanera"
                        Dim xInfoAduanera As XmlElement = xmlDoc.CreateElement(InfoAduaneraTag, ns)
                        xInfoAduanera.SetAttribute("numero", infoAduanera.Numero)
                        xInfoAduanera.SetAttribute("fecha", infoAduanera.Fecha.ToString("yyyy-MM-dd"))
                        xInfoAduanera.SetAttribute("aduana", infoAduanera.Aduana)
                        Concepto.AppendChild(xInfoAduanera)
                    Next
                End With
                conceptos.AppendChild(Concepto)
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al generar el xml de los conceptos", ex)
        End Try
    End Sub

    Private Sub CreateImpuestosXML(ByVal xmlDoc As XmlDocument, ByVal impuestos As XmlElement, ByVal comprobante As ComprobanteFiscalInfo, ByVal ns As String, formato As FormatoCFD)
        Try
            impuestos.SetAttribute("totalImpuestosRetenidos", comprobante.Impuestos.TotalRetenciones.ToString("##0.00"))
            impuestos.SetAttribute("totalImpuestosTrasladados", comprobante.Impuestos.TotalTraslados.ToString("##0.00"))
            '
            If comprobante.Impuestos.Retenciones.Count > 0 Then
                Dim RetencionesTag As String = "Retenciones"
                If formato = FormatoCFD.CFDI Then RetencionesTag = "cfdi:Retenciones"
                Dim Retenciones As XmlElement = xmlDoc.CreateElement(RetencionesTag, ns)
                For Each retencionInf As RetencionCFDInfo In comprobante.Impuestos.Retenciones
                    Dim RetencionTag As String = "Retencion"
                    If formato = FormatoCFD.CFDI Then RetencionTag = "cfdi:Retencion"
                    Dim Retencion As XmlElement = xmlDoc.CreateElement(RetencionTag, ns)
                    Retencion.SetAttribute("impuesto", retencionInf.Impuesto.ToString.ToUpper)
                    Retencion.SetAttribute("importe", retencionInf.Importe.ToString("##0.00"))
                    Retenciones.AppendChild(Retencion)
                Next
                impuestos.AppendChild(Retenciones)
            End If
            '
            If comprobante.Impuestos.Traslados.Count > 0 Then
                Dim TrasladosTag As String = "Traslados"
                If formato = FormatoCFD.CFDI Then TrasladosTag = "cfdi:Traslados"
                Dim Traslados As XmlElement = xmlDoc.CreateElement(TrasladosTag, ns)
                For Each trasladoInf As TrasladoInfo In comprobante.Impuestos.Traslados
                    Dim TrasladoTag As String = "Traslado"
                    If formato = FormatoCFD.CFDI Then TrasladoTag = "cfdi:Traslado"
                    Dim Traslado As XmlElement = xmlDoc.CreateElement(TrasladoTag, ns)
                    Traslado.SetAttribute("impuesto", trasladoInf.Impuesto.ToString.ToUpper)
                    Traslado.SetAttribute("tasa", trasladoInf.Tasa.ToString("##0.00"))
                    Traslado.SetAttribute("importe", trasladoInf.Importe.ToString("##0.00"))
                    Traslados.AppendChild(Traslado)
                Next
                impuestos.AppendChild(Traslados)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al generar el xml de los impuestos", ex)
        End Try
    End Sub

    Private Sub CreateComercioExteriorXML(ByVal xmlDoc As XmlDocument, ByVal comercioExterior As XmlElement, ByVal comprobante As ComprobanteFiscalInfo, ByVal ns As String)
        With comercioExterior
            'Raíz del nodo
            .SetAttribute("Version", "1.0")
            .SetAttribute("TipoOperacion", comprobante.ComercioExterior.TipoOperacion)
            If comprobante.ComercioExterior.ClavePedimento.Trim <> String.Empty Then .SetAttribute("ClaveDePedimento", comprobante.ComercioExterior.ClavePedimento)
            If comprobante.ComercioExterior.CertificadoOrigen.Trim <> String.Empty Then .SetAttribute("CertificadoOrigen", comprobante.ComercioExterior.CertificadoOrigen)
            If comprobante.ComercioExterior.NumCertificadoOrigen <> String.Empty Then .SetAttribute("NumCertificadoOrigen", comprobante.ComercioExterior.NumCertificadoOrigen)
            If comprobante.ComercioExterior.NumExportadorConfiable.Trim <> String.Empty Then .SetAttribute("NumeroExportadorConfiable", comprobante.ComercioExterior.NumExportadorConfiable)
            If comprobante.ComercioExterior.Incoterm <> String.Empty Then .SetAttribute("Incoterm", comprobante.ComercioExterior.Incoterm)
            If comprobante.ComercioExterior.SubDivision.Trim <> String.Empty Then .SetAttribute("Subdivision", comprobante.ComercioExterior.SubDivision)
            If comprobante.ComercioExterior.Observaciones.Trim <> String.Empty Then .SetAttribute("Observaciones", comprobante.ComercioExterior.Observaciones)
            If comprobante.ComercioExterior.TipoCambio <> 0 Then .SetAttribute("TipoCambioUSD", comprobante.ComercioExterior.TipoCambio.ToString("##0.00"))
            If comprobante.ComercioExterior.TotalUSD <> 0 Then .SetAttribute("TotalUSD", comprobante.ComercioExterior.TotalUSD.ToString("##0.00"))
            'Nodo emisor
            Dim Emisor As XmlElement = xmlDoc.CreateElement("cce:Emisor", ns)
            If comprobante.ComercioExterior.Emisor.Curp.Trim <> String.Empty Then Emisor.SetAttribute("Curp", comprobante.ComercioExterior.Emisor.Curp)
            .AppendChild(Emisor)
            'Nodo receptor
            Dim Receptor As XmlElement = xmlDoc.CreateElement("cce:Receptor", ns)
            If comprobante.ComercioExterior.Receptor.Curp <> String.Empty Then Receptor.SetAttribute("Curp", comprobante.ComercioExterior.Receptor.Curp)
            Receptor.SetAttribute("NumRegIdTrib", comprobante.ComercioExterior.Receptor.NumRegIdTrib)
            .AppendChild(Receptor)
        End With

        'Destinatario
        If comprobante.ComercioExterior.Destinatario.NumRegIdTrib.Trim <> String.Empty Then
            With comprobante.ComercioExterior.Destinatario
                Dim Destinatario As XmlElement = xmlDoc.CreateElement("cce:Destinatario", ns)
                If .NumRegIdTrib.Trim <> String.Empty Then Destinatario.SetAttribute("NumRegIdTrib", .NumRegIdTrib)
                If .RFC.Trim <> String.Empty Then Destinatario.SetAttribute("Rfc", .RFC)
                If .Curp.Trim <> String.Empty Then Destinatario.SetAttribute("Curp", .Curp)
                If .Nombre.Trim <> String.Empty Then Destinatario.SetAttribute("Nombre", .Nombre)
                'Domicilio
                Dim Domicilio As XmlElement = xmlDoc.CreateElement("cce:Domicilio", ns)
                With Domicilio
                    .SetAttribute("calle", comprobante.ComercioExterior.Destinatario.Domicilio.Calle.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.NumExt.Trim <> String.Empty Then .SetAttribute("noExterior", comprobante.ComercioExterior.Destinatario.Domicilio.NumExt.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.NumInt.Trim <> String.Empty Then .SetAttribute("noInterior", comprobante.ComercioExterior.Destinatario.Domicilio.NumInt.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.Colonia.Trim <> String.Empty Then .SetAttribute("colonia", comprobante.ComercioExterior.Destinatario.Domicilio.Colonia.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.Localidad.Trim <> String.Empty Then .SetAttribute("localidad", comprobante.ComercioExterior.Destinatario.Domicilio.Localidad.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.Referencia.Trim <> String.Empty Then .SetAttribute("referencia", comprobante.ComercioExterior.Destinatario.Domicilio.Referencia.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.Municipio.Trim <> String.Empty Then .SetAttribute("municipio", comprobante.ComercioExterior.Destinatario.Domicilio.Municipio.Trim)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.Estado.Trim <> String.Empty Then .SetAttribute("estado", comprobante.ComercioExterior.Destinatario.Domicilio.Estado.Trim)
                    .SetAttribute("pais", comprobante.ComercioExterior.Destinatario.Domicilio.Pais)
                    If comprobante.ComercioExterior.Destinatario.Domicilio.CodigoPostal.Trim <> String.Empty Then .SetAttribute("codigoPostal", comprobante.ComercioExterior.Destinatario.Domicilio.CodigoPostal.Trim)
                End With
                Destinatario.AppendChild(Domicilio)
                comercioExterior.AppendChild(Destinatario)
            End With
        End If
        'Mercancias
        If comprobante.ComercioExterior.Mercancias.Count > 0 Then
            Dim Mercancias As XmlElement = xmlDoc.CreateElement("cce:Mercancias", ns)
            For Each Mercancia As ComercioExteriorInfo.MercanciaInfo In comprobante.ComercioExterior.Mercancias
                Dim MercanciaNode As XmlElement = xmlDoc.CreateElement("cce:Mercancia", ns)
                MercanciaNode.SetAttribute("NoIdentificacion", Mercancia.NumIdentificacion)
                If Mercancia.FraccionArancelaria.Trim <> String.Empty Then MercanciaNode.SetAttribute("FraccionArancelaria", Mercancia.FraccionArancelaria)
                If Mercancia.CantidadAduana <> 0 Then MercanciaNode.SetAttribute("CantidadAduana", Mercancia.CantidadAduana.ToString("##0.00"))
                If Mercancia.UnidadAduana.Trim <> String.Empty Then MercanciaNode.SetAttribute("UnidadAduana", Mercancia.UnidadAduana)
                If Mercancia.ValorUnitarioAduana <> 0 Then MercanciaNode.SetAttribute("ValorUnitarioAduana", Mercancia.ValorUnitarioAduana.ToString("##0.00"))
                MercanciaNode.SetAttribute("ValorDolares", Mercancia.ValorDolares.ToString("##0.00"))
                Mercancias.AppendChild(MercanciaNode)
            Next
            comercioExterior.AppendChild(Mercancias)
        End If
    End Sub

    Private Sub AddendaAMECE(ByVal xmlDoc As XmlDocument, ByVal Addenda As XmlElement, ByVal comprobante As ComprobanteFiscalInfo, ByVal ns As String)
        'Asignar esquema de AMECE
        Dim FacturaXSD As Schema.XmlSchema
        Dim reader As New System.IO.StringReader(My.Resources.FacturaXSD_AMECE)
        FacturaXSD = XmlSchema.Read(reader, AddressOf Esquema_Validation)
        Dim Esquemas As New XmlSchemaSet()
        Esquemas.Add(FacturaXSD)
        xmlDoc.Schemas = Esquemas
        'a
        Dim requestForPayment As XmlElement = xmlDoc.CreateElement("requestForPayment", ns)
        requestForPayment.SetAttribute("type", "SimpleInvoiceType")
        requestForPayment.SetAttribute("contentVersion", "1.3.1")
        requestForPayment.SetAttribute("documentStructureVersion", "AMC7.1")
        requestForPayment.SetAttribute("documentStatus", "ORIGINAL")
        requestForPayment.SetAttribute("DeliveryDate", comprobante.Fecha.ToString("yyyy-MM-dd"))

        '------ > Agregar a.1 <---------
        Dim a1_requestForPaymentIdentification As XmlElement = xmlDoc.CreateElement("requestForPaymentIdentification", ns)
        Dim a1_1_entityType As XmlElement = xmlDoc.CreateElement("entityType", ns)
        Dim a1_2_uniqueCreatorIdentification As XmlElement = xmlDoc.CreateElement("uniqueCreatorIdentification", ns)

        Select Case comprobante.TipoDocumento
            Case TipoCFD.Factura
                a1_1_entityType.InnerText = "INVOICE"
            Case TipoCFD.NotaCargo
                a1_1_entityType.InnerText = "DEBIT_NOTE"
            Case TipoCFD.NotaCredito
                a1_1_entityType.InnerText = "CREDIT_NOTE"
        End Select
        a1_2_uniqueCreatorIdentification.InnerText = Trim(comprobante.Serie.Trim & comprobante.Folio.ToString)
        a1_requestForPaymentIdentification.AppendChild(a1_1_entityType) 'a.1.1
        a1_requestForPaymentIdentification.AppendChild(a1_2_uniqueCreatorIdentification) 'a.1.2
        requestForPayment.AppendChild(a1_requestForPaymentIdentification) '/>a.1

        '------ > Agregar a.2 <---------
        Dim a2_specialInstruction As XmlElement = xmlDoc.CreateElement("specialInstruction", ns)
        Dim a2_1_Text As XmlElement = xmlDoc.CreateElement("text", ns)
        a2_specialInstruction.SetAttribute("code", "ZZZ") 'Importe con letra
        a2_1_Text.InnerText = Number.ToText(comprobante.Total, Number.FormatoTexto.Mayusculas)
        a2_specialInstruction.AppendChild(a2_1_Text)
        requestForPayment.AppendChild(a2_specialInstruction)

        '------ > Agregar a.3 <---------
        Dim a3_orderIdentificaction As XmlElement = xmlDoc.CreateElement("orderIdentification", ns)
        Dim a3_1_referenceIdentification As XmlElement = xmlDoc.CreateElement("referenceIdentification", ns)
        a3_1_referenceIdentification.SetAttribute("type", "ON")
        Dim a3_2_referenceDate As XmlElement = xmlDoc.CreateElement("ReferenceDate", ns)
        a3_1_referenceIdentification.InnerText = CStr(IIf(comprobante.Referencia = String.Empty, 0, comprobante.Referencia))
        a3_2_referenceDate.InnerText = comprobante.FechaDocumento.ToString("yyyy-MM-dd")
        a3_orderIdentificaction.AppendChild(a3_1_referenceIdentification)
        a3_orderIdentificaction.AppendChild(a3_2_referenceDate)
        requestForPayment.AppendChild(a3_orderIdentificaction)

        '------ > Agregar a.4 <---------
        Dim a4_AdditionalInformation As XmlElement = xmlDoc.CreateElement("AdditionalInformation", ns)
        Dim a4_1_referenceIdentificacion As XmlElement = xmlDoc.CreateElement("referenceIdentification", ns)
        a4_1_referenceIdentificacion.SetAttribute("type", "ACE")
        a4_1_referenceIdentificacion.InnerText = "0"
        a4_AdditionalInformation.AppendChild(a4_1_referenceIdentificacion)
        requestForPayment.AppendChild(a4_AdditionalInformation)

        '------ > Agregar a.6 <---------
        Dim a6_Buyer As XmlElement = xmlDoc.CreateElement("buyer", ns)
        Dim a6_1_gln As XmlElement = xmlDoc.CreateElement("gln", ns)
        a6_1_gln.InnerText = comprobante.GLNBuyer.Trim
        a6_Buyer.AppendChild(a6_1_gln)
        requestForPayment.AppendChild(a6_Buyer)

        '------ > Agregar a.7 <---------
        If comprobante.GLNSeller.Trim <> String.Empty Then
            Dim a7_seller As XmlElement = xmlDoc.CreateElement("seller", ns)
            Dim a7_1_gln As XmlElement = xmlDoc.CreateElement("gln", ns)
            Dim a7_2_alternatePartyIdentification As XmlElement = xmlDoc.CreateElement("alternatePartyIdentification", ns)
            a7_1_gln.InnerText = comprobante.GLNSeller
            a7_2_alternatePartyIdentification.SetAttribute("type", "SELLER_ASSIGNED_IDENTIFIER_FOR_A_PARTY")
            a7_2_alternatePartyIdentification.InnerText = comprobante.SellerID
            a7_seller.AppendChild(a7_1_gln)
            a7_seller.AppendChild(a7_2_alternatePartyIdentification)
            requestForPayment.AppendChild(a7_seller)
        End If

        '------ > Agregar a.8 <---------
        Dim a8_shipTo As XmlElement = xmlDoc.CreateElement("shipTo", ns)
        Dim a8_1_gln As XmlElement = xmlDoc.CreateElement("gln", ns)
        Dim a8_2_nameAndAddress As XmlElement = xmlDoc.CreateElement("nameAndAddress", ns)
        Dim a8_2_1_name As XmlElement = xmlDoc.CreateElement("name", ns)
        Dim a8_2_2_streetAddressOne As XmlElement = xmlDoc.CreateElement("streetAddressOne", ns)
        Dim a8_2_3_city As XmlElement = xmlDoc.CreateElement("city", ns)
        Dim a8_2_4_postalCode As XmlElement = xmlDoc.CreateElement("postalCode", ns)
        a8_1_gln.InnerText = comprobante.GLNStore
        a8_2_1_name.InnerText = comprobante.Receptor.Nombre.Substring(0, 35)
        a8_2_2_streetAddressOne.InnerText = CStr(comprobante.Receptor.DomicilioEnvio.Calle & " " & comprobante.Receptor.DomicilioEnvio.NumExt & " " & comprobante.Receptor.DomicilioEnvio.NumInt).Trim.Substring(0, 35)
        a8_2_3_city.InnerText = comprobante.Receptor.DomicilioEnvio.Localidad.Substring(0, 35)
        a8_2_4_postalCode.InnerText = comprobante.Receptor.DomicilioEnvio.CodigoPostal
        a8_2_nameAndAddress.AppendChild(a8_2_1_name)
        a8_2_nameAndAddress.AppendChild(a8_2_2_streetAddressOne)
        a8_2_nameAndAddress.AppendChild(a8_2_3_city)
        a8_2_nameAndAddress.AppendChild(a8_2_4_postalCode)
        If comprobante.GLNStore.Trim <> String.Empty Then a8_shipTo.AppendChild(a8_1_gln)
        a8_shipTo.AppendChild(a8_2_nameAndAddress)
        requestForPayment.AppendChild(a8_shipTo)

        '------ > Agregar a.11 <---------
        Dim a11_currency As XmlElement = xmlDoc.CreateElement("currency", ns)
        Dim a11_1_currencyFunction As XmlElement = xmlDoc.CreateElement("currencyFunction", ns)
        Dim a11_2_rateOfChance As XmlElement = xmlDoc.CreateElement("rateOfChange", ns)
        a11_1_currencyFunction.InnerText = "BILLING_CURRENCY"
        a11_2_rateOfChance.InnerText = comprobante.TipoCambio.ToString
        a11_currency.SetAttribute("currencyISOCode", comprobante.Divisa)
        a11_currency.AppendChild(a11_1_currencyFunction)
        a11_currency.AppendChild(a11_2_rateOfChance)
        requestForPayment.AppendChild(a11_currency)

        '------ > Agregar a.12 <---------
        Dim a12_paymentTerms As XmlElement = xmlDoc.CreateElement("paymentTerms", ns)
        a12_paymentTerms.SetAttribute("PaymentTermsRelationTime", "REFERENCE_AFTER")
        Dim a12_1_netPayment As XmlElement = xmlDoc.CreateElement("netPayment", ns)
        a12_1_netPayment.SetAttribute("netPaymentTermsType", "BASIC_NET")
        Dim a12_1_1_paymentTimePeriod As XmlElement = xmlDoc.CreateElement("paymentTimePeriod", ns)
        Dim a12_1_1_1_timePeriodDue As XmlElement = xmlDoc.CreateElement("timePeriodDue", ns)
        a12_1_1_1_timePeriodDue.SetAttribute("timePeriod", "DAYS")
        Dim a12_1_1_1_1_value As XmlElement = xmlDoc.CreateElement("value", ns)
        a12_1_1_1_1_value.InnerText = CStr(comprobante.DiasCredito.ToString)
        a12_1_1_1_timePeriodDue.AppendChild(a12_1_1_1_1_value)
        a12_1_1_paymentTimePeriod.AppendChild(a12_1_1_1_timePeriodDue)
        If comprobante.Credito Then a12_1_netPayment.AppendChild(a12_1_1_paymentTimePeriod)
        a12_paymentTerms.AppendChild(a12_1_netPayment)
        requestForPayment.AppendChild(a12_paymentTerms)

        '------ > Agregar a.14 <---------
        'Dim a14_allowanceCharge As XmlElement = xmlDoc.CreateElement("allowanceCharge", ns)
        'a14_allowanceCharge.SetAttribute("settlementType", "OFF_INVOICE")
        'a14_allowanceCharge.SetAttribute("allowanceChargeType", "ALLOWANCE_GLOBAL")
        'Dim a14_1_specialServicesType As XmlElement = xmlDoc.CreateElement("specialServicesType", ns)
        'a14_1_specialServicesType.InnerText = "DI"
        'Dim a14_2_monetaryAmountOrPercentage As XmlElement = xmlDoc.CreateElement("monetaryAmountOrPercentage", ns)
        'Dim a14_2_1_rate As XmlElement = xmlDoc.CreateElement("rate", ns)
        'a14_2_1_rate.SetAttribute("base", "INVOICE_VALUE")
        'Dim a14_2_1_1_percentage As XmlElement = xmlDoc.CreateElement("percentage", ns)
        'a14_2_1_1_percentage.InnerText = "0.00" ' CDec((comprobante.Descuento / comprobante.SubTotal) * 100).ToString("##0.00")
        'a14_2_1_rate.AppendChild(a14_2_1_1_percentage)
        'a14_2_monetaryAmountOrPercentage.AppendChild(a14_2_1_rate)
        'a14_allowanceCharge.AppendChild(a14_1_specialServicesType)
        'a14_allowanceCharge.AppendChild(a14_2_monetaryAmountOrPercentage)
        'requestForPayment.AppendChild(a14_allowanceCharge)

        '------ > Agregar a.15 <---------
        Dim count As Integer = 1
        For Each conceptoInf As ConceptoInfo In comprobante.Conceptos
            Dim a15_lineItem As XmlElement = xmlDoc.CreateElement("lineItem", ns)
            a15_lineItem.SetAttribute("type", "SimpleInvoiceLineItemType")
            a15_lineItem.SetAttribute("number", CStr(count))

            Dim a15_1_tradeItemIdentificaction As XmlElement = xmlDoc.CreateElement("tradeItemIdentification", ns)
            Dim a15_1_1_gtin As XmlElement = xmlDoc.CreateElement("gtin", ns)
            a15_1_1_gtin.InnerText = conceptoInf.EAN
            a15_1_tradeItemIdentificaction.AppendChild(a15_1_1_gtin)
            a15_lineItem.AppendChild(a15_1_tradeItemIdentificaction)

            Dim a15_2_alternateTradeItemIdentification As XmlElement = xmlDoc.CreateElement("alternateTradeItemIdentification", ns)
            a15_2_alternateTradeItemIdentification.SetAttribute("type", "GLOBAL_TRADE_ITEM_IDENTIFICATION")
            a15_2_alternateTradeItemIdentification.InnerText = conceptoInf.EAN
            a15_lineItem.AppendChild(a15_2_alternateTradeItemIdentification)

            Dim a15_3_tradeItemDescriptionInformation As XmlElement = xmlDoc.CreateElement("tradeItemDescriptionInformation", ns)
            a15_3_tradeItemDescriptionInformation.SetAttribute("language", "ES")
            Dim a15_3_1_longText As XmlElement = xmlDoc.CreateElement("longText", ns)
            a15_3_1_longText.InnerText = conceptoInf.Descripcion
            a15_3_tradeItemDescriptionInformation.AppendChild(a15_3_1_longText)
            a15_lineItem.AppendChild(a15_3_tradeItemDescriptionInformation)

            Dim a15_4_invoicedQuantity As XmlElement = xmlDoc.CreateElement("invoicedQuantity", ns)
            a15_4_invoicedQuantity.InnerText = conceptoInf.Cantidad.ToString("##0.00")
            a15_4_invoicedQuantity.SetAttribute("unitOfMeasure", "CA")
            a15_lineItem.AppendChild(a15_4_invoicedQuantity)

            Dim a15_5_aditionalQuantity As XmlElement = xmlDoc.CreateElement("aditionalQuantity", ns)
            a15_5_aditionalQuantity.SetAttribute("QuantityType", "NUM_CONSUMER_UNITS")
            a15_5_aditionalQuantity.InnerText = conceptoInf.CantidadConsumo.ToString
            a15_lineItem.AppendChild(a15_5_aditionalQuantity)

            Dim netPrice As Decimal = CDec(conceptoInf.ValorUnitario - conceptoInf.MontoDescuento1 - conceptoInf.MontoDescuento2 - conceptoInf.MontoDescuento3)

            Dim a15_6_grossPrice As XmlElement = xmlDoc.CreateElement("grossPrice", ns)
            Dim a15_6_1_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
            a15_6_1_Amount.InnerText = netPrice.ToString("##0.00")

            a15_6_grossPrice.AppendChild(a15_6_1_Amount)
            a15_lineItem.AppendChild(a15_6_grossPrice)

            Dim a15_7_netPrice As XmlElement = xmlDoc.CreateElement("netPrice", ns)
            Dim a15_7_1_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
            a15_7_1_Amount.InnerText = netPrice.ToString("##0.00")

            a15_7_netPrice.AppendChild(a15_7_1_Amount)
            a15_lineItem.AppendChild(a15_7_netPrice)

            'Dim a15_13_allowanceCharge As XmlElement = xmlDoc.CreateElement("allowanceCharge", ns)
            'a15_13_allowanceCharge.SetAttribute("allowanceChargeType", "ALLOWANCE_GLOBAL")
            'a15_13_allowanceCharge.SetAttribute("settlementType", "OFF_INVOICE")

            'Dim a15_13_1_specialServicesType As XmlElement = xmlDoc.CreateElement("specialServicesType", ns)
            'a15_13_1_specialServicesType.InnerText = "DI"

            'Dim a15_13_2_monetaryAmountOrPercentage As XmlElement = xmlDoc.CreateElement("monetaryAmountOrPercentage", ns)

            'Dim a15_13_2_1_percentagePerUnit As XmlElement = xmlDoc.CreateElement("percentagePerUnit", ns)
            'a15_13_2_1_percentagePerUnit.InnerText = CDec(((conceptoInf.MontoDescuento1 + conceptoInf.MontoDescuento2 + conceptoInf.MontoDescuento3) / conceptoInf.ValorUnitario) * 100).ToString("##0.00")
            'a15_13_2_monetaryAmountOrPercentage.AppendChild(a15_13_2_1_percentagePerUnit)

            'a15_13_allowanceCharge.AppendChild(a15_13_1_specialServicesType)
            'a15_13_allowanceCharge.AppendChild(a15_13_2_monetaryAmountOrPercentage)

            'a15_lineItem.AppendChild(a15_13_allowanceCharge)
            If conceptoInf.PorcentajeImpuestoTrasladado1 > 0 Then
                Dim a15_14_tradeItemTaxInformation As XmlElement = xmlDoc.CreateElement("tradeItemTaxInformation", ns)
                Dim a15_14_1_taxTypeDescription As XmlElement = xmlDoc.CreateElement("taxTypeDescription", ns)
                a15_14_1_taxTypeDescription.InnerText = "VAT"
                a15_14_tradeItemTaxInformation.AppendChild(a15_14_1_taxTypeDescription)

                Dim a15_14_3_tradeItemTaxAmount As XmlElement = xmlDoc.CreateElement("tradeItemTaxAmount", ns)
                Dim a15_14_3_1_taxPorcentege As XmlElement = xmlDoc.CreateElement("taxPercentage", ns)
                a15_14_3_1_taxPorcentege.InnerText = CDec(conceptoInf.PorcentajeImpuestoTrasladado1 * 100).ToString("##0.00")

                Dim a15_14_3_2_taxAmount As XmlElement = xmlDoc.CreateElement("taxAmount", ns)
                a15_14_3_2_taxAmount.InnerText = Decimal.Round(CDec(netPrice * conceptoInf.PorcentajeImpuestoTrasladado1 * conceptoInf.Cantidad), 2).ToString("##0.00") 'Monto del impuesto

                a15_14_3_tradeItemTaxAmount.AppendChild(a15_14_3_1_taxPorcentege)
                a15_14_3_tradeItemTaxAmount.AppendChild(a15_14_3_2_taxAmount)
                a15_14_tradeItemTaxInformation.AppendChild(a15_14_3_tradeItemTaxAmount)
                a15_lineItem.AppendChild(a15_14_tradeItemTaxInformation)
            End If

            Dim a15_15_totalLineAmount As XmlElement = xmlDoc.CreateElement("totalLineAmount", ns)
            Dim a15_15_1_grossAmount As XmlElement = xmlDoc.CreateElement("grossAmount", ns)
            Dim a15_15_1_1_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
            a15_15_1_1_Amount.InnerText = CDec((conceptoInf.ValorUnitario - conceptoInf.MontoDescuento1 - conceptoInf.MontoDescuento2 - conceptoInf.MontoDescuento3) * conceptoInf.Cantidad).ToString("##0.00")
            a15_15_1_grossAmount.AppendChild(a15_15_1_1_Amount)
            a15_15_totalLineAmount.AppendChild(a15_15_1_grossAmount)

            Dim a15_15_2_netAmount As XmlElement = xmlDoc.CreateElement("netAmount", ns)
            Dim a15_15_2_1_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
            a15_15_2_1_Amount.InnerText = CDec((conceptoInf.ValorUnitario - conceptoInf.MontoDescuento1 - conceptoInf.MontoDescuento2 - conceptoInf.MontoDescuento3) * conceptoInf.Cantidad).ToString("##0.00")
            a15_15_2_netAmount.AppendChild(a15_15_2_1_Amount)

            a15_15_totalLineAmount.AppendChild(a15_15_2_netAmount)

            a15_lineItem.AppendChild(a15_15_totalLineAmount)

            requestForPayment.AppendChild(a15_lineItem)
            count = count + 1
        Next
        'SUMARIO
        '------ > Agregar a.16 <---------
        'Sub Total de comprobante
        Dim a16_totalAmount As XmlElement = xmlDoc.CreateElement("totalAmount", ns)
        Dim a16_1_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
        a16_1_Amount.InnerText = CDec(comprobante.SubTotal - comprobante.Descuentos).ToString("##0.00")
        a16_totalAmount.AppendChild(a16_1_Amount)
        requestForPayment.AppendChild(a16_totalAmount)
        '------ > Agregar a.17 <---------
        'Total descuentos
        'Dim a17_totalAllowanceCharge As XmlElement = xmlDoc.CreateElement("TotalAllowanceCharge", ns)
        'a17_totalAllowanceCharge.SetAttribute("allowanceOrChargeType", "ALLOWANCE")
        'Dim a17_2_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
        'a17_2_Amount.InnerText = "0.00"
        'a17_totalAllowanceCharge.AppendChild(a17_2_Amount)
        'requestForPayment.AppendChild(a17_totalAllowanceCharge)
        '------ > Agregar a.18 <---------
        'Sub Total - Descuentos
        Dim a18_baseAmount As XmlElement = xmlDoc.CreateElement("baseAmount", ns)
        Dim a18_1_amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
        a18_1_amount.InnerText = CDec(comprobante.SubTotal - comprobante.Descuentos).ToString
        a18_baseAmount.AppendChild(a18_1_amount)
        requestForPayment.AppendChild(a18_baseAmount)
        '------ > Agregar a.19 <---------
        'Impuestos trasladados
        For Each impuesto As TrasladoInfo In comprobante.Impuestos.Traslados
            Dim a19_tax As XmlElement = xmlDoc.CreateElement("tax", ns)
            Select Case impuesto.Impuesto
                Case TipoImpuestoTraslado.IVA
                    a19_tax.SetAttribute("type", "VAT")
                Case TipoImpuestoTraslado.IEPS
                    a19_tax.SetAttribute("type", "GST")
            End Select
            Dim a19_1_taxPercentage As XmlElement = xmlDoc.CreateElement("taxPercentage", ns)
            a19_1_taxPercentage.InnerText = impuesto.Tasa.ToString("##0.00")
            Dim a19_2_taxAmount As XmlElement = xmlDoc.CreateElement("taxAmount", ns)
            a19_2_taxAmount.InnerText = impuesto.Importe.ToString("##0.00")
            Dim a19_3_taxCategory As XmlElement = xmlDoc.CreateElement("taxCategory", ns)
            a19_3_taxCategory.InnerText = "TRANSFERIDO"
            a19_tax.AppendChild(a19_1_taxPercentage)
            a19_tax.AppendChild(a19_2_taxAmount)
            a19_tax.AppendChild(a19_3_taxCategory)
            requestForPayment.AppendChild(a19_tax)
        Next
        'Impuestos retenidos
        For Each impuesto As RetencionCFDInfo In comprobante.Impuestos.Retenciones
            Dim a19_tax As XmlElement = xmlDoc.CreateElement("tax", ns)
            Select Case impuesto.Impuesto
                Case TipoImpuestoRetencion.IVA
                    a19_tax.SetAttribute("type", "VAT")
                Case TipoImpuestoRetencion.ISR
                    a19_tax.SetAttribute("type", "LAC")
            End Select
            Dim a19_2_taxAmount As XmlElement = xmlDoc.CreateElement("taxAmount", ns)
            a19_2_taxAmount.InnerText = impuesto.Importe.ToString("##0.00")
            Dim a19_3_taxCategory As XmlElement = xmlDoc.CreateElement("taxCategory", ns)
            a19_3_taxCategory.InnerText = "RETENIDO"
            a19_tax.AppendChild(a19_2_taxAmount)
            a19_tax.AppendChild(a19_3_taxCategory)
            requestForPayment.AppendChild(a19_tax)
        Next
        '------ > Agregar a.20 <---------
        'Total comprobante
        Dim a20_payableAmount As XmlElement = xmlDoc.CreateElement("payableAmount", ns)
        Dim a20_1_Amount As XmlElement = xmlDoc.CreateElement("Amount", ns)
        a20_1_Amount.InnerText = comprobante.Total.ToString("##0.00")
        a20_payableAmount.AppendChild(a20_1_Amount)
        requestForPayment.AppendChild(a20_payableAmount)
        '------ > Agregar a <---------
        Addenda.AppendChild(requestForPayment)
    End Sub


#End Region

#Region "Constructor"

    Public Sub New(ByVal sessionID As Guid)
        Me.SessionID = sessionID
        _Emisor = New EmisorInfo
        _Receptor = New ReceptorInfo
        _Conceptos = New ConceptosCollection
        _Impuestos = New ImpuestosInfo
        _TimbreFiscal = New TimbreFiscalInfo
        _ComercioExterior = New ComercioExteriorInfo
        _Version = "2.2"
    End Sub

#End Region

End Class



Public Class ComprobanteFiscalService

#Region "Constructores"
    Protected Session As SessionInfo
    Protected Connection As IDbConnection
    Protected Transaction As IDbTransaction
    Protected SessionID As Guid

    Public Sub New(ByVal sessionID As Guid, ByVal connection As IDbConnection, ByVal transaction As IDbTransaction)
        Me.SessionID = sessionID
        Me.Connection = connection
        Me.Transaction = transaction
        Session = Azteca.Kernel.Server.Sessions(sessionID)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal Connection As IDbConnection)
        Me.New(sessionID, Connection, Nothing)
    End Sub

#End Region

#Region "Metodos Privados"

    Private Function GetTimbrador(timbrador As TimbradorInfo) As ITimbrador
        Dim EnsambladoCacheKey As String = timbrador.Ensamblado & "_" & timbrador.Clase
        Dim Ensamblado As System.Reflection.Assembly
        If Azteca.Kernel.Cache.Contains(EnsambladoCacheKey) Then
            Ensamblado = CType(Azteca.Kernel.Cache.Item(EnsambladoCacheKey), System.Reflection.Assembly)
        Else
            Ensamblado = System.Reflection.Assembly.Load(timbrador.Ensamblado)
        End If
        Dim TimbradorInt As ITimbrador = CType(Ensamblado.CreateInstance(timbrador.Clase, False), ITimbrador)
        Return TimbradorInt
    End Function

    Protected Function Timbrar(comprobante As ComprobanteFiscalInfo, certificado As CertificadoInfo) As ComprobanteFiscalInfo
        Dim EmpresaSvc As New EmpresaService(SessionID, Connection, Transaction)
        Dim Empresa As EmpresaInfo = EmpresaSvc.GetDetailFromCache(certificado.IdEmpresa)
        'Cargar configuración de la empresa
        Dim EmpresaConfigSvc As New EmpresaConfigService(SessionID, Connection, Transaction)
        Dim Config As EmpresaConfigInfo = EmpresaConfigSvc.GetDetailFromCache(certificado.IdEmpresa)
        'Cargar información del timbrador
        Dim TimbradorSvc As New TimbradorService(SessionID, Connection, Transaction)
        Dim TimbradorInf As TimbradorInfo = TimbradorSvc.GetDetailFromCache(Config.IdTimbrador)
        'Crear una instancia del timbrador
        Dim Timbrador As ITimbrador = GetTimbrador(TimbradorInf)
        'Si el usuario es el de pruebas, cambiar rfc del emisor y regenerar cadena original y sello digital
        If TimbradorInf.Usuario.Trim.ToLower = "test" Then
            comprobante.Emisor.RFC = "GOYA780416GM0"
            comprobante.Emisor.RFC = "APR0412108C5"
            Dim comprobanteXML As XmlDocument = comprobante.GetXML(FormatoCFD.CFDI)
            Dim CadenaOriginal As String = GenerarCadenaOriginal_V3(comprobanteXML)
            comprobante.Sello = GenerarSelloDigital(CadenaOriginal, certificado)
        End If
        Timbrador.IniciarSersion(Empresa.RFC, TimbradorInf.Usuario, TimbradorInf.Password)
        comprobante = Timbrador.Timbrar(comprobante)
        Return comprobante
    End Function

    Private Sub CancelarTimbre(UUID As String, certificado As CertificadoInfo, idEmpresa As Integer)
        'Cargar configuración de la empresa
        Dim EmpresaConfigSvc As New EmpresaConfigService(SessionID, Connection, Transaction)
        Dim Config As EmpresaConfigInfo = EmpresaConfigSvc.GetDetailFromCache(idEmpresa)
        '
        Dim EmpresaSvc As New EmpresaService(SessionID, Connection, Transaction)
        Dim EmpresaInf As EmpresaInfo = EmpresaSvc.GetDetailFromCache(idEmpresa)

        'Cargar información del timbrador
        Dim TimbradorSvc As New TimbradorService(SessionID, Connection, Transaction)
        Dim TimbradorInf As TimbradorInfo = TimbradorSvc.GetDetailFromCache(Config.IdTimbrador)
        'Crear una instancia del timbrador
        Dim Timbrador As ITimbrador = GetTimbrador(TimbradorInf)
        Timbrador.IniciarSersion(EmpresaInf.RFC, TimbradorInf.Usuario, TimbradorInf.Password)
        Timbrador.Cancelar(UUID, EmpresaInf.RFC, certificado)
    End Sub


    Protected Overridable Sub CargarEmisor(ByVal comprobante As ComprobanteFiscalInfo, ByVal emisor As XmlElement, ByVal nsManager As XmlNamespaceManager)
        Try
            With comprobante
                .Emisor.RFC = emisor.GetAttribute("rfc")
                .Emisor.Nombre = emisor.GetAttribute("nombre")
                Dim Domicilio As XmlElement = CType(emisor.SelectSingleNode("/cfd:Comprobante/cfd:Emisor/cfd:DomicilioFiscal", nsManager), XmlElement)
                With .Emisor.DomicilioFiscal
                    .Calle = Domicilio.GetAttribute("calle")
                    .NumExt = Domicilio.GetAttribute("noExterior")
                    .NumInt = Domicilio.GetAttribute("noInterior")
                    .Colonia = Domicilio.GetAttribute("colonia")
                    .Localidad = Domicilio.GetAttribute("localidad")
                    .Referencia = Domicilio.GetAttribute("referencia")
                    .Municipio = Domicilio.GetAttribute("municipio")
                    If .Localidad = String.Empty And .Municipio <> String.Empty Then .Localidad = .Municipio
                    .Estado = Domicilio.GetAttribute("estado")
                    .Pais = Domicilio.GetAttribute("pais")
                    .CodigoPostal = Domicilio.GetAttribute("codigoPostal")
                End With
                Dim LugarExp As XmlElement = CType(emisor.SelectSingleNode("/cfd:Comprobante/cfd:Emisor/cfd:ExpedidoEn", nsManager), XmlElement)
                With .Emisor.LugarExpedicion
                    .Calle = LugarExp.GetAttribute("calle")
                    .NumExt = LugarExp.GetAttribute("noExterior")
                    .NumInt = LugarExp.GetAttribute("noInterior")
                    .Colonia = LugarExp.GetAttribute("colonia")
                    .Localidad = LugarExp.GetAttribute("localidad")
                    .Referencia = LugarExp.GetAttribute("referencia")
                    .Municipio = LugarExp.GetAttribute("municipio")
                    If .Localidad = String.Empty And .Municipio <> String.Empty Then .Localidad = .Municipio
                    .Estado = LugarExp.GetAttribute("estado")
                    .Pais = LugarExp.GetAttribute("pais")
                    .CodigoPostal = LugarExp.GetAttribute("codigoPostal")
                End With
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los datos del emisor", ex)
        End Try
    End Sub

    Protected Overridable Sub CargarReceptor(ByVal comprobante As ComprobanteFiscalInfo, ByVal receptor As XmlElement, ByVal nsManager As XmlNamespaceManager)
        Try
            With comprobante
                .Receptor.RFC = receptor.GetAttribute("rfc")
                .Receptor.Nombre = receptor.GetAttribute("nombre")
                Dim Domicilio As XmlElement = CType(receptor.SelectSingleNode("/cfd:Comprobante/cfd:Receptor/cfd:Domicilio", nsManager), XmlElement)
                With .Receptor.Domicilio
                    .Calle = Domicilio.GetAttribute("calle")
                    .NumExt = Domicilio.GetAttribute("noExterior")
                    .NumInt = Domicilio.GetAttribute("noInterior")
                    .Colonia = Domicilio.GetAttribute("colonia")
                    .Localidad = Domicilio.GetAttribute("localidad")
                    .Referencia = Domicilio.GetAttribute("referencia")
                    .Municipio = Domicilio.GetAttribute("municipio")
                    If .Localidad = String.Empty And .Municipio <> String.Empty Then .Localidad = .Municipio
                    .Estado = Domicilio.GetAttribute("estado")
                    .Pais = Domicilio.GetAttribute("pais")
                    .CodigoPostal = Domicilio.GetAttribute("codigoPostal")
                End With
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los datos del receptor.", ex)
        End Try
    End Sub

    Protected Overridable Sub CargarConceptos(ByVal comprobante As ComprobanteFiscalInfo, ByVal conceptos As XmlElement)
        Try
            For Each concepto As XmlElement In conceptos.ChildNodes
                Dim ConceptoInf As New ConceptoInfo
                With ConceptoInf
                    .Cantidad = CDec(concepto.GetAttribute("cantidad"))
                    .Unidad = concepto.GetAttribute("unidad")
                    .Codigo = concepto.GetAttribute("noIdentificacion")
                    .Descripcion = concepto.GetAttribute("descripcion")
                    .ValorUnitario = CDec(concepto.GetAttribute("valorUnitario"))
                    If concepto.GetAttribute("agrupador") <> String.Empty Then
                        Dim TasaIVA As Decimal = 0
                        If comprobante.Impuestos.Traslados.Count > 0 Then TasaIVA = comprobante.Impuestos.Traslados(0).Tasa / 100
                        If CInt(concepto.GetAttribute("agrupador")) = 1 Then
                            .PorcentajeImpuestoTrasladado1 = TasaIVA
                            .MontoImpuestoTrasladado1 = .ValorUnitario * TasaIVA
                        End If
                    End If
                End With
                comprobante.Conceptos.Add(ConceptoInf)
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los conceptos del CFD.", ex)
        End Try
    End Sub

    Protected Overridable Sub CargarImpuestos(ByVal comprobante As ComprobanteFiscalInfo, ByVal impuestos As XmlElement, ByVal nsManager As XmlNamespaceManager)
        Try
            Dim Retenciones As XmlElement = CType(impuestos.SelectSingleNode("/cfd:Comprobante/cfd:Impuestos/cfd:Retenciones", nsManager), XmlElement)
            If Retenciones IsNot Nothing Then
                For Each retencion As XmlElement In Retenciones.ChildNodes
                    Dim retencionInf As New RetencionCFDInfo
                    With retencionInf
                        .Impuesto = GetTipoImpuestoRetencion(retencion.GetAttribute("impuesto"))
                        .Importe = CDec(retencion.GetAttribute("importe"))
                    End With
                    comprobante.Impuestos.Retenciones.Add(retencionInf)
                Next
            End If
            Dim Traslados As XmlElement = CType(impuestos.SelectSingleNode("/cfd:Comprobante/cfd:Impuestos/cfd:Traslados", nsManager), XmlElement)
            If Traslados IsNot Nothing Then
                For Each traslado As XmlElement In Traslados.ChildNodes
                    Dim trasladoInf As New TrasladoInfo
                    With trasladoInf
                        .Impuesto = GetTipoImpuestoTraslado(traslado.GetAttribute("impuesto"))
                        .Tasa = CDec(traslado.GetAttribute("tasa"))
                        .Importe = CDec(traslado.GetAttribute("importe"))
                    End With
                    comprobante.Impuestos.Traslados.Add(trasladoInf)
                Next
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los impuestos del CFD.", ex)
        End Try
    End Sub

    Protected Overridable Sub CargarTimbreFiscal(comprobante As ComprobanteFiscalInfo, timbreFiscal As XmlElement, nsManager As XmlNamespaceManager)
        With comprobante.TimbreFiscal
            ._Version = timbreFiscal.GetAttribute("version")
            ._UUID = timbreFiscal.GetAttribute("UUID")
            ._Fecha = CDate(timbreFiscal.GetAttribute("FechaTimbrado"))
            ._SelloCFD = timbreFiscal.GetAttribute("selloCFD")
            ._NumeroCertificadoSAT = timbreFiscal.GetAttribute("noCertificadoSAT")
            ._SelloSAT = timbreFiscal.GetAttribute("selloSAT")
        End With
    End Sub

    Protected Function GetVersion(comprobanteXML As XmlDocument) As Decimal
        Dim PrimaryNodeIndex As Integer = 0
        If comprobanteXML.ChildNodes.Count > 1 Then PrimaryNodeIndex = 1
        'Determinar la versión del comprobante
        Dim Version As Decimal = CDec(comprobanteXML.ChildNodes(PrimaryNodeIndex).Attributes("version").Value)
        Return Version
    End Function

    Protected Function GenerarCadenaOriginalTimbre(comprobante As ComprobanteFiscalInfo) As String
        Dim CadenaOriginal As New System.Text.StringBuilder()
        With CadenaOriginal
            .Append("||")
            .Append(comprobante.TimbreFiscal.Version & "|")
            .Append(comprobante.TimbreFiscal.UUID & "|")
            .Append(comprobante.TimbreFiscal.Fecha.ToString("yyyy-MM-dd") & "T" & comprobante.TimbreFiscal.Fecha.ToString("HH:mm:ss") & "Z|")
            .Append(comprobante.TimbreFiscal.SelloCFD & "|")
            .Append(comprobante.TimbreFiscal.SelloSAT & "||")
        End With
        Return CadenaOriginal.ToString()
    End Function

    Private Function GenerarCadenaOriginal_V2(ByVal comprobante As XmlDocument) As String
        Dim CacheKey As String = "CadenaOriginalXSLT_V2_2"
        Dim Navigator As XPathNavigator = comprobante.CreateNavigator
        Dim Transformer As XslCompiledTransform = Nothing
        If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
            Transformer = New XslCompiledTransform
            'Leer xslt de transformación de los recursos 
            Dim UtileriasPath As String = Azteca.Kernel.Server.ApplicationFolder & "\XSLT"
            Dim XSLTString As String = My.Resources.CadenOriginalXSLT_V2_2.Replace("[UTILITY_PATH]", UtileriasPath)
            Dim strReader As New StringReader(XSLTString)
            Dim Reader As XmlReader = XmlReader.Create(strReader)
            Transformer.Load(Reader)
            Azteca.Kernel.Cache.Add(CacheKey, Transformer, TimeSpan.FromDays(7))
        Else
            Transformer = CType(Azteca.Kernel.Cache.Item(CacheKey), XslCompiledTransform)
        End If
        '        
        Dim CadenaOriginal As New System.Text.StringBuilder()
        Dim strWriter As New StringWriter(CadenaOriginal)
        Transformer.Transform(Navigator, Nothing, strWriter)
        Return CadenaOriginal.ToString.Trim
    End Function

    Protected Function GenerarCadenaOriginal_V3(ByVal factura As XmlDocument) As String
        Dim Navigator As XPathNavigator = factura.CreateNavigator
        Dim Transformer As XslCompiledTransform = Nothing
        If Azteca.Kernel.Cache.Item("CadenaOriginalXSLT_V3") Is Nothing Then
            Transformer = New XslCompiledTransform
            'Leer xslt de transformación de los recursos 
            Dim UtileriasPath As String = Azteca.Kernel.Server.ApplicationFolder & "\XSLT"
            Dim XSLTString As String = My.Resources.CadenaOriginalXSLT_V3_2.Replace("[UTILITY_PATH]", UtileriasPath)
            Dim strReader As New StringReader(XSLTString)
            Dim Reader As XmlReader = XmlReader.Create(strReader)
            Transformer.Load(Reader)
            Azteca.Kernel.Cache.Add("CadenaOriginalXSLT_V3", Transformer, TimeSpan.FromDays(7))
        Else
            Transformer = CType(Azteca.Kernel.Cache.Item("CadenaOriginalXSLT_V3"), XslCompiledTransform)
        End If
        '        
        Dim CadenaOriginal As New System.Text.StringBuilder()
        Dim strWriter As New StringWriter(CadenaOriginal)
        Transformer.Transform(Navigator, Nothing, strWriter)
        Return CadenaOriginal.ToString.Trim
    End Function

    Protected Function GenerarSelloDigital(ByVal cadenaOriginal As String, ByVal certificado As CertificadoInfo) As String
        Try
            'Obtener llave privada
            Dim success As Boolean = True
            Dim PK As New PrivateKey()
            success = PK.LoadPkcs8Encrypted(certificado.LlavePrivada, certificado.PasswordPrivateKey)
            If Not success Then Throw New BusinessException("Error al cargar la llave privada (modo encriptado) para facturación")
            'Transformar a xml
            Dim PrivateKeyXML As String = PK.GetXml
            'Configurar componente RSA, si ya existe cargarlo del caché
            Dim RSA As New Rsa
            success = RSA.UnlockComponent("AZTECARSA_vhvTCZ0KjHwn")
            If Not success Then Throw New BusinessException("Error de licencia en componente de encriptación")
            success = RSA.ImportPrivateKey(PrivateKeyXML)
            If Not success Then Throw New BusinessException("Error al importar la llave privada de facturación: " & RSA.LastErrorText)
            RSA.EncodingMode = "base64"
            RSA.Charset = "utf-8"
            RSA.LittleEndian = False
            'Generar firma de la cadena original
            Dim DigitalSignature As String = RSA.SignStringENC(cadenaOriginal, "sha-1")
            Return DigitalSignature
        Catch ex As Exception
            Throw New BusinessException("Error al generar el sello digital", ex)
        End Try
    End Function

    Protected Function GetTipoComprobante(ByVal tipo As String) As TipoComprobante
        Select Case tipo.ToLower
            Case "ingreso"
                Return TipoComprobante.Ingreso
            Case "egreso"
                Return TipoComprobante.Egreso
            Case "traslado"
                Return TipoComprobante.Traslado
            Case Else
                Return TipoComprobante.Ingreso
        End Select
    End Function

    Private Function GetTipoImpuestoRetencion(ByVal tipo As String) As TipoImpuestoRetencion
        Select Case tipo.ToLower
            Case "isr"
                Return TipoImpuestoRetencion.ISR
            Case "iva"
                Return TipoImpuestoRetencion.IVA
            Case Else
                Return TipoImpuestoRetencion.IVA
        End Select
    End Function

    Private Function GetTipoImpuestoTraslado(ByVal tipo As String) As TipoImpuestoTraslado
        Select Case tipo.ToLower
            Case "iva"
                Return TipoImpuestoTraslado.IVA
            Case "ieps"
                Return TipoImpuestoTraslado.IEPS
            Case Else
                Return TipoImpuestoTraslado.IVA
        End Select
    End Function

    Private Function GetTipoCFD(ByVal tipo As Integer) As TipoCFD
        Select Case tipo
            Case 1
                Return TipoCFD.Factura
            Case 2
                Return TipoCFD.NotaCargo
            Case 3
                Return TipoCFD.NotaCredito
            Case 4
                Return TipoCFD.NotaVenta
            Case Else
                Return TipoCFD.Factura
        End Select
    End Function

    Private Function GetNuevoFolio(ByVal serie As SerieInfo) As Integer
        Dim spNuevo As New StoredProcedure("Accounting", "CFDNuevoFolio", Connection, Transaction)
        spNuevo.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = serie.Identity
        spNuevo.Parameters.Add("@Folio", DbType.Int32, ParameterDirection.InputOutput).Value = 0
        spNuevo.Execute()
        Dim Folio As Integer = CInt(spNuevo.Parameters("@Folio").Value)
        'Validar que el nuevo folio no sea mayor al limite de la sucursal
        If Folio > serie.FolioLimite Then Throw New BusinessException("Se ha excedido el limite de folios concedidos por el SAT. Solicite un nuevo rango de folios")
        Return Folio
    End Function

    Private Function GetNumeroAprobacion(ByVal serie As SerieInfo, ByVal folio As Integer) As Integer
        Dim vwFolios As New DataView(serie.Folios, "FolioInicial <= " & folio.ToString & " AND FolioFinal >= " & folio.ToString, String.Empty, DataViewRowState.CurrentRows)
        If vwFolios.Count > 0 Then
            Dim drv As DataRowView = vwFolios(0)
            Return CInt(drv("NumAprobacion"))
        Else
            Throw New BusinessException("No se pudo encontrar el número de aprobación para el folio " & serie.Serie & "-" & folio.ToString)
        End If
    End Function

    Private Function GetAnioAprobacion(ByVal serie As SerieInfo, ByVal folio As Integer) As Integer
        Dim vwFolios As New DataView(serie.Folios, "FolioInicial <= " & folio.ToString & " AND FolioFinal >= " & folio.ToString, String.Empty, DataViewRowState.CurrentRows)
        If vwFolios.Count > 0 Then
            Dim drv As DataRowView = vwFolios(0)
            Return CInt(drv("AnioAprobacion"))
        Else
            Throw New BusinessException("No se pudo encontrar el año de aprobación para el folio " & serie.Serie & "-" & folio.ToString)
        End If
    End Function

    Private Function GetQrCode(comprobante As ComprobanteFiscalInfo) As Byte()
        Dim Text As New System.Text.StringBuilder()
        Text.Append("?re=" & comprobante.Emisor.RFC)
        Text.Append("&rr=" & comprobante.Receptor.RFC)
        Text.Append("&tt=" & comprobante.Total.ToString("0000000000.000000"))
        Text.Append("&id=" & comprobante.UUID)
        '
        Dim QrCode As New C1.Win.C1BarCode.C1QRCode()
        QrCode.Text = Text.ToString()
        Dim QrImage As System.Drawing.Image = QrCode.GetImage(System.Drawing.Imaging.ImageFormat.Jpeg, 250, 250)
        Dim msQrCode As New System.IO.MemoryStream()
        QrImage.Save(msQrCode, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return msQrCode.GetBuffer()
    End Function

    Protected Sub Save(ByVal comprobante As ComprobanteFiscalInfo, ByVal cadenaOriginalCFD As String, cadenaOriginalTimbre As String, tipoCFD As FormatoCFD)
        If comprobante.Total < comprobante.Impuestos.TotalTraslados Then
            Throw New BusinessException("El monto total del comprobante no puede ser menor al impuesto de la misma.")
        End If
        'Obtener el xml como cadena
        Dim ComprobanteXML As XmlDocument = comprobante.GetXML(tipoCFD)
        Dim xmlText As New System.Text.StringBuilder
        Dim writer As New System.IO.StringWriter(xmlText)
        ComprobanteXML.Save(writer)
        Dim xmlString As String = xmlText.ToString
        'Generar QrCode del comprobante
        comprobante._QrCode = GetQrCode(comprobante)
        'Guardar factura en base de datos
        Dim spUpdate As New StoredProcedure("Accounting", "CFDUpdate", Connection, Transaction)
        With spUpdate
            .Parameters.Add("@FechaComprobante", DbType.DateTime).Value = comprobante.Fecha.Date
            .Parameters.Add("@HoraComprobante", DbType.DateTime).Value = comprobante.Fecha
            .Parameters.Add("@IdCFDSerie", DbType.Int32).Value = comprobante.IdSerie
            .Parameters.Add("@Folio", DbType.Int32).Value = comprobante.Folio
            .Parameters.Add("@UUID", DbType.String).Value = comprobante.UUID
            .Parameters.Add("@FechaTimbrado", DbType.DateTime).Value = comprobante.TimbreFiscal.Fecha
            .Parameters.Add("@FechaDocumento", DbType.DateTime).Value = comprobante.FechaDocumento
            .Parameters.Add("@IdDocumento", DbType.String).Value = comprobante.IdDocumento
            .Parameters.Add("@Comprobante", DbType.Xml).Value = xmlString
            .Parameters.Add("@CadenaOriginal", DbType.String).Value = cadenaOriginalCFD
            .Parameters.Add("@SelloDigital", DbType.String).Value = comprobante.Sello
            .Parameters.Add("@NumCertificado", DbType.String).Value = comprobante.NumeroCertificado
            .Parameters.Add("@AnioAprobacion", DbType.Int32).Value = comprobante.AnioAprobacion
            .Parameters.Add("@NumAprobacion", DbType.Int32).Value = comprobante.NumeroAprobacion
            .Parameters.Add("@NumCertificadoSAT", DbType.String).Value = comprobante.TimbreFiscal.NumeroCertificadoSAT
            .Parameters.Add("@SelloSAT", DbType.String).Value = comprobante.TimbreFiscal.SelloSAT
            .Parameters.Add("@CadenaOriginalCert", DbType.String).Value = cadenaOriginalTimbre
            .Parameters.Add("@IdCliente", DbType.Int32).Value = comprobante.IdCliente
            .Parameters.Add("@CalleEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.Calle
            .Parameters.Add("@NumExtEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.NumExt
            .Parameters.Add("@NumIntEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.NumInt
            .Parameters.Add("@ColoniaEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.Colonia
            .Parameters.Add("@LocalidadEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.Localidad
            .Parameters.Add("@MunicipioEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.Municipio
            .Parameters.Add("@EstadoEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.Estado
            .Parameters.Add("@PaisEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.Pais
            .Parameters.Add("@CPEnvio", DbType.String).Value = comprobante.Receptor.DomicilioEnvio.CodigoPostal
            .Parameters.Add("@IdDivisa", DbType.Int32).Value = comprobante.IdDivisa
            .Parameters.Add("@Divisa", DbType.String).Value = comprobante.Divisa
            .Parameters.Add("@TipoCambio", DbType.Decimal).Value = comprobante.TipoCambio
            .Parameters.Add("@SubTotal", DbType.Decimal).Value = comprobante.SubTotal
            .Parameters.Add("@Descuentos", DbType.Decimal).Value = comprobante.Descuentos
            .Parameters.Add("@ImpTrasladados", DbType.Decimal).Value = comprobante.Impuestos.TotalTraslados
            .Parameters.Add("@ImpRetenidos", DbType.Decimal).Value = comprobante.Impuestos.TotalRetenciones
            .Parameters.Add("@Total", DbType.Decimal).Value = comprobante.Total
            .Parameters.Add("@IdSucursal", DbType.Int32).Value = comprobante.IdSucursal
            .Parameters.Add("@IdCFDTipo", DbType.Int32).Value = comprobante.TipoDocumento
            .Parameters.Add("@Credito", DbType.Boolean).Value = comprobante.Credito
            .Parameters.Add("@DiasCredito", DbType.Int32).Value = comprobante.DiasCredito
            .Parameters.Add("@Referencia", DbType.String).Value = comprobante.Referencia
            .Parameters.Add("@IdCFDAddenda", DbType.Int32).Value = comprobante.IdAddenda
            .Parameters.Add("@GLNBuyer", DbType.String).Value = comprobante.GLNBuyer
            .Parameters.Add("@GLNStore", DbType.String).Value = comprobante.GLNStore
            .Parameters.Add("@GLNSeller", DbType.String).Value = comprobante.GLNSeller
            .Parameters.Add("@SellerID", DbType.String).Value = comprobante.SellerID
            .Parameters.Add("@IdCFDSerieOrig", DbType.Int32).Value = comprobante.IdSerie
            .Parameters.Add("@FolioCFDOrig", DbType.Int32).Value = Val(comprobante.FolioFiscalOrigen)
            .Parameters.Add("@UUIDCFDOrig", DbType.String).Value = comprobante.UUIDFiscalOrigen
            .Parameters.Add("@FechaCFDOrig", DbType.DateTime).Value = comprobante.FechaFolioFiscalOrigen
            .Parameters.Add("@MontoCFDOrig", DbType.Decimal).Value = comprobante.MontoFolioFiscalOrigen
            .Parameters.Add("@Version", DbType.Decimal).Value = CDec(comprobante.Version)
            .Parameters.Add("@QrCode", DbType.Binary).Value = comprobante.QrCode
            .Parameters.Add("@UserUpdate", DbType.Int32).Value = Session.User.Identity
            .Parameters.Add("@PCUpdate", DbType.String).Value = Session.WorkStation
            .Execute()
        End With
        SaveDetail(comprobante)
        'Si el cliente tiene una addenda especial, enviar archivo de factura por el puerto AS2
        If comprobante.IdAddenda > 0 Then
            Try
                Dim OutgoingPath As String = Azteca.Kernel.Configuration.ConfigurationManager.SystemConfiguration.GetValue("Configuracion/Ventas/Facturacion", "ServidorAS2")
                ComprobanteXML.Save(OutgoingPath & "\" & comprobante.Serie.Trim & comprobante.Folio.ToString & ".xml")
            Catch ex As Exception
                AppEventLog.WriteEntry("Error al enviar el CFD al puerto AS2. " & ex.ToString, EventLogType.Error)
            End Try
        End If
    End Sub

    Private Sub SaveDetail(ByVal comprobante As ComprobanteFiscalInfo)
        Try
            For Each concepto As ConceptoInfo In comprobante.Conceptos
                With concepto
                    Dim spInsert As New StoredProcedure("Accounting", "CFDConceptosUPD", Connection, Transaction)
                    spInsert.Parameters.Add("@Fechacomprobante", DbType.DateTime).Value = comprobante.Fecha.Date
                    spInsert.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = comprobante.IdSerie
                    spInsert.Parameters.Add("@Folio", DbType.Int32).Value = comprobante.Folio
                    spInsert.Parameters.Add("@UUID", DbType.String).Value = comprobante.UUID
                    spInsert.Parameters.Add("@IdArticulo", DbType.Int32).Value = .IdArticulo
                    spInsert.Parameters.Add("@IdServicio", DbType.Int32).Value = .IdServicio
                    spInsert.Parameters.Add("@Codigo", DbType.String).Value = .Codigo
                    spInsert.Parameters.Add("@Descripcion", DbType.String).Value = .Descripcion
                    spInsert.Parameters.Add("@EAN", DbType.String).Value = .EAN
                    spInsert.Parameters.Add("@Unidad", DbType.String).Value = .Unidad
                    spInsert.Parameters.Add("@Cantidad", DbType.Decimal).Value = .Cantidad
                    spInsert.Parameters.Add("@PrecioUnitario", DbType.Decimal).Value = .ValorUnitario
                    spInsert.Parameters.Add("@PorcImpTras1", DbType.Decimal).Value = .PorcentajeImpuestoTrasladado1
                    spInsert.Parameters.Add("@PorcImpTras2", DbType.Decimal).Value = .PorcentajeImpuestoTrasladado2
                    spInsert.Parameters.Add("@PorcImpTras3", DbType.Decimal).Value = .PorcentajeImpuestoTrasladado3
                    spInsert.Parameters.Add("@PorcImpRet1", DbType.Decimal).Value = .PorcentajeImpuestoRetenido1
                    spInsert.Parameters.Add("@PorcImpRet2", DbType.Decimal).Value = .PorcentajeImpuestoRetenido2
                    spInsert.Parameters.Add("@PorcImpRet3", DbType.Decimal).Value = .PorcentajeImpuestoRetenido3
                    spInsert.Parameters.Add("@PorcDesc1", DbType.Decimal).Value = .PorcentajeDescuento1
                    spInsert.Parameters.Add("@PorcDesc2", DbType.Decimal).Value = .PorcentajeDescuento2
                    spInsert.Parameters.Add("@PorcDesc3", DbType.Decimal).Value = .PorcentajeDescuento3
                    spInsert.Parameters.Add("@PorcDesc4", DbType.Decimal).Value = .PorcentajeDescuento4
                    spInsert.Parameters.Add("@PorcDesc5", DbType.Decimal).Value = .PorcentajeDescuento5
                    spInsert.Parameters.Add("@FactorUnidad", DbType.Int32).Value = .CantidadConsumo
                    spInsert.Parameters.Add("@IdDocumento", DbType.String).Value = comprobante.IdDocumento
                    spInsert.Parameters.Add("@FechaDocumento", DbType.DateTime).Value = comprobante.FechaDocumento
                    spInsert.Parameters.Add("@Referencia", DbType.String).Value = .Referencia
                    If .InformacionAduanera.Count > 0 Then
                        spInsert.Parameters.Add("@NumPedimento", DbType.String).Value = .InformacionAduanera(0).Numero
                        spInsert.Parameters.Add("@FechaPedimento", DbType.DateTime).Value = .InformacionAduanera(0).Fecha
                        spInsert.Parameters.Add("@Aduana", DbType.String).Value = .InformacionAduanera(0).Aduana
                    End If
                    spInsert.Execute()
                End With
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el detalle del CFD.", ex)
        End Try
    End Sub

    Private Sub DeleteDetail(ByVal fechaComprobante As Date, ByVal idSerie As Integer, ByVal folio As Integer)
        Try
            Dim spDelete As New StoredProcedure("Sales", "CFDConceptosDEL", Connection, Transaction)
            spDelete.Parameters.Add("@FechaComprobante", DbType.DateTime).Value = fechaComprobante
            spDelete.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            spDelete.Parameters.Add("@Folio", DbType.Int32).Value = folio
            spDelete.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al eliminar el detalle del CFD:" & folio.ToString, ex)
        End Try
    End Sub

    Private Sub CargarDetalle(ByVal comprobante As ComprobanteFiscalInfo)
        Try
            Dim fxSelect As New FunctionSQL("Accounting", "fxCFDConceptosSEL", Connection, Transaction)
            fxSelect.Parameters.Add("@Fechacomprobante", DbType.DateTime).Value = comprobante.Fecha.Date
            fxSelect.Parameters.Add("@IdCFDSerie", DbType.String).Value = comprobante.IdSerie
            fxSelect.Parameters.Add("@Folio", DbType.Int32).Value = comprobante.Folio
            Dim dtPartidas As New DataTable("Partidas")
            fxSelect.FillDataTable(dtPartidas)
            'Borrar los conceptos que se hayan creado en base al XML para recrearlos con el detalle de la comprobante
            comprobante.Conceptos.Clear()
            'Regenerar conceptos
            For Each dr As DataRow In dtPartidas.Rows
                Dim concepto As New ConceptoInfo
                With concepto
                    .IdArticulo = CInt(dr("IdArticulo"))
                    .IdServicio = CInt(dr("IdServicio"))
                    .Codigo = dr("Codigo").ToString
                    .Descripcion = dr("Descripcion").ToString
                    .Unidad = dr("Unidad").ToString
                    .Cantidad = CDec(dr("Cantidad"))
                    .ValorUnitario = CDec(dr("PrecioUnitario"))
                    .PorcentajeImpuestoTrasladado1 = CDec(dr("PorcImpTras1"))
                    .PorcentajeImpuestoTrasladado2 = CDec(dr("PorcImpTras2"))
                    .PorcentajeImpuestoTrasladado3 = CDec(dr("PorcImpTras3"))
                    .PorcentajeImpuestoRetenido1 = CDec(dr("PorcImpRet1"))
                    .PorcentajeImpuestoRetenido2 = CDec(dr("PorcImpRet2"))
                    .PorcentajeImpuestoRetenido3 = CDec(dr("PorcImpRet3"))
                    .PorcentajeDescuento1 = CDec(dr("PorcDesc1"))
                    .PorcentajeDescuento2 = CDec(dr("PorcDesc2"))
                    .PorcentajeDescuento3 = CDec(dr("PorcDesc3"))
                    .PorcentajeDescuento4 = CDec(dr("PorcDesc4"))
                    .PorcentajeDescuento5 = CDec(dr("PorcDesc5"))
                    .EAN = dr("EAN").ToString
                    .CantidadConsumo = CInt(dr("FactorUnidad"))
                    .FechaDocumento = CDate(dr("FechaDocumento"))
                    .IdDocumento = dr("IdDocumento").ToString
                    .Referencia = dr("Referencia").ToString
                    If dr("NumPedimento") IsNot DBNull.Value AndAlso dr("NumPedimento").ToString.Trim <> String.Empty Then
                        Dim InfoPedimento As New InformacionAduanera()
                        InfoPedimento.Numero = dr("NumPedimento").ToString()
                        InfoPedimento.Fecha = CDate(dr("FechaPedimento"))
                        InfoPedimento.Aduana = dr("Aduana").ToString()
                    End If
                End With
                comprobante.Conceptos.Add(concepto)
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el detalle del CFD " & comprobante.Serie & " " & comprobante.Folio.ToString, ex)
        End Try
    End Sub

    Private Function Cargar(ByVal dtComprobante As DataTable) As ComprobanteFiscalInfo
        If dtComprobante.Rows.Count > 0 Then
            Dim drComprobante As DataRow = dtComprobante.Rows(0)
            Dim IdSerie As Integer = CInt(drComprobante("IdCFDSerie"))
            'Obtener el xml
            Dim xmlString As String = CStr(drComprobante("Comprobante"))
            Dim xmlComprobante As New XmlDocument
            xmlComprobante.LoadXml(xmlString)
            'Determinar la versión del comprobante
            Dim Version As Decimal = GetVersion(xmlComprobante)
            Dim Comprobante As ComprobanteFiscalInfo = GetComprobanteFiscal(xmlString, Version)
            With Comprobante
                .IdSerie = IdSerie
                .IdDocumento = CStr(drComprobante("IdDocumento")).Trim
                .FechaDocumento = CDate(drComprobante("FechaDocumento"))
                .IdCliente = CInt(drComprobante("IdCliente"))
                .Receptor.DomicilioEnvio.Calle = drComprobante("CalleEnvio").ToString
                .Receptor.DomicilioEnvio.NumExt = drComprobante("NumExtEnvio").ToString
                .Receptor.DomicilioEnvio.NumInt = drComprobante("NumIntEnvio").ToString
                .Receptor.DomicilioEnvio.Colonia = drComprobante("ColoniaEnvio").ToString
                .Receptor.DomicilioEnvio.Localidad = drComprobante("LocalidadEnvio").ToString
                .Receptor.DomicilioEnvio.Municipio = drComprobante("MunicipioEnvio").ToString
                .Receptor.DomicilioEnvio.Estado = drComprobante("EstadoEnvio").ToString
                .Receptor.DomicilioEnvio.Pais = drComprobante("PaisEnvio").ToString
                .Receptor.DomicilioEnvio.CodigoPostal = drComprobante("CPEnvio").ToString
                ._Cancelada = Not CBool(drComprobante("Activa"))
                If .Cancelada Then ._FechaCancelacion = CDate(drComprobante("FechaCancelacion"))
                .IdSucursal = CInt(drComprobante("IdSucursal"))
                .TipoDocumento = GetTipoCFD(CInt(drComprobante("IdCFDTipo")))
                .Credito = CBool(drComprobante("Credito"))
                .DiasCredito = CInt(drComprobante("DiasCredito"))
                .Referencia = drComprobante("Referencia").ToString
                .IdAddenda = CInt(drComprobante("IdCFDAddenda"))
                .GLNBuyer = drComprobante("GLNBuyer").ToString
                .GLNStore = drComprobante("GLNStore").ToString
                .GLNSeller = drComprobante("GLNSeller").ToString
                .SellerID = drComprobante("SellerID").ToString
                .IdDivisa = CInt(drComprobante("IdDivisa"))
                .Divisa = drComprobante("Divisa").ToString
                .TipoCambio = CDec(drComprobante("TipoCambio"))
                If drComprobante("QrCode") IsNot DBNull.Value Then ._QrCode = CType(drComprobante("QrCode"), Byte())
            End With
            CargarDetalle(Comprobante)
            Return Comprobante
        Else
            Return Nothing
        End If
    End Function

    Private Sub CalcularTotales(ByVal comprobante As ComprobanteFiscalInfo)
        'Actualizar montos en el detalle
        Dim SubTotal, TotalDescuentos, Total As Decimal
        For Each Concepto As ConceptoInfo In comprobante.Conceptos
            With Concepto
                SubTotal += .ValorUnitario * .Cantidad
                TotalDescuentos += ((.MontoDescuento1 + .MontoDescuento2 + .MontoDescuento3 + .MontoDescuento4 + .MontoDescuento5) * .Cantidad)
            End With
        Next
        'Actualizar totales
        Total = SubTotal + comprobante.Impuestos.TotalTraslados - comprobante.Impuestos.TotalRetenciones - TotalDescuentos
        comprobante.SubTotal = SubTotal
        comprobante.Descuentos = TotalDescuentos
        comprobante.Total = Total
    End Sub

#End Region

#Region "Metodos Publicos"


    Public Function GetComprobanteFiscal(ByVal xml As String, version As Decimal) As ComprobanteFiscalInfo
        Dim ComprobanteXML As New XmlDocument
        ComprobanteXML.LoadXml(xml)
        '
        Dim nsManager As New XmlNamespaceManager(ComprobanteXML.NameTable)
        If version >= 2 And version < 3 Then
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/2")
        Else
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/3")
            nsManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        End If
        '
        Dim ComprobanteFiscal As New ComprobanteFiscalInfo(SessionID)
        Dim Comprobante As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante", nsManager), XmlElement)
        With ComprobanteFiscal
            .Version = Comprobante.GetAttribute("version")
            .Serie = Comprobante.GetAttribute("serie")
            ._Folio = CInt(Comprobante.GetAttribute("folio"))
            .Fecha = CDate(Comprobante.GetAttribute("fecha"))
            .Sello = Comprobante.GetAttribute("sello")
            If version < 3 Then
                ._NumeroAprobacion = CInt(Comprobante.GetAttribute("noAprobacion"))
                ._AnioAprobacion = CInt(Comprobante.GetAttribute("anoAprobacion"))
            End If
            .FormaPago = Comprobante.GetAttribute("formaDePago")
            ._NumeroCertificado = CStr(Comprobante.GetAttribute("noCertificado"))
            ._Certificado = Comprobante.GetAttribute("certificado")
            .CondicionesPago = Comprobante.GetAttribute("condicionesDePago")
            .SubTotal = CDec(Comprobante.GetAttribute("subTotal"))
            .Descuentos = CDec(Comprobante.GetAttribute("descuento"))
            .MotivoDescuento = Comprobante.GetAttribute("motivoDescuento")
            .Total = CDec(Comprobante.GetAttribute("total"))
            .MetodoPago = Comprobante.GetAttribute("metodoDePago")
            .TipoComprobante = GetTipoComprobante(Comprobante.GetAttribute("tipoDeComprobante"))
        End With
        Dim Emisor As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Emisor", nsManager), XmlElement)
        CargarEmisor(ComprobanteFiscal, Emisor, nsManager)
        Dim Receptor As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Receptor", nsManager), XmlElement)
        CargarReceptor(ComprobanteFiscal, Receptor, nsManager)
        Dim Conceptos As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Conceptos", nsManager), XmlElement)
        CargarConceptos(ComprobanteFiscal, Conceptos)
        Dim Impuestos As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Impuestos", nsManager), XmlElement)
        CargarImpuestos(ComprobanteFiscal, Impuestos, nsManager)
        If version >= 3 Then
            Dim TimbreFiscal As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Complemento/tfd:TimbreFiscalDigital", nsManager), XmlElement)
            CargarTimbreFiscal(ComprobanteFiscal, TimbreFiscal, nsManager)
        End If
        Return ComprobanteFiscal
    End Function

    Public Function Load(ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As ComprobanteFiscalInfo
        Try
            Dim fxLoad As New FunctionSQL("Accounting", "fxCFDSelectFolio", Connection, Transaction)
            fxLoad.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            fxLoad.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxLoad.Parameters.Add("@UUID", DbType.String).Value = UUID
            Dim dtComprobante As New DataTable("Comprobante")
            fxLoad.FillDataTable(dtComprobante)
            '
            Dim Comprobante As ComprobanteFiscalInfo = Cargar(dtComprobante)
            If Comprobante Is Nothing Then Throw New BusinessException("No se encontró el CFD especificado. (" & idSerie.ToString & "," & folio.ToString & "," & UUID & ")")
            Return Comprobante
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el CFD " & folio.ToString, ex)
        End Try
    End Function

    Public Function Load(ByVal fechaComprobante As Date, ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As ComprobanteFiscalInfo
        Try
            Dim fxLoad As New FunctionSQL("Accounting", "fxCFDSelect", Connection, Transaction)
            fxLoad.Parameters.Add("@FechaComprobante", DbType.DateTime).Value = fechaComprobante
            fxLoad.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            fxLoad.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxLoad.Parameters.Add("@UUID", DbType.String).Value = UUID
            Dim dtComprobante As New DataTable("Comprobante")
            fxLoad.FillDataTable(dtComprobante)
            '
            Dim Comprobante As ComprobanteFiscalInfo = Cargar(dtComprobante)
            If Comprobante Is Nothing Then Throw New BusinessException("No se encontró el CFD especificado. (" & idSerie.ToString & "," & folio.ToString & "," & UUID & "," & fechaComprobante.ToShortDateString & ")")
            Return Comprobante
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el CFD " & folio.ToString, ex)
        End Try
    End Function

    Public Function LoadXML(ByVal IdSerie As Integer, ByVal folio As Integer, UUID As String) As String
        Try
            Dim fxFactura As New FunctionSQL("Accounting", "fxCFDSelectXML", Connection, Transaction)
            fxFactura.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = IdSerie
            fxFactura.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxFactura.Parameters.Add("@UUID", DbType.String).Value = UUID
            Return CStr(fxFactura.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el xml del CFD: " & folio.ToString, ex)
        End Try
    End Function

    Public Sub Cancelar(uuid As String)
        Try
            Dim sqlCFD As New SentenceSQL("SELECT IdCFDSerie, Folio FROM Accounting.CFD WHERE UUID=@UUID", Connection, Transaction)
            sqlCFD.Parameters.Add("@UUID", DbType.String).Value = uuid
            Dim dtInfo As DataTable = sqlCFD.GetTable()
            If dtInfo.Rows.Count > 0 Then
                Dim dr As DataRow = dtInfo.Rows(0)
                Dim IdSerie As Integer = CInt(dr("IdCFDSerie"))
                Dim Folio As Integer = CInt(dr("Folio"))
                Cancelar(IdSerie, Folio, uuid)
            Else
                Throw New BusinessException("No se encontró un comprobante fiscal con el UUID: " & uuid)
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cancelar el CFDI: " & uuid, ex)
        End Try
    End Sub

    Public Sub Cancelar(ByVal idSerie As Integer, ByVal folio As Integer, UUID As String)
        Try
            'Cargar información de la serie de CFD
            Dim SerieSvc As New SerieService(SessionID, Connection, Transaction)
            Dim SerieInf As SerieInfo = SerieSvc.GetDetailFromCache(idSerie)
            'Cargar información del certificado digital
            Dim CertificadoSvc As New CertificadoService(SessionID, Connection, Transaction)
            Dim CertificadoInf As CertificadoInfo = CertificadoSvc.GetDetailFromCache(SerieInf.IdCertificado)
            If CertificadoInf.TipoCFD = FormatoCFD.CFDI Then CancelarTimbre(UUID, CertificadoInf, SerieInf.IdEmpresa)

            Dim spCancelar As New StoredProcedure("Accounting", "CFDCancel", Connection, Transaction)
            spCancelar.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            spCancelar.Parameters.Add("@Folio", DbType.Int32).Value = folio
            spCancelar.Parameters.Add("@UUID", DbType.String).Value = UUID
            spCancelar.Execute()
        Catch ex As Exception
            Throw New BusinessException("Error al cancelar el CFD: " & folio.ToString, ex)
        End Try
    End Sub

    Public Function Generar(ByVal idSerie As Integer, ByVal comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo
        Return Generar(idSerie, comprobante, Date.Now)
    End Function

    Public Function Generar(ByVal idSerie As Integer, ByVal comprobante As ComprobanteFiscalInfo, ByVal fechaComprobante As Date) As ComprobanteFiscalInfo
        Try
            CalcularTotales(comprobante)
            'Cargar información de la serie de CFD
            Dim SerieSvc As New SerieService(SessionID, Connection, Transaction)
            Dim SerieInf As SerieInfo = SerieSvc.GetDetail(idSerie, False, True)
            'Cargar información del certificado digital
            Dim CertificadoSvc As New CertificadoService(SessionID, Connection, Transaction)
            Dim CertificadoInf As New CertificadoInfo(SessionID)
            CertificadoSvc.GetDetail(SerieInf.IdCertificado, CertificadoInf, False)
            'Cargar certificado
            Dim Certificate As New Cert
            Certificate.LoadFromBinary(CertificadoInf.Certificado)
            '
            Dim Folio As Integer = GetNuevoFolio(SerieInf)
            comprobante.IdSerie = idSerie
            comprobante.Serie = SerieInf.Serie
            comprobante._Folio = Folio
            comprobante.Fecha = fechaComprobante.AddHours(-4)
            comprobante._NumeroAprobacion = GetNumeroAprobacion(SerieInf, Folio)
            comprobante._AnioAprobacion = GetAnioAprobacion(SerieInf, Folio)
            comprobante._NumeroCertificado = CertificadoInf.NumeroCertificado
            comprobante._Certificado = Certificate.GetEncoded().Replace(ControlChars.NewLine, String.Empty)
            'Determinar la versión del comprobante
            If CertificadoInf.TipoCFD = FormatoCFD.CFD Then
                comprobante.Version = "2.2"
            Else
                comprobante.Version = "3.2"
            End If
            'Si se trata de un CFD, validar folio y certificado
            If CertificadoInf.TipoCFD = FormatoCFD.CFD Then
                ValidarFolio(comprobante)
                ValidarCertificado(comprobante)
            End If
            'Obtener comprobante en documento xml para generar cadena original y sello digital
            Dim comprobanteXML As XmlDocument = comprobante.GetXML(CertificadoInf.TipoCFD)
            Dim CadenaOriginalCFD As String = String.Empty
            Dim CadenaOriginalTimbre As String = String.Empty
            If CertificadoInf.TipoCFD = FormatoCFD.CFD Then
                CadenaOriginalCFD = GenerarCadenaOriginal_V2(comprobanteXML)
            Else
                CadenaOriginalCFD = GenerarCadenaOriginal_V3(comprobanteXML)
            End If
            comprobante.Sello = GenerarSelloDigital(CadenaOriginalCFD, CertificadoInf)
            'Timbrar comprobante
            If CertificadoInf.TipoCFD = FormatoCFD.CFDI Then
                AppEventLog.WriteEntry("Timbrando comprobante " & comprobante.Folio & ". Cadena original utilizada para el sello: " & CadenaOriginalCFD & ".", EventLogType.Information)
                comprobante = Timbrar(comprobante, CertificadoInf)
                CadenaOriginalTimbre = GenerarCadenaOriginalTimbre(comprobante)
            End If
            'Guardar en base de datos
            Save(comprobante, CadenaOriginalCFD, CadenaOriginalTimbre, CertificadoInf.TipoCFD)
            Return comprobante
        Catch ex As Exception
            Throw New BusinessException("Error al generar el CFD del documento.", ex)
        End Try
    End Function

    Public Overridable Function Generar(idSucursal As Integer, idSerie As Integer, xmlComprobante As String, referencia As String) As ComprobanteFiscalInfo
        Try
            Dim ComprobanteXML As New XmlDocument
            ComprobanteXML.LoadXml(xmlComprobante)
            '
            Dim nsManager As New XmlNamespaceManager(ComprobanteXML.NameTable)
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/3")
            nsManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            '
            Dim ComprobanteFiscal As New ComprobanteFiscalInfo(SessionID)
            Dim Comprobante As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante", nsManager), XmlElement)
            With ComprobanteFiscal
                .Version = Comprobante.GetAttribute("version")
                .Fecha = CDate(Comprobante.GetAttribute("fecha"))
                .Sello = Comprobante.GetAttribute("sello")
                .FormaPago = Comprobante.GetAttribute("formaDePago")
                .CondicionesPago = Comprobante.GetAttribute("condicionesDePago")
                .SubTotal = CDec(Comprobante.GetAttribute("subTotal"))
                If Comprobante.GetAttribute("descuento") <> String.Empty Then
                    .Descuentos = CDec(Comprobante.GetAttribute("descuento"))
                End If
                .IdSucursal = idSucursal
                .IdDivisa = 1
                .TipoComprobante = TipoComprobante.Ingreso
                .TipoDocumento = TipoCFD.Factura
                .MotivoDescuento = Comprobante.GetAttribute("motivoDescuento")
                .Total = CDec(Comprobante.GetAttribute("total"))
                .MetodoPago = Comprobante.GetAttribute("metodoDePago")
                .TipoComprobante = GetTipoComprobante(Comprobante.GetAttribute("tipoDeComprobante"))
                .Referencia = referencia
                .FechaDocumento = Date.Today
                .IdDocumento = referencia
            End With
            Dim Emisor As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Emisor", nsManager), XmlElement)
            CargarEmisor(ComprobanteFiscal, Emisor, nsManager)
            Dim Receptor As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Receptor", nsManager), XmlElement)
            CargarReceptor(ComprobanteFiscal, Receptor, nsManager)
            Dim Impuestos As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Impuestos", nsManager), XmlElement)
            CargarImpuestos(ComprobanteFiscal, Impuestos, nsManager)
            Dim Conceptos As XmlElement = CType(ComprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Conceptos", nsManager), XmlElement)
            CargarConceptos(ComprobanteFiscal, Conceptos)
            '
            'Cargar información de la serie de CFD
            Dim SerieSvc As New SerieService(SessionID, Connection, Transaction)
            Dim SerieInf As SerieInfo = SerieSvc.GetDetail(idSerie, False, True)
            'Cargar información del certificado digital
            Dim CertificadoSvc As New CertificadoService(SessionID, Connection, Transaction)
            Dim CertificadoInf As New CertificadoInfo(SessionID)
            CertificadoSvc.GetDetail(SerieInf.IdCertificado, CertificadoInf, False)
            '
            'Detectar campos faltantes y llenarlos
            If ComprobanteFiscal.LugarExpedicion.Trim() = String.Empty Then ComprobanteFiscal.LugarExpedicion = ComprobanteFiscal.Emisor.LugarExpedicion.Localidad & ", " & ComprobanteFiscal.Emisor.LugarExpedicion.Estado
            If ComprobanteFiscal.Emisor.RegimenesFiscales.Count = 0 Then
                Dim EmpresaConfigSvc As New EmpresaConfigService(SessionID, Connection, Transaction)
                Dim Config As EmpresaConfigInfo = EmpresaConfigSvc.GetDetailFromCache(SerieInf.IdEmpresa)
                Dim Regimenes As String() = Config.RegimenFiscal.Split(New Char() {ControlChars.Cr, ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
                For Each regimen As String In Regimenes
                    ComprobanteFiscal.Emisor.RegimenesFiscales.Add(regimen.Trim)
                Next
            End If
            'Asignar nuevo folio interno
            AsignarFolio(ComprobanteFiscal, SerieInf, CertificadoInf)
            '
            'Obtener comprobante en documento xml para generar cadena original y sello digital
            ComprobanteXML = ComprobanteFiscal.GetXML(CertificadoInf.TipoCFD)
            Dim CadenaOriginalCFD As String = String.Empty
            Dim CadenaOriginalTimbre As String = String.Empty
            CadenaOriginalCFD = GenerarCadenaOriginal_V3(ComprobanteXML)
            ComprobanteFiscal.Sello = GenerarSelloDigital(CadenaOriginalCFD, CertificadoInf)
            'Timbrar comprobante
            AppEventLog.WriteEntry("Timbrando comprobante " & ComprobanteFiscal.Folio & ". Cadena original utilizada para el sello: " & CadenaOriginalCFD & ".", EventLogType.Information)
            ComprobanteFiscal = Timbrar(ComprobanteFiscal, CertificadoInf)
            CadenaOriginalTimbre = GenerarCadenaOriginalTimbre(ComprobanteFiscal)
            'Guardar en base de datos
            Save(ComprobanteFiscal, CadenaOriginalCFD, CadenaOriginalTimbre, CertificadoInf.TipoCFD)
            Return ComprobanteFiscal
        Catch ex As Exception
            Throw New BusinessException("Error al generar el CFDI a partir del xml." & ControlChars.NewLine & "XML: " & xmlComprobante, ex)
        End Try
    End Function

    Protected Sub AsignarFolio(ComprobanteFiscal As ComprobanteFiscalInfo, serie As SerieInfo, certificado As CertificadoInfo)
        'Cargar certificado
        Dim Certificate As New Cert
        Certificate.LoadFromBinary(certificado.Certificado)

        Dim Folio As Integer = GetNuevoFolio(serie)
        ComprobanteFiscal.IdSerie = serie.Identity
        ComprobanteFiscal.Serie = serie.Serie
        ComprobanteFiscal._Folio = Folio
        ComprobanteFiscal._NumeroAprobacion = GetNumeroAprobacion(serie, Folio)
        ComprobanteFiscal._AnioAprobacion = GetAnioAprobacion(serie, Folio)
        ComprobanteFiscal._NumeroCertificado = certificado.NumeroCertificado
        ComprobanteFiscal._Certificado = Certificate.GetEncoded().Replace(ControlChars.NewLine, String.Empty)

    End Sub

    Public Sub Regenerar(ByVal comprobante As ComprobanteFiscalInfo, ByVal idSerie As Integer, ByVal folio As Integer, ByVal fechaComprobante As Date)
        Try
            'Cargar información de la serie de CFD
            Dim SerieSvc As New SerieService(SessionID, Connection, Transaction)
            Dim SerieInf As SerieInfo = SerieSvc.GetDetailFromCache(idSerie)
            'Cargar información del certificado digital
            Dim CertificadoSvc As New CertificadoService(SessionID, Connection, Transaction)
            Dim CertificadoInf As CertificadoInfo = CertificadoSvc.GetDetailFromCache(SerieInf.IdCertificado)
            'Cargar certificado
            Dim Certificate As New Cert
            Certificate.LoadFromBinary(CertificadoInf.Certificado)
            'Asignar valores a comprobante
            comprobante.IdSerie = idSerie
            comprobante.Serie = SerieInf.Serie
            comprobante._Folio = folio
            comprobante.Fecha = fechaComprobante
            comprobante._NumeroAprobacion = GetNumeroAprobacion(SerieInf, folio)
            comprobante._AnioAprobacion = GetAnioAprobacion(SerieInf, folio)
            comprobante._NumeroCertificado = CertificadoInf.NumeroCertificado
            comprobante._Certificado = Certificate.GetEncoded()
            'Obtener comprobante en documento xml para generar cadena original y sello digital
            Dim comprobanteXML As XmlDocument = comprobante.GetXML(CertificadoInf.TipoCFD)
            Dim CadenaOriginalCFD As String = String.Empty
            Dim CadenaOriginalTimbre As String = String.Empty
            If CertificadoInf.TipoCFD = FormatoCFD.CFD Then
                CadenaOriginalCFD = GenerarCadenaOriginal_V2(comprobanteXML)
            Else
                CadenaOriginalCFD = GenerarCadenaOriginal_V3(comprobanteXML)
            End If
            comprobante.Sello = GenerarSelloDigital(CadenaOriginalCFD, CertificadoInf)
            If CertificadoInf.TipoCFD = FormatoCFD.CFDI Then
                comprobante = Timbrar(comprobante, CertificadoInf)
                CadenaOriginalTimbre = GenerarCadenaOriginalTimbre(comprobante)
            End If
            'Guardar en base de datos
            Save(comprobante, CadenaOriginalCFD, CadenaOriginalTimbre, CertificadoInf.TipoCFD)
        Catch ex As Exception
            Throw New BusinessException("Error al regenerar la comprobante " & folio.ToString, ex)
        End Try
    End Sub



#End Region

#Region "Validaciones"

    Private Function ValidarFolio(ByVal factura As ComprobanteFiscalInfo) As Boolean
        Dim SAT As New Azteca.Business.Contabilidad.SATService(SessionID, Connection, Transaction)
        If SAT.ValidarFolio(factura.Emisor.RFC, factura.NumeroAprobacion, factura.AnioAprobacion, factura.Serie, factura.Folio) Then
            Return True
        Else
            Throw New BusinessException("El folio del comprobante fiscal no ha sido autorizado por el SAT")
        End If
    End Function

    Private Function ValidarCertificado(ByVal factura As ComprobanteFiscalInfo) As Boolean
        Dim SAT As New Azteca.Business.Contabilidad.SATService(SessionID, Connection, Transaction)
        Dim dtCert As DataTable = SAT.GetCertificadoInfo(factura.Emisor.RFC, factura.NumeroCertificado)
        If dtCert.Rows.Count > 0 Then
            Dim drCert As DataRow = dtCert.Rows(0)
            Dim Estatus As String = drCert("Estatus").ToString
            Dim FechaIni As Date = CDate(drCert("FechaInicial")).Date
            Dim FechaFin As Date = CDate(drCert("FechaFinal")).Date.AddDays(1)
            'Revisar si la factura se generó fuera del rango de vigencia del certificado
            If factura.Fecha < FechaIni Or factura.Fecha > FechaFin Then
                Throw New BusinessException("El certificado especificado en el CFD no estaba vigente cuando se generó la factura.")
            End If
            Select Case Estatus
                Case "A"
                    Return True
                Case "C"
                    Return True
                Case "R"
                    Throw New BusinessException("El certificado especificado en el CFD ha sido revocado.")
                Case Else
                    Throw New BusinessException("El certificado especificado en el CFD contiene un estatus desconocido.")
            End Select
        Else
            Throw New BusinessException("El certificado especificado en el CFD no ha sido autorizado por el SAT.")
        End If
    End Function

#End Region

#Region "Informes"

    Public Function LoadPrintInfo(ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As InformesDS.ComprobantesFiscalesDataTable
        Try
            'Cargar información del comprobante
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteSvc.Load(idSerie, folio, UUID)
            'Determinar la función del comprobante dependiendo de la versión
            Dim FunctionName As String = "fxComprobanteFiscalRPT_V2"
            If CDec(Comprobante.Version) >= 3 Then FunctionName = "fxComprobanteFiscalRPT_V3"

            Dim fxReport As New FunctionSQL("Accounting", FunctionName, Connection, Transaction)
            fxReport.Parameters.Add("@IdCFDSerie", DbType.Int32).Value = idSerie
            fxReport.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxReport.Parameters.Add("@UUID", DbType.String).Value = UUID
            Dim dtReport As New InformesDS.ComprobantesFiscalesDataTable
            fxReport.FillDataTable(dtReport)
            Return dtReport
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión del CFD.", ex)
        End Try
    End Function


    Public Function CargarInforme(ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As InformesDS.ComprobantesEmitidosDataTable
        Try
            Dim fxComprobantes As New FunctionSQL("Accounting", "fxComprobantesEmitidos", Connection, Transaction)
            fxComprobantes.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxComprobantes.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxComprobantes.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            Dim Comprobantes As New InformesDS.ComprobantesEmitidosDataTable
            fxComprobantes.CommandTimeOut = 1200
            fxComprobantes.FillDataTable(Comprobantes)
            Return Comprobantes
        Catch ex As Exception
            Throw New BusinessException("Error al cargar el informe de CFD emitidos.", ex)
        End Try
    End Function

    Public Function GenerarInformeHacienda(ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As String
        Dim Informe As New System.Text.StringBuilder()
        Try
            Dim Comprobantes As InformesDS.ComprobantesEmitidosDataTable = CargarInforme(idEmpresa, fechaInicial, fechaFinal)
            For Each drComprobantes As InformesDS.ComprobantesEmitidosRow In Comprobantes
                Dim Estatus As Integer = CInt(IIf(drComprobantes.Activa, "1", "0"))
                With Informe
                    .Append("|")
                    .Append(drComprobantes.RFC.Trim & "|")
                    .Append(drComprobantes.Serie.Trim & "|")
                    .Append(drComprobantes.Folio.ToString & "|")
                    .Append(drComprobantes.NumAprobacion.ToString & "|")
                    .Append(drComprobantes.HoraComprobante.ToString("dd/MM/yyyy HH:mm:ss") & "|")
                    .Append(drComprobantes.Total.ToString("##0.00") & "|")
                    .Append(drComprobantes.ImpTrasladados.ToString("##0.00") & "|")
                    .Append(Estatus.ToString & "|")
                    .Append(drComprobantes.Efecto & "|")
                    .Append("|")
                    .Append("|")
                    .Append("|")
                    Informe.Append(ControlChars.NewLine)
                End With
            Next
            Return Informe.ToString
        Catch ex As Exception
            Throw New BusinessException("Error al generar el informe mensual de comprobantes emitidos.", ex)
        End Try
    End Function

    Public Function LoadComprobantesList(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idTipoCFD As Integer, ByVal idCliente As Integer) As InformesDS.ComprobantesListDataTable
        Try
            Dim fxList As New FunctionSQL("Accounting", "fxCFDListRPT", Connection, Transaction)
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxList.Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
            fxList.Parameters.Add("@IdCFDTipo", DbType.Int32).Value = idTipoCFD
            fxList.Parameters.Add("@IdCliente", DbType.Int32).Value = idCliente
            '
            Dim dtList As New InformesDS.ComprobantesListDataTable
            fxList.FillDataTable(dtList)
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de comprobantes fiscales.", ex)
        End Try
    End Function

#End Region


End Class



Public Class ComprobanteFiscalFacade
    Inherits Azteca.Kernel.RemoteObject

#Region "Campos Privados"
    Private Connection As IDbConnection
    Private Transaction As IDbTransaction
#End Region

#Region "Metodos Privados"
    Private Sub ValidateSession(ByVal sessionID As Guid)

    End Sub

    Private Sub HandleException(ByVal ex As Exception)
        AppEventLog.LogException(ex)
        Throw ex
    End Sub
#End Region

#Region "Metodos Publicos"

    Public Function Generar(ByVal sessionID As Guid, ByVal idSerie As Integer, ByVal comprobante As ComprobanteFiscalInfo) As ComprobanteFiscalInfo
        ValidateSession(sessionID)
        Dim RetComprobante As New ComprobanteFiscalInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
                RetComprobante = svc.Generar(idSerie, comprobante)
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
        Return RetComprobante
    End Function

    Public Overridable Function Generar(sessionID As Guid, idSucursal As Integer, idSerie As Integer, xml As String, referencia As String) As ComprobanteFiscalInfo
        ValidateSession(sessionID)
        Dim RetComprobante As New ComprobanteFiscalInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
                RetComprobante = svc.Generar(idSucursal, idSerie, xml, referencia)
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
        Return RetComprobante
    End Function

    Public Sub Cancelar(ByVal sessionID As Guid, uuid As String)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
                svc.Cancelar(uuid)
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

    Public Sub Cancelar(ByVal sessionID As Guid, ByVal idSerie As Integer, ByVal folio As Integer, UUID As String)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
                svc.Cancelar(idSerie, folio, UUID)

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

    Public Function LoadXML(ByVal sessionID As Guid, ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As String
        Dim xml As String = String.Empty
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New ComprobanteFiscalService(sessionID, Connection)
            xml = svc.LoadXML(idSerie, folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return xml
    End Function

    Public Function Load(ByVal sessionID As Guid, ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As ComprobanteFiscalInfo
        Dim Comprobante As ComprobanteFiscalInfo = Nothing
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New ComprobanteFiscalService(sessionID, Connection)
            Comprobante = svc.Load(idSerie, folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Comprobante
    End Function


#End Region

#Region "Informes"

    Public Function LoadPrintInfo(ByVal sessionID As Guid, ByVal idSerie As Integer, ByVal folio As Integer, UUID As String) As InformesDS.ComprobantesFiscalesDataTable
        ValidateSession(sessionID)
        Dim dtInforme As New InformesDS.ComprobantesFiscalesDataTable
        Try
            Connection = DataServices.OpenConnection
            Dim svc As New ComprobanteFiscalService(sessionID, Connection)
            dtInforme = svc.LoadPrintInfo(idSerie, folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInforme
    End Function

    Public Function CargarInforme(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As InformesDS.ComprobantesEmitidosDataTable
        ValidateSession(sessionID)
        Dim Comprobantes As InformesDS.ComprobantesEmitidosDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            Comprobantes = Svc.CargarInforme(idEmpresa, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Comprobantes
    End Function

    Public Function GenerarInformeHacienda(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal fechaInicial As Date, ByVal fechaFinal As Date) As String
        ValidateSession(sessionID)
        Dim Informe As String = String.Empty
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            Informe = Svc.GenerarInformeHacienda(idEmpresa, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Informe
    End Function

    Public Function LoadComprobantesList(ByVal sessionID As Guid, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idTipoCFD As Integer, ByVal idCliente As Integer) As InformesDS.ComprobantesListDataTable
        ValidateSession(sessionID)
        Dim dtComprobantes As InformesDS.ComprobantesListDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            dtComprobantes = Svc.LoadComprobantesList(fechaInicial, fechaFinal, idEmpresa, idSucursal, idTipoCFD, idCliente)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtComprobantes
    End Function


#End Region

End Class