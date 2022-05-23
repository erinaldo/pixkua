Imports Azteca.Kernel.General
Imports Chilkat
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.XPath
Imports System.Xml.Xsl
Imports System.IO

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
    End Sub

    Public Property RFC() As String

    Public Property Nombre() As String

    Public Property DomicilioFiscal() As DomicilioInfo

    Public Property LugarExpedicion() As DomicilioInfo

End Class


<Serializable()> _
Public Class ReceptorInfo

    Public Sub New()
        _Domicilio = New DomicilioInfo
    End Sub

    Public Property RFC() As String

    Public Property Nombre() As String

    Public Property Domicilio() As DomicilioInfo

End Class


<Serializable()> _
Public Class ConceptoInfo
    Private _Importe As Decimal

    Public Property Cantidad() As Decimal

    Public Property Unidad() As String = String.Empty

    Public Property NumID() As String = String.Empty

    Public Property IdArticuloStock As Integer

    Public Property IdServicio As Integer

    Public Property Descripcion() As String = String.Empty

    Public Property EAN As String = String.Empty

    Public Property FactorUnidad As Integer

    Public Property ValorUnitario() As Decimal

    Public ReadOnly Property Importe() As Decimal
        Get
            Return _ValorUnitario * _Cantidad
        End Get
    End Property

End Class

<Serializable()> _
Public Class ConceptosCollection
    Inherits System.Collections.Generic.List(Of ConceptoInfo)


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
        For Each retencion As RetencionInfo In _Retenciones
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
Public Class RetencionInfo
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
Public Class TimbreFiscalInfo
    Friend _Version As String = String.Empty
    Friend _SelloSAT As String = String.Empty
    Friend _NumeroCertificadoSAT As String = String.Empty
    Friend _UUID As String = String.Empty
    Friend _Fecha As Date
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


<Serializable()> _
Public Class RetencionesCollection
    Inherits System.Collections.Generic.List(Of RetencionInfo)

End Class

<Serializable()> _
Public Class TrasladosCollection
    Inherits System.Collections.Generic.List(Of TrasladoInfo)

End Class

<Serializable()> _
Public Enum TipoComprobante
    Ingreso
    Egreso
    Traslado
End Enum

<Serializable()> _
Public Enum TipoImpuestoRetencion
    IVA
    ISR
End Enum

<Serializable()> _
Public Enum TipoImpuestoTraslado
    IVA = 1
    IEPS = 2
End Enum

<Serializable()> _
Public Enum TipoDocumento
    Factura = 1
    NotaCargo = 2
    NotaCredito = 3
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

    Friend _Version As String = String.Empty
    Friend _Serie As String = String.Empty
    Friend _Folio As Integer
    Friend _Fecha As Date
    Friend _Sello As String = String.Empty
    Friend _NumeroAprobacion As Integer
    Friend _AnioAprobacion As Integer
    Private _FormaPago As String = String.Empty
    Friend _NumeroCertificado As String = String.Empty
    Friend _Certificado As String = String.Empty

#End Region

#Region "Propiedades Auxiliares"

    Public Property IdProveedor() As Integer

    Public Property FechaDocumento() As Date

    Public Property IdDocumento() As String = String.Empty

    Public Property IdEmpresa As Integer

    Public Property Estatus As String = String.Empty

    Public Property Valido As Boolean = False

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

    Public ReadOnly Property Version() As String
        Get
            Return _Version
        End Get
    End Property

    Public ReadOnly Property Serie() As String
        Get
            Return _Serie
        End Get
    End Property

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

    Public ReadOnly Property Fecha() As Date
        Get
            Return _Fecha
        End Get
    End Property

    Public ReadOnly Property Sello() As String
        Get
            Return _Sello
        End Get
    End Property

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

    Public Property FormaPago() As String
        Get
            Return _FormaPago
        End Get
        Set(ByVal value As String)
            _FormaPago = value
        End Set
    End Property

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

    Public Property CondicionesPago() As String

    Public Property SubTotal() As Decimal

    Public Property Descuento() As Decimal

    Public Property MotivoDescuento() As String

    Public Property Total() As Decimal

    Public Property Moneda As String = String.Empty

    Public Property TipoCambio As Decimal = 1D

    Public Property MetodoPago() As String

    Public Property TipoComprobante() As TipoComprobante

    Public Property TipoDocumento() As TipoDocumento

#End Region

#Region "Constructor"


    Public Sub New(ByVal sessionID As GUID)
        Me.SessionID = SessionID
        _Emisor = New EmisorInfo
        _Receptor = New ReceptorInfo
        _Conceptos = New ConceptosCollection
        _Impuestos = New ImpuestosInfo
        _TimbreFiscal = New TimbreFiscalInfo
        _Version = "2.0"
    End Sub

#End Region

End Class


Public Class ComprobanteFiscalService

#Region "Constructores"
    Protected SessionID As Guid
    Private Session As SessionInfo
    Private Connection As IDbConnection
    Private Transaction As IDbTransaction

    Public Sub New(ByVal sessionID As Guid, ByVal connection As IDbConnection, ByVal transaction As IDbTransaction)
        Me.SessionID = SessionID
        Me.Connection = connection
        Me.Transaction = transaction
        Session = Azteca.Kernel.Server.Sessions(sessionID)
    End Sub

    Public Sub New(ByVal sessionID As Guid, ByVal Connection As IDbConnection)
        Me.New(sessionID, Connection, Nothing)
    End Sub

#End Region

