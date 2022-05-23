

Namespace Services.Kernel


    <ServiceContract()>
    Public Interface IUsuario
        Inherits ICatalogWebService

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Login(userName As String, password As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function SearchKeyword(sessionID As Guid, keyword As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function CargarAccesos(sessionID As Guid, idUsuario As Integer) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function GuardarAccesos(sessionID As Guid, idUsuario As Integer, accesos As String) As String

    End Interface

End Namespace