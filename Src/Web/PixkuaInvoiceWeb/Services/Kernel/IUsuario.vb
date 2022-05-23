

Namespace Services.Kernel


    <ServiceContract()>
    Public Interface IUsuario

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function Login(userName As String, password As String) As String

    End Interface

End Namespace