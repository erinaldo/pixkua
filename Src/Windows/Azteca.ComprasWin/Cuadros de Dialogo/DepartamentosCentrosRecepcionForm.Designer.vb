<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentosCentrosRecepcionForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartamentosCentrosRecepcionForm))
        Me.gbxDeptosCategorias = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdCentrosRecepcion = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsCentrosRecepcion = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbDeptosCategoria = New Azteca.Windows.Controls.CIToolBar()
        Me.btnCentroRecepcionAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.gbxDeptosCategorias.SuspendLayout()
        CType(Me.grdCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCentrosRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDeptosCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDeptosCategorias
        '
        Me.gbxDeptosCategorias.Controls.Add(Me.grdCentrosRecepcion)
        Me.gbxDeptosCategorias.Controls.Add(Me.tbDeptosCategoria)
        Me.gbxDeptosCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDeptosCategorias.Location = New System.Drawing.Point(0, 0)
        Me.gbxDeptosCategorias.Name = "gbxDeptosCategorias"
        Me.gbxDeptosCategorias.Size = New System.Drawing.Size(480, 364)
        Me.gbxDeptosCategorias.TabIndex = 49
        Me.gbxDeptosCategorias.TabStop = False
        '
        'grdCentrosRecepcion
        '
        Me.grdCentrosRecepcion.AlternatingRows = True
        Me.grdCentrosRecepcion.DataSource = Me.bsCentrosRecepcion
        Me.grdCentrosRecepcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCentrosRecepcion.IDCatalogField = "IdCentroRecepcion"
        Me.grdCentrosRecepcion.Images.Add(CType(resources.GetObject("grdCentrosRecepcion.Images"), System.Drawing.Image))
        Me.grdCentrosRecepcion.Location = New System.Drawing.Point(3, 55)
        Me.grdCentrosRecepcion.Name = "grdCentrosRecepcion"
        Me.grdCentrosRecepcion.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdCentrosRecepcion.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdCentrosRecepcion.PreviewInfo.ZoomFactor = 75.0R
        Me.grdCentrosRecepcion.PrintInfo.PageSettings = CType(resources.GetObject("grdCentrosRecepcion.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdCentrosRecepcion.RowHeight = 17
        Me.grdCentrosRecepcion.ShowEditButton = False
        Me.grdCentrosRecepcion.Size = New System.Drawing.Size(474, 306)
        Me.grdCentrosRecepcion.TabIndex = 46
        Me.grdCentrosRecepcion.Text = "AzTrueDBGrid1"
        Me.grdCentrosRecepcion.PropBag = resources.GetString("grdCentrosRecepcion.PropBag")
        '
        'tbDeptosCategoria
        '
        Me.tbDeptosCategoria.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbDeptosCategoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCentroRecepcionAdd, Me.ToolStripSeparator1, Me.btnGuardar, Me.btnCancelar})
        Me.tbDeptosCategoria.Location = New System.Drawing.Point(3, 16)
        Me.tbDeptosCategoria.Name = "tbDeptosCategoria"
        Me.tbDeptosCategoria.Size = New System.Drawing.Size(474, 39)
        Me.tbDeptosCategoria.TabIndex = 45
        Me.tbDeptosCategoria.Text = "CiToolBar4"
        '
        'btnCentroRecepcionAdd
        '
        Me.btnCentroRecepcionAdd.Image = CType(resources.GetObject("btnCentroRecepcionAdd.Image"), System.Drawing.Image)
        Me.btnCentroRecepcionAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCentroRecepcionAdd.Name = "btnCentroRecepcionAdd"
        Me.btnCentroRecepcionAdd.Size = New System.Drawing.Size(200, 36)
        Me.btnCentroRecepcionAdd.Text = "Agregar Centros de recepción"
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
        'DepartamentosCentrosRecepcionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 364)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxDeptosCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DepartamentosCentrosRecepcionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Centros de Recepcion autorizados al departamento"
        Me.gbxDeptosCategorias.ResumeLayout(False)
        Me.gbxDeptosCategorias.PerformLayout()
        CType(Me.grdCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCentrosRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDeptosCategoria.ResumeLayout(False)
        Me.tbDeptosCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDeptosCategorias As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdCentrosRecepcion As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbDeptosCategoria As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnCentroRecepcionAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsCentrosRecepcion As System.Windows.Forms.BindingSource
End Class
