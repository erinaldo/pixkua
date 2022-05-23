Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Azteca.Kernel.Search
Imports Newtonsoft.Json

Namespace Kernel.Serialization

    Public Class SortOrderConverter
        Inherits JsonConverter


        Public Overrides Function CanConvert(objectType As Type) As Boolean
            'return typeof(SortOrder).IsAssignableFrom(objectType)
            'Return TypeOf (SortOrder).IsAssignableFrom(objectType) Is 
            Return objectType Is GetType(Kernel.Search.SortOrder)
        End Function


        Public Overrides Sub WriteJson(writer As JsonWriter, value As Object, serializer As JsonSerializer)
            Dim Sort As Kernel.Search.SortOrder = CType(value, Kernel.Search.SortOrder)
            writer.WriteStartObject()
            writer.WritePropertyName("Field")
            serializer.Serialize(writer, Sort.Field)
            writer.WritePropertyName("Direction")
            serializer.Serialize(writer, Sort.GetDirection())
            writer.WriteEndObject()
        End Sub

        Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As Object, serializer As JsonSerializer) As Object
            Dim Sort As New Kernel.Search.SortOrder()

            While (reader.Read() And reader.TokenType <> Newtonsoft.Json.JsonToken.EndObject)
                If reader.TokenType = Newtonsoft.Json.JsonToken.PropertyName Then
                    Select Case reader.Value.ToString
                        Case "Field"
                            Sort.Field = reader.ReadAsString()
                        Case "Direction"
                            Sort.SetDirection(reader.ReadAsString())
                    End Select
                End If
            End While
            Return Sort
        End Function
    End Class

End Namespace