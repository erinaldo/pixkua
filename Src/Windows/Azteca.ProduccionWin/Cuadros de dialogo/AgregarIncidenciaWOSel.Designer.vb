<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarIncidenciaWOSel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarIncidenciaWOSel))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOrdenTrabajo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.cboIncidencias = New Azteca.Windows.Produccion.IncidenciasComboBox(Me.components)
        Me.cboEnsambles = New Azteca.Windows.Produccion.EnsamblesComboBox(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New Azteca.Windows.Controls.CITextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmsRecEnt = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.cmsRecEnt.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOrdenTrabajo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 63)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden de Trabajo"
        '
        'lblOrdenTrabajo
        '
        Me.lblOrdenTrabajo.AutoSize = True
        Me.lblOrdenTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenTrabajo.Location = New System.Drawing.Point(96, 26)
        Me.lblOrdenTrabajo.Name = "lblOrdenTrabajo"
        Me.lblOrdenTrabajo.Size = New System.Drawing.Size(101, 24)
        Me.lblOrdenTrabajo.TabIndex = 63
        Me.lblOrdenTrabajo.Text = "OT-00000"
        Me.lblOrdenTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Incidencia:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(201, 323)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(113, 41)
        Me.btnCancelar.TabIndex = 69
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAceptar.Location = New System.Drawing.Point(82, 323)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(113, 41)
        Me.btnAceptar.TabIndex = 68
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cboIncidencias
        '
        Me.cboIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIncidencias.FormattingEnabled = True
        Me.cboIncidencias.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboIncidencias.ItemsTable = Nothing
        Me.cboIncidencias.Location = New System.Drawing.Point(12, 168)
        Me.cboIncidencias.Name = "cboIncidencias"
        Me.cboIncidencias.Size = New System.Drawing.Size(299, 32)
        Me.cboIncidencias.TabIndex = 70
        Me.cboIncidencias.UIName = Nothing
        '
        'cboEnsambles
        '
        Me.cboEnsambles.DropDownHeight = 130
        Me.cboEnsambles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnsambles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnsambles.FormattingEnabled = True
        Me.cboEnsambles.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEnsambles.IntegralHeight = False
        Me.cboEnsambles.ItemHeight = 24
        Me.cboEnsambles.ItemsTable = Nothing
        Me.cboEnsambles.Location = New System.Drawing.Point(14, 105)
        Me.cboEnsambles.Name = "cboEnsambles"
        Me.cboEnsambles.Size = New System.Drawing.Size(297, 32)
        Me.cboEnsambles.TabIndex = 71
        Me.cboEnsambles.UIName = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Ensamble:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.DigitsType = Azteca.Windows.Controls.DigitsType.Decimals
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtObservaciones.Location = New System.Drawing.Point(15, 245)
        Me.txtObservaciones.MaxLength = 128
        Me.txtObservaciones.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(299, 65)
        Me.txtObservaciones.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Observaciones:"
        '
        'cmsRecEnt
        '
        Me.cmsRecEnt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsModificar})
        Me.cmsRecEnt.Name = "cmsRecEnt"
        Me.cmsRecEnt.Size = New System.Drawing.Size(164, 26)
        '
        'cmsModificar
        '
        Me.cmsModificar.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.delete_32x32
        Me.cmsModificar.Name = "cmsModificar"
        Me.cmsModificar.Size = New System.Drawing.Size(163, 22)
        Me.cmsModificar.Text = "Cerrar Incidencia"
        '
        'AgregarIncidenciaWOSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 373)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEnsambles)
        Me.Controls.Add(Me.cboIncidencias)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "AgregarIncidenciaWOSel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarIncidenciaWOSel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cmsRecEnt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOrdenTrabajo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents cboIncidencias As Azteca.Windows.Produccion.IncidenciasComboBox
    Friend WithEvents cboEnsambles As Azteca.Windows.Produccion.EnsamblesComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As Azteca.Windows.Controls.CITextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmsRecEnt As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsModificar As System.Windows.Forms.ToolStripMenuItem
End Class
