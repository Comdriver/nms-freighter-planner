<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ButtonLeft = New System.Windows.Forms.Button()
        Me.ButtonRight = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CurrentItemPicture = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.ShipLayoutGB.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveShipBtn, Me.LoadShipBtn, Me.ToolStripSeparator1, Me.PrintShipBtn, Me.ToolStripSeparator2, Me.NewShipBtn, Me.ToolStripSeparator3, Me.RedrawBtn, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(952, 25)
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
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = Global.nms_freighter_planner.My.Resources.Resources.HelpApplication_16x
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton2.Text = "About"
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
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonLeft, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CurrentItemPicture, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(777, 117)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(144, 48)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'CurrentItemPicture
        '
        Me.CurrentItemPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CurrentItemPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurrentItemPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrentItemPicture.Location = New System.Drawing.Point(48, 0)
        Me.CurrentItemPicture.Margin = New System.Windows.Forms.Padding(0)
        Me.CurrentItemPicture.Name = "CurrentItemPicture"
        Me.CurrentItemPicture.Size = New System.Drawing.Size(48, 48)
        Me.CurrentItemPicture.TabIndex = 5
        Me.CurrentItemPicture.TabStop = False
        Me.CurrentItemPicture.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(735, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 468)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elements"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton4, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton5, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton7, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton8, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton9, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton10, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton11, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton12, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton13, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton14, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton15, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton16, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton17, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton18, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton19, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton20, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 2, 5)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(195, 440)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.empty
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton1.Location = New System.Drawing.Point(0, 0)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton1.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.RadioButton1, "Empty Space")
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton2.Location = New System.Drawing.Point(38, 0)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton2.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.RadioButton2, "Freighter Room")
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton3.Location = New System.Drawing.Point(76, 0)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton3.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.RadioButton3, "Fleet Command Room")
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton4.Location = New System.Drawing.Point(114, 0)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton4.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.RadioButton4, "Orbital Exocraft Room")
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton5.Location = New System.Drawing.Point(152, 0)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.stairs
        Me.RadioButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton6.Location = New System.Drawing.Point(0, 38)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton6.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.RadioButton6, "Stairs Up")
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.corridor_str
        Me.RadioButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton7.Location = New System.Drawing.Point(38, 38)
        Me.RadioButton7.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton7.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.RadioButton7, "Corridor 2 Way")
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.corridor_u
        Me.RadioButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton8.Location = New System.Drawing.Point(76, 38)
        Me.RadioButton8.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton8.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.RadioButton8, "Corridor Curved")
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.corridor_t
        Me.RadioButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton9.Location = New System.Drawing.Point(114, 38)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton9.TabIndex = 8
        Me.ToolTip.SetToolTip(Me.RadioButton9, "Corridor Junction")
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.corridor_square
        Me.RadioButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton10.Location = New System.Drawing.Point(152, 38)
        Me.RadioButton10.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton10.TabIndex = 9
        Me.ToolTip.SetToolTip(Me.RadioButton10, "Corridor Cross")
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton11.Location = New System.Drawing.Point(0, 76)
        Me.RadioButton11.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton11.TabIndex = 10
        Me.ToolTip.SetToolTip(Me.RadioButton11, "Storage Room 0")
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton12.Location = New System.Drawing.Point(38, 76)
        Me.RadioButton12.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton12.TabIndex = 11
        Me.ToolTip.SetToolTip(Me.RadioButton12, "Storage Room 1")
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton13.Location = New System.Drawing.Point(76, 76)
        Me.RadioButton13.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton13.TabIndex = 12
        Me.ToolTip.SetToolTip(Me.RadioButton13, "Storage Room 2")
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton14.Location = New System.Drawing.Point(114, 76)
        Me.RadioButton14.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton14.TabIndex = 13
        Me.ToolTip.SetToolTip(Me.RadioButton14, "Storage Room 3")
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton15.Location = New System.Drawing.Point(152, 76)
        Me.RadioButton15.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton15.TabIndex = 14
        Me.ToolTip.SetToolTip(Me.RadioButton15, "Storage Room 4")
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton16.Location = New System.Drawing.Point(0, 114)
        Me.RadioButton16.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton16.TabIndex = 15
        Me.ToolTip.SetToolTip(Me.RadioButton16, "Storage Room 5")
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton17.Location = New System.Drawing.Point(38, 114)
        Me.RadioButton17.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton17.TabIndex = 16
        Me.ToolTip.SetToolTip(Me.RadioButton17, "Storage Room 6")
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton18.Location = New System.Drawing.Point(76, 114)
        Me.RadioButton18.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton18.TabIndex = 17
        Me.ToolTip.SetToolTip(Me.RadioButton18, "Storage Room 7")
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton19
        '
        Me.RadioButton19.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton19.Location = New System.Drawing.Point(114, 114)
        Me.RadioButton19.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton19.TabIndex = 18
        Me.ToolTip.SetToolTip(Me.RadioButton19, "Storage Room 8")
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.BackgroundImage = Global.nms_freighter_planner.My.Resources.Resources.room_noconnection
        Me.RadioButton20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioButton20.Location = New System.Drawing.Point(152, 114)
        Me.RadioButton20.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(38, 38)
        Me.RadioButton20.TabIndex = 19
        Me.ToolTip.SetToolTip(Me.RadioButton20, "Storage Room 9")
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "02"
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
        Me.TestBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TestBox.Enabled = False
        Me.TestBox.Location = New System.Drawing.Point(777, 168)
        Me.TestBox.Name = "TestBox"
        Me.TestBox.Size = New System.Drawing.Size(144, 23)
        Me.TestBox.TabIndex = 13
        Me.TestBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 767)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents TestBox As TextBox
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents CurrentItemPicture As Button
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
