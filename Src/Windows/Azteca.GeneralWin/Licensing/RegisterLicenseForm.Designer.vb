<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterLicenseForm
    Inherits Azteca.Windows.Forms.Forma

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterLicenseForm))
        Me.grdLicencias = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.bsLicencias = New System.Windows.Forms.BindingSource(Me.components)
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        CType(Me.grdLicencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLicencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdLicencias
        '
        Me.grdLicencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLicencias.DataSource = Me.bsLicencias
        Me.grdLicencias.Images.Add(CType(resources.GetObject("grdLicencias.Images"), System.Drawing.Image))
        Me.grdLicencias.Images.Add(CType(resources.GetObject("grdLicencias.Images1"), System.Drawing.Image))
        Me.grdLicencias.Images.Add(CType(resources.GetObject("grdLicencias.Images2"), System.Drawing.Image))
        Me.grdLicencias.Images.Add(CType(resources.GetObject("grdLicencias.Images3"), System.Drawing.Image))
        Me.grdLicencias.Location = New System.Drawing.Point(0, 85)
        Me.grdLicencias.Name = "grdLicencias"
        Me.grdLicencias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdLicencias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdLicencias.PreviewInfo.ZoomFactor = 75.0R
        Me.grdLicencias.PrintInfo.PageSettings = CType(resources.GetObject("grdLicencias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdLicencias.Size = New System.Drawing.Size(553, 249)
        Me.grdLicencias.TabIndex = 6
        Me.grdLicencias.Text = "C1TrueDBGrid1"
        Me.grdLicencias.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdLicencias.PropBag = resources.GetString("grdLicencias.PropBag")
        '
        'picTitle
        '
        Me.picTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picTitle.Image = Global.Azteca.Windows.General.My.Resources.Resources.RegistroLicencias
        Me.picTitle.Location = New System.Drawing.Point(0, -2)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(553, 81)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 5
        Me.picTitle.TabStop = False
        '
        'btnAplicar
        '
        Me.btnAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAplicar.Image = Global.Azteca.Windows.General.My.Resources.Resources.button_ok
        Me.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAplicar.Location = New System.Drawing.Point(418, 340)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(123, 32)
        Me.btnAplicar.TabIndex = 7
        Me.btnAplicar.Text = "Aplicar Cambios"
        Me.btnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'RegisterLicenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 397)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.grdLicencias)
        Me.Controls.Add(Me.picTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "RegisterLicenseForm"
        Me.Text = "RegisterLicenseForm"
        Me.Controls.SetChildIndex(Me.picTitle, 0)
        Me.Controls.SetChildIndex(Me.grdLicencias, 0)
        Me.Controls.SetChildIndex(Me.btnAplicar, 0)
        CType(Me.grdLicencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLicencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTitle As System.Windows.Forms.PictureBox
    Friend WithEvents grdLicencias As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsLicencias As System.Windows.Forms.BindingSource
    Friend WithEvents btnAplicar As System.Windows.Forms.Button
End Class
