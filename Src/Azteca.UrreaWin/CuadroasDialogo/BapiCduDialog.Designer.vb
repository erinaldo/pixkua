<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BapiCduDialog
    Inherits Azteca.Windows.Forms.BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BapiCduDialog))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grdDatosBapi = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.bsDatosBapi = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.grdDatosBapi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDatosBapi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(621, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(540, 10)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 14
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 41)
        Me.Panel1.TabIndex = 16
        '
        'grdDatosBapi
        '
        Me.grdDatosBapi.AllowUpdate = False
        Me.grdDatosBapi.DataSource = Me.bsDatosBapi
        Me.grdDatosBapi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDatosBapi.FilterBar = True
        Me.grdDatosBapi.Images.Add(CType(resources.GetObject("grdDatosBapi.Images"), System.Drawing.Image))
        Me.grdDatosBapi.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosBapi.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdDatosBapi.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.Simple
        Me.grdDatosBapi.Name = "grdDatosBapi"
        Me.grdDatosBapi.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDatosBapi.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDatosBapi.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDatosBapi.PrintInfo.PageSettings = CType(resources.GetObject("grdDatosBapi.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDatosBapi.Size = New System.Drawing.Size(708, 272)
        Me.grdDatosBapi.TabIndex = 56
        Me.grdDatosBapi.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2010Blue
        Me.grdDatosBapi.PropBag = resources.GetString("grdDatosBapi.PropBag")
        '
        'BapiCduDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 313)
        Me.Controls.Add(Me.grdDatosBapi)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BapiCduDialog"
        Me.Text = "BapiCduDialog"
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdDatosBapi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDatosBapi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents grdDatosBapi As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsDatosBapi As System.Windows.Forms.BindingSource
End Class
