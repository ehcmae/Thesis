<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetNOISE = New NoiseDetect.DataSetNOISE()
        Me.rvNoise = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetNOISE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSetNOISE
        '
        'DataSetNOISE
        '
        Me.DataSetNOISE.DataSetName = "DataSetNOISE"
        Me.DataSetNOISE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvNoise
        '
        Me.rvNoise.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSetNOISE"
        ReportDataSource2.Value = Me.DataTable1BindingSource
        Me.rvNoise.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvNoise.LocalReport.ReportEmbeddedResource = "NoiseDetect.Report1.rdlc"
        Me.rvNoise.Location = New System.Drawing.Point(0, 0)
        Me.rvNoise.Name = "rvNoise"
        Me.rvNoise.Size = New System.Drawing.Size(654, 451)
        Me.rvNoise.TabIndex = 0
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 451)
        Me.Controls.Add(Me.rvNoise)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetNOISE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvNoise As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetNOISE As NoiseDetect.DataSetNOISE
End Class
