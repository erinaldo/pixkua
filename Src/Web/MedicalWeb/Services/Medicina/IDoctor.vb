Imports System.ServiceModel

Namespace Services.Medicina

    <ServiceContract()>
    Public Interface IDoctor
        Inherits ICatalogWebService

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function CargarEspecialidades(sessionID As Guid) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function GetDoctorByUser(sessionID As Guid, idUsuario As Integer) As String

    End Interface

End Namespace
