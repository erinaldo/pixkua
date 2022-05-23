Imports System.Drawing
Imports System.ComponentModel

Public Class QuantityEditor
    Implements Azteca.Windows.Controls.Common.ISecure
    Implements Azteca.Windows.Controls.Common.IValidable
    Implements Azteca.Windows.Controls.Common.IEditable

    Private UnidadMedida As UnidadMedidaInfo

    Private _Value As Decimal = 0D
    Private _IdUnidadMedida As Integer = 0
    Private _Locked As Boolean

    <Browsable(False), DefaultValue(0)> _
    Public Property Value As Decimal
        Get
            Return _Value
        End Get
        Set(value As Decimal)
            _Value = value
            SetValue()
            RaiseEvent DataChanged(Me, EventArgs.Empty)
        End Set
    End Property

    <Browsable(False), DefaultValue(0)> _
    Public Property IdUnidadMedida As Integer
        Get
            Return _IdUnidadMedida
        End Get
        Set(value As Integer)
            Dim Changed As Boolean = value <> _IdUnidadMedida
            _IdUnidadMedida = value
            If Changed Then SetUnidadMedida()
        End Set
    End Property

    <DefaultValue(50)> _
    Public Property WidthUnidades As Integer
        Get
            Return nudUnidades.Width
        End Get
        Set(value As Integer)
            If value >= 50 Then
                nudUnidades.Width = value
            End If
        End Set
    End Property

    <DefaultValue(30)> _
    Public Property WidthLabel As Integer
        Get
            Return lblUnidad.Width
        End Get
        Set(value As Integer)
            If value >= 30 Then
                lblUnidad.Width = value
            End If
        End Set
    End Property

    Public Overrides Property Text As String
        Get
            Return _Value.ToString
        End Get
        Set(value As String)
            _Value = CDec(Val(value))
        End Set
    End Property


    Private Sub SetUnidadMedida()
        RaiseEvent DataChanged(Me, EventArgs.Empty)
        If IdUnidadMedida > 0 Then
            Dim UnidadMedidaFac As New UnidadMedidaFacade
            If UnidadMedidaFac.Exists(App.Session.SessionID, IdUnidadMedida) Then
                UnidadMedida = UnidadMedidaFac.GetDetailFromCache(App.Session.SessionID, IdUnidadMedida)
                If UnidadMedida.Identity > 1 And UnidadMedida.IdTipoUnidad = 1 And UnidadMedida.Factor > 1 Then
                    nudUnidades.Visible = True
                    nudUnidades.Maximum = UnidadMedida.Factor
                    txtCantidad.DigitsType = Windows.Controls.DigitsType.Integers
                Else
                    nudUnidades.Visible = False
                    If UnidadMedida.Identity = 1 Then
                        txtCantidad.DigitsType = Windows.Controls.DigitsType.Integers
                    Else
                        txtCantidad.DigitsType = Windows.Controls.DigitsType.Decimals
                    End If
                End If
                lblUnidad.Text = "[" & UnidadMedida.Abreviatura & "]"
                SetSize()
                SetValue()
                EnableControl(True)
            Else
                UnidadMedida = Nothing
                EnableControl(False)
                txtCantidad.Text = String.Empty
                nudUnidades.Value = 0
                lblUnidad.Text = "[]"
            End If
        Else
            txtCantidad.Text = String.Empty
            nudUnidades.Value = 0
            lblUnidad.Text = "[]"
        End If
    End Sub

    Private Sub SetValue()
        If UnidadMedida IsNot Nothing Then
            If UnidadMedida.Identity > 1 And UnidadMedida.IdTipoUnidad = 1 And UnidadMedida.Factor > 1 Then
                Dim Cantidad As New Empaquetado(Value, UnidadMedida.Factor)
                txtCantidad.Text = Cantidad.Cajas.ToString
                nudUnidades.Value = Cantidad.Unidades
            Else
                If UnidadMedida.Identity = 1 Then
                    txtCantidad.Text = CInt(Value).ToString
                Else
                    txtCantidad.Text = Value.ToString
                End If
            End If
        Else
            txtCantidad.Text = String.Empty
            nudUnidades.Value = 0
            lblUnidad.Text = "[]"
        End If
    End Sub

    Private Sub SetSize()
        Height = 20
        If Width < 132 Then Width = 132
        txtCantidad.Location = New Point(0, 0)
        If nudUnidades.Visible Then
            txtCantidad.Width = (Width - nudUnidades.Width - lblUnidad.Width)
            nudUnidades.Location = New Point(txtCantidad.Right + 1, 0)
            lblUnidad.Location = New Point(nudUnidades.Right + 1, 0)
        Else
            txtCantidad.Width = (Width - lblUnidad.Width)
            lblUnidad.Location = New Point(txtCantidad.Right + 1, 0)
        End If
    End Sub

    Private Sub QuantityEditor_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        SetSize()
    End Sub

    Private Sub EnableControl(enable As Boolean)
        txtCantidad.ReadOnly = Not (enable And UnidadMedida IsNot Nothing)
        nudUnidades.ReadOnly = Not (enable And UnidadMedida IsNot Nothing)
    End Sub


#Region "Implementacion Interfases"

    Private _InvalidReason As String

    Public Event DataChanged(sender As Object, e As System.EventArgs) Implements Controls.Common.IEditable.DataChanged

    <DefaultValue(True)> _
    Public Property AutoLock As Boolean = True Implements Controls.Common.ISecure.AutoLock

    Private Property Locked As Boolean Implements Controls.Common.ISecure.Locked
        Get
            Return _Locked
        End Get
        Set(value As Boolean)
            _Locked = value
            EnableControl(Not Locked)
        End Set
    End Property

    <Browsable(False), DefaultValue("")> _
    Public ReadOnly Property InvalidReason As String Implements Controls.Common.IValidable.InvalidReason
        Get
            Return _InvalidReason
        End Get
    End Property

    <DefaultValue(False)> _
    Public Property RequiredField As Boolean = False Implements Controls.Common.IValidable.RequiredField
    <DefaultValue("")> _
    Public Property UIName As String = String.Empty Implements Controls.Common.IValidable.UIName
    <DefaultValue(True)> _
    Public Property AutoClear As Boolean = True Implements Controls.Common.IEditable.AutoClear

    Public Sub ApplyPolicies(Politicas As Kernel.Security.PoliticasCollection) Implements Controls.Common.ISecure.ApplyPolicies
        Azteca.Windows.Controls.Common.Support.ApplyControlPolicies(Politicas, Me)
    End Sub

    Private Function IsEmpty() As Boolean Implements Controls.Common.IValidable.IsEmpty
        Return Val(txtCantidad.Text) <= 0
    End Function

    Private Function IsValid() As Boolean Implements Controls.Common.IValidable.IsValid
        Return True
    End Function

    Private Sub ClearData() Implements Controls.Common.IEditable.ClearData
        _Value = 0D
        txtCantidad.Text = "0"
        nudUnidades.Value = 0D
        lblUnidad.Text = "[]"
        _IdUnidadMedida = 0
        UnidadMedida = Nothing
        EnableControl(False)
    End Sub

#End Region

End Class
