Imports System.ServiceModel

Namespace Services.Kernel.General

    ' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPoblacion" in both code and config file together.
    <ServiceContract()>
    Public Interface IPoblacion

    <OperationContract()>
        Inherits ICatalogWebService

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String

    End Interface

End Namespace