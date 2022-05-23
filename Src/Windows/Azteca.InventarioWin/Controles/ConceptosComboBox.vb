Public Class ConceptosComboBox
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overrides Sub LoadList()
        Try
            Dim Concepto As New ConceptoFacade
            Dim dtList As DataTable = Concepto.LoadList(App.Session.SessionID)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdConcepto"
            _ItemsTable = dtList
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Overloads Sub LoadList(ByVal automaticos As Boolean, ByVal tipo As TipoConcepto)
        Dim TipoStr As String = "E"
        Select Case tipo
            Case TipoConcepto.Entrada
                TipoStr = "E"
            Case TipoConcepto.Salida
                TipoStr = "S"
            Case TipoConcepto.Traspaso
                TipoStr = "T"
        End Select
        FilterExpression = "Automatico=" & automaticos.ToString & " AND Tipo='" & TipoStr & "'"
        LoadList()
    End Sub

    Public Overloads Sub LoadList(ByVal automaticos As Boolean)
        FilterExpression = "Automatico=" & automaticos.ToString
        LoadList()
    End Sub

    Public Overloads Sub LoadList(ByVal tipo As TipoConcepto)
        Dim TipoStr As String = "E"
        Select Case tipo
            Case TipoConcepto.Entrada
                TipoStr = "E"
            Case TipoConcepto.Salida
                TipoStr = "S"
            Case TipoConcepto.Traspaso
                TipoStr = "T"
        End Select
        FilterExpression = "Tipo='" & TipoStr & "'"
        LoadList()
    End Sub


End Class
