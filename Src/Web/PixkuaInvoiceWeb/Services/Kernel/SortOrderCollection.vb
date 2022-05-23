Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Kernel.Search

    Public Class SortOrderCollection
        Inherits List(Of Kernel.Search.SortOrder)

        Public Overloads Function Add(field As String, Direction As SortDirection) As Kernel.Search.SortOrder
            Dim Sort As New Kernel.Search.SortOrder
            Sort.Field = field
            Sort.Direction = Direction
            Add(Sort)
            Return Sort
        End Function

    End Class

End Namespace