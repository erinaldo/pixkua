<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProveedoresExpressForm
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chkFactElectronica = New Azteca.Windows.Controls.CICheckBox()
        Me.txtRazonSocial = New Azteca.Windows.Controls.CITextBox()
        Me.lblRazonSocial = New Azteca.Windows.Controls.CILabel()
        Me.txtPoblacionFIS = New Azteca.Windows.Controls.General.PoblacionSelector()
        Me.CiLabel5 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel6 = New Azteca.Windows.Controls.CILabel()
        Me.txtCPFis = New Azteca.Windows.Controls.CITextBox()
        Me.txtColoniaFIS = New Azteca.Windows.Controls.CITextBox()
        Me.txtNumExtFIS = New Azteca.Windows.Controls.CITextBox()
        Me.txtCalleFIS = New Azteca.Windows.Controls.CITextBox()
        Me.CiLabel7 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel8 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel9 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel10 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel11 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel12 = New Azteca.Windows.Controls.CILabel()
        Me.txtRFC = New Azteca.Windows.Controls.CITextBox()
        Me.lblRFC = New Azteca.Windows.Controls.CILabel()
        Me.txtNumIntFIS = New Azteca.Windows.Controls.CITextBox()
        Me.SuspendLayout()
        '
        'chkFactElectronica
        '
        Me.chkFactElectronica.AutoSize = True
        Me.chkFactElectronica.Location = New System.Drawing.Point(93, 306)
        Me.chkFactElectronica.Name = "chkFactElectronica"
        Me.chkFactElectronica.Size = New System.Drawing.Size(118, 17)
        Me.chkFactElectronica.TabIndex = 55
        Me.chkFactElectronica.Text = "Factura Electrónica"
        Me.chkFactElectronica.UseVisualStyleBackColor = True
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window
        Me.txtRazonSocial.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRazonSocial.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRazonSocial.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRazonSocial.Location = New System.Drawing.Point(93, 125)
        Me.txtRazonSocial.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(274, 20)
        Me.txtRazonSocial.TabIndex = 41
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(12, 128)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(73, 13)
        Me.lblRazonSocial.TabIndex = 40
        Me.lblRazonSocial.Text = "Razón Social:"
        '
        'txtPoblacionFIS
        '
        Me.txtPoblacionFIS.AnySite = False
        Me.txtPoblacionFIS.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtPoblacionFIS.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtPoblacionFIS.EditorAssembly = "Azteca.Windows"
        Me.txtPoblacionFIS.EditorClass = "Azteca.Windows.Forms.General.CatalogoPoblaciones"
        Me.txtPoblacionFIS.EditorTitle = "Editar población..."
        Me.txtPoblacionFIS.Key = 0
        Me.txtPoblacionFIS.Linked = False
        Me.txtPoblacionFIS.Location = New System.Drawing.Point(93, 246)
        Me.txtPoblacionFIS.Name = "txtPoblacionFIS"
        Me.txtPoblacionFIS.ReturnType = Azteca.Windows.Controls.ReturnValueType.Value
        Me.txtPoblacionFIS.Size = New System.Drawing.Size(389, 23)
        Me.txtPoblacionFIS.TabIndex = 52
        Me.txtPoblacionFIS.TextWidth = 70
        Me.txtPoblacionFIS.UIName = "Pobación"
        '
        'CiLabel5
        '
        Me.CiLabel5.AutoSize = True
        Me.CiLabel5.Location = New System.Drawing.Point(90, 277)
        Me.CiLabel5.Name = "CiLabel5"
        Me.CiLabel5.Size = New System.Drawing.Size(46, 13)
        Me.CiLabel5.TabIndex = 54
        Me.CiLabel5.Text = "[Estado]"
        '
        'CiLabel6
        '
        Me.CiLabel6.AutoSize = True
        Me.CiLabel6.Location = New System.Drawing.Point(12, 277)
        Me.CiLabel6.Name = "CiLabel6"
        Me.CiLabel6.Size = New System.Drawing.Size(43, 13)
        Me.CiLabel6.TabIndex = 53
        Me.CiLabel6.Text = "Estado:"
        '
        'txtCPFis
        '
        Me.txtCPFis.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCPFis.Digits = True
        Me.txtCPFis.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCPFis.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCPFis.Location = New System.Drawing.Point(93, 220)
        Me.txtCPFis.MaxLength = 5
        Me.txtCPFis.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCPFis.Name = "txtCPFis"
        Me.txtCPFis.Size = New System.Drawing.Size(70, 20)
        Me.txtCPFis.TabIndex = 50
        Me.txtCPFis.UIName = "Código Postal"
        '
        'txtColoniaFIS
        '
        Me.txtColoniaFIS.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtColoniaFIS.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtColoniaFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtColoniaFIS.Location = New System.Drawing.Point(93, 194)
        Me.txtColoniaFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtColoniaFIS.Name = "txtColoniaFIS"
        Me.txtColoniaFIS.Size = New System.Drawing.Size(274, 20)
        Me.txtColoniaFIS.TabIndex = 48
        Me.txtColoniaFIS.UIName = "Colonia"
        '
        'txtNumExtFIS
        '
        Me.txtNumExtFIS.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumExtFIS.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumExtFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumExtFIS.Location = New System.Drawing.Point(93, 171)
        Me.txtNumExtFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumExtFIS.Name = "txtNumExtFIS"
        Me.txtNumExtFIS.Size = New System.Drawing.Size(70, 20)
        Me.txtNumExtFIS.TabIndex = 45
        Me.txtNumExtFIS.UIName = "Num. Exterior"
        '
        'txtCalleFIS
        '
        Me.txtCalleFIS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCalleFIS.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtCalleFIS.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtCalleFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtCalleFIS.Location = New System.Drawing.Point(93, 148)
        Me.txtCalleFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCalleFIS.Name = "txtCalleFIS"
        Me.txtCalleFIS.Size = New System.Drawing.Size(274, 20)
        Me.txtCalleFIS.TabIndex = 43
        Me.txtCalleFIS.UIName = "Calle"
        '
        'CiLabel7
        '
        Me.CiLabel7.AutoSize = True
        Me.CiLabel7.Location = New System.Drawing.Point(12, 250)
        Me.CiLabel7.Name = "CiLabel7"
        Me.CiLabel7.Size = New System.Drawing.Size(57, 13)
        Me.CiLabel7.TabIndex = 51
        Me.CiLabel7.Text = "Población:"
        '
        'CiLabel8
        '
        Me.CiLabel8.AutoSize = True
        Me.CiLabel8.Location = New System.Drawing.Point(12, 223)
        Me.CiLabel8.Name = "CiLabel8"
        Me.CiLabel8.Size = New System.Drawing.Size(75, 13)
        Me.CiLabel8.TabIndex = 49
        Me.CiLabel8.Text = "Código Postal:"
        '
        'CiLabel9
        '
        Me.CiLabel9.AutoSize = True
        Me.CiLabel9.Location = New System.Drawing.Point(169, 174)
        Me.CiLabel9.Name = "CiLabel9"
        Me.CiLabel9.Size = New System.Drawing.Size(62, 13)
        Me.CiLabel9.TabIndex = 46
        Me.CiLabel9.Text = "No. Interior:"
        '
        'CiLabel10
        '
        Me.CiLabel10.AutoSize = True
        Me.CiLabel10.Location = New System.Drawing.Point(12, 171)
        Me.CiLabel10.Name = "CiLabel10"
        Me.CiLabel10.Size = New System.Drawing.Size(65, 13)
        Me.CiLabel10.TabIndex = 44
        Me.CiLabel10.Text = "No. Exterior:"
        '
        'CiLabel11
        '
        Me.CiLabel11.AutoSize = True
        Me.CiLabel11.Location = New System.Drawing.Point(12, 194)
        Me.CiLabel11.Name = "CiLabel11"
        Me.CiLabel11.Size = New System.Drawing.Size(45, 13)
        Me.CiLabel11.TabIndex = 47
        Me.CiLabel11.Text = "Colonia:"
        '
        'CiLabel12
        '
        Me.CiLabel12.AutoSize = True
        Me.CiLabel12.Location = New System.Drawing.Point(12, 151)
        Me.CiLabel12.Name = "CiLabel12"
        Me.CiLabel12.Size = New System.Drawing.Size(33, 13)
        Me.CiLabel12.TabIndex = 42
        Me.CiLabel12.Text = "Calle:"
        '
        'txtRFC
        '
        Me.txtRFC.BackColor = System.Drawing.SystemColors.Window
        Me.txtRFC.CharacterCasing = Azteca.Windows.Controls.CaseType.Upper
        Me.txtRFC.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtRFC.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtRFC.Location = New System.Drawing.Point(93, 99)
        Me.txtRFC.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(125, 20)
        Me.txtRFC.TabIndex = 39
        Me.txtRFC.UIName = "RFC"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(12, 102)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(31, 13)
        Me.lblRFC.TabIndex = 38
        Me.lblRFC.Text = "RFC:"
        '
        'txtNumIntFIS
        '
        Me.txtNumIntFIS.CharacterCasing = Azteca.Windows.Controls.CaseType.Normal
        Me.txtNumIntFIS.DigitsType = Azteca.Windows.Controls.DigitsType.Integers
        Me.txtNumIntFIS.HighlightColor = System.Drawing.SystemColors.Info
        Me.txtNumIntFIS.Location = New System.Drawing.Point(230, 171)
        Me.txtNumIntFIS.MaxValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFIS.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNumIntFIS.Name = "txtNumIntFIS"
        Me.txtNumIntFIS.Size = New System.Drawing.Size(70, 20)
        Me.txtNumIntFIS.TabIndex = 56
        Me.txtNumIntFIS.UIName = Nothing
        '
        'ProveedoresExpressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 374)
        Me.Controls.Add(Me.txtNumIntFIS)
        Me.Controls.Add(Me.chkFactElectronica)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.lblRazonSocial)
        Me.Controls.Add(Me.txtPoblacionFIS)
        Me.Controls.Add(Me.CiLabel5)
        Me.Controls.Add(Me.CiLabel6)
        Me.Controls.Add(Me.txtCPFis)
        Me.Controls.Add(Me.txtColoniaFIS)
        Me.Controls.Add(Me.txtNumExtFIS)
        Me.Controls.Add(Me.txtCalleFIS)
        Me.Controls.Add(Me.CiLabel7)
        Me.Controls.Add(Me.CiLabel8)
        Me.Controls.Add(Me.CiLabel9)
        Me.Controls.Add(Me.CiLabel10)
        Me.Controls.Add(Me.CiLabel11)
        Me.Controls.Add(Me.CiLabel12)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.lblRFC)
        Me.Name = "ProveedoresExpressForm"
        Me.Text = "ProveedorExpressForm"
        Me.Controls.SetChildIndex(Me.lblRFC, 0)
        Me.Controls.SetChildIndex(Me.txtRFC, 0)
        Me.Controls.SetChildIndex(Me.CiLabel12, 0)
        Me.Controls.SetChildIndex(Me.CiLabel11, 0)
        Me.Controls.SetChildIndex(Me.CiLabel10, 0)
        Me.Controls.SetChildIndex(Me.CiLabel9, 0)
        Me.Controls.SetChildIndex(Me.CiLabel8, 0)
        Me.Controls.SetChildIndex(Me.CiLabel7, 0)
        Me.Controls.SetChildIndex(Me.txtCalleFIS, 0)
        Me.Controls.SetChildIndex(Me.txtNumExtFIS, 0)
        Me.Controls.SetChildIndex(Me.txtColoniaFIS, 0)
        Me.Controls.SetChildIndex(Me.txtCPFis, 0)
        Me.Controls.SetChildIndex(Me.CiLabel6, 0)
        Me.Controls.SetChildIndex(Me.CiLabel5, 0)
        Me.Controls.SetChildIndex(Me.txtPoblacionFIS, 0)
        Me.Controls.SetChildIndex(Me.lblRazonSocial, 0)
        Me.Controls.SetChildIndex(Me.txtRazonSocial, 0)
        Me.Controls.SetChildIndex(Me.chkFactElectronica, 0)
        Me.Controls.SetChildIndex(Me.txtNumIntFIS, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkFactElectronica As Azteca.Windows.Controls.CICheckBox
    Friend WithEvents txtRazonSocial As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblRazonSocial As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtPoblacionFIS As Azteca.Windows.Controls.General.PoblacionSelector
    Friend WithEvents CiLabel5 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel6 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtCPFis As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtColoniaFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtNumExtFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents txtCalleFIS As Azteca.Windows.Controls.CITextBox
    Friend WithEvents CiLabel7 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel8 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel9 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel10 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel11 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel12 As Azteca.Windows.Controls.CILabel
    Friend WithEvents txtRFC As Azteca.Windows.Controls.CITextBox
    Friend WithEvents lblRFC As Azteca.Windows.Controls.CILabel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Facade = New ProveedorFacade

    End Sub
    Friend WithEvents txtNumIntFIS As Azteca.Windows.Controls.CITextBox
End Class
