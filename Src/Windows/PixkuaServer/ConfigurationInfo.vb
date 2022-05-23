Imports System.Xml
Imports Azteca.Kernel

Public Class ConfigurationInfo
    Public Property Sesion As SesionInfo
    Public Property FacturaElectronica As FacturaElectronicaInfo

    Public Sub New()
        Sesion = New SesionInfo
        FacturaElectronica = New FacturaElectronicaInfo
    End Sub

    Public Sub CargarConfiguracion()
        Try
            Dim xmlConfig As New XmlDocument
            xmlConfig.Load(My.Application.Info.DirectoryPath & "\Configuracion.xml")
            '
            Dim SesionNode As XmlNode = xmlConfig.SelectSingleNode("PixkuaConfiguration/Session")
            With Sesion
                .UserName = SesionNode.Attributes("userName").Value
                .Password = SesionNode.Attributes("password").Value
            End With
            With FacturaElectronica
                Dim ArchivosValidacionNode As XmlNode = xmlConfig.SelectSingleNode("PixkuaConfiguration/FacturaElectronica/ArchivosValidacion")
                With .ArchivosValidacion
                    .DescargaAutomatica = CBool(ArchivosValidacionNode.Attributes("descargaAutomatica").Value)
                    .HoraDescarga = CDate(ArchivosValidacionNode.Attributes("horaDescarga").Value)
                End With
            End With
        Catch ex As Exception
            Throw New AztecaException("Error al cargar la configuración del servidor de aplicaciones.", ex)
        End Try
    End Sub
End Class


Public Class SesionInfo
    Public Property UserName As String
    Public Property Password As String
End Class

Public Class FacturaElectronicaInfo
    Public Property ArchivosValidacion As ArchivosValidacionInfo

    Public Sub New()
        ArchivosValidacion = New ArchivosValidacionInfo
    End Sub
End Class

Public Class ArchivosValidacionInfo
    Public Property DescargaAutomatica As Boolean
    Public Property HoraDescarga As Date
End Class