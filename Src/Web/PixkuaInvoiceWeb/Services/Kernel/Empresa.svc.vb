Imports Azteca.Kernel.Security

Namespace Services.Kernel

    Public Class Empresa
        Implements IEmpresa

        Public Function LoadListByUsuario(sessionID As System.Guid, idUsuario As Integer) As String Implements IEmpresa.LoadListByUsuario
            Try
                Dim EmpresaFac As New EmpresaFacade
                Dim dsEmpresas As DataSet = EmpresaFac.LoadList(idUsuario)
                Return JsonConvert.SerializeObject(dsEmpresas.Tables(0))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function

    End Class

End Namespace
