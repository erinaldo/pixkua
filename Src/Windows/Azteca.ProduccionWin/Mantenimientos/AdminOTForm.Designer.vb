<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminOTForm
    Inherits Azteca.Windows.Forms.Forma

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminOTForm))
        Dim C1TopicPage1 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink1 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink2 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink3 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicPage2 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink4 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Me.dtpFechaFin = New Azteca.Windows.Controls.CIDateTimePicker()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdGuardados = New C1.Win.C1Command.C1CommandControl()
        Me.enEspera = New C1.Win.C1Command.C1Command()
        Me.cmbLib = New C1.Win.C1Command.C1Command()
        Me.cmdCan = New C1.Win.C1Command.C1Command()
        Me.cmdCerr = New C1.Win.C1Command.C1Command()
        Me.C1CommandControl1 = New C1.Win.C1Command.C1CommandControl()
        Me.cmdConsultar = New C1.Win.C1Command.C1Command()
        Me.C1CommandControl3 = New C1.Win.C1Command.C1CommandControl()
        Me.tlbActualizar = New C1.Win.C1Command.C1Command()
        Me.tlbSiguiente = New C1.Win.C1Command.C1Command()
        Me.tlbRecibirEntregar = New C1.Win.C1Command.C1Command()
        Me.tlbAgregarIncidencia = New C1.Win.C1Command.C1Command()
        Me.tlbCerrarIncidencia = New C1.Win.C1Command.C1Command()
        Me.tlbCierreOT = New C1.Win.C1Command.C1Command()
        Me.tlbSurtirMat = New C1.Win.C1Command.C1ContextMenu()
        Me.tlbSurtirMP = New C1.Win.C1Command.C1Command()
        Me.tlbRecibirFabricacion = New C1.Win.C1Command.C1Command()
        Me.C1Command1 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink16 = New C1.Win.C1Command.C1CommandLink()
        Me.tlbInformes_Seguimiento = New C1.Win.C1Command.C1Command()
        Me.InvTrans = New C1.Win.C1Command.C1Command()
        Me.C1CommandControl2 = New C1.Win.C1Command.C1CommandControl()
        Me.cboEnsambles = New Azteca.Windows.Produccion.EnsamblesComboBox(Me.components)
        Me.tlbScannWorkOrder = New C1.Win.C1Command.C1Command()
        Me.C1Command2 = New C1.Win.C1Command.C1Command()
        Me.tlbImprimirMovimientos = New C1.Win.C1Command.C1Command()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.tlbStatus = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.tlbProcesos = New C1.Win.C1Command.C1ToolBar()
        Me.tlbTop = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink12 = New C1.Win.C1Command.C1CommandLink()
        Me.tlbInvTrans = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink13 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink15 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink14 = New C1.Win.C1Command.C1CommandLink()
        Me.grdOrdenesTrabajo = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.bsOrdenesTrabajo = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgEmpleado = New System.Windows.Forms.PictureBox()
        Me.tbEmpleado = New C1.Win.C1Command.C1TopicBar()
        Me.cmdIniciarSesion = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlbProcesos.SuspendLayout()
        CType(Me.grdOrdenesTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOrdenesTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imgEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.HighlightColor = System.Drawing.SystemColors.Info
        Me.dtpFechaFin.Location = New System.Drawing.Point(0, 0)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFin.TabIndex = 3
        Me.dtpFechaFin.Value = New Date(2012, 2, 19, 0, 0, 0, 0)
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Commands.Add(Me.cmdGuardados)
        Me.C1CommandHolder1.Commands.Add(Me.enEspera)
        Me.C1CommandHolder1.Commands.Add(Me.cmbLib)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCan)
        Me.C1CommandHolder1.Commands.Add(Me.cmdCerr)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandControl1)
        Me.C1CommandHolder1.Commands.Add(Me.cmdConsultar)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandControl3)
        Me.C1CommandHolder1.Commands.Add(Me.tlbActualizar)
        Me.C1CommandHolder1.Commands.Add(Me.tlbSiguiente)
        Me.C1CommandHolder1.Commands.Add(Me.tlbRecibirEntregar)
        Me.C1CommandHolder1.Commands.Add(Me.tlbAgregarIncidencia)
        Me.C1CommandHolder1.Commands.Add(Me.tlbCerrarIncidencia)
        Me.C1CommandHolder1.Commands.Add(Me.tlbCierreOT)
        Me.C1CommandHolder1.Commands.Add(Me.tlbSurtirMat)
        Me.C1CommandHolder1.Commands.Add(Me.tlbSurtirMP)
        Me.C1CommandHolder1.Commands.Add(Me.tlbRecibirFabricacion)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command1)
        Me.C1CommandHolder1.Commands.Add(Me.tlbInformes_Seguimiento)
        Me.C1CommandHolder1.Commands.Add(Me.InvTrans)
        Me.C1CommandHolder1.Commands.Add(Me.C1CommandControl2)
        Me.C1CommandHolder1.Commands.Add(Me.tlbScannWorkOrder)
        Me.C1CommandHolder1.Commands.Add(Me.C1Command2)
        Me.C1CommandHolder1.Commands.Add(Me.tlbImprimirMovimientos)
        Me.C1CommandHolder1.Owner = Me
        Me.C1CommandHolder1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'cmdGuardados
        '
        Me.cmdGuardados.Image = CType(resources.GetObject("cmdGuardados.Image"), System.Drawing.Image)
        Me.cmdGuardados.Name = "cmdGuardados"
        Me.cmdGuardados.ShortcutText = ""
        Me.cmdGuardados.Text = "Liberados"
        Me.cmdGuardados.ToolTipText = "Consulta las OT guardadas"
        '
        'enEspera
        '
        Me.enEspera.Image = CType(resources.GetObject("enEspera.Image"), System.Drawing.Image)
        Me.enEspera.Name = "enEspera"
        Me.enEspera.ShortcutText = ""
        Me.enEspera.Text = "En Espera"
        '
        'cmbLib
        '
        Me.cmbLib.Image = CType(resources.GetObject("cmbLib.Image"), System.Drawing.Image)
        Me.cmbLib.Name = "cmbLib"
        Me.cmbLib.ShortcutText = ""
        Me.cmbLib.Text = "Liberados"
        '
        'cmdCan
        '
        Me.cmdCan.Image = CType(resources.GetObject("cmdCan.Image"), System.Drawing.Image)
        Me.cmdCan.Name = "cmdCan"
        Me.cmdCan.ShortcutText = ""
        Me.cmdCan.Text = "Cancelados"
        '
        'cmdCerr
        '
        Me.cmdCerr.Image = CType(resources.GetObject("cmdCerr.Image"), System.Drawing.Image)
        Me.cmdCerr.Name = "cmdCerr"
        Me.cmdCerr.ShortcutText = ""
        Me.cmdCerr.Text = "Cerrados"
        '
        'C1CommandControl1
        '
        Me.C1CommandControl1.Name = "C1CommandControl1"
        Me.C1CommandControl1.ShortcutText = ""
        '
        'cmdConsultar
        '
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.ShortcutText = ""
        Me.cmdConsultar.Text = "Consultar"
        '
        'C1CommandControl3
        '
        Me.C1CommandControl3.Name = "C1CommandControl3"
        Me.C1CommandControl3.ShortcutText = ""
        '
        'tlbActualizar
        '
        Me.tlbActualizar.Image = CType(resources.GetObject("tlbActualizar.Image"), System.Drawing.Image)
        Me.tlbActualizar.Name = "tlbActualizar"
        Me.tlbActualizar.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.tlbActualizar.ShortcutText = ""
        Me.tlbActualizar.Text = "Actualizar"
        '
        'tlbSiguiente
        '
        Me.tlbSiguiente.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.next_24
        Me.tlbSiguiente.Name = "tlbSiguiente"
        Me.tlbSiguiente.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.tlbSiguiente.ShortcutText = ""
        Me.tlbSiguiente.Text = "F2"
        Me.tlbSiguiente.ToolTipText = "Siguiente Ensamble"
        '
        'tlbRecibirEntregar
        '
        Me.tlbRecibirEntregar.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.RecibirWO_32px
        Me.tlbRecibirEntregar.Name = "tlbRecibirEntregar"
        Me.tlbRecibirEntregar.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.tlbRecibirEntregar.ShortcutText = ""
        Me.tlbRecibirEntregar.Text = "F3"
        Me.tlbRecibirEntregar.ToolTipText = "Recibir o Entregar"
        '
        'tlbAgregarIncidencia
        '
        Me.tlbAgregarIncidencia.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.AddIncidencias_32px2
        Me.tlbAgregarIncidencia.Name = "tlbAgregarIncidencia"
        Me.tlbAgregarIncidencia.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.tlbAgregarIncidencia.ShortcutText = ""
        Me.tlbAgregarIncidencia.Text = "F4"
        Me.tlbAgregarIncidencia.ToolTipText = "Agregar Incidencia"
        '
        'tlbCerrarIncidencia
        '
        Me.tlbCerrarIncidencia.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.CloseIncidencias_32px
        Me.tlbCerrarIncidencia.Name = "tlbCerrarIncidencia"
        Me.tlbCerrarIncidencia.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.tlbCerrarIncidencia.ShortcutText = ""
        Me.tlbCerrarIncidencia.Text = "F5"
        Me.tlbCerrarIncidencia.ToolTipText = "CerrarIncidencia"
        '
        'tlbCierreOT
        '
        Me.tlbCierreOT.Enabled = False
        Me.tlbCierreOT.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.close_workorder2
        Me.tlbCierreOT.Name = "tlbCierreOT"
        Me.tlbCierreOT.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.tlbCierreOT.ShortcutText = ""
        Me.tlbCierreOT.Text = "F6"
        Me.tlbCierreOT.ToolTipText = "Cerrar Orden"
        '
        'tlbSurtirMat
        '
        Me.tlbSurtirMat.HideNonRecentLinks = False
        Me.tlbSurtirMat.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.warehouse
        Me.tlbSurtirMat.Name = "tlbSurtirMat"
        Me.tlbSurtirMat.ShortcutText = ""
        Me.tlbSurtirMat.ShowTextAsToolTip = False
        Me.tlbSurtirMat.ShowToolTips = True
        Me.tlbSurtirMat.Text = "Inventario"
        Me.tlbSurtirMat.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'tlbSurtirMP
        '
        Me.tlbSurtirMP.Name = "tlbSurtirMP"
        Me.tlbSurtirMP.ShortcutText = ""
        Me.tlbSurtirMP.Text = "Surtir Insumo"
        Me.tlbSurtirMP.ToolTipText = "Generar una Salida del Almacen referente a la OT"
        '
        'tlbRecibirFabricacion
        '
        Me.tlbRecibirFabricacion.Name = "tlbRecibirFabricacion"
        Me.tlbRecibirFabricacion.ShortcutText = ""
        Me.tlbRecibirFabricacion.Text = "Recibir PT"
        '
        'C1Command1
        '
        Me.C1Command1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink16})
        Me.C1Command1.HideNonRecentLinks = False
        Me.C1Command1.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.report_32X32
        Me.C1Command1.Name = "C1Command1"
        Me.C1Command1.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.C1Command1.ShortcutText = ""
        Me.C1Command1.ShowToolTips = True
        Me.C1Command1.Text = "Informes (F8)"
        Me.C1Command1.ToolTipText = "Informes"
        Me.C1Command1.Visible = False
        Me.C1Command1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink16
        '
        Me.C1CommandLink16.Command = Me.tlbInformes_Seguimiento
        Me.C1CommandLink16.Text = "Seguimiento OT"
        '
        'tlbInformes_Seguimiento
        '
        Me.tlbInformes_Seguimiento.Name = "tlbInformes_Seguimiento"
        Me.tlbInformes_Seguimiento.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.tlbInformes_Seguimiento.ShortcutText = ""
        Me.tlbInformes_Seguimiento.Text = "Seguimiento OT"
        Me.tlbInformes_Seguimiento.ToolTipText = "Seguimiento OT (F8)"
        '
        'InvTrans
        '
        Me.InvTrans.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.warehouse
        Me.InvTrans.Name = "InvTrans"
        Me.InvTrans.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.InvTrans.ShortcutText = ""
        Me.InvTrans.Text = "Inventario (F7)"
        Me.InvTrans.ToolTipText = "Transacciones en Inventario"
        '
        'C1CommandControl2
        '
        Me.C1CommandControl2.Control = Me.cboEnsambles
        Me.C1CommandControl2.Name = "C1CommandControl2"
        Me.C1CommandControl2.ShortcutText = ""
        '
        'cboEnsambles
        '
        Me.cboEnsambles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnsambles.FormattingEnabled = True
        Me.cboEnsambles.HighlightColor = System.Drawing.SystemColors.Info
        Me.cboEnsambles.ItemsTable = Nothing
        Me.cboEnsambles.Location = New System.Drawing.Point(94, 6)
        Me.cboEnsambles.Name = "cboEnsambles"
        Me.cboEnsambles.Size = New System.Drawing.Size(207, 21)
        Me.cboEnsambles.TabIndex = 10
        Me.cboEnsambles.UIName = Nothing
        '
        'tlbScannWorkOrder
        '
        Me.tlbScannWorkOrder.Enabled = False
        Me.tlbScannWorkOrder.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.codigodebarras
        Me.tlbScannWorkOrder.Name = "tlbScannWorkOrder"
        Me.tlbScannWorkOrder.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.tlbScannWorkOrder.ShortcutText = ""
        Me.tlbScannWorkOrder.Text = "Scann OT (F11)"
        Me.tlbScannWorkOrder.ToolTipText = "Scann OT"
        '
        'C1Command2
        '
        Me.C1Command2.Image = CType(resources.GetObject("C1Command2.Image"), System.Drawing.Image)
        Me.C1Command2.Name = "C1Command2"
        Me.C1Command2.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.C1Command2.ShortcutText = ""
        Me.C1Command2.Text = "Iniciar Sesión"
        '
        'tlbImprimirMovimientos
        '
        Me.tlbImprimirMovimientos.Image = CType(resources.GetObject("tlbImprimirMovimientos.Image"), System.Drawing.Image)
        Me.tlbImprimirMovimientos.Name = "tlbImprimirMovimientos"
        Me.tlbImprimirMovimientos.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.tlbImprimirMovimientos.ShortcutText = ""
        Me.tlbImprimirMovimientos.Text = "Movimientos (F8)"
        Me.tlbImprimirMovimientos.ToolTipText = "Movimientos"
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.AccessibleName = "Tool Bar"
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink6})
        Me.C1ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(26, 26)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        Me.C1ToolBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Text = "New Command"
        '
        'tlbStatus
        '
        Me.tlbStatus.AccessibleName = "Tool Bar"
        Me.tlbStatus.AutoSize = False
        Me.tlbStatus.Border.Width = 1
        Me.tlbStatus.ButtonLookEnforceVert = True
        Me.tlbStatus.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbStatus.CommandHolder = Me.C1CommandHolder1
        Me.tlbStatus.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1, Me.C1CommandLink2, Me.C1CommandLink3, Me.C1CommandLink4, Me.C1CommandLink5})
        Me.tlbStatus.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlbStatus.Horizontal = False
        Me.tlbStatus.Location = New System.Drawing.Point(0, 0)
        Me.tlbStatus.MinButtonSize = 50
        Me.tlbStatus.Movable = False
        Me.tlbStatus.Name = "tlbStatus"
        Me.tlbStatus.Size = New System.Drawing.Size(102, 450)
        Me.tlbStatus.Text = "C1ToolBar2"
        Me.tlbStatus.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.tlbStatus.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink1.Command = Me.cmdGuardados
        Me.C1CommandLink1.Text = "Guardados"
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink2.Command = Me.cmbLib
        Me.C1CommandLink2.OwnerDraw = True
        Me.C1CommandLink2.SortOrder = 1
        Me.C1CommandLink2.Text = "Liberados"
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink3.Command = Me.enEspera
        Me.C1CommandLink3.OwnerDraw = True
        Me.C1CommandLink3.SortOrder = 2
        Me.C1CommandLink3.Text = "En Espera"
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink4.Command = Me.cmdCerr
        Me.C1CommandLink4.OwnerDraw = True
        Me.C1CommandLink4.SortOrder = 3
        Me.C1CommandLink4.Text = "Cerrados"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.ButtonLook = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1CommandLink5.Command = Me.cmdCan
        Me.C1CommandLink5.OwnerDraw = True
        Me.C1CommandLink5.SortOrder = 4
        Me.C1CommandLink5.Text = "Cancelados"
        '
        'tlbProcesos
        '
        Me.tlbProcesos.AccessibleName = "Tool Bar"
        Me.tlbProcesos.AutoSize = False
        Me.tlbProcesos.ButtonLookEnforceHorz = True
        Me.tlbProcesos.ButtonLookHorz = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.tlbProcesos.CommandHolder = Me.C1CommandHolder1
        Me.tlbProcesos.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.tlbTop, Me.C1CommandLink7, Me.C1CommandLink8, Me.C1CommandLink9, Me.C1CommandLink10, Me.C1CommandLink11, Me.C1CommandLink12, Me.tlbInvTrans, Me.C1CommandLink13, Me.C1CommandLink15, Me.C1CommandLink14})
        Me.tlbProcesos.Controls.Add(Me.cboEnsambles)
        Me.tlbProcesos.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlbProcesos.Location = New System.Drawing.Point(102, 0)
        Me.tlbProcesos.MinButtonSize = 32
        Me.tlbProcesos.Movable = False
        Me.tlbProcesos.Name = "tlbProcesos"
        Me.tlbProcesos.Size = New System.Drawing.Size(1147, 33)
        Me.tlbProcesos.Text = "C1ToolBar3"
        Me.tlbProcesos.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'tlbTop
        '
        Me.tlbTop.Command = Me.tlbActualizar
        Me.tlbTop.Text = "Consultar"
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.C1CommandControl2
        Me.C1CommandLink7.SortOrder = 1
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Command = Me.tlbSiguiente
        Me.C1CommandLink8.Delimiter = True
        Me.C1CommandLink8.SortOrder = 2
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Command = Me.tlbRecibirEntregar
        Me.C1CommandLink9.Delimiter = True
        Me.C1CommandLink9.SortOrder = 3
        '
        'C1CommandLink10
        '
        Me.C1CommandLink10.Command = Me.tlbAgregarIncidencia
        Me.C1CommandLink10.Delimiter = True
        Me.C1CommandLink10.SortOrder = 4
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Command = Me.tlbCerrarIncidencia
        Me.C1CommandLink11.Delimiter = True
        Me.C1CommandLink11.SortOrder = 5
        '
        'C1CommandLink12
        '
        Me.C1CommandLink12.Command = Me.tlbCierreOT
        Me.C1CommandLink12.Delimiter = True
        Me.C1CommandLink12.SortOrder = 6
        '
        'tlbInvTrans
        '
        Me.tlbInvTrans.Command = Me.InvTrans
        Me.tlbInvTrans.Delimiter = True
        Me.tlbInvTrans.SortOrder = 7
        '
        'C1CommandLink13
        '
        Me.C1CommandLink13.Command = Me.C1Command1
        Me.C1CommandLink13.SortOrder = 8
        '
        'C1CommandLink15
        '
        Me.C1CommandLink15.Command = Me.tlbImprimirMovimientos
        Me.C1CommandLink15.Delimiter = True
        Me.C1CommandLink15.SortOrder = 9
        '
        'C1CommandLink14
        '
        Me.C1CommandLink14.Command = Me.tlbScannWorkOrder
        Me.C1CommandLink14.Delimiter = True
        Me.C1CommandLink14.SortOrder = 10
        Me.C1CommandLink14.ToolTipText = "F11"
        '
        'grdOrdenesTrabajo
        '
        Me.grdOrdenesTrabajo.AllowUpdate = False
        Me.grdOrdenesTrabajo.DataSource = Me.bsOrdenesTrabajo
        Me.grdOrdenesTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdOrdenesTrabajo.FilterBar = True
        Me.grdOrdenesTrabajo.Images.Add(CType(resources.GetObject("grdOrdenesTrabajo.Images"), System.Drawing.Image))
        Me.grdOrdenesTrabajo.Images.Add(CType(resources.GetObject("grdOrdenesTrabajo.Images1"), System.Drawing.Image))
        Me.grdOrdenesTrabajo.Images.Add(CType(resources.GetObject("grdOrdenesTrabajo.Images2"), System.Drawing.Image))
        Me.grdOrdenesTrabajo.Location = New System.Drawing.Point(102, 33)
        Me.grdOrdenesTrabajo.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdOrdenesTrabajo.Name = "grdOrdenesTrabajo"
        Me.grdOrdenesTrabajo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdOrdenesTrabajo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdOrdenesTrabajo.PreviewInfo.ZoomFactor = 75.0R
        Me.grdOrdenesTrabajo.PrintInfo.PageSettings = CType(resources.GetObject("grdOrdenesTrabajo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdOrdenesTrabajo.Size = New System.Drawing.Size(993, 417)
        Me.grdOrdenesTrabajo.TabIndex = 6
        Me.grdOrdenesTrabajo.PropBag = resources.GetString("grdOrdenesTrabajo.PropBag")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.imgEmpleado)
        Me.Panel1.Controls.Add(Me.tbEmpleado)
        Me.Panel1.Controls.Add(Me.cmdIniciarSesion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1095, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 417)
        Me.Panel1.TabIndex = 10
        '
        'imgEmpleado
        '
        Me.imgEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.imgEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.imgEmpleado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.imgEmpleado.Location = New System.Drawing.Point(0, 222)
        Me.imgEmpleado.Name = "imgEmpleado"
        Me.imgEmpleado.Size = New System.Drawing.Size(154, 126)
        Me.imgEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEmpleado.TabIndex = 2
        Me.imgEmpleado.TabStop = False
        '
        'tbEmpleado
        '
        Me.tbEmpleado.AutoScrollMinSize = New System.Drawing.Size(0, 193)
        Me.tbEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.tbEmpleado.Name = "tbEmpleado"
        C1TopicLink1.ImageIndex = 5
        C1TopicLink1.Text = "Nombre"
        C1TopicLink2.Text = "Apellido Paterno"
        C1TopicLink3.Text = "Apellido Materno"
        C1TopicPage1.Links.Add(C1TopicLink1)
        C1TopicPage1.Links.Add(C1TopicLink2)
        C1TopicPage1.Links.Add(C1TopicLink3)
        C1TopicPage1.Text = "Empleado"
        C1TopicLink4.ImageIndex = 3
        C1TopicLink4.Text = "00:00"
        C1TopicLink4.ToolTipText = "Tiempo Restante"
        C1TopicPage2.Links.Add(C1TopicLink4)
        C1TopicPage2.Text = "Información General"
        Me.tbEmpleado.Pages.Add(C1TopicPage1)
        Me.tbEmpleado.Pages.Add(C1TopicPage2)
        Me.tbEmpleado.Size = New System.Drawing.Size(154, 348)
        Me.tbEmpleado.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.tbEmpleado.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'cmdIniciarSesion
        '
        Me.cmdIniciarSesion.BackColor = System.Drawing.Color.MintCream
        Me.cmdIniciarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIniciarSesion.Image = Global.Azteca.Windows.Produccion.My.Resources.Resources.Servicios32X32
        Me.cmdIniciarSesion.Location = New System.Drawing.Point(0, 348)
        Me.cmdIniciarSesion.Name = "cmdIniciarSesion"
        Me.cmdIniciarSesion.Size = New System.Drawing.Size(154, 69)
        Me.cmdIniciarSesion.TabIndex = 3
        Me.cmdIniciarSesion.Text = "Iniciar Sesión"
        Me.cmdIniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdIniciarSesion.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'AdminOTForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 472)
        Me.Controls.Add(Me.grdOrdenesTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tlbProcesos)
        Me.Controls.Add(Me.tlbStatus)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Name = "AdminOTForm"
        Me.Text = "AdminOTForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.dtpFechaFin, 0)
        Me.Controls.SetChildIndex(Me.C1ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.tlbStatus, 0)
        Me.Controls.SetChildIndex(Me.tlbProcesos, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.grdOrdenesTrabajo, 0)
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlbProcesos.ResumeLayout(False)
        CType(Me.grdOrdenesTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOrdenesTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.imgEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFechaFin As Azteca.Windows.Controls.CIDateTimePicker
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents enEspera As C1.Win.C1Command.C1Command
    Friend WithEvents cmbLib As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCan As C1.Win.C1Command.C1Command
    Friend WithEvents cmdCerr As C1.Win.C1Command.C1Command
    Friend WithEvents tlbStatus As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandControl1 As C1.Win.C1Command.C1CommandControl
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents cmdConsultar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandControl3 As C1.Win.C1Command.C1CommandControl
    Friend WithEvents tlbProcesos As C1.Win.C1Command.C1ToolBar
    Friend WithEvents tlbActualizar As C1.Win.C1Command.C1Command
    Friend WithEvents tlbTop As C1.Win.C1Command.C1CommandLink
    Public WithEvents cmdGuardados As C1.Win.C1Command.C1CommandControl
    Friend WithEvents grdOrdenesTrabajo As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents bsOrdenesTrabajo As System.Windows.Forms.BindingSource
    Friend WithEvents cboEnsambles As Azteca.Windows.Produccion.EnsamblesComboBox
    Friend WithEvents tlbSiguiente As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbRecibirEntregar As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbAgregarIncidencia As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbCerrarIncidencia As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbCierreOT As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink12 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbSurtirMat As C1.Win.C1Command.C1ContextMenu
    Friend WithEvents tlbSurtirMP As C1.Win.C1Command.C1Command
    Friend WithEvents tlbRecibirFabricacion As C1.Win.C1Command.C1Command
    Friend WithEvents C1Command1 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink16 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink13 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbInformes_Seguimiento As C1.Win.C1Command.C1Command
    Friend WithEvents InvTrans As C1.Win.C1Command.C1Command
    Friend WithEvents tlbInvTrans As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandControl2 As C1.Win.C1Command.C1CommandControl
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents tlbScannWorkOrder As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink14 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents imgEmpleado As System.Windows.Forms.PictureBox
    Friend WithEvents tbEmpleado As C1.Win.C1Command.C1TopicBar
    Friend WithEvents cmdIniciarSesion As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents C1Command2 As C1.Win.C1Command.C1Command
    Friend WithEvents tlbImprimirMovimientos As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink15 As C1.Win.C1Command.C1CommandLink
End Class
