<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPrecioForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPrecioForm))
        Me.AzToolBar1 = New Azteca.Windows.Controls.AZToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAceptar = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.cboDivisa = New Azteca.Windows.Contabilidad.DivisasComboBox()
        Me.txtPrecio = New Azteca.Windows.Controls.CITextBox()
        Me.grpOpciones = New Azteca.Windows.Controls.CIGroupBox()
        Me.rdbFiltro = New Azteca.Windows.Controls.CIRadioButton()
        Me.rdbSeleccion = New Azteca.Windows.Controls.CIRadioButton()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'AzToolBar1
        '
        Me.AzToolBar1.AccessibleName = "Tool Bar"
        Me.AzToolBar1.AutoSize = False
        Me.AzToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.AzToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2})
        Me.AzToolBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AzToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.AzToolBar1.MinButtonSize = 32
        Me.AzToolBar1.Movable = False
        Me.AzToolBar1.Name = "AzToolBar1"
        Me.AzToolBar1.Size = New System.Drawing.Size(476, 32)
        Me.AzToolBar1.Text = "AzToolBar1"
        Me.AzToolBar1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.AzToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
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
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdAceptar
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmdCancelar
        Me.C1CommandLink2.SortOrder = 1
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(11, 57)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(40, 13)
        Me.CiLabel1.TabIndex = 0
        Me.CiLabel1.Text = "Precio:"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(12, 86)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(39, 13)
        Me.CiLabel2.TabIndex = 2
        Me.CiLabel2.Text = "Divisa:"
        '
        'cboDivisa
        '
        Me.cboDivisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDivisa.FormattingEnabled = True
        Me.cboDivisa.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboDivisa.ItemsTable = Nothing
        Me.cboDivisa.Location = New System.Drawing.Point(57, 83)
        Me.cboDivisa.Name = "cboDivisa"
        Me.cboDivisa.Size = New System.Drawing.Size(227, 21)
        Me.cboDivisa.TabIndex = 3
        Me.cboDivisa.UIName = Nothing
        '
        'txtPrecio
        '
        Me.txtPrecio.Digits = True
        Me.txtPrecio.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtPrecio.Format = "C"
        Me.txtPrecio.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPrecio.Location = New System.Drawing.Point(58, 57)
        Me.txtPrecio.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 1
        '
        'grpOpciones
        '
        Me.grpOpciones.Controls.Add(Me.rdbFiltro)
        Me.grpOpciones.Controls.Add(Me.rdbSeleccion)
        Me.grpOpciones.Location = New System.Drawing.Point(14, 119)
        Me.grpOpciones.Name = "grpOpciones"
        Me.grpOpciones.Size = New System.Drawing.Size(297, 95)
        Me.grpOpciones.TabIndex = 4
        Me.grpOpciones.TabStop = False
        Me.grpOpciones.Text = "Opciones"
        '
        'rdbFiltro
        '
        Me.rdbFiltro.AutoSize = True
        Me.rdbFiltro.Location = New System.Drawing.Point(43, 42)
        Me.rdbFiltro.Name = "rdbFiltro"
        Me.rdbFiltro.Size = New System.Drawing.Size(156, 17)
        Me.rdbFiltro.TabIndex = 1
        Me.rdbFiltro.Text = "Aplicar a elementos filtrados"
        Me.rdbFiltro.UseVisualStyleBackColor = True
        '
        'rdbSeleccion
        '
        Me.rdbSeleccion.AutoSize = True
        Me.rdbSeleccion.Checked = True
        Me.rdbSeleccion.Location = New System.Drawing.Point(43, 19)
        Me.rdbSeleccion.Name = "rdbSeleccion"
        Me.rdbSeleccion.Size = New System.Drawing.Size(188, 17)
        Me.rdbSeleccion.TabIndex = 0
        Me.rdbSeleccion.TabStop = True
        Me.rdbSeleccion.Text = "Aplicar a elementos seleccionados"
        Me.rdbSeleccion.UseVisualStyleBackColor = True
        '
        'EditPrecioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpOpciones)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cboDivisa)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.AzToolBar1)
        Me.Name = "EditPrecioForm"
        Me.Text = "Asignación de precio y divisa"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOpciones.ResumeLayout(False)
        Me.grpOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AzToolBar1 As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents cmdAceptar As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents grpOpciones As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents rdbFiltro As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents rdbSeleccion As Azteca.Windows.Controls.CIRadioButton
    Friend WithEvents txtPrecio As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboDivisa As Azteca.Windows.Contabilidad.DivisasComboBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
End Class
