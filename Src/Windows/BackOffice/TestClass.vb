Public Class TestClass

    Public count As Integer

    Public Function SetNext(ByVal i As Integer) As Integer
        count += 1
        Return count
    End Function

    Public Function GetCount() As Integer
        Return count
    End Function


    Public Function GetMonthName(ByVal numberMonth As Integer) As String

        Dim NameMonth As String = ""


        Select Case numberMonth
            Case 1
                NameMonth = "ENERO"
            Case 2
                NameMonth = "FEBRERO"
            Case 3
                NameMonth = "MARZO"
            Case 4
                NameMonth = "ABRIL"
            Case 5
                NameMonth = "MAYO"
            Case 6
                NameMonth = "JUNIO"
            Case 7
                NameMonth = "JULIO"
            Case 8
                NameMonth = "AGOSTO"
            Case 9
                NameMonth = "SEPTIEMBRE"
            Case 10
                NameMonth = "OCTUBRE"
            Case 11
                NameMonth = "NOVIEMBRE"
            Case 12
                NameMonth = "DICIEMBRE"
        End Select

        Return NameMonth

    End Function




End Class
