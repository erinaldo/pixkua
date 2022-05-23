Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService" in both code and config file together.
<ServiceContract()>
Public Interface IService

    <OperationContract()>
    Sub EnviarCFD(ByVal codigoProveedor As String, ByVal password As String, ByVal cfd As String)

End Interface
