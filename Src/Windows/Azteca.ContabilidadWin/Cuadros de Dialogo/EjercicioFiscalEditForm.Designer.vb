<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EjercicioFiscalEditForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EjercicioFiscalEditForm))
        Me.CiDateTimePicker1 = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiDateTimePicker2 = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.CiLabel1 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel2 = New Azteca.Windows.Controls.CILabel()
        Me.CiLabel3 = New Azteca.Windows.Controls.CILabel()
        Me.grdPeriodos = New Azteca.Windows.Controls.DataGridViewCatalog()
        CType(Me.grdPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CiDateTimePicker1
        '
        Me.CiDateTimePicker1.HighlightColor = System.Drawing.SystemColors.Info
        Me.CiDateTimePicker1.Location = New System.Drawing.Point(345, 62)
        Me.CiDateTimePicker1.Name = "CiDateTimePicker1"
        Me.CiDateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.CiDateTimePicker1.TabIndex = 0
        '
        'CiDateTimePicker2
        '
        Me.CiDateTimePicker2.HighlightColor = System.Drawing.SystemColors.Info
        Me.CiDateTimePicker2.Location = New System.Drawing.Point(78, 62)
        Me.CiDateTimePicker2.Name = "CiDateTimePicker2"
        Me.CiDateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.CiDateTimePicker2.TabIndex = 1
        '
        'CiLabel1
        '
        Me.CiLabel1.AutoSize = True
        Me.CiLabel1.Location = New System.Drawing.Point(35, 65)
        Me.CiLabel1.Name = "CiLabel1"
        Me.CiLabel1.Size = New System.Drawing.Size(37, 13)
        Me.CiLabel1.TabIndex = 2
        Me.CiLabel1.Text = "Fecha"
        '
        'CiLabel2
        '
        Me.CiLabel2.AutoSize = True
        Me.CiLabel2.Location = New System.Drawing.Point(305, 65)
        Me.CiLabel2.Name = "CiLabel2"
        Me.CiLabel2.Size = New System.Drawing.Size(37, 13)
        Me.CiLabel2.TabIndex = 3
        Me.CiLabel2.Text = "Fecha"
        '
        'CiLabel3
        '
        Me.CiLabel3.AutoSize = True
        Me.CiLabel3.Location = New System.Drawing.Point(35, 126)
        Me.CiLabel3.Name = "CiLabel3"
        Me.CiLabel3.Size = New System.Drawing.Size(48, 13)
        Me.CiLabel3.TabIndex = 4
        Me.CiLabel3.Text = "Periodos"
        '
        'grdPeriodos
        '
        Me.grdPeriodos.AllowAddNew = True
        Me.grdPeriodos.AllowDelete = True
        Me.grdPeriodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPeriodos.IDCatalogField = "Id"
        Me.grdPeriodos.Images.Add(CType(resources.GetObject("grdPeriodos.Images"), System.Drawing.Image))
        Me.grdPeriodos.Location = New System.Drawing.Point(85, 126)
        Me.grdPeriodos.Name = "grdPeriodos"
        Me.grdPeriodos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdPeriodos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdPeriodos.PreviewInfo.ZoomFactor = 75.0R
        Me.grdPeriodos.PrintInfo.PageSettings = CType(resources.GetObject("grdPeriodos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdPeriodos.ShowEditButton = False
        Me.grdPeriodos.Size = New System.Drawing.Size(409, 188)
        Me.grdPeriodos.TabIndex = 33
        Me.grdPeriodos.Text = "AzTrueDBGrid1"
        Me.grdPeriodos.PropBag = resources.GetString("grdPeriodos.PropBag")
        '
        'EjercicioFiscalEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 337)
        Me.Controls.Add(Me.grdPeriodos)
        Me.Controls.Add(Me.CiLabel3)
        Me.Controls.Add(Me.CiLabel2)
        Me.Controls.Add(Me.CiLabel1)
        Me.Controls.Add(Me.CiDateTimePicker2)
        Me.Controls.Add(Me.CiDateTimePicker1)
        Me.Name = "EjercicioFiscalEditForm"
        Me.Text = "EjercicioFiscalEditForm"
        CType(Me.grdPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CiDateTimePicker1 As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiDateTimePicker2 As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents CiLabel1 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel2 As Azteca.Windows.Controls.CILabel
    Friend WithEvents CiLabel3 As Azteca.Windows.Controls.CILabel
    Friend WithEvents grdPeriodos As Azteca.Windows.Controls.DataGridViewCatalog
End Class
