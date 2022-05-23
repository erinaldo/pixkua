<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GastosConceptosImpuestosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GastosConceptosImpuestosForm))
        Me.gbxDeptosCategorias = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdArticulos = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.tbDeptosCategoria = New Azteca.Windows.Controls.CIToolBar()
        Me.btnArticulosAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.gbxDeptosCategorias.SuspendLayout()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDeptosCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDeptosCategorias
        '
        Me.gbxDeptosCategorias.Controls.Add(Me.grdArticulos)
        Me.gbxDeptosCategorias.Controls.Add(Me.tbDeptosCategoria)
        Me.gbxDeptosCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDeptosCategorias.Location = New System.Drawing.Point(0, 0)
        Me.gbxDeptosCategorias.Name = "gbxDeptosCategorias"
        Me.gbxDeptosCategorias.Size = New System.Drawing.Size(470, 399)
        Me.gbxDeptosCategorias.TabIndex = 50
        Me.gbxDeptosCategorias.TabStop = False
        '
        'grdArticulos
        '
        Me.grdArticulos.AlternatingRows = True
        Me.grdArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArticulos.IDCatalogField = "IdArticuloStock"
        Me.grdArticulos.Images.Add(CType(resources.GetObject("grdArticulos.Images"), System.Drawing.Image))
        Me.grdArticulos.Location = New System.Drawing.Point(3, 55)
        Me.grdArticulos.Name = "grdArticulos"
        Me.grdArticulos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdArticulos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdArticulos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdArticulos.PrintInfo.PageSettings = CType(resources.GetObject("grdArticulos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdArticulos.RowHeight = 17
        Me.grdArticulos.ShowEditButton = False
        Me.grdArticulos.Size = New System.Drawing.Size(464, 341)
        Me.grdArticulos.TabIndex = 46
        Me.grdArticulos.Text = "AzTrueDBGrid1"
        Me.grdArticulos.PropBag = resources.GetString("grdArticulos.PropBag")
        '
        'tbDeptosCategoria
        '
        Me.tbDeptosCategoria.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbDeptosCategoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnArticulosAdd, Me.ToolStripSeparator1, Me.btnGuardar, Me.btnCancelar})
        Me.tbDeptosCategoria.Location = New System.Drawing.Point(3, 16)
        Me.tbDeptosCategoria.Name = "tbDeptosCategoria"
        Me.tbDeptosCategoria.Size = New System.Drawing.Size(464, 39)
        Me.tbDeptosCategoria.TabIndex = 47
        Me.tbDeptosCategoria.Text = "CiToolBar4"
        '
        'btnArticulosAdd
        '
        Me.btnArticulosAdd.Image = CType(resources.GetObject("btnArticulosAdd.Image"), System.Drawing.Image)
        Me.btnArticulosAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnArticulosAdd.Name = "btnArticulosAdd"
        Me.btnArticulosAdd.Size = New System.Drawing.Size(143, 36)
        Me.btnArticulosAdd.Text = "Agregar Impuestos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 36)
        Me.btnGuardar.Text = "Guardar Cambios"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 36)
        Me.btnCancelar.Text = "Cancelar "
        '
        'GastosConceptosImpuestosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 399)
        Me.Controls.Add(Me.gbxDeptosCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GastosConceptosImpuestosForm"
        Me.Text = "Impuestos por Concepto de Gasto"
        Me.gbxDeptosCategorias.ResumeLayout(False)
        Me.gbxDeptosCategorias.PerformLayout()
        CType(Me.grdArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDeptosCategoria.ResumeLayout(False)
        Me.tbDeptosCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDeptosCategorias As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdArticulos As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbDeptosCategoria As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnArticulosAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
End Class
