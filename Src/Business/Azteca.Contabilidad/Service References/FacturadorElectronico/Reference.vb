﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.544
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace FacturadorElectronico
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://facturadorelectronico.com/timbrado/", ConfigurationName:="FacturadorElectronico.wsTimbradoSoap")>  _
    Public Interface wsTimbradoSoap
        
        'CODEGEN: Generating message contract since element name CFDIcliente from namespace http://facturadorelectronico.com/timbrado/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://facturadorelectronico.com/timbrado/obtenerTimbrado", ReplyAction:="*")>  _
        Function obtenerTimbrado(ByVal request As FacturadorElectronico.obtenerTimbradoRequest) As FacturadorElectronico.obtenerTimbradoResponse
        
        'CODEGEN: Generating message contract since element name xmlCancelacion from namespace http://facturadorelectronico.com/timbrado/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://facturadorelectronico.com/timbrado/cancelarComprobante", ReplyAction:="*")>  _
        Function cancelarComprobante(ByVal request As FacturadorElectronico.cancelarComprobanteRequest) As FacturadorElectronico.cancelarComprobanteResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class obtenerTimbradoRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="obtenerTimbrado", [Namespace]:="http://facturadorelectronico.com/timbrado/", Order:=0)>  _
        Public Body As FacturadorElectronico.obtenerTimbradoRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As FacturadorElectronico.obtenerTimbradoRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://facturadorelectronico.com/timbrado/")>  _
    Partial Public Class obtenerTimbradoRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public CFDIcliente As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public Usuario As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public password As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal CFDIcliente As String, ByVal Usuario As String, ByVal password As String)
            MyBase.New
            Me.CFDIcliente = CFDIcliente
            Me.Usuario = Usuario
            Me.password = password
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class obtenerTimbradoResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="obtenerTimbradoResponse", [Namespace]:="http://facturadorelectronico.com/timbrado/", Order:=0)>  _
        Public Body As FacturadorElectronico.obtenerTimbradoResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As FacturadorElectronico.obtenerTimbradoResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://facturadorelectronico.com/timbrado/")>  _
    Partial Public Class obtenerTimbradoResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public obtenerTimbradoResult As System.Xml.Linq.XElement
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal obtenerTimbradoResult As System.Xml.Linq.XElement)
            MyBase.New
            Me.obtenerTimbradoResult = obtenerTimbradoResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class cancelarComprobanteRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="cancelarComprobante", [Namespace]:="http://facturadorelectronico.com/timbrado/", Order:=0)>  _
        Public Body As FacturadorElectronico.cancelarComprobanteRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As FacturadorElectronico.cancelarComprobanteRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://facturadorelectronico.com/timbrado/")>  _
    Partial Public Class cancelarComprobanteRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public xmlCancelacion As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public usuario As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public password As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal xmlCancelacion As String, ByVal usuario As String, ByVal password As String)
            MyBase.New
            Me.xmlCancelacion = xmlCancelacion
            Me.usuario = usuario
            Me.password = password
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class cancelarComprobanteResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="cancelarComprobanteResponse", [Namespace]:="http://facturadorelectronico.com/timbrado/", Order:=0)>  _
        Public Body As FacturadorElectronico.cancelarComprobanteResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As FacturadorElectronico.cancelarComprobanteResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://facturadorelectronico.com/timbrado/")>  _
    Partial Public Class cancelarComprobanteResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public cancelarComprobanteResult As System.Xml.Linq.XElement
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal cancelarComprobanteResult As System.Xml.Linq.XElement)
            MyBase.New
            Me.cancelarComprobanteResult = cancelarComprobanteResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface wsTimbradoSoapChannel
        Inherits FacturadorElectronico.wsTimbradoSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class wsTimbradoSoapClient
        Inherits System.ServiceModel.ClientBase(Of FacturadorElectronico.wsTimbradoSoap)
        Implements FacturadorElectronico.wsTimbradoSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function FacturadorElectronico_wsTimbradoSoap_obtenerTimbrado(ByVal request As FacturadorElectronico.obtenerTimbradoRequest) As FacturadorElectronico.obtenerTimbradoResponse Implements FacturadorElectronico.wsTimbradoSoap.obtenerTimbrado
            Return MyBase.Channel.obtenerTimbrado(request)
        End Function
        
        Public Function obtenerTimbrado(ByVal CFDIcliente As String, ByVal Usuario As String, ByVal password As String) As System.Xml.Linq.XElement
            Dim inValue As FacturadorElectronico.obtenerTimbradoRequest = New FacturadorElectronico.obtenerTimbradoRequest()
            inValue.Body = New FacturadorElectronico.obtenerTimbradoRequestBody()
            inValue.Body.CFDIcliente = CFDIcliente
            inValue.Body.Usuario = Usuario
            inValue.Body.password = password
            Dim retVal As FacturadorElectronico.obtenerTimbradoResponse = CType(Me,FacturadorElectronico.wsTimbradoSoap).obtenerTimbrado(inValue)
            Return retVal.Body.obtenerTimbradoResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function FacturadorElectronico_wsTimbradoSoap_cancelarComprobante(ByVal request As FacturadorElectronico.cancelarComprobanteRequest) As FacturadorElectronico.cancelarComprobanteResponse Implements FacturadorElectronico.wsTimbradoSoap.cancelarComprobante
            Return MyBase.Channel.cancelarComprobante(request)
        End Function
        
        Public Function cancelarComprobante(ByVal xmlCancelacion As String, ByVal usuario As String, ByVal password As String) As System.Xml.Linq.XElement
            Dim inValue As FacturadorElectronico.cancelarComprobanteRequest = New FacturadorElectronico.cancelarComprobanteRequest()
            inValue.Body = New FacturadorElectronico.cancelarComprobanteRequestBody()
            inValue.Body.xmlCancelacion = xmlCancelacion
            inValue.Body.usuario = usuario
            inValue.Body.password = password
            Dim retVal As FacturadorElectronico.cancelarComprobanteResponse = CType(Me,FacturadorElectronico.wsTimbradoSoap).cancelarComprobante(inValue)
            Return retVal.Body.cancelarComprobanteResult
        End Function
    End Class
End Namespace