#Region "Metodos Privados"

    Private Function GetErrorStack(ByVal ex As Exception) As String
        Dim ErrorText As String = ex.Message
        If ex.InnerException IsNot Nothing Then ErrorText &= ControlChars.NewLine & GetErrorStack(ex.InnerException)
        Return ErrorText
    End Function

    Private Function GetVersion(comprobanteXML As XmlDocument) As Decimal
        Dim PrimaryNodeIndex As Integer = 0
        If comprobanteXML.ChildNodes.Count > 1 Then PrimaryNodeIndex = 1
        'Determinar la versión del comprobante
        Dim Version As Decimal = CDec(comprobanteXML.ChildNodes(PrimaryNodeIndex).Attributes("version").Value)
        Return Version
    End Function


    Private Function GenerarCadenaOriginal(ByVal comprobante As XmlDocument, ByVal version As Decimal) As String
        Dim Navigator As XPathNavigator = comprobante.CreateNavigator
        Dim Transformer As XslCompiledTransform = Nothing

        Dim CacheKey As String = String.Empty
        If version = 2 Then
            CacheKey = "CadenaOriginalXSLT_V2"
        ElseIf version = 2.2 Then
            CacheKey = "CadenaOriginalXSLT_V2_2"
        ElseIf version = 3 Then
            CacheKey = "CadenaOriginalXSLT_V3"
        ElseIf version = 3.2 Then
            CacheKey = "CadenaOriginalXSLT_V3_2"
        End If
        If Azteca.Kernel.Cache.Item(CacheKey) Is Nothing Then
            Transformer = New XslCompiledTransform
            'Leer xslt de transformación de los recursos 
            Dim UtileriasPath As String = Azteca.Kernel.Server.ApplicationFolder & "\XSLT"
            Dim XSLTString As String = String.Empty
            If version = 2 Then
                XSLTString = My.Resources.CadenaOriginalXSLT_V2.Replace("[UTILITY_PATH]", UtileriasPath)
            ElseIf version = 2.2 Then
                XSLTString = My.Resources.CadenaOriginalXSLT_V2_2.Replace("[UTILITY_PATH]", UtileriasPath)
            ElseIf version = 3 Then
                XSLTString = My.Resources.CadenaOriginalXSLT_V3.Replace("[UTILITY_PATH]", UtileriasPath)
            ElseIf version = 3.2 Then
                XSLTString = My.Resources.CadenaOriginalXSLT_V3_2.Replace("[UTILITY_PATH]", UtileriasPath)
            End If
            Using strReader As New StringReader(XSLTString)
                Dim Reader As XmlReader = XmlReader.Create(strReader)
                Transformer.Load(Reader)
                Azteca.Kernel.Cache.Add(CacheKey, Transformer, TimeSpan.FromDays(7))
            End Using
        Else
            Transformer = CType(Azteca.Kernel.Cache.Item(CacheKey), XslCompiledTransform)
        End If
        '        
        Dim CadenaOriginal As New System.Text.StringBuilder()
        Dim strWriter As New StringWriter(CadenaOriginal)
        Transformer.Transform(Navigator, Nothing, strWriter)
        Return CadenaOriginal.ToString.Trim
    End Function

    Private Function GetTipoComprobante(ByVal tipo As String) As TipoComprobante
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

    Public Function Exists(ByVal idProveedor As Integer, ByVal serie As String, ByVal folio As Integer, UUID As String) As Boolean
        Try
            Dim fxExists As New FunctionSQL("Purchasing", "CFDExists", Connection, Transaction)
            fxExists.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxExists.Parameters.Add("@Serie", DbType.String).Value = serie
            fxExists.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxExists.Parameters.Add("@UUID", DbType.String).Value = UUID
            Return CBool(fxExists.GetScalar)
        Catch ex As Exception
            Throw New BusinessException("Error al verificar la existencia del comprobante fiscal.", ex)
        End Try
    End Function

#End Region

