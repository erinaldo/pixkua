Public Class DomicilioEditForm

#Region "Propiedades Publicas"

    Public ReadOnly Property Calle As String
        Get
            Return txtCalle.Text
        End Get
    End Property
    Public ReadOnly Property NumExt As String
        Get
            Return txtNumExt.Text
        End Get
    End Property
    Public ReadOnly Property NumInt As String
        Get
            Return txtNumInt.Text
        End Get
    End Property
    Public ReadOnly Property Colonia As String
        Get
            Return txtColonia.Text
        End Get
    End Property
    Public ReadOnly Property CP As String
        Get
            Return txtCP.Text
        End Get
    End Property
    Public ReadOnly Property Fax As String
        Get
            Return txtFax.Text
        End Get
    End Property
    Public ReadOnly Property Tel1 As String
        Get
            Return txtTel1.Text
        End Get
    End Property
    Public ReadOnly Property Tel2 As String
        Get
            Return txtTel2.Text
        End Get
    End Property
    Public ReadOnly Property IdPoblacion As Integer
        Get
            Return txtPoblacion.Key
        End Get
    End Property
    Public ReadOnly Property IdMunicipio As Integer
        Get
            Return txtMunicipio.Key
        End Get
    End Property

#End Region

    Public Overloads Function ShowDialog(ByVal owner As Form, ByVal calle As String, ByVal NumExt As String, ByVal NumInt As String, ByVal Colonia As String, ByVal CP As String, _
                                         ByVal IdPoblacion As Integer, ByVal IdMunicipio As Integer, ByVal Tel1 As String, ByVal Tel2 As String, ByVal Fax As String) As DialogResult
        txtCalle.Text = calle
        txtNumExt.Text = NumExt
        txtNumInt.Text = NumInt
        txtColonia.Text = Colonia
        txtCP.Text = CP
        txtPoblacion.LoadInfo(IdPoblacion)
        txtMunicipio.LoadInfo(IdMunicipio)
        txtTel1.Text = Tel1
        txtTel2.Text = Tel2
        txtFax.Text = Fax

        Return MyBase.ShowDialog(owner)
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

End Class