<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbrirInventarioForm
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
        Me.lblTurno = New Azteca.Windows.Controls.CILabel()
        Me.cboTurno = New Azteca.Windows.Inventario.TurnosComboBox()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdAbrirCorte = New C1.Win.C1Command.C1Command()
        Me.cmdCancelar = New C1.Win.C1Command.C1Command()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.tlbMenu = New Azteca.Windows.Controls.AZToolBar()
        Me.btnAbrirCorte = New C1.Win.C1Command.C1CommandLink()
        Me.btnCancelar = New C1.Win.C1Command.C1CommandLink()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Location = New System.Drawing.Point(12, 87)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(38, 13)
        Me.lblTurno.TabIndex = 4
        Me.lblTurno.Text = "Turno:"
        '
        'cboTurno
        '
        Me.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTurno.FormattingEnabled = True
        Me.cboTurno.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboTurno.ItemsTable = Nothing
        Me.cboTurno.Location = New System.Drawing.Point(56, 84)
        Me.cboTurno.Name = "cboTurno"
        Me.cboTurno.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboTurno.Size = New System.Drawing.Size(265, 21)
        Me.cboTurno.TabIndex = 5
        Me.cboTurno.UIName = Nothing
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdAbrirCorte)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCancelar)
        Me.C1CommandHolder1.Owner = Me
        '
        'cmdAbrirCorte
        '
        Me.cmdAbrirCorte.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.AbrirCorteInventario_32
        Me.cmdAbrirCorte.Name = "cmdAbrirCorte"
        Me.cmdAbrirCorte.Text = "Abrir Corte"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = Global.Azteca.Windows.Inventario.My.Resources.Resources.Close_32
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Text = "Cancelar"
        '
        'CiLabel1
        '
        Me.CiLabel1.BackColor = System.Drawing.SystemColors.Info
        Me.CiLabel1.Location = New System.Drawing.Point(12, 51)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(309, 23)
        Me.CiLabel1.TabIndex = 6
        Me.CiLabel1.Text = "Seleccione el turno de inventario al que pertenece éste corte:"
        Me.CiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlbMenu
        '
        Me.tlbMenu.AccessibleName = "Tool Bar"
        Me.tlbMenu.AutoSize = False
        Me.tlbMenu.CommandHolder = Me.C1CommandHolder1
        Me.tlbMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.btnAbrirCorte, Me.btnCancelar})
        Me.tlbMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbMenu.Location = New System.Drawing.Point(0, 0)
        Me.tlbMenu.MinButtonSize = 32
        Me.tlbMenu.Movable = False
        Me.tlbMenu.Name = "tlbMenu"
        Me.tlbMenu.Size = New System.Drawing.Size(491, 34)
        Me.tlbMenu.Text = "AzToolBar1"
        Me.tlbMenu.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tlbMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'btnAbrirCorte
        '
        Me.btnAbrirCorte.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnAbrirCorte.Command = Me.cmdAbrirCorte
        '
        'btnCancelar
        '
        Me.btnCancelar.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.btnCancelar.Command = Me.cmdCancelar
        Me.btnCancelar.SortOrder = 1
        '
        'AbrirInventarioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlbMenu)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.cboTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Name = "AbrirInventarioForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apertura de corte de inventario"
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTurno As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboTurno As Azteca.Windows.Inventario.TurnosComboBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents cmdAbrirCorte As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCancelar As C1.Win.C1Command.C1Command
    Friend WithEvents tlbMenu As Azteca.Windows.Controls.AZToolBar
    Friend WithEvents btnAbrirCorte As C1.Win.C1Command.C1CommandLink
    Friend WithEvents btnCancelar As C1.Win.C1Command.C1CommandLink
End Class
