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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.LoadShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewShipBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RedrawBtn = New System.Windows.Forms.ToolStripButton()
        Me.ButtonLeft = New System.Windows.Forms.Button()
        Me.ButtonRight = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShipLayoutGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ShipCells = New System.Windows.Forms.TableLayoutPanel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.LevelUpBtn = New System.Windows.Forms.Button()
        Me.LevelDownBtn = New System.Windows.Forms.Button()
        Me.CurrentLevel = New System.Windows.Forms.Label()
        Me.TestBox = New System.Windows.Forms.TextBox()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ShipLayoutGB.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveShipBtn, Me.LoadShipBtn, Me.ToolStripSeparator1, Me.PrintShipBtn, Me.ToolStripSeparator2, Me.NewShipBtn, Me.ToolStripSeparator3, Me.RedrawBtn, Me.ToolStripSeparator4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(948, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveShipBtn
        '
        Me.SaveShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.Save_16x
        Me.SaveShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveShipBtn.Name = "SaveShipBtn"
        Me.SaveShipBtn.Size = New System.Drawing.Size(77, 22)
        Me.SaveShipBtn.Text = "Save Ship"
        Me.SaveShipBtn.ToolTipText = "Save Ship Layout"
        '
        'LoadShipBtn
        '
        Me.LoadShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.OpenFolder_16x
        Me.LoadShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadShipBtn.Name = "LoadShipBtn"
        Me.LoadShipBtn.Size = New System.Drawing.Size(79, 22)
        Me.LoadShipBtn.Text = "Load Ship"
        Me.LoadShipBtn.ToolTipText = "Load Ship Layout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        Me.PrintShipBtn.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NewShipBtn
        '
        Me.NewShipBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.NewFile_16x
        Me.NewShipBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewShipBtn.Name = "NewShipBtn"
        Me.NewShipBtn.Size = New System.Drawing.Size(77, 22)
        Me.NewShipBtn.Text = "New Ship"
        Me.NewShipBtn.ToolTipText = "New Ship"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'RedrawBtn
        '
        Me.RedrawBtn.Image = Global.nms_freighter_planner.My.Resources.Resources.Refresh_16x
        Me.RedrawBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedrawBtn.Name = "RedrawBtn"
        Me.RedrawBtn.Size = New System.Drawing.Size(92, 22)
        Me.RedrawBtn.Text = "Redraw Ship"
        Me.RedrawBtn.ToolTipText = "Redraw Ship"
        '
        'ButtonLeft
        '
        Me.ButtonLeft.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLeft.Image = Global.nms_freighter_planner.My.Resources.Resources.arrow_right_48px
        Me.ButtonLeft.Location = New System.Drawing.Point(0, 0)
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
        Me.ButtonRight.Location = New System.Drawing.Point(96, 0)
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
        Me.Label1.Location = New System.Drawing.Point(735, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LEVEL:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRight, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonLeft, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(777, 117)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(144, 48)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.nms_freighter_planner.My.Resources.Resources.empty
        Me.PictureBox1.Location = New System.Drawing.Point(48, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.ToolTip.SetToolTip(Me.PictureBox1, "Current Element")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(735, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 468)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elements"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ClearBtn, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button4, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button5, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button7, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button9, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button8, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 22)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 11
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(188, 440)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'ClearBtn
        '
        Me.ClearBtn.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.empty
        Me.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClearBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClearBtn.Location = New System.Drawing.Point(0, 0)
        Me.ClearBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(38, 38)
        Me.ClearBtn.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.ClearBtn, "Empty Space")
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(38, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "room"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(76, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "command room"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(114, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 38)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "storage"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Location = New System.Drawing.Point(152, 0)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 38)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "exomek"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(0, 38)
        Me.Button6.Margin = New System.Windows.Forms.Padding(0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(38, 38)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "stairs"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Location = New System.Drawing.Point(38, 38)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(38, 38)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "cor-2way"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.Location = New System.Drawing.Point(152, 38)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(38, 38)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "cor-4way"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.Location = New System.Drawing.Point(114, 38)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(38, 38)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "cor-3way"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(76, 38)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "cor-corn"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShipLayoutGB
        '
        Me.ShipLayoutGB.Controls.Add(Me.PictureBox3)
        Me.ShipLayoutGB.Controls.Add(Me.PictureBox2)
        Me.ShipLayoutGB.Controls.Add(Me.ShipCells)
        Me.ShipLayoutGB.Location = New System.Drawing.Point(12, 28)
        Me.ShipLayoutGB.Name = "ShipLayoutGB"
        Me.ShipLayoutGB.Size = New System.Drawing.Size(717, 732)
        Me.ShipLayoutGB.TabIndex = 9
        Me.ShipLayoutGB.TabStop = False
        Me.ShipLayoutGB.Text = "Your Freighter"
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
        'ShipCells
        '
        Me.ShipCells.ColumnCount = 21
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ShipCells.Location = New System.Drawing.Point(39, 54)
        Me.ShipCells.Margin = New System.Windows.Forms.Padding(0)
        Me.ShipCells.Name = "ShipCells"
        Me.ShipCells.RowCount = 21
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ShipCells.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ShipCells.Size = New System.Drawing.Size(672, 672)
        Me.ShipCells.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LevelUpBtn
        '
        Me.LevelUpBtn.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.go_up
        Me.LevelUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LevelUpBtn.Location = New System.Drawing.Point(873, 43)
        Me.LevelUpBtn.Name = "LevelUpBtn"
        Me.LevelUpBtn.Size = New System.Drawing.Size(48, 24)
        Me.LevelUpBtn.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.LevelUpBtn, "Up 1 Level")
        Me.LevelUpBtn.UseVisualStyleBackColor = True
        '
        'LevelDownBtn
        '
        Me.LevelDownBtn.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.go_down
        Me.LevelDownBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LevelDownBtn.Location = New System.Drawing.Point(873, 72)
        Me.LevelDownBtn.Name = "LevelDownBtn"
        Me.LevelDownBtn.Size = New System.Drawing.Size(48, 24)
        Me.LevelDownBtn.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.LevelDownBtn, "Down 1 Level")
        Me.LevelDownBtn.UseVisualStyleBackColor = True
        '
        'CurrentLevel
        '
        Me.CurrentLevel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentLevel.AutoSize = True
        Me.CurrentLevel.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CurrentLevel.Location = New System.Drawing.Point(829, 50)
        Me.CurrentLevel.Margin = New System.Windows.Forms.Padding(0)
        Me.CurrentLevel.Name = "CurrentLevel"
        Me.CurrentLevel.Size = New System.Drawing.Size(41, 30)
        Me.CurrentLevel.TabIndex = 10
        Me.CurrentLevel.Text = "00"
        Me.CurrentLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TestBox
        '
        Me.TestBox.Location = New System.Drawing.Point(821, 187)
        Me.TestBox.Name = "TestBox"
        Me.TestBox.Size = New System.Drawing.Size(100, 23)
        Me.TestBox.TabIndex = 13
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.nms_freighter_planner.My.Resources.Resources.InformationSymbol_16x
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(78, 22)
        Me.ToolStripButton1.Text = "Ship Stats"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 767)
        Me.Controls.Add(Me.TestBox)
        Me.Controls.Add(Me.LevelDownBtn)
        Me.Controls.Add(Me.LevelUpBtn)
        Me.Controls.Add(Me.CurrentLevel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ShipLayoutGB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "NMS Freighter Planner"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ShipLayoutGB.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveShipBtn As ToolStripButton
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
    Friend WithEvents ShipCells As TableLayoutPanel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CurrentLevel As Label
    Friend WithEvents LevelUpBtn As Button
    Friend WithEvents LevelDownBtn As Button
    Friend WithEvents RedrawBtn As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ClearBtn As Button
    Friend WithEvents TestBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
