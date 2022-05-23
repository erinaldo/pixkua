Namespace Services.Kernel


    <ServiceContract()>
    Public Interface IEmpresa

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function LoadListByUsuario(sessionID As Guid, idUsuario As Integer) As String

    End Interface

End Namespace