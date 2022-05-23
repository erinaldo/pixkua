<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeriodosForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeriodosForm))
        Me.cboEjercicio = New Azteca.Windows.Contabilidad.EjercicioFiscalCombobox()
        Me.txtNombre = New Azteca.Windows.Controls.CITextBox()
        Me.lblNombre = New Azteca.Windows.Controls.CILabel()
        Me.cboPeriodo = New Azteca.Windows.Controls.CIComboBox()
        Me.lblPeriodo = New Azteca.Windows.Controls.CILabel()
        Me.lblEjercicio = New Azteca.Windows.Controls.CILabel()
        Me.lblApertura = New Azteca.Windows.Controls.CILabel()
        Me.lblFechaApertura = New Azteca.Windows.Controls.CILabel()
        Me.btnAbrir = New Azteca.Windows.Controls.CIButton()
        Me.btnCerrar = New Azteca.Windows.Controls.CIButton()
        Me.lblFechaCierreTXT = New Azteca.Windows.Controls.CILabel()
        Me.lblFechaCierre = New Azteca.Windows.Controls.CILabel()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        CType(Me.cboEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEjercicio
        '
        Me.cboEjercicio.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cboEjercicio.AutoClear = False
        Me.cboEjercicio.AutoLock = False
        Me.cboEjercicio.Caption = ""
        Me.cboEjercicio.CaptionHeight = 17
        Me.cboEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cboEjercicio.ColumnCaptionHeight = 17
        Me.cboEjercicio.ColumnFooterHeight = 17
        Me.cboEjercicio.ColumnWidth = 100
        Me.cboEjercicio.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cboEjercicio.ContentHeight = 15
        Me.cboEjercicio.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cboEjercicio.DisplayMember = "IdEjercicioFiscalTit"
        Me.cboEjercicio.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cboEjercicio.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEjercicio.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cboEjercicio.EditorHeight = 15
        Me.cboEjercicio.EnterTab = False
        Me.cboEjercicio.FilterExpression = Nothing
        Me.cboEjercicio.Images.Add(CType(resources.GetObject("cboEjercicio.Images"), System.Drawing.Image))
        Me.cboEjercicio.ItemHeight = 15
        Me.cboEjercicio.ItemsTable = Nothing
        Me.cboEjercicio.Location = New System.Drawing.Point(100, 125)
        Me.cboEjercicio.MatchEntryTimeout = CType(2000, Long)
        Me.cboEjercicio.MaxDropDownItems = CType(5, Short)
        Me.cboEjercicio.MaxLength = 32767
        Me.cboEjercicio.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cboEjercicio.Name = "cboEjercicio"
        Me.cboEjercicio.NoneItemText = Nothing
        Me.cboEjercicio.RequiredField = True
        Me.cboEjercicio.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cboEjercicio.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cboEjercicio.Size = New System.Drawing.Size(326, 21)
        Me.cboEjercicio.SortExpression = Nothing
        Me.cboEjercicio.TabIndex = 39
        Me.cboEjercicio.Text = "Seleccione un Ejercicio Fiscal"
        Me.cboEjercicio.UIName = Nothing
        Me.cboEjercicio.ValueMember = "IdEjercicioFiscalTit"
        Me.cboEjercicio.PropBag = resources.GetString("cboEjercicio.PropBag")
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNombre.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNombre.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNombre.Location = New System.Drawing.Point(100, 99)
        Me.txtNombre.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.RequiredField = True
        Me.txtNombre.Size = New System.Drawing.Size(326, 20)
        Me.txtNombre.TabIndex = 41
        Me.txtNombre.UIName = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 101)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 40
        Me.lblNombre.Text = "Nombre:"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboPeriodo.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cboPeriodo.ItemsTable = Nothing
        Me.cboPeriodo.Location = New System.Drawing.Point(100, 152)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.RequiredField = True
        Me.cboPeriodo.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboPeriodo.Size = New System.Drawing.Size(144, 21)
        Me.cboPeriodo.TabIndex = 42
        Me.cboPeriodo.UIName = Nothing
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(12, 155)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(46, 13)
        Me.lblPeriodo.TabIndex = 43
        Me.lblPeriodo.Text = "Periodo:"
        '
        'lblEjercicio
        '
        Me.lblEjercicio.AutoSize = True
        Me.lblEjercicio.Location = New System.Drawing.Point(12, 127)
        Me.lblEjercicio.Name = "lblEjercicio"
        Me.lblEjercicio.Size = New System.Drawing.Size(80, 13)
        Me.lblEjercicio.TabIndex = 44
        Me.lblEjercicio.Text = "Ejercicio Fiscal:"
        '
        'lblApertura
        '
        Me.lblApertura.AutoSize = True
        Me.lblApertura.Location = New System.Drawing.Point(12, 204)
        Me.lblApertura.Name = "lblApertura"
        Me.lblApertura.Size = New System.Drawing.Size(82, 13)
        Me.lblApertura.TabIndex = 45
        Me.lblApertura.Text = "Fecha apertura:"
        '
        'lblFechaApertura
        '
        Me.lblFechaApertura.AutoClear = True
        Me.lblFechaApertura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaApertura.Location = New System.Drawing.Point(100, 199)
        Me.lblFechaApertura.Name = "lblFechaApertura"
        Me.lblFechaApertura.Size = New System.Drawing.Size(144, 23)
        Me.lblFechaApertura.TabIndex = 46
        Me.lblFechaApertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAbrir
        '
        Me.btnAbrir.Enabled = False
        Me.btnAbrir.Location = New System.Drawing.Point(262, 199)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(75, 23)
        Me.btnAbrir.TabIndex = 47
        Me.btnAbrir.Text = "Abrir"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Enabled = False
        Me.btnCerrar.Location = New System.Drawing.Point(261, 228)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 50
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lblFechaCierreTXT
        '
        Me.lblFechaCierreTXT.AutoClear = True
        Me.lblFechaCierreTXT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFechaCierreTXT.Location = New System.Drawing.Point(100, 228)
        Me.lblFechaCierreTXT.Name = "lblFechaCierreTXT"
        Me.lblFechaCierreTXT.Size = New System.Drawing.Size(144, 23)
        Me.lblFechaCierreTXT.TabIndex = 49
        Me.lblFechaCierreTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaCierre
        '
        Me.lblFechaCierre.AutoSize = True
        Me.lblFechaCierre.Location = New System.Drawing.Point(12, 233)
        Me.lblFechaCierre.Name = "lblFechaCierre"
        Me.lblFechaCierre.Size = New System.Drawing.Size(70, 13)
        Me.lblFechaCierre.TabIndex = 48
        Me.lblFechaCierre.Text = "Fecha Cierre:"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'PeriodosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 295)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblFechaCierreTXT)
        Me.Controls.Add(Me.lblFechaCierre)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.lblFechaApertura)
        Me.Controls.Add(Me.lblApertura)
        Me.Controls.Add(Me.lblEjercicio)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cboEjercicio)
        Me.Name = "PeriodosForm"
        Me.ShowStatus = False
        Me.Text = "PeriodosForm"
        Me.Controls.SetChildIndex(Me.cboEjercicio, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.cboPeriodo, 0)
        Me.Controls.SetChildIndex(Me.lblPeriodo, 0)
        Me.Controls.SetChildIndex(Me.lblEjercicio, 0)
        Me.Controls.SetChildIndex(Me.lblApertura, 0)
        Me.Controls.SetChildIndex(Me.lblFechaApertura, 0)
        Me.Controls.SetChildIndex(Me.btnAbrir, 0)
        Me.Controls.SetChildIndex(Me.lblFechaCierre, 0)
        Me.Controls.SetChildIndex(Me.lblFechaCierreTXT, 0)
        Me.Controls.SetChildIndex(Me.btnCerrar, 0)
        CType(Me.cboEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEjercicio As Azteca.Windows.Contabilidad.EjercicioFiscalCombobox
    Friend WithEvents txtNombre As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblNombre As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboPeriodo As Azteca.Windows.Controls.CIComboBox
    Friend WithEvents lblPeriodo As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblEjercicio As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblApertura As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFechaApertura As Azteca.Windows.Controls.CILabel
    Friend WithEvents btnAbrir As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnCerrar As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblFechaCierreTXT As Azteca.Windows.Controls.CILabel
    Friend WithEvents lblFechaCierre As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Facade = New PeriodoFacade
    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder

End Class