#Region "Metodos XML"

    Public Function GetXMLString(IdProveedor As Integer, Serie As String, Folio As Integer, UUID As String) As String
        Try
            Dim fx As New FunctionSQL("Purchasing", "fxCFDGetXML", Me.Connection, Me.Transaction)
            fx.Parameters.Add("@IdProveedor", DbType.Int32).Value = IdProveedor
            fx.Parameters.Add("@Serie", DbType.String).Value = Serie
            fx.Parameters.Add("@Folio", DbType.Int32).Value = Folio
            fx.Parameters.Add("@UUID", DbType.String).Value = UUID
            Dim XML As String = CStr(fx.GetScalar)
            Return XML
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el CFD (XML) del almacén digital.", ex)
        End Try
    End Function

    Public Function GetXMLDocument(IdProveedor As Integer, Serie As String, Folio As Integer, UUID As String) As XmlDocument
        Dim XML As String = GetXMLString(IdProveedor, Serie, Folio, UUID)

        Dim rdr As System.Xml.XmlReader = System.Xml.XmlReader.Create(New System.IO.StringReader(XML))
        Dim Comprobante As New XmlDocument
        Comprobante.Load(rdr)

        Return Comprobante
    End Function

    Private Sub Esquema_Validation(ByVal sender As Object, ByVal e As System.Xml.Schema.ValidationEventArgs)
        If e.Severity = XmlSeverityType.Error Then
            Throw New BusinessException("Error al validar el esquema de la factura.", e.Exception)
        Else
            AppEventLog.WriteEntry(e.Message, EventLogType.Warning)
        End If
    End Sub

    Private Sub GenerarComprobanteEmisor(ByVal comprobante As ComprobanteFiscalInfo, ByVal emisor As XmlElement, ByVal nsManager As XmlNamespaceManager)
        Try
            With comprobante
                .Emisor.RFC = emisor.GetAttribute("rfc").Trim
                .Emisor.Nombre = emisor.GetAttribute("nombre")
                Dim Domicilio As XmlElement = CType(emisor.SelectSingleNode("/cfd:Comprobante/cfd:Emisor/cfd:DomicilioFiscal", nsManager), XmlElement)
                If Domicilio IsNot Nothing Then
                    With .Emisor.DomicilioFiscal
                        .Calle = Domicilio.GetAttribute("calle")
                        .NumExt = Domicilio.GetAttribute("noExterior")
                        .NumInt = Domicilio.GetAttribute("noInterior")
                        .Colonia = Domicilio.GetAttribute("colonia")
                        .Localidad = Domicilio.GetAttribute("localidad")
                        .Referencia = Domicilio.GetAttribute("referencia")
                        .Municipio = Domicilio.GetAttribute("municipio")
                        .Estado = Domicilio.GetAttribute("estado")
                        .Pais = Domicilio.GetAttribute("pais")
                        .CodigoPostal = Domicilio.GetAttribute("codigoPostal")
                    End With
                End If

                Dim LugarExp As XmlElement = CType(emisor.SelectSingleNode("/cfd:Comprobante/cfd:Emisor/cfd:ExpedidoEn", nsManager), XmlElement)
                If LugarExp IsNot Nothing Then
                    With .Emisor.LugarExpedicion
                        .Calle = LugarExp.GetAttribute("calle")
                        .NumExt = LugarExp.GetAttribute("noExterior")
                        .NumInt = LugarExp.GetAttribute("noInterior")
                        .Colonia = LugarExp.GetAttribute("colonia")
                        .Localidad = LugarExp.GetAttribute("localidad")
                        .Referencia = LugarExp.GetAttribute("referencia")
                        .Municipio = LugarExp.GetAttribute("municipio")
                        .Estado = LugarExp.GetAttribute("estado")
                        .Pais = LugarExp.GetAttribute("pais")
                        .CodigoPostal = LugarExp.GetAttribute("codigoPostal")
                    End With
                End If
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los datos del emisor", ex)
        End Try
    End Sub

    Private Sub GenerarComprobanteReceptor(ByVal comprobante As ComprobanteFiscalInfo, ByVal receptor As XmlElement, ByVal nsManager As XmlNamespaceManager)
        Try
            With comprobante
                .Receptor.RFC = receptor.GetAttribute("rfc").Trim
                .Receptor.Nombre = receptor.GetAttribute("nombre")
                Dim Domicilio As XmlElement = CType(receptor.SelectSingleNode("/cfd:Comprobante/cfd:Receptor/cfd:Domicilio", nsManager), XmlElement)
                If Domicilio IsNot Nothing Then
                    With .Receptor.Domicilio
                        .Calle = Domicilio.GetAttribute("calle")
                        .NumExt = Domicilio.GetAttribute("noExterior")
                        .NumInt = Domicilio.GetAttribute("noInterior")
                        .Colonia = Domicilio.GetAttribute("colonia")
                        .Localidad = Domicilio.GetAttribute("localidad")
                        .Referencia = Domicilio.GetAttribute("referencia")
                        .Municipio = Domicilio.GetAttribute("municipio")
                        .Estado = Domicilio.GetAttribute("estado")
                        .Pais = Domicilio.GetAttribute("pais")
                        .CodigoPostal = Domicilio.GetAttribute("codigoPostal")
                    End With
                End If
            End With
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los datos del receptor.", ex)
        End Try
    End Sub

    Private Sub GenerarComprobanteConceptos(ByVal comprobante As ComprobanteFiscalInfo, ByVal conceptos As XmlElement)
        Try
            For Each concepto As XmlElement In conceptos.ChildNodes
                Dim ConceptoInf As New ConceptoInfo
                Dim ValorUnitario As Decimal = CDec(concepto.GetAttribute("valorUnitario"))
                If ValorUnitario > 0 Then
                    With ConceptoInf
                        .Cantidad = CDec(concepto.GetAttribute("cantidad"))
                        .Unidad = concepto.GetAttribute("unidad")
                        .NumID = concepto.GetAttribute("noIdentificacion")
                        .Descripcion = concepto.GetAttribute("descripcion")
                        .ValorUnitario = CDec(concepto.GetAttribute("valorUnitario"))
                    End With
                    comprobante.Conceptos.Add(ConceptoInf)
                End If
            Next
        Catch ex As Exception
            Throw New BusinessException("Error al extraer los conceptos del comprobante fiscal.", ex)
        End Try
    End Sub

    Private Sub GenerarComprobanteImpuestos(ByVal comprobante As ComprobanteFiscalInfo, ByVal impuestos As XmlElement, ByVal nsManager As XmlNamespaceManager)
        Try
            Dim Retenciones As XmlElement = CType(impuestos.SelectSingleNode("/cfd:Comprobante/cfd:Impuestos/cfd:Retenciones", nsManager), XmlElement)
            If Retenciones IsNot Nothing Then
                For Each retencion As XmlElement In Retenciones.ChildNodes
                    Dim retencionInf As New RetencionInfo
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
            Throw New BusinessException("Error al extraer los impuestos del comprobante fiscal.", ex)
        End Try
    End Sub

    Private Sub GenerarComprobanteTimbre(ByVal comprobante As ComprobanteFiscalInfo, ByVal timbreFiscal As XmlElement, ByVal nsManager As XmlNamespaceManager)
        With comprobante.TimbreFiscal
            ._Version = timbreFiscal.GetAttribute("version")
            ._SelloSAT = timbreFiscal.GetAttribute("selloSAT")
            ._NumeroCertificadoSAT = timbreFiscal.GetAttribute("noCertificadoSAT")
            ._UUID = timbreFiscal.GetAttribute("UUID")
            ._Fecha = CDate(timbreFiscal.GetAttribute("FechaTimbrado"))
            ._SelloCFD = timbreFiscal.GetAttribute("selloCFD")
        End With
    End Sub

#End Region

