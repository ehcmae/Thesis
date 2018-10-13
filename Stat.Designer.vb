<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stat
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stat))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbLog = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.act_timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.log_message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdAll = New System.Windows.Forms.RadioButton()
        Me.rdCustom = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnViewChart = New System.Windows.Forms.Button()
        Me.dateAlarm2 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dateAlarm1 = New System.Windows.Forms.DateTimePicker()
        Me.rdCustomAlarm = New System.Windows.Forms.RadioButton()
        Me.rdAllAlarm = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.cbReport = New System.Windows.Forms.ComboBox()
        Me.btnExportLog = New System.Windows.Forms.Button()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.menuSettings = New System.Windows.Forms.PictureBox()
        Me.menuExit = New System.Windows.Forms.PictureBox()
        Me.menuDashboard = New System.Windows.Forms.PictureBox()
        Me.menuMonitor = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.menuSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX2.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY2.MajorGrid.Enabled = False
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(614, 112)
        Me.Chart1.Name = "Chart1"
        Series1.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(222, Byte), Integer))
        Series1.BorderColor = System.Drawing.Color.Black
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Color = System.Drawing.Color.SeaGreen
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "count"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(465, 165)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'cbLog
        '
        Me.cbLog.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLog.FormattingEnabled = True
        Me.cbLog.Location = New System.Drawing.Point(731, 327)
        Me.cbLog.Name = "cbLog"
        Me.cbLog.Size = New System.Drawing.Size(215, 28)
        Me.cbLog.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(637, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Log:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(731, 387)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(215, 27)
        Me.DateTimePicker2.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(654, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "--"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(731, 359)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 27)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(637, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 28)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Date:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(614, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(465, 44)
        Me.Label7.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.act_timestamp, Me.type, Me.log_message, Me.source})
        Me.DataGridView1.Location = New System.Drawing.Point(614, 418)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(458, 149)
        Me.DataGridView1.TabIndex = 18
        '
        'act_timestamp
        '
        Me.act_timestamp.DataPropertyName = "act_timestamp"
        Me.act_timestamp.HeaderText = "TIMESTAMP"
        Me.act_timestamp.Name = "act_timestamp"
        Me.act_timestamp.ReadOnly = True
        '
        'type
        '
        Me.type.DataPropertyName = "type"
        Me.type.HeaderText = "TYPE"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'log_message
        '
        Me.log_message.DataPropertyName = "log_message"
        Me.log_message.HeaderText = "LOG MESSAGE"
        Me.log_message.Name = "log_message"
        Me.log_message.ReadOnly = True
        '
        'source
        '
        Me.source.DataPropertyName = "source"
        Me.source.HeaderText = "SOURCE"
        Me.source.Name = "source"
        Me.source.ReadOnly = True
        '
        'rdAll
        '
        Me.rdAll.AutoSize = True
        Me.rdAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rdAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAll.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rdAll.Location = New System.Drawing.Point(901, 290)
        Me.rdAll.Name = "rdAll"
        Me.rdAll.Size = New System.Drawing.Size(45, 24)
        Me.rdAll.TabIndex = 28
        Me.rdAll.TabStop = True
        Me.rdAll.Text = "All"
        Me.rdAll.UseVisualStyleBackColor = False
        '
        'rdCustom
        '
        Me.rdCustom.AutoSize = True
        Me.rdCustom.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rdCustom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCustom.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rdCustom.Location = New System.Drawing.Point(959, 290)
        Me.rdCustom.Name = "rdCustom"
        Me.rdCustom.Size = New System.Drawing.Size(113, 24)
        Me.rdCustom.TabIndex = 29
        Me.rdCustom.TabStop = True
        Me.rdCustom.Text = "Custom Date"
        Me.rdCustom.UseVisualStyleBackColor = False
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGo.Enabled = False
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGo.Location = New System.Drawing.Point(997, 327)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 48)
        Me.btnGo.TabIndex = 30
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnViewChart
        '
        Me.btnViewChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewChart.Enabled = False
        Me.btnViewChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnViewChart.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewChart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewChart.Location = New System.Drawing.Point(786, 71)
        Me.btnViewChart.Name = "btnViewChart"
        Me.btnViewChart.Size = New System.Drawing.Size(76, 28)
        Me.btnViewChart.TabIndex = 35
        Me.btnViewChart.Text = "View Chart"
        Me.btnViewChart.UseVisualStyleBackColor = False
        '
        'dateAlarm2
        '
        Me.dateAlarm2.Enabled = False
        Me.dateAlarm2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAlarm2.Location = New System.Drawing.Point(582, 71)
        Me.dateAlarm2.Name = "dateAlarm2"
        Me.dateAlarm2.Size = New System.Drawing.Size(198, 27)
        Me.dateAlarm2.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label13.Location = New System.Drawing.Point(565, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "--"
        '
        'dateAlarm1
        '
        Me.dateAlarm1.Enabled = False
        Me.dateAlarm1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAlarm1.Location = New System.Drawing.Point(365, 71)
        Me.dateAlarm1.Name = "dateAlarm1"
        Me.dateAlarm1.Size = New System.Drawing.Size(198, 27)
        Me.dateAlarm1.TabIndex = 32
        '
        'rdCustomAlarm
        '
        Me.rdCustomAlarm.AutoSize = True
        Me.rdCustomAlarm.BackColor = System.Drawing.Color.White
        Me.rdCustomAlarm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCustomAlarm.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rdCustomAlarm.Location = New System.Drawing.Point(93, 32)
        Me.rdCustomAlarm.Name = "rdCustomAlarm"
        Me.rdCustomAlarm.Size = New System.Drawing.Size(113, 24)
        Me.rdCustomAlarm.TabIndex = 38
        Me.rdCustomAlarm.TabStop = True
        Me.rdCustomAlarm.Text = "Custom Date"
        Me.rdCustomAlarm.UseVisualStyleBackColor = False
        '
        'rdAllAlarm
        '
        Me.rdAllAlarm.AutoSize = True
        Me.rdAllAlarm.BackColor = System.Drawing.Color.White
        Me.rdAllAlarm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdAllAlarm.ForeColor = System.Drawing.SystemColors.InfoText
        Me.rdAllAlarm.Location = New System.Drawing.Point(37, 32)
        Me.rdAllAlarm.Name = "rdAllAlarm"
        Me.rdAllAlarm.Size = New System.Drawing.Size(45, 24)
        Me.rdAllAlarm.TabIndex = 37
        Me.rdAllAlarm.TabStop = True
        Me.rdAllAlarm.Text = "All"
        Me.rdAllAlarm.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(128, -13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(951, 64)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(3, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 50)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = " DASHBOARD"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblMessage.Location = New System.Drawing.Point(17, 5)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(59, 20)
        Me.lblMessage.TabIndex = 48
        Me.lblMessage.Text = "Label22"
        '
        'cbReport
        '
        Me.cbReport.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReport.FormattingEnabled = True
        Me.cbReport.Items.AddRange(New Object() {"Report", "Print This Chart", "Generate Tabular Report"})
        Me.cbReport.Location = New System.Drawing.Point(868, 71)
        Me.cbReport.Name = "cbReport"
        Me.cbReport.Size = New System.Drawing.Size(204, 28)
        Me.cbReport.TabIndex = 71
        '
        'btnExportLog
        '
        Me.btnExportLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExportLog.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExportLog.Location = New System.Drawing.Point(997, 381)
        Me.btnExportLog.Name = "btnExportLog"
        Me.btnExportLog.Size = New System.Drawing.Size(75, 31)
        Me.btnExportLog.TabIndex = 72
        Me.btnExportLog.Text = "Export"
        Me.btnExportLog.UseVisualStyleBackColor = False
        '
        'Chart2
        '
        Me.Chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.BackSecondaryColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(130, 112)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Day"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(477, 455)
        Me.Chart2.TabIndex = 73
        Me.Chart2.Text = "Chart2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Location = New System.Drawing.Point(130, 572)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(949, 36)
        Me.Panel1.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdAllAlarm)
        Me.GroupBox1.Controls.Add(Me.rdCustomAlarm)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 91)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(614, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 44)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = " ACTIVITY LOG"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.menuSettings)
        Me.Panel2.Controls.Add(Me.menuExit)
        Me.Panel2.Controls.Add(Me.menuDashboard)
        Me.Panel2.Controls.Add(Me.menuMonitor)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(142, 609)
        Me.Panel2.TabIndex = 78
        '
        'menuSettings
        '
        Me.menuSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.menuSettings.BackgroundImage = CType(resources.GetObject("menuSettings.BackgroundImage"), System.Drawing.Image)
        Me.menuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuSettings.Location = New System.Drawing.Point(31, 313)
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Size = New System.Drawing.Size(80, 78)
        Me.menuSettings.TabIndex = 48
        Me.menuSettings.TabStop = False
        '
        'menuExit
        '
        Me.menuExit.BackgroundImage = CType(resources.GetObject("menuExit.BackgroundImage"), System.Drawing.Image)
        Me.menuExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuExit.Location = New System.Drawing.Point(31, 423)
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(80, 78)
        Me.menuExit.TabIndex = 48
        Me.menuExit.TabStop = False
        '
        'menuDashboard
        '
        Me.menuDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.menuDashboard.BackgroundImage = CType(resources.GetObject("menuDashboard.BackgroundImage"), System.Drawing.Image)
        Me.menuDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuDashboard.Location = New System.Drawing.Point(31, 203)
        Me.menuDashboard.Name = "menuDashboard"
        Me.menuDashboard.Size = New System.Drawing.Size(80, 78)
        Me.menuDashboard.TabIndex = 48
        Me.menuDashboard.TabStop = False
        '
        'menuMonitor
        '
        Me.menuMonitor.BackgroundImage = CType(resources.GetObject("menuMonitor.BackgroundImage"), System.Drawing.Image)
        Me.menuMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuMonitor.Location = New System.Drawing.Point(31, 91)
        Me.menuMonitor.Name = "menuMonitor"
        Me.menuMonitor.Size = New System.Drawing.Size(80, 78)
        Me.menuMonitor.TabIndex = 48
        Me.menuMonitor.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 203)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 78)
        Me.Panel4.TabIndex = 50
        '
        'Stat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1078, 601)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.btnExportLog)
        Me.Controls.Add(Me.cbReport)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnViewChart)
        Me.Controls.Add(Me.dateAlarm2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dateAlarm1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.rdCustom)
        Me.Controls.Add(Me.rdAll)
        Me.Controls.Add(Me.cbLog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Stat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.menuSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cbLog As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents act_timestamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents log_message As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rdAll As System.Windows.Forms.RadioButton
    Friend WithEvents rdCustom As System.Windows.Forms.RadioButton
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnViewChart As System.Windows.Forms.Button
    Friend WithEvents dateAlarm2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dateAlarm1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rdCustomAlarm As System.Windows.Forms.RadioButton
    Friend WithEvents rdAllAlarm As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents cbReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnExportLog As System.Windows.Forms.Button
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents menuSettings As System.Windows.Forms.PictureBox
    Friend WithEvents menuExit As System.Windows.Forms.PictureBox
    Friend WithEvents menuDashboard As System.Windows.Forms.PictureBox
    Friend WithEvents menuMonitor As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
