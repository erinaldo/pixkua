
Public Structure Empaquetado
    Private _Cajas As Integer
    Private _Unidades As Integer
    Private _Presentacion As Decimal

#Region "Operadores"
    Public Shared Operator +(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Empaquetado
        If emp1.Presentacion = emp2.Presentacion Then
            Dim Cantidad As Decimal = emp1.ToDecimal + emp2.ToDecimal
            Return New Empaquetado(Cantidad, emp1.Presentacion)
        Else
            Throw New InvalidOperationException("No es posible sumar dos empaquetados con presentacón diferente")
        End If
    End Operator

    Public Shared Operator -(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Empaquetado
        If emp1.Presentacion = emp2.Presentacion Then
            Dim Cantidad As Decimal = emp1.ToDecimal - emp2.ToDecimal
            Return New Empaquetado(Cantidad, emp1.Presentacion)
        Else
            Throw New InvalidOperationException("No es posible restar dos empaquetados con presentacón diferente")
        End If
    End Operator

    Public Shared Operator >(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Boolean
        If emp1.Presentacion = emp2.Presentacion Then
            Return emp1.ToDecimal > emp2.ToDecimal
        Else
            Throw New InvalidOperationException("No es posible comparar dos empaquetados de diferente presentación")
        End If
    End Operator

    Public Shared Operator <(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Boolean
        If emp1.Presentacion = emp2.Presentacion Then
            Return emp1.ToDecimal < emp2.ToDecimal
        Else
            Throw New InvalidOperationException("No es posible comparar dos empaquetados de diferente presentación")
        End If
    End Operator

    Public Shared Operator =(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Boolean
        If emp1.Presentacion = emp2.Presentacion Then
            Return emp1.ToDecimal = emp2.ToDecimal
        Else
            Throw New InvalidOperationException("No es posible comparar dos empaquetados de diferente presentación")
        End If
    End Operator

    Public Shared Operator <>(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Boolean
        If emp1.Presentacion = emp2.Presentacion Then
            Return emp1.ToDecimal <> emp2.ToDecimal
        Else
            Throw New InvalidOperationException("No es posible comparar dos empaquetados de diferente presentación")
        End If
    End Operator

    Public Shared Operator >=(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Boolean
        If emp1.Presentacion = emp2.Presentacion Then
            Return emp1.ToDecimal >= emp2.ToDecimal
        Else
            Throw New InvalidOperationException("No es posible comparar dos empaquetados de diferente presentación")
        End If
    End Operator

    Public Shared Operator <=(ByVal emp1 As Empaquetado, ByVal emp2 As Empaquetado) As Boolean
        If emp1.Presentacion = emp2.Presentacion Then
            Return emp1.ToDecimal <= emp2.ToDecimal
        Else
            Throw New InvalidOperationException("No es posible comparar dos empaquetados de diferente presentación")
        End If
    End Operator

#End Region

#Region "Propiedades"
    Public Property Cajas() As Integer
        Get
            Return _Cajas
        End Get
        Set(ByVal value As Integer)
            _Cajas = value
        End Set
    End Property

    Public Property Unidades() As Integer
        Get
            Return _Unidades
        End Get
        Set(ByVal value As Integer)
            _Unidades = value
        End Set
    End Property

    Public Property Presentacion() As Decimal
        Get
            Return _Presentacion
        End Get
        Set(ByVal value As Decimal)
            _Presentacion = value
        End Set
    End Property

    Public ReadOnly Property TotalUnidades() As Integer
        Get
            Return CInt((Cajas * _Presentacion) + _Unidades)
        End Get
    End Property

#End Region

#Region "Metodos"
    Public Sub New(ByVal cajas As Integer, ByVal unidades As Integer, ByVal presentacion As Decimal)
        Dim TotalUnidades As Integer = CInt(unidades + (cajas * presentacion))
        _Cajas = CInt(TotalUnidades \ CInt(presentacion))
        _Unidades = TotalUnidades Mod CInt(presentacion)
        _Presentacion = presentacion
    End Sub

    Public Sub New(ByVal cantidad As Decimal, ByVal presentacion As Decimal)
        _Cajas = CInt(Math.Truncate(cantidad))
        _Unidades = CInt((cantidad - Cajas) * presentacion)
        If _Unidades = presentacion Then
            _Cajas = Cajas + 1
            _Unidades = 0
        End If
        _Presentacion = presentacion
    End Sub

    Public Function ToDecimal() As Decimal
        Dim Cantidad As Decimal = CDec(Me.Cajas + (Me.Unidades / Me.Presentacion))
        Return Cantidad        
    End Function

    Public Shared Function ToDecimal(ByVal emp As Empaquetado) As Decimal
        Dim Cantidad As Decimal = CDec(emp.Cajas + (emp.Unidades / emp.Presentacion))
        Return Cantidad
    End Function

    Public Shared Function ToEmpaquetado(ByVal cantidad As Decimal, ByVal presentacion As Decimal) As Empaquetado
        Dim emp As New Empaquetado(cantidad, presentacion)
        Return emp
    End Function

#End Region

End Structure

