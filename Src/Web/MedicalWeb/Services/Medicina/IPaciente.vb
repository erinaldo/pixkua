Imports System.ServiceModel

Namespace Services.Medicina

    <ServiceContract()>
    Public Interface IPaciente
        Inherits ICatalogWebService

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Overloads Function SearchKeyword(sessionID As Guid, keyword As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function GuardarRegistro(sessionID As Guid, idExpediente As Integer, idDoctor As Integer, idPaciente As Integer, diagnostico As String, medicina As String, motivo As String, generales As String, observaciones As String, tratamiento As String) As Integer

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function LoadRegistros(sessionID As Guid, idPaciente As Integer) As String

    End Interface

End Namespace