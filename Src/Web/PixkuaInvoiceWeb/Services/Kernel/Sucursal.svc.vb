Imports Azteca.Kernel.Security

Namespace Services.Kernel

    Public Class Sucursal
        Implements ISucursal

        Public Function LoadListByUsuario(sessionID As System.Guid, idEmpresa As Integer, idUsuario As Integer) As String Implements ISucursal.LoadListByUsuario
            Try
                Dim SucursalFac As New SucursalFacade
                Dim dsSucursales As DataSet = SucursalFac.LoadList(idEmpresa, idUsuario)
                Return JsonConvert.SerializeObject(dsSucursales.Tables(0))
            Catch ex As Exception
                Return ErrorHandler.HandleException(ex)
            End Try
        End Function
    End Class

End Namespace