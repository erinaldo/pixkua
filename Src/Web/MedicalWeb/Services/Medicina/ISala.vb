Imports System.ServiceModel

Namespace Services.Medicina

    <ServiceContract()>
    Public Interface ISala
        Inherits ICatalogWebService

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function CargarAgenda(sessionID As Guid, idSala As Integer) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function AgendarEvento(sessionID As Guid, evento As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function EliminarEvento(sessionID As Guid, idEvento As Integer) As Boolean

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function AddUser(sessionID As Guid, idSala As Integer, idUsuario As Integer) As Boolean

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function RemoveUser(sessionID As Guid, idSala As Integer, idUsuario As Integer) As Boolean

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function LoadUserAccess(sessionID As Guid, idSala As Integer) As String

    End Interface

End Namespace
