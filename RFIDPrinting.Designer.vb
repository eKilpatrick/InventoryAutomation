<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RFIDPrinting
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnChangePrinter = New System.Windows.Forms.Button()
        Me.btn4x3 = New System.Windows.Forms.Button()
        Me.btn4x2 = New System.Windows.Forms.Button()
        Me.txtPN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblEPC = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblPrinter = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 100)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RFID Printing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnChangePrinter)
        Me.Panel2.Controls.Add(Me.btn4x3)
        Me.Panel2.Controls.Add(Me.btn4x2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 350)
        Me.Panel2.TabIndex = 1
        '
        'btnChangePrinter
        '
        Me.btnChangePrinter.BackColor = System.Drawing.Color.SlateBlue
        Me.btnChangePrinter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnChangePrinter.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePrinter.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnChangePrinter.Location = New System.Drawing.Point(0, 312)
        Me.btnChangePrinter.Name = "btnChangePrinter"
        Me.btnChangePrinter.Size = New System.Drawing.Size(198, 36)
        Me.btnChangePrinter.TabIndex = 2
        Me.btnChangePrinter.Text = "Change Printer"
        Me.btnChangePrinter.UseVisualStyleBackColor = False
        '
        'btn4x3
        '
        Me.btn4x3.BackColor = System.Drawing.Color.SlateBlue
        Me.btn4x3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn4x3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4x3.ForeColor = System.Drawing.Color.GhostWhite
        Me.btn4x3.Location = New System.Drawing.Point(0, 36)
        Me.btn4x3.Name = "btn4x3"
        Me.btn4x3.Size = New System.Drawing.Size(198, 36)
        Me.btn4x3.TabIndex = 1
        Me.btn4x3.Text = "4"" x 3"" Label"
        Me.btn4x3.UseVisualStyleBackColor = False
        '
        'btn4x2
        '
        Me.btn4x2.BackColor = System.Drawing.Color.SlateBlue
        Me.btn4x2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn4x2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4x2.ForeColor = System.Drawing.Color.GhostWhite
        Me.btn4x2.Location = New System.Drawing.Point(0, 0)
        Me.btn4x2.Name = "btn4x2"
        Me.btn4x2.Size = New System.Drawing.Size(198, 36)
        Me.btn4x2.TabIndex = 0
        Me.btn4x2.Text = "4"" x 2"" Label"
        Me.btn4x2.UseVisualStyleBackColor = False
        '
        'txtPN
        '
        Me.txtPN.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPN.Location = New System.Drawing.Point(357, 126)
        Me.txtPN.Name = "txtPN"
        Me.txtPN.Size = New System.Drawing.Size(222, 26)
        Me.txtPN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(206, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Part Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label3.Location = New System.Drawing.Point(206, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(357, 171)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(90, 26)
        Me.txtQty.TabIndex = 4
        '
        'lblEPC
        '
        Me.lblEPC.AutoSize = True
        Me.lblEPC.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEPC.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblEPC.Location = New System.Drawing.Point(206, 266)
        Me.lblEPC.Name = "lblEPC"
        Me.lblEPC.Size = New System.Drawing.Size(58, 23)
        Me.lblEPC.TabIndex = 6
        Me.lblEPC.Text = "EPC:"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.SlateBlue
        Me.btnPrint.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnPrint.Location = New System.Drawing.Point(357, 318)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(151, 36)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label5.Location = New System.Drawing.Point(206, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(357, 220)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(222, 26)
        Me.txtDescription.TabIndex = 8
        '
        'lblPrinter
        '
        Me.lblPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrinter.AutoSize = True
        Me.lblPrinter.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrinter.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblPrinter.Location = New System.Drawing.Point(206, 418)
        Me.lblPrinter.Name = "lblPrinter"
        Me.lblPrinter.Size = New System.Drawing.Size(155, 23)
        Me.lblPrinter.TabIndex = 10
        Me.lblPrinter.Text = "Active Printer:"
        Me.lblPrinter.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RFIDPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPrinter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblEPC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPN)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RFIDPrinting"
        Me.Text = "RFIDPrinting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn4x3 As Button
    Friend WithEvents btn4x2 As Button
    Friend WithEvents txtPN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents lblEPC As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblPrinter As Label
    Friend WithEvents btnChangePrinter As Button
End Class
