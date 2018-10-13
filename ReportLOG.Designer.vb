<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportLOG
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
        Me.rvLog = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvLog
        '
        Me.rvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvLog.Location = New System.Drawing.Point(0, 0)
        Me.rvLog.Name = "rvLog"
        Me.rvLog.Size = New System.Drawing.Size(547, 378)
        Me.rvLog.TabIndex = 0
        '
        'ReportLOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 378)
        Me.Controls.Add(Me.rvLog)
        Me.Name = "ReportLOG"
        Me.Text = "Acitvity Log Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvLog As Microsoft.Reporting.WinForms.ReportViewer
End Class
