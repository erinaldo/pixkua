<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformesForm
    Inherits Azteca.Windows.Forms.BaseForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformesForm))
        Me.lblEjercicioFiscal = New Azteca.Windows.Controls.CILabel()
        Me.lblInformes = New Azteca.Windows.Controls.CILabel()
        Me.lblCuenta = New Azteca.Windows.Controls.CILabel()
        Me.lblPeriodo = New Azteca.Windows.Controls.CILabel()
        Me.cboInformes = New Azteca.Windows.Controls.CIComboBox()
        Me.cboPeriodo = New Azteca.Windows.Controls.CIComboBox()
        Me.tbInformes = New Azteca.Windows.Controls.CIToolBar()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.gbxGral = New Azteca.Windows.Controls.CIGroupBox()
        Me.cboEjercicioFiscal = New Azteca.Windows.Contabilidad.EjercicioFiscalCombobox()
        Me.selCuenta = New Azteca.Windows.Contabilidad.CuentaSelector()
        Me.tbInformes.SuspendLayout()
        Me.gbxGral.SuspendLayout()
        CType(Me.cboEjercicioFiscal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEjercicioFiscal
        '
        Me.lblEjercicioFiscal.AutoSize = True
        Me.lblEjercicioFiscal.Location = New System.Drawing.Point(25, 73)
        Me.lblEjercicioFiscal.Name = "lblEjercicioFiscal"
        Me.lblEjercicioFiscal.Size = New System.Drawing.Size(77, 13)
        Me.lblEjercicioFiscal.TabIndex = 0
        Me.lblEjercicioFiscal.Text = "Ejercicio Fiscal"
        '
        'lblInformes
        '
        Me.lblInformes.AutoSize = True
        Me.lblInformes.Location = New System.Drawing.Point(27, 48)
        Me.lblInformes.Name = "lblInformes"
        Me.lblInformes.Size = New System.Drawing.Size(42, 13)
        Me.lblInformes.TabIndex = 1
        Me.lblInformes.Text = "Informe"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Location = New System.Drawing.Point(27, 115)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
        Me.lblCuenta.TabIndex = 2
        Me.lblCuenta.Text = "Cuenta"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(360, 73)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 27
        Me.lblPeriodo.Text = "Periodo"
        '
        'cboInformes
        '
        Me.cboInformes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInformes.FormattingEnabled = True
        Me.cboInformes.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboInformes.ItemsTable = Nothing
        Me.cboInformes.Location = New System.Drawing.Point(110, 44)
        Me.cboInformes.Name = "cboInformes"
        Me.cboInformes.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboInformes.Size = New System.Drawing.Size(431, 21)
        Me.cboInformes.TabIndex = 28
        Me.cboInformes.UIName = Nothing
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPeriodo.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboPeriodo.ItemsTable = Nothing
        Me.cboPeriodo.Location = New System.Drawing.Point(409, 70)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPeriodo.Size = New System.Drawing.Size(132, 21)
        Me.cboPeriodo.TabIndex = 30
        Me.cboPeriodo.UIName = Nothing
        '
        'tbInformes
        '
        Me.tbInformes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbInformes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.ToolStripSeparator1})
        Me.tbInformes.Location = New System.Drawing.Point(0, 0)
        Me.tbInformes.Name = "tbInformes"
        Me.tbInformes.Size = New System.Drawing.Size(596, 39)
        Me.tbInformes.TabIndex = 31
        Me.tbInformes.Text = "Informes"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(89, 36)
        Me.btnPrint.Text = "Imprimir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'gbxGral
        '
        Me.gbxGral.Controls.Add(Me.cboEjercicioFiscal)
        Me.gbxGral.Controls.Add(Me.cboInformes)
        Me.gbxGral.Controls.Add(Me.lblEjercicioFiscal)
        Me.gbxGral.Controls.Add(Me.cboPeriodo)
        Me.gbxGral.Controls.Add(Me.lblInformes)
        Me.gbxGral.Controls.Add(Me.lblCuenta)
        Me.gbxGral.Controls.Add(Me.selCuenta)
        Me.gbxGral.Controls.Add(Me.lblPeriodo)
        Me.gbxGral.Location = New System.Drawing.Point(12, 49)
        Me.gbxGral.Name = "gbxGral"
        Me.gbxGral.Size = New System.Drawing.Size(572, 171)
        Me.gbxGral.TabIndex = 32
        Me.gbxGral.TabStop = False
        '
        'cboEjercicioFiscal
        '
        Me.cboEjercicioFiscal.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboEjercicioFiscal.AutoClear = False
        Me.cboEjercicioFiscal.AutoLock = False
        Me.cboEjercicioFiscal.Caption = ""
        Me.cboEjercicioFiscal.CaptionHeight = 17
        Me.cboEjercicioFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjercicioFiscal.ColumnCaptionHeight = 17
        Me.cboEjercicioFiscal.ColumnFooterHeight = 17
        Me.cboEjercicioFiscal.ColumnWidth = 100
        Me.cboEjercicioFiscal.ContentHeight = 15
        Me.cboEjercicioFiscal.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboEjercicioFiscal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboEjercicioFiscal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEjercicioFiscal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEjercicioFiscal.EditorHeight = 15
        Me.cboEjercicioFiscal.EnterTab = False
        Me.cboEjercicioFiscal.FilterExpression = Nothing
        Me.cboEjercicioFiscal.Images.Add(CType(resources.GetObject("cboEjercicioFiscal.Images"), System.Drawing.Image))
        Me.cboEjercicioFiscal.ItemHeight = 15
        Me.cboEjercicioFiscal.ItemsTable = Nothing
        Me.cboEjercicioFiscal.Location = New System.Drawing.Point(110, 71)
        Me.cboEjercicioFiscal.MatchEntryTimeout = CType(2000, Long)
        Me.cboEjercicioFiscal.MaxDropDownItems = CType(5, Short)
        Me.cboEjercicioFiscal.MaxLength = 32767
        Me.cboEjercicioFiscal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboEjercicioFiscal.Name = "cboEjercicioFiscal"
        Me.cboEjercicioFiscal.NoneItemText = Nothing
        Me.cboEjercicioFiscal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboEjercicioFiscal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboEjercicioFiscal.Size = New System.Drawing.Size(244, 21)
        Me.cboEjercicioFiscal.SortExpression = Nothing
        Me.cboEjercicioFiscal.TabIndex = 39
        Me.cboEjercicioFiscal.Text = "Seleccione un Ejercicio Fiscal"
        Me.cboEjercicioFiscal.UIName = Nothing
        Me.cboEjercicioFiscal.PropBag = resources.GetString("cboEjercicioFiscal.PropBag")
        '
        'selCuenta
        '
        Me.selCuenta.AnySite = False
        Me.selCuenta.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selCuenta.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.selCuenta.EditorAssembly = "Azteca.ContabilidadWin"
        Me.selCuenta.EditorClass = "Azteca.Windows.Contabilidad.CuentaForm"
        Me.selCuenta.EditorTitle = "Editar Cuenta..."
        Me.selCuenta.Enabled = False
        Me.selCuenta.Key = 0
        Me.selCuenta.Linked = False
        Me.selCuenta.Location = New System.Drawing.Point(110, 113)
        Me.selCuenta.Name = "selCuenta"
        Me.selCuenta.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.selCuenta.Size = New System.Drawing.Size(430, 23)
        Me.selCuenta.TabIndex = 26
        Me.selCuenta.TextWidth = 100
        '
        'InformesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 240)
        Me.Controls.Add(Me.gbxGral)
        Me.Controls.Add(Me.tbInformes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InformesForm"
        Me.Text = "Administrador de informes"
        Me.tbInformes.ResumeLayout(False)
        Me.tbInformes.PerformLayout()
        Me.gbxGral.ResumeLayout(False)
        Me.gbxGral.PerformLayout()
        CType(Me.cboEjercicioFiscal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEjercicioFiscal As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblInformes As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblCuenta As Azteca.Windows.Controls.CILabel
    Friend WithEvents selCuenta As Azteca.Windows.Contabilidad.CuentaSelector
    Friend WithEvents lblPeriodo As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboInformes As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents cboPeriodo As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents tbInformes As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxGral As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents cboEjercicioFiscal As Azteca.Windows.Contabilidad.EjercicioFiscalCombobox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
