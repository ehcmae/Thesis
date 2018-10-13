<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoiseDetector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoiseDetector))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.cbPort = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.groupLibStructure = New System.Windows.Forms.GroupBox()
        Me.divider = New System.Windows.Forms.PictureBox()
        Me.opac = New System.Windows.Forms.PictureBox()
        Me.bookssection1 = New System.Windows.Forms.PictureBox()
        Me.bookssection2 = New System.Windows.Forms.PictureBox()
        Me.table8 = New System.Windows.Forms.PictureBox()
        Me.table7 = New System.Windows.Forms.PictureBox()
        Me.table6 = New System.Windows.Forms.PictureBox()
        Me.librarian3 = New System.Windows.Forms.PictureBox()
        Me.table5 = New System.Windows.Forms.PictureBox()
        Me.table4 = New System.Windows.Forms.PictureBox()
        Me.table1 = New System.Windows.Forms.PictureBox()
        Me.table2 = New System.Windows.Forms.PictureBox()
        Me.table3 = New System.Windows.Forms.PictureBox()
        Me.bookshelf1 = New System.Windows.Forms.PictureBox()
        Me.librarian1 = New System.Windows.Forms.PictureBox()
        Me.table10 = New System.Windows.Forms.PictureBox()
        Me.table9 = New System.Windows.Forms.PictureBox()
        Me.logtable = New System.Windows.Forms.PictureBox()
        Me.thesaurus = New System.Windows.Forms.PictureBox()
        Me.pcsection = New System.Windows.Forms.PictureBox()
        Me.bookshelf2 = New System.Windows.Forms.PictureBox()
        Me.librarian2 = New System.Windows.Forms.PictureBox()
        Me.baggagecounter = New System.Windows.Forms.PictureBox()
        Me.door = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnSaveUI = New System.Windows.Forms.Button()
        Me.checkMoveObjects = New System.Windows.Forms.CheckBox()
        Me.btnCancelUI = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.PictureBox()
        Me.btnDisconnect = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menuSettings = New System.Windows.Forms.PictureBox()
        Me.menuExit = New System.Windows.Forms.PictureBox()
        Me.menuDashboard = New System.Windows.Forms.PictureBox()
        Me.menuMonitor = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.groupLibStructure.SuspendLayout()
        CType(Me.divider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookssection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookssection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.librarian3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookshelf1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.librarian1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logtable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thesaurus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcsection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookshelf2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.librarian2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baggagecounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConnect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDisconnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.menuSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'cbPort
        '
        Me.cbPort.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPort.FormattingEnabled = True
        Me.cbPort.Location = New System.Drawing.Point(92, 12)
        Me.cbPort.Name = "cbPort"
        Me.cbPort.Size = New System.Drawing.Size(161, 28)
        Me.cbPort.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "COM port:"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'groupLibStructure
        '
        Me.groupLibStructure.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.groupLibStructure.Controls.Add(Me.divider)
        Me.groupLibStructure.Controls.Add(Me.opac)
        Me.groupLibStructure.Controls.Add(Me.bookssection1)
        Me.groupLibStructure.Controls.Add(Me.bookssection2)
        Me.groupLibStructure.Controls.Add(Me.table8)
        Me.groupLibStructure.Controls.Add(Me.table7)
        Me.groupLibStructure.Controls.Add(Me.table6)
        Me.groupLibStructure.Controls.Add(Me.librarian3)
        Me.groupLibStructure.Controls.Add(Me.table5)
        Me.groupLibStructure.Controls.Add(Me.table4)
        Me.groupLibStructure.Controls.Add(Me.table1)
        Me.groupLibStructure.Controls.Add(Me.table2)
        Me.groupLibStructure.Controls.Add(Me.table3)
        Me.groupLibStructure.Controls.Add(Me.bookshelf1)
        Me.groupLibStructure.Controls.Add(Me.librarian1)
        Me.groupLibStructure.Controls.Add(Me.table10)
        Me.groupLibStructure.Controls.Add(Me.table9)
        Me.groupLibStructure.Controls.Add(Me.logtable)
        Me.groupLibStructure.Controls.Add(Me.thesaurus)
        Me.groupLibStructure.Controls.Add(Me.pcsection)
        Me.groupLibStructure.Controls.Add(Me.bookshelf2)
        Me.groupLibStructure.Controls.Add(Me.librarian2)
        Me.groupLibStructure.Controls.Add(Me.baggagecounter)
        Me.groupLibStructure.Controls.Add(Me.door)
        Me.groupLibStructure.Controls.Add(Me.Label20)
        Me.groupLibStructure.Enabled = False
        Me.groupLibStructure.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupLibStructure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.groupLibStructure.Location = New System.Drawing.Point(141, 69)
        Me.groupLibStructure.Name = "groupLibStructure"
        Me.groupLibStructure.Size = New System.Drawing.Size(1051, 430)
        Me.groupLibStructure.TabIndex = 13
        Me.groupLibStructure.TabStop = False
        '
        'divider
        '
        Me.divider.BackgroundImage = CType(resources.GetObject("divider.BackgroundImage"), System.Drawing.Image)
        Me.divider.Location = New System.Drawing.Point(32, 295)
        Me.divider.Name = "divider"
        Me.divider.Size = New System.Drawing.Size(125, 20)
        Me.divider.TabIndex = 48
        Me.divider.TabStop = False
        '
        'opac
        '
        Me.opac.BackColor = System.Drawing.Color.LemonChiffon
        Me.opac.BackgroundImage = CType(resources.GetObject("opac.BackgroundImage"), System.Drawing.Image)
        Me.opac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.opac.Location = New System.Drawing.Point(461, 36)
        Me.opac.Name = "opac"
        Me.opac.Size = New System.Drawing.Size(36, 29)
        Me.opac.TabIndex = 47
        Me.opac.TabStop = False
        '
        'bookssection1
        '
        Me.bookssection1.BackColor = System.Drawing.Color.Honeydew
        Me.bookssection1.BackgroundImage = CType(resources.GetObject("bookssection1.BackgroundImage"), System.Drawing.Image)
        Me.bookssection1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bookssection1.Location = New System.Drawing.Point(868, 37)
        Me.bookssection1.Name = "bookssection1"
        Me.bookssection1.Size = New System.Drawing.Size(126, 137)
        Me.bookssection1.TabIndex = 46
        Me.bookssection1.TabStop = False
        '
        'bookssection2
        '
        Me.bookssection2.BackColor = System.Drawing.Color.Honeydew
        Me.bookssection2.BackgroundImage = CType(resources.GetObject("bookssection2.BackgroundImage"), System.Drawing.Image)
        Me.bookssection2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bookssection2.Location = New System.Drawing.Point(868, 236)
        Me.bookssection2.Name = "bookssection2"
        Me.bookssection2.Size = New System.Drawing.Size(126, 137)
        Me.bookssection2.TabIndex = 20
        Me.bookssection2.TabStop = False
        '
        'table8
        '
        Me.table8.BackColor = System.Drawing.Color.Honeydew
        Me.table8.BackgroundImage = CType(resources.GetObject("table8.BackgroundImage"), System.Drawing.Image)
        Me.table8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table8.Location = New System.Drawing.Point(768, 36)
        Me.table8.Name = "table8"
        Me.table8.Size = New System.Drawing.Size(94, 54)
        Me.table8.TabIndex = 19
        Me.table8.TabStop = False
        '
        'table7
        '
        Me.table7.BackColor = System.Drawing.Color.Honeydew
        Me.table7.BackgroundImage = CType(resources.GetObject("table7.BackgroundImage"), System.Drawing.Image)
        Me.table7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table7.Location = New System.Drawing.Point(737, 133)
        Me.table7.Name = "table7"
        Me.table7.Size = New System.Drawing.Size(85, 101)
        Me.table7.TabIndex = 18
        Me.table7.TabStop = False
        '
        'table6
        '
        Me.table6.BackColor = System.Drawing.Color.Honeydew
        Me.table6.BackgroundImage = CType(resources.GetObject("table6.BackgroundImage"), System.Drawing.Image)
        Me.table6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table6.Location = New System.Drawing.Point(653, 133)
        Me.table6.Name = "table6"
        Me.table6.Size = New System.Drawing.Size(85, 101)
        Me.table6.TabIndex = 17
        Me.table6.TabStop = False
        '
        'librarian3
        '
        Me.librarian3.BackColor = System.Drawing.Color.Honeydew
        Me.librarian3.BackgroundImage = CType(resources.GetObject("librarian3.BackgroundImage"), System.Drawing.Image)
        Me.librarian3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.librarian3.Location = New System.Drawing.Point(503, 257)
        Me.librarian3.Name = "librarian3"
        Me.librarian3.Size = New System.Drawing.Size(225, 138)
        Me.librarian3.TabIndex = 16
        Me.librarian3.TabStop = False
        '
        'table5
        '
        Me.table5.BackColor = System.Drawing.Color.Honeydew
        Me.table5.BackgroundImage = CType(resources.GetObject("table5.BackgroundImage"), System.Drawing.Image)
        Me.table5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table5.Location = New System.Drawing.Point(572, 133)
        Me.table5.Name = "table5"
        Me.table5.Size = New System.Drawing.Size(85, 101)
        Me.table5.TabIndex = 15
        Me.table5.TabStop = False
        '
        'table4
        '
        Me.table4.BackColor = System.Drawing.Color.Honeydew
        Me.table4.BackgroundImage = CType(resources.GetObject("table4.BackgroundImage"), System.Drawing.Image)
        Me.table4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table4.Location = New System.Drawing.Point(488, 133)
        Me.table4.Name = "table4"
        Me.table4.Size = New System.Drawing.Size(85, 101)
        Me.table4.TabIndex = 14
        Me.table4.TabStop = False
        '
        'table1
        '
        Me.table1.BackColor = System.Drawing.Color.Honeydew
        Me.table1.BackgroundImage = CType(resources.GetObject("table1.BackgroundImage"), System.Drawing.Image)
        Me.table1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table1.Location = New System.Drawing.Point(333, 257)
        Me.table1.Name = "table1"
        Me.table1.Size = New System.Drawing.Size(100, 71)
        Me.table1.TabIndex = 13
        Me.table1.TabStop = False
        '
        'table2
        '
        Me.table2.BackColor = System.Drawing.Color.Honeydew
        Me.table2.BackgroundImage = CType(resources.GetObject("table2.BackgroundImage"), System.Drawing.Image)
        Me.table2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table2.Location = New System.Drawing.Point(333, 189)
        Me.table2.Name = "table2"
        Me.table2.Size = New System.Drawing.Size(100, 71)
        Me.table2.TabIndex = 12
        Me.table2.TabStop = False
        '
        'table3
        '
        Me.table3.BackColor = System.Drawing.Color.Honeydew
        Me.table3.BackgroundImage = CType(resources.GetObject("table3.BackgroundImage"), System.Drawing.Image)
        Me.table3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table3.Location = New System.Drawing.Point(333, 119)
        Me.table3.Name = "table3"
        Me.table3.Size = New System.Drawing.Size(100, 71)
        Me.table3.TabIndex = 11
        Me.table3.TabStop = False
        '
        'bookshelf1
        '
        Me.bookshelf1.BackColor = System.Drawing.Color.Honeydew
        Me.bookshelf1.BackgroundImage = CType(resources.GetObject("bookshelf1.BackgroundImage"), System.Drawing.Image)
        Me.bookshelf1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bookshelf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bookshelf1.Location = New System.Drawing.Point(309, 355)
        Me.bookshelf1.Name = "bookshelf1"
        Me.bookshelf1.Size = New System.Drawing.Size(146, 40)
        Me.bookshelf1.TabIndex = 10
        Me.bookshelf1.TabStop = False
        '
        'librarian1
        '
        Me.librarian1.BackColor = System.Drawing.Color.Honeydew
        Me.librarian1.BackgroundImage = CType(resources.GetObject("librarian1.BackgroundImage"), System.Drawing.Image)
        Me.librarian1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.librarian1.ErrorImage = CType(resources.GetObject("librarian1.ErrorImage"), System.Drawing.Image)
        Me.librarian1.Location = New System.Drawing.Point(162, 296)
        Me.librarian1.Name = "librarian1"
        Me.librarian1.Size = New System.Drawing.Size(130, 99)
        Me.librarian1.TabIndex = 9
        Me.librarian1.TabStop = False
        '
        'table10
        '
        Me.table10.BackColor = System.Drawing.Color.Honeydew
        Me.table10.BackgroundImage = CType(resources.GetObject("table10.BackgroundImage"), System.Drawing.Image)
        Me.table10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table10.Location = New System.Drawing.Point(210, 36)
        Me.table10.Name = "table10"
        Me.table10.Size = New System.Drawing.Size(100, 71)
        Me.table10.TabIndex = 8
        Me.table10.TabStop = False
        '
        'table9
        '
        Me.table9.BackColor = System.Drawing.Color.Honeydew
        Me.table9.BackgroundImage = CType(resources.GetObject("table9.BackgroundImage"), System.Drawing.Image)
        Me.table9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.table9.Location = New System.Drawing.Point(768, 341)
        Me.table9.Name = "table9"
        Me.table9.Size = New System.Drawing.Size(94, 54)
        Me.table9.TabIndex = 7
        Me.table9.TabStop = False
        '
        'logtable
        '
        Me.logtable.BackColor = System.Drawing.Color.LemonChiffon
        Me.logtable.BackgroundImage = CType(resources.GetObject("logtable.BackgroundImage"), System.Drawing.Image)
        Me.logtable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logtable.Location = New System.Drawing.Point(32, 189)
        Me.logtable.Name = "logtable"
        Me.logtable.Size = New System.Drawing.Size(43, 61)
        Me.logtable.TabIndex = 6
        Me.logtable.TabStop = False
        '
        'thesaurus
        '
        Me.thesaurus.BackColor = System.Drawing.Color.Honeydew
        Me.thesaurus.BackgroundImage = CType(resources.GetObject("thesaurus.BackgroundImage"), System.Drawing.Image)
        Me.thesaurus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.thesaurus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.thesaurus.Location = New System.Drawing.Point(730, 36)
        Me.thesaurus.Name = "thesaurus"
        Me.thesaurus.Size = New System.Drawing.Size(32, 29)
        Me.thesaurus.TabIndex = 5
        Me.thesaurus.TabStop = False
        '
        'pcsection
        '
        Me.pcsection.BackColor = System.Drawing.Color.LemonChiffon
        Me.pcsection.BackgroundImage = CType(resources.GetObject("pcsection.BackgroundImage"), System.Drawing.Image)
        Me.pcsection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcsection.Location = New System.Drawing.Point(503, 36)
        Me.pcsection.Name = "pcsection"
        Me.pcsection.Size = New System.Drawing.Size(221, 38)
        Me.pcsection.TabIndex = 4
        Me.pcsection.TabStop = False
        '
        'bookshelf2
        '
        Me.bookshelf2.BackColor = System.Drawing.Color.Honeydew
        Me.bookshelf2.BackgroundImage = CType(resources.GetObject("bookshelf2.BackgroundImage"), System.Drawing.Image)
        Me.bookshelf2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bookshelf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bookshelf2.Location = New System.Drawing.Point(309, 36)
        Me.bookshelf2.Name = "bookshelf2"
        Me.bookshelf2.Size = New System.Drawing.Size(146, 38)
        Me.bookshelf2.TabIndex = 3
        Me.bookshelf2.TabStop = False
        '
        'librarian2
        '
        Me.librarian2.BackColor = System.Drawing.Color.Honeydew
        Me.librarian2.BackgroundImage = CType(resources.GetObject("librarian2.BackgroundImage"), System.Drawing.Image)
        Me.librarian2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.librarian2.Location = New System.Drawing.Point(32, 316)
        Me.librarian2.Name = "librarian2"
        Me.librarian2.Size = New System.Drawing.Size(79, 62)
        Me.librarian2.TabIndex = 2
        Me.librarian2.TabStop = False
        '
        'baggagecounter
        '
        Me.baggagecounter.BackColor = System.Drawing.Color.Honeydew
        Me.baggagecounter.BackgroundImage = CType(resources.GetObject("baggagecounter.BackgroundImage"), System.Drawing.Image)
        Me.baggagecounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.baggagecounter.Location = New System.Drawing.Point(92, 36)
        Me.baggagecounter.Name = "baggagecounter"
        Me.baggagecounter.Size = New System.Drawing.Size(64, 117)
        Me.baggagecounter.TabIndex = 1
        Me.baggagecounter.TabStop = False
        '
        'door
        '
        Me.door.BackColor = System.Drawing.Color.Honeydew
        Me.door.BackgroundImage = CType(resources.GetObject("door.BackgroundImage"), System.Drawing.Image)
        Me.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.door.Location = New System.Drawing.Point(33, 35)
        Me.door.Name = "door"
        Me.door.Size = New System.Drawing.Size(53, 55)
        Me.door.TabIndex = 0
        Me.door.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Honeydew
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(31, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(965, 364)
        Me.Label20.TabIndex = 29
        '
        'btnSaveUI
        '
        Me.btnSaveUI.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveUI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveUI.Location = New System.Drawing.Point(859, 51)
        Me.btnSaveUI.Name = "btnSaveUI"
        Me.btnSaveUI.Size = New System.Drawing.Size(89, 29)
        Me.btnSaveUI.TabIndex = 14
        Me.btnSaveUI.Text = "Save Changes"
        Me.btnSaveUI.UseVisualStyleBackColor = False
        Me.btnSaveUI.Visible = False
        '
        'checkMoveObjects
        '
        Me.checkMoveObjects.AutoSize = True
        Me.checkMoveObjects.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkMoveObjects.Location = New System.Drawing.Point(908, 11)
        Me.checkMoveObjects.Name = "checkMoveObjects"
        Me.checkMoveObjects.Size = New System.Drawing.Size(119, 24)
        Me.checkMoveObjects.TabIndex = 15
        Me.checkMoveObjects.Text = "Move Objects"
        Me.checkMoveObjects.UseVisualStyleBackColor = True
        '
        'btnCancelUI
        '
        Me.btnCancelUI.BackColor = System.Drawing.Color.Brown
        Me.btnCancelUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelUI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelUI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelUI.Location = New System.Drawing.Point(952, 51)
        Me.btnCancelUI.Name = "btnCancelUI"
        Me.btnCancelUI.Size = New System.Drawing.Size(75, 29)
        Me.btnCancelUI.TabIndex = 16
        Me.btnCancelUI.Text = "Cancel"
        Me.btnCancelUI.UseVisualStyleBackColor = False
        Me.btnCancelUI.Visible = False
        '
        'btnConnect
        '
        Me.btnConnect.BackgroundImage = CType(resources.GetObject("btnConnect.BackgroundImage"), System.Drawing.Image)
        Me.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConnect.Location = New System.Drawing.Point(259, 4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(40, 40)
        Me.btnConnect.TabIndex = 17
        Me.btnConnect.TabStop = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.BackgroundImage = CType(resources.GetObject("btnDisconnect.BackgroundImage"), System.Drawing.Image)
        Me.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDisconnect.Location = New System.Drawing.Point(305, 4)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(40, 40)
        Me.btnDisconnect.TabIndex = 18
        Me.btnDisconnect.TabStop = False
        Me.btnDisconnect.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel1.Controls.Add(Me.menuSettings)
        Me.Panel1.Controls.Add(Me.menuExit)
        Me.Panel1.Controls.Add(Me.menuDashboard)
        Me.Panel1.Controls.Add(Me.menuMonitor)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(142, 502)
        Me.Panel1.TabIndex = 19
        '
        'menuSettings
        '
        Me.menuSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.menuSettings.BackgroundImage = CType(resources.GetObject("menuSettings.BackgroundImage"), System.Drawing.Image)
        Me.menuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuSettings.Location = New System.Drawing.Point(31, 254)
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Size = New System.Drawing.Size(80, 78)
        Me.menuSettings.TabIndex = 48
        Me.menuSettings.TabStop = False
        '
        'menuExit
        '
        Me.menuExit.BackgroundImage = CType(resources.GetObject("menuExit.BackgroundImage"), System.Drawing.Image)
        Me.menuExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuExit.Location = New System.Drawing.Point(31, 364)
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(80, 78)
        Me.menuExit.TabIndex = 48
        Me.menuExit.TabStop = False
        '
        'menuDashboard
        '
        Me.menuDashboard.BackgroundImage = CType(resources.GetObject("menuDashboard.BackgroundImage"), System.Drawing.Image)
        Me.menuDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuDashboard.Location = New System.Drawing.Point(31, 144)
        Me.menuDashboard.Name = "menuDashboard"
        Me.menuDashboard.Size = New System.Drawing.Size(80, 78)
        Me.menuDashboard.TabIndex = 48
        Me.menuDashboard.TabStop = False
        '
        'menuMonitor
        '
        Me.menuMonitor.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.menuMonitor.BackgroundImage = CType(resources.GetObject("menuMonitor.BackgroundImage"), System.Drawing.Image)
        Me.menuMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.menuMonitor.Location = New System.Drawing.Point(31, 32)
        Me.menuMonitor.Name = "menuMonitor"
        Me.menuMonitor.Size = New System.Drawing.Size(80, 78)
        Me.menuMonitor.TabIndex = 48
        Me.menuMonitor.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(142, 78)
        Me.Panel4.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbPort)
        Me.Panel2.Controls.Add(Me.btnCancelUI)
        Me.Panel2.Controls.Add(Me.btnDisconnect)
        Me.Panel2.Controls.Add(Me.checkMoveObjects)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.btnSaveUI)
        Me.Panel2.Controls.Add(Me.btnConnect)
        Me.Panel2.Location = New System.Drawing.Point(141, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1030, 83)
        Me.Panel2.TabIndex = 20
        '
        'NoiseDetector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1169, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.groupLibStructure)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NoiseDetector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Monitor"
        Me.groupLibStructure.ResumeLayout(False)
        CType(Me.divider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookssection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookssection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.librarian3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookshelf1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.librarian1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logtable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thesaurus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcsection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookshelf2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.librarian2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baggagecounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConnect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDisconnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.menuSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents cbPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents groupLibStructure As System.Windows.Forms.GroupBox
    Friend WithEvents table8 As System.Windows.Forms.PictureBox
    Friend WithEvents table7 As System.Windows.Forms.PictureBox
    Friend WithEvents table6 As System.Windows.Forms.PictureBox
    Friend WithEvents librarian3 As System.Windows.Forms.PictureBox
    Friend WithEvents table5 As System.Windows.Forms.PictureBox
    Friend WithEvents table4 As System.Windows.Forms.PictureBox
    Friend WithEvents table1 As System.Windows.Forms.PictureBox
    Friend WithEvents table2 As System.Windows.Forms.PictureBox
    Friend WithEvents table3 As System.Windows.Forms.PictureBox
    Friend WithEvents bookshelf1 As System.Windows.Forms.PictureBox
    Friend WithEvents librarian1 As System.Windows.Forms.PictureBox
    Friend WithEvents table10 As System.Windows.Forms.PictureBox
    Friend WithEvents table9 As System.Windows.Forms.PictureBox
    Friend WithEvents logtable As System.Windows.Forms.PictureBox
    Friend WithEvents thesaurus As System.Windows.Forms.PictureBox
    Friend WithEvents pcsection As System.Windows.Forms.PictureBox
    Friend WithEvents bookshelf2 As System.Windows.Forms.PictureBox
    Friend WithEvents librarian2 As System.Windows.Forms.PictureBox
    Friend WithEvents baggagecounter As System.Windows.Forms.PictureBox
    Friend WithEvents door As System.Windows.Forms.PictureBox
    Friend WithEvents bookssection2 As System.Windows.Forms.PictureBox
    Friend WithEvents bookssection1 As System.Windows.Forms.PictureBox
    Friend WithEvents opac As System.Windows.Forms.PictureBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnSaveUI As System.Windows.Forms.Button
    Friend WithEvents checkMoveObjects As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelUI As System.Windows.Forms.Button
    Friend WithEvents divider As System.Windows.Forms.PictureBox
    Friend WithEvents btnConnect As System.Windows.Forms.PictureBox
    Friend WithEvents btnDisconnect As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents menuExit As System.Windows.Forms.PictureBox
    Friend WithEvents menuDashboard As System.Windows.Forms.PictureBox
    Friend WithEvents menuMonitor As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents menuSettings As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
