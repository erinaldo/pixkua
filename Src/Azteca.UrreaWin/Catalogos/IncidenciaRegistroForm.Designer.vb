<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenciaRegistroForm
    Inherits Azteca.Windows.Forms.BusinessForms.CatalogForm

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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Facade = New IncidenciaRegistroFacade
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdBuscarLinea = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrdenTransporte = New Azteca.Windows.Controls.CITextBox()
        Me.txtPaquete = New Azteca.Windows.Controls.CITextBox()
        Me.txtEntrega = New Azteca.Windows.Controls.CITextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtComentarios = New Azteca.Windows.Controls.CITextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIDCaja = New Azteca.Windows.Controls.CITextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumeroContenedor = New Azteca.Windows.Controls.CITextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFigura = New Azteca.Windows.Controls.CITextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRevisaFigura = New Azteca.Windows.Controls.CITextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRevisaOT = New Azteca.Windows.Controls.CITextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumColaborador = New Azteca.Windows.Controls.CITextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraCierre = New System.Windows.Forms.DateTimePicker()
        Me.cboIncidencia = New Azteca.Windows.Urrea.IncidenciasComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtResponsable = New Azteca.Windows.Controls.CITextBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(210, 47)
        Me.txtCantidad.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(73, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmdBuscarLinea)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtOrdenTransporte)
        Me.GroupBox1.Controls.Add(Me.txtPaquete)
        Me.GroupBox1.Controls.Add(Me.txtEntrega)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Pedido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Orden de Transporte"
        '
        'cmdBuscarLinea
        '
        Me.cmdBuscarLinea.Location = New System.Drawing.Point(516, 42)
        Me.cmdBuscarLinea.Name = "cmdBuscarLinea"
        Me.cmdBuscarLinea.Size = New System.Drawing.Size(33, 23)
        Me.cmdBuscarLinea.TabIndex = 44
        Me.cmdBuscarLinea.Text = "..."
        Me.cmdBuscarLinea.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Entrega"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Paquete"
        '
        'txtOrdenTransporte
        '
        Me.txtOrdenTransporte.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdenTransporte.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtOrdenTransporte.Location = New System.Drawing.Point(357, 42)
        Me.txtOrdenTransporte.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenTransporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtOrdenTransporte.Name = "txtOrdenTransporte"
        Me.txtOrdenTransporte.ReadOnly = True
        Me.txtOrdenTransporte.RequiredField = True
        Me.txtOrdenTransporte.Size = New System.Drawing.Size(149, 20)
        Me.txtOrdenTransporte.TabIndex = 2
        Me.txtOrdenTransporte.UIName = "Nombre"
        '
        'txtPaquete
        '
        Me.txtPaquete.BackColor = System.Drawing.SystemColors.Window
        Me.txtPaquete.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtPaquete.Location = New System.Drawing.Point(13, 44)
        Me.txtPaquete.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPaquete.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPaquete.Name = "txtPaquete"
        Me.txtPaquete.ReadOnly = True
        Me.txtPaquete.RequiredField = True
        Me.txtPaquete.Size = New System.Drawing.Size(149, 20)
        Me.txtPaquete.TabIndex = 0
        Me.txtPaquete.UIName = "Nombre"
        '
        'txtEntrega
        '
        Me.txtEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.txtEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtEntrega.Location = New System.Drawing.Point(185, 42)
        Me.txtEntrega.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEntrega.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEntrega.Name = "txtEntrega"
        Me.txtEntrega.ReadOnly = True
        Me.txtEntrega.RequiredField = True
        Me.txtEntrega.Size = New System.Drawing.Size(149, 20)
        Me.txtEntrega.TabIndex = 1
        Me.txtEntrega.UIName = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComentarios)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 472)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Observaciones"
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.SystemColors.Window
        Me.txtComentarios.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtComentarios.Location = New System.Drawing.Point(13, 19)
        Me.txtComentarios.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtComentarios.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(536, 75)
        Me.txtComentarios.TabIndex = 0
        Me.txtComentarios.UIName = "Nombre"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtCantidad)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtIDCaja)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtNumeroContenedor)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtFigura)
        Me.GroupBox4.Location = New System.Drawing.Point(34, 218)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(301, 171)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Linea"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "ID Caja"
        '
        'txtIDCaja
        '
        Me.txtIDCaja.BackColor = System.Drawing.SystemColors.Window
        Me.txtIDCaja.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtIDCaja.Location = New System.Drawing.Point(23, 134)
        Me.txtIDCaja.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIDCaja.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIDCaja.Name = "txtIDCaja"
        Me.txtIDCaja.Size = New System.Drawing.Size(260, 20)
        Me.txtIDCaja.TabIndex = 3
        Me.txtIDCaja.UIName = "Nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Numero de Contenedor"
        '
        'txtNumeroContenedor
        '
        Me.txtNumeroContenedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroContenedor.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumeroContenedor.Location = New System.Drawing.Point(23, 92)
        Me.txtNumeroContenedor.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroContenedor.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumeroContenedor.Name = "txtNumeroContenedor"
        Me.txtNumeroContenedor.Size = New System.Drawing.Size(260, 20)
        Me.txtNumeroContenedor.TabIndex = 2
        Me.txtNumeroContenedor.UIName = "Nombre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Figura"
        '
        'txtFigura
        '
        Me.txtFigura.BackColor = System.Drawing.SystemColors.Window
        Me.txtFigura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtFigura.Location = New System.Drawing.Point(23, 47)
        Me.txtFigura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFigura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtFigura.Name = "txtFigura"
        Me.txtFigura.Size = New System.Drawing.Size(181, 20)
        Me.txtFigura.TabIndex = 0
        Me.txtFigura.UIName = "Nombre"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtRevisaFigura)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtRevisaOT)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.txtNumColaborador)
        Me.GroupBox5.Location = New System.Drawing.Point(341, 218)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(248, 171)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Colaboradores"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Revisa Figura"
        '
        'txtRevisaFigura
        '
        Me.txtRevisaFigura.BackColor = System.Drawing.SystemColors.Window
        Me.txtRevisaFigura.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRevisaFigura.Location = New System.Drawing.Point(18, 134)
        Me.txtRevisaFigura.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRevisaFigura.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRevisaFigura.Name = "txtRevisaFigura"
        Me.txtRevisaFigura.Size = New System.Drawing.Size(208, 20)
        Me.txtRevisaFigura.TabIndex = 2
        Me.txtRevisaFigura.UIName = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Revisa OT"
        '
        'txtRevisaOT
        '
        Me.txtRevisaOT.BackColor = System.Drawing.SystemColors.Window
        Me.txtRevisaOT.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRevisaOT.Location = New System.Drawing.Point(18, 92)
        Me.txtRevisaOT.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRevisaOT.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRevisaOT.Name = "txtRevisaOT"
        Me.txtRevisaOT.Size = New System.Drawing.Size(208, 20)
        Me.txtRevisaOT.TabIndex = 1
        Me.txtRevisaOT.UIName = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Num. Colaborador"
        '
        'txtNumColaborador
        '
        Me.txtNumColaborador.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumColaborador.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumColaborador.Location = New System.Drawing.Point(18, 47)
        Me.txtNumColaborador.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumColaborador.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumColaborador.Name = "txtNumColaborador"
        Me.txtNumColaborador.Size = New System.Drawing.Size(208, 20)
        Me.txtNumColaborador.TabIndex = 0
        Me.txtNumColaborador.UIName = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Incidencia"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFecha.Location = New System.Drawing.Point(440, 106)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(149, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Fecha"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpFechaCierre)
        Me.GroupBox3.Controls.Add(Me.dtpHoraCierre)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 578)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 54)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cierre de Incidencia"
        '
        'dtpFechaCierre
        '
        Me.dtpFechaCierre.Enabled = False
        Me.dtpFechaCierre.Location = New System.Drawing.Point(103, 19)
        Me.dtpFechaCierre.Name = "dtpFechaCierre"
        Me.dtpFechaCierre.Size = New System.Drawing.Size(227, 20)
        Me.dtpFechaCierre.TabIndex = 54
        '
        'dtpHoraCierre
        '
        Me.dtpHoraCierre.Enabled = False
        Me.dtpHoraCierre.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraCierre.Location = New System.Drawing.Point(353, 19)
        Me.dtpHoraCierre.Name = "dtpHoraCierre"
        Me.dtpHoraCierre.Size = New System.Drawing.Size(149, 20)
        Me.dtpHoraCierre.TabIndex = 53
        '
        'cboIncidencia
        '
        Me.cboIncidencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIncidencia.FormattingEnabled = True
        Me.cboIncidencia.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboIncidencia.ItemsTable = Nothing
        Me.cboIncidencia.Location = New System.Drawing.Point(106, 105)
        Me.cboIncidencia.Name = "cboIncidencia"
        Me.cboIncidencia.Size = New System.Drawing.Size(251, 21)
        Me.cboIncidencia.TabIndex = 0
        Me.cboIncidencia.UIName = Nothing
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txtResponsable)
        Me.GroupBox6.Controls.Add(Me.cboArea)
        Me.GroupBox6.Location = New System.Drawing.Point(34, 395)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(555, 71)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Información General"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(322, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Responsable"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Área"
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.SystemColors.Window
        Me.txtResponsable.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtResponsable.Location = New System.Drawing.Point(325, 41)
        Me.txtResponsable.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtResponsable.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(208, 20)
        Me.txtResponsable.TabIndex = 2
        Me.txtResponsable.UIName = "Nombre"
        '
        'cboArea
        '
        Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArea.FormattingEnabled = True
        Me.cboArea.Items.AddRange(New Object() {"Programacion", "Recoleccion", "Empaque", "Consolidacion", "Embarque"})
        Me.cboArea.Location = New System.Drawing.Point(23, 41)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(260, 21)
        Me.cboArea.TabIndex = 0
        '
        'IncidenciaRegistroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 663)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cboIncidencia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IncidenciaRegistroForm"
        Me.Text = "IncidenciaRegistroForm"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cboIncidencia, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarLinea As System.Windows.Forms.Button
    Friend WithEvents txtOrdenTransporte As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtEntrega As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtPaquete As Azteca.Windows.Controls.CITextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComentarios As Azteca.Windows.Controls.CITextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtIDCaja As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNumeroContenedor As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFigura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRevisaFigura As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRevisaOT As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNumColaborador As Azteca.Windows.Controls.CITextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboIncidencia As Azteca.Windows.Urrea.IncidenciasComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraCierre As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable As Azteca.Windows.Controls.CITextBox
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
End Class
