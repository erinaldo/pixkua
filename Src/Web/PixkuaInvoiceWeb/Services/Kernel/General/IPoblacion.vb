Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPoblacion" in both code and config file together.
Namespace Services.Kernel.General

    <ServiceContract()>
    Public Interface IPoblacion

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function LoadList(sessionID As Guid, idMunicipio As Integer) As String

        <OperationContract()>
       <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Search(sessionID As Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String
    End Interface

End Namespace