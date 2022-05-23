<Serializable()> _
Public Class Movimiento

    Public Property IdMovimiento As Integer
    Public Property IdOrdenTrabajo As Integer
    Public Property IdEnsamble As Integer
    Public Property IdIncidencia As Integer
    Public Property Fecha As Date
    Public Property Clase As String
    Public Property Cantidad As Decimal
    Public Property Observaciones As String
    Public Property IdEmpleado As Integer

    Sub New()
        IdMovimiento = 0
        IdOrdenTrabajo = 0
        IdEnsamble = 0
        IdIncidencia = 0
        Clase = ""
        Cantidad = 0
        Fecha = Date.Today()
        Observaciones = String.Empty
        IdEmpleado = 0
    End Sub

End Class
