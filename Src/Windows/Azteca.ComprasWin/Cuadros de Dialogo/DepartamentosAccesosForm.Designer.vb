<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentosAccesosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartamentosAccesosForm))
        Me.gbxDeptosCategorias = New Azteca.Windows.Controls.CIGroupBox()
        Me.grdUsuarios = New Azteca.Windows.Controls.DataGridViewCatalog()
        Me.bsAccesos = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbDeptosCategoria = New Azteca.Windows.Controls.CIToolBar()
        Me.btnUsuariosAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.gbxDeptosCategorias.SuspendLayout()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAccesos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDeptosCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxDeptosCategorias
        '
        Me.gbxDeptosCategorias.Controls.Add(Me.grdUsuarios)
        Me.gbxDeptosCategorias.Controls.Add(Me.tbDeptosCategoria)
        Me.gbxDeptosCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDeptosCategorias.Location = New System.Drawing.Point(0, 0)
        Me.gbxDeptosCategorias.Name = "gbxDeptosCategorias"
        Me.gbxDeptosCategorias.Size = New System.Drawing.Size(492, 366)
        Me.gbxDeptosCategorias.TabIndex = 48
        Me.gbxDeptosCategorias.TabStop = False
        '
        'grdUsuarios
        '
        Me.grdUsuarios.AlternatingRows = True
        Me.grdUsuarios.DataSource = Me.bsAccesos
        Me.grdUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdUsuarios.IDCatalogField = "IdUsuario"
        Me.grdUsuarios.Images.Add(CType(resources.GetObject("grdUsuarios.Images"), System.Drawing.Image))
        Me.grdUsuarios.Location = New System.Drawing.Point(3, 55)
        Me.grdUsuarios.Name = "grdUsuarios"
        Me.grdUsuarios.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdUsuarios.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdUsuarios.PreviewInfo.ZoomFactor = 75.0R
        Me.grdUsuarios.PrintInfo.PageSettings = CType(resources.GetObject("grdDepartamentoCategorias.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdUsuarios.RowHeight = 17
        Me.grdUsuarios.ShowEditButton = False
        Me.grdUsuarios.Size = New System.Drawing.Size(486, 308)
        Me.grdUsuarios.TabIndex = 46
        Me.grdUsuarios.Text = "AzTrueDBGrid1"
        Me.grdUsuarios.PropBag = resources.GetString("grdUsuarios.PropBag")
        '
        'tbDeptosCategoria
        '
        Me.tbDeptosCategoria.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbDeptosCategoria.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnUsuariosAdd, Me.ToolStripSeparator1, Me.btnGuardar, Me.btnCancelar})
        Me.tbDeptosCategoria.Location = New System.Drawing.Point(3, 16)
        Me.tbDeptosCategoria.Name = "tbDeptosCategoria"
        Me.tbDeptosCategoria.Size = New System.Drawing.Size(486, 39)
        Me.tbDeptosCategoria.TabIndex = 45
        Me.tbDeptosCategoria.Text = "CiToolBar4"
        '
        'btnUsuariosAdd
        '
        Me.btnUsuariosAdd.Image = CType(resources.GetObject("btnUsuariosAdd.Image"), System.Drawing.Image)
        Me.btnUsuariosAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuariosAdd.Name = "btnUsuariosAdd"
        Me.btnUsuariosAdd.Size = New System.Drawing.Size(133, 36)
        Me.btnUsuariosAdd.Text = "Agregar Usuarios"
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
        'DepartamentosAccesosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxDeptosCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "DepartamentosAccesosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuarios del departamento"
        Me.gbxDeptosCategorias.ResumeLayout(False)
        Me.gbxDeptosCategorias.PerformLayout()
        CType(Me.grdUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAccesos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDeptosCategoria.ResumeLayout(False)
        Me.tbDeptosCategoria.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDeptosCategorias As Azteca.Windows.Controls.CIGroupBox
    Friend WithEvents grdUsuarios As Azteca.Windows.Controls.DataGridViewCatalog
    Friend WithEvents tbDeptosCategoria As Azteca.Windows.Controls.CIToolBar
    Friend WithEvents btnUsuariosAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bsAccesos As System.Windows.Forms.BindingSource
End Class
