<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLog
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STATToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTIVITYLOGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STATToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.act_timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.log_message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.source = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbLog = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.act_timestamp, Me.type, Me.log_message, Me.source})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(667, 230)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STATToolStripMenuItem, Me.ACTIVITYLOGToolStripMenuItem, Me.STATToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(691, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STATToolStripMenuItem
        '
        Me.STATToolStripMenuItem.Name = "STATToolStripMenuItem"
        Me.STATToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.STATToolStripMenuItem.Text = "SETTINGS"
        '
        'ACTIVITYLOGToolStripMenuItem
        '
        Me.ACTIVITYLOGToolStripMenuItem.Name = "ACTIVITYLOGToolStripMenuItem"
        Me.ACTIVITYLOGToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ACTIVITYLOGToolStripMenuItem.Text = "ACTIVITY LOG"
        '
        'STATToolStripMenuItem1
        '
        Me.STATToolStripMenuItem1.Name = "STATToolStripMenuItem1"
        Me.STATToolStripMenuItem1.Size = New System.Drawing.Size(45, 20)
        Me.STATToolStripMenuItem1.Text = "STAT"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Activity Log"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(54, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "--"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(278, 101)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Log:"
        '
        'cbLog
        '
        Me.cbLog.FormattingEnabled = True
        Me.cbLog.Location = New System.Drawing.Point(539, 101)
        Me.cbLog.Name = "cbLog"
        Me.cbLog.Size = New System.Drawing.Size(140, 21)
        Me.cbLog.TabIndex = 17
        '
        'ActivityLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 370)
        Me.Controls.Add(Me.cbLog)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ActivityLog"
        Me.Text = "ActivityLog"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents STATToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACTIVITYLOGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STATToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents act_timestamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents log_message As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbLog As System.Windows.Forms.ComboBox
End Class
