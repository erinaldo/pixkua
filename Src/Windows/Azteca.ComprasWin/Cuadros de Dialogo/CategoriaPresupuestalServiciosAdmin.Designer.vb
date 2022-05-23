<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoriaPresupuestalServiciosAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoriaPresupuestalServiciosAdmin))
        Me.gbxDeptosCategorias = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdServicios = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsServicios = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbDeptosCategoria = New Azteca.Windows.Controls.CIToolBar()
        Me.btnServiciosAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.gbxDeptosCategorias.SuspendLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDeptosCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDeptosCategorias
        '
        Me.gbxDeptosCategorias.Controls.Add(Me.grdServicios)
        Me.gbxDeptosCategorias.Controls.Add(Me.tbDeptosCategoria)
        Me.gbxDeptosCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDeptosCategorias.Location = New System.Drawing.Point(0, 0)
        Me.gbxDeptosCategorias.Name = "gbxDeptosCategorias"
        Me.gbxDeptosCategorias.Size = New System.Drawing.Size(515, 359)
        Me.gbxDeptosCategorias.TabIndex = 49
        Me.gbxDeptosCategorias.TabStop = False
        '
        'grdServicios
        '
        Me.grdServicios.AlternatingRows = True
        Me.grdServicios.DataSource = Me.bsServicios
        Me.grdServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdServicios.IDCatalogField = "IdServicio"
        Me.grdServicios.Images.Add(CType(resources.GetObject("grdServicios.Images"), System.Drawing.Image))
        Me.grdServicios.Location = New System.Drawing.Point(3, 55)
        Me.grdServicios.Name = "grdServicios"
        Me.grdServicios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdServicios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdServicios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdServicios.PrintInfo.PageSettings = CType(resources.GetObject("grdServicios.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdServicios.RowHeight = 17
        Me.grdServicios.ShowEditButton = False
        Me.grdServicios.Size = New System.Drawing.Size(509, 301)
        Me.grdServicios.TabIndex = 46
        Me.grdServicios.Text = "AzTrueDBGrid1"
        Me.grdServicios.PropBag = resources.GetString("grdServicios.PropBag")
        '
        'tbDeptosCategoria
        '
        Me.tbDeptosCategoria.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbDeptosCategoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnServiciosAdd, Me.ToolStripSeparator1, Me.btnGuardar, Me.btnCancelar})
        Me.tbDeptosCategoria.Location = New System.Drawing.Point(3, 16)
        Me.tbDeptosCategoria.Name = "tbDeptosCategoria"
        Me.tbDeptosCategoria.Size = New System.Drawing.Size(509, 39)
        Me.tbDeptosCategoria.TabIndex = 45
        Me.tbDeptosCategoria.Text = "CiToolBar4"
        '
        'btnServiciosAdd
        '
        Me.btnServiciosAdd.Image = CType(resources.GetObject("btnServiciosAdd.Image"), System.Drawing.Image)
        Me.btnServiciosAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnServiciosAdd.Name = "btnServiciosAdd"
        Me.btnServiciosAdd.Size = New System.Drawing.Size(134, 36)
        Me.btnServiciosAdd.Text = "Agregar Servicios"
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
        'CategoriaPresupuestalServiciosAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxDeptosCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "CategoriaPresupuestalServiciosAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Servicios en la Categoria Presupuestal"
        Me.gbxDeptosCategorias.ResumeLayout(False)
        Me.gbxDeptosCategorias.PerformLayout()
        CType(Me.grdServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDeptosCategoria.ResumeLayout(False)
        Me.tbDeptosCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDeptosCategorias As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdServicios As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbDeptosCategoria As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnServiciosAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsServicios As System.Windows.Forms.BindingSource
End Class
