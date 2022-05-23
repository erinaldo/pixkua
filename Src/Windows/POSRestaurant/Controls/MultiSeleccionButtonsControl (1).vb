Public Class MultiSeleccionButtonsControl
    Private _key As Integer
    Private _MostrarNumerics As Boolean
    Private _Seleccionado As Boolean = False
    Public Event selectEvent(ByVal sender As Object, ByVal e As EventArgs)
    Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

    ''<Browsable(False), DefaultValue(GetType(CatalogInfo), Nothing), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public WriteOnly Property ImageButton As Image
        Set(ByVal value As Image)
            btnOpcion.Image = value
        End Set
    End Property

#Region "Propiedades"

    Public Property MostrarNumeric As Boolean
        Get
            Return _MostrarNumerics
        End Get
        Set(ByVal value As Boolean)
            _MostrarNumerics = value
            If Not MostrarNumeric Then
                lblDescripcion.Width = lblDescripcion.Width + AzNumericEdit1.Width
                AzNumericEdit1.Visible = False
            End If
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return lblDescripcion.Text
        End Get
        Set(ByVal value As String)
            lblDescripcion.Text = value
        End Set
    End Property

    Public Property Key As Integer
        Get
            Return _key
        End Get
        Set(ByVal value As Integer)
            _key = value
        End Set
    End Property

    Public Property Valor As Decimal
        Get
            Return AzNumericEdit1.Value
        End Get
        Set(ByVal value As Decimal)
            AzNumericEdit1.Value = 0
            AzNumericEdit1.Value = value
        End Set
    End Property

    Public Property Seleccionado As Boolean
        Get
            Return _Seleccionado
        End Get
        Set(ByVal value As Boolean)
            _Seleccionado = value
        End Set
    End Property


#End Region

    Private Sub btnOpcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpcion.Click
        RaiseEvent selectEvent(Me, e)
    End Sub

    Private Sub AzNumericEdit1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AzNumericEdit1.ValueChanged
        RaiseEvent ValueChanged(Me, e)
    End Sub

End Class
