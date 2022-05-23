Imports Newtonsoft.Json

Public Class EventoSala

    Public Property ID As Integer
    Public Property IdSala As Integer

    <JsonConverter(GetType(Azteca.Kernel.Serialization.JavascriptDateConverter))> _
    Public Property FechaRegistro As Date

    <JsonConverter(GetType(Azteca.Kernel.Serialization.JavascriptDateConverter))> _
    Public Property FechaInicial As Date

    <JsonConverter(GetType(Azteca.Kernel.Serialization.JavascriptDateConverter))> _
    Public Property FechaFinal As Date

    Public Property IdDoctor As Integer
    Public Property Doctor As String

    Public Property IdPaciente As Integer
    Public Property Paciente As String

    Public Property Observaciones As String


End Class
