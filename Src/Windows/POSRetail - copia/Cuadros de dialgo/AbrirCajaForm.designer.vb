<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbrirCajaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbrirCajaForm))
        Me.lblCajero = New Azteca.Windows.Controls.CILabel()
        Me.btnCancelar = New Azteca.Windows.Controls.CIButton()
        Me.btnAceptar = New Azteca.Windows.Controls.CIButton()
        Me.lblCaja = New Azteca.Windows.Controls.CILabel()
        Me.cboCajeros = New Azteca.Windows.Ventas.CajerosCombobox()
        Me.SuspendLayout()
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Location = New System.Drawing.Point(31, 49)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(37, 13)
        Me.lblCajero.TabIndex = 2
        Me.lblCajero.Text = "Cajero"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(242, 94)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(161, 94)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Abrir Caja"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblCaja
        '
        Me.lblCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaja.ForeColor = System.Drawing.Color.Red
        Me.lblCaja.Location = New System.Drawing.Point(77, 17)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(241, 23)
        Me.lblCaja.TabIndex = 13
        Me.lblCaja.Text = "Descripcion de la caja"
        Me.lblCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCajeros
        '
        Me.cboCajeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCajeros.FormattingEnabled = True
        Me.cboCajeros.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboCajeros.ItemsTable = Nothing
        Me.cboCajeros.Location = New System.Drawing.Point(78, 46)
        Me.cboCajeros.Name = "cboCajeros"
        Me.cboCajeros.ReturnValue = Azteca.Windows.Controls.ReturnValueType.Value
        Me.cboCajeros.Size = New System.Drawing.Size(238, 21)
        Me.cboCajeros.TabIndex = 3
        Me.cboCajeros.UIName = Nothing
        '
        'AbrirCajaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cboCajeros)
        Me.Controls.Add(Me.lblCajero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AbrirCajaForm"
        Me.Text = "Nueva apertura de caja..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCajero As Azteca.Windows.Controls.CILabel
    Friend WithEvents cboCajeros As Azteca.Windows.Ventas.CajerosCombobox
    Friend WithEvents btnCancelar As Azteca.Windows.Controls.CIButton
    Friend WithEvents btnAceptar As Azteca.Windows.Controls.CIButton
    Friend WithEvents lblCaja As Azteca.Windows.Controls.CILabel
End Class
