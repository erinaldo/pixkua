<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimeEtiqueta
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
        Me.lblImprimiendo = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.c1bcCodArticulo = New C1.Win.C1BarCode.C1BarCode()
        Me.c1bcCodProveedor = New C1.Win.C1BarCode.C1BarCode()
        Me.SuspendLayout()
        '
        'lblImprimiendo
        '
        Me.lblImprimiendo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprimiendo.Location = New System.Drawing.Point(12, 9)
        Me.lblImprimiendo.Name = "lblImprimiendo"
        Me.lblImprimiendo.Size = New System.Drawing.Size(318, 33)
        Me.lblImprimiendo.TabIndex = 1
        Me.lblImprimiendo.Text = "Imprimiendo Etiqueta..."
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'c1bcCodArticulo
        '
        Me.c1bcCodArticulo.BarWide = 3
        Me.c1bcCodArticulo.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128
        Me.c1bcCodArticulo.Location = New System.Drawing.Point(236, 80)
        Me.c1bcCodArticulo.Name = "c1bcCodArticulo"
        Me.c1bcCodArticulo.Size = New System.Drawing.Size(75, 23)
        Me.c1bcCodArticulo.TabIndex = 2
        Me.c1bcCodArticulo.Text = "Nada"
        '
        'c1bcCodProveedor
        '
        Me.c1bcCodProveedor.BarWide = 3
        Me.c1bcCodProveedor.CodeType = C1.Win.C1BarCode.CodeTypeEnum.Code128
        Me.c1bcCodProveedor.Location = New System.Drawing.Point(137, 80)
        Me.c1bcCodProveedor.Name = "c1bcCodProveedor"
        Me.c1bcCodProveedor.Size = New System.Drawing.Size(75, 23)
        Me.c1bcCodProveedor.TabIndex = 3
        Me.c1bcCodProveedor.Text = "Nada"
        '
        'ImprimeEtiqueta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 51)
        Me.ControlBox = False
        Me.Controls.Add(Me.c1bcCodProveedor)
        Me.Controls.Add(Me.c1bcCodArticulo)
        Me.Controls.Add(Me.lblImprimiendo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ImprimeEtiqueta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblImprimiendo As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents c1bcCodArticulo As C1.Win.C1BarCode.C1BarCode
    Friend WithEvents c1bcCodProveedor As C1.Win.C1BarCode.C1BarCode
End Class
