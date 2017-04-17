<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HotspotFitting
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.ImportLabel = New System.Windows.Forms.Label()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ImportdataTextBox = New System.Windows.Forms.TextBox()
        Me.OpticalLabel = New System.Windows.Forms.Label()
        Me.rowTextBox = New System.Windows.Forms.TextBox()
        Me.rowLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReSampleButton = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FittingLabel = New System.Windows.Forms.Label()
        Me.FittingButton1 = New System.Windows.Forms.Button()
        Me.FittingButton2 = New System.Windows.Forms.Button()
        Me.FittingButton3 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.SmoothLabel = New System.Windows.Forms.Label()
        Me.TrackbarValueTextBox = New System.Windows.Forms.TextBox()
        Me.zeroLabel = New System.Windows.Forms.Label()
        Me.bonusLabel = New System.Windows.Forms.Label()
        Me.bluLabel = New System.Windows.Forms.Label()
        Me.BluwidthTextBox = New System.Windows.Forms.TextBox()
        Me.LEDnumberTextBox = New System.Windows.Forms.TextBox()
        Me.LEDnumLabel = New System.Windows.Forms.Label()
        Me.LEDpitchLabel = New System.Windows.Forms.Label()
        Me.LEDpitchTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.OutputAddPButton = New System.Windows.Forms.Button()
        Me.controlLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OutputMinusPButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImportLabel
        '
        Me.ImportLabel.AutoSize = True
        Me.ImportLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportLabel.Location = New System.Drawing.Point(9, 15)
        Me.ImportLabel.Name = "ImportLabel"
        Me.ImportLabel.Size = New System.Drawing.Size(132, 17)
        Me.ImportLabel.TabIndex = 3
        Me.ImportLabel.Text = "Import Optical Data"
        '
        'ImportButton
        '
        Me.ImportButton.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportButton.Location = New System.Drawing.Point(609, 8)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(75, 32)
        Me.ImportButton.TabIndex = 5
        Me.ImportButton.Text = "Import"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImportdataTextBox
        '
        Me.ImportdataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImportdataTextBox.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportdataTextBox.Location = New System.Drawing.Point(142, 13)
        Me.ImportdataTextBox.Name = "ImportdataTextBox"
        Me.ImportdataTextBox.Size = New System.Drawing.Size(461, 23)
        Me.ImportdataTextBox.TabIndex = 6
        '
        'OpticalLabel
        '
        Me.OpticalLabel.AutoSize = True
        Me.OpticalLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpticalLabel.Location = New System.Drawing.Point(6, 18)
        Me.OpticalLabel.Name = "OpticalLabel"
        Me.OpticalLabel.Size = New System.Drawing.Size(176, 17)
        Me.OpticalLabel.TabIndex = 7
        Me.OpticalLabel.Text = "Optical Data(Hotspot Side)"
        '
        'rowTextBox
        '
        Me.rowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rowTextBox.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowTextBox.Location = New System.Drawing.Point(221, 16)
        Me.rowTextBox.Name = "rowTextBox"
        Me.rowTextBox.Size = New System.Drawing.Size(41, 23)
        Me.rowTextBox.TabIndex = 12
        Me.rowTextBox.Text = "8"
        Me.rowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rowLabel
        '
        Me.rowLabel.AutoSize = True
        Me.rowLabel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rowLabel.Location = New System.Drawing.Point(265, 19)
        Me.rowLabel.Name = "rowLabel"
        Me.rowLabel.Size = New System.Drawing.Size(38, 15)
        Me.rowLabel.TabIndex = 13
        Me.rowLabel.Text = "Rows"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 18
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(923, 237)
        Me.DataGridView1.TabIndex = 14
        '
        'ReSampleButton
        '
        Me.ReSampleButton.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReSampleButton.Location = New System.Drawing.Point(311, 15)
        Me.ReSampleButton.Name = "ReSampleButton"
        Me.ReSampleButton.Size = New System.Drawing.Size(75, 23)
        Me.ReSampleButton.TabIndex = 16
        Me.ReSampleButton.Text = "ReSample"
        Me.ReSampleButton.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea6.AxisY.Interval = 10.0R
        ChartArea6.AxisY.Maximum = 110.0R
        ChartArea6.AxisY.Minimum = 55.0R
        ChartArea6.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea6)
        Me.Chart1.Location = New System.Drawing.Point(11, 449)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(923, 359)
        Me.Chart1.TabIndex = 17
        '
        'FittingLabel
        '
        Me.FittingLabel.AutoSize = True
        Me.FittingLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FittingLabel.Location = New System.Drawing.Point(10, 18)
        Me.FittingLabel.Name = "FittingLabel"
        Me.FittingLabel.Size = New System.Drawing.Size(89, 17)
        Me.FittingLabel.TabIndex = 18
        Me.FittingLabel.Text = "Fitting Select"
        '
        'FittingButton1
        '
        Me.FittingButton1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FittingButton1.Location = New System.Drawing.Point(122, 14)
        Me.FittingButton1.Name = "FittingButton1"
        Me.FittingButton1.Size = New System.Drawing.Size(96, 26)
        Me.FittingButton1.TabIndex = 19
        Me.FittingButton1.Text = "Upper Fitting"
        Me.FittingButton1.UseVisualStyleBackColor = True
        '
        'FittingButton2
        '
        Me.FittingButton2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FittingButton2.Location = New System.Drawing.Point(234, 14)
        Me.FittingButton2.Name = "FittingButton2"
        Me.FittingButton2.Size = New System.Drawing.Size(96, 26)
        Me.FittingButton2.TabIndex = 20
        Me.FittingButton2.Text = "Middle Fitting"
        Me.FittingButton2.UseVisualStyleBackColor = True
        '
        'FittingButton3
        '
        Me.FittingButton3.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FittingButton3.Location = New System.Drawing.Point(344, 14)
        Me.FittingButton3.Name = "FittingButton3"
        Me.FittingButton3.Size = New System.Drawing.Size(96, 26)
        Me.FittingButton3.TabIndex = 21
        Me.FittingButton3.Text = "Lower Fitting"
        Me.FittingButton3.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 1
        Me.TrackBar1.Location = New System.Drawing.Point(155, 54)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(274, 42)
        Me.TrackBar1.TabIndex = 22
        '
        'SmoothLabel
        '
        Me.SmoothLabel.AutoSize = True
        Me.SmoothLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SmoothLabel.Location = New System.Drawing.Point(10, 64)
        Me.SmoothLabel.Name = "SmoothLabel"
        Me.SmoothLabel.Size = New System.Drawing.Size(112, 17)
        Me.SmoothLabel.TabIndex = 24
        Me.SmoothLabel.Text = "Smoothing Value"
        '
        'TrackbarValueTextBox
        '
        Me.TrackbarValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TrackbarValueTextBox.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackbarValueTextBox.Location = New System.Drawing.Point(124, 62)
        Me.TrackbarValueTextBox.Name = "TrackbarValueTextBox"
        Me.TrackbarValueTextBox.Size = New System.Drawing.Size(25, 25)
        Me.TrackbarValueTextBox.TabIndex = 25
        Me.TrackbarValueTextBox.Text = "0"
        Me.TrackbarValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'zeroLabel
        '
        Me.zeroLabel.AutoSize = True
        Me.zeroLabel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zeroLabel.Location = New System.Drawing.Point(162, 86)
        Me.zeroLabel.Name = "zeroLabel"
        Me.zeroLabel.Size = New System.Drawing.Size(14, 15)
        Me.zeroLabel.TabIndex = 27
        Me.zeroLabel.Text = "0"
        '
        'bonusLabel
        '
        Me.bonusLabel.AutoSize = True
        Me.bonusLabel.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bonusLabel.Location = New System.Drawing.Point(405, 85)
        Me.bonusLabel.Name = "bonusLabel"
        Me.bonusLabel.Size = New System.Drawing.Size(21, 15)
        Me.bonusLabel.TabIndex = 28
        Me.bonusLabel.Text = "10"
        '
        'bluLabel
        '
        Me.bluLabel.AutoSize = True
        Me.bluLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bluLabel.Location = New System.Drawing.Point(7, 18)
        Me.bluLabel.Name = "bluLabel"
        Me.bluLabel.Size = New System.Drawing.Size(75, 17)
        Me.bluLabel.TabIndex = 30
        Me.bluLabel.Text = "BLU width"
        '
        'BluwidthTextBox
        '
        Me.BluwidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BluwidthTextBox.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BluwidthTextBox.Location = New System.Drawing.Point(84, 16)
        Me.BluwidthTextBox.Name = "BluwidthTextBox"
        Me.BluwidthTextBox.Size = New System.Drawing.Size(70, 23)
        Me.BluwidthTextBox.TabIndex = 31
        Me.BluwidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LEDnumberTextBox
        '
        Me.LEDnumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LEDnumberTextBox.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEDnumberTextBox.Location = New System.Drawing.Point(252, 16)
        Me.LEDnumberTextBox.Name = "LEDnumberTextBox"
        Me.LEDnumberTextBox.Size = New System.Drawing.Size(34, 23)
        Me.LEDnumberTextBox.TabIndex = 33
        Me.LEDnumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LEDnumLabel
        '
        Me.LEDnumLabel.AutoSize = True
        Me.LEDnumLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEDnumLabel.Location = New System.Drawing.Point(164, 18)
        Me.LEDnumLabel.Name = "LEDnumLabel"
        Me.LEDnumLabel.Size = New System.Drawing.Size(87, 17)
        Me.LEDnumLabel.TabIndex = 32
        Me.LEDnumLabel.Text = "LED number"
        '
        'LEDpitchLabel
        '
        Me.LEDpitchLabel.AutoSize = True
        Me.LEDpitchLabel.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEDpitchLabel.Location = New System.Drawing.Point(299, 18)
        Me.LEDpitchLabel.Name = "LEDpitchLabel"
        Me.LEDpitchLabel.Size = New System.Drawing.Size(70, 17)
        Me.LEDpitchLabel.TabIndex = 34
        Me.LEDpitchLabel.Text = "LED pitch"
        '
        'LEDpitchTextBox
        '
        Me.LEDpitchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LEDpitchTextBox.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEDpitchTextBox.Location = New System.Drawing.Point(370, 16)
        Me.LEDpitchTextBox.Name = "LEDpitchTextBox"
        Me.LEDpitchTextBox.Size = New System.Drawing.Size(66, 23)
        Me.LEDpitchTextBox.TabIndex = 35
        Me.LEDpitchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(10, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(186, 21)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Bright Area front the LED"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(228, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(208, 21)
        Me.CheckBox2.TabIndex = 37
        Me.CheckBox2.Text = "Bright Area between the LED"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'OutputAddPButton
        '
        Me.OutputAddPButton.Enabled = False
        Me.OutputAddPButton.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputAddPButton.Location = New System.Drawing.Point(634, 814)
        Me.OutputAddPButton.Name = "OutputAddPButton"
        Me.OutputAddPButton.Size = New System.Drawing.Size(141, 27)
        Me.OutputAddPButton.TabIndex = 38
        Me.OutputAddPButton.Text = "Output Add Points"
        Me.OutputAddPButton.UseVisualStyleBackColor = True
        '
        'controlLabel
        '
        Me.controlLabel.AutoSize = True
        Me.controlLabel.Location = New System.Drawing.Point(15, 817)
        Me.controlLabel.Name = "controlLabel"
        Me.controlLabel.Size = New System.Drawing.Size(37, 12)
        Me.controlLabel.TabIndex = 39
        Me.controlLabel.Text = "Label1"
        Me.controlLabel.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OpticalLabel)
        Me.GroupBox1.Controls.Add(Me.rowTextBox)
        Me.GroupBox1.Controls.Add(Me.rowLabel)
        Me.GroupBox1.Controls.Add(Me.ReSampleButton)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 49)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.bonusLabel)
        Me.GroupBox2.Controls.Add(Me.zeroLabel)
        Me.GroupBox2.Controls.Add(Me.FittingLabel)
        Me.GroupBox2.Controls.Add(Me.FittingButton1)
        Me.GroupBox2.Controls.Add(Me.FittingButton2)
        Me.GroupBox2.Controls.Add(Me.FittingButton3)
        Me.GroupBox2.Controls.Add(Me.SmoothLabel)
        Me.GroupBox2.Controls.Add(Me.TrackbarValueTextBox)
        Me.GroupBox2.Controls.Add(Me.TrackBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 106)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bluLabel)
        Me.GroupBox3.Controls.Add(Me.BluwidthTextBox)
        Me.GroupBox3.Controls.Add(Me.LEDnumLabel)
        Me.GroupBox3.Controls.Add(Me.LEDnumberTextBox)
        Me.GroupBox3.Controls.Add(Me.LEDpitchLabel)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.LEDpitchTextBox)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(482, 335)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 106)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        '
        'OutputMinusPButton
        '
        Me.OutputMinusPButton.Enabled = False
        Me.OutputMinusPButton.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputMinusPButton.Location = New System.Drawing.Point(784, 814)
        Me.OutputMinusPButton.Name = "OutputMinusPButton"
        Me.OutputMinusPButton.Size = New System.Drawing.Size(151, 27)
        Me.OutputMinusPButton.TabIndex = 43
        Me.OutputMinusPButton.Text = "Output Minus Points"
        Me.OutputMinusPButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 817)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 44
        Me.Label1.Visible = False
        '
        'HotspotFitting
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 846)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OutputMinusPButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.controlLabel)
        Me.Controls.Add(Me.OutputAddPButton)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ImportdataTextBox)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.ImportLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "HotspotFitting"
        Me.Text = "Hotspot Fitting"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImportLabel As System.Windows.Forms.Label
    Friend WithEvents ImportButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImportdataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpticalLabel As System.Windows.Forms.Label
    Friend WithEvents rowTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rowLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReSampleButton As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents FittingLabel As System.Windows.Forms.Label
    Friend WithEvents FittingButton1 As System.Windows.Forms.Button
    Friend WithEvents FittingButton2 As System.Windows.Forms.Button
    Friend WithEvents FittingButton3 As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents SmoothLabel As System.Windows.Forms.Label
    Friend WithEvents TrackbarValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents zeroLabel As System.Windows.Forms.Label
    Friend WithEvents bonusLabel As System.Windows.Forms.Label
    Friend WithEvents bluLabel As System.Windows.Forms.Label
    Friend WithEvents LEDnumLabel As System.Windows.Forms.Label
    Friend WithEvents LEDpitchLabel As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents OutputAddPButton As System.Windows.Forms.Button
    Friend WithEvents controlLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OutputMinusPButton As System.Windows.Forms.Button
    Public WithEvents BluwidthTextBox As System.Windows.Forms.TextBox
    Public WithEvents LEDnumberTextBox As System.Windows.Forms.TextBox
    Public WithEvents LEDpitchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
