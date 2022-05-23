Namespace Services.Kernel


    <ServiceContract()>
    Public Interface ISucursal

        <OperationContract()>
        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.WrappedRequest)>
        Function LoadListByUsuario(sessionID As Guid, idEmpresa As Integer, idUsuario As Integer) As String


    End Interface

End Namespace