<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CerrarInventarioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CerrarInventarioForm))
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.grdDiferencias = New Azteca.Windows.Controls.AZTrueDBGrid()
        Me.bsDiferencias = New System.Windows.Forms.BindingSource(Me.components)
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdCerrarCorte = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCerrarCorte = New C1.Win.C1Command.C1CommandLink()
        CType(Me.grdDiferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDiferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiLabel1
        '
        Me.CiLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiLabel1.BackColor = System.Drawing.SystemColors.Info
        Me.CiLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel1.Location = New System.Drawing.Point(0, 37)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(661, 23)
        Me.CiLabel1.TabIndex = 8
        Me.CiLabel1.Text = "Diferencias contra el inventario físico"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grdDiferencias
        '
        Me.grdDiferencias.AllowUpdate = False
        Me.grdDiferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDiferencias.DataSource = Me.bsDiferencias
        Me.grdDiferencias.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveDown
        Me.grdDiferencias.FilterBar = True
        Me.grdDiferencias.Images.Add(CType(resources.GetObject("grdDiferencias.Images"), System.Drawing.Image))
        Me.grdDiferencias.Location = New System.Drawing.Point(0, 63)
        Me.grdDiferencias.Name = "grdDiferencias"
        Me.grdDiferencias.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdDiferencias.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdDiferencias.PreviewInfo.ZoomFactor = 75.0R
        Me.grdDiferencias.PrintInfo.PageSettings = CType(resources.GetObject("grdDiferencias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdDiferencias.Size = New System.Drawing.Size(661, 325)
        Me.grdDiferencias.TabIndex = 7
        Me.grdDiferencias.Text = "AzTrueDBGrid1"
        Me.grdDiferencias.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdDiferencias.PropBag = resources.GetString("grdDiferencias.PropBag")
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnCerrarCorte, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(661, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdCerrarCorte)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdCerrarCorte
        '
        Me.cmdCerrarCorte.Image = CType(resources.GetObject("cmdCerrarCorte.Image"), System.Drawing.Image)
        Me.cmdCerrarCorte.Name = "cmdCerrarCorte"
        Me.cmdCerrarCorte.Text = "Cerrar Corte"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar"
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        '
        'btnCerrarCorte
        '
        Me.btnCerrarCorte.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCerrarCorte.Command = Me.cmdCerrarCorte
        '
        'CerrarInventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.grdDiferencias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CerrarInventarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cerrar Corte de Inventario"
        CType(Me.grdDiferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDiferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents bsDiferencias As System.Windows.Forms.BindingSource
    Friend WithEvents grdDiferencias As Azteca.Windows.Controls.AZTrueDBGrid
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents btnCerrarCorte As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdCerrarCorte As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
End Class
