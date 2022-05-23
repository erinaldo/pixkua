Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json

Namespace Kernel.Search


    <Serializable()>
    <JsonConverter(GetType(Kernel.Serialization.SortOrderConverter))> _
    Public Class SortOrder

#Region "Propiedades"

        Public Property Field As String
        Public Property Direction As SortDirection

#End Region

#Region "Metodos"

        Public Overrides Function ToString() As String
            Return "[" + Field + "] " + GetDirection()
        End Function

        Public Function GetDirection() As String
            If (Direction = SortDirection.Ascending) Then
                Return "ASC"
            ElseIf (Direction = SortDirection.Descending) Then
                Return "DESC"
            Else
                Return "ASC"
            End If
        End Function


        Friend Sub SetDirection(direction As String)
            Select Case direction.Trim().ToUpper()
                Case "ASC"
                    direction = SortDirection.Ascending
                Case "DESC"
                    direction = SortDirection.Descending
            End Select
        End Sub

#End Region

    End Class

End Namespace