<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim C1TopicPage6 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Me.C1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.C1TopicBar1 = New C1.Win.C1Command.C1TopicBar()
        Me.C1ToolBar1 = New C1.Win.C1Command.C1ToolBar()
        Me.C1CommandHolder1 = New C1.Win.C1Command.C1CommandHolder()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.C1OutBar1 = New C1.Win.C1Command.C1OutBar()
        Me.C1OutPage1 = New C1.Win.C1Command.C1OutPage()
        Me.C1ToolBar2 = New C1.Win.C1Command.C1ToolBar()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1Label1 = New C1.Win.C1Input.C1Label()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TopicBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1OutBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1OutBar1.SuspendLayout()
        Me.C1OutPage1.SuspendLayout()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1CommandDock1
        '
        Me.C1CommandDock1.Id = 1
        Me.C1CommandDock1.Location = New System.Drawing.Point(0, 0)
        Me.C1CommandDock1.Name = "C1CommandDock1"
        Me.C1CommandDock1.Size = New System.Drawing.Size(685, 32)
        '
        'C1TopicBar1
        '
        Me.C1TopicBar1.AutoScrollMinSize = New System.Drawing.Size(0, 71)
        Me.C1TopicBar1.Location = New System.Drawing.Point(441, 52)
        Me.C1TopicBar1.Name = "C1TopicBar1"
        C1TopicPage6.Text = "Page 1"
        Me.C1TopicBar1.Pages.Add(C1TopicPage6)
        Me.C1TopicBar1.Size = New System.Drawing.Size(200, 300)
        '
        'C1ToolBar1
        '
        Me.C1ToolBar1.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar1.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink1})
        Me.C1ToolBar1.Location = New System.Drawing.Point(94, 328)
        Me.C1ToolBar1.Name = "C1ToolBar1"
        Me.C1ToolBar1.Size = New System.Drawing.Size(24, 24)
        Me.C1ToolBar1.Text = "C1ToolBar1"
        '
        'C1CommandHolder1
        '
        Me.C1CommandHolder1.Owner = Me
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Text = "New Command"
        '
        'C1OutBar1
        '
        Me.C1OutBar1.Controls.Add(Me.C1OutPage1)
        Me.C1OutBar1.Location = New System.Drawing.Point(203, 51)
        Me.C1OutBar1.Name = "C1OutBar1"
        Me.C1OutBar1.Size = New System.Drawing.Size(200, 300)
        '
        'C1OutPage1
        '
        Me.C1OutPage1.Controls.Add(Me.C1ToolBar2)
        Me.C1OutPage1.Name = "C1OutPage1"
        Me.C1OutPage1.Size = New System.Drawing.Size(200, 264)
        Me.C1OutPage1.Text = "Page1"
        '
        'C1ToolBar2
        '
        Me.C1ToolBar2.AutoSize = False
        Me.C1ToolBar2.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.C1ToolBar2.CommandHolder = Me.C1CommandHolder1
        Me.C1ToolBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1ToolBar2.Horizontal = False
        Me.C1ToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.C1ToolBar2.Movable = False
        Me.C1ToolBar2.Name = "C1ToolBar2"
        Me.C1ToolBar2.Size = New System.Drawing.Size(200, 264)
        Me.C1ToolBar2.Text = "Page1"
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 32)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(685, 156)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Tab"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Group"
        '
        'C1TextBox1
        '
        Me.C1TextBox1.Location = New System.Drawing.Point(94, 406)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBox1.TabIndex = 5
        Me.C1TextBox1.Tag = Nothing
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.C1InputPanel1.Location = New System.Drawing.Point(159, 182)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(240, 150)
        Me.C1InputPanel1.TabIndex = 6
        '
        'C1TextBox2
        '
        Me.C1TextBox2.Location = New System.Drawing.Point(265, 406)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(100, 18)
        Me.C1TextBox2.TabIndex = 7
        Me.C1TextBox2.Tag = Nothing
        '
        'C1Label1
        '
        Me.C1Label1.AutoSize = True
        Me.C1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1Label1.Location = New System.Drawing.Point(214, 375)
        Me.C1Label1.Name = "C1Label1"
        Me.C1Label1.Size = New System.Drawing.Size(52, 13)
        Me.C1Label1.TabIndex = 8
        Me.C1Label1.Tag = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 502)
        Me.Controls.Add(Me.C1Label1)
        Me.Controls.Add(Me.C1TextBox2)
        Me.Controls.Add(Me.C1InputPanel1)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Controls.Add(Me.C1OutBar1)
        Me.Controls.Add(Me.C1ToolBar1)
        Me.Controls.Add(Me.C1TopicBar1)
        Me.Controls.Add(Me.C1CommandDock1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TopicBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandHolder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1OutBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1OutBar1.ResumeLayout(False)
        Me.C1OutPage1.ResumeLayout(False)
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents C1TopicBar1 As C1.Win.C1Command.C1TopicBar
    Friend WithEvents C1ToolBar1 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1CommandHolder1 As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1OutBar1 As C1.Win.C1Command.C1OutBar
    Friend WithEvents C1OutPage1 As C1.Win.C1Command.C1OutPage
    Friend WithEvents C1ToolBar2 As C1.Win.C1Command.C1ToolBar
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel
    Friend WithEvents C1Label1 As C1.Win.C1Input.C1Label
End Class