#Region "Metodos Publicos"

    Public Sub Save(ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idProveedor As Integer, ByVal xml As String)
        Save(idEmpresa, idSucursal, idProveedor, xml, String.Empty, 1, 1)
    End Sub

    Public Sub Save(ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idProveedor As Integer, ByVal xml As String, referencia As String, idDivisa As Integer, tipoCambio As Decimal)
        Try
            Dim ComprobanteXML As New XmlDocument
            ComprobanteXML.LoadXml(xml)
            '
            Dim nsManager As New XmlNamespaceManager(ComprobanteXML.NameTable)
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/2")
            'Convertir documento xml a string (solo con el fin de convertir a UTF-16 y que permita guardar en SQL)        
            Dim strXML As New System.Text.StringBuilder
            Dim writer As New StringWriter(strXML)
            ComprobanteXML.Save(writer)
            'Generar objeto de Comprobante
            Dim Comprobante As ComprobanteFiscalInfo = Validar(idEmpresa, xml)
            'Si se especifico un proveedor, cargar su información, si no, determinar si existe el RFC del emisor
            Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
            Dim Proveedor As New ProveedorInfo(SessionID)
            If idProveedor > 0 Then
                ProveedorSvc.GetDetail(idProveedor, Proveedor, False)
                If Proveedor.RFC <> Comprobante.Emisor.RFC Then Throw New BusinessException("El RFC del emisor del CFD no corresponde al proveedor especificado.")
            Else
                'Verificar si existe algún proveedor con el mismo rfc que el del CFD
                If ProveedorSvc.Exists(idEmpresa, Comprobante.Emisor.RFC) Then
                    Proveedor = ProveedorSvc.GetDetail(idEmpresa, Comprobante.Emisor.RFC)
                Else
                    With Proveedor
                        .UserCode = Comprobante.Emisor.RFC
                        .Nombre = Comprobante.Emisor.Nombre
                        .RFC = Comprobante.Emisor.RFC
                        .RazonSocial = Comprobante.Emisor.Nombre
                        .CalleFiscal = Comprobante.Emisor.DomicilioFiscal.Calle
                        .NumExtFiscal = Comprobante.Emisor.DomicilioFiscal.NumExt
                        .NumIntFiscal = Comprobante.Emisor.DomicilioFiscal.NumInt
                        .ColoniaFiscal = Comprobante.Emisor.DomicilioFiscal.Colonia
                        .IdPoblacionFiscal = 0
                        .CPFiscal = Comprobante.Emisor.DomicilioFiscal.CodigoPostal
                        .FacturaElectronica = True
                        .Calle = Comprobante.Emisor.LugarExpedicion.Calle
                        .NumExt = Comprobante.Emisor.LugarExpedicion.NumExt
                        .NumInt = Comprobante.Emisor.LugarExpedicion.NumInt
                        .Colonia = Comprobante.Emisor.LugarExpedicion.Colonia
                        .IdPoblacion = 0
                        .CP = Comprobante.Emisor.LugarExpedicion.CodigoPostal
                        .Status = CatalogState.Active
                        .IdEmpresa = idEmpresa
                        .IdSucursal = idSucursal
                    End With
                    idProveedor = ProveedorSvc.Update(Proveedor)
                End If
            End If
            'Verificar que no exista el Comprobante en la bd
            If Not Exists(Proveedor.Identity, Comprobante.Serie, Comprobante.Folio, Comprobante.UUID) Then
                'Asignar ID y fecha de documento
                Comprobante.IdDocumento = String.Empty
                Comprobante.FechaDocumento = Date.Today
                Comprobante.IdProveedor = Proveedor.Identity
                'Si se especificó un tipo de cambio por parámetro, asignar
                If tipoCambio > 0 And tipoCambio <> 1 Then Comprobante.TipoCambio = tipoCambio
                'Obtener la cadena original
                Dim CadenaOriginal As String = GenerarCadenaOriginal(ComprobanteXML, CInt(Comprobante.Version))
                'Guardar Comprobante en base de datos
                Dim spUpdate As New StoredProcedure("Purchasing", "CFDUpdate", Connection, Transaction)
                With spUpdate
                    .Parameters.Add("@FechaComprobante", DbType.DateTime).Value = Comprobante.Fecha.Date
                    .Parameters.Add("@HoraComprobante", DbType.DateTime).Value = Comprobante.Fecha
                    .Parameters.Add("@Comprobante", DbType.Xml).Value = strXML.ToString
                    .Parameters.Add("@CadenaOriginal", DbType.String).Value = CadenaOriginal
                    .Parameters.Add("@SelloDigital", DbType.String).Value = Comprobante.Sello
                    .Parameters.Add("@NumCertificado", DbType.String).Value = Comprobante.NumeroCertificado
                    .Parameters.Add("@Serie", DbType.String).Value = Comprobante.Serie
                    .Parameters.Add("@Folio", DbType.Int32).Value = Comprobante.Folio
                    .Parameters.Add("@UUID", DbType.String).Value = Comprobante.TimbreFiscal.UUID
                    .Parameters.Add("@AnioAprobacion", DbType.Int32).Value = Comprobante.AnioAprobacion
                    .Parameters.Add("@NumAprobacion", DbType.Int32).Value = Comprobante.NumeroAprobacion
                    .Parameters.Add("@IdProveedor", DbType.Int32).Value = Comprobante.IdProveedor
                    .Parameters.Add("@IdDivisa", DbType.Int32).Value = idDivisa
                    .Parameters.Add("@TipoCambio", DbType.Decimal).Value = Comprobante.TipoCambio
                    .Parameters.Add("@SubTotal", DbType.Decimal).Value = Comprobante.SubTotal
                    .Parameters.Add("@Descuentos", DbType.Decimal).Value = Comprobante.Descuento
                    .Parameters.Add("@ImpuestosTras", DbType.Decimal).Value = Comprobante.Impuestos.TotalTraslados
                    .Parameters.Add("@ImpuestosRet", DbType.Decimal).Value = Comprobante.Impuestos.TotalRetenciones
                    .Parameters.Add("@Total", DbType.Decimal).Value = Comprobante.Total
                    .Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
                    .Parameters.Add("@IdSucursal", DbType.Int32).Value = idSucursal
                    If Comprobante.TipoComprobante = TipoComprobante.Ingreso Or Comprobante.TipoComprobante = TipoComprobante.Traslado Then
                        .Parameters.Add("@IdComprobanteTipo", DbType.Int32).Value = TipoDocumento.Factura
                    Else
                        .Parameters.Add("@IdComprobanteTipo", DbType.Int32).Value = TipoDocumento.NotaCredito
                    End If
                    .Parameters.Add("@FechaDocumento", DbType.Date).Value = Comprobante.FechaDocumento
                    .Parameters.Add("@IdDocumento", DbType.String).Value = Comprobante.IdDocumento
                    .Parameters.Add("@Referencia", DbType.String).Value = referencia
                    .Parameters.Add("@Version", DbType.Decimal).Value = Comprobante.Version
                    .Execute()
                End With
                'Insertar detalle de Comprobante
                For Each concepto As ConceptoInfo In Comprobante.Conceptos
                    Dim spConcepto As New StoredProcedure("Purchasing", "CFDConceptosUPD", Connection, Transaction)
                    spConcepto.Parameters.Add("@IdProveedor", DbType.Int32).Value = Proveedor.Identity
                    spConcepto.Parameters.Add("@Serie", DbType.String).Value = Comprobante.Serie
                    spConcepto.Parameters.Add("@Folio", DbType.Int32).Value = Comprobante.Folio
                    spConcepto.Parameters.Add("@UUID", DbType.String).Value = Comprobante.TimbreFiscal.UUID
                    spConcepto.Parameters.Add("@Codigo", DbType.String).Value = concepto.NumID
                    spConcepto.Parameters.Add("@Descripcion", DbType.String).Value = concepto.Descripcion
                    spConcepto.Parameters.Add("@EAN", DbType.String).Value = concepto.EAN
                    spConcepto.Parameters.Add("@Unidad", DbType.String).Value = concepto.Unidad
                    spConcepto.Parameters.Add("@PrecioUnitario", DbType.Decimal).Value = concepto.ValorUnitario
                    spConcepto.Parameters.Add("@Cantidad", DbType.Decimal).Value = concepto.Cantidad
                    spConcepto.Parameters.Add("@FactorUnidad", DbType.Int32).Value = concepto.FactorUnidad
                    spConcepto.Parameters.Add("@IdArticuloStock", DbType.Int32).Value = concepto.IdArticuloStock
                    spConcepto.Parameters.Add("@IdServicio", DbType.Int32).Value = concepto.IdServicio
                    spConcepto.Parameters.Add("@PorcImpTras1", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcImpTras2", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcImpTras3", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcImpRet1", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcImpRet2", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcImpRet3", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcDesc1", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcDesc2", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@PorcDesc3", DbType.Decimal).Value = 0
                    spConcepto.Parameters.Add("@FechaDocumento", DbType.Date).Value = Comprobante.FechaDocumento
                    spConcepto.Parameters.Add("@IdDocumento", DbType.String).Value = Comprobante.IdDocumento
                    spConcepto.Execute()
                Next
            Else
                Throw New BusinessException("El Comprobante fiscal ya existe en la base de datos.")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al guardar el Comprobante fiscal del proveedor.", ex)
        End Try
    End Sub


    Public Function GetComprobante(ByVal comprobanteXML As XmlDocument, ByVal version As Decimal) As ComprobanteFiscalInfo
        'Determinar namespace en base a la versión del comprobante
        Dim nsManager As New XmlNamespaceManager(comprobanteXML.NameTable)
        If version >= 2 And version < 3 Then
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/2")
        ElseIf version >= 3 And version < 4 Then
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/3")
            nsManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        Else
            Throw New BusinessException("La versión del comprobante fiscal no está soportada. Version: " & version.ToString)
        End If
        '
        Dim Comprobante As New ComprobanteFiscalInfo(SessionID)
        Dim ComprobanteNode As XmlElement = CType(comprobanteXML.SelectSingleNode("/cfd:Comprobante", nsManager), XmlElement)
        With Comprobante
            ._Version = ComprobanteNode.GetAttribute("version")
            ._Serie = ComprobanteNode.GetAttribute("serie")
            If Val(ComprobanteNode.GetAttribute("folio")) < Integer.MaxValue Then ._Folio = CInt(Val(ComprobanteNode.GetAttribute("folio")))
            ._Fecha = CDate(ComprobanteNode.GetAttribute("fecha"))
            ._Sello = ComprobanteNode.GetAttribute("sello")
            .FormaPago = ComprobanteNode.GetAttribute("formaDePago")
            ._NumeroCertificado = CStr(ComprobanteNode.GetAttribute("noCertificado"))
            ._Certificado = ComprobanteNode.GetAttribute("certificado")
            .CondicionesPago = ComprobanteNode.GetAttribute("condicionesDePago")
            .SubTotal = CDec(ComprobanteNode.GetAttribute("subTotal"))
            .Descuento = CDec(Val(ComprobanteNode.GetAttribute("descuento")))
            .MotivoDescuento = ComprobanteNode.GetAttribute("motivoDescuento")
            .Total = CDec(ComprobanteNode.GetAttribute("total"))
            .MetodoPago = ComprobanteNode.GetAttribute("metodoDePago")
            .TipoComprobante = GetTipoComprobante(ComprobanteNode.GetAttribute("tipoDeComprobante"))
            If version >= 2 And version < 3 Then
                ._NumeroAprobacion = CInt(ComprobanteNode.GetAttribute("noAprobacion"))
                ._AnioAprobacion = CInt(ComprobanteNode.GetAttribute("anoAprobacion"))
            End If
            If version > 2 Then
                .TipoCambio = CDec(Val(ComprobanteNode.GetAttribute("TipoCambio")))
                .Moneda = ComprobanteNode.GetAttribute("Moneda")
            End If
        End With
        Dim Emisor As XmlElement = CType(comprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Emisor", nsManager), XmlElement)
        GenerarComprobanteEmisor(Comprobante, Emisor, nsManager)
        Dim Receptor As XmlElement = CType(comprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Receptor", nsManager), XmlElement)
        GenerarComprobanteReceptor(Comprobante, Receptor, nsManager)
        Dim Conceptos As XmlElement = CType(comprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Conceptos", nsManager), XmlElement)
        GenerarComprobanteConceptos(Comprobante, Conceptos)
        Dim Impuestos As XmlElement = CType(comprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Impuestos", nsManager), XmlElement)
        GenerarComprobanteImpuestos(Comprobante, Impuestos, nsManager)
        If version >= 3 Then
            Dim TimbreFiscal As XmlElement = CType(comprobanteXML.SelectSingleNode("/cfd:Comprobante/cfd:Complemento/tfd:TimbreFiscalDigital", nsManager), XmlElement)
            GenerarComprobanteTimbre(Comprobante, TimbreFiscal, nsManager)
        End If
        Return Comprobante
    End Function

    Public Function Load(xml As String) As ComprobanteFiscalInfo
        Dim Comprobante As ComprobanteFiscalInfo = Nothing
        Try
            Dim ComprobanteXML As New XmlDocument
            ComprobanteXML.LoadXml(xml)
            'Determinar la versión del comprobante
            Dim Version As Decimal = GetVersion(ComprobanteXML)            
            Comprobante = GetComprobante(ComprobanteXML, Version)
            Return Comprobante
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del comprobante fiscal digital", ex)
        End Try
    End Function

    Public Function Validar(ByVal idEmpresa As Integer, ByVal xml As String) As ComprobanteFiscalInfo
        Dim Comprobante As ComprobanteFiscalInfo = Nothing
        Try
            Dim ComprobanteXML As New XmlDocument
            ComprobanteXML.LoadXml(xml)
            'Determinar la versión del comprobante
            Dim Version As Decimal = GetVersion(ComprobanteXML)
            '
            Comprobante = GetComprobante(ComprobanteXML, Version)
            'Validar que la versión de comprobante sea 2.2 o 3.2 si la fecha es mayor al 01/07/2012
            If (Version = 2 Or Version = 3) And Comprobante.Fecha >= New Date(2012, 7, 1) Then Throw New BusinessException("La versión del comprobante es " & Version.ToString & " y a partir del 01/07/2012 sólo pueden emitirse versiones 2.2 y 3.2")
            ValidarExistencia(idEmpresa, Comprobante)
            ValidarEsquema(xml, Version)
            If Version < 3 Then ValidarSelloDigital(ComprobanteXML, Comprobante)
            ValidarReceptor(idEmpresa, Comprobante)
            If Version >= 2 And Version < 3 Then ValidarFolio(Comprobante)
            If Version >= 2 And Version < 3 Then ValidarCertificado(Comprobante)

            Comprobante.Valido = True
        Catch ex As Exception
            If Comprobante IsNot Nothing Then
                Comprobante.Estatus = GetErrorStack(ex)
                Comprobante.Valido = False
            End If
        End Try
        Return Comprobante
    End Function

    Public Function Load(idProveedor As Integer, serie As String, folio As Integer, UUID As String) As ComprobanteFiscalInfo
        Try
            Dim XML As XmlDocument = GetXMLDocument(idProveedor, serie, folio, UUID)
            Dim Version As Decimal = GetVersion(XML)
            Dim Comprobante As ComprobanteFiscalInfo = GetComprobante(XML, Version)
            Return Comprobante
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del comprobante fiscal " & serie & "-" & folio.ToString & "(" & UUID & ")", ex)
        End Try
    End Function


#End Region

#Region "Validaciones"

    Private Sub ValidarExistencia(ByVal idEmpresa As Integer, ByVal comprobante As ComprobanteFiscalInfo)
        Dim ProveedorSvc As New ProveedorService(SessionID, Connection, Transaction)
        'Verificar si el proveedor de este comprobante está registrado
        If ProveedorSvc.Exists(idEmpresa, comprobante.Emisor.RFC) Then
            Dim Proveedor As ProveedorInfo = ProveedorSvc.GetDetail(idEmpresa, comprobante.Emisor.RFC)
            'Verificar si existe el comprobante en la base de datos
            If Exists(Proveedor.Identity, comprobante.Serie, comprobante.Folio, comprobante.UUID) Then
                Throw New BusinessException("El comprobante fiscal ya existe en la base de datos.")
            End If
        End If
    End Sub

    Private Sub ValidarEsquema(ByVal xml As String, ByVal version As Decimal)
        'Asignar esquema a una copia del comprobante fiscal
        Dim XMLTest As New XmlDocument
        Dim nsManager As New XmlNamespaceManager(XMLTest.NameTable)
        'Leer el esquema de la factura
        Dim ComprobanteXSD As Schema.XmlSchema
        Dim reader As System.IO.StringReader = Nothing
        If version = 2 Then
            reader = New System.IO.StringReader(My.Resources.FacturaXSD_V2)
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/2")
        ElseIf version = 2.2 Then
            reader = New System.IO.StringReader(My.Resources.FacturaXSD_V2_2)
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/2")
        ElseIf version = 3 Then
            reader = New System.IO.StringReader(My.Resources.FacturaXSD_V3)
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/3")
        ElseIf version = 3.2 Then
            reader = New System.IO.StringReader(My.Resources.FacturaXSD_V3_2)
            nsManager.AddNamespace("cfd", "http://www.sat.gob.mx/cfd/3")
        End If
        ComprobanteXSD = XmlSchema.Read(reader, AddressOf Esquema_Validation)
        Dim Esquemas As New XmlSchemaSet()
        Esquemas.Add(ComprobanteXSD)
        '
        XMLTest.LoadXml(xml)
        Dim Comprobante As XmlNode = XMLTest.SelectSingleNode("/cfd:Comprobante", nsManager)
        Dim NodeAddenda As XmlNode = Comprobante.SelectSingleNode("/cfd:Comprobante/cfd:Addenda", nsManager)
        If NodeAddenda IsNot Nothing Then Comprobante.RemoveChild(NodeAddenda)
        Dim ComplementoNode As XmlNode = Comprobante.SelectSingleNode("/cfd:Comprobante/cfd:Complemento", nsManager)
        If ComplementoNode IsNot Nothing Then Comprobante.RemoveChild(ComplementoNode)
        Dim ConceptosNode As XmlNode = Comprobante.SelectSingleNode("/cfd:Comprobante/cfd:Conceptos", nsManager)
        For Each conceptoNode As XmlNode In ConceptosNode.ChildNodes
            Dim ComplementoConceptoNode As XmlNode = conceptoNode.SelectSingleNode("cfd:ComplementoConcepto", nsManager)
            If ComplementoConceptoNode IsNot Nothing Then conceptoNode.RemoveChild(ComplementoConceptoNode)
        Next
        '
        XMLTest.Schemas = Esquemas
        XMLTest.Validate(AddressOf Esquema_Validation)
    End Sub

    Private Function ValidarSelloDigital(ByVal xmlComprobante As XmlDocument, ByVal comprobante As ComprobanteFiscalInfo) As Boolean
        'Si la factura contiene un certificado, verificar que el sello digital sea correcto
        If comprobante.Certificado.Trim <> String.Empty Then
            Dim CadenaOriginal As String = GenerarCadenaOriginal(xmlComprobante, CDec(comprobante.Version))
            Dim CertDigital As New Cert
            Dim success As Boolean = CertDigital.LoadFromBase64(comprobante.Certificado)
            Dim RSA As New Rsa
            success = RSA.UnlockComponent("AZTECARSA_vhvTCZ0KjHwn")
            If Not success Then Throw New BusinessException("Error de licencia en componente de encriptación")
            Dim PubKey As PublicKey = CertDigital.ExportPublicKey()
            If PubKey Is Nothing Then Return True
            success = RSA.ImportPublicKey(PubKey.GetXml)
            If Not success Then Throw New BusinessException("Error al importar la llave pública del certificado digital.")
            RSA.EncodingMode = "base64"
            RSA.Charset = "utf-8"
            RSA.LittleEndian = False
            If comprobante.Fecha <= New Date(2010, 12, 31) Then
                success = RSA.VerifyStringENC(CadenaOriginal, "md5", comprobante.Sello)
            Else
                success = RSA.VerifyStringENC(CadenaOriginal, "sha-1", comprobante.Sello)
            End If
            If Not success Then Throw New BusinessException("El sello digital del comprobante fiscal no es válido.")
            Return success
        Else
            Return True
        End If
    End Function

    Private Function ValidarReceptor(ByVal idEmpresa As Integer, ByVal factura As ComprobanteFiscalInfo) As Boolean
        Dim EmpresaSvc As New EmpresaService(SessionID, Connection, Transaction)
        Dim Empresa As EmpresaInfo = EmpresaSvc.GetDetailFromCache(idEmpresa)
        If Empresa.RFC.ToUpper.Trim = factura.Receptor.RFC.ToUpper.Trim Then
            Return True
        Else
            Dim DatosFiscales As String = "RFC: " & factura.Receptor.RFC & ControlChars.NewLine & "Razón Social: " & factura.Receptor.Nombre
            Throw New BusinessException("Los datos fiscales del comprobante fiscal son incorrectos." & ControlChars.NewLine & DatosFiscales)
        End If
    End Function

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

    Public Function ListaPorPeriodo(ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idEmpresa As Integer, ByVal idProveedor As Integer) As DataTable
        Try
            Dim fxReport As New FunctionSQL("Purchasing", "fxFacturasListRPT", Connection, Transaction)
            fxReport.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial.ToShortDateString
            fxReport.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal.ToShortDateString
            fxReport.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxReport.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            Dim dtFacturas As DataTable = fxReport.GetTable("Facturas")
            Return dtFacturas
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de facturas del perido " & fechaInicial.ToShortDateString & " al " & fechaFinal.ToShortDateString, ex)
        End Try
    End Function

    Public Function ListaProveedor(idProveedor As Integer, fechaInicial As Date, fechaFinal As Date) As DataTable
        Try
            Dim fxFacturas As New FunctionSQL("Purchasing", "fxFacturasProveedor", Connection, Transaction)
            fxFacturas.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxFacturas.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxFacturas.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            Dim dtFacturas As DataTable = fxFacturas.GetTable("Facturas")
            Return dtFacturas
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la lista de facturas del proveedor", ex)
        End Try
    End Function

    Public Function ListaPorPeriodo(fechaInicial As Date, fechaFinal As Date, idEmpresa As Integer) As DataTable
        Try
            Dim fxList As New FunctionSQL("Purchasing", "fxCFDList", Connection, Transaction)
            fxList.Parameters.Add("@IdEmpresa", DbType.Int32).Value = idEmpresa
            fxList.Parameters.Add("@FechaIni", DbType.DateTime).Value = fechaInicial
            fxList.Parameters.Add("@FechaFin", DbType.DateTime).Value = fechaFinal
            Dim dtList As DataTable = fxList.GetTable("Comprobantes")
            Return dtList
        Catch ex As Exception
            Throw New BusinessException("Error al obtener la lista de CFD.", ex)
        End Try
    End Function

    Public Function LoadPrintInfo(idProveedor As Integer, serie As String, folio As Integer, UUID As String) As InformesDS.ComprobantesFiscalesDataTable
        Try
            Dim ComprobanteSvc As New ComprobanteFiscalService(SessionID, Connection, Transaction)
            Dim Comprobante As ComprobanteFiscalInfo = ComprobanteSvc.Load(idProveedor, serie, folio, UUID)
            'Verificar la versión del comprobante
            Dim FunctionName As String = "fxComprobanteFiscalRPT_V2"
            If CDec(Comprobante.Version) >= 3 Then FunctionName = "fxComprobanteFiscalRPT_V3"
            'Cargar información de impresión
            Dim fxInfo As New FunctionSQL("Purchasing", FunctionName, Connection, Transaction)
            fxInfo.Parameters.Add("@IdProveedor", DbType.Int32).Value = idProveedor
            fxInfo.Parameters.Add("@Serie", DbType.String).Value = serie
            fxInfo.Parameters.Add("@Folio", DbType.Int32).Value = folio
            fxInfo.Parameters.Add("@UUID", DbType.String).Value = UUID
            Dim dtInfo As New InformesDS.ComprobantesFiscalesDataTable
            fxInfo.FillDataTable(dtInfo)
            Return dtInfo
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información de impresión del CFD.", ex)
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
    Private Sub ValidateSession(ByVal sessionID As GUID)

    End Sub

    Private Sub HandleException(ByVal ex As Exception)
        Azteca.Kernel.General.AppEventLog.LogException(ex)
        Throw ex
    End Sub
#End Region

#Region "Metodos Publicos"

    Public Sub Save(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal idProveedor As Integer, ByVal xmlComprobante As String, referencia As String, idDivisa As Integer, tipoCambio As Decimal)
        ValidateSession(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Try
                Transaction = DataServices.BeginTransaction(Connection)
                Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
                Svc.Save(idEmpresa, idSucursal, idProveedor, xmlComprobante, referencia, idDivisa, tipoCambio)
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

    Public Sub Save(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal idSucursal As Integer, ByVal xmlComprobante As String, idDivisa As Integer, tipoCambio As Decimal)
        Save(sessionID, idEmpresa, idSucursal, 0, xmlComprobante, String.Empty, idDivisa, tipoCambio)
    End Sub

    Public Sub Save(ByVal sessionID As Guid, ByVal idEmpresa As Integer, ByVal xmlComprobante As String)
        Save(sessionID, idEmpresa, 0, xmlComprobante, 1, 1)
    End Sub


    Public Function Validar(ByVal sessionID As GUID, ByVal idEmpresa As Integer, ByVal xml As String) As ComprobanteFiscalInfo
        ValidateSession(sessionID)
        Dim FacturaInf As New ComprobanteFiscalInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            FacturaInf = Svc.Validar(idEmpresa, xml)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return FacturaInf
    End Function

    Public Function GetComprobante(ByVal sessionID As Guid, IdProveedor As Integer, Serie As String, Folio As Integer, UUID As String) As ComprobanteFiscalInfo
        ValidateSession(sessionID)
        Dim Comprobante As New ComprobanteFiscalInfo(sessionID)
        Dim comprobanteXML As XmlDocument

        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            comprobanteXML = Svc.GetXMLDocument(IdProveedor, Serie, Folio, UUID)
            Dim PrimaryNodeIndex As Integer = 0
            If comprobanteXML.ChildNodes.Count > 1 Then PrimaryNodeIndex = 1
            'Determinar la versión del comprobante
            Dim Version As Integer = CInt(comprobanteXML.ChildNodes(PrimaryNodeIndex).Attributes("version").Value)
            Comprobante = Svc.GetComprobante(comprobanteXML, Version)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Comprobante
    End Function

    Public Function Load(sessionID As Guid, idProveedor As Integer, serie As String, folio As Integer, UUID As String) As ComprobanteFiscalInfo
        ValidateSession(sessionID)
        Dim Comprobante As New ComprobanteFiscalInfo(sessionID)
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            Comprobante = Svc.Load(idProveedor, serie, folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return Comprobante
    End Function

    Public Function GetXML(sessionID As Guid, IdProveedor As Integer, Serie As String, Folio As Integer, UUID As String) As String
        ValidateSession(sessionID)
        Dim XML As String = String.Empty
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection, Transaction)
            XML = Svc.GetXMLString(IdProveedor, Serie, Folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return XML
    End Function

#End Region

#Region "Informes"

    Public Function ListaPorPeriodo(ByVal sessionID As Guid, ByVal fechaInicial As Date, ByVal fechaFinal As Date, ByVal idEmpresa As Integer, ByVal idProveedor As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtFacturas As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection)
            dtFacturas = Svc.ListaPorPeriodo(fechaInicial, fechaFinal, idEmpresa, idProveedor)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFacturas
    End Function

    Public Function ListaProveedor(sessionID As Guid, idProveedor As Integer, fechaInicial As Date, fechaFinal As Date) As DataTable
        ValidateSession(sessionID)
        Dim dtFacturas As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection)
            dtFacturas = Svc.ListaProveedor(idProveedor, fechaInicial, fechaFinal)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtFacturas
    End Function

    Public Function ListaPorPeriodo(sessionID As Guid, fechaInicial As Date, fechaFinal As Date, idEmpresa As Integer) As DataTable
        ValidateSession(sessionID)
        Dim dtList As DataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection)
            dtList = Svc.ListaPorPeriodo(fechaInicial, fechaFinal, idEmpresa)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtList
    End Function

    Public Function LoadPrintInfo(sessionID As Guid, idProveedor As Integer, serie As String, folio As Integer, UUID As String) As InformesDS.ComprobantesFiscalesDataTable
        ValidateSession(sessionID)
        Dim dtInfo As InformesDS.ComprobantesFiscalesDataTable = Nothing
        Try
            Connection = DataServices.OpenConnection
            Dim Svc As New ComprobanteFiscalService(sessionID, Connection)
            dtInfo = Svc.LoadPrintInfo(idProveedor, serie, folio, UUID)
        Catch ex As Exception
            HandleException(ex)
        Finally
            DataServices.CloseConnection(Connection)
        End Try
        Return dtInfo
    End Function

#End Region

End Class
