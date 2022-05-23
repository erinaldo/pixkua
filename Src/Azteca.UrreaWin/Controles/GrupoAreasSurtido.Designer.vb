<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrupoAreasSurtido
    Inherits Azteca.Windows.Controls.CIComboBox

    Public Overloads Sub LoadList()
        Try
            Dim Facade As New Azteca.Business.Urrea.GrupoAreaSurtidoFacade
            Dim dtResult As DataTable = Facade.LoadList(App.Session.SessionID, App.DefaultSite.Identity)
            Me.DisplayMember = "Nombre"
            Me.ValueMember = "IdGrupoAreaSurtido"
            _ItemsTable = dtResult
            MyBase.LoadList()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
