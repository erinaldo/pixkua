<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminTallasColoresForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminTallasColoresForm))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Negro", "capture_32.png")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Azul"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.ControlLightLight, Nothing)
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.tlbMenh = New Azteca.Windows.Controls.AZToolBar()
        Me.btnAceptar = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        Me.chkRegleta = New Azteca.Windows.Controls.CICheckBox()
        Me.chkColores = New Azteca.Windows.Controls.CICheckBox()
        Me.lsvColores = New Azteca.Windows.Controls.CIListView()
        Me.ilstColores = New System.Windows.Forms.ImageList(Me.components)
        Me.CiLabel14 = New Azteca.Windows.Controls.CILabel()
        Me.CiPanel1 = New Azteca.Windows.Controls.CIPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me._flex = New Azteca.Windows.Controls.AZFlexGrid()
        Me.bsMatriz = New System.Windows.Forms.BindingSource(Me.components)
        Me.selRegleta = New Azteca.Windows.Inventario.RegletaSelector()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CiPanel1.SuspendLayout()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAceptar)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.ShortcutText = ""
        Me.cmdAceptar.Text = "Aceptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.ShortcutText = ""
        Me.cmdCancelar.Text = "Cancelar"
        '
        'tlbMenh
        '
        Me.tlbMenh.AccessibleName = "Tool Bar"
        Me.tlbMenh.AutoSize = False
        Me.tlbMenh.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenh.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAceptar, Me.btnCancelar})
        Me.tlbMenh.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenh.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenh.MinButtonSize = 32
        Me.tlbMenh.Movable = False
        Me.tlbMenh.Name = "tlbMenh"
        Me.tlbMenh.Size = New System.Drawing.Size(640, 35)
        Me.tlbMenh.Text = "AzToolBar1"
        Me.tlbMenh.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenh.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnAceptar
        '
        Me.btnAceptar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAceptar.Command = Me.cmdAceptar
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        '
        'chkRegleta
        '
        Me.chkRegleta.AutoSize = True
        Me.chkRegleta.Location = New System.Drawing.Point(12, 52)
        Me.chkRegleta.Name = "chkRegleta"
        Me.chkRegleta.Size = New System.Drawing.Size(63, 17)
        Me.chkRegleta.TabIndex = 3
        Me.chkRegleta.Text = "Regleta"
        Me.chkRegleta.UseVisualStyleBackColor = True
        '
        'chkColores
        '
        Me.chkColores.AutoSize = True
        Me.chkColores.Location = New System.Drawing.Point(12, 93)
        Me.chkColores.Name = "chkColores"
        Me.chkColores.Size = New System.Drawing.Size(61, 17)
        Me.chkColores.TabIndex = 4
        Me.chkColores.Text = "Colores"
        Me.chkColores.UseVisualStyleBackColor = True
        '
        'lsvColores
        '
        Me.lsvColores.CheckBoxes = True
        Me.lsvColores.Enabled = False
        Me.lsvColores.GridLines = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        Me.lsvColores.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lsvColores.LargeImageList = Me.ilstColores
        Me.lsvColores.Location = New System.Drawing.Point(81, 93)
        Me.lsvColores.Name = "lsvColores"
        Me.lsvColores.Size = New System.Drawing.Size(547, 92)
        Me.lsvColores.SmallImageList = Me.ilstColores
        Me.lsvColores.TabIndex = 5
        Me.lsvColores.UseCompatibleStateImageBehavior = False
        Me.lsvColores.View = System.Windows.Forms.View.List
        '
        'ilstColores
        '
        Me.ilstColores.ImageStream = CType(resources.GetObject("ilstColores.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilstColores.TransparentColor = System.Drawing.Color.Transparent
        Me.ilstColores.Images.SetKeyName(0, "capture_32.png")
        '
        'CiLabel14
        '
        Me.CiLabel14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CiLabel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CiLabel14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiLabel14.ForeColor = System.Drawing.Color.White
        Me.CiLabel14.Location = New System.Drawing.Point(0, 0)
        Me.CiLabel14.Name = "CiLabel14"
        Me.CiLabel14.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.CiLabel14.Size = New System.Drawing.Size(640, 322)
        Me.CiLabel14.TabIndex = 49
        Me.CiLabel14.Text = "Mátriz de Códigos de Resultados"
        Me.CiLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CiPanel1
        '
        Me.CiPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiPanel1.Controls.Add(Me.TextBox1)
        Me.CiPanel1.Controls.Add(Me._flex)
        Me.CiPanel1.Controls.Add(Me.CiLabel14)
        Me.CiPanel1.GradientColorA = System.Drawing.SystemColors.ControlLight
        Me.CiPanel1.GradientColorB = System.Drawing.SystemColors.ControlDark
        Me.CiPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.CiPanel1.Location = New System.Drawing.Point(0, 191)
        Me.CiPanel1.Name = "CiPanel1"
        Me.CiPanel1.Size = New System.Drawing.Size(640, 322)
        Me.CiPanel1.TabIndex = 50
        Me.CiPanel1.UseGradient = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 52
        '
        '_flex
        '
        Me._flex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._flex.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:72;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Location = New System.Drawing.Point(12, 19)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.Size = New System.Drawing.Size(616, 289)
        Me._flex.TabIndex = 50
        '
        'selRegleta
        '
        Me.selRegleta.AnySite = False
        Me.selRegleta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selRegleta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selRegleta.EditorAssembly = "Azteca.InventarioWin"
        Me.selRegleta.EditorClass = "Azteca.Windows.Inventario.RegletasForm"
        Me.selRegleta.EditorTitle = "Editar Regleta..."
        Me.selRegleta.Enabled = False
        Me.selRegleta.Key = 0
        Me.selRegleta.Linked = False
        Me.selRegleta.Location = New System.Drawing.Point(81, 52)
        Me.selRegleta.Name = "selRegleta"
        Me.selRegleta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selRegleta.Size = New System.Drawing.Size(547, 23)
        Me.selRegleta.TabIndex = 0
        '
        'AdminTallasColoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 511)
        Me.Controls.Add(Me.CiPanel1)
        Me.Controls.Add(Me.lsvColores)
        Me.Controls.Add(Me.chkColores)
        Me.Controls.Add(Me.chkRegleta)
        Me.Controls.Add(Me.tlbMenh)
        Me.Controls.Add(Me.selRegleta)
        Me.Name = "AdminTallasColoresForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Presentaciones por Talla y Color"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CiPanel1.ResumeLayout(False)
        Me.CiPanel1.PerformLayout()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selRegleta As Azteca.Windows.Inventario.RegletaSelector
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents tlbMenh As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAceptar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
    Friend WithEvents chkRegleta As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents chkColores As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents lsvColores As Azteca.Windows.Controls.CIListView
    Friend WithEvents ilstColores As System.Windows.Forms.ImageList
    Friend WithEvents CiLabel14 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiPanel1 As Azteca.Windows.Controls.CIPanel
    Friend WithEvents bsMatriz As System.Windows.Forms.BindingSource
    Friend WithEvents _flex As Azteca.Windows.Controls.AZFlexGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
