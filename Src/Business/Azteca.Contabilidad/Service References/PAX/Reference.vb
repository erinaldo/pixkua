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


Namespace PAX
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="https://test.paxfacturacion.com.mx:453", ConfigurationName:="PAX.IwcfRecepcion")>  _
    Public Interface IwcfRecepcion
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://test.paxfacturacion.com.mx:453/IwcfRecepcion/fnEnviarXML", ReplyAction:="https://test.paxfacturacion.com.mx:453/IwcfRecepcion/fnEnviarXMLResponse")>  _
        Function fnEnviarXML(ByVal psComprobante As String, ByVal psTipoDocumento As String, ByVal pnId_Estructura As Integer, ByVal sNombre As String, ByVal sContraseña As String, ByVal sVersion As String) As String
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IwcfRecepcionChannel
        Inherits PAX.IwcfRecepcion, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class IwcfRecepcionClient
        Inherits System.ServiceModel.ClientBase(Of PAX.IwcfRecepcion)
        Implements PAX.IwcfRecepcion
        
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
        
        Public Function fnEnviarXML(ByVal psComprobante As String, ByVal psTipoDocumento As String, ByVal pnId_Estructura As Integer, ByVal sNombre As String, ByVal sContraseña As String, ByVal sVersion As String) As String Implements PAX.IwcfRecepcion.fnEnviarXML
            Return MyBase.Channel.fnEnviarXML(psComprobante, psTipoDocumento, pnId_Estructura, sNombre, sContraseña, sVersion)
        End Function
    End Class
End Namespace