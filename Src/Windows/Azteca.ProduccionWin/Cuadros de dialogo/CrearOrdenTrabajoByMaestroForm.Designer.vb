<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearOrdenTrabajoByMaestroForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearOrdenTrabajoByMaestroForm))
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.txtCantidad = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.txtVersion = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaRequerida = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaRecepcion = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.dtpFechaPromEntrega = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel4 = New Azteca.Windows.Controls.CILabel()
        Me.selMaestroIng = New Azteca.Windows.Produccion.OrdenTrabajoSelector()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(259, 215)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(178, 215)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Digits = True
        Me.txtCantidad.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCantidad.Location = New System.Drawing.Point(106, 167)
        Me.txtCantidad.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(92, 20)
        Me.txtCantidad.TabIndex = 73
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(48, 170)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(49, 13)
        Me.CiLabel1.TabIndex = 74
        Me.CiLabel1.Text = "Cantidad"
        '
        'txtVersion
        '
        Me.txtVersion.Digits = True
        Me.txtVersion.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtVersion.Location = New System.Drawing.Point(106, 38)
        Me.txtVersion.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersion.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.ReadOnly = True
        Me.txtVersion.Size = New System.Drawing.Size(92, 20)
        Me.txtVersion.TabIndex = 75
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(55, 41)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(42, 13)
        Me.CiLabel2.TabIndex = 76
        Me.CiLabel2.Text = "Versión"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(52, 15)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel3.TabIndex = 77
        Me.CiLabel3.Text = "Maestro"
        '
        'dtpFechaRequerida
        '
        Me.dtpFechaRequerida.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaRequerida.Location = New System.Drawing.Point(106, 127)
        Me.dtpFechaRequerida.Name = "dtpFechaRequerida"
        Me.dtpFechaRequerida.Size = New System.Drawing.Size(231, 20)
        Me.dtpFechaRequerida.TabIndex = 83
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(8, 130)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(89, 13)
        Me.CiLabel8.TabIndex = 82
        Me.CiLabel8.Text = "Fecha Requerida"
        '
        'dtpFechaRecepcion
        '
        Me.dtpFechaRecepcion.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaRecepcion.Location = New System.Drawing.Point(106, 75)
        Me.dtpFechaRecepcion.Name = "dtpFechaRecepcion"
        Me.dtpFechaRecepcion.Size = New System.Drawing.Size(231, 20)
        Me.dtpFechaRecepcion.TabIndex = 81
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(5, 78)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(92, 13)
        Me.CiLabel7.TabIndex = 80
        Me.CiLabel7.Text = "Fecha Recepción"
        '
        'dtpFechaPromEntrega
        '
        Me.dtpFechaPromEntrega.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaPromEntrega.Location = New System.Drawing.Point(106, 101)
        Me.dtpFechaPromEntrega.Name = "dtpFechaPromEntrega"
        Me.dtpFechaPromEntrega.Size = New System.Drawing.Size(231, 20)
        Me.dtpFechaPromEntrega.TabIndex = 79
        '
        'CiLabel4
        '
        Me.CiLabel4.AutoSize = True
        Me.CiLabel4.Location = New System.Drawing.Point(20, 104)
        Me.CiLabel4.Name = "CiLabel4"
        Me.CiLabel4.Size = New System.Drawing.Size(77, 13)
        Me.CiLabel4.TabIndex = 78
        Me.CiLabel4.Text = "Fecha Entrega"
        '
        'selMaestroIng
        '
        Me.selMaestroIng.AnySite = False
        Me.selMaestroIng.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.selMaestroIng.EditorAssembly = "Azteca.ProduccionWin"
        Me.selMaestroIng.EditorClass = "Azteca.Windows.Produccion.OrdenesTrabajoForm"
        Me.selMaestroIng.EditorTitle = "Editar Orden de Trabajo..."
        Me.selMaestroIng.Key = 0
        Me.selMaestroIng.Linked = False
        Me.selMaestroIng.Location = New System.Drawing.Point(106, 9)
        Me.selMaestroIng.Name = "selMaestroIng"
        Me.selMaestroIng.Size = New System.Drawing.Size(231, 23)
        Me.selMaestroIng.TabIndex = 84
        '
        'CrearOrdenTrabajoByMaestroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 250)
        Me.Controls.Add(Me.selMaestroIng)
        Me.Controls.Add(Me.dtpFechaRequerida)
        Me.Controls.Add(Me.CiLabel8)
        Me.Controls.Add(Me.dtpFechaRecepcion)
        Me.Controls.Add(Me.CiLabel7)
        Me.Controls.Add(Me.dtpFechaPromEntrega)
        Me.Controls.Add(Me.CiLabel4)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "CrearOrdenTrabajoByMaestroForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrearOrdenTrabajoByMaestroForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents txtCantidad As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtVersion As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaRequerida As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaRecepcion As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents dtpFechaPromEntrega As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel4 As Azteca.Windows.Controls.CILabel
    Friend WithEvents selMaestroIng As Azteca.Windows.Produccion.OrdenTrabajoSelector
End Class
