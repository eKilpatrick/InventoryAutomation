<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRFIDPrinting = New System.Windows.Forms.Button()
        Me.btnScanning = New System.Windows.Forms.Button()
        Me.btnLblPrinting = New System.Windows.Forms.Button()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.DarkOrchid
        Me.PanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTitle.Controls.Add(Me.PictureBox2)
        Me.PanelTitle.Controls.Add(Me.Label1)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(800, 80)
        Me.PanelTitle.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SlateBlue
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 56)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SlateBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(798, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Physical Inventory"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SlateBlue
        Me.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnRFIDPrinting)
        Me.PanelMenu.Controls.Add(Me.btnScanning)
        Me.PanelMenu.Controls.Add(Me.btnLblPrinting)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 80)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(204, 370)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 291)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 77)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 77)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnRFIDPrinting
        '
        Me.btnRFIDPrinting.BackColor = System.Drawing.Color.Teal
        Me.btnRFIDPrinting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRFIDPrinting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFIDPrinting.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRFIDPrinting.Location = New System.Drawing.Point(0, 100)
        Me.btnRFIDPrinting.Name = "btnRFIDPrinting"
        Me.btnRFIDPrinting.Size = New System.Drawing.Size(202, 50)
        Me.btnRFIDPrinting.TabIndex = 2
        Me.btnRFIDPrinting.Text = "RFID Printing"
        Me.btnRFIDPrinting.UseVisualStyleBackColor = False
        '
        'btnScanning
        '
        Me.btnScanning.BackColor = System.Drawing.Color.Teal
        Me.btnScanning.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnScanning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanning.ForeColor = System.Drawing.SystemColors.Control
        Me.btnScanning.Location = New System.Drawing.Point(0, 50)
        Me.btnScanning.Name = "btnScanning"
        Me.btnScanning.Size = New System.Drawing.Size(202, 50)
        Me.btnScanning.TabIndex = 1
        Me.btnScanning.Text = "Label Scanning"
        Me.btnScanning.UseVisualStyleBackColor = False
        '
        'btnLblPrinting
        '
        Me.btnLblPrinting.BackColor = System.Drawing.Color.Teal
        Me.btnLblPrinting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLblPrinting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLblPrinting.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLblPrinting.Location = New System.Drawing.Point(0, 0)
        Me.btnLblPrinting.Name = "btnLblPrinting"
        Me.btnLblPrinting.Size = New System.Drawing.Size(202, 50)
        Me.btnLblPrinting.TabIndex = 0
        Me.btnLblPrinting.Text = "Label Printing"
        Me.btnLblPrinting.UseVisualStyleBackColor = False
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(204, 80)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(596, 370)
        Me.PanelMain.TabIndex = 2
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelTitle)
        Me.Name = "Main"
        Me.Text = "Physical Inventory"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTitle.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnRFIDPrinting As Button
    Friend WithEvents btnScanning As Button
    Friend WithEvents btnLblPrinting As Button
    Friend WithEvents PanelMain As Panel
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
