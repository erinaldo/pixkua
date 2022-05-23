Imports System.Xml
Imports System.IO
Imports Azteca.Business.Compras

Partial Class Facturacion_CargarFactura
    Inherits System.Web.UI.Page

    Dim PixcuaSession As Azteca.Kernel.Security.SessionInfo

    Private Function GetErrorStack(ByVal ex As Exception) As String
        Dim ErrorText As String = ex.Message
        If ex.InnerException IsNot Nothing Then ErrorText &= ControlChars.NewLine & GetErrorStack(ex.InnerException)
        Return ErrorText
    End Function


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PixcuaSession = CType(Application("Session"), Azteca.Kernel.Security.SessionInfo)
    End Sub

    Protected Sub btnCargar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        lblError.Text = String.Empty
        lblInfo.Text = String.Empty
        Try
            If updFactura.HasFile Then
                Dim xmlDoc As New XmlDocument
                Dim xmlStream As Stream = updFactura.FileContent
                Dim reader As New StreamReader(xmlStream)
                Dim xml As String = reader.ReadToEnd()
                reader.Close()
                'Obtener información del proveedor
                Dim ProveedorInf As ProveedorInfo = CType(Session("Proveedor"), ProveedorInfo)
                'Guardar factura en la base de datos
                Dim Servicio As New Service
                Servicio.EnviarCFD(ProveedorInf.UserCode, ProveedorInf.WebPassword, xml)
                lblInfo.Text = "La factura ha sido cargada con éxito."
            Else
                lblError.Text = "No ha especificado un archivo para cargar."
            End If
        Catch ex As Exception
            lblError.Text = GetErrorStack(ex)
        End Try
    End Sub

End Class
