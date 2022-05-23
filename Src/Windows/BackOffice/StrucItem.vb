Public Enum ItemType
    Root
    [Module]
    Process
End Enum


Public Class StrucItem
    Inherits ListViewItem

    Private _Type As ItemType
    Private _ID As Integer

    Public Property Type() As ItemType
        Get
            Return _Type
        End Get
        Set(ByVal value As ItemType)
            _Type = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Public Sub New(ByVal text As String, ByVal imageKey As String, ByVal type As ItemType)
        MyBase.New(text, imageKey)
        _Type = type
    End Sub

    Public Sub New(ByVal text As String, ByVal imageIndex As Integer, ByVal type As ItemType)
        MyBase.New(text, imageIndex)
        _Type = type
    End Sub

End Class
