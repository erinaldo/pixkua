Public Class CuentaSelector
    Inherits Azteca.Windows.Controls.CatalogSelector

    Private HierarchyFac As Azteca.Kernel.BusinessStructure.IHierarchyFacade

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        If Not DesignMode Then
            Dim CtaFac As New CuentaFacade
            Me.Facade = CtaFac
            Me.HierarchyFac = CtaFac
            Me.EditorAssembly = "Azteca.ContabilidadWin"
            Me.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
            Me.EditorTitle = "Editar Cuenta..."
        End If
    End Sub

    Protected Overrides Sub OnLoadingInfo(ByVal e As System.ComponentModel.CancelEventArgs)
        MyBase.OnLoadingInfo(e)
        Dim Cuenta As CuentaInfo = CType(Me.PackageInfo, CuentaInfo)
        If Cuenta IsNot Nothing Then
            Text = Cuenta.UserCode
            Key = Cuenta.Identity
            TextInfo = Cuenta.Nombre
        Else
            If Me.Text.Trim.Length > 0 Then
                Dim CtaFac As New CuentaFacade
                Dim Cta As CuentaInfo = CtaFac.GetDetail(App.Session.SessionID, CInt(Me.Text))
                Me.Text = Cta.UserCode
                Me.TextInfo = Cta.Nombre
                Me.Key = Cta.Identity
            End If
        End If
    End Sub

    Protected Overrides Sub OnSearchingItem(ByVal e As System.EventArgs)
        Dim frmSearch As New Azteca.Windows.Forms.MsgHierarchyForm
        If frmSearch.ShowDialog(HierarchyFac, Facade) = System.Windows.Forms.DialogResult.OK Then
            PackageInfo = Facade.GetDetail(App.Session.SessionID, frmSearch.SelectedId)
            LoadInfo()
        End If
    End Sub


    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CuentaSelector
        '
        Me.Name = "CuentaSelector"
        Me.Size = New System.Drawing.Size(191, 23)
        Me.TextWidth = 100
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub CuentaSelector_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not DesignMode Then
            Me.MaskText = App.DefaultCompany.FormatoContable()
        End If
    End Sub
End Class