Partial Class BeneficiarioService

    Public Function GetIDByProveedor(idProveedor As Integer) As Integer
        Try
            'Obtener el id del beneficiario
            Dim fxId As New FunctionSQL("Treasury", "fxBeneficiarioByType", Connection, Transaction)
            fxId.Parameters.Add("@Tipo", DbType.String).Value = "P"
            fxId.Parameters.Add("@IdReferencia", DbType.Int32).Value = idProveedor
            Dim IdBeneficiario As Integer = CInt(fxId.GetScalar())
            Return IdBeneficiario
        Catch ex As Exception
            Throw New BusinessException("Error al obtener el ID del beneficiario (Proveedor: " & idProveedor & ")", ex)
        End Try
    End Function

    Public Function GetDetailByIdProveedor(idProveedor As Integer) As BeneficiarioInfo
        Try
            Dim IdBeneficiario As Integer = GetIDByProveedor(idProveedor)
            If IdBeneficiario > 0 Then
                'Cargar información del beneficiario
                Dim Svc As New BeneficiarioService(SessionID, Connection, Transaction)
                Dim Beneficiario As New BeneficiarioInfo(SessionID)
                Svc.GetDetail(IdBeneficiario, Beneficiario, False)
                Return Beneficiario
            Else
                Throw New BusinessException("No se encontró el proveedor " & idProveedor & " en el catálogo de beneficiarios")
            End If
        Catch ex As Exception
            Throw New BusinessException("Error al cargar la información del beneficiario (Proveedor: " & idProveedor & ")", ex)
        End Try
    End Function

End Class
