
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.ServiceModel.Web

Namespace Services.Kernel
    Public Class ErrorHandler

        Public Shared Function HandleException(ex As Exception) As String
            Throw New WebFaultException(Of String)(ex.Message, System.Net.HttpStatusCode.InternalServerError)
        End Function

    End Class

End Namespace



