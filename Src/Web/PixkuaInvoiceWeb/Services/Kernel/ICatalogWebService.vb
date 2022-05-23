Namespace Services.Kernel
    <ServiceContract()>
    Public Interface ICatalogWebService

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Create(sessionID As Guid) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Update(sessionID As Guid, info As String) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function GetDetailByID(sessionID As Guid, itemID As Integer, checkStatus As Boolean)

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function GetDetailByCode(sessionID As Guid, idBranch As Integer, code As String, checkStatus As Boolean)

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Delete(sessionID As Guid, itemID As Integer) As Boolean

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function ExistsID(sessionID As Guid, itemID As Integer) As Boolean

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function ExistsCode(sessionID As Guid, idBranch As Integer, code As String) As Boolean

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function LoadList(idBranch As Integer) As String

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Search(sessionID As Guid, idBranch As Integer, conditions As String, sortOrder As String, page As Integer) As String

        <OperationContract()>
       <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Sub ChangeStatus(sessionID As Guid, itemId As Integer, Active As Boolean)

    End Interface
End Namespace