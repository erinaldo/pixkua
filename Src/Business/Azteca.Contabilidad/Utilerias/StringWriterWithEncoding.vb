Imports System.IO
Imports System.Text

Friend Class StringWriterWithEncoding
    Inherits StringWriter

    Private _encoding As Encoding

    Public Sub New(ByVal sb As StringBuilder, ByVal encoding As Encoding)
        MyBase.New(sb)
        _encoding = encoding
    End Sub

    Public Overrides ReadOnly Property Encoding() As Encoding
        Get
            Return _encoding
        End Get
    End Property

End Class