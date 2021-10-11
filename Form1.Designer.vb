<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ButtonUp = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.LoadShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.NewShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.PrintShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.ButtonDown = New System.Windows.Forms.Button()
        Me.ButtonLeft = New System.Windows.Forms.Button()
        Me.ButtonRight = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShipLayoutGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Ship = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShipLayoutGB.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonUp
        '
        Me.ButtonUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonUp.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.level_up
        Me.ButtonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUp.Location = New System.Drawing.Point(48, 0)
        Me.ButtonUp.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonUp.Name = "ButtonUp"
        Me.ButtonUp.Size = New System.Drawing.Size(48, 48)
        Me.ButtonUp.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.ButtonUp, "Upper Deck")
        Me.ButtonUp.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveShipBtn, Me.LoadShipBtn, Me.NewShipBtn, Me.PrintShipBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(948, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveShipBtn
        '
        Me.SaveShipBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.Save_16x
        Me.SaveShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveShipBtn.Name = "SaveShipBtn"
        Me.SaveShipBtn.Size = New System.Drawing.Size(23, 22)
        Me.SaveShipBtn.Text = "ToolStripButton1"
        Me.SaveShipBtn.ToolTipText = "Save Ship Layout"
        '
        'LoadShipBtn
        '
        Me.LoadShipBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoadShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.OpenFolder_16x
        Me.LoadShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadShipBtn.Name = "LoadShipBtn"
        Me.LoadShipBtn.Size = New System.Drawing.Size(23, 22)
        Me.LoadShipBtn.Text = "ToolStripButton2"
        Me.LoadShipBtn.ToolTipText = "Load Ship Layout"
        '
        'NewShipBtn
        '
        Me.NewShipBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.NewFile_16x
        Me.NewShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewShipBtn.Name = "NewShipBtn"
        Me.NewShipBtn.Size = New System.Drawing.Size(23, 22)
        Me.NewShipBtn.Text = "ToolStripButton3"
        Me.NewShipBtn.ToolTipText = "New Ship"
        '
        'PrintShipBtn
        '
        Me.PrintShipBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintShipBtn.Enabled = False
        Me.PrintShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.Print_16x
        Me.PrintShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintShipBtn.Name = "PrintShipBtn"
        Me.PrintShipBtn.Size = New System.Drawing.Size(23, 22)
        Me.PrintShipBtn.Text = "ToolStripButton4"
        '
        'ButtonDown
        '
        Me.ButtonDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDown.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.level_down
        Me.ButtonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDown.Location = New System.Drawing.Point(48, 96)
        Me.ButtonDown.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonDown.Name = "ButtonDown"
        Me.ButtonDown.Size = New System.Drawing.Size(48, 48)
        Me.ButtonDown.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.ButtonDown, "Lower Deck")
        Me.ButtonDown.UseVisualStyleBackColor = True
        '
        'ButtonLeft
        '
        Me.ButtonLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLeft.Image = Global.nms_freighter_planner.My.Resources.Resources.arrow_right_48px
        Me.ButtonLeft.Location = New System.Drawing.Point(0, 48)
        Me.ButtonLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLeft.Name = "ButtonLeft"
        Me.ButtonLeft.Size = New System.Drawing.Size(48, 48)
        Me.ButtonLeft.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.ButtonLeft, "Rotate Layout Clockwise")
        Me.ButtonLeft.UseVisualStyleBackColor = True
        '
        'ButtonRight
        '
        Me.ButtonRight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRight.Image = Global.nms_freighter_planner.My.Resources.Resources.arrow_left_48px
        Me.ButtonRight.Location = New System.Drawing.Point(96, 48)
        Me.ButtonRight.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRight.Name = "ButtonRight"
        Me.ButtonRight.Size = New System.Drawing.Size(48, 48)
        Me.ButtonRight.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.ButtonRight, "Rotate Layout Anticlockwise")
        Me.ButtonRight.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(48, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonUp, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonLeft, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonDown, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRight, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(735, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(144, 144)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(735, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox1, "Current Element")
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(735, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 468)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elements"
        '
        'ShipLayoutGB
        '
        Me.ShipLayoutGB.Controls.Add(Me.PictureBox3)
        Me.ShipLayoutGB.Controls.Add(Me.PictureBox2)
        Me.ShipLayoutGB.Controls.Add(Me.Ship)
        Me.ShipLayoutGB.Location = New System.Drawing.Point(12, 28)
        Me.ShipLayoutGB.Name = "ShipLayoutGB"
        Me.ShipLayoutGB.Size = New System.Drawing.Size(717, 732)
        Me.ShipLayoutGB.TabIndex = 9
        Me.ShipLayoutGB.TabStop = False
        Me.ShipLayoutGB.Text = "NewShip"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.nms_freighter_planner.My.Resources.Resources.rulery
        Me.PictureBox3.Location = New System.Drawing.Point(7, 54)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 672)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.nms_freighter_planner.My.Resources.Resources.rulerx
        Me.PictureBox2.Location = New System.Drawing.Point(39, 22)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(672, 32)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Ship
        '
        Me.Ship.ColumnCount = 21
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Ship.Location = New System.Drawing.Point(39, 54)
        Me.Ship.Margin = New System.Windows.Forms.Padding(0)
        Me.Ship.Name = "Ship"
        Me.Ship.RowCount = 21
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.Ship.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Ship.Size = New System.Drawing.Size(672, 672)
        Me.Ship.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 768)
        Me.Controls.Add(Me.ShipLayoutGB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "NMS Freigher Planner"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShipLayoutGB.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonUp As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveShipBtn As ToolStripButton
    Friend WithEvents ButtonDown As Button
    Friend WithEvents ButtonLeft As Button
    Friend WithEvents ButtonRight As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadShipBtn As ToolStripButton
    Friend WithEvents NewShipBtn As ToolStripButton
    Friend WithEvents PrintShipBtn As ToolStripButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShipLayoutGB As GroupBox
    Friend WithEvents Ship As TableLayoutPanel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